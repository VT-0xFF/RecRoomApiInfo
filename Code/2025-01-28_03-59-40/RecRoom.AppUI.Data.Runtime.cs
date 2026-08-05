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
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
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
		[Cpp2IlInjected.Address(RVA = "0x704AD70", Offset = "0x7049F70", VA = "0x18704AD70")]
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
namespace _AssemblyRegistry.RecRoom_AppUI_Data_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x704D4F0", Offset = "0x704C6F0", VA = "0x18704D4F0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x23EA930", Offset = "0x23E9B30", VA = "0x1823EA930")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class EBMFHNOGPOD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct HGDFMDPLNMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<List<bool>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public List<GLPOHAHMIGG> roomSaves;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private GCBLFMPAFLE <roomsClient>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private List<bool> <results>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private List<GLPOHAHMIGG>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7046990", Offset = "0x7045B90", VA = "0x187046990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7047040", Offset = "0x7046240", VA = "0x187047040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct LCIFMDMGNDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AsyncTaskMethodBuilder<GLPOHAHMIGG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public List<GLPOHAHMIGG> roomSaves;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private GCBLFMPAFLE <roomsClient>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private List<GLPOHAHMIGG>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private GLPOHAHMIGG <roomSave>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7048430", Offset = "0x7047630", VA = "0x187048430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7048A70", Offset = "0x7047C70", VA = "0x187048A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x703F200", Offset = "0x703E400", VA = "0x18703F200")]
	[AsyncStateMachine(typeof(HGDFMDPLNMP))]
	public static Task<List<bool>> JIFILBLNGJO(List<GLPOHAHMIGG> PFCLGMIPNDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x703F0F0", Offset = "0x703E2F0", VA = "0x18703F0F0")]
	[AsyncStateMachine(typeof(LCIFMDMGNDE))]
	public static Task<GLPOHAHMIGG> CNFPGAPNFIC(List<GLPOHAHMIGG> PFCLGMIPNDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class DNNPKCBGKOI : NOADEEKBJOD
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class EKIBCLILGFN : IEquatable<EKIBCLILGFN>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public long MELEKCADECD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public long DHEBGGJJHAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public int LJGBCKKDLOP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected virtual Type FEMMFGFHKNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x703F680", Offset = "0x703E880", VA = "0x18703F680", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x703F950", Offset = "0x703EB50", VA = "0x18703F950")]
		public EKIBCLILGFN(long NCEMOPPICCG, long OPKJNOJBOAB, int HBJKAENMGFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x703F840", Offset = "0x703EA40", VA = "0x18703F840", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x703F310", Offset = "0x703E510", VA = "0x18703F310", Slot = "6")]
		protected virtual bool EEMOKFJFMOB(StringBuilder NAIHAIAEIFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x703F6E0", Offset = "0x703E8E0", VA = "0x18703F6E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x703F5F0", Offset = "0x703E7F0", VA = "0x18703F5F0", Slot = "0")]
		public override bool Equals(object? LCACGJDNDHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x703F470", Offset = "0x703E670", VA = "0x18703F470", Slot = "7")]
		public virtual bool Equals(EKIBCLILGFN? JAINJPLCLDO)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct MNLPBIKAEPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<List<long>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public DNNPKCBGKOI <>4__this;

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
		private List<AOOMHJBAKPO> <myClubs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private TaskAwaiter<List<AOOMHJBAKPO>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x704A290", Offset = "0x7049490", VA = "0x18704A290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x704AA70", Offset = "0x7049C70", VA = "0x18704AA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct CMLNGCLNJDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public DNNPKCBGKOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<IReadOnlyList<KGIHPNJIMOG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x703E030", Offset = "0x703D230", VA = "0x18703E030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x703E510", Offset = "0x703D710", VA = "0x18703E510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private NHKBIEIPOHH NPPPAKEHEAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private List<AOOMHJBAKPO> BHFLPIMPEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private Dictionary<long, EKIBCLILGFN> IHIKCOEKLBN;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x703EA90", Offset = "0x703DC90", VA = "0x18703EA90")]
	[NAOGKPPNIGE.AGGBMPJIOLK.IPOKDFJKKKA]
	internal static void BHMHEMCKFJH(JBPONICDCIO CKNPDKKKGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x703F020", Offset = "0x703E220", VA = "0x18703F020")]
	[RecRoom.NoEngine.Common.Preserve]
	public DNNPKCBGKOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x703EBF0", Offset = "0x703DDF0", VA = "0x18703EBF0", Slot = "4")]
	[AsyncStateMachine(typeof(MNLPBIKAEPN))]
	public Task<List<long>> JPBBJOOOGCF(bool MONNIKAAGMI, int CKAENKEABLC, CancellationToken BCOHKLCJCPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x703EB00", Offset = "0x703DD00", VA = "0x18703EB00")]
	[AsyncStateMachine(typeof(CMLNGCLNJDO))]
	private Task FFBKIOOOOBL(CancellationToken BCOHKLCJCPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x703ED40", Offset = "0x703DF40", VA = "0x18703ED40")]
	private void LDKHIAGIKLP(List<AOOMHJBAKPO> GNELIEHKHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x703EE40", Offset = "0x703E040", VA = "0x18703EE40")]
	private int NHONIKKGALH(AOOMHJBAKPO FBCBJPMNPEK, AOOMHJBAKPO HHDMEFHBCOI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class FAFNECMNIDC : DOBANDLDJLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly FDGPEFHHCNB CLLJOHBFGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[CompilerGenerated]
	private Action GFBKELGNLNG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private bool PLHCINFCECL
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8FA8F0", Offset = "0x8F9AF0", VA = "0x1808FA8F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7040910", Offset = "0x703FB10", VA = "0x187040910")]
	[NAOGKPPNIGE.AGGBMPJIOLK.IPOKDFJKKKA]
	internal static void BHMHEMCKFJH(JBPONICDCIO CKNPDKKKGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x902B20", Offset = "0x901D20", VA = "0x180902B20")]
	[RecRoom.NoEngine.Common.Preserve]
	public FAFNECMNIDC([FMJHJHHALCB(null)] FDGPEFHHCNB CLLJOHBFGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7040BB0", Offset = "0x703FDB0", VA = "0x187040BB0", Slot = "4")]
	public bool MCJNPBGJFEK(ADGABPOJFPO PBPEOMJKKKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x70409A0", Offset = "0x703FBA0", VA = "0x1870409A0", Slot = "5")]
	public void FAONLEIKGBI(OAOBEPBAJLE BGDELDLHBMB, CNMPJHKKKIM PIBGHFKDAOK, bool JDNCDKFOJGA, PNIOOCKILGF IGFMGKDOOHI, [Optional] GLPOHAHMIGG AHGOPEHCPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7040980", Offset = "0x703FB80", VA = "0x187040980")]
	private void EHBKJLFKEDG(KEPBPDFKJKB NJFLHCEDIDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class FHNIBBOFCPH : BHNGCGAOKPE
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class AEFBHHFGLFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public string KDDNKOPIMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public HashSet<long> LCNBCAOJDCD;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x703DF80", Offset = "0x703D180", VA = "0x18703DF80")]
		public AEFBHHFGLFA()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct FBAPHENMMNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<List<ADGABPOJFPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public FHNIBBOFCPH <>4__this;

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
		private List<ADGABPOJFPO> <roomList>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter<List<ADGABPOJFPO>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private object <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7040BE0", Offset = "0x703FDE0", VA = "0x187040BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7042770", Offset = "0x7041970", VA = "0x187042770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct NDPFLKMDEEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<ADGABPOJFPO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public FHNIBBOFCPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<ADGABPOJFPO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x704AAE0", Offset = "0x7049CE0", VA = "0x18704AAE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x704AD00", Offset = "0x7049F00", VA = "0x18704AD00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct ELGHJJCKLIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<OAOBEPBAJLE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public FHNIBBOFCPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<OAOBEPBAJLE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x703F9A0", Offset = "0x703EBA0", VA = "0x18703F9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x703FBD0", Offset = "0x703EDD0", VA = "0x18703FBD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct ELPMPEJBNFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<List<ADGABPOJFPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public FHNIBBOFCPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<IReadOnlyList<ADGABPOJFPO>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter<List<long>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private TaskAwaiter<List<ADGABPOJFPO>> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x703FC40", Offset = "0x703EE40", VA = "0x18703FC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x70408A0", Offset = "0x703FAA0", VA = "0x1870408A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct LDBNBJJICDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public AsyncTaskMethodBuilder<List<ADGABPOJFPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public FHNIBBOFCPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter<IReadOnlyList<ADGABPOJFPO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7048AE0", Offset = "0x7047CE0", VA = "0x187048AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7049830", Offset = "0x7048A30", VA = "0x187049830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct FPDJJJIHIEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AsyncTaskMethodBuilder<List<ADGABPOJFPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public FHNIBBOFCPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private Task<NACFKIPJPJK> <queryTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private TaskAwaiter<NACFKIPJPJK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TaskAwaiter<List<ADGABPOJFPO>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private TaskAwaiter<GLPACAEBEMM> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter<IReadOnlyList<ADGABPOJFPO>> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7045170", Offset = "0x7044370", VA = "0x187045170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x70465A0", Offset = "0x70457A0", VA = "0x1870465A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct ONCBFHIOGNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AsyncTaskMethodBuilder<List<ADGABPOJFPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public FHNIBBOFCPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<JFDMGCFJKGH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private TaskAwaiter<List<ADGABPOJFPO>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private TaskAwaiter<IReadOnlyList<ADGABPOJFPO>> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private TaskAwaiter<IReadOnlyList<JBCOMFNALJF>> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private Task<ADGABPOJFPO> <recCenterTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Task<IReadOnlyList<ADGABPOJFPO>> <recentRoomsTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private Task<IReadOnlyList<ADGABPOJFPO>> <creatorsISubscribeToRoomTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private TaskAwaiter <>u__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private TaskAwaiter<JBCOMFNALJF> <>u__6;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x704B4F0", Offset = "0x704A6F0", VA = "0x18704B4F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x704D480", Offset = "0x704C680", VA = "0x18704D480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct OAJGEKBEGLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public AsyncTaskMethodBuilder<List<ADGABPOJFPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public FHNIBBOFCPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private Task<IReadOnlyList<ADGABPOJFPO>> <myOwnedRoomsTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private Task<IReadOnlyList<ADGABPOJFPO>> <clubhouseTemplateRoomsTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter<IReadOnlyList<ADGABPOJFPO>[]> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x704ADF0", Offset = "0x7049FF0", VA = "0x18704ADF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x704B480", Offset = "0x704A680", VA = "0x18704B480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct JAGIHKAOMJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public AsyncTaskMethodBuilder<List<ADGABPOJFPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public FHNIBBOFCPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter<List<ADGABPOJFPO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7047810", Offset = "0x7046A10", VA = "0x187047810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7047BF0", Offset = "0x7046DF0", VA = "0x187047BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct JMEBKIBEFIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public AsyncTaskMethodBuilder<List<ADGABPOJFPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public FHNIBBOFCPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<List<ADGABPOJFPO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7047C60", Offset = "0x7046E60", VA = "0x187047C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7048100", Offset = "0x7047300", VA = "0x187048100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct KKOHGKNPNIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public AsyncTaskMethodBuilder<List<ADGABPOJFPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public List<long> idList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter<IReadOnlyList<ADGABPOJFPO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7048170", Offset = "0x7047370", VA = "0x187048170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x70483C0", Offset = "0x70475C0", VA = "0x1870483C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct IPLGAFABGEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder<List<ADGABPOJFPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public JFDMGCFJKGH algorithmicList;

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
		public FHNIBBOFCPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter<IReadOnlyList<ADGABPOJFPO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x70470B0", Offset = "0x70462B0", VA = "0x1870470B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x70477A0", Offset = "0x70469A0", VA = "0x1870477A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct LINEIALCHPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncTaskMethodBuilder<IReadOnlyList<ADGABPOJFPO>> <>t__builder;

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
		public FHNIBBOFCPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private TaskAwaiter<List<int>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<IReadOnlyList<ADGABPOJFPO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x70498A0", Offset = "0x7048AA0", VA = "0x1870498A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7049C80", Offset = "0x7048E80", VA = "0x187049C80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private DEGKPLDMDPH FFIHFEFPIBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private NHKBIEIPOHH NPPPAKEHEAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NOADEEKBJOD ELPAJGIKKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private AFJINEAEPKI APAGJACOOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private BAFCNJJFGLN MINAOELMCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private BHGEBPAJCJG KFGGNNGBAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private DAFHFNLOIHA DIIHDCJHINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<string, List<AEFBHHFGLFA>> DKKLPNADOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private HashSet<long> PJBPEDPCENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private StringBuilder NAIHAIAEIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, int> CEFBBFNFBGG;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7042940", Offset = "0x7041B40", VA = "0x187042940")]
	[NAOGKPPNIGE.AGGBMPJIOLK.IPOKDFJKKKA]
	internal static void BHMHEMCKFJH(JBPONICDCIO CKNPDKKKGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7044FE0", Offset = "0x70441E0", VA = "0x187044FE0")]
	[RecRoom.NoEngine.Common.Preserve]
	public FHNIBBOFCPH([FMJHJHHALCB(null)] DEGKPLDMDPH FFIHFEFPIBD, [FMJHJHHALCB(null)] NHKBIEIPOHH NPPPAKEHEAC, [FMJHJHHALCB(null)] NOADEEKBJOD ELPAJGIKKLO, [FMJHJHHALCB(null)] AFJINEAEPKI APAGJACOOAN, [FMJHJHHALCB(null)] DAFHFNLOIHA POIDAFKFBPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7043F20", Offset = "0x7043120", VA = "0x187043F20", Slot = "4")]
	[AsyncStateMachine(typeof(FBAPHENMMNJ))]
	public Task<List<ADGABPOJFPO>> JMCLJIBEDPD(RoomListQueryData APCBJIPDHLK, CancellationToken BCOHKLCJCPM, [Optional] Func<bool> HKHONNDNJIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7043080", Offset = "0x7042280", VA = "0x187043080", Slot = "5")]
	[AsyncStateMachine(typeof(NDPFLKMDEEO))]
	public Task<ADGABPOJFPO> EEDILAMAACI(long MOMKFNIIPAA, CancellationToken BCOHKLCJCPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7044380", Offset = "0x7043580", VA = "0x187044380", Slot = "6")]
	[AsyncStateMachine(typeof(ELGHJJCKLIF))]
	public Task<OAOBEPBAJLE> MJNHMHCDOJG(long MOMKFNIIPAA, CancellationToken BCOHKLCJCPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x70442D0", Offset = "0x70434D0", VA = "0x1870442D0", Slot = "7")]
	public bool LPJGJCJIKPP(long MOMKFNIIPAA, [Out] int COKGNHFKNEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7044C70", Offset = "0x7043E70", VA = "0x187044C70")]
	[AsyncStateMachine(typeof(ELPMPEJBNFH))]
	private Task<List<ADGABPOJFPO>> OKCIDLBBCGC(RoomListQueryData APCBJIPDHLK, CancellationToken BCOHKLCJCPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7044940", Offset = "0x7043B40", VA = "0x187044940")]
	[AsyncStateMachine(typeof(LDBNBJJICDC))]
	private Task<List<ADGABPOJFPO>> MOFDNKOIHDD(RoomListQueryData APCBJIPDHLK, CancellationToken BCOHKLCJCPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7043660", Offset = "0x7042860", VA = "0x187043660")]
	[AsyncStateMachine(typeof(FPDJJJIHIEE))]
	private Task<List<ADGABPOJFPO>> FPOEPOOOBIO(RoomListQueryData APCBJIPDHLK, CancellationToken BCOHKLCJCPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7043500", Offset = "0x7042700", VA = "0x187043500")]
	[AsyncStateMachine(typeof(ONCBFHIOGNH))]
	private Task<List<ADGABPOJFPO>> FOEGLEGDIJP(RoomListQueryData APCBJIPDHLK, CancellationToken BCOHKLCJCPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x70438F0", Offset = "0x7042AF0", VA = "0x1870438F0")]
	[AsyncStateMachine(typeof(OAJGEKBEGLB))]
	private Task<List<ADGABPOJFPO>> GNDBANLAMFJ(RoomListQueryData APCBJIPDHLK, CancellationToken BCOHKLCJCPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x70437B0", Offset = "0x70429B0", VA = "0x1870437B0")]
	[AsyncStateMachine(typeof(JAGIHKAOMJA))]
	private Task<List<ADGABPOJFPO>> GGNLCABPDPJ(RoomListQueryData APCBJIPDHLK, CancellationToken BCOHKLCJCPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7044190", Offset = "0x7043390", VA = "0x187044190")]
	[AsyncStateMachine(typeof(JMEBKIBEFIP))]
	private Task<List<ADGABPOJFPO>> LEKIIPDOPDC(RoomListQueryData APCBJIPDHLK, CancellationToken BCOHKLCJCPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7044080", Offset = "0x7043280", VA = "0x187044080")]
	[AsyncStateMachine(typeof(KKOHGKNPNIP))]
	private Task<List<ADGABPOJFPO>> KCEHBPFFICA(List<long> LGEOCNDJLPK, CancellationToken BCOHKLCJCPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7043D50", Offset = "0x7042F50", VA = "0x187043D50")]
	[AsyncStateMachine(typeof(IPLGAFABGEF))]
	private Task<List<ADGABPOJFPO>> IFFLJADNEKN(JFDMGCFJKGH MDJONKFKEEG, int JJJCHFOKNGJ, int JANFFOPEAIJ, Dictionary<long, string> JCPLEMBNGAA, CancellationToken BCOHKLCJCPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x70429B0", Offset = "0x7041BB0", VA = "0x1870429B0")]
	[AsyncStateMachine(typeof(LINEIALCHPL))]
	private Task<IReadOnlyList<ADGABPOJFPO>> BJFJNNCBBBF(int JJJCHFOKNGJ, int JANFFOPEAIJ, CancellationToken BCOHKLCJCPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7042BA0", Offset = "0x7041DA0", VA = "0x187042BA0")]
	private void DOCJAMPIJEP(List<ADGABPOJFPO> NAFCCDGEMGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7044E70", Offset = "0x7044070", VA = "0x187044E70")]
	private bool OLACJINJFFF(ADGABPOJFPO PBPEOMJKKKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x70432B0", Offset = "0x70424B0", VA = "0x1870432B0")]
	private void EGPNHPJLBME(List<ADGABPOJFPO> NAFCCDGEMGP, JLOPKLONJGG PCDIJANPPEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7042AF0", Offset = "0x7041CF0", VA = "0x187042AF0")]
	private void BLFPNCGKANM(List<ADGABPOJFPO> NAFCCDGEMGP, JLOPKLONJGG PCDIJANPPEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7044DC0", Offset = "0x7043FC0", VA = "0x187044DC0")]
	private void OKPLFBKJDHF(List<ADGABPOJFPO> NAFCCDGEMGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7044340", Offset = "0x7043540", VA = "0x187044340")]
	private bool MAKDPHEKKIF(ADGABPOJFPO PBPEOMJKKKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7043CA0", Offset = "0x7042EA0", VA = "0x187043CA0")]
	private void IEOGAMHBCFH(List<ADGABPOJFPO> NAFCCDGEMGP, bool PGLMCJKJMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7044AF0", Offset = "0x7043CF0", VA = "0x187044AF0")]
	private void OJICIMKKHPJ(List<ADGABPOJFPO> NAFCCDGEMGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x70431B0", Offset = "0x70423B0", VA = "0x1870431B0")]
	private bool EGKIBDFPBFD(ADGABPOJFPO PBPEOMJKKKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7043360", Offset = "0x7042560", VA = "0x187043360")]
	private void EMJIKAJFEEA(List<ADGABPOJFPO> NAFCCDGEMGP, int GOLPFJHCONJ, RoomListQueryData.BNODGNGLEAG DNPJDOEIFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7044ED0", Offset = "0x70440D0", VA = "0x187044ED0")]
	private void PMNNPDHGDDE(List<ADGABPOJFPO> NAFCCDGEMGP, bool PCBCGJFDOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x70427E0", Offset = "0x70419E0", VA = "0x1870427E0")]
	private void AELMMDEKILM(List<ADGABPOJFPO> NAFCCDGEMGP, (int, int)? KBIKEPPGEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x70444B0", Offset = "0x70436B0", VA = "0x1870444B0")]
	private string MKOECDBANHP(List<ADGABPOJFPO> NAFCCDGEMGP, string CMHCBPNBFEB, string HPIAOILIGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7042DC0", Offset = "0x7041FC0", VA = "0x187042DC0")]
	private void ECDPDMAPHOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7044A80", Offset = "0x7043C80", VA = "0x187044A80")]
	private void NJKENFJCKON(List<ADGABPOJFPO> NAFCCDGEMGP, int CANKCBFJEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7043EB0", Offset = "0x70430B0", VA = "0x187043EB0")]
	private int ILEOKPGJJNH(ADGABPOJFPO FBCBJPMNPEK, ADGABPOJFPO HHDMEFHBCOI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7043A30", Offset = "0x7042C30", VA = "0x187043A30")]
	private int HKHDBDBFLGP(ADGABPOJFPO PBPEOMJKKKC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7042C80", Offset = "0x7041E80", VA = "0x187042C80")]
	private void ECACMNHMMOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class GOAKFKMGJOF : DGCJNLNOHCD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct LLOHJIAIIKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AsyncTaskMethodBuilder<GLPOHAHMIGG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public GOAKFKMGJOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public CNMPJHKKKIM subRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private TaskAwaiter<FCDHELLKKAK<GLPOHAHMIGG>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private TaskAwaiter<GLPOHAHMIGG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7049CF0", Offset = "0x7048EF0", VA = "0x187049CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x704A220", Offset = "0x7049420", VA = "0x18704A220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct DFJLKIBGDKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder<GLPOHAHMIGG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public GOAKFKMGJOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public CNMPJHKKKIM subRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<FCDHELLKKAK<GLPOHAHMIGG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x703E570", Offset = "0x703D770", VA = "0x18703E570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x703EA20", Offset = "0x703DC20", VA = "0x18703EA20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private List<GLPOHAHMIGG> JAPKNCDPCAM;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7046610", Offset = "0x7045810", VA = "0x187046610")]
	[NAOGKPPNIGE.AGGBMPJIOLK.IPOKDFJKKKA]
	internal static void BHMHEMCKFJH(JBPONICDCIO CKNPDKKKGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7046900", Offset = "0x7045B00", VA = "0x187046900")]
	[RecRoom.NoEngine.Common.Preserve]
	public GOAKFKMGJOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x70467C0", Offset = "0x70459C0", VA = "0x1870467C0", Slot = "4")]
	[AsyncStateMachine(typeof(LLOHJIAIIKF))]
	public Task<GLPOHAHMIGG> IJOOKAJJHHH(CNMPJHKKKIM PIBGHFKDAOK, CancellationToken BCOHKLCJCPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7046680", Offset = "0x7045880", VA = "0x187046680", Slot = "5")]
	[AsyncStateMachine(typeof(DFJLKIBGDKB))]
	public Task<GLPOHAHMIGG> ECLIOLLNFHJ(CNMPJHKKKIM PIBGHFKDAOK, CancellationToken BCOHKLCJCPM)
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
