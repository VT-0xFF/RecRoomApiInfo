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
		[Cpp2IlInjected.Address(RVA = "0x72D0C10", Offset = "0x72CF810", VA = "0x1872D0C10")]
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
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
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
namespace _AssemblyRegistry.RecRoom_AppUI_Data_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x72D1D60", Offset = "0x72D0960", VA = "0x1872D1D60", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x240ECE0", Offset = "0x240D8E0", VA = "0x18240ECE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class PJCJOAIIIML
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct BGBJFLFEFMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<List<bool>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public List<IPHHHIANCDI> roomSaves;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private OIDBMIDIFKL <roomsClient>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private List<bool> <results>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private List<IPHHHIANCDI>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x72C3D00", Offset = "0x72C2900", VA = "0x1872C3D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x72C43B0", Offset = "0x72C2FB0", VA = "0x1872C43B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct FFBIAABANKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AsyncTaskMethodBuilder<IPHHHIANCDI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public List<IPHHHIANCDI> roomSaves;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private OIDBMIDIFKL <roomsClient>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private List<IPHHHIANCDI>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private IPHHHIANCDI <roomSave>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x72CA2C0", Offset = "0x72C8EC0", VA = "0x1872CA2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x72CA900", Offset = "0x72C9500", VA = "0x1872CA900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x72D1B40", Offset = "0x72D0740", VA = "0x1872D1B40")]
	[AsyncStateMachine(typeof(BGBJFLFEFMP))]
	public static Task<List<bool>> ADJKIKIOIGE(List<IPHHHIANCDI> BHJDLCCALMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x72D1C50", Offset = "0x72D0850", VA = "0x1872D1C50")]
	[AsyncStateMachine(typeof(FFBIAABANKC))]
	public static Task<IPHHHIANCDI> LHPFKFMIFLB(List<IPHHHIANCDI> BHJDLCCALMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class PGLMLECOCHD : KCLNGKFGMDC
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class GKGOLIJJNML : IEquatable<GKGOLIJJNML>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public long NNNJLKJGKNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public long MFPLFEMMAFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public int LMBMBPNMEIC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected virtual Type FAJABJFOFDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x72CBAC0", Offset = "0x72CA6C0", VA = "0x1872CBAC0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x72CBEF0", Offset = "0x72CAAF0", VA = "0x1872CBEF0")]
		public GKGOLIJJNML(long CGFMBHMKNNK, long HDGMMPEKNKM, int BPIANBDKGEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x72CBDE0", Offset = "0x72CA9E0", VA = "0x1872CBDE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x72CBC80", Offset = "0x72CA880", VA = "0x1872CBC80", Slot = "6")]
		protected virtual bool MMMNPPPBBPH(StringBuilder PLBIGDLAEKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x72CBB20", Offset = "0x72CA720", VA = "0x1872CBB20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x72CBA30", Offset = "0x72CA630", VA = "0x1872CBA30", Slot = "0")]
		public override bool Equals(object? CFMCKCBBBKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x72CB8B0", Offset = "0x72CA4B0", VA = "0x1872CB8B0", Slot = "7")]
		public virtual bool Equals(GKGOLIJJNML? PELBNOCGOOJ)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct EOKIOLEBPBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<List<long>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public PGLMLECOCHD <>4__this;

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
		private List<OKJJKCNLPAM> <myClubs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private TaskAwaiter<List<OKJJKCNLPAM>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x72C9A70", Offset = "0x72C8670", VA = "0x1872C9A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x72CA250", Offset = "0x72C8E50", VA = "0x1872CA250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct INBMLAKANNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public PGLMLECOCHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<IReadOnlyList<HNGLNPAIPNA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x72CC380", Offset = "0x72CAF80", VA = "0x1872CC380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x72CC860", Offset = "0x72CB460", VA = "0x1872CC860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private HJCFJFKLJMF IHNKLAIIBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private List<OKJJKCNLPAM> PNACFILFDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private Dictionary<long, GKGOLIJJNML> EPEGHFAKLNP;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x72D1710", Offset = "0x72D0310", VA = "0x1872D1710")]
	[DMDJPIBKEJJ.OPKFCOALFMB.IBOCCFBJPBC]
	internal static void HMDEJEGKIBO(KPLLBHIBBNH AGGFAPJEEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x72D19C0", Offset = "0x72D05C0", VA = "0x1872D19C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public PGLMLECOCHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x72D1780", Offset = "0x72D0380", VA = "0x1872D1780", Slot = "4")]
	[AsyncStateMachine(typeof(EOKIOLEBPBE))]
	public Task<List<long>> JPDPNBMMBLA(bool GDJGIAGNCBP, int PCJEDDEFLMO, CancellationToken IKLHDHMJFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x72D18D0", Offset = "0x72D04D0", VA = "0x1872D18D0")]
	[AsyncStateMachine(typeof(INBMLAKANNA))]
	private Task NHKBJIBAONE(CancellationToken IKLHDHMJFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x72D1610", Offset = "0x72D0210", VA = "0x1872D1610")]
	private void GPFHDHLFLDE(List<OKJJKCNLPAM> ACOPJCPNJOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x72D1430", Offset = "0x72D0030", VA = "0x1872D1430")]
	private int COHLMILBJFB(OKJJKCNLPAM IFMENDFGFGN, OKJJKCNLPAM DPEOCFNLADP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class GIOLOIEBAAC : BDANNHMJMLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly OALCBAAFGHC DDKHJHJFIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[CompilerGenerated]
	private Action KMILFNHNGIJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private bool GEIOKMMOFHF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963120", VA = "0x180964520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x72CB610", Offset = "0x72CA210", VA = "0x1872CB610")]
	[DMDJPIBKEJJ.OPKFCOALFMB.IBOCCFBJPBC]
	internal static void HMDEJEGKIBO(KPLLBHIBBNH AGGFAPJEEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x95A080", Offset = "0x958C80", VA = "0x18095A080")]
	[RecRoom.NoEngine.Common.Preserve]
	public GIOLOIEBAAC([GJMNBPKNJPO(null)] OALCBAAFGHC DDKHJHJFIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x72CB5E0", Offset = "0x72CA1E0", VA = "0x1872CB5E0", Slot = "4")]
	public bool AMCHLHNFBDG(JCOCCFMLIAE JPHOBLFNMNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x72CB6A0", Offset = "0x72CA2A0", VA = "0x1872CB6A0", Slot = "5")]
	public void JGEFBHOFGFH(BCPENJPKFJJ MDPGCFDKEND, FFBHBDHOGKB ICHBBGHLOON, bool LBHBNIFOLPE, PINBABNPMHD PJINHCHFNOH, [Optional] IPHHHIANCDI OEBHAJLKLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x72CB680", Offset = "0x72CA280", VA = "0x1872CB680")]
	private void ILKPHGAKNND(NOGJKLNPNGG HBANOBDOKBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class DFEEMLJHGBD : OJNIPBPGFNF
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class PHADAKLJGKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public string PCIGIEJPCCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public HashSet<long> AKNPPPFEEOH;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x72D1A90", Offset = "0x72D0690", VA = "0x1872D1A90")]
		public PHADAKLJGKM()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct JPMJMCNELDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<List<JCOCCFMLIAE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public DFEEMLJHGBD <>4__this;

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
		private List<JCOCCFMLIAE> <roomList>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter<List<JCOCCFMLIAE>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private object <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x72CE0D0", Offset = "0x72CCCD0", VA = "0x1872CE0D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x72CFC50", Offset = "0x72CE850", VA = "0x1872CFC50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct OMJCFKFHLLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<JCOCCFMLIAE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public DFEEMLJHGBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<JCOCCFMLIAE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x72D11A0", Offset = "0x72CFDA0", VA = "0x1872D11A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x72D13C0", Offset = "0x72CFFC0", VA = "0x1872D13C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct LHCOCBIGOOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<BCPENJPKFJJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public DFEEMLJHGBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<BCPENJPKFJJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x72D06B0", Offset = "0x72CF2B0", VA = "0x1872D06B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x72D08E0", Offset = "0x72CF4E0", VA = "0x1872D08E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct DMCPKHKNEIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<List<JCOCCFMLIAE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public DFEEMLJHGBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<IReadOnlyList<JCOCCFMLIAE>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter<List<long>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private TaskAwaiter<List<JCOCCFMLIAE>> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x72C8DB0", Offset = "0x72C79B0", VA = "0x1872C8DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x72C9A00", Offset = "0x72C8600", VA = "0x1872C9A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct BFMCNPEPCMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public AsyncTaskMethodBuilder<List<JCOCCFMLIAE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public DFEEMLJHGBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter<IReadOnlyList<JCOCCFMLIAE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x72C2F50", Offset = "0x72C1B50", VA = "0x1872C2F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x72C3C90", Offset = "0x72C2890", VA = "0x1872C3C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct JIFJILFKMAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AsyncTaskMethodBuilder<List<JCOCCFMLIAE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public DFEEMLJHGBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private Task<FDLCOHDADFO> <queryTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private TaskAwaiter<FDLCOHDADFO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TaskAwaiter<List<JCOCCFMLIAE>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private TaskAwaiter<HFNLDFKIGBK> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter<IReadOnlyList<JCOCCFMLIAE>> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x72CC8C0", Offset = "0x72CB4C0", VA = "0x1872CC8C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x72CDCE0", Offset = "0x72CC8E0", VA = "0x1872CDCE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct CIJANIIABPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AsyncTaskMethodBuilder<List<JCOCCFMLIAE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public DFEEMLJHGBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<OBNKFLFMANH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private TaskAwaiter<List<JCOCCFMLIAE>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private TaskAwaiter<IReadOnlyList<JCOCCFMLIAE>> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private TaskAwaiter<IReadOnlyList<EPLNIPCOADD>> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private Task<JCOCCFMLIAE> <recCenterTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Task<IReadOnlyList<JCOCCFMLIAE>> <recentRoomsTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private Task<IReadOnlyList<JCOCCFMLIAE>> <creatorsISubscribeToRoomTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private TaskAwaiter <>u__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private TaskAwaiter<EPLNIPCOADD> <>u__6;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x72C4420", Offset = "0x72C3020", VA = "0x1872C4420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x72C63B0", Offset = "0x72C4FB0", VA = "0x1872C63B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct FPCGHDEHMHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public AsyncTaskMethodBuilder<List<JCOCCFMLIAE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public DFEEMLJHGBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private Task<IReadOnlyList<JCOCCFMLIAE>> <myOwnedRoomsTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private Task<IReadOnlyList<JCOCCFMLIAE>> <clubhouseTemplateRoomsTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter<IReadOnlyList<JCOCCFMLIAE>[]> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x72CA970", Offset = "0x72C9570", VA = "0x1872CA970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x72CB000", Offset = "0x72C9C00", VA = "0x1872CB000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct LCMEFMPHEDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public AsyncTaskMethodBuilder<List<JCOCCFMLIAE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public DFEEMLJHGBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter<List<JCOCCFMLIAE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x72D0260", Offset = "0x72CEE60", VA = "0x1872D0260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x72D0640", Offset = "0x72CF240", VA = "0x1872D0640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct OMIIGJMMCIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public AsyncTaskMethodBuilder<List<JCOCCFMLIAE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public DFEEMLJHGBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<List<JCOCCFMLIAE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x72D0C90", Offset = "0x72CF890", VA = "0x1872D0C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x72D1130", Offset = "0x72CFD30", VA = "0x1872D1130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct MJDIMBNMHPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public AsyncTaskMethodBuilder<List<JCOCCFMLIAE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public List<long> idList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter<IReadOnlyList<JCOCCFMLIAE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x72D0950", Offset = "0x72CF550", VA = "0x1872D0950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x72D0BA0", Offset = "0x72CF7A0", VA = "0x1872D0BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct AACLODOBJCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder<List<JCOCCFMLIAE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public OBNKFLFMANH algorithmicList;

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
		public DFEEMLJHGBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter<IReadOnlyList<JCOCCFMLIAE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x72C27C0", Offset = "0x72C13C0", VA = "0x1872C27C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x72C2EE0", Offset = "0x72C1AE0", VA = "0x1872C2EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct IMGFCPPINAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncTaskMethodBuilder<IReadOnlyList<JCOCCFMLIAE>> <>t__builder;

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
		public DFEEMLJHGBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private TaskAwaiter<List<int>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<IReadOnlyList<JCOCCFMLIAE>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x72CBF40", Offset = "0x72CAB40", VA = "0x1872CBF40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x72CC310", Offset = "0x72CAF10", VA = "0x1872CC310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private CMLMNIGHOGD JMOHGPBLMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HJCFJFKLJMF IHNKLAIIBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private KCLNGKFGMDC GJPKPHGNMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private DEECLODLFLE EPNBOPCMOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private DCLHAILMONJ NOGHGAJEBIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private ELPENKJBGBH MCBGHCKDCGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private MFKFGBIAKOC LKIIDIGEGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<string, List<PHADAKLJGKM>> ODICOJCHDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private HashSet<long> HLJPNEOEJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private StringBuilder PLBIGDLAEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, int> OOKLLPBKMJJ;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x72C7810", Offset = "0x72C6410", VA = "0x1872C7810")]
	[DMDJPIBKEJJ.OPKFCOALFMB.IBOCCFBJPBC]
	internal static void HMDEJEGKIBO(KPLLBHIBBNH AGGFAPJEEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x72C8C20", Offset = "0x72C7820", VA = "0x1872C8C20")]
	[RecRoom.NoEngine.Common.Preserve]
	public DFEEMLJHGBD([GJMNBPKNJPO(null)] CMLMNIGHOGD JMOHGPBLMLJ, [GJMNBPKNJPO(null)] HJCFJFKLJMF IHNKLAIIBOJ, [GJMNBPKNJPO(null)] KCLNGKFGMDC GJPKPHGNMME, [GJMNBPKNJPO(null)] DEECLODLFLE EPNBOPCMOMD, [GJMNBPKNJPO(null)] MFKFGBIAKOC HBDBBINAAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x72C6D10", Offset = "0x72C5910", VA = "0x1872C6D10", Slot = "4")]
	[AsyncStateMachine(typeof(JPMJMCNELDF))]
	public Task<List<JCOCCFMLIAE>> CDPNGOFDGAJ(RoomListQueryData BAHFLOKBEBD, CancellationToken IKLHDHMJFFL, [Optional] Func<bool> FEMBNPFKOOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x72C7D20", Offset = "0x72C6920", VA = "0x1872C7D20", Slot = "5")]
	[AsyncStateMachine(typeof(OMJCFKFHLLE))]
	public Task<JCOCCFMLIAE> JHOIPPBJCJD(long EPGJLNEAJPA, CancellationToken IKLHDHMJFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x72C8830", Offset = "0x72C7430", VA = "0x1872C8830", Slot = "6")]
	[AsyncStateMachine(typeof(LHCOCBIGOOO))]
	public Task<BCPENJPKFJJ> PEAAOKBKBKB(long EPGJLNEAJPA, CancellationToken IKLHDHMJFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x72C82F0", Offset = "0x72C6EF0", VA = "0x1872C82F0", Slot = "7")]
	public bool LNIDHMNJDAN(long EPGJLNEAJPA, [Out] int EAGLKPCKNFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x72C6E70", Offset = "0x72C5A70", VA = "0x1872C6E70")]
	[AsyncStateMachine(typeof(DMCPKHKNEIA))]
	private Task<List<JCOCCFMLIAE>> CGBMNICDIKI(RoomListQueryData BAHFLOKBEBD, CancellationToken IKLHDHMJFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x72C72A0", Offset = "0x72C5EA0", VA = "0x1872C72A0")]
	[AsyncStateMachine(typeof(BFMCNPEPCMK))]
	private Task<List<JCOCCFMLIAE>> EPCFHGDKGLD(RoomListQueryData BAHFLOKBEBD, CancellationToken IKLHDHMJFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x72C6420", Offset = "0x72C5020", VA = "0x1872C6420")]
	[AsyncStateMachine(typeof(JIFJILFKMAL))]
	private Task<List<JCOCCFMLIAE>> AAHAHIBAEBH(RoomListQueryData BAHFLOKBEBD, CancellationToken IKLHDHMJFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x72C6FC0", Offset = "0x72C5BC0", VA = "0x1872C6FC0")]
	[AsyncStateMachine(typeof(CIJANIIABPM))]
	private Task<List<JCOCCFMLIAE>> DEADDJJKLBJ(RoomListQueryData BAHFLOKBEBD, CancellationToken IKLHDHMJFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x72C7B30", Offset = "0x72C6730", VA = "0x1872C7B30")]
	[AsyncStateMachine(typeof(FPCGHDEHMHH))]
	private Task<List<JCOCCFMLIAE>> IOKIIFGKHKF(RoomListQueryData BAHFLOKBEBD, CancellationToken IKLHDHMJFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x72C81B0", Offset = "0x72C6DB0", VA = "0x1872C81B0")]
	[AsyncStateMachine(typeof(LCMEFMPHEDD))]
	private Task<List<JCOCCFMLIAE>> LMIICLDHADK(RoomListQueryData BAHFLOKBEBD, CancellationToken IKLHDHMJFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x72C86F0", Offset = "0x72C72F0", VA = "0x1872C86F0")]
	[AsyncStateMachine(typeof(OMIIGJMMCIE))]
	private Task<List<JCOCCFMLIAE>> OPLALGOPGAH(RoomListQueryData BAHFLOKBEBD, CancellationToken IKLHDHMJFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x72C6C00", Offset = "0x72C5800", VA = "0x1872C6C00")]
	[AsyncStateMachine(typeof(MJDIMBNMHPK))]
	private Task<List<JCOCCFMLIAE>> BIPFIMDJJLA(List<long> OIDDDCDNDBC, CancellationToken IKLHDHMJFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x72C8960", Offset = "0x72C7560", VA = "0x1872C8960")]
	[AsyncStateMachine(typeof(AACLODOBJCI))]
	private Task<List<JCOCCFMLIAE>> PFCNJKAFCBP(OBNKFLFMANH HGKLCKDIIGN, int EJCOHHHONCF, int BIGDOCHKBOG, Dictionary<long, string> OOLFOFKPOMO, CancellationToken IKLHDHMJFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x72C7F90", Offset = "0x72C6B90", VA = "0x1872C7F90")]
	[AsyncStateMachine(typeof(IMGFCPPINAB))]
	private Task<IReadOnlyList<JCOCCFMLIAE>> KAAHFLKGKGI(int EJCOHHHONCF, int BIGDOCHKBOG, CancellationToken IKLHDHMJFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x72C80D0", Offset = "0x72C6CD0", VA = "0x1872C80D0")]
	private void LHFBIFPIBDM(List<JCOCCFMLIAE> AHBOLBHGANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x72C6AB0", Offset = "0x72C56B0", VA = "0x1872C6AB0")]
	private bool AKPAMDJIJGP(JCOCCFMLIAE JPHOBLFNMNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x72C8B70", Offset = "0x72C7770", VA = "0x1872C8B70")]
	private void PNFOECDMLGF(List<JCOCCFMLIAE> AHBOLBHGANL, OFBAPGLNKEN FDCLEEBDFHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x72C6A00", Offset = "0x72C5600", VA = "0x1872C6A00")]
	private void AENMINCMEOI(List<JCOCCFMLIAE> AHBOLBHGANL, OFBAPGLNKEN FDCLEEBDFHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x72C7C70", Offset = "0x72C6870", VA = "0x1872C7C70")]
	private void JADMCFCIDJC(List<JCOCCFMLIAE> AHBOLBHGANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x72C8360", Offset = "0x72C6F60", VA = "0x1872C8360")]
	private bool MBPCPFBKPLM(JCOCCFMLIAE JPHOBLFNMNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x17AC2B0", Offset = "0x17AAEB0", VA = "0x1817AC2B0")]
	private bool KOMPFDCACJJ(JCOCCFMLIAE JPHOBLFNMNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x72C8AC0", Offset = "0x72C76C0", VA = "0x1872C8AC0")]
	private void PFFBLLIDMJO(List<JCOCCFMLIAE> AHBOLBHGANL, bool EOAKNLHPNPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x72C7120", Offset = "0x72C5D20", VA = "0x1872C7120")]
	private void EJIPGHHNEFE(List<JCOCCFMLIAE> AHBOLBHGANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x72C6B10", Offset = "0x72C5710", VA = "0x1872C6B10")]
	private bool BGBEEFMDFDG(JCOCCFMLIAE JPHOBLFNMNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x72C7990", Offset = "0x72C6590", VA = "0x1872C7990")]
	private void INIPKEOIPIA(List<JCOCCFMLIAE> AHBOLBHGANL, int HOGOECIJPMO, RoomListQueryData.LAKKHCDDGOO BNNNKMNGIMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x72C7880", Offset = "0x72C6480", VA = "0x1872C7880")]
	private void HOGGBLMHGEH(List<JCOCCFMLIAE> AHBOLBHGANL, bool PHFGKHNJNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x72C76B0", Offset = "0x72C62B0", VA = "0x1872C76B0")]
	private void GGLECEKIDIC(List<JCOCCFMLIAE> AHBOLBHGANL, (int, int)? MHJOLBMHOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x72C6570", Offset = "0x72C5170", VA = "0x1872C6570")]
	private string ADHMKFLNBFN(List<JCOCCFMLIAE> AHBOLBHGANL, string NNHKECADONL, string BJNNMAANCKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x72C73E0", Offset = "0x72C5FE0", VA = "0x1872C73E0")]
	private void GENFCNOMIHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x72C8680", Offset = "0x72C7280", VA = "0x1872C8680")]
	private void NJEPOIELDCP(List<JCOCCFMLIAE> AHBOLBHGANL, int PHMEDJIMOJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x72C8610", Offset = "0x72C7210", VA = "0x1872C8610")]
	private int MLPNNNPNKAP(JCOCCFMLIAE IFMENDFGFGN, JCOCCFMLIAE DPEOCFNLADP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x72C83A0", Offset = "0x72C6FA0", VA = "0x1872C83A0")]
	private int MKFHDIFABHJ(JCOCCFMLIAE JPHOBLFNMNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x72C7E50", Offset = "0x72C6A50", VA = "0x1872C7E50")]
	private void JPNEAIKNJFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class JKICCHHGLMM : ALADGKBEPJH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct KLMBCHDILIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AsyncTaskMethodBuilder<IPHHHIANCDI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public JKICCHHGLMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public FFBHBDHOGKB subRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private TaskAwaiter<DOGBGFIFBGJ<NAKFAFENAFD>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private TaskAwaiter<IPHHHIANCDI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x72CFCC0", Offset = "0x72CE8C0", VA = "0x1872CFCC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x72D01F0", Offset = "0x72CEDF0", VA = "0x1872D01F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct GBOFLFHCKGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder<IPHHHIANCDI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public JKICCHHGLMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public FFBHBDHOGKB subRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<DOGBGFIFBGJ<NAKFAFENAFD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x72CB070", Offset = "0x72C9C70", VA = "0x1872CB070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x72CB570", Offset = "0x72CA170", VA = "0x1872CB570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private List<IPHHHIANCDI> LJIEFCHKLJD;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x72CDE90", Offset = "0x72CCA90", VA = "0x1872CDE90")]
	[DMDJPIBKEJJ.OPKFCOALFMB.IBOCCFBJPBC]
	internal static void HMDEJEGKIBO(KPLLBHIBBNH AGGFAPJEEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x72CE040", Offset = "0x72CCC40", VA = "0x1872CE040")]
	[RecRoom.NoEngine.Common.Preserve]
	public JKICCHHGLMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x72CDF00", Offset = "0x72CCB00", VA = "0x1872CDF00", Slot = "4")]
	[AsyncStateMachine(typeof(KLMBCHDILIJ))]
	public Task<IPHHHIANCDI> NJJOHGAILJB(FFBHBDHOGKB ICHBBGHLOON, CancellationToken IKLHDHMJFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x72CDD50", Offset = "0x72CC950", VA = "0x1872CDD50", Slot = "5")]
	[AsyncStateMachine(typeof(GBOFLFHCKGE))]
	public Task<IPHHHIANCDI> AHLHEHIKHPO(FFBHBDHOGKB ICHBBGHLOON, CancellationToken IKLHDHMJFFL)
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
