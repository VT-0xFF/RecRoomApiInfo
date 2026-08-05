using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2AB4580", Offset = "0x2AB3980", VA = "0x182AB4580")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA99B00", Offset = "0xA98F00", VA = "0x180A99B00")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA99B40", Offset = "0xA98F40", VA = "0x180A99B40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class NEENANIJBDG<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> : IDisposable where TAction : notnull where TNetSys : notnull where TReceiver : notnull where TActionDeps : notnull, GGDAFFJDJDN.JEGACGOIHBA<TAction, TNetSys> where TReceiverDeps : notnull, GGDAFFJDJDN.GHJPFEIHICN<TAction, TReceiver> where TRootDeps : notnull, GGDAFFJDJDN.KMDIOHFKGDG<TAction, TRoot> where TRoot : notnull where TDeps : notnull, GGDAFFJDJDN.EGJKGAHLAEO<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal sealed class LNJGFHGGJOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal int? MFDFLPEILNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal readonly List<Func<Task>> CFBNKKIPDPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal bool NMHIKMLAAFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly List<Func<Task>> NBMPIPCLNGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal bool CEBJFMIFJLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal TAction[]? KKKKMFFPKBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly HIIAJDNDIFJ<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> GDPLHCACPAP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		internal bool NIIFOMEMGPD
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x5590200", Offset = "0x558F600", VA = "0x185590200")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5590250", Offset = "0x558F650", VA = "0x185590250")]
		public LNJGFHGGJOA(int? JPGHFGMKLEB, List<Func<Task>> NOHOHEJIMFI, bool IGGLOICLOIC, List<Func<Task>> LMKEIFGIMLI, bool HBFDABEPHHB, TAction[]? JHKGHHINLLG, HIIAJDNDIFJ<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> CHAOEFIECNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x558FFC0", Offset = "0x558F3C0", VA = "0x18558FFC0")]
		public static NEENANIJBDG<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps>.LNJGFHGGJOA EJOLKNBPCJB(TDeps MOHOCDOOLDA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class JHBAPJHHDGF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct <<SendActionToAll>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public JHBAPJHHDGF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private TaskCompletionSource<DGHPMJAIBNO<object?, NKJBEJMGDBL>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private TaskAwaiter<DGHPMJAIBNO<object, NKJBEJMGDBL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x44BF9E0", Offset = "0x44BEDE0", VA = "0x1844BF9E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x44C0170", Offset = "0x44BF570", VA = "0x1844C0170", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public LNJGFHGGJOA client;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public TNetSys sender;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public JGDCCHDHIKG<DNIHGDNFFLB> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TaskCompletionSource<DGHPMJAIBNO<object?, NKJBEJMGDBL>> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public TAction actionCopy;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public JHBAPJHHDGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5328DF0", Offset = "0x53281F0", VA = "0x185328DF0")]
		[AsyncStateMachine(typeof(NEENANIJBDG<, , , , , , , >.JHBAPJHHDGF.<<SendActionToAll>b__0>d))]
		internal Task NBPCHFKOOKJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class NJDDGNKINBC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private struct <<ReceiveAction>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public NJDDGNKINBC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskCompletionSource<DGHPMJAIBNO<object, NKJBEJMGDBL>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TaskAwaiter<DGHPMJAIBNO<object, NKJBEJMGDBL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x44BDEA0", Offset = "0x44BD2A0", VA = "0x1844BDEA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x44BE5D0", Offset = "0x44BD9D0", VA = "0x1844BE5D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public LNJGFHGGJOA client;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public JGDCCHDHIKG<DNIHGDNFFLB> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TaskCompletionSource<DGHPMJAIBNO<object, NKJBEJMGDBL>> tcs;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public NJDDGNKINBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5810A10", Offset = "0x580FE10", VA = "0x185810A10")]
		[AsyncStateMachine(typeof(NEENANIJBDG<, , , , , , , >.NJDDGNKINBC.<<ReceiveAction>b__0>d))]
		internal Task CFCLANDGDLB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NHGMKBGLCBA<DNIHGDNFFLB, LNJGFHGGJOA> EFNICGMHGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly List<CAGNMOFNFFF<TAction>> OGKDMNELBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly int PIHOIHHFCHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly int OFODKHGECFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly int KCBKPPCDDOI;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x57F4D80", Offset = "0x57F4180", VA = "0x1857F4D80")]
	public NEENANIJBDG(int BAEMBNOJEIP, int OLAHOHAMGJL, int FNGDOLFLOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x57F3600", Offset = "0x57F2A00", VA = "0x1857F3600", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x57F3690", Offset = "0x57F2A90", VA = "0x1857F3690")]
	public void EOGKMNGDBHK(JGDCCHDHIKG<DNIHGDNFFLB> ICAMGPAGGAL, TDeps MOHOCDOOLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x57F3BC0", Offset = "0x57F2FC0", VA = "0x1857F3BC0")]
	public void KLGIMHMFMPL(JGDCCHDHIKG<DNIHGDNFFLB> ICAMGPAGGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x57F4700", Offset = "0x57F3B00", VA = "0x1857F4700")]
	public void NELHLPLCJEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x57F40C0", Offset = "0x57F34C0", VA = "0x1857F40C0")]
	public Task<DGHPMJAIBNO<object, NKJBEJMGDBL>> LMFPPLOKJNG(TRoot LDEPDDDHLLO, [In] NIGAJHMGNCH<DNIHGDNFFLB> GIDCOHICBCB, [In] NHGMKBGLCBA<DNIHGDNFFLB, TNetSys> HEODMIIFHCL, [In] NHGMKBGLCBA<DNIHGDNFFLB, TReceiver> ANEENHFIPEB, JGDCCHDHIKG<DNIHGDNFFLB> CEOKNCPDLIJ, TAction ENDEKEOKCCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x57F3BE0", Offset = "0x57F2FE0", VA = "0x1857F3BE0")]
	public Task<DGHPMJAIBNO<object, NKJBEJMGDBL>> LMFPPLOKJNG(TRoot LDEPDDDHLLO, TNetSys KEJCMKLNFBJ, JGDCCHDHIKG<DNIHGDNFFLB> CEOKNCPDLIJ, TAction ENDEKEOKCCM, bool AGKKLJHAOAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x57F4A60", Offset = "0x57F3E60", VA = "0x1857F4A60")]
	public Task<DGHPMJAIBNO<object, NKJBEJMGDBL>> PPBBIMPLGGG(TRoot LDEPDDDHLLO, TNetSys MCNFNCGENNF, TReceiver EIMAFKHCFEM, JGDCCHDHIKG<DNIHGDNFFLB> JFHGNBNOPBC, JGDCCHDHIKG<DNIHGDNFFLB> CEOKNCPDLIJ, TAction ENDEKEOKCCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x57F3960", Offset = "0x57F2D60", VA = "0x1857F3960")]
	public Task FEMKLMCOHFD(TRoot LDEPDDDHLLO, TNetSys MCNFNCGENNF, TReceiver EIMAFKHCFEM, JGDCCHDHIKG<DNIHGDNFFLB> JFHGNBNOPBC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal readonly struct CAGNMOFNFFF<TAction> where TAction : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly JGDCCHDHIKG<DNIHGDNFFLB> ECJIBJLJPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly TAction GCEAEAHJEHF;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x18FE520", Offset = "0x18FD920", VA = "0x1818FE520")]
	public CAGNMOFNFFF(JGDCCHDHIKG<DNIHGDNFFLB> CJKINMFPLED, TAction ENDEKEOKCCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class GCJBNFMBOOJ
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3204240", Offset = "0x3203640", VA = "0x183204240")]
	public static CAGNMOFNFFF<TAction> EJOLKNBPCJB<TAction>(JGDCCHDHIKG<DNIHGDNFFLB> CJKINMFPLED, TAction ENDEKEOKCCM) where TAction : notnull
	{
		return default(CAGNMOFNFFF<TAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class HIIMEHJLPCF<TRoot, TDeps> : MGHHEHLALAD where TRoot : notnull where TDeps : notnull, LDGMPMNPHEG.MCBALGAFCKF<TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct IJFKMKLAAPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<DGHPMJAIBNO<object?, NKJBEJMGDBL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public HIIMEHJLPCF<TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public HLCECAAPGJB action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<DGHPMJAIBNO<object?, NKJBEJMGDBL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x50E67E0", Offset = "0x50E5BE0", VA = "0x1850E67E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x50E6B80", Offset = "0x50E5F80", VA = "0x1850E6B80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly TDeps MGFGGPPDFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly TRoot JANIGEANJIO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public JGDCCHDHIKG<DNIHGDNFFLB> GBLLFIGJGOH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xACA830", Offset = "0xAC9C30", VA = "0x180ACA830")]
		[CompilerGenerated]
		get
		{
			return default(JGDCCHDHIKG<DNIHGDNFFLB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x30098D0", Offset = "0x3008CD0", VA = "0x1830098D0")]
	public HIIMEHJLPCF(TDeps MOHOCDOOLDA, TRoot LDEPDDDHLLO, JGDCCHDHIKG<DNIHGDNFFLB> MPDFHFLBELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4FDF520", Offset = "0x4FDE920", VA = "0x184FDF520", Slot = "4")]
	[AsyncStateMachine(typeof(HIIMEHJLPCF<, >.IJFKMKLAAPP))]
	public Task<DGHPMJAIBNO<object, NKJBEJMGDBL>> LMFPPLOKJNG(HLCECAAPGJB ENDEKEOKCCM, bool AGKKLJHAOAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class LDGMPMNPHEG
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface MCBALGAFCKF<TRoot> where TRoot : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<DGHPMJAIBNO<object, NKJBEJMGDBL>> LMFPPLOKJNG(TRoot LDEPDDDHLLO, JGDCCHDHIKG<DNIHGDNFFLB> CEOKNCPDLIJ, HLCECAAPGJB ENDEKEOKCCM, bool AGKKLJHAOAG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class OMHFAGDNHCI : HFJFPNMHODI
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate void KPCMGJIPMLJ(JGDCCHDHIKG<BLBKEFIFJJH> LAGHGCFFPCD, JGDCCHDHIKG<AGHHHMBIGJH> HPJEMCIKCEI, JGDCCHDHIKG<KJEBJIOBLPE> HEDDIALINMD);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate void DEDIIMHNPNO(JGDCCHDHIKG<BLBKEFIFJJH> LAGHGCFFPCD, JGDCCHDHIKG<AGHHHMBIGJH> HPJEMCIKCEI, JGDCCHDHIKG<KJEBJIOBLPE> HEDDIALINMD);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void PKGFNCJDBFK(JGDCCHDHIKG<BLBKEFIFJJH> LAGHGCFFPCD, JGDCCHDHIKG<HEGDLLCPNGA> BBEBJBEHHMM);

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly OMHFAGDNHCI NKAKNKMIPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly KPCMGJIPMLJ? FPOCDCFKHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly DEDIIMHNPNO? GMKMDJBJIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly PKGFNCJDBFK? BMMDHFILEDP;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0xDA1DB0", Offset = "0xDA11B0", VA = "0x180DA1DB0")]
	public OMHFAGDNHCI([Optional] KPCMGJIPMLJ? CABOGLAGCJM, [Optional] DEDIIMHNPNO? KDBEGEBJJBJ, [Optional] PKGFNCJDBFK? HILBFLMPIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2AB4620", Offset = "0x2AB3A20", VA = "0x182AB4620", Slot = "4")]
	public void OnEdgeDidAdd(JGDCCHDHIKG<BLBKEFIFJJH> LAGHGCFFPCD, JGDCCHDHIKG<AGHHHMBIGJH> HPJEMCIKCEI, JGDCCHDHIKG<KJEBJIOBLPE> HEDDIALINMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2AB4640", Offset = "0x2AB3A40", VA = "0x182AB4640", Slot = "5")]
	public void OnEdgeWillRemove(JGDCCHDHIKG<BLBKEFIFJJH> LAGHGCFFPCD, JGDCCHDHIKG<AGHHHMBIGJH> HPJEMCIKCEI, JGDCCHDHIKG<KJEBJIOBLPE> HEDDIALINMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2AB4600", Offset = "0x2AB3A00", VA = "0x182AB4600", Slot = "6")]
	public void DOFCDIJBEJK(JGDCCHDHIKG<BLBKEFIFJJH> LAGHGCFFPCD, JGDCCHDHIKG<HEGDLLCPNGA> BBEBJBEHHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "7")]
	public void OnFunctionDeclsRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "9")]
	public void OnObjectPropertiesRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "10")]
	public void OnPlayerPropertiesRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "11")]
	public void OnEditGraphDidPush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "12")]
	public void OnEditGraphDidPop()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "8")]
	public void OnFunctionDeclChanged(JGDCCHDHIKG<NDGCACNBKLP> NKOCAONNINB)
	{
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
