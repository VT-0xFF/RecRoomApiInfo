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
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
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
		[Cpp2IlInjected.Address(RVA = "0x7257E10", Offset = "0x7256810", VA = "0x187257E10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AE5A0", Offset = "0x8ACFA0", VA = "0x1808AE5A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AE5E0", Offset = "0x8ACFE0", VA = "0x1808AE5E0")]
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
	public class LogRegistrationIndex : NDHLMBGDHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x724FEA0", Offset = "0x724E8A0", VA = "0x18724FEA0", Slot = "4")]
		public override void FBIMIMMHNIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
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
	public class _AssemblyIndex : FDEGBGNEMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7259C80", Offset = "0x7258680", VA = "0x187259C80", Slot = "8")]
		public override void CPJKPCOPIOF(INNEGFJDCKJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x626DEE0", Offset = "0x626C8E0", VA = "0x18626DEE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class GEBLOPHOJKK : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x72412E0", Offset = "0x723FCE0", VA = "0x1872412E0")]
	public GEBLOPHOJKK(string BBDGOIMNDJI, Exception DEHBLLKHAIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class DFBKMJMMHLM : IDABFCKEPNC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct NDMPEBICOPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<BEOIGDDMAEA>> <>t__builder;

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
		private TaskAwaiter<PFFONPMHJGI<BEOIGDDMAEA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7251A00", Offset = "0x7250400", VA = "0x187251A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7251C40", Offset = "0x7250640", VA = "0x187251C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct PBIMMHABDNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<LAAPBDLOOLG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<LAAPBDLOOLG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7258790", Offset = "0x7257190", VA = "0x187258790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x72589A0", Offset = "0x72573A0", VA = "0x1872589A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	[UnityEngine.Scripting.Preserve]
	public DFBKMJMMHLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x723ECF0", Offset = "0x723D6F0", VA = "0x18723ECF0", Slot = "4")]
	[AsyncStateMachine(typeof(NDMPEBICOPJ))]
	public Task<IReadOnlyList<BEOIGDDMAEA>> CNMNNDMILBB(long MOEKPKHCJHD, long OAOCFKDGHFI, [Optional] CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x723EE10", Offset = "0x723D810", VA = "0x18723EE10", Slot = "5")]
	[AsyncStateMachine(typeof(PBIMMHABDNC))]
	public Task<IReadOnlyList<LAAPBDLOOLG>> JMOIOFLBOJH(IReadOnlyList<int> GIBEIPOJGPG, [Optional] CancellationToken LOIOCMLGMKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BPCMFGFOMDN : IEquatable<BPCMFGFOMDN>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int CHKLMGKELDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	LAAPBDLOOLG NGIOJDMMKMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime PMEPFDMIFPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	BDPFNHAIJEP? JMMGHHMBKDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	MPJIEOLOOPF? HIELIBFPOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	BODCHPIMPOD GPDGBJLGEGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<AKHLLPJOLIM> HIPJPCEILBP();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum BODCHPIMPOD
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IDABFCKEPNC
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<BEOIGDDMAEA>> CNMNNDMILBB(long MOEKPKHCJHD, long OAOCFKDGHFI, [Optional] CancellationToken LOIOCMLGMKH);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<LAAPBDLOOLG>> JMOIOFLBOJH(IReadOnlyList<int> GIBEIPOJGPG, [Optional] CancellationToken LOIOCMLGMKH);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class ICCCLMOIACI
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class FFHEAMHBAOD : BPCMFGFOMDN, IEquatable<BPCMFGFOMDN>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct FBDHLEFKIEH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<AKHLLPJOLIM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public FFHEAMHBAOD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private HGIEGEHKIOH <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<NBOIDPFPFBM> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<AKHLLPJOLIM> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7240180", Offset = "0x723EB80", VA = "0x187240180", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7240640", Offset = "0x723F040", VA = "0x187240640", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly BEOIGDDMAEA PKDAIDAEKKE;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int CHKLMGKELDG
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x883E10", Offset = "0x882810", VA = "0x180883E10", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public LAAPBDLOOLG NGIOJDMMKMA
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime GJGELDOOENC
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5DC27A0", Offset = "0x5DC11A0", VA = "0x185DC27A0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public BDPFNHAIJEP? JMMGHHMBKDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1F93610", Offset = "0x1F92010", VA = "0x181F93610", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public MPJIEOLOOPF? HIELIBFPOEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5DC2880", Offset = "0x5DC1280", VA = "0x185DC2880", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public BODCHPIMPOD GPDGBJLGEGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x913B40", Offset = "0x912540", VA = "0x180913B40", Slot = "10")]
			get
			{
				return default(BODCHPIMPOD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7240860", Offset = "0x723F260", VA = "0x187240860", Slot = "9")]
		[AsyncStateMachine(typeof(FBDHLEFKIEH))]
		public Task<AKHLLPJOLIM> HIPJPCEILBP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x72409A0", Offset = "0x723F3A0", VA = "0x1872409A0")]
		public FFHEAMHBAOD(int FKCOBKGNDII, LAAPBDLOOLG IFOCDHOHIFI, BEOIGDDMAEA PKDAIDAEKKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x72406B0", Offset = "0x723F0B0", VA = "0x1872406B0", Slot = "11")]
		public bool Equals(BPCMFGFOMDN CGCLEIBHLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7240740", Offset = "0x723F140", VA = "0x187240740", Slot = "0")]
		public override bool Equals(object FHFDEAHMMBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7240960", Offset = "0x723F360", VA = "0x187240960")]
		private bool LKJOJLPEBFN(FFHEAMHBAOD CGCLEIBHLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x72407E0", Offset = "0x723F1E0", VA = "0x1872407E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class KLAOIECAOFL : BPCMFGFOMDN, IEquatable<BPCMFGFOMDN>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct DKDNIDDKIFK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<AKHLLPJOLIM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public KLAOIECAOFL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<AKHLLPJOLIM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x723FA20", Offset = "0x723E420", VA = "0x18723FA20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x723FC70", Offset = "0x723E670", VA = "0x18723FC70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly BKKMLGPDFKC DFDIPDBHLLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly BDPFNHAIJEP FMOLJMACPIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly MPJIEOLOOPF MKODPAOJLPJ;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int CHKLMGKELDG
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x724F250", Offset = "0x724DC50", VA = "0x18724F250", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public LAAPBDLOOLG NGIOJDMMKMA
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x724F1C0", Offset = "0x724DBC0", VA = "0x18724F1C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime GJGELDOOENC
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x724F5A0", Offset = "0x724DFA0", VA = "0x18724F5A0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public BDPFNHAIJEP? JMMGHHMBKDO
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x724F3E0", Offset = "0x724DDE0", VA = "0x18724F3E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public MPJIEOLOOPF? HIELIBFPOEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x724F650", Offset = "0x724E050", VA = "0x18724F650", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public BODCHPIMPOD GPDGBJLGEGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x975980", Offset = "0x974380", VA = "0x180975980", Slot = "10")]
			get
			{
				return default(BODCHPIMPOD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x163A8E0", Offset = "0x16392E0", VA = "0x18163A8E0")]
		public KLAOIECAOFL(BKKMLGPDFKC FMBLDCCMMOM, BDPFNHAIJEP EHBCFJHOLAH, MPJIEOLOOPF FGNPKGGPHGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x724F4B0", Offset = "0x724DEB0", VA = "0x18724F4B0", Slot = "9")]
		[AsyncStateMachine(typeof(DKDNIDDKIFK))]
		public Task<AKHLLPJOLIM> HIPJPCEILBP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x724F340", Offset = "0x724DD40", VA = "0x18724F340", Slot = "11")]
		public bool Equals(BPCMFGFOMDN CGCLEIBHLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x724F290", Offset = "0x724DC90", VA = "0x18724F290", Slot = "0")]
		public override bool Equals(object FHFDEAHMMBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x724F5F0", Offset = "0x724DFF0", VA = "0x18724F5F0")]
		private bool LKJOJLPEBFN(KLAOIECAOFL CGCLEIBHLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x724F430", Offset = "0x724DE30", VA = "0x18724F430", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class HIBDJMFICMG : BPCMFGFOMDN, IEquatable<BPCMFGFOMDN>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct MPAJEFEDCBN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<AKHLLPJOLIM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<AKHLLPJOLIM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7251730", Offset = "0x7250130", VA = "0x187251730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7251990", Offset = "0x7250390", VA = "0x187251990", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly LAAPBDLOOLG IMGIKGNJIND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly BDPFNHAIJEP FMOLJMACPIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly MPJIEOLOOPF MKODPAOJLPJ;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int CHKLMGKELDG
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7244580", Offset = "0x7242F80", VA = "0x187244580", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public LAAPBDLOOLG NGIOJDMMKMA
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime GJGELDOOENC
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public BDPFNHAIJEP? JMMGHHMBKDO
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7244690", Offset = "0x7243090", VA = "0x187244690", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public MPJIEOLOOPF? HIELIBFPOEE
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7244920", Offset = "0x7243320", VA = "0x187244920", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public BODCHPIMPOD GPDGBJLGEGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240", Slot = "10")]
			get
			{
				return default(BODCHPIMPOD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x163A8E0", Offset = "0x16392E0", VA = "0x18163A8E0")]
		public HIBDJMFICMG(LAAPBDLOOLG IFOCDHOHIFI, BDPFNHAIJEP EHBCFJHOLAH, MPJIEOLOOPF FGNPKGGPHGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7244770", Offset = "0x7243170", VA = "0x187244770", Slot = "9")]
		[AsyncStateMachine(typeof(MPAJEFEDCBN))]
		public Task<AKHLLPJOLIM> HIPJPCEILBP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x72445A0", Offset = "0x7242FA0", VA = "0x1872445A0", Slot = "11")]
		public bool Equals(BPCMFGFOMDN CGCLEIBHLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7244610", Offset = "0x7243010", VA = "0x187244610", Slot = "0")]
		public override bool Equals(object FHFDEAHMMBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x72446E0", Offset = "0x72430E0", VA = "0x1872446E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7244840", Offset = "0x7243240", VA = "0x187244840")]
		private bool LKJOJLPEBFN(HIBDJMFICMG CGCLEIBHLHF)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct AIGCPGPJJDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<BPCMFGFOMDN>> <>t__builder;

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
		public ICCCLMOIACI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<BEOIGDDMAEA> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<BEOIGDDMAEA>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, LAAPBDLOOLG account, BEOIGDDMAEA roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x723C620", Offset = "0x723B020", VA = "0x18723C620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x723D460", Offset = "0x723BE60", VA = "0x18723D460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct HADCCNBNCDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, LAAPBDLOOLG account, BEOIGDDMAEA roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<BEOIGDDMAEA> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public ICCCLMOIACI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<LAAPBDLOOLG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7242F40", Offset = "0x7241940", VA = "0x187242F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7243910", Offset = "0x7242310", VA = "0x187243910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly DKCPOPADEMG GNLGOHKGPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly IDABFCKEPNC MLKMKODLDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly ENAGKPAGHJH LICEFODJBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly HJCAPPCGINM<(long, long), IReadOnlyList<BEOIGDDMAEA>> ABAPADLHEPB;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7244D70", Offset = "0x7243770", VA = "0x187244D70")]
	[UnityEngine.Scripting.Preserve]
	public ICCCLMOIACI([LKKACOOMNBP(null)] IDABFCKEPNC CNLFPBNECLG, [LKKACOOMNBP(null)] ENAGKPAGHJH BHFFBHNJIAC, [LKKACOOMNBP(null)] DKCPOPADEMG GKGIGIJEPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7244A80", Offset = "0x7243480", VA = "0x187244A80")]
	[AsyncStateMachine(typeof(AIGCPGPJJDN))]
	public Task<IList<BPCMFGFOMDN>> JKEBLBHBNMI(long MOEKPKHCJHD, long NMDIIDEMCDI, bool LPMNLGAELNB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7244BD0", Offset = "0x72435D0", VA = "0x187244BD0")]
	private bool MENGHAOJEJF(DateTime? EJMNCHIGLDG, long MOEKPKHCJHD, long NMDIIDEMCDI, [Out] BKKMLGPDFKC HEOEEINJPBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7244970", Offset = "0x7243370", VA = "0x187244970")]
	[AsyncStateMachine(typeof(HADCCNBNCDG))]
	private Task<IReadOnlyList<(int, LAAPBDLOOLG, BEOIGDDMAEA)>> GDIADDFOLCF(IReadOnlyList<BEOIGDDMAEA> KHJDDNGIJLF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface ENAGKPAGHJH
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<BKKMLGPDFKC> PMGNKHJHKOK;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FNPOEMPEJPN(long MOEKPKHCJHD, long NMDIIDEMCDI, FNKDHFNCDJH HBCKKFNCFAB, IHMNJEAIAGN PHAIKKCIPMC);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PFNCHOMMFJJ(long MOEKPKHCJHD, long NMDIIDEMCDI, [Out] BKKMLGPDFKC HEOEEINJPBK);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CKJCDLFMGLD(long MOEKPKHCJHD, long NMDIIDEMCDI, IHMNJEAIAGN PHAIKKCIPMC, [Out] BKKMLGPDFKC HEOEEINJPBK);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AHAAMGPOHEP(long MOEKPKHCJHD, long NMDIIDEMCDI);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface JMDDJLEFKPO : IBKICHECLOP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool KOFIMCIMBCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task GAJIEFMCHEP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BAAGCGMDLAG(Task DJIALEEMCOO, string KOJDGNAGPMN);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface CDCOAANFAKN : IBKICHECLOP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<AKHLLPJOLIM> HHPPLPAFMDH(BKKMLGPDFKC HEOEEINJPBK);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task JDFANJABGNH(CancellationToken LOIOCMLGMKH);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface MDOLEKCMIJG : IBKICHECLOP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	MBGDHIJMIIB BEPNKKGPKNA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FPCBKDGLGGP();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MEDPFHHKIME();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface IBKICHECLOP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HINDDHMAHAN(FGAGHPALDNJ NCAFNAHMGMF);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface KMMINAKBMNC
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan JNNPJHILEIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan OEHBBIFJNNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan HFDJMALECMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan BBMDEFNDMBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool NPJDBMMHICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool KMEKIIHDPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool BKBBNDNGPKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int LJAMEJIMFFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool PHEDFEHMIAK
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool KFPBEIEMAGH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum PJODBLGHFGM
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum AAMHGEMHMAI
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
public struct LBGEPNPLEJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long EBBFOAPEDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long OAOCFKDGHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly PJODBLGHFGM AOGCIMANLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception EHFLGMBOOAD;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x724F6F0", Offset = "0x724E0F0", VA = "0x18724F6F0")]
	public LBGEPNPLEJA(long EBBFOAPEDII, long OAOCFKDGHFI, PJODBLGHFGM AOGCIMANLIJ, [CanBeNull] Exception EHFLGMBOOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x724F6A0", Offset = "0x724E0A0", VA = "0x18724F6A0")]
	public static LBGEPNPLEJA IDOJPEKGCAG(FLFGKHCBJJD JBNNOLFNFCI, PJODBLGHFGM AOGCIMANLIJ, [Optional] Exception EHFLGMBOOAD)
	{
		return default(LBGEPNPLEJA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate void KABIPJMJCMA(LBGEPNPLEJA MPDIMGMLMLB);
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface CHEFPFPNLAH : IBKICHECLOP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action AFOJNLGEBIA;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event KABIPJMJCMA IGGAFOLMODO;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event KABIPJMJCMA GBOCHEODLHJ;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event KABIPJMJCMA FJKGLNIPELD;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<AAMHGEMHMAI, bool> EJMPOEDFGCM;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FBPLOACBMJA();

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JLOIMNJMJJA(LBGEPNPLEJA MPDIMGMLMLB);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NNCLGLLKMJK(LBGEPNPLEJA MPDIMGMLMLB);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void BGGLBCOLNBP(LBGEPNPLEJA MPDIMGMLMLB);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ODCDEKONLEF(AAMHGEMHMAI PILNALGGBDH, bool FAJBCEPOPIC);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface JGIFLLCDELO : IBKICHECLOP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task GDEFFEFLBFI();

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DCAPLDHJFNG();
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface AICBHGIIPCC : IBKICHECLOP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TaskStatus FPIIIEGLHKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task PJGILNINOEI(FLFGKHCBJJD GLKHPKFKHBP, MLKICDEJOHA JKHINNBAOLE, CancellationToken BENMLFLNPKG);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal static class BPNPBJLGDCM
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x723DD90", Offset = "0x723C790", VA = "0x18723DD90")]
	public static bool IAPGGJCMJHN(this AICBHGIIPCC ACLDJPPMMKC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public delegate Task KAMMFCOFEKA(CancellationToken OEELDHBFFAF, int HOCGJECDFPB, LNBDJMHHJGO ELPFAHNNEBO);
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface AGBNPJFBPJE : IBKICHECLOP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LFMEDBPMOOE(KAMMFCOFEKA FBLPLFLECFP);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface FGAGHPALDNJ : HGIEGEHKIOH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CancellationToken ILNIGJLCOBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	FNNNJBMCDDC FLLHNGMEMOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	MMHLBANLMND HHPJNKNGKEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	GKKFLCEIJBD ANELFHIMBGF
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	CIFFNCDBMGE FJMIEGHLOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	EFNKOCFKAGD GEKNCMNDKFA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	INLGAAHNKKO KFLHNODJJBH
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	HAMCOKMBKOP NGPCCJNHEMH
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NBEBJDKLKGB HJMIKOBGPGI
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	JMDDJLEFKPO IGAGLLKHOBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	CDCOAANFAKN NMEHMCCKAAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	CHEFPFPNLAH AIAIFAOKMEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	JGIFLLCDELO NJMFFOFMFDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	AICBHGIIPCC JCCBHGDPMKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	AGBNPJFBPJE LLLGAPNBACK
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	KKPEPLMLPGP JFHPMCDGPFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	FGGCPEEBABA IOOONBIKNKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	CGAIKGLOANH FPLHBNOGAPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	PMJOEOOAEEK GPOHPMKFHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	ENDPBOLMIGD ABFJBGLFFBF
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	KMKMNKDOIAM KBOBOFDDCKE
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	BHHODHEHGIH KADEGNINIOH
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	KJJMDHOPKCC CAKMHCKJJGB
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	JMICKOINANM HBAELPGOBBE
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	NNAPFBHACLG HOLJDGAFHJH
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	MDOLEKCMIJG LKAONEDFIMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	KMMINAKBMNC OCJIOBLIHJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	GLGFPDCOPAH EJMABPBKADP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	ENAGKPAGHJH FEBKKFKHGLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	IBLNJEOJMIB LNFKLNNIHPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	LMCJEKCBNKB KGAKFMDJHOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	LNMBGKHEPPE GPFMAPHFPJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	FNAGFEIMDPL JEEMHAEHFNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void AFHBMBMHDLD(MLKICDEJOHA PBODNKDDCIM);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface KKPEPLMLPGP : IBKICHECLOP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KHNJPFEAAJA KDCHLCHLBCK(Guid OOCNLFNKKML);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GDFNAHCIADO(Guid OOCNLFNKKML);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool INJHINDIHGJ(Guid OOCNLFNKKML, Task NOMEBNIPKKI);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HHJPJGGIAJE(Guid OOCNLFNKKML, AKHLLPJOLIM CBCNCOEPKLK);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(AKHLLPJOLIM, Task)> NEOHJLAFGAH(Guid OOCNLFNKKML);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface ENGAAKMEHHE : IBKICHECLOP, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface FGGCPEEBABA : IBKICHECLOP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JDMEPHAPAGH(CELGPAAAIIN BBDGOIMNDJI);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ELINJJBHMIA(CELGPAAAIIN BBDGOIMNDJI);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<IBPIJMAGBAA> ABGOJLIKHFP(CancellationToken FBCMDPADHIO);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface CGAIKGLOANH : IBKICHECLOP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KHNJPFEAAJA OBBHJPJHLDA(CELGPAAAIIN OGOBLPBPLMI);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LEFFKLIHCME(Guid OOCNLFNKKML, Task NOMEBNIPKKI);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface PMJOEOOAEEK : IBKICHECLOP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<AKHLLPJOLIM> GPOHPMKFHHJ(CELGPAAAIIN GHHJCAFPGMI);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface ENDPBOLMIGD : IBKICHECLOP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IMNJOLLKFEM> AKBOHGCKELK(GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, FLFGKHCBJJD GLKHPKFKHBP, CancellationToken LOIOCMLGMKH);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface BHHODHEHGIH : IBKICHECLOP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AKHLLPJOLIM KPOMPGFNILP(ICGGIJDMFMC NKFPHIOHJGB);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GBGNFEDLBOD(string KCEMGCAKHDC);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface KMKMNKDOIAM : IBKICHECLOP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CELGPAAAIIN> BFPGAACJLAH(CELGPAAAIIN MGBHCKLJEHL, MILPNFIFKAC PDGPAJDMGIC, CancellationToken LOIOCMLGMKH);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<CELGPAAAIIN> OFPBHBOPFNB(CancellationToken LOIOCMLGMKH, MILPNFIFKAC PDGPAJDMGIC);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JHPBEIHBNBJ FIJDNBEPILK(IGIEMLKHNDA LNAJFNNDKKK, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JHPBEIHBNBJ BGDCJHAEBOA(IGIEMLKHNDA LNAJFNNDKKK, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface KJJMDHOPKCC : IBKICHECLOP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AKHLLPJOLIM DHBOFAGMCGO(ICGGIJDMFMC NKFPHIOHJGB, IBPIJMAGBAA POBPINKCPGH);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AKHLLPJOLIM DLKDBCLDAPE(ICGGIJDMFMC JAJDIOMIOCD);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface JMICKOINANM
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FAMGJKALDDL(HFHHNJGAHIF OKOBIDLBHBO);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NEEFJLNJFDB(HFHHNJGAHIF OKOBIDLBHBO);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FDGGBCODJIN(HFHHNJGAHIF OKOBIDLBHBO);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EGPANNOMMCF(HFHHNJGAHIF OKOBIDLBHBO);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class HFHHNJGAHIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly FLFGKHCBJJD AJJNLOAIHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> ICPABKEBJPL;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public GOLFJDFFGLD<string> HOLEGDODMIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x885640", Offset = "0x884040", VA = "0x180885640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8913E0", Offset = "0x88FDE0", VA = "0x1808913E0")]
	public HFHHNJGAHIF(FLFGKHCBJJD GDEDPAAODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x72444B0", Offset = "0x7242EB0", VA = "0x1872444B0")]
	public HFHHNJGAHIF PECBPMPMKBH(string COMNIKKFEEB, string IPHMAHBENGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7244420", Offset = "0x7242E20", VA = "0x187244420")]
	public bool CIDEPMNJILE([Out] IEnumerable<KeyValuePair<string, string>> FFMAFOBFPMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6492A60", Offset = "0x6491460", VA = "0x186492A60")]
	public HFHHNJGAHIF ABKCEHABPHH(GOLFJDFFGLD<string> MBHLFFACPEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface GLGFPDCOPAH
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool ILODOJGNINM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	string DHKGFIEBAJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool NMEFPOLHGLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ECOPBFHJDNH();

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FGEOBGDPNLE CPBLFNNFCGJ(long FNDGMLDNPNL);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GOHOJKICAGG<LGAFJFEBDLI, GHGEAPMBJNK> IFLIHHHDFHK(long FNDGMLDNPNL);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GOHOJKICAGG<LGAFJFEBDLI, EGDKLHCLIKL> MLOLNMDFEIC(long FNDGMLDNPNL);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GOHOJKICAGG<long, NHAKOHKGGMG> CNDHDPFLFNO();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FIHDIBBINGI(long FNDGMLDNPNL, [Out] bool DCKOHEGNMHG);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<bool> KPNMJJPOBCJ(byte[] IPPFHGIBMOF, byte[] NDNMMDDAEMJ, CancellationToken LOIOCMLGMKH);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface HGIEGEHKIOH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool IAPGGJCMJHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool NPIFOGNHMFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	MLKICDEJOHA FHMCBLNPFHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action AFOJNLGEBIA;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event KABIPJMJCMA IGGAFOLMODO;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event KABIPJMJCMA GBOCHEODLHJ;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event KABIPJMJCMA FJKGLNIPELD;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<AAMHGEMHMAI, bool> EJMPOEDFGCM;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DCAPLDHJFNG();

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	DEDBOOPDHDF EANGOBHMABF();

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "14")]
	KGNIFDDMKKJ BOADIGKLKPH();

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<AKHLLPJOLIM> HHPPLPAFMDH(BKKMLGPDFKC FMBLDCCMMOM);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task JDFANJABGNH(CancellationToken LOIOCMLGMKH);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface EFNKOCFKAGD
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool EJLONMAOPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	string NMEBEPBJJKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MHBKLHHEENO(Scene ODFBOBCAIMB);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task NCEPMCCGKDJ(GBJMJJIHNHN GPICJLIDBHF, CancellationToken LOIOCMLGMKH);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task NLPHGMCHGME();

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task JDHGEEBEAMH();
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface CIFFNCDBMGE
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	DPDIKCBEILH NNPDHOLGNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool ONMGLJIONPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool CIHCEFIHLHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool KDIIMBJOCHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool GJABIAEGGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	int EFOEJLPDCKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool HBPEOCHKMOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool OHHLENJOMEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	byte FMIFCHGIJJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	byte JHPEDKFFFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool LNCPEHGCGPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool CACGGEBAMLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool AECJLCGPCOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	float BBCCCEBCIPL
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> NMDHBBIIMGE;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FNNNJBMCDDC KJCCOPAAGPH(FNNNJBMCDDC KJJLKBPLCPE);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EGBBFGKGDOP(FNNNJBMCDDC NKDOKEFKKDI);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void POGOMJIBPEO();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task IDEIPLKEAIK(GOLFJDFFGLD<string>.EFMHMOBJFGI LJPDIAJNOGH, CancellationToken LOIOCMLGMKH);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DIDJEIECPCJ(float JMOFNDHPCFH);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MHOOKCFOAKL(string JOGNFAPCOHE);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<NKCJHNHKDGB> KNEGKLMONHI();

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable OOJFOHENMIK(object MPOBGCPIOEI, NKCJHNHKDGB GNOOEAHLONB);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<LFFEIIPBOIA> MMAPHLMFBPE();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	GHGEAPMBJNK KKANILPAHBN(IEnumerable<OEAGPMFPCEL> IDIHGMMGLOE);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MOFJMGHDLMC(int NAANNFJNLEO);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task BPKOEPNLAKE();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void HILGPIAELGH();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool FILONHMONCG();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task KGLCENIJJOL(CancellationToken LOIOCMLGMKH);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task GMAIKLKDFKI(CancellationToken LOIOCMLGMKH);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<IOMPOJPCGMJ> GLFNDBDNJJC(DateTime PIOPNGEIJMB, CancellationToken LOIOCMLGMKH);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> AHACHODGLKI(CancellationToken LOIOCMLGMKH);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void JDKGFFFOOHO(string BBDGOIMNDJI = "", float GLIHGPEPPCD = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "25")]
	GOHCPCCLBBP IFEJDHIHIIB(CHIDMAEAKIM BEFFGCNODKD, HFFOHGGNEID MHHOLLPCDIN, EGDKLHCLIKL HHPGIHNIGBN, IEnumerable<PersistenceView> BICMIAAIGKE, BLHBGBALGGJ JOABFILHDFE);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void FGDMJIIDKMO(EGDKLHCLIKL HHPGIHNIGBN);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void ONDPOLGBLAL(OEAGPMFPCEL OKFKNACKKGK, [In] GOHCPCCLBBP MHAHKDLDBBM);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task BEFBMEECJIA(EGDKLHCLIKL FIAJEGMHHBJ, bool LHLBJCLGABB, CancellationToken LOIOCMLGMKH);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task FEPJBOBININ(CancellationToken LOIOCMLGMKH);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void DIPDLKPGMNG(long MOEKPKHCJHD, long OAOCFKDGHFI, NBOIDPFPFBM HELAFOILBPK, BEOIGDDMAEA BMENFJPHGAB, FNKDHFNCDJH HBCKKFNCFAB, BFKIDDCLOKK? CNLLIFFAFAG, IHKLNMNONHG? OEBMIFFJLCC);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void DCDEIBDNOHI(long MOEKPKHCJHD, long OAOCFKDGHFI, IHKLNMNONHG? OEBMIFFJLCC);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void CKALDEIOBNB(PersistenceView HOJFKIDGEHK);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool PNPNFMHPFKF(PersistenceView BDGJAKFBCKL);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool AIIJIHDFHFI(OEAGPMFPCEL OKFKNACKKGK, OEONGJBPPJN DBJLFEPCIKM, [Out] NMCMBFFDKNP OEGHJLOGDPB);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task BPLLPABBFPI(CancellationToken LOIOCMLGMKH);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void OKPCJKDOFJB();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable GKJAGDHKCBD();

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void CCPBBIEFPGH(EGDKLHCLIKL FIAJEGMHHBJ, OEONGJBPPJN DBJLFEPCIKM);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<bool> MFKFNIMMICK(MMHLBANLMND NHPIKOHJFBH, CancellationToken LOIOCMLGMKH, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void BODBOELICEB(CancellationToken LOIOCMLGMKH);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<ANLPGLHMEBJ> GJGMLJONOGI(ABEOAPJLLEM MGBHCKLJEHL);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<NBOIDPFPFBM> IBNDINPCEEI(long MOEKPKHCJHD, bool CONENHAOLKF, CancellationToken LOIOCMLGMKH);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<BEOIGDDMAEA> ONKGJDOCBCD(long MOEKPKHCJHD, long OAOCFKDGHFI, long NNPDAFALPBG, CancellationToken LOIOCMLGMKH);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<BEOIGDDMAEA> GFLIMDDJNPN(long MOEKPKHCJHD, long OAOCFKDGHFI, CancellationToken LOIOCMLGMKH);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<OGEJFLLGHCE> HPCFAPEICDC(string IJGMHBOCGFJ, CancellationToken LOIOCMLGMKH);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<OGEJFLLGHCE> HFJHAEBHAGJ(string IJGMHBOCGFJ, long MOEKPKHCJHD, long OAOCFKDGHFI, string CGCFDFNPJNA, IKOFLNOKKHP.ICKENEBJDOH HCKNFILJEND, IKOFLNOKKHP.ICKENEBJDOH NDNMMDDAEMJ, int PPGFEIKKFKK);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool CKBBPMPBEGO();

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "49")]
	bool CKAOLFPKFIM();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool PCOINECOLCF(IEnumerable<NMCMBFFDKNP> DEMAIMNGKDE);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void BIPMMNMGGDA(List<GameObject> KPODJKEAJCB);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "52")]
	float PFNJLBJPJOG();

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "53")]
	Task<Scene> EDAHGKGLMOC(string MIHEAIGNLHB, LoadSceneMode IDEOBHFKGEL, bool KMBCBEELMDE, GOLFJDFFGLD<string>.EFMHMOBJFGI MBHLFFACPEB);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void BINMNJBPPFB();

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void MOFJPPKEHJF(bool PBBOCFHFMJC);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void LDOEDLEOAPB();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void AKFEDAMBENI();

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void ONNJILOKAAC(FLFGKHCBJJD CPHHMAHEGMA);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Task OCDPJOGGLHN(GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "69")]
	Task JIDDIAKAMMA(GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "70")]
	Task LEIJGBIGCBI(GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "71")]
	Task DOFHBKALHNB(GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "72")]
	IDisposable FHHIJCEPCAK();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "73")]
	ECDKEFHMNCF GONEHDFKJGG();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task LMEMCHJOLBM(CancellationToken LOIOCMLGMKH);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface ECDKEFHMNCF
{
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task CANNIJPHNHH(CancellationToken LOIOCMLGMKH);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task FGEJDDBJFGL(CancellationToken LOIOCMLGMKH);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct GOHCPCCLBBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> IEFGPELCIDJ;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public enum IOMPOJPCGMJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct CHIDMAEAKIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public string HFGMKFLDDAN;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface DPDIKCBEILH
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	FLFGKHCBJJD KBDFDJCLIIG
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	NBOIDPFPFBM DKOOFCLDBCA
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	OPLJDOIGEJC GCJOBDKONCH
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool AEBAKPCAJJA
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool FIOKLMFAFHK
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	int BEOBDMIHDGG
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action LJHBIAHLILA;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> IDDOIDHHGMI;

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JCLAPOJNMAK();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.HHEENMENMII> IGNPPGDPLKN(long FNDGMLDNPNL, [Optional] CancellationToken LOIOCMLGMKH);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<AHHBFPPCKKM> BDIDGNBBGCO();

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task HHOOJPKOCPA();

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(FLFGKHCBJJD, MLKICDEJOHA) KFDJGLNIENI();

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "15")]
	HCKKKMLKBME BKHMIAONPEJ();

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KCEMPHDEGLF(long FNDGMLDNPNL);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void NFBPALOFOEP(FLFGKHCBJJD GDEDPAAODIE, Matchmaking.FDCDEKFCOJH NLAECIHBKHE, (int Major, int? Minor)? GHILOAGNIAE);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface NNAPFBHACLG
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CLPLOKJDHKL([Out] IEnumerable<int> IJMNMKPMNGE);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GCONINJCNMH(FKBHKHOFIEC OEELDHBFFAF);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AHFONDCLPGB(FKBHKHOFIEC OEELDHBFFAF);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface APIEDIDMLNA
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string IKNBFGHMKDK(AKHLLPJOLIM KIBLJLKIFJI);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface COHPPPNIMFL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AHNEJPIGOPA(BEJGMKFODHN.CGELBCPAECL GEPFENNDPEF);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JDAJDCNFGED(BEJGMKFODHN.CGELBCPAECL GEPFENNDPEF);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface INLGAAHNKKO : COHPPPNIMFL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AKHLLPJOLIM BKGPAJNHPKB(ICGGIJDMFMC JAJDIOMIOCD);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface HAMCOKMBKOP : COHPPPNIMFL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AKHLLPJOLIM KPOMPGFNILP(ICGGIJDMFMC JDGFBJBABBK);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface FGEOBGDPNLE
{
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CDOLGFBAJII<GBJMJJIHNHN, PKNKGFKCKHA>> HDDHACKJKGP(string CGCFDFNPJNA, long FNDGMLDNPNL, long? MOEKPKHCJHD, long? OAOCFKDGHFI, IIHPMDGIECC.CFKNKDEMDKJ GKOMPLMOPJP, CancellationToken LOIOCMLGMKH);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface GOHOJKICAGG<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CDOLGFBAJII<LDBHNJKNPKI<TData>, PKNKGFKCKHA>> NIJHDKDEPPG(TGetDataArg OKHFPGFAECB, CancellationToken LOIOCMLGMKH);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class KEJAOIAGINP : FGAGHPALDNJ, HGIEGEHKIOH, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct GHLFELMJEAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public AsyncTaskMethodBuilder<AKHLLPJOLIM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public KEJAOIAGINP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public BKKMLGPDFKC autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter<AKHLLPJOLIM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7241C50", Offset = "0x7240650", VA = "0x187241C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7241ED0", Offset = "0x72408D0", VA = "0x187241ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct FMJBPLLMPAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KEJAOIAGINP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7241050", Offset = "0x723FA50", VA = "0x187241050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7241280", Offset = "0x723FC80", VA = "0x187241280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class MFFIGHLPABL : IEnumerable<IBKICHECLOP>, IEnumerable, IEnumerator<IBKICHECLOP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private IBKICHECLOP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public KEJAOIAGINP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		private IBKICHECLOP System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x976660", Offset = "0x975060", VA = "0x180976660")]
		[DebuggerHidden]
		public MFFIGHLPABL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x72507B0", Offset = "0x724F1B0", VA = "0x1872507B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7250C10", Offset = "0x724F610", VA = "0x187250C10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x7250B60", Offset = "0x724F560", VA = "0x187250B60", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<IBKICHECLOP> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x7250B60", Offset = "0x724F560", VA = "0x187250B60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource MBNNGNBCNEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly FNNNJBMCDDC NKDOKEFKKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool NMOEEADIFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private CBLMPKMEIGI AJDALGGGPPH;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public MMHLBANLMND HHPJNKNGKEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x883D50", Offset = "0x882750", VA = "0x180883D50", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x883E30", Offset = "0x882830", VA = "0x180883E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public GKKFLCEIJBD ANELFHIMBGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x88B2B0", Offset = "0x889CB0", VA = "0x18088B2B0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x88B2A0", Offset = "0x889CA0", VA = "0x18088B2A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public CIFFNCDBMGE FJMIEGHLOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x88B2F0", Offset = "0x889CF0", VA = "0x18088B2F0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x88B2D0", Offset = "0x889CD0", VA = "0x18088B2D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public EFNKOCFKAGD GEKNCMNDKFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x88C420", Offset = "0x88AE20", VA = "0x18088C420", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x88C410", Offset = "0x88AE10", VA = "0x18088C410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public INLGAAHNKKO KFLHNODJJBH
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x88B270", Offset = "0x889C70", VA = "0x18088B270", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x88B280", Offset = "0x889C80", VA = "0x18088B280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public HAMCOKMBKOP NGPCCJNHEMH
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x88B1C0", Offset = "0x889BC0", VA = "0x18088B1C0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x88B290", Offset = "0x889C90", VA = "0x18088B290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public NBEBJDKLKGB HJMIKOBGPGI
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x883D40", Offset = "0x882740", VA = "0x180883D40", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x883E00", Offset = "0x882800", VA = "0x180883E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public JMDDJLEFKPO IGAGLLKHOBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x883E50", Offset = "0x882850", VA = "0x180883E50", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x883E40", Offset = "0x882840", VA = "0x180883E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public CDCOAANFAKN NMEHMCCKAAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x883C90", Offset = "0x882690", VA = "0x180883C90", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x883DE0", Offset = "0x8827E0", VA = "0x180883DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public CHEFPFPNLAH AIAIFAOKMEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x9C2BB0", Offset = "0x9C15B0", VA = "0x1809C2BB0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xD2B0B0", Offset = "0xD29AB0", VA = "0x180D2B0B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public JGIFLLCDELO NJMFFOFMFDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x883D00", Offset = "0x882700", VA = "0x180883D00", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x883E60", Offset = "0x882860", VA = "0x180883E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public AICBHGIIPCC JCCBHGDPMKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x92C030", Offset = "0x92AA30", VA = "0x18092C030", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x913BD0", Offset = "0x9125D0", VA = "0x180913BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public AGBNPJFBPJE LLLGAPNBACK
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x88EC20", Offset = "0x88D620", VA = "0x18088EC20", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x88EBD0", Offset = "0x88D5D0", VA = "0x18088EBD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public KKPEPLMLPGP JFHPMCDGPFA
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x913710", Offset = "0x912110", VA = "0x180913710", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x913720", Offset = "0x912120", VA = "0x180913720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public ENGAAKMEHHE LGDOIKECBCG
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA957B0", Offset = "0xA941B0", VA = "0x180A957B0", Slot = "57")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xD126E0", Offset = "0xD110E0", VA = "0x180D126E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public FGGCPEEBABA IOOONBIKNKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x94E390", Offset = "0x94CD90", VA = "0x18094E390", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xB8B480", Offset = "0xB89E80", VA = "0x180B8B480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public CGAIKGLOANH FPLHBNOGAPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9CE9E0", Offset = "0x9CD3E0", VA = "0x1809CE9E0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xB91240", Offset = "0xB8FC40", VA = "0x180B91240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public PMJOEOOAEEK GPOHPMKFHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9585E0", Offset = "0x956FE0", VA = "0x1809585E0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x998A90", Offset = "0x997490", VA = "0x180998A90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public ENDPBOLMIGD ABFJBGLFFBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x88EC10", Offset = "0x88D610", VA = "0x18088EC10", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x88EBF0", Offset = "0x88D5F0", VA = "0x18088EBF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public KMKMNKDOIAM KBOBOFDDCKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xAFA650", Offset = "0xAF9050", VA = "0x180AFA650", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xC36310", Offset = "0xC34D10", VA = "0x180C36310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public BHHODHEHGIH KADEGNINIOH
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xACF520", Offset = "0xACDF20", VA = "0x180ACF520", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xDD90F0", Offset = "0xDD7AF0", VA = "0x180DD90F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public KJJMDHOPKCC CAKMHCKJJGB
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8CE890", Offset = "0x8CD290", VA = "0x1808CE890", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xDD90D0", Offset = "0xDD7AD0", VA = "0x180DD90D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public JMICKOINANM HBAELPGOBBE
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x957100", Offset = "0x955B00", VA = "0x180957100", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xC35070", Offset = "0xC33A70", VA = "0x180C35070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public NNAPFBHACLG HOLJDGAFHJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x90CF70", Offset = "0x90B970", VA = "0x18090CF70", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x90D410", Offset = "0x90BE10", VA = "0x18090D410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public MDOLEKCMIJG LKAONEDFIMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x90CDF0", Offset = "0x90B7F0", VA = "0x18090CDF0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xDD9250", Offset = "0xDD7C50", VA = "0x180DD9250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public KMMINAKBMNC OCJIOBLIHJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xAFA6F0", Offset = "0xAF90F0", VA = "0x180AFA6F0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xDD9230", Offset = "0xDD7C30", VA = "0x180DD9230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public GLGFPDCOPAH EJMABPBKADP
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9E1410", Offset = "0x9DFE10", VA = "0x1809E1410", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xDD9170", Offset = "0xDD7B70", VA = "0x180DD9170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public ENAGKPAGHJH FEBKKFKHGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x9E1400", Offset = "0x9DFE00", VA = "0x1809E1400", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public IBLNJEOJMIB LNFKLNNIHPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x950B20", Offset = "0x94F520", VA = "0x180950B20", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public LMCJEKCBNKB KGAKFMDJHOE
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x954ED0", Offset = "0x9538D0", VA = "0x180954ED0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public LNMBGKHEPPE GPFMAPHFPJD
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xD42F60", Offset = "0xD41960", VA = "0x180D42F60", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public FNAGFEIMDPL JEEMHAEHFNM
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x9F8E30", Offset = "0x9F7830", VA = "0x1809F8E30", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public MLKICDEJOHA FHMCBLNPFHP
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x9839C0", Offset = "0x9823C0", VA = "0x1809839C0", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xDD9130", Offset = "0xDD7B30", VA = "0x180DD9130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private bool NGOKGEHDKEK
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x724DD50", Offset = "0x724C750", VA = "0x18724DD50", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private bool PKKECPCEJBF
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x724DCD0", Offset = "0x724C6D0", VA = "0x18724DCD0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private CancellationToken KAFKHJJECBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x724D670", Offset = "0x724C070", VA = "0x18724D670", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private FNNNJBMCDDC CDJHIMKBLFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action LMHAIFOBIFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x724D910", Offset = "0x724C310", VA = "0x18724D910", Slot = "38")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x724D6F0", Offset = "0x724C0F0", VA = "0x18724D6F0", Slot = "39")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event KABIPJMJCMA NCEKBNLKLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x724D3F0", Offset = "0x724BDF0", VA = "0x18724D3F0", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x724DC70", Offset = "0x724C670", VA = "0x18724DC70", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event KABIPJMJCMA GIOBFNANCBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x724DAC0", Offset = "0x724C4C0", VA = "0x18724DAC0", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x724DA60", Offset = "0x724C460", VA = "0x18724DA60", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event KABIPJMJCMA NLKONLIHIGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x724DC10", Offset = "0x724C610", VA = "0x18724DC10", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x724D690", Offset = "0x724C090", VA = "0x18724D690", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<AAMHGEMHMAI, bool> CJDCEHNKGOM
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x724DE00", Offset = "0x724C800", VA = "0x18724DE00", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x724D970", Offset = "0x724C370", VA = "0x18724D970", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0xDD9130", Offset = "0xDD7B30", VA = "0x180DD9130", Slot = "37")]
	public void AFHBMBMHDLD(MLKICDEJOHA PBODNKDDCIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x724DE60", Offset = "0x724C860", VA = "0x18724DE60")]
	[UnityEngine.Scripting.Preserve]
	internal KEJAOIAGINP([LKKACOOMNBP(null)] FNNNJBMCDDC NKDOKEFKKDI, [LKKACOOMNBP(null)] MMHLBANLMND NHPIKOHJFBH, [LKKACOOMNBP(null)] GKKFLCEIJBD JIHGKELGKLG, [LKKACOOMNBP(null)] CIFFNCDBMGE HILLMDJLLHN, [LKKACOOMNBP(null)] EFNKOCFKAGD IEGOGCILMAM, [LKKACOOMNBP(null)] INLGAAHNKKO EFMONLFGACP, [LKKACOOMNBP(null)] HAMCOKMBKOP FKPPAPHNOEF, [LKKACOOMNBP(null)] NBEBJDKLKGB DCGJPHFKPFE, [LKKACOOMNBP(null)] JMDDJLEFKPO JLGHMOKLLEE, [LKKACOOMNBP(null)] CDCOAANFAKN EKOINKEHBPI, [LKKACOOMNBP(null)] CHEFPFPNLAH EOBABJGIHLL, [LKKACOOMNBP(null)] JGIFLLCDELO JEGGPKGLKCD, [LKKACOOMNBP(null)] AICBHGIIPCC ACLDJPPMMKC, [LKKACOOMNBP(null)] AGBNPJFBPJE JALADFJIJMD, [LKKACOOMNBP(null)] KKPEPLMLPGP JDGKHMCHAPK, [LKKACOOMNBP(null)] ENGAAKMEHHE GPCNJPBJCMD, [LKKACOOMNBP(null)] FGGCPEEBABA ELAHHDIOCDJ, [LKKACOOMNBP(null)] CGAIKGLOANH EIMGFBCBFMK, [LKKACOOMNBP(null)] PMJOEOOAEEK CCCGELGFIAE, [LKKACOOMNBP(null)] ENDPBOLMIGD LGPIAOPCNDD, [LKKACOOMNBP(null)] BHHODHEHGIH DHFFPBHBGKN, [LKKACOOMNBP(null)] KMKMNKDOIAM MACEODBCNIM, [LKKACOOMNBP(null)] KJJMDHOPKCC DGHPCNCOEPG, [LKKACOOMNBP(null)] JMICKOINANM JLAPPFBNJBH, [LKKACOOMNBP(null)] NNAPFBHACLG JMGAGNOEDPF, [LKKACOOMNBP(null)] KMMINAKBMNC EILKMNJGOBA, [LKKACOOMNBP(null)] GLGFPDCOPAH BDMKNGFGKCB, [LKKACOOMNBP(null)] ENAGKPAGHJH MKCACONIPHL, [LKKACOOMNBP(null)] IBLNJEOJMIB EAEPHFCLJDK, [LKKACOOMNBP(null)] LMCJEKCBNKB OHLCPPFCGAC, [LKKACOOMNBP(null)] LNMBGKHEPPE HNBNFFEILKE, [LKKACOOMNBP(null)] FNAGFEIMDPL JBONBGBOHBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x724D750", Offset = "0x724C150", VA = "0x18724D750")]
	private void HINDDHMAHAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x724D4E0", Offset = "0x724BEE0", VA = "0x18724D4E0", Slot = "56")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x724DDB0", Offset = "0x724C7B0", VA = "0x18724DDB0", Slot = "50")]
	private void PEGEAGKIKHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x724D450", Offset = "0x724BE50", VA = "0x18724D450", Slot = "51")]
	private DEDBOOPDHDF DFFOGCGMFIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x724D9D0", Offset = "0x724C3D0", VA = "0x18724D9D0", Slot = "52")]
	private KGNIFDDMKKJ KBLOJFFPNIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x724D800", Offset = "0x724C200", VA = "0x18724D800", Slot = "53")]
	[AsyncStateMachine(typeof(GHLFELMJEAK))]
	private Task<AKHLLPJOLIM> IFCCAINLMIJ(BKKMLGPDFKC HEOEEINJPBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x724DB20", Offset = "0x724C520", VA = "0x18724DB20", Slot = "54")]
	[AsyncStateMachine(typeof(FMJBPLLMPAM))]
	private Task LIKFLODBFJM(CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x724D310", Offset = "0x724BD10", VA = "0x18724D310")]
	[IteratorStateMachine(typeof(MFFIGHLPABL))]
	private IEnumerable<IBKICHECLOP> ACFBDONLMJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x724D390", Offset = "0x724BD90", VA = "0x18724D390")]
	[CompilerGenerated]
	private void BJNFDMLINKJ(IBKICHECLOP ANHGADCFANN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class ALIHDBMBLCA : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x1151750", Offset = "0x1150150", VA = "0x181151750")]
	public ALIHDBMBLCA(string BBDGOIMNDJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal class PNEPBDJJIKI : BHEMBNBIBKG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct GECFKEGCGBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public PNEPBDJJIKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7241350", Offset = "0x723FD50", VA = "0x187241350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7241690", Offset = "0x7240090", VA = "0x187241690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly FGAGHPALDNJ NCAFNAHMGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CIFFNCDBMGE HILLMDJLLHN;

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x887590", Offset = "0x885F90", VA = "0x180887590")]
	public PNEPBDJJIKI(FGAGHPALDNJ NCAFNAHMGMF, CIFFNCDBMGE HILLMDJLLHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x72593F0", Offset = "0x7257DF0", VA = "0x1872593F0", Slot = "4")]
	[AsyncStateMachine(typeof(GECFKEGCGBI))]
	public Task<bool> BNFCKIGOLIK(CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x72594E0", Offset = "0x7257EE0", VA = "0x1872594E0")]
	[CompilerGenerated]
	private object GGOCKIOLJFE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal class NEPPEEGABCJ : BHEMBNBIBKG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct DJAPBPMBGKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public NEPPEEGABCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private float <timeoutTime>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x723EF20", Offset = "0x723D920", VA = "0x18723EF20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x723F630", Offset = "0x723E030", VA = "0x18723F630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly FGAGHPALDNJ NCAFNAHMGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly CIFFNCDBMGE HILLMDJLLHN;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	private DPDIKCBEILH NNPDHOLGNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7255900", Offset = "0x7254300", VA = "0x187255900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x887590", Offset = "0x885F90", VA = "0x180887590")]
	public NEPPEEGABCJ(FGAGHPALDNJ NCAFNAHMGMF, CIFFNCDBMGE HILLMDJLLHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x72556F0", Offset = "0x72540F0", VA = "0x1872556F0", Slot = "4")]
	[AsyncStateMachine(typeof(DJAPBPMBGKH))]
	public Task<bool> BNFCKIGOLIK(CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x7255820", Offset = "0x7254220", VA = "0x187255820")]
	[CompilerGenerated]
	private object DMMOCKJGINN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal class FGGEDHDDANN : BHEMBNBIBKG
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class OHELHGABHLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public FGGEDHDDANN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AHHBFPPCKKM result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public FLFGKHCBJJD newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public OHELHGABHLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x7257F00", Offset = "0x7256900", VA = "0x187257F00")]
		internal object GGNABDFLGNI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7257E90", Offset = "0x7256890", VA = "0x187257E90")]
		internal object BNPECFMGCCM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7257FF0", Offset = "0x72569F0", VA = "0x187257FF0")]
		internal object IDOCOHMLKHE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct KDCDCHDKIHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public FGGEDHDDANN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private OHELHGABHLA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<AHHBFPPCKKM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x724C990", Offset = "0x724B390", VA = "0x18724C990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x724D2A0", Offset = "0x724BCA0", VA = "0x18724D2A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly FGAGHPALDNJ NCAFNAHMGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly CIFFNCDBMGE HILLMDJLLHN;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private DPDIKCBEILH NNPDHOLGNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7240B20", Offset = "0x723F520", VA = "0x187240B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x887590", Offset = "0x885F90", VA = "0x180887590")]
	public FGGEDHDDANN(FGAGHPALDNJ NCAFNAHMGMF, CIFFNCDBMGE HILLMDJLLHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7240A00", Offset = "0x723F400", VA = "0x187240A00", Slot = "4")]
	[AsyncStateMachine(typeof(KDCDCHDKIHK))]
	public Task<bool> BNFCKIGOLIK(CancellationToken LOIOCMLGMKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal interface BHEMBNBIBKG
{
	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> BNFCKIGOLIK(CancellationToken LOIOCMLGMKH);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal struct DAJIAELBDLI
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class JNNDBENHODL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public FGAGHPALDNJ manager;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public JNNDBENHODL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7246E40", Offset = "0x7245840", VA = "0x187246E40")]
		internal Task ENKLIIMEENH(CancellationToken cancellationToken, int roomTotalVersion, LNBDJMHHJGO localPlayerAccountRoleType)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct NIABODOAGHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public DAJIAELBDLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private BKKMLGPDFKC <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TaskAwaiter<IOMPOJPCGMJ> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TaskAwaiter<AKHLLPJOLIM> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7255950", Offset = "0x7254350", VA = "0x187255950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7255EE0", Offset = "0x72548E0", VA = "0x187255EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct DJEFOGCPJJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public DAJIAELBDLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x723F6A0", Offset = "0x723E0A0", VA = "0x18723F6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x723F9C0", Offset = "0x723E3C0", VA = "0x18723F9C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly CancellationToken LOIOCMLGMKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly FGAGHPALDNJ PEDEFMGDCEP;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	private MMHLBANLMND HHPJNKNGKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x723E810", Offset = "0x723D210", VA = "0x18723E810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private CIFFNCDBMGE FJMIEGHLOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x723ECA0", Offset = "0x723D6A0", VA = "0x18723ECA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private DPDIKCBEILH NNPDHOLGNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x723E860", Offset = "0x723D260", VA = "0x18723E860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private CDCOAANFAKN NMEHMCCKAAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x723E5B0", Offset = "0x723CFB0", VA = "0x18723E5B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x21430E0", Offset = "0x2141AE0", VA = "0x1821430E0")]
	public DAJIAELBDLI(CancellationToken LOIOCMLGMKH, FGAGHPALDNJ PEDEFMGDCEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x723E9F0", Offset = "0x723D3F0", VA = "0x18723E9F0")]
	public static KAMMFCOFEKA KPEMHHDGNPF(FGAGHPALDNJ PEDEFMGDCEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x723E8E0", Offset = "0x723D2E0", VA = "0x18723E8E0")]
	[AsyncStateMachine(typeof(NIABODOAGHA))]
	public Task<bool> KELODGGKPBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x723E600", Offset = "0x723D000", VA = "0x18723E600")]
	private bool AOEOMBNKPMP([Out] BKKMLGPDFKC HEOEEINJPBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x723EAA0", Offset = "0x723D4A0", VA = "0x18723EAA0")]
	[AsyncStateMachine(typeof(DJEFOGCPJJD))]
	private Task LPMFDEADGAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x723EB70", Offset = "0x723D570", VA = "0x18723EB70")]
	private Task<IOMPOJPCGMJ> OIKKMFNHJHG(BKKMLGPDFKC IFMPNDJGLHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal struct KHNJPFEAAJA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly KKPEPLMLPGP JDGKHMCHAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly Guid OOCNLFNKKML;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Task<(AKHLLPJOLIM, Task)> NHDCIKJNAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x724F0F0", Offset = "0x724DAF0", VA = "0x18724F0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x446DE00", Offset = "0x446C800", VA = "0x18446DE00")]
	public KHNJPFEAAJA(KKPEPLMLPGP JDGKHMCHAPK, Guid OOCNLFNKKML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x724EFD0", Offset = "0x724D9D0", VA = "0x18724EFD0")]
	public TaskAwaiter<(AKHLLPJOLIM, Task)> CCPNIIDMBMI()
	{
		return default(TaskAwaiter<(AKHLLPJOLIM, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x724F020", Offset = "0x724DA20", VA = "0x18724F020", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal struct ABHNBGJHBNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly TaskCompletionSource<(AKHLLPJOLIM, Task)> HHGHMNNAPED;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Task<(AKHLLPJOLIM, Task)> NHDCIKJNAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x723BC70", Offset = "0x723A670", VA = "0x18723BC70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x723BCB0", Offset = "0x723A6B0", VA = "0x18723BCB0")]
	public ABHNBGJHBNJ(TimeSpan BHOCMEPADDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x723BBD0", Offset = "0x723A5D0", VA = "0x18723BBD0")]
	public void IFFPKKKLJOO(Task NOMEBNIPKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x723BAF0", Offset = "0x723A4F0", VA = "0x18723BAF0")]
	public void BBLFOFPBKNH(AKHLLPJOLIM KIBLJLKIFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x723BB80", Offset = "0x723A580", VA = "0x18723BB80")]
	public void CPLDEOLDAAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x723BA60", Offset = "0x723A460", VA = "0x18723BA60")]
	internal void AJJAAEFFHKC(string BBDGOIMNDJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class IPMPMMIFGCJ
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class LMFNHOIHOBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public BEOIGDDMAEA subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public LMFNHOIHOBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x724F710", Offset = "0x724E110", VA = "0x18724F710")]
		internal bool MHHNBMFKFHF(OPLJDOIGEJC s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x72466B0", Offset = "0x72450B0", VA = "0x1872466B0")]
	public static IMNJOLLKFEM EMJKOLAJLFI(long EBBFOAPEDII, long OAOCFKDGHFI, string IJGMHBOCGFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7246970", Offset = "0x7245370", VA = "0x187246970")]
	public static IMNJOLLKFEM EMJKOLAJLFI(long EBBFOAPEDII, long OAOCFKDGHFI, LGAFJFEBDLI IPPFHGIBMOF, long NNPDAFALPBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7246A30", Offset = "0x7245430", VA = "0x187246A30")]
	public static IMNJOLLKFEM EMJKOLAJLFI(ANLPGLHMEBJ BPOOJLCNFDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7246740", Offset = "0x7245140", VA = "0x187246740")]
	public static IMNJOLLKFEM EMJKOLAJLFI(NBOIDPFPFBM DKMCECHMKKH, BEOIGDDMAEA OBNECPFBHGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7246BC0", Offset = "0x72455C0", VA = "0x187246BC0")]
	public static IMNJOLLKFEM KOJMFFACFOC(this IMNJOLLKFEM HDOCILHNNDE, NBOIDPFPFBM GJLJOJKAKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7246CB0", Offset = "0x72456B0", VA = "0x187246CB0")]
	public static IMNJOLLKFEM NEKAEGCEPOH(this IMNJOLLKFEM HDOCILHNNDE, BEOIGDDMAEA BCGDHHBHGMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[RecRoom.NoEngine.Common.Preserve]
internal class GMDGOAACHOC : JMDDJLEFKPO, IBKICHECLOP, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private struct MDILKBKKCBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public GMDGOAACHOC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private CJHBAICPELK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x72500C0", Offset = "0x724EAC0", VA = "0x1872500C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x7250750", Offset = "0x724F150", VA = "0x187250750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly FKBHKHOFIEC ECHAICIDLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private string EEEHJIIKJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Task MLPCEDGPDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private FGAGHPALDNJ NCAFNAHMGMF;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool KOFIMCIMBCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7242D60", Offset = "0x7241760", VA = "0x187242D60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public Task GAJIEFMCHEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x7242CD0", Offset = "0x72416D0", VA = "0x187242CD0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x8892C0", Offset = "0x887CC0", VA = "0x1808892C0", Slot = "7")]
	public void HINDDHMAHAN(FGAGHPALDNJ NCAFNAHMGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7242B70", Offset = "0x7241570", VA = "0x187242B70", Slot = "6")]
	public void BAAGCGMDLAG(Task DJIALEEMCOO, string KOJDGNAGPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7242D90", Offset = "0x7241790", VA = "0x187242D90")]
	[AsyncStateMachine(typeof(MDILKBKKCBC))]
	private Task GOOOPICCHLH(Task HNKEBDJKBHK, string KOJDGNAGPMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7242EB0", Offset = "0x72418B0", VA = "0x187242EB0")]
	public GMDGOAACHOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class EGCLIPOKEHL : MDOLEKCMIJG, IBKICHECLOP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool GMJFEOEABBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private MBGDHIJMIIB ODEANGKGABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private MMHLBANLMND NHPIKOHJFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private KMMINAKBMNC EILKMNJGOBA;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public MBGDHIJMIIB BEPNKKGPKNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x723FCE0", Offset = "0x723E6E0", VA = "0x18723FCE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7240000", Offset = "0x723EA00", VA = "0x187240000", Slot = "7")]
	public void HINDDHMAHAN(FGAGHPALDNJ NCAFNAHMGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x723FE50", Offset = "0x723E850", VA = "0x18723FE50", Slot = "5")]
	public void FPCBKDGLGGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x723FE10", Offset = "0x723E810", VA = "0x18723FE10", Slot = "6")]
	public void MEDPFHHKIME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x723FD50", Offset = "0x723E750", VA = "0x18723FD50")]
	private Task DPCECEGGMAO(KADNHJEMCEO DICHKFJDHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x723FE10", Offset = "0x723E810", VA = "0x18723FE10", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public EGCLIPOKEHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal class BCMDJCMICAH : KMMINAKBMNC
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private class FMKFKHLKPFL<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly OKLMGPLPKNE KGEAHMJPFHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly string COMNIKKFEEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly T FABNMHPKJIP;

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public T ADJCIFCGLHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x913F50", Offset = "0x912950", VA = "0x180913F50")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x913F60", Offset = "0x912960", VA = "0x180913F60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3E05570", Offset = "0x3E03F70", VA = "0x183E05570")]
		public FMKFKHLKPFL(OKLMGPLPKNE KGEAHMJPFHI, string COMNIKKFEEB, T FABNMHPKJIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3E053F0", Offset = "0x3E03DF0", VA = "0x183E053F0")]
		private void PFGHMKIIGCH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly OKLMGPLPKNE KGEAHMJPFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly FMKFKHLKPFL<TimeSpan> OEOIIKIOBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly FMKFKHLKPFL<TimeSpan> ICGNJPAABIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly FMKFKHLKPFL<TimeSpan> MAJNKHNMAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly FMKFKHLKPFL<TimeSpan> OJAALGOCNJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly FMKFKHLKPFL<bool> HPCPGNIFLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly FMKFKHLKPFL<bool> DBIGAFGOHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly FMKFKHLKPFL<bool> KKGHGHHPAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly FMKFKHLKPFL<int> GJJPKAJKDBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly FMKFKHLKPFL<bool> BKBADIGPHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly FMKFKHLKPFL<bool> MNPDBFIEMEB;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public TimeSpan JNNPJHILEIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x723D5D0", Offset = "0x723BFD0", VA = "0x18723D5D0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public TimeSpan OEHBBIFJNNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x723D550", Offset = "0x723BF50", VA = "0x18723D550", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public TimeSpan HFDJMALECMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x723D590", Offset = "0x723BF90", VA = "0x18723D590", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public TimeSpan BBMDEFNDMBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x723D650", Offset = "0x723C050", VA = "0x18723D650", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool NPJDBMMHICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x723D710", Offset = "0x723C110", VA = "0x18723D710", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool KMEKIIHDPBO
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x723D4D0", Offset = "0x723BED0", VA = "0x18723D4D0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool BKBBNDNGPKK
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x723D610", Offset = "0x723C010", VA = "0x18723D610", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public int LJAMEJIMFFE
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x723D6D0", Offset = "0x723C0D0", VA = "0x18723D6D0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool PHEDFEHMIAK
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x723D690", Offset = "0x723C090", VA = "0x18723D690", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool KFPBEIEMAGH
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x723D510", Offset = "0x723BF10", VA = "0x18723D510", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x723D750", Offset = "0x723C150", VA = "0x18723D750")]
	[UnityEngine.Scripting.Preserve]
	public BCMDJCMICAH([LKKACOOMNBP(null)] OKLMGPLPKNE KGEAHMJPFHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[UnityEngine.Scripting.Preserve]
internal class IDGCBEDCIAA : CHEFPFPNLAH, IBKICHECLOP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class HBHPLABIBBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public LBGEPNPLEJA roomEvent;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public HBHPLABIBBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x7243980", Offset = "0x7242380", VA = "0x187243980")]
		internal object HNIJJAHFFDK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action AFOJNLGEBIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x7245510", Offset = "0x7243F10", VA = "0x187245510", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x7244F40", Offset = "0x7243940", VA = "0x187244F40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event KABIPJMJCMA IGGAFOLMODO
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x7244EA0", Offset = "0x72438A0", VA = "0x187244EA0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x7245470", Offset = "0x7243E70", VA = "0x187245470", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event KABIPJMJCMA GBOCHEODLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7245730", Offset = "0x7244130", VA = "0x187245730", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7245850", Offset = "0x7244250", VA = "0x187245850", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event KABIPJMJCMA FJKGLNIPELD
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x72455B0", Offset = "0x7243FB0", VA = "0x1872455B0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x72458F0", Offset = "0x72442F0", VA = "0x1872458F0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<AAMHGEMHMAI, bool> EJMPOEDFGCM
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x72451D0", Offset = "0x7243BD0", VA = "0x1872451D0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x7245680", Offset = "0x7244080", VA = "0x187245680", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "19")]
	public void HINDDHMAHAN(FGAGHPALDNJ NCAFNAHMGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x7245280", Offset = "0x7243C80", VA = "0x187245280", Slot = "14")]
	public void FBPLOACBMJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x7245650", Offset = "0x7244050", VA = "0x187245650", Slot = "15")]
	public void JLOIMNJMJJA(LBGEPNPLEJA MPDIMGMLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x72457D0", Offset = "0x72441D0", VA = "0x1872457D0", Slot = "16")]
	public void NNCLGLLKMJK(LBGEPNPLEJA MPDIMGMLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x7244FE0", Offset = "0x72439E0", VA = "0x187244FE0", Slot = "17")]
	public void BGGLBCOLNBP(LBGEPNPLEJA MPDIMGMLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x7245800", Offset = "0x7244200", VA = "0x187245800", Slot = "18")]
	public void ODCDEKONLEF(AAMHGEMHMAI PILNALGGBDH, bool FAJBCEPOPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x7245010", Offset = "0x7243A10", VA = "0x187245010")]
	private void CPLCIOOIDJC(KABIPJMJCMA GNOOEAHLONB, LBGEPNPLEJA MPDIMGMLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public IDGCBEDCIAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[UnityEngine.Scripting.Preserve]
internal class IHOPABBKIOJ : JGIFLLCDELO, IBKICHECLOP, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct GFNAKPANBGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public IHOPABBKIOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private CJHBAICPELK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7241700", Offset = "0x7240100", VA = "0x187241700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x7241BF0", Offset = "0x72405F0", VA = "0x187241BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct OHKIJGIFBAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public IHOPABBKIOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private CJHBAICPELK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x7258090", Offset = "0x7256A90", VA = "0x187258090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7258730", Offset = "0x7257130", VA = "0x187258730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class PFJODPPFCMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public PFJODPPFCMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x7258A10", Offset = "0x7257410", VA = "0x187258A10")]
		internal object JOPPPGDHCIN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct NOPEJGGDBHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public IHOPABBKIOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private PFJODPPFCMI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private CJHBAICPELK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7257650", Offset = "0x7256050", VA = "0x187257650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7257DA0", Offset = "0x72567A0", VA = "0x187257DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class AIEPJBHDNAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public AIEPJBHDNAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x723C5B0", Offset = "0x723AFB0", VA = "0x18723C5B0")]
		internal object OPCJJFNHKFI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly CAFGMNLACIN FEMNEHJOJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private FGAGHPALDNJ NCAFNAHMGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private CIFFNCDBMGE HILLMDJLLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private BHEMBNBIBKG[] LNBIPFBPJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private CancellationTokenSource OJIENHCHFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private int MEIIJOGNGFO;

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x72462A0", Offset = "0x7244CA0", VA = "0x1872462A0", Slot = "6")]
	public void HINDDHMAHAN(FGAGHPALDNJ NCAFNAHMGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x72460E0", Offset = "0x7244AE0", VA = "0x1872460E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x7246320", Offset = "0x7244D20", VA = "0x187246320", Slot = "8")]
	public void MLLJDEONDHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x7246010", Offset = "0x7244A10", VA = "0x187246010", Slot = "5")]
	public void DCAPLDHJFNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x72460F0", Offset = "0x7244AF0", VA = "0x1872460F0", Slot = "4")]
	[AsyncStateMachine(typeof(GFNAKPANBGE))]
	public Task GDEFFEFLBFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x7245990", Offset = "0x7244390", VA = "0x187245990")]
	private void BBJPLIFADDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x7245DD0", Offset = "0x72447D0", VA = "0x187245DD0")]
	[AsyncStateMachine(typeof(OHKIJGIFBAI))]
	private Task BDHOGIHNKFD(CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x7245ED0", Offset = "0x72448D0", VA = "0x187245ED0")]
	[AsyncStateMachine(typeof(NOPEJGGDBHM))]
	private Task<bool> CDNPIHNGPCH(int ENMILGHAHOM, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x7246550", Offset = "0x7244F50", VA = "0x187246550")]
	private void OLIDOKFBKDA(int ENMILGHAHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x72461C0", Offset = "0x7244BC0", VA = "0x1872461C0")]
	private void GLPMENFADJC(int ENMILGHAHOM, bool FAJBCEPOPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x7245CA0", Offset = "0x72446A0", VA = "0x187245CA0")]
	private void BCPHMOCKKCD(int ENMILGHAHOM, Exception JCOJOLLOCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x7246420", Offset = "0x7244E20", VA = "0x187246420")]
	private void OHBODJHDLKP(CancellationToken LOIOCMLGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public IHOPABBKIOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[RecRoom.NoEngine.Common.Preserve]
internal class NEANMHABJGN : AICBHGIIPCC, IBKICHECLOP, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct HDBLJPHNNNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public FLFGKHCBJJD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public NEANMHABJGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public MLKICDEJOHA customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private CJHBAICPELK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x7243A60", Offset = "0x7242460", VA = "0x187243A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x72443C0", Offset = "0x7242DC0", VA = "0x1872443C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private struct KGCBOPFPAGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public NEANMHABJGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public FLFGKHCBJJD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public MLKICDEJOHA customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private GOLFJDFFGLD<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private CJHBAICPELK <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private MILPNFIFKAC <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private HFHHNJGAHIF <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x724E2D0", Offset = "0x724CCD0", VA = "0x18724E2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x724EF70", Offset = "0x724D970", VA = "0x18724EF70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class AAKJHANLOOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public Matchmaking.FDCDEKFCOJH result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public JLDHMGNBHBF errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public AAKJHANLOOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x723B9B0", Offset = "0x723A3B0", VA = "0x18723B9B0")]
		internal object LCOMELNGBAO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class PIEKJDEMHAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public Task<IMNJOLLKFEM> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public PIEKJDEMHAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
		internal Task<IMNJOLLKFEM> HKCCBAGMEJL(GOLFJDFFGLD<string>.EFMHMOBJFGI _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct JOJHFKKKOBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public NEANMHABJGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public FLFGKHCBJJD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public MLKICDEJOHA customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public MILPNFIFKAC joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private PIEKJDEMHAD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private COMLPPJJGPO <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private CJHBAICPELK <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private NELNHAFDEJH <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private Task<Matchmaking.HHEENMENMII> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private HALAPDMKKJO <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private int <i>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private TaskAwaiter<Matchmaking.HHEENMENMII> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private TaskAwaiter<IMNJOLLKFEM> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x7246E90", Offset = "0x7245890", VA = "0x187246E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x724C840", Offset = "0x724B240", VA = "0x18724C840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct MIKANLBKCJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public NEANMHABJGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private CJHBAICPELK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7250C60", Offset = "0x724F660", VA = "0x187250C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x72516D0", Offset = "0x72500D0", VA = "0x1872516D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct FHNKEIFPPLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public NEANMHABJGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private FNNNJBMCDDC <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7240B70", Offset = "0x723F570", VA = "0x187240B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7240FF0", Offset = "0x723F9F0", VA = "0x187240FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct ACNMIKMJHCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public AsyncTaskMethodBuilder<Matchmaking.HHEENMENMII> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public FLFGKHCBJJD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public NEANMHABJGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private TaskAwaiter<Matchmaking.HHEENMENMII> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x723BE30", Offset = "0x723A830", VA = "0x18723BE30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x723C340", Offset = "0x723AD40", VA = "0x18723C340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct LPJFBLGGCEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public Matchmaking.HHEENMENMII serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public NEANMHABJGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public MILPNFIFKAC joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private CJHBAICPELK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private TaskAwaiter<BLODAGLGBFN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x724F740", Offset = "0x724E140", VA = "0x18724F740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x724FE40", Offset = "0x724E840", VA = "0x18724FE40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class AHNJHIPIINO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public FLFGKHCBJJD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public AHNJHIPIINO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x723C4B0", Offset = "0x723AEB0", VA = "0x18723C4B0")]
		internal object OAGOHFHLLJN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x723C3B0", Offset = "0x723ADB0", VA = "0x18723C3B0")]
		internal string CPJGJFCOOOI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct GJEKBEDFGAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public FLFGKHCBJJD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public NEANMHABJGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private AHNJHIPIINO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private CJHBAICPELK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7241F40", Offset = "0x7240940", VA = "0x187241F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7242B10", Offset = "0x7241510", VA = "0x187242B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct PGOKJHHKICL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public NEANMHABJGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public MILPNFIFKAC joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public IMNJOLLKFEM initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public FLFGKHCBJJD targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public COMLPPJJGPO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7258A80", Offset = "0x7257480", VA = "0x187258A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7259390", Offset = "0x7257D90", VA = "0x187259390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct NJMMFDCOBFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public NEANMHABJGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private CJHBAICPELK <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private CancellationTokenSource <timeoutTcs>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private CancellationToken <timeoutToken>5__7;

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7255F50", Offset = "0x7254950", VA = "0x187255F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x72575F0", Offset = "0x7255FF0", VA = "0x1872575F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct CPPMPFGFMCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public LNBDJMHHJGO localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public NEANMHABJGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private CJHBAICPELK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private TaskAwaiter<AKHLLPJOLIM> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x723DDE0", Offset = "0x723C7E0", VA = "0x18723DDE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x723E550", Offset = "0x723CF50", VA = "0x18723E550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class BEAECJMMJFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public FLFGKHCBJJD targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public BEAECJMMJFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x723DBC0", Offset = "0x723C5C0", VA = "0x18723DBC0")]
		internal object PJDDBABNAFN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class GOKLCIDEOFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public GOKLCIDEOFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x7266CA0", Offset = "0x72656A0", VA = "0x187266CA0")]
		internal void KFPCODNDFCJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class OLJLDLAKANI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public FLFGKHCBJJD targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public OLJLDLAKANI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x7277E50", Offset = "0x7276850", VA = "0x187277E50")]
		internal object OEJJACHPKAF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class LBGANKALGMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public FLFGKHCBJJD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public LBGANKALGMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x726FEB0", Offset = "0x726E8B0", VA = "0x18726FEB0")]
		internal string BKNIAOJFIBG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly CAFGMNLACIN FEMNEHJOJBN;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly CAFGMNLACIN OAEGJJBAPBD;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly CAFGMNLACIN ACJBIAHDGHI;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly CAFGMNLACIN MGOEMCCLCPI;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly string MMFNOOIJPMJ;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static readonly string KDBMEPANMDP;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static readonly string CHDHEBIHDCP;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static readonly Guid IOIPNMJNBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private NBEBJDKLKGB DCGJPHFKPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private GKKFLCEIJBD JIHGKELGKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private MMHLBANLMND NHPIKOHJFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private FGAGHPALDNJ NCAFNAHMGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private CIFFNCDBMGE HILLMDJLLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private JGIFLLCDELO JEGGPKGLKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private JMDDJLEFKPO JLGHMOKLLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private CHEFPFPNLAH EOBABJGIHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private LMCJEKCBNKB OHLCPPFCGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private IBLNJEOJMIB EAEPHFCLJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private IDisposable PBKJNJBIMGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private FNAGFEIMDPL JBONBGBOHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly FKBHKHOFIEC KGMBOKNGIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private HALAPDMKKJO KBKICONPJKP;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public TaskStatus FPIIIEGLHKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8AB7F0", Offset = "0x8AA1F0", VA = "0x1808AB7F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xD09080", Offset = "0xD07A80", VA = "0x180D09080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	private DPDIKCBEILH NNPDHOLGNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7253F80", Offset = "0x7252980", VA = "0x187253F80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x7253650", Offset = "0x7252050", VA = "0x187253650", Slot = "6")]
	public void HINDDHMAHAN(FGAGHPALDNJ NCAFNAHMGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x7252460", Offset = "0x7250E60", VA = "0x187252460", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x7255320", Offset = "0x7253D20", VA = "0x187255320", Slot = "5")]
	[AsyncStateMachine(typeof(HDBLJPHNNNC))]
	public Task PJGILNINOEI(FLFGKHCBJJD GLKHPKFKHBP, MLKICDEJOHA JKHINNBAOLE, CancellationToken BENMLFLNPKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x7252D80", Offset = "0x7251780", VA = "0x187252D80")]
	[AsyncStateMachine(typeof(KGCBOPFPAGE))]
	private Task FBLAHIGCIKI(FLFGKHCBJJD GLKHPKFKHBP, MLKICDEJOHA JKHINNBAOLE, CancellationToken BENMLFLNPKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x7254A60", Offset = "0x7253460", VA = "0x187254A60")]
	private void MOOOHCIMILC(LMCJEKCBNKB OHLCPPFCGAC, FLFGKHCBJJD GLKHPKFKHBP, Exception JCOJOLLOCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x7252540", Offset = "0x7250F40", VA = "0x187252540")]
	private static void EJDHEJFKNEK(HFHHNJGAHIF GMGPBKGHLEJ, Exception JCOJOLLOCIG, [Optional] List<int> KJGGMBECNDN, int MEIIJOGNGFO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7251D80", Offset = "0x7250780", VA = "0x187251D80")]
	[AsyncStateMachine(typeof(JOJHFKKKOBB))]
	private Task BCKBJPGDLFO(GOLFJDFFGLD<string>.EFMHMOBJFGI MBHLFFACPEB, FLFGKHCBJJD GLKHPKFKHBP, MLKICDEJOHA JKHINNBAOLE, MILPNFIFKAC NECIKGDIJNJ, CancellationToken BENMLFLNPKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x7253980", Offset = "0x7252380", VA = "0x187253980")]
	private void HKCPHDDKHEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x7255000", Offset = "0x7253A00", VA = "0x187255000")]
	[AsyncStateMachine(typeof(MIKANLBKCJM))]
	private Task NJMGKFDGBOO(GOLFJDFFGLD<string>.EFMHMOBJFGI MBHLFFACPEB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x72530E0", Offset = "0x7251AE0", VA = "0x1872530E0")]
	private void HBECHFCIOOJ(FLFGKHCBJJD GLKHPKFKHBP, CancellationToken BENMLFLNPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7253FD0", Offset = "0x72529D0", VA = "0x187253FD0")]
	private void KECCEOGLEDP(FLFGKHCBJJD GLKHPKFKHBP, MILPNFIFKAC NECIKGDIJNJ, OperationCanceledException FAJJIHJAAFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x7254220", Offset = "0x7252C20", VA = "0x187254220")]
	private void KGJHACEOMHO(FLFGKHCBJJD GLKHPKFKHBP, MILPNFIFKAC NECIKGDIJNJ, Exception JCOJOLLOCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7252ED0", Offset = "0x72518D0", VA = "0x187252ED0")]
	private void GEPPPJHBAOO(FLFGKHCBJJD GLKHPKFKHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x7254720", Offset = "0x7253120", VA = "0x187254720")]
	private static LBGEPNPLEJA MCPEPCCLIKH(FLFGKHCBJJD GLKHPKFKHBP)
	{
		return default(LBGEPNPLEJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x7251CB0", Offset = "0x72506B0", VA = "0x187251CB0")]
	[AsyncStateMachine(typeof(FHNKEIFPPLN))]
	private Task ADEFADBJLGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x7253D20", Offset = "0x7252720", VA = "0x187253D20")]
	[AsyncStateMachine(typeof(ACNMIKMJHCB))]
	private Task<Matchmaking.HHEENMENMII> IGNPPGDPLKN(FLFGKHCBJJD GLKHPKFKHBP, GOLFJDFFGLD<string>.EFMHMOBJFGI MBHLFFACPEB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x7253C10", Offset = "0x7252610", VA = "0x187253C10")]
	private static BLODAGLGBFN IFBKGEFDGAH(Matchmaking.HHEENMENMII HJJFPPFAIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x7252310", Offset = "0x7250D10", VA = "0x187252310")]
	[AsyncStateMachine(typeof(LPJFBLGGCEA))]
	private Task DMOJDHFCBIF(Matchmaking.HHEENMENMII HJJFPPFAIIP, MILPNFIFKAC NECIKGDIJNJ, GOLFJDFFGLD<string>.EFMHMOBJFGI MBHLFFACPEB, CancellationToken IJOHDFFMBCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x7253AD0", Offset = "0x72524D0", VA = "0x187253AD0")]
	[AsyncStateMachine(typeof(GJEKBEDFGAL))]
	private Task IEDNLDCDGBC(FLFGKHCBJJD GLKHPKFKHBP, CancellationTokenSource GBEBLLKAIFL, Task KJOOLHKEBJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x72548F0", Offset = "0x72532F0", VA = "0x1872548F0")]
	[AsyncStateMachine(typeof(PGOKJHHKICL))]
	private Task MLKJIFMFAMK(IMNJOLLKFEM EEOCFOEALDO, COMLPPJJGPO KHANOOAMEIK, FLFGKHCBJJD ECMNAELPNJN, MILPNFIFKAC AIOAADIFAMN, GOLFJDFFGLD<string>.EFMHMOBJFGI MBHLFFACPEB, CancellationToken KBFJKADIBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x7255130", Offset = "0x7253B30", VA = "0x187255130")]
	private MILPNFIFKAC OKEABIOECMA(MILPNFIFKAC AIOAADIFAMN, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x72520F0", Offset = "0x7250AF0", VA = "0x1872520F0")]
	[AsyncStateMachine(typeof(NJMMFDCOBFE))]
	private Task DBBPJNDDOPJ(GOLFJDFFGLD<string>.EFMHMOBJFGI MBHLFFACPEB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x7254ED0", Offset = "0x72538D0", VA = "0x187254ED0")]
	[AsyncStateMachine(typeof(CPPMPFGFMCH))]
	private Task NBLNKHBLBEO(CancellationToken LOIOCMLGMKH, int HOCGJECDFPB, LNBDJMHHJGO ELPFAHNNEBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x7251F70", Offset = "0x7250970", VA = "0x187251F70")]
	private static void CHPNKONKEKL(FLFGKHCBJJD GLKHPKFKHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x72544D0", Offset = "0x7252ED0", VA = "0x1872544D0")]
	private void LNBOHFMMBLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x72535C0", Offset = "0x7251FC0", VA = "0x1872535C0")]
	private void HIBMIIGBFBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x72524B0", Offset = "0x7250EB0", VA = "0x1872524B0")]
	private void EJBKJANLDPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x7251EE0", Offset = "0x72508E0", VA = "0x187251EE0")]
	private void BPMDHDIFFIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x7252220", Offset = "0x7250C20", VA = "0x187252220")]
	private static void DMMPDIMADKM(FLFGKHCBJJD GLKHPKFKHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x7254780", Offset = "0x7253180", VA = "0x187254780")]
	private static CancellationTokenRegistration MEKFEKFFEKP(FLFGKHCBJJD GLKHPKFKHBP, CancellationToken IJOHDFFMBCF)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x7253E80", Offset = "0x7252880", VA = "0x187253E80")]
	private static void JMIALNDDCBI(FLFGKHCBJJD GLKHPKFKHBP, Exception JCOJOLLOCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x7253410", Offset = "0x7251E10", VA = "0x187253410")]
	private void HGKJFDOMGBK(FLFGKHCBJJD GLKHPKFKHBP, Task KJOOLHKEBJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x7254470", Offset = "0x7252E70", VA = "0x187254470")]
	private static void LHPAJEFICIG(Func<string> MKCFHDDLJBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x7255660", Offset = "0x7254060", VA = "0x187255660")]
	public NEANMHABJGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x7254890", Offset = "0x7253290", VA = "0x187254890")]
	[CompilerGenerated]
	internal static (int, int?) MFOOOJPFAMB(JLDHMGNBHBF GHILOAGNIAE)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[RecRoom.NoEngine.Common.Preserve]
internal class ODDDOJNCILB : AGBNPJFBPJE, IBKICHECLOP, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct BNBFCJBFBNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public ODDDOJNCILB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public LNBDJMHHJGO localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x725C450", Offset = "0x725AE50", VA = "0x18725C450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x725C8B0", Offset = "0x725B2B0", VA = "0x18725C8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class KFGGFKNNNMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public ODDDOJNCILB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public LNBDJMHHJGO localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public KFGGFKNNNMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x726F9C0", Offset = "0x726E3C0", VA = "0x18726F9C0")]
		internal List<Task> KECIHOFIIAO(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct NHBOFMILHGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public KAMMFCOFEKA taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public LNBDJMHHJGO localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private CJHBAICPELK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7275560", Offset = "0x7273F60", VA = "0x187275560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7275900", Offset = "0x7274300", VA = "0x187275900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private struct HDOGFNPBKAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public ODDDOJNCILB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7266D40", Offset = "0x7265740", VA = "0x187266D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7267020", Offset = "0x7265A20", VA = "0x187267020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private readonly HashSet<KAMMFCOFEKA> PKPBCEBPDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private GKKFLCEIJBD JIHGKELGKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private FGAGHPALDNJ NCAFNAHMGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private NKCJHNHKDGB PCANMAGOMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private LGCMBGEMKDC EGFFOACGEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private IDisposable PBKJNJBIMGI;

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x7277660", Offset = "0x7276060", VA = "0x187277660", Slot = "5")]
	public void HINDDHMAHAN(FGAGHPALDNJ NCAFNAHMGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x72775E0", Offset = "0x7275FE0", VA = "0x1872775E0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x7277A30", Offset = "0x7276430", VA = "0x187277A30", Slot = "4")]
	public bool LFMEDBPMOOE(KAMMFCOFEKA FBLPLFLECFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x7277420", Offset = "0x7275E20", VA = "0x187277420")]
	private void CONJLKAKHAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x7277B40", Offset = "0x7276540", VA = "0x187277B40")]
	private void PCHKAJDMPCH(OOGIBKAOAMC HCKNFILJEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x72774F0", Offset = "0x7275EF0", VA = "0x1872774F0")]
	[AsyncStateMachine(typeof(BNBFCJBFBNK))]
	private Task DHBOOPBMCED(int HOCGJECDFPB, LNBDJMHHJGO ELPFAHNNEBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x7277960", Offset = "0x7276360", VA = "0x187277960")]
	private Func<CancellationToken, List<Task>> KBGPMCNCAKM(int HOCGJECDFPB, LNBDJMHHJGO ELPFAHNNEBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x7276E30", Offset = "0x7275830", VA = "0x187276E30")]
	private List<Task> BKOJACAMAME(int HOCGJECDFPB, LNBDJMHHJGO ELPFAHNNEBO, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x7277300", Offset = "0x7275D00", VA = "0x187277300")]
	[AsyncStateMachine(typeof(NHBOFMILHGO))]
	private Task CEHPGNNCPCN(KAMMFCOFEKA PELOHCJGJCF, CancellationToken OEELDHBFFAF, int HOCGJECDFPB, LNBDJMHHJGO ELPFAHNNEBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x7276D60", Offset = "0x7275760", VA = "0x187276D60")]
	[AsyncStateMachine(typeof(HDOGFNPBKAB))]
	private Task AKOKEKIPFIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x7277A90", Offset = "0x7276490", VA = "0x187277A90")]
	private void MLLJDEONDHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x7277D60", Offset = "0x7276760", VA = "0x187277D60")]
	public ODDDOJNCILB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[UnityEngine.Scripting.Preserve]
internal sealed class GAKICKDEAME : KKPEPLMLPGP, IBKICHECLOP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class FCCKNOGEHDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public FCCKNOGEHDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x72623E0", Offset = "0x7260DE0", VA = "0x1872623E0")]
		internal object BLEIOFECNMJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class PBMKIJFMNFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public PBMKIJFMNFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x72784E0", Offset = "0x7276EE0", VA = "0x1872784E0")]
		internal object MCAAFLKEFPN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class HJDNLLJDBPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public HJDNLLJDBPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class LIMFDDPJIFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public LIMFDDPJIFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x7270420", Offset = "0x726EE20", VA = "0x187270420")]
		internal object DGOCBAIHNBN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class DKPBIGKNKDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public DKPBIGKNKDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x725FF30", Offset = "0x725E930", VA = "0x18725FF30")]
		internal object KNEDGPKCLEH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private readonly Dictionary<Guid, ABHNBGJHBNJ> JDGKHMCHAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private readonly TimeSpan GICLEMJOJNA;

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "9")]
	public void HINDDHMAHAN(FGAGHPALDNJ NCAFNAHMGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x7263940", Offset = "0x7262340", VA = "0x187263940", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x72642A0", Offset = "0x7262CA0", VA = "0x1872642A0", Slot = "4")]
	public KHNJPFEAAJA KDCHLCHLBCK(Guid OOCNLFNKKML)
	{
		return default(KHNJPFEAAJA);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x7263950", Offset = "0x7262350", VA = "0x187263950", Slot = "5")]
	public bool GDFNAHCIADO(Guid OOCNLFNKKML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x7263F70", Offset = "0x7262970", VA = "0x187263F70", Slot = "6")]
	public bool INJHINDIHGJ(Guid OOCNLFNKKML, Task NOMEBNIPKKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x7263B60", Offset = "0x7262560", VA = "0x187263B60", Slot = "7")]
	public bool HHJPJGGIAJE(Guid OOCNLFNKKML, AKHLLPJOLIM KIBLJLKIFJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x72644C0", Offset = "0x7262EC0", VA = "0x1872644C0", Slot = "8")]
	public Task<(AKHLLPJOLIM, Task)> NEOHJLAFGAH(Guid OOCNLFNKKML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x7263D40", Offset = "0x7262740", VA = "0x187263D40")]
	private void IKKAOEICCJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x7264530", Offset = "0x7262F30", VA = "0x187264530")]
	public GAKICKDEAME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[RecRoom.NoEngine.Common.Preserve]
internal class HGBNKEOAMOF : ENGAAKMEHHE, IBKICHECLOP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private class DPHEOJCAOHG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private readonly FLFGKHCBJJD CPHHMAHEGMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private readonly CancellationTokenSource OJIENHCHFHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public readonly CancellationToken MFLEEFFMMGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private bool EKOANIKHFLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private bool PJFKAIJIJGP;

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x72622D0", Offset = "0x7260CD0", VA = "0x1872622D0")]
		public DPHEOJCAOHG(FLFGKHCBJJD CPHHMAHEGMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7262180", Offset = "0x7260B80", VA = "0x187262180")]
		public void MLLJDEONDHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x7262150", Offset = "0x7260B50", VA = "0x187262150", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class DHBBKEINCKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public KADNHJEMCEO disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public DHBBKEINCKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x725FEA0", Offset = "0x725E8A0", VA = "0x18725FEA0")]
		internal object NFMMFEIPCCG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct AGFBPJJJJAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public KADNHJEMCEO disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public HGBNKEOAMOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private CJHBAICPELK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x725A380", Offset = "0x7258D80", VA = "0x18725A380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x725A780", Offset = "0x7259180", VA = "0x18725A780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class KIGMABOLJIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public KIGMABOLJIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x726FD80", Offset = "0x726E780", VA = "0x18726FD80")]
		internal object LADKMIFEFGA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private struct IKCADFOGLGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public HGBNKEOAMOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private CJHBAICPELK <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x726AD90", Offset = "0x7269790", VA = "0x18726AD90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8D8CD0", Offset = "0x8D76D0", VA = "0x1808D8CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class BEHPMJMEAKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public FLFGKHCBJJD newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public BEHPMJMEAKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x725BF00", Offset = "0x725A900", VA = "0x18725BF00")]
		internal object CDNKHOJHCMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x725BFE0", Offset = "0x725A9E0", VA = "0x18725BFE0")]
		internal object ODCDHBKHPHJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x725BFA0", Offset = "0x725A9A0", VA = "0x18725BFA0")]
		internal object NPCENFGDEGN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class MJKNCPOLPCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public MJKNCPOLPCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x72720F0", Offset = "0x7270AF0", VA = "0x1872720F0")]
		internal void BGFLHGCOLOA()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct CEPCDCGGPOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public FLFGKHCBJJD newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public HGBNKEOAMOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public MLKICDEJOHA customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private BEHPMJMEAKO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private CJHBAICPELK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private CancellationTokenRegistration <_>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x725D4E0", Offset = "0x725BEE0", VA = "0x18725D4E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x725E470", Offset = "0x725CE70", VA = "0x18725E470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly CAFGMNLACIN FEMNEHJOJBN;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly BOBFAHJBLPF.FBIHOICDEHG LHBDNECAHMJ;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly LLFNHNCNGDD NIGLOBGCHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private GKKFLCEIJBD JIHGKELGKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private FGAGHPALDNJ NCAFNAHMGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private JGIFLLCDELO JEGGPKGLKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private CIFFNCDBMGE HILLMDJLLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private KMMINAKBMNC EILKMNJGOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private AICBHGIIPCC ACLDJPPMMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private FLFGKHCBJJD IOJCANJCCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private DPHEOJCAOHG FBMCMNAKGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private bool FEKKJCJNJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private Task BLGOIJALANO;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private DPDIKCBEILH NNPDHOLGNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x72679A0", Offset = "0x72663A0", VA = "0x1872679A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool GHHMBJHAOEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x98B5F0", Offset = "0x989FF0", VA = "0x18098B5F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x72674B0", Offset = "0x7265EB0", VA = "0x1872674B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x72674C0", Offset = "0x7265EC0", VA = "0x1872674C0", Slot = "4")]
	public void HINDDHMAHAN(FGAGHPALDNJ NCAFNAHMGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7267080", Offset = "0x7265A80", VA = "0x187267080", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x72679F0", Offset = "0x72663F0", VA = "0x1872679F0")]
	[AsyncStateMachine(typeof(AGFBPJJJJAH))]
	private Task KEOAHAECGAL(KADNHJEMCEO IPDGMNCIOGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x7267AE0", Offset = "0x72664E0", VA = "0x187267AE0")]
	private void LJHBIAHLILA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x72671F0", Offset = "0x7265BF0", VA = "0x1872671F0")]
	private void EOGLHFEOEIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x7267EF0", Offset = "0x72668F0", VA = "0x187267EF0")]
	private void NDANHFDDAGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x7268070", Offset = "0x7266A70", VA = "0x187268070")]
	private bool PIPKLEIBIPF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x7267760", Offset = "0x7266160", VA = "0x187267760")]
	[AsyncStateMachine(typeof(IKCADFOGLGF))]
	private void IDDOIDHHGMI(int ILBCHIFAEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x7267C70", Offset = "0x7266670", VA = "0x187267C70")]
	private void MKEACECKHMB([Out] IDisposable FOCAPINNLHP, [Out] IDisposable JLILNJBBEGL, [Out] IDisposable FHMCFGCLFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x7267880", Offset = "0x7266280", VA = "0x187267880")]
	private bool IPJDEHOODEM(FLFGKHCBJJD CPHHMAHEGMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7267830", Offset = "0x7266230", VA = "0x187267830")]
	private void IJDOOAPJBCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7267380", Offset = "0x7265D80", VA = "0x187267380")]
	[AsyncStateMachine(typeof(CEPCDCGGPOB))]
	private Task FBLAHIGCIKI(FLFGKHCBJJD CPHHMAHEGMA, MLKICDEJOHA JKHINNBAOLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x7268480", Offset = "0x7266E80", VA = "0x187268480")]
	public HGBNKEOAMOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[UnityEngine.Scripting.Preserve]
internal sealed class DDOGCBMEFEN : FGGCPEEBABA, IBKICHECLOP, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private struct INJOHIICFEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public AsyncTaskMethodBuilder<IBPIJMAGBAA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public DDOGCBMEFEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private TaskAwaiter<IBPIJMAGBAA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x726BF70", Offset = "0x726A970", VA = "0x18726BF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x726C200", Offset = "0x726AC00", VA = "0x18726C200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class KOALEAFCNFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public CELGPAAAIIN message;

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public KOALEAFCNFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x726FE50", Offset = "0x726E850", VA = "0x18726FE50")]
		internal object HFOPPGCNHKP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class ONADLOMPPOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public CELGPAAAIIN messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public ONADLOMPPOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x7277ED0", Offset = "0x72768D0", VA = "0x187277ED0")]
		internal object PJBBGHBBKOL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class LGGEKHKIEGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public CELGPAAAIIN request;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public LGGEKHKIEGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x72703C0", Offset = "0x726EDC0", VA = "0x1872703C0")]
		internal object LADACDMLCIB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct MFKFMMCOJNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public CELGPAAAIIN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public DDOGCBMEFEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private CJHBAICPELK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private TaskAwaiter<IGIEMLKHNDA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x72717C0", Offset = "0x72701C0", VA = "0x1872717C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x7272090", Offset = "0x7270A90", VA = "0x187272090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class IHLOPEHDDBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public CELGPAAAIIN operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public IHLOPEHDDBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x726AB90", Offset = "0x7269590", VA = "0x18726AB90")]
		internal object EMGCOGEPEJM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct BNLABJDDAOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public CELGPAAAIIN operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public DDOGCBMEFEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private CJHBAICPELK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private MILPNFIFKAC <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private TaskAwaiter<CELGPAAAIIN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x725C910", Offset = "0x725B310", VA = "0x18725C910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x725D480", Offset = "0x725BE80", VA = "0x18725D480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private struct MELOLMCDLIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public AsyncTaskMethodBuilder<IGIEMLKHNDA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public DDOGCBMEFEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public CELGPAAAIIN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private DNHKFDPGGBB.FEOIHEGOFGK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private MILPNFIFKAC <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private TaskAwaiter<CELGPAAAIIN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x7271220", Offset = "0x726FC20", VA = "0x187271220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x7271750", Offset = "0x7270150", VA = "0x187271750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class NIELBGPBNKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public IGIEMLKHNDA operation;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public NIELBGPBNKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x7276100", Offset = "0x7274B00", VA = "0x187276100")]
		internal object ELFFPCEBIPD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private struct APGOJJAGEMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public IGIEMLKHNDA operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public DDOGCBMEFEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private CJHBAICPELK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private GOLFJDFFGLD<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x725A850", Offset = "0x7259250", VA = "0x18725A850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x725AE80", Offset = "0x7259880", VA = "0x18725AE80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class EBJMMCFFOFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public CELGPAAAIIN request;

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public EBJMMCFFOFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x7262380", Offset = "0x7260D80", VA = "0x187262380")]
		internal object BHGJLHLJPCN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	private sealed class KAFKOHGABGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public CELGPAAAIIN request;

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public KAFKOHGABGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x726F610", Offset = "0x726E010", VA = "0x18726F610")]
		internal object DIDPCMLLJJF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private FGAGHPALDNJ NCAFNAHMGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private JMDDJLEFKPO JLGHMOKLLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private CGAIKGLOANH EIMGFBCBFMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private KMKMNKDOIAM MACEODBCNIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private MMHLBANLMND NHPIKOHJFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private TaskCompletionSource<IBPIJMAGBAA> GFEIOMGPPHE;

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x725F430", Offset = "0x725DE30", VA = "0x18725F430", Slot = "7")]
	public void HINDDHMAHAN(FGAGHPALDNJ NCAFNAHMGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x725EAF0", Offset = "0x725D4F0", VA = "0x18725EAF0", Slot = "6")]
	[AsyncStateMachine(typeof(INJOHIICFEN))]
	public Task<IBPIJMAGBAA> ABGOJLIKHFP(CancellationToken FBCMDPADHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x725F520", Offset = "0x725DF20", VA = "0x18725F520", Slot = "4")]
	public void JDMEPHAPAGH(CELGPAAAIIN BBDGOIMNDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x725EEA0", Offset = "0x725D8A0", VA = "0x18725EEA0", Slot = "5")]
	public void ELINJJBHMIA(CELGPAAAIIN OMPMOKNILPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x725F200", Offset = "0x725DC00", VA = "0x18725F200")]
	[AsyncStateMachine(typeof(MFKFMMCOJNJ))]
	private Task FMPJIMFMKHF(CELGPAAAIIN MGBHCKLJEHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x725F8B0", Offset = "0x725E2B0", VA = "0x18725F8B0")]
	[AsyncStateMachine(typeof(BNLABJDDAOH))]
	private Task LEMKHJBGACJ(CELGPAAAIIN ELPDPIKODIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x725FD50", Offset = "0x725E750", VA = "0x18725FD50")]
	[AsyncStateMachine(typeof(MELOLMCDLIL))]
	private Task<IGIEMLKHNDA> OHDNLEFHOCE(CELGPAAAIIN MGBHCKLJEHL, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x725EE10", Offset = "0x725D810", VA = "0x18725EE10")]
	private MILPNFIFKAC DBDLHGKFBPL(CELGPAAAIIN GHHJCAFPGMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x725F310", Offset = "0x725DD10", VA = "0x18725F310")]
	[AsyncStateMachine(typeof(APGOJJAGEMD))]
	private Task HGGEJFOJFLL(IGIEMLKHNDA OBCNEKMKFFE, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x725EC00", Offset = "0x725D600", VA = "0x18725EC00")]
	private IGIEMLKHNDA BDBBMPHKDPC(CELGPAAAIIN MGBHCKLJEHL, MILPNFIFKAC PDGPAJDMGIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x2B8CE20", Offset = "0x2B8B820", VA = "0x182B8CE20")]
	private T KJCNJIENKAJ<T>(T IPHMAHBENGI) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x725F9C0", Offset = "0x725E3C0", VA = "0x18725F9C0")]
	private IGIEMLKHNDA OAGDKCODPJG(CELGPAAAIIN MGBHCKLJEHL, MILPNFIFKAC PDGPAJDMGIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public DDOGCBMEFEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[UnityEngine.Scripting.Preserve]
internal sealed class DMGNNNLDDAL : CGAIKGLOANH, IBKICHECLOP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class GLNKLGNLJEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public GLNKLGNLJEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x72665B0", Offset = "0x7264FB0", VA = "0x1872665B0")]
		internal object EAPPLPJMLLC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class GIIINPCNGNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public GIIINPCNGNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x7265CD0", Offset = "0x72646D0", VA = "0x187265CD0")]
		internal object EANFHNBIGNH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private MMHLBANLMND NHPIKOHJFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private KJJMDHOPKCC DGHPCNCOEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private FGGCPEEBABA ELAHHDIOCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private KKPEPLMLPGP JDGKHMCHAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private NNAPFBHACLG JMGAGNOEDPF;

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x7260D90", Offset = "0x725F790", VA = "0x187260D90", Slot = "6")]
	public void HINDDHMAHAN(FGAGHPALDNJ NCAFNAHMGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x7260AB0", Offset = "0x725F4B0", VA = "0x187260AB0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x72618F0", Offset = "0x72602F0", VA = "0x1872618F0", Slot = "4")]
	public KHNJPFEAAJA OBBHJPJHLDA(CELGPAAAIIN OGOBLPBPLMI)
	{
		return default(KHNJPFEAAJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x72616E0", Offset = "0x72600E0", VA = "0x1872616E0", Slot = "5")]
	public void LEFFKLIHCME(Guid OOCNLFNKKML, Task NOMEBNIPKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x7260740", Offset = "0x725F140", VA = "0x187260740")]
	private void CICNMLBCHPA(byte JBJOJGKPEIN, int MMMJCJNILOD, object MACOJPABPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x7261170", Offset = "0x725FB70", VA = "0x187261170")]
	private void JNKJHJEEECD(KHANMAEBCIN BEAACGPFCBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x72601D0", Offset = "0x725EBD0", VA = "0x1872601D0")]
	private void AIJBAOFHHOA(KHANMAEBCIN BEAACGPFCBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x725FF90", Offset = "0x725E990", VA = "0x18725FF90")]
	private void AHMFCMJCGKD(KHANMAEBCIN BEAACGPFCBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x7260B60", Offset = "0x725F560", VA = "0x187260B60")]
	private AKHLLPJOLIM FIPJFABNLNE(CELGPAAAIIN GHHJCAFPGMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x7261D10", Offset = "0x7260710", VA = "0x187261D10")]
	private void OKHGIIICBAF(CELGPAAAIIN ELPDPIKODIL, AKHLLPJOLIM KIBLJLKIFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x7260810", Offset = "0x725F210", VA = "0x187260810")]
	private bool DPGGDBIIJHI(CELGPAAAIIN ELPDPIKODIL, AKHLLPJOLIM KIBLJLKIFJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x7260F00", Offset = "0x725F900", VA = "0x187260F00")]
	private bool JGDMONPBLFD(CELGPAAAIIN BDJJDEBIMLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x72604C0", Offset = "0x725EEC0", VA = "0x1872604C0")]
	private bool BJMKPFALJPH(byte JBJOJGKPEIN, ExitGames.Client.Photon.Hashtable BEAACGPFCBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public DMGNNNLDDAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[UnityEngine.Scripting.Preserve]
internal sealed class IEAFDEJJOIF : PMJOEOOAEEK, IBKICHECLOP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class IIGOBFPBEIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public IBPIJMAGBAA operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public IEAFDEJJOIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public CELGPAAAIIN roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public IIGOBFPBEIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x726AD20", Offset = "0x7269720", VA = "0x18726AD20")]
		internal object LGFAKMHKNOP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x726ABF0", Offset = "0x72695F0", VA = "0x18726ABF0")]
		internal object FKCNJJKGPAG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private struct GGGCADAMFPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public AsyncTaskMethodBuilder<AKHLLPJOLIM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public IEAFDEJJOIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public CELGPAAAIIN roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private CJHBAICPELK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private TaskAwaiter<AKHLLPJOLIM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x7265360", Offset = "0x7263D60", VA = "0x187265360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x7265A00", Offset = "0x7264400", VA = "0x187265A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class ANICGIMMKGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public IBPIJMAGBAA operationType;

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public ANICGIMMKGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x725A7E0", Offset = "0x72591E0", VA = "0x18725A7E0")]
		internal object OPJBFKDGGKA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class LBMEAHBPINE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public CELGPAAAIIN request;

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public LBMEAHBPINE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x7270090", Offset = "0x726EA90", VA = "0x187270090")]
		internal object FOAKODFHOLH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x726FFB0", Offset = "0x726E9B0", VA = "0x18726FFB0")]
		internal object ANDKKMFDLBG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x7270020", Offset = "0x726EA20", VA = "0x187270020")]
		internal object EOGMMMGLHEH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct BCDNIPKLOLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public AsyncTaskMethodBuilder<AKHLLPJOLIM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public CELGPAAAIIN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public IEAFDEJJOIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private LBMEAHBPINE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private CJHBAICPELK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private KHNJPFEAAJA <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private AKHLLPJOLIM <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private TaskAwaiter<(AKHLLPJOLIM validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x725AFA0", Offset = "0x72599A0", VA = "0x18725AFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x725B850", Offset = "0x725A250", VA = "0x18725B850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private MMHLBANLMND NHPIKOHJFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private KJJMDHOPKCC DGHPCNCOEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private CGAIKGLOANH EIMGFBCBFMK;

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x726A7B0", Offset = "0x72691B0", VA = "0x18726A7B0", Slot = "5")]
	public void HINDDHMAHAN(FGAGHPALDNJ NCAFNAHMGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x726A690", Offset = "0x7269090", VA = "0x18726A690", Slot = "4")]
	[AsyncStateMachine(typeof(GGGCADAMFPK))]
	private Task<AKHLLPJOLIM> HFAOKPJBIKB(CELGPAAAIIN GHHJCAFPGMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x726A860", Offset = "0x7269260", VA = "0x18726A860")]
	private bool KLDJBBHJDCJ(IBPIJMAGBAA PILNALGGBDH, [Out] AKHLLPJOLIM NLAECIHBKHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x726AA50", Offset = "0x7269450", VA = "0x18726AA50")]
	[AsyncStateMachine(typeof(BCDNIPKLOLE))]
	private Task<AKHLLPJOLIM> OACABCCONCO(CELGPAAAIIN MGBHCKLJEHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public IEAFDEJJOIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class GJFMFFHICIE : ENDPBOLMIGD, IBKICHECLOP, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct BEEKPMEPPOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public AsyncTaskMethodBuilder<IMNJOLLKFEM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public FLFGKHCBJJD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public GJFMFFHICIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private TaskAwaiter<NBOIDPFPFBM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private TaskAwaiter<IMNJOLLKFEM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x725B8C0", Offset = "0x725A2C0", VA = "0x18725B8C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x725BE90", Offset = "0x725A890", VA = "0x18725BE90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class HLLGPCCFHNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public HLLGPCCFHNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x7269570", Offset = "0x7267F70", VA = "0x187269570")]
		internal object JHHLCBJGMPI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private struct PLMMPINBBFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public AsyncTaskMethodBuilder<NBOIDPFPFBM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public GJFMFFHICIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public FLFGKHCBJJD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private HLLGPCCFHNA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private TaskAwaiter<NBOIDPFPFBM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x72790A0", Offset = "0x7277AA0", VA = "0x1872790A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x7279690", Offset = "0x7278090", VA = "0x187279690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct MCOCHCIPDHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public AsyncTaskMethodBuilder<IMNJOLLKFEM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public GJFMFFHICIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public FLFGKHCBJJD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public NBOIDPFPFBM roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private TaskAwaiter<(LGAFJFEBDLI superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x7270480", Offset = "0x726EE80", VA = "0x187270480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x72708E0", Offset = "0x726F2E0", VA = "0x1872708E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class FECOGBCKAAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public FECOGBCKAAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x937850", Offset = "0x936250", VA = "0x180937850")]
		internal bool JGGCAIALHML(OPLJDOIGEJC sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct NLDNEGHAMBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public AsyncTaskMethodBuilder<(LGAFJFEBDLI superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public NBOIDPFPFBM roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public GJFMFFHICIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public FLFGKHCBJJD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private TaskAwaiter<(LGAFJFEBDLI superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x7276180", Offset = "0x7274B80", VA = "0x187276180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x7276820", Offset = "0x7275220", VA = "0x187276820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class CKJABLEOPHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public CKJABLEOPHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x725EA40", Offset = "0x725D440", VA = "0x18725EA40")]
		internal object CGILJCFFPGH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct GFDMHMAJCPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public AsyncTaskMethodBuilder<(LGAFJFEBDLI superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public OPLJDOIGEJC subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public GJFMFFHICIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public FLFGKHCBJJD dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private CKJABLEOPHO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private TaskAwaiter<BEOIGDDMAEA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x72645F0", Offset = "0x7262FF0", VA = "0x1872645F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x7264D20", Offset = "0x7263720", VA = "0x187264D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static readonly (LGAFJFEBDLI superRoomData, long subRoomDataSaveId) GKNDKINHAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private CIFFNCDBMGE HILLMDJLLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private LNMBGKHEPPE HNBNFFEILKE;

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x72662E0", Offset = "0x7264CE0", VA = "0x1872662E0", Slot = "5")]
	public void HINDDHMAHAN(FGAGHPALDNJ NCAFNAHMGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x7265EB0", Offset = "0x72648B0", VA = "0x187265EB0", Slot = "4")]
	[AsyncStateMachine(typeof(BEEKPMEPPOM))]
	public Task<IMNJOLLKFEM> AKBOHGCKELK(GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, FLFGKHCBJJD GLKHPKFKHBP, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x7266010", Offset = "0x7264A10", VA = "0x187266010")]
	[AsyncStateMachine(typeof(PLMMPINBBFP))]
	private Task<NBOIDPFPFBM> DGIEACFAGPN(FLFGKHCBJJD GLKHPKFKHBP, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x7266170", Offset = "0x7264B70", VA = "0x187266170")]
	[AsyncStateMachine(typeof(MCOCHCIPDHN))]
	private Task<IMNJOLLKFEM> ENGMKJGPOLA(FLFGKHCBJJD GLKHPKFKHBP, NBOIDPFPFBM AHDMLEHPFLJ, long NMDIIDEMCDI, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x7266370", Offset = "0x7264D70", VA = "0x187266370")]
	[AsyncStateMachine(typeof(NLDNEGHAMBE))]
	private Task<(LGAFJFEBDLI, long)> JKHGMJLONMK(FLFGKHCBJJD GLKHPKFKHBP, NBOIDPFPFBM AHDMLEHPFLJ, long NMDIIDEMCDI, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x7265D40", Offset = "0x7264740", VA = "0x187265D40")]
	[AsyncStateMachine(typeof(GFDMHMAJCPJ))]
	private Task<(LGAFJFEBDLI, long)> AHAMLIFOJJC(FLFGKHCBJJD JMJOFPCDPAA, OPLJDOIGEJC BECKILCGADC, long NMDIIDEMCDI, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public GJFMFFHICIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[UnityEngine.Scripting.Preserve]
internal sealed class HGEAPIPHKNH : KMKMNKDOIAM, IBKICHECLOP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class PAFPBJFOBHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public CELGPAAAIIN request;

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public PAFPBJFOBHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x7278480", Offset = "0x7276E80", VA = "0x187278480")]
		internal object IMADIOMDJBH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct GMCLAHHACKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public AsyncTaskMethodBuilder<CELGPAAAIIN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public CELGPAAAIIN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public HGEAPIPHKNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public MILPNFIFKAC pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private CJHBAICPELK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private TaskAwaiter<CELGPAAAIIN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x7266620", Offset = "0x7265020", VA = "0x187266620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x7266C30", Offset = "0x7265630", VA = "0x187266C30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct PPHDPGFDMPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public AsyncTaskMethodBuilder<CELGPAAAIIN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public HGEAPIPHKNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public MILPNFIFKAC pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private CJHBAICPELK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private TaskAwaiter<OEAHFFNPLGM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x7279700", Offset = "0x7278100", VA = "0x187279700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x7279CF0", Offset = "0x72786F0", VA = "0x187279CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class KLGNBMHMFON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public CELGPAAAIIN request;

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public KLGNBMHMFON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x726FDF0", Offset = "0x726E7F0", VA = "0x18726FDF0")]
		internal object MPIEJIJJACA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct FIPEBHNLNKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public AsyncTaskMethodBuilder<CELGPAAAIIN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public CELGPAAAIIN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public HGEAPIPHKNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public MILPNFIFKAC pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private CJHBAICPELK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private BOHGADKHJKJ <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private FPFCGKOLBBM <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private TaskAwaiter<OEAHFFNPLGM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x72624C0", Offset = "0x7260EC0", VA = "0x1872624C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x72630B0", Offset = "0x7261AB0", VA = "0x1872630B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private MMHLBANLMND NHPIKOHJFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private MDOLEKCMIJG HCNDINEDMCL;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	private MBGDHIJMIIB BEPNKKGPKNA
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x72684F0", Offset = "0x7266EF0", VA = "0x1872684F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x7268CB0", Offset = "0x72676B0", VA = "0x187268CB0", Slot = "8")]
	public void HINDDHMAHAN(FGAGHPALDNJ NCAFNAHMGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x72685B0", Offset = "0x7266FB0", VA = "0x1872685B0", Slot = "4")]
	[AsyncStateMachine(typeof(GMCLAHHACKC))]
	public Task<CELGPAAAIIN> BFPGAACJLAH(CELGPAAAIIN MGBHCKLJEHL, MILPNFIFKAC PDGPAJDMGIC, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x7268D40", Offset = "0x7267740", VA = "0x187268D40", Slot = "5")]
	[AsyncStateMachine(typeof(PPHDPGFDMPA))]
	public Task<CELGPAAAIIN> OFPBHBOPFNB(CancellationToken LOIOCMLGMKH, MILPNFIFKAC PDGPAJDMGIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x7268AA0", Offset = "0x72674A0", VA = "0x187268AA0", Slot = "6")]
	public JHPBEIHBNBJ FIJDNBEPILK(IGIEMLKHNDA LNAJFNNDKKK, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x7268710", Offset = "0x7267110", VA = "0x187268710", Slot = "7")]
	public JHPBEIHBNBJ BGDCJHAEBOA(IGIEMLKHNDA LNAJFNNDKKK, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x7268940", Offset = "0x7267340", VA = "0x187268940")]
	[AsyncStateMachine(typeof(FIPEBHNLNKF))]
	private Task<CELGPAAAIIN> CGGGJAGFICC(CELGPAAAIIN MGBHCKLJEHL, MILPNFIFKAC PDGPAJDMGIC, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x2DBCF30", Offset = "0x2DBB930", VA = "0x182DBCF30")]
	private static byte[] NFAFBMABDLC(CELGPAAAIIN BBDGOIMNDJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public HGEAPIPHKNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[UnityEngine.Scripting.Preserve]
internal sealed class GAFHJPNEHJC : KJJMDHOPKCC, IBKICHECLOP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	private INLGAAHNKKO EFMONLFGACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	private MMHLBANLMND NHPIKOHJFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private JMDDJLEFKPO JLGHMOKLLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private BHHODHEHGIH DHFFPBHBGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private CIFFNCDBMGE HILLMDJLLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private AICBHGIIPCC ACLDJPPMMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private AGBNPJFBPJE JALADFJIJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private KMMINAKBMNC EILKMNJGOBA;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private DPDIKCBEILH NNPDHOLGNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x7263830", Offset = "0x7262230", VA = "0x187263830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	private static AKHLLPJOLIM MFBOAEBNHDE
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x72638E0", Offset = "0x72622E0", VA = "0x1872638E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x72636C0", Offset = "0x72620C0", VA = "0x1872636C0", Slot = "6")]
	public void HINDDHMAHAN(FGAGHPALDNJ NCAFNAHMGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x7263240", Offset = "0x7261C40", VA = "0x187263240", Slot = "4")]
	public AKHLLPJOLIM DHBOFAGMCGO(ICGGIJDMFMC NKFPHIOHJGB, IBPIJMAGBAA POBPINKCPGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x72633B0", Offset = "0x7261DB0", VA = "0x1872633B0", Slot = "5")]
	public AKHLLPJOLIM DLKDBCLDAPE(ICGGIJDMFMC JAJDIOMIOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x7263880", Offset = "0x7262280", VA = "0x187263880")]
	private static AKHLLPJOLIM LMMFJKIIDOL(CGOGNJKHKDK NOJDLJBPIDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public GAFHJPNEHJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public class PCIPGLCIIGM : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x7278680", Offset = "0x7277080", VA = "0x187278680")]
	public PCIPGLCIIGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x66DA900", Offset = "0x66D9300", VA = "0x1866DA900")]
	public PCIPGLCIIGM(string BBDGOIMNDJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[UnityEngine.Scripting.Preserve]
internal sealed class JDAONIDCIML : CDCOAANFAKN, IBKICHECLOP, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct MMIKBLGEKIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public AsyncTaskMethodBuilder<AKHLLPJOLIM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public JDAONIDCIML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public BKKMLGPDFKC autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private GOLFJDFFGLD<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private KJFJOEKAPNM <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private TaskAwaiter<AKHLLPJOLIM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x72738A0", Offset = "0x72722A0", VA = "0x1872738A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x7274420", Offset = "0x7272E20", VA = "0x187274420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct NHNAICKKGAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public JDAONIDCIML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x7275960", Offset = "0x7274360", VA = "0x187275960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x72760A0", Offset = "0x7274AA0", VA = "0x1872760A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct CIAGIMENFFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public JDAONIDCIML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x725E4D0", Offset = "0x725CED0", VA = "0x18725E4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x725E9E0", Offset = "0x725D3E0", VA = "0x18725E9E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct JDBGBNCJDON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public JDAONIDCIML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x726D9F0", Offset = "0x726C3F0", VA = "0x18726D9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x726E140", Offset = "0x726CB40", VA = "0x18726E140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct NEEDJHAMHDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public JDAONIDCIML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x7275360", Offset = "0x7273D60", VA = "0x187275360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x7275500", Offset = "0x7273F00", VA = "0x187275500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct IOHGCINJEBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public JDAONIDCIML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x726C270", Offset = "0x726AC70", VA = "0x18726C270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x726C980", Offset = "0x726B380", VA = "0x18726C980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct NLMKFFGOFGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public JDAONIDCIML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private Task <delayTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x7276890", Offset = "0x7275290", VA = "0x187276890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x7276D00", Offset = "0x7275700", VA = "0x187276D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private struct GFLOBOGBDEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public JDAONIDCIML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public IHMNJEAIAGN autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private GOLFJDFFGLD<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x7264D90", Offset = "0x7263790", VA = "0x187264D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x7265300", Offset = "0x7263D00", VA = "0x187265300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private MMHLBANLMND NHPIKOHJFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private FGAGHPALDNJ NCAFNAHMGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private CIFFNCDBMGE HILLMDJLLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private KMKMNKDOIAM MACEODBCNIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	private JMDDJLEFKPO JLGHMOKLLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private AGBNPJFBPJE JALADFJIJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	private CancellationTokenSource EOMINKPPCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private Task PKDMCGCGKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	private TaskCompletionSource<int> FGMJHNPNBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	private int KDGKGHCDJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private int JMGDMKOHIGA;

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x726CE70", Offset = "0x726B870", VA = "0x18726CE70", Slot = "6")]
	public void HINDDHMAHAN(FGAGHPALDNJ NCAFNAHMGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0xCC6E00", Offset = "0xCC5800", VA = "0x180CC6E00", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x726D720", Offset = "0x726C120", VA = "0x18726D720")]
	private void NFOOPEACFOK(float JHFNGJADBMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x726CD40", Offset = "0x726B740", VA = "0x18726CD40", Slot = "4")]
	[AsyncStateMachine(typeof(MMIKBLGEKIM))]
	public Task<AKHLLPJOLIM> HHPPLPAFMDH(BKKMLGPDFKC HEOEEINJPBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x726D130", Offset = "0x726BB30", VA = "0x18726D130", Slot = "5")]
	[AsyncStateMachine(typeof(NHNAICKKGAF))]
	public Task JDFANJABGNH([Optional] CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0xCC6E00", Offset = "0xCC5800", VA = "0x180CC6E00")]
	public void MMOHGDEHJNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x726C9E0", Offset = "0x726B3E0", VA = "0x18726C9E0")]
	private KJFJOEKAPNM DOIJNDJPMKM(BKKMLGPDFKC HEOEEINJPBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x726D900", Offset = "0x726C300", VA = "0x18726D900")]
	[AsyncStateMachine(typeof(CIAGIMENFFO))]
	private Task OHMICMOCFEB(CancellationToken BENMLFLNPKG, int HOCGJECDFPB, LNBDJMHHJGO ELPFAHNNEBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x726CB50", Offset = "0x726B550", VA = "0x18726CB50")]
	[AsyncStateMachine(typeof(JDBGBNCJDON))]
	private Task EEOEBHDNFHF(CancellationToken BENMLFLNPKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x726CC50", Offset = "0x726B650", VA = "0x18726CC50")]
	[AsyncStateMachine(typeof(NEEDJHAMHDF))]
	private Task FLGNKENGIMG([Optional] CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x726D220", Offset = "0x726BC20", VA = "0x18726D220")]
	[AsyncStateMachine(typeof(IOHGCINJEBL))]
	private Task KBJCICCJHGB(CancellationToken BENMLFLNPKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x726D800", Offset = "0x726C200", VA = "0x18726D800")]
	[AsyncStateMachine(typeof(NLMKFFGOFGB))]
	private Task NNLONLJOPCC(CancellationToken OKIHIMKAIKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x726D590", Offset = "0x726BF90", VA = "0x18726D590")]
	private Task LBEBGHBFACJ(IHMNJEAIAGN PHAIKKCIPMC, CancellationToken BENMLFLNPKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x726D020", Offset = "0x726BA20", VA = "0x18726D020")]
	[AsyncStateMachine(typeof(GFLOBOGBDEI))]
	private Task IMJCIMICEAP(IHMNJEAIAGN PHAIKKCIPMC, CancellationToken BENMLFLNPKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x726D310", Offset = "0x726BD10", VA = "0x18726D310")]
	private bool KPOMPGFNILP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public JDAONIDCIML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[UnityEngine.Scripting.Preserve]
internal class PJLJDLGFAJD : BHHODHEHGIH, IBKICHECLOP, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private struct HKMMHEGFNEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public PJLJDLGFAJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private GOLFJDFFGLD<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x7268FA0", Offset = "0x72679A0", VA = "0x187268FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x7269510", Offset = "0x7267F10", VA = "0x187269510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private HAMCOKMBKOP FKPPAPHNOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	private FGAGHPALDNJ NCAFNAHMGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private KJJMDHOPKCC DGHPCNCOEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	private KMKMNKDOIAM MACEODBCNIM;

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x7278D60", Offset = "0x7277760", VA = "0x187278D60", Slot = "6")]
	public void HINDDHMAHAN(FGAGHPALDNJ NCAFNAHMGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x7278B20", Offset = "0x7277520", VA = "0x187278B20", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x7278C60", Offset = "0x7277660", VA = "0x187278C60", Slot = "5")]
	[AsyncStateMachine(typeof(HKMMHEGFNEI))]
	public Task GBGNFEDLBOD(string KCEMGCAKHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x7279040", Offset = "0x7277A40", VA = "0x187279040", Slot = "4")]
	public AKHLLPJOLIM KPOMPGFNILP(ICGGIJDMFMC NKFPHIOHJGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x7278B70", Offset = "0x7277570", VA = "0x187278B70")]
	private MKGMCPIACGB FEAEMDMFOJE(string KCEMGCAKHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public PJLJDLGFAJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public static class MEDEGOGNOHG
{
	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x7270950", Offset = "0x726F350", VA = "0x187270950")]
	public static void FEFJMFOCOGM(FNNNJBMCDDC NKDOKEFKKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x72710C0", Offset = "0x726FAC0", VA = "0x1872710C0")]
	internal static void JCDNOCNPECG(FNNNJBMCDDC NKDOKEFKKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x7270B90", Offset = "0x726F590", VA = "0x187270B90")]
	internal static void GCJKJPHMOGK(FNNNJBMCDDC NKDOKEFKKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x7270C70", Offset = "0x726F670", VA = "0x187270C70")]
	internal static void IMAPGHNFGOJ(FNNNJBMCDDC NKDOKEFKKDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal class HNJLFNKJADL : AFNLDNMPLGA<CELGPAAAIIN>
{
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class KBFEFMLCEJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public CELGPAAAIIN message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public KBFEFMLCEJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x726F670", Offset = "0x726E070", VA = "0x18726F670")]
		internal object LECLMNHFKDB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly HNJLFNKJADL GHBFIIGNNDE;

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x7269620", Offset = "0x7268020", VA = "0x187269620")]
	public ExitGames.Client.Photon.Hashtable BBLOJHGNHMB(CELGPAAAIIN BBDGOIMNDJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x7269950", Offset = "0x7268350", VA = "0x187269950", Slot = "5")]
	protected override void LCOHEBEBCLL(CELGPAAAIIN BBDGOIMNDJI, IDictionary<object, object> LNCKNHNHHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x7269B90", Offset = "0x7268590", VA = "0x187269B90", Slot = "6")]
	public override CELGPAAAIIN MPIHBHFBPAP(IDictionary<object, object> LNCKNHNHHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x7269A80", Offset = "0x7268480", VA = "0x187269A80")]
	private static void LHPAJEFICIG(string AOABLNBOBDJ, CELGPAAAIIN BBDGOIMNDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x7269E50", Offset = "0x7268850", VA = "0x187269E50")]
	public HNJLFNKJADL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x72696B0", Offset = "0x72680B0", VA = "0x1872696B0")]
	[CompilerGenerated]
	internal static string FOCIHGGJIOH(IMNJOLLKFEM HDOCILHNNDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public static class PFMNMKDDIOA
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public static AKHLLPJOLIM MFBOAEBNHDE
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x72638E0", Offset = "0x72622E0", VA = "0x1872638E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x7278910", Offset = "0x7277310", VA = "0x187278910")]
	public static bool JFJIKAJJKKJ(this AKHLLPJOLIM KIBLJLKIFJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x7263880", Offset = "0x7262280", VA = "0x187263880")]
	public static AKHLLPJOLIM LMMFJKIIDOL(CGOGNJKHKDK JLNBNGDGFJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x7278930", Offset = "0x7277330", VA = "0x187278930")]
	public static AKHLLPJOLIM OKANFMCDKCF(IEnumerable<AKHLLPJOLIM> PDNMABBJKGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x72786C0", Offset = "0x72770C0", VA = "0x1872786C0")]
	public static string GGLIPABLDDK(this AKHLLPJOLIM NLAECIHBKHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public abstract class BEJGMKFODHN : COHPPPNIMFL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public delegate AKHLLPJOLIM CGELBCPAECL([NotNull] ICGGIJDMFMC AJKAAPEBLIO);

	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class OCJCNDLLJKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public ICGGIJDMFMC photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public OCJCNDLLJKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x68CE390", Offset = "0x68CCD90", VA = "0x1868CE390")]
		internal AKHLLPJOLIM OPDIKBFPFCJ(CGELBCPAECL v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private bool NMOEEADIFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	protected readonly HashSet<CGELBCPAECL> FHPDEKBKGKO;

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x725C020", Offset = "0x725AA20", VA = "0x18725C020", Slot = "4")]
	public void AHNEJPIGOPA(CGELBCPAECL GEPFENNDPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x725C0D0", Offset = "0x725AAD0", VA = "0x18725C0D0", Slot = "5")]
	public void JDAJDCNFGED(CGELBCPAECL GEPFENNDPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x725C080", Offset = "0x725AA80", VA = "0x18725C080", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x725C130", Offset = "0x725AB30", VA = "0x18725C130")]
	protected AKHLLPJOLIM NNLLAEOENCC(ICGGIJDMFMC JAJDIOMIOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x725C3C0", Offset = "0x725ADC0", VA = "0x18725C3C0")]
	protected BEJGMKFODHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class FJFFDECJHHH : BEJGMKFODHN, INLGAAHNKKO, COHPPPNIMFL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private sealed class MNFEPPJKMIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public AKHLLPJOLIM result;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public MNFEPPJKMIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x7274490", Offset = "0x7272E90", VA = "0x187274490")]
		internal object OJKEMGHHCCH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x7263230", Offset = "0x7261C30", VA = "0x187263230")]
	[UnityEngine.Scripting.Preserve]
	public FJFFDECJHHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x7263120", Offset = "0x7261B20", VA = "0x187263120", Slot = "8")]
	public AKHLLPJOLIM BKGPAJNHPKB(ICGGIJDMFMC JAJDIOMIOCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class HIPEOAFMHHG : BEJGMKFODHN, HAMCOKMBKOP, COHPPPNIMFL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private sealed class OGMAGNIPLCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public AKHLLPJOLIM result;

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public OGMAGNIPLCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x7277DF0", Offset = "0x72767F0", VA = "0x187277DF0")]
		internal object KKMMILCKNEL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x7263230", Offset = "0x7261C30", VA = "0x187263230")]
	[UnityEngine.Scripting.Preserve]
	public HIPEOAFMHHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x7268E90", Offset = "0x7267890", VA = "0x187268E90", Slot = "8")]
	public AKHLLPJOLIM KPOMPGFNILP(ICGGIJDMFMC JDGFBJBABBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal static class GHGBFDOLNLD
{
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private sealed class JICLHKOJLPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public GOLFJDFFGLD<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public JICLHKOJLPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x726F4B0", Offset = "0x726DEB0", VA = "0x18726F4B0")]
		internal object BNEPEKDADID()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x7265BF0", Offset = "0x72645F0", VA = "0x187265BF0")]
	public static GOLFJDFFGLD<string> MMNHBBIGLNM(CAFGMNLACIN FEMNEHJOJBN, [Optional] string LODNIHJAOOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x7265B30", Offset = "0x7264530", VA = "0x187265B30")]
	public static void ECNBCLGPGPC(GOLFJDFFGLD<string> MBHLFFACPEB, CAFGMNLACIN FEMNEHJOJBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x7265A70", Offset = "0x7264470", VA = "0x187265A70")]
	public static string CKMDHNLNKCM(CELGPAAAIIN GHHJCAFPGMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal static class PCCILIGDEJE
{
	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x7278540", Offset = "0x7276F40", VA = "0x187278540")]
	public static void IAIOGKOOIJN(this MMHLBANLMND NHPIKOHJFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x7278670", Offset = "0x7277070", VA = "0x187278670")]
	public static void LDNKHMKCIOG(this MMHLBANLMND NHPIKOHJFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x7278550", Offset = "0x7276F50", VA = "0x187278550")]
	private static void IDEPBBDAOFO(this MMHLBANLMND NHPIKOHJFBH, bool KAKGNAGCPAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public class OOENHGGPFAL : GKKBIJCBKII, GIMLDLHEIFP, ELGOJFFHPLJ, HMIMGJLKGHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	private readonly GIMLDLHEIFP DPNKNFIAODJ;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public ICGGIJDMFMC LJEDONCJDNE
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x72783E0", Offset = "0x7276DE0", VA = "0x1872783E0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public int KNCHNKDOPHB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x7278290", Offset = "0x7276C90", VA = "0x187278290", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public int CMDPLHAENEC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x7278430", Offset = "0x7276E30", VA = "0x187278430", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool PDOKLFBKPDK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public int CHEABCKBACK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x913B40", Offset = "0x912540", VA = "0x180913B40", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event FFALJMGJPAC.KOCEJJMKKPF PKHHOEEBFEE
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event MIOMBGDCKJP OHHDCNAGAHN
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x7278150", Offset = "0x7276B50", VA = "0x187278150", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x72780B0", Offset = "0x7276AB0", VA = "0x1872780B0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> DGGEKLKAKKD
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<ICGGIJDMFMC> JCIMDLCBPHB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action FJDLBEAEFAC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x72781F0", Offset = "0x7276BF0", VA = "0x1872781F0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x7278010", Offset = "0x7276A10", VA = "0x187278010", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0xC95100", Offset = "0xC93B00", VA = "0x180C95100")]
	public OOENHGGPFAL(GIMLDLHEIFP DPNKNFIAODJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x72782E0", Offset = "0x7276CE0", VA = "0x1872782E0", Slot = "8")]
	public bool LPLLOEAKPEB(byte JBJOJGKPEIN, ExitGames.Client.Photon.Hashtable OHMEBFLHEFC, EDDHLAOOLCG IEKMGPEKHHF, SendOptions ALBILFLBGAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x7277F30", Offset = "0x7276930", VA = "0x187277F30", Slot = "16")]
	public ICGGIJDMFMC ABAGBFBGGOO(int DIIHKAJKDLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "19")]
	public void MHANKMEEPMJ(object OEELDHBFFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "20")]
	public void DMGOJOPNKBA(object OEELDHBFFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "21")]
	public void JNKAAGAPADJ(object OEELDHBFFAF, bool CFEOBBJAIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x7278390", Offset = "0x7276D90", VA = "0x187278390", Slot = "22")]
	public IDisposable MDLIGIMMKPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "23")]
	private bool ICAILDEMFEN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "24")]
	public void IBNCEODHJNN(StringBuilder EGHDGLDJNDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x9FAD30", Offset = "0x9F9730", VA = "0x1809FAD30", Slot = "25")]
	public bool MOOLDAJNCIF(bool ACMDNKGELAL, [Out] string EJIIMGEBDBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x92A630", Offset = "0x929030", VA = "0x18092A630", Slot = "28")]
	public void GIJJDBOEDBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal struct KHANMAEBCIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	private readonly IDictionary<object, object> BEAACGPFCBO;

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0xB63000", Offset = "0xB61A00", VA = "0x180B63000")]
	public KHANMAEBCIN(IDictionary<object, object> BEAACGPFCBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x726FBA0", Offset = "0x726E5A0", VA = "0x18726FBA0")]
	public bool OKPCIBDCFNP([Out] CELGPAAAIIN BBDGOIMNDJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x726FA00", Offset = "0x726E400", VA = "0x18726FA00")]
	public Guid DLEIIKEHFBP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x726FC50", Offset = "0x726E650", VA = "0x18726FC50")]
	public AKHLLPJOLIM PAAMIIDECBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x726FAB0", Offset = "0x726E4B0", VA = "0x18726FAB0")]
	public static ExitGames.Client.Photon.Hashtable EMJKOLAJLFI(CELGPAAAIIN BBDGOIMNDJI, AKHLLPJOLIM KIBLJLKIFJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal static class FGGPEBFNKOI
{
	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x7262440", Offset = "0x7260E40", VA = "0x187262440")]
	public static bool IAOCJEFKBAO(this FLFGKHCBJJD GDEDPAAODIE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal struct LGCMBGEMKDC : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct DMIAMECOPFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public LGCMBGEMKDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x7261F10", Offset = "0x7260910", VA = "0x187261F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x72620F0", Offset = "0x7260AF0", VA = "0x1872620F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031B")]
	private readonly CancellationTokenSource OJIENHCHFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	private bool NMOEEADIFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	private Task DJIALEEMCOO;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool DDBKACNOMBL
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x7270260", Offset = "0x726EC60", VA = "0x187270260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x7270290", Offset = "0x726EC90", VA = "0x187270290")]
	public LGCMBGEMKDC(CancellationToken LOIOCMLGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x7270150", Offset = "0x726EB50", VA = "0x187270150")]
	[AsyncStateMachine(typeof(DMIAMECOPFD))]
	public Task FPPMCDAOLBI(Func<CancellationToken, List<Task>> PJGAOBPHIJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x7270100", Offset = "0x726EB00", VA = "0x187270100", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public readonly struct HIODHCPGACA<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct PADCAANMENA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<LDBHNJKNPKI<TData>, PKNKGFKCKHA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public HIODHCPGACA<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private TaskAwaiter<CDOLGFBAJII<LDBHNJKNPKI<TData>, PKNKGFKCKHA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x4996F70", Offset = "0x4995970", VA = "0x184996F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x3E09970", Offset = "0x3E08370", VA = "0x183E09970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	private readonly GOHOJKICAGG<TGetDataArg, TData> GBEKAPOEJCH;

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0xB63000", Offset = "0xB61A00", VA = "0x180B63000")]
	internal HIODHCPGACA(GOHOJKICAGG<TGetDataArg, TData> HBFCALFCDLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x3F9ABC0", Offset = "0x3F995C0", VA = "0x183F9ABC0")]
	[AsyncStateMachine(typeof(HIODHCPGACA<, >.PADCAANMENA))]
	public Task<CDOLGFBAJII<LDBHNJKNPKI<TData>, PKNKGFKCKHA>> KOOIJAFOKCM(TGetDataArg OKHFPGFAECB, string LAAKMABIMKK, GOLFJDFFGLD<string>.EFMHMOBJFGI MBHLFFACPEB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public static class KAAIMOLGMJH
{
	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x2AC91B0", Offset = "0x2AC7BB0", VA = "0x182AC91B0")]
	public static HIODHCPGACA<TGetDataArg, TData> OOAFHJGKFEK<TGetDataArg, TData>(GOHOJKICAGG<TGetDataArg, TData> HBFCALFCDLO)
	{
		return default(HIODHCPGACA<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public struct JLDHMGNBHBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public readonly int ALGGFBMICNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public readonly int? NPGCIKOMAOO;

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x4469790", Offset = "0x4468190", VA = "0x184469790")]
	public JLDHMGNBHBF(int NAANNFJNLEO, [Optional] int? FLHBMMAEECM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x726F530", Offset = "0x726DF30", VA = "0x18726F530", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public interface FCFHOGBMDAE<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GKHGJKOEKAH();

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FCFHOGBMDAE<T> GDNHBMJOCHP(string HJEKPEEDGCE);

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FCFHOGBMDAE<T> KMIPDFKJKOH(KHIEPGKDJID<T> JOEKBCLEKNK);

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FCFHOGBMDAE<T> AJLBDGPJCAA(int GHILOAGNIAE);

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FCFHOGBMDAE<T> HNGFEDLLJOP(int GHILOAGNIAE, ODAFFINELBI<T> NIGBOHDDEAL);
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public interface LMCJEKCBNKB
{
	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FCFHOGBMDAE<T> JCLBLEBCBPL<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BANGDJJCOOF ONJDOMLCAAA(Exception JCOJOLLOCIG);

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JLDHMGNBHBF NFJDLJDBELG(Exception JCOJOLLOCIG);
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public delegate string KHIEPGKDJID<in T>(T JCOJOLLOCIG) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public delegate int ODAFFINELBI<in T>(T JCOJOLLOCIG) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000E4")]
internal class MMDPNMDOFIP : LMCJEKCBNKB
{
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	private delegate string JKGAHOCHEKL(Exception JCOJOLLOCIG);

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	private delegate int KEAPOAECGGI(Exception JCOJOLLOCIG);

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	private class KJECFEBFAKC<T> : FCFHOGBMDAE<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000E8")]
		[CompilerGenerated]
		private sealed class MKKMFCAOOPG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public MKKMFCAOOPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
			internal string HDJDLMDLNCF(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		[CompilerGenerated]
		private sealed class LMHPFHEMHMO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public KHIEPGKDJID<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public LMHPFHEMHMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x44A4010", Offset = "0x44A2A10", VA = "0x1844A4010")]
			internal string PHLLENANINF(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		[CompilerGenerated]
		private sealed class OMOMCDINCKH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public ODAFFINELBI<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public OMOMCDINCKH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x44A4010", Offset = "0x44A2A10", VA = "0x1844A4010")]
			internal int KMOOJHMPFFH(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		private readonly MMDPNMDOFIP OHLCPPFCGAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private readonly Type EAKNPGICHPB;

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x43D7DF0", Offset = "0x43D67F0", VA = "0x1843D7DF0")]
		internal KJECFEBFAKC(MMDPNMDOFIP OHLCPPFCGAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x43D7B70", Offset = "0x43D6570", VA = "0x1843D7B70", Slot = "4")]
		public void GKHGJKOEKAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x43D7A50", Offset = "0x43D6450", VA = "0x1843D7A50", Slot = "5")]
		public FCFHOGBMDAE<T> GDNHBMJOCHP(string HJEKPEEDGCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x43D7CD0", Offset = "0x43D66D0", VA = "0x1843D7CD0", Slot = "6")]
		public FCFHOGBMDAE<T> KMIPDFKJKOH(KHIEPGKDJID<T> JOEKBCLEKNK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x43D7A10", Offset = "0x43D6410", VA = "0x1843D7A10", Slot = "7")]
		public FCFHOGBMDAE<T> AJLBDGPJCAA(int GHILOAGNIAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x43D7BA0", Offset = "0x43D65A0", VA = "0x1843D7BA0", Slot = "8")]
		public FCFHOGBMDAE<T> HNGFEDLLJOP(int GHILOAGNIAE, ODAFFINELBI<T> NIGBOHDDEAL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	private class HMJBECHPGOD<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private bool CIKECLJKIOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private readonly List<Type> LKHOBMPFHEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private readonly Dictionary<Type, TVal> FPPEIGFFOIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private readonly Dictionary<Type, int> HLOEDDLMKII;

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public IReadOnlyList<Type> FOHMAJKPBEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x3FCB040", Offset = "0x3FC9A40", VA = "0x183FCB040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x3FCB550", Offset = "0x3FC9F50", VA = "0x183FCB550")]
		public HMJBECHPGOD(Dictionary<Type, int> HLOEDDLMKII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x3FCB330", Offset = "0x3FC9D30", VA = "0x183FCB330")]
		public void KDCHLCHLBCK(Type COMNIKKFEEB, TVal POCLHBJGKBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x3FCB3E0", Offset = "0x3FC9DE0", VA = "0x183FCB3E0")]
		public bool POMAPGNGIDD(Type EAKNPGICHPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x3FCAF40", Offset = "0x3FC9940", VA = "0x183FCAF40")]
		public bool CJNMODHIIHL(TVal IPHMAHBENGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x3FCB0F0", Offset = "0x3FC9AF0", VA = "0x183FCB0F0")]
		public TVal GJMIFHLLDMF(Type AOGCIMANLIJ)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x3FCB1E0", Offset = "0x3FC9BE0", VA = "0x183FCB1E0")]
		[CompilerGenerated]
		private int IMACIJHIKBM(Type GMAJNLBANDM, Type MFKFGKHPHJC)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private sealed class ICAELNJDJCE : IEnumerable<JLDHMGNBHBF>, IEnumerable, IEnumerator<JLDHMGNBHBF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private JLDHMGNBHBF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public MMDPNMDOFIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private IEnumerator<JLDHMGNBHBF> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		private JLDHMGNBHBF System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0x3A9F220", Offset = "0x3A9DC20", VA = "0x183A9F220", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(JLDHMGNBHBF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0x726A4F0", Offset = "0x7268EF0", VA = "0x18726A4F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x976660", Offset = "0x975060", VA = "0x180976660")]
		[DebuggerHidden]
		public ICAELNJDJCE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x726A540", Offset = "0x7268F40", VA = "0x18726A540", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x7269F30", Offset = "0x7268930", VA = "0x187269F30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x7269EE0", Offset = "0x72688E0", VA = "0x187269EE0")]
		private void JDIKFIOLCDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x7269E90", Offset = "0x7268890", VA = "0x187269E90")]
		private void EEFNKGAPPJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x726A4A0", Offset = "0x7268EA0", VA = "0x18726A4A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x726A3E0", Offset = "0x7268DE0", VA = "0x18726A3E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JLDHMGNBHBF> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x726A3E0", Offset = "0x7268DE0", VA = "0x18726A3E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private static readonly JLDHMGNBHBF LHEGBHOEHGM;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private static readonly Dictionary<Type, int> EMIDKKCDACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private readonly HashSet<Type> NOOMOJAKHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private readonly HMJBECHPGOD<int> LHPBCKPMJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private readonly HMJBECHPGOD<KEAPOAECGGI> BICBBLEKLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private readonly HMJBECHPGOD<JKGAHOCHEKL> FHBCJKDMKJL;

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x72731B0", Offset = "0x7271BB0", VA = "0x1872731B0")]
	[MDINNNLEANF.FIHKBCJDGBK.GBDNBGLLJBG]
	internal static void NBLEEGPPBCG(FNNNJBMCDDC FOKBFKHGDKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x7273570", Offset = "0x7271F70", VA = "0x187273570")]
	[RecRoom.NoEngine.Common.Preserve]
	public MMDPNMDOFIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x2BD0970", Offset = "0x2BCF370", VA = "0x182BD0970", Slot = "4")]
	public FCFHOGBMDAE<T> JCLBLEBCBPL<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x7273420", Offset = "0x7271E20", VA = "0x187273420", Slot = "5")]
	public BANGDJJCOOF ONJDOMLCAAA(Exception JCOJOLLOCIG)
	{
		return default(BANGDJJCOOF);
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x7273220", Offset = "0x7271C20", VA = "0x187273220", Slot = "6")]
	public JLDHMGNBHBF NFJDLJDBELG(Exception? JCOJOLLOCIG)
	{
		return default(JLDHMGNBHBF);
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x7272540", Offset = "0x7270F40", VA = "0x187272540", Slot = "7")]
	[IteratorStateMachine(typeof(ICAELNJDJCE))]
	public IEnumerable<JLDHMGNBHBF> GKKEMFDDMBL(Exception JCOJOLLOCIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x7272A60", Offset = "0x7271460", VA = "0x187272A60", Slot = "8")]
	public string IGLHCOAANHM(Exception? JCOJOLLOCIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x7272760", Offset = "0x7271160", VA = "0x187272760")]
	private string HMPKDGMLDMA(AggregateException AKDCMDIDFEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x7272BB0", Offset = "0x72715B0", VA = "0x187272BB0")]
	private void JHDGNDOLEFN(Type EAKNPGICHPB, int GHILOAGNIAE, KEAPOAECGGI? NKHONKHPNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x7272F60", Offset = "0x7271960", VA = "0x187272F60")]
	private void MGFEEGNHOFL(Type EAKNPGICHPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x7272270", Offset = "0x7270C70", VA = "0x187272270")]
	private void GEDFKLAOEOP(Type EAKNPGICHPB, JKGAHOCHEKL NMFCGFNMCMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x72725E0", Offset = "0x7270FE0", VA = "0x1872725E0")]
	private static int GNKELINCFCH(Type EAKNPGICHPB, Dictionary<Type, int> HLOEDDLMKII)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x2E78B20", Offset = "0x2E77520", VA = "0x182E78B20")]
	private static bool CMFPJPAGAML<TVal>(HMJBECHPGOD<TVal> KIAGDMGGGNM, Type EAKNPGICHPB, [Out] TVal IPHMAHBENGI) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x7272190", Offset = "0x7270B90", VA = "0x187272190")]
	[CompilerGenerated]
	internal static int DPEMPOEOGAC(Type EOENMJCHGNI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public struct BANGDJJCOOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public readonly JLDHMGNBHBF EOMDBCPFIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public readonly string JJEFHCBGMCH;

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x725AF80", Offset = "0x7259980", VA = "0x18725AF80")]
	public BANGDJJCOOF(string OLIGEPCJNCB, JLDHMGNBHBF GHILOAGNIAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x725AEE0", Offset = "0x72598E0", VA = "0x18725AEE0")]
	public string CGAMEFOBJFG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public class NBEBJDKLKGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private readonly GJAOPJJEKBG FNFLCBODDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private string KCNIDFFACPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private long? KPILCJGPKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private long? NNPCKJBEJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private long? HFMKPFEFFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private string CAHDINNIDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private MOLNENEPFJJ EIKGJOOLJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private long? NNFPNGGFILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private bool CHALJOPAMIP;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public string GFAICMMOMJH
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public long DADANCIEDIK
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x7275260", Offset = "0x7273C60", VA = "0x187275260")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public long KHGPFCGPFBA
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x72744F0", Offset = "0x7272EF0", VA = "0x1872744F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public long AMCLBEHEKDN
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x72752C0", Offset = "0x7273CC0", VA = "0x1872752C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public string AOHNFHFNGHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x72750D0", Offset = "0x7273AD0", VA = "0x1872750D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public MOLNENEPFJJ CEAFPOLFDEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x9363A0", Offset = "0x934DA0", VA = "0x1809363A0")]
		get
		{
			return default(MOLNENEPFJJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x7275110", Offset = "0x7273B10", VA = "0x187275110")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public long INEIHGIJMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x7275200", Offset = "0x7273C00", VA = "0x187275200")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x7275320", Offset = "0x7273D20", VA = "0x187275320")]
	[UnityEngine.Scripting.Preserve]
	public NBEBJDKLKGB([LKKACOOMNBP(null)] GJAOPJJEKBG FNFLCBODDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x7274550", Offset = "0x7272F50", VA = "0x187274550")]
	private void BKPJGCIDEDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x72747A0", Offset = "0x72731A0", VA = "0x1872747A0")]
	public void FFCDPKOHKDF(long MOEKPKHCJHD, long NMDIIDEMCDI, [Optional] long? FNDGMLDNPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x7274C30", Offset = "0x7273630", VA = "0x187274C30")]
	public void FIFGBPCJOKM(long FNDGMLDNPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x7275050", Offset = "0x7273A50", VA = "0x187275050")]
	public void LKJOEDKGMPE(string GFHFEOKMPEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x7274CD0", Offset = "0x72736D0", VA = "0x187274CD0")]
	public void GCJIMCCCOJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal class JHPBEIHBNBJ : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct GBIHCDILIKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public AsyncTaskMethodBuilder<CELGPAAAIIN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public CELGPAAAIIN roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public JHPBEIHBNBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		private TaskAwaiter<MBGDHIJMIIB.BAICMHEGOAA<CELGPAAAIIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x7283B70", Offset = "0x7282570", VA = "0x187283B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x7283F80", Offset = "0x7282980", VA = "0x187283F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private struct AEIMLHNDOJJ<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class KKJLOIHBKDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public CELGPAAAIIN roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public KKJLOIHBKDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x728AEC0", Offset = "0x72898C0", VA = "0x18728AEC0")]
		internal CELGPAAAIIN LNFFCALAPDG(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct AFAHAOEGIPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public AsyncTaskMethodBuilder<MBGDHIJMIIB.BAICMHEGOAA<CELGPAAAIIN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public CELGPAAAIIN roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public JHPBEIHBNBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private BOHGADKHJKJ <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private TaskAwaiter<MBGDHIJMIIB.BAICMHEGOAA<CELGPAAAIIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x727A7F0", Offset = "0x72791F0", VA = "0x18727A7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x727AE00", Offset = "0x7279800", VA = "0x18727AE00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private struct ALIMGPMFKPK<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public JHPBEIHBNBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x3EA4A30", Offset = "0x3EA3430", VA = "0x183EA4A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x3751550", Offset = "0x374FF50", VA = "0x183751550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private struct IBNMFHBALAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public JHPBEIHBNBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x7285BC0", Offset = "0x72845C0", VA = "0x187285BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x7285D80", Offset = "0x7284780", VA = "0x187285D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class MNJLIIJCGFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public MNJLIIJCGFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x728BA20", Offset = "0x728A420", VA = "0x18728BA20")]
		internal object CNKPEFPMNFM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x728BA80", Offset = "0x728A480", VA = "0x18728BA80")]
		internal bool JOMAGODFGDO(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class PGKLLDDHPFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public PGKLLDDHPFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x728F8D0", Offset = "0x728E2D0", VA = "0x18728F8D0")]
		internal object AEMDKLMOKMG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class CAHIMPEAIEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public CAHIMPEAIEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x727E440", Offset = "0x727CE40", VA = "0x18727E440")]
		internal object PBCDEDFOHAO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class PLGJIAJFGIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public PLGJIAJFGIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x7290C50", Offset = "0x728F650", VA = "0x187290C50")]
		internal object EKNOAIECPIE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private sealed class MIEIECCCLEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public JHPBEIHBNBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public MIEIECCCLEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x728B620", Offset = "0x728A020", VA = "0x18728B620")]
		internal object LECLMNHFKDB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private static readonly Guid LMJKPCCIMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public readonly IGIEMLKHNDA MEAMDPFBBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private readonly MBGDHIJMIIB KJBFLODHOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	private readonly ELGOJFFHPLJ NHPIKOHJFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private readonly HMIMGJLKGHN FNFBLNBDFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private bool KOOBOLBAICK;

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x726F280", Offset = "0x726DC80", VA = "0x18726F280")]
	public JHPBEIHBNBJ(IGIEMLKHNDA OBCNEKMKFFE, MBGDHIJMIIB KJBFLODHOBA, ELGOJFFHPLJ NHPIKOHJFBH, HMIMGJLKGHN FNFBLNBDFEA, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x726E4C0", Offset = "0x726CEC0", VA = "0x18726E4C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x726E4C0", Offset = "0x726CEC0", VA = "0x18726E4C0")]
	public void FNPBDCMHGHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x726E2A0", Offset = "0x726CCA0", VA = "0x18726E2A0")]
	public void CGKINJACGDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x726E8C0", Offset = "0x726D2C0", VA = "0x18726E8C0")]
	public void JNCJFHEMJHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x726EBC0", Offset = "0x726D5C0", VA = "0x18726EBC0")]
	[AsyncStateMachine(typeof(GBIHCDILIKM))]
	internal Task<CELGPAAAIIN> LMOGJNJAFDO(GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CELGPAAAIIN GHHJCAFPGMI, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x2DBCF30", Offset = "0x2DBB930", VA = "0x182DBCF30")]
	private static byte[] FMGJANLDOHC<T>(T BBDGOIMNDJI) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x2DBD570", Offset = "0x2DBBF70", VA = "0x182DBD570")]
	private static T KMBOHAGNKBP<T>(MessageParser<T> JEHGHMHDOEI, byte[] BBDGOIMNDJI, T GEFBPGNPGOK) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x726EFD0", Offset = "0x726D9D0", VA = "0x18726EFD0")]
	[AsyncStateMachine(typeof(AFAHAOEGIPG))]
	private Task<MBGDHIJMIIB.BAICMHEGOAA<CELGPAAAIIN>> OHJLFNKCPCH(CELGPAAAIIN GHHJCAFPGMI, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x2DBD1E0", Offset = "0x2DBBBE0", VA = "0x182DBD1E0")]
	[AsyncStateMachine(typeof(ALIMGPMFKPK<>))]
	internal Task<T> KGJAKFOFNDN<T>(CancellationToken BENMLFLNPKG, Func<CancellationToken, Task<T>> DBNGLGDCIGA, int KDKKILEJHHC = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x726E980", Offset = "0x726D380", VA = "0x18726E980")]
	[AsyncStateMachine(typeof(IBNMFHBALAM))]
	internal Task KGJAKFOFNDN(CancellationToken BENMLFLNPKG, Func<CancellationToken, Task> DBNGLGDCIGA, int KDKKILEJHHC = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x726E220", Offset = "0x726CC20", VA = "0x18726E220")]
	public OOHOLKEKFNH BEMCALMBBID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x726E1A0", Offset = "0x726CBA0", VA = "0x18726E1A0")]
	public CONEGFNGJKI AMHJJDKIDLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x726E630", Offset = "0x726D030", VA = "0x18726E630")]
	public BKADMLOCICM GDCLKHOEIGO([Optional] CAFGMNLACIN? FEMNEHJOJBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x726E360", Offset = "0x726CD60", VA = "0x18726E360")]
	public void DDPPOOHJAHD(Func<Guid, bool> FBANNEPFCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x726E7B0", Offset = "0x726D1B0", VA = "0x18726E7B0")]
	public void JDEEEHLMMJA(Func<Guid, bool> JHNBDIAGEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x726ED20", Offset = "0x726D720", VA = "0x18726ED20")]
	public Guid NABMKIKMIPL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x726F110", Offset = "0x726DB10", VA = "0x18726F110")]
	public void PFONOJAOMJA(Guid DPLOPLHNDPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x726EEA0", Offset = "0x726D8A0", VA = "0x18726EEA0")]
	public void OCDDFAALGMN(CELGPAAAIIN KJIJELNLOCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x726EAB0", Offset = "0x726D4B0", VA = "0x18726EAB0")]
	public void LHPAJEFICIG(string NHMLKPEGAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x2DBD480", Offset = "0x2DBBE80", VA = "0x182DBD480")]
	private T KJCNJIENKAJ<T>(T IPHMAHBENGI) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x726E5E0", Offset = "0x726CFE0", VA = "0x18726E5E0")]
	public void FBKCOOCDAHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x2DBCF40", Offset = "0x2DBB940", VA = "0x182DBCF40")]
	[CompilerGenerated]
	internal static string GOPJEFDMLIP<T>(byte[] MGCOGNAKONH, int CIJNMEICJJP, AEIMLHNDOJJ<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal sealed class DEOAFOAIBDJ : IGIEMLKHNDA
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private sealed class BENAFEEJHPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public BENAFEEJHPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x727C170", Offset = "0x727AB70", VA = "0x18727C170")]
		internal object HNJIKPCIEHG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private struct COGCGIKCBCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public DEOAFOAIBDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public JHPBEIHBNBJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private HCKKKMLKBME <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private CONEGFNGJKI <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x727FB70", Offset = "0x727E570", VA = "0x18727FB70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x7280440", Offset = "0x727EE40", VA = "0x187280440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private struct MOFPILNHFGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public DEOAFOAIBDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private bool <omIsEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private bool <omShouldBeEnabled>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private TaskAwaiter<NBOIDPFPFBM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private TaskAwaiter<byte> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x728C460", Offset = "0x728AE60", VA = "0x18728C460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x728CC10", Offset = "0x728B610", VA = "0x18728CC10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private struct BEMADMBEGJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public AsyncTaskMethodBuilder<byte> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public DEOAFOAIBDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private TaskAwaiter<BEOIGDDMAEA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x727BDF0", Offset = "0x727A7F0", VA = "0x18727BDF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x727C100", Offset = "0x727AB00", VA = "0x18727C100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private sealed class AACHNHIOMEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public HCKKKMLKBME presence;

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public AACHNHIOMEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x727A6B0", Offset = "0x72790B0", VA = "0x18727A6B0")]
		internal object GFLHLMJJJHP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	private static readonly CAFGMNLACIN FEMNEHJOJBN;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	private static readonly CAFGMNLACIN ECGJLAPELMA;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	private static readonly CAFGMNLACIN BLKGCPMEGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000387")]
	private readonly IMNJOLLKFEM EEOCFOEALDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000388")]
	private readonly FLFGKHCBJJD BCAAIJFNEIG;

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x7282B10", Offset = "0x7281510", VA = "0x187282B10")]
	public DEOAFOAIBDJ(IMNJOLLKFEM EEOCFOEALDO, FLFGKHCBJJD BCAAIJFNEIG, Guid OOCNLFNKKML, FGAGHPALDNJ NCAFNAHMGMF, MILPNFIFKAC LJMBLCOFDDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x7282520", Offset = "0x7280F20", VA = "0x187282520", Slot = "7")]
	[AsyncStateMachine(typeof(COGCGIKCBCD))]
	protected override Task ACGJELDFPMN(JHPBEIHBNBJ FEKPEBAIDHP, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x7282940", Offset = "0x7281340", VA = "0x187282940")]
	[AsyncStateMachine(typeof(MOFPILNHFGH))]
	private Task MOFJPPKEHJF(CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x7282830", Offset = "0x7281230", VA = "0x187282830")]
	[AsyncStateMachine(typeof(BEMADMBEGJP))]
	private Task<byte> IJNAOKBCPFP(CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x7282660", Offset = "0x7281060", VA = "0x187282660")]
	private HCKKKMLKBME BKHMIAONPEJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal class KJFJOEKAPNM : IGIEMLKHNDA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private struct JGPJMEKFECM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public KJFJOEKAPNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public JHPBEIHBNBJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private TaskAwaiter<ANLPGLHMEBJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x7287500", Offset = "0x7285F00", VA = "0x187287500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x7287EA0", Offset = "0x72868A0", VA = "0x187287EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	private readonly int DPOGGDODFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	private readonly BKKMLGPDFKC FMBLDCCMMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public readonly long EPMGNKNAKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public readonly long FABIKPNHAJJ;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public ANLPGLHMEBJ ABPJKBJNBAG
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x883C90", Offset = "0x882690", VA = "0x180883C90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x883DE0", Offset = "0x8827E0", VA = "0x180883DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x728AD90", Offset = "0x7289790", VA = "0x18728AD90")]
	public KJFJOEKAPNM(Guid OOCNLFNKKML, FGAGHPALDNJ NCAFNAHMGMF, MILPNFIFKAC LJMBLCOFDDD, int DPOGGDODFMC, BKKMLGPDFKC FMBLDCCMMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x728AC70", Offset = "0x7289670", VA = "0x18728AC70", Slot = "7")]
	[AsyncStateMachine(typeof(JGPJMEKFECM))]
	protected override Task ACGJELDFPMN(JHPBEIHBNBJ FEKPEBAIDHP, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
internal abstract class PJAJMDCEJNK : IGIEMLKHNDA
{
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private sealed class EHPKENHFOBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public PJAJMDCEJNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public ECDKEFHMNCF playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public EHPKENHFOBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x7282FC0", Offset = "0x72819C0", VA = "0x187282FC0")]
		internal Task EGDEMNPEKDI(GOLFJDFFGLD<string>.EFMHMOBJFGI postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x7282F30", Offset = "0x7281930", VA = "0x187282F30")]
		internal object BHBCBJIPFPH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private struct GDHOBAJEKAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public PJAJMDCEJNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public JHPBEIHBNBJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private EHPKENHFOBB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x7284D70", Offset = "0x7283770", VA = "0x187284D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x7285530", Offset = "0x7283F30", VA = "0x187285530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private struct KFCJFLHPIAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public ECDKEFHMNCF playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public PJAJMDCEJNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x72887E0", Offset = "0x72871E0", VA = "0x1872887E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x7288D80", Offset = "0x7287780", VA = "0x187288D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x7290C00", Offset = "0x728F600", VA = "0x187290C00")]
	public PJAJMDCEJNK(Guid OOCNLFNKKML, FGAGHPALDNJ NCAFNAHMGMF, MILPNFIFKAC LJMBLCOFDDD, string IEGNCODBKLA, AAMHGEMHMAI PILNALGGBDH, bool IHNCJGHBGEG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x7290980", Offset = "0x728F380", VA = "0x187290980", Slot = "7")]
	[AsyncStateMachine(typeof(GDHOBAJEKAA))]
	protected override Task ACGJELDFPMN(JHPBEIHBNBJ FEKPEBAIDHP, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task GCBCBFIDJLF(JHPBEIHBNBJ FEKPEBAIDHP, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x7290AC0", Offset = "0x728F4C0", VA = "0x187290AC0")]
	[AsyncStateMachine(typeof(KFCJFLHPIAC))]
	private Task GDIHHLENOMA(IDisposable NHAGJJLKLBC, ECDKEFHMNCF JOPGOEHBKDJ, GOLFJDFFGLD<string>.EFMHMOBJFGI MBHLFFACPEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
internal class KFKDOMNCDIA : IGIEMLKHNDA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct KFAFLOGLCDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public KFKDOMNCDIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public JHPBEIHBNBJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private TaskAwaiter<FNKDHFNCDJH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x7288210", Offset = "0x7286C10", VA = "0x187288210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x7288780", Offset = "0x7287180", VA = "0x187288780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	private readonly IHMNJEAIAGN PHAIKKCIPMC;

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x7288FE0", Offset = "0x72879E0", VA = "0x187288FE0")]
	public KFKDOMNCDIA(Guid OOCNLFNKKML, FGAGHPALDNJ NCAFNAHMGMF, MILPNFIFKAC LJMBLCOFDDD, IHMNJEAIAGN PHAIKKCIPMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x7288F00", Offset = "0x7287900", VA = "0x187288F00", Slot = "6")]
	protected override string HCMFLHIGHAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x7288DE0", Offset = "0x72877E0", VA = "0x187288DE0", Slot = "7")]
	[AsyncStateMachine(typeof(KFAFLOGLCDJ))]
	protected override Task ACGJELDFPMN(JHPBEIHBNBJ FEKPEBAIDHP, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
internal abstract class IGIEMLKHNDA : EJPHPAFHCLP
{
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	public delegate Task LKAPKLEDAMA(GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH);

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private sealed class EFFEDNDAPKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public IGIEMLKHNDA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public EFFEDNDAPKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x7282E00", Offset = "0x7281800", VA = "0x187282E00")]
		internal Task CAFKBEOIEOK(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private sealed class IDGJJPNALHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public EFFEDNDAPKB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public IDGJJPNALHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x7285DE0", Offset = "0x72847E0", VA = "0x187285DE0")]
		internal object IHLKIEFNNLA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct BOMIHLGKCKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public IGIEMLKHNDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public Func<IGIEMLKHNDA, GOLFJDFFGLD<string>.EFMHMOBJFGI, JHPBEIHBNBJ> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private EFFEDNDAPKB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private JHPBEIHBNBJ <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private TaskAwaiter<CELGPAAAIIN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x727C300", Offset = "0x727AD00", VA = "0x18727C300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x727D400", Offset = "0x727BE00", VA = "0x18727D400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct NGMIDFACJFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public Func<CancellationToken, Task> createDriverTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public Func<CancellationToken, Task> originalTaskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private CancellationTokenSource <driverCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private Task <driverTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private Task <originalTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x728CC70", Offset = "0x728B670", VA = "0x18728CC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x728D710", Offset = "0x728C110", VA = "0x18728D710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private struct PPAHDGLGKJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public IGIEMLKHNDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x7290CC0", Offset = "0x728F6C0", VA = "0x187290CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x7291020", Offset = "0x728FA20", VA = "0x187291020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public readonly Guid NMADGHJLOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public readonly ByteString OBCBBAABLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public readonly MILPNFIFKAC HHDBFKGNGGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	protected readonly string MCBJDMDLMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	private readonly FGAGHPALDNJ NCAFNAHMGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	private readonly bool IHNCJGHBGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	private readonly Queue<LKAPKLEDAMA> OGNEBFCHAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	private readonly NELNHAFDEJH CNFDPIHMENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	private readonly AAMHGEMHMAI PILNALGGBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private bool MPKPKCDIOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public MOLNENEPFJJ NPPIBAIHHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public MOLNENEPFJJ GJPKADLJHLP;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public FGAGHPALDNJ DPCMCCOLGJA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x8892A0", Offset = "0x887CA0", VA = "0x1808892A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public CIFFNCDBMGE FJMIEGHLOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x7286910", Offset = "0x7285310", VA = "0x187286910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public EFNKOCFKAGD GEKNCMNDKFA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x72862A0", Offset = "0x7284CA0", VA = "0x1872862A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public DPDIKCBEILH NNPDHOLGNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x7286420", Offset = "0x7284E20", VA = "0x187286420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event ECJGDNNMOKO KIJKLDICDMC
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x7286120", Offset = "0x7284B20", VA = "0x187286120", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x72864A0", Offset = "0x7284EA0", VA = "0x1872864A0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x7286AE0", Offset = "0x72854E0", VA = "0x187286AE0")]
	protected IGIEMLKHNDA(Guid OOCNLFNKKML, FGAGHPALDNJ NCAFNAHMGMF, MILPNFIFKAC LJMBLCOFDDD, string IEGNCODBKLA, AAMHGEMHMAI PILNALGGBDH, bool IHNCJGHBGEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x7286260", Offset = "0x7284C60", VA = "0x187286260", Slot = "6")]
	protected virtual string HCMFLHIGHAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x72860A0", Offset = "0x7284AA0", VA = "0x1872860A0")]
	public void BBMBAJJBHBN(LKAPKLEDAMA PELOHCJGJCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x7286100", Offset = "0x7284B00", VA = "0x187286100")]
	protected void BNPJEDAHOMG(float DKCAIIDABEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x72864C0", Offset = "0x7284EC0", VA = "0x1872864C0")]
	[AsyncStateMachine(typeof(BOMIHLGKCKB))]
	public Task KELODGGKPBN(CancellationToken LOIOCMLGMKH, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, [Optional] Func<IGIEMLKHNDA, GOLFJDFFGLD<string>.EFMHMOBJFGI, JHPBEIHBNBJ> HNKNBKIJCLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x72862F0", Offset = "0x7284CF0", VA = "0x1872862F0")]
	[AsyncStateMachine(typeof(NGMIDFACJFA))]
	private static Task JGGMEPEEHKO(Func<CancellationToken, Task> DDBMLPDCPDH, Func<CancellationToken, Task> JBNJGILCPDB, CancellationToken BENMLFLNPKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x7286960", Offset = "0x7285360", VA = "0x187286960")]
	private void OJONEKIONJC(bool FAJBCEPOPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x7286800", Offset = "0x7285200", VA = "0x187286800")]
	private void MPHEFKIMIAO(JHPBEIHBNBJ FEKPEBAIDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task ACGJELDFPMN(JHPBEIHBNBJ FEKPEBAIDHP, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH);

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x7286140", Offset = "0x7284B40", VA = "0x187286140")]
	[AsyncStateMachine(typeof(PPAHDGLGKJC))]
	private Task DEFALEFFGKH(GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x7286700", Offset = "0x7285100", VA = "0x187286700")]
	public CELGPAAAIIN MCCJMJNOCLE(BOHGADKHJKJ FKAMHDGHCHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x7286610", Offset = "0x7285010", VA = "0x187286610")]
	[CompilerGenerated]
	private Task KHMAPFLPDLD(CancellationToken NNEFLDDEJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x7286780", Offset = "0x7285180", VA = "0x187286780")]
	[CompilerGenerated]
	private object MELKBPPGNKB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
internal sealed class IELAGPLNMLF : PJAJMDCEJNK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct JCMNDICNDBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public IELAGPLNMLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public JHPBEIHBNBJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private LBGEPNPLEJA <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private CONEGFNGJKI <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x7286D40", Offset = "0x7285740", VA = "0x187286D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x72874A0", Offset = "0x7285EA0", VA = "0x1872874A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	private readonly IMNJOLLKFEM GOMCOADIBGD;

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x7285FF0", Offset = "0x72849F0", VA = "0x187285FF0")]
	public IELAGPLNMLF(Guid OOCNLFNKKML, FGAGHPALDNJ NCAFNAHMGMF, IMNJOLLKFEM GOMCOADIBGD, MILPNFIFKAC LJMBLCOFDDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x7285EA0", Offset = "0x72848A0", VA = "0x187285EA0", Slot = "8")]
	[AsyncStateMachine(typeof(JCMNDICNDBE))]
	protected override Task GCBCBFIDJLF(JHPBEIHBNBJ FEKPEBAIDHP, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal class MKGMCPIACGB : IGIEMLKHNDA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private struct LIDHEGOGGKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public MKGMCPIACGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public JHPBEIHBNBJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private TaskAwaiter<FNKDHFNCDJH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x728AFA0", Offset = "0x72899A0", VA = "0x18728AFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x728B350", Offset = "0x7289D50", VA = "0x18728B350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	private readonly string OBHFMAFLHLH;

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x728B970", Offset = "0x728A370", VA = "0x18728B970")]
	public MKGMCPIACGB(Guid OOCNLFNKKML, FGAGHPALDNJ NCAFNAHMGMF, MILPNFIFKAC LJMBLCOFDDD, string OBHFMAFLHLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x728B860", Offset = "0x728A260", VA = "0x18728B860", Slot = "7")]
	[AsyncStateMachine(typeof(LIDHEGOGGKM))]
	protected override Task ACGJELDFPMN(JHPBEIHBNBJ FEKPEBAIDHP, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal class CODNBHKMAMB : PJAJMDCEJNK
{
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private sealed class LLLOKCLLJIE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000119")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000416")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000417")]
			public AsyncTaskMethodBuilder<CELGPAAAIIN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000418")]
			public LLLOKCLLJIE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000419")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			private TaskAwaiter<FNKDHFNCDJH> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400041B")]
			private TaskAwaiter<CELGPAAAIIN> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0x72925E0", Offset = "0x7290FE0", VA = "0x1872925E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0x7292AA0", Offset = "0x72914A0", VA = "0x187292AA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public CODNBHKMAMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public BKADMLOCICM serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public CHIDMAEAKIM roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public OOHOLKEKFNH uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public IHKLNMNONHG roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public LLLOKCLLJIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x728B500", Offset = "0x7289F00", VA = "0x18728B500")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<CELGPAAAIIN> JHFMFDJHPKP(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct CAHCLCAFHMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public CODNBHKMAMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public JHPBEIHBNBJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private LLLOKCLLJIE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private LBGEPNPLEJA <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private CONEGFNGJKI <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private CELGPAAAIIN <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private TaskAwaiter<CELGPAAAIIN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x727D460", Offset = "0x727BE60", VA = "0x18727D460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x727E3E0", Offset = "0x727CDE0", VA = "0x18727E3E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	private static readonly CAFGMNLACIN FEMNEHJOJBN;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	private static readonly CAFGMNLACIN ECGJLAPELMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	private readonly int PPGFEIKKFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	[CanBeNull]
	private readonly BFKIDDCLOKK CNLLIFFAFAG;

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x727FAC0", Offset = "0x727E4C0", VA = "0x18727FAC0")]
	public CODNBHKMAMB(Guid OOCNLFNKKML, FGAGHPALDNJ NCAFNAHMGMF, int PPGFEIKKFKK, BFKIDDCLOKK CNLLIFFAFAG, MILPNFIFKAC LJMBLCOFDDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x727F8D0", Offset = "0x727E2D0", VA = "0x18727F8D0", Slot = "8")]
	[AsyncStateMachine(typeof(CAHCLCAFHMM))]
	protected override Task GCBCBFIDJLF(JHPBEIHBNBJ FEKPEBAIDHP, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x727F7D0", Offset = "0x727E1D0", VA = "0x18727F7D0")]
	private void FNFIALGGGCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x727F600", Offset = "0x727E000", VA = "0x18727F600")]
	private void AGLPKGPMCLG(GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, LBGEPNPLEJA MPDIMGMLMLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal abstract class EDDFFAEACND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public readonly IGIEMLKHNDA MEAMDPFBBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public readonly JHPBEIHBNBJ EOMEHNNLMHB;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public CIFFNCDBMGE FJMIEGHLOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x7282D50", Offset = "0x7281750", VA = "0x187282D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public DPDIKCBEILH NNPDHOLGNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x7282CA0", Offset = "0x72816A0", VA = "0x187282CA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x7282DA0", Offset = "0x72817A0", VA = "0x187282DA0")]
	protected EDDFFAEACND(JHPBEIHBNBJ FEKPEBAIDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x7282D30", Offset = "0x7281730", VA = "0x187282D30")]
	protected void LHPAJEFICIG(string NHMLKPEGAJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
internal struct OACAHPCPDFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public Dictionary<Guid, List<OAHEDLFPPFF>> FMHIKDGOMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public Dictionary<Guid, List<OAHEDLFPPFF>> OAMMDGDNHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public Dictionary<Guid, List<OAHEDLFPPFF>> MKBDNBMNDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public List<Guid> IKBEAPJOAKD;

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x728F2D0", Offset = "0x728DCD0", VA = "0x18728F2D0")]
	public static OACAHPCPDFN GJMIFHLLDMF(CIFFNCDBMGE HILLMDJLLHN, MOLNENEPFJJ MIIPACJPANO, OOGIBKAOAMC AMPNJKNENLH)
	{
		return default(OACAHPCPDFN);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal struct AABKCEKKNKC
{
	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0")]
	public static AABKCEKKNKC EMJKOLAJLFI()
	{
		return default(AABKCEKKNKC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal struct EOEGNCKBDEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public readonly NBOIDPFPFBM HELAFOILBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public readonly OPLJDOIGEJC OILIMOHNFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public readonly string CGCFDFNPJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public readonly LGAFJFEBDLI IPPFHGIBMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public readonly LGAFJFEBDLI NDNMMDDAEMJ;

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x7283000", Offset = "0x7281A00", VA = "0x187283000")]
	public EOEGNCKBDEC(NBOIDPFPFBM HELAFOILBPK, OPLJDOIGEJC OILIMOHNFPG, string CGCFDFNPJNA, LGAFJFEBDLI IPPFHGIBMOF, LGAFJFEBDLI NDNMMDDAEMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
internal struct GFNNEPIJLDN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	private readonly JHPBEIHBNBJ FEKPEBAIDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	private readonly Guid DPLOPLHNDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	private bool FAJBCEPOPIC;

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x7285870", Offset = "0x7284270", VA = "0x187285870")]
	public static GFNNEPIJLDN NABMKIKMIPL(JHPBEIHBNBJ FEKPEBAIDHP)
	{
		return default(GFNNEPIJLDN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0xBC40D0", Offset = "0xBC2AD0", VA = "0x180BC40D0")]
	public void FOEMNOKPCAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x7285810", Offset = "0x7284210", VA = "0x187285810", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x7285970", Offset = "0x7284370", VA = "0x187285970")]
	private GFNNEPIJLDN(JHPBEIHBNBJ FEKPEBAIDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x7285810", Offset = "0x7284210", VA = "0x187285810")]
	private void PFONOJAOMJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x72858D0", Offset = "0x72842D0", VA = "0x1872858D0")]
	private Func<Guid, bool> POFDBFAADDD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal class CONEGFNGJKI : EDDFFAEACND, EJPHPAFHCLP
{
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	public delegate Task<MOLNENEPFJJ> IKOAJLMENGN(OOGIBKAOAMC LNCKNHNHHDF, EOOMPLIHHFH AGPCJLANBFL, NELNHAFDEJH KHANOOAMEIK, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct KIALNGNDDIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public CONEGFNGJKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public IMNJOLLKFEM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		private GFNNEPIJLDN <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		private TaskAwaiter<CELGPAAAIIN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x728A4A0", Offset = "0x7288EA0", VA = "0x18728A4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x728AC10", Offset = "0x7289610", VA = "0x18728AC10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct KGELBAECBIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public AsyncTaskMethodBuilder<CELGPAAAIIN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public CONEGFNGJKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public IMNJOLLKFEM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		private TaskAwaiter<CELGPAAAIIN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x7289080", Offset = "0x7287A80", VA = "0x187289080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x72894B0", Offset = "0x7287EB0", VA = "0x1872894B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private struct DBOHIMNCKGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public CONEGFNGJKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public IMNJOLLKFEM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x7282030", Offset = "0x7280A30", VA = "0x187282030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x72824C0", Offset = "0x7280EC0", VA = "0x1872824C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private sealed class FKPDJMMEDOI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000127")]
		private struct <<LoadRoomLocal>b__1>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			public AsyncTaskMethodBuilder<EOEGNCKBDEC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000464")]
			public FKPDJMMEDOI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000465")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			private EOEGNCKBDEC <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			private TaskAwaiter<MOLNENEPFJJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			private TaskAwaiter<EOEGNCKBDEC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000517")]
			[Cpp2IlInjected.Address(RVA = "0x7291080", Offset = "0x728FA80", VA = "0x187291080", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0x7291820", Offset = "0x7290220", VA = "0x187291820", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			public AsyncTaskMethodBuilder<OOGIBKAOAMC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			public FKPDJMMEDOI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			private OOGIBKAOAMC <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			private TaskAwaiter<MOLNENEPFJJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			private TaskAwaiter<OOGIBKAOAMC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x7291890", Offset = "0x7290290", VA = "0x187291890", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051A")]
			[Cpp2IlInjected.Address(RVA = "0x7291EE0", Offset = "0x72908E0", VA = "0x187291EE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public CONEGFNGJKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public IMNJOLLKFEM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public NELNHAFDEJH preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public NELNHAFDEJH downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public EOEGNCKBDEC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public NELNHAFDEJH postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public OOGIBKAOAMC phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public IIHPMDGIECC.CFKNKDEMDKJ <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public FKPDJMMEDOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x7283890", Offset = "0x7282290", VA = "0x187283890")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<EOEGNCKBDEC> KLDGIPJLNKH(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x7283610", Offset = "0x7282010", VA = "0x187283610")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<OOGIBKAOAMC> BGHKDEPJKIP(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x72839D0", Offset = "0x72823D0", VA = "0x1872839D0")]
		internal void OBCPHGDIEHK(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x7283730", Offset = "0x7282130", VA = "0x187283730")]
		internal Task HPLBFLOFPCA(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x7283A10", Offset = "0x7282410", VA = "0x187283A10")]
		internal Task PDDADAFDHLN(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct GBOKCNEGMJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public CONEGFNGJKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public IMNJOLLKFEM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private FKPDJMMEDOI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		private TaskAwaiter<EOEGNCKBDEC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private TaskAwaiter<OOGIBKAOAMC> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x7283FF0", Offset = "0x72829F0", VA = "0x187283FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x7284D10", Offset = "0x7283710", VA = "0x187284D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct KGKFCPABDCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public CONEGFNGJKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public OOGIBKAOAMC phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public NELNHAFDEJH postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private TaskAwaiter<MOLNENEPFJJ> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private EOOMPLIHHFH <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x7289520", Offset = "0x7287F20", VA = "0x187289520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x728A440", Offset = "0x7288E40", VA = "0x18728A440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct MNPDKHDHDLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public CONEGFNGJKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x728BB40", Offset = "0x728A540", VA = "0x18728BB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x728C400", Offset = "0x728AE00", VA = "0x18728C400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct NJAMDAAFEEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public CONEGFNGJKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public OOGIBKAOAMC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public NELNHAFDEJH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private TaskAwaiter<MOLNENEPFJJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x728E8E0", Offset = "0x728D2E0", VA = "0x18728E8E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x728F270", Offset = "0x728DC70", VA = "0x18728F270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct PHHEGOLJKAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public AsyncTaskMethodBuilder<MOLNENEPFJJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public CONEGFNGJKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public OOGIBKAOAMC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public NELNHAFDEJH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private TaskAwaiter<MOLNENEPFJJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x728F930", Offset = "0x728E330", VA = "0x18728F930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x7290910", Offset = "0x728F310", VA = "0x187290910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct NIIJHFLBEBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public AsyncTaskMethodBuilder<MOLNENEPFJJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public CONEGFNGJKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public OOGIBKAOAMC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public NELNHAFDEJH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public EOOMPLIHHFH timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private TaskAwaiter<MOLNENEPFJJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x728D770", Offset = "0x728C170", VA = "0x18728D770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x728E870", Offset = "0x728D270", VA = "0x18728E870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct JJGKMGJIOHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public AsyncTaskMethodBuilder<MOLNENEPFJJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public CONEGFNGJKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public MOLNENEPFJJ operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public NELNHAFDEJH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public OOGIBKAOAMC deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		private TaskAwaiter<MOLNENEPFJJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x7287F00", Offset = "0x7286900", VA = "0x187287F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x72881A0", Offset = "0x7286BA0", VA = "0x1872881A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private sealed class BJAEBGFLPEI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000132")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004BF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004C0")]
			public AsyncTaskMethodBuilder<MOLNENEPFJJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004C1")]
			public BJAEBGFLPEI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004C2")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C3")]
			private CJHBAICPELK <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004C4")]
			private TaskAwaiter<MOLNENEPFJJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000531")]
			[Cpp2IlInjected.Address(RVA = "0x7291F50", Offset = "0x7290950", VA = "0x187291F50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0x7292570", Offset = "0x7290F70", VA = "0x187292570", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public CONEGFNGJKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public OOGIBKAOAMC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public NELNHAFDEJH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public IKOAJLMENGN masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public EOOMPLIHHFH timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public MOLNENEPFJJ originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public BJAEBGFLPEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x727C1E0", Offset = "0x727ABE0", VA = "0x18727C1E0")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<MOLNENEPFJJ> MMNLNPOMDMB(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct FFNLNFPAGIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public AsyncTaskMethodBuilder<MOLNENEPFJJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public CONEGFNGJKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public OOGIBKAOAMC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public NELNHAFDEJH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public IKOAJLMENGN masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public EOOMPLIHHFH timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private CJHBAICPELK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private TaskAwaiter<MOLNENEPFJJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x7283080", Offset = "0x7281A80", VA = "0x187283080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x72835A0", Offset = "0x7281FA0", VA = "0x1872835A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct CFJNNEJGFDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public CONEGFNGJKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public OOGIBKAOAMC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public NELNHAFDEJH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private MOLNENEPFJJ <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private IEnumerator<MOLNENEPFJJ> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private TaskAwaiter<MOLNENEPFJJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x727F050", Offset = "0x727DA50", VA = "0x18727F050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x727F5A0", Offset = "0x727DFA0", VA = "0x18727F5A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct GFLKNHBANNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public CONEGFNGJKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public OOGIBKAOAMC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x7285590", Offset = "0x7283F90", VA = "0x187285590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x72857B0", Offset = "0x72841B0", VA = "0x1872857B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private struct HGFDBLLHMEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public CONEGFNGJKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public OOGIBKAOAMC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x72859C0", Offset = "0x72843C0", VA = "0x1872859C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x7285B60", Offset = "0x7284560", VA = "0x187285B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct AINAABPANDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public CONEGFNGJKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public OOGIBKAOAMC phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public NELNHAFDEJH postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private TaskAwaiter<MOLNENEPFJJ> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private EOOMPLIHHFH <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x727AE70", Offset = "0x7279870", VA = "0x18727AE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x727BD90", Offset = "0x727A790", VA = "0x18727BD90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private struct CFFOFCOBDJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public AsyncTaskMethodBuilder<MOLNENEPFJJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public CONEGFNGJKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public OOGIBKAOAMC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public NELNHAFDEJH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		private TaskAwaiter<MOLNENEPFJJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x727E4B0", Offset = "0x727CEB0", VA = "0x18727E4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x727EFE0", Offset = "0x727D9E0", VA = "0x18727EFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	private readonly FKBHKHOFIEC KBNMEJALDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	private readonly FKBHKHOFIEC KMLKOGELCEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	private readonly NBEBJDKLKGB DCGJPHFKPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	private readonly NENGJPGGJNJ IHJPFEAMHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	private readonly LENEIEDCGBB BPMOMPFFOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400043E")]
	private ProfilerCounterValue<int> NAIFEPBHDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400043F")]
	private readonly COMLPPJJGPO DGFIGEAAMID;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private FGAGHPALDNJ DPCMCCOLGJA
	{
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x7280FA0", Offset = "0x727F9A0", VA = "0x187280FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event ECJGDNNMOKO KIJKLDICDMC
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x72804C0", Offset = "0x727EEC0", VA = "0x1872804C0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x7281130", Offset = "0x727FB30", VA = "0x187281130", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x7281D70", Offset = "0x7280770", VA = "0x187281D70")]
	public CONEGFNGJKI(JHPBEIHBNBJ FEKPEBAIDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x7281830", Offset = "0x7280230", VA = "0x187281830")]
	[AsyncStateMachine(typeof(KIALNGNDDIM))]
	public Task MIBPOCOJHCP(IMNJOLLKFEM MGBHCKLJEHL, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x7281150", Offset = "0x727FB50", VA = "0x187281150")]
	[AsyncStateMachine(typeof(KGELBAECBIM))]
	private Task<CELGPAAAIIN> KJFOFAJJNPE(IMNJOLLKFEM MGBHCKLJEHL, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x7281980", Offset = "0x7280380", VA = "0x187281980")]
	[AsyncStateMachine(typeof(DBOHIMNCKGJ))]
	private Task NJPIPADNHIL(IMNJOLLKFEM MGBHCKLJEHL, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x7281C30", Offset = "0x7280630", VA = "0x187281C30")]
	[AsyncStateMachine(typeof(GBOKCNEGMJJ))]
	private Task POFAIJJGPOJ(IMNJOLLKFEM MGBHCKLJEHL, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken IIKKBEFFJBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x72807D0", Offset = "0x727F1D0", VA = "0x1872807D0")]
	[AsyncStateMachine(typeof(KGKFCPABDCK))]
	private Task DDHBEFELJCI(OOGIBKAOAMC PIEGIDGECGL, NELNHAFDEJH LAMFJADMGCJ, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken OBGJCPAGGIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x7281B00", Offset = "0x7280500", VA = "0x187281B00")]
	[AsyncStateMachine(typeof(MNPDKHDHDLA))]
	private Task OCDPJOGGLHN(GOLFJDFFGLD<string>.EFMHMOBJFGI MBHLFFACPEB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x72804E0", Offset = "0x727EEE0", VA = "0x1872804E0")]
	[AsyncStateMachine(typeof(NJAMDAAFEEO))]
	private Task CONIJONIEGK(OOGIBKAOAMC LNCKNHNHHDF, NELNHAFDEJH KHANOOAMEIK, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x7280BD0", Offset = "0x727F5D0", VA = "0x187280BD0")]
	[AsyncStateMachine(typeof(PHHEGOLJKAN))]
	private Task<MOLNENEPFJJ> FLPJIGEFLDN(OOGIBKAOAMC LNCKNHNHHDF, EOOMPLIHHFH GFMMKKCCHBM, NELNHAFDEJH KHANOOAMEIK, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x7281530", Offset = "0x727FF30", VA = "0x187281530")]
	[AsyncStateMachine(typeof(NIIJHFLBEBE))]
	private Task<MOLNENEPFJJ> MHNMAINGFIB(OOGIBKAOAMC LNCKNHNHHDF, EOOMPLIHHFH GFMMKKCCHBM, NELNHAFDEJH KHANOOAMEIK, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x72816B0", Offset = "0x72800B0", VA = "0x1872816B0")]
	[AsyncStateMachine(typeof(JJGKMGJIOHB))]
	private Task<MOLNENEPFJJ> MIALKLKCELF(MOLNENEPFJJ MIIPACJPANO, OOGIBKAOAMC AMPNJKNENLH, NELNHAFDEJH KHANOOAMEIK, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH, bool PMCDHHINFIK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x7281000", Offset = "0x727FA00", VA = "0x187281000")]
	private bool IBFJEFGHHOL(OOGIBKAOAMC PIEGIDGECGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x7281310", Offset = "0x727FD10", VA = "0x187281310")]
	[AsyncStateMachine(typeof(FFNLNFPAGIH))]
	protected Task<MOLNENEPFJJ> MBGECDCHIIK(OOGIBKAOAMC LNCKNHNHHDF, EOOMPLIHHFH GFMMKKCCHBM, NELNHAFDEJH KHANOOAMEIK, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH, IKOAJLMENGN NLHHKOILAHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x7280680", Offset = "0x727F080", VA = "0x187280680")]
	[AsyncStateMachine(typeof(CFJNNEJGFDD))]
	private Task DBJABKJDOAF(OOGIBKAOAMC LNCKNHNHHDF, NELNHAFDEJH KHANOOAMEIK, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x7280630", Offset = "0x727F030", VA = "0x187280630")]
	private void DAGCKNMLMKH(MOLNENEPFJJ IFGGMOHGJIG, NELNHAFDEJH KHANOOAMEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x72812B0", Offset = "0x727FCB0", VA = "0x1872812B0")]
	private void LABGEAGGNJL(MOLNENEPFJJ NHDOPPFFJEF, [Out] MOLNENEPFJJ JMJBFJAHKJP, [Out] MOLNENEPFJJ IOAJFEFKOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x72814F0", Offset = "0x727FEF0", VA = "0x1872814F0")]
	private Task<EOEGNCKBDEC> MFMGOJLHDMH(IMNJOLLKFEM MGBHCKLJEHL, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x7281AC0", Offset = "0x72804C0", VA = "0x187281AC0")]
	private Task<OOGIBKAOAMC> NMLOPMBPHKM(EOEGNCKBDEC LNCKNHNHHDF, IIHPMDGIECC.CFKNKDEMDKJ GKOMPLMOPJP, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x7280920", Offset = "0x727F320", VA = "0x187280920")]
	[AsyncStateMachine(typeof(GFLKNHBANNL))]
	private Task DFBBJAEDJOF(OOGIBKAOAMC LNCKNHNHHDF, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH, bool PJOHNMDMNGI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x7280D40", Offset = "0x727F740", VA = "0x187280D40")]
	[AsyncStateMachine(typeof(HGFDBLLHMEG))]
	private Task GIHNDDEFNOO(OOGIBKAOAMC LNCKNHNHHDF, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x7280FD0", Offset = "0x727F9D0", VA = "0x187280FD0")]
	private Task HOCLKOJEDMJ(OOGIBKAOAMC LNCKNHNHHDF, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x72804A0", Offset = "0x727EEA0", VA = "0x1872804A0")]
	private Task BHIKNOOKPIB(OOGIBKAOAMC LNCKNHNHHDF, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x7281110", Offset = "0x727FB10", VA = "0x187281110")]
	private Task JEHKOMHELAD(OOGIBKAOAMC LNCKNHNHHDF, EOOMPLIHHFH GFMMKKCCHBM, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x72812F0", Offset = "0x727FCF0", VA = "0x1872812F0")]
	private Task LHMJLHOOFMP(OOGIBKAOAMC LNCKNHNHHDF, EOOMPLIHHFH GFMMKKCCHBM, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x7280D30", Offset = "0x727F730", VA = "0x187280D30")]
	private static Task GAJPHDJBAPN(CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x7281C10", Offset = "0x7280610", VA = "0x187281C10")]
	private Task OKEOEADIIDJ(OOGIBKAOAMC LNCKNHNHHDF, EOOMPLIHHFH GFMMKKCCHBM, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x72810F0", Offset = "0x727FAF0", VA = "0x1872810F0")]
	private Task IJNKNHOPKND(OOGIBKAOAMC LNCKNHNHHDF, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x72814A0", Offset = "0x727FEA0", VA = "0x1872814A0")]
	private void MEFCBDGCKEG(IMNJOLLKFEM MGBHCKLJEHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x7280E30", Offset = "0x727F830", VA = "0x187280E30")]
	public void GJGKFMLAPHM(long FNDGMLDNPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	private static void HOIIBGDOCCL(NBOIDPFPFBM HELAFOILBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x7280E50", Offset = "0x727F850", VA = "0x187280E50")]
	[AsyncStateMachine(typeof(AINAABPANDA))]
	private Task HEHEEHAMGCB(OOGIBKAOAMC PIEGIDGECGL, NELNHAFDEJH LAMFJADMGCJ, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken OBGJCPAGGIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x7280A70", Offset = "0x727F470", VA = "0x187280A70")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(CFFOFCOBDJA))]
	private Task<MOLNENEPFJJ> DJGECLBFNGA(OOGIBKAOAMC LNCKNHNHHDF, EOOMPLIHHFH GFMMKKCCHBM, NELNHAFDEJH KHANOOAMEIK, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct BHFMFLDHPDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private FGAGHPALDNJ NCAFNAHMGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private OOGIBKAOAMC LNCKNHNHHDF;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private CIFFNCDBMGE FJMIEGHLOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x72944C0", Offset = "0x7292EC0", VA = "0x1872944C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x72941D0", Offset = "0x7292BD0", VA = "0x1872941D0")]
	public static Task KELODGGKPBN(FGAGHPALDNJ NCAFNAHMGMF, OOGIBKAOAMC LNCKNHNHHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x72942B0", Offset = "0x7292CB0", VA = "0x1872942B0")]
	private void KELODGGKPBN()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal struct CIDADNJDCDK
{
	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x7296A50", Offset = "0x7295450", VA = "0x187296A50")]
	public static Task KELODGGKPBN(CancellationToken LOIOCMLGMKH)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct FGNINPCEBFK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct LPEEEHMAAIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public JHPBEIHBNBJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public OOGIBKAOAMC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private CJHBAICPELK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x72A6650", Offset = "0x72A5050", VA = "0x1872A6650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x72A6B80", Offset = "0x72A5580", VA = "0x1872A6B80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x7299DE0", Offset = "0x72987E0", VA = "0x187299DE0")]
	[AsyncStateMachine(typeof(LPEEEHMAAIN))]
	public static Task KELODGGKPBN(JHPBEIHBNBJ FEKPEBAIDHP, OOGIBKAOAMC LNCKNHNHHDF, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013D")]
internal struct LAAHGOAIDOF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private struct NDJHGEBFNKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public JHPBEIHBNBJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public OOGIBKAOAMC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public EOOMPLIHHFH timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private MOLNENEPFJJ <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private FGAGHPALDNJ <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private CIFFNCDBMGE <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private CJHBAICPELK <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private List<(PersistenceView, OEAGPMFPCEL)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private OEAGPMFPCEL <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x72A7A00", Offset = "0x72A6400", VA = "0x1872A7A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x72A8690", Offset = "0x72A7090", VA = "0x1872A8690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x72A39D0", Offset = "0x72A23D0", VA = "0x1872A39D0")]
	[AsyncStateMachine(typeof(NDJHGEBFNKA))]
	public static Task KELODGGKPBN(JHPBEIHBNBJ FEKPEBAIDHP, OOGIBKAOAMC LNCKNHNHHDF, EOOMPLIHHFH GFMMKKCCHBM, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x72A37E0", Offset = "0x72A21E0", VA = "0x1872A37E0")]
	private static void AAGODGFEFOL(PersistenceView BDGJAKFBCKL, OEAGPMFPCEL OKFKNACKKGK, OOGIBKAOAMC LNCKNHNHHDF, MOLNENEPFJJ MIIPACJPANO, bool LHLBJCLGABB)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000140")]
internal struct AJLMOJOLKMF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct LLMBNJDGHJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public FGAGHPALDNJ roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public OOGIBKAOAMC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x72A6180", Offset = "0x72A4B80", VA = "0x1872A6180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x72A65B0", Offset = "0x72A4FB0", VA = "0x1872A65B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x7293FD0", Offset = "0x72929D0", VA = "0x187293FD0")]
	[AsyncStateMachine(typeof(LLMBNJDGHJF))]
	public static Task KELODGGKPBN(FGAGHPALDNJ NCAFNAHMGMF, OOGIBKAOAMC LNCKNHNHHDF, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
internal struct PJGFACBPPEP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct KBIAINAKIBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public FGAGHPALDNJ roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public OOGIBKAOAMC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public JHPBEIHBNBJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x72A0910", Offset = "0x729F310", VA = "0x1872A0910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x72A0B20", Offset = "0x729F520", VA = "0x1872A0B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private sealed class FIIHNKEHLOI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000145")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400052D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400052E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400052F")]
			public GOLFJDFFGLD<string>.EFMHMOBJFGI timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000530")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			public FIIHNKEHLOI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			private GOLFJDFFGLD<string>.EFMHMOBJFGI <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(RVA = "0x72ABD50", Offset = "0x72AA750", VA = "0x1872ABD50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0x72AC0E0", Offset = "0x72AAAE0", VA = "0x1872AC0E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public FIIHNKEHLOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x729A510", Offset = "0x7298F10", VA = "0x18729A510")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task POEJGOIMCGI(GOLFJDFFGLD<string>.EFMHMOBJFGI timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct KIDHKNNAMDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public PJGFACBPPEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private CJHBAICPELK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private TaskAwaiter<CELGPAAAIIN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x72A1890", Offset = "0x72A0290", VA = "0x1872A1890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x72A2260", Offset = "0x72A0C60", VA = "0x1872A2260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private sealed class KNJDNMLBNJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public OEONGJBPPJN version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public KNJDNMLBNJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x72A3700", Offset = "0x72A2100", VA = "0x1872A3700")]
		internal object KINNJPDJOCI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x72A3650", Offset = "0x72A2050", VA = "0x1872A3650")]
		internal object EMMCDGAONKC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	private FGAGHPALDNJ NCAFNAHMGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	private OOGIBKAOAMC LNCKNHNHHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	private JHPBEIHBNBJ FEKPEBAIDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	private bool PJOHNMDMNGI;

	[Cpp2IlInjected.Token(Token = "0x4000522")]
	private static readonly ByteString KJEKAMDHPLK;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private CIFFNCDBMGE FJMIEGHLOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x72AB750", Offset = "0x72AA150", VA = "0x1872AB750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private DPDIKCBEILH NNPDHOLGNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x72AB420", Offset = "0x72A9E20", VA = "0x1872AB420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x72AB4C0", Offset = "0x72A9EC0", VA = "0x1872AB4C0")]
	[AsyncStateMachine(typeof(KBIAINAKIBO))]
	public static Task KELODGGKPBN(FGAGHPALDNJ NCAFNAHMGMF, OOGIBKAOAMC LNCKNHNHHDF, JHPBEIHBNBJ FEKPEBAIDHP, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH, bool PJOHNMDMNGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x72AB610", Offset = "0x72AA010", VA = "0x1872AB610")]
	[AsyncStateMachine(typeof(KIDHKNNAMDB))]
	private Task KELODGGKPBN(GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x72AADA0", Offset = "0x72A97A0", VA = "0x1872AADA0")]
	private void FACEDKKKBMG([NotNull] EGDKLHCLIKL FIAJEGMHHBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x72AAD60", Offset = "0x72A9760", VA = "0x1872AAD60")]
	private bool DKPBCCDDAKN(OEONGJBPPJN MOOGIOAAOOM, EGDKLHCLIKL FIAJEGMHHBJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
internal struct NPFOAOJCHCE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct EDOEAMCIBOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public AsyncTaskMethodBuilder<OOGIBKAOAMC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public NPFOAOJCHCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public IIHPMDGIECC.CFKNKDEMDKJ downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		private CJHBAICPELK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private TaskAwaiter<(CDOLGFBAJII<GBJMJJIHNHN, PKNKGFKCKHA>, CDOLGFBAJII<LDBHNJKNPKI<EGDKLHCLIKL>, PKNKGFKCKHA>, CDOLGFBAJII<LDBHNJKNPKI<GHGEAPMBJNK>, PKNKGFKCKHA>, CDOLGFBAJII<LDBHNJKNPKI<NHAKOHKGGMG>, PKNKGFKCKHA>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x7298310", Offset = "0x7296D10", VA = "0x187298310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x7298DC0", Offset = "0x72977C0", VA = "0x187298DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct LAPJNHNAHIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<GBJMJJIHNHN, PKNKGFKCKHA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public NPFOAOJCHCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public IIHPMDGIECC.CFKNKDEMDKJ downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private CJHBAICPELK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private TaskAwaiter<CDOLGFBAJII<GBJMJJIHNHN, PKNKGFKCKHA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x72A3B20", Offset = "0x72A2520", VA = "0x1872A3B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x72A4130", Offset = "0x72A2B30", VA = "0x1872A4130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	private HIODHCPGACA<LGAFJFEBDLI, GHGEAPMBJNK> OKIONINFHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	private HIODHCPGACA<LGAFJFEBDLI, EGDKLHCLIKL> NFLNJOPGLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	private HIODHCPGACA<long, NHAKOHKGGMG> KDBOBMIHMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	private FGEOBGDPNLE BCAHBGNFFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	private NBOIDPFPFBM HELAFOILBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	private OPLJDOIGEJC OILIMOHNFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	private string CGCFDFNPJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	private LGAFJFEBDLI IPPFHGIBMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	private LGAFJFEBDLI NDNMMDDAEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	private long FNDGMLDNPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	private GOLFJDFFGLD<string>.EFMHMOBJFGI MBHLFFACPEB;

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x72A9CE0", Offset = "0x72A86E0", VA = "0x1872A9CE0")]
	public static Task<OOGIBKAOAMC> PMCJHGGIMDE(FGAGHPALDNJ NCAFNAHMGMF, [In] EOEGNCKBDEC LNCKNHNHHDF, IIHPMDGIECC.CFKNKDEMDKJ GKOMPLMOPJP, GOLFJDFFGLD<string>.EFMHMOBJFGI MBHLFFACPEB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x72A9B50", Offset = "0x72A8550", VA = "0x1872A9B50")]
	[AsyncStateMachine(typeof(EDOEAMCIBOC))]
	private Task<OOGIBKAOAMC> KELODGGKPBN(IIHPMDGIECC.CFKNKDEMDKJ GKOMPLMOPJP, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x72A9990", Offset = "0x72A8390", VA = "0x1872A9990")]
	[AsyncStateMachine(typeof(LAPJNHNAHIK))]
	private Task<CDOLGFBAJII<GBJMJJIHNHN, PKNKGFKCKHA>> HDBBGBKFFKH(string CGCFDFNPJNA, long FNDGMLDNPNL, long? MOEKPKHCJHD, long? OAOCFKDGHFI, IIHPMDGIECC.CFKNKDEMDKJ GKOMPLMOPJP, GOLFJDFFGLD<string>.EFMHMOBJFGI AILNDEEJMAJ, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
internal struct HENCPNBOHBL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct OHGBALFCPPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public AsyncTaskMethodBuilder<EOEGNCKBDEC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public HENCPNBOHBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private TaskAwaiter<EOEGNCKBDEC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x72AA200", Offset = "0x72A8C00", VA = "0x1872AA200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x72AA610", Offset = "0x72A9010", VA = "0x1872AA610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct DPBMFNLBJBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public AsyncTaskMethodBuilder<EOEGNCKBDEC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public HENCPNBOHBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private TaskAwaiter<EOEGNCKBDEC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x7297A60", Offset = "0x7296460", VA = "0x187297A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x7297E90", Offset = "0x7296890", VA = "0x187297E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private sealed class LEMHLGNINCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public LEMHLGNINCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x937850", Offset = "0x936250", VA = "0x180937850")]
		internal bool PCJGDMBEHEP(OPLJDOIGEJC sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct KIKAOLPHHNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public AsyncTaskMethodBuilder<EOEGNCKBDEC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public LGAFJFEBDLI superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public CIFFNCDBMGE callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private LEMHLGNINCF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public GLGFPDCOPAH roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private NBOIDPFPFBM <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private OPLJDOIGEJC <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private LGAFJFEBDLI <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private LGAFJFEBDLI <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private TaskAwaiter<NBOIDPFPFBM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private TaskAwaiter<OGEJFLLGHCE> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private TaskAwaiter<BEOIGDDMAEA> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x72A2490", Offset = "0x72A0E90", VA = "0x1872A2490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x72A35E0", Offset = "0x72A1FE0", VA = "0x1872A35E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000562")]
	private CIFFNCDBMGE HILLMDJLLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000563")]
	private NBEBJDKLKGB DCGJPHFKPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000564")]
	private GLGFPDCOPAH BDMKNGFGKCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000565")]
	private GOLFJDFFGLD<string>.EFMHMOBJFGI MBHLFFACPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	private long MOEKPKHCJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	private long NMDIIDEMCDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	private long NNPDAFALPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	private string IJGMHBOCGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	private LGAFJFEBDLI JJHGFPHHCJL;

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x729C150", Offset = "0x729AB50", VA = "0x18729C150")]
	public static Task<EOEGNCKBDEC> PMCJHGGIMDE(FGAGHPALDNJ NCAFNAHMGMF, IMNJOLLKFEM MGBHCKLJEHL, GOLFJDFFGLD<string>.EFMHMOBJFGI MBHLFFACPEB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x729BCD0", Offset = "0x729A6D0", VA = "0x18729BCD0")]
	[AsyncStateMachine(typeof(OHGBALFCPPK))]
	private Task<EOEGNCKBDEC> KELODGGKPBN(CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x729BFF0", Offset = "0x729A9F0", VA = "0x18729BFF0")]
	[AsyncStateMachine(typeof(DPBMFNLBJBO))]
	private Task<EOEGNCKBDEC> MFMGOJLHDMH(GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x729BE50", Offset = "0x729A850", VA = "0x18729BE50")]
	[AsyncStateMachine(typeof(KIKAOLPHHNG))]
	private static Task<EOEGNCKBDEC> MFMGOJLHDMH(CIFFNCDBMGE HILLMDJLLHN, GLGFPDCOPAH BDMKNGFGKCB, long MOEKPKHCJHD, long NMDIIDEMCDI, long NNPDAFALPBG, string IJGMHBOCGFJ, LGAFJFEBDLI JJHGFPHHCJL, CancellationToken LOIOCMLGMKH, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x729BE20", Offset = "0x729A820", VA = "0x18729BE20")]
	private void LJDGBCJCEKJ(NBOIDPFPFBM HELAFOILBPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
internal struct DDMKJPHFNBA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private struct FHMEGNIHBMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public DDMKJPHFNBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x7299F20", Offset = "0x7298920", VA = "0x187299F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x729A4B0", Offset = "0x7298EB0", VA = "0x18729A4B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400058D")]
	private CIFFNCDBMGE HILLMDJLLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400058E")]
	private OOGIBKAOAMC LNCKNHNHHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400058F")]
	private GOLFJDFFGLD<string>.EFMHMOBJFGI MBHLFFACPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000590")]
	private float OKCPIDFCGEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000591")]
	private float BDBHGLIDFAG;

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x72970A0", Offset = "0x7295AA0", VA = "0x1872970A0")]
	public static Task OMIMIIBGHNP(FGAGHPALDNJ NCAFNAHMGMF, OOGIBKAOAMC LNCKNHNHHDF, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x7296EC0", Offset = "0x72958C0", VA = "0x187296EC0")]
	[AsyncStateMachine(typeof(FHMEGNIHBMK))]
	public Task KELODGGKPBN(CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x7296C10", Offset = "0x7295610", VA = "0x187296C10")]
	private static void CGEOOKEPOIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x7296D60", Offset = "0x7295760", VA = "0x187296D60")]
	private void IJPLBIFPFGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x7296FE0", Offset = "0x72959E0", VA = "0x187296FE0")]
	private static float MNFKCPLDKCF(CIFFNCDBMGE HILLMDJLLHN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x7296D40", Offset = "0x7295740", VA = "0x187296D40")]
	private static float IHEPCDHGIEF()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000153")]
internal struct EJJLDLICNOF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct KEHJIAAIKIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public JHPBEIHBNBJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public OOGIBKAOAMC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private CJHBAICPELK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private IGIEMLKHNDA <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private FGAGHPALDNJ <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private JAMMCECFHJK.JBHOKCACPDF <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private TaskAwaiter<CELGPAAAIIN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x72A0B80", Offset = "0x729F580", VA = "0x1872A0B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x72A13A0", Offset = "0x729FDA0", VA = "0x1872A13A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private struct GFPJNMPDABC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private CJHBAICPELK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x729B230", Offset = "0x7299C30", VA = "0x18729B230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x729B560", Offset = "0x7299F60", VA = "0x18729B560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x7299350", Offset = "0x7297D50", VA = "0x187299350")]
	[AsyncStateMachine(typeof(KEHJIAAIKIO))]
	public static Task KELODGGKPBN(JHPBEIHBNBJ FEKPEBAIDHP, OOGIBKAOAMC LNCKNHNHHDF, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x7299490", Offset = "0x7297E90", VA = "0x187299490")]
	private static Task<CELGPAAAIIN> LMOENEPDIEF(JHPBEIHBNBJ FEKPEBAIDHP, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x7299500", Offset = "0x7297F00", VA = "0x187299500")]
	[AsyncStateMachine(typeof(GFPJNMPDABC))]
	private static Task OEMKOHDFBEB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal struct NBGDDJPMEAG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct JGGKIIBDALJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public NBGDDJPMEAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x729F720", Offset = "0x729E120", VA = "0x18729F720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x729FDD0", Offset = "0x729E7D0", VA = "0x18729FDD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private sealed class GJKBGGLENBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public GJKBGGLENBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x729B5C0", Offset = "0x7299FC0", VA = "0x18729B5C0")]
		internal object BDDNEIFBJIJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct JIJNGOHAOMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public NBGDDJPMEAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private CJHBAICPELK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x729FE30", Offset = "0x729E830", VA = "0x18729FE30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x72A02B0", Offset = "0x729ECB0", VA = "0x1872A02B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005AC")]
	private bool OCIPFBEEDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005AD")]
	private GOLFJDFFGLD<string>.EFMHMOBJFGI MBHLFFACPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005AE")]
	private FGAGHPALDNJ NCAFNAHMGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005AF")]
	private CancellationToken LOIOCMLGMKH;

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x72A78A0", Offset = "0x72A62A0", VA = "0x1872A78A0")]
	public static Task EPJMGLGJNEH(FGAGHPALDNJ NCAFNAHMGMF, bool OCIPFBEEDPC, GOLFJDFFGLD<string>.EFMHMOBJFGI MBHLFFACPEB, CancellationToken IJOHDFFMBCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x72A7910", Offset = "0x72A6310", VA = "0x1872A7910")]
	[AsyncStateMachine(typeof(JGGKIIBDALJ))]
	private Task KELODGGKPBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x72A7770", Offset = "0x72A6170", VA = "0x1872A7770")]
	[AsyncStateMachine(typeof(JIJNGOHAOMH))]
	private Task BCLFNHEOHBI(bool KMBCBEELMDE, string MIHEAIGNLHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0")]
	private bool NJPMPGLCIHN(bool OCIPFBEEDPC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct DFGGILGHBLI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct CEIJHIBIFDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public DFGGILGHBLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x7295DC0", Offset = "0x72947C0", VA = "0x187295DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x7296330", Offset = "0x7294D30", VA = "0x187296330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private sealed class KBCOEDGDABJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public KBCOEDGDABJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x72A08C0", Offset = "0x729F2C0", VA = "0x1872A08C0")]
		internal object BDDNEIFBJIJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct IJFEPKAGKJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public DFGGILGHBLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		private CJHBAICPELK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x729CF50", Offset = "0x729B950", VA = "0x18729CF50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x729D3D0", Offset = "0x729BDD0", VA = "0x18729D3D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005BF")]
	private MMCKDFJKIGA PAOIDIJNOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005C0")]
	private GOLFJDFFGLD<string>.EFMHMOBJFGI MBHLFFACPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C1")]
	private FGAGHPALDNJ NCAFNAHMGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C2")]
	private bool CBKKANOAABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005C3")]
	private OOGIBKAOAMC LNCKNHNHHDF;

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x72975A0", Offset = "0x7295FA0", VA = "0x1872975A0")]
	public static Task<Scene> GLHOKBLFGIA(FGAGHPALDNJ NCAFNAHMGMF, MMCKDFJKIGA AHCJFEHDHMO, GOLFJDFFGLD<string>.EFMHMOBJFGI MBHLFFACPEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x7297650", Offset = "0x7296050", VA = "0x187297650")]
	[AsyncStateMachine(typeof(CEIJHIBIFDO))]
	private Task<Scene> KELODGGKPBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x7297620", Offset = "0x7296020", VA = "0x187297620")]
	private bool JIBDJPNBEJL(OOGIBKAOAMC LNCKNHNHHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x7297530", Offset = "0x7295F30", VA = "0x187297530")]
	private void BINMNJBPPFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x72973E0", Offset = "0x7295DE0", VA = "0x1872973E0")]
	[AsyncStateMachine(typeof(IJFEPKAGKJB))]
	private Task<Scene> BCLFNHEOHBI(string MIHEAIGNLHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal struct LENEIEDCGBB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private struct LHBAGPAKNJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public AsyncTaskMethodBuilder<MOLNENEPFJJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public LENEIEDCGBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public MOLNENEPFJJ nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public OOGIBKAOAMC deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		private TaskAwaiter<MOLNENEPFJJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x72A5610", Offset = "0x72A4010", VA = "0x1872A5610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x72A6110", Offset = "0x72A4B10", VA = "0x1872A6110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private struct MGLMCPLDAMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public AsyncTaskMethodBuilder<MOLNENEPFJJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public LENEIEDCGBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public MOLNENEPFJJ state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		private TaskAwaiter<CELGPAAAIIN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x72A72E0", Offset = "0x72A5CE0", VA = "0x1872A72E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x72A75C0", Offset = "0x72A5FC0", VA = "0x1872A75C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D0")]
	private readonly JHPBEIHBNBJ FEKPEBAIDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	private readonly NBEBJDKLKGB DCGJPHFKPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D2")]
	private readonly NENGJPGGJNJ IHJPFEAMHPP;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private IGIEMLKHNDA MEAMDPFBBBI
	{
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x5A03E80", Offset = "0x5A02880", VA = "0x185A03E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x72A4F90", Offset = "0x72A3990", VA = "0x1872A4F90")]
	public LENEIEDCGBB(JHPBEIHBNBJ FEKPEBAIDHP, NBEBJDKLKGB DCGJPHFKPFE, NENGJPGGJNJ IHJPFEAMHPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x72A4CB0", Offset = "0x72A36B0", VA = "0x1872A4CB0")]
	[AsyncStateMachine(typeof(LHBAGPAKNJJ))]
	public Task<MOLNENEPFJJ> LJDJBBBALFJ(MOLNENEPFJJ FKBDDBBEHMP, OOGIBKAOAMC AMPNJKNENLH, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH, bool PMCDHHINFIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x72A4E30", Offset = "0x72A3830", VA = "0x1872A4E30")]
	[AsyncStateMachine(typeof(MGLMCPLDAMB))]
	private Task<MOLNENEPFJJ> OFBMINJAFIF(GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, MOLNENEPFJJ PFFGBBPKGJN, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x72A4C60", Offset = "0x72A3660", VA = "0x1872A4C60")]
	private bool HDFFHPJKLEO(MOLNENEPFJJ FFNJPPFKFMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x72A4C90", Offset = "0x72A3690", VA = "0x1872A4C90")]
	private void LHPAJEFICIG(string MKCFHDDLJBE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000161")]
internal struct ODJGLCPCBJC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private struct CFPOOHPNENL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public IGIEMLKHNDA operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public OOGIBKAOAMC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public EOOMPLIHHFH timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private CJHBAICPELK <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		private List<(PersistenceView, OEAGPMFPCEL)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private (PersistenceView, OEAGPMFPCEL) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x72963A0", Offset = "0x7294DA0", VA = "0x1872963A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x72969F0", Offset = "0x72953F0", VA = "0x1872969F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x72AA0C0", Offset = "0x72A8AC0", VA = "0x1872AA0C0")]
	[AsyncStateMachine(typeof(CFPOOHPNENL))]
	public static Task KELODGGKPBN(IGIEMLKHNDA OBCNEKMKFFE, OOGIBKAOAMC LNCKNHNHHDF, EOOMPLIHHFH GFMMKKCCHBM, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000163")]
internal struct MJDDEFPLFBI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private struct IEKFCHEDNIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public IGIEMLKHNDA operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public OOGIBKAOAMC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public EOOMPLIHHFH timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		private OEONGJBPPJN <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		private CJHBAICPELK <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private List<(PersistenceView, OEAGPMFPCEL)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private OEAGPMFPCEL <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x729C640", Offset = "0x729B040", VA = "0x18729C640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x729CEF0", Offset = "0x729B8F0", VA = "0x18729CEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x72A7630", Offset = "0x72A6030", VA = "0x1872A7630")]
	[AsyncStateMachine(typeof(IEKFCHEDNIN))]
	public static Task KELODGGKPBN(IGIEMLKHNDA OBCNEKMKFFE, OOGIBKAOAMC LNCKNHNHHDF, EOOMPLIHHFH GFMMKKCCHBM, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
internal struct JAMMCECFHJK
{
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	public struct JBHOKCACPDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public List<NMCMBFFDKNP> IJBMBMKEOED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public List<OEAGPMFPCEL> FFBLDEBLDHD;

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0xCEC2C0", Offset = "0xCEACC0", VA = "0x180CEC2C0")]
		public JBHOKCACPDF(List<NMCMBFFDKNP> IJBMBMKEOED, List<OEAGPMFPCEL> FFBLDEBLDHD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private sealed class JFALFMLMAKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public IEnumerable<NMCMBFFDKNP> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public JFALFMLMAKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x729F6A0", Offset = "0x729E0A0", VA = "0x18729F6A0")]
		internal object FKEDCLFILIB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005FF")]
	private FGAGHPALDNJ NCAFNAHMGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000600")]
	private OOGIBKAOAMC LNCKNHNHHDF;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private CIFFNCDBMGE FJMIEGHLOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x729EF50", Offset = "0x729D950", VA = "0x18729EF50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x729EEF0", Offset = "0x729D8F0", VA = "0x18729EEF0")]
	public static JBHOKCACPDF KELODGGKPBN(FGAGHPALDNJ NCAFNAHMGMF, OOGIBKAOAMC LNCKNHNHHDF)
	{
		return default(JBHOKCACPDF);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x729ECA0", Offset = "0x729D6A0", VA = "0x18729ECA0")]
	private JBHOKCACPDF KELODGGKPBN()
	{
		return default(JBHOKCACPDF);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x729E700", Offset = "0x729D100", VA = "0x18729E700")]
	private JBHOKCACPDF HGKIGLBEEFM(EGDKLHCLIKL FIAJEGMHHBJ, OEONGJBPPJN DBJLFEPCIKM)
	{
		return default(JBHOKCACPDF);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x729E530", Offset = "0x729CF30", VA = "0x18729E530")]
	private bool DNJJKBIDOEG(IEnumerable<NMCMBFFDKNP> IJBMBMKEOED)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000168")]
internal struct JLPCBKKFAOA
{
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private sealed class HHGGPHJBEBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public JAMMCECFHJK.JBHOKCACPDF instantiations;

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public HHGGPHJBEBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x729C520", Offset = "0x729AF20", VA = "0x18729C520")]
		internal object POEJGOIMCGI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private sealed class NIOEDJNFNLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public NIOEDJNFNLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x72A9630", Offset = "0x72A8030", VA = "0x1872A9630")]
		internal object CAFKBEOIEOK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x72A0310", Offset = "0x729ED10", VA = "0x1872A0310")]
	public static void KELODGGKPBN(IGIEMLKHNDA OBCNEKMKFFE, OOGIBKAOAMC LNCKNHNHHDF, JAMMCECFHJK.JBHOKCACPDF EFKAHPCDOGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
internal class NENGJPGGJNJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct ELHBOGJBMPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public NENGJPGGJNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public MOLNENEPFJJ operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public OOGIBKAOAMC deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x72995C0", Offset = "0x7297FC0", VA = "0x1872995C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x7299D30", Offset = "0x7298730", VA = "0x187299D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private sealed class BFLHKKOMFOO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016E")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000615")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000616")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000617")]
			public BFLHKKOMFOO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000618")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000619")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x72ABA30", Offset = "0x72AA430", VA = "0x1872ABA30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x72ABCF0", Offset = "0x72AA6F0", VA = "0x1872ABCF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public NENGJPGGJNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public OOGIBKAOAMC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public BFLHKKOMFOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x72940E0", Offset = "0x7292AE0", VA = "0x1872940E0")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task MEGCADKOGFH(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private struct LCFEABPJKOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public NENGJPGGJNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public OOGIBKAOAMC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		private BFLHKKOMFOO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x72A46D0", Offset = "0x72A30D0", VA = "0x1872A46D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x72A4C00", Offset = "0x72A3600", VA = "0x1872A4C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct ILOJPFDMKBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public NENGJPGGJNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public OOGIBKAOAMC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		private Dictionary<Guid, List<OAHEDLFPPFF>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x729D910", Offset = "0x729C310", VA = "0x18729D910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x729DF20", Offset = "0x729C920", VA = "0x18729DF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private struct JBDKNKBEMHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public NENGJPGGJNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public OOGIBKAOAMC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		private Dictionary<Guid, List<OAHEDLFPPFF>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x729EFA0", Offset = "0x729D9A0", VA = "0x18729EFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x729F640", Offset = "0x729E040", VA = "0x18729F640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private sealed class NOGAFCFFDLF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000173")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000639")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400063A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400063B")]
			public OAHEDLFPPFF handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400063C")]
			public NOGAFCFFDLF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400063D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005D9")]
			[Cpp2IlInjected.Address(RVA = "0x72AB830", Offset = "0x72AA230", VA = "0x1872AB830", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DA")]
			[Cpp2IlInjected.Address(RVA = "0x72AB9D0", Offset = "0x72AA3D0", VA = "0x1872AB9D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public CDBNCENGFBE runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public List<OAHEDLFPPFF> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public OOGIBKAOAMC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public NOGAFCFFDLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x72A96C0", Offset = "0x72A80C0", VA = "0x1872A96C0")]
		internal object JMACMFPIIAA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x72A98A0", Offset = "0x72A82A0", VA = "0x1872A98A0")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task KFLJCMMEIGH(OAHEDLFPPFF handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x72A97B0", Offset = "0x72A81B0", VA = "0x1872A97B0")]
		internal object JNNPDENDCMO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private struct LBJNLCHDPGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public CDBNCENGFBE runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public List<OAHEDLFPPFF> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public OOGIBKAOAMC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		private NOGAFCFFDLF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x72A41A0", Offset = "0x72A2BA0", VA = "0x1872A41A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x72A4670", Offset = "0x72A3070", VA = "0x1872A4670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private struct LEOGLPHLIKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public NENGJPGGJNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public OOGIBKAOAMC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x72A4FF0", Offset = "0x72A39F0", VA = "0x1872A4FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x72A55B0", Offset = "0x72A3FB0", VA = "0x1872A55B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private sealed class CJKIMDGBCGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public CJKIMDGBCGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x7296BA0", Offset = "0x72955A0", VA = "0x187296BA0")]
		internal object BPBPFADIEEI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private struct EGFDPFGPNMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public NENGJPGGJNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public OOGIBKAOAMC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		private CJHBAICPELK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x7298E30", Offset = "0x7297830", VA = "0x187298E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x72992F0", Offset = "0x7297CF0", VA = "0x1872992F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private sealed class OCPEHNGJGAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public OCPEHNGJGAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x72AA050", Offset = "0x72A8A50", VA = "0x1872AA050")]
		internal object ILJGANKBHJB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private struct GNFDBMOOECE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public NENGJPGGJNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private CJHBAICPELK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		private TaskAwaiter<CELGPAAAIIN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x729B640", Offset = "0x729A040", VA = "0x18729B640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x729BC70", Offset = "0x729A670", VA = "0x18729BC70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private sealed class CIFMGMNHDLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public CIFMGMNHDLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x7296B30", Offset = "0x7295530", VA = "0x187296B30")]
		internal object OFMHPIAIJJE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000607")]
	private readonly JHPBEIHBNBJ FEKPEBAIDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000608")]
	private OACAHPCPDFN IHJPFEAMHPP;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private IGIEMLKHNDA MEAMDPFBBBI
	{
		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0xB09E60", Offset = "0xB08860", VA = "0x180B09E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x8913E0", Offset = "0x88FDE0", VA = "0x1808913E0")]
	public NENGJPGGJNJ(JHPBEIHBNBJ FEKPEBAIDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x72A8ED0", Offset = "0x72A78D0", VA = "0x1872A8ED0")]
	[AsyncStateMachine(typeof(ELHBOGJBMPM))]
	public Task KELODGGKPBN(MOLNENEPFJJ MIIPACJPANO, OOGIBKAOAMC AMPNJKNENLH, GOLFJDFFGLD<string>.EFMHMOBJFGI MBHLFFACPEB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x72A8B40", Offset = "0x72A7540", VA = "0x1872A8B40")]
	[AsyncStateMachine(typeof(LCFEABPJKOF))]
	private Task HOLNEMKMGDN(OOGIBKAOAMC LNCKNHNHHDF, GOLFJDFFGLD<string>.EFMHMOBJFGI MBHLFFACPEB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x72A8A00", Offset = "0x72A7400", VA = "0x1872A8A00")]
	[AsyncStateMachine(typeof(ILOJPFDMKBA))]
	private Task HMPFAKOBDMB(OOGIBKAOAMC LNCKNHNHHDF, GOLFJDFFGLD<string>.EFMHMOBJFGI MBHLFFACPEB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x72A8D90", Offset = "0x72A7790", VA = "0x1872A8D90")]
	[AsyncStateMachine(typeof(JBDKNKBEMHH))]
	private Task JNKLCALDHMO(OOGIBKAOAMC LNCKNHNHHDF, GOLFJDFFGLD<string>.EFMHMOBJFGI MBHLFFACPEB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x72A9260", Offset = "0x72A7C60", VA = "0x1872A9260")]
	[AsyncStateMachine(typeof(LBJNLCHDPGG))]
	private Task NIJCKHAMHKN(Guid KJAAIJMIPCF, List<OAHEDLFPPFF> PJOHIKIEODC, CDBNCENGFBE JOONFHBGNDD, OOGIBKAOAMC LNCKNHNHHDF, CancellationToken OEELDHBFFAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x72A93B0", Offset = "0x72A7DB0", VA = "0x1872A93B0")]
	[AsyncStateMachine(typeof(LEOGLPHLIKE))]
	private Task OICMGPNCJGL(OOGIBKAOAMC LNCKNHNHHDF, GOLFJDFFGLD<string>.EFMHMOBJFGI MBHLFFACPEB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x72A94F0", Offset = "0x72A7EF0", VA = "0x1872A94F0")]
	[AsyncStateMachine(typeof(EGFDPFGPNMO))]
	private Task OJBNMIEMNJD(Guid INGBHPCPMNP, OOGIBKAOAMC LNCKNHNHHDF, GOLFJDFFGLD<string>.EFMHMOBJFGI MBHLFFACPEB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x72A88C0", Offset = "0x72A72C0", VA = "0x1872A88C0")]
	[AsyncStateMachine(typeof(GNFDBMOOECE))]
	private Task FLLCJMAMIKG(Guid INGBHPCPMNP, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x72A8C80", Offset = "0x72A7680", VA = "0x1872A8C80")]
	private void JLPPJPDBKPB(Guid INGBHPCPMNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x72A9020", Offset = "0x72A7A20", VA = "0x1872A9020")]
	private void MBJMMOEENBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x72A90D0", Offset = "0x72A7AD0", VA = "0x1872A90D0")]
	public Guid MEIAPFILLIG(MOLNENEPFJJ IFGGMOHGJIG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x72A86F0", Offset = "0x72A70F0", VA = "0x1872A86F0")]
	[CompilerGenerated]
	private object ECMDJDNPFOL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
internal struct HHFFMNIOMLC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private struct BJIGECJKJHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public HHFFMNIOMLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		private IEnumerator<LFFEIIPBOIA> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x7294510", Offset = "0x7292F10", VA = "0x187294510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x7294C10", Offset = "0x7293610", VA = "0x187294C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000665")]
	private CIFFNCDBMGE HILLMDJLLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000666")]
	private GOLFJDFFGLD<string>.EFMHMOBJFGI MBHLFFACPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000667")]
	private CancellationToken LOIOCMLGMKH;

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x729C3C0", Offset = "0x729ADC0", VA = "0x18729C3C0")]
	public static Task FPPMCDAOLBI(CIFFNCDBMGE HILLMDJLLHN, GOLFJDFFGLD<string>.EFMHMOBJFGI MBHLFFACPEB, CancellationToken IJOHDFFMBCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x729C430", Offset = "0x729AE30", VA = "0x18729C430")]
	[AsyncStateMachine(typeof(BJIGECJKJHE))]
	private Task KELODGGKPBN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
public readonly struct IHKLNMNONHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066E")]
	public readonly bool PEAHKFPDKIJ;

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x2300B30", Offset = "0x22FF530", VA = "0x182300B30")]
	public IHKLNMNONHG(bool FGMCGIAPANP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
public readonly struct FNKDHFNCDJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066F")]
	public readonly EGDKLHCLIKL? IJCKMNNJMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000670")]
	public readonly MFEIMCNAPBK LPEFBKCCPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000671")]
	public readonly string? HFGMKFLDDAN;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public IReadOnlyCollection<string> LKOGCIJNCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x729AD40", Offset = "0x7299740", VA = "0x18729AD40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public IReadOnlyDictionary<long, int> IGJCOAABCMI
	{
		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x729AD20", Offset = "0x7299720", VA = "0x18729AD20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x729AD60", Offset = "0x7299760", VA = "0x18729AD60")]
	public FNKDHFNCDJH(EGDKLHCLIKL? HCKNFILJEND, MFEIMCNAPBK KMMAFNKLMBC, string? CGCFDFNPJNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal class BKADMLOCICM : EDDFFAEACND
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct FILHDNCNFAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public AsyncTaskMethodBuilder<FNKDHFNCDJH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public BKADMLOCICM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public HFFOHGGNEID serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public CHIDMAEAKIM roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		private CJHBAICPELK <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x729A630", Offset = "0x7299030", VA = "0x18729A630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x729ACB0", Offset = "0x72996B0", VA = "0x18729ACB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private sealed class DFMGKJDINBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		public HFFOHGGNEID serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		public BKADMLOCICM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public DFMGKJDINBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x7297850", Offset = "0x7296250", VA = "0x187297850")]
		internal Task IOBIMJMIHJE(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x7297770", Offset = "0x7296170", VA = "0x187297770")]
		internal Task FHIIIOIOBIF(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private sealed class HOKLLLNBONM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		public DFMGKJDINBL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public HOKLLLNBONM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x729C5D0", Offset = "0x729AFD0", VA = "0x18729C5D0")]
		internal object MLJKJOOPFJI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private sealed class LPBOCKJPBDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public DFMGKJDINBL CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public LPBOCKJPBDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x72A6610", Offset = "0x72A5010", VA = "0x1872A6610")]
		internal Task BHPLOPKFADC(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	private struct ABPPFNKJDCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		public HFFOHGGNEID serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public BKADMLOCICM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		private HOKLLLNBONM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		private CJHBAICPELK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x7292E50", Offset = "0x7291850", VA = "0x187292E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x72936B0", Offset = "0x72920B0", VA = "0x1872936B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000672")]
	private readonly CAFGMNLACIN FEMNEHJOJBN;

	[Cpp2IlInjected.Token(Token = "0x4000673")]
	private static readonly TimeSpan CIDFDAFLPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000674")]
	private readonly DDGEJEKFGOA AKCPOJMENDM;

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x7295D70", Offset = "0x7294770", VA = "0x187295D70")]
	public BKADMLOCICM(JHPBEIHBNBJ FEKPEBAIDHP, DDGEJEKFGOA AKCPOJMENDM, CAFGMNLACIN FEMNEHJOJBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x7294C70", Offset = "0x7293670", VA = "0x187294C70")]
	[AsyncStateMachine(typeof(FILHDNCNFAN))]
	public Task<FNKDHFNCDJH> BBLOJHGNHMB(long NMDIIDEMCDI, CHIDMAEAKIM BEFFGCNODKD, HFFOHGGNEID MHHOLLPCDIN, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x7295BC0", Offset = "0x72945C0", VA = "0x187295BC0")]
	[AsyncStateMachine(typeof(ABPPFNKJDCK))]
	private Task NBGGCJFPHNB(HFFOHGGNEID MHHOLLPCDIN, IEnumerable<PersistenceView> BICMIAAIGKE, StringBuilder LDFCMLLMJHH, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x7295600", Offset = "0x7294000", VA = "0x187295600")]
	private FNKDHFNCDJH LAKILLBHNFP(long NMDIIDEMCDI, CHIDMAEAKIM BEFFGCNODKD, HFFOHGGNEID MHHOLLPCDIN, IEnumerable<PersistenceView> BICMIAAIGKE, StringBuilder LDFCMLLMJHH)
	{
		return default(FNKDHFNCDJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x72954B0", Offset = "0x7293EB0", VA = "0x1872954B0")]
	private EGDKLHCLIKL JCIBOEICCPM(long NMDIIDEMCDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0x7295260", Offset = "0x7293C60", VA = "0x187295260")]
	private void HMOGADGLMCM(EGDKLHCLIKL HHPGIHNIGBN, StringBuilder LDFCMLLMJHH, IEnumerable<PersistenceView> BICMIAAIGKE, [In] GOHCPCCLBBP MHAHKDLDBBM, BLHBGBALGGJ JOABFILHDFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x7294DD0", Offset = "0x72937D0", VA = "0x187294DD0")]
	private void GLCKKMHGBIP(EGDKLHCLIKL HHPGIHNIGBN, StringBuilder LDFCMLLMJHH, PersistenceView BDGJAKFBCKL, BLHBGBALGGJ JOABFILHDFE, [In] GOHCPCCLBBP MHAHKDLDBBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
internal class OOHOLKEKFNH : EDDFFAEACND
{
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	private sealed class FEJIEJHPOOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public IKOFLNOKKHP.ICKENEBJDOH roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public FEJIEJHPOOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x7299D90", Offset = "0x7298790", VA = "0x187299D90")]
		internal object EBAMFPMOPIP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private struct AGEFOINKEPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		public AsyncTaskMethodBuilder<(IKOFLNOKKHP.ICKENEBJDOH roomDataUpload, IKOFLNOKKHP.ICKENEBJDOH subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		public FNKDHFNCDJH roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		public OOHOLKEKFNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		private FEJIEJHPOOM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		private TaskAwaiter<IKOFLNOKKHP.ICKENEBJDOH> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x7293710", Offset = "0x7292110", VA = "0x187293710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x7293F60", Offset = "0x7292960", VA = "0x187293F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private struct LPHIFGNGMHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public AsyncTaskMethodBuilder<ANLPGLHMEBJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public OOHOLKEKFNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		public FNKDHFNCDJH roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public BFKIDDCLOKK roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		private TaskAwaiter<(IKOFLNOKKHP.ICKENEBJDOH roomDataUpload, IKOFLNOKKHP.ICKENEBJDOH subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		private TaskAwaiter<ANLPGLHMEBJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x72A6BE0", Offset = "0x72A55E0", VA = "0x1872A6BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x72A7270", Offset = "0x72A5C70", VA = "0x1872A7270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[CompilerGenerated]
	private struct IOJDCLKHNDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public AsyncTaskMethodBuilder<OGEJFLLGHCE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public OOHOLKEKFNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public FNKDHFNCDJH roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		private TaskAwaiter<(IKOFLNOKKHP.ICKENEBJDOH roomDataUpload, IKOFLNOKKHP.ICKENEBJDOH subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		private TaskAwaiter<OGEJFLLGHCE> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x729DF80", Offset = "0x729C980", VA = "0x18729DF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x729E390", Offset = "0x729CD90", VA = "0x18729E390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private sealed class JAGMKAFKKCG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200018D")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006C0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006C1")]
			public AsyncTaskMethodBuilder<CELGPAAAIIN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006C2")]
			public JAGMKAFKKCG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006C3")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006C4")]
			private CELGPAAAIIN <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006C5")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006C6")]
			private TaskAwaiter<OGEJFLLGHCE> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006C7")]
			private TaskAwaiter<ANLPGLHMEBJ> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006C8")]
			private TaskAwaiter<CELGPAAAIIN> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x600061E")]
			[Cpp2IlInjected.Address(RVA = "0x72AC140", Offset = "0x72AAB40", VA = "0x1872AC140", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061F")]
			[Cpp2IlInjected.Address(RVA = "0x72AD0C0", Offset = "0x72ABAC0", VA = "0x1872AD0C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public OOHOLKEKFNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		public FNKDHFNCDJH roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		public BFKIDDCLOKK roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public IHKLNMNONHG roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public JAGMKAFKKCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x729E400", Offset = "0x729CE00", VA = "0x18729E400")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<CELGPAAAIIN> NBCBNEJJPJM(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[CompilerGenerated]
	private struct ILHIJMOJMMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		public AsyncTaskMethodBuilder<CELGPAAAIIN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		public OOHOLKEKFNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		public FNKDHFNCDJH roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public BFKIDDCLOKK roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public IHKLNMNONHG roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		private TaskAwaiter<CELGPAAAIIN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x729D590", Offset = "0x729BF90", VA = "0x18729D590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x729D8A0", Offset = "0x729C2A0", VA = "0x18729D8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000697")]
	private static readonly CAFGMNLACIN FEMNEHJOJBN;

	[Cpp2IlInjected.Token(Token = "0x4000698")]
	private static readonly CAFGMNLACIN ECGJLAPELMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000699")]
	private readonly ENDPBOLMIGD LGPIAOPCNDD;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	private FGAGHPALDNJ DPCMCCOLGJA
	{
		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x7280FA0", Offset = "0x727F9A0", VA = "0x187280FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x72AACD0", Offset = "0x72A96D0", VA = "0x1872AACD0")]
	public OOHOLKEKFNH(JHPBEIHBNBJ FEKPEBAIDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x72AA820", Offset = "0x72A9220", VA = "0x1872AA820")]
	[AsyncStateMachine(typeof(AGEFOINKEPJ))]
	private Task<(IKOFLNOKKHP.ICKENEBJDOH, IKOFLNOKKHP.ICKENEBJDOH)> NKOFGDLJNJD(FNKDHFNCDJH HBCKKFNCFAB, long MOEKPKHCJHD, long OAOCFKDGHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x72AA960", Offset = "0x72A9360", VA = "0x1872AA960")]
	[AsyncStateMachine(typeof(LPHIFGNGMHO))]
	public Task<ANLPGLHMEBJ> OODKCDPJBAB(int PPGFEIKKFKK, [CanBeNull] BFKIDDCLOKK CNLLIFFAFAG, FNKDHFNCDJH HBCKKFNCFAB, long MOEKPKHCJHD, long OAOCFKDGHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x72AAAD0", Offset = "0x72A94D0", VA = "0x1872AAAD0")]
	[AsyncStateMachine(typeof(IOJDCLKHNDN))]
	private Task<OGEJFLLGHCE> PMNOGCJEJAI(string IJGMHBOCGFJ, int PPGFEIKKFKK, FNKDHFNCDJH HBCKKFNCFAB, long MOEKPKHCJHD, long OAOCFKDGHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x72AA680", Offset = "0x72A9080", VA = "0x1872AA680")]
	[AsyncStateMachine(typeof(ILHIJMOJMMA))]
	public Task<CELGPAAAIIN> IBFMFKHJMIA(int PPGFEIKKFKK, BFKIDDCLOKK? CNLLIFFAFAG, FNKDHFNCDJH HBCKKFNCFAB, long MOEKPKHCJHD, long OAOCFKDGHFI, IHKLNMNONHG OEBMIFFJLCC, GOLFJDFFGLD<string>.EFMHMOBJFGI JMMBBOLJGHB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
public abstract class LAOBIJPPJAI<T> where T : LAOBIJPPJAI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D5")]
	internal readonly FGAGHPALDNJ EFOJOLICMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D6")]
	private int? LFGKLELCCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D7")]
	protected readonly Guid NMADGHJLOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D8")]
	protected readonly IBPIJMAGBAA GNEHOJLIBEF;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	protected T HJKPHHGCPCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x4471A50", Offset = "0x4470450", VA = "0x184471A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x4471AB0", Offset = "0x44704B0", VA = "0x184471AB0")]
	internal LAOBIJPPJAI(FGAGHPALDNJ DAKEBPKBGGE, IBPIJMAGBAA POBPINKCPGH, [Optional] Guid? OOCNLFNKKML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x4471700", Offset = "0x4470100", VA = "0x184471700")]
	private CELGPAAAIIN APJNEOLLDJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "4")]
	protected virtual void KKIFBFMHBNP(CELGPAAAIIN BBDGOIMNDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x44717E0", Offset = "0x44701E0", VA = "0x1844717E0")]
	public T HOLMFJCAIAN(ICGGIJDMFMC JDGFBJBABBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x4471880", Offset = "0x4470280", VA = "0x184471880")]
	public T ICFJGCFIJKL(int OPDMOOIEGLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x4471920", Offset = "0x4470320", VA = "0x184471920", Slot = "5")]
	public virtual Task<AKHLLPJOLIM> IEGGEFCPJJN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
public class DEDBOOPDHDF : LAOBIJPPJAI<DEDBOOPDHDF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006D9")]
	private IMNJOLLKFEM HDOCILHNNDE;

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x7297310", Offset = "0x7295D10", VA = "0x187297310")]
	internal DEDBOOPDHDF(FGAGHPALDNJ DAKEBPKBGGE, IBPIJMAGBAA POBPINKCPGH, [Optional] Guid? OOCNLFNKKML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x67ADD50", Offset = "0x67AC750", VA = "0x1867ADD50")]
	public DEDBOOPDHDF LBGMPJLAHLL(IMNJOLLKFEM HDOCILHNNDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x7297240", Offset = "0x7295C40", VA = "0x187297240", Slot = "4")]
	protected override void KKIFBFMHBNP(CELGPAAAIIN BBDGOIMNDJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
public class KGNIFDDMKKJ : LAOBIJPPJAI<KGNIFDDMKKJ>
{
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	internal enum BOLPMFJIOOB
	{
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private struct ECDPHOGCFJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		public AsyncTaskMethodBuilder<AKHLLPJOLIM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		public KGNIFDDMKKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		private TaskAwaiter<AKHLLPJOLIM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x7297F00", Offset = "0x7296900", VA = "0x187297F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x72982A0", Offset = "0x7296CA0", VA = "0x1872982A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006DA")]
	private BOLPMFJIOOB CKFKHFHOHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	private string EAIFIOENDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006DC")]
	private BFKIDDCLOKK HDOCILHNNDE;

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x72A1720", Offset = "0x72A0120", VA = "0x1872A1720")]
	internal KGNIFDDMKKJ(FGAGHPALDNJ DAKEBPKBGGE, IBPIJMAGBAA POBPINKCPGH, [Optional] Guid? OOCNLFNKKML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x72A16D0", Offset = "0x72A00D0", VA = "0x1872A16D0")]
	public KGNIFDDMKKJ LKOFDPDFMJH(string MAAJPCIONKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x72A1700", Offset = "0x72A0100", VA = "0x1872A1700")]
	public KGNIFDDMKKJ NKGBLGFELFG(bool EIOIPGMNOBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x72A1400", Offset = "0x729FE00", VA = "0x1872A1400")]
	public KGNIFDDMKKJ ACOEPLLKNDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x72A1560", Offset = "0x729FF60", VA = "0x1872A1560", Slot = "4")]
	protected override void KKIFBFMHBNP(CELGPAAAIIN BBDGOIMNDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x72A1430", Offset = "0x729FE30", VA = "0x1872A1430", Slot = "5")]
	[AsyncStateMachine(typeof(ECDPHOGCFJH))]
	public override Task<AKHLLPJOLIM> IEGGEFCPJJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x72A1520", Offset = "0x729FF20", VA = "0x1872A1520")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<AKHLLPJOLIM> KAPLJNBMAGM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
internal static class KIHLHMECGOG
{
	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x72A22C0", Offset = "0x72A0CC0", VA = "0x1872A22C0")]
	public static void BGEAMLINMNM(this HCKKKMLKBME FLLDEEENGFJ, FLFGKHCBJJD BCAAIJFNEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x72A2410", Offset = "0x72A0E10", VA = "0x1872A2410")]
	public static void CHPNKONKEKL(this FLFGKHCBJJD GDEDPAAODIE, [Optional] string BBDGOIMNDJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
public static class IKMEKJGDBOE
{
	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x729D4F0", Offset = "0x729BEF0", VA = "0x18729D4F0")]
	public static LGAFJFEBDLI BOCKHBFMDKL(this MGABNKIFIAL GOLGLPCFHCI)
	{
		return default(LGAFJFEBDLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x729D440", Offset = "0x729BE40", VA = "0x18729D440")]
	public static MGABNKIFIAL BDACHNJHIAG(this LGAFJFEBDLI BLDHFLIEJOI)
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
			[Cpp2IlInjected.Token(Token = "0x40006E9")]
			public CGOGNJKHKDK ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006EA")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006EB")]
			public CGOGNJKHKDK HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006EC")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006ED")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006EE")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x600063F")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		private static CGOGNJKHKDK[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		private Dictionary<CGOGNJKHKDK, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x72AD610", Offset = "0x72AC010", VA = "0x1872AD610")]
		public bool ACHNCABPFDI(CGOGNJKHKDK JLNBNGDGFJH, [Out] ResultConfig EILKMNJGOBA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x72ADD90", Offset = "0x72AC790", VA = "0x1872ADD90")]
		public ResultConfig PNHHIKOFGLJ(CGOGNJKHKDK NOJDLJBPIDL, [Optional] HashSet<CGOGNJKHKDK> ILJKNOKKGIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x72ADBB0", Offset = "0x72AC5B0", VA = "0x1872ADBB0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x72AD680", Offset = "0x72AC080", VA = "0x1872AD680", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x994550", Offset = "0x992F50", VA = "0x180994550")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
public class GDFEECLLKON : FNAGFEIMDPL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private struct OIAEBJFILPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		public GDFEECLLKON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x72B34E0", Offset = "0x72B1EE0", VA = "0x1872B34E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x72B3670", Offset = "0x72B2070", VA = "0x1872B3670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private struct HFFMGFLBBBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		public GOLFJDFFGLD<string>.EFMHMOBJFGI timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		public FNAGFEIMDPL preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		private GOLFJDFFGLD<string>.EFMHMOBJFGI <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x72B0740", Offset = "0x72AF140", VA = "0x1872B0740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x72B0C60", Offset = "0x72AF660", VA = "0x1872B0C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006F4")]
	private readonly EAGEAGJPIIL COFNLCAGJGH;

	[Cpp2IlInjected.Token(Token = "0x40006F5")]
	private static readonly CAFGMNLACIN FEMNEHJOJBN;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public string IJIFOGBNCIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x729AE60", Offset = "0x7299860", VA = "0x18729AE60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x729AE90", Offset = "0x7299890", VA = "0x18729AE90")]
	[MDINNNLEANF.FIHKBCJDGBK.GBDNBGLLJBG]
	internal static void FACEOGGPDCB(FNNNJBMCDDC FOKBFKHGDKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x8913E0", Offset = "0x88FDE0", VA = "0x1808913E0")]
	[RecRoom.NoEngine.Common.Preserve]
	public GDFEECLLKON([LKKACOOMNBP(null)] EAGEAGJPIIL COFNLCAGJGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x729B0B0", Offset = "0x7299AB0", VA = "0x18729B0B0", Slot = "5")]
	[AsyncStateMachine(typeof(OIAEBJFILPB))]
	public Task KELODGGKPBN(GOLFJDFFGLD<string>.EFMHMOBJFGI ANBADFODAKB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x729AF90", Offset = "0x7299990", VA = "0x18729AF90")]
	[AsyncStateMachine(typeof(HFFMGFLBBBE))]
	private Task GFFNJJKDCGI(FNAGFEIMDPL JBONBGBOHBI, GOLFJDFFGLD<string>.EFMHMOBJFGI ANBADFODAKB, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
public interface EAGEAGJPIIL : FNAGFEIMDPL
{
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
public interface FNAGFEIMDPL
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	string IJIFOGBNCIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KELODGGKPBN(GOLFJDFFGLD<string>.EFMHMOBJFGI ANBADFODAKB, CancellationToken LOIOCMLGMKH);
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
public static class HMOEDPGDMGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x72B0CC0", Offset = "0x72AF6C0", VA = "0x1872B0CC0")]
	[MDINNNLEANF.FIHKBCJDGBK.GBDNBGLLJBG]
	internal static void CNFNMOPOGFM(FNNNJBMCDDC FOKBFKHGDKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
public interface BKKMLGPDFKC : IEquatable<BKKMLGPDFKC>
{
	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	DateTime JAELIBLNHPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HHLIAOFHGLC();

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ANIELNCBAJM(long MOEKPKHCJHD, long NMDIIDEMCDI, [Out] FNKDHFNCDJH HBCKKFNCFAB);
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
internal class DDPOIOEHEAI : ENAGKPAGHJH
{
	[Cpp2IlInjected.Token(Token = "0x20001A1")]
	[CompilerGenerated]
	private sealed class OPNKEKGLAJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public IHMNJEAIAGN autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public OPNKEKGLAJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x72B36D0", Offset = "0x72B20D0", VA = "0x1872B36D0")]
		internal object ECHEOFCNLEC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000703")]
	private readonly MIJAGLOHIOK LFHMEHAFGKJ;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<BKKMLGPDFKC> PMGNKHJHKOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x72AF730", Offset = "0x72AE130", VA = "0x1872AF730", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x72AF510", Offset = "0x72ADF10", VA = "0x1872AF510", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x8913E0", Offset = "0x88FDE0", VA = "0x1808913E0")]
	[UnityEngine.Scripting.Preserve]
	public DDPOIOEHEAI([LKKACOOMNBP(null)] MIJAGLOHIOK LFHMEHAFGKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x72AEE10", Offset = "0x72AD810", VA = "0x1872AEE10", Slot = "6")]
	public bool FNPOEMPEJPN(long MOEKPKHCJHD, long NMDIIDEMCDI, FNKDHFNCDJH HBCKKFNCFAB, IHMNJEAIAGN PHAIKKCIPMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x1FB44D0", Offset = "0x1FB2ED0", VA = "0x181FB44D0")]
	private void IOOCEJOJOJI(BKKMLGPDFKC FMBLDCCMMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x72AF5C0", Offset = "0x72ADFC0", VA = "0x1872AF5C0", Slot = "7")]
	public bool PFNCHOMMFJJ(long MOEKPKHCJHD, long NMDIIDEMCDI, [Out] BKKMLGPDFKC HEOEEINJPBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x72AED60", Offset = "0x72AD760", VA = "0x1872AED60", Slot = "8")]
	public bool CKJCDLFMGLD(long MOEKPKHCJHD, long NMDIIDEMCDI, IHMNJEAIAGN PHAIKKCIPMC, [Out] BKKMLGPDFKC HEOEEINJPBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x72AF0F0", Offset = "0x72ADAF0", VA = "0x1872AF0F0")]
	private void GNOCEBBFDIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x72AEC40", Offset = "0x72AD640", VA = "0x1872AEC40", Slot = "9")]
	public void AHAAMGPOHEP(long MOEKPKHCJHD, long NMDIIDEMCDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
internal abstract class EEGJNFOGKPL : MIJAGLOHIOK
{
	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	protected enum KAGIMBGBMAI : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[CompilerGenerated]
	private sealed class JIDBEMCOIAP : IEnumerable<BKKMLGPDFKC>, IEnumerable, IEnumerator<BKKMLGPDFKC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		private BKKMLGPDFKC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		public EEGJNFOGKPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		private IHMNJEAIAGN autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		public IHMNJEAIAGN <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		private BKKMLGPDFKC System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000674")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000676")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x976660", Offset = "0x975060", VA = "0x180976660")]
		[DebuggerHidden]
		public JIDBEMCOIAP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x72B1980", Offset = "0x72B0380", VA = "0x1872B1980", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x72B1C60", Offset = "0x72B0660", VA = "0x1872B1C60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x72B1BB0", Offset = "0x72B05B0", VA = "0x1872B1BB0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BKKMLGPDFKC> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x72B1BB0", Offset = "0x72B05B0", VA = "0x1872B1BB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	[CompilerGenerated]
	private sealed class BBMHGAOLOJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		public IHMNJEAIAGN autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public BBMHGAOLOJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x72AEBA0", Offset = "0x72AD5A0", VA = "0x1872AEBA0")]
		internal object JGKBBIJAKGG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[CompilerGenerated]
	private sealed class PLIGBADLLMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		public EEGJNFOGKPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public PLIGBADLLMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x72B3740", Offset = "0x72B2140", VA = "0x1872B3740")]
		internal void CGFNGHJEOAD(NJBELKLAGJD.PFFCJCMEFNJ ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000709")]
	private readonly object EKEECHHHLGC;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	protected string APOIPPPOIEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x72AF7E0", Offset = "0x72AE1E0", VA = "0x1872AF7E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public abstract BFOPHKKMPJF GFKEMDCNHEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x72B0200", Offset = "0x72AEC00", VA = "0x1872B0200")]
	protected EEGJNFOGKPL([CanBeNull] string GNJNIBNFCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x72AFBF0", Offset = "0x72AE5F0", VA = "0x1872AFBF0", Slot = "5")]
	public bool KIBPJLOOAPE(long MOEKPKHCJHD, long NMDIIDEMCDI, IHMNJEAIAGN PHAIKKCIPMC, [Out] BKKMLGPDFKC FMBLDCCMMOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x72AF7F0", Offset = "0x72AE1F0", VA = "0x1872AF7F0", Slot = "6")]
	[IteratorStateMachine(typeof(JIDBEMCOIAP))]
	public IEnumerable<BKKMLGPDFKC> EAFEGPIIEIP(IHMNJEAIAGN PHAIKKCIPMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void HCEKKMCNAHI(Stream OJEGKLIIPBM, long MOEKPKHCJHD, long NMDIIDEMCDI, FNKDHFNCDJH HBCKKFNCFAB);

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool CGIHLILGLBJ(Stream JMGPCOMBGJF, long MOEKPKHCJHD, long NMDIIDEMCDI, BDKAIFNKBKB MIFDECKIMJM, [Out] FNKDHFNCDJH HBCKKFNCFAB);

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x72AF880", Offset = "0x72AE280", VA = "0x1872AF880", Slot = "7")]
	public BKKMLGPDFKC EGFHLJEIECB(long MOEKPKHCJHD, long NMDIIDEMCDI, FNKDHFNCDJH HBCKKFNCFAB, IHMNJEAIAGN PHAIKKCIPMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo IKFCFLBKKPH(long MOEKPKHCJHD, long NMDIIDEMCDI, IHMNJEAIAGN PHAIKKCIPMC, KAGIMBGBMAI JICNPDPGGJL);

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo FBNEDIFGIEC(IHMNJEAIAGN PHAIKKCIPMC, KAGIMBGBMAI JICNPDPGGJL);

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x72B0190", Offset = "0x72AEB90", VA = "0x1872B0190")]
	protected void PCBBKJGBMHO(NJBELKLAGJD.PFFCJCMEFNJ CNHJGNDHKHG, string MKCFHDDLJBE, FileInfo AEFBODKJJHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x72AFDE0", Offset = "0x72AE7E0", VA = "0x1872AFDE0")]
	internal bool MBLKFKIFPJM(FileInfo BKLHPLNNKJM, long MOEKPKHCJHD, long NMDIIDEMCDI, [Out] FNKDHFNCDJH HBCKKFNCFAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	private void CCHBFHGGKBM(Exception DGKPIJKBMCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
internal class ABFNAEEGOJD : EEGJNFOGKPL
{
	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public override BFOPHKKMPJF GFKEMDCNHEI
	{
		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x15C2170", Offset = "0x15C0B70", VA = "0x1815C2170", Slot = "8")]
		get
		{
			return default(BFOPHKKMPJF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(RVA = "0x72AEB60", Offset = "0x72AD560", VA = "0x1872AEB60")]
	public ABFNAEEGOJD([Optional] string GNJNIBNFCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x72AEAE0", Offset = "0x72AD4E0", VA = "0x1872AEAE0")]
	private void IPDPHEFPIMP(IHMNJEAIAGN PHAIKKCIPMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0x72AE760", Offset = "0x72AD160", VA = "0x1872AE760", Slot = "9")]
	internal override void HCEKKMCNAHI(Stream OJEGKLIIPBM, long MOEKPKHCJHD, long NMDIIDEMCDI, FNKDHFNCDJH HBCKKFNCFAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(RVA = "0x72AE070", Offset = "0x72ACA70", VA = "0x1872AE070", Slot = "10")]
	internal override bool CGIHLILGLBJ(Stream JMGPCOMBGJF, long MOEKPKHCJHD, long NMDIIDEMCDI, BDKAIFNKBKB MIFDECKIMJM, [Out] FNKDHFNCDJH HBCKKFNCFAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x72AE9F0", Offset = "0x72AD3F0", VA = "0x1872AE9F0", Slot = "11")]
	protected override FileInfo IKFCFLBKKPH(long MOEKPKHCJHD, long NMDIIDEMCDI, IHMNJEAIAGN PHAIKKCIPMC, KAGIMBGBMAI JICNPDPGGJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x72AE660", Offset = "0x72AD060", VA = "0x1872AE660", Slot = "12")]
	protected override DirectoryInfo FBNEDIFGIEC(IHMNJEAIAGN PHAIKKCIPMC, KAGIMBGBMAI JICNPDPGGJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
internal sealed class ODPKNHIFNDB : EEGJNFOGKPL
{
	[Cpp2IlInjected.Token(Token = "0x4000719")]
	private static readonly byte[] COMNIKKFEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400071A")]
	private readonly byte[] OBIHNFMDMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400071B")]
	private readonly byte[] MDFFKKILKBL;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public override BFOPHKKMPJF GFKEMDCNHEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x603D6E0", Offset = "0x603C0E0", VA = "0x18603D6E0", Slot = "8")]
		get
		{
			return default(BFOPHKKMPJF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x72B33F0", Offset = "0x72B1DF0", VA = "0x1872B33F0")]
	public ODPKNHIFNDB([Optional] string GNJNIBNFCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x72B2EC0", Offset = "0x72B18C0", VA = "0x1872B2EC0", Slot = "9")]
	internal override void HCEKKMCNAHI(Stream OJEGKLIIPBM, long MOEKPKHCJHD, long NMDIIDEMCDI, FNKDHFNCDJH HBCKKFNCFAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x72B25D0", Offset = "0x72B0FD0", VA = "0x1872B25D0", Slot = "10")]
	internal override bool CGIHLILGLBJ(Stream JMGPCOMBGJF, long MOEKPKHCJHD, long NMDIIDEMCDI, BDKAIFNKBKB MIFDECKIMJM, [Out] FNKDHFNCDJH HBCKKFNCFAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x72B32A0", Offset = "0x72B1CA0", VA = "0x1872B32A0")]
	private void LMKFDIEFLOF(byte[] MGCOGNAKONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x72B3170", Offset = "0x72B1B70", VA = "0x1872B3170", Slot = "11")]
	protected override FileInfo IKFCFLBKKPH(long MOEKPKHCJHD, long NMDIIDEMCDI, IHMNJEAIAGN PHAIKKCIPMC, KAGIMBGBMAI JICNPDPGGJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x72B2DB0", Offset = "0x72B17B0", VA = "0x1872B2DB0", Slot = "12")]
	protected override DirectoryInfo FBNEDIFGIEC(IHMNJEAIAGN PHAIKKCIPMC, KAGIMBGBMAI JICNPDPGGJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AA")]
public enum BFOPHKKMPJF : byte
{
	[Cpp2IlInjected.Token(Token = "0x400071D")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x400071E")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x400071F")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
internal class IMBBLHDCMAM : MIJAGLOHIOK
{
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[CompilerGenerated]
	private sealed class HAEKGLAMEDB : IEnumerable<BKKMLGPDFKC>, IEnumerable, IEnumerator<BKKMLGPDFKC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000727")]
		private BKKMLGPDFKC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000728")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		public IMBBLHDCMAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400072A")]
		private IHMNJEAIAGN autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		public IHMNJEAIAGN <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		private BFOPHKKMPJF[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		private IEnumerator<BKKMLGPDFKC> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		private BKKMLGPDFKC System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600069B")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600069D")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x976660", Offset = "0x975060", VA = "0x180976660")]
		[DebuggerHidden]
		public HAEKGLAMEDB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x72B06B0", Offset = "0x72AF0B0", VA = "0x1872B06B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x72B02D0", Offset = "0x72AECD0", VA = "0x1872B02D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x72B0280", Offset = "0x72AEC80", VA = "0x1872B0280")]
		private void JDIKFIOLCDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x72B0660", Offset = "0x72AF060", VA = "0x1872B0660", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x72B05B0", Offset = "0x72AEFB0", VA = "0x1872B05B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BKKMLGPDFKC> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x72B05B0", Offset = "0x72AEFB0", VA = "0x1872B05B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000720")]
	private readonly BFOPHKKMPJF[] NHPIDMLLOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000721")]
	private readonly Dictionary<BFOPHKKMPJF, MIJAGLOHIOK> PADJOLJJPKN;

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public BFOPHKKMPJF GFKEMDCNHEI
	{
		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x72B10D0", Offset = "0x72AFAD0", VA = "0x1872B10D0", Slot = "4")]
		get
		{
			return default(BFOPHKKMPJF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x72B1650", Offset = "0x72B0050", VA = "0x1872B1650")]
	[UnityEngine.Scripting.Preserve]
	public IMBBLHDCMAM(params MIJAGLOHIOK[] GAANGBIGHOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x72B1500", Offset = "0x72AFF00", VA = "0x1872B1500", Slot = "5")]
	public bool KIBPJLOOAPE(long MOEKPKHCJHD, long NMDIIDEMCDI, IHMNJEAIAGN PHAIKKCIPMC, [Out] BKKMLGPDFKC FMBLDCCMMOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x72B12E0", Offset = "0x72AFCE0", VA = "0x1872B12E0")]
	private void JOJMCHCMNKD(int JPGEHEOIEJO, long MOEKPKHCJHD, long NMDIIDEMCDI, IHMNJEAIAGN PHAIKKCIPMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x72B1100", Offset = "0x72AFB00", VA = "0x1872B1100", Slot = "6")]
	[IteratorStateMachine(typeof(HAEKGLAMEDB))]
	public IEnumerable<BKKMLGPDFKC> EAFEGPIIEIP(IHMNJEAIAGN PHAIKKCIPMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x72B1190", Offset = "0x72AFB90", VA = "0x1872B1190", Slot = "7")]
	public BKKMLGPDFKC EGFHLJEIECB(long MOEKPKHCJHD, long NMDIIDEMCDI, FNKDHFNCDJH HBCKKFNCFAB, IHMNJEAIAGN PHAIKKCIPMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
internal static class NHKNALGAEBA
{
	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(RVA = "0x72B2510", Offset = "0x72B0F10", VA = "0x1872B2510")]
	internal static byte[] MOBBBEDCHNF(byte[] MGCOGNAKONH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x72B2490", Offset = "0x72B0E90", VA = "0x1872B2490")]
	public static void GNPFIJPFBCC(Stream ECOBFOEFDNF, byte[] NIIGPDDOCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x72B22B0", Offset = "0x72B0CB0", VA = "0x1872B22B0")]
	public static bool DMOJFBJILJF(Stream ECOBFOEFDNF, long ODHPAAIHDCI, BDKAIFNKBKB ECDELHINCGF, [Out] byte[] HGFCFCCOJPG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AF")]
internal sealed class KDJEJPJEAEO : BKKMLGPDFKC, IEquatable<BKKMLGPDFKC>, IEquatable<KDJEJPJEAEO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400072F")]
	private readonly EEGJNFOGKPL IEJMEBKMNMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000730")]
	public readonly FileInfo IFGKHGDAMMO;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public BFOPHKKMPJF GFKEMDCNHEI
	{
		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x6C59240", Offset = "0x6C57C40", VA = "0x186C59240", Slot = "9")]
		get
		{
			return default(BFOPHKKMPJF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public DateTime JAELIBLNHPB
	{
		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x72B1CF0", Offset = "0x72B06F0", VA = "0x1872B1CF0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x72B21A0", Offset = "0x72B0BA0", VA = "0x1872B21A0")]
	public KDJEJPJEAEO(EEGJNFOGKPL OINBMAIKHAJ, FileInfo BKLHPLNNKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x72B20F0", Offset = "0x72B0AF0", VA = "0x1872B20F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x72B2030", Offset = "0x72B0A30", VA = "0x1872B2030", Slot = "5")]
	public void HHLIAOFHGLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x72B1CB0", Offset = "0x72B06B0", VA = "0x1872B1CB0", Slot = "6")]
	public bool ANIELNCBAJM(long MOEKPKHCJHD, long NMDIIDEMCDI, [Out] FNKDHFNCDJH HBCKKFNCFAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x72B1F30", Offset = "0x72B0930", VA = "0x1872B1F30", Slot = "7")]
	public bool Equals(BKKMLGPDFKC CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x72B1E70", Offset = "0x72B0870", VA = "0x1872B1E70", Slot = "8")]
	public bool Equals(KDJEJPJEAEO CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x72B1D80", Offset = "0x72B0780", VA = "0x1872B1D80", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x72B1FA0", Offset = "0x72B09A0", VA = "0x1872B1FA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public delegate void BDKAIFNKBKB(NJBELKLAGJD.PFFCJCMEFNJ NONIEKJFILK, string BBDGOIMNDJI);
[Cpp2IlInjected.Token(Token = "0x20001B1")]
internal interface MIJAGLOHIOK
{
	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	BFOPHKKMPJF GFKEMDCNHEI
	{
		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KIBPJLOOAPE(long MOEKPKHCJHD, long NMDIIDEMCDI, IHMNJEAIAGN PHAIKKCIPMC, [Out] BKKMLGPDFKC FMBLDCCMMOM);

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<BKKMLGPDFKC> EAFEGPIIEIP(IHMNJEAIAGN PHAIKKCIPMC);

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BKKMLGPDFKC EGFHLJEIECB(long MOEKPKHCJHD, long NMDIIDEMCDI, FNKDHFNCDJH HBCKKFNCFAB, IHMNJEAIAGN PHAIKKCIPMC);
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
