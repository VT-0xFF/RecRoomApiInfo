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
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E24B40", Offset = "0x6E23F40", VA = "0x186E24B40")]
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
namespace _AssemblyRegistry.RecRoom_AppUI_Data_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6E2A960", Offset = "0x6E29D60", VA = "0x186E2A960", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2200990", Offset = "0x21FFD90", VA = "0x182200990")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class KNBOLKHCMGJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct AOPBHMDACGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<List<bool>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public List<GNODDIAAKFD> roomSaves;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private FAOLBBDMMOC <roomsClient>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private List<bool> <results>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private List<GNODDIAAKFD>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6E1D040", Offset = "0x6E1C440", VA = "0x186E1D040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6E1D6F0", Offset = "0x6E1CAF0", VA = "0x186E1D6F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct JFJKGNJCODA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AsyncTaskMethodBuilder<GNODDIAAKFD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public List<GNODDIAAKFD> roomSaves;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private FAOLBBDMMOC <roomsClient>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private List<GNODDIAAKFD>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private GNODDIAAKFD <roomSave>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6E22290", Offset = "0x6E21690", VA = "0x186E22290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6E228D0", Offset = "0x6E21CD0", VA = "0x186E228D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6E241E0", Offset = "0x6E235E0", VA = "0x186E241E0")]
	[AsyncStateMachine(typeof(AOPBHMDACGK))]
	public static Task<List<bool>> LPAOBALFOKP(List<GNODDIAAKFD> NHGMLNGPKGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6E240D0", Offset = "0x6E234D0", VA = "0x186E240D0")]
	[AsyncStateMachine(typeof(JFJKGNJCODA))]
	public static Task<GNODDIAAKFD> KELMFEIDAFL(List<GNODDIAAKFD> NHGMLNGPKGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class JMCCNGIAGLJ : OMJBMNDENLE
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class BEPECFGIIBG : IEquatable<BEPECFGIIBG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public long IBJNFJAKGGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public long DBIBMPFHLJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public int LNJIAAKDNHP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected virtual Type CIPCMABGEED
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6E1EBF0", Offset = "0x6E1DFF0", VA = "0x186E1EBF0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F230", Offset = "0x6E1E630", VA = "0x186E1F230")]
		public BEPECFGIIBG(long DOLNFCKLGNL, long IFOLMFABDDF, int GCHAHPEIGHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F120", Offset = "0x6E1E520", VA = "0x186E1F120", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6E1EC50", Offset = "0x6E1E050", VA = "0x186E1EC50", Slot = "6")]
		protected virtual bool CFCDDFGMHCJ(StringBuilder HJDHIEFHLEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6E1EFC0", Offset = "0x6E1E3C0", VA = "0x186E1EFC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6E1EDB0", Offset = "0x6E1E1B0", VA = "0x186E1EDB0", Slot = "0")]
		public override bool Equals(object? NCHBKHMIMGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6E1EE40", Offset = "0x6E1E240", VA = "0x186E1EE40", Slot = "7")]
		public virtual bool Equals(BEPECFGIIBG? BMKPAKCEMFK)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct NMLCNJMJMOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<List<long>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public JMCCNGIAGLJ <>4__this;

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
		private List<EJECLCMBIHF> <myClubs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private TaskAwaiter<List<EJECLCMBIHF>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6E242F0", Offset = "0x6E236F0", VA = "0x186E242F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6E24AD0", Offset = "0x6E23ED0", VA = "0x186E24AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct KADNNMLKLEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public JMCCNGIAGLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<IReadOnlyList<JNFFBAECOOC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6E233F0", Offset = "0x6E227F0", VA = "0x186E233F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6E238D0", Offset = "0x6E22CD0", VA = "0x186E238D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private OPACFMPIKLJ FFOPLHPMAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private List<EJECLCMBIHF> NPDHMLMMIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private Dictionary<long, BEPECFGIIBG> MAMKHEMMMGP;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6E232B0", Offset = "0x6E226B0", VA = "0x186E232B0")]
	[AGCFNMIICNN.HNNLCOLGEGD.DNCHPFJACPB]
	internal static void OHHPJPBCCIE(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6E23320", Offset = "0x6E22720", VA = "0x186E23320")]
	[RecRoom.NoEngine.Common.Preserve]
	public JMCCNGIAGLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6E22D90", Offset = "0x6E22190", VA = "0x186E22D90", Slot = "4")]
	[AsyncStateMachine(typeof(NMLCNJMJMOB))]
	public Task<List<long>> BKFBBHKLCKO(bool BAHKHONNKBA, int EAINDCGPNCK, CancellationToken CMNJCPJBHGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6E22EE0", Offset = "0x6E222E0", VA = "0x186E22EE0")]
	[AsyncStateMachine(typeof(KADNNMLKLEL))]
	private Task CGDEDOCHEOH(CancellationToken CMNJCPJBHGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6E22FD0", Offset = "0x6E223D0", VA = "0x186E22FD0")]
	private void KKKHNOJOGCH(List<EJECLCMBIHF> MILNHJBBKON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6E230D0", Offset = "0x6E224D0", VA = "0x186E230D0")]
	private int MHEJLEBEMMD(EJECLCMBIHF FGFJFGGJOII, EJECLCMBIHF CABLGFIBABJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class GBMDGCFEJCD : AIDPAHIFJDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly PDJDNBCIJIJ PDMLDPAAAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[CompilerGenerated]
	private Action IDNABBKHHHI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private bool GKFELILNDFC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8CE810", Offset = "0x8CDC10", VA = "0x1808CE810")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6E20C30", Offset = "0x6E20030", VA = "0x186E20C30")]
	[AGCFNMIICNN.HNNLCOLGEGD.DNCHPFJACPB]
	internal static void OHHPJPBCCIE(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8CADF0", Offset = "0x8CA1F0", VA = "0x1808CADF0")]
	[RecRoom.NoEngine.Common.Preserve]
	public GBMDGCFEJCD([CNGCCDLPGOD(null)] PDJDNBCIJIJ PDMLDPAAAOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6E209C0", Offset = "0x6E1FDC0", VA = "0x186E209C0", Slot = "4")]
	public bool DPAOMNDEDMO(PIPCEIFGMAA MFIGDOAMPLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6E209F0", Offset = "0x6E1FDF0", VA = "0x186E209F0", Slot = "5")]
	public void GCEABLLAAMA(NLMAEEICDJF CIOKBAAIBPO, BEANCEBHDPC ELONMONDCOI, bool HFOCFDLPOMD, PJONPPOEIME EDDJKDEFFLJ, [Optional] GNODDIAAKFD JMJPKINNKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6E20C10", Offset = "0x6E20010", VA = "0x186E20C10")]
	private void INKGOBJJDHF(PNNJPJHHLAH CEDDFJCBLGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class PAHCJEEIOPF : JOLGMCMGLGG
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class HKMCNLMKLDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public string JAGDNDKNHPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public HashSet<long> PDOMGGFCNCF;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6E218C0", Offset = "0x6E20CC0", VA = "0x186E218C0")]
		public HKMCNLMKLDD()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct AGDFMFFKNPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<List<PIPCEIFGMAA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public PAHCJEEIOPF <>4__this;

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
		private List<PIPCEIFGMAA> <roomList>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter<List<PIPCEIFGMAA>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private object <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B450", Offset = "0x6E1A850", VA = "0x186E1B450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6E1CFD0", Offset = "0x6E1C3D0", VA = "0x186E1CFD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct KHGONFNKAKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<PIPCEIFGMAA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public PAHCJEEIOPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<PIPCEIFGMAA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6E23E40", Offset = "0x6E23240", VA = "0x186E23E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6E24060", Offset = "0x6E23460", VA = "0x186E24060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct DGGIPCCEHEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<NLMAEEICDJF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public PAHCJEEIOPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<NLMAEEICDJF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F970", Offset = "0x6E1ED70", VA = "0x186E1F970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6E1FBA0", Offset = "0x6E1EFA0", VA = "0x186E1FBA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct ONDHCIEJCHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<List<PIPCEIFGMAA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public PAHCJEEIOPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<IReadOnlyList<PIPCEIFGMAA>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter<List<long>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private TaskAwaiter<List<PIPCEIFGMAA>> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6E24BC0", Offset = "0x6E23FC0", VA = "0x186E24BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6E25810", Offset = "0x6E24C10", VA = "0x186E25810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct EKKOEJIKKCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public AsyncTaskMethodBuilder<List<PIPCEIFGMAA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public PAHCJEEIOPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter<IReadOnlyList<PIPCEIFGMAA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6E1FC10", Offset = "0x6E1F010", VA = "0x186E1FC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6E20950", Offset = "0x6E1FD50", VA = "0x186E20950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct BDILDNAIHOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AsyncTaskMethodBuilder<List<PIPCEIFGMAA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public PAHCJEEIOPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private Task<MGOHKNABCIO> <queryTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private TaskAwaiter<MGOHKNABCIO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TaskAwaiter<List<PIPCEIFGMAA>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private TaskAwaiter<NANBBMHGFMA> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter<IReadOnlyList<PIPCEIFGMAA>> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6E1D760", Offset = "0x6E1CB60", VA = "0x186E1D760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6E1EB80", Offset = "0x6E1DF80", VA = "0x186E1EB80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct PGBHJNMEFPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AsyncTaskMethodBuilder<List<PIPCEIFGMAA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public PAHCJEEIOPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<LFOIMCNNKJJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private TaskAwaiter<List<PIPCEIFGMAA>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private TaskAwaiter<IReadOnlyList<PIPCEIFGMAA>> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private TaskAwaiter<IReadOnlyList<NBPCMONDFFE>> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private Task<PIPCEIFGMAA> <recCenterTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Task<IReadOnlyList<PIPCEIFGMAA>> <recentRoomsTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private Task<IReadOnlyList<PIPCEIFGMAA>> <creatorsISubscribeToRoomTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private TaskAwaiter <>u__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private TaskAwaiter<NBPCMONDFFE> <>u__6;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6E28200", Offset = "0x6E27600", VA = "0x186E28200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6E2A190", Offset = "0x6E29590", VA = "0x186E2A190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct HENLMFGDIMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public AsyncTaskMethodBuilder<List<PIPCEIFGMAA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public PAHCJEEIOPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private Task<IReadOnlyList<PIPCEIFGMAA>> <myOwnedRoomsTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private Task<IReadOnlyList<PIPCEIFGMAA>> <clubhouseTemplateRoomsTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter<IReadOnlyList<PIPCEIFGMAA>[]> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6E211C0", Offset = "0x6E205C0", VA = "0x186E211C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6E21850", Offset = "0x6E20C50", VA = "0x186E21850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct JKNBIIECGEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public AsyncTaskMethodBuilder<List<PIPCEIFGMAA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public PAHCJEEIOPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter<List<PIPCEIFGMAA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6E22940", Offset = "0x6E21D40", VA = "0x186E22940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6E22D20", Offset = "0x6E22120", VA = "0x186E22D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct KFIBDFPONEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public AsyncTaskMethodBuilder<List<PIPCEIFGMAA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public PAHCJEEIOPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<List<PIPCEIFGMAA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6E23930", Offset = "0x6E22D30", VA = "0x186E23930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6E23DD0", Offset = "0x6E231D0", VA = "0x186E23DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct CJGCAJNOIJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public AsyncTaskMethodBuilder<List<PIPCEIFGMAA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public List<long> idList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter<IReadOnlyList<PIPCEIFGMAA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F6C0", Offset = "0x6E1EAC0", VA = "0x186E1F6C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F900", Offset = "0x6E1ED00", VA = "0x186E1F900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct POIOGGFLLEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder<List<PIPCEIFGMAA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public LFOIMCNNKJJ algorithmicList;

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
		public PAHCJEEIOPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter<IReadOnlyList<PIPCEIFGMAA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6E2A200", Offset = "0x6E29600", VA = "0x186E2A200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6E2A8F0", Offset = "0x6E29CF0", VA = "0x186E2A8F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct CFMDDCGHDNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncTaskMethodBuilder<IReadOnlyList<PIPCEIFGMAA>> <>t__builder;

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
		public PAHCJEEIOPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private TaskAwaiter<List<int>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<IReadOnlyList<PIPCEIFGMAA>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F280", Offset = "0x6E1E680", VA = "0x186E1F280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F650", Offset = "0x6E1EA50", VA = "0x186E1F650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private PBMDMFNAGKG NPHJHEOIMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private OPACFMPIKLJ FFOPLHPMAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private OMJBMNDENLE NFHBGHAEPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private AJCHOFIOKBP OMPDJEGMEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private GDPBDJEECFD MANPNEOGDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private PHKJMBBDPIH JGMHIOEOBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private DLCOEACENMD ACKKCOBHOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<string, List<HKMCNLMKLDD>> BOJCOKCFMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private HashSet<long> IOIAGILELJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private StringBuilder HJDHIEFHLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, int> MIHBBMGAAOP;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6E27630", Offset = "0x6E26A30", VA = "0x186E27630")]
	[AGCFNMIICNN.HNNLCOLGEGD.DNCHPFJACPB]
	internal static void OHHPJPBCCIE(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6E28070", Offset = "0x6E27470", VA = "0x186E28070")]
	[RecRoom.NoEngine.Common.Preserve]
	public PAHCJEEIOPF([CNGCCDLPGOD(null)] PBMDMFNAGKG NPHJHEOIMPF, [CNGCCDLPGOD(null)] OPACFMPIKLJ FFOPLHPMAIN, [CNGCCDLPGOD(null)] OMJBMNDENLE NFHBGHAEPBC, [CNGCCDLPGOD(null)] AJCHOFIOKBP OMPDJEGMEOI, [CNGCCDLPGOD(null)] DLCOEACENMD PIDFKCNJJLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6E26790", Offset = "0x6E25B90", VA = "0x186E26790", Slot = "4")]
	[AsyncStateMachine(typeof(AGDFMFFKNPB))]
	public Task<List<PIPCEIFGMAA>> HFOEPNJKKKE(RoomListQueryData GLMFHHIGGDM, CancellationToken CMNJCPJBHGE, [Optional] Func<bool> PIBLGJMMGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6E27260", Offset = "0x6E26660", VA = "0x186E27260", Slot = "5")]
	[AsyncStateMachine(typeof(KHGONFNKAKJ))]
	public Task<PIPCEIFGMAA> NMKPCOGKEPO(long GGLEGKBAGLC, CancellationToken CMNJCPJBHGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6E26E80", Offset = "0x6E26280", VA = "0x186E26E80", Slot = "6")]
	[AsyncStateMachine(typeof(DGGIPCCEHEA))]
	public Task<NLMAEEICDJF> LFOPHPBGAFM(long GGLEGKBAGLC, CancellationToken CMNJCPJBHGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6E268F0", Offset = "0x6E25CF0", VA = "0x186E268F0", Slot = "7")]
	public bool HGMDOKHAMCF(long GGLEGKBAGLC, [Out] int AHAFONDBFBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6E27F20", Offset = "0x6E27320", VA = "0x186E27F20")]
	[AsyncStateMachine(typeof(ONDHCIEJCHK))]
	private Task<List<PIPCEIFGMAA>> PMCPLKCFDNM(RoomListQueryData GLMFHHIGGDM, CancellationToken CMNJCPJBHGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6E26D40", Offset = "0x6E26140", VA = "0x186E26D40")]
	[AsyncStateMachine(typeof(EKKOEJIKKCI))]
	private Task<List<PIPCEIFGMAA>> KENMMFLANMD(RoomListQueryData GLMFHHIGGDM, CancellationToken CMNJCPJBHGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6E26590", Offset = "0x6E25990", VA = "0x186E26590")]
	[AsyncStateMachine(typeof(BDILDNAIHOG))]
	private Task<List<PIPCEIFGMAA>> GNABLCCAHPO(RoomListQueryData GLMFHHIGGDM, CancellationToken CMNJCPJBHGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6E27390", Offset = "0x6E26790", VA = "0x186E27390")]
	[AsyncStateMachine(typeof(PGBHJNMEFPC))]
	private Task<List<PIPCEIFGMAA>> NPLNLHDNKGM(RoomListQueryData GLMFHHIGGDM, CancellationToken CMNJCPJBHGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6E274F0", Offset = "0x6E268F0", VA = "0x186E274F0")]
	[AsyncStateMachine(typeof(HENLMFGDIMF))]
	private Task<List<PIPCEIFGMAA>> OCHOKFLBNDH(RoomListQueryData GLMFHHIGGDM, CancellationToken CMNJCPJBHGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6E26070", Offset = "0x6E25470", VA = "0x186E26070")]
	[AsyncStateMachine(typeof(JKNBIIECGEM))]
	private Task<List<PIPCEIFGMAA>> DJHEDMJGGAO(RoomListQueryData GLMFHHIGGDM, CancellationToken CMNJCPJBHGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6E25F30", Offset = "0x6E25330", VA = "0x186E25F30")]
	[AsyncStateMachine(typeof(KFIBDFPONEL))]
	private Task<List<PIPCEIFGMAA>> DEGJNNGJPFA(RoomListQueryData GLMFHHIGGDM, CancellationToken CMNJCPJBHGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6E25A20", Offset = "0x6E24E20", VA = "0x186E25A20")]
	[AsyncStateMachine(typeof(CJGCAJNOIJP))]
	private Task<List<PIPCEIFGMAA>> BJPIIFPJOFG(List<long> DFDLJGFHMPH, CancellationToken CMNJCPJBHGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6E25C70", Offset = "0x6E25070", VA = "0x186E25C70")]
	[AsyncStateMachine(typeof(POIOGGFLLEK))]
	private Task<List<PIPCEIFGMAA>> CNDDJAIOIFK(LFOIMCNNKJJ IFEIOIEHJFB, int PBKDHPOGGNI, int IHBIDIIOBDB, Dictionary<long, string> KABIPIBNBGF, CancellationToken CMNJCPJBHGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6E25B30", Offset = "0x6E24F30", VA = "0x186E25B30")]
	[AsyncStateMachine(typeof(CFMDDCGHDNI))]
	private Task<IReadOnlyList<PIPCEIFGMAA>> CACIEFABBHK(int PBKDHPOGGNI, int IHBIDIIOBDB, CancellationToken CMNJCPJBHGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6E26BB0", Offset = "0x6E25FB0", VA = "0x186E26BB0")]
	private void JNEJGJINJFK(List<PIPCEIFGMAA> KICHBNDPJKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6E259C0", Offset = "0x6E24DC0", VA = "0x186E259C0")]
	private bool BGMMEDPNNGK(PIPCEIFGMAA MFIGDOAMPLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6E26FB0", Offset = "0x6E263B0", VA = "0x186E26FB0")]
	private void MDGBLODNMFH(List<PIPCEIFGMAA> KICHBNDPJKI, KLEAILFOGEL JBGLGACIHDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6E266E0", Offset = "0x6E25AE0", VA = "0x186E266E0")]
	private void HBNNMAPGADN(List<PIPCEIFGMAA> KICHBNDPJKI, KLEAILFOGEL JBGLGACIHDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6E26C90", Offset = "0x6E26090", VA = "0x186E26C90")]
	private void KECDJDPODNN(List<PIPCEIFGMAA> KICHBNDPJKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6E26B70", Offset = "0x6E25F70", VA = "0x186E26B70")]
	private bool JKGFHFJLHFI(PIPCEIFGMAA MFIGDOAMPLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6E26220", Offset = "0x6E25620", VA = "0x186E26220")]
	private void EHLNEGDOKOG(List<PIPCEIFGMAA> KICHBNDPJKI, bool IOLBANAPPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6E27DA0", Offset = "0x6E271A0", VA = "0x186E27DA0")]
	private void PFADMJNAPOA(List<PIPCEIFGMAA> KICHBNDPJKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6E27060", Offset = "0x6E26460", VA = "0x186E27060")]
	private bool MIDGCCFFAGC(PIPCEIFGMAA MFIGDOAMPLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6E26960", Offset = "0x6E25D60", VA = "0x186E26960")]
	private void HPMLIEFOPDE(List<PIPCEIFGMAA> KICHBNDPJKI, int HKJDGEGEECN, RoomListQueryData.LPPGPJKCOHF BOFJGCKHJBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6E27150", Offset = "0x6E26550", VA = "0x186E27150")]
	private void MLEBPCOOIHJ(List<PIPCEIFGMAA> KICHBNDPJKI, bool FECDNIBALKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6E25DD0", Offset = "0x6E251D0", VA = "0x186E25DD0")]
	private void COJFDFPGDEG(List<PIPCEIFGMAA> KICHBNDPJKI, (int, int)? GPIDFCDADAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6E276A0", Offset = "0x6E26AA0", VA = "0x186E276A0")]
	private string ONAKKOMMLNA(List<PIPCEIFGMAA> KICHBNDPJKI, string DAEGBLDHAJO, string AMOJALEMLHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6E262D0", Offset = "0x6E256D0", VA = "0x186E262D0")]
	private void FHIJJCJBBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6E261B0", Offset = "0x6E255B0", VA = "0x186E261B0")]
	private void DKEOPBIHOLA(List<PIPCEIFGMAA> KICHBNDPJKI, int MJNBPIJBFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6E26B00", Offset = "0x6E25F00", VA = "0x186E26B00")]
	private int IILCPPPJHIF(PIPCEIFGMAA FGFJFGGJOII, PIPCEIFGMAA CABLGFIBABJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6E27B30", Offset = "0x6E26F30", VA = "0x186E27B30")]
	private int PELHGGLKNCJ(PIPCEIFGMAA MFIGDOAMPLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6E25880", Offset = "0x6E24C80", VA = "0x186E25880")]
	private void AFFFBJOJNND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class JEDPOKKNJPK : HNLNCDFMAHN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct IIOIOLJAKOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AsyncTaskMethodBuilder<GNODDIAAKFD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public JEDPOKKNJPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public BEANCEBHDPC subRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private TaskAwaiter<ENPMNALFKDH<GNODDIAAKFD>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private TaskAwaiter<GNODDIAAKFD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6E21970", Offset = "0x6E20D70", VA = "0x186E21970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6E21EA0", Offset = "0x6E212A0", VA = "0x186E21EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct HDDNLJKCLLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder<GNODDIAAKFD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public JEDPOKKNJPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public BEANCEBHDPC subRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<ENPMNALFKDH<GNODDIAAKFD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6E20CA0", Offset = "0x6E200A0", VA = "0x186E20CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6E21150", Offset = "0x6E20550", VA = "0x186E21150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private List<GNODDIAAKFD> FMIPFBIOOKC;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6E22050", Offset = "0x6E21450", VA = "0x186E22050")]
	[AGCFNMIICNN.HNNLCOLGEGD.DNCHPFJACPB]
	internal static void OHHPJPBCCIE(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6E22200", Offset = "0x6E21600", VA = "0x186E22200")]
	[RecRoom.NoEngine.Common.Preserve]
	public JEDPOKKNJPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6E220C0", Offset = "0x6E214C0", VA = "0x186E220C0", Slot = "4")]
	[AsyncStateMachine(typeof(IIOIOLJAKOJ))]
	public Task<GNODDIAAKFD> POMFLPAMJBB(BEANCEBHDPC ELONMONDCOI, CancellationToken CMNJCPJBHGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6E21F10", Offset = "0x6E21310", VA = "0x186E21F10", Slot = "5")]
	[AsyncStateMachine(typeof(HDDNLJKCLLP))]
	public Task<GNODDIAAKFD> ECBMKAIJANC(BEANCEBHDPC ELONMONDCOI, CancellationToken CMNJCPJBHGE)
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
