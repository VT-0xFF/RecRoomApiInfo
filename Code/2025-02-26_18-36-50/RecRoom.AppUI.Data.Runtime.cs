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
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x726DED0", Offset = "0x726D2D0", VA = "0x18726DED0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x975680", Offset = "0x974A80", VA = "0x180975680")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9756C0", Offset = "0x974AC0", VA = "0x1809756C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7270960", Offset = "0x726FD60", VA = "0x187270960", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x242AF30", Offset = "0x242A330", VA = "0x18242AF30")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class FBPBMJADDPC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct PKDGEDAHCPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<List<bool>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public List<CCDAHBCPCKI> roomSaves;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private JCGLOKBJLCC <roomsClient>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private List<bool> <results>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private List<CCDAHBCPCKI>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7270240", Offset = "0x726F640", VA = "0x187270240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x72708F0", Offset = "0x726FCF0", VA = "0x1872708F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct IIHJECBBOPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AsyncTaskMethodBuilder<CCDAHBCPCKI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public List<CCDAHBCPCKI> roomSaves;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private JCGLOKBJLCC <roomsClient>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private List<CCDAHBCPCKI>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private CCDAHBCPCKI <roomSave>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x72692B0", Offset = "0x72686B0", VA = "0x1872692B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x72698F0", Offset = "0x7268CF0", VA = "0x1872698F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x72687D0", Offset = "0x7267BD0", VA = "0x1872687D0")]
	[AsyncStateMachine(typeof(PKDGEDAHCPE))]
	public static Task<List<bool>> NBOLCPJEMLM(List<CCDAHBCPCKI> KDAAMABLAJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x72686C0", Offset = "0x7267AC0", VA = "0x1872686C0")]
	[AsyncStateMachine(typeof(IIHJECBBOPP))]
	public static Task<CCDAHBCPCKI> FPPDAEMGHMJ(List<CCDAHBCPCKI> KDAAMABLAJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class OKDADBNMAKJ : JKKPMFKNCBD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct ELDADCKENNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AsyncTaskMethodBuilder<DBEECBAIEKP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int accountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private TaskAwaiter<DBEECBAIEKP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7268440", Offset = "0x7267840", VA = "0x187268440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7268650", Offset = "0x7267A50", VA = "0x187268650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private List<Action> EAOEJNKICLF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JFPFICFFMLN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x726F270", Offset = "0x726E670", VA = "0x18726F270", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x726ED90", Offset = "0x726E190", VA = "0x18726ED90")]
	[HLOHOCOKELO.IDGFAEKKODB.GGCNFHIOHEN]
	internal static void AOKDCDMDNDH(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x726F440", Offset = "0x726E840", VA = "0x18726F440")]
	[RecRoom.NoEngine.Common.Preserve]
	public OKDADBNMAKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x726F0C0", Offset = "0x726E4C0", VA = "0x18726F0C0", Slot = "5")]
	[AsyncStateMachine(typeof(ELDADCKENNO))]
	public Task<DBEECBAIEKP> EBGNOICFMLO(int NJNOPMJJKAE, CancellationToken LAAJFAFNFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x726F1C0", Offset = "0x726E5C0", VA = "0x18726F1C0", Slot = "6")]
	public List<int> GHBAKBGODIN(AccountListQueryData LLPIBDHHKEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x726EE00", Offset = "0x726E200", VA = "0x18726EE00", Slot = "7")]
	public void BKIOGGKCKID(AccountListQueryData LLPIBDHHKEE, Action OCIEANDEEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x726F1F0", Offset = "0x726E5F0", VA = "0x18726F1F0", Slot = "8")]
	public void LBOAJFKPMGD(AccountListQueryData LLPIBDHHKEE, Action OCIEANDEEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x726EE80", Offset = "0x726E280", VA = "0x18726EE80")]
	private List<int> DLGDKKLJHML(AccountListQueryData LLPIBDHHKEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x726F340", Offset = "0x726E740", VA = "0x18726F340")]
	private void PFOHDLOKIKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class DEFLKODKIGI : EEEFAOGBHFJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct AHLHPEOHBBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public AsyncTaskMethodBuilder<List<string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public DEFLKODKIGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public string panelId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<IKGGNJPFIKE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x725BFC0", Offset = "0x725B3C0", VA = "0x18725BFC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x725C670", Offset = "0x725BA70", VA = "0x18725C670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct NGKMGLMDFKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public AsyncTaskMethodBuilder<KIGJGNEEDOF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public DEFLKODKIGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<List<CLFDJHEGAEM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x726D400", Offset = "0x726C800", VA = "0x18726D400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x726D650", Offset = "0x726CA50", VA = "0x18726D650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct NCFGNEPMPPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<IKGGNJPFIKE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public DEFLKODKIGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<List<CLFDJHEGAEM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x726D140", Offset = "0x726C540", VA = "0x18726D140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x726D390", Offset = "0x726C790", VA = "0x18726D390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct EBLGEKDJKHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<List<CLFDJHEGAEM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public OHCGJDBOAKP source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<List<CLFDJHEGAEM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7267C60", Offset = "0x7267060", VA = "0x187267C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7267E40", Offset = "0x7267240", VA = "0x187267E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private EMKKBBONOCA HOGGHHGMKGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private LOHONBJIAJM DDONPOBFPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private IKGGNJPFIKE JAJFCLMAJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private KIGJGNEEDOF CPAFGMANENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private HashSet<string> CLIMIKOOLNI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public FKDOIPNGGAF GKIMDPGHIEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x94BDD0", Offset = "0x94B1D0", VA = "0x18094BDD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<string> IEFECFAJMNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x725FE00", Offset = "0x725F200", VA = "0x18725FE00", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x725F220", Offset = "0x725E620", VA = "0x18725F220", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x725F1B0", Offset = "0x725E5B0", VA = "0x18725F1B0")]
	[HLOHOCOKELO.CMBCHPAFDOL.DIAIOJMELDA]
	internal static void AOKDCDMDNDH(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x72600D0", Offset = "0x725F4D0", VA = "0x1872600D0")]
	[RecRoom.NoEngine.Common.Preserve]
	public DEFLKODKIGI([IBJCGEMJMJL(null)] EMKKBBONOCA LNFGNDKNMAM, [IBJCGEMJMJL(null)] LOHONBJIAJM BCCAPFAPCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x725FCC0", Offset = "0x725F0C0", VA = "0x18725FCC0", Slot = "7")]
	[AsyncStateMachine(typeof(AHLHPEOHBBJ))]
	public Task<List<string>> JKGMDAOPEGK(string FPHLHEOFFDL, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x725FFC0", Offset = "0x725F3C0", VA = "0x18725FFC0", Slot = "8")]
	[AsyncStateMachine(typeof(NGKMGLMDFKB))]
	public Task<KIGJGNEEDOF> PNPJNKFNIJJ(CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x725FEB0", Offset = "0x725F2B0", VA = "0x18725FEB0")]
	[AsyncStateMachine(typeof(NCFGNEPMPPM))]
	private Task<IKGGNJPFIKE> LFLNBOBFDBK(CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x725F0B0", Offset = "0x725E4B0", VA = "0x18725F0B0")]
	[AsyncStateMachine(typeof(EBLGEKDJKHK))]
	private Task<List<CLFDJHEGAEM>> ADDGDCIJJCO(OHCGJDBOAKP MBDLAJMBAIN, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x725F2D0", Offset = "0x725E6D0", VA = "0x18725F2D0")]
	private bool CIICOPKHLDM(string BEHNAMBHIHO, IKGGNJPFIKE ANEAMLPAILJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x725FAF0", Offset = "0x725EEF0", VA = "0x18725FAF0")]
	private void IGPIFIACEDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x725FA10", Offset = "0x725EE10", VA = "0x18725FA10")]
	private void GNKKOAPNODJ(bool JIDEPALIAMB, string BPPCEJGCMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1BE5D80", Offset = "0x1BE5180", VA = "0x181BE5D80")]
	private void MJKHDINBMFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class KOFEAGOLBKG : MKDOOAILPDB
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private class OCDIHBNPMOB : IEquatable<OCDIHBNPMOB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public long OGMJCKLNEKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public long JOMFGNNHFPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int FBMPALOHCEJ;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected virtual Type FHINNFNBKBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x726E0B0", Offset = "0x726D4B0", VA = "0x18726E0B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x726E590", Offset = "0x726D990", VA = "0x18726E590")]
		public OCDIHBNPMOB(long LGNCNJHPBIH, long ALJIDHDMGPD, int IDBOHHOGKFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x726E480", Offset = "0x726D880", VA = "0x18726E480", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x726DF50", Offset = "0x726D350", VA = "0x18726DF50", Slot = "6")]
		protected virtual bool ALIAADNPHJA(StringBuilder FIFAAOLCMNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x726E320", Offset = "0x726D720", VA = "0x18726E320", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x726E110", Offset = "0x726D510", VA = "0x18726E110", Slot = "0")]
		public override bool Equals(object? GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x726E1A0", Offset = "0x726D5A0", VA = "0x18726E1A0", Slot = "7")]
		public virtual bool Equals(OCDIHBNPMOB? OKCHLIEAIJP)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct DLAFBGCNIBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder<List<long>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public KOFEAGOLBKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public bool sortByClubMemberCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int maxQuerySize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private List<FDNOOAIDONL> <myClubs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<List<FDNOOAIDONL>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7264A70", Offset = "0x7263E70", VA = "0x187264A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7265250", Offset = "0x7264650", VA = "0x187265250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct DBOBHKNDMLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public KOFEAGOLBKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<IReadOnlyList<LAEHKJJGHMJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x725EB70", Offset = "0x725DF70", VA = "0x18725EB70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x725F050", Offset = "0x725E450", VA = "0x18725F050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private KOGJGNIFGMB PBOOMDNBGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private List<FDNOOAIDONL> JMJGKBIIIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private Dictionary<long, OCDIHBNPMOB> FEHLAONHJKP;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x726A840", Offset = "0x7269C40", VA = "0x18726A840")]
	[HLOHOCOKELO.CMBCHPAFDOL.DIAIOJMELDA]
	internal static void AOKDCDMDNDH(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x726ADD0", Offset = "0x726A1D0", VA = "0x18726ADD0")]
	[RecRoom.NoEngine.Common.Preserve]
	public KOFEAGOLBKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x726A9A0", Offset = "0x7269DA0", VA = "0x18726A9A0", Slot = "4")]
	[AsyncStateMachine(typeof(DLAFBGCNIBJ))]
	public Task<List<long>> IFBPHLLNCDL(bool GLOLKGNBEBI, int CGIGPEEEAAB, CancellationToken LAAJFAFNFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x726A8B0", Offset = "0x7269CB0", VA = "0x18726A8B0")]
	[AsyncStateMachine(typeof(DBOBHKNDMLO))]
	private Task GIGOKPBCMBO(CancellationToken LAAJFAFNFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x726AAF0", Offset = "0x7269EF0", VA = "0x18726AAF0")]
	private void NLGJBEOEOJH(List<FDNOOAIDONL> MIAPHANIDFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x726ABF0", Offset = "0x7269FF0", VA = "0x18726ABF0")]
	private int PPNAEHAPLMG(FDNOOAIDONL CLHNCHKFPON, FDNOOAIDONL KMNANLEEDKO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class OCMNOMDOGJI : HFLHAJEFECF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct NIJCGJOIIJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder<List<IJBHONDDGJA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public OCMNOMDOGJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int maxResultCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public bool publicOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public bool excludeCurrentlyEquipped;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private TaskAwaiter<IReadOnlyDictionary<int, OJDOIIFPLOL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x726D6C0", Offset = "0x726CAC0", VA = "0x18726D6C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x726DE60", Offset = "0x726D260", VA = "0x18726DE60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct CCMLPNMFLIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public OCMNOMDOGJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public IJBHONDDGJA outfitData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x725E830", Offset = "0x725DC30", VA = "0x18725E830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x725EA60", Offset = "0x725DE60", VA = "0x18725EA60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly EMKKBBONOCA LNFGNDKNMAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly KBKEAOJHNOA EFFFMKLHKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly PKKLBBLHCMJ BPHDLLKLMLA;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public FKDOIPNGGAF NAFGPAKNAPA
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x94B9E0", Offset = "0x94ADE0", VA = "0x18094B9E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x726E5E0", Offset = "0x726D9E0", VA = "0x18726E5E0")]
	[HLOHOCOKELO.CMBCHPAFDOL.DIAIOJMELDA]
	internal static void AOKDCDMDNDH(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x726EBB0", Offset = "0x726DFB0", VA = "0x18726EBB0")]
	[RecRoom.NoEngine.Common.Preserve]
	public OCMNOMDOGJI([IBJCGEMJMJL(null)] EMKKBBONOCA LNFGNDKNMAM, [IBJCGEMJMJL(null)] KBKEAOJHNOA EFFFMKLHKJF, [IBJCGEMJMJL(null)] PKKLBBLHCMJ BPHDLLKLMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x726E740", Offset = "0x726DB40", VA = "0x18726E740", Slot = "5")]
	[AsyncStateMachine(typeof(NIJCGJOIIJE))]
	public Task<List<IJBHONDDGJA>> EMGGMKLDFAM(CancellationToken LAAJFAFNFCN, bool INFPMMIMNBC = false, int CCCJCLAKKDD = -1, bool CGCBEDKHBKM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x726E650", Offset = "0x726DA50", VA = "0x18726E650", Slot = "6")]
	[AsyncStateMachine(typeof(CCMLPNMFLIB))]
	public Task BOIJNLEABKE(IJBHONDDGJA NKILLPHANBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x726E860", Offset = "0x726DC60", VA = "0x18726E860")]
	private void FBCELDCHBMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x726EA90", Offset = "0x726DE90", VA = "0x18726EA90")]
	private void FKHJFAJPHEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x726EAE0", Offset = "0x726DEE0", VA = "0x18726EAE0")]
	private void IONGIJLMKEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x726E930", Offset = "0x726DD30", VA = "0x18726E930")]
	private bool FJFDKDAALHE(IJBHONDDGJA CLHNCHKFPON, IJBHONDDGJA KMNANLEEDKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x726EAB0", Offset = "0x726DEB0", VA = "0x18726EAB0")]
	private bool GCJIKEMGMAC(OJDOIIFPLOL ICAHHKCMFIN, bool INFPMMIMNBC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class EHHDLHKDJCA : IIHOLPABEOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly GHGEMLGKFFA OEFAPELPMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[CompilerGenerated]
	private Action AAMDODPMKBG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private bool IFECDBENDPA
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x949420", Offset = "0x948820", VA = "0x180949420")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7268200", Offset = "0x7267600", VA = "0x187268200")]
	[HLOHOCOKELO.CMBCHPAFDOL.DIAIOJMELDA]
	internal static void AOKDCDMDNDH(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x951BA0", Offset = "0x950FA0", VA = "0x180951BA0")]
	[RecRoom.NoEngine.Common.Preserve]
	public EHHDLHKDJCA([IBJCGEMJMJL(null)] GHGEMLGKFFA OEFAPELPMEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x72680C0", Offset = "0x72674C0", VA = "0x1872680C0", Slot = "4")]
	public void AIJIPDMHNJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7268270", Offset = "0x7267670", VA = "0x187268270", Slot = "5")]
	public void MIENPHFKLMF(NBOGHBPKEMA KMMJGNHILKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x72683F0", Offset = "0x72677F0", VA = "0x1872683F0", Slot = "6")]
	public bool MLCOAOJLAEL(ALHPBBOBFGN KMMJGNHILKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7267EB0", Offset = "0x72672B0", VA = "0x187267EB0", Slot = "7")]
	public void ABOEBAAEPNP(EPDFKONBMMJ OCNEFBOFEOP, KOLBKODMCOP OILMJLBENOE, bool AADHKHNEFAB, DDHAEMNNJCB IOMMMEDMKKD, [Optional] CCDAHBCPCKI CCIMNDEGKOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7268420", Offset = "0x7267820", VA = "0x187268420")]
	private void MNBEALOLGLI(FKEAOBEFCNA BIEIOPPGBOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class DMBKMHGBLFH : CNHEGPKFIDO
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal class COBGLKBMPGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public string LGOKINMPBII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public HashSet<long> CEPGPKGMNBM;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x725EAC0", Offset = "0x725DEC0", VA = "0x18725EAC0")]
		public COBGLKBMPGD()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct BKIIHDDONMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public AsyncTaskMethodBuilder<List<ALHPBBOBFGN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public DMBKMHGBLFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Func<bool> waitToContinueFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private List<ALHPBBOBFGN> <roomList>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private TaskAwaiter<List<ALHPBBOBFGN>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private object <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x725C9A0", Offset = "0x725BDA0", VA = "0x18725C9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x725E530", Offset = "0x725D930", VA = "0x18725E530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct CBDFJLNPGFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public AsyncTaskMethodBuilder<ALHPBBOBFGN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public DMBKMHGBLFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskAwaiter<ALHPBBOBFGN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x725E5A0", Offset = "0x725D9A0", VA = "0x18725E5A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x725E7C0", Offset = "0x725DBC0", VA = "0x18725E7C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct LFBLOCJDJGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder<EPDFKONBMMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public DMBKMHGBLFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<EPDFKONBMMJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x726AEA0", Offset = "0x726A2A0", VA = "0x18726AEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x726B0D0", Offset = "0x726A4D0", VA = "0x18726B0D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct ONNGNEEGAME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder<List<ALHPBBOBFGN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public DMBKMHGBLFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TaskAwaiter<IReadOnlyList<ALHPBBOBFGN>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter<List<long>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<List<ALHPBBOBFGN>> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x726F570", Offset = "0x726E970", VA = "0x18726F570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x72701D0", Offset = "0x726F5D0", VA = "0x1872701D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct MPHMEIOCFCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public AsyncTaskMethodBuilder<List<ALHPBBOBFGN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public DMBKMHGBLFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private TaskAwaiter<IReadOnlyList<ALHPBBOBFGN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x726BDE0", Offset = "0x726B1E0", VA = "0x18726BDE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x726CB30", Offset = "0x726BF30", VA = "0x18726CB30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct DHJPGODLCDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public AsyncTaskMethodBuilder<List<ALHPBBOBFGN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public DMBKMHGBLFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private Task<JHKHGALJGOB> <queryTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private TaskAwaiter<JHKHGALJGOB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter<List<ALHPBBOBFGN>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter<MDOEAGAJCKF> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter<IReadOnlyList<ALHPBBOBFGN>> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x72635D0", Offset = "0x72629D0", VA = "0x1872635D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7264A00", Offset = "0x7263E00", VA = "0x187264A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct DGANLFPIDCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder<List<ALHPBBOBFGN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public DMBKMHGBLFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<EKMEGFBEHND> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TaskAwaiter<List<ALHPBBOBFGN>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private TaskAwaiter<IReadOnlyList<ALHPBBOBFGN>> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private TaskAwaiter<IReadOnlyList<NBBOPLILILA>> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private Task<ALHPBBOBFGN> <recCenterTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private Task<IReadOnlyList<ALHPBBOBFGN>> <recentRoomsTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private Task<IReadOnlyList<ALHPBBOBFGN>> <creatorsISubscribeToRoomTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private TaskAwaiter <>u__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private TaskAwaiter<NBBOPLILILA> <>u__6;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x72615C0", Offset = "0x72609C0", VA = "0x1872615C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7263560", Offset = "0x7262960", VA = "0x187263560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct IMLKFEFLINM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder<List<ALHPBBOBFGN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public DMBKMHGBLFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Task<IReadOnlyList<ALHPBBOBFGN>> <myOwnedRoomsTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private Task<IReadOnlyList<ALHPBBOBFGN>> <clubhouseTemplateRoomsTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private TaskAwaiter<IReadOnlyList<ALHPBBOBFGN>[]> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7269DB0", Offset = "0x72691B0", VA = "0x187269DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x726A450", Offset = "0x7269850", VA = "0x18726A450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct IDJKFHIFFGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public AsyncTaskMethodBuilder<List<ALHPBBOBFGN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public DMBKMHGBLFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private TaskAwaiter<List<ALHPBBOBFGN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7268E60", Offset = "0x7268260", VA = "0x187268E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7269240", Offset = "0x7268640", VA = "0x187269240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct MBNEICNJJEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder<List<ALHPBBOBFGN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public DMBKMHGBLFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<List<ALHPBBOBFGN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x726B140", Offset = "0x726A540", VA = "0x18726B140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x726B5E0", Offset = "0x726A9E0", VA = "0x18726B5E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct BKEALLNNECE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public AsyncTaskMethodBuilder<List<ALHPBBOBFGN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public List<long> idList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter<IReadOnlyList<ALHPBBOBFGN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x725C6E0", Offset = "0x725BAE0", VA = "0x18725C6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x725C930", Offset = "0x725BD30", VA = "0x18725C930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct MKOABLDCAGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public AsyncTaskMethodBuilder<List<ALHPBBOBFGN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public EKMEGFBEHND algorithmicList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public int skip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public int take;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Dictionary<long, string> rankingContextMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public DMBKMHGBLFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private TaskAwaiter<IReadOnlyList<ALHPBBOBFGN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x726B650", Offset = "0x726AA50", VA = "0x18726B650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x726BD70", Offset = "0x726B170", VA = "0x18726BD70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct ILKBPKOMFOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public AsyncTaskMethodBuilder<IReadOnlyList<ALHPBBOBFGN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public int skip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public int take;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public DMBKMHGBLFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private TaskAwaiter<List<int>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private TaskAwaiter<IReadOnlyList<ALHPBBOBFGN>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7269960", Offset = "0x7268D60", VA = "0x187269960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7269D40", Offset = "0x7269140", VA = "0x187269D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private CHDNBFGGGBI DIKLELHCODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private KOGJGNIFGMB PBOOMDNBGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private MKDOOAILPDB PAHPHDOLMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private FIIDOADKEDD MGBNFJALEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private HPDENNBAGKP FHLDNDGBIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private KJCONENAPPK HFNIINCGAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private EMKKBBONOCA HOGGHHGMKGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private Dictionary<string, List<COBGLKBMPGD>> DNADPIEEGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private HashSet<long> AHKDHEAKPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private StringBuilder FIFAAOLCMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private Dictionary<long, int> EJHAELFLMFJ;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x72652C0", Offset = "0x72646C0", VA = "0x1872652C0")]
	[HLOHOCOKELO.CMBCHPAFDOL.DIAIOJMELDA]
	internal static void AOKDCDMDNDH(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7267AD0", Offset = "0x7266ED0", VA = "0x187267AD0")]
	[RecRoom.NoEngine.Common.Preserve]
	public DMBKMHGBLFH([IBJCGEMJMJL(null)] CHDNBFGGGBI DIKLELHCODJ, [IBJCGEMJMJL(null)] KOGJGNIFGMB PBOOMDNBGPL, [IBJCGEMJMJL(null)] MKDOOAILPDB PAHPHDOLMEM, [IBJCGEMJMJL(null)] FIIDOADKEDD MGBNFJALEFB, [IBJCGEMJMJL(null)] EMKKBBONOCA LNFGNDKNMAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7265CB0", Offset = "0x72650B0", VA = "0x187265CB0", Slot = "4")]
	[AsyncStateMachine(typeof(BKIIHDDONMP))]
	public Task<List<ALHPBBOBFGN>> EEPDNNLKHIC(RoomListQueryData LLPIBDHHKEE, CancellationToken LAAJFAFNFCN, [Optional] Func<bool> MODFFFNPGHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7267210", Offset = "0x7266610", VA = "0x187267210", Slot = "5")]
	[AsyncStateMachine(typeof(CBDFJLNPGFN))]
	public Task<ALHPBBOBFGN> MIDMPFMPOEN(long FFFLOIOFAMB, CancellationToken LAAJFAFNFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x72656C0", Offset = "0x7264AC0", VA = "0x1872656C0", Slot = "6")]
	[AsyncStateMachine(typeof(LFBLOCJDJGI))]
	public Task<EPDFKONBMMJ> CMJDMNBOIGG(long FFFLOIOFAMB, CancellationToken LAAJFAFNFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x72666A0", Offset = "0x7265AA0", VA = "0x1872666A0", Slot = "7")]
	public bool IBCIOPOKDFJ(long FFFLOIOFAMB, [Out] int CJBNKLPJJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7267340", Offset = "0x7266740", VA = "0x187267340")]
	[AsyncStateMachine(typeof(ONNGNEEGAME))]
	private Task<List<ALHPBBOBFGN>> MMKKDHDIJEB(RoomListQueryData LLPIBDHHKEE, CancellationToken LAAJFAFNFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7265F50", Offset = "0x7265350", VA = "0x187265F50")]
	[AsyncStateMachine(typeof(MPHMEIOCFCN))]
	private Task<List<ALHPBBOBFGN>> EPPKCMBBFFJ(RoomListQueryData LLPIBDHHKEE, CancellationToken LAAJFAFNFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7266550", Offset = "0x7265950", VA = "0x187266550")]
	[AsyncStateMachine(typeof(DHJPGODLCDO))]
	private Task<List<ALHPBBOBFGN>> HAKNEHHFAGJ(RoomListQueryData LLPIBDHHKEE, CancellationToken LAAJFAFNFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7266B70", Offset = "0x7265F70", VA = "0x187266B70")]
	[AsyncStateMachine(typeof(DGANLFPIDCJ))]
	private Task<List<ALHPBBOBFGN>> JPEAPLOOKMC(RoomListQueryData LLPIBDHHKEE, CancellationToken LAAJFAFNFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7265330", Offset = "0x7264730", VA = "0x187265330")]
	[AsyncStateMachine(typeof(IMLKFEFLINM))]
	private Task<List<ALHPBBOBFGN>> BHEGAFEPEMG(RoomListQueryData LLPIBDHHKEE, CancellationToken LAAJFAFNFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7266090", Offset = "0x7265490", VA = "0x187266090")]
	[AsyncStateMachine(typeof(IDJKFHIFFGK))]
	private Task<List<ALHPBBOBFGN>> FBJFJGNHLMN(RoomListQueryData LLPIBDHHKEE, CancellationToken LAAJFAFNFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7266330", Offset = "0x7265730", VA = "0x187266330")]
	[AsyncStateMachine(typeof(MBNEICNJJEL))]
	private Task<List<ALHPBBOBFGN>> GKJLODKDLMM(RoomListQueryData LLPIBDHHKEE, CancellationToken LAAJFAFNFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7265BA0", Offset = "0x7264FA0", VA = "0x187265BA0")]
	[AsyncStateMachine(typeof(BKEALLNNECE))]
	private Task<List<ALHPBBOBFGN>> EEOLMDNCNJM(List<long> HIMLIOHCIIF, CancellationToken LAAJFAFNFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x72661D0", Offset = "0x72655D0", VA = "0x1872661D0")]
	[AsyncStateMachine(typeof(MKOABLDCAGD))]
	private Task<List<ALHPBBOBFGN>> FEOAFFMGHBK(EKMEGFBEHND NDCEMMMMPPJ, int CMAGHDEIFAJ, int AMJPLBEPICP, Dictionary<long, string> KGMOLPEBCMO, CancellationToken LAAJFAFNFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7265E10", Offset = "0x7265210", VA = "0x187265E10")]
	[AsyncStateMachine(typeof(ILKBPKOMFOJ))]
	private Task<IReadOnlyList<ALHPBBOBFGN>> EGBALKCKACD(int CMAGHDEIFAJ, int AMJPLBEPICP, CancellationToken LAAJFAFNFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7266470", Offset = "0x7265870", VA = "0x187266470")]
	private void GMHFIIILHEC(List<ALHPBBOBFGN> BOKJFJMKBNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x72667C0", Offset = "0x7265BC0", VA = "0x1872667C0")]
	private bool JFLOKPHAEOO(ALHPBBOBFGN KMMJGNHILKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7266CD0", Offset = "0x72660D0", VA = "0x187266CD0")]
	private void KHNJBNFCHOH(List<ALHPBBOBFGN> BOKJFJMKBNO, HCEGBBOOHEP PENCANPOCMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7265470", Offset = "0x7264870", VA = "0x187265470")]
	private void BKKBHGPIJLF(List<ALHPBBOBFGN> BOKJFJMKBNO, HCEGBBOOHEP PENCANPOCMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7266710", Offset = "0x7265B10", VA = "0x187266710")]
	private void JFLMFMANNDP(List<ALHPBBOBFGN> BOKJFJMKBNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7267910", Offset = "0x7266D10", VA = "0x187267910")]
	private bool POJDAJFILDA(ALHPBBOBFGN KMMJGNHILKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x17ADBB0", Offset = "0x17ACFB0", VA = "0x1817ADBB0")]
	private bool JMEEIMNOEEM(ALHPBBOBFGN KMMJGNHILKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7267490", Offset = "0x7266890", VA = "0x187267490")]
	private void MNAIJJAAPAN(List<ALHPBBOBFGN> BOKJFJMKBNO, bool KFDBDJLPICM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7267950", Offset = "0x7266D50", VA = "0x187267950")]
	private void PPLMCCJGJJD(List<ALHPBBOBFGN> BOKJFJMKBNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7267540", Offset = "0x7266940", VA = "0x187267540")]
	private bool NMECJBBCHDP(ALHPBBOBFGN KMMJGNHILKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7265520", Offset = "0x7264920", VA = "0x187265520")]
	private void CGHKIPKEFOE(List<ALHPBBOBFGN> BOKJFJMKBNO, int NJNOPMJJKAE, RoomListQueryData.FJMPDELKNBO GOBHOGBNOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x72657F0", Offset = "0x7264BF0", VA = "0x1872657F0")]
	private void DDEDKOFMGIN(List<ALHPBBOBFGN> BOKJFJMKBNO, bool DPJLNGHBMBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7265A40", Offset = "0x7264E40", VA = "0x187265A40")]
	private void DHCKFMPKLKO(List<ALHPBBOBFGN> BOKJFJMKBNO, (int, int)? EBMEFPKMBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7266D80", Offset = "0x7266180", VA = "0x187266D80")]
	private string MCNOOLGNBHE(List<ALHPBBOBFGN> BOKJFJMKBNO, string JNCHHEPCAOF, string NLPMCAEJEOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7267640", Offset = "0x7266A40", VA = "0x187267640")]
	private void PMLHKDJNAFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7266B00", Offset = "0x7265F00", VA = "0x187266B00")]
	private void JOICEDKOEOD(List<ALHPBBOBFGN> BOKJFJMKBNO, int OCIEMCGOIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7266A90", Offset = "0x7265E90", VA = "0x187266A90")]
	private int JNLJLOMKGKB(ALHPBBOBFGN CLHNCHKFPON, ALHPBBOBFGN KMNANLEEDKO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7266820", Offset = "0x7265C20", VA = "0x187266820")]
	private int JHLABHINIGE(ALHPBBOBFGN KMMJGNHILKN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7265900", Offset = "0x7264D00", VA = "0x187265900")]
	private void DEHBGAEJPHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class JLLFDKHCCJB : OGFOKCFEOOL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct MPJFICGJLLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public AsyncTaskMethodBuilder<CCDAHBCPCKI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public JLLFDKHCCJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public KOLBKODMCOP subRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private TaskAwaiter<JBPILBKHAGM<JHNKENAKGMI>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private TaskAwaiter<CCDAHBCPCKI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x726CBA0", Offset = "0x726BFA0", VA = "0x18726CBA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x726D0D0", Offset = "0x726C4D0", VA = "0x18726D0D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct FIDCCPJKHHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public AsyncTaskMethodBuilder<CCDAHBCPCKI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public JLLFDKHCCJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public KOLBKODMCOP subRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private TaskAwaiter<JBPILBKHAGM<JHNKENAKGMI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x72688E0", Offset = "0x7267CE0", VA = "0x1872688E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7268DF0", Offset = "0x72681F0", VA = "0x187268DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private List<CCDAHBCPCKI> NMGMKIPICMI;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x726A4C0", Offset = "0x72698C0", VA = "0x18726A4C0")]
	[HLOHOCOKELO.CMBCHPAFDOL.DIAIOJMELDA]
	internal static void AOKDCDMDNDH(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x726A7B0", Offset = "0x7269BB0", VA = "0x18726A7B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public JLLFDKHCCJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x726A670", Offset = "0x7269A70", VA = "0x18726A670", Slot = "4")]
	[AsyncStateMachine(typeof(MPJFICGJLLM))]
	public Task<CCDAHBCPCKI> LDJLNIAFDHG(KOLBKODMCOP OILMJLBENOE, CancellationToken LAAJFAFNFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x726A530", Offset = "0x7269930", VA = "0x18726A530", Slot = "5")]
	[AsyncStateMachine(typeof(FIDCCPJKHHE))]
	public Task<CCDAHBCPCKI> HOPLJOFMBDH(KOLBKODMCOP OILMJLBENOE, CancellationToken LAAJFAFNFCN)
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
