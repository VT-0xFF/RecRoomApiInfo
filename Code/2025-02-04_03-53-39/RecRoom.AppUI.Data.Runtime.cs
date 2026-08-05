using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.AppUI.Data;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;

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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x70A79F0", Offset = "0x70A67F0", VA = "0x1870A79F0")]
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
namespace _AssemblyRegistry.RecRoom_AppUI_Data_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x70AA870", Offset = "0x70A9670", VA = "0x1870AA870", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2408FF0", Offset = "0x2407DF0", VA = "0x182408FF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class LJGEBMKNJKM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct LACBNINAEIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<List<bool>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public List<KGAIHJLHFDH> roomSaves;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private FDOOICDKOMB <roomsClient>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private List<bool> <results>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private List<KGAIHJLHFDH>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x70A34F0", Offset = "0x70A22F0", VA = "0x1870A34F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x70A3BA0", Offset = "0x70A29A0", VA = "0x1870A3BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct FEDGPPAMGMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AsyncTaskMethodBuilder<KGAIHJLHFDH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public List<KGAIHJLHFDH> roomSaves;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private FDOOICDKOMB <roomsClient>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private List<KGAIHJLHFDH>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private KGAIHJLHFDH <roomSave>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x709E940", Offset = "0x709D740", VA = "0x18709E940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x709EF80", Offset = "0x709DD80", VA = "0x18709EF80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x70A65B0", Offset = "0x70A53B0", VA = "0x1870A65B0")]
	[AsyncStateMachine(typeof(LACBNINAEIB))]
	public static Task<List<bool>> IDCPPOMHFKO(List<KGAIHJLHFDH> PJBFLBDFCCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x70A66C0", Offset = "0x70A54C0", VA = "0x1870A66C0")]
	[AsyncStateMachine(typeof(FEDGPPAMGMO))]
	public static Task<KGAIHJLHFDH> NFAFILLEBDI(List<KGAIHJLHFDH> PJBFLBDFCCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class HDJMDENPHDF : CALOLFCNJLO
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class GNKAENIOKOD : IEquatable<GNKAENIOKOD>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public long KBHAJPMMEGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public long EPECBIMCHCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public int FAEMCLFCBBF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected virtual Type LPINEMLCCAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x70A1B50", Offset = "0x70A0950", VA = "0x1870A1B50", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x70A1CC0", Offset = "0x70A0AC0", VA = "0x1870A1CC0")]
		public GNKAENIOKOD(long OPDIJICLPKM, long ALBJJJMKEAA, int BONMOIMLOEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x70A1BB0", Offset = "0x70A09B0", VA = "0x1870A1BB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x70A1890", Offset = "0x70A0690", VA = "0x1870A1890", Slot = "6")]
		protected virtual bool GJNCKJIAMME(StringBuilder ENNMAEMAGJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x70A19F0", Offset = "0x70A07F0", VA = "0x1870A19F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x70A1800", Offset = "0x70A0600", VA = "0x1870A1800", Slot = "0")]
		public override bool Equals(object? JOOHPPHJKMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x70A1680", Offset = "0x70A0480", VA = "0x1870A1680", Slot = "7")]
		public virtual bool Equals(GNKAENIOKOD? LHMPMCLNOPG)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct LOHHBMMEPKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<List<long>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public HDJMDENPHDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public bool sortByClubMemberCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int maxQuerySize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private List<NPMDFDLAIKK> <myClubs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private TaskAwaiter<List<NPMDFDLAIKK>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x70A6D70", Offset = "0x70A5B70", VA = "0x1870A6D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x70A7550", Offset = "0x70A6350", VA = "0x1870A7550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct FIBJDFFOKAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public HDJMDENPHDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<IReadOnlyList<AOMMJLGJMGL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x709EFF0", Offset = "0x709DDF0", VA = "0x18709EFF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x709F4D0", Offset = "0x709E2D0", VA = "0x18709F4D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private CHIEPMBALCJ JAKFGGFGGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private List<NPMDFDLAIKK> IMADFHKPOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private Dictionary<long, GNKAENIOKOD> NIOPELBDLKI;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x70A24D0", Offset = "0x70A12D0", VA = "0x1870A24D0")]
	[FOLINPJCBJN.MNGLEKFJHCC.CIIMNDHGCHC]
	internal static void PIKBCINMJOC(IEPIHLKICIO BCNFHKMHIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x70A2540", Offset = "0x70A1340", VA = "0x1870A2540")]
	[RecRoom.NoEngine.Common.Preserve]
	public HDJMDENPHDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x70A20A0", Offset = "0x70A0EA0", VA = "0x1870A20A0", Slot = "4")]
	[AsyncStateMachine(typeof(LOHHBMMEPKH))]
	public Task<List<long>> HHMFGFFBPOK(bool PBNBMIKBBPJ, int LIEIBKHBHEL, CancellationToken HACFGBHNOCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x70A1FB0", Offset = "0x70A0DB0", VA = "0x1870A1FB0")]
	[AsyncStateMachine(typeof(FIBJDFFOKAD))]
	private Task EJOGIODOHML(CancellationToken HACFGBHNOCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x70A21F0", Offset = "0x70A0FF0", VA = "0x1870A21F0")]
	private void IBOBKJBDDEL(List<NPMDFDLAIKK> KILPHNKLKEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x70A22F0", Offset = "0x70A10F0", VA = "0x1870A22F0")]
	private int MKLANBHLEHD(NPMDFDLAIKK NMOPBJNEFKL, NPMDFDLAIKK KCJDGOIFCIF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class KNCFONLKECD : NPAGANPMLFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly HKOIOHFMIIK LMFPNEEOGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[CompilerGenerated]
	private Action JBGMPEPIDAO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private bool CAJAGPDPLAG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8FE800", Offset = "0x8FD600", VA = "0x1808FE800")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x70A3480", Offset = "0x70A2280", VA = "0x1870A3480")]
	[FOLINPJCBJN.MNGLEKFJHCC.CIIMNDHGCHC]
	internal static void PIKBCINMJOC(IEPIHLKICIO BCNFHKMHIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8FE740", Offset = "0x8FD540", VA = "0x1808FE740")]
	[RecRoom.NoEngine.Common.Preserve]
	public KNCFONLKECD([MHFJPMCEEAM(null)] HKOIOHFMIIK LMFPNEEOGOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x70A3450", Offset = "0x70A2250", VA = "0x1870A3450", Slot = "4")]
	public bool OKBDENFBPFP(PJIJPHIAAAH EFFHEJGJIEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x70A3220", Offset = "0x70A2020", VA = "0x1870A3220", Slot = "5")]
	public void ACAJEHDLFLC(DGCCNGNLMNC KGMCCCOKBDB, DADBLAJODHB IENBCIOOFAA, bool CJCLLIDDKED, JMKHKMHBFBD HKEKCDDGAKH, [Optional] KGAIHJLHFDH POLMBGIFLNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x70A3430", Offset = "0x70A2230", VA = "0x1870A3430")]
	private void FMEOJENLKMK(CLFBLPMMPBD LDEANEOLAOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class LIPEIKDPAJM : KBEMJLBENNH
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class NBNGGFHEDGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public string EMAJGDOFPDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public HashSet<long> IFCCJOFEBBH;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x70A75C0", Offset = "0x70A63C0", VA = "0x1870A75C0")]
		public NBNGGFHEDGJ()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct PKABDNGJAHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<List<PJIJPHIAAAH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public LIPEIKDPAJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public Func<bool> waitToContinueFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private List<PJIJPHIAAAH> <roomList>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter<List<PJIJPHIAAAH>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private object <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x70A7EC0", Offset = "0x70A6CC0", VA = "0x1870A7EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x70A9A50", Offset = "0x70A8850", VA = "0x1870A9A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct EIBFJOOIAPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<PJIJPHIAAAH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public LIPEIKDPAJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<PJIJPHIAAAH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x709E6B0", Offset = "0x709D4B0", VA = "0x18709E6B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x709E8D0", Offset = "0x709D6D0", VA = "0x18709E8D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct HCCBJCHEMCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<DGCCNGNLMNC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public LIPEIKDPAJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<DGCCNGNLMNC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x70A1D10", Offset = "0x70A0B10", VA = "0x1870A1D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x70A1F40", Offset = "0x70A0D40", VA = "0x1870A1F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct GFJEFBLJAOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<List<PJIJPHIAAAH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public LIPEIKDPAJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<IReadOnlyList<PJIJPHIAAAH>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter<List<long>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private TaskAwaiter<List<PJIJPHIAAAH>> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x709F530", Offset = "0x709E330", VA = "0x18709F530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x70A0180", Offset = "0x709EF80", VA = "0x1870A0180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct POLEECNAHLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public AsyncTaskMethodBuilder<List<PJIJPHIAAAH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public LIPEIKDPAJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter<IReadOnlyList<PJIJPHIAAAH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x70A9AC0", Offset = "0x70A88C0", VA = "0x1870A9AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x70AA800", Offset = "0x70A9600", VA = "0x1870AA800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct GMOJIHPNEMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AsyncTaskMethodBuilder<List<PJIJPHIAAAH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public LIPEIKDPAJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private Task<ONOOCHFLGLE> <queryTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private TaskAwaiter<ONOOCHFLGLE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TaskAwaiter<List<PJIJPHIAAAH>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private TaskAwaiter<KHCOBEIAJFM> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter<IReadOnlyList<PJIJPHIAAAH>> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x70A01F0", Offset = "0x709EFF0", VA = "0x1870A01F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x70A1610", Offset = "0x70A0410", VA = "0x1870A1610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct DGMJMMPJMIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AsyncTaskMethodBuilder<List<PJIJPHIAAAH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public LIPEIKDPAJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<JNKBPLAKAJN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private TaskAwaiter<List<PJIJPHIAAAH>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private TaskAwaiter<IReadOnlyList<PJIJPHIAAAH>> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private TaskAwaiter<IReadOnlyList<IPLDBEHMJAA>> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private Task<PJIJPHIAAAH> <recCenterTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Task<IReadOnlyList<PJIJPHIAAAH>> <recentRoomsTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private Task<IReadOnlyList<PJIJPHIAAAH>> <creatorsISubscribeToRoomTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private TaskAwaiter <>u__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private TaskAwaiter<IPLDBEHMJAA> <>u__6;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x709C6A0", Offset = "0x709B4A0", VA = "0x18709C6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x709E640", Offset = "0x709D440", VA = "0x18709E640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct BPKKDHPDAFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public AsyncTaskMethodBuilder<List<PJIJPHIAAAH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public LIPEIKDPAJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private Task<IReadOnlyList<PJIJPHIAAAH>> <myOwnedRoomsTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private Task<IReadOnlyList<PJIJPHIAAAH>> <clubhouseTemplateRoomsTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter<IReadOnlyList<PJIJPHIAAAH>[]> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x709BA80", Offset = "0x709A880", VA = "0x18709BA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x709C110", Offset = "0x709AF10", VA = "0x18709C110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct OLNDDOOMKDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public AsyncTaskMethodBuilder<List<PJIJPHIAAAH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public LIPEIKDPAJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter<List<PJIJPHIAAAH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x70A7A70", Offset = "0x70A6870", VA = "0x1870A7A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x70A7E50", Offset = "0x70A6C50", VA = "0x1870A7E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct HGHEOIHJABH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public AsyncTaskMethodBuilder<List<PJIJPHIAAAH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public LIPEIKDPAJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<List<PJIJPHIAAAH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x70A2610", Offset = "0x70A1410", VA = "0x1870A2610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x70A2AB0", Offset = "0x70A18B0", VA = "0x1870A2AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct HJKCGCAPJJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public AsyncTaskMethodBuilder<List<PJIJPHIAAAH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public List<long> idList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter<IReadOnlyList<PJIJPHIAAAH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x70A2B20", Offset = "0x70A1920", VA = "0x1870A2B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x70A2D70", Offset = "0x70A1B70", VA = "0x1870A2D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct AAODGGMALFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder<List<PJIJPHIAAAH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public JNKBPLAKAJN algorithmicList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int skip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int take;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Dictionary<long, string> rankingContextMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public LIPEIKDPAJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter<IReadOnlyList<PJIJPHIAAAH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x709B300", Offset = "0x709A100", VA = "0x18709B300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x709BA10", Offset = "0x709A810", VA = "0x18709BA10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct HLMMNKMHHEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncTaskMethodBuilder<IReadOnlyList<PJIJPHIAAAH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int skip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int take;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public LIPEIKDPAJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private TaskAwaiter<List<int>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<IReadOnlyList<PJIJPHIAAAH>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x70A2DE0", Offset = "0x70A1BE0", VA = "0x1870A2DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x70A31B0", Offset = "0x70A1FB0", VA = "0x1870A31B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private JGLLKCGMCOF HMFEFPHLCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private CHIEPMBALCJ JAKFGGFGGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private CALOLFCNJLO BBCLGJELMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private DPIEDOFFLCF HMHLOFOACGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private KGJJNCGCPGF IPABHHHPLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private KNJOEGIPOFK CLBLPOFHNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private BOHPGCEDCNM NILIPJLEDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<string, List<NBNGGFHEDGJ>> PPPHJPCGILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private HashSet<long> AJDLLOLIBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private StringBuilder ENNMAEMAGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, int> FAHKONFLBDA;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x70A63B0", Offset = "0x70A51B0", VA = "0x1870A63B0")]
	[FOLINPJCBJN.MNGLEKFJHCC.CIIMNDHGCHC]
	internal static void PIKBCINMJOC(IEPIHLKICIO BCNFHKMHIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x70A6420", Offset = "0x70A5220", VA = "0x1870A6420")]
	[RecRoom.NoEngine.Common.Preserve]
	public LIPEIKDPAJM([MHFJPMCEEAM(null)] JGLLKCGMCOF HMFEFPHLCJH, [MHFJPMCEEAM(null)] CHIEPMBALCJ JAKFGGFGGIH, [MHFJPMCEEAM(null)] CALOLFCNJLO BBCLGJELMCF, [MHFJPMCEEAM(null)] DPIEDOFFLCF HMHLOFOACGH, [MHFJPMCEEAM(null)] BOHPGCEDCNM ANLHEFAJNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x70A58A0", Offset = "0x70A46A0", VA = "0x1870A58A0", Slot = "4")]
	[AsyncStateMachine(typeof(PKABDNGJAHP))]
	public Task<List<PJIJPHIAAAH>> ILMIBCMGNOM(RoomListQueryData CGNDNFEKAPC, CancellationToken HACFGBHNOCC, [Optional] Func<bool> DEKBGKENHAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x70A4A60", Offset = "0x70A3860", VA = "0x1870A4A60", Slot = "5")]
	[AsyncStateMachine(typeof(EIBFJOOIAPI))]
	public Task<PJIJPHIAAAH> ELNGLJPOPMC(long OGMIFIGJENM, CancellationToken HACFGBHNOCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x70A45A0", Offset = "0x70A33A0", VA = "0x1870A45A0", Slot = "6")]
	[AsyncStateMachine(typeof(HCCBJCHEMCI))]
	public Task<DGCCNGNLMNC> DEAFAHKGEGP(long OGMIFIGJENM, CancellationToken HACFGBHNOCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x70A3F60", Offset = "0x70A2D60", VA = "0x1870A3F60", Slot = "7")]
	public bool CCPBJNPJLND(long OGMIFIGJENM, [Out] int IPHJMBDJDJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x70A56A0", Offset = "0x70A44A0", VA = "0x1870A56A0")]
	[AsyncStateMachine(typeof(GFJEFBLJAOE))]
	private Task<List<PJIJPHIAAAH>> IDKDKBFKCDM(RoomListQueryData CGNDNFEKAPC, CancellationToken HACFGBHNOCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x70A4920", Offset = "0x70A3720", VA = "0x1870A4920")]
	[AsyncStateMachine(typeof(POLEECNAHLP))]
	private Task<List<PJIJPHIAAAH>> EFKOLHGDKCJ(RoomListQueryData CGNDNFEKAPC, CancellationToken HACFGBHNOCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x70A4D30", Offset = "0x70A3B30", VA = "0x1870A4D30")]
	[AsyncStateMachine(typeof(GMOJIHPNEMI))]
	private Task<List<PJIJPHIAAAH>> FNLHHKPJPEJ(RoomListQueryData CGNDNFEKAPC, CancellationToken HACFGBHNOCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x70A3C10", Offset = "0x70A2A10", VA = "0x1870A3C10")]
	[AsyncStateMachine(typeof(DGMJMMPJMIB))]
	private Task<List<PJIJPHIAAAH>> AAJPGCKJLLF(RoomListQueryData CGNDNFEKAPC, CancellationToken HACFGBHNOCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x70A3E20", Offset = "0x70A2C20", VA = "0x1870A3E20")]
	[AsyncStateMachine(typeof(BPKKDHPDAFP))]
	private Task<List<PJIJPHIAAAH>> BMKJGEFDFHG(RoomListQueryData CGNDNFEKAPC, CancellationToken HACFGBHNOCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x70A47E0", Offset = "0x70A35E0", VA = "0x1870A47E0")]
	[AsyncStateMachine(typeof(OLNDDOOMKDB))]
	private Task<List<PJIJPHIAAAH>> EFHJIMMEINP(RoomListQueryData CGNDNFEKAPC, CancellationToken HACFGBHNOCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x70A5E40", Offset = "0x70A4C40", VA = "0x1870A5E40")]
	[AsyncStateMachine(typeof(HGHEOIHJABH))]
	private Task<List<PJIJPHIAAAH>> OMGHFDIOMID(RoomListQueryData CGNDNFEKAPC, CancellationToken HACFGBHNOCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x70A5CC0", Offset = "0x70A4AC0", VA = "0x1870A5CC0")]
	[AsyncStateMachine(typeof(HJKCGCAPJJG))]
	private Task<List<PJIJPHIAAAH>> NNJOMBGPNHO(List<long> MMBNLMKGFJI, CancellationToken HACFGBHNOCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x70A5F80", Offset = "0x70A4D80", VA = "0x1870A5F80")]
	[AsyncStateMachine(typeof(AAODGGMALFI))]
	private Task<List<PJIJPHIAAAH>> OOIDDAHOOAK(JNKBPLAKAJN JDBBFMCBKDC, int KLKOJFIHFLG, int NEEMDJNIHKL, Dictionary<long, string> CDAEOEJGIOA, CancellationToken HACFGBHNOCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x70A4B90", Offset = "0x70A3990", VA = "0x1870A4B90")]
	[AsyncStateMachine(typeof(HLMMNKMHHEL))]
	private Task<IReadOnlyList<PJIJPHIAAAH>> FAAKLDCMMHH(int KLKOJFIHFLG, int NEEMDJNIHKL, CancellationToken HACFGBHNOCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x70A5440", Offset = "0x70A4240", VA = "0x1870A5440")]
	private void HPKPEGFJKBA(List<PJIJPHIAAAH> JNEAIMNCJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x70A4CD0", Offset = "0x70A3AD0", VA = "0x1870A4CD0")]
	private bool FIKLIGICPCM(PJIJPHIAAAH EFFHEJGJIEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x70A3D70", Offset = "0x70A2B70", VA = "0x1870A3D70")]
	private void ALFCEKDJBGO(List<PJIJPHIAAAH> JNEAIMNCJNG, KMOEFKKPGAN KEKAMFBEIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x70A5390", Offset = "0x70A4190", VA = "0x1870A5390")]
	private void HOHJIGMOJBO(List<PJIJPHIAAAH> JNEAIMNCJNG, KMOEFKKPGAN KEKAMFBEIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x70A5BA0", Offset = "0x70A49A0", VA = "0x1870A5BA0")]
	private void NJGEJJPFNMG(List<PJIJPHIAAAH> JNEAIMNCJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x70A5350", Offset = "0x70A4150", VA = "0x1870A5350")]
	private bool HAHABEOIAEF(PJIJPHIAAAH EFFHEJGJIEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x178B0B0", Offset = "0x1789EB0", VA = "0x18178B0B0")]
	private bool FJAGCCFFDHF(PJIJPHIAAAH EFFHEJGJIEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x70A57F0", Offset = "0x70A45F0", VA = "0x1870A57F0")]
	private void IIOGLDEGHMD(List<PJIJPHIAAAH> JNEAIMNCJNG, bool CDKJKCKJCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x70A5520", Offset = "0x70A4320", VA = "0x1870A5520")]
	private void ICDBOAGNJLM(List<PJIJPHIAAAH> JNEAIMNCJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x70A50F0", Offset = "0x70A3EF0", VA = "0x1870A50F0")]
	private bool GNEFCBGOIJP(PJIJPHIAAAH EFFHEJGJIEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x70A5A00", Offset = "0x70A4800", VA = "0x1870A5A00")]
	private void JGIILKICFMM(List<PJIJPHIAAAH> JNEAIMNCJNG, int JFPAEBMEBNC, RoomListQueryData.BJLBMBJPKBI LDPCGGNMEHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x70A46D0", Offset = "0x70A34D0", VA = "0x1870A46D0")]
	private void EEGBGJEBCNI(List<PJIJPHIAAAH> JNEAIMNCJNG, bool OOBCMJAJEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x70A51F0", Offset = "0x70A3FF0", VA = "0x1870A51F0")]
	private void GPMPPGOGBMF(List<PJIJPHIAAAH> JNEAIMNCJNG, (int, int)? BHBHODPFIMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x70A3FD0", Offset = "0x70A2DD0", VA = "0x1870A3FD0")]
	private string CDPFBEJFILO(List<PJIJPHIAAAH> JNEAIMNCJNG, string IOAJHHCCGHA, string NMLEJDOFKLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x70A60E0", Offset = "0x70A4EE0", VA = "0x1870A60E0")]
	private void OPBHEPCAOHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x70A5DD0", Offset = "0x70A4BD0", VA = "0x1870A5DD0")]
	private void NPLFKKKGHNB(List<PJIJPHIAAAH> JNEAIMNCJNG, int BEOMHJICOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x70A5C50", Offset = "0x70A4A50", VA = "0x1870A5C50")]
	private int NKHOIAJJDDN(PJIJPHIAAAH NMOPBJNEFKL, PJIJPHIAAAH KCJDGOIFCIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x70A4E80", Offset = "0x70A3C80", VA = "0x1870A4E80")]
	private int GDKEOEAKLPH(PJIJPHIAAAH EFFHEJGJIEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x70A4460", Offset = "0x70A3260", VA = "0x1870A4460")]
	private void CMGJBNKHBGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class NGOKOOHKCMF : PPLLAFJKCAI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct LLJPILKDPBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AsyncTaskMethodBuilder<KGAIHJLHFDH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public NGOKOOHKCMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public DADBLAJODHB subRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private TaskAwaiter<AANCFLJFFNE<KGAIHJLHFDH>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private TaskAwaiter<KGAIHJLHFDH> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x70A67D0", Offset = "0x70A55D0", VA = "0x1870A67D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x70A6D00", Offset = "0x70A5B00", VA = "0x1870A6D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct DAJMEBFJHJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder<KGAIHJLHFDH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public NGOKOOHKCMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public DADBLAJODHB subRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<AANCFLJFFNE<KGAIHJLHFDH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x709C180", Offset = "0x709AF80", VA = "0x18709C180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x709C630", Offset = "0x709B430", VA = "0x18709C630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private List<KGAIHJLHFDH> AOCKJOAMCCL;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x70A78F0", Offset = "0x70A66F0", VA = "0x1870A78F0")]
	[FOLINPJCBJN.MNGLEKFJHCC.CIIMNDHGCHC]
	internal static void PIKBCINMJOC(IEPIHLKICIO BCNFHKMHIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x70A7960", Offset = "0x70A6760", VA = "0x1870A7960")]
	[RecRoom.NoEngine.Common.Preserve]
	public NGOKOOHKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x70A77B0", Offset = "0x70A65B0", VA = "0x1870A77B0", Slot = "4")]
	[AsyncStateMachine(typeof(LLJPILKDPBK))]
	public Task<KGAIHJLHFDH> ICNGLJAJOAF(DADBLAJODHB IENBCIOOFAA, CancellationToken HACFGBHNOCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x70A7670", Offset = "0x70A6470", VA = "0x1870A7670", Slot = "5")]
	[AsyncStateMachine(typeof(DAJMEBFJHJI))]
	public Task<KGAIHJLHFDH> AADOCIFJPKE(DADBLAJODHB IENBCIOOFAA, CancellationToken HACFGBHNOCC)
	{
		return null;
	}
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
