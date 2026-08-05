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
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FC1DB0", Offset = "0x7FC11B0", VA = "0x187FC1DB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9BC6F0", Offset = "0x9BBAF0", VA = "0x1809BC6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BC730", Offset = "0x9BBB30", VA = "0x1809BC730")]
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
	public class LogRegistrationIndex : PNJEOLJBAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7FB8A40", Offset = "0x7FB7E40", VA = "0x187FB8A40", Slot = "4")]
		public override void ELBDPICAHPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FC7A70", Offset = "0x7FC6E70", VA = "0x187FC7A70", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x251F7B0", Offset = "0x251EBB0", VA = "0x18251F7B0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class LAPKLJGEJEP : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7FB7DF0", Offset = "0x7FB71F0", VA = "0x187FB7DF0")]
	public LAPKLJGEJEP(string EIGJGBPHOMK, Exception JFHJDHHPKPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class CJAACIKCELL : KHMEPPBLIJK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct CKLPEPHFNAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<CELGJIPHPBI>> <>t__builder;

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
		private TaskAwaiter<GLGHGDBIHIE<PJLADDLLKED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7FA8910", Offset = "0x7FA7D10", VA = "0x187FA8910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7FA8B50", Offset = "0x7FA7F50", VA = "0x187FA8B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct PEJAFOEBKEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<OMFLAIAJHME>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<OMFLAIAJHME>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7FC45A0", Offset = "0x7FC39A0", VA = "0x187FC45A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7FC47B0", Offset = "0x7FC3BB0", VA = "0x187FC47B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	[UnityEngine.Scripting.Preserve]
	public CJAACIKCELL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7FA87F0", Offset = "0x7FA7BF0", VA = "0x187FA87F0", Slot = "4")]
	[AsyncStateMachine(typeof(CKLPEPHFNAO))]
	public Task<IReadOnlyList<CELGJIPHPBI>> OMFJFLIFPGC(long CCHPCHDJHAI, long CLKFEHDHMIF, [Optional] CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7FA86E0", Offset = "0x7FA7AE0", VA = "0x187FA86E0", Slot = "5")]
	[AsyncStateMachine(typeof(PEJAFOEBKEA))]
	public Task<IReadOnlyList<OMFLAIAJHME>> IHHLOPPBOGB(IReadOnlyList<int> HLPFHOIFLHA, [Optional] CancellationToken BLABAMPAGAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface PCFGBJFANKM : IEquatable<PCFGBJFANKM>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int NCFODHOPPDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	OMFLAIAJHME MBPBCANIOHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime KPAEMIHDIGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	MABNPILMDOB? BDECGBHDJIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	LBFFGAPHOLK? ABGJHOHLJPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	GKONKAMBCEF GJCAIPBGFBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<BAOOEPCCKJO> KAELNOLHOKI();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum GKONKAMBCEF
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KHMEPPBLIJK
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<CELGJIPHPBI>> OMFJFLIFPGC(long CCHPCHDJHAI, long CLKFEHDHMIF, [Optional] CancellationToken BLABAMPAGAH);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<OMFLAIAJHME>> IHHLOPPBOGB(IReadOnlyList<int> HLPFHOIFLHA, [Optional] CancellationToken BLABAMPAGAH);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class DGKJLIIFHFB
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class OLIENLBJNDB : PCFGBJFANKM, IEquatable<PCFGBJFANKM>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct MKKGBGADBAG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<BAOOEPCCKJO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public OLIENLBJNDB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private LHLINMOGEBD <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<KDNGIJKMAJN> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<BAOOEPCCKJO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7FC17B0", Offset = "0x7FC0BB0", VA = "0x187FC17B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7FC1D40", Offset = "0x7FC1140", VA = "0x187FC1D40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly CELGJIPHPBI CJPJKAHAAFF;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int NCFODHOPPDD
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x991DB0", Offset = "0x9911B0", VA = "0x180991DB0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OMFLAIAJHME MBPBCANIOHM
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x991DE0", Offset = "0x9911E0", VA = "0x180991DE0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime EHDAFFOELOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7FC3C30", Offset = "0x7FC3030", VA = "0x187FC3C30", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public MABNPILMDOB? BDECGBHDJIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x68EC2B0", Offset = "0x68EB6B0", VA = "0x1868EC2B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public LBFFGAPHOLK? ABGJHOHLJPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2861390", Offset = "0x2860790", VA = "0x182861390", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public GKONKAMBCEF GJCAIPBGFBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xB2B4E0", Offset = "0xB2A8E0", VA = "0x180B2B4E0", Slot = "10")]
			get
			{
				return default(GKONKAMBCEF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7FC3C50", Offset = "0x7FC3050", VA = "0x187FC3C50", Slot = "9")]
		[AsyncStateMachine(typeof(MKKGBGADBAG))]
		public Task<BAOOEPCCKJO> KAELNOLHOKI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7FC3D90", Offset = "0x7FC3190", VA = "0x187FC3D90")]
		public OLIENLBJNDB(int PHKIOMLCHHD, OMFLAIAJHME NGBBOALNNID, CELGJIPHPBI CJPJKAHAAFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7FC3A80", Offset = "0x7FC2E80", VA = "0x187FC3A80", Slot = "11")]
		public bool Equals(PCFGBJFANKM JAPIEEBOJEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7FC3B10", Offset = "0x7FC2F10", VA = "0x187FC3B10", Slot = "0")]
		public override bool Equals(object HAPOBHMBDHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7FC3D50", Offset = "0x7FC3150", VA = "0x187FC3D50")]
		private bool MBHCAHEOOGE(OLIENLBJNDB JAPIEEBOJEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7FC3BB0", Offset = "0x7FC2FB0", VA = "0x187FC3BB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class PEPHKOGGJFG : PCFGBJFANKM, IEquatable<PCFGBJFANKM>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct CDIHJANAOKB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<BAOOEPCCKJO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public PEPHKOGGJFG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<BAOOEPCCKJO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7FA82D0", Offset = "0x7FA76D0", VA = "0x187FA82D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7FA8520", Offset = "0x7FA7920", VA = "0x187FA8520", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly GLNNANNECEB GLMFAKMGINP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly MABNPILMDOB IJLKPNIBNKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly LBFFGAPHOLK CCGEFJCIKBB;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int NCFODHOPPDD
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7FC4900", Offset = "0x7FC3D00", VA = "0x187FC4900", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public OMFLAIAJHME MBPBCANIOHM
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7FC4820", Offset = "0x7FC3C20", VA = "0x187FC4820", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime EHDAFFOELOM
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7FC4B10", Offset = "0x7FC3F10", VA = "0x187FC4B10", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public MABNPILMDOB? BDECGBHDJIF
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7FC4C50", Offset = "0x7FC4050", VA = "0x187FC4C50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public LBFFGAPHOLK? ABGJHOHLJPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7FC48B0", Offset = "0x7FC3CB0", VA = "0x187FC48B0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public GKONKAMBCEF GJCAIPBGFBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xB1EC30", Offset = "0xB1E030", VA = "0x180B1EC30", Slot = "10")]
			get
			{
				return default(GKONKAMBCEF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1D1A7D0", Offset = "0x1D19BD0", VA = "0x181D1A7D0")]
		public PEPHKOGGJFG(GLNNANNECEB CCGNPPPBHGG, MABNPILMDOB DPJIDEADIGI, LBFFGAPHOLK CHFAGODJHCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7FC4B60", Offset = "0x7FC3F60", VA = "0x187FC4B60", Slot = "9")]
		[AsyncStateMachine(typeof(CDIHJANAOKB))]
		public Task<BAOOEPCCKJO> KAELNOLHOKI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7FC4940", Offset = "0x7FC3D40", VA = "0x187FC4940", Slot = "11")]
		public bool Equals(PCFGBJFANKM JAPIEEBOJEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7FC49E0", Offset = "0x7FC3DE0", VA = "0x187FC49E0", Slot = "0")]
		public override bool Equals(object HAPOBHMBDHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7FC4CA0", Offset = "0x7FC40A0", VA = "0x187FC4CA0")]
		private bool MBHCAHEOOGE(PEPHKOGGJFG JAPIEEBOJEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7FC4A90", Offset = "0x7FC3E90", VA = "0x187FC4A90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class GKFNMBJBLHC : PCFGBJFANKM, IEquatable<PCFGBJFANKM>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct LLNLODMOHNE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<BAOOEPCCKJO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<BAOOEPCCKJO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7FB8770", Offset = "0x7FB7B70", VA = "0x187FB8770", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7FB89D0", Offset = "0x7FB7DD0", VA = "0x187FB89D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly OMFLAIAJHME IOLMBFLBIHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly MABNPILMDOB IJLKPNIBNKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly LBFFGAPHOLK CCGEFJCIKBB;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int NCFODHOPPDD
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7FB2B10", Offset = "0x7FB1F10", VA = "0x187FB2B10", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public OMFLAIAJHME MBPBCANIOHM
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime EHDAFFOELOM
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public MABNPILMDOB? BDECGBHDJIF
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7FB2D80", Offset = "0x7FB2180", VA = "0x187FB2D80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public LBFFGAPHOLK? ABGJHOHLJPG
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7FB2AC0", Offset = "0x7FB1EC0", VA = "0x187FB2AC0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public GKONKAMBCEF GJCAIPBGFBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "10")]
			get
			{
				return default(GKONKAMBCEF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1D1A7D0", Offset = "0x1D19BD0", VA = "0x181D1A7D0")]
		public GKFNMBJBLHC(OMFLAIAJHME NGBBOALNNID, MABNPILMDOB DPJIDEADIGI, LBFFGAPHOLK CHFAGODJHCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7FB2CB0", Offset = "0x7FB20B0", VA = "0x187FB2CB0", Slot = "9")]
		[AsyncStateMachine(typeof(LLNLODMOHNE))]
		public Task<BAOOEPCCKJO> KAELNOLHOKI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7FB2BB0", Offset = "0x7FB1FB0", VA = "0x187FB2BB0", Slot = "11")]
		public bool Equals(PCFGBJFANKM JAPIEEBOJEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7FB2B30", Offset = "0x7FB1F30", VA = "0x187FB2B30", Slot = "0")]
		public override bool Equals(object HAPOBHMBDHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7FB2C20", Offset = "0x7FB2020", VA = "0x187FB2C20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7FB2DD0", Offset = "0x7FB21D0", VA = "0x187FB2DD0")]
		private bool MBHCAHEOOGE(GKFNMBJBLHC JAPIEEBOJEA)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct OCKCIJDCAKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<PCFGBJFANKM>> <>t__builder;

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
		public DGKJLIIFHFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<CELGJIPHPBI> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<CELGJIPHPBI>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, OMFLAIAJHME account, CELGJIPHPBI roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7FC25D0", Offset = "0x7FC19D0", VA = "0x187FC25D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7FC3410", Offset = "0x7FC2810", VA = "0x187FC3410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct PLPAEOEAHIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, OMFLAIAJHME account, CELGJIPHPBI roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<CELGJIPHPBI> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public DGKJLIIFHFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<OMFLAIAJHME>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7FC4DB0", Offset = "0x7FC41B0", VA = "0x187FC4DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7FC5790", Offset = "0x7FC4B90", VA = "0x187FC5790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly GBCNPHDGDJP FKPLEPLAEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly KHMEPPBLIJK KNAMOHNBEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly LIKHEEBCIHK PDMFGCLOIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly NENMPGKCOOL<(long, long), IReadOnlyList<CELGJIPHPBI>> GCMPOBNAANJ;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7FAF890", Offset = "0x7FAEC90", VA = "0x187FAF890")]
	[UnityEngine.Scripting.Preserve]
	public DGKJLIIFHFB([GKAMHFFOHNI(null)] KHMEPPBLIJK GJOAEKPPPDK, [GKAMHFFOHNI(null)] LIKHEEBCIHK EDBEHJGNFNL, [GKAMHFFOHNI(null)] GBCNPHDGDJP OMFENLCFFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7FAF740", Offset = "0x7FAEB40", VA = "0x187FAF740")]
	[AsyncStateMachine(typeof(OCKCIJDCAKL))]
	public Task<IList<PCFGBJFANKM>> OIMPPBKLGJJ(long CCHPCHDJHAI, long DCFFKJJLEHN, bool EPCNBOICFPP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7FAF5A0", Offset = "0x7FAE9A0", VA = "0x187FAF5A0")]
	private bool IDMOFAAEKBP(DateTime? KBAAEOEAHPJ, long CCHPCHDJHAI, long DCFFKJJLEHN, [Out] GLNNANNECEB PEJBDAJPKPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7FAF490", Offset = "0x7FAE890", VA = "0x187FAF490")]
	[AsyncStateMachine(typeof(PLPAEOEAHIL))]
	private Task<IReadOnlyList<(int, OMFLAIAJHME, CELGJIPHPBI)>> EJEIECOHPEB(IReadOnlyList<CELGJIPHPBI> MKCJHCBDFCO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LIKHEEBCIHK
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<GLNNANNECEB> IHOEBLKNKNJ;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JAOPIPJLJPF(long CCHPCHDJHAI, long DCFFKJJLEHN, IPEJPHCMEGJ HOIBEPBFBCD, ONAMBMOGICM AMGCMCFMLOG);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KNFDMPMLONJ(long CCHPCHDJHAI, long DCFFKJJLEHN, [Out] GLNNANNECEB PEJBDAJPKPF);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PFKIJJEHFAN(long CCHPCHDJHAI, long DCFFKJJLEHN, ONAMBMOGICM AMGCMCFMLOG, [Out] GLNNANNECEB PEJBDAJPKPF);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DAHOFGJNGMK(long CCHPCHDJHAI, long DCFFKJJLEHN);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface BIOLGOHEHIG : ECNGEIBHFNE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool OKBOGPEDLOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task DGMFONDJLPB
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ICANDIIJJJP(Task ALKPEINKLAJ, string HHONLIOPJPE);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface OJPLJCNJJKD : ECNGEIBHFNE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BAOOEPCCKJO> PLLEKKHMDNF(GLNNANNECEB PEJBDAJPKPF);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CCKDNBHKPHB(CancellationToken BLABAMPAGAH);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface ELCIHFFMKCH : ECNGEIBHFNE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	OCJBCLJLKMI OAPOLNNKMOI
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FPDJKNCCFJH();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BEGIPBDKKHL();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface ECNGEIBHFNE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MBHBIOMKKEG(GGAFKPAJMJF NNEBHMDLFHI);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface ECMFINOGIEN
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan CIBGNEKHFKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan CBMAAHGHMFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan POBIHKBGNJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan KBNHJLFJAOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool FDJKFKPFNFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool MECEEDFKPGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool FJGOOIDODBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int JLPKHIIBDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool LIJBFMEFOPD
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool JGEGEPOCHJK
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool CJNBHIOHGKP
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum KDCNAAJLOBB
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum CAACDBPGMHO
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
public struct KDMPGIPNGGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long PENFHAJDLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long CLKFEHDHMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly KDCNAAJLOBB MAIGGPEPIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception HPMBAOFGPBL;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7FB7180", Offset = "0x7FB6580", VA = "0x187FB7180")]
	public KDMPGIPNGGP(long PENFHAJDLCJ, long CLKFEHDHMIF, KDCNAAJLOBB MAIGGPEPIHD, [CanBeNull] Exception HPMBAOFGPBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7FB7130", Offset = "0x7FB6530", VA = "0x187FB7130")]
	public static KDMPGIPNGGP KJCCMOBODJG(MEMBODLLNEP KKONDFKAMLF, KDCNAAJLOBB MAIGGPEPIHD, [Optional] Exception HPMBAOFGPBL)
	{
		return default(KDMPGIPNGGP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate void DMKKJJFGIHC(KDMPGIPNGGP IHPBFDHNLCL);
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface PPPKKCAALIA : ECNGEIBHFNE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action KJEMEDAPGPB;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event DMKKJJFGIHC HJIJHAMJCMH;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event DMKKJJFGIHC JFNIPPCBGJF;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event DMKKJJFGIHC EMBKPGPEAOG;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<CAACDBPGMHO, bool> KBEFGIMJDHJ;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NLOBECAGNLF();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FEKFKMGLDDK(KDMPGIPNGGP IHPBFDHNLCL);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KPLDHILGDJD(KDMPGIPNGGP IHPBFDHNLCL);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GCDIODIBGPM(KDMPGIPNGGP IHPBFDHNLCL);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GEKGECFJHLL(CAACDBPGMHO AKJDKCNBMBD, bool NIGNBIDEMPO);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface PDIKACNCFIO : ECNGEIBHFNE, IDisposable
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
	bool FGHCJJPJJPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GAJINAKGNIO(Reason CIAFGFLDDGN = Reason.Unknown);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CAEDPFCHGMG();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface HFLJMAPFFOH : ECNGEIBHFNE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	TaskStatus CKPNCEPDOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AOPLIIMJOLI(MEMBODLLNEP NDIAONIIAAM, CMOOMNHMMEN CPFAIKOKJAE, CancellationToken LDLCOIFGBGG);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class MJFECKPPNBP
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7FC1760", Offset = "0x7FC0B60", VA = "0x187FC1760")]
	public static bool NGMKLJBNCNP(this HFLJMAPFFOH BJFGOAGLAAG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public delegate Task DIOKMOOEKFM(CancellationToken HEJFDMJNIGB, int PDNIHCHMOIK, HJMLLMJGAOM GOCEFJMNFLE);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface OHBPDLMECML : ECNGEIBHFNE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NLNFHFOODOC(DIOKMOOEKFM BDOPBPGMGIM);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface GGAFKPAJMJF : LHLINMOGEBD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	CancellationToken ACOIOKONELA
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	NPIEGGOELNH GLJKILIPJOE
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	OAHJJJNDMGJ HCPOCNIOGNB
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	GJAODIKIHGJ CNOEILKFJPH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	IFFMIKJIEPF OGNNDGMLFKL
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	HCCOGDFGNKF MPLBCJFDNKO
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	INMEKJKHLIJ HFOGKDJLDNI
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	DADHEHMMNDP BMNOMPHNOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	DFOPGDIDDDM KHGLGFADHMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	BIOLGOHEHIG CMMEHCLLEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	OJPLJCNJJKD DIGDKFPEMNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	PPPKKCAALIA LPFGBBHOFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	PDIKACNCFIO AFBNDPCNOKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	HFLJMAPFFOH BJPLDLKIPDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	OHBPDLMECML CFAAGJCEIGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	KONPINNDDMD KODMJEHIJIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	PABLCMOOJMJ OMIPAHBKLAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	FEEAKBALFLE KDICMCGLFEG
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	IOOPIIJMGEA GBHMIAGPLKD
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	FCJIJIJJMOO KGHOAGPGCLG
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	HBCHHOMPPDH HGIIJHMIOOA
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	BPJAFKHGDAB IIMMLOIIFLN
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	KPKAECBKNJI AODNFGLHAJO
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	BFBEANOKDGL LDEFEODDNAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	JNINLOJJHPN JOABJOLAAAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	ELCIHFFMKCH BNJJFGOOKEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	ECMFINOGIEN FJJKAGFFJHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	JCENNCFNDPE BHIAJIFBKDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	LIKHEEBCIHK ELPGJMIOFBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	NDHBCEMPGLA IKLOJLGLBOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	OACPOPIIAFF PPFBOMFPPOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	PJFNBOFGLFH GODBKCMEGPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	PMAHOPLKPFE MLBNOGHAGOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	new bool HIBJOHEGKEJ
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
	void CBOJEHHPOON(CMOOMNHMMEN GJAMJHDEMJF);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface KONPINNDDMD : ECNGEIBHFNE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KHBHCLPOBBI LLICHLCEEGA(Guid NPMNDEDHHIJ);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FBDLIPAFCGJ(Guid NPMNDEDHHIJ);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool APBIGAMLLHF(Guid NPMNDEDHHIJ, Task FKDKDOOLECK);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GFMBLLIODCB(Guid NPMNDEDHHIJ, BAOOEPCCKJO PJAEGPHLEBH);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(BAOOEPCCKJO, Task)> AHPBOKCNNDI(Guid NPMNDEDHHIJ);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface JGJDODCEDJJ : ECNGEIBHFNE, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface PABLCMOOJMJ : ECNGEIBHFNE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DPNOHGDBOFA(KOEDLEGFKIO EIGJGBPHOMK);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BKJNBKFJKJO(KOEDLEGFKIO EIGJGBPHOMK);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<HAMDHMOMGFH> OHEPPAEIDFM(CancellationToken GCPMGDAEHFD);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface FEEAKBALFLE : ECNGEIBHFNE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KHBHCLPOBBI ENOCFLOMDGM(KOEDLEGFKIO HOIEIPLDPOP);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BMIMLDJKLFC(Guid NPMNDEDHHIJ, Task FKDKDOOLECK);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface IOOPIIJMGEA : ECNGEIBHFNE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BAOOEPCCKJO> GBHMIAGPLKD(KOEDLEGFKIO EKKCFNIJCDA);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface FCJIJIJJMOO : ECNGEIBHFNE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JGCMJADBFFC> DJEEFNGILBJ(HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, MEMBODLLNEP NDIAONIIAAM, CancellationToken BLABAMPAGAH);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface BPJAFKHGDAB : ECNGEIBHFNE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BAOOEPCCKJO BLKNKOAMHCD(FEIKLGLBIHI NKHMBLLHHHJ);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task IACIMPJJMME(string PMILCDIBAOD);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface HBCHHOMPPDH : ECNGEIBHFNE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KOEDLEGFKIO> JJONFHELDDH(KOEDLEGFKIO INLHACAOAMD, BFOAALAPEEN LFDLABBBODP, CancellationToken BLABAMPAGAH);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<KOEDLEGFKIO> PJGNLPBBMHG(CancellationToken BLABAMPAGAH, BFOAALAPEEN LFDLABBBODP);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BBEKBLPLKNJ GIEGJCBEGHC(IMFDIOOAAIF OHOMKHKAGJK, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BBEKBLPLKNJ HPAIOBBBEMF(IMFDIOOAAIF OHOMKHKAGJK, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface KPKAECBKNJI : ECNGEIBHFNE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BAOOEPCCKJO NPIKAHFPIGK(FEIKLGLBIHI NKHMBLLHHHJ, HAMDHMOMGFH IIDBEKEFGGH);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BAOOEPCCKJO JLOOKONFCGB(FEIKLGLBIHI LANFCLNHAKB);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface BLENEGCJEED
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	const int MJDOJDFIIDO = 1000;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	IReadOnlyDictionary<Guid, ACPFCDMPAEO> HPHHHAMOCPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Action PJFMIFOINBE
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
	IReadOnlyList<Guid> PHACNGAHGBG();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task OMCEOIJFFHI([Optional] CancellationToken BLABAMPAGAH);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task EEPCNMEJBKI([Optional] CancellationToken BLABAMPAGAH);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface BFBEANOKDGL
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NFHPADHMPAI(BPJJMHKIAII EKHIEFCBFAF);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HLLICGEFJOE(BPJJMHKIAII EKHIEFCBFAF);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KOCMHKKIAOA(BPJJMHKIAII EKHIEFCBFAF);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EGAHGFDOBHK(BPJJMHKIAII EKHIEFCBFAF);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class BPJJMHKIAII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly MEMBODLLNEP NAOJPEACFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Dictionary<string, string> GJCBJACHPAF;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public HOEFFPEDKPI<string> HFPEBMLDNAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x991DE0", Offset = "0x9911E0", VA = "0x180991DE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x991DF0", Offset = "0x9911F0", VA = "0x180991DF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x999BC0", Offset = "0x998FC0", VA = "0x180999BC0")]
	public BPJJMHKIAII(MEMBODLLNEP OHBACCHDJLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7FA8200", Offset = "0x7FA7600", VA = "0x187FA8200")]
	public BPJJMHKIAII NIOJHEAHEEE(string MCBJECJLDOM, string FIIKLGCIAGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7FA8170", Offset = "0x7FA7570", VA = "0x187FA8170")]
	public bool AOHAPDNLEOA([Out] IEnumerable<KeyValuePair<string, string>> LLJBKFAFKMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A130", Offset = "0x6F09530", VA = "0x186F0A130")]
	public BPJJMHKIAII IPDGFODBGNJ(HOEFFPEDKPI<string> AOBIHHLEODI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface JCENNCFNDPE
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool BGHHBDFLBGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string PDEGJAIKFEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool NPMINBHEMGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OJAEMDKCGKJ();

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JGCFIAOCGKE BGHBMCGILNI(long OCCKLCFPOGA);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JJDBDLLIKAM<PGNIPJOEHNG, EKENJADJMDF> LKEEGIOGIPB(long OCCKLCFPOGA);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JJDBDLLIKAM<PGNIPJOEHNG, BPGLDJMOGPH> OJPGGABLOAP(long OCCKLCFPOGA);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JJDBDLLIKAM<long, KBLNENNOAFL> KEMAMNFNEOD();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<IReadOnlyCollection<DCNOJEHNBBC>> FHMDHIJCLFN(long OCCKLCFPOGA, IReadOnlyCollection<DCNOJEHNBBC> KANLGAAIMBH, CancellationToken BLABAMPAGAH);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool IPHJFEGKODG(long OCCKLCFPOGA, [Out] bool JFGCJIEODDK);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<bool> IJOMJIOKLAL(byte[] EDHFJOANBFH, byte[] FDCGPHOJGDK, IReadOnlyCollection<Guid> MPJNMLGDPDG, CancellationToken BLABAMPAGAH);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface DBCPILAEFPO
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JGCMJADBFFC DCJNBNANGBG(long PENFHAJDLCJ, long CLKFEHDHMIF, string CGOKGIMLOPB);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JGCMJADBFFC DCJNBNANGBG(long PENFHAJDLCJ, long CLKFEHDHMIF, PGNIPJOEHNG EDHFJOANBFH, Guid? GMEANDPBKJG, long CPCDCDODJDH, bool DNCDEBKACBJ);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JGCMJADBFFC DCJNBNANGBG(PFDCFKLNLCM FMPJHIEGICA);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JGCMJADBFFC DCJNBNANGBG(KDNGIJKMAJN FMMIDMGJGCP, CELGJIPHPBI FPNKCMHKPAF);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface LHLINMOGEBD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool NGMKLJBNCNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool LCIMMPJABHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool HIBJOHEGKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	DBCPILAEFPO NOOIOOHFGBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	CMOOMNHMMEN IHGFGEOJMEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action KJEMEDAPGPB;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event DMKKJJFGIHC HJIJHAMJCMH;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event DMKKJJFGIHC JFNIPPCBGJF;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event DMKKJJFGIHC EMBKPGPEAOG;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<CAACDBPGMHO, bool> KBEFGIMJDHJ;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void CAEDPFCHGMG();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	CNOLAGDHOLD HHNEMEPNFAI();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DJBGKFICKCD EFJMPHJAAHD();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task DCFAOKPDGGG(int PNMPDHMKPJO, OIFNNMDODPC HBOAENOKJMI, Func<IPEJPHCMEGJ, IPEJPHCMEGJ> HENCKODCDJF);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<BAOOEPCCKJO> PLLEKKHMDNF(GLNNANNECEB CCGNPPPBHGG);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task CCKDNBHKPHB(CancellationToken BLABAMPAGAH);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface HCCOGDFGNKF
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool LOCCOIMBMND
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool JAJHBCEHOAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	Guid? ELHDPGPCINF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AJIMOIDCOGD(Scene CIMHEKNAACJ);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task GJBIJAKLAMN(EHJFIGHECKN AAGBMAGDLEJ, IReadOnlyList<EHJFIGHECKN> GPECCJOHLNL, IReadOnlyList<EHJFIGHECKN> GCLPJEIMBBM, CancellationToken BLABAMPAGAH);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CCDGCMEPMJN(PGCKNOHFIFJ LIJEDFCMGPL);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task CIOAAGDOKCH(IReadOnlyList<Guid> DLCMHEMNBJG, CancellationToken ALDHIBJNAHO);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BCHCIFHCAFD FAJFIENEMCP();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task MNHOIFCBCFO();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task DNOEFKEKKEE();
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface IFFMIKJIEPF
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	OAJMAHCOGME MJEJCKIGNCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool PCMGAEJDOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool CJAHKGNIBGK
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool IHIBGBBEMMB
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool LJOFPFGMBAG
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	int EFGJBKCEHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	bool BKNMLJLGCDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool OGLKCNKOFCM
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	int AANNGCPFOAM
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	int BBMIGCJNBBP
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool LGMNDKNEECF
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	bool PDIOBHNMLIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool MOCMICHHNBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	float EPIOPGCBDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> PLGCEHCAMHH;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NPIEGGOELNH IGEBKOBELMK(NPIEGGOELNH GAGDNMMIJGI);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PAPDKJOAGKL(NPIEGGOELNH PHDMEDCBLHH);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EJHFBECAGKH();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task FKBOMKADFLM(HOEFFPEDKPI<string>.AEKMEBIOPMA ACLHCPPCFNP, CancellationToken BLABAMPAGAH);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DNNJPGDBIHP(float CLBNNMGBMLF);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CEHKKGFLLCC(string FAGNIGAMDJK);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<PNCKNIPBJFF> PPMENLPGNNF();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable MMLLMOMAPPC(object PFPNPMCGHHC, PNCKNIPBJFF ANHGJIGHHKP);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<JLFGFHNLHIB> POLDNHLDEMF();

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	EKENJADJMDF ECLPHOJBJAH(IEnumerable<EBFEMKEPGFD> LMHGCJEGHLD);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FOENDDKNJIM(int JMDODKHGNOP);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task EDMCDBPCBAD();

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void PPLJDHDDNOP();

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool IBMPLHDLMJE();

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task BOHCMNGLEEO(CancellationToken BLABAMPAGAH);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task MCFCDICFPBE(CancellationToken BLABAMPAGAH);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<HJOHEIBOLIO> HKNLNBCFOAC(DateTime GKBOOHBLCCI, CancellationToken BLABAMPAGAH);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> BCABNOFFNGL(CancellationToken BLABAMPAGAH);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void LPHBHDNJCPD(string EIGJGBPHOMK = "", float DAJECHOKOMD = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "25")]
	NLAMBFGLOBN ILKDNDAECKF(IBCDIPHCGCH PKLHKIHLDNE, HNICEBLJKEL AKNAPINBDMI, BPGLDJMOGPH PCPAAMNPCIJ, IEnumerable<PersistenceView> FFBELCKBILJ, OFKAINDDBDJ GAJIPEHJGJC);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void LBCKDNMFHLI(BPGLDJMOGPH PCPAAMNPCIJ);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void INEOGNGGBPE(EBFEMKEPGFD IBPIFPONGON, [In] NLAMBFGLOBN LEKCKLHAMHC);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task NEJCNPMCMLL(BPGLDJMOGPH MAJENMBDEJN, bool JKCKDKDDDOK, CancellationToken BLABAMPAGAH);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task KIOGPNNONDA(CancellationToken BLABAMPAGAH);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void IEFBMJJCJJE(long CCHPCHDJHAI, long CLKFEHDHMIF, KDNGIJKMAJN KECIPBKCBHF, CELGJIPHPBI PHCBODKKENA, IPEJPHCMEGJ HOIBEPBFBCD, OIFNNMDODPC? HBOAENOKJMI, GGKMAMDIMDL? HKBEOFMEHMF);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void PGPHCINIKBE(long CCHPCHDJHAI, long CLKFEHDHMIF, GGKMAMDIMDL? HKBEOFMEHMF);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void EBACBIGPLAG(PersistenceView NLEDABKIKLD);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void BAOPKLAMFMK(string IMLBFEPBBFJ, MEMBODLLNEP OHBACCHDJLF, IGHPKFMLLFB JJJOOJLLFOL, [Optional] string? DNJBCEGDEIH, [Optional] string? DOIMFAAJHAJ, [Optional] string? NPFJBMIOBBL);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool BGGPGALDIGF(PersistenceView FEDEGDPKLDC);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool KAONCDLFDII(EBFEMKEPGFD IBPIFPONGON, OLMIOOOKIFM JGMFBKOBNEC, [Out] NNBDDFDNPNN AJJJCPEKILP);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task FKIFONHLLNB(CancellationToken BLABAMPAGAH);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void JPMOAJCACHM();

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "38")]
	IDisposable OICIEAAJALI();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void FAKDAIPBELE(BPGLDJMOGPH MAJENMBDEJN, OLMIOOOKIFM JGMFBKOBNEC);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<bool> NMNOGEKNMBM(OAHJJJNDMGJ AAHFLKJGFKB, CancellationToken BLABAMPAGAH, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void PAGKMCHOGMF(CancellationToken BLABAMPAGAH);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<PFDCFKLNLCM> PIPDMDDAKCC(FKEPNHFCGLI INLHACAOAMD);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<KDNGIJKMAJN> BDJIJHFPFNB(long CCHPCHDJHAI, bool PBFGCJKFGFN, CancellationToken BLABAMPAGAH);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<PJLADDLLKED> PNBACGAIEJN(long CCHPCHDJHAI, long CLKFEHDHMIF, long CPCDCDODJDH, CancellationToken BLABAMPAGAH);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<PJLADDLLKED> EPCKCHIFHJI(long CCHPCHDJHAI, long CLKFEHDHMIF, CancellationToken BLABAMPAGAH);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<KPNAPGNHCBJ> FJLOADCLCGA(long CCHPCHDJHAI, Guid DKPDJPBGMOJ, long? DCFFKJJLEHN, CancellationToken BLABAMPAGAH);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "47")]
	JJDBDLLIKAM<KPNAPGNHCBJ, IEnumerable<EGKNKDEIGBO>> GEDKOGKMIJF();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "48")]
	Task<CMHOHMOMOEI> KLCCFDFHOOD(string CGOKGIMLOPB, CancellationToken BLABAMPAGAH);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "49")]
	Task<CMHOHMOMOEI> NJKPABJPLDM(string CGOKGIMLOPB, long CCHPCHDJHAI, long CLKFEHDHMIF, Guid? PADEBAHBFEO, IOEIADFCNCL.NFIBEOODLPK BDAPIDPALOK, IOEIADFCNCL.NFIBEOODLPK FDCGPHOJGDK, int PNMPDHMKPJO);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool NFFIFJHOIIF();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool DHKMPJEILIG();

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "53")]
	bool LDLHOEEEGJG(IEnumerable<NNBDDFDNPNN> NHPPMNEJOID);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void JAJMMCIOHOK(List<GameObject> DECBAPENPKP);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "55")]
	float EOGHEHGCPPP();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "56")]
	Task<bool> LIBLAFFIDBH(CancellationToken BLABAMPAGAH);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "57")]
	Task<Scene> INJODMPNMKK(string CNIMAACIFLC, LoadSceneMode EPPJKBMEIHC, bool KFLPFOEINCD, HOEFFPEDKPI<string>.AEKMEBIOPMA AOBIHHLEODI);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void OCPPDCLDCNE();

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "63")]
	void HFMHHPEEPBA(bool EJBJKNOIGIB);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void DONKNOLJPAE();

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void DKKDEOBGKDI();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void MGOFLOBLAPF(bool FMBCMHPFBKL);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "72")]
	Task<IOEIADFCNCL.NFIBEOODLPK> GFAAEGIGNGN(byte[] AMHCLKHIFKH, IOEIADFCNCL.DEMIFEPIELC JIMILAONHJG, BDAELFHGLMN MAPFBFNEHOH, [Optional] IReadOnlyCollection<string>? EPDNEBKOPOI, [Optional] string? LOOEGHEMNKE);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void LGAJKOPJEEM(MEMBODLLNEP IKLADMLGKHJ);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task NPIDFFMOMDL(HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "75")]
	Task KAOGJOHPHIL(HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "76")]
	Task KGCMHGAHHNB(HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "77")]
	Task ICDBFKBHAIM(HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "78")]
	IDisposable COCJAILDAHM();

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "79")]
	KBEDLKKEHIH MAACMKGNBII();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "80")]
	Task OIBPJEBIPEG(CancellationToken BLABAMPAGAH);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface KBEDLKKEHIH
{
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task ONLLBPAMMCK(CancellationToken BLABAMPAGAH);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task HHPBGPOCHJN(CancellationToken BLABAMPAGAH);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct NLAMBFGLOBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public HashSet<int> DKFALLIEEDO;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum HJOHEIBOLIO : byte
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	No,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct IBCDIPHCGCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Guid? ELLIFFLFPKG;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface OAJMAHCOGME
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	MEMBODLLNEP IFDIOLBKIPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	KDNGIJKMAJN MAKCLLHGJFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	FEOHBPOKLEE JLEPMBDOHPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool DGDMNGALBIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool BDAENDPJFEA
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	int HIFJAJALJKA
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action HFBHNHMAMJO;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> MLHMPMOFNMJ;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FLPPBOBHIAK();

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.NDHKEMAFIBA> MNCBFCMOMPL(long OCCKLCFPOGA, [Optional] CancellationToken BLABAMPAGAH);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<NNHGHMAIOHK> OGFMFEAJOFO(MEMBODLLNEP OHBACCHDJLF, [Optional] CMOOMNHMMEN CPFAIKOKJAE);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<NNHGHMAIOHK> MINLOOANCLJ();

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task OKGANDLBJBL();

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "15")]
	(MEMBODLLNEP, CMOOMNHMMEN) CPAICCEBLON();

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "16")]
	NDKFKFGHFIK JAJGFCIALCD();

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void ELKOPKAPCNA(long OCCKLCFPOGA);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void IPJOIAOLGGF(MEMBODLLNEP OHBACCHDJLF, Matchmaking.OKHHKDOGKML KGODHHBLJOE, (int Major, int? Minor)? BGDJGAKNCHF);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface JNINLOJJHPN
{
	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JGALHAFADPM([Out] IEnumerable<int> LLLENDNKBPK);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CAJCCNEPELH(NIOICMFLLAK HEJFDMJNIGB);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GENPBJOHOKH(NIOICMFLLAK HEJFDMJNIGB);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface MBADENDMOHA
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string PNJHLKMCICL(BAOOEPCCKJO LIPHIBKLFND);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface NIGLPKBPIFA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MHEKANOBJOG(AGEBNCIICJF.KLGLCGJFHGH LBNFEMMNIFP);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EJBIDIBDKOO(AGEBNCIICJF.KLGLCGJFHGH LBNFEMMNIFP);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface INMEKJKHLIJ : NIGLPKBPIFA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BAOOEPCCKJO LEJELGCKEEE(FEIKLGLBIHI LANFCLNHAKB);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface DADHEHMMNDP : NIGLPKBPIFA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BAOOEPCCKJO BLKNKOAMHCD(FEIKLGLBIHI HNCNLBLNACH);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface JGCFIAOCGKE
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<AEAAIINGJNL<AAHFAAICCFI, BPMPLDFNAFC>> NKEOIKMNLIG(Guid? PADEBAHBFEO, IReadOnlyCollection<DCNOJEHNBBC> IPAAGEDONDC, IReadOnlyCollection<DCNOJEHNBBC> HECPBDOGLLL, BBNAHMCPPIB MFJLCKHJEGE, long? CCHPCHDJHAI, long? CLKFEHDHMIF, PKKJGLJEKIC.LEEPLEBKEAD IGBNBACADMP, CancellationToken BLABAMPAGAH);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public sealed class AAHFAAICCFI
{
	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public EHJFIGHECKN CLFNIAJNLGI
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public IReadOnlyList<EHJFIGHECKN> LFDNMPBBLDP
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public IReadOnlyList<EHJFIGHECKN> AAPCLCDEEFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x991DE0", Offset = "0x9911E0", VA = "0x180991DE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0xB9A2E0", Offset = "0xB996E0", VA = "0x180B9A2E0")]
	public AAHFAAICCFI(EHJFIGHECKN GDLFIMKAFCB, IReadOnlyList<EHJFIGHECKN> FEOJBICMELO, IReadOnlyList<EHJFIGHECKN> MMFANALGNOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface JJDBDLLIKAM<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<AEAAIINGJNL<NJNFGEEDFLI<TData>, BPMPLDFNAFC>> MMMBPBCOFEN(TGetDataArg PKKPPHDAMAG, CancellationToken BLABAMPAGAH);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class MCIPCMGBMIM : GGAFKPAJMJF, LHLINMOGEBD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct DNFCEKBMOIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AsyncTaskMethodBuilder<BAOOEPCCKJO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public MCIPCMGBMIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public GLNNANNECEB autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TaskAwaiter<BAOOEPCCKJO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x7FAFAB0", Offset = "0x7FAEEB0", VA = "0x187FAFAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x7FAFD30", Offset = "0x7FAF130", VA = "0x187FAFD30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct LGEEADJLIHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public MCIPCMGBMIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7FB84E0", Offset = "0x7FB78E0", VA = "0x187FB84E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7FB8710", Offset = "0x7FB7B10", VA = "0x187FB8710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class IJMICFOMEPP : IEnumerable<ECNGEIBHFNE>, IEnumerable, IEnumerator<ECNGEIBHFNE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private ECNGEIBHFNE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public MCIPCMGBMIM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private ECNGEIBHFNE System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xDDEBA0", Offset = "0xDDDFA0", VA = "0x180DDEBA0")]
		[DebuggerHidden]
		public IJMICFOMEPP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7FB58F0", Offset = "0x7FB4CF0", VA = "0x187FB58F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7FB5D50", Offset = "0x7FB5150", VA = "0x187FB5D50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7FB5CA0", Offset = "0x7FB50A0", VA = "0x187FB5CA0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ECNGEIBHFNE> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7FB5CA0", Offset = "0x7FB50A0", VA = "0x187FB5CA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly CancellationTokenSource CGKCFJMFGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly NPIEGGOELNH PHDMEDCBLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool MIGDMPFDAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private ABCLGEEMMFI AMMCEBFDDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private bool GLCGNHOGCMI;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public OAHJJJNDMGJ HCPOCNIOGNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x993390", Offset = "0x992790", VA = "0x180993390", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9933A0", Offset = "0x9927A0", VA = "0x1809933A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public GJAODIKIHGJ CNOEILKFJPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x993280", Offset = "0x992680", VA = "0x180993280", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x993410", Offset = "0x992810", VA = "0x180993410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public IFFMIKJIEPF OGNNDGMLFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x997460", Offset = "0x996860", VA = "0x180997460", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x997470", Offset = "0x996870", VA = "0x180997470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public HCCOGDFGNKF MPLBCJFDNKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x993540", Offset = "0x992940", VA = "0x180993540", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x9932B0", Offset = "0x9926B0", VA = "0x1809932B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public INMEKJKHLIJ HFOGKDJLDNI
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x993460", Offset = "0x992860", VA = "0x180993460", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x993520", Offset = "0x992920", VA = "0x180993520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public DADHEHMMNDP BMNOMPHNOJB
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x99A8A0", Offset = "0x999CA0", VA = "0x18099A8A0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x99A9E0", Offset = "0x999DE0", VA = "0x18099A9E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public DBCPILAEFPO NOOIOOHFGBO
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x99AA50", Offset = "0x999E50", VA = "0x18099AA50", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x99A960", Offset = "0x999D60", VA = "0x18099A960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public DFOPGDIDDDM KHGLGFADHMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x99A9F0", Offset = "0x999DF0", VA = "0x18099A9F0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x99AA20", Offset = "0x999E20", VA = "0x18099AA20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public BIOLGOHEHIG CMMEHCLLEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xB2BB10", Offset = "0xB2AF10", VA = "0x180B2BB10", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x11E1950", Offset = "0x11E0D50", VA = "0x1811E1950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public OJPLJCNJJKD DIGDKFPEMNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x99A940", Offset = "0x999D40", VA = "0x18099A940", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x99A8F0", Offset = "0x999CF0", VA = "0x18099A8F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public PPPKKCAALIA LPFGBBHOFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xC2B3E0", Offset = "0xC2A7E0", VA = "0x180C2B3E0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xD940F0", Offset = "0xD934F0", VA = "0x180D940F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public PDIKACNCFIO AFBNDPCNOKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x999C90", Offset = "0x999090", VA = "0x180999C90", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x999C50", Offset = "0x999050", VA = "0x180999C50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public HFLJMAPFFOH BJPLDLKIPDD
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xB7A750", Offset = "0xB79B50", VA = "0x180B7A750", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xDA8080", Offset = "0xDA7480", VA = "0x180DA8080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public OHBPDLMECML CFAAGJCEIGG
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xC82700", Offset = "0xC81B00", VA = "0x180C82700", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xC82710", Offset = "0xC81B10", VA = "0x180C82710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public KONPINNDDMD KODMJEHIJIF
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xC2B210", Offset = "0xC2A610", VA = "0x180C2B210", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x1069B40", Offset = "0x1068F40", VA = "0x181069B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public JGJDODCEDJJ CMPMDEGCJCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xC16AE0", Offset = "0xC15EE0", VA = "0x180C16AE0", Slot = "62")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xCCE510", Offset = "0xCCD910", VA = "0x180CCE510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public PABLCMOOJMJ OMIPAHBKLAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA0FF70", Offset = "0xA0F370", VA = "0x180A0FF70", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA14B20", Offset = "0xA13F20", VA = "0x180A14B20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public FEEAKBALFLE KDICMCGLFEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x999C40", Offset = "0x999040", VA = "0x180999C40", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x999CC0", Offset = "0x9990C0", VA = "0x180999CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public IOOPIIJMGEA GBHMIAGPLKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xA18180", Offset = "0xA17580", VA = "0x180A18180", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xAF6090", Offset = "0xAF5490", VA = "0x180AF6090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public FCJIJIJJMOO KGHOAGPGCLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xA17D10", Offset = "0xA17110", VA = "0x180A17D10", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xB02680", Offset = "0xB01A80", VA = "0x180B02680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public HBCHHOMPPDH HGIIJHMIOOA
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA10110", Offset = "0xA0F510", VA = "0x180A10110", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA08D40", Offset = "0xA08140", VA = "0x180A08D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public BPJAFKHGDAB IIMMLOIIFLN
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x9FDCC0", Offset = "0x9FD0C0", VA = "0x1809FDCC0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA034D0", Offset = "0xA028D0", VA = "0x180A034D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public KPKAECBKNJI AODNFGLHAJO
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA18B50", Offset = "0xA17F50", VA = "0x180A18B50", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADF770", VA = "0x180AE0370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public BFBEANOKDGL LDEFEODDNAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA18B10", Offset = "0xA17F10", VA = "0x180A18B10", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA0A0D0", Offset = "0xA094D0", VA = "0x180A0A0D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public JNINLOJJHPN JOABJOLAAAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA18B30", Offset = "0xA17F30", VA = "0x180A18B30", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x9FFD80", Offset = "0x9FF180", VA = "0x1809FFD80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public ELCIHFFMKCH BNJJFGOOKEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA18B20", Offset = "0xA17F20", VA = "0x180A18B20", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA0BBD0", Offset = "0xA0AFD0", VA = "0x180A0BBD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public ECMFINOGIEN FJJKAGFFJHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA09240", Offset = "0xA08640", VA = "0x180A09240", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA07340", Offset = "0xA06740", VA = "0x180A07340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public JCENNCFNDPE BHIAJIFBKDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xA17A20", Offset = "0xA16E20", VA = "0x180A17A20", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA2B890", Offset = "0xA2AC90", VA = "0x180A2B890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public LIKHEEBCIHK ELPGJMIOFBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA0D230", Offset = "0xA0C630", VA = "0x180A0D230", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public NDHBCEMPGLA IKLOJLGLBOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA00DF0", Offset = "0xA001F0", VA = "0x180A00DF0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public OACPOPIIAFF PPFBOMFPPOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA08D60", Offset = "0xA08160", VA = "0x180A08D60", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public PJFNBOFGLFH GODBKCMEGPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA0DCC0", Offset = "0xA0D0C0", VA = "0x180A0DCC0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public PMAHOPLKPFE MLBNOGHAGOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xA17790", Offset = "0xA16B90", VA = "0x180A17790", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public CMOOMNHMMEN IHGFGEOJMEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA09250", Offset = "0xA08650", VA = "0x180A09250", Slot = "60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xE86870", Offset = "0xE85C70", VA = "0x180E86870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool JIAPEPJPEPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7FB9A20", Offset = "0x7FB8E20", VA = "0x187FB9A20", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool LBMAJHECLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7FB8D70", Offset = "0x7FB8170", VA = "0x187FB8D70", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool OPFLNLHJDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x1AC5570", Offset = "0x1AC4970", VA = "0x181AC5570", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private CancellationToken GFFNEBDBGPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x7FB9A00", Offset = "0x7FB8E00", VA = "0x187FB9A00", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private NPIEGGOELNH OKEIOELIAHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private bool ECOGOLNBPJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x1AC5570", Offset = "0x1AC4970", VA = "0x181AC5570", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x1ABF0F0", Offset = "0x1ABE4F0", VA = "0x181ABF0F0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action IIKPAIEADGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x7FB9740", Offset = "0x7FB8B40", VA = "0x187FB9740", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7FB9050", Offset = "0x7FB8450", VA = "0x187FB9050", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event DMKKJJFGIHC MOCFDNHEJMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x7FB9A80", Offset = "0x7FB8E80", VA = "0x187FB9A80", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7FB97A0", Offset = "0x7FB8BA0", VA = "0x187FB97A0", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event DMKKJJFGIHC AOCLDJHNEMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7FB9BF0", Offset = "0x7FB8FF0", VA = "0x187FB9BF0", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7FB90B0", Offset = "0x7FB84B0", VA = "0x187FB90B0", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event DMKKJJFGIHC FIOAOKHMKME
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7FB96E0", Offset = "0x7FB8AE0", VA = "0x187FB96E0", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7FB9860", Offset = "0x7FB8C60", VA = "0x187FB9860", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<CAACDBPGMHO, bool> BHFMNCBDEEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7FB9470", Offset = "0x7FB8870", VA = "0x187FB9470", Slot = "48")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x7FB8EE0", Offset = "0x7FB82E0", VA = "0x187FB8EE0", Slot = "49")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0xE86870", Offset = "0xE85C70", VA = "0x180E86870", Slot = "39")]
	public void CBOJEHHPOON(CMOOMNHMMEN GJAMJHDEMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x7FB9CE0", Offset = "0x7FB90E0", VA = "0x187FB9CE0")]
	[UnityEngine.Scripting.Preserve]
	internal MCIPCMGBMIM([GKAMHFFOHNI(null)] NPIEGGOELNH PHDMEDCBLHH, [GKAMHFFOHNI(null)] OAHJJJNDMGJ AAHFLKJGFKB, [GKAMHFFOHNI(null)] GJAODIKIHGJ OHOCPKNEMIO, [GKAMHFFOHNI(null)] IFFMIKJIEPF MFCHJJKNFDE, [GKAMHFFOHNI(null)] HCCOGDFGNKF FBDEPFOMMJE, [GKAMHFFOHNI(null)] INMEKJKHLIJ NBHIDLGKAGG, [GKAMHFFOHNI(null)] DADHEHMMNDP JGEMNCIHBBD, [GKAMHFFOHNI(null)] DFOPGDIDDDM AMGKGNHPMEG, [GKAMHFFOHNI(null)] BIOLGOHEHIG AIIKHBBLNAB, [GKAMHFFOHNI(null)] OJPLJCNJJKD HOGFAPNCLCL, [GKAMHFFOHNI(null)] PPPKKCAALIA PLEEBMIEBKK, [GKAMHFFOHNI(null)] PDIKACNCFIO DPHDNAKPIKG, [GKAMHFFOHNI(null)] HFLJMAPFFOH BJFGOAGLAAG, [GKAMHFFOHNI(null)] OHBPDLMECML GFKNIDDNOPM, [GKAMHFFOHNI(null)] KONPINNDDMD INFNJGOHAOA, [GKAMHFFOHNI(null)] JGJDODCEDJJ ADHCBCOLHCN, [GKAMHFFOHNI(null)] PABLCMOOJMJ NBHIAEJAPKM, [GKAMHFFOHNI(null)] FEEAKBALFLE BNDNNJMAACG, [GKAMHFFOHNI(null)] IOOPIIJMGEA OMPPKMCINHH, [GKAMHFFOHNI(null)] FCJIJIJJMOO MJKJNFCJDPC, [GKAMHFFOHNI(null)] BPJAFKHGDAB LIDMNCDJHKP, [GKAMHFFOHNI(null)] HBCHHOMPPDH GMPBMLNBNKJ, [GKAMHFFOHNI(null)] KPKAECBKNJI KEJLMDCJCCG, [GKAMHFFOHNI(null)] BFBEANOKDGL BGHOFLGKEEH, [GKAMHFFOHNI(null)] JNINLOJJHPN KJFELDIBKKG, [GKAMHFFOHNI(null)] ECMFINOGIEN EOPBDJJHJJL, [GKAMHFFOHNI(null)] JCENNCFNDPE IELGNIBJJEK, [GKAMHFFOHNI(null)] LIKHEEBCIHK ABGHEFKFGGA, [GKAMHFFOHNI(null)] NDHBCEMPGLA OPPHNMJGLCK, [GKAMHFFOHNI(null)] OACPOPIIAFF ACGDIJMHPEF, [GKAMHFFOHNI(null)] PJFNBOFGLFH NIKHCJJEBJP, [GKAMHFFOHNI(null)] PMAHOPLKPFE ONKIFNKOIKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x7FB98C0", Offset = "0x7FB8CC0", VA = "0x187FB98C0")]
	private void MBHBIOMKKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x7FB94D0", Offset = "0x7FB88D0", VA = "0x187FB94D0", Slot = "61")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x7FB9110", Offset = "0x7FB8510", VA = "0x187FB9110", Slot = "53")]
	private void CPHPFFLMIAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7FB9970", Offset = "0x7FB8D70", VA = "0x187FB9970", Slot = "54")]
	private CNOLAGDHOLD MJFIKMBIKPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7FB9C50", Offset = "0x7FB9050", VA = "0x187FB9C50", Slot = "55")]
	private DJBGKFICKCD PBFNGENHDCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7FB9160", Offset = "0x7FB8560", VA = "0x187FB9160", Slot = "57")]
	public Task DCFAOKPDGGG(int PNMPDHMKPJO, OIFNNMDODPC HBOAENOKJMI, Func<IPEJPHCMEGJ, IPEJPHCMEGJ> HENCKODCDJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7FB8F40", Offset = "0x7FB8340", VA = "0x187FB8F40")]
	private FDANPMIDNLA CBEOBAEGBIN(int PNMPDHMKPJO, OIFNNMDODPC HBOAENOKJMI, Func<IPEJPHCMEGJ, IPEJPHCMEGJ> HENCKODCDJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7FB9AE0", Offset = "0x7FB8EE0", VA = "0x187FB9AE0", Slot = "58")]
	[AsyncStateMachine(typeof(DNFCEKBMOIE))]
	private Task<BAOOEPCCKJO> OKNOGLHFONA(GLNNANNECEB PEJBDAJPKPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x7FB8DF0", Offset = "0x7FB81F0", VA = "0x187FB8DF0", Slot = "59")]
	[AsyncStateMachine(typeof(LGEEADJLIHJ))]
	private Task BAEOJHCADHM(CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x7FB9660", Offset = "0x7FB8A60", VA = "0x187FB9660")]
	[IteratorStateMachine(typeof(IJMICFOMEPP))]
	private IEnumerable<ECNGEIBHFNE> FEEBBOFFBEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x7FB9800", Offset = "0x7FB8C00", VA = "0x187FB9800")]
	[CompilerGenerated]
	private void JIPKCDBFMKO(ECNGEIBHFNE EJFPPCHJOBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class CEBHPPMJIGA : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x16817D0", Offset = "0x1680BD0", VA = "0x1816817D0")]
	public CEBHPPMJIGA(string EIGJGBPHOMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal class FMBAJEPEAEO : PMCKHAAEPML
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct MELIFMNJAML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncTaskMethodBuilder<PMCKHAAEPML.PAICCLOMNDO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public HashSet<PDIKACNCFIO.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public FMBAJEPEAEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x7FBA1B0", Offset = "0x7FB95B0", VA = "0x187FBA1B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x7FBA4B0", Offset = "0x7FB98B0", VA = "0x187FBA4B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly GGAFKPAJMJF NNEBHMDLFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly IFFMIKJIEPF MFCHJJKNFDE;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private string CILNDCKAELB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7FB2530", Offset = "0x7FB1930", VA = "0x187FB2530", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x995770", Offset = "0x994B70", VA = "0x180995770")]
	public FMBAJEPEAEO(GGAFKPAJMJF NNEBHMDLFHI, IFFMIKJIEPF MFCHJJKNFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x7FB2560", Offset = "0x7FB1960", VA = "0x187FB2560", Slot = "5")]
	[AsyncStateMachine(typeof(MELIFMNJAML))]
	public Task<PMCKHAAEPML.PAICCLOMNDO> OLFBKCKDMKB(HashSet<PDIKACNCFIO.Reason> JCKNNFBDABL, CancellationToken BLABAMPAGAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal class HCEPJPCKPCE : GPGMFMFNMCA, PMCKHAAEPML
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct DPHFMKBOFAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public AsyncTaskMethodBuilder<PMCKHAAEPML.PAICCLOMNDO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public HCEPJPCKPCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public HashSet<PDIKACNCFIO.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private MEMBODLLNEP <localRoomInstance>5__2;

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
		private TaskAwaiter<PMCKHAAEPML.PAICCLOMNDO> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x7FAFDA0", Offset = "0x7FAF1A0", VA = "0x187FAFDA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x7FB0700", Offset = "0x7FAFB00", VA = "0x187FB0700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private string CILNDCKAELB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x7FB3CC0", Offset = "0x7FB30C0", VA = "0x187FB3CC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x995770", Offset = "0x994B70", VA = "0x180995770")]
	public HCEPJPCKPCE(GGAFKPAJMJF NNEBHMDLFHI, IFFMIKJIEPF MFCHJJKNFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7FB3CF0", Offset = "0x7FB30F0", VA = "0x187FB3CF0", Slot = "5")]
	[AsyncStateMachine(typeof(DPHFMKBOFAN))]
	public Task<PMCKHAAEPML.PAICCLOMNDO> OLFBKCKDMKB(HashSet<PDIKACNCFIO.Reason> JCKNNFBDABL, CancellationToken BLABAMPAGAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal class FCJLLAFOMEE : GPGMFMFNMCA, PMCKHAAEPML
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct KPPLPHOIONL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public AsyncTaskMethodBuilder<PMCKHAAEPML.PAICCLOMNDO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public FCJLLAFOMEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public HashSet<PDIKACNCFIO.Reason> fallbackTriggersToIgnore;

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
		private TaskAwaiter<NNHGHMAIOHK> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private TaskAwaiter<PMCKHAAEPML.PAICCLOMNDO> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7FB7390", Offset = "0x7FB6790", VA = "0x187FB7390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7FB7D80", Offset = "0x7FB7180", VA = "0x187FB7D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private string CILNDCKAELB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x7FB1BF0", Offset = "0x7FB0FF0", VA = "0x187FB1BF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x995770", Offset = "0x994B70", VA = "0x180995770")]
	public FCJLLAFOMEE(GGAFKPAJMJF NNEBHMDLFHI, IFFMIKJIEPF MFCHJJKNFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7FB1C20", Offset = "0x7FB1020", VA = "0x187FB1C20", Slot = "5")]
	[AsyncStateMachine(typeof(KPPLPHOIONL))]
	public Task<PMCKHAAEPML.PAICCLOMNDO> OLFBKCKDMKB(HashSet<PDIKACNCFIO.Reason> JCKNNFBDABL, CancellationToken BLABAMPAGAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal class LFMCPCCAEOA : GPGMFMFNMCA, PMCKHAAEPML
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class PNHILPNPOAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public NNHGHMAIOHK matchmakingErrorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public MEMBODLLNEP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public long preFallbackInstance;

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public PNHILPNPOAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x7FC5800", Offset = "0x7FC4C00", VA = "0x187FC5800")]
		internal object AOKPKIAJHHL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x7FC5880", Offset = "0x7FC4C80", VA = "0x187FC5880")]
		internal object MKBCJLGKLBP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct GPMPADNAINP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public AsyncTaskMethodBuilder<PMCKHAAEPML.PAICCLOMNDO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public LFMCPCCAEOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public HashSet<PDIKACNCFIO.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private PNHILPNPOAO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private TaskAwaiter<NNHGHMAIOHK> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private TaskAwaiter<PMCKHAAEPML.PAICCLOMNDO> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x7FB3030", Offset = "0x7FB2430", VA = "0x187FB3030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x7FB3C50", Offset = "0x7FB3050", VA = "0x187FB3C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private string CILNDCKAELB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7FB82E0", Offset = "0x7FB76E0", VA = "0x187FB82E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x995770", Offset = "0x994B70", VA = "0x180995770")]
	public LFMCPCCAEOA(GGAFKPAJMJF NNEBHMDLFHI, IFFMIKJIEPF MFCHJJKNFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7FB8310", Offset = "0x7FB7710", VA = "0x187FB8310", Slot = "5")]
	[AsyncStateMachine(typeof(GPMPADNAINP))]
	public Task<PMCKHAAEPML.PAICCLOMNDO> OLFBKCKDMKB(HashSet<PDIKACNCFIO.Reason> JCKNNFBDABL, CancellationToken BLABAMPAGAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal abstract class GPGMFMFNMCA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct JEGBIFAIPFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public ABDDJEPKCOD log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public HashSet<PDIKACNCFIO.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public GPGMFMFNMCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private PEPIFLGHCHM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private List<PDIKACNCFIO.Reason> <newDisconnectTriggers>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x7FB6AB0", Offset = "0x7FB5EB0", VA = "0x187FB6AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x7FB6FD0", Offset = "0x7FB63D0", VA = "0x187FB6FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	protected readonly GGAFKPAJMJF NNEBHMDLFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	protected readonly IFFMIKJIEPF MFCHJJKNFDE;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	protected OAJMAHCOGME MJEJCKIGNCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x7FB2EB0", Offset = "0x7FB22B0", VA = "0x187FB2EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x995770", Offset = "0x994B70", VA = "0x180995770")]
	public GPGMFMFNMCA(GGAFKPAJMJF NNEBHMDLFHI, IFFMIKJIEPF MFCHJJKNFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7FB2F00", Offset = "0x7FB2300", VA = "0x187FB2F00")]
	[AsyncStateMachine(typeof(JEGBIFAIPFM))]
	protected Task PGMGEPIHOFL(ABDDJEPKCOD LEMJHEDOKDF, HashSet<PDIKACNCFIO.Reason> JCKNNFBDABL, CancellationToken BLABAMPAGAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class AKPPFKBFOGF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct OPJGNBGMDBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public AsyncTaskMethodBuilder<PMCKHAAEPML.PAICCLOMNDO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public IFFMIKJIEPF callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x7FC4170", Offset = "0x7FC3570", VA = "0x187FC4170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x7FC44F0", Offset = "0x7FC38F0", VA = "0x187FC44F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class JKGDJIPJFPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public string fallbackName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public GGAFKPAJMJF roomManager;

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public JKGDJIPJFPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x7FB7030", Offset = "0x7FB6430", VA = "0x187FB7030")]
		internal object FCFFCJMCDNA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static readonly float CNNPJEAJAFA;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	internal static readonly HashSet<PDIKACNCFIO.Reason> OOOGBFFADGC;

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7FA7C10", Offset = "0x7FA7010", VA = "0x187FA7C10")]
	[AsyncStateMachine(typeof(OPJGNBGMDBP))]
	internal static Task<PMCKHAAEPML.PAICCLOMNDO> GELBEIDDECL(IFFMIKJIEPF MFCHJJKNFDE, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7FA7A90", Offset = "0x7FA6E90", VA = "0x187FA7A90")]
	internal static void FMOONCAEAOJ(GGAFKPAJMJF NNEBHMDLFHI, ABDDJEPKCOD LEMJHEDOKDF, string IMLBFEPBBFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal interface PMCKHAAEPML
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct PAICCLOMNDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public bool NIGNBIDEMPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public PDIKACNCFIO.Reason CIAFGFLDDGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Enum? NPFJBMIOBBL;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x7FC4560", Offset = "0x7FC3960", VA = "0x187FC4560")]
		public static PAICCLOMNDO AJJECIJBGPC()
		{
			return default(PAICCLOMNDO);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x7FC4570", Offset = "0x7FC3970", VA = "0x187FC4570")]
		public static PAICCLOMNDO LHFFBHAPKHM(PDIKACNCFIO.Reason CIAFGFLDDGN, [Optional] Enum? NPFJBMIOBBL)
		{
			return default(PAICCLOMNDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	string ADCKDCJKMMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<PAICCLOMNDO> OLFBKCKDMKB(HashSet<PDIKACNCFIO.Reason> JCKNNFBDABL, CancellationToken BLABAMPAGAH);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal struct FMANJODDJGH
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class DFMKNKJOFLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public GGAFKPAJMJF manager;

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public DFMKNKJOFLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x7FAF440", Offset = "0x7FAE840", VA = "0x187FAF440")]
		internal Task DOLKMHIDLEA(CancellationToken cancellationToken, int roomTotalVersion, HJMLLMJGAOM localPlayerAccountRoleType)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct OHJGJKAEACG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public FMANJODDJGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private GLNNANNECEB <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private TaskAwaiter<HJOHEIBOLIO> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private TaskAwaiter<BAOOEPCCKJO> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x7FC3480", Offset = "0x7FC2880", VA = "0x187FC3480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7FC3A10", Offset = "0x7FC2E10", VA = "0x187FC3A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct OPIHOEEDGML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public FMANJODDJGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7FC3DF0", Offset = "0x7FC31F0", VA = "0x187FC3DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7FC4110", Offset = "0x7FC3510", VA = "0x187FC4110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly CancellationToken BLABAMPAGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly GGAFKPAJMJF ECPDNOJCJEA;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private OAHJJJNDMGJ HCPOCNIOGNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x7FB1F00", Offset = "0x7FB1300", VA = "0x187FB1F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private IFFMIKJIEPF OGNNDGMLFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7FB21B0", Offset = "0x7FB15B0", VA = "0x187FB21B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private OAJMAHCOGME MJEJCKIGNCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x7FB2130", Offset = "0x7FB1530", VA = "0x187FB2130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	private OJPLJCNJJKD DIGDKFPEMNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x7FB22D0", Offset = "0x7FB16D0", VA = "0x187FB22D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x264B7A0", Offset = "0x264ABA0", VA = "0x18264B7A0")]
	public FMANJODDJGH(CancellationToken BLABAMPAGAH, GGAFKPAJMJF ECPDNOJCJEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x7FB1F50", Offset = "0x7FB1350", VA = "0x187FB1F50")]
	public static DIOKMOOEKFM FIKJJGNBPMC(GGAFKPAJMJF ECPDNOJCJEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x7FB1DF0", Offset = "0x7FB11F0", VA = "0x187FB1DF0")]
	[AsyncStateMachine(typeof(OHJGJKAEACG))]
	public Task<bool> CAFDDKMELKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x7FB2320", Offset = "0x7FB1720", VA = "0x187FB2320")]
	private bool OBKNFMICNEE([Out] GLNNANNECEB PEJBDAJPKPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x7FB2200", Offset = "0x7FB1600", VA = "0x187FB2200")]
	[AsyncStateMachine(typeof(OPIHOEEDGML))]
	private Task NLKBGLNBACG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7FB2000", Offset = "0x7FB1400", VA = "0x187FB2000")]
	private Task<HJOHEIBOLIO> HAEIFLKCEOP(GLNNANNECEB GKIBCEPEGBG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct KHBHCLPOBBI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly KONPINNDDMD INFNJGOHAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly Guid NPMNDEDHHIJ;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private Task<(BAOOEPCCKJO, Task)> POGFBMLNLEO
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x7FB7270", Offset = "0x7FB6670", VA = "0x187FB7270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x4D66EF0", Offset = "0x4D662F0", VA = "0x184D66EF0")]
	public KHBHCLPOBBI(KONPINNDDMD INFNJGOHAOA, Guid NPMNDEDHHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x7FB7340", Offset = "0x7FB6740", VA = "0x187FB7340")]
	public TaskAwaiter<(BAOOEPCCKJO, Task)> JAGFCPCIBCF()
	{
		return default(TaskAwaiter<(BAOOEPCCKJO, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x7FB71A0", Offset = "0x7FB65A0", VA = "0x187FB71A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal struct LDFLJPKKCPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly TaskCompletionSource<(BAOOEPCCKJO, Task)> OJPJPPEDNGG;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Task<(BAOOEPCCKJO, Task)> POGFBMLNLEO
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x7FB7F10", Offset = "0x7FB7310", VA = "0x187FB7F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x7FB8160", Offset = "0x7FB7560", VA = "0x187FB8160")]
	public LDFLJPKKCPG(TimeSpan DHENFBPIIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x7FB7F50", Offset = "0x7FB7350", VA = "0x187FB7F50")]
	public void GIPECFKODIJ(Task FKDKDOOLECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x7FB80D0", Offset = "0x7FB74D0", VA = "0x187FB80D0")]
	public void PJOOMJMNNOI(BAOOEPCCKJO LIPHIBKLFND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x7FB7FF0", Offset = "0x7FB73F0", VA = "0x187FB7FF0")]
	public void HEOAENPEAFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x7FB8040", Offset = "0x7FB7440", VA = "0x187FB8040")]
	internal void LNKAMEJMHGJ(string EIGJGBPHOMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class AMBDEBHOENG
{
	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x7FA7FD0", Offset = "0x7FA73D0", VA = "0x187FA7FD0")]
	public static JGCMJADBFFC JLPDCOKMOJG(this JGCMJADBFFC KGCLHKOHKLJ, KDNGIJKMAJN IBEBAOJDPBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x7FA7E40", Offset = "0x7FA7240", VA = "0x187FA7E40")]
	public static JGCMJADBFFC FELMAOIELID(this JGCMJADBFFC KGCLHKOHKLJ, CELGJIPHPBI AMMDNHHKABI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class ELGJANFDCJO : DBCPILAEFPO
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class LCDBDDPDGFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public CELGJIPHPBI subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public LCDBDDPDGFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7FB7E60", Offset = "0x7FB7260", VA = "0x187FB7E60")]
		internal bool LDBEKNJMFFP(FEOHBPOKLEE s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly ECMFINOGIEN MIFGCCGFNDD;

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x999BC0", Offset = "0x998FC0", VA = "0x180999BC0")]
	public ELGJANFDCJO(ECMFINOGIEN EOPBDJJHJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x7FB0820", Offset = "0x7FAFC20", VA = "0x187FB0820", Slot = "4")]
	public JGCMJADBFFC DCJNBNANGBG(long PENFHAJDLCJ, long CLKFEHDHMIF, string CGOKGIMLOPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x7FB08B0", Offset = "0x7FAFCB0", VA = "0x187FB08B0", Slot = "5")]
	public JGCMJADBFFC DCJNBNANGBG(long PENFHAJDLCJ, long CLKFEHDHMIF, PGNIPJOEHNG EDHFJOANBFH, Guid? GMEANDPBKJG, long CPCDCDODJDH, bool DNCDEBKACBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x7FB0CF0", Offset = "0x7FB00F0", VA = "0x187FB0CF0", Slot = "6")]
	public JGCMJADBFFC DCJNBNANGBG(PFDCFKLNLCM FMPJHIEGICA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x7FB0A10", Offset = "0x7FAFE10", VA = "0x187FB0A10", Slot = "7")]
	public JGCMJADBFFC DCJNBNANGBG(KDNGIJKMAJN FMMIDMGJGCP, CELGJIPHPBI FPNKCMHKPAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x7FB0770", Offset = "0x7FAFB70", VA = "0x187FB0770")]
	private Guid? CJEDAIAGGJF(KDNGIJKMAJN LOONGALEIFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[RecRoom.NoEngine.Common.Preserve]
internal class FOOMDJHJIEG : BIOLGOHEHIG, ECNGEIBHFNE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct ABMJEJDGBKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public FOOMDJHJIEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private PEPIFLGHCHM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x7FA73A0", Offset = "0x7FA67A0", VA = "0x187FA73A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7FA7A30", Offset = "0x7FA6E30", VA = "0x187FA7A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly NIOICMFLLAK MDLMFBPOMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private string MHDAEJKDFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Task OAADJOKGAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private GGAFKPAJMJF NNEBHMDLFHI;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool OKBOGPEDLOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7FB26F0", Offset = "0x7FB1AF0", VA = "0x187FB26F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Task DGMFONDJLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x7FB2880", Offset = "0x7FB1C80", VA = "0x187FB2880", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x99BAC0", Offset = "0x99AEC0", VA = "0x18099BAC0", Slot = "7")]
	public void MBHBIOMKKEG(GGAFKPAJMJF NNEBHMDLFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x7FB2720", Offset = "0x7FB1B20", VA = "0x187FB2720", Slot = "6")]
	public void ICANDIIJJJP(Task ALKPEINKLAJ, string HHONLIOPJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x7FB2910", Offset = "0x7FB1D10", VA = "0x187FB2910")]
	[AsyncStateMachine(typeof(ABMJEJDGBKM))]
	private Task LFOLEJAGEPC(Task CCKCANLHMBJ, string HHONLIOPJPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x7FB2A30", Offset = "0x7FB1E30", VA = "0x187FB2A30")]
	public FOOMDJHJIEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal class IIMDMGKNFMP : ELCIHFFMKCH, ECNGEIBHFNE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private bool BJFNDNGJGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private OCJBCLJLKMI LIHCDJIOCAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private OAHJJJNDMGJ AAHFLKJGFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private ECMFINOGIEN EOPBDJJHJJL;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public OCJBCLJLKMI OAPOLNNKMOI
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x7FB5700", Offset = "0x7FB4B00", VA = "0x187FB5700", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x7FB5770", Offset = "0x7FB4B70", VA = "0x187FB5770", Slot = "7")]
	public void MBHBIOMKKEG(GGAFKPAJMJF NNEBHMDLFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x7FB5490", Offset = "0x7FB4890", VA = "0x187FB5490", Slot = "5")]
	public void FPDJKNCCFJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x7FB5450", Offset = "0x7FB4850", VA = "0x187FB5450", Slot = "6")]
	public void BEGIPBDKKHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x7FB5640", Offset = "0x7FB4A40", VA = "0x187FB5640")]
	private Task IGJMNHCPINJ(OIALOHMOJIF OICAMEEFOOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x7FB5450", Offset = "0x7FB4850", VA = "0x187FB5450", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public IIMDMGKNFMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal class OAKHMCIGFDD : ECMFINOGIEN
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private class CKGJDIONGEN<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly KIKFEAEKMGH GOOAHAMPCLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private readonly string MCBJECJLDOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly T MBADHELIPJM;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public T HNMCNCHEPGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0xBD2B40", Offset = "0xBD1F40", VA = "0x180BD2B40")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0xBD2770", Offset = "0xBD1B70", VA = "0x180BD2770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x620FD60", Offset = "0x620F160", VA = "0x18620FD60")]
		public CKGJDIONGEN(KIKFEAEKMGH GOOAHAMPCLE, string MCBJECJLDOM, T MBADHELIPJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x620F4C0", Offset = "0x620E8C0", VA = "0x18620F4C0")]
		private void HIPCJPIEPOA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly KIKFEAEKMGH GOOAHAMPCLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly CKGJDIONGEN<TimeSpan> DJFFHJKGLJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly CKGJDIONGEN<TimeSpan> BBHNCHHADLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly CKGJDIONGEN<TimeSpan> CLHJBPODLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly CKGJDIONGEN<TimeSpan> DBHLFBIFIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly CKGJDIONGEN<bool> BNINOPNPCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly CKGJDIONGEN<bool> AEGPCGMOJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly CKGJDIONGEN<bool> NFCDEHNKNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly CKGJDIONGEN<int> ECOHKLCGGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly CKGJDIONGEN<bool> IJKNLBBGCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly CKGJDIONGEN<bool> BJGFBIBFDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly CKGJDIONGEN<HLIMIBICFIJ> EOOHNMFOCBO;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public TimeSpan CIBGNEKHFKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x7FC1E30", Offset = "0x7FC1230", VA = "0x187FC1E30", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public TimeSpan CBMAAHGHMFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7FC1E70", Offset = "0x7FC1270", VA = "0x187FC1E70", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public TimeSpan POBIHKBGNJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x7FC1F70", Offset = "0x7FC1370", VA = "0x187FC1F70", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public TimeSpan KBNHJLFJAOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2070", Offset = "0x7FC1470", VA = "0x187FC2070", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool FDJKFKPFNFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x7FC1FB0", Offset = "0x7FC13B0", VA = "0x187FC1FB0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool MECEEDFKPGA
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x7FC1EF0", Offset = "0x7FC12F0", VA = "0x187FC1EF0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool FJGOOIDODBN
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x7FC1F30", Offset = "0x7FC1330", VA = "0x187FC1F30", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int JLPKHIIBDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x7FC1FF0", Offset = "0x7FC13F0", VA = "0x187FC1FF0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool LIJBFMEFOPD
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x7FC1EB0", Offset = "0x7FC12B0", VA = "0x187FC1EB0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool JGEGEPOCHJK
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2030", Offset = "0x7FC1430", VA = "0x187FC2030", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool CJNBHIOHGKP
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x7FC20B0", Offset = "0x7FC14B0", VA = "0x187FC20B0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7FC2100", Offset = "0x7FC1500", VA = "0x187FC2100")]
	[UnityEngine.Scripting.Preserve]
	public OAKHMCIGFDD([GKAMHFFOHNI(null)] KIKFEAEKMGH GOOAHAMPCLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[UnityEngine.Scripting.Preserve]
internal class IBCEPHKMHKH : PPPKKCAALIA, ECNGEIBHFNE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class IIIDMJPKPBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public KDMPGIPNGGP roomEvent;

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public IIIDMJPKPBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x7FB5370", Offset = "0x7FB4770", VA = "0x187FB5370")]
		internal object NNPMDNGNMKM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action KJEMEDAPGPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x7FB4F00", Offset = "0x7FB4300", VA = "0x187FB4F00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x7FB52D0", Offset = "0x7FB46D0", VA = "0x187FB52D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event DMKKJJFGIHC HJIJHAMJCMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x7FB5190", Offset = "0x7FB4590", VA = "0x187FB5190", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x7FB4C30", Offset = "0x7FB4030", VA = "0x187FB4C30", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event DMKKJJFGIHC JFNIPPCBGJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x7FB4B90", Offset = "0x7FB3F90", VA = "0x187FB4B90", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x7FB5230", Offset = "0x7FB4630", VA = "0x187FB5230", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event DMKKJJFGIHC EMBKPGPEAOG
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x7FB4CD0", Offset = "0x7FB40D0", VA = "0x187FB4CD0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x7FB4A40", Offset = "0x7FB3E40", VA = "0x187FB4A40", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<CAACDBPGMHO, bool> KBEFGIMJDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x7FB4E20", Offset = "0x7FB4220", VA = "0x187FB4E20", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x7FB4AE0", Offset = "0x7FB3EE0", VA = "0x187FB4AE0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "19")]
	public void MBHBIOMKKEG(GGAFKPAJMJF NNEBHMDLFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x7FB4FA0", Offset = "0x7FB43A0", VA = "0x187FB4FA0", Slot = "14")]
	public void NLOBECAGNLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x7FB4D70", Offset = "0x7FB4170", VA = "0x187FB4D70", Slot = "15")]
	public void FEKFKMGLDDK(KDMPGIPNGGP IHPBFDHNLCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x7FB4ED0", Offset = "0x7FB42D0", VA = "0x187FB4ED0", Slot = "16")]
	public void KPLDHILGDJD(KDMPGIPNGGP IHPBFDHNLCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x7FB4DA0", Offset = "0x7FB41A0", VA = "0x187FB4DA0", Slot = "17")]
	public void GCDIODIBGPM(KDMPGIPNGGP IHPBFDHNLCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x7FB4DD0", Offset = "0x7FB41D0", VA = "0x187FB4DD0", Slot = "18")]
	public void GEKGECFJHLL(CAACDBPGMHO AKJDKCNBMBD, bool NIGNBIDEMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x7FB4880", Offset = "0x7FB3C80", VA = "0x187FB4880")]
	private void BHNBAFNFKNN(DMKKJJFGIHC ANHGJIGHHKP, KDMPGIPNGGP IHPBFDHNLCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public IBCEPHKMHKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[UnityEngine.Scripting.Preserve]
internal class PPJIDOPDJOA : PDIKACNCFIO, ECNGEIBHFNE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private class CLJNMHMAMIA : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private struct DBLOPNEHJMO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public CLJNMHMAMIA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public PDIKACNCFIO.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			private PEPIFLGHCHM <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			private PMCKHAAEPML[] <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			private int <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			private TaskAwaiter<PMCKHAAEPML.PAICCLOMNDO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x7FAE6E0", Offset = "0x7FADAE0", VA = "0x187FAE6E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x7FAEE10", Offset = "0x7FAE210", VA = "0x187FAEE10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private struct FCDJMNMCOOL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public AsyncTaskMethodBuilder<PMCKHAAEPML.PAICCLOMNDO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public PMCKHAAEPML fallbackProvider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public CLJNMHMAMIA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public PDIKACNCFIO.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			private PEPIFLGHCHM <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			private DBCOPAHCJBF <individualFallbackTaskState>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			private TaskAwaiter<PMCKHAAEPML.PAICCLOMNDO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x7FB0EF0", Offset = "0x7FB02F0", VA = "0x187FB0EF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x7FB1B80", Offset = "0x7FB0F80", VA = "0x187FB1B80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class LCHFGJAOFDB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public PMCKHAAEPML fallbackProvider;

			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public LCHFGJAOFDB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x7FB7E90", Offset = "0x7FB7290", VA = "0x187FB7E90")]
			internal object NJLIEOFFHJD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public Task ALKPEINKLAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public CancellationTokenSource ILOJCDEHDJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public DBCOPAHCJBF IMIPMKPIKMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public IFFMIKJIEPF MFCHJJKNFDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public IGHPKFMLLFB JJJOOJLLFOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public MEMBODLLNEP OHBACCHDJLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public PMCKHAAEPML[] LIINJEPHEBB;

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public bool OKPEPBABHOB
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x7FA9310", Offset = "0x7FA8710", VA = "0x187FA9310")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool DONCDILDAJE
		{
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x7FA9330", Offset = "0x7FA8730", VA = "0x187FA9330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7FAA710", Offset = "0x7FA9B10", VA = "0x187FAA710")]
		public CLJNMHMAMIA(IFFMIKJIEPF MFCHJJKNFDE, IGHPKFMLLFB JJJOOJLLFOL, MEMBODLLNEP OHBACCHDJLF, PMCKHAAEPML[] LIINJEPHEBB, CancellationToken BLABAMPAGAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9020", Offset = "0x7FA8420", VA = "0x187FA9020", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9610", Offset = "0x7FA8A10", VA = "0x187FA9610")]
		public void HKPHHHMIICC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7FA91B0", Offset = "0x7FA85B0", VA = "0x187FA91B0")]
		public void EBOLJFIKGOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7FA97C0", Offset = "0x7FA8BC0", VA = "0x187FA97C0")]
		public void KDDPGLMGAHN(PDIKACNCFIO.Reason MEKDEJEDLAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7FA8F20", Offset = "0x7FA8320", VA = "0x187FA8F20")]
		[AsyncStateMachine(typeof(DBLOPNEHJMO))]
		public Task DHJHPMLMPPO(PDIKACNCFIO.Reason CIAFGFLDDGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9680", Offset = "0x7FA8A80", VA = "0x187FA9680")]
		[AsyncStateMachine(typeof(FCDJMNMCOOL))]
		private Task<PMCKHAAEPML.PAICCLOMNDO> KBPCPIEJONC(PDIKACNCFIO.Reason CIAFGFLDDGN, PMCKHAAEPML KGCJMKJFLME)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7FA94F0", Offset = "0x7FA88F0", VA = "0x187FA94F0")]
		private void HKLJMOCKMJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7FA8BC0", Offset = "0x7FA7FC0", VA = "0x187FA8BC0")]
		public bool BEEMHAIDFFJ(PDIKACNCFIO.Reason LAJKPMDHMDI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7FA8C70", Offset = "0x7FA8070", VA = "0x187FA8C70")]
		private void CAPAGPOKIKH(DBCOPAHCJBF FBOKGPFKJCL, PDIKACNCFIO.Reason CIAFGFLDDGN = PDIKACNCFIO.Reason.Unknown)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9A70", Offset = "0x7FA8E70", VA = "0x187FA9A70")]
		private void MKIAJLNLEIC(DBCOPAHCJBF FBOKGPFKJCL, PMCKHAAEPML.PAICCLOMNDO KGODHHBLJOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9350", Offset = "0x7FA8750", VA = "0x187FA9350")]
		private void GNENBEDJEEO(DBCOPAHCJBF FBOKGPFKJCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9D50", Offset = "0x7FA9150", VA = "0x187FA9D50")]
		private void MPFDBKPNEIM(DBCOPAHCJBF FBOKGPFKJCL, PMCKHAAEPML.PAICCLOMNDO KGODHHBLJOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7FAA110", Offset = "0x7FA9510", VA = "0x187FAA110")]
		private void OBENJNGJNFF(DBCOPAHCJBF FBOKGPFKJCL, Exception GEEGJFAONEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C40", Offset = "0x7FA9040", VA = "0x187FA9C40")]
		private void MNKLHGIKHFF(PMCKHAAEPML KGCJMKJFLME, PDIKACNCFIO.Reason CIAFGFLDDGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x7FAA270", Offset = "0x7FA9670", VA = "0x187FAA270")]
		private void ONKIDEGMCHB(PMCKHAAEPML KGCJMKJFLME, PDIKACNCFIO.Reason CIAFGFLDDGN, string NPFJBMIOBBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x7FAA380", Offset = "0x7FA9780", VA = "0x187FAA380", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class DBCOPAHCJBF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public Task<PMCKHAAEPML.PAICCLOMNDO> ALKPEINKLAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public CancellationTokenSource ILOJCDEHDJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public PMCKHAAEPML KGCJMKJFLME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public PDIKACNCFIO.Reason MEKDEJEDLAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public HashSet<PDIKACNCFIO.Reason> JCKNNFBDABL;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public bool OKPEPBABHOB
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x7FA9310", Offset = "0x7FA8710", VA = "0x187FA9310")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public bool DONCDILDAJE
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x7FA9330", Offset = "0x7FA8730", VA = "0x187FA9330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x7FAA850", Offset = "0x7FA9C50", VA = "0x187FAA850")]
		public void MDEFFPJLFDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7FAA830", Offset = "0x7FA9C30", VA = "0x187FAA830", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7FAA9B0", Offset = "0x7FA9DB0", VA = "0x187FAA9B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x7FAAD20", Offset = "0x7FAA120", VA = "0x187FAAD20")]
		public DBCOPAHCJBF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class CHHACCGGEEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public PDIKACNCFIO.Reason reason;

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public CHHACCGGEEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7FA8590", Offset = "0x7FA7990", VA = "0x187FA8590")]
		internal object CLLDPBGMKCG(DBCOPAHCJBF x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x7FA8600", Offset = "0x7FA7A00", VA = "0x187FA8600")]
		internal object FGOCEOELKHJ(CLJNMHMAMIA x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7FA8670", Offset = "0x7FA7A70", VA = "0x187FA8670")]
		internal object OIAHPMDMDIF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct MJBMDMCONPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public PDIKACNCFIO.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public PPJIDOPDJOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private CHHACCGGEEJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private PEPIFLGHCHM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x7FC0CA0", Offset = "0x7FC00A0", VA = "0x187FC0CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x7FC1700", Offset = "0x7FC0B00", VA = "0x187FC1700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private struct MHBGNDICLMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public PPJIDOPDJOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public PDIKACNCFIO.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private CLJNMHMAMIA <localTaskState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x7FBA520", Offset = "0x7FB9920", VA = "0x187FBA520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x7FBB190", Offset = "0x7FBA590", VA = "0x187FBB190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private struct DBNJBMFGCIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public PPJIDOPDJOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x7FAEE70", Offset = "0x7FAE270", VA = "0x187FAEE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x7FAF3E0", Offset = "0x7FAE7E0", VA = "0x187FAF3E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	internal static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	internal static readonly ABDDJEPKCOD HNOOKCPBLNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private GGAFKPAJMJF NNEBHMDLFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private IFFMIKJIEPF MFCHJJKNFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private CLJNMHMAMIA GBKJGNHGEPB;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private OAJMAHCOGME MJEJCKIGNCH
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x7FC60B0", Offset = "0x7FC54B0", VA = "0x187FC60B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool FGHCJJPJJPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x2202070", Offset = "0x2201470", VA = "0x182202070", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private bool PCCHCFCPKGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x7FC66C0", Offset = "0x7FC5AC0", VA = "0x187FC66C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x7FC6100", Offset = "0x7FC5500", VA = "0x187FC6100", Slot = "7")]
	public void MBHBIOMKKEG(GGAFKPAJMJF NNEBHMDLFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x7FC5A10", Offset = "0x7FC4E10", VA = "0x187FC5A10", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x7FC6180", Offset = "0x7FC5580", VA = "0x187FC6180", Slot = "9")]
	public void MDEFFPJLFDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x7FC5A20", Offset = "0x7FC4E20", VA = "0x187FC5A20")]
	private bool EMJKNHGELGG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x7FC5940", Offset = "0x7FC4D40", VA = "0x187FC5940", Slot = "6")]
	private void CEBDDGGIEEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x7FC6300", Offset = "0x7FC5700", VA = "0x187FC6300", Slot = "5")]
	[AsyncStateMachine(typeof(MJBMDMCONPN))]
	private Task NOOCEJCBLLF(PDIKACNCFIO.Reason CIAFGFLDDGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x7FC63F0", Offset = "0x7FC57F0", VA = "0x187FC63F0")]
	private bool ONHOFFEAKPP(PDIKACNCFIO.Reason CIAFGFLDDGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x7FC5BD0", Offset = "0x7FC4FD0", VA = "0x187FC5BD0")]
	private PMCKHAAEPML[] HCGCIPEIFJE(MEMBODLLNEP CEDEOGCBBIO, IGHPKFMLLFB OIILMINAEGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x7FC5FA0", Offset = "0x7FC53A0", VA = "0x187FC5FA0")]
	[AsyncStateMachine(typeof(MHBGNDICLMG))]
	private Task HNFLJCJBHLI(PDIKACNCFIO.Reason CIAFGFLDDGN, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x7FC5B00", Offset = "0x7FC4F00", VA = "0x187FC5B00")]
	[AsyncStateMachine(typeof(DBNJBMFGCIF))]
	private Task FKHLAPPLMAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public PPJIDOPDJOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[RecRoom.NoEngine.Common.Preserve]
internal class DBHDIGKMJJI : HFLJMAPFFOH, ECNGEIBHFNE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct HDJFNMFAJMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public MEMBODLLNEP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public DBHDIGKMJJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public CMOOMNHMMEN customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private PEPIFLGHCHM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x7FB3EC0", Offset = "0x7FB32C0", VA = "0x187FB3EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7FB4820", Offset = "0x7FB3C20", VA = "0x187FB4820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct IMANDEGNLLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public DBHDIGKMJJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public MEMBODLLNEP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public CMOOMNHMMEN customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private HOEFFPEDKPI<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private PEPIFLGHCHM <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private BFOAALAPEEN <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private BPJJMHKIAII <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x7FB5DA0", Offset = "0x7FB51A0", VA = "0x187FB5DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x7FB6A50", Offset = "0x7FB5E50", VA = "0x187FB6A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class PHPPLFCDLCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public Matchmaking.OKHHKDOGKML result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public JEEOHFCIHID errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public PHPPLFCDLCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x7FC4D00", Offset = "0x7FC4100", VA = "0x187FC4D00")]
		internal object OAJFDMMEHAK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class HLBEBKKGIFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public Task<JGCMJADBFFC> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public HLBEBKKGIFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
		internal Task<JGCMJADBFFC> PAOJIAEBJMC(HOEFFPEDKPI<string>.AEKMEBIOPMA _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private struct MILEGNIEGEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public DBHDIGKMJJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public MEMBODLLNEP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public CMOOMNHMMEN customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public BFOAALAPEEN joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private HLBEBKKGIFA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private MIHMEPLBLHG <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private PEPIFLGHCHM <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <connectToRoomAndRunLoadLogicTimer>5__5;

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
		private CMIBACOKHIM <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private Task<Matchmaking.NDHKEMAFIBA> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private NFFKPCPKHGN <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <>7__wrap12;

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
		private TaskAwaiter<Matchmaking.NDHKEMAFIBA> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private TaskAwaiter<JGCMJADBFFC> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x7FBB1F0", Offset = "0x7FBA5F0", VA = "0x187FBB1F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x7FC0C40", Offset = "0x7FC0040", VA = "0x187FC0C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private struct BLHHBGNGLHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public DBHDIGKMJJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private PEPIFLGHCHM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <disconnectTimerScope>5__3;

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
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x7FC9960", Offset = "0x7FC8D60", VA = "0x187FC9960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x7FCA3C0", Offset = "0x7FC97C0", VA = "0x187FCA3C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct JCJMPIAIAHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public DBHDIGKMJJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private NPIEGGOELNH <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x7FD4850", Offset = "0x7FD3C50", VA = "0x187FD4850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x7FD4CE0", Offset = "0x7FD40E0", VA = "0x187FD4CE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private struct EOCCOIEMIJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public AsyncTaskMethodBuilder<Matchmaking.NDHKEMAFIBA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public MEMBODLLNEP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public DBHDIGKMJJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private TaskAwaiter<Matchmaking.NDHKEMAFIBA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x7FCEF70", Offset = "0x7FCE370", VA = "0x187FCEF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x7FCF450", Offset = "0x7FCE850", VA = "0x187FCF450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private struct PMPNFKGHNHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public Matchmaking.NDHKEMAFIBA serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public DBHDIGKMJJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public BFOAALAPEEN joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private PEPIFLGHCHM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private TaskAwaiter<DBOGEOGKNMN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x7FE5230", Offset = "0x7FE4630", VA = "0x187FE5230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x7FE5870", Offset = "0x7FE4C70", VA = "0x187FE5870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class IBBDIGLKGON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public MEMBODLLNEP targetInstance;

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
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public IBBDIGLKGON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2C10", Offset = "0x7FD2010", VA = "0x187FD2C10")]
		internal object GANHPGEMNHD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2B10", Offset = "0x7FD1F10", VA = "0x187FD2B10")]
		internal string EEPOFNHBOGK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private struct BEILFDJIDOC : IAsyncStateMachine
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
		public MEMBODLLNEP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public DBHDIGKMJJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private IBBDIGLKGON <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private PEPIFLGHCHM <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0x7FC8470", Offset = "0x7FC7870", VA = "0x187FC8470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x7FC9000", Offset = "0x7FC8400", VA = "0x187FC9000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct KKNLDGAKFED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public DBHDIGKMJJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public BFOAALAPEEN joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public JGCMJADBFFC initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public MEMBODLLNEP targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public MIHMEPLBLHG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x7FD8840", Offset = "0x7FD7C40", VA = "0x187FD8840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9030", Offset = "0x7FD8430", VA = "0x187FD9030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct KLKMMBDHABA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public DBHDIGKMJJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private PEPIFLGHCHM <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <>7__wrap3;

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
		private PEPIFLGHCHM <>7__wrap5;

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
		[Cpp2IlInjected.Address(RVA = "0x7FD9090", Offset = "0x7FD8490", VA = "0x187FD9090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x7FDA870", Offset = "0x7FD9C70", VA = "0x187FDA870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct CLHKINEELAF : IAsyncStateMachine
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
		public HJMLLMJGAOM localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public DBHDIGKMJJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private PEPIFLGHCHM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private TaskAwaiter<BAOOEPCCKJO> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x7FCC290", Offset = "0x7FCB690", VA = "0x187FCC290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x7FCCA90", Offset = "0x7FCBE90", VA = "0x187FCCA90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class CBPFLLOLGDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public MEMBODLLNEP targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public CBPFLLOLGDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x7FCAD90", Offset = "0x7FCA190", VA = "0x187FCAD90")]
		internal object HPNCBDENLAF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class NMPNHHMDHOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public NMPNHHMDHOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0A20", Offset = "0x7FDFE20", VA = "0x187FE0A20")]
		internal void KJOEBLOAOCI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class FMGDBFCOICI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public MEMBODLLNEP targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public FMGDBFCOICI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x7FD0710", Offset = "0x7FCFB10", VA = "0x187FD0710")]
		internal object CDGOKENJJNA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class BEPBIEHPEMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public MEMBODLLNEP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public BEPBIEHPEMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x7FC9060", Offset = "0x7FC8460", VA = "0x187FC9060")]
		internal string PBDEGJLFEKJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static readonly ABDDJEPKCOD JEBGKKICGFH;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static readonly ABDDJEPKCOD NHOOMFALAGG;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly ABDDJEPKCOD CJBFHFOBECH;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly string EFIFCINMKIJ;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private static readonly string IJMEBPPGDHE;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private static readonly string LFIDHIHKLOC;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public static readonly Guid EHEMBMKEKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private DFOPGDIDDDM AMGKGNHPMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private GJAODIKIHGJ OHOCPKNEMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private OAHJJJNDMGJ AAHFLKJGFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private GGAFKPAJMJF NNEBHMDLFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private IFFMIKJIEPF MFCHJJKNFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private PDIKACNCFIO DPHDNAKPIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private BIOLGOHEHIG AIIKHBBLNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private PPPKKCAALIA PLEEBMIEBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private OACPOPIIAFF ACGDIJMHPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private NDHBCEMPGLA OPPHNMJGLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private IDisposable LLOKKPKJAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private PMAHOPLKPFE ONKIFNKOIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private readonly NIOICMFLLAK DHBACBJNGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private NFFKPCPKHGN ALPAEPLMJFG;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public TaskStatus CKPNCEPDOMH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x9B9020", Offset = "0x9B8420", VA = "0x1809B9020", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x11DB1A0", Offset = "0x11DA5A0", VA = "0x1811DB1A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private OAJMAHCOGME MJEJCKIGNCH
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x7FAC6A0", Offset = "0x7FABAA0", VA = "0x187FAC6A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x7FACA70", Offset = "0x7FABE70", VA = "0x187FACA70", Slot = "6")]
	public void MBHBIOMKKEG(GGAFKPAJMJF NNEBHMDLFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x7FABCE0", Offset = "0x7FAB0E0", VA = "0x187FABCE0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7FAAEF0", Offset = "0x7FAA2F0", VA = "0x187FAAEF0", Slot = "5")]
	[AsyncStateMachine(typeof(HDJFNMFAJMN))]
	public Task AOPLIIMJOLI(MEMBODLLNEP NDIAONIIAAM, CMOOMNHMMEN CPFAIKOKJAE, CancellationToken LDLCOIFGBGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x7FAC0D0", Offset = "0x7FAB4D0", VA = "0x187FAC0D0")]
	[AsyncStateMachine(typeof(IMANDEGNLLM))]
	private Task GIADHLGOFEC(MEMBODLLNEP NDIAONIIAAM, CMOOMNHMMEN CPFAIKOKJAE, CancellationToken LDLCOIFGBGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x7FAB810", Offset = "0x7FAAC10", VA = "0x187FAB810")]
	private void CNPMJNOBPOG(OACPOPIIAFF ACGDIJMHPEF, MEMBODLLNEP NDIAONIIAAM, Exception GEEGJFAONEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x7FADB90", Offset = "0x7FACF90", VA = "0x187FADB90")]
	private static void PJJHDKLBJLF(BPJJMHKIAII BCDOICDMKCF, Exception GEEGJFAONEJ, [Optional] List<int> LAHAJHOFGEI, int HMNHJHBFMPO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x7FABD30", Offset = "0x7FAB130", VA = "0x187FABD30")]
	[AsyncStateMachine(typeof(MILEGNIEGEC))]
	private Task EOBBCHNFDMC(HOEFFPEDKPI<string>.AEKMEBIOPMA AOBIHHLEODI, MEMBODLLNEP NDIAONIIAAM, CMOOMNHMMEN CPFAIKOKJAE, BFOAALAPEEN OMGHLPAJHNN, CancellationToken LDLCOIFGBGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x7FAC220", Offset = "0x7FAB620", VA = "0x187FAC220")]
	private void HJGCINOIDGH([CallerMemberName] string KOJEKCFNEIM = "<unknown>")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x7FACDA0", Offset = "0x7FAC1A0", VA = "0x187FACDA0")]
	[AsyncStateMachine(typeof(BLHHBGNGLHD))]
	private Task MECNKDEHIKL(HOEFFPEDKPI<string>.AEKMEBIOPMA AOBIHHLEODI, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x7FAD030", Offset = "0x7FAC430", VA = "0x187FAD030")]
	private void NNJFLPAMDLI(MEMBODLLNEP NDIAONIIAAM, CancellationToken LDLCOIFGBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x7FAD360", Offset = "0x7FAC760", VA = "0x187FAD360")]
	private void OAAMLILMPPE(MEMBODLLNEP NDIAONIIAAM, TaskStatus JAJGMGIDHPL, string EIGJGBPHOMK, BFOAALAPEEN OMGHLPAJHNN, Exception JBOPLLAHGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7FAB1E0", Offset = "0x7FAA5E0", VA = "0x187FAB1E0")]
	private void BIDNDAKMOPP(MEMBODLLNEP NDIAONIIAAM, BFOAALAPEEN OMGHLPAJHNN, OperationCanceledException IBHHHIFDDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7FAE3D0", Offset = "0x7FAD7D0", VA = "0x187FAE3D0")]
	private void POKMNJFMMIM(MEMBODLLNEP NDIAONIIAAM, BFOAALAPEEN OMGHLPAJHNN, Exception GEEGJFAONEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x7FAB350", Offset = "0x7FAA750", VA = "0x187FAB350")]
	private void CHAJNGJOLAL(MEMBODLLNEP NDIAONIIAAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x7FAD730", Offset = "0x7FACB30", VA = "0x187FAD730")]
	private static KDMPGIPNGGP OMNBOOMKGAC(MEMBODLLNEP NDIAONIIAAM)
	{
		return default(KDMPGIPNGGP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x7FAC3A0", Offset = "0x7FAB7A0", VA = "0x187FAC3A0")]
	[AsyncStateMachine(typeof(JCJMPIAIAHK))]
	private Task HKPLLDCDDHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x7FACED0", Offset = "0x7FAC2D0", VA = "0x187FACED0")]
	[AsyncStateMachine(typeof(EOCCOIEMIJJ))]
	private Task<Matchmaking.NDHKEMAFIBA> MNCBFCMOMPL(MEMBODLLNEP NDIAONIIAAM, HOEFFPEDKPI<string>.AEKMEBIOPMA AOBIHHLEODI, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x7FADA80", Offset = "0x7FACE80", VA = "0x187FADA80")]
	private static DBOGEOGKNMN PHKPJFJDDHE(Matchmaking.NDHKEMAFIBA EBGMCMAMJBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x7FAC810", Offset = "0x7FABC10", VA = "0x187FAC810")]
	[AsyncStateMachine(typeof(PMPNFKGHNHE))]
	private Task KAPHKCGALNE(Matchmaking.NDHKEMAFIBA EBGMCMAMJBA, BFOAALAPEEN OMGHLPAJHNN, HOEFFPEDKPI<string>.AEKMEBIOPMA AOBIHHLEODI, CancellationToken CAPKGEJBGJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x7FAADB0", Offset = "0x7FAA1B0", VA = "0x187FAADB0")]
	[AsyncStateMachine(typeof(BEILFDJIDOC))]
	private Task AAJFIEMONNA(MEMBODLLNEP NDIAONIIAAM, CancellationTokenSource HBGCLNDGPGA, Task FNEGBAPMOJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x7FAD5C0", Offset = "0x7FAC9C0", VA = "0x187FAD5C0")]
	[AsyncStateMachine(typeof(KKNLDGAKFED))]
	private Task OIKEDHLDGOJ(JGCMJADBFFC CEKINONAFIE, MIHMEPLBLHG MJMGCDGPNJD, MEMBODLLNEP BPANNAAMDGI, BFOAALAPEEN KBFHLCLBMHI, HOEFFPEDKPI<string>.AEKMEBIOPMA AOBIHHLEODI, CancellationToken PPEBPKDNEFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x7FAD790", Offset = "0x7FACB90", VA = "0x187FAD790")]
	private BFOAALAPEEN PBFKHDKGFMI(BFOAALAPEEN KBFHLCLBMHI, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x7FAC500", Offset = "0x7FAB900", VA = "0x187FAC500")]
	[AsyncStateMachine(typeof(KLKMMBDHABA))]
	private Task ICHNKLCPMAP(HOEFFPEDKPI<string>.AEKMEBIOPMA AOBIHHLEODI, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x7FAB560", Offset = "0x7FAA960", VA = "0x187FAB560")]
	[AsyncStateMachine(typeof(CLHKINEELAF))]
	private Task CHGDANGMPOP(CancellationToken BLABAMPAGAH, int PDNIHCHMOIK, HJMLLMJGAOM GOCEFJMNFLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x7FAB690", Offset = "0x7FAAA90", VA = "0x187FAB690")]
	private static void CNNHOGHHKHH(MEMBODLLNEP NDIAONIIAAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x7FABE90", Offset = "0x7FAB290", VA = "0x187FABE90")]
	private void FLLIJOGLLNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x7FAC470", Offset = "0x7FAB870", VA = "0x187FAC470")]
	private void IAFANGLPGEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x7FAC6F0", Offset = "0x7FABAF0", VA = "0x187FAC6F0")]
	private void IOPENFLHIHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x7FAC780", Offset = "0x7FABB80", VA = "0x187FAC780")]
	private void JENDNJIDHJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x7FAB260", Offset = "0x7FAA660", VA = "0x187FAB260")]
	private static void CCJCLGMCACE(MEMBODLLNEP NDIAONIIAAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x7FAC960", Offset = "0x7FABD60", VA = "0x187FAC960")]
	private static CancellationTokenRegistration LOGJFDJJPBA(MEMBODLLNEP NDIAONIIAAM, CancellationToken CAPKGEJBGJB)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x7FAD980", Offset = "0x7FACD80", VA = "0x187FAD980")]
	private static void PGLLANCOGDC(MEMBODLLNEP NDIAONIIAAM, Exception GEEGJFAONEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x7FAB030", Offset = "0x7FAA430", VA = "0x187FAB030")]
	private void APCIHAFPDEA(MEMBODLLNEP NDIAONIIAAM, Task FNEGBAPMOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x7FABC80", Offset = "0x7FAB080", VA = "0x187FABC80")]
	private static void DLBCFJLNCHA(Func<string> JKMIMMPCKOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x7FAE650", Offset = "0x7FADA50", VA = "0x187FAE650")]
	public DBHDIGKMJJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x7FAC640", Offset = "0x7FABA40", VA = "0x187FAC640")]
	[CompilerGenerated]
	internal static (int, int?) ICPBJPMKKOG(JEEOHFCIHID BGDJGAKNCHF)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[RecRoom.NoEngine.Common.Preserve]
internal class IIGIJAKMFFB : OHBPDLMECML, ECNGEIBHFNE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private struct GPJOPGFPBJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public IIGIJAKMFFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public HJMLLMJGAOM localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x7FD1CB0", Offset = "0x7FD10B0", VA = "0x187FD1CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2190", Offset = "0x7FD1590", VA = "0x187FD2190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class GEIPHGGEDCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public IIGIJAKMFFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public HJMLLMJGAOM localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public GEIPHGGEDCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x7FD1820", Offset = "0x7FD0C20", VA = "0x187FD1820")]
		internal List<Task> NEFJFEHHLPI(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct BLNDAJLMDNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public DIOKMOOEKFM taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public HJMLLMJGAOM localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private PEPIFLGHCHM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x7FCA420", Offset = "0x7FC9820", VA = "0x187FCA420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x7FCA7C0", Offset = "0x7FC9BC0", VA = "0x187FCA7C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct GIBOEJHLAND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public IIGIJAKMFFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x7FD18C0", Offset = "0x7FD0CC0", VA = "0x187FD18C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x7FD1BA0", Offset = "0x7FD0FA0", VA = "0x187FD1BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private readonly HashSet<DIOKMOOEKFM> GJANIEOHPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private GJAODIKIHGJ OHOCPKNEMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private GGAFKPAJMJF NNEBHMDLFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private PNCKNIPBJFF BOLNCCDLOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private DJEMIOHALLK FCKBBFPDPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private IDisposable LLOKKPKJAGE;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x7FD34D0", Offset = "0x7FD28D0", VA = "0x187FD34D0", Slot = "5")]
	public void MBHBIOMKKEG(GGAFKPAJMJF NNEBHMDLFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x7FD2DE0", Offset = "0x7FD21E0", VA = "0x187FD2DE0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3B20", Offset = "0x7FD2F20", VA = "0x187FD3B20", Slot = "4")]
	public bool NLNFHFOODOC(DIOKMOOEKFM BDOPBPGMGIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x7FD2D10", Offset = "0x7FD2110", VA = "0x187FD2D10")]
	private void ABHAAKLLKCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3830", Offset = "0x7FD2C30", VA = "0x187FD3830")]
	private void NAPKNKJAACK(CFLKKNKAIAK BDAPIDPALOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x7FD2F10", Offset = "0x7FD2310", VA = "0x187FD2F10")]
	[AsyncStateMachine(typeof(GPJOPGFPBJO))]
	private Task IPKNAAKMJAJ(int PDNIHCHMOIK, HJMLLMJGAOM GOCEFJMNFLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x7FD2E40", Offset = "0x7FD2240", VA = "0x187FD2E40")]
	private Func<CancellationToken, List<Task>> FGEEIGNNAPA(int PDNIHCHMOIK, HJMLLMJGAOM GOCEFJMNFLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3000", Offset = "0x7FD2400", VA = "0x187FD3000")]
	private List<Task> LADFIAGDPEB(int PDNIHCHMOIK, HJMLLMJGAOM GOCEFJMNFLE, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3B80", Offset = "0x7FD2F80", VA = "0x187FD3B80")]
	[AsyncStateMachine(typeof(BLNDAJLMDNI))]
	private Task PCPJIDCHJHH(DIOKMOOEKFM JENKLPHLLJG, CancellationToken HEJFDMJNIGB, int PDNIHCHMOIK, HJMLLMJGAOM GOCEFJMNFLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3A50", Offset = "0x7FD2E50", VA = "0x187FD3A50")]
	[AsyncStateMachine(typeof(GIBOEJHLAND))]
	private Task NGNCKODCJMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x7FD37B0", Offset = "0x7FD2BB0", VA = "0x187FD37B0")]
	private void MDEFFPJLFDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3CA0", Offset = "0x7FD30A0", VA = "0x187FD3CA0")]
	public IIGIJAKMFFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[UnityEngine.Scripting.Preserve]
internal sealed class CEBOFCNNOJD : KONPINNDDMD, ECNGEIBHFNE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class EFFHJLKGCGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public EFFHJLKGCGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x7FCDB00", Offset = "0x7FCCF00", VA = "0x187FCDB00")]
		internal object LGMEGCDLABB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class MOBDNAGGEMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public MOBDNAGGEMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x7FDF400", Offset = "0x7FDE800", VA = "0x187FDF400")]
		internal object BFIHBKBBMKG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class OJPFANDBINK
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public OJPFANDBINK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class MCHMIKCFICE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public MCHMIKCFICE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x7FDD990", Offset = "0x7FDCD90", VA = "0x187FDD990")]
		internal object PAIDBLBINFL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class HBPGADMLOPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public HBPGADMLOPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x7FD21F0", Offset = "0x7FD15F0", VA = "0x187FD21F0")]
		internal object FNDLGDNMHNF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private readonly Dictionary<Guid, LDFLJPKKCPG> INFNJGOHAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private readonly TimeSpan PDHINNHNPGH;

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "9")]
	public void MBHBIOMKKEG(GGAFKPAJMJF NNEBHMDLFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x7FCB980", Offset = "0x7FCAD80", VA = "0x187FCB980", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x7FCBFB0", Offset = "0x7FCB3B0", VA = "0x187FCBFB0", Slot = "4")]
	public KHBHCLPOBBI LLICHLCEEGA(Guid NPMNDEDHHIJ)
	{
		return default(KHBHCLPOBBI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x7FCB990", Offset = "0x7FCAD90", VA = "0x187FCB990", Slot = "5")]
	public bool FBDLIPAFCGJ(Guid NPMNDEDHHIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x7FCB650", Offset = "0x7FCAA50", VA = "0x187FCB650", Slot = "6")]
	public bool APBIGAMLLHF(Guid NPMNDEDHHIJ, Task FKDKDOOLECK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x7FCBBA0", Offset = "0x7FCAFA0", VA = "0x187FCBBA0", Slot = "7")]
	public bool GFMBLLIODCB(Guid NPMNDEDHHIJ, BAOOEPCCKJO LIPHIBKLFND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x7FCB5E0", Offset = "0x7FCA9E0", VA = "0x187FCB5E0", Slot = "8")]
	public Task<(BAOOEPCCKJO, Task)> AHPBOKCNNDI(Guid NPMNDEDHHIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x7FCBD80", Offset = "0x7FCB180", VA = "0x187FCBD80")]
	private void JJAIFDLEEMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x7FCC1D0", Offset = "0x7FCB5D0", VA = "0x187FCC1D0")]
	public CEBOFCNNOJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[RecRoom.NoEngine.Common.Preserve]
internal class MGHGKELEDBH : JGJDODCEDJJ, ECNGEIBHFNE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	private class CNPJFIPNGEA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private readonly MEMBODLLNEP IKLADMLGKHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private readonly CancellationTokenSource CGAKGMDNBAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public readonly CancellationToken OCLINABENBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private bool IFGPOIFOHAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private bool AOPCOJBCAIK;

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x7FCD250", Offset = "0x7FCC650", VA = "0x187FCD250")]
		public CNPJFIPNGEA(MEMBODLLNEP IKLADMLGKHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x7FCD100", Offset = "0x7FCC500", VA = "0x187FCD100")]
		public void MDEFFPJLFDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x7FCD0D0", Offset = "0x7FCC4D0", VA = "0x187FCD0D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class DDMMCGLBIAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public OIALOHMOJIF disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public DDMMCGLBIAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x7FCD360", Offset = "0x7FCC760", VA = "0x187FCD360")]
		internal object NNMPMPFDOEC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private struct FCKDJDLIIBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public OIALOHMOJIF disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public MGHGKELEDBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private PEPIFLGHCHM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x7FCFC00", Offset = "0x7FCF000", VA = "0x187FCFC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x7FD0050", Offset = "0x7FCF450", VA = "0x187FD0050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class NJOJICPGDAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public MGHGKELEDBH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public NJOJICPGDAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x7FDFDF0", Offset = "0x7FDF1F0", VA = "0x187FDFDF0")]
		internal object ABCJFPIFJNE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class MMBLHJPOGGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public MEMBODLLNEP newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public NJOJICPGDAM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public MMBLHJPOGGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x7FDF340", Offset = "0x7FDE740", VA = "0x187FDF340")]
		internal object LKEBFJHEJFI((MEMBODLLNEP lastLocalPlayerRoomInstance, MEMBODLLNEP newRoomInstance, PDIKACNCFIO fallbacks) x)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct LMIJHACAHFI : IAsyncStateMachine
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
		public MGHGKELEDBH <>4__this;

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
		private PEPIFLGHCHM <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x7FDBC80", Offset = "0x7FDB080", VA = "0x187FDBC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x9E0290", Offset = "0x9DF690", VA = "0x1809E0290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class NOGCKIFDNLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public MEMBODLLNEP newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public NOGCKIFDNLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0BC0", Offset = "0x7FDFFC0", VA = "0x187FE0BC0")]
		internal object PNLCJNFPDMK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0B00", Offset = "0x7FDFF00", VA = "0x187FE0B00")]
		internal void ENMDDJEKGJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0AC0", Offset = "0x7FDFEC0", VA = "0x187FE0AC0")]
		internal object EGGPDEKKJGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0B80", Offset = "0x7FDFF80", VA = "0x187FE0B80")]
		internal object HFOJGLMLPHD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct KKAIGMNKKEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public MEMBODLLNEP newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public MGHGKELEDBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public CMOOMNHMMEN customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private NOGCKIFDNLH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private PEPIFLGHCHM <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0x7FD7820", Offset = "0x7FD6C20", VA = "0x187FD7820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x7FD87E0", Offset = "0x7FD7BE0", VA = "0x187FD87E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private static readonly IBLPGBNIDJE.CGGGKLEECOM OBPDFKNEHPF;

	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private static readonly DGNCBDKCJKH JOFMBGHPKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private GJAODIKIHGJ OHOCPKNEMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private GGAFKPAJMJF NNEBHMDLFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private PDIKACNCFIO DPHDNAKPIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private IFFMIKJIEPF MFCHJJKNFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private ECMFINOGIEN EOPBDJJHJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private HFLJMAPFFOH BJFGOAGLAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private MEMBODLLNEP MMMMEBDFHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private CNPJFIPNGEA MBOCMMPMMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private bool IIGMBPJMBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private Task INHNHEAIFHD;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private OAJMAHCOGME MJEJCKIGNCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x7FDE590", Offset = "0x7FDD990", VA = "0x187FDE590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool EIMJJPOCKID
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xBACB90", Offset = "0xBABF90", VA = "0x180BACB90")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x7FDEAE0", Offset = "0x7FDDEE0", VA = "0x187FDEAE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE770", Offset = "0x7FDDB70", VA = "0x187FDE770", Slot = "4")]
	public void MBHBIOMKKEG(GGAFKPAJMJF NNEBHMDLFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE160", Offset = "0x7FDD560", VA = "0x187FDE160", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE070", Offset = "0x7FDD470", VA = "0x187FDE070")]
	[AsyncStateMachine(typeof(FCKDJDLIIBD))]
	private Task AMBOMPBFEGB(OIALOHMOJIF GGKMBKFMGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE400", Offset = "0x7FDD800", VA = "0x187FDE400")]
	private void HFBHNHMAMJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE5E0", Offset = "0x7FDD9E0", VA = "0x187FDE5E0")]
	private void JPHHGEFLBFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x7FDDEF0", Offset = "0x7FDD2F0", VA = "0x187FDDEF0")]
	private void AFALAACAFEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x7FDEC40", Offset = "0x7FDE040", VA = "0x187FDEC40")]
	private bool ODJFHENODJO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x7FDEA10", Offset = "0x7FDDE10", VA = "0x187FDEA10")]
	[AsyncStateMachine(typeof(LMIJHACAHFI))]
	private void MLHMPMOFNMJ(int EJFMLPKGCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x7FDECB0", Offset = "0x7FDE0B0", VA = "0x187FDECB0")]
	private void OGBABCOCMPF([Out] IDisposable MECMANLGDHO, [Out] IDisposable PGCFMIIPHND, [Out] IDisposable JPJBBLELOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x7FDEAF0", Offset = "0x7FDDEF0", VA = "0x187FDEAF0")]
	private bool NNEJBEHFCGI(MEMBODLLNEP IKLADMLGKHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7FDEBF0", Offset = "0x7FDDFF0", VA = "0x187FDEBF0")]
	private void NPMMGLFHKGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE2D0", Offset = "0x7FDD6D0", VA = "0x187FDE2D0")]
	[AsyncStateMachine(typeof(KKAIGMNKKEA))]
	private Task GIADHLGOFEC(MEMBODLLNEP IKLADMLGKHJ, CMOOMNHMMEN CPFAIKOKJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x7FDF2D0", Offset = "0x7FDE6D0", VA = "0x187FDF2D0")]
	public MGHGKELEDBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[UnityEngine.Scripting.Preserve]
internal sealed class LHAAJJKPLFI : PABLCMOOJMJ, ECNGEIBHFNE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct KBADELFCPPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public AsyncTaskMethodBuilder<HAMDHMOMGFH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public LHAAJJKPLFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private TaskAwaiter<HAMDHMOMGFH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x7FD65E0", Offset = "0x7FD59E0", VA = "0x187FD65E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x7FD6870", Offset = "0x7FD5C70", VA = "0x187FD6870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private sealed class ALLBAGPHGAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public KOEDLEGFKIO message;

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public ALLBAGPHGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x7FC8210", Offset = "0x7FC7610", VA = "0x187FC8210")]
		internal object BPGACHIDABM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class GHABMOGCGGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public KOEDLEGFKIO messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public GHABMOGCGGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x7FD1860", Offset = "0x7FD0C60", VA = "0x187FD1860")]
		internal object CCAMBFMMJPH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class NGMCBELHOLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public KOEDLEGFKIO request;

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public NGMCBELHOLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x7FDFD90", Offset = "0x7FDF190", VA = "0x187FDFD90")]
		internal object IOPNDBBLCFI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private struct MPGDBGGIOBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public KOEDLEGFKIO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public LHAAJJKPLFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private PEPIFLGHCHM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private TaskAwaiter<IMFDIOOAAIF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x7FDF460", Offset = "0x7FDE860", VA = "0x187FDF460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x7FDFD30", Offset = "0x7FDF130", VA = "0x187FDFD30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class KEGGBKAPGCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public KOEDLEGFKIO operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public KEGGBKAPGCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x7FD7080", Offset = "0x7FD6480", VA = "0x187FD7080")]
		internal object GJKBHPPGHMP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct JMBFHAFHOOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public KOEDLEGFKIO operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public LHAAJJKPLFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private PEPIFLGHCHM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private BFOAALAPEEN <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private TaskAwaiter<KOEDLEGFKIO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x7FD5A10", Offset = "0x7FD4E10", VA = "0x187FD5A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x7FD6580", Offset = "0x7FD5980", VA = "0x187FD6580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct PAAGCHGJAHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public AsyncTaskMethodBuilder<IMFDIOOAAIF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public LHAAJJKPLFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public KOEDLEGFKIO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private MCGGNIPFKPG.BIFBLIALFPK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private BFOAALAPEEN <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private TaskAwaiter<KOEDLEGFKIO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x7FE3D00", Offset = "0x7FE3100", VA = "0x187FE3D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4230", Offset = "0x7FE3630", VA = "0x187FE4230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class GCOEHMLFEGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public IMFDIOOAAIF operation;

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public GCOEHMLFEGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x7FD17A0", Offset = "0x7FD0BA0", VA = "0x187FD17A0")]
		internal object AFMINDCHBPH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct HGPPEACKPLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public IMFDIOOAAIF operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public LHAAJJKPLFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private PEPIFLGHCHM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private HOEFFPEDKPI<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2470", Offset = "0x7FD1870", VA = "0x187FD2470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2AB0", Offset = "0x7FD1EB0", VA = "0x187FD2AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class BHFLOHIAINI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public KOEDLEGFKIO request;

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public BHFLOHIAINI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x7FC9900", Offset = "0x7FC8D00", VA = "0x187FC9900")]
		internal object GBKKDAGAHIF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class DOEKPAJMBCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public KOEDLEGFKIO request;

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public DOEKPAJMBCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x7FCDAA0", Offset = "0x7FCCEA0", VA = "0x187FCDAA0")]
		internal object NDLPADCFBOJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	private GGAFKPAJMJF NNEBHMDLFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private BIOLGOHEHIG AIIKHBBLNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private FEEAKBALFLE BNDNNJMAACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private HBCHHOMPPDH GMPBMLNBNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private OAHJJJNDMGJ AAHFLKJGFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	private TaskCompletionSource<HAMDHMOMGFH> FKNODBCDFNM;

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB8D0", Offset = "0x7FDACD0", VA = "0x187FDB8D0", Slot = "7")]
	public void MBHBIOMKKEG(GGAFKPAJMJF NNEBHMDLFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB9C0", Offset = "0x7FDADC0", VA = "0x187FDB9C0", Slot = "6")]
	[AsyncStateMachine(typeof(KBADELFCPPB))]
	public Task<HAMDHMOMGFH> OHEPPAEIDFM(CancellationToken GCPMGDAEHFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x7FDAD80", Offset = "0x7FDA180", VA = "0x187FDAD80", Slot = "4")]
	public void DPNOHGDBOFA(KOEDLEGFKIO EIGJGBPHOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x7FDA8D0", Offset = "0x7FD9CD0", VA = "0x187FDA8D0", Slot = "5")]
	public void BKJNBKFJKJO(KOEDLEGFKIO OFCJIKOMPJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB7C0", Offset = "0x7FDABC0", VA = "0x187FDB7C0")]
	[AsyncStateMachine(typeof(MPGDBGGIOBD))]
	private Task LEHEIIBEOJD(KOEDLEGFKIO INLHACAOAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB110", Offset = "0x7FDA510", VA = "0x187FDB110")]
	[AsyncStateMachine(typeof(JMBFHAFHOOO))]
	private Task HFPODAGBDGP(KOEDLEGFKIO KNNBEPBKFKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x7FDAC30", Offset = "0x7FDA030", VA = "0x187FDAC30")]
	[AsyncStateMachine(typeof(PAAGCHGJAHL))]
	private Task<IMFDIOOAAIF> CFJMHEIHHPF(KOEDLEGFKIO INLHACAOAMD, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x7FDBBF0", Offset = "0x7FDAFF0", VA = "0x187FDBBF0")]
	private BFOAALAPEEN PDDGNHMEKGI(KOEDLEGFKIO EKKCFNIJCDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x7FDBAD0", Offset = "0x7FDAED0", VA = "0x187FDBAD0")]
	[AsyncStateMachine(typeof(HGPPEACKPLO))]
	private Task OIDGOHKPJJB(IMFDIOOAAIF MEOMIMDGMJF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB5B0", Offset = "0x7FDA9B0", VA = "0x187FDB5B0")]
	private IMFDIOOAAIF KDDFOIJHOHO(KOEDLEGFKIO INLHACAOAMD, BFOAALAPEEN LFDLABBBODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x36BD4B0", Offset = "0x36BC8B0", VA = "0x1836BD4B0")]
	private T LBGGHOIOPJM<T>(T FIIKLGCIAGG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB220", Offset = "0x7FDA620", VA = "0x187FDB220")]
	private IMFDIOOAAIF JKHKLFAJKLD(KOEDLEGFKIO INLHACAOAMD, BFOAALAPEEN LFDLABBBODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public LHAAJJKPLFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[UnityEngine.Scripting.Preserve]
internal sealed class ODIOPBBDHCP : FEEAKBALFLE, ECNGEIBHFNE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private sealed class ONINJFNFFOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public ONINJFNFFOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x7FE3B90", Offset = "0x7FE2F90", VA = "0x187FE3B90")]
		internal object EHHCBPGIJHB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class DNKMLJKKKBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public DNKMLJKKKBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x7FCDA30", Offset = "0x7FCCE30", VA = "0x187FCDA30")]
		internal object NLLICJEOOPD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	private OAHJJJNDMGJ AAHFLKJGFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	private KPKAECBKNJI KEJLMDCJCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	private PABLCMOOJMJ NBHIAEJAPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	private KONPINNDDMD INFNJGOHAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	private JNINLOJJHPN KJFELDIBKKG;

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x7FE37A0", Offset = "0x7FE2BA0", VA = "0x187FE37A0", Slot = "6")]
	public void MBHBIOMKKEG(GGAFKPAJMJF NNEBHMDLFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2110", Offset = "0x7FE1510", VA = "0x187FE2110", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x7FE21C0", Offset = "0x7FE15C0", VA = "0x187FE21C0", Slot = "4")]
	public KHBHCLPOBBI ENOCFLOMDGM(KOEDLEGFKIO HOIEIPLDPOP)
	{
		return default(KHBHCLPOBBI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1F00", Offset = "0x7FE1300", VA = "0x187FE1F00", Slot = "5")]
	public void BMIMLDJKLFC(Guid NPMNDEDHHIJ, Task FKDKDOOLECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x7FE3220", Offset = "0x7FE2620", VA = "0x187FE3220")]
	private void GKONLHHJMCC(byte MKLGKNFOABE, int LEKKPMMKFMI, object DJNCOFJJAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2AA0", Offset = "0x7FE1EA0", VA = "0x187FE2AA0")]
	private void GHPDMFHNDCE(DJFJBEOCGCC JNDPCNNCNMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x7FE25E0", Offset = "0x7FE19E0", VA = "0x187FE25E0")]
	private void FDCNPKLMGIK(DJFJBEOCGCC JNDPCNNCNMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x7FE2860", Offset = "0x7FE1C60", VA = "0x187FE2860")]
	private void GADKBFDIHIP(DJFJBEOCGCC JNDPCNNCNMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x7FE3500", Offset = "0x7FE2900", VA = "0x187FE3500")]
	private BAOOEPCCKJO HOPEDMOFJGE(KOEDLEGFKIO EKKCFNIJCDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x7FE3020", Offset = "0x7FE2420", VA = "0x187FE3020")]
	private void GIEKOBNBMHC(KOEDLEGFKIO KNNBEPBKFKD, BAOOEPCCKJO LIPHIBKLFND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x7FE1D20", Offset = "0x7FE1120", VA = "0x187FE1D20")]
	private bool ACGPBLKHAOO(KOEDLEGFKIO KNNBEPBKFKD, BAOOEPCCKJO LIPHIBKLFND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x7FE32F0", Offset = "0x7FE26F0", VA = "0x187FE32F0")]
	private bool HIEIIEAJLFA(KOEDLEGFKIO HHIMPBPFEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x7FE3910", Offset = "0x7FE2D10", VA = "0x187FE3910")]
	private bool OFDPHMLCLLD(byte MKLGKNFOABE, ExitGames.Client.Photon.Hashtable JNDPCNNCNMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public ODIOPBBDHCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[UnityEngine.Scripting.Preserve]
internal sealed class MDGHFJJBJLK : IOOPIIJMGEA, ECNGEIBHFNE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private sealed class HDLMAOANNHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public HAMDHMOMGFH operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public MDGHFJJBJLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public KOEDLEGFKIO roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public HDLMAOANNHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2250", Offset = "0x7FD1650", VA = "0x187FD2250")]
		internal object FFGBLFHPODB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x7FD22C0", Offset = "0x7FD16C0", VA = "0x187FD22C0")]
		internal object HEGNBBBOBKF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct PBJBCAOFCCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public AsyncTaskMethodBuilder<BAOOEPCCKJO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public MDGHFJJBJLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public KOEDLEGFKIO roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private PEPIFLGHCHM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private TaskAwaiter<BAOOEPCCKJO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x7FE42A0", Offset = "0x7FE36A0", VA = "0x187FE42A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4940", Offset = "0x7FE3D40", VA = "0x187FE4940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class PJPLLELMFHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public HAMDHMOMGFH operationType;

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public PJPLLELMFHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x7FE5160", Offset = "0x7FE4560", VA = "0x187FE5160")]
		internal object LGMADFJOJPI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class PDIKKHBFOBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public KOEDLEGFKIO request;

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public PDIKKHBFOBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x7FE49B0", Offset = "0x7FE3DB0", VA = "0x187FE49B0")]
		internal object BCFJDKBBOCK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4A20", Offset = "0x7FE3E20", VA = "0x187FE4A20")]
		internal object IBAKGOEKAGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4A90", Offset = "0x7FE3E90", VA = "0x187FE4A90")]
		internal object OPGCIFNOCGM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct IIHCNMBJAFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public AsyncTaskMethodBuilder<BAOOEPCCKJO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public KOEDLEGFKIO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public MDGHFJJBJLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private PDIKKHBFOBE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private PEPIFLGHCHM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private KHBHCLPOBBI <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private BAOOEPCCKJO <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private TaskAwaiter<(BAOOEPCCKJO validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x7FD3D30", Offset = "0x7FD3130", VA = "0x187FD3D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x7FD4600", Offset = "0x7FD3A00", VA = "0x187FD4600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private OAHJJJNDMGJ AAHFLKJGFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private KPKAECBKNJI KEJLMDCJCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private FEEAKBALFLE BNDNNJMAACG;

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x7FDDE40", Offset = "0x7FDD240", VA = "0x187FDDE40", Slot = "5")]
	public void MBHBIOMKKEG(GGAFKPAJMJF NNEBHMDLFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x7FDDD20", Offset = "0x7FDD120", VA = "0x187FDDD20", Slot = "4")]
	[AsyncStateMachine(typeof(PBJBCAOFCCJ))]
	private Task<BAOOEPCCKJO> GJOPDCJIEFE(KOEDLEGFKIO EKKCFNIJCDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD9F0", Offset = "0x7FDCDF0", VA = "0x187FDD9F0")]
	private bool ADLNNAPHJFJ(HAMDHMOMGFH AKJDKCNBMBD, [Out] BAOOEPCCKJO KGODHHBLJOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x7FDDBE0", Offset = "0x7FDCFE0", VA = "0x187FDDBE0")]
	[AsyncStateMachine(typeof(IIHCNMBJAFK))]
	private Task<BAOOEPCCKJO> DKLPKKGNPEL(KOEDLEGFKIO INLHACAOAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public MDGHFJJBJLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class JHCKFHBPBMN : FCJIJIJJMOO, ECNGEIBHFNE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	private struct MMFLKMLHKEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public PGNIPJOEHNG JOCKPMEMAMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public long MCFFLDBILCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public Guid? LNBCNGJALAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public bool ALCBOMOOKKM;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct DJLOHOIMBNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public AsyncTaskMethodBuilder<JGCMJADBFFC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public MEMBODLLNEP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public JHCKFHBPBMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private TaskAwaiter<KDNGIJKMAJN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private TaskAwaiter<JGCMJADBFFC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x7FCD3F0", Offset = "0x7FCC7F0", VA = "0x187FCD3F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x7FCD9C0", Offset = "0x7FCCDC0", VA = "0x187FCD9C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private sealed class GNIKCBBOMDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public GNIKCBBOMDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x7FD1C00", Offset = "0x7FD1000", VA = "0x187FD1C00")]
		internal object LDDPOMFIDCG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct FKIIIDPNKPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public AsyncTaskMethodBuilder<KDNGIJKMAJN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public JHCKFHBPBMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public MEMBODLLNEP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private GNIKCBBOMDM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private TaskAwaiter<KDNGIJKMAJN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x7FD00B0", Offset = "0x7FCF4B0", VA = "0x187FD00B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x7FD06A0", Offset = "0x7FCFAA0", VA = "0x187FD06A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct CMPHBGGPPMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public AsyncTaskMethodBuilder<JGCMJADBFFC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public JHCKFHBPBMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public MEMBODLLNEP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public KDNGIJKMAJN roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private TaskAwaiter<MMFLKMLHKEE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x7FCCAF0", Offset = "0x7FCBEF0", VA = "0x187FCCAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x7FCD060", Offset = "0x7FCC460", VA = "0x187FCD060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private sealed class IPCBAKHDNIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public KDNGIJKMAJN roomDetailsDto;

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public IPCBAKHDNIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xD94850", Offset = "0xD93C50", VA = "0x180D94850")]
		internal bool CAKOHPIBONF(FEOHBPOKLEE sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x7FD4700", Offset = "0x7FD3B00", VA = "0x187FD4700")]
		internal object NHJKNGONOPJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x7FD4670", Offset = "0x7FD3A70", VA = "0x187FD4670")]
		internal object NAGJHJOLEFB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x7FD47C0", Offset = "0x7FD3BC0", VA = "0x187FD47C0")]
		internal object OPCICBCCHBK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class OOGJJEJMCDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public bool loadUsedCompatibility;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public IPCBAKHDNIJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public OOGJJEJMCDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x7FE3C00", Offset = "0x7FE3000", VA = "0x187FE3C00")]
		internal object ADIFKKPAGNH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private struct OBPIAMFBKDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public AsyncTaskMethodBuilder<MMFLKMLHKEE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public KDNGIJKMAJN roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public JHCKFHBPBMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public MEMBODLLNEP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		private OOGJJEJMCDP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private TaskAwaiter<MMFLKMLHKEE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private TaskAwaiter<KPNAPGNHCBJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0D10", Offset = "0x7FE0110", VA = "0x187FE0D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1CB0", Offset = "0x7FE10B0", VA = "0x187FE1CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private sealed class NPJEMPICKGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public NPJEMPICKGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x7FE0C60", Offset = "0x7FE0060", VA = "0x187FE0C60")]
		internal object BBLLDMGIJCP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private struct KHAIAMFIMLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public AsyncTaskMethodBuilder<MMFLKMLHKEE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public FEOHBPOKLEE subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public JHCKFHBPBMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public MEMBODLLNEP dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private NPJEMPICKGM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private TaskAwaiter<PJLADDLLKED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x7FD70E0", Offset = "0x7FD64E0", VA = "0x187FD70E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x7FD77B0", Offset = "0x7FD6BB0", VA = "0x187FD77B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	private IFFMIKJIEPF MFCHJJKNFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	private ECMFINOGIEN EOPBDJJHJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	private PJFNBOFGLFH NIKHCJJEBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	private DBCPILAEFPO JBEBFAMKJEN;

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x7FD5650", Offset = "0x7FD4A50", VA = "0x187FD5650", Slot = "5")]
	public void MBHBIOMKKEG(GGAFKPAJMJF NNEBHMDLFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x7FD5380", Offset = "0x7FD4780", VA = "0x187FD5380", Slot = "4")]
	[AsyncStateMachine(typeof(DJLOHOIMBNO))]
	public Task<JGCMJADBFFC> DJEEFNGILBJ(HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, MEMBODLLNEP NDIAONIIAAM, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x7FD5740", Offset = "0x7FD4B40", VA = "0x187FD5740")]
	[AsyncStateMachine(typeof(FKIIIDPNKPL))]
	private Task<KDNGIJKMAJN> OBIMGHBDOCB(MEMBODLLNEP NDIAONIIAAM, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x7FD58A0", Offset = "0x7FD4CA0", VA = "0x187FD58A0")]
	[AsyncStateMachine(typeof(CMPHBGGPPMD))]
	private Task<JGCMJADBFFC> PKGAMGBDBEB(MEMBODLLNEP NDIAONIIAAM, KDNGIJKMAJN PIHDLOODHLD, long DCFFKJJLEHN, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x7FD54E0", Offset = "0x7FD48E0", VA = "0x187FD54E0")]
	[AsyncStateMachine(typeof(OBPIAMFBKDG))]
	private Task<MMFLKMLHKEE> JHMBCHNHJLB(MEMBODLLNEP NDIAONIIAAM, KDNGIJKMAJN PIHDLOODHLD, long DCFFKJJLEHN, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x7FD5210", Offset = "0x7FD4610", VA = "0x187FD5210")]
	[AsyncStateMachine(typeof(KHAIAMFIMLA))]
	private Task<MMFLKMLHKEE> AJHGGAMJELN(MEMBODLLNEP KCENCDOPCOL, FEOHBPOKLEE PEJPCEPGAMG, long DCFFKJJLEHN, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public JHCKFHBPBMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[UnityEngine.Scripting.Preserve]
internal sealed class FBGENLELBJG : HBCHHOMPPDH, ECNGEIBHFNE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[CompilerGenerated]
	private sealed class DDGNPDAPFBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public KOEDLEGFKIO request;

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public DDGNPDAPFBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x7FCD300", Offset = "0x7FCC700", VA = "0x187FCD300")]
		internal object MJHPLCPLNJL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private struct CDODBBMPEAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public AsyncTaskMethodBuilder<KOEDLEGFKIO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public KOEDLEGFKIO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public FBGENLELBJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public BFOAALAPEEN pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private PEPIFLGHCHM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private TaskAwaiter<KOEDLEGFKIO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x7FCAF60", Offset = "0x7FCA360", VA = "0x187FCAF60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x7FCB570", Offset = "0x7FCA970", VA = "0x187FCB570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private struct PELGLGMHNJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public AsyncTaskMethodBuilder<KOEDLEGFKIO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public FBGENLELBJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public BFOAALAPEEN pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private PEPIFLGHCHM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private TaskAwaiter<CIANKMMCJEO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4B00", Offset = "0x7FE3F00", VA = "0x187FE4B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x7FE50F0", Offset = "0x7FE44F0", VA = "0x187FE50F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class PMHOAAFIAGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public KOEDLEGFKIO request;

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public PMHOAAFIAGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x7FE51D0", Offset = "0x7FE45D0", VA = "0x187FE51D0")]
		internal object KGJDBMIBBLP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private struct EKMHMNHAAIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public AsyncTaskMethodBuilder<KOEDLEGFKIO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public KOEDLEGFKIO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public FBGENLELBJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public BFOAALAPEEN pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private PEPIFLGHCHM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private LKFIODGOOPL <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private HADGFOFNNML <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private TaskAwaiter<CIANKMMCJEO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x7FCDB60", Offset = "0x7FCCF60", VA = "0x187FCDB60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x7FCE750", Offset = "0x7FCDB50", VA = "0x187FCE750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	private OAHJJJNDMGJ AAHFLKJGFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	private ELCIHFFMKCH AHEKOIDIAHL;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private OCJBCLJLKMI OAPOLNNKMOI
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x7FCF6A0", Offset = "0x7FCEAA0", VA = "0x187FCF6A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF8C0", Offset = "0x7FCECC0", VA = "0x187FCF8C0", Slot = "8")]
	public void MBHBIOMKKEG(GGAFKPAJMJF NNEBHMDLFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF760", Offset = "0x7FCEB60", VA = "0x187FCF760", Slot = "4")]
	[AsyncStateMachine(typeof(CDODBBMPEAA))]
	public Task<KOEDLEGFKIO> JJONFHELDDH(KOEDLEGFKIO INLHACAOAMD, BFOAALAPEEN LFDLABBBODP, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x7FCFAB0", Offset = "0x7FCEEB0", VA = "0x187FCFAB0", Slot = "5")]
	[AsyncStateMachine(typeof(PELGLGMHNJB))]
	public Task<KOEDLEGFKIO> PJGNLPBBMHG(CancellationToken BLABAMPAGAH, BFOAALAPEEN LFDLABBBODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF4C0", Offset = "0x7FCE8C0", VA = "0x187FCF4C0", Slot = "6")]
	public BBEKBLPLKNJ GIEGJCBEGHC(IMFDIOOAAIF OHOMKHKAGJK, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF570", Offset = "0x7FCE970", VA = "0x187FCF570", Slot = "7")]
	public BBEKBLPLKNJ HPAIOBBBEMF(IMFDIOOAAIF OHOMKHKAGJK, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF950", Offset = "0x7FCED50", VA = "0x187FCF950")]
	[AsyncStateMachine(typeof(EKMHMNHAAIF))]
	private Task<KOEDLEGFKIO> OFOBIPGNEMA(KOEDLEGFKIO INLHACAOAMD, BFOAALAPEEN LFDLABBBODP, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x3359410", Offset = "0x3358810", VA = "0x183359410")]
	private static byte[] DFBCANBBHIA(KOEDLEGFKIO EIGJGBPHOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public FBGENLELBJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[UnityEngine.Scripting.Preserve]
internal sealed class LNBMDPKDMAH : KPKAECBKNJI, ECNGEIBHFNE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private INMEKJKHLIJ NBHIDLGKAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private OAHJJJNDMGJ AAHFLKJGFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private BIOLGOHEHIG AIIKHBBLNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private BPJAFKHGDAB LIDMNCDJHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private IFFMIKJIEPF MFCHJJKNFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private HFLJMAPFFOH BJFGOAGLAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private OHBPDLMECML GFKNIDDNOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private ECMFINOGIEN EOPBDJJHJJL;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private OAJMAHCOGME MJEJCKIGNCH
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x7FDD3E0", Offset = "0x7FDC7E0", VA = "0x187FDD3E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private static BAOOEPCCKJO AJJECIJBGPC
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x7FDD3D0", Offset = "0x7FDC7D0", VA = "0x187FDD3D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD6B0", Offset = "0x7FDCAB0", VA = "0x187FDD6B0", Slot = "6")]
	public void MBHBIOMKKEG(GGAFKPAJMJF NNEBHMDLFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD820", Offset = "0x7FDCC20", VA = "0x187FDD820", Slot = "4")]
	public BAOOEPCCKJO NPIKAHFPIGK(FEIKLGLBIHI NKHMBLLHHHJ, HAMDHMOMGFH IIDBEKEFGGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD430", Offset = "0x7FDC830", VA = "0x187FDD430", Slot = "5")]
	public BAOOEPCCKJO JLOOKONFCGB(FEIKLGLBIHI LANFCLNHAKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD3C0", Offset = "0x7FDC7C0", VA = "0x187FDD3C0")]
	private static BAOOEPCCKJO DNFCFONMNGN(DFBMLOIHJIF CIAFGFLDDGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public LNBMDPKDMAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class ENBJCDAPJEC : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x7FCEF30", Offset = "0x7FCE330", VA = "0x187FCEF30")]
	public ENBJCDAPJEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x7280590", Offset = "0x727F990", VA = "0x187280590")]
	public ENBJCDAPJEC(string EIGJGBPHOMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[UnityEngine.Scripting.Preserve]
internal sealed class GBGPBHHJNFL : OJPLJCNJJKD, ECNGEIBHFNE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private struct NMNANHEENAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public AsyncTaskMethodBuilder<BAOOEPCCKJO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public GBGPBHHJNFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public GLNNANNECEB autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private HOEFFPEDKPI<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private GCMEKDAJCAO <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private TaskAwaiter<BAOOEPCCKJO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x7FDFE60", Offset = "0x7FDF260", VA = "0x187FDFE60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x7FE09B0", Offset = "0x7FDFDB0", VA = "0x187FE09B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct KBMKIHGOKGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public GBGPBHHJNFL <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7FD68E0", Offset = "0x7FD5CE0", VA = "0x187FD68E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x7FD7020", Offset = "0x7FD6420", VA = "0x187FD7020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct CBCMMONHHLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public GBGPBHHJNFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x7FCA820", Offset = "0x7FC9C20", VA = "0x187FCA820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x7FCAD30", Offset = "0x7FCA130", VA = "0x187FCAD30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct BFGNMNALANP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public GBGPBHHJNFL <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7FC9160", Offset = "0x7FC8560", VA = "0x187FC9160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x7FC98A0", Offset = "0x7FC8CA0", VA = "0x187FC98A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct AMIMIHDJCCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public GBGPBHHJNFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x7FC8270", Offset = "0x7FC7670", VA = "0x187FC8270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x7FC8410", Offset = "0x7FC7810", VA = "0x187FC8410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct ELMDMCCCGDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public GBGPBHHJNFL <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7FCE7C0", Offset = "0x7FCDBC0", VA = "0x187FCE7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x7FCEED0", Offset = "0x7FCE2D0", VA = "0x187FCEED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct JGGNMILDCNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public GBGPBHHJNFL <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7FD4D40", Offset = "0x7FD4140", VA = "0x187FD4D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x7FD51B0", Offset = "0x7FD45B0", VA = "0x187FD51B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct POCOJDCLBPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public GBGPBHHJNFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public ONAMBMOGICM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private HOEFFPEDKPI<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x8000AD0", Offset = "0x7FFFED0", VA = "0x188000AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x8001070", Offset = "0x8000470", VA = "0x188001070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private OAHJJJNDMGJ AAHFLKJGFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private GGAFKPAJMJF NNEBHMDLFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private IFFMIKJIEPF MFCHJJKNFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	private HBCHHOMPPDH GMPBMLNBNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	private BIOLGOHEHIG AIIKHBBLNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400033E")]
	private OHBPDLMECML GFKNIDDNOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400033F")]
	private CancellationTokenSource MPPMNJKCEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000340")]
	private Task LFOJMJMELGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	private TaskCompletionSource<int> INFHAIMJKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	private int FKPHICCEPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	private int BAMMDOHFBLK;

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x7FD12E0", Offset = "0x7FD06E0", VA = "0x187FD12E0", Slot = "6")]
	public void MBHBIOMKKEG(GGAFKPAJMJF NNEBHMDLFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x11A78B0", Offset = "0x11A6CB0", VA = "0x1811A78B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1490", Offset = "0x7FD0890", VA = "0x187FD1490")]
	private void MDNPBAHHGEH(float DJGPAINCFCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1670", Offset = "0x7FD0A70", VA = "0x187FD1670", Slot = "4")]
	[AsyncStateMachine(typeof(NMNANHEENAM))]
	public Task<BAOOEPCCKJO> PLLEKKHMDNF(GLNNANNECEB PEJBDAJPKPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0B00", Offset = "0x7FCFF00", VA = "0x187FD0B00", Slot = "5")]
	[AsyncStateMachine(typeof(KBMKIHGOKGP))]
	public Task CCKDNBHKPHB([Optional] CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x11A78B0", Offset = "0x11A6CB0", VA = "0x1811A78B0")]
	public void GJIODEHDLIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1170", Offset = "0x7FD0570", VA = "0x187FD1170")]
	private GCMEKDAJCAO KFHJNBGGLDH(GLNNANNECEB PEJBDAJPKPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1080", Offset = "0x7FD0480", VA = "0x187FD1080")]
	[AsyncStateMachine(typeof(CBCMMONHHLM))]
	private Task KECEODEMGOE(CancellationToken LDLCOIFGBGG, int PDNIHCHMOIK, HJMLLMJGAOM GOCEFJMNFLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0F80", Offset = "0x7FD0380", VA = "0x187FD0F80")]
	[AsyncStateMachine(typeof(BFGNMNALANP))]
	private Task JHICODKBIPN(CancellationToken LDLCOIFGBGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0790", Offset = "0x7FCFB90", VA = "0x187FD0790")]
	[AsyncStateMachine(typeof(AMIMIHDJCCO))]
	private Task BHKKKGJNMOK([Optional] CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0E90", Offset = "0x7FD0290", VA = "0x187FD0E90")]
	[AsyncStateMachine(typeof(ELMDMCCCGDL))]
	private Task HHMAPCFGENC(CancellationToken LDLCOIFGBGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1570", Offset = "0x7FD0970", VA = "0x187FD1570")]
	[AsyncStateMachine(typeof(JGGNMILDCNC))]
	private Task MGDOPDJCLDH(CancellationToken FKNBBHGMGNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0BF0", Offset = "0x7FCFFF0", VA = "0x187FD0BF0")]
	private Task CLLIHCLPFEA(ONAMBMOGICM AMGCMCFMLOG, CancellationToken LDLCOIFGBGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0D80", Offset = "0x7FD0180", VA = "0x187FD0D80")]
	[AsyncStateMachine(typeof(POCOJDCLBPA))]
	private Task DBJOAJELIJH(ONAMBMOGICM AMGCMCFMLOG, CancellationToken LDLCOIFGBGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0880", Offset = "0x7FCFC80", VA = "0x187FD0880")]
	private bool BLKNKOAMHCD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public GBGPBHHJNFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[UnityEngine.Scripting.Preserve]
internal class JINNENGNFFN : BPJAFKHGDAB, ECNGEIBHFNE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct NPINDMOPHMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public JINNENGNFFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private HOEFFPEDKPI<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x7FFCC30", Offset = "0x7FFC030", VA = "0x187FFCC30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x7FFD1F0", Offset = "0x7FFC5F0", VA = "0x187FFD1F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400037D")]
	private DADHEHMMNDP JGEMNCIHBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400037E")]
	private GGAFKPAJMJF NNEBHMDLFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400037F")]
	private KPKAECBKNJI KEJLMDCJCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000380")]
	private HBCHHOMPPDH GMPBMLNBNKJ;

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x7FF3FA0", Offset = "0x7FF33A0", VA = "0x187FF3FA0", Slot = "6")]
	public void MBHBIOMKKEG(GGAFKPAJMJF NNEBHMDLFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x7FF3D10", Offset = "0x7FF3110", VA = "0x187FF3D10", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x7FF3D60", Offset = "0x7FF3160", VA = "0x187FF3D60", Slot = "5")]
	[AsyncStateMachine(typeof(NPINDMOPHMN))]
	public Task IACIMPJJMME(string PMILCDIBAOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x7FF3C50", Offset = "0x7FF3050", VA = "0x187FF3C50", Slot = "4")]
	public BAOOEPCCKJO BLKNKOAMHCD(FEIKLGLBIHI NKHMBLLHHHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x7FF3E60", Offset = "0x7FF3260", VA = "0x187FF3E60")]
	private HNIKHDLNCLF IMMJOGLMBFH(string PMILCDIBAOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public JINNENGNFFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public static class KJFEFEEELOA
{
	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x7FF7820", Offset = "0x7FF6C20", VA = "0x187FF7820")]
	public static void AICJOEBFLGF(NPIEGGOELNH PHDMEDCBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x7FF7F70", Offset = "0x7FF7370", VA = "0x187FF7F70")]
	internal static void PKBOKHCHAAI(NPIEGGOELNH PHDMEDCBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x7FF7E90", Offset = "0x7FF7290", VA = "0x187FF7E90")]
	internal static void OOBJCDDGAPF(NPIEGGOELNH PHDMEDCBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x7FF7A60", Offset = "0x7FF6E60", VA = "0x187FF7A60")]
	internal static void KOAMDKDAHCN(NPIEGGOELNH PHDMEDCBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x36AF830", Offset = "0x36AEC30", VA = "0x1836AF830")]
	private static void OMFGJABBIAF<Interface, Impl, Interface>(NPIEGGOELNH PHDMEDCBLHH) where Impl : Interface
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
internal class BBKJPLCIGNO : KILINHKGHMP<KOEDLEGFKIO>
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private sealed class POOMIIOLPCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public KOEDLEGFKIO message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public POOMIIOLPCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x80010D0", Offset = "0x80004D0", VA = "0x1880010D0")]
		internal object HLGMIPPDNND()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly BBKJPLCIGNO DMADMDPHOOL;

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x7FEA220", Offset = "0x7FE9620", VA = "0x187FEA220")]
	public ExitGames.Client.Photon.Hashtable LMGGAKIACNI(KOEDLEGFKIO EIGJGBPHOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x7FEA2B0", Offset = "0x7FE96B0", VA = "0x187FEA2B0", Slot = "5")]
	protected override void NCDMKEMFHOH(KOEDLEGFKIO EIGJGBPHOMK, IDictionary<object, object> AMHCLKHIFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x7FEA3E0", Offset = "0x7FE97E0", VA = "0x187FEA3E0", Slot = "6")]
	public override KOEDLEGFKIO OJJOMCGFFJC(IDictionary<object, object> AMHCLKHIFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x7FE9E60", Offset = "0x7FE9260", VA = "0x187FE9E60")]
	private static void DLBCFJLNCHA(string FECOBDLBHJF, KOEDLEGFKIO EIGJGBPHOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x7FEA6A0", Offset = "0x7FE9AA0", VA = "0x187FEA6A0")]
	public BBKJPLCIGNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x7FE9F70", Offset = "0x7FE9370", VA = "0x187FE9F70")]
	[CompilerGenerated]
	internal static string HBFKOHCDLPA(JGCMJADBFFC KGCLHKOHKLJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public static class PKLOKDNNKGK
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public static BAOOEPCCKJO AJJECIJBGPC
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x8000170", Offset = "0x7FFF570", VA = "0x188000170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x80003C0", Offset = "0x7FFF7C0", VA = "0x1880003C0")]
	public static bool LHKBDJGFJLE(this BAOOEPCCKJO LIPHIBKLFND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x8000110", Offset = "0x7FFF510", VA = "0x188000110")]
	public static BAOOEPCCKJO DNFCFONMNGN(DFBMLOIHJIF EJDDKMKFNBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x80001D0", Offset = "0x7FFF5D0", VA = "0x1880001D0")]
	public static BAOOEPCCKJO JFLPGFIOEJP(IEnumerable<BAOOEPCCKJO> AOHKHMGJAJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x80003E0", Offset = "0x7FFF7E0", VA = "0x1880003E0")]
	public static string NLIFOJJDBJP(this BAOOEPCCKJO KGODHHBLJOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public abstract class AGEBNCIICJF : NIGLPKBPIFA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public delegate BAOOEPCCKJO KLGLCGJFHGH([NotNull] FEIKLGLBIHI CPHNKAKPMGD);

	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[CompilerGenerated]
	private sealed class GEPPFBOBHGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public FEIKLGLBIHI photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public GEPPFBOBHGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x145FCF0", Offset = "0x145F0F0", VA = "0x18145FCF0")]
		internal BAOOEPCCKJO OCOAGPPGHCJ(KLGLCGJFHGH v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400038D")]
	private bool MIGDMPFDAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400038E")]
	protected readonly HashSet<KLGLCGJFHGH> PDLHMFPLCID;

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x7FE7C70", Offset = "0x7FE7070", VA = "0x187FE7C70", Slot = "4")]
	public void MHEKANOBJOG(KLGLCGJFHGH LBNFEMMNIFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x7FE7980", Offset = "0x7FE6D80", VA = "0x187FE7980", Slot = "5")]
	public void EJBIDIBDKOO(KLGLCGJFHGH LBNFEMMNIFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x7FE7930", Offset = "0x7FE6D30", VA = "0x187FE7930", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x7FE79E0", Offset = "0x7FE6DE0", VA = "0x187FE79E0")]
	protected BAOOEPCCKJO EKALJMIBBIE(FEIKLGLBIHI LANFCLNHAKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x7FE7CD0", Offset = "0x7FE70D0", VA = "0x187FE7CD0")]
	protected AGEBNCIICJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public class BLPPHIIKHJC : AGEBNCIICJF, INMEKJKHLIJ, NIGLPKBPIFA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private sealed class GNAMKJLNNII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public BAOOEPCCKJO result;

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public GNAMKJLNNII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1170", Offset = "0x7FF0570", VA = "0x187FF1170")]
		internal object EBDLJAFEEDM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x7FEA8C0", Offset = "0x7FE9CC0", VA = "0x187FEA8C0")]
	[UnityEngine.Scripting.Preserve]
	public BLPPHIIKHJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x7FEA7B0", Offset = "0x7FE9BB0", VA = "0x187FEA7B0", Slot = "8")]
	public BAOOEPCCKJO LEJELGCKEEE(FEIKLGLBIHI LANFCLNHAKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public class PHGNKNHFMAG : AGEBNCIICJF, DADHEHMMNDP, NIGLPKBPIFA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private sealed class IOKDEBLDKMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public BAOOEPCCKJO result;

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public IOKDEBLDKMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x7FF3B10", Offset = "0x7FF2F10", VA = "0x187FF3B10")]
		internal object IFJPOPIJLFH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x7FEA8C0", Offset = "0x7FE9CC0", VA = "0x187FEA8C0")]
	[UnityEngine.Scripting.Preserve]
	public PHGNKNHFMAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x7FFFF90", Offset = "0x7FFF390", VA = "0x187FFFF90", Slot = "8")]
	public BAOOEPCCKJO BLKNKOAMHCD(FEIKLGLBIHI HNCNLBLNACH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal static class LMNODMNFCNB
{
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private sealed class MFBMJGHANBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public HOEFFPEDKPI<string> timer;

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public MFBMJGHANBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x7FFACD0", Offset = "0x7FFA0D0", VA = "0x187FFACD0")]
		internal object HAJMOMPBNLP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x7FFA180", Offset = "0x7FF9580", VA = "0x187FFA180")]
	public static HOEFFPEDKPI<string> FEDKFOPLIHF(ABDDJEPKCOD LEMJHEDOKDF, [Optional] string CCGEFFLJOFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x7FFA000", Offset = "0x7FF9400", VA = "0x187FFA000")]
	public static void CMBBJLFDJMM(HOEFFPEDKPI<string> AOBIHHLEODI, ABDDJEPKCOD LEMJHEDOKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x7FFA0C0", Offset = "0x7FF94C0", VA = "0x187FFA0C0")]
	public static string DDDFFONHPAK(KOEDLEGFKIO EKKCFNIJCDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
internal static class EIPBLDFJKCL
{
	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x7FED810", Offset = "0x7FECC10", VA = "0x187FED810")]
	public static void CPJFFCNMFGD(this OAHJJJNDMGJ AAHFLKJGFKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x7FED820", Offset = "0x7FECC20", VA = "0x187FED820")]
	public static void DLKKJAIBDBD(this OAHJJJNDMGJ AAHFLKJGFKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x7FED6F0", Offset = "0x7FECAF0", VA = "0x187FED6F0")]
	private static void AHONGBKKJEB(this OAHJJJNDMGJ AAHFLKJGFKB, bool LJJPDJNNIMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class INCKKIONKMP : KEPLMPBBEJG, FMNHDKPLIDD, JKHEKLEPELB, DHNKAEFGHHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000396")]
	private readonly FMNHDKPLIDD MNHEHLFDFED;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public FEIKLGLBIHI FHNCGKJHDKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x7FF36B0", Offset = "0x7FF2AB0", VA = "0x187FF36B0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int LLAJKJBBKAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x7FF3850", Offset = "0x7FF2C50", VA = "0x187FF3850", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public int LLCPEGDKKLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x7FF35C0", Offset = "0x7FF29C0", VA = "0x187FF35C0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool GJFIDCOACBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public int FBCKEBCLNFC
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0xB2B4E0", Offset = "0xB2A8E0", VA = "0x180B2B4E0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event MAIANHJHJIN.LCDNNJPLNIB KILMMNBHLHP
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event HCJIKDBFMJB LMGGKNPJBOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x7FF3940", Offset = "0x7FF2D40", VA = "0x187FF3940", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x7FF37B0", Offset = "0x7FF2BB0", VA = "0x187FF37B0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> KMADFAEFNDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<FEIKLGLBIHI> NPBMHCLOOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action NCILNKJKIJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x7FF38A0", Offset = "0x7FF2CA0", VA = "0x187FF38A0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x7FF3610", Offset = "0x7FF2A10", VA = "0x187FF3610", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0xC4EFB0", Offset = "0xC4E3B0", VA = "0x180C4EFB0")]
	public INCKKIONKMP(FMNHDKPLIDD MNHEHLFDFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x7FF3700", Offset = "0x7FF2B00", VA = "0x187FF3700", Slot = "8")]
	public bool GNKJGNKHLAP(byte MKLGKNFOABE, object OEEFLECLMKF, JIJKACACFPP DBADGOIDFPK, SendOptions DOLDBLADPOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x7FF3A30", Offset = "0x7FF2E30", VA = "0x187FF3A30", Slot = "16")]
	public FEIKLGLBIHI ONCADMNALOJ(int OJKFBILBJGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "19")]
	public void GIICGLPILMF(object HEJFDMJNIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "20")]
	public void OIJGJIJKHCK(object HEJFDMJNIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "21")]
	public void HENDBJHNHCA(object HEJFDMJNIGB, bool CIHAFFHCONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x7FF39E0", Offset = "0x7FF2DE0", VA = "0x187FF39E0", Slot = "22")]
	public IDisposable MJJKLDMILCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "23")]
	private bool CPFFGPLLOHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "24")]
	public void OGJGNIDPICD(StringBuilder BCMHGPKCLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0xEA1150", Offset = "0xEA0550", VA = "0x180EA1150", Slot = "25")]
	public bool MMMMACLLHHP(bool HIIEDCJKLKM, [Out] string DFEFGBECJNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0xE28AC0", Offset = "0xE27EC0", VA = "0x180E28AC0", Slot = "28")]
	public void BHCNPDLEJOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
internal struct DJFJBEOCGCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000398")]
	private readonly IDictionary<object, object> JNDPCNNCNMB;

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0xC67CE0", Offset = "0xC670E0", VA = "0x180C67CE0")]
	public DJFJBEOCGCC(IDictionary<object, object> JNDPCNNCNMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x7FEBEC0", Offset = "0x7FEB2C0", VA = "0x187FEBEC0")]
	public bool KBGKAGBHMBG([Out] KOEDLEGFKIO EIGJGBPHOMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x7FEBF70", Offset = "0x7FEB370", VA = "0x187FEBF70")]
	public Guid PCKALEPJJGA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x7FEBCA0", Offset = "0x7FEB0A0", VA = "0x187FEBCA0")]
	public BAOOEPCCKJO CHAAIPNKJIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x7FEBDD0", Offset = "0x7FEB1D0", VA = "0x187FEBDD0")]
	public static ExitGames.Client.Photon.Hashtable DCJNBNANGBG(KOEDLEGFKIO EIGJGBPHOMK, BAOOEPCCKJO LIPHIBKLFND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal static class AHKABBFLHAM
{
	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x7FE7D60", Offset = "0x7FE7160", VA = "0x187FE7D60")]
	public static bool IEANDKJHINI(this MEMBODLLNEP OHBACCHDJLF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal struct DJEMIOHALLK : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private struct KPOIKJEHFAA : IAsyncStateMachine
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
		public DJEMIOHALLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x7FF8490", Offset = "0x7FF7890", VA = "0x187FF8490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x7FF8670", Offset = "0x7FF7A70", VA = "0x187FF8670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000399")]
	private readonly CancellationTokenSource CGAKGMDNBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400039A")]
	private bool MIGDMPFDAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400039B")]
	private Task ALKPEINKLAJ;

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool MLDGJAOBMHH
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x7FEBA30", Offset = "0x7FEAE30", VA = "0x187FEBA30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x7FEBB70", Offset = "0x7FEAF70", VA = "0x187FEBB70")]
	public DJEMIOHALLK(CancellationToken BLABAMPAGAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x7FEBA60", Offset = "0x7FEAE60", VA = "0x187FEBA60")]
	[AsyncStateMachine(typeof(KPOIKJEHFAA))]
	public Task KPOKBIBPDEK(Func<CancellationToken, List<Task>> BNGCKEBNIJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB9E0", Offset = "0x7FEADE0", VA = "0x187FEB9E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public readonly struct GPIFECBMKGA<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private struct LFNEDHFABKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<NJNFGEEDFLI<TData>, BPMPLDFNAFC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public GPIFECBMKGA<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private TaskAwaiter<AEAAIINGJNL<NJNFGEEDFLI<TData>, BPMPLDFNAFC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x4D7B220", Offset = "0x4D7A620", VA = "0x184D7B220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x46D85A0", Offset = "0x46D79A0", VA = "0x1846D85A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	private readonly JJDBDLLIKAM<TGetDataArg, TData> EGDADDGFBOH;

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0xC67CE0", Offset = "0xC670E0", VA = "0x180C67CE0")]
	internal GPIFECBMKGA(JJDBDLLIKAM<TGetDataArg, TData> EIHGNKDHDGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x483D8F0", Offset = "0x483CCF0", VA = "0x18483D8F0")]
	[AsyncStateMachine(typeof(GPIFECBMKGA<, >.LFNEDHFABKG))]
	public Task<AEAAIINGJNL<NJNFGEEDFLI<TData>, BPMPLDFNAFC>> FIJADCAOFOM(TGetDataArg PKKPPHDAMAG, string JFJOLDAOIPK, HOEFFPEDKPI<string>.AEKMEBIOPMA AOBIHHLEODI, CancellationToken BLABAMPAGAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public static class PFLDLBOCDII
{
	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x335D740", Offset = "0x335CB40", VA = "0x18335D740")]
	public static GPIFECBMKGA<TGetDataArg, TData> AFLKMMODJAC<TGetDataArg, TData>(JJDBDLLIKAM<TGetDataArg, TData> EIHGNKDHDGF)
	{
		return default(GPIFECBMKGA<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public struct JEEOHFCIHID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public readonly int AJHCHHGOILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public readonly int? ANCEDMEOFHM;

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x4D674E0", Offset = "0x4D668E0", VA = "0x184D674E0")]
	public JEEOHFCIHID(int JMDODKHGNOP, [Optional] int? DEJGJGIILJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x7FF3B70", Offset = "0x7FF2F70", VA = "0x187FF3B70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public interface ECACLFGMMKH<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MBHIOAECINH();

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ECACLFGMMKH<T> LIKFEBCKOKJ(string PCGENKDPJLI);

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ECACLFGMMKH<T> KKANFOFNHAC(PLNEJLIGPBP<T> OFEIHPJIFPG);

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ECACLFGMMKH<T> NMJAEENKLMP(int BGDJGAKNCHF);

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ECACLFGMMKH<T> FBDNHGECFPE(int BGDJGAKNCHF, JFAOJDOBFNI<T> OBDOPMILNNO);
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public interface OACPOPIIAFF
{
	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ECACLFGMMKH<T> OABPCIFCMCA<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ALCONNMLJEG HDFPCLKMADM(Exception GEEGJFAONEJ);

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JEEOHFCIHID NOOLCAIBLHL(Exception GEEGJFAONEJ);
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public delegate string PLNEJLIGPBP<in T>(T GEEGJFAONEJ) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public delegate int JFAOJDOBFNI<in T>(T GEEGJFAONEJ) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FB")]
internal class JMOJGDEOEFN : OACPOPIIAFF
{
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	private delegate string BBFNOPLDPNP(Exception GEEGJFAONEJ);

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	private delegate int FLPJDJLHEFO(Exception GEEGJFAONEJ);

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	private class EJDIOPFKLDP<T> : ECACLFGMMKH<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		[CompilerGenerated]
		private sealed class PIAONFLCBJK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x60004A0")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public PIAONFLCBJK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A1")]
			[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
			internal string KKDMEHBENGC(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000100")]
		[CompilerGenerated]
		private sealed class JLFOBKOKPJJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public PLNEJLIGPBP<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public JLFOBKOKPJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0x483CE40", Offset = "0x483C240", VA = "0x18483CE40")]
			internal string ADCEJGOIBDJ(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000101")]
		[CompilerGenerated]
		private sealed class GPAKMHKNFLI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public JFAOJDOBFNI<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public GPAKMHKNFLI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0x483CE40", Offset = "0x483C240", VA = "0x18483CE40")]
			internal int PHHLNLNCKOB(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private readonly JMOJGDEOEFN ACGDIJMHPEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private readonly Type DDMLCPNBONE;

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x4288000", Offset = "0x4287400", VA = "0x184288000")]
		internal EJDIOPFKLDP(JMOJGDEOEFN ACGDIJMHPEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x4287F90", Offset = "0x4287390", VA = "0x184287F90", Slot = "4")]
		public void MBHIOAECINH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x4287E70", Offset = "0x4287270", VA = "0x184287E70", Slot = "5")]
		public ECACLFGMMKH<T> LIKFEBCKOKJ(string PCGENKDPJLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x4287D50", Offset = "0x4287150", VA = "0x184287D50", Slot = "6")]
		public ECACLFGMMKH<T> KKANFOFNHAC(PLNEJLIGPBP<T> OFEIHPJIFPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x4287FC0", Offset = "0x42873C0", VA = "0x184287FC0", Slot = "7")]
		public ECACLFGMMKH<T> NMJAEENKLMP(int BGDJGAKNCHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x4287C20", Offset = "0x4287020", VA = "0x184287C20", Slot = "8")]
		public ECACLFGMMKH<T> FBDNHGECFPE(int BGDJGAKNCHF, JFAOJDOBFNI<T> OBDOPMILNNO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	private class JEBMDJJAMMP<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private bool JGBHEDKOBEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private readonly List<Type> CHLCJHBBDHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private readonly Dictionary<Type, TVal> DBEIPJIGMML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private readonly Dictionary<Type, int> DFMOHOBHMDD;

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public IReadOnlyList<Type> NFGCFDLAEIG
		{
			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0x4BD1B00", Offset = "0x4BD0F00", VA = "0x184BD1B00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x4BD1FA0", Offset = "0x4BD13A0", VA = "0x184BD1FA0")]
		public JEBMDJJAMMP(Dictionary<Type, int> DFMOHOBHMDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x4BD1EF0", Offset = "0x4BD12F0", VA = "0x184BD1EF0")]
		public void LLICHLCEEGA(Type MCBJECJLDOM, TVal NMBONOELKFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x4BD1CB0", Offset = "0x4BD10B0", VA = "0x184BD1CB0")]
		public bool FHEFKDKCICI(Type DDMLCPNBONE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x4BD1AB0", Offset = "0x4BD0EB0", VA = "0x184BD1AB0")]
		public bool BCINEMAMEDF(TVal FIIKLGCIAGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x4BD1C60", Offset = "0x4BD1060", VA = "0x184BD1C60")]
		public TVal CNKKCIMLPML(Type MAIGGPEPIHD)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x4BD1DA0", Offset = "0x4BD11A0", VA = "0x184BD1DA0")]
		[CompilerGenerated]
		private int KFIPBHAIOHN(Type BDKMBKFGGCO, Type ADMEJBHONMM)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private sealed class EBLHPNLKOAG : IEnumerable<JEEOHFCIHID>, IEnumerable, IEnumerator<JEEOHFCIHID>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private JEEOHFCIHID <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public JMOJGDEOEFN <>4__this;

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
		private IEnumerator<JEEOHFCIHID> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		private JEEOHFCIHID System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x431F430", Offset = "0x431E830", VA = "0x18431F430", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(JEEOHFCIHID);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0x7FEC680", Offset = "0x7FEBA80", VA = "0x187FEC680", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0xDDEBA0", Offset = "0xDDDFA0", VA = "0x180DDEBA0")]
		[DebuggerHidden]
		public EBLHPNLKOAG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x7FEC6D0", Offset = "0x7FEBAD0", VA = "0x187FEC6D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x7FEC0C0", Offset = "0x7FEB4C0", VA = "0x187FEC0C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x7FEC070", Offset = "0x7FEB470", VA = "0x187FEC070")]
		private void KNMHCFDKFOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x7FEC020", Offset = "0x7FEB420", VA = "0x187FEC020")]
		private void CHDBNOFNPHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x7FEC630", Offset = "0x7FEBA30", VA = "0x187FEC630", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x7FEC570", Offset = "0x7FEB970", VA = "0x187FEC570", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JEEOHFCIHID> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x7FEC570", Offset = "0x7FEB970", VA = "0x187FEC570", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	private static readonly JEEOHFCIHID JCHPBGMCOEA;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	private static readonly Dictionary<Type, int> HOJECCFDNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private readonly HashSet<Type> KLEFOMGJDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	private readonly JEBMDJJAMMP<int> IGIMILMJLOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	private readonly JEBMDJJAMMP<FLPJDJLHEFO> HLGPEANCNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	private readonly JEBMDJJAMMP<BBFNOPLDPNP> KPONFDMGNAO;

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x7FF69D0", Offset = "0x7FF5DD0", VA = "0x187FF69D0")]
	[BOBPNFIGGBE.NBDKKMMHNGD.OAOMAIGGIPF]
	internal static void KKOCPHMJODH(NPIEGGOELNH FLKEBBNIBPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x7FF6DE0", Offset = "0x7FF61E0", VA = "0x187FF6DE0")]
	[RecRoom.NoEngine.Common.Preserve]
	public JMOJGDEOEFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x363C7F0", Offset = "0x363BBF0", VA = "0x18363C7F0", Slot = "4")]
	public ECACLFGMMKH<T> OABPCIFCMCA<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x7FF62A0", Offset = "0x7FF56A0", VA = "0x187FF62A0", Slot = "5")]
	public ALCONNMLJEG HDFPCLKMADM(Exception GEEGJFAONEJ)
	{
		return default(ALCONNMLJEG);
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x7FF6B20", Offset = "0x7FF5F20", VA = "0x187FF6B20", Slot = "6")]
	public JEEOHFCIHID NOOLCAIBLHL(Exception? GEEGJFAONEJ)
	{
		return default(JEEOHFCIHID);
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x7FF5B80", Offset = "0x7FF4F80", VA = "0x187FF5B80", Slot = "7")]
	[IteratorStateMachine(typeof(EBLHPNLKOAG))]
	public IEnumerable<JEEOHFCIHID> CCOIDODPKJM(Exception GEEGJFAONEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x7FF6330", Offset = "0x7FF5730", VA = "0x187FF6330", Slot = "8")]
	public string HLEAIPOPNMA(Exception? GEEGJFAONEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x7FF6480", Offset = "0x7FF5880", VA = "0x187FF6480")]
	private string JHPGDGGCJID(AggregateException OGGABAPJBIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x7FF5EF0", Offset = "0x7FF52F0", VA = "0x187FF5EF0")]
	private void DMGAGIMCGMH(Type DDMLCPNBONE, int BGDJGAKNCHF, FLPJDJLHEFO? LABNDHIJPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x7FF6780", Offset = "0x7FF5B80", VA = "0x187FF6780")]
	private void KFHDLDDDEIA(Type DDMLCPNBONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x7FF5C20", Offset = "0x7FF5020", VA = "0x187FF5C20")]
	private void CJLPIFBJLGB(Type DDMLCPNBONE, BBFNOPLDPNP JODKBDENKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x7FF5A00", Offset = "0x7FF4E00", VA = "0x187FF5A00")]
	private static int BNMFEFIALGF(Type DDMLCPNBONE, Dictionary<Type, int> DFMOHOBHMDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x368C1A0", Offset = "0x368B5A0", VA = "0x18368C1A0")]
	private static bool DPAAENIFEDH<TVal>(JEBMDJJAMMP<TVal> EDJBENPLFOA, Type DDMLCPNBONE, [Out] TVal FIIKLGCIAGG) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x7FF6A40", Offset = "0x7FF5E40", VA = "0x187FF6A40")]
	[CompilerGenerated]
	internal static int LJPLBNJELOF(Type FOONIEILEIP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public struct ALCONNMLJEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public readonly JEEOHFCIHID NGJNNPHKGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public readonly string OMGKDKOOBHJ;

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x7FE8A30", Offset = "0x7FE7E30", VA = "0x187FE8A30")]
	public ALCONNMLJEG(string BAMFAKOPDOI, JEEOHFCIHID BGDJGAKNCHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x7FE8990", Offset = "0x7FE7D90", VA = "0x187FE8990")]
	public string NCIFENBFGJN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public class DFOPGDIDDDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	private readonly MDABFMCKPEE ADOEEBPKIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	private string LAPEGEBDMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	private long? DABGOJEDOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	private long? LNKFDPNNPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	private long? EHLACNDAOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	private string KGGCDGEPDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	private CNMGOCEKCNJ LFMIFMCFJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	private long? JBCOFFHAFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	private bool COFCKJEHILA;

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public string PCMBKJONCIA
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public long DBEGJFNNADH
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x7FEB880", Offset = "0x7FEAC80", VA = "0x187FEB880")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public long ABPLKOAPGAD
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x7FEB820", Offset = "0x7FEAC20", VA = "0x187FEB820")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public long AFEGCHCIJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x7FEAF50", Offset = "0x7FEA350", VA = "0x187FEAF50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public string MEHBCJLLLOA
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x7FEB8E0", Offset = "0x7FEACE0", VA = "0x187FEB8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public CNMGOCEKCNJ JPHFPCFGEPO
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0xCC2500", Offset = "0xCC1900", VA = "0x180CC2500")]
		get
		{
			return default(CNMGOCEKCNJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x7FEAE60", Offset = "0x7FEA260", VA = "0x187FEAE60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public long LNDHMGAIDFI
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x7FEB7C0", Offset = "0x7FEABC0", VA = "0x187FEB7C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB9A0", Offset = "0x7FEADA0", VA = "0x187FEB9A0")]
	[UnityEngine.Scripting.Preserve]
	public DFOPGDIDDDM([GKAMHFFOHNI(null)] MDABFMCKPEE ADOEEBPKIFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x7FEAC10", Offset = "0x7FEA010", VA = "0x187FEAC10")]
	private void EBBADNHNIIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x7FEAFB0", Offset = "0x7FEA3B0", VA = "0x187FEAFB0")]
	public void JHFDCBPLJAO(long CCHPCHDJHAI, long DCFFKJJLEHN, [Optional] long? OCCKLCFPOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x7FEAB70", Offset = "0x7FE9F70", VA = "0x187FEAB70")]
	public void BFDCKDFOBJG(long OCCKLCFPOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB920", Offset = "0x7FEAD20", VA = "0x187FEB920")]
	public void PPFIHEGMFNC(string KLELKFDGBKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB440", Offset = "0x7FEA840", VA = "0x187FEB440")]
	public void JMEFBIGKEAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
internal class BBEKBLPLKNJ : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private struct PFGMGBODMGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public AsyncTaskMethodBuilder<KOEDLEGFKIO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public KOEDLEGFKIO roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public BBEKBLPLKNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private TaskAwaiter<OCJBCLJLKMI.LGIFCDAOIKK<KOEDLEGFKIO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x7FFF540", Offset = "0x7FFE940", VA = "0x187FFF540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x7FFFA80", Offset = "0x7FFEE80", VA = "0x187FFFA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private struct PPKCIILOKLK<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private sealed class IFMPBMPJKGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public KOEDLEGFKIO roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public IFMPBMPJKGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1A40", Offset = "0x7FF0E40", VA = "0x187FF1A40")]
		internal KOEDLEGFKIO BPADNIEIPID(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct IMJMBMMKBPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public AsyncTaskMethodBuilder<OCJBCLJLKMI.LGIFCDAOIKK<KOEDLEGFKIO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public KOEDLEGFKIO roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public BBEKBLPLKNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private LKFIODGOOPL <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private TaskAwaiter<OCJBCLJLKMI.LGIFCDAOIKK<KOEDLEGFKIO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x7FF2F40", Offset = "0x7FF2340", VA = "0x187FF2F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x7FF3550", Offset = "0x7FF2950", VA = "0x187FF3550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private struct FKCNGKNLFLA<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public BBEKBLPLKNJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x46E6E70", Offset = "0x46E6270", VA = "0x1846E6E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x3E603B0", Offset = "0x3E5F7B0", VA = "0x183E603B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private struct NANOGGHFNHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public BBEKBLPLKNJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7FFBE90", Offset = "0x7FFB290", VA = "0x187FFBE90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x7FFC050", Offset = "0x7FFB450", VA = "0x187FFC050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private sealed class GHCBDHKFKPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public GHCBDHKFKPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x7FEFD80", Offset = "0x7FEF180", VA = "0x187FEFD80")]
		internal object KJFCGKKJIDM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x7FEFDE0", Offset = "0x7FEF1E0", VA = "0x187FEFDE0")]
		internal bool KLNMLNAMNLH(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private sealed class LNLJFIGCALG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public LNLJFIGCALG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x7FFA260", Offset = "0x7FF9660", VA = "0x187FFA260")]
		internal object FDPNBMODFKO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private sealed class CMNPMBKKKHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public CMNPMBKKKHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x7FEAA00", Offset = "0x7FE9E00", VA = "0x187FEAA00")]
		internal object BOGPJLAPEEH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private sealed class PDHDAMIANCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public PDHDAMIANCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x7FFF4D0", Offset = "0x7FFE8D0", VA = "0x187FFF4D0")]
		internal object FNGMLCLDLAC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private sealed class NNFOBLJEEMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public BBEKBLPLKNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public NNFOBLJEEMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x7FFC9E0", Offset = "0x7FFBDE0", VA = "0x187FFC9E0")]
		internal object HLGMIPPDNND()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	private static readonly Guid KLBIEDJDFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public readonly IMFDIOOAAIF PMCHJLNGKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	private readonly OCJBCLJLKMI FGHEPFDKEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private readonly JKHEKLEPELB AAHFLKJGFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	private readonly DHNKAEFGHHC BOKFMLBNKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private bool EAICHMLFGDJ;

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x7FE9C30", Offset = "0x7FE9030", VA = "0x187FE9C30")]
	public BBEKBLPLKNJ(IMFDIOOAAIF MEOMIMDGMJF, OCJBCLJLKMI FGHEPFDKEIG, JKHEKLEPELB AAHFLKJGFKB, DHNKAEFGHHC BOKFMLBNKGH, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x7FE8F40", Offset = "0x7FE8340", VA = "0x187FE8F40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x7FE8BB0", Offset = "0x7FE7FB0", VA = "0x187FE8BB0")]
	public void AOGDPFJDPMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x7FE9710", Offset = "0x7FE8B10", VA = "0x187FE9710")]
	public void JOCFJJMJNMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x7FE93E0", Offset = "0x7FE87E0", VA = "0x187FE93E0")]
	public void INPHMPLBEAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x7FE8A50", Offset = "0x7FE7E50", VA = "0x187FE8A50")]
	[AsyncStateMachine(typeof(PFGMGBODMGA))]
	internal Task<KOEDLEGFKIO> AEHIMMCDBFG(HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, KOEDLEGFKIO EKKCFNIJCDA, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x3359410", Offset = "0x3358810", VA = "0x183359410")]
	private static byte[] IBDIMFJBDDG<T>(T EIGJGBPHOMK) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x3359420", Offset = "0x3358820", VA = "0x183359420")]
	private static T IFDPDBPFGKB<T>(MessageParser<T> HNBEPBLDIOP, byte[] EIGJGBPHOMK, T EEBGFPOICDD) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x7FE95D0", Offset = "0x7FE89D0", VA = "0x187FE95D0")]
	[AsyncStateMachine(typeof(IMJMBMMKBPK))]
	private Task<OCJBCLJLKMI.LGIFCDAOIKK<KOEDLEGFKIO>> JOBOKIIOOCA(KOEDLEGFKIO EKKCFNIJCDA, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x3359570", Offset = "0x3358970", VA = "0x183359570")]
	[AsyncStateMachine(typeof(FKCNGKNLFLA<>))]
	internal Task<T> JCFEEBIHKMB<T>(CancellationToken LDLCOIFGBGG, Func<CancellationToken, Task<T>> EGEJPPNNBFE, int AKNABCHGHKM = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x7FE94A0", Offset = "0x7FE88A0", VA = "0x187FE94A0")]
	[AsyncStateMachine(typeof(NANOGGHFNHF))]
	internal Task JCFEEBIHKMB(CancellationToken LDLCOIFGBGG, Func<CancellationToken, Task> EGEJPPNNBFE, int AKNABCHGHKM = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x7FE9900", Offset = "0x7FE8D00", VA = "0x187FE9900")]
	public MEPGEDKMDKD ODCKBENEOKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x7FE99D0", Offset = "0x7FE8DD0", VA = "0x187FE99D0")]
	public OJHMOJIKBMO ONODILDJDPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x7FE9060", Offset = "0x7FE8460", VA = "0x187FE9060")]
	public CKJILLGLNDH HDKCGHJMGOE([Optional] ABDDJEPKCOD? LEMJHEDOKDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x7FE8CD0", Offset = "0x7FE80D0", VA = "0x187FE8CD0")]
	public void BIBDMPBCKIB(Func<Guid, bool> BIBBDAEBHAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x7FE92D0", Offset = "0x7FE86D0", VA = "0x187FE92D0")]
	public void HEOMICCCJML(Func<Guid, bool> GKDJEDGBJFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x7FE9A50", Offset = "0x7FE8E50", VA = "0x187FE9A50")]
	public Guid PFENOOGPMJA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x7FE8F50", Offset = "0x7FE8350", VA = "0x187FE8F50")]
	public void EHNFIFLEBMC(Guid IAHHGHKNCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x7FE97D0", Offset = "0x7FE8BD0", VA = "0x187FE97D0")]
	public void NAEONIHLLCO(KOEDLEGFKIO GGODOAOAPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x7FE8E30", Offset = "0x7FE8230", VA = "0x187FE8E30")]
	public void DLBCFJLNCHA(string DLIGPOGBAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x3359810", Offset = "0x3358C10", VA = "0x183359810")]
	private T LBGGHOIOPJM<T>(T FIIKLGCIAGG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x7FE9980", Offset = "0x7FE8D80", VA = "0x187FE9980")]
	public void OJKPOOHKELB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x3359900", Offset = "0x3358D00", VA = "0x183359900")]
	[CompilerGenerated]
	internal static string LPMCBEHJBOH<T>(byte[] FIKLNMFCLIL, int CGKHNEOJKPD, PPKCIILOKLK<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal sealed class MGKNMEGJJNL : IMFDIOOAAIF
{
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private sealed class PJFEJGOHHPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public PJFEJGOHHPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x80000A0", Offset = "0x7FFF4A0", VA = "0x1880000A0")]
		internal object GLDKGICDEPL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private struct MOMGDEMAPMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public MGKNMEGJJNL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public BBEKBLPLKNJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private NDKFKFGHFIK <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private OJHMOJIKBMO <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x7FFB4E0", Offset = "0x7FFA8E0", VA = "0x187FFB4E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x7FFBE30", Offset = "0x7FFB230", VA = "0x187FFBE30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private struct LJBFNDHFJCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public MGKNMEGJJNL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private bool <omShouldBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private TaskAwaiter<KDNGIJKMAJN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private TaskAwaiter<int> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x7FF8920", Offset = "0x7FF7D20", VA = "0x187FF8920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x7FF9060", Offset = "0x7FF8460", VA = "0x187FF9060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct AICJCECPAFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public MGKNMEGJJNL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private TaskAwaiter<PJLADDLLKED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x7FE7DE0", Offset = "0x7FE71E0", VA = "0x187FE7DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x7FE80F0", Offset = "0x7FE74F0", VA = "0x187FE80F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private sealed class FLCOFOGIJEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public NDKFKFGHFIK presence;

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public FLCOFOGIJEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x7FEED10", Offset = "0x7FEE110", VA = "0x187FEED10")]
		internal object KIPGFPBDOCE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	private static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	private static readonly ABDDJEPKCOD IAEPOPBDDCD;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	private static readonly ABDDJEPKCOD GGNPNDHONME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	private readonly JGCMJADBFFC CEKINONAFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	private readonly MEMBODLLNEP MOFLDKODPHP;

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x7FFB350", Offset = "0x7FFA750", VA = "0x187FFB350")]
	public MGKNMEGJJNL(JGCMJADBFFC CEKINONAFIE, MEMBODLLNEP MOFLDKODPHP, Guid NPMNDEDHHIJ, GGAFKPAJMJF NNEBHMDLFHI, BFOAALAPEEN ICDHJFGIHKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x7FFB140", Offset = "0x7FFA540", VA = "0x187FFB140", Slot = "7")]
	[AsyncStateMachine(typeof(MOMGDEMAPMO))]
	protected override Task OBEADLEOIED(BBEKBLPLKNJ OBMIMFHGEKH, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x7FFAD50", Offset = "0x7FFA150", VA = "0x187FFAD50")]
	[AsyncStateMachine(typeof(LJBFNDHFJCF))]
	private Task HFMHHPEEPBA(CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x7FFB030", Offset = "0x7FFA430", VA = "0x187FFB030")]
	[AsyncStateMachine(typeof(AICJCECPAFJ))]
	private Task<int> MDELBKJJBGE(CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x7FFAE50", Offset = "0x7FFA250", VA = "0x187FFAE50")]
	private NDKFKFGHFIK JAJGFCIALCD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal class GCMEKDAJCAO : IMFDIOOAAIF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct GCNMMKLOCJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public GCMEKDAJCAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public BBEKBLPLKNJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private TaskAwaiter<PFDCFKLNLCM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x7FEF370", Offset = "0x7FEE770", VA = "0x187FEF370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x7FEFD20", Offset = "0x7FEF120", VA = "0x187FEFD20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	private readonly int OEGKBOAEBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000420")]
	private readonly GLNNANNECEB CCGNPPPBHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public readonly long BKLLPDKHGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public readonly long MBCKMCAAHHI;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public PFDCFKLNLCM CJBPIDMFMIK
	{
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x99A9F0", Offset = "0x999DF0", VA = "0x18099A9F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x99AA20", Offset = "0x999E20", VA = "0x18099AA20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x7FEF240", Offset = "0x7FEE640", VA = "0x187FEF240")]
	public GCMEKDAJCAO(Guid NPMNDEDHHIJ, GGAFKPAJMJF NNEBHMDLFHI, BFOAALAPEEN ICDHJFGIHKK, int OEGKBOAEBKO, GLNNANNECEB CCGNPPPBHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x7FEF120", Offset = "0x7FEE520", VA = "0x187FEF120", Slot = "7")]
	[AsyncStateMachine(typeof(GCNMMKLOCJC))]
	protected override Task OBEADLEOIED(BBEKBLPLKNJ OBMIMFHGEKH, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
internal abstract class FMKCKGDMLCD : IMFDIOOAAIF
{
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private sealed class BCCNGHMAIFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public FMKCKGDMLCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public KBEDLKKEHIH playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public BCCNGHMAIFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x7FEA770", Offset = "0x7FE9B70", VA = "0x187FEA770")]
		internal Task OCMEALNBFOP(HOEFFPEDKPI<string>.AEKMEBIOPMA postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x7FEA6E0", Offset = "0x7FE9AE0", VA = "0x187FEA6E0")]
		internal object MMOCMBLPIEP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private struct AICKPOBIJNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public FMKCKGDMLCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public BBEKBLPLKNJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		private BCCNGHMAIFJ <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x7FE8160", Offset = "0x7FE7560", VA = "0x187FE8160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x7FE8930", Offset = "0x7FE7D30", VA = "0x187FE8930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private struct JLPLBELPLGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public KBEDLKKEHIH playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public FMKCKGDMLCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x7FF53F0", Offset = "0x7FF47F0", VA = "0x187FF53F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x7FF59A0", Offset = "0x7FF4DA0", VA = "0x187FF59A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x7FEF0D0", Offset = "0x7FEE4D0", VA = "0x187FEF0D0")]
	public FMKCKGDMLCD(Guid NPMNDEDHHIJ, GGAFKPAJMJF NNEBHMDLFHI, BFOAALAPEEN ICDHJFGIHKK, string IJBHKFFHEIN, CAACDBPGMHO AKJDKCNBMBD, bool DHKCOICKDEK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x7FEEF90", Offset = "0x7FEE390", VA = "0x187FEEF90", Slot = "7")]
	[AsyncStateMachine(typeof(AICKPOBIJNI))]
	protected override Task OBEADLEOIED(BBEKBLPLKNJ OBMIMFHGEKH, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task PCKNEMBKELI(BBEKBLPLKNJ OBMIMFHGEKH, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH);

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x7FEEE50", Offset = "0x7FEE250", VA = "0x187FEEE50")]
	[AsyncStateMachine(typeof(JLPLBELPLGD))]
	private Task HHMENNLOMNJ(IDisposable KPLFPFLNMPH, KBEDLKKEHIH KCCCGHOIODF, HOEFFPEDKPI<string>.AEKMEBIOPMA AOBIHHLEODI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal class PDBMBIIGIAM : IMFDIOOAAIF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private struct HEOMDKHPGHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public PDBMBIIGIAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public BBEKBLPLKNJ operationContext;

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
		private TaskAwaiter<IPEJPHCMEGJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1290", Offset = "0x7FF0690", VA = "0x187FF1290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1820", Offset = "0x7FF0C20", VA = "0x187FF1820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000440")]
	private readonly ONAMBMOGICM AMGCMCFMLOG;

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x7FFF430", Offset = "0x7FFE830", VA = "0x187FFF430")]
	public PDBMBIIGIAM(Guid NPMNDEDHHIJ, GGAFKPAJMJF NNEBHMDLFHI, BFOAALAPEEN ICDHJFGIHKK, ONAMBMOGICM AMGCMCFMLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x7FFF230", Offset = "0x7FFE630", VA = "0x187FFF230", Slot = "6")]
	protected override string BIKEOPEONDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x7FFF310", Offset = "0x7FFE710", VA = "0x187FFF310", Slot = "7")]
	[AsyncStateMachine(typeof(HEOMDKHPGHN))]
	protected override Task OBEADLEOIED(BBEKBLPLKNJ OBMIMFHGEKH, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
internal abstract class IMFDIOOAAIF : EMCCFILHLEN
{
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	public delegate Task ONPKCDPBDJK(HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH);

	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private sealed class CMFDGGGDBKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public IMFDIOOAAIF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public CMFDGGGDBKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x7FEA8D0", Offset = "0x7FE9CD0", VA = "0x187FEA8D0")]
		internal Task GIGOKOGEOBJ(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private sealed class HEIHIPKLLDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public CMFDGGGDBKC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public HEIHIPKLLDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x7FF11D0", Offset = "0x7FF05D0", VA = "0x187FF11D0")]
		internal object LHHLJIIHJEB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct AFLBCGIPKLF : IAsyncStateMachine
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
		public IMFDIOOAAIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public Func<IMFDIOOAAIF, HOEFFPEDKPI<string>.AEKMEBIOPMA, BBEKBLPLKNJ> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private CMFDGGGDBKC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private BBEKBLPLKNJ <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private TaskAwaiter<KOEDLEGFKIO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x7FE6780", Offset = "0x7FE5B80", VA = "0x187FE6780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x7FE78D0", Offset = "0x7FE6CD0", VA = "0x187FE78D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct GHNJHAELIMK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7FF0670", Offset = "0x7FEFA70", VA = "0x187FF0670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1110", Offset = "0x7FF0510", VA = "0x187FF1110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct KMCIGNCNJMF : IAsyncStateMachine
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
		public IMFDIOOAAIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x7FF80D0", Offset = "0x7FF74D0", VA = "0x187FF80D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x7FF8430", Offset = "0x7FF7830", VA = "0x187FF8430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public readonly Guid PNDIAPLLLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public readonly ByteString NMHFLIJFMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public readonly BFOAALAPEEN AKAIFHIKLMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400044C")]
	protected readonly string MLBNBJEEGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400044D")]
	private readonly GGAFKPAJMJF NNEBHMDLFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400044E")]
	private readonly bool DHKCOICKDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400044F")]
	private readonly Queue<ONPKCDPBDJK> DPGBFAMIDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000450")]
	private readonly CMIBACOKHIM PLEBIACLKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000451")]
	private readonly CAACDBPGMHO AKJDKCNBMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	private bool LBEMJJBBLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public CNMGOCEKCNJ BEANHFLGDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public CNMGOCEKCNJ JDCJLJABBCJ;

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public GGAFKPAJMJF COEODMFJGAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x993450", Offset = "0x992850", VA = "0x180993450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public IFFMIKJIEPF OGNNDGMLFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x7FF2640", Offset = "0x7FF1A40", VA = "0x187FF2640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public HCCOGDFGNKF MPLBCJFDNKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x7FF2220", Offset = "0x7FF1620", VA = "0x187FF2220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public OAJMAHCOGME MJEJCKIGNCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x7FF2480", Offset = "0x7FF1880", VA = "0x187FF2480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event CDKMFFODKCF GLFDMFDCLGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x7FF2690", Offset = "0x7FF1A90", VA = "0x187FF2690", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x7FF27A0", Offset = "0x7FF1BA0", VA = "0x187FF27A0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x7FF2BE0", Offset = "0x7FF1FE0", VA = "0x187FF2BE0")]
	protected IMFDIOOAAIF(Guid NPMNDEDHHIJ, GGAFKPAJMJF NNEBHMDLFHI, BFOAALAPEEN ICDHJFGIHKK, string IJBHKFFHEIN, CAACDBPGMHO AKJDKCNBMBD, bool DHKCOICKDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x7FF2090", Offset = "0x7FF1490", VA = "0x187FF2090", Slot = "6")]
	protected virtual string BIKEOPEONDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x7FF2420", Offset = "0x7FF1820", VA = "0x187FF2420")]
	public void GCEMFFMMAND(ONPKCDPBDJK JENKLPHLLJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x7FF2500", Offset = "0x7FF1900", VA = "0x187FF2500")]
	protected void IOBJLJENLCA(float GGAJNINGNDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x7FF20D0", Offset = "0x7FF14D0", VA = "0x187FF20D0")]
	[AsyncStateMachine(typeof(AFLBCGIPKLF))]
	public Task CAFDDKMELKN(CancellationToken BLABAMPAGAH, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, [Optional] Func<IMFDIOOAAIF, HOEFFPEDKPI<string>.AEKMEBIOPMA, BBEKBLPLKNJ> IDENOKCPOOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x7FF22F0", Offset = "0x7FF16F0", VA = "0x187FF22F0")]
	[AsyncStateMachine(typeof(GHNJHAELIMK))]
	private static Task FKAEJBANIKJ(Func<CancellationToken, Task> EAHDJJHDNEI, Func<CancellationToken, Task> IGCALENMMOB, CancellationToken LDLCOIFGBGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x7FF29E0", Offset = "0x7FF1DE0", VA = "0x187FF29E0")]
	private void OFNPJJOPHLB(bool NIGNBIDEMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x7FF27C0", Offset = "0x7FF1BC0", VA = "0x187FF27C0")]
	private void OBIOHKGJEDO(BBEKBLPLKNJ OBMIMFHGEKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task OBEADLEOIED(BBEKBLPLKNJ OBMIMFHGEKH, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH);

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x7FF2520", Offset = "0x7FF1920", VA = "0x187FF2520")]
	[AsyncStateMachine(typeof(KMCIGNCNJMF))]
	private Task JHOBFMDJAGM(HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x7FF2B60", Offset = "0x7FF1F60", VA = "0x187FF2B60")]
	public KOEDLEGFKIO PKDEHJGMPHC(LKFIODGOOPL OBKNMPPBMJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x7FF26B0", Offset = "0x7FF1AB0", VA = "0x187FF26B0")]
	[CompilerGenerated]
	private Task MFNGOLKNMKA(CancellationToken CFOOONLCHLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x7FF2270", Offset = "0x7FF1670", VA = "0x187FF2270")]
	[CompilerGenerated]
	private object FGHDJFJPLMJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
internal sealed class IMJKIMIFFOJ : FMKCKGDMLCD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct GHCBNHIDAIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public IMJKIMIFFOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public BBEKBLPLKNJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private KDMPGIPNGGP <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private OJHMOJIKBMO <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x7FEFEA0", Offset = "0x7FEF2A0", VA = "0x187FEFEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x7FF0610", Offset = "0x7FEFA10", VA = "0x187FF0610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000476")]
	private readonly JGCMJADBFFC FFDGEOMIDMF;

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x7FF2E90", Offset = "0x7FF2290", VA = "0x187FF2E90")]
	public IMJKIMIFFOJ(Guid NPMNDEDHHIJ, GGAFKPAJMJF NNEBHMDLFHI, JGCMJADBFFC FFDGEOMIDMF, BFOAALAPEEN ICDHJFGIHKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x7FF2D40", Offset = "0x7FF2140", VA = "0x187FF2D40", Slot = "8")]
	[AsyncStateMachine(typeof(GHCBNHIDAIE))]
	protected override Task PCKNEMBKELI(BBEKBLPLKNJ OBMIMFHGEKH, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
internal class HNIKHDLNCLF : IMFDIOOAAIF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct LOBBNILLMNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public HNIKHDLNCLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public BBEKBLPLKNJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private TaskAwaiter<IPEJPHCMEGJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x7FFA2C0", Offset = "0x7FF96C0", VA = "0x187FFA2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x7FFA670", Offset = "0x7FF9A70", VA = "0x187FFA670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000480")]
	private readonly string ICGGHMAANDK;

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x7FF1990", Offset = "0x7FF0D90", VA = "0x187FF1990")]
	public HNIKHDLNCLF(Guid NPMNDEDHHIJ, GGAFKPAJMJF NNEBHMDLFHI, BFOAALAPEEN ICDHJFGIHKK, string ICGGHMAANDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x7FF1880", Offset = "0x7FF0C80", VA = "0x187FF1880", Slot = "7")]
	[AsyncStateMachine(typeof(LOBBNILLMNI))]
	protected override Task OBEADLEOIED(BBEKBLPLKNJ OBMIMFHGEKH, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
internal class IIHHIKAEMOB : FMKCKGDMLCD
{
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private sealed class EBLLEPNCMBH
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
			public AsyncTaskMethodBuilder<KOEDLEGFKIO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000495")]
			public EBLLEPNCMBH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000497")]
			private TaskAwaiter<IPEJPHCMEGJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			private TaskAwaiter<KOEDLEGFKIO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000552")]
			[Cpp2IlInjected.Address(RVA = "0x8002380", Offset = "0x8001780", VA = "0x188002380", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000553")]
			[Cpp2IlInjected.Address(RVA = "0x8002870", Offset = "0x8001C70", VA = "0x188002870", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public IIHHIKAEMOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public CKJILLGLNDH serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public IBCDIPHCGCH roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public MEPGEDKMDKD uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public GGKMAMDIMDL roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public EBLLEPNCMBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x7FEC820", Offset = "0x7FEBC20", VA = "0x187FEC820")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<KOEDLEGFKIO> DOAOLACCHAK(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private struct LKDONDIKAMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public IIHHIKAEMOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public BBEKBLPLKNJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private EBLLEPNCMBH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private KDMPGIPNGGP <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private OJHMOJIKBMO <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private KOEDLEGFKIO <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private TaskAwaiter<KOEDLEGFKIO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x7FF90C0", Offset = "0x7FF84C0", VA = "0x187FF90C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x7FF9FA0", Offset = "0x7FF93A0", VA = "0x187FF9FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	private static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	private static readonly ABDDJEPKCOD IAEPOPBDDCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000489")]
	private readonly int PNMPDHMKPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400048A")]
	[CanBeNull]
	private readonly OIFNNMDODPC HBOAENOKJMI;

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x7FF1FE0", Offset = "0x7FF13E0", VA = "0x187FF1FE0")]
	public IIHHIKAEMOB(Guid NPMNDEDHHIJ, GGAFKPAJMJF NNEBHMDLFHI, int PNMPDHMKPJO, OIFNNMDODPC HBOAENOKJMI, BFOAALAPEEN ICDHJFGIHKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x7FF1DF0", Offset = "0x7FF11F0", VA = "0x187FF1DF0", Slot = "8")]
	[AsyncStateMachine(typeof(LKDONDIKAMM))]
	protected override Task PCKNEMBKELI(BBEKBLPLKNJ OBMIMFHGEKH, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x7FF1B20", Offset = "0x7FF0F20", VA = "0x187FF1B20")]
	private void HBLCFCBPAMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x7FF1C20", Offset = "0x7FF1020", VA = "0x187FF1C20")]
	private void MBKOPFNKEKN(HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, KDMPGIPNGGP IHPBFDHNLCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal class FDANPMIDNLA : IMFDIOOAAIF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct EPCPGKBMLJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public FDANPMIDNLA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private KDMPGIPNGGP <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private long <superRoomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private long <subRoomId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private FHGKGMPNNBH<ReadOnlySequence<byte>> <subroomDataBlobHandle>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private TaskAwaiter<ReadOnlySequence<byte>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		private TaskAwaiter<PFDCFKLNLCM> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x7FED830", Offset = "0x7FECC30", VA = "0x187FED830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x7FEE970", Offset = "0x7FEDD70", VA = "0x187FEE970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	private readonly int PNMPDHMKPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	private readonly OIFNNMDODPC HBOAENOKJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	private Func<IPEJPHCMEGJ, IPEJPHCMEGJ> HENCKODCDJF;

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x7FEEB10", Offset = "0x7FEDF10", VA = "0x187FEEB10")]
	public FDANPMIDNLA(Guid NPMNDEDHHIJ, GGAFKPAJMJF NNEBHMDLFHI, int PNMPDHMKPJO, OIFNNMDODPC HBOAENOKJMI, Func<IPEJPHCMEGJ, IPEJPHCMEGJ> HENCKODCDJF, BFOAALAPEEN ICDHJFGIHKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x7FEE9D0", Offset = "0x7FEDDD0", VA = "0x187FEE9D0", Slot = "7")]
	[AsyncStateMachine(typeof(EPCPGKBMLJM))]
	protected override Task OBEADLEOIED(BBEKBLPLKNJ OBMIMFHGEKH, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
internal abstract class LBPHHFCCKPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public readonly IMFDIOOAAIF PMCHJLNGKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public readonly BBEKBLPLKNJ FEACOBKIAKL;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public IFFMIKJIEPF OGNNDGMLFKL
	{
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x7FF8870", Offset = "0x7FF7C70", VA = "0x187FF8870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public OAJMAHCOGME MJEJCKIGNCH
	{
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x7FF87E0", Offset = "0x7FF7BE0", VA = "0x187FF87E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x7FF88C0", Offset = "0x7FF7CC0", VA = "0x187FF88C0")]
	protected LBPHHFCCKPL(BBEKBLPLKNJ OBMIMFHGEKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x7FF86D0", Offset = "0x7FF7AD0", VA = "0x187FF86D0")]
	protected void DLBCFJLNCHA(string DLIGPOGBAFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
internal struct MCCKBPLKAGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public Dictionary<Guid, List<FCJCKALOIJJ>> KIFPKLLJLMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public Dictionary<Guid, List<FCJCKALOIJJ>> DNHFPGONEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public Dictionary<Guid, List<FCJCKALOIJJ>> MIPIKJKIEHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public List<Guid> NJBLFBOPCNH;

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x7FFA6D0", Offset = "0x7FF9AD0", VA = "0x187FFA6D0")]
	public static MCCKBPLKAGM CNKKCIMLPML(IFFMIKJIEPF MFCHJJKNFDE, CNMGOCEKCNJ OKMOMAIGKJG, CFLKKNKAIAK BJDLKEJBJLL)
	{
		return default(MCCKBPLKAGM);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000137")]
internal struct FENBHBDDDPG
{
	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10")]
	public static FENBHBDDDPG DCJNBNANGBG()
	{
		return default(FENBHBDDDPG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal struct FHHLFNCEPNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public readonly KDNGIJKMAJN KECIPBKCBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public readonly FEOHBPOKLEE JFLEAPKANBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public readonly Guid? PADEBAHBFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public readonly IReadOnlyCollection<DCNOJEHNBBC> IPAAGEDONDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public readonly IReadOnlyCollection<DCNOJEHNBBC> HECPBDOGLLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public readonly PGNIPJOEHNG EDHFJOANBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public readonly PGNIPJOEHNG FDCGPHOJGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public readonly KPNAPGNHCBJ BHPCICOOIHC;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool MADLKHHIHJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x7FEEBD0", Offset = "0x7FEDFD0", VA = "0x187FEEBD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x7FEEC60", Offset = "0x7FEE060", VA = "0x187FEEC60")]
	public FHHLFNCEPNK(KDNGIJKMAJN KECIPBKCBHF, FEOHBPOKLEE JFLEAPKANBH, Guid? PADEBAHBFEO, IReadOnlyList<DCNOJEHNBBC> IPAAGEDONDC, IReadOnlyCollection<DCNOJEHNBBC> HECPBDOGLLL, PGNIPJOEHNG EDHFJOANBFH, PGNIPJOEHNG FDCGPHOJGDK, KPNAPGNHCBJ BHPCICOOIHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct PFKABLJGGMN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	private readonly BBEKBLPLKNJ OBMIMFHGEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	private readonly Guid IAHHGHKNCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	private bool NIGNBIDEMPO;

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x7FFFDD0", Offset = "0x7FFF1D0", VA = "0x187FFFDD0")]
	public static PFKABLJGGMN PFENOOGPMJA(BBEKBLPLKNJ OBMIMFHGEKH)
	{
		return default(PFKABLJGGMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x10CD0F0", Offset = "0x10CC4F0", VA = "0x1810CD0F0")]
	public void IIKKIBDBEOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x7FFFAF0", Offset = "0x7FFEEF0", VA = "0x187FFFAF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x7FFFE00", Offset = "0x7FFF200", VA = "0x187FFFE00")]
	private PFKABLJGGMN(BBEKBLPLKNJ OBMIMFHGEKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x7FFFB00", Offset = "0x7FFEF00", VA = "0x187FFFB00")]
	private void EHNFIFLEBMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x7FFFD30", Offset = "0x7FFF130", VA = "0x187FFFD30")]
	private Func<Guid, bool> MJJPKGLFCEH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal class OJHMOJIKBMO : LBPHHFCCKPL, EMCCFILHLEN
{
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	public delegate Task<CNMGOCEKCNJ> DCACEOBNHEM(CFLKKNKAIAK AMHCLKHIFKH, IGFHAMJOMKM AINGIBCCBIP, CMIBACOKHIM MJMGCDGPNJD, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct NBMNNOAKFPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public OJHMOJIKBMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public JGCMJADBFFC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private PFKABLJGGMN <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private TaskAwaiter<KOEDLEGFKIO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x7FFC0B0", Offset = "0x7FFB4B0", VA = "0x187FFC0B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x7FFC980", Offset = "0x7FFBD80", VA = "0x187FFC980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private struct PLFLACHNDJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public AsyncTaskMethodBuilder<KOEDLEGFKIO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public OJHMOJIKBMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public JGCMJADBFFC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		private TaskAwaiter<KOEDLEGFKIO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x8000630", Offset = "0x7FFFA30", VA = "0x188000630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x8000A60", Offset = "0x7FFFE60", VA = "0x188000A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private struct JNIAMLBBEGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public OJHMOJIKBMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public JGCMJADBFFC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x7FF7180", Offset = "0x7FF6580", VA = "0x187FF7180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x7FF77C0", Offset = "0x7FF6BC0", VA = "0x187FF77C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private sealed class ABEKNMMDHLM
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
			public AsyncTaskMethodBuilder<FHHLFNCEPNK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004F3")]
			public ABEKNMMDHLM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F4")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004F5")]
			private FHHLFNCEPNK <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40004F6")]
			private TaskAwaiter<CNMGOCEKCNJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40004F7")]
			private TaskAwaiter<FHHLFNCEPNK> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005A0")]
			[Cpp2IlInjected.Address(RVA = "0x8001430", Offset = "0x8000830", VA = "0x188001430", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0x8001C20", Offset = "0x8001020", VA = "0x188001C20", Slot = "5")]
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
			public AsyncTaskMethodBuilder<CFLKKNKAIAK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004FA")]
			public ABEKNMMDHLM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004FB")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004FC")]
			private CFLKKNKAIAK <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004FD")]
			private TaskAwaiter<CNMGOCEKCNJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004FE")]
			private TaskAwaiter<CFLKKNKAIAK> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005A2")]
			[Cpp2IlInjected.Address(RVA = "0x8001C90", Offset = "0x8001090", VA = "0x188001C90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A3")]
			[Cpp2IlInjected.Address(RVA = "0x8002310", Offset = "0x8001710", VA = "0x188002310", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public OJHMOJIKBMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public JGCMJADBFFC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public CMIBACOKHIM preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public CMIBACOKHIM downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public FHHLFNCEPNK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public CMIBACOKHIM postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public CFLKKNKAIAK phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public PKKJGLJEKIC.LEEPLEBKEAD <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public ABEKNMMDHLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x7FE6370", Offset = "0x7FE5770", VA = "0x187FE6370")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<FHHLFNCEPNK> HEFOMHLBFMJ(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x7FE6660", Offset = "0x7FE5A60", VA = "0x187FE6660")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<CFLKKNKAIAK> PGINIKGPPFC(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x7FE6620", Offset = "0x7FE5A20", VA = "0x187FE6620")]
		internal void OOMCGDNIBHD(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x7FE64C0", Offset = "0x7FE58C0", VA = "0x187FE64C0")]
		internal Task KBNPKMOJEGB(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x7FE6210", Offset = "0x7FE5610", VA = "0x187FE6210")]
		internal Task EDMDEOGBEME(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct ECKCLAHHLDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public OJHMOJIKBMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public JGCMJADBFFC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private ABEKNMMDHLM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private TaskAwaiter<FHHLFNCEPNK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private TaskAwaiter<CFLKKNKAIAK> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x7FEC940", Offset = "0x7FEBD40", VA = "0x187FEC940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x7FED690", Offset = "0x7FECA90", VA = "0x187FED690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private struct JJKDNEPGLML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public OJHMOJIKBMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public CFLKKNKAIAK phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public CMIBACOKHIM postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		private TaskAwaiter<CNMGOCEKCNJ> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private IGFHAMJOMKM <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x7FF4280", Offset = "0x7FF3680", VA = "0x187FF4280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x7FF5390", Offset = "0x7FF4790", VA = "0x187FF5390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct HOOJFNGGIID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public OJHMOJIKBMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x800CA30", Offset = "0x800BE30", VA = "0x18800CA30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x800D210", Offset = "0x800C610", VA = "0x18800D210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct KFHHAGOGOOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public OJHMOJIKBMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public CFLKKNKAIAK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public CMIBACOKHIM progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private TaskAwaiter<CNMGOCEKCNJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x8010CB0", Offset = "0x80100B0", VA = "0x188010CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x80114F0", Offset = "0x80108F0", VA = "0x1880114F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private struct PBNDOBPDOOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public AsyncTaskMethodBuilder<CNMGOCEKCNJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public OJHMOJIKBMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public CFLKKNKAIAK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public CMIBACOKHIM progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		private TaskAwaiter<CNMGOCEKCNJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x8018510", Offset = "0x8017910", VA = "0x188018510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x80194D0", Offset = "0x80188D0", VA = "0x1880194D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct GEGNADCDPHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public AsyncTaskMethodBuilder<CNMGOCEKCNJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public OJHMOJIKBMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public CFLKKNKAIAK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public CMIBACOKHIM progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public IGFHAMJOMKM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private TaskAwaiter<CNMGOCEKCNJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x800A1A0", Offset = "0x80095A0", VA = "0x18800A1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x800B2B0", Offset = "0x800A6B0", VA = "0x18800B2B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct JCBJHGBLFJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public AsyncTaskMethodBuilder<CNMGOCEKCNJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public OJHMOJIKBMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public CNMGOCEKCNJ operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public CMIBACOKHIM progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public CFLKKNKAIAK deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private TaskAwaiter<CNMGOCEKCNJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x800F040", Offset = "0x800E440", VA = "0x18800F040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x800F290", Offset = "0x800E690", VA = "0x18800F290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private sealed class KNNEOOLEHKJ
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
			public AsyncTaskMethodBuilder<CNMGOCEKCNJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000550")]
			public KNNEOOLEHKJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000551")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000552")]
			private PEPIFLGHCHM <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000553")]
			private TaskAwaiter<CNMGOCEKCNJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005BA")]
			[Cpp2IlInjected.Address(RVA = "0x801AAA0", Offset = "0x8019EA0", VA = "0x18801AAA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BB")]
			[Cpp2IlInjected.Address(RVA = "0x801B0C0", Offset = "0x801A4C0", VA = "0x18801B0C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public OJHMOJIKBMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public CFLKKNKAIAK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public CMIBACOKHIM progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public DCACEOBNHEM masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public IGFHAMJOMKM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public CNMGOCEKCNJ originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public KNNEOOLEHKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x80124E0", Offset = "0x80118E0", VA = "0x1880124E0")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<CNMGOCEKCNJ> IGKJPIAGNJM(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct PAGJJKFBCEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public AsyncTaskMethodBuilder<CNMGOCEKCNJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public OJHMOJIKBMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public CFLKKNKAIAK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public CMIBACOKHIM progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public DCACEOBNHEM masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public IGFHAMJOMKM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private PEPIFLGHCHM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		private TaskAwaiter<CNMGOCEKCNJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x8017F80", Offset = "0x8017380", VA = "0x188017F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x80184A0", Offset = "0x80178A0", VA = "0x1880184A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct MLLGCLBNOHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public OJHMOJIKBMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public CFLKKNKAIAK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public CMIBACOKHIM progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		private CNMGOCEKCNJ <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		private IEnumerator<CNMGOCEKCNJ> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		private TaskAwaiter<CNMGOCEKCNJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x80154D0", Offset = "0x80148D0", VA = "0x1880154D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x8015A30", Offset = "0x8014E30", VA = "0x188015A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private struct OFHHIJDMKCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public OJHMOJIKBMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public CFLKKNKAIAK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

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
		[Cpp2IlInjected.Address(RVA = "0x80171D0", Offset = "0x80165D0", VA = "0x1880171D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x80174C0", Offset = "0x80168C0", VA = "0x1880174C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct HPJDMEIODPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public OJHMOJIKBMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public CFLKKNKAIAK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x800D270", Offset = "0x800C670", VA = "0x18800D270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x800D490", Offset = "0x800C890", VA = "0x18800D490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private sealed class MLBFOPIKBOM
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
			public AsyncTaskMethodBuilder<CNMGOCEKCNJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400057A")]
			public MLBFOPIKBOM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400057B")]
			public CFLKKNKAIAK data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400057C")]
			public CMIBACOKHIM progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400057D")]
			public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400057E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400057F")]
			private TaskAwaiter<CNMGOCEKCNJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000580")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000581")]
			private TaskAwaiter<ILMGNGONJNA> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0x801B130", Offset = "0x801A530", VA = "0x18801B130", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0x801BC00", Offset = "0x801B000", VA = "0x18801BC00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public OJHMOJIKBMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public BAKLFNIJNLG mainLoadService;

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public MLBFOPIKBOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x8015370", Offset = "0x8014770", VA = "0x188015370")]
		[AsyncStateMachine(typeof(<<RoomV2LoadLogic>b__0>d))]
		internal Task<CNMGOCEKCNJ> COAFOGMFCNJ(CFLKKNKAIAK data, IGFHAMJOMKM _, CMIBACOKHIM progressTracker, HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct LGOOMIPOCNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public OJHMOJIKBMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public CFLKKNKAIAK phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public CMIBACOKHIM postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private MLBFOPIKBOM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private IGFHAMJOMKM <timedYielder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private TaskAwaiter<CNMGOCEKCNJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x80134A0", Offset = "0x80128A0", VA = "0x1880134A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x8014370", Offset = "0x8013770", VA = "0x188014370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private struct JDBBJCIPDCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public OJHMOJIKBMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public CFLKKNKAIAK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x800F300", Offset = "0x800E700", VA = "0x18800F300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x800F700", Offset = "0x800EB00", VA = "0x18800F700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct ODMHBEBPLCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public AsyncTaskMethodBuilder<CNMGOCEKCNJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public OJHMOJIKBMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public CFLKKNKAIAK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public CMIBACOKHIM progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		private TaskAwaiter<CNMGOCEKCNJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x8016B40", Offset = "0x8015F40", VA = "0x188016B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x8017160", Offset = "0x8016560", VA = "0x188017160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	private readonly NIOICMFLLAK DGJACHPANPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	private readonly NIOICMFLLAK EJOBJDMIJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	private readonly DFOPGDIDDDM AMGKGNHPMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	private readonly IBKJCEELKEI BEMOPAHNLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	private readonly GJFCDFDMMPM LJHEAPOAKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	private ProfilerCounterValue<int> DANPHKFGJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	private readonly MIHMEPLBLHG ADJNOCPGOCM;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	private GGAFKPAJMJF COEODMFJGAB
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x7FFDA10", Offset = "0x7FFCE10", VA = "0x187FFDA10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event CDKMFFODKCF GLFDMFDCLGP
	{
		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x7FFE2F0", Offset = "0x7FFD6F0", VA = "0x187FFE2F0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x7FFE8C0", Offset = "0x7FFDCC0", VA = "0x187FFE8C0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x7FFEE10", Offset = "0x7FFE210", VA = "0x187FFEE10")]
	public OJHMOJIKBMO(BBEKBLPLKNJ OBMIMFHGEKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x7FFDA40", Offset = "0x7FFCE40", VA = "0x187FFDA40")]
	[AsyncStateMachine(typeof(NBMNNOAKFPE))]
	public Task FPFIKNIOMID(JGCMJADBFFC INLHACAOAMD, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x7FFDB90", Offset = "0x7FFCF90", VA = "0x187FFDB90")]
	[AsyncStateMachine(typeof(PLFLACHNDJN))]
	private Task<KOEDLEGFKIO> IBEKDIJDOKG(JGCMJADBFFC INLHACAOAMD, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x7FFE460", Offset = "0x7FFD860", VA = "0x187FFE460")]
	[AsyncStateMachine(typeof(JNIAMLBBEGN))]
	private Task MGMEPIBAMFN(JGCMJADBFFC INLHACAOAMD, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD250", Offset = "0x7FFC650", VA = "0x187FFD250")]
	[AsyncStateMachine(typeof(ECKCLAHHLDO))]
	private Task ANJJCGGFPLH(JGCMJADBFFC INLHACAOAMD, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken IDMAKOPNBEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x7FFECC0", Offset = "0x7FFE0C0", VA = "0x187FFECC0")]
	[AsyncStateMachine(typeof(JJKDNEPGLML))]
	private Task POAOHLPOPNO(CFLKKNKAIAK KHGMFLMBKMH, CMIBACOKHIM BGKCJMGNKCB, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken DKPPNFFDIGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x7FFE8E0", Offset = "0x7FFDCE0", VA = "0x187FFE8E0")]
	[AsyncStateMachine(typeof(HOOJFNGGIID))]
	private Task NPIDFFMOMDL(HOEFFPEDKPI<string>.AEKMEBIOPMA AOBIHHLEODI, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x7FFE5A0", Offset = "0x7FFD9A0", VA = "0x187FFE5A0")]
	[AsyncStateMachine(typeof(KFHHAGOGOOJ))]
	private Task MNDMCMCDEFG(CFLKKNKAIAK AMHCLKHIFKH, CMIBACOKHIM MJMGCDGPNJD, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x7FFDE60", Offset = "0x7FFD260", VA = "0x187FFDE60")]
	[AsyncStateMachine(typeof(PBNDOBPDOOM))]
	private Task<CNMGOCEKCNJ> IPEOMNDFAJC(CFLKKNKAIAK AMHCLKHIFKH, IGFHAMJOMKM JDLLAINBMCJ, CMIBACOKHIM MJMGCDGPNJD, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD750", Offset = "0x7FFCB50", VA = "0x187FFD750")]
	[AsyncStateMachine(typeof(GEGNADCDPHP))]
	private Task<CNMGOCEKCNJ> EOFGEELDGMD(CFLKKNKAIAK AMHCLKHIFKH, IGFHAMJOMKM JDLLAINBMCJ, CMIBACOKHIM MJMGCDGPNJD, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x7FFEB40", Offset = "0x7FFDF40", VA = "0x187FFEB40")]
	[AsyncStateMachine(typeof(JCBJHGBLFJB))]
	private Task<CNMGOCEKCNJ> PFOEAPECPEP(CNMGOCEKCNJ OKMOMAIGKJG, CFLKKNKAIAK BJDLKEJBJLL, CMIBACOKHIM MJMGCDGPNJD, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH, bool LBKMNLEIJIB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x7FFDD50", Offset = "0x7FFD150", VA = "0x187FFDD50")]
	private bool IIPDIBKBKDK(CFLKKNKAIAK KHGMFLMBKMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD460", Offset = "0x7FFC860", VA = "0x187FFD460")]
	[AsyncStateMachine(typeof(PAGJJKFBCEM))]
	protected Task<CNMGOCEKCNJ> DGAPDIKEIGI(CFLKKNKAIAK AMHCLKHIFKH, IGFHAMJOMKM JDLLAINBMCJ, CMIBACOKHIM MJMGCDGPNJD, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH, DCACEOBNHEM ONFOGJHBKCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x7FFE310", Offset = "0x7FFD710", VA = "0x187FFE310")]
	[AsyncStateMachine(typeof(MLLGCLBNOHD))]
	private Task MAMDKJCJHAM(CFLKKNKAIAK AMHCLKHIFKH, CMIBACOKHIM MJMGCDGPNJD, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD700", Offset = "0x7FFCB00", VA = "0x187FFD700")]
	private void EICEJCLMEFL(CNMGOCEKCNJ KPHPAAJKPFJ, CMIBACOKHIM MJMGCDGPNJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x7FFE2B0", Offset = "0x7FFD6B0", VA = "0x187FFE2B0")]
	private void LOJLMAAJEHJ(CNMGOCEKCNJ IKPIHIGENPB, [Out] CNMGOCEKCNJ MIDLEPGHLGH, [Out] CNMGOCEKCNJ KOIKBJBGBJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x7FFDCF0", Offset = "0x7FFD0F0", VA = "0x187FFDCF0")]
	private Task<FHHLFNCEPNK> IEOKBKOCBCG(JGCMJADBFFC INLHACAOAMD, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x7FFDFC0", Offset = "0x7FFD3C0", VA = "0x187FFDFC0")]
	private Task<CFLKKNKAIAK> JAMLOGPJCCH(FHHLFNCEPNK AMHCLKHIFKH, PKKJGLJEKIC.LEEPLEBKEAD IGBNBACADMP, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x7FFE770", Offset = "0x7FFDB70", VA = "0x187FFE770")]
	[AsyncStateMachine(typeof(OFHHIJDMKCA))]
	private Task NGACKGFHHNC(CFLKKNKAIAK AMHCLKHIFKH, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH, bool MHEDJCDLGGK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD5F0", Offset = "0x7FFC9F0", VA = "0x187FFD5F0")]
	[AsyncStateMachine(typeof(HPJDMEIODPJ))]
	private Task EGLNPKCALAL(CFLKKNKAIAK AMHCLKHIFKH, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x7FFE000", Offset = "0x7FFD400", VA = "0x187FFE000")]
	private Task JCKMOGMONOC(CFLKKNKAIAK AMHCLKHIFKH, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x7FFE750", Offset = "0x7FFDB50", VA = "0x187FFE750")]
	private Task NBELBDDIGON(CFLKKNKAIAK AMHCLKHIFKH, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD6E0", Offset = "0x7FFCAE0", VA = "0x187FFD6E0")]
	private Task EHIOANEOKKD(CFLKKNKAIAK AMHCLKHIFKH, IGFHAMJOMKM JDLLAINBMCJ, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x7FFDE40", Offset = "0x7FFD240", VA = "0x187FFDE40")]
	private Task INOAJDJICKL(CFLKKNKAIAK AMHCLKHIFKH, IGFHAMJOMKM JDLLAINBMCJ, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x7FFE740", Offset = "0x7FFDB40", VA = "0x187FFE740")]
	private static Task MPOAJKJDNBK(CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x7FFDD30", Offset = "0x7FFD130", VA = "0x187FFDD30")]
	private Task IGCELADJHCK(CFLKKNKAIAK AMHCLKHIFKH, IGFHAMJOMKM JDLLAINBMCJ, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD440", Offset = "0x7FFC840", VA = "0x187FFD440")]
	private Task CNLBIMMPAAK(CFLKKNKAIAK AMHCLKHIFKH, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x7FFE6F0", Offset = "0x7FFDAF0", VA = "0x187FFE6F0")]
	private void MPEPPDOHNJL(JGCMJADBFFC INLHACAOAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD390", Offset = "0x7FFC790", VA = "0x187FFD390")]
	public void BILDMJMOJHC(long OCCKLCFPOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340")]
	private static void PADJHAOENKG(KDNGIJKMAJN KECIPBKCBHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x7FFE9F0", Offset = "0x7FFDDF0", VA = "0x187FFE9F0")]
	[AsyncStateMachine(typeof(LGOOMIPOCNA))]
	private Task OJKKMNMGCCO(CFLKKNKAIAK KHGMFLMBKMH, CMIBACOKHIM BGKCJMGNKCB, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken DKPPNFFDIGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD8D0", Offset = "0x7FFCCD0", VA = "0x187FFD8D0")]
	[AsyncStateMachine(typeof(JDBBJCIPDCP))]
	private Task EONMIJOMMGP(CFLKKNKAIAK AMHCLKHIFKH, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x7FFE030", Offset = "0x7FFD430", VA = "0x187FFE030")]
	private static OMPLJGIOMFD JJFFECMMAJM(CFLKKNKAIAK BJDLKEJBJLL)
	{
		return default(OMPLJGIOMFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x7FFE150", Offset = "0x7FFD550", VA = "0x187FFE150")]
	[AsyncStateMachine(typeof(ODMHBEBPLCD))]
	private Task<CNMGOCEKCNJ> KBJKNMFDKBG(CFLKKNKAIAK AMHCLKHIFKH, IGFHAMJOMKM JDLLAINBMCJ, CMIBACOKHIM MJMGCDGPNJD, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340")]
	private void BDBMONCHPNI(CNMGOCEKCNJ BEOBAENHOED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000155")]
internal struct FJKBMOFJBOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059E")]
	private GGAFKPAJMJF NNEBHMDLFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400059F")]
	private CFLKKNKAIAK AMHCLKHIFKH;

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	private IFFMIKJIEPF OGNNDGMLFKL
	{
		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x8009B40", Offset = "0x8008F40", VA = "0x188009B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x8009A60", Offset = "0x8008E60", VA = "0x188009A60")]
	public static Task CAFDDKMELKN(GGAFKPAJMJF NNEBHMDLFHI, CFLKKNKAIAK AMHCLKHIFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x8009840", Offset = "0x8008C40", VA = "0x188009840")]
	private void CAFDDKMELKN()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal struct EJLENLLEDCE
{
	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x80093D0", Offset = "0x80087D0", VA = "0x1880093D0")]
	public static Task CAFDDKMELKN(CancellationToken BLABAMPAGAH)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000157")]
internal struct GHDBAGOPNKM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private struct ADBEAAOACFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public BBEKBLPLKNJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public CFLKKNKAIAK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private PEPIFLGHCHM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x8002FB0", Offset = "0x80023B0", VA = "0x188002FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x80034E0", Offset = "0x80028E0", VA = "0x1880034E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x800B5F0", Offset = "0x800A9F0", VA = "0x18800B5F0")]
	[AsyncStateMachine(typeof(ADBEAAOACFP))]
	public static Task CAFDDKMELKN(BBEKBLPLKNJ OBMIMFHGEKH, CFLKKNKAIAK AMHCLKHIFKH, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal struct BDANCODMIPB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private struct MHKJBEIBHDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public BBEKBLPLKNJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public CFLKKNKAIAK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public IGFHAMJOMKM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		private GGAFKPAJMJF <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		private IFFMIKJIEPF <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		private CNMGOCEKCNJ <operationState>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private bool <isMaster>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private PEPIFLGHCHM <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		private List<(PersistenceView, EBFEMKEPGFD)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		private EBFEMKEPGFD <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x8014640", Offset = "0x8013A40", VA = "0x188014640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x8015310", Offset = "0x8014710", VA = "0x188015310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x8004590", Offset = "0x8003990", VA = "0x188004590")]
	[AsyncStateMachine(typeof(MHKJBEIBHDO))]
	public static Task CAFDDKMELKN(BBEKBLPLKNJ OBMIMFHGEKH, CFLKKNKAIAK AMHCLKHIFKH, IGFHAMJOMKM JDLLAINBMCJ, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x80046E0", Offset = "0x8003AE0", VA = "0x1880046E0")]
	private static void FGEDOKHKAAD(PersistenceView FEDEGDPKLDC, EBFEMKEPGFD IBPIFPONGON, CFLKKNKAIAK AMHCLKHIFKH, CNMGOCEKCNJ OKMOMAIGKJG, bool JKCKDKDDDOK)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal struct GNIKHOCHINI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct DDHGMFKKHJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public GGAFKPAJMJF roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public CFLKKNKAIAK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private PEPIFLGHCHM <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x8007030", Offset = "0x8006430", VA = "0x188007030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x8007650", Offset = "0x8006A50", VA = "0x188007650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(RVA = "0x800BAC0", Offset = "0x800AEC0", VA = "0x18800BAC0")]
	[AsyncStateMachine(typeof(DDHGMFKKHJK))]
	public static Task CAFDDKMELKN(GGAFKPAJMJF NNEBHMDLFHI, CFLKKNKAIAK AMHCLKHIFKH, CancellationToken BLABAMPAGAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal struct LFEDIICOBOO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private struct IELMNCDABCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public GGAFKPAJMJF roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public CFLKKNKAIAK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public BBEKBLPLKNJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x800E400", Offset = "0x800D800", VA = "0x18800E400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x800E610", Offset = "0x800DA10", VA = "0x18800E610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class GEGMAJJCGCN
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
			public HOEFFPEDKPI<string>.AEKMEBIOPMA timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005D5")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005D6")]
			public GEGMAJJCGCN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005D7")]
			private HOEFFPEDKPI<string>.AEKMEBIOPMA <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005D8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005EA")]
			[Cpp2IlInjected.Address(RVA = "0x801BF90", Offset = "0x801B390", VA = "0x18801BF90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EB")]
			[Cpp2IlInjected.Address(RVA = "0x801C320", Offset = "0x801B720", VA = "0x18801C320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public GEGMAJJCGCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x800A080", Offset = "0x8009480", VA = "0x18800A080")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task PHMHKMNANNC(HOEFFPEDKPI<string>.AEKMEBIOPMA timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private struct JGLMJLFOHGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public LFEDIICOBOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		private PEPIFLGHCHM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		private PEPIFLGHCHM <_>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private TaskAwaiter<KOEDLEGFKIO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x800F760", Offset = "0x800EB60", VA = "0x18800F760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x8010370", Offset = "0x800F770", VA = "0x188010370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private sealed class KGMFGJBADJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public OLMIOOOKIFM version;

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
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public KGMFGJBADJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x8011600", Offset = "0x8010A00", VA = "0x188011600")]
		internal object LNFNDEEPCCB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x8011550", Offset = "0x8010950", VA = "0x188011550")]
		internal object DDNBLOHAAHP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C3")]
	private GGAFKPAJMJF NNEBHMDLFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005C4")]
	private CFLKKNKAIAK AMHCLKHIFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C5")]
	private BBEKBLPLKNJ OBMIMFHGEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	private bool MHEDJCDLGGK;

	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	private static readonly ByteString OHMJHNJHAHB;

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private IFFMIKJIEPF OGNNDGMLFKL
	{
		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x8012BF0", Offset = "0x8011FF0", VA = "0x188012BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	private OAJMAHCOGME MJEJCKIGNCH
	{
		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x8012B50", Offset = "0x8011F50", VA = "0x188012B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x80129C0", Offset = "0x8011DC0", VA = "0x1880129C0")]
	[AsyncStateMachine(typeof(IELMNCDABCG))]
	public static Task CAFDDKMELKN(GGAFKPAJMJF NNEBHMDLFHI, CFLKKNKAIAK AMHCLKHIFKH, BBEKBLPLKNJ OBMIMFHGEKH, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH, bool MHEDJCDLGGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x8012890", Offset = "0x8011C90", VA = "0x188012890")]
	[AsyncStateMachine(typeof(JGLMJLFOHGD))]
	private Task CAFDDKMELKN(HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x8012C40", Offset = "0x8012040", VA = "0x188012C40")]
	private void OMPKEOMJGDL([NotNull] BPGLDJMOGPH MAJENMBDEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x8012B10", Offset = "0x8011F10", VA = "0x188012B10")]
	private bool FDJMFGKBKJJ(OLMIOOOKIFM DFDKLALNEIC, BPGLDJMOGPH MAJENMBDEJN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
internal struct CFAIFAIOILF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private struct HFJAJGHGDOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public AsyncTaskMethodBuilder<CFLKKNKAIAK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public CFAIFAIOILF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public PKKJGLJEKIC.LEEPLEBKEAD downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private PEPIFLGHCHM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private TaskAwaiter<IReadOnlyCollection<DCNOJEHNBBC>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private TaskAwaiter<(AEAAIINGJNL<AAHFAAICCFI, BPMPLDFNAFC>, AEAAIINGJNL<NJNFGEEDFLI<BPGLDJMOGPH>, BPMPLDFNAFC>, AEAAIINGJNL<NJNFGEEDFLI<EKENJADJMDF>, BPMPLDFNAFC>, AEAAIINGJNL<NJNFGEEDFLI<IEnumerable<EGKNKDEIGBO>>, BPMPLDFNAFC>, AEAAIINGJNL<NJNFGEEDFLI<KBLNENNOAFL>, BPMPLDFNAFC>)> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x800BBE0", Offset = "0x800AFE0", VA = "0x18800BBE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x800C9C0", Offset = "0x800BDC0", VA = "0x18800C9C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private struct OIIOJIDGJAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<AAHFAAICCFI, BPMPLDFNAFC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public CFAIFAIOILF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public IReadOnlyCollection<DCNOJEHNBBC> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public IReadOnlyCollection<DCNOJEHNBBC> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public PKKJGLJEKIC.LEEPLEBKEAD downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		private PEPIFLGHCHM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		private TaskAwaiter<AEAAIINGJNL<AAHFAAICCFI, BPMPLDFNAFC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x8017520", Offset = "0x8016920", VA = "0x188017520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x8017B80", Offset = "0x8016F80", VA = "0x188017B80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E8")]
	private GPIFECBMKGA<PGNIPJOEHNG, EKENJADJMDF> CBIHCLALPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005E9")]
	private GPIFECBMKGA<PGNIPJOEHNG, BPGLDJMOGPH> FMICKNOGDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005EA")]
	private GPIFECBMKGA<KPNAPGNHCBJ, IEnumerable<EGKNKDEIGBO>> LEIAHHMKLMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005EB")]
	private GPIFECBMKGA<long, KBLNENNOAFL> LHFAGJOJDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005EC")]
	private JGCFIAOCGKE HOCMLKFPJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005ED")]
	private KDNGIJKMAJN KECIPBKCBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005EE")]
	private FEOHBPOKLEE JFLEAPKANBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40005EF")]
	private Guid? PADEBAHBFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40005F0")]
	private IReadOnlyCollection<DCNOJEHNBBC> IPAAGEDONDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	private Task<IReadOnlyCollection<DCNOJEHNBBC>> AGANCMKPKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40005F2")]
	private PGNIPJOEHNG EDHFJOANBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40005F3")]
	private PGNIPJOEHNG FDCGPHOJGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40005F4")]
	private PGNIPJOEHNG? NLACDGFMJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40005F5")]
	private KPNAPGNHCBJ BHPCICOOIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40005F6")]
	private HOEFFPEDKPI<string>.AEKMEBIOPMA AOBIHHLEODI;

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x80055E0", Offset = "0x80049E0", VA = "0x1880055E0")]
	public static Task<CFLKKNKAIAK> BPOOHFEGCMJ(GGAFKPAJMJF NNEBHMDLFHI, [In] FHHLFNCEPNK AMHCLKHIFKH, PKKJGLJEKIC.LEEPLEBKEAD IGBNBACADMP, HOEFFPEDKPI<string>.AEKMEBIOPMA AOBIHHLEODI, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(RVA = "0x8005AE0", Offset = "0x8004EE0", VA = "0x188005AE0")]
	[AsyncStateMachine(typeof(HFJAJGHGDOE))]
	private Task<CFLKKNKAIAK> CAFDDKMELKN(PKKJGLJEKIC.LEEPLEBKEAD IGBNBACADMP, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x8005C90", Offset = "0x8005090", VA = "0x188005C90")]
	[AsyncStateMachine(typeof(OIIOJIDGJAI))]
	private Task<AEAAIINGJNL<AAHFAAICCFI, BPMPLDFNAFC>> FDHGIIEMPJL(Guid? PADEBAHBFEO, IReadOnlyCollection<DCNOJEHNBBC> IPAAGEDONDC, IReadOnlyCollection<DCNOJEHNBBC> HECPBDOGLLL, long? CCHPCHDJHAI, long? CLKFEHDHMIF, PKKJGLJEKIC.LEEPLEBKEAD IGBNBACADMP, HOEFFPEDKPI<string>.AEKMEBIOPMA KAJNIKFPJOE, CancellationToken BLABAMPAGAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
internal struct AEGDDLHJOPP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct DBPLEILAKIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		public AsyncTaskMethodBuilder<FHHLFNCEPNK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public AEGDDLHJOPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		private TaskAwaiter<FHHLFNCEPNK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x8006B70", Offset = "0x8005F70", VA = "0x188006B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x8006FC0", Offset = "0x80063C0", VA = "0x188006FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct GBEIFMJMAIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public AsyncTaskMethodBuilder<FHHLFNCEPNK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public AEGDDLHJOPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		private TaskAwaiter<FHHLFNCEPNK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x8009B90", Offset = "0x8008F90", VA = "0x188009B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x800A010", Offset = "0x8009410", VA = "0x18800A010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private sealed class GGIAFIAEFMG
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
			public GGIAFIAEFMG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000636")]
			private HOEFFPEDKPI<string>.AEKMEBIOPMA <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000637")]
			private TaskAwaiter<CMHOHMOMOEI> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000638")]
			private TaskAwaiter<PJLADDLLKED> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0x801A080", Offset = "0x8019480", VA = "0x18801A080", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0x801AA40", Offset = "0x8019E40", VA = "0x18801AA40", Slot = "5")]
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
		public JCENNCFNDPE roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public IFFMIKJIEPF callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public PGNIPJOEHNG superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public PGNIPJOEHNG subRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public IReadOnlyList<DCNOJEHNBBC> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public IReadOnlyList<DCNOJEHNBBC> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public KDNGIJKMAJN roomDetails;

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public GGIAFIAEFMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0xD94850", Offset = "0xD93C50", VA = "0x180D94850")]
		internal bool BPHHFFAJNOI(FEOHBPOKLEE sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x800B320", Offset = "0x800A720", VA = "0x18800B320")]
		[AsyncStateMachine(typeof(<<FetchRoomLoadDetails>g__getRoomSaveData|0>d))]
		internal Task AFBKJJJKLLM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x800B3F0", Offset = "0x800A7F0", VA = "0x18800B3F0")]
		internal Task<KPNAPGNHCBJ> GJIGKLHANCO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct MPDHIJDNEBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public AsyncTaskMethodBuilder<FHHLFNCEPNK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public JCENNCFNDPE roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public IFFMIKJIEPF callbacks;

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
		public PGNIPJOEHNG superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		private GGIAFIAEFMG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		private FEOHBPOKLEE <subroom>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		private Task<KPNAPGNHCBJ> <getRoomLoadDTOTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		private TaskAwaiter<KDNGIJKMAJN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		private TaskAwaiter<KPNAPGNHCBJ> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x8015A90", Offset = "0x8014E90", VA = "0x188015A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x8016A40", Offset = "0x8015E40", VA = "0x188016A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400060E")]
	private IFFMIKJIEPF MFCHJJKNFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400060F")]
	private DFOPGDIDDDM AMGKGNHPMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000610")]
	private JCENNCFNDPE IELGNIBJJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000611")]
	private HOEFFPEDKPI<string>.AEKMEBIOPMA AOBIHHLEODI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000612")]
	private long CCHPCHDJHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000613")]
	private long DCFFKJJLEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000614")]
	private long CPCDCDODJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000615")]
	private string CGOKGIMLOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000616")]
	private PGNIPJOEHNG JOEHLAAGEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000617")]
	private Guid OKFEGAJECOA;

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x8003570", Offset = "0x8002970", VA = "0x188003570")]
	public static Task<FHHLFNCEPNK> BPOOHFEGCMJ(GGAFKPAJMJF NNEBHMDLFHI, JGCMJADBFFC INLHACAOAMD, HOEFFPEDKPI<string>.AEKMEBIOPMA AOBIHHLEODI, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0x80037C0", Offset = "0x8002BC0", VA = "0x1880037C0")]
	[AsyncStateMachine(typeof(DBPLEILAKIA))]
	private Task<FHHLFNCEPNK> CAFDDKMELKN(CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x8003910", Offset = "0x8002D10", VA = "0x188003910")]
	[AsyncStateMachine(typeof(GBEIFMJMAIH))]
	private Task<FHHLFNCEPNK> IEOKBKOCBCG(HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x8003A80", Offset = "0x8002E80", VA = "0x188003A80")]
	[AsyncStateMachine(typeof(MPDHIJDNEBL))]
	private static Task<FHHLFNCEPNK> IEOKBKOCBCG(IFFMIKJIEPF MFCHJJKNFDE, JCENNCFNDPE IELGNIBJJEK, long CCHPCHDJHAI, long DCFFKJJLEHN, long CPCDCDODJDH, string CGOKGIMLOPB, PGNIPJOEHNG JOEHLAAGEDH, Guid OKFEGAJECOA, CancellationToken BLABAMPAGAH, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x8003540", Offset = "0x8002940", VA = "0x188003540")]
	private void BHPFHELMCLC(KDNGIJKMAJN KECIPBKCBHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
internal struct DIAHPMHKJLO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private struct BNINGGNEBGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public DIAHPMHKJLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x8004FF0", Offset = "0x80043F0", VA = "0x188004FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x8005580", Offset = "0x8004980", VA = "0x188005580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400064C")]
	private IFFMIKJIEPF MFCHJJKNFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400064D")]
	private CFLKKNKAIAK AMHCLKHIFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400064E")]
	private HOEFFPEDKPI<string>.AEKMEBIOPMA AOBIHHLEODI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400064F")]
	private float MLEKNAIGAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000650")]
	private float DJAPPLCMKKG;

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x80086C0", Offset = "0x8007AC0", VA = "0x1880086C0")]
	public static Task BDDNJKKJPJL(GGAFKPAJMJF NNEBHMDLFHI, CFLKKNKAIAK AMHCLKHIFKH, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0x8008860", Offset = "0x8007C60", VA = "0x188008860")]
	[AsyncStateMachine(typeof(BNINGGNEBGO))]
	public Task CAFDDKMELKN(CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x8008980", Offset = "0x8007D80", VA = "0x188008980")]
	private static void CAHCPMDONAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x8008560", Offset = "0x8007960", VA = "0x188008560")]
	private void AMJJANNCKEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x8008AB0", Offset = "0x8007EB0", VA = "0x188008AB0")]
	private static float CPAKLCBCJKH(IFFMIKJIEPF MFCHJJKNFDE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x8008B70", Offset = "0x8007F70", VA = "0x188008B70")]
	private static float INFEAACHMFG()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000170")]
internal struct LPNIIEANABI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private struct DFPCGKPPOGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public BBEKBLPLKNJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public CFLKKNKAIAK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		private PEPIFLGHCHM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		private IMFDIOOAAIF <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		private GGAFKPAJMJF <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		private CGECCKKDLDK.PFENLPPMOED <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		private TaskAwaiter<KOEDLEGFKIO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x80076B0", Offset = "0x8006AB0", VA = "0x1880076B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x8007ED0", Offset = "0x80072D0", VA = "0x188007ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private struct PAEAMPJFOBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private PEPIFLGHCHM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x8017BF0", Offset = "0x8016FF0", VA = "0x188017BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x8017F20", Offset = "0x8017320", VA = "0x188017F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x80143D0", Offset = "0x80137D0", VA = "0x1880143D0")]
	[AsyncStateMachine(typeof(DFPCGKPPOGM))]
	public static Task CAFDDKMELKN(BBEKBLPLKNJ OBMIMFHGEKH, CFLKKNKAIAK AMHCLKHIFKH, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x80145D0", Offset = "0x80139D0", VA = "0x1880145D0")]
	private static Task<KOEDLEGFKIO> JFOFGJHAIHJ(BBEKBLPLKNJ OBMIMFHGEKH, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x8014510", Offset = "0x8013910", VA = "0x188014510")]
	[AsyncStateMachine(typeof(PAEAMPJFOBG))]
	private static Task IKEHJCFLIPE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
internal struct LFDIBHPDOEE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private struct EEPFLBONKDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public LFDIBHPDOEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x8008CC0", Offset = "0x80080C0", VA = "0x188008CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x8009370", Offset = "0x8008770", VA = "0x188009370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private sealed class KLAGFIEDHKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public KLAGFIEDHKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x8012460", Offset = "0x8011860", VA = "0x188012460")]
		internal object JBPBJNOHJBO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private struct IMNMCMEFLBC : IAsyncStateMachine
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
		public LFDIBHPDOEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private PEPIFLGHCHM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x800E670", Offset = "0x800DA70", VA = "0x18800E670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x800EAF0", Offset = "0x800DEF0", VA = "0x18800EAF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066B")]
	private bool GGNBFFMFHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400066C")]
	private HOEFFPEDKPI<string>.AEKMEBIOPMA AOBIHHLEODI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400066D")]
	private GGAFKPAJMJF NNEBHMDLFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400066E")]
	private CancellationToken BLABAMPAGAH;

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x8012820", Offset = "0x8011C20", VA = "0x188012820")]
	public static Task EGNCODJFIII(GGAFKPAJMJF NNEBHMDLFHI, bool GGNBFFMFHCE, HOEFFPEDKPI<string>.AEKMEBIOPMA AOBIHHLEODI, CancellationToken CAPKGEJBGJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x8012600", Offset = "0x8011A00", VA = "0x188012600")]
	[AsyncStateMachine(typeof(EEPFLBONKDE))]
	private Task CAFDDKMELKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x80126F0", Offset = "0x8011AF0", VA = "0x1880126F0")]
	[AsyncStateMachine(typeof(IMNMCMEFLBC))]
	private Task DBMKFFHNAGA(bool KFLPFOEINCD, string CNIMAACIFLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10")]
	private bool MHFMGFKHNII(bool GGNBFFMFHCE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
internal struct FJHJGFILLIN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private struct DGBKKGHFKGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		public FJHJGFILLIN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x8007F30", Offset = "0x8007330", VA = "0x188007F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x80084A0", Offset = "0x80078A0", VA = "0x1880084A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class DHEKPFDOKLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public DHEKPFDOKLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x8008510", Offset = "0x8007910", VA = "0x188008510")]
		internal object JBPBJNOHJBO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private struct IOIPMLCMCKL : IAsyncStateMachine
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
		public FJHJGFILLIN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		private PEPIFLGHCHM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x800EB50", Offset = "0x800DF50", VA = "0x18800EB50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x800EFD0", Offset = "0x800E3D0", VA = "0x18800EFD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400067E")]
	private LMOLJMDABJO JAFMHIIFDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400067F")]
	private HOEFFPEDKPI<string>.AEKMEBIOPMA AOBIHHLEODI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000680")]
	private GGAFKPAJMJF NNEBHMDLFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000681")]
	private bool NEKLOAPOGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000682")]
	private CFLKKNKAIAK AMHCLKHIFKH;

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x8009750", Offset = "0x8008B50", VA = "0x188009750")]
	public static Task<Scene> LLJBJPIINKH(GGAFKPAJMJF NNEBHMDLFHI, LMOLJMDABJO NOLBFIOJGBD, HOEFFPEDKPI<string>.AEKMEBIOPMA AOBIHHLEODI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x80094B0", Offset = "0x80088B0", VA = "0x1880094B0")]
	[AsyncStateMachine(typeof(DGBKKGHFKGH))]
	private Task<Scene> CAFDDKMELKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x8009720", Offset = "0x8008B20", VA = "0x188009720")]
	private bool EIDGHDMEEBN(CFLKKNKAIAK AMHCLKHIFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x80097D0", Offset = "0x8008BD0", VA = "0x1880097D0")]
	private void OCPPDCLDCNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x80095D0", Offset = "0x80089D0", VA = "0x1880095D0")]
	[AsyncStateMachine(typeof(IOIPMLCMCKL))]
	private Task<Scene> DBMKFFHNAGA(string CNIMAACIFLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
internal struct GJFCDFDMMPM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private struct PIELCOIBAEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		public AsyncTaskMethodBuilder<CNMGOCEKCNJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		public GJFCDFDMMPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public CNMGOCEKCNJ nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		public CFLKKNKAIAK deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		private TaskAwaiter<CNMGOCEKCNJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x8019540", Offset = "0x8018940", VA = "0x188019540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x801A010", Offset = "0x8019410", VA = "0x18801A010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private struct JLNCEGKGNEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		public AsyncTaskMethodBuilder<CNMGOCEKCNJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		public GJFCDFDMMPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public CNMGOCEKCNJ state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		private TaskAwaiter<KOEDLEGFKIO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x80103D0", Offset = "0x800F7D0", VA = "0x1880103D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x80106B0", Offset = "0x800FAB0", VA = "0x1880106B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400068F")]
	private readonly BBEKBLPLKNJ OBMIMFHGEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000690")]
	private readonly DFOPGDIDDDM AMGKGNHPMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000691")]
	private readonly IBKJCEELKEI BEMOPAHNLDD;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private IMFDIOOAAIF PMCHJLNGKOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x6543A20", Offset = "0x6542E20", VA = "0x186543A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x800BA60", Offset = "0x800AE60", VA = "0x18800BA60")]
	public GJFCDFDMMPM(BBEKBLPLKNJ OBMIMFHGEKH, DFOPGDIDDDM AMGKGNHPMEG, IBKJCEELKEI BEMOPAHNLDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x800B8E0", Offset = "0x800ACE0", VA = "0x18800B8E0")]
	[AsyncStateMachine(typeof(PIELCOIBAEM))]
	public Task<CNMGOCEKCNJ> KPJMIGBNCND(CNMGOCEKCNJ CNMJBMCCHAN, CFLKKNKAIAK BJDLKEJBJLL, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH, bool LBKMNLEIJIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x800B750", Offset = "0x800AB50", VA = "0x18800B750")]
	[AsyncStateMachine(typeof(JLNCEGKGNEH))]
	private Task<CNMGOCEKCNJ> FJJPDPDMHFG(HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CNMGOCEKCNJ FBOKGPFKJCL, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x800B8B0", Offset = "0x800ACB0", VA = "0x18800B8B0")]
	private bool HACDCEOEOBF(CNMGOCEKCNJ KCIADIEGCCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x800B730", Offset = "0x800AB30", VA = "0x18800B730")]
	private void DLBCFJLNCHA(string JKMIMMPCKOM)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal struct CGJFIHGMMFJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private struct BDPKBOLLPGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		public IMFDIOOAAIF operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		public CFLKKNKAIAK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		public IGFHAMJOMKM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		private PEPIFLGHCHM <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		private List<(PersistenceView, EBFEMKEPGFD)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		private (PersistenceView, EBFEMKEPGFD) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x80048D0", Offset = "0x8003CD0", VA = "0x1880048D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x8004F90", Offset = "0x8004390", VA = "0x188004F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x8006940", Offset = "0x8005D40", VA = "0x188006940")]
	[AsyncStateMachine(typeof(BDPKBOLLPGM))]
	public static Task CAFDDKMELKN(IMFDIOOAAIF MEOMIMDGMJF, CFLKKNKAIAK AMHCLKHIFKH, IGFHAMJOMKM JDLLAINBMCJ, CancellationToken BLABAMPAGAH)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal struct AACDDFCACCP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct AODDGAGEDHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		public IMFDIOOAAIF operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		public CFLKKNKAIAK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public IGFHAMJOMKM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		private OLMIOOOKIFM <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		private PEPIFLGHCHM <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		private List<(PersistenceView, EBFEMKEPGFD)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		private EBFEMKEPGFD <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x8003C50", Offset = "0x8003050", VA = "0x188003C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x8004530", Offset = "0x8003930", VA = "0x188004530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x8002E70", Offset = "0x8002270", VA = "0x188002E70")]
	[AsyncStateMachine(typeof(AODDGAGEDHP))]
	public static Task CAFDDKMELKN(IMFDIOOAAIF MEOMIMDGMJF, CFLKKNKAIAK AMHCLKHIFKH, IGFHAMJOMKM JDLLAINBMCJ, CancellationToken BLABAMPAGAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
internal struct CGECCKKDLDK
{
	[Cpp2IlInjected.Token(Token = "0x2000183")]
	public struct PFENLPPMOED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public List<NNBDDFDNPNN> JAIHPBAFLEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		public List<EBFEMKEPGFD> OKDBEBOIPJL;

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x9F9CA0", Offset = "0x9F90A0", VA = "0x1809F9CA0")]
		public PFENLPPMOED(List<NNBDDFDNPNN> JAIHPBAFLEI, List<EBFEMKEPGFD> OKDBEBOIPJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private sealed class DKJOEFHGJBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		public IEnumerable<NNBDDFDNPNN> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public DKJOEFHGJBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x8008B90", Offset = "0x8007F90", VA = "0x188008B90")]
		internal object DOGNENBKAPH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006BE")]
	private GGAFKPAJMJF NNEBHMDLFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006BF")]
	private CFLKKNKAIAK AMHCLKHIFKH;

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private IFFMIKJIEPF OGNNDGMLFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x80068F0", Offset = "0x8005CF0", VA = "0x1880068F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0x8006110", Offset = "0x8005510", VA = "0x188006110")]
	public static PFENLPPMOED CAFDDKMELKN(GGAFKPAJMJF NNEBHMDLFHI, CFLKKNKAIAK AMHCLKHIFKH)
	{
		return default(PFENLPPMOED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x8005EC0", Offset = "0x80052C0", VA = "0x188005EC0")]
	private PFENLPPMOED CAFDDKMELKN()
	{
		return default(PFENLPPMOED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(RVA = "0x8006170", Offset = "0x8005570", VA = "0x188006170")]
	private PFENLPPMOED FJPOJMOAHNL(BPGLDJMOGPH MAJENMBDEJN, OLMIOOOKIFM JGMFBKOBNEC)
	{
		return default(PFENLPPMOED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(RVA = "0x8006720", Offset = "0x8005B20", VA = "0x188006720")]
	private bool GLPCKMPCBOL(IEnumerable<NNBDDFDNPNN> JAIHPBAFLEI)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000185")]
internal struct KJPFIILPMAD
{
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	private sealed class DOFEIEEACHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public CGECCKKDLDK.PFENLPPMOED instantiations;

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public DOFEIEEACHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x8008C10", Offset = "0x8008010", VA = "0x188008C10")]
		internal object PHMHKMNANNC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[CompilerGenerated]
	private sealed class NMFGMCNDMDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public NMFGMCNDMDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x8016AB0", Offset = "0x8015EB0", VA = "0x188016AB0")]
		internal object GIGOKOGEOBJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x8011EB0", Offset = "0x80112B0", VA = "0x188011EB0")]
	public static void CAFDDKMELKN(IMFDIOOAAIF MEOMIMDGMJF, CFLKKNKAIAK AMHCLKHIFKH, CGECCKKDLDK.PFENLPPMOED HKOCOFMBDCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
internal class IBKJCEELKEI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private struct KJCGCCADFMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		public IBKJCEELKEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		public CNMGOCEKCNJ operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		public CFLKKNKAIAK deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x80116E0", Offset = "0x8010AE0", VA = "0x1880116E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x8011E50", Offset = "0x8011250", VA = "0x188011E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private sealed class CNBJACFFDEA
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
			public CNBJACFFDEA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006D7")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006D8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000660")]
			[Cpp2IlInjected.Address(RVA = "0x801BC70", Offset = "0x801B070", VA = "0x18801BC70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000661")]
			[Cpp2IlInjected.Address(RVA = "0x801BF30", Offset = "0x801B330", VA = "0x18801BF30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public IBKJCEELKEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public CFLKKNKAIAK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public CNBJACFFDEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x8006A80", Offset = "0x8005E80", VA = "0x188006A80")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task DOHELLIPIEO(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private struct KDLAGEEKNKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006DB")]
		public IBKJCEELKEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		public CFLKKNKAIAK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		private CNBJACFFDEA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x8010720", Offset = "0x800FB20", VA = "0x188010720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x8010C50", Offset = "0x8010050", VA = "0x188010C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private struct MBJEDIJIBEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		public IBKJCEELKEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		public CFLKKNKAIAK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		private Dictionary<Guid, List<FCJCKALOIJJ>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x80278D0", Offset = "0x8026CD0", VA = "0x1880278D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x8027EE0", Offset = "0x80272E0", VA = "0x188027EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[CompilerGenerated]
	private struct LBPICECMNMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		public IBKJCEELKEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		public CFLKKNKAIAK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		private Dictionary<Guid, List<FCJCKALOIJJ>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x80254C0", Offset = "0x80248C0", VA = "0x1880254C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x8025B50", Offset = "0x8024F50", VA = "0x188025B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018F")]
	[CompilerGenerated]
	private sealed class EPHNFJDKAPC
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
			public FCJCKALOIJJ handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006FB")]
			public EPHNFJDKAPC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006FC")]
			private PEPIFLGHCHM <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006FD")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600066C")]
			[Cpp2IlInjected.Address(RVA = "0x802B130", Offset = "0x802A530", VA = "0x18802B130", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066D")]
			[Cpp2IlInjected.Address(RVA = "0x802B590", Offset = "0x802A990", VA = "0x18802B590", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		public BEKNCAPDLOD runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		public List<FCJCKALOIJJ> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public CFLKKNKAIAK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public EPHNFJDKAPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x8021330", Offset = "0x8020730", VA = "0x188021330")]
		internal object LJAJAOPGKOD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x8021230", Offset = "0x8020630", VA = "0x188021230")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task ECNGBDKGLEH(FCJCKALOIJJ handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x8021420", Offset = "0x8020820", VA = "0x188021420")]
		internal object OLJNCBCGLKA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private struct KJOMIMIECNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		public BEKNCAPDLOD runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public List<FCJCKALOIJJ> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		public CFLKKNKAIAK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		private EPHNFJDKAPC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x8024AD0", Offset = "0x8023ED0", VA = "0x188024AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x8024FA0", Offset = "0x80243A0", VA = "0x188024FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private struct JAJDFNINBFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		public IBKJCEELKEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		public CFLKKNKAIAK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA timer;

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
		[Cpp2IlInjected.Address(RVA = "0x8022CF0", Offset = "0x80220F0", VA = "0x188022CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x8022FE0", Offset = "0x80223E0", VA = "0x188022FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[CompilerGenerated]
	private sealed class JMKNFLNFBCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public JMKNFLNFBCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x80236B0", Offset = "0x8022AB0", VA = "0x1880236B0")]
		internal object EJGGFBGODFJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000195")]
	[CompilerGenerated]
	private struct FHLHECNELLL : IAsyncStateMachine
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
		public IBKJCEELKEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		public CFLKKNKAIAK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		private PEPIFLGHCHM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x8021510", Offset = "0x8020910", VA = "0x188021510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x80219C0", Offset = "0x8020DC0", VA = "0x1880219C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[CompilerGenerated]
	private sealed class JJCCHMMHPHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public JJCCHMMHPHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x8023330", Offset = "0x8022730", VA = "0x188023330")]
		internal object JKDBJPGNANA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private struct NNFBAEOOHNG : IAsyncStateMachine
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
		public IBKJCEELKEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		private PEPIFLGHCHM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000723")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000724")]
		private TaskAwaiter<KOEDLEGFKIO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x8028FB0", Offset = "0x80283B0", VA = "0x188028FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x80295E0", Offset = "0x80289E0", VA = "0x1880295E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private sealed class GBIEBKAAKEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000725")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public GBIEBKAAKEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x8022100", Offset = "0x8021500", VA = "0x188022100")]
		internal object PKAGGCGAGJH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006C6")]
	private readonly BBEKBLPLKNJ OBMIMFHGEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006C7")]
	private MCCKBPLKAGM BEMOPAHNLDD;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private IMFDIOOAAIF PMCHJLNGKOC
	{
		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0xFE24B0", Offset = "0xFE18B0", VA = "0x180FE24B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x999BC0", Offset = "0x998FC0", VA = "0x180999BC0")]
	public IBKJCEELKEI(BBEKBLPLKNJ OBMIMFHGEKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x800D4F0", Offset = "0x800C8F0", VA = "0x18800D4F0")]
	[AsyncStateMachine(typeof(KJCGCCADFMH))]
	public Task CAFDDKMELKN(CNMGOCEKCNJ OKMOMAIGKJG, CFLKKNKAIAK BJDLKEJBJLL, HOEFFPEDKPI<string>.AEKMEBIOPMA AOBIHHLEODI, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x800D9D0", Offset = "0x800CDD0", VA = "0x18800D9D0")]
	[AsyncStateMachine(typeof(KDLAGEEKNKC))]
	private Task GDIABEKFJFC(CFLKKNKAIAK AMHCLKHIFKH, HOEFFPEDKPI<string>.AEKMEBIOPMA AOBIHHLEODI, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x800DEF0", Offset = "0x800D2F0", VA = "0x18800DEF0")]
	[AsyncStateMachine(typeof(MBJEDIJIBEJ))]
	private Task JAGPDJDFDAB(CFLKKNKAIAK AMHCLKHIFKH, HOEFFPEDKPI<string>.AEKMEBIOPMA AOBIHHLEODI, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x800DB10", Offset = "0x800CF10", VA = "0x18800DB10")]
	[AsyncStateMachine(typeof(LBPICECMNMN))]
	private Task GDPAKJNDEGI(CFLKKNKAIAK AMHCLKHIFKH, HOEFFPEDKPI<string>.AEKMEBIOPMA AOBIHHLEODI, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x800E030", Offset = "0x800D430", VA = "0x18800E030")]
	[AsyncStateMachine(typeof(KJOMIMIECNO))]
	private Task MLKPHMCJEHD(Guid GPDBBFAGDHM, List<FCJCKALOIJJ> JIPGMACFEOP, BEKNCAPDLOD OAHIAJMEKNG, CFLKKNKAIAK AMHCLKHIFKH, CancellationToken HEJFDMJNIGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x800DDB0", Offset = "0x800D1B0", VA = "0x18800DDB0")]
	[AsyncStateMachine(typeof(JAJDFNINBFO))]
	private Task IJILAIKDADH(CFLKKNKAIAK AMHCLKHIFKH, HOEFFPEDKPI<string>.AEKMEBIOPMA AOBIHHLEODI, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x800E2C0", Offset = "0x800D6C0", VA = "0x18800E2C0")]
	[AsyncStateMachine(typeof(FHLHECNELLL))]
	private Task OMIEIONPENO(Guid JBDJGPDDLMI, CFLKKNKAIAK AMHCLKHIFKH, HOEFFPEDKPI<string>.AEKMEBIOPMA AOBIHHLEODI, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x800E180", Offset = "0x800D580", VA = "0x18800E180")]
	[AsyncStateMachine(typeof(NNFBAEOOHNG))]
	private Task OBGPHLCFLPN(Guid JBDJGPDDLMI, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x800D8C0", Offset = "0x800CCC0", VA = "0x18800D8C0")]
	private void GCFHOCABEIO(Guid JBDJGPDDLMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x800D640", Offset = "0x800CA40", VA = "0x18800D640")]
	private void DONBEGLAHKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x800DC50", Offset = "0x800D050", VA = "0x18800DC50")]
	public Guid GGKOGBFDMAJ(CNMGOCEKCNJ KPHPAAJKPFJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x800D6F0", Offset = "0x800CAF0", VA = "0x18800D6F0")]
	[CompilerGenerated]
	private object FNCINLNLJBF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
internal struct NMDBPHCOENL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private struct LCIIFMEAOOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400072A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		public NMDBPHCOENL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		private IEnumerator<JLFGFHNLHIB> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x8026790", Offset = "0x8025B90", VA = "0x188026790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x8026E30", Offset = "0x8026230", VA = "0x188026E30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000726")]
	private IFFMIKJIEPF MFCHJJKNFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000727")]
	private HOEFFPEDKPI<string>.AEKMEBIOPMA AOBIHHLEODI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000728")]
	private CancellationToken BLABAMPAGAH;

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0x8028F40", Offset = "0x8028340", VA = "0x188028F40")]
	public static Task KPOKBIBPDEK(IFFMIKJIEPF MFCHJJKNFDE, HOEFFPEDKPI<string>.AEKMEBIOPMA AOBIHHLEODI, CancellationToken CAPKGEJBGJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(RVA = "0x8028E50", Offset = "0x8028250", VA = "0x188028E50")]
	[AsyncStateMachine(typeof(LCIIFMEAOOD))]
	private Task CAFDDKMELKN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
public readonly struct GGKMAMDIMDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400072F")]
	public readonly bool PPIHFDPGLBL;

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x2854050", Offset = "0x2853450", VA = "0x182854050")]
	public GGKMAMDIMDL(bool MHGPIEFKLEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
public readonly struct IPEJPHCMEGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000730")]
	public readonly BPGLDJMOGPH? CJPIDICBEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000731")]
	public readonly HECDLJHFNEH ALJIIOAJKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000732")]
	public readonly Guid? ELLIFFLFPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000733")]
	public readonly IReadOnlyList<Guid> HPHHHAMOCPP;

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public IReadOnlyCollection<string> HAAPCGEMLLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x8022BB0", Offset = "0x8021FB0", VA = "0x188022BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public IReadOnlyDictionary<long, int> MEFLLOMEFIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x8022BD0", Offset = "0x8021FD0", VA = "0x188022BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x8022BF0", Offset = "0x8021FF0", VA = "0x188022BF0")]
	public IPEJPHCMEGJ(BPGLDJMOGPH? BDAPIDPALOK, HECDLJHFNEH CACCJGEDGIC, Guid? PADEBAHBFEO, [Optional] IReadOnlyList<Guid>? CLDNEABJOKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
internal class CKJILLGLNDH : LBPHHFCCKPL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[CompilerGenerated]
	private struct GLODNDPEEJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000739")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		public AsyncTaskMethodBuilder<IPEJPHCMEGJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		public CKJILLGLNDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		public HNICEBLJKEL serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		public IBCDIPHCGCH roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000740")]
		private PersistenceView[] <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		private PEPIFLGHCHM <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x8022170", Offset = "0x8021570", VA = "0x188022170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x8022810", Offset = "0x8021C10", VA = "0x188022810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[CompilerGenerated]
	private sealed class AIEFAKINLOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		public float time;

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public AIEFAKINLOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x801C750", Offset = "0x801BB50", VA = "0x18801C750")]
		internal object GKAAMOPGBKC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	[CompilerGenerated]
	private struct DEPMAPFEHFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000747")]
		public CKJILLGLNDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		public PersistenceView[] activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000749")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400074A")]
		public HNICEBLJKEL serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400074B")]
		private AIEFAKINLOG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400074C")]
		private PEPIFLGHCHM <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400074D")]
		private CancellationTokenSource <cts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		private EIEPCDCEBED<Task> <tasks>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x801F980", Offset = "0x801ED80", VA = "0x18801F980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x8020440", Offset = "0x801F840", VA = "0x188020440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000734")]
	private readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.Token(Token = "0x4000735")]
	private static readonly TimeSpan GEMABECIHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000736")]
	private readonly FIMNLABAGFP BIJGHCJLBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000737")]
	private readonly NOIIEBIOGKN JHNBPAGDJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000738")]
	private readonly BLENEGCJEED OBFANLBKKJK;

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x801F720", Offset = "0x801EB20", VA = "0x18801F720")]
	public CKJILLGLNDH(BBEKBLPLKNJ OBMIMFHGEKH, FIMNLABAGFP BIJGHCJLBHH, NOIIEBIOGKN CJOPIHHDIAM, BLENEGCJEED OBFANLBKKJK, ABDDJEPKCOD LEMJHEDOKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x801EAB0", Offset = "0x801DEB0", VA = "0x18801EAB0")]
	[AsyncStateMachine(typeof(GLODNDPEEJH))]
	public Task<IPEJPHCMEGJ> LMGGAKIACNI(long DCFFKJJLEHN, IBCDIPHCGCH PKLHKIHLDNE, HNICEBLJKEL AKNAPINBDMI, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x801E560", Offset = "0x801D960", VA = "0x18801E560")]
	[AsyncStateMachine(typeof(DEPMAPFEHFH))]
	private Task DCEDBMICKIM(HNICEBLJKEL AKNAPINBDMI, PersistenceView[] FFBELCKBILJ, StringBuilder IANABLLOCIB, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x801EC00", Offset = "0x801E000", VA = "0x18801EC00")]
	private IPEJPHCMEGJ MJPBCCFGFGC(long DCFFKJJLEHN, IBCDIPHCGCH PKLHKIHLDNE, HNICEBLJKEL AKNAPINBDMI, IEnumerable<PersistenceView> FFBELCKBILJ, StringBuilder IANABLLOCIB)
	{
		return default(IPEJPHCMEGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x801E6A0", Offset = "0x801DAA0", VA = "0x18801E6A0")]
	private BPGLDJMOGPH INNPGKDPPNB(long DCFFKJJLEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x801E860", Offset = "0x801DC60", VA = "0x18801E860")]
	private void JLOPJLNLDIM(BPGLDJMOGPH PCPAAMNPCIJ, StringBuilder IANABLLOCIB, IEnumerable<PersistenceView> FFBELCKBILJ, [In] NLAMBFGLOBN LEKCKLHAMHC, OFKAINDDBDJ GAJIPEHJGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x801F210", Offset = "0x801E610", VA = "0x18801F210")]
	private void NPMILEOPPIE(BPGLDJMOGPH PCPAAMNPCIJ, StringBuilder IANABLLOCIB, PersistenceView FEDEGDPKLDC, OFKAINDDBDJ GAJIPEHJGJC, [In] NLAMBFGLOBN LEKCKLHAMHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
internal class MEPGEDKMDKD : LBPHHFCCKPL
{
	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	[CompilerGenerated]
	private sealed class CLBHHDEJODE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000755")]
		public IOEIADFCNCL.NFIBEOODLPK roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public CLBHHDEJODE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x801F790", Offset = "0x801EB90", VA = "0x18801F790")]
		internal object BJOHJLNBMPE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	[CompilerGenerated]
	private struct KIOEMGIOKBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000756")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000757")]
		public AsyncTaskMethodBuilder<(IOEIADFCNCL.NFIBEOODLPK roomDataUpload, IOEIADFCNCL.NFIBEOODLPK subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000758")]
		public IPEJPHCMEGJ roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000759")]
		public IFFMIKJIEPF callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400075A")]
		private CLBHHDEJODE <>8__1;

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
		private TaskAwaiter<IOEIADFCNCL.NFIBEOODLPK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x80241E0", Offset = "0x80235E0", VA = "0x1880241E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x8024A60", Offset = "0x8023E60", VA = "0x188024A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[CompilerGenerated]
	private struct JMKGJLELDMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400075F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000760")]
		public AsyncTaskMethodBuilder<PFDCFKLNLCM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000761")]
		public MEPGEDKMDKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000762")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000763")]
		public OIFNNMDODPC roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000764")]
		public IPEJPHCMEGJ roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000765")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000766")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000767")]
		private TaskAwaiter<PFDCFKLNLCM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x80233A0", Offset = "0x80227A0", VA = "0x1880233A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x8023640", Offset = "0x8022A40", VA = "0x188023640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	[CompilerGenerated]
	private struct BGFIAEGAGJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000768")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		public AsyncTaskMethodBuilder<PFDCFKLNLCM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		public IFFMIKJIEPF callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		public IPEJPHCMEGJ roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400076C")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400076E")]
		public KBACDNJLCPJ ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400076F")]
		public OIFNNMDODPC roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		private TaskAwaiter<(IOEIADFCNCL.NFIBEOODLPK roomDataUpload, IOEIADFCNCL.NFIBEOODLPK subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000772")]
		private TaskAwaiter<PFDCFKLNLCM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x801CDA0", Offset = "0x801C1A0", VA = "0x18801CDA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x801D400", Offset = "0x801C800", VA = "0x18801D400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[CompilerGenerated]
	private struct MBGGEAIEGMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		public AsyncTaskMethodBuilder<CMHOHMOMOEI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		public MEPGEDKMDKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		public IPEJPHCMEGJ roomSerializedData;

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
		private TaskAwaiter<(IOEIADFCNCL.NFIBEOODLPK roomDataUpload, IOEIADFCNCL.NFIBEOODLPK subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400077C")]
		private TaskAwaiter<CMHOHMOMOEI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x80273A0", Offset = "0x80267A0", VA = "0x1880273A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x8027860", Offset = "0x8026C60", VA = "0x188027860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[CompilerGenerated]
	private sealed class ACHKIGKJHCH
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
			public AsyncTaskMethodBuilder<KOEDLEGFKIO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000787")]
			public ACHKIGKJHCH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000788")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000789")]
			private KOEDLEGFKIO <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400078A")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400078B")]
			private TaskAwaiter<CMHOHMOMOEI> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400078C")]
			private TaskAwaiter<PFDCFKLNLCM> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400078D")]
			private TaskAwaiter<KOEDLEGFKIO> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60006AE")]
			[Cpp2IlInjected.Address(RVA = "0x802B5F0", Offset = "0x802A9F0", VA = "0x18802B5F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006AF")]
			[Cpp2IlInjected.Address(RVA = "0x802C800", Offset = "0x802BC00", VA = "0x18802C800", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400077D")]
		public MEPGEDKMDKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400077E")]
		public IPEJPHCMEGJ roomSerializedData;

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
		public OIFNNMDODPC roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		public GGKMAMDIMDL roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public ACHKIGKJHCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x801C620", Offset = "0x801BA20", VA = "0x18801C620")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<KOEDLEGFKIO> KHKAFAPCIFA(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[CompilerGenerated]
	private struct FOCEEIADFDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400078E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400078F")]
		public AsyncTaskMethodBuilder<KOEDLEGFKIO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000790")]
		public MEPGEDKMDKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000791")]
		public IPEJPHCMEGJ roomSerializedData;

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
		public OIFNNMDODPC roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000796")]
		public GGKMAMDIMDL roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000797")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000798")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000799")]
		private TaskAwaiter<KOEDLEGFKIO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x8021D60", Offset = "0x8021160", VA = "0x188021D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x8022090", Offset = "0x8021490", VA = "0x188022090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000752")]
	private static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.Token(Token = "0x4000753")]
	private static readonly ABDDJEPKCOD IAEPOPBDDCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000754")]
	private readonly FCJIJIJJMOO MJKJNFCJDPC;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private GGAFKPAJMJF COEODMFJGAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x7FFDA10", Offset = "0x7FFCE10", VA = "0x187FFDA10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x8028AA0", Offset = "0x8027EA0", VA = "0x188028AA0")]
	public MEPGEDKMDKD(BBEKBLPLKNJ OBMIMFHGEKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x8028270", Offset = "0x8027670", VA = "0x188028270")]
	[AsyncStateMachine(typeof(KIOEMGIOKBG))]
	private static Task<(IOEIADFCNCL.NFIBEOODLPK, IOEIADFCNCL.NFIBEOODLPK)> JBJFHKHOEFO(IFFMIKJIEPF MFCHJJKNFDE, IPEJPHCMEGJ HOIBEPBFBCD, long CCHPCHDJHAI, long CLKFEHDHMIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x80283C0", Offset = "0x80277C0", VA = "0x1880283C0")]
	[AsyncStateMachine(typeof(JMKGJLELDMF))]
	public Task<PFDCFKLNLCM> LIKBNOLJNCP(int PNMPDHMKPJO, [CanBeNull] OIFNNMDODPC HBOAENOKJMI, IPEJPHCMEGJ HOIBEPBFBCD, long CCHPCHDJHAI, long CLKFEHDHMIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x80286C0", Offset = "0x8027AC0", VA = "0x1880286C0")]
	public static Task<PFDCFKLNLCM> LIKBNOLJNCP(IFFMIKJIEPF MFCHJJKNFDE, int PNMPDHMKPJO, [CanBeNull] OIFNNMDODPC HBOAENOKJMI, IPEJPHCMEGJ HOIBEPBFBCD, long CCHPCHDJHAI, long CLKFEHDHMIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x8028530", Offset = "0x8027930", VA = "0x188028530")]
	[AsyncStateMachine(typeof(BGFIAEGAGJG))]
	public static Task<PFDCFKLNLCM> LIKBNOLJNCP(IFFMIKJIEPF MFCHJJKNFDE, int PNMPDHMKPJO, [CanBeNull] OIFNNMDODPC HBOAENOKJMI, IPEJPHCMEGJ HOIBEPBFBCD, long CCHPCHDJHAI, long CLKFEHDHMIF, KBACDNJLCPJ FMHFJIMEAHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x8027F40", Offset = "0x8027340", VA = "0x188027F40")]
	[AsyncStateMachine(typeof(MBGGEAIEGMC))]
	private Task<CMHOHMOMOEI> EKAJHHMMHEK(string CGOKGIMLOPB, int PNMPDHMKPJO, IPEJPHCMEGJ HOIBEPBFBCD, long CCHPCHDJHAI, long CLKFEHDHMIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(RVA = "0x80280C0", Offset = "0x80274C0", VA = "0x1880280C0")]
	[AsyncStateMachine(typeof(FOCEEIADFDL))]
	public Task<KOEDLEGFKIO> IBHLNALHCMD(int PNMPDHMKPJO, OIFNNMDODPC? HBOAENOKJMI, IPEJPHCMEGJ HOIBEPBFBCD, long CCHPCHDJHAI, long CLKFEHDHMIF, GGKMAMDIMDL HKBEOFMEHMF, HOEFFPEDKPI<string>.AEKMEBIOPMA COPIKEMNCKF, CancellationToken BLABAMPAGAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
public abstract class EKEEOLDEAKB<T> where T : EKEEOLDEAKB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400079A")]
	internal readonly GGAFKPAJMJF LGLEKBLFNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400079B")]
	private int? GHDGNPLGEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400079C")]
	protected readonly Guid PNDIAPLLLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400079D")]
	protected readonly HAMDHMOMGFH EFCENFMNOPA;

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	protected T KOLOJHIDHHG
	{
		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x428F550", Offset = "0x428E950", VA = "0x18428F550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(RVA = "0x428F650", Offset = "0x428EA50", VA = "0x18428F650")]
	internal EKEEOLDEAKB(GGAFKPAJMJF IJDMAKBKHFO, HAMDHMOMGFH IIDBEKEFGGH, [Optional] Guid? NPMNDEDHHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(RVA = "0x428F2A0", Offset = "0x428E6A0", VA = "0x18428F2A0")]
	private KOEDLEGFKIO AEFKINODEEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "4")]
	protected virtual void GFJMGKGGLDF(KOEDLEGFKIO EIGJGBPHOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(RVA = "0x428F380", Offset = "0x428E780", VA = "0x18428F380")]
	public T BCPBKFCOBJP(FEIKLGLBIHI HNCNLBLNACH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0x428F5B0", Offset = "0x428E9B0", VA = "0x18428F5B0")]
	public T FOEDNKHOBOF(int JAKMGKBHJPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0x428F420", Offset = "0x428E820", VA = "0x18428F420", Slot = "5")]
	public virtual Task<BAOOEPCCKJO> CFBGPJKMKIM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AC")]
public class CNOLAGDHOLD : EKEEOLDEAKB<CNOLAGDHOLD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400079E")]
	private JGCMJADBFFC KGCLHKOHKLJ;

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x801F8B0", Offset = "0x801ECB0", VA = "0x18801F8B0")]
	internal CNOLAGDHOLD(GGAFKPAJMJF IJDMAKBKHFO, HAMDHMOMGFH IIDBEKEFGGH, [Optional] Guid? NPMNDEDHHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x7339710", Offset = "0x7338B10", VA = "0x187339710")]
	public CNOLAGDHOLD FBAANIKMKMN(JGCMJADBFFC KGCLHKOHKLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0x801F7E0", Offset = "0x801EBE0", VA = "0x18801F7E0", Slot = "4")]
	protected override void GFJMGKGGLDF(KOEDLEGFKIO EIGJGBPHOMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AD")]
public class DJBGKFICKCD : EKEEOLDEAKB<DJBGKFICKCD>
{
	[Cpp2IlInjected.Token(Token = "0x20001AE")]
	internal enum PDNMFCPCHMA
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
	private struct CEBKKBKLPEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007A7")]
		public AsyncTaskMethodBuilder<BAOOEPCCKJO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007A8")]
		public DJBGKFICKCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007A9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007AA")]
		private TaskAwaiter<BAOOEPCCKJO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x801E140", Offset = "0x801D540", VA = "0x18801E140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x801E4F0", Offset = "0x801D8F0", VA = "0x18801E4F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400079F")]
	private PDNMFCPCHMA MADPJJJCNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40007A0")]
	private string JKNNHEPNGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40007A1")]
	private OIFNNMDODPC KGCLHKOHKLJ;

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(RVA = "0x80207E0", Offset = "0x801FBE0", VA = "0x1880207E0")]
	internal DJBGKFICKCD(GGAFKPAJMJF IJDMAKBKHFO, HAMDHMOMGFH IIDBEKEFGGH, [Optional] Guid? NPMNDEDHHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x8020720", Offset = "0x801FB20", VA = "0x188020720")]
	public DJBGKFICKCD HBKBPDPJNJI(string DPHOGONECCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0x80204A0", Offset = "0x801F8A0", VA = "0x1880204A0")]
	public DJBGKFICKCD BHOIHAAIDNP(bool LOAJMOGIEIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x8020790", Offset = "0x801FB90", VA = "0x188020790")]
	public DJBGKFICKCD MOKDENJBOFP(bool GBOJBMMBADE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x80207B0", Offset = "0x801FBB0", VA = "0x1880207B0")]
	public DJBGKFICKCD OJLCJODPFPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x80205B0", Offset = "0x801F9B0", VA = "0x1880205B0", Slot = "4")]
	protected override void GFJMGKGGLDF(KOEDLEGFKIO EIGJGBPHOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x80204C0", Offset = "0x801F8C0", VA = "0x1880204C0", Slot = "5")]
	[AsyncStateMachine(typeof(CEBKKBKLPEF))]
	public override Task<BAOOEPCCKJO> CFBGPJKMKIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x8020750", Offset = "0x801FB50", VA = "0x188020750")]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task<BAOOEPCCKJO> JPJJGPFGFGD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
internal static class AMGNHDIAFLB
{
	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x801C840", Offset = "0x801BC40", VA = "0x18801C840")]
	public static void IKMKHLHBKAB(this NDKFKFGHFIK KGODABFKFLE, MEMBODLLNEP MOFLDKODPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x801C7C0", Offset = "0x801BBC0", VA = "0x18801C7C0")]
	public static void CNNHOGHHKHH(this MEMBODLLNEP OHBACCHDJLF, [Optional] string EIGJGBPHOMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
public static class PLHCLHANPPF
{
	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x802B090", Offset = "0x802A490", VA = "0x18802B090")]
	public static PGNIPJOEHNG IJCHIPHHAKD(this OELIIHGFMPP FJINBMBKNIJ)
	{
		return default(PGNIPJOEHNG);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x802AFE0", Offset = "0x802A3E0", VA = "0x18802AFE0")]
	public static OELIIHGFMPP HGLJGMPGEGD(this PGNIPJOEHNG OAKGOBDGHNI)
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
			public DFBMLOIHJIF ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007AF")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007B0")]
			public DFBMLOIHJIF HandleAs;

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
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40007AB")]
		private static DFBMLOIHJIF[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007AC")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007AD")]
		private Dictionary<DFBMLOIHJIF, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x802CDC0", Offset = "0x802C1C0", VA = "0x18802CDC0")]
		public bool COKPKLCEGJN(DFBMLOIHJIF EJDDKMKFNBB, [Out] ResultConfig EOPBDJJHJJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x802CE30", Offset = "0x802C230", VA = "0x18802CE30")]
		public ResultConfig FGNNIGKEHOM(DFBMLOIHJIF CIAFGFLDDGN, [Optional] HashSet<DFBMLOIHJIF> NKCMHGHNOAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x802D520", Offset = "0x802C920", VA = "0x18802D520", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x802CF70", Offset = "0x802C370", VA = "0x18802CF70", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0xAF7D80", Offset = "0xAF7180", VA = "0x180AF7D80")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B5")]
public class FNMFGPBOEBC : PMAHOPLKPFE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001B6")]
	[CompilerGenerated]
	private struct JFCDMOHMFDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007BD")]
		public FNMFGPBOEBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007BE")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007BF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007C0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x8023040", Offset = "0x8022440", VA = "0x188023040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x80232D0", Offset = "0x80226D0", VA = "0x1880232D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	[CompilerGenerated]
	private struct MBDDLKAHNCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007C3")]
		public HOEFFPEDKPI<string>.AEKMEBIOPMA timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007C4")]
		public PMAHOPLKPFE preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007C5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007C6")]
		private HOEFFPEDKPI<string>.AEKMEBIOPMA <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x8026E90", Offset = "0x8026290", VA = "0x188026E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x8027340", Offset = "0x8026740", VA = "0x188027340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007B9")]
	private readonly DDGOHKFLIHO PJNJDIOKAAC;

	[Cpp2IlInjected.Token(Token = "0x40007BA")]
	private static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public string DPBDCFNEEOE
	{
		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x8021CC0", Offset = "0x80210C0", VA = "0x188021CC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D8")]
	[Cpp2IlInjected.Address(RVA = "0x8021C50", Offset = "0x8021050", VA = "0x188021C50")]
	[BOBPNFIGGBE.NBDKKMMHNGD.OAOMAIGGIPF]
	internal static void MIDKFNLDDFI(NPIEGGOELNH FLKEBBNIBPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x999BC0", Offset = "0x998FC0", VA = "0x180999BC0")]
	[RecRoom.NoEngine.Common.Preserve]
	public FNMFGPBOEBC([GKAMHFFOHNI(null)] DDGOHKFLIHO PJNJDIOKAAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x8021A20", Offset = "0x8020E20", VA = "0x188021A20", Slot = "5")]
	[AsyncStateMachine(typeof(JFCDMOHMFDH))]
	public Task CAFDDKMELKN(HOEFFPEDKPI<string>.AEKMEBIOPMA EIFGLEGDNIH, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x8021B30", Offset = "0x8020F30", VA = "0x188021B30")]
	[AsyncStateMachine(typeof(MBDDLKAHNCO))]
	private Task FKKJHBDAOMA(PMAHOPLKPFE ONKIFNKOIKC, HOEFFPEDKPI<string>.AEKMEBIOPMA EIFGLEGDNIH, CancellationToken BLABAMPAGAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B8")]
public interface DDGOHKFLIHO : PMAHOPLKPFE
{
}
[Cpp2IlInjected.Token(Token = "0x20001B9")]
public interface PMAHOPLKPFE
{
	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	string DPBDCFNEEOE
	{
		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CAFDDKMELKN(HOEFFPEDKPI<string>.AEKMEBIOPMA EIFGLEGDNIH, CancellationToken BLABAMPAGAH);
}
[Cpp2IlInjected.Token(Token = "0x20001BA")]
public static class BBICOODPKDF
{
	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(RVA = "0x801C990", Offset = "0x801BD90", VA = "0x18801C990")]
	[BOBPNFIGGBE.NBDKKMMHNGD.OAOMAIGGIPF]
	internal static void KDIILJNJDKF(NPIEGGOELNH FLKEBBNIBPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BB")]
public interface GLNNANNECEB : IEquatable<GLNNANNECEB>
{
	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	DateTime KKKBAGHLBFI
	{
		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FPDBAKJJINA();

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DGCKCJFDDHE(long CCHPCHDJHAI, long DCFFKJJLEHN, [Out] IPEJPHCMEGJ HOIBEPBFBCD);
}
[Cpp2IlInjected.Token(Token = "0x20001BC")]
internal class LCGCCPIFDEM : LIKHEEBCIHK
{
	[Cpp2IlInjected.Token(Token = "0x20001BD")]
	[CompilerGenerated]
	private sealed class EEFBPHPHINB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007CA")]
		public ONAMBMOGICM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007CB")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public EEFBPHPHINB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x80211C0", Offset = "0x80205C0", VA = "0x1880211C0")]
		internal object HOLPEEKJEJE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007C8")]
	private readonly MCPANOEKGNC AMABDCKHFKO;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<GLNNANNECEB> IHOEBLKNKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x8026630", Offset = "0x8025A30", VA = "0x188026630", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x8025CE0", Offset = "0x80250E0", VA = "0x188025CE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x999BC0", Offset = "0x998FC0", VA = "0x180999BC0")]
	[UnityEngine.Scripting.Preserve]
	public LCGCCPIFDEM([GKAMHFFOHNI(null)] MCPANOEKGNC AMABDCKHFKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x80261C0", Offset = "0x80255C0", VA = "0x1880261C0", Slot = "6")]
	public bool JAOPIPJLJPF(long CCHPCHDJHAI, long DCFFKJJLEHN, IPEJPHCMEGJ HOIBEPBFBCD, ONAMBMOGICM AMGCMCFMLOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0xD0D6B0", Offset = "0xD0CAB0", VA = "0x180D0D6B0")]
	private void NOJKCGHMAHF(GLNNANNECEB CCGNPPPBHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x80264C0", Offset = "0x80258C0", VA = "0x1880264C0", Slot = "7")]
	public bool KNFDMPMLONJ(long CCHPCHDJHAI, long DCFFKJJLEHN, [Out] GLNNANNECEB PEJBDAJPKPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x80266E0", Offset = "0x8025AE0", VA = "0x1880266E0", Slot = "8")]
	public bool PFKIJJEHFAN(long CCHPCHDJHAI, long DCFFKJJLEHN, ONAMBMOGICM AMGCMCFMLOG, [Out] GLNNANNECEB PEJBDAJPKPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x8025D90", Offset = "0x8025190", VA = "0x188025D90")]
	private void IHHGEGJCOMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(RVA = "0x8025BB0", Offset = "0x8024FB0", VA = "0x188025BB0", Slot = "9")]
	public void DAHOFGJNGMK(long CCHPCHDJHAI, long DCFFKJJLEHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BF")]
internal abstract class KFKHMIEGJGC : MCPANOEKGNC
{
	[Cpp2IlInjected.Token(Token = "0x20001C0")]
	protected enum BEBFFPHOHJD : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40007D0")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40007D1")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001C1")]
	[CompilerGenerated]
	private sealed class IDKPJFBHODM : IEnumerable<GLNNANNECEB>, IEnumerable, IEnumerator<GLNNANNECEB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007D2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007D3")]
		private GLNNANNECEB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D4")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007D5")]
		public KFKHMIEGJGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007D6")]
		private ONAMBMOGICM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40007D7")]
		public ONAMBMOGICM <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007D8")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007D9")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		private GLNNANNECEB System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000705")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0xDDEBA0", Offset = "0xDDDFA0", VA = "0x180DDEBA0")]
		[DebuggerHidden]
		public IDKPJFBHODM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x8022880", Offset = "0x8021C80", VA = "0x188022880", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x8022B60", Offset = "0x8021F60", VA = "0x188022B60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x8022AB0", Offset = "0x8021EB0", VA = "0x188022AB0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GLNNANNECEB> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x8022AB0", Offset = "0x8021EB0", VA = "0x188022AB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	[CompilerGenerated]
	private sealed class OOEFLHNPIDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007DA")]
		public ONAMBMOGICM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007DB")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public OOEFLHNPIDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x8029640", Offset = "0x8028A40", VA = "0x188029640")]
		internal object BMEBJKIEMOC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	[CompilerGenerated]
	private sealed class CDKDPJHLAOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007DC")]
		public KFKHMIEGJGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007DD")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public CDKDPJHLAOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x801E0C0", Offset = "0x801D4C0", VA = "0x18801E0C0")]
		internal void JPJEFDIOFKJ(CIGDMMOBHEC.AFPCPDEINMM ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007CE")]
	private readonly object LAICNIFEOCB;

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	protected string PJPLAJBMGPG
	{
		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x8023790", Offset = "0x8022B90", VA = "0x188023790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public abstract BHCHIAOMANO NFMNOCKOPLG
	{
		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0x8024160", Offset = "0x8023560", VA = "0x188024160")]
	protected KFKHMIEGJGC([CanBeNull] string DJEELEIHDNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(RVA = "0x8023B20", Offset = "0x8022F20", VA = "0x188023B20", Slot = "5")]
	public bool JIFDAJLLLHM(long CCHPCHDJHAI, long DCFFKJJLEHN, ONAMBMOGICM AMGCMCFMLOG, [Out] GLNNANNECEB CCGNPPPBHGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(RVA = "0x8023D10", Offset = "0x8023110", VA = "0x188023D10", Slot = "6")]
	[IteratorStateMachine(typeof(IDKPJFBHODM))]
	public IEnumerable<GLNNANNECEB> KDGOOBJKHCA(ONAMBMOGICM AMGCMCFMLOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void OBAKOFDFGEG(Stream NODJOCMEJNM, long CCHPCHDJHAI, long DCFFKJJLEHN, IPEJPHCMEGJ HOIBEPBFBCD);

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool HPNJHKMEJKP(Stream GLDFPBLPOEK, long CCHPCHDJHAI, long DCFFKJJLEHN, NLEJCIDMFGB PCOCKOBKBLM, [Out] IPEJPHCMEGJ HOIBEPBFBCD);

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0x80237A0", Offset = "0x8022BA0", VA = "0x1880237A0", Slot = "7")]
	public GLNNANNECEB ILHKGCDMAJP(long CCHPCHDJHAI, long DCFFKJJLEHN, IPEJPHCMEGJ HOIBEPBFBCD, ONAMBMOGICM AMGCMCFMLOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo MIIIIGAJJMN(long CCHPCHDJHAI, long DCFFKJJLEHN, ONAMBMOGICM AMGCMCFMLOG, BEBFFPHOHJD AMMHKEFBKHM);

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo MKHCKGHAGGH(ONAMBMOGICM AMGCMCFMLOG, BEBFFPHOHJD AMMHKEFBKHM);

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x8023720", Offset = "0x8022B20", VA = "0x188023720")]
	protected void DGHMPDBDNOL(CIGDMMOBHEC.AFPCPDEINMM CLDBLCNPGDL, string JKMIMMPCKOM, FileInfo IMLACEGDIKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x8023DA0", Offset = "0x80231A0", VA = "0x188023DA0")]
	internal bool NECKOINHBOA(FileInfo KMGOBKOFBEH, long CCHPCHDJHAI, long DCFFKJJLEHN, [Out] IPEJPHCMEGJ HOIBEPBFBCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340")]
	private void IDEEMNBCMAM(Exception JBOPLLAHGDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C4")]
internal class BLDLFPLMIHJ : KFKHMIEGJGC
{
	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public override BHCHIAOMANO NFMNOCKOPLG
	{
		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x1C730E0", Offset = "0x1C724E0", VA = "0x181C730E0", Slot = "8")]
		get
		{
			return default(BHCHIAOMANO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0x801E080", Offset = "0x801D480", VA = "0x18801E080")]
	public BLDLFPLMIHJ([Optional] string DJEELEIHDNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x801D470", Offset = "0x801C870", VA = "0x18801D470")]
	private void BKIDDAPGOBA(ONAMBMOGICM AMGCMCFMLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x801DDD0", Offset = "0x801D1D0", VA = "0x18801DDD0", Slot = "9")]
	internal override void OBAKOFDFGEG(Stream NODJOCMEJNM, long CCHPCHDJHAI, long DCFFKJJLEHN, IPEJPHCMEGJ HOIBEPBFBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0x801D4F0", Offset = "0x801C8F0", VA = "0x18801D4F0", Slot = "10")]
	internal override bool HPNJHKMEJKP(Stream GLDFPBLPOEK, long CCHPCHDJHAI, long DCFFKJJLEHN, NLEJCIDMFGB PCOCKOBKBLM, [Out] IPEJPHCMEGJ HOIBEPBFBCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(RVA = "0x801DBE0", Offset = "0x801CFE0", VA = "0x18801DBE0", Slot = "11")]
	protected override FileInfo MIIIIGAJJMN(long CCHPCHDJHAI, long DCFFKJJLEHN, ONAMBMOGICM AMGCMCFMLOG, BEBFFPHOHJD AMMHKEFBKHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000714")]
	[Cpp2IlInjected.Address(RVA = "0x801DCD0", Offset = "0x801D0D0", VA = "0x18801DCD0", Slot = "12")]
	protected override DirectoryInfo MKHCKGHAGGH(ONAMBMOGICM AMGCMCFMLOG, BEBFFPHOHJD AMMHKEFBKHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C5")]
internal sealed class PBIFECHGPNB : KFKHMIEGJGC
{
	[Cpp2IlInjected.Token(Token = "0x40007DE")]
	private static readonly byte[] MCBJECJLDOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007DF")]
	private readonly byte[] AOFEPDABLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40007E0")]
	private readonly byte[] CNHGFBHPFOC;

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public override BHCHIAOMANO NFMNOCKOPLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x6B71180", Offset = "0x6B70580", VA = "0x186B71180", Slot = "8")]
		get
		{
			return default(BHCHIAOMANO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000716")]
	[Cpp2IlInjected.Address(RVA = "0x802A8F0", Offset = "0x8029CF0", VA = "0x18802A8F0")]
	public PBIFECHGPNB([Optional] string DJEELEIHDNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x802A450", Offset = "0x8029850", VA = "0x18802A450", Slot = "9")]
	internal override void OBAKOFDFGEG(Stream NODJOCMEJNM, long CCHPCHDJHAI, long DCFFKJJLEHN, IPEJPHCMEGJ HOIBEPBFBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x80296E0", Offset = "0x8028AE0", VA = "0x1880296E0", Slot = "10")]
	internal override bool HPNJHKMEJKP(Stream GLDFPBLPOEK, long CCHPCHDJHAI, long DCFFKJJLEHN, NLEJCIDMFGB PCOCKOBKBLM, [Out] IPEJPHCMEGJ HOIBEPBFBCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x802A150", Offset = "0x8029550", VA = "0x18802A150")]
	private void KAFNMNCBFPA(byte[] FIKLNMFCLIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x802A210", Offset = "0x8029610", VA = "0x18802A210", Slot = "11")]
	protected override FileInfo MIIIIGAJJMN(long CCHPCHDJHAI, long DCFFKJJLEHN, ONAMBMOGICM AMGCMCFMLOG, BEBFFPHOHJD AMMHKEFBKHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(RVA = "0x802A340", Offset = "0x8029740", VA = "0x18802A340", Slot = "12")]
	protected override DirectoryInfo MKHCKGHAGGH(ONAMBMOGICM AMGCMCFMLOG, BEBFFPHOHJD AMMHKEFBKHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C7")]
public enum BHCHIAOMANO : byte
{
	[Cpp2IlInjected.Token(Token = "0x40007E4")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40007E5")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40007E6")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001C8")]
internal class DPACEBOHMHJ : MCPANOEKGNC
{
	[Cpp2IlInjected.Token(Token = "0x20001CA")]
	[CompilerGenerated]
	private sealed class KKFEPKJANFO : IEnumerable<GLNNANNECEB>, IEnumerable, IEnumerator<GLNNANNECEB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007ED")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007EE")]
		private GLNNANNECEB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007EF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007F0")]
		public DPACEBOHMHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007F1")]
		private ONAMBMOGICM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40007F2")]
		public ONAMBMOGICM <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007F3")]
		private BHCHIAOMANO[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007F4")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007F5")]
		private IEnumerator<GLNNANNECEB> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		private GLNNANNECEB System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0xDDEBA0", Offset = "0xDDDFA0", VA = "0x180DDEBA0")]
		[DebuggerHidden]
		public KKFEPKJANFO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x8025430", Offset = "0x8024830", VA = "0x188025430", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x8025050", Offset = "0x8024450", VA = "0x188025050", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x8025000", Offset = "0x8024400", VA = "0x188025000")]
		private void KNMHCFDKFOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x80253E0", Offset = "0x80247E0", VA = "0x1880253E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x8025330", Offset = "0x8024730", VA = "0x188025330", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GLNNANNECEB> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x8025330", Offset = "0x8024730", VA = "0x188025330", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007E7")]
	private readonly BHCHIAOMANO[] ANHMDNPDJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007E8")]
	private readonly Dictionary<BHCHIAOMANO, MCPANOEKGNC> LHHDNNIFHOC;

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public BHCHIAOMANO NFMNOCKOPLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x8020E60", Offset = "0x8020260", VA = "0x188020E60", Slot = "4")]
		get
		{
			return default(BHCHIAOMANO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x8020E90", Offset = "0x8020290", VA = "0x188020E90")]
	[UnityEngine.Scripting.Preserve]
	public DPACEBOHMHJ(params MCPANOEKGNC[] KFJNCMGCKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x8020C80", Offset = "0x8020080", VA = "0x188020C80", Slot = "5")]
	public bool JIFDAJLLLHM(long CCHPCHDJHAI, long DCFFKJJLEHN, ONAMBMOGICM AMGCMCFMLOG, [Out] GLNNANNECEB CCGNPPPBHGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x8020950", Offset = "0x801FD50", VA = "0x188020950")]
	private void AJOFEEIMLOB(int CNIJBKMPPBL, long CCHPCHDJHAI, long DCFFKJJLEHN, ONAMBMOGICM AMGCMCFMLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x8020DD0", Offset = "0x80201D0", VA = "0x188020DD0", Slot = "6")]
	[IteratorStateMachine(typeof(KKFEPKJANFO))]
	public IEnumerable<GLNNANNECEB> KDGOOBJKHCA(ONAMBMOGICM AMGCMCFMLOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x8020B90", Offset = "0x801FF90", VA = "0x188020B90", Slot = "7")]
	public GLNNANNECEB ILHKGCDMAJP(long CCHPCHDJHAI, long DCFFKJJLEHN, IPEJPHCMEGJ HOIBEPBFBCD, ONAMBMOGICM AMGCMCFMLOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CB")]
internal static class MPAGHKNHHGF
{
	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(RVA = "0x8028D90", Offset = "0x8028190", VA = "0x188028D90")]
	internal static byte[] MNCKHODBKDH(byte[] FIKLNMFCLIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x8028B30", Offset = "0x8027F30", VA = "0x188028B30")]
	public static void GGIFCNAGOEG(Stream FEFFODEJHDO, byte[] GPDNJKDEGHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(RVA = "0x8028BB0", Offset = "0x8027FB0", VA = "0x188028BB0")]
	public static bool MDKNMAPLHDN(Stream FEFFODEJHDO, long KBGNHLDHPNA, NLEJCIDMFGB KKAJNCPDLDA, [Out] byte[] NACJGOOIJNC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CC")]
internal sealed class PDEKJADMMJG : GLNNANNECEB, IEquatable<GLNNANNECEB>, IEquatable<PDEKJADMMJG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007F6")]
	private readonly KFKHMIEGJGC MOHOBEHLCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007F7")]
	public readonly FileInfo MNBCFKIPPGJ;

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public BHCHIAOMANO NFMNOCKOPLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x791D340", Offset = "0x791C740", VA = "0x18791D340", Slot = "9")]
		get
		{
			return default(BHCHIAOMANO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public DateTime KKKBAGHLBFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x802AD90", Offset = "0x802A190", VA = "0x18802AD90", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(RVA = "0x802AED0", Offset = "0x802A2D0", VA = "0x18802AED0")]
	public PDEKJADMMJG(KFKHMIEGJGC EEMFILFDIKA, FileInfo KMGOBKOFBEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x802AE20", Offset = "0x802A220", VA = "0x18802AE20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x802AC40", Offset = "0x802A040", VA = "0x18802AC40", Slot = "5")]
	public void FPDBAKJJINA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x802A9E0", Offset = "0x8029DE0", VA = "0x18802A9E0", Slot = "6")]
	public bool DGCKCJFDDHE(long CCHPCHDJHAI, long DCFFKJJLEHN, [Out] IPEJPHCMEGJ HOIBEPBFBCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x802AAE0", Offset = "0x8029EE0", VA = "0x18802AAE0", Slot = "7")]
	public bool Equals(GLNNANNECEB JAPIEEBOJEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0x802AA20", Offset = "0x8029E20", VA = "0x18802AA20", Slot = "8")]
	public bool Equals(PDEKJADMMJG JAPIEEBOJEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0x802AB50", Offset = "0x8029F50", VA = "0x18802AB50", Slot = "0")]
	public override bool Equals(object HAPOBHMBDHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x802AD00", Offset = "0x802A100", VA = "0x18802AD00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CD")]
public delegate void NLEJCIDMFGB(CIGDMMOBHEC.AFPCPDEINMM MPNHIHBIINL, string EIGJGBPHOMK);
[Cpp2IlInjected.Token(Token = "0x20001CE")]
internal interface MCPANOEKGNC
{
	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	BHCHIAOMANO NFMNOCKOPLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JIFDAJLLLHM(long CCHPCHDJHAI, long DCFFKJJLEHN, ONAMBMOGICM AMGCMCFMLOG, [Out] GLNNANNECEB CCGNPPPBHGG);

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<GLNNANNECEB> KDGOOBJKHCA(ONAMBMOGICM AMGCMCFMLOG);

	[Cpp2IlInjected.Token(Token = "0x6000746")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GLNNANNECEB ILHKGCDMAJP(long CCHPCHDJHAI, long DCFFKJJLEHN, IPEJPHCMEGJ HOIBEPBFBCD, ONAMBMOGICM AMGCMCFMLOG);
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
