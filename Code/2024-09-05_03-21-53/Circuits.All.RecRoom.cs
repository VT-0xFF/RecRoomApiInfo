using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Circuits.Shared.Api;
using Circuits.Static.Api;
using Cpp2IlInjected;
using Google.Protobuf;
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
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
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
		[Cpp2IlInjected.Address(RVA = "0x207A250", Offset = "0x2078C50", VA = "0x18207A250")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AEC90", Offset = "0x8AD690", VA = "0x1808AEC90")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AECD0", Offset = "0x8AD6D0", VA = "0x1808AECD0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class DBKFEBENKEL : IDisposable, IJDAENADLJN, JGDNNLEEDMA, HGLEODBLFMK, ALJEGPNNAAA
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class OBDNCKFPOIL : PBFANLMFFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int CHJLJOMDFOB
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x207A2D0", Offset = "0x2078CD0", VA = "0x18207A2D0", Slot = "5")]
		public EJNAILEIMOC BKDFAEHFDHA(JABOMEANPDH.OHKBAAKBJKG JPDKLLDNBGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void NLGJNHAEAJD();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void MCIJBILDFFN();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x207A4A0", Offset = "0x2078EA0", VA = "0x18207A4A0", Slot = "13")]
		public virtual void OJKOFKPMEMP(DBKFEBENKEL NLLPJEKPGDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x207A420", Offset = "0x2078E20", VA = "0x18207A420", Slot = "14")]
		public virtual void JPDCDFAPMPH(DBKFEBENKEL NLLPJEKPGDO, NFPABPCJAGA ENNGIICFMFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		protected OBDNCKFPOIL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface PBFANLMFFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int CHJLJOMDFOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		EJNAILEIMOC BKDFAEHFDHA(JABOMEANPDH.OHKBAAKBJKG JPDKLLDNBGD);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void NLGJNHAEAJD();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void MCIJBILDFFN();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void OJKOFKPMEMP(DBKFEBENKEL NLLPJEKPGDO);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void JPDCDFAPMPH(DBKFEBENKEL NLLPJEKPGDO, NFPABPCJAGA ENNGIICFMFD);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct FNJDHBFENGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly PHFJLKJHNDO<NHMLEAIPHKC, NFPABPCJAGA, DBKFEBENKEL, EINFKNJDJCL.AKGGBJEONCP<NHMLEAIPHKC, NFPABPCJAGA, DBKFEBENKEL>> DBLNPODEKIK;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x20679B0", Offset = "0x20663B0", VA = "0x1820679B0")]
		internal FNJDHBFENGL(PHFJLKJHNDO<NHMLEAIPHKC, NFPABPCJAGA, DBKFEBENKEL, EINFKNJDJCL.AKGGBJEONCP<NHMLEAIPHKC, NFPABPCJAGA, DBKFEBENKEL>> BMCAAIIMEIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class KMBDCKLNKPM : EINFKNJDJCL.AKGGBJEONCP<NHMLEAIPHKC, NFPABPCJAGA, DBKFEBENKEL>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly KMBDCKLNKPM LPENGNKGBMO;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		private KMBDCKLNKPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x11666E0", Offset = "0x11650E0", VA = "0x1811666E0", Slot = "4")]
		public NHMLEAIPHKC FHOMFPILOBF(NFPABPCJAGA PECHDAFMNOO)
		{
			return default(NHMLEAIPHKC);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x20759D0", Offset = "0x20743D0", VA = "0x1820759D0", Slot = "5")]
		public void OJKOFKPMEMP(DBKFEBENKEL MGPJOGDJPHA, NFPABPCJAGA ENNGIICFMFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x20758C0", Offset = "0x20742C0", VA = "0x1820758C0", Slot = "6")]
		public void JPDCDFAPMPH(DBKFEBENKEL MGPJOGDJPHA, NFPABPCJAGA ENNGIICFMFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct CFBJCBGPNJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public FHHLCBPGANA<NHMLEAIPHKC, NFPABPCJAGA, DBKFEBENKEL, EINFKNJDJCL.AKGGBJEONCP<NHMLEAIPHKC, NFPABPCJAGA, DBKFEBENKEL>> DBLNPODEKIK;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2062DC0", Offset = "0x20617C0", VA = "0x182062DC0")]
		internal CFBJCBGPNJN(FHHLCBPGANA<NHMLEAIPHKC, NFPABPCJAGA, DBKFEBENKEL, EINFKNJDJCL.AKGGBJEONCP<NHMLEAIPHKC, NFPABPCJAGA, DBKFEBENKEL>> BMCAAIIMEIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2062D70", Offset = "0x2061770", VA = "0x182062D70")]
		public static CFBJCBGPNJN MMKGNMBHOIH()
		{
			return default(CFBJCBGPNJN);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct MPHGIBIIPMK : ANNAAHFLNJO.MGOCHGGOOOO<NFPABPCJAGA, DBKFEBENKEL>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct AHLPAIMMGNH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<MOKFKOEPKDB<object, JNDPMGELPNI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public DBKFEBENKEL receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public NFPABPCJAGA action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public MPHGIBIIPMK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<MOKFKOEPKDB<object, JNDPMGELPNI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x205E410", Offset = "0x205CE10", VA = "0x18205E410", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x205E5F0", Offset = "0x205CFF0", VA = "0x18205E5F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA48810", Offset = "0xA47210", VA = "0x180A48810", Slot = "4")]
		public MLGFJIHMDCD<COIKDNADKKF> NCLOOJOAJEP(DBKFEBENKEL BKEICMBDHGB)
		{
			return default(MLGFJIHMDCD<COIKDNADKKF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2077110", Offset = "0x2075B10", VA = "0x182077110", Slot = "5")]
		[AsyncStateMachine(typeof(AHLPAIMMGNH))]
		public Task<MOKFKOEPKDB<object, JNDPMGELPNI>> CKFJJMODHAE(DBKFEBENKEL BKEICMBDHGB, NFPABPCJAGA ENNGIICFMFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2077240", Offset = "0x2075C40", VA = "0x182077240", Slot = "6")]
		public NFPABPCJAGA[] PCDILFHJIJL(DBKFEBENKEL BKEICMBDHGB)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct GAHHFCOPJNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<bool, JNDPMGELPNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public DBKFEBENKEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public HHGPMIDEFHD rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public LOOBEJOIHCO circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public KBMJFJMBCBA superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<MOKFKOEPKDB<bool, JNDPMGELPNI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2068180", Offset = "0x2066B80", VA = "0x182068180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2068400", Offset = "0x2066E00", VA = "0x182068400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct NAHDMEAGDDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<bool, JNDPMGELPNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public DBKFEBENKEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<MOKFKOEPKDB<bool, JNDPMGELPNI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2077260", Offset = "0x2075C60", VA = "0x182077260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x20774F0", Offset = "0x2075EF0", VA = "0x1820774F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct HLLIIMPLDEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public DBKFEBENKEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x20739E0", Offset = "0x20723E0", VA = "0x1820739E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2073BC0", Offset = "0x20725C0", VA = "0x182073BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct GBDGNPOIIOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<object, JNDPMGELPNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public DBKFEBENKEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public NFPABPCJAGA action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<MOKFKOEPKDB<object, JNDPMGELPNI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2068470", Offset = "0x2066E70", VA = "0x182068470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2068660", Offset = "0x2067060", VA = "0x182068660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct DHBCFJNFNBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public DBKFEBENKEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<MOKFKOEPKDB<bool, JNDPMGELPNI>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2064AD0", Offset = "0x20634D0", VA = "0x182064AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x20652C0", Offset = "0x2063CC0", VA = "0x1820652C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly MLGFJIHMDCD<COIKDNADKKF> AIODIGAALMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly FNJDHBFENGL JFNHJHJMHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly GHHOMABKDOM IMKELLDKNCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly NFGGJDGPOJE JHPAGJEOHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1900")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly FGJJJMLAIHN OOBNHNLFCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1908")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly LENGACKPANN.CNHBKJEDLPN FLFPFHOIGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1928")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly JBJOEPIJBGN LLGGJOHIJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1930")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly DJKHAIHGHHM FALEFBPLOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1938")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly FKHIFIMCDEE EPCIODDHLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1940")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly HOCMAHFMIJJ KAHJMBHMCME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1948")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private JNKOJEMIDNA EJOEGGHIAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1958")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private GEPNOKDIMAF GFNOJGLBKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1978")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly GHHOMABKDOM.CLNDPJLEADP MLGLBHIHPJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1980")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly GAMHEIBPJLL OLOFBEFIHFD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public GHHOMABKDOM HIILCGOHEKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x20637C0", Offset = "0x20621C0", VA = "0x1820637C0")]
		get
		{
			return default(GHHOMABKDOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal PBFANLMFFHJ FFKBILMDGGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x20637D0", Offset = "0x20621D0", VA = "0x1820637D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal EJNAILEIMOC OKKNIDHNKKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x20633A0", Offset = "0x2061DA0", VA = "0x1820633A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x20634C0", Offset = "0x2061EC0", VA = "0x1820634C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool PLBJLDFDNKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2063B20", Offset = "0x2062520", VA = "0x182063B20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2063B30", Offset = "0x2062530", VA = "0x182063B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public EOFHEJKIFHM FPFFPEFBIDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2064A90", Offset = "0x2063490", VA = "0x182064A90", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public OMCMONEGDKI OKKPCNDGOGM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2064AA0", Offset = "0x20634A0", VA = "0x182064AA0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IHCEJBEOOBL AMBDMPLGLOH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2064AC0", Offset = "0x20634C0", VA = "0x182064AC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public FJLBAIGNHBB CPEMOIPFGOF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2064AB0", Offset = "0x20634B0", VA = "0x182064AB0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public LENGACKPANN? OADFFMICJAL
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2063320", Offset = "0x2061D20", VA = "0x182063320", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private PKMMAOIOKBP? BFAAOKCCBMD
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2063BB0", Offset = "0x20625B0", VA = "0x182063BB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2064790", Offset = "0x2063190", VA = "0x182064790")]
	private DBKFEBENKEL(FGJJJMLAIHN CALPACHLHEI, MLGFJIHMDCD<COIKDNADKKF> NCGCLGONMJP, [In] FNJDHBFENGL BIPHNECGOHB, [In] GHHOMABKDOM IBGNGNPMFEF, [In] NFGGJDGPOJE IHICOMOLPGN, EJNAILEIMOC DJBGCNHEKJN, [In] LENGACKPANN.CNHBKJEDLPN BOMOIOMOJHF, GHHOMABKDOM.CLNDPJLEADP LAMFFKKLHGM, GAMHEIBPJLL FLAADGPBKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2063EC0", Offset = "0x20628C0", VA = "0x182063EC0")]
	public static DBKFEBENKEL MMKGNMBHOIH(FGJJJMLAIHN JPDKLLDNBGD, [In] JDEGNJNANCK FLNBDNDABGL, HLKCEILFGGG LMPGIKDLKHH, [In] ACDJNMPJNME DEFALFBMHHL, BOHANNKMOLK PGHFPELMJNM, MLGFJIHMDCD<COIKDNADKKF> NCGCLGONMJP, MLGFJIHMDCD<GBJGBJDGEGH> DOKCFPPBCNG, KOFEPIBJAEI JKKBNDHDINA, DDJHMJLMKGE OFLKAHMMFLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2064000", Offset = "0x2062A00", VA = "0x182064000")]
	public static DBKFEBENKEL MMKGNMBHOIH(FGJJJMLAIHN CALPACHLHEI, [In] GHHOMABKDOM IBGNGNPMFEF, [In] NFGGJDGPOJE IHICOMOLPGN, MLGFJIHMDCD<COIKDNADKKF> NCGCLGONMJP, MLGFJIHMDCD<GBJGBJDGEGH> DOKCFPPBCNG, KOFEPIBJAEI JKKBNDHDINA, DDJHMJLMKGE OFLKAHMMFLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x20634E0", Offset = "0x2061EE0", VA = "0x1820634E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2063D60", Offset = "0x2062760", VA = "0x182063D60")]
	[AsyncStateMachine(typeof(GAHHFCOPJNA))]
	internal Task<MOKFKOEPKDB<bool, JNDPMGELPNI>> LGIBGAKCABE(HHGPMIDEFHD BBMHNPDNFDC, LOOBEJOIHCO HKHFEOGOHFP, KBMJFJMBCBA KPLKDBDJMCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x20636D0", Offset = "0x20620D0", VA = "0x1820636D0")]
	[AsyncStateMachine(typeof(NAHDMEAGDDC))]
	public Task<MOKFKOEPKDB<bool, JNDPMGELPNI>> EBCFKKDBFNJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2063820", Offset = "0x2062220", VA = "0x182063820")]
	[AsyncStateMachine(typeof(HLLIIMPLDEH))]
	public Task<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> HJGHBJFGIBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2063910", Offset = "0x2062310", VA = "0x182063910")]
	internal void HKHMCAGMHKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2063CE0", Offset = "0x20626E0", VA = "0x182063CE0")]
	internal MKGNLHEPBHJ<NFPABPCJAGA> LCMAMHGHMJD([In] HDFPFIHLLBE MANGGNNBELM)
	{
		return default(MKGNLHEPBHJ<NFPABPCJAGA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2063B40", Offset = "0x2062540", VA = "0x182063B40")]
	internal bool JIOHGIAIFKH([In] HDFPFIHLLBE MANGGNNBELM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x20632A0", Offset = "0x2061CA0", VA = "0x1820632A0")]
	internal MKGNLHEPBHJ<NFPABPCJAGA> AAGKIPCAIFB([In] AHKOCGAJLIM IPLKIOMAPJP)
	{
		return default(MKGNLHEPBHJ<NFPABPCJAGA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x20633B0", Offset = "0x2061DB0", VA = "0x1820633B0")]
	[AsyncStateMachine(typeof(GBDGNPOIIOA))]
	internal Task<MOKFKOEPKDB<object, JNDPMGELPNI>> BNIJCMKFOOA(NFPABPCJAGA ENNGIICFMFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x20642E0", Offset = "0x2062CE0", VA = "0x1820642E0")]
	private NFPABPCJAGA[] PCDILFHJIJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2064670", Offset = "0x2063070", VA = "0x182064670")]
	[AsyncStateMachine(typeof(DHBCFJNFNBO))]
	public Task<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> PHMDGCNEFEE(Guid LGFMOLIHODP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class CPNAJKIPJJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2AC99C0", Offset = "0x2AC83C0", VA = "0x182AC99C0")]
	public static IFPNELJFMEF<(TPrev?, DBKFEBENKEL?), PKMMAOIOKBP> HFJPJFOBFGH<TPrev>([In] this IFPNELJFMEF<TPrev, DBKFEBENKEL> PECHDAFMNOO)
	{
		return default(IFPNELJFMEF<(TPrev, DBKFEBENKEL), PKMMAOIOKBP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2AC9580", Offset = "0x2AC7F80", VA = "0x182AC9580")]
	public static IFPNELJFMEF<TPrev?, DBKFEBENKEL?> DOEJGEBPNJN<TPrev>([In] this IFPNELJFMEF<TPrev, DBKFEBENKEL> PECHDAFMNOO)
	{
		return default(IFPNELJFMEF<TPrev, DBKFEBENKEL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class KCOMMECAJEL<TData> : IPGCPDAOJFL, GEGMFODCAOG, NLHAIFJDFEL where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly DKFKDKPPDAA<COGPDFLIJHB>? DJNACLDNANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly string LKAAOFNIBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly TData CNPFJDANIOD;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public DKFKDKPPDAA<COGPDFLIJHB>? LFGAJJOBMBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x22A6720", Offset = "0x22A5120", VA = "0x1822A6720", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8869B0", Offset = "0x8853B0", VA = "0x1808869B0", Slot = "7")]
	public override string PDDPMMJGDDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x43183A0", Offset = "0x4316DA0", VA = "0x1843183A0")]
	internal KCOMMECAJEL([In] DKFKDKPPDAA<COGPDFLIJHB>? LBAEGNKBFLG, MLGFJIHMDCD<IMMAAIMBPJM>? ONHCNBGADDB, IOKind? ELGGKJCEIIC, string MEBLNPKEJMN, [In] TData OIGMDCDEKEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class PGAJEGFNLAG
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x207A930", Offset = "0x2079330", VA = "0x18207A930")]
	public static MOKFKOEPKDB<FFBJJBKCCLE, GEGMFODCAOG> HHKJBOAABKH([In] this BLPAOAJPAGO<FKNKBFINFMK> OIGNDLJFLKP)
	{
		return default(MOKFKOEPKDB<FFBJJBKCCLE, GEGMFODCAOG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2E4AF80", Offset = "0x2E49980", VA = "0x182E4AF80")]
	public static MOKFKOEPKDB<TOk, GEGMFODCAOG> NMFPKMHIFFC<TOk>([In] this MOKFKOEPKDB<TOk, GEGMFODCAOG> PECHDAFMNOO, [In] DKFKDKPPDAA<COGPDFLIJHB>? LBAEGNKBFLG, MLGFJIHMDCD<IMMAAIMBPJM>? ONHCNBGADDB, IOKind? ELGGKJCEIIC, string MEBLNPKEJMN) where TOk : notnull
	{
		return default(MOKFKOEPKDB<TOk, GEGMFODCAOG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface FGJJJMLAIHN
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	LFJFEJENMAL.LAFIJMAPJJK ALFOLJLEKMC
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	JABOMEANPDH.OHKBAAKBJKG DBLCJLJPDJN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	DBKFEBENKEL.PBFANLMFFHJ KGAIHLCPKIF
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	KGBHMHDIMKJ.MAHPLEDMLMD GALMEBLKBEB
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	EINFKNJDJCL.AKGGBJEONCP<NHMLEAIPHKC, NFPABPCJAGA, DBKFEBENKEL> DNIHNBMNJGN
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	GGPBOBCBBBL HAGLPGOJPIM
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	JKBJEGHLFGB OAAGBCECAOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	KKJMEFJPJNE MONEBCMICAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	JBACPDMAHMM OCJLAIAMCHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	HMFKENPLIJJ HJNDFLPCOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class IIMAEICDAPA
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2073E40", Offset = "0x2072840", VA = "0x182073E40")]
	public static NFPABPCJAGA MEAPFMMAGEJ(this NFPABPCJAGA PECHDAFMNOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2073D70", Offset = "0x2072770", VA = "0x182073D70")]
	public static NFPABPCJAGA BJKCLMLCICC(this BDLINPLPPBK PECHDAFMNOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct BDLINPLPPBK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct EGFFNFIPFDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<object, JNDPMGELPNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public DBKFEBENKEL root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public BDLINPLPPBK self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<MOKFKOEPKDB<object, JNDPMGELPNI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2066010", Offset = "0x2064A10", VA = "0x182066010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x20662D0", Offset = "0x2064CD0", VA = "0x1820662D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly ByteString GJBIHCLEEHA;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xACCA10", Offset = "0xACB410", VA = "0x180ACCA10")]
	private BDLINPLPPBK(ByteString CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x205EDC0", Offset = "0x205D7C0", VA = "0x18205EDC0")]
	public static NFPABPCJAGA NIOLPFJLJBI(ByteString CLMKDBDPNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x205ED10", Offset = "0x205D710", VA = "0x18205ED10")]
	public static HPLECPIBIIH<NHMLEAIPHKC, BDLINPLPPBK> GJNKPHMLGCG(NFPABPCJAGA ELHGNJFEIPI)
	{
		return default(HPLECPIBIIH<NHMLEAIPHKC, BDLINPLPPBK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x205EC00", Offset = "0x205D600", VA = "0x18205EC00")]
	[AsyncStateMachine(typeof(EGFFNFIPFDG))]
	public static Task<MOKFKOEPKDB<object, JNDPMGELPNI>> BNIJCMKFOOA(DBKFEBENKEL MGPJOGDJPHA, BDLINPLPPBK PECHDAFMNOO)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct IMDLAMEPNHO
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2074340", Offset = "0x2072D40", VA = "0x182074340")]
	public static NFPABPCJAGA NIOLPFJLJBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2074250", Offset = "0x2072C50", VA = "0x182074250")]
	public static HPLECPIBIIH<NHMLEAIPHKC, IMDLAMEPNHO> GJNKPHMLGCG(NFPABPCJAGA ELHGNJFEIPI)
	{
		return default(HPLECPIBIIH<NHMLEAIPHKC, IMDLAMEPNHO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x20742C0", Offset = "0x2072CC0", VA = "0x1820742C0")]
	public static MOKFKOEPKDB<IEPJDCHMGFO, LAEJIKKOMKB> NCBFHFABHGH(DBKFEBENKEL MGPJOGDJPHA, [In] IMDLAMEPNHO PECHDAFMNOO)
	{
		return default(MOKFKOEPKDB<IEPJDCHMGFO, LAEJIKKOMKB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct MLFNMENILPA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct MLENHDBFBME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<IEPJDCHMGFO, LAEJIKKOMKB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public DBKFEBENKEL root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public MLFNMENILPA self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private MOKFKOEPKDB<IEPJDCHMGFO, LAEJIKKOMKB> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x20768A0", Offset = "0x20752A0", VA = "0x1820768A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2076C10", Offset = "0x2075610", VA = "0x182076C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly HHGPMIDEFHD? KOLDNAKHOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly LOOBEJOIHCO? DFPFHEFPBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly KBMJFJMBCBA? NFBJMOHKHKC;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1F98250", Offset = "0x1F96C50", VA = "0x181F98250")]
	private MLFNMENILPA(HHGPMIDEFHD? BBMHNPDNFDC, LOOBEJOIHCO? HKHFEOGOHFP, KBMJFJMBCBA? KPLKDBDJMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2076ED0", Offset = "0x20758D0", VA = "0x182076ED0")]
	public static NFPABPCJAGA? NIOLPFJLJBI(HHGPMIDEFHD? BBMHNPDNFDC, LOOBEJOIHCO? HKHFEOGOHFP, KBMJFJMBCBA? KPLKDBDJMCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2076DC0", Offset = "0x20757C0", VA = "0x182076DC0")]
	public static HPLECPIBIIH<NHMLEAIPHKC, MLFNMENILPA> GJNKPHMLGCG(NFPABPCJAGA ELHGNJFEIPI)
	{
		return default(HPLECPIBIIH<NHMLEAIPHKC, MLFNMENILPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2076C80", Offset = "0x2075680", VA = "0x182076C80")]
	[AsyncStateMachine(typeof(MLENHDBFBME))]
	public static Task<MOKFKOEPKDB<IEPJDCHMGFO, LAEJIKKOMKB>> BNIJCMKFOOA(DBKFEBENKEL MGPJOGDJPHA, MLFNMENILPA PECHDAFMNOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct DIDCIFIJCBF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct CPIKLKHCAAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<ACBJJNFNOGH, JNDPMGELPNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public DIDCIFIJCBF self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public DBKFEBENKEL root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private MOKFKOEPKDB<ACBJJNFNOGH, JNDPMGELPNI> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private MOKFKOEPKDB<object, NLHAIFJDFEL>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private MOKFKOEPKDB<object, NLHAIFJDFEL> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private MOKFKOEPKDB<object, NLHAIFJDFEL>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<MOKFKOEPKDB<object, JNDPMGELPNI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2062DD0", Offset = "0x20617D0", VA = "0x182062DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2063230", Offset = "0x2061C30", VA = "0x182063230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IReadOnlyList<NFPABPCJAGA> AJNMDAHOMCJ;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xACCA10", Offset = "0xACB410", VA = "0x180ACCA10")]
	private DIDCIFIJCBF(IReadOnlyList<NFPABPCJAGA> IKJNEEELGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2065630", Offset = "0x2064030", VA = "0x182065630")]
	public static NFPABPCJAGA NIOLPFJLJBI(IReadOnlyList<NFPABPCJAGA> IKJNEEELGKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2065590", Offset = "0x2063F90", VA = "0x182065590")]
	public static HPLECPIBIIH<NHMLEAIPHKC, DIDCIFIJCBF> GJNKPHMLGCG(NFPABPCJAGA ELHGNJFEIPI)
	{
		return default(HPLECPIBIIH<NHMLEAIPHKC, DIDCIFIJCBF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2065450", Offset = "0x2063E50", VA = "0x182065450")]
	[AsyncStateMachine(typeof(CPIKLKHCAAF))]
	public static Task<MOKFKOEPKDB<ACBJJNFNOGH, JNDPMGELPNI>> BNIJCMKFOOA(DBKFEBENKEL MGPJOGDJPHA, DIDCIFIJCBF PECHDAFMNOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct AHKOCGAJLIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly int FPAPEBLAAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int MOMFAOPBBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly byte[] CNPFJDANIOD;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1D144C0", Offset = "0x1D12EC0", VA = "0x181D144C0")]
	private AHKOCGAJLIM(int KFBJHPBJLOG, int EBDDHAPIAHH, byte[] OIGMDCDEKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x205E330", Offset = "0x205CD30", VA = "0x18205E330")]
	public static NFPABPCJAGA NIOLPFJLJBI(int KFBJHPBJLOG, int EBDDHAPIAHH, ByteString OIGMDCDEKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x205E0E0", Offset = "0x205CAE0", VA = "0x18205E0E0")]
	public static NFPABPCJAGA[] JEAFGINLNOP(NFPABPCJAGA ENNGIICFMFD, int KNJCAIGEJEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x205E000", Offset = "0x205CA00", VA = "0x18205E000")]
	public static HPLECPIBIIH<NHMLEAIPHKC, AHKOCGAJLIM> GJNKPHMLGCG(NFPABPCJAGA ELHGNJFEIPI)
	{
		return default(HPLECPIBIIH<NHMLEAIPHKC, AHKOCGAJLIM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x205E210", Offset = "0x205CC10", VA = "0x18205E210")]
	public static MOKFKOEPKDB<NFPABPCJAGA, LAEJIKKOMKB> NCBFHFABHGH(DBKFEBENKEL MGPJOGDJPHA, [In] AHKOCGAJLIM PECHDAFMNOO)
	{
		return default(MOKFKOEPKDB<NFPABPCJAGA, LAEJIKKOMKB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct HDFPFIHLLBE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct DPFMKKKJENM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<bool, LAEJIKKOMKB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public DBKFEBENKEL root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public HDFPFIHLLBE self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private MOKFKOEPKDB<bool, LAEJIKKOMKB> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<MOKFKOEPKDB<IEPJDCHMGFO, LAEJIKKOMKB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2065960", Offset = "0x2064360", VA = "0x182065960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2065FA0", Offset = "0x20649A0", VA = "0x182065FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly int FPAPEBLAAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int MOMFAOPBBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly byte[] CNPFJDANIOD;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1D144C0", Offset = "0x1D12EC0", VA = "0x181D144C0")]
	private HDFPFIHLLBE(int KFBJHPBJLOG, int EBDDHAPIAHH, byte[] OIGMDCDEKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2073620", Offset = "0x2072020", VA = "0x182073620")]
	public static NFPABPCJAGA NIOLPFJLJBI(int KFBJHPBJLOG, int EBDDHAPIAHH, ByteString OIGMDCDEKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2073700", Offset = "0x2072100", VA = "0x182073700")]
	public static NFPABPCJAGA?[]? PPNGPGCIJPC(int KNJCAIGEJEE, HHGPMIDEFHD? BBMHNPDNFDC, LOOBEJOIHCO? HKHFEOGOHFP, KBMJFJMBCBA? KPLKDBDJMCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2073540", Offset = "0x2071F40", VA = "0x182073540")]
	public static HPLECPIBIIH<NHMLEAIPHKC, HDFPFIHLLBE> GJNKPHMLGCG(NFPABPCJAGA ELHGNJFEIPI)
	{
		return default(HPLECPIBIIH<NHMLEAIPHKC, HDFPFIHLLBE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2073410", Offset = "0x2071E10", VA = "0x182073410")]
	[AsyncStateMachine(typeof(DPFMKKKJENM))]
	public static Task<MOKFKOEPKDB<bool, LAEJIKKOMKB>> BNIJCMKFOOA(DBKFEBENKEL MGPJOGDJPHA, HDFPFIHLLBE PECHDAFMNOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class JBJOEPIJBGN : EOFHEJKIFHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly DBKFEBENKEL JKIGMMCPDCE;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public AOFHALFGCNB? LPENGNKGBMO
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2074E30", Offset = "0x2073830", VA = "0x182074E30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x882870", Offset = "0x881270", VA = "0x180882870")]
	internal JBJOEPIJBGN(DBKFEBENKEL NLLPJEKPGDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class BHJNBBGEABP : AOFHALFGCNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly DBKFEBENKEL JKIGMMCPDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly PKCCJBPIFIB HEADFOLPJBA;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x88B090", Offset = "0x889A90", VA = "0x18088B090")]
	public BHJNBBGEABP(DBKFEBENKEL NLLPJEKPGDO, PKCCJBPIFIB ANFLFKCPKCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x205FAB0", Offset = "0x205E4B0", VA = "0x18205FAB0", Slot = "4")]
	public MOKFKOEPKDB<FFBJJBKCCLE, GEGMFODCAOG> BMANPDNOBHI(DKFKDKPPDAA<COGPDFLIJHB> ODLOJKBAHLA, MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII, MLGFJIHMDCD<HINBMEFALMJ> KKKBAAHOPHK)
	{
		return default(MOKFKOEPKDB<FFBJJBKCCLE, GEGMFODCAOG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x205FD90", Offset = "0x205E790", VA = "0x18205FD90", Slot = "5")]
	public MOKFKOEPKDB<FFBJJBKCCLE, GEGMFODCAOG> EDIBONJKOMA(DKFKDKPPDAA<COGPDFLIJHB> ODLOJKBAHLA, MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII, MLGFJIHMDCD<DAEKILKJHLB> NCKPDHPKIAJ)
	{
		return default(MOKFKOEPKDB<FFBJJBKCCLE, GEGMFODCAOG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class LFJFEJENMAL : FGDGJDOBGLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface LAFIJMAPJJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<PKCCJBPIFIB> OFNOOGOEGCP(DBKFEBENKEL NLLPJEKPGDO, LOOBEJOIHCO? DAOACJFLJEO, KBMJFJMBCBA? EDHPPLNGNBK, CancellationToken OGJIGALEPCA);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		BNEMNAKPOJH JGMBOPMICLC(DBKFEBENKEL NLLPJEKPGDO, HHGPMIDEFHD IEFDEOEDNEP);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class OPAIPEJIFAM : LAFIJMAPJJK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct ANMHNHJJIJB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public AsyncTaskMethodBuilder<PKCCJBPIFIB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public DBKFEBENKEL circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public LOOBEJOIHCO cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public KBMJFJMBCBA cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter<KGBHMHDIMKJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x205E9C0", Offset = "0x205D3C0", VA = "0x18205E9C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x205EB90", Offset = "0x205D590", VA = "0x18205EB90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly OPAIPEJIFAM LPENGNKGBMO;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		private OPAIPEJIFAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x207A500", Offset = "0x2078F00", VA = "0x18207A500", Slot = "4")]
		[AsyncStateMachine(typeof(ANMHNHJJIJB))]
		public Task<PKCCJBPIFIB> OFNOOGOEGCP(DBKFEBENKEL NLLPJEKPGDO, LOOBEJOIHCO? DAOACJFLJEO, KBMJFJMBCBA? EDHPPLNGNBK, CancellationToken OGJIGALEPCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x207A4E0", Offset = "0x2078EE0", VA = "0x18207A4E0", Slot = "5")]
		public BNEMNAKPOJH JGMBOPMICLC(DBKFEBENKEL NLLPJEKPGDO, HHGPMIDEFHD IEFDEOEDNEP)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct IPBONKDBBDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder<LFJFEJENMAL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public DBKFEBENKEL circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public LOOBEJOIHCO cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public KBMJFJMBCBA cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public HHGPMIDEFHD evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private LAFIJMAPJJK <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter<PKCCJBPIFIB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x20743E0", Offset = "0x2072DE0", VA = "0x1820743E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x20748E0", Offset = "0x20732E0", VA = "0x1820748E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly PKCCJBPIFIB HEADFOLPJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly BNEMNAKPOJH CJPOLFOGMNC;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public LENGACKPANN OADFFMICJAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2075EE0", Offset = "0x20748E0", VA = "0x182075EE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public PKMMAOIOKBP FKKLAFIDJMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2076100", Offset = "0x2074B00", VA = "0x182076100", Slot = "5")]
		get
		{
			return default(PKMMAOIOKBP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public BHJNBBGEABP KKADELEECPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8869A0", Offset = "0x8853A0", VA = "0x1808869A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public NBKLJEEPNJG OFKPECLCGAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x886D60", Offset = "0x885760", VA = "0x180886D60", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x963AD0", Offset = "0x9624D0", VA = "0x180963AD0")]
	private LFJFEJENMAL(PKCCJBPIFIB ANFLFKCPKCA, BNEMNAKPOJH AAPKKOAGECA, BHJNBBGEABP EMOJEBENDHA, NBKLJEEPNJG PGEMCBNJEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2075F90", Offset = "0x2074990", VA = "0x182075F90")]
	[AsyncStateMachine(typeof(IPBONKDBBDA))]
	public static Task<LFJFEJENMAL> GFPMOBDCNNE(DBKFEBENKEL NLLPJEKPGDO, HHGPMIDEFHD IEFDEOEDNEP, LOOBEJOIHCO? DAOACJFLJEO, KBMJFJMBCBA? EDHPPLNGNBK, CancellationToken OGJIGALEPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2075F30", Offset = "0x2074930", VA = "0x182075F30", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class JABOMEANPDH : EJNAILEIMOC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface OHKBAAKBJKG
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<FGDGJDOBGLF> NNEHFDAGALO(DBKFEBENKEL NLLPJEKPGDO, HHGPMIDEFHD IEFDEOEDNEP, LOOBEJOIHCO? DAOACJFLJEO, KBMJFJMBCBA? EDHPPLNGNBK, CancellationToken OGJIGALEPCA);

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BFFJENNBCAD();

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OINOGOMFEKC();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class BLPHEECOGOB : OHKBAAKBJKG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct LPNJPJLLPFA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public AsyncTaskMethodBuilder<FGDGJDOBGLF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public DBKFEBENKEL circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public HHGPMIDEFHD evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public LOOBEJOIHCO cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public KBMJFJMBCBA cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private TaskAwaiter<LFJFEJENMAL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x2076470", Offset = "0x2074E70", VA = "0x182076470", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x20767B0", Offset = "0x20751B0", VA = "0x1820767B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x2060600", Offset = "0x205F000", VA = "0x182060600", Slot = "4")]
		[AsyncStateMachine(typeof(LPNJPJLLPFA))]
		public Task<FGDGJDOBGLF> NNEHFDAGALO(DBKFEBENKEL NLLPJEKPGDO, HHGPMIDEFHD IEFDEOEDNEP, LOOBEJOIHCO? DAOACJFLJEO, KBMJFJMBCBA? EDHPPLNGNBK, CancellationToken OGJIGALEPCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void BFFJENNBCAD();

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void OINOGOMFEKC();

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		protected BLPHEECOGOB()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct DIHPKOGNKKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder<FGDGJDOBGLF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public JABOMEANPDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter<IEPJDCHMGFO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x20656F0", Offset = "0x20640F0", VA = "0x1820656F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x20658F0", Offset = "0x20642F0", VA = "0x1820658F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct BIOLFPDBCCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public JABOMEANPDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public DBKFEBENKEL circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public HHGPMIDEFHD evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public LOOBEJOIHCO cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public KBMJFJMBCBA cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<FGDGJDOBGLF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x2060070", Offset = "0x205EA70", VA = "0x182060070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x20605A0", Offset = "0x205EFA0", VA = "0x1820605A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly OHKBAAKBJKG OIIMCPAPNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly TaskCompletionSource<IEPJDCHMGFO> LMMPFJEFNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly TaskCompletionSource<IEPJDCHMGFO> EKHMGIDLJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly CancellationTokenSource MIGMKAGFBII;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool PLBJLDFDNKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xB75510", Offset = "0xB73F10", VA = "0x180B75510", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xC622D0", Offset = "0xC60CD0", VA = "0x180C622D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool PAJCHKNMDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xC622B0", Offset = "0xC60CB0", VA = "0x180C622B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xC622A0", Offset = "0xC60CA0", VA = "0x180C622A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool OALMOGILIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x127CE50", Offset = "0x127B850", VA = "0x18127CE50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2074D10", Offset = "0x2073710", VA = "0x182074D10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public FGDGJDOBGLF? ACGLHEOFAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x8853C0", VA = "0x1808869C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x891470", Offset = "0x88FE70", VA = "0x180891470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2074C20", Offset = "0x2073620", VA = "0x182074C20", Slot = "7")]
	[AsyncStateMachine(typeof(DIHPKOGNKKH))]
	public Task<FGDGJDOBGLF> HPIKGKOPACM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2074D20", Offset = "0x2073720", VA = "0x182074D20")]
	public JABOMEANPDH(OHKBAAKBJKG JPDKLLDNBGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2074950", Offset = "0x2073350", VA = "0x182074950", Slot = "8")]
	[AsyncStateMachine(typeof(BIOLFPDBCCG))]
	public Task CIOANLHILOF(DBKFEBENKEL NLLPJEKPGDO, HHGPMIDEFHD IEFDEOEDNEP, LOOBEJOIHCO? DAOACJFLJEO, KBMJFJMBCBA? EDHPPLNGNBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2074AB0", Offset = "0x20734B0", VA = "0x182074AB0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class JBIIFEOEAKI : OKOPBODIFCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly NBKLJEEPNJG ONKGPMMFLNA;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x882870", Offset = "0x881270", VA = "0x180882870")]
	public JBIIFEOEAKI(NBKLJEEPNJG PGEMCBNJEKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class JEMKDMDDJHM
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class KCPAIANEKPP<TGraph> : IDNMHIFJHOJ where TGraph : PDPODFCLEJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		protected readonly TGraph NHOPIJPJKKB;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public virtual CADOEEJFFAD? MLBFNGPCMDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x10D6120", Offset = "0x10D4B20", VA = "0x1810D6120", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public MLGFJIHMDCD<BLDJADOAIME> AIDNCMLHHNN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x4318490", Offset = "0x4316E90", VA = "0x184318490", Slot = "5")]
			get
			{
				return default(MLGFJIHMDCD<BLDJADOAIME>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public MLGFJIHMDCD<BLDJADOAIME>? LINKDBGJJCP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x43184B0", Offset = "0x4316EB0", VA = "0x1843184B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x882870", Offset = "0x881270", VA = "0x180882870")]
		public KCPAIANEKPP(TGraph MCNAAKGDKOD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class HEOOMNLPFGP : KCPAIANEKPP<OLPCDFHBIBL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override CADOEEJFFAD? MLBFNGPCMDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x20738F0", Offset = "0x20722F0", VA = "0x1820738F0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2073910", Offset = "0x2072310", VA = "0x182073910")]
		public HEOOMNLPFGP(OLPCDFHBIBL GNMPNBGPELI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2074F30", Offset = "0x2073930", VA = "0x182074F30")]
	public static IDNMHIFJHOJ MMKGNMBHOIH(PDPODFCLEJG MCNAAKGDKOD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class NPCBDKKKHLM : IAFCDCHFGLG, MKHMFONGLFO, ACJGAIHJELB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class BFLKFIANMIE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private struct <<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public BFLKFIANMIE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public GGPBOBCBBBL errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x207ADD0", Offset = "0x20797D0", VA = "0x18207ADD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x207B040", Offset = "0x2079A40", VA = "0x18207B040", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public NPCBDKKKHLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public BFLKFIANMIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x205F9C0", Offset = "0x205E3C0", VA = "0x18205F9C0")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task LLPACMIHMKF(GGPBOBCBBBL errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct KHIEJCNOBAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public bool checkStringPurity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public NPCBDKKKHLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2075120", Offset = "0x2073B20", VA = "0x182075120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2075630", Offset = "0x2074030", VA = "0x182075630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class IHPKPMBDDFE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private struct <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public IHPKPMBDDFE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x207B0A0", Offset = "0x2079AA0", VA = "0x18207B0A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x207B380", Offset = "0x2079D80", VA = "0x18207B380", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public NPCBDKKKHLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public IHPKPMBDDFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2073CA0", Offset = "0x20726A0", VA = "0x182073CA0")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task HOGDIOOEGHE(GGPBOBCBBBL errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly AKABJABIDDF HMBNEHOACEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly ICollection<LABCBKPHFPL> DIENIBNJPHM;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private FGJJJMLAIHN JICNLJMJMOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x20778A0", Offset = "0x20762A0", VA = "0x1820778A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public MLGFJIHMDCD<HINBMEFALMJ> AOCCLEKPHOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x92BE60", Offset = "0x92A860", VA = "0x18092BE60", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(MLGFJIHMDCD<HINBMEFALMJ>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x92A950", Offset = "0x929350", VA = "0x18092A950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private MLGFJIHMDCD<JCNBPBDCDNO> INPDOJHLONJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xC67CC0", Offset = "0xC666C0", VA = "0x180C67CC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public MLGFJIHMDCD<EEPPPKFALIN> GACPHAAPPEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8ABC80", Offset = "0x8AA680", VA = "0x1808ABC80", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(MLGFJIHMDCD<EEPPPKFALIN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public override MLGFJIHMDCD<IMMAAIMBPJM> INHFEMFLFBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2079F20", Offset = "0x2078920", VA = "0x182079F20", Slot = "20")]
		get
		{
			return default(MLGFJIHMDCD<IMMAAIMBPJM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool AFEDKGBBDNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2078F80", Offset = "0x2077980", VA = "0x182078F80", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x207A030", Offset = "0x2078A30", VA = "0x18207A030")]
	private NPCBDKKKHLM(DBKFEBENKEL NLLPJEKPGDO, GNMLBPFILMD AJIEBFICGCI, AKABJABIDDF EAFPCINHAJK, MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII, MLGFJIHMDCD<HINBMEFALMJ> KKKBAAHOPHK, MLGFJIHMDCD<JCNBPBDCDNO> CNBEFMBNOMD, bool NEGCLIMIHGF, string HBOONHFLONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2079900", Offset = "0x2078300", VA = "0x182079900")]
	public static NPCBDKKKHLM MMKGNMBHOIH(DBKFEBENKEL NLLPJEKPGDO, GNMLBPFILMD AJIEBFICGCI, AKABJABIDDF DKDIADEJLHP, MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII, MLGFJIHMDCD<JCNBPBDCDNO> CNBEFMBNOMD, MLGFJIHMDCD<HINBMEFALMJ> KKKBAAHOPHK, bool NEGCLIMIHGF, bool FKJMBMGKIEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2079E00", Offset = "0x2078800", VA = "0x182079E00", Slot = "21")]
	protected override void PCEEADECCDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x20784F0", Offset = "0x2076EF0", VA = "0x1820784F0", Slot = "22")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x20778C0", Offset = "0x20762C0", VA = "0x1820778C0", Slot = "30")]
	public void CIPIIOALFGB(LABCBKPHFPL HNHFONBKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2078910", Offset = "0x2077310", VA = "0x182078910", Slot = "27")]
	public void GHMNGPDLMPP(CCIANAJMGDD LMIBACCLMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2077B50", Offset = "0x2076550", VA = "0x182077B50", Slot = "28")]
	public void CNIAFBPFMAC(HGICJEPBKED DPFKIGMPBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2078CD0", Offset = "0x20776D0", VA = "0x182078CD0", Slot = "23")]
	protected override void HADEFFLENHI(HLEGIHKJLKF FKCOIAIFJKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2078E20", Offset = "0x2077820", VA = "0x182078E20", Slot = "32")]
	public string HBJNCKPKAHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2078650", Offset = "0x2077050", VA = "0x182078650", Slot = "29")]
	public string ENMKNBGCEIJ(int CPJHHMNPCPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2077920", Offset = "0x2076320", VA = "0x182077920")]
	private void CLAFGMJCFAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2079120", Offset = "0x2077B20", VA = "0x182079120", Slot = "31")]
	public void JCPOHEAHABG(LABCBKPHFPL HNHFONBKJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2079430", Offset = "0x2077E30", VA = "0x182079430")]
	private void KACIJGFFHEA(bool CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2079320", Offset = "0x2077D20", VA = "0x182079320", Slot = "33")]
	[AsyncStateMachine(typeof(KHIEJCNOBAG))]
	public Task JLAPDFGKAAE(string CLMKDBDPNNH, bool OHKAOICLFNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2079CB0", Offset = "0x20786B0", VA = "0x182079CB0")]
	public void OCEMEFEDFCL(string CLMKDBDPNNH, bool OHKAOICLFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x20796D0", Offset = "0x20780D0", VA = "0x1820796D0")]
	private void KOEGMJMOOIA(int CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x92A950", Offset = "0x929350", VA = "0x18092A950")]
	internal void FKOGAGLJNEM(MLGFJIHMDCD<HINBMEFALMJ> CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x20796C0", Offset = "0x20780C0", VA = "0x1820796C0")]
	[CompilerGenerated]
	private void KNHHAIJLILB(string CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x20791E0", Offset = "0x2077BE0", VA = "0x1820791E0")]
	[CompilerGenerated]
	private bool JFANFDECADE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2078590", Offset = "0x2076F90", VA = "0x182078590")]
	[CompilerGenerated]
	private bool ENKPINHEFKC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x20790D0", Offset = "0x2077AD0", VA = "0x1820790D0")]
	[CompilerGenerated]
	private int HPBOHENDFNK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2077800", Offset = "0x2076200", VA = "0x182077800")]
	[CompilerGenerated]
	private bool AHHJFAEINOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2077890", Offset = "0x2076290", VA = "0x182077890")]
	[CompilerGenerated]
	private void BLIBJNNDPNG(string CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2079F70", Offset = "0x2078970", VA = "0x182079F70")]
	[CompilerGenerated]
	private bool PNPMCOIFHOA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2078C80", Offset = "0x2077680", VA = "0x182078C80")]
	[CompilerGenerated]
	private bool GLCGAFHDPJK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2079870", Offset = "0x2078270", VA = "0x182079870")]
	[CompilerGenerated]
	private bool MMHHEADDPPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x20790D0", Offset = "0x2077AD0", VA = "0x1820790D0")]
	[CompilerGenerated]
	private int LNCKLLMIFDH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2079000", Offset = "0x2077A00", VA = "0x182079000")]
	[CompilerGenerated]
	private bool HMBLLCDLKHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2079EA0", Offset = "0x20788A0", VA = "0x182079EA0")]
	[CompilerGenerated]
	private object PIEEOJJMJNH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x20792A0", Offset = "0x2077CA0", VA = "0x1820792A0")]
	[CompilerGenerated]
	private void JJANJFPNGPC(object CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x20795F0", Offset = "0x2077FF0", VA = "0x1820795F0")]
	[CompilerGenerated]
	private bool KMJMHBEJILG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class ELCBILOAAKJ
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class JPAJDBJDIBC : NKFGKEJNIDG<CFLJKMCNAPN>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override HNCHBMBKAHI FJMKJEMBLNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x91D410", Offset = "0x91BE10", VA = "0x18091D410", Slot = "126")]
			get
			{
				return default(HNCHBMBKAHI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x20750C0", Offset = "0x2073AC0", VA = "0x1820750C0")]
		public JPAJDBJDIBC(DBKFEBENKEL NLLPJEKPGDO, CFLJKMCNAPN BMCAAIIMEIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class ANFNOGDJNHJ : FDDKFBJHECJ<PBBEBKNFNGH>
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x205E950", Offset = "0x205D350", VA = "0x18205E950")]
		public ANFNOGDJNHJ(DBKFEBENKEL NLLPJEKPGDO, PBBEBKNFNGH AJIEBFICGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x205E780", Offset = "0x205D180", VA = "0x18205E780", Slot = "120")]
		protected override void DLJDAFBNPBC(ODBHMKEOHCG PCACEJCPOFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x205E900", Offset = "0x205D300", VA = "0x18205E900")]
		[CompilerGenerated]
		private bool PFHJAEJEPNL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x205E660", Offset = "0x205D060", VA = "0x18205E660")]
		[CompilerGenerated]
		private void AINCHEBNAPI(bool CLMKDBDPNNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class LDKFNDEMFHK : FDDKFBJHECJ<GDCOECCJOLD>
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class PFLIEFFKAMM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public LILAAGPMKMO nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public LDKFNDEMFHK <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public PFLIEFFKAMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x207A840", Offset = "0x2079240", VA = "0x18207A840")]
			internal void EKIMLELLLBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x207A8E0", Offset = "0x20792E0", VA = "0x18207A8E0")]
			internal bool JHMMMGBFJBC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x207A890", Offset = "0x2079290", VA = "0x18207A890")]
			internal bool FJEBMGILCGL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x207A720", Offset = "0x2079120", VA = "0x18207A720")]
			internal void EHDKHGOAOBN(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x207A6D0", Offset = "0x20790D0", VA = "0x18207A6D0")]
			internal bool CCCGDHCBFGD()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2075E70", Offset = "0x2074870", VA = "0x182075E70")]
		public LDKFNDEMFHK(DBKFEBENKEL NLLPJEKPGDO, GDCOECCJOLD AJIEBFICGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2075B40", Offset = "0x2074540", VA = "0x182075B40", Slot = "120")]
		protected override void DLJDAFBNPBC(ODBHMKEOHCG PCACEJCPOFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class FOGPOJJDGCP : FDDKFBJHECJ<PAJHPDOIKMI>
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class CCHADGDFIHO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public LILAAGPMKMO nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public FOGPOJJDGCP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public CCHADGDFIHO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x20626D0", Offset = "0x20610D0", VA = "0x1820626D0")]
			internal object EKIMLELLLBK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x2062CF0", Offset = "0x20616F0", VA = "0x182062CF0")]
			internal bool OIKJCJPLEDI(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x2062930", Offset = "0x2061330", VA = "0x182062930")]
			internal void JHMMMGBFJBC(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x20627D0", Offset = "0x20611D0", VA = "0x1820627D0")]
			internal string FJEBMGILCGL(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x2062680", Offset = "0x2061080", VA = "0x182062680")]
			internal IReadOnlyList<object> EHDKHGOAOBN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x2062610", Offset = "0x2061010", VA = "0x182062610")]
			internal bool CCCGDHCBFGD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x2062B80", Offset = "0x2061580", VA = "0x182062B80")]
			internal bool LIAGIHGIJMN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x2062BD0", Offset = "0x20615D0", VA = "0x182062BD0")]
			internal void LJOEOKPGLFG(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2068110", Offset = "0x2066B10", VA = "0x182068110")]
		public FOGPOJJDGCP(DBKFEBENKEL NLLPJEKPGDO, PAJHPDOIKMI AJIEBFICGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x20679C0", Offset = "0x20663C0", VA = "0x1820679C0", Slot = "120")]
		protected override void DLJDAFBNPBC(ODBHMKEOHCG PCACEJCPOFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class NEHNALCKMKI : FDDKFBJHECJ<JCENEMLHMKO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class EMAFCKOMFDF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public NEHNALCKMKI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public LILAAGPMKMO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public EMAFCKOMFDF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x20677F0", Offset = "0x20661F0", VA = "0x1820677F0")]
			internal bool EKIMLELLLBK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x2067890", Offset = "0x2066290", VA = "0x182067890")]
			internal void JHMMMGBFJBC(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x2067840", Offset = "0x2066240", VA = "0x182067840")]
			internal bool FJEBMGILCGL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2077790", Offset = "0x2076190", VA = "0x182077790")]
		public NEHNALCKMKI(DBKFEBENKEL NLLPJEKPGDO, JCENEMLHMKO AJIEBFICGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2077560", Offset = "0x2075F60", VA = "0x182077560", Slot = "120")]
		protected override void DLJDAFBNPBC(ODBHMKEOHCG PCACEJCPOFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public abstract class LLGMLCGGDGI<TNode> : FDDKFBJHECJ<TNode> where TNode : notnull, GJCLAKGJENF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct MFNBMHEIKDI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public AsyncTaskMethodBuilder<MOKFKOEPKDB<MLGFJIHMDCD<KGKGLKMKAOL>, JNDPMGELPNI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public LLGMLCGGDGI<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private TaskAwaiter<MOKFKOEPKDB<MLGFJIHMDCD<KGKGLKMKAOL>, JNDPMGELPNI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x46141B0", Offset = "0x4612BB0", VA = "0x1846141B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x46145B0", Offset = "0x4612FB0", VA = "0x1846145B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct LKGBCBLHIAA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public AsyncTaskMethodBuilder<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public LLGMLCGGDGI<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public MLGFJIHMDCD<KGKGLKMKAOL> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private TaskAwaiter<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x4436A00", Offset = "0x4435400", VA = "0x184436A00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x4436E00", Offset = "0x4435800", VA = "0x184436E00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public sealed override bool JJOGJCJDEGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "115")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override MLGFJIHMDCD<KGKGLKMKAOL>? LMEBCIOGHEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x4439BE0", Offset = "0x44385E0", VA = "0x184439BE0", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4439B90", Offset = "0x4438590", VA = "0x184439B90")]
		protected LLGMLCGGDGI(DBKFEBENKEL NLLPJEKPGDO, TNode AJIEBFICGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4439780", Offset = "0x4438180", VA = "0x184439780", Slot = "100")]
		[AsyncStateMachine(typeof(LLGMLCGGDGI<>.MFNBMHEIKDI))]
		public override Task<MOKFKOEPKDB<MLGFJIHMDCD<KGKGLKMKAOL>, JNDPMGELPNI>> AILJAKPFFNA(string HBOONHFLONJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4439A50", Offset = "0x4438450", VA = "0x184439A50", Slot = "124")]
		public sealed override bool KBCCFEFPEMK(MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x44399B0", Offset = "0x44383B0", VA = "0x1844399B0", Slot = "112")]
		protected sealed override bool FMBKMHCOENA(MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4439AF0", Offset = "0x44384F0", VA = "0x184439AF0", Slot = "113")]
		protected override bool MBDPPCPKMFL(MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x44398A0", Offset = "0x44382A0", VA = "0x1844398A0", Slot = "101")]
		[AsyncStateMachine(typeof(LLGMLCGGDGI<>.LKGBCBLHIAA))]
		public override Task<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> DDACAIGPFPP(MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class LICAEIFAKMK : JBEJAGBKFDJ<ABGDHGEJLON>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class MOGAHMGKNOJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public LICAEIFAKMK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public LILAAGPMKMO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public MOGAHMGKNOJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x2076FD0", Offset = "0x20759D0", VA = "0x182076FD0")]
			internal bool CBHJBEKPBFD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x2077050", Offset = "0x2075A50", VA = "0x182077050")]
			internal void HDNFOCBGDNA(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2076410", Offset = "0x2074E10", VA = "0x182076410")]
		public LICAEIFAKMK(DBKFEBENKEL NLLPJEKPGDO, ABGDHGEJLON BMCAAIIMEIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x20761C0", Offset = "0x2074BC0", VA = "0x1820761C0", Slot = "126")]
		protected override void IAGPOKKMKBD(ODBHMKEOHCG PCACEJCPOFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class ILCMIJFGFJD : OOGPDBKGEKD<OBAJNCLBALA>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override NodeVisualizationKey JDBNAJHLPPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x900EE0", Offset = "0x8FF8E0", VA = "0x180900EE0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x20741F0", Offset = "0x2072BF0", VA = "0x1820741F0")]
		public ILCMIJFGFJD(DBKFEBENKEL NLLPJEKPGDO, OBAJNCLBALA AJIEBFICGCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public abstract class OOGPDBKGEKD<TNode> : FDDKFBJHECJ<TNode> where TNode : notnull, CHNAFNHKJHA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct IOPJKHKGFHO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public AsyncTaskMethodBuilder<MOKFKOEPKDB<MLGFJIHMDCD<KGKGLKMKAOL>, JNDPMGELPNI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public OOGPDBKGEKD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			private TaskAwaiter<MOKFKOEPKDB<MLGFJIHMDCD<KGKGLKMKAOL>, JNDPMGELPNI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x4039AC0", Offset = "0x40384C0", VA = "0x184039AC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x4039F70", Offset = "0x4038970", VA = "0x184039F70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct CIOHJOJAOHA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public AsyncTaskMethodBuilder<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public OOGPDBKGEKD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public MLGFJIHMDCD<KGKGLKMKAOL> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private TaskAwaiter<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x543E0F0", Offset = "0x543CAF0", VA = "0x18543E0F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x543E580", Offset = "0x543CF80", VA = "0x18543E580", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct HOBAFBIIPFP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public AsyncTaskMethodBuilder<MOKFKOEPKDB<ACBJJNFNOGH, JNDPMGELPNI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public OOGPDBKGEKD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private TaskAwaiter<MOKFKOEPKDB<ACBJJNFNOGH, JNDPMGELPNI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x3EF4D60", Offset = "0x3EF3760", VA = "0x183EF4D60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x3EF5430", Offset = "0x3EF3E30", VA = "0x183EF5430", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private sealed class BCPPKMIMBJF
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000050")]
			private struct <<BuildConfigMenuInternal>b__7>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public BCPPKMIMBJF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0x36AF890", Offset = "0x36AE290", VA = "0x1836AF890", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000150")]
				[Cpp2IlInjected.Address(RVA = "0xB9ACE0", Offset = "0xB996E0", VA = "0x180B9ACE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public ODBHMKEOHCG configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public LILAAGPMKMO nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public OOGPDBKGEKD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public Func<string, bool> <>9__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public Action <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public BCPPKMIMBJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x5002240", Offset = "0x5000C40", VA = "0x185002240")]
			internal bool LJOEOKPGLFG(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x5001B40", Offset = "0x5000540", VA = "0x185001B40")]
			internal void EKIMLELLLBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x50022B0", Offset = "0x5000CB0", VA = "0x1850022B0")]
			[AsyncStateMachine(typeof(OOGPDBKGEKD<>.BCPPKMIMBJF.<<BuildConfigMenuInternal>b__7>d))]
			internal void OIKJCJPLEDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x5001E30", Offset = "0x5000830", VA = "0x185001E30")]
			internal bool JHMMMGBFJBC()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class NGAGOIKGFOF
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000052")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F3")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				public NGAGOIKGFOF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				private TaskAwaiter<TaskStatus> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000156")]
				[Cpp2IlInjected.Address(RVA = "0x36AF510", Offset = "0x36ADF10", VA = "0x1836AF510", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000157")]
				[Cpp2IlInjected.Address(RVA = "0xB9ACE0", Offset = "0xB996E0", VA = "0x180B9ACE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public string newFunctionName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public BCPPKMIMBJF CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public Func<string> <>9__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public Action<string> <>9__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public Action <>9__5;

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public NGAGOIKGFOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x46AC140", Offset = "0x46AAB40", VA = "0x1846AC140")]
			internal void FJEBMGILCGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780")]
			internal string EHDKHGOAOBN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x882790", Offset = "0x881190", VA = "0x180882790")]
			internal void CCCGDHCBFGD(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x46AC560", Offset = "0x46AAF60", VA = "0x1846AC560")]
			[AsyncStateMachine(typeof(OOGPDBKGEKD<>.NGAGOIKGFOF.<<BuildConfigMenuInternal>b__5>d))]
			internal void LIAGIHGIJMN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class BCEFNIBADOK
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000054")]
			private struct <<AddDynamicNodeGroupSettingV2>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000105")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000106")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				public BCEFNIBADOK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016B")]
				[Cpp2IlInjected.Address(RVA = "0x36AF040", Offset = "0x36ADA40", VA = "0x1836AF040", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0xB9ACE0", Offset = "0xB996E0", VA = "0x180B9ACE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000055")]
			private struct <<AddDynamicNodeGroupSettingV2>b__6>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000109")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010A")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010B")]
				public BCEFNIBADOK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010C")]
				private TaskAwaiter<MOKFKOEPKDB<MLGFJIHMDCD<JCNBPBDCDNO>, JNDPMGELPNI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0x36AF220", Offset = "0x36ADC20", VA = "0x1836AF220", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016E")]
				[Cpp2IlInjected.Address(RVA = "0xB9ACE0", Offset = "0xB996E0", VA = "0x180B9ACE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000056")]
			private struct <<AddDynamicNodeGroupSettingV2>b__10>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public BCEFNIBADOK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				private TaskAwaiter<MOKFKOEPKDB<MLGFJIHMDCD<LKMKIJDBGPC>, JNDPMGELPNI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0x36AE970", Offset = "0x36AD370", VA = "0x1836AE970", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0xB9ACE0", Offset = "0xB996E0", VA = "0x180B9ACE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public OOGPDBKGEKD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public MLGFJIHMDCD<KGKGLKMKAOL> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public ODBHMKEOHCG configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public LILAAGPMKMO nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public HOFGADJGIDE nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public int minGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public int maxGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public LLBJEPOEBFC selectedInputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public string newInputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public List<FNDIDCCLPKE> inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public LLBJEPOEBFC selectedOutputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public string newOutputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public List<FNDIDCCLPKE> outputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public Func<string, bool> <>9__17;

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public BCEFNIBADOK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x5000120", Offset = "0x4FFEB20", VA = "0x185000120")]
			internal bool DKIHDKICIOI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x5000190", Offset = "0x4FFEB90", VA = "0x185000190")]
			internal void DNGCHHLFGPI(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x50008F0", Offset = "0x4FFF2F0", VA = "0x1850008F0")]
			internal bool PKHEMJCOLLO(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x50006C0", Offset = "0x4FFF0C0", VA = "0x1850006C0")]
			internal bool LMOPDOIEFHM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x50004B0", Offset = "0x4FFEEB0", VA = "0x1850004B0")]
			[AsyncStateMachine(typeof(OOGPDBKGEKD<>.BCEFNIBADOK.<<AddDynamicNodeGroupSettingV2>b__2>d))]
			internal void KCHHHIEAJGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x5000810", Offset = "0x4FFF210", VA = "0x185000810")]
			internal bool NPCAGCHNEAP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x5000600", Offset = "0x4FFF000", VA = "0x185000600")]
			internal void KKJBLGJHDBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x5000550", Offset = "0x4FFEF50", VA = "0x185000550")]
			internal bool KDOJNDMLFLI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x5000340", Offset = "0x4FFED40", VA = "0x185000340")]
			internal void GCJPPFIAMHD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x5000400", Offset = "0x4FFEE00", VA = "0x185000400")]
			internal bool GGBIJLKMCKJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x50000B0", Offset = "0x4FFEAB0", VA = "0x1850000B0")]
			internal bool CMHCDHMIBBI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x50007A0", Offset = "0x4FFF1A0", VA = "0x1850007A0")]
			internal void NLOPDPKFIAC(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x5000850", Offset = "0x4FFF250", VA = "0x185000850")]
			[AsyncStateMachine(typeof(OOGPDBKGEKD<>.BCEFNIBADOK.<<AddDynamicNodeGroupSettingV2>b__6>d))]
			internal void PHLNKJGPBAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x5000050", Offset = "0x4FFEA50", VA = "0x185000050")]
			internal bool AICILFDNIPB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x50002D0", Offset = "0x4FFECD0", VA = "0x1850002D0")]
			internal bool FHDKIPJMICN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x5000260", Offset = "0x4FFEC60", VA = "0x185000260")]
			internal void FACDMNCCIFH(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x5000700", Offset = "0x4FFF100", VA = "0x185000700")]
			[AsyncStateMachine(typeof(OOGPDBKGEKD<>.BCEFNIBADOK.<<AddDynamicNodeGroupSettingV2>b__10>d))]
			internal void LOEDHOJEDLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x5000200", Offset = "0x4FFEC00", VA = "0x185000200")]
			internal bool EEGGGLBIMGI()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class EOFJPIMBFFP
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000058")]
			private struct <<AddDynamicNodeGroupSettingV2>b__16>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000116")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000117")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000118")]
				public EOFJPIMBFFP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				private TaskAwaiter<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000176")]
				[Cpp2IlInjected.Address(RVA = "0x36AEC60", Offset = "0x36AD660", VA = "0x1836AEC60", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000177")]
				[Cpp2IlInjected.Address(RVA = "0xB9ACE0", Offset = "0xB996E0", VA = "0x180B9ACE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public BCEFNIBADOK CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public Func<string> <>9__14;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public Action<string> <>9__15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public Action <>9__16;

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public EOFJPIMBFFP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x39AEEC0", Offset = "0x39AD8C0", VA = "0x1839AEEC0")]
			internal void FBNIAPJKDBB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780")]
			internal string JHIDGEMIAHD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x882790", Offset = "0x881190", VA = "0x180882790")]
			internal void MLGAIMEKGKJ(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x39AF2E0", Offset = "0x39ADCE0", VA = "0x1839AF2E0")]
			[AsyncStateMachine(typeof(OOGPDBKGEKD<>.EOFJPIMBFFP.<<AddDynamicNodeGroupSettingV2>b__16>d))]
			internal void FOHEGJBAJBG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		[CompilerGenerated]
		private sealed class HNFMJCGMJAC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public HOFGADJGIDE nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public List<FNDIDCCLPKE> portMenu;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public OOGPDBKGEKD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public MLGFJIHMDCD<KGKGLKMKAOL> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public int portCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public Func<bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public HNFMJCGMJAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x3EF3DE0", Offset = "0x3EF27E0", VA = "0x183EF3DE0")]
			internal bool DJDOJIBNPAF()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private sealed class PMCOFNFMNCF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public ACJGAIHJELB port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public HNFMJCGMJAC CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public PMCOFNFMNCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x4938840", Offset = "0x4937240", VA = "0x184938840")]
			internal void FHIMDHPBLIB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x4938950", Offset = "0x4937350", VA = "0x184938950")]
			internal bool IDBDJDAIDKG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x4938720", Offset = "0x4937120", VA = "0x184938720")]
			internal void AGMGLHJOMJK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x49389A0", Offset = "0x49373A0", VA = "0x1849389A0")]
			internal bool OGAJPPCGBNC()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private sealed class PMMGGPGGIGM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public FNDIDCCLPKE portControls;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public PMCOFNFMNCF CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public PMMGGPGGIGM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x493A870", Offset = "0x4939270", VA = "0x18493A870")]
			internal void FGJDIOGAGDI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class GAFMNINLKFG
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005D")]
			private struct <<CreatePortItemV2>b__3>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400012D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400012E")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400012F")]
				public GAFMNINLKFG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000130")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000131")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				private TaskAwaiter<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000187")]
				[Cpp2IlInjected.Address(RVA = "0x36B0CF0", Offset = "0x36AF6F0", VA = "0x1836B0CF0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000188")]
				[Cpp2IlInjected.Address(RVA = "0xB9ACE0", Offset = "0xB996E0", VA = "0x180B9ACE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public List<object> allTypeObjects;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public LLBJEPOEBFC selectedType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public HOFGADJGIDE nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public ACJGAIHJELB port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public LILAAGPMKMO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public GAFMNINLKFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x3DFCC90", Offset = "0x3DFB690", VA = "0x183DFCC90")]
			internal int OCDNAEJILOP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x3DFC8A0", Offset = "0x3DFB2A0", VA = "0x183DFC8A0")]
			internal void BJJKELFHPPH(int val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x8853C0", VA = "0x1808869C0")]
			internal string OFEGBIFFHNN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x3DFCBD0", Offset = "0x3DFB5D0", VA = "0x183DFCBD0")]
			[AsyncStateMachine(typeof(OOGPDBKGEKD<>.GAFMNINLKFG.<<CreatePortItemV2>b__3>d))]
			internal void JOHHOEPCJJH(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x3DFCAF0", Offset = "0x3DFB4F0", VA = "0x183DFCAF0")]
			internal bool CLOAGILOALA(string text)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly Dictionary<MLGFJIHMDCD<KGKGLKMKAOL>, bool> DLPIBMCJNGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private readonly Dictionary<MLGFJIHMDCD<KGKGLKMKAOL>, bool> LHAFEFABHAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private readonly Dictionary<MLGFJIHMDCD<KGKGLKMKAOL>, bool> HCNBOOFEGLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Dictionary<MLGFJIHMDCD<KGKGLKMKAOL>, bool> EBBIIONIKAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private Dictionary<MLGFJIHMDCD<KGKGLKMKAOL>, bool> ANMHODHNCLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private Dictionary<MLGFJIHMDCD<KGKGLKMKAOL>, bool> GCOBMHMKOEO;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool CBAEGDLFPHD
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected virtual bool NPHGOEJCLCI
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "126")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected virtual bool OMDMHGJBAPP
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "127")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected virtual bool FHGEIEFEALH
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "128")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override MLGFJIHMDCD<BLDJADOAIME>? NKJEAKGIHDF
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x4863190", Offset = "0x4861B90", VA = "0x184863190", Slot = "116")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override MLGFJIHMDCD<KGKGLKMKAOL>? LMEBCIOGHEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x4863460", Offset = "0x4861E60", VA = "0x184863460", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override IEnumerable<DKFKDKPPDAA<COGPDFLIJHB>>? NAHDODPLHEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x4863250", Offset = "0x4861C50", VA = "0x184863250", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x4862F70", Offset = "0x4861970", VA = "0x184862F70")]
		public OOGPDBKGEKD(DBKFEBENKEL NLLPJEKPGDO, TNode AJIEBFICGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "129")]
		protected virtual bool LCIJFOFFPIK(int IELNDNNGEMN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "130")]
		protected virtual bool MFHHKBFHLOI(int IELNDNNGEMN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "131")]
		protected virtual bool OKLKOAEHHHG(int IELNDNNGEMN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "132")]
		protected virtual void PMDMFOIJKFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x48615B0", Offset = "0x485FFB0", VA = "0x1848615B0", Slot = "124")]
		public override bool KBCCFEFPEMK(MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x485E540", Offset = "0x485CF40", VA = "0x18485E540", Slot = "100")]
		[AsyncStateMachine(typeof(OOGPDBKGEKD<>.IOPJKHKGFHO))]
		public override Task<MOKFKOEPKDB<MLGFJIHMDCD<KGKGLKMKAOL>, JNDPMGELPNI>> AILJAKPFFNA(string HBOONHFLONJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x485E760", Offset = "0x485D160", VA = "0x18485E760", Slot = "101")]
		[AsyncStateMachine(typeof(OOGPDBKGEKD<>.CIOHJOJAOHA))]
		public override Task<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> DDACAIGPFPP(MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x4862A40", Offset = "0x4861440", VA = "0x184862A40", Slot = "102")]
		public override void NNBKFPHHPHF(MLGFJIHMDCD<KGKGLKMKAOL> EBDDHAPIAHH, MLGFJIHMDCD<KGKGLKMKAOL> IPOCAIFIKHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x4862CF0", Offset = "0x48616F0", VA = "0x184862CF0", Slot = "103")]
		public override IEnumerable<NFPABPCJAGA> OMOIJGGCMLD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x485E660", Offset = "0x485D060", VA = "0x18485E660")]
		[AsyncStateMachine(typeof(OOGPDBKGEKD<>.HOBAFBIIPFP))]
		private Task<MOKFKOEPKDB<ACBJJNFNOGH, JNDPMGELPNI>> BLJIJAJOPMK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "133")]
		protected virtual bool MIEJCFAJDJF(MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "134")]
		protected virtual bool NMBAAFIOJFH(MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "135")]
		protected virtual bool MIILONFOJHP(MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "136")]
		protected virtual bool OECEEKNMCFJ(MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "137")]
		protected virtual bool EBCMJBHEIDM(MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII, int OLLNALGPMGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "138")]
		protected virtual bool EEFKBLDAEJO(MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII, int OLLNALGPMGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "139")]
		protected virtual bool HJOOIGIEGFH(MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII, int IJKADDPBJKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "140")]
		protected virtual bool HPOHPKPICNA(MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII, int IJKADDPBJKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "141")]
		protected virtual bool JCMGFAJDNNN(MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII, int IGFHNMEDLLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "142")]
		protected virtual bool AOPKBCPHEHP(MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII, int EINNMBDFPBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x4861650", Offset = "0x4860050", VA = "0x184861650", Slot = "143")]
		protected virtual List<LLBJEPOEBFC> KHAMBKABHLG(MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "144")]
		protected virtual void BMOPLENMAJK(ODBHMKEOHCG PCACEJCPOFN, FODGGAGDMEH AEEHGBJCMBC, HOFGADJGIDE CELNOPAPIHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x485E870", Offset = "0x485D270", VA = "0x18485E870", Slot = "120")]
		protected override void DLJDAFBNPBC(ODBHMKEOHCG PCACEJCPOFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x485F2E0", Offset = "0x485DCE0", VA = "0x18485F2E0")]
		private FODGGAGDMEH GBLJEBPHLFA(ODBHMKEOHCG PCACEJCPOFN, HOFGADJGIDE CELNOPAPIHE, MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x48618F0", Offset = "0x48602F0", VA = "0x1848618F0")]
		private List<FNDIDCCLPKE> LEOLNKLMGON(ODBHMKEOHCG PCACEJCPOFN, HOFGADJGIDE CELNOPAPIHE, FODGGAGDMEH IEAGPBDAPCO, bool GMFNNKMEKEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x4860C50", Offset = "0x485F650", VA = "0x184860C50")]
		private List<FNDIDCCLPKE> JNJEBKDDOKE(ODBHMKEOHCG PCACEJCPOFN, HOFGADJGIDE CELNOPAPIHE, ACJGAIHJELB BPMKLCLFPCJ, bool GMFNNKMEKEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x4860A60", Offset = "0x485F460", VA = "0x184860A60")]
		private LLBJEPOEBFC JBOMJJKALGG(List<LLBJEPOEBFC> PKHEMOOKLLO, ACJGAIHJELB BPMKLCLFPCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x4862C50", Offset = "0x4861650", VA = "0x184862C50")]
		[CompilerGenerated]
		private NFPABPCJAGA OMLMAGCKMDP(GNMLBPFILMD PPNCECJAFNC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public sealed class KJDKIMBFEFH : FDDKFBJHECJ<LFGLAMNDMAP>
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class ACJFHMFJFCG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public KJDKIMBFEFH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public LILAAGPMKMO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public ACJFHMFJFCG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x205DF20", Offset = "0x205C920", VA = "0x18205DF20")]
			internal int EKIMLELLLBK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x205DF70", Offset = "0x205C970", VA = "0x18205DF70")]
			internal void JHMMMGBFJBC(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override NodeVisualizationKey JDBNAJHLPPP
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xA49930", Offset = "0xA48330", VA = "0x180A49930", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2075850", Offset = "0x2074250", VA = "0x182075850")]
		public KJDKIMBFEFH(DBKFEBENKEL NLLPJEKPGDO, LFGLAMNDMAP AJIEBFICGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2075690", Offset = "0x2074090", VA = "0x182075690", Slot = "120")]
		protected override void DLJDAFBNPBC(ODBHMKEOHCG PCACEJCPOFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public sealed class IKFNCNJIJPB : JBEJAGBKFDJ<DOAGJAIAENJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class DIAEAIPPDOO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public IKFNCNJIJPB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public LILAAGPMKMO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public DIAEAIPPDOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x2065330", Offset = "0x2063D30", VA = "0x182065330")]
			internal int CBHJBEKPBFD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x20653B0", Offset = "0x2063DB0", VA = "0x1820653B0")]
			internal void HDNFOCBGDNA(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2074190", Offset = "0x2072B90", VA = "0x182074190")]
		public IKFNCNJIJPB(DBKFEBENKEL NLLPJEKPGDO, DOAGJAIAENJ BMCAAIIMEIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2073F50", Offset = "0x2072950", VA = "0x182073F50", Slot = "126")]
		protected override void IAGPOKKMKBD(ODBHMKEOHCG PCACEJCPOFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private sealed class IDCIIDPIKNK : FDDKFBJHECJ<KMHJDKOBHPP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey JDBNAJHLPPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xA22E80", Offset = "0xA21880", VA = "0x180A22E80", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2073C30", Offset = "0x2072630", VA = "0x182073C30")]
		public IDCIIDPIKNK(DBKFEBENKEL NLLPJEKPGDO, KMHJDKOBHPP AJIEBFICGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "120")]
		protected override void DLJDAFBNPBC(ODBHMKEOHCG PCACEJCPOFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public sealed class CAOEAFAMDME : FDDKFBJHECJ<MBKELNIAMPF>
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class GCGBINJEFJP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public CAOEAFAMDME <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public ODBHMKEOHCG configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public Func<string> <>9__224;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public Action<string> <>9__225;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public Func<int> <>9__228;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public Action<int> <>9__229;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public Func<bool> <>9__230;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public Func<bool> <>9__231;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Func<bool> <>9__232;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Func<float> <>9__233;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Action<float> <>9__234;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Func<bool> <>9__235;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Func<bool> <>9__236;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Func<bool> <>9__237;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public Func<string> <>9__238;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Action<string> <>9__239;

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public GCGBINJEFJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x206FE90", Offset = "0x206E890", VA = "0x18206FE90")]
			internal bool EKIMLELLLBK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x20713D0", Offset = "0x206FDD0", VA = "0x1820713D0")]
			internal void JHMMMGBFJBC(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x20693A0", Offset = "0x2067DA0", VA = "0x1820693A0")]
			internal bool CCCGDHCBFGD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x2071DD0", Offset = "0x20707D0", VA = "0x182071DD0")]
			internal bool LIAGIHGIJMN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x2071EC0", Offset = "0x20708C0", VA = "0x182071EC0")]
			internal void LJOEOKPGLFG(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x2072790", Offset = "0x2071190", VA = "0x182072790")]
			internal bool OCOOHNBGGDJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x2070160", Offset = "0x206EB60", VA = "0x182070160")]
			internal bool FEIPPEEBHLO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x2069B00", Offset = "0x2068500", VA = "0x182069B00")]
			internal void DMPNMGNBLNK(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x206FEE0", Offset = "0x206E8E0", VA = "0x18206FEE0")]
			internal bool EKJNIMHAOGO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x2069260", Offset = "0x2067C60", VA = "0x182069260")]
			internal bool CAMJNFIDOLC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x20718A0", Offset = "0x20702A0", VA = "0x1820718A0")]
			internal void KLHFNBNIGDC(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x2071690", Offset = "0x2070090", VA = "0x182071690")]
			internal bool KEPJIOEDIFO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x2072B60", Offset = "0x2071560", VA = "0x182072B60")]
			internal bool OKIMCFFMJCI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x20706F0", Offset = "0x206F0F0", VA = "0x1820706F0")]
			internal bool FOFBKNBNAAJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x206FDF0", Offset = "0x206E7F0", VA = "0x18206FDF0")]
			internal bool EHKPHMGDPJL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x2069AB0", Offset = "0x20684B0", VA = "0x182069AB0")]
			internal bool DMFBDEJDBNO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x2069A10", Offset = "0x2068410", VA = "0x182069A10")]
			internal bool DJPBEEICAAM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x2070B60", Offset = "0x206F560", VA = "0x182070B60")]
			internal bool GOPENMMAFAP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x20715F0", Offset = "0x206FFF0", VA = "0x1820715F0")]
			internal bool KBPJFEDGMGN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x2068830", Offset = "0x2067230", VA = "0x182068830")]
			internal bool ACMOBDFHDFK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x2072940", Offset = "0x2071340", VA = "0x182072940")]
			internal void OHBNEDDMMKF(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x2068A70", Offset = "0x2067470", VA = "0x182068A70")]
			internal bool AKNGJMGDNPF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x2072250", Offset = "0x2070C50", VA = "0x182072250")]
			internal bool MJOLFAFFDMM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x2072110", Offset = "0x2070B10", VA = "0x182072110")]
			internal bool MCOIALKCCPE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x2072830", Offset = "0x2071230", VA = "0x182072830")]
			internal bool ODILFDMHHKJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x2072D60", Offset = "0x2071760", VA = "0x182072D60")]
			internal bool PEPLFDLCCBK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x20719B0", Offset = "0x20703B0", VA = "0x1820719B0")]
			internal bool KMMMEMPMIJB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x2071E20", Offset = "0x2070820", VA = "0x182071E20")]
			internal bool LJDPINLLINO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x20708E0", Offset = "0x206F2E0", VA = "0x1820708E0")]
			internal bool GFMNBCKLHOI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x2071840", Offset = "0x2070240", VA = "0x182071840")]
			internal void KHPELOMPPCL(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x2072E00", Offset = "0x2071800", VA = "0x182072E00")]
			internal bool PHCABEENIIJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x2069850", Offset = "0x2068250", VA = "0x182069850")]
			internal bool DEHPDOMNFEF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x20723B0", Offset = "0x2070DB0", VA = "0x1820723B0")]
			internal void NDAAIKGIEIG(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x2069120", Offset = "0x2067B20", VA = "0x182069120")]
			internal bool BPPOBPIDJIH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x20721B0", Offset = "0x2070BB0", VA = "0x1820721B0")]
			internal bool MHPCALAKNNO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x2069580", Offset = "0x2067F80", VA = "0x182069580")]
			internal void CJGDBHLPNKJ(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x2069BB0", Offset = "0x20685B0", VA = "0x182069BB0")]
			internal List<FNDIDCCLPKE> EACDKPDHJNG(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x2069080", Offset = "0x2067A80", VA = "0x182069080")]
			internal bool BOPGMDCCOEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x2068880", Offset = "0x2067280", VA = "0x182068880")]
			internal int ACOBJLGNDBA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x2070880", Offset = "0x206F280", VA = "0x182070880")]
			internal void GFJJCCOILKK(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x206FFD0", Offset = "0x206E9D0", VA = "0x18206FFD0")]
			internal bool EMMEMFEEMGB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x2070070", Offset = "0x206EA70", VA = "0x182070070")]
			internal bool EPECIDIGCOA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x2072BB0", Offset = "0x20715B0", VA = "0x182072BB0")]
			internal bool ONHNKCOCJII()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x206FC70", Offset = "0x206E670", VA = "0x18206FC70")]
			internal int EEELMJAHLLA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x20709F0", Offset = "0x206F3F0", VA = "0x1820709F0")]
			internal void GHLLOGPOMBD(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x2071640", Offset = "0x2070040", VA = "0x182071640")]
			internal bool KCPNGBMJJHG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x2071190", Offset = "0x206FB90", VA = "0x182071190")]
			internal bool JAFJCKGIJGI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x20692B0", Offset = "0x2067CB0", VA = "0x1820692B0")]
			internal bool CBABBKGCIAB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x20724B0", Offset = "0x2070EB0", VA = "0x1820724B0")]
			internal bool NGPFJEGPLDH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x2072500", Offset = "0x2070F00", VA = "0x182072500")]
			internal bool NHFBBKFGPMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x2069B60", Offset = "0x2068560", VA = "0x182069B60")]
			internal bool DNNFEKGNGHD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x2071290", Offset = "0x206FC90", VA = "0x182071290")]
			internal string JDAAKEBILNB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x2071430", Offset = "0x206FE30", VA = "0x182071430")]
			internal void JHOOMPOCNOO(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x20709A0", Offset = "0x206F3A0", VA = "0x1820709A0")]
			internal int GHIFMBELCBH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x20726E0", Offset = "0x20710E0", VA = "0x1820726E0")]
			internal void NOKOPHMLJHI(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x2070FB0", Offset = "0x206F9B0", VA = "0x182070FB0")]
			internal bool IFKPBEDPGPB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x2068C80", Offset = "0x2067680", VA = "0x182068C80")]
			internal bool BAKKHCEHMPM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x20694E0", Offset = "0x2067EE0", VA = "0x1820694E0")]
			internal bool CHLEIIFGCAE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x2072200", Offset = "0x2070C00", VA = "0x182072200")]
			internal float MIDMDMGFPPP()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x2071B10", Offset = "0x2070510", VA = "0x182071B10")]
			internal void LACIBKNHOJK(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x2068E50", Offset = "0x2067850", VA = "0x182068E50")]
			internal bool BHNAMJPMNAI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x20707E0", Offset = "0x206F1E0", VA = "0x1820707E0")]
			internal bool GDMABCHPFLA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x2072550", Offset = "0x2070F50", VA = "0x182072550")]
			internal bool NIGOILLIJAB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x2069530", Offset = "0x2067F30", VA = "0x182069530")]
			internal bool CIHKDDPGFFF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x2072690", Offset = "0x2071090", VA = "0x182072690")]
			internal bool NOFHCJNLJAJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x2070EC0", Offset = "0x206F8C0", VA = "0x182070EC0")]
			internal bool IALNNELAEGG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x20701B0", Offset = "0x206EBB0", VA = "0x1820701B0")]
			internal void FGEOEOGDHPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x20705B0", Offset = "0x206EFB0", VA = "0x1820705B0")]
			internal string FIJPGMKIEJD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x20699A0", Offset = "0x20683A0", VA = "0x1820699A0")]
			internal void DILHCGDANGM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x2071380", Offset = "0x206FD80", VA = "0x182071380")]
			internal bool JHJFCDONKIM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x2071CD0", Offset = "0x20706D0", VA = "0x182071CD0")]
			internal bool LHDGNHEOPCB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x2068EA0", Offset = "0x20678A0", VA = "0x182068EA0")]
			internal bool BIHNHBNEHNF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x2072F90", Offset = "0x2071990", VA = "0x182072F90")]
			internal void PKKNOJDFJNE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x2068FE0", Offset = "0x20679E0", VA = "0x182068FE0")]
			internal bool BLPEAFOBDGP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x2072F40", Offset = "0x2071940", VA = "0x182072F40")]
			internal bool PKCEFIDIADE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x2070F10", Offset = "0x206F910", VA = "0x182070F10")]
			internal bool ICDHPEAPJFD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x20691C0", Offset = "0x2067BC0", VA = "0x1820691C0")]
			internal bool CAHGPGPCKGI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x2071D70", Offset = "0x2070770", VA = "0x182071D70")]
			internal void LIAAGFDINKD(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x20728F0", Offset = "0x20712F0", VA = "0x1820728F0")]
			internal bool OGOCDEBJMPL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x2071A50", Offset = "0x2070450", VA = "0x182071A50")]
			internal bool KOKHKKGAGGP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x20715A0", Offset = "0x206FFA0", VA = "0x1820715A0")]
			internal bool KBEENPIOBEO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x2071A00", Offset = "0x2070400", VA = "0x182071A00")]
			internal bool KNAMAEPJMDF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x2068B60", Offset = "0x2067560", VA = "0x182068B60")]
			internal void AMDMCMMIKBK(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x2070F60", Offset = "0x206F960", VA = "0x182070F60")]
			internal bool IFKGGNIKCLP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x206FE40", Offset = "0x206E840", VA = "0x18206FE40")]
			internal bool EJGNAJMDMOK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x2069030", Offset = "0x2067A30", VA = "0x182069030")]
			internal bool BOJEOHMMHLM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x2068F90", Offset = "0x2067990", VA = "0x182068F90")]
			internal bool BKNPFKFOLOH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x2072340", Offset = "0x2070D40", VA = "0x182072340")]
			internal object NAJFIOOEEJE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x206FD10", Offset = "0x206E710", VA = "0x18206FD10")]
			internal void EEOOCKIKPJG(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x2072020", Offset = "0x2070A20", VA = "0x182072020")]
			internal bool MAANHHCADLO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x2068EF0", Offset = "0x20678F0", VA = "0x182068EF0")]
			internal bool BIINIBLMLMN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x2073250", Offset = "0x2071C50", VA = "0x182073250")]
			internal int PKPEOEDOBLK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x2071900", Offset = "0x2070300", VA = "0x182071900")]
			internal void KMAEMMLEFBL(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x20696A0", Offset = "0x20680A0", VA = "0x1820696A0")]
			internal bool CLHPJJGNEMC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x2071140", Offset = "0x206FB40", VA = "0x182071140")]
			internal bool IPGOGNKOPHD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x206FCC0", Offset = "0x206E6C0", VA = "0x18206FCC0")]
			internal int EEKCEFGOEKA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x20711E0", Offset = "0x206FBE0", VA = "0x1820711E0")]
			internal void JCEAILODGNJ(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x2069210", Offset = "0x2067C10", VA = "0x182069210")]
			internal bool CAIIHJEKNNG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x20722F0", Offset = "0x2070CF0", VA = "0x1820722F0")]
			internal bool MPDMLFALBGK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x20697B0", Offset = "0x20681B0", VA = "0x1820697B0")]
			internal bool COOFBIPLPPF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x2068720", Offset = "0x2067120", VA = "0x182068720")]
			internal int AAGHHDHGOPH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x20729F0", Offset = "0x20713F0", VA = "0x1820729F0")]
			internal void OIMEEENOBKC(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x2072EF0", Offset = "0x20718F0", VA = "0x182072EF0")]
			internal bool PJNGIOBOFAF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x2071960", Offset = "0x2070360", VA = "0x182071960")]
			internal bool KMBONACEFOE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x2072160", Offset = "0x2070B60", VA = "0x182072160")]
			internal bool MGFNKHMHAKO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x2072C50", Offset = "0x2071650", VA = "0x182072C50")]
			internal object OPJILGGBMLI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x2068D70", Offset = "0x2067770", VA = "0x182068D70")]
			internal void BDMFAGBDJGF(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x20710F0", Offset = "0x206FAF0", VA = "0x1820710F0")]
			internal bool IMPLNBPCEIG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x2068F40", Offset = "0x2067940", VA = "0x182068F40")]
			internal bool BJOMECOJMCN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x2072A50", Offset = "0x2071450", VA = "0x182072A50")]
			internal object OJADFLDCAPH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x2071F20", Offset = "0x2070920", VA = "0x182071F20")]
			internal void LNLPINGHCHO(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x2070AC0", Offset = "0x206F4C0", VA = "0x182070AC0")]
			internal bool GLJMNKDBJCJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x2069490", Offset = "0x2067E90", VA = "0x182069490")]
			internal int CFCEKJIMOKC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x20714F0", Offset = "0x206FEF0", VA = "0x1820714F0")]
			internal void KAECLMIHPGP(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x2068A20", Offset = "0x2067420", VA = "0x182068A20")]
			internal bool AKJLCFJCBOA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x20720C0", Offset = "0x2070AC0", VA = "0x1820720C0")]
			internal bool MCIOFCODFKB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x2072E50", Offset = "0x2071850", VA = "0x182072E50")]
			internal bool PHLLCDJANFB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x2071C80", Offset = "0x2070680", VA = "0x182071C80")]
			internal int LGEIPIMFNFG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x2068C20", Offset = "0x2067620", VA = "0x182068C20")]
			internal void ANLOGJMGNNL(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x2071000", Offset = "0x206FA00", VA = "0x182071000")]
			internal bool IGJKAJHFIIG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x2068D20", Offset = "0x2067720", VA = "0x182068D20")]
			internal bool BDLCICLGCLM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x2068930", Offset = "0x2067330", VA = "0x182068930")]
			internal bool AHCJKIHCPNA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x2072B10", Offset = "0x2071510", VA = "0x182072B10")]
			internal float OKAKGKEHFKH()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x20688D0", Offset = "0x20672D0", VA = "0x1820688D0")]
			internal void AGKLGFOBHDD(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x2072CC0", Offset = "0x20716C0", VA = "0x182072CC0")]
			internal bool OPNMEBKNBMO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x2070650", Offset = "0x206F050", VA = "0x182070650")]
			internal bool FLHAJCEBKKN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x2072DB0", Offset = "0x20717B0", VA = "0x182072DB0")]
			internal bool PFHJOEAHMPG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x2068E00", Offset = "0x2067800", VA = "0x182068E00")]
			internal float BHBGNJICJPP()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x2069940", Offset = "0x2068340", VA = "0x182069940")]
			internal void DIHACHGKGIP(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x2069A60", Offset = "0x2068460", VA = "0x182069A60")]
			internal bool DMBJPFOIBCA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x206FDA0", Offset = "0x206E7A0", VA = "0x18206FDA0")]
			internal bool EFPGIPICGHK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x2071C30", Offset = "0x2070630", VA = "0x182071C30")]
			internal string LFOFNNJODLK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x2071FB0", Offset = "0x20709B0", VA = "0x182071FB0")]
			internal void LPCKEKPLHNC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x20695E0", Offset = "0x2067FE0", VA = "0x1820695E0")]
			internal bool CKIEEGMPHFL(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x2070790", Offset = "0x206F190", VA = "0x182070790")]
			internal bool GCCNMGKKICM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x206FC20", Offset = "0x206E620", VA = "0x18206FC20")]
			internal bool ECIGLAMHCAL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x206FF80", Offset = "0x206E980", VA = "0x18206FF80")]
			internal bool EMICDEKNFBM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x2070830", Offset = "0x206F230", VA = "0x182070830")]
			internal string GEAICJIMLFO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x2072880", Offset = "0x2071280", VA = "0x182072880")]
			internal void OFAECHMHLBC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x2069350", Offset = "0x2067D50", VA = "0x182069350")]
			internal bool CBJMKGFAEFO(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x20729A0", Offset = "0x20713A0", VA = "0x1820729A0")]
			internal bool OHGHDJMHPMA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x20725F0", Offset = "0x2070FF0", VA = "0x1820725F0")]
			internal bool NKGLFLHKDKL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x2070020", Offset = "0x206EA20", VA = "0x182070020")]
			internal bool EOANMHIMHOE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x20725A0", Offset = "0x2070FA0", VA = "0x1820725A0")]
			internal string NJLKGNGLGGN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x2071BC0", Offset = "0x20705C0", VA = "0x182071BC0")]
			internal void LCKCGCFKHAD(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x20690D0", Offset = "0x2067AD0", VA = "0x1820690D0")]
			internal bool BPOODIBNEMD(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x2072410", Offset = "0x2070E10", VA = "0x182072410")]
			internal bool NDKBHBJNHOD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x20714A0", Offset = "0x206FEA0", VA = "0x1820714A0")]
			internal bool JJIDFIKPDIP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x2072C00", Offset = "0x2071600", VA = "0x182072C00")]
			internal bool OPELHKCMJHA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x2071550", Offset = "0x206FF50", VA = "0x182071550")]
			internal string KAPCBMKCFHC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x20732A0", Offset = "0x2071CA0", VA = "0x1820732A0")]
			internal void PLHODLNCMOK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x2070D60", Offset = "0x206F760", VA = "0x182070D60")]
			internal bool HLJNEOBAHPC(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x2071240", Offset = "0x206FC40", VA = "0x182071240")]
			internal bool JCPOCCIMFHB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x2073310", Offset = "0x2071D10", VA = "0x182073310")]
			internal bool PMMAOEGMCEA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x20696F0", Offset = "0x20680F0", VA = "0x1820696F0")]
			internal bool CMODACFMKEJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x20717A0", Offset = "0x20701A0", VA = "0x1820717A0")]
			internal string KHJKJPAOIAD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x2069740", Offset = "0x2068140", VA = "0x182069740")]
			internal void CNIEDPHMBON(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x2070B10", Offset = "0x206F510", VA = "0x182070B10")]
			internal bool GOEBDMELBLH(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x2070BB0", Offset = "0x206F5B0", VA = "0x182070BB0")]
			internal bool GPIJKPDFMFL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x20727E0", Offset = "0x20711E0", VA = "0x1820727E0")]
			internal bool ODHOLFFAEAK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x2069170", Offset = "0x2067B70", VA = "0x182069170")]
			internal bool CAFKNJALLCH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x2070D10", Offset = "0x206F710", VA = "0x182070D10")]
			internal string HHHEENGEJHI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x2070C50", Offset = "0x206F650", VA = "0x182070C50")]
			internal void HFKMFHEICNI(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x2072AC0", Offset = "0x20714C0", VA = "0x182072AC0")]
			internal bool OJLKHNMIICC(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x2069300", Offset = "0x2067D00", VA = "0x182069300")]
			internal bool CBDKHFNIIFM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x20698A0", Offset = "0x20682A0", VA = "0x1820698A0")]
			internal bool DFMCBAOHDPN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x20712E0", Offset = "0x206FCE0", VA = "0x1820712E0")]
			internal bool JDIBAPOHHNG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x20698F0", Offset = "0x20682F0", VA = "0x1820698F0")]
			internal string DGADPNENEAC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x2071730", Offset = "0x2070130", VA = "0x182071730")]
			internal void KFEPIIPGFKJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x20689D0", Offset = "0x20673D0", VA = "0x1820689D0")]
			internal bool AIEHFJFGMLO(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x20733C0", Offset = "0x2071DC0", VA = "0x1820733C0")]
			internal bool PPGGBOBAABN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x2070E20", Offset = "0x206F820", VA = "0x182070E20")]
			internal bool HOLLPBEKPBN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x2072640", Offset = "0x2071040", VA = "0x182072640")]
			internal bool NLJPGOCBKCG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x20722A0", Offset = "0x2070CA0", VA = "0x1820722A0")]
			internal string MNNCOPJPHHH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x2071AA0", Offset = "0x20704A0", VA = "0x182071AA0")]
			internal void KPMFPCGIOCN(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x2068980", Offset = "0x2067380", VA = "0x182068980")]
			internal bool AIDFJGMOHNO(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x2070740", Offset = "0x206F140", VA = "0x182070740")]
			internal bool FOGIOFHHPKH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x2072070", Offset = "0x2070A70", VA = "0x182072070")]
			internal bool MCCGANDOBON()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x2071B70", Offset = "0x2070570", VA = "0x182071B70")]
			internal bool LCHMLIDBODA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x2071D20", Offset = "0x2070720", VA = "0x182071D20")]
			internal string LHOCFPGEOPK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x2070DB0", Offset = "0x206F7B0", VA = "0x182070DB0")]
			internal void HOKLEGBDCJO(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x2070CC0", Offset = "0x206F6C0", VA = "0x182070CC0")]
			internal bool HGPMDCHHHEL(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x2071330", Offset = "0x206FD30", VA = "0x182071330")]
			internal bool JGLMEHPLODD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x206FF30", Offset = "0x206E930", VA = "0x18206FF30")]
			internal bool EKPJHNMKMLO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x2068CD0", Offset = "0x20676D0", VA = "0x182068CD0")]
			internal bool BBLPAFEDDGG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x20686D0", Offset = "0x20670D0", VA = "0x1820686D0")]
			internal string AADPHOPPLNG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x2069630", Offset = "0x2068030", VA = "0x182069630")]
			internal void CKLGJHKEDJP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x2072460", Offset = "0x2070E60", VA = "0x182072460")]
			internal bool NEDDKJDCNCI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x2070C00", Offset = "0x206F600", VA = "0x182070C00")]
			internal bool HCOMAEKJFNK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x20710A0", Offset = "0x206FAA0", VA = "0x1820710A0")]
			internal bool IMOBCDLBJGK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x2070E70", Offset = "0x206F870", VA = "0x182070E70")]
			internal string HPBMMLEGDLK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x2068770", Offset = "0x2067170", VA = "0x182068770")]
			internal void ABFBMLJEDHC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x2072D10", Offset = "0x2071710", VA = "0x182072D10")]
			internal bool PEDLIILMKHB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x20687E0", Offset = "0x20671E0", VA = "0x1820687E0")]
			internal bool ACECJEKJHNI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x20693F0", Offset = "0x2067DF0", VA = "0x1820693F0")]
			internal bool CCDHBBBKBHN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x2072EA0", Offset = "0x20718A0", VA = "0x182072EA0")]
			internal string PILMFCHGOMK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x2070930", Offset = "0x206F330", VA = "0x182070930")]
			internal void GHFMMDGPGBC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x2070110", Offset = "0x206EB10", VA = "0x182070110")]
			internal bool FBCEJFPLNEM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x2072740", Offset = "0x2071140", VA = "0x182072740")]
			internal bool OBFPIGAPMLK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x2069440", Offset = "0x2067E40", VA = "0x182069440")]
			internal bool CEDNINDIELI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x20706A0", Offset = "0x206F0A0", VA = "0x1820706A0")]
			internal string FNADLLNEIPK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x2070A50", Offset = "0x206F450", VA = "0x182070A50")]
			internal void GJOFBKKBLMN(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x20700C0", Offset = "0x206EAC0", VA = "0x1820700C0")]
			internal bool FABCCIGANLL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x2071050", Offset = "0x206FA50", VA = "0x182071050")]
			internal bool IIOGPKGDEOK(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x20716E0", Offset = "0x20700E0", VA = "0x1820716E0")]
			internal float KFCOIODLJNI()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x2068BC0", Offset = "0x20675C0", VA = "0x182068BC0")]
			internal void AMIKOMDFDMN(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x2068B10", Offset = "0x2067510", VA = "0x182068B10")]
			internal bool ALOCMKOCHEF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x20717F0", Offset = "0x20701F0", VA = "0x1820717F0")]
			internal bool KHLIMLNMMBD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x2069800", Offset = "0x2068200", VA = "0x182069800")]
			internal bool CPKLMNCHGJP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x2068AC0", Offset = "0x20674C0", VA = "0x182068AC0")]
			internal int ALNOLMJNBKD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x2073360", Offset = "0x2071D60", VA = "0x182073360")]
			internal void PMMJPCFCDAN(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x2071E70", Offset = "0x2070870", VA = "0x182071E70")]
			internal bool LJHNNLDCLIO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x2070600", Offset = "0x206F000", VA = "0x182070600")]
			internal bool FLEKBHKDGHK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x2070560", Offset = "0x206EF60", VA = "0x182070560")]
			internal bool FIDKJCKDDKC()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class BEHOFJPJDFJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public string secondaryLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public GCGBINJEFJP CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public BEHOFJPJDFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x205EE80", Offset = "0x205D880", VA = "0x18205EE80")]
			internal void LPNHEMLJPAO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class MFIBFBHCIMA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public char[] swizzleChars;

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public MFIBFBHCIMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x2076820", Offset = "0x2075220", VA = "0x182076820")]
			internal bool DJAFAKAIDAK(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly OHAODOOFHCE JBCNEBLPAIG;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x20624B0", Offset = "0x2060EB0", VA = "0x1820624B0")]
		public CAOEAFAMDME(DBKFEBENKEL NLLPJEKPGDO, MBKELNIAMPF AJIEBFICGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2060760", Offset = "0x205F160", VA = "0x182060760", Slot = "120")]
		protected override void DLJDAFBNPBC(ODBHMKEOHCG PCACEJCPOFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public sealed class FHALJGDJLCF : FDDKFBJHECJ<BPFFMGEPAHL>
	{
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class CKGIFEBENOG
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006A")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000175")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000176")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000177")]
				public CKGIFEBENOG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				private TaskAwaiter<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002A5")]
				[Cpp2IlInjected.Address(RVA = "0x2097830", Offset = "0x2096230", VA = "0x182097830", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A6")]
				[Cpp2IlInjected.Address(RVA = "0xB9ACE0", Offset = "0xB996E0", VA = "0x180B9ACE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public FHALJGDJLCF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public LILAAGPMKMO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public CKGIFEBENOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x207D800", Offset = "0x207C200", VA = "0x18207D800")]
			internal string EKIMLELLLBK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x207D8A0", Offset = "0x207C2A0", VA = "0x18207D8A0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void JHMMMGBFJBC(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x207D850", Offset = "0x207C250", VA = "0x18207D850")]
			internal int FJEBMGILCGL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x207D770", Offset = "0x207C170", VA = "0x18207D770")]
			internal void EHDKHGOAOBN(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override NodeVisualizationKey JDBNAJHLPPP
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xA49930", Offset = "0xA48330", VA = "0x180A49930", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x2087EA0", Offset = "0x20868A0", VA = "0x182087EA0")]
		public FHALJGDJLCF(DBKFEBENKEL NLLPJEKPGDO, BPFFMGEPAHL BMCAAIIMEIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x2087B50", Offset = "0x2086550", VA = "0x182087B50", Slot = "120")]
		protected override void DLJDAFBNPBC(ODBHMKEOHCG PCACEJCPOFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public sealed class ELBPGJKJLCJ : FDDKFBJHECJ<LDIDLGPFCIE>
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private sealed class JBDHIHHGEJO
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006D")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				public JBDHIHHGEJO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000180")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000181")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000182")]
				private TaskAwaiter<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BA")]
				[Cpp2IlInjected.Address(RVA = "0x20974F0", Offset = "0x2095EF0", VA = "0x1820974F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BB")]
				[Cpp2IlInjected.Address(RVA = "0xB9ACE0", Offset = "0xB996E0", VA = "0x180B9ACE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006E")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000183")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000184")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000185")]
				public JBDHIHHGEJO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000188")]
				private TaskAwaiter<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x2097B40", Offset = "0x2096540", VA = "0x182097B40", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0xB9ACE0", Offset = "0xB996E0", VA = "0x180B9ACE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public ELBPGJKJLCJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public LILAAGPMKMO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public JBDHIHHGEJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x208C730", Offset = "0x208B130", VA = "0x18208C730")]
			internal string EKIMLELLLBK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x208C930", Offset = "0x208B330", VA = "0x18208C930")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void JHMMMGBFJBC(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x208C840", Offset = "0x208B240", VA = "0x18208C840")]
			internal int FJEBMGILCGL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x208C6A0", Offset = "0x208B0A0", VA = "0x18208C6A0")]
			internal void EHDKHGOAOBN(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x208C5C0", Offset = "0x208AFC0", VA = "0x18208C5C0")]
			internal string CCCGDHCBFGD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x208CAB0", Offset = "0x208B4B0", VA = "0x18208CAB0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void LIAGIHGIJMN(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x208CB80", Offset = "0x208B580", VA = "0x18208CB80")]
			internal bool LJOEOKPGLFG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x208CC60", Offset = "0x208B660", VA = "0x18208CC60")]
			internal void OIKJCJPLEDI(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x208CA60", Offset = "0x208B460", VA = "0x18208CA60")]
			internal bool KMILKLCMLPG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x208CBD0", Offset = "0x208B5D0", VA = "0x18208CBD0")]
			internal void OCOOHNBGGDJ(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x208C7F0", Offset = "0x208B1F0", VA = "0x18208C7F0")]
			internal float FEIPPEEBHLO()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x208C610", Offset = "0x208B010", VA = "0x18208C610")]
			internal void DMPNMGNBLNK(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x208CA00", Offset = "0x208B400", VA = "0x18208CA00")]
			internal int KAAEAKBOJKK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x208C890", Offset = "0x208B290", VA = "0x18208C890")]
			internal void FOKPEBDKFMC(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x208C780", Offset = "0x208B180", VA = "0x18208C780")]
			internal bool EKJNIMHAOGO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey JDBNAJHLPPP
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0xA49930", Offset = "0xA48330", VA = "0x180A49930", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x2086CC0", Offset = "0x20856C0", VA = "0x182086CC0")]
		public ELBPGJKJLCJ(DBKFEBENKEL NLLPJEKPGDO, LDIDLGPFCIE AJIEBFICGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x2086280", Offset = "0x2084C80", VA = "0x182086280", Slot = "120")]
		protected override void DLJDAFBNPBC(ODBHMKEOHCG PCACEJCPOFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class MFAEAGHOPCO : FDDKFBJHECJ<PHABDDHMDKK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class AEHODAGFNBN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public LILAAGPMKMO nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public MFAEAGHOPCO <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public AEHODAGFNBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x207C760", Offset = "0x207B160", VA = "0x18207C760")]
			internal Dictionary<string, GOLDOKHMCBL> EKIMLELLLBK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x207C920", Offset = "0x207B320", VA = "0x18207C920")]
			internal int JHMMMGBFJBC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x207C800", Offset = "0x207B200", VA = "0x18207C800")]
			internal void FJEBMGILCGL(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x207C6E0", Offset = "0x207B0E0", VA = "0x18207C6E0")]
			internal bool EHDKHGOAOBN()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey JDBNAJHLPPP
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0xA49930", Offset = "0xA48330", VA = "0x180A49930", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x208EC40", Offset = "0x208D640", VA = "0x18208EC40")]
		public MFAEAGHOPCO(DBKFEBENKEL NLLPJEKPGDO, PHABDDHMDKK BMCAAIIMEIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x208E970", Offset = "0x208D370", VA = "0x18208E970", Slot = "120")]
		protected override void DLJDAFBNPBC(ODBHMKEOHCG PCACEJCPOFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class JOEEDKEOODG : FDDKFBJHECJ<PFELADLCOPA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private sealed class PNJBICLDOOM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public LILAAGPMKMO nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public JOEEDKEOODG <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public PNJBICLDOOM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x20970D0", Offset = "0x2095AD0", VA = "0x1820970D0")]
			internal void EKIMLELLLBK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey JDBNAJHLPPP
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0xA49930", Offset = "0xA48330", VA = "0x180A49930", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x208D6A0", Offset = "0x208C0A0", VA = "0x18208D6A0")]
		public JOEEDKEOODG(DBKFEBENKEL NLLPJEKPGDO, PFELADLCOPA BMCAAIIMEIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x208D520", Offset = "0x208BF20", VA = "0x18208D520", Slot = "120")]
		protected override void DLJDAFBNPBC(ODBHMKEOHCG PCACEJCPOFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private sealed class MAKOBBOJPGB : OOGPDBKGEKD<JKDDHCGECEB>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool GPFICBPFPIC
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override bool BMOCJKPPFMB
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x208E8D0", Offset = "0x208D2D0", VA = "0x18208E8D0", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override NodeVisualizationKey JDBNAJHLPPP
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x907610", Offset = "0x906010", VA = "0x180907610", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x208E870", Offset = "0x208D270", VA = "0x18208E870")]
		public MAKOBBOJPGB(DBKFEBENKEL NLLPJEKPGDO, JKDDHCGECEB AJIEBFICGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "120")]
		protected override void DLJDAFBNPBC(ODBHMKEOHCG PCACEJCPOFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	private sealed class LEDGAKEOFNK : FDDKFBJHECJ<DBFLDBCBJNJ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override NodeVisualizationKey JDBNAJHLPPP
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xA18840", Offset = "0xA17240", VA = "0x180A18840", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x208E5E0", Offset = "0x208CFE0", VA = "0x18208E5E0")]
		public LEDGAKEOFNK(DBKFEBENKEL NLLPJEKPGDO, DBFLDBCBJNJ AJIEBFICGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "120")]
		protected override void DLJDAFBNPBC(ODBHMKEOHCG PCACEJCPOFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class BBAOGJNLJIL : FDDKFBJHECJ<GLCNKPLANCA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override NodeVisualizationKey JDBNAJHLPPP
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0xA54A30", Offset = "0xA53430", VA = "0x180A54A30", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x207D2A0", Offset = "0x207BCA0", VA = "0x18207D2A0")]
		public BBAOGJNLJIL(DBKFEBENKEL NLLPJEKPGDO, GLCNKPLANCA AJIEBFICGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "112")]
		protected override bool FMBKMHCOENA(MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "120")]
		protected override void DLJDAFBNPBC(ODBHMKEOHCG PCACEJCPOFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class MLGHLNMMDHK : FDDKFBJHECJ<AHJGEBLMAKM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override NodeVisualizationKey JDBNAJHLPPP
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0xA581F0", Offset = "0xA56BF0", VA = "0x180A581F0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool CEDMOJHLHMA
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x208F5A0", Offset = "0x208DFA0", VA = "0x18208F5A0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected override bool CNAPMEAKAOF
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x208F530", Offset = "0x208DF30", VA = "0x18208F530")]
		public MLGHLNMMDHK(DBKFEBENKEL NLLPJEKPGDO, AHJGEBLMAKM AJIEBFICGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "120")]
		protected override void DLJDAFBNPBC(ODBHMKEOHCG PCACEJCPOFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private sealed class ADCHAAICAFB : FDDKFBJHECJ<HJMDCDAAKGB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override NodeVisualizationKey JDBNAJHLPPP
		{
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x91D410", Offset = "0x91BE10", VA = "0x18091D410", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override bool CEDMOJHLHMA
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x207C690", Offset = "0x207B090", VA = "0x18207C690", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		protected override bool CNAPMEAKAOF
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x207C620", Offset = "0x207B020", VA = "0x18207C620")]
		public ADCHAAICAFB(DBKFEBENKEL NLLPJEKPGDO, HJMDCDAAKGB AJIEBFICGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "120")]
		protected override void DLJDAFBNPBC(ODBHMKEOHCG PCACEJCPOFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public sealed class CHGPKJFNFDB : JBEJAGBKFDJ<PIABPEKEBKH>
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		[CompilerGenerated]
		private sealed class OENEPGEMNCJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public CHGPKJFNFDB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public LILAAGPMKMO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public OENEPGEMNCJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x2095960", Offset = "0x2094360", VA = "0x182095960")]
			internal float CBHJBEKPBFD()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x20959E0", Offset = "0x20943E0", VA = "0x1820959E0")]
			internal void HDNFOCBGDNA(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x207D710", Offset = "0x207C110", VA = "0x18207D710")]
		public CHGPKJFNFDB(DBKFEBENKEL NLLPJEKPGDO, PIABPEKEBKH BMCAAIIMEIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x207D490", Offset = "0x207BE90", VA = "0x18207D490", Slot = "126")]
		protected override void IAGPOKKMKBD(ODBHMKEOHCG PCACEJCPOFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public sealed class NCPEANELLAH : FDDKFBJHECJ<LFLALCCJLHG>
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		[CompilerGenerated]
		private sealed class LJDPMCLPPJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public NCPEANELLAH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public LILAAGPMKMO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public LJDPMCLPPJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x208E650", Offset = "0x208D050", VA = "0x18208E650")]
			internal bool EKIMLELLLBK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x208E6A0", Offset = "0x208D0A0", VA = "0x18208E6A0")]
			internal void JHMMMGBFJBC(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x2094820", Offset = "0x2093220", VA = "0x182094820")]
		public NCPEANELLAH(DBKFEBENKEL NLLPJEKPGDO, LFLALCCJLHG BMCAAIIMEIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x2094570", Offset = "0x2092F70", VA = "0x182094570", Slot = "120")]
		protected override void DLJDAFBNPBC(ODBHMKEOHCG PCACEJCPOFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public sealed class IPFALODAAPL : FDDKFBJHECJ<NLBGKJMMPKP>
	{
		[Cpp2IlInjected.Token(Token = "0x200007D")]
		[CompilerGenerated]
		private sealed class AHEINPLJCGL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public LILAAGPMKMO nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public IPFALODAAPL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public AHEINPLJCGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x207CA30", Offset = "0x207B430", VA = "0x18207CA30")]
			internal object EKIMLELLLBK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x207D080", Offset = "0x207BA80", VA = "0x18207D080")]
			internal bool OIKJCJPLEDI(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x207CCC0", Offset = "0x207B6C0", VA = "0x18207CCC0")]
			internal void JHMMMGBFJBC(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x207CB60", Offset = "0x207B560", VA = "0x18207CB60")]
			internal string FJEBMGILCGL(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x207C9E0", Offset = "0x207B3E0", VA = "0x18207C9E0")]
			internal IReadOnlyList<object> EHDKHGOAOBN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x207C970", Offset = "0x207B370", VA = "0x18207C970")]
			internal bool CCCGDHCBFGD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x207CF10", Offset = "0x207B910", VA = "0x18207CF10")]
			internal bool LIAGIHGIJMN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x207CF60", Offset = "0x207B960", VA = "0x18207CF60")]
			internal void LJOEOKPGLFG(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x208C150", Offset = "0x208AB50", VA = "0x18208C150")]
		public IPFALODAAPL(DBKFEBENKEL NLLPJEKPGDO, NLBGKJMMPKP BMCAAIIMEIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x208B940", Offset = "0x208A340", VA = "0x18208B940", Slot = "120")]
		protected override void DLJDAFBNPBC(ODBHMKEOHCG PCACEJCPOFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public sealed class OMJOMJGMJIJ : LLGMLCGGDGI<MLFFKBJLFHM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override NodeVisualizationKey JDBNAJHLPPP
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0xC3ABA0", Offset = "0xC395A0", VA = "0x180C3ABA0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x2095F60", Offset = "0x2094960", VA = "0x182095F60")]
		public OMJOMJGMJIJ(DBKFEBENKEL NLLPJEKPGDO, MLFFKBJLFHM AJIEBFICGCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public sealed class EGJKCKKLODO : JBEJAGBKFDJ<DGCBKNDOCEF>
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class AJKPKNAFHHK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public EGJKCKKLODO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public LILAAGPMKMO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public AJKPKNAFHHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x207D100", Offset = "0x207BB00", VA = "0x18207D100")]
			internal int CBHJBEKPBFD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x207D180", Offset = "0x207BB80", VA = "0x18207D180")]
			internal void HDNFOCBGDNA(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x2086220", Offset = "0x2084C20", VA = "0x182086220")]
		public EGJKCKKLODO(DBKFEBENKEL NLLPJEKPGDO, DGCBKNDOCEF BMCAAIIMEIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x2085F90", Offset = "0x2084990", VA = "0x182085F90", Slot = "126")]
		protected override void IAGPOKKMKBD(ODBHMKEOHCG PCACEJCPOFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public sealed class HIGEMLBHKPA : FDDKFBJHECJ<OHENEGPFDCB>
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		[CompilerGenerated]
		private sealed class OBMKOAKEGNF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public HIGEMLBHKPA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public LILAAGPMKMO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public OBMKOAKEGNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x20957A0", Offset = "0x20941A0", VA = "0x1820957A0")]
			internal bool EKIMLELLLBK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x20957F0", Offset = "0x20941F0", VA = "0x1820957F0")]
			internal void JHMMMGBFJBC(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x20890B0", Offset = "0x2087AB0", VA = "0x1820890B0")]
		public HIGEMLBHKPA(DBKFEBENKEL NLLPJEKPGDO, OHENEGPFDCB BMCAAIIMEIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x2088ED0", Offset = "0x20878D0", VA = "0x182088ED0", Slot = "120")]
		protected override void DLJDAFBNPBC(ODBHMKEOHCG PCACEJCPOFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class IGEHMNPHEHJ : FDDKFBJHECJ<JLAMPAOCAIB>
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		[CompilerGenerated]
		private sealed class ODAPBHHIPHJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public IGEHMNPHEHJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public LILAAGPMKMO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public ODAPBHHIPHJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x2095880", Offset = "0x2094280", VA = "0x182095880")]
			internal bool EKIMLELLLBK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x20958D0", Offset = "0x20942D0", VA = "0x1820958D0")]
			internal void JHMMMGBFJBC(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x208B360", Offset = "0x2089D60", VA = "0x18208B360")]
		public IGEHMNPHEHJ(DBKFEBENKEL NLLPJEKPGDO, JLAMPAOCAIB BMCAAIIMEIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x208B180", Offset = "0x2089B80", VA = "0x18208B180", Slot = "120")]
		protected override void DLJDAFBNPBC(ODBHMKEOHCG PCACEJCPOFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class PEILLJMANPF : FDDKFBJHECJ<FNMHDDKJHCK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		[CompilerGenerated]
		private sealed class IOEAGEBHDNO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public PEILLJMANPF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public LILAAGPMKMO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public IOEAGEBHDNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x208B430", Offset = "0x2089E30", VA = "0x18208B430")]
			internal int EKIMLELLLBK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x208B480", Offset = "0x2089E80", VA = "0x18208B480")]
			internal void JHMMMGBFJBC(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x2096CA0", Offset = "0x20956A0", VA = "0x182096CA0")]
		public PEILLJMANPF(DBKFEBENKEL NLLPJEKPGDO, FNMHDDKJHCK BMCAAIIMEIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x2096A40", Offset = "0x2095440", VA = "0x182096A40", Slot = "120")]
		protected override void DLJDAFBNPBC(ODBHMKEOHCG PCACEJCPOFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class ILJAIMACKIH : NKFGKEJNIDG<JDANPGDDLEC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override HNCHBMBKAHI FJMKJEMBLNL
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x900EE0", Offset = "0x8FF8E0", VA = "0x180900EE0", Slot = "126")]
			get
			{
				return default(HNCHBMBKAHI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x208B3D0", Offset = "0x2089DD0", VA = "0x18208B3D0")]
		public ILJAIMACKIH(DBKFEBENKEL NLLPJEKPGDO, JDANPGDDLEC BMCAAIIMEIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class JECBEABJJGB : FDDKFBJHECJ<GNMLBPFILMD>
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x208B8D0", Offset = "0x208A2D0", VA = "0x18208B8D0")]
		public JECBEABJJGB(DBKFEBENKEL NLLPJEKPGDO, GNMLBPFILMD AJIEBFICGCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public abstract class FDDKFBJHECJ<TNode> : JINHCMKFECA, IDisposable where TNode : notnull, GNMLBPFILMD
	{
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		[CompilerGenerated]
		private sealed class DMEIBNOPPGF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public FDDKFBJHECJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			public DBKFEBENKEL circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public DMEIBNOPPGF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x5A77580", Offset = "0x5A75F80", VA = "0x185A77580")]
			internal EGFMMEGKJNC KKEPKFHLGDG(GDGGKNMDGAI portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		[CompilerGenerated]
		private struct GKOOJEIJMNM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public FDDKFBJHECJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private TaskAwaiter<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x3E30310", Offset = "0x3E2ED10", VA = "0x183E30310", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0xB9ACE0", Offset = "0xB996E0", VA = "0x180B9ACE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		[CompilerGenerated]
		private struct JKGIKFGNGOK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public AsyncTaskMethodBuilder<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public FDDKFBJHECJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public GPIKNAHGEJD? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public KKIALALDEMD? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			private TaskAwaiter<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x4232790", Offset = "0x4231190", VA = "0x184232790", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x4232A40", Offset = "0x4231440", VA = "0x184232A40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008D")]
		[CompilerGenerated]
		private sealed class BIOFEAOEOIP
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200008E")]
			private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C8")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C9")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CA")]
				public BIOFEAOEOIP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CB")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000396")]
				[Cpp2IlInjected.Address(RVA = "0x36AFAA0", Offset = "0x36AE4A0", VA = "0x1836AFAA0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000397")]
				[Cpp2IlInjected.Address(RVA = "0xB9ACE0", Offset = "0xB996E0", VA = "0x180B9ACE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public Func<string, bool> submitValidator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public LILAAGPMKMO nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public FDDKFBJHECJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public ODBHMKEOHCG configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public BIOFEAOEOIP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780")]
			internal string OILGOIIJHCK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x882790", Offset = "0x881190", VA = "0x180882790")]
			internal void GLGFCMOJCCA(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0x5057970", Offset = "0x5056370", VA = "0x185057970")]
			[AsyncStateMachine(typeof(FDDKFBJHECJ<>.BIOFEAOEOIP.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void MFDOLPAJNGP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		[CompilerGenerated]
		private sealed class HNALGGEHDLP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public LILAAGPMKMO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public HNALGGEHDLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x3EF29A0", Offset = "0x3EF13A0", VA = "0x183EF29A0")]
			internal bool KOCJBNPGPOF(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x3EF2990", Offset = "0x3EF1390", VA = "0x183EF2990")]
			internal bool JFHJKCCDKOG(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000090")]
		[CompilerGenerated]
		private struct IKHEKPMJDNC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public AsyncTaskMethodBuilder<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public FDDKFBJHECJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			private TaskAwaiter<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x401CCD0", Offset = "0x401B6D0", VA = "0x18401CCD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x401D060", Offset = "0x401BA60", VA = "0x18401D060", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private readonly DBKFEBENKEL JKIGMMCPDCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly bool KFFNPBBIEGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private LOFGLBPFPME<KGKGLKMKAOL, EGFMMEGKJNC> CMKCICFABMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private LOFGLBPFPME<KGKGLKMKAOL, HOFGADJGIDE> AJJMOJDHJNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private List<Action> FICHMGLOMCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[CompilerGenerated]
		private Action<MLGFJIHMDCD<KGKGLKMKAOL>>? JFDNADJLCBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[CompilerGenerated]
		private Action<MLGFJIHMDCD<KGKGLKMKAOL>, HOFGADJGIDE>? LGLDBOGFMBI;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		protected FKLLFJIANML OFKPECLCGAD
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x3D32310", Offset = "0x3D30D10", VA = "0x183D32310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		protected LILAAGPMKMO LAMKBNFBDEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x3D33660", Offset = "0x3D32060", VA = "0x183D33660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		protected TNode DGCNMJLNBEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x8893E0", Offset = "0x887DE0", VA = "0x1808893E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public DKFKDKPPDAA<CJEPNLHNKAI> CJIODDABMFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0xCA3450", Offset = "0xCA1E50", VA = "0x180CA3450", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(DKFKDKPPDAA<CJEPNLHNKAI>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public MLGFJIHMDCD<BGHCAPELKKH> NDBLNGGGODM
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x3D37680", Offset = "0x3D36080", VA = "0x183D37680", Slot = "6")]
			get
			{
				return default(MLGFJIHMDCD<BGHCAPELKKH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public object CLHDDLICOFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x39F7B00", Offset = "0x39F6500", VA = "0x1839F7B00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public virtual bool DNBIJFANBBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int OAKOGEMAGKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x3D372B0", Offset = "0x3D35CB0", VA = "0x183D372B0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public GICBDAJODOB FOJKPGMHINO
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x3D37250", Offset = "0x3D35C50", VA = "0x183D37250", Slot = "10")]
			get
			{
				return default(GICBDAJODOB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string FCFONJDHLHP
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x3D37840", Offset = "0x3D36240", VA = "0x183D37840", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		protected virtual bool CNAPMEAKAOF
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual NodeVisualizationKey JDBNAJHLPPP
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public MLGFJIHMDCD<BGBLALPJFPI> GNLJPPAKHHH
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0xACBAF0", Offset = "0xACA4F0", VA = "0x180ACBAF0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(MLGFJIHMDCD<BGBLALPJFPI>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0xCAAA20", Offset = "0xCA9420", VA = "0x180CAAA20")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual bool CEDMOJHLHMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual bool GPFICBPFPIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual FJJIJFMABPF JMNBGMJNADP
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x93A520", Offset = "0x938F20", VA = "0x18093A520", Slot = "94")]
			get
			{
				return default(FJJIJFMABPF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool PADFPFLKBLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x3D36F60", Offset = "0x3D35960", VA = "0x183D36F60", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool DODEFDCOHKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x3D36FD0", Offset = "0x3D359D0", VA = "0x183D36FD0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool MBNBDKHCLBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x3D37040", Offset = "0x3D35A40", VA = "0x183D37040", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int GNLGAHLKOJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x3D37620", Offset = "0x3D36020", VA = "0x183D37620", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool AGIGEFABOPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x3D37440", Offset = "0x3D35E40", VA = "0x183D37440", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool NNMPPOAIGKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x3D37170", Offset = "0x3D35B70", VA = "0x183D37170", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool LIKKPIEAMEB
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x3D37100", Offset = "0x3D35B00", VA = "0x183D37100", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool OLJLKBBAKEH
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0xDF5D70", Offset = "0xDF4770", VA = "0x180DF5D70", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0xDF5D80", Offset = "0xDF4780", VA = "0x180DF5D80")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public virtual bool KHFNKJFLDPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual bool OLDNCEOCDOL
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x3D370B0", Offset = "0x3D35AB0", VA = "0x183D370B0", Slot = "96")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool JKDOOLPAKPG
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x3D37370", Offset = "0x3D35D70", VA = "0x183D37370", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public GPIKNAHGEJD MHEDOFLPKMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x3D37560", Offset = "0x3D35F60", VA = "0x183D37560", Slot = "28")]
			get
			{
				return default(GPIKNAHGEJD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public KKIALALDEMD MGLMKDCNIOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x3D375C0", Offset = "0x3D35FC0", VA = "0x183D375C0", Slot = "30")]
			get
			{
				return default(KKIALALDEMD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool BKBOJIHDFFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "108")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual CHNPADHEBJM? MIKKEKPHHHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220", Slot = "109")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual IAOHLNIMNCD? CFMEHEEMPNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220", Slot = "110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual IEnumerable<DKFKDKPPDAA<COGPDFLIJHB>>? NAHDODPLHEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool AHHNDCJMPJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x3D371E0", Offset = "0x3D35BE0", VA = "0x183D371E0", Slot = "114")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public DKFKDKPPDAA<BLDJADOAIME> AHFAGCGOPAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x3D374A0", Offset = "0x3D35EA0", VA = "0x183D374A0", Slot = "62")]
			get
			{
				return default(DKFKDKPPDAA<BLDJADOAIME>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public MLGFJIHMDCD<BLDJADOAIME> AIDNCMLHHNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x3D37310", Offset = "0x3D35D10", VA = "0x183D37310", Slot = "56")]
			get
			{
				return default(MLGFJIHMDCD<BLDJADOAIME>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public virtual bool JJOGJCJDEGB
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "115")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public virtual MLGFJIHMDCD<BLDJADOAIME>? NKJEAKGIHDF
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220", Slot = "116")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public virtual bool BMOCJKPPFMB
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool AFEDFNONPAE
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x3D373D0", Offset = "0x3D35DD0", VA = "0x183D373D0", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public string IAIAEPAKLMP
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x88C870", Offset = "0x88B270", VA = "0x18088C870", Slot = "64")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x88C8A0", Offset = "0x88B2A0", VA = "0x18088C8A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		private string LGCIBANAANB
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x88C860", Offset = "0x88B260", VA = "0x18088C860")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public DKFKDKPPDAA<COGPDFLIJHB> JALHLLEIOKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x3D37500", Offset = "0x3D35F00", VA = "0x183D37500", Slot = "63")]
			get
			{
				return default(DKFKDKPPDAA<COGPDFLIJHB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public DKFKDKPPDAA<COGPDFLIJHB>? INCKOPCPNNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x3D37710", Offset = "0x3D36110", VA = "0x183D37710", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public EKPODPHDKAD<KGKGLKMKAOL, HOFGADJGIDE> JAGJOPPMMBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x3D37800", Offset = "0x3D36200", VA = "0x183D37800", Slot = "65")]
			get
			{
				return default(EKPODPHDKAD<KGKGLKMKAOL, HOFGADJGIDE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public virtual MLGFJIHMDCD<KGKGLKMKAOL>? LMEBCIOGHEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public virtual bool CBAEGDLFPHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public virtual bool EOLNLNOHBJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "123")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action MCIJIDDIHEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x3D33D40", Offset = "0x3D32740", VA = "0x183D33D40", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x3D34750", Offset = "0x3D33150", VA = "0x183D34750", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event KELMMJNBDPG KGPNMBACBBO
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x3D352E0", Offset = "0x3D33CE0", VA = "0x183D352E0", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x3D32950", Offset = "0x3D31350", VA = "0x183D32950", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event NDKIJFKDDGI NEGGACKEJGL
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x3D32750", Offset = "0x3D31150", VA = "0x183D32750", Slot = "41")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x3D346B0", Offset = "0x3D330B0", VA = "0x183D346B0", Slot = "42")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action FPPKCILJDKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x3D33540", Offset = "0x3D31F40", VA = "0x183D33540", Slot = "43")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x3D324D0", Offset = "0x3D30ED0", VA = "0x183D324D0", Slot = "44")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action KKMNLLCLFIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x3D33DE0", Offset = "0x3D327E0", VA = "0x183D33DE0", Slot = "45")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x3D36110", Offset = "0x3D34B10", VA = "0x183D36110", Slot = "46")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<MLGFJIHMDCD<KGKGLKMKAOL>, HOFGADJGIDE> NHPMANOAFPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x3D34AC0", Offset = "0x3D334C0", VA = "0x183D34AC0", Slot = "67")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x3D32130", Offset = "0x3D30B30", VA = "0x183D32130", Slot = "68")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<MLGFJIHMDCD<KGKGLKMKAOL>, HOFGADJGIDE> IICIMNLFLOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x3D34940", Offset = "0x3D33340", VA = "0x183D34940", Slot = "71")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x3D35160", Offset = "0x3D33B60", VA = "0x183D35160", Slot = "72")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<MLGFJIHMDCD<KGKGLKMKAOL>> NJJPPGLJDNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x3D358C0", Offset = "0x3D342C0", VA = "0x183D358C0", Slot = "69")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x3D34B80", Offset = "0x3D33580", VA = "0x183D34B80", Slot = "70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<MLGFJIHMDCD<KGKGLKMKAOL>, MLGFJIHMDCD<KGKGLKMKAOL>> OHPAKOHBDPL
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x3D35430", Offset = "0x3D33E30", VA = "0x183D35430", Slot = "73")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x3D35F50", Offset = "0x3D34950", VA = "0x183D35F50", Slot = "74")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<MLGFJIHMDCD<KGKGLKMKAOL>, HOFGADJGIDE> KBPMBAJOGJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x3D335A0", Offset = "0x3D31FA0", VA = "0x183D335A0", Slot = "75")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x3D34A00", Offset = "0x3D33400", VA = "0x183D34A00", Slot = "76")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<MLGFJIHMDCD<KGKGLKMKAOL>, MLGFJIHMDCD<KGKGLKMKAOL>> HGDPJHJDHPP
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x3D31CC0", Offset = "0x3D306C0", VA = "0x183D31CC0", Slot = "77")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x3D35220", Offset = "0x3D33C20", VA = "0x183D35220", Slot = "78")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x3D36960", Offset = "0x3D35360", VA = "0x183D36960")]
		[OIGNFCKIMEJ("Need to handle `Name` better.")]
		[OIGNFCKIMEJ("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		protected FDDKFBJHECJ(DBKFEBENKEL NLLPJEKPGDO, TNode AJIEBFICGCI, bool FKJMBMGKIEH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x3D361B0", Offset = "0x3D34BB0", VA = "0x183D361B0", Slot = "87")]
		protected virtual void PCEEADECCDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x3D329F0", Offset = "0x3D313F0", VA = "0x183D329F0", Slot = "88")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x3D35380", Offset = "0x3D33D80", VA = "0x183D35380", Slot = "9")]
		[AsyncStateMachine(typeof(FDDKFBJHECJ<>.GKOOJEIJMNM))]
		public void KPGKJAIGCOB(int EILDGCJHHPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x3D32460", Offset = "0x3D30E60", VA = "0x183D32460")]
		public bool CHFKLOJGNKL([In] GPIKNAHGEJD CLMKDBDPNNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x3D33490", Offset = "0x3D31E90", VA = "0x183D33490")]
		public bool ECHOKODAPAD([In] KKIALALDEMD CLMKDBDPNNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x3D35560", Offset = "0x3D33F60", VA = "0x183D35560", Slot = "32")]
		public void LKDGNFAFHBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x3D347F0", Offset = "0x3D331F0", VA = "0x183D347F0", Slot = "33")]
		[AsyncStateMachine(typeof(FDDKFBJHECJ<>.JKGIKFGNGOK))]
		public Task<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> IIGGAIMGLID(GPIKNAHGEJD? IFAKEDNBGGM, KKIALALDEMD? CHAHMPCNOAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "97")]
		public virtual void NMJFOKHPCKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "98")]
		public virtual void NJHCOPDDBJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "99")]
		public virtual void CLBAGHEKBOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x905830", Offset = "0x904230", VA = "0x180905830")]
		protected void IHGDLFKFDMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x936F20", Offset = "0x935920", VA = "0x180936F20")]
		protected void GGBEHKHKGDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x227DD60", Offset = "0x227C760", VA = "0x18227DD60")]
		private void KCFNNJNGDKK([In] KKIALALDEMD FJFNLINEAKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x3D32060", Offset = "0x3D30A60", VA = "0x183D32060", Slot = "100")]
		public virtual Task<MOKFKOEPKDB<MLGFJIHMDCD<KGKGLKMKAOL>, JNDPMGELPNI>> AILJAKPFFNA(string HBOONHFLONJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x3D32680", Offset = "0x3D31080", VA = "0x183D32680", Slot = "101")]
		public virtual Task<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> DDACAIGPFPP(MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "102")]
		public virtual void NNBKFPHHPHF(MLGFJIHMDCD<KGKGLKMKAOL> FEAKPFLKIIH, MLGFJIHMDCD<KGKGLKMKAOL> KANCJDMIAFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x3D36080", Offset = "0x3D34A80", VA = "0x183D36080", Slot = "103")]
		public virtual IEnumerable<NFPABPCJAGA> OMOIJGGCMLD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x3D35EC0", Offset = "0x3D348C0", VA = "0x183D35EC0", Slot = "104")]
		public MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI> NGEHFMKEEID(string CLFPGJNNJGG)
		{
			return default(MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x3D35770", Offset = "0x3D34170", VA = "0x183D35770", Slot = "47")]
		public bool MAGEBJGOLEK([Out] Guid BBHOGONPACC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x3D31D80", Offset = "0x3D30780", VA = "0x183D31D80")]
		public bool AGPIBBGMPNC([In] Guid OJMCAIBKDOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "105")]
		public virtual void CGBFLDMMJFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "106")]
		public virtual void ILCPAABKBMB(bool DGKBEOALEIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220", Slot = "107")]
		public virtual JNEKIKANCPD EPGODODDACM([In] MDDNJMDGKKM DNLDMECBOLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x3D33750", Offset = "0x3D32150", VA = "0x183D33750")]
		protected void FKMHAKMCGDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x3D33950", Offset = "0x3D32350", VA = "0x183D33950", Slot = "112")]
		protected virtual bool FMBKMHCOENA(MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "113")]
		protected virtual bool MBDPPCPKMFL(MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "120")]
		protected virtual void DLJDAFBNPBC(ODBHMKEOHCG PGBPKNEACBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x3D35AB0", Offset = "0x3D344B0", VA = "0x183D35AB0")]
		protected void MNOJCFFFKBH(ODBHMKEOHCG PCACEJCPOFN, Func<string> KMNMKMMENBC, Action<string> DFDMFCGKOHE, string FKOHEHJGFPM, string NNKNOGNNDDI, string BKCCKGAHMNJ, EBNGFLOGHBI ADILCEEJDHM, PKCBGGHDFEA PLHPBKADFOG, Func<string, bool> NFNCFEHKBCC, string ELPMGOCPLKM, Func<string, bool> JIMAJFNMHHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x3D33E80", Offset = "0x3D32880", VA = "0x183D33E80")]
		protected void HCPEDPMLIGH(ODBHMKEOHCG PCACEJCPOFN, Func<string> KMNMKMMENBC, Action<string> DFDMFCGKOHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x3D332D0", Offset = "0x3D31CD0", VA = "0x183D332D0", Slot = "121")]
		protected virtual void EBHBBPAOKGO(ODBHMKEOHCG PCACEJCPOFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x3D32530", Offset = "0x3D30F30", VA = "0x183D32530", Slot = "80")]
		public void CNIAFBPFMAC(ODBHMKEOHCG PCACEJCPOFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x3D32580", Offset = "0x3D30F80", VA = "0x183D32580", Slot = "81")]
		public JGEFDJEOPKG COEBNDCHCKK()
		{
			return default(JGEFDJEOPKG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "124")]
		public virtual bool KBCCFEFPEMK(MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x15D8BE0", Offset = "0x15D75E0", VA = "0x1815D8BE0")]
		private void LEINFKNHCLG([In] GPIKNAHGEJD BJDHDJCINFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x3D327F0", Offset = "0x3D311F0", VA = "0x183D327F0")]
		private void DLMNGKGLJHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x3D34110", Offset = "0x3D32B10", VA = "0x183D34110")]
		private void HKOLOJPKLIA(MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII, GDGGKNMDGAI EJELGELAOJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0xA369C0", Offset = "0xA353C0", VA = "0x180A369C0")]
		private void PAODNMEFFCB(MLGFJIHMDCD<KGKGLKMKAOL> KFBALBFDDFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x3D35980", Offset = "0x3D34380", VA = "0x183D35980")]
		private void MJCILHABCHP(MLGFJIHMDCD<KGKGLKMKAOL> KFBALBFDDFF, GDGGKNMDGAI KNOOHONGJDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x3D33990", Offset = "0x3D32390", VA = "0x183D33990")]
		private void GFJGMEBGOEI(MLGFJIHMDCD<KGKGLKMKAOL> FEAKPFLKIIH, MLGFJIHMDCD<KGKGLKMKAOL> KANCJDMIAFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xA35830", Offset = "0xA34230", VA = "0x180A35830")]
		private void GINCINOCNOL(MLGFJIHMDCD<KGKGLKMKAOL> FEAKPFLKIIH, MLGFJIHMDCD<KGKGLKMKAOL> KANCJDMIAFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x3D32040", Offset = "0x3D30A40", VA = "0x183D32040")]
		private void AHMEPHFLNMF(MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x3D34CF0", Offset = "0x3D336F0", VA = "0x183D34CF0")]
		private void JPHJJOMGIHO(MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII, GDGGKNMDGAI EJELGELAOJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x3D354F0", Offset = "0x3D33EF0", VA = "0x183D354F0")]
		private void LJMOEIDMOMH(MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII, GDGGKNMDGAI KNOOHONGJDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x3D321F0", Offset = "0x3D30BF0", VA = "0x183D321F0", Slot = "125")]
		[AsyncStateMachine(typeof(FDDKFBJHECJ<>.IKHEKPMJDNC))]
		public Task<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> BBIONAMOPGO(string CLFPGJNNJGG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x3D36010", Offset = "0x3D34A10", VA = "0x183D36010", Slot = "54")]
		private void OHPJDIEKGND(object OFLAIIIOJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x3D34C80", Offset = "0x3D33680", VA = "0x183D34C80", Slot = "55")]
		private void JMEHFNDBNIF(object OFLAIIIOJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x3D36920", Offset = "0x3D35320", VA = "0x183D36920", Slot = "29")]
		private bool PFBCCNKIBJA([In] GPIKNAHGEJD CLMKDBDPNNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x3D34C40", Offset = "0x3D33640", VA = "0x183D34C40", Slot = "31")]
		private bool JHNLNEFLHEO([In] KKIALALDEMD CLMKDBDPNNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x3D32370", Offset = "0x3D30D70", VA = "0x183D32370", Slot = "48")]
		private bool BMEOGOKILFA([In] Guid OJMCAIBKDOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x3D33500", Offset = "0x3D31F00", VA = "0x183D33500")]
		[CompilerGenerated]
		private string EMFBFLPNNEI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x3D323B0", Offset = "0x3D30DB0", VA = "0x183D323B0")]
		[CompilerGenerated]
		private void CENIJPANPCI(string HBOONHFLONJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public sealed class EBGAFPIKACP : LLGMLCGGDGI<FMPFOBFIDJC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public override NodeVisualizationKey JDBNAJHLPPP
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x12B1990", Offset = "0x12B0390", VA = "0x1812B1990", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x207FEF0", Offset = "0x207E8F0", VA = "0x18207FEF0")]
		public EBGAFPIKACP(DBKFEBENKEL NLLPJEKPGDO, FMPFOBFIDJC AJIEBFICGCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class CGHFDJEDCKJ : OOGPDBKGEKD<NDDJPLNOIMB>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public override NodeVisualizationKey JDBNAJHLPPP
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x900EE0", Offset = "0x8FF8E0", VA = "0x180900EE0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x207D430", Offset = "0x207BE30", VA = "0x18207D430")]
		public CGHFDJEDCKJ(DBKFEBENKEL NLLPJEKPGDO, NDDJPLNOIMB AJIEBFICGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "120")]
		protected override void DLJDAFBNPBC(ODBHMKEOHCG PCACEJCPOFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public abstract class NKFGKEJNIDG<T> : FDDKFBJHECJ<T> where T : notnull, AMOCBJCKDKA
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class POBFGBJABPH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public IReadOnlyList<KeyValuePair<string, GOLDOKHMCBL>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public NKFGKEJNIDG<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public LILAAGPMKMO nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public HNCHBMBKAHI clipType;

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public POBFGBJABPH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780")]
			internal IReadOnlyList<KeyValuePair<string, GOLDOKHMCBL>> EKIMLELLLBK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x493C0F0", Offset = "0x493AAF0", VA = "0x18493C0F0")]
			internal int JHMMMGBFJBC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x493BE10", Offset = "0x493A810", VA = "0x18493BE10")]
			internal void FJEBMGILCGL(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x493BD60", Offset = "0x493A760", VA = "0x18493BD60")]
			internal void EHDKHGOAOBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x493BB50", Offset = "0x493A550", VA = "0x18493BB50")]
			internal void CCCGDHCBFGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x493C310", Offset = "0x493AD10", VA = "0x18493C310")]
			internal bool LIAGIHGIJMN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x493C3A0", Offset = "0x493ADA0", VA = "0x18493C3A0")]
			internal void LJOEOKPGLFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x493C310", Offset = "0x493AD10", VA = "0x18493C310")]
			internal bool OIKJCJPLEDI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x493C2B0", Offset = "0x493ACB0", VA = "0x18493C2B0")]
			internal float KMILKLCMLPG()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x493C3F0", Offset = "0x493ADF0", VA = "0x18493C3F0")]
			internal void OCOOHNBGGDJ(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x493BDB0", Offset = "0x493A7B0", VA = "0x18493BDB0")]
			internal float FEIPPEEBHLO()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x493BCA0", Offset = "0x493A6A0", VA = "0x18493BCA0")]
			internal void DMPNMGNBLNK(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x493C250", Offset = "0x493AC50", VA = "0x18493C250")]
			internal float KAAEAKBOJKK()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x493C030", Offset = "0x493AA30", VA = "0x18493C030")]
			internal void FOKPEBDKFMC(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override NodeVisualizationKey JDBNAJHLPPP
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0xA49930", Offset = "0xA48330", VA = "0x180A49930", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public abstract HNCHBMBKAHI FJMKJEMBLNL
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(Slot = "126")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x460C790", Offset = "0x460B190", VA = "0x18460C790")]
		public NKFGKEJNIDG(DBKFEBENKEL NLLPJEKPGDO, T AJIEBFICGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x46BF640", Offset = "0x46BE040", VA = "0x1846BF640", Slot = "120")]
		protected sealed override void DLJDAFBNPBC(ODBHMKEOHCG PCACEJCPOFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private sealed class EFFDFNICEBC : FDDKFBJHECJ<CCBMMAINNGE>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public override NodeVisualizationKey JDBNAJHLPPP
		{
			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0xA4DC00", Offset = "0xA4C600", VA = "0x180A4DC00", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x207FF50", Offset = "0x207E950", VA = "0x18207FF50")]
		public EFFDFNICEBC(DBKFEBENKEL NLLPJEKPGDO, CCBMMAINNGE AJIEBFICGCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class DCCJMPEJMGJ : FDDKFBJHECJ<AHLIGHHDLJJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class OHKPOHPEBCL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public DCCJMPEJMGJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public LILAAGPMKMO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public OHKPOHPEBCL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x2095B10", Offset = "0x2094510", VA = "0x182095B10")]
			internal int JHMMMGBFJBC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x2095A80", Offset = "0x2094480", VA = "0x182095A80")]
			internal void FJEBMGILCGL(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private static Dictionary<string, GOLDOKHMCBL>? FFMMPDKJMCG;

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x207DCE0", Offset = "0x207C6E0", VA = "0x18207DCE0")]
		public DCCJMPEJMGJ(DBKFEBENKEL NLLPJEKPGDO, AHLIGHHDLJJ AJIEBFICGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x207D970", Offset = "0x207C370", VA = "0x18207D970", Slot = "120")]
		protected override void DLJDAFBNPBC(ODBHMKEOHCG PCACEJCPOFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class APHCFMDGPOP : NKFGKEJNIDG<IGHEJCKPFJC>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public override HNCHBMBKAHI FJMKJEMBLNL
		{
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220", Slot = "126")]
			get
			{
				return default(HNCHBMBKAHI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x207D240", Offset = "0x207BC40", VA = "0x18207D240")]
		public APHCFMDGPOP(DBKFEBENKEL NLLPJEKPGDO, IGHEJCKPFJC BMCAAIIMEIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class MBIJLGPPLHH : OOGPDBKGEKD<KLKDEMCIONM>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public override NodeVisualizationKey JDBNAJHLPPP
		{
			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x900EE0", Offset = "0x8FF8E0", VA = "0x180900EE0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x208E910", Offset = "0x208D310", VA = "0x18208E910")]
		public MBIJLGPPLHH(DBKFEBENKEL NLLPJEKPGDO, KLKDEMCIONM AJIEBFICGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "120")]
		protected override void DLJDAFBNPBC(ODBHMKEOHCG PCACEJCPOFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	private sealed class FAMGHHGBBPA : OOGPDBKGEKD<NDEDMJJCFGA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public override NodeVisualizationKey JDBNAJHLPPP
		{
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x900EE0", Offset = "0x8FF8E0", VA = "0x180900EE0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x2087AF0", Offset = "0x20864F0", VA = "0x182087AF0")]
		public FAMGHHGBBPA(DBKFEBENKEL NLLPJEKPGDO, NDEDMJJCFGA AJIEBFICGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "120")]
		protected override void DLJDAFBNPBC(ODBHMKEOHCG PCACEJCPOFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class EONLFJLDHJF : JBEJAGBKFDJ<HEKHGEOHMEN>
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class HIKMCLNDBLK
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200009E")]
			private struct <<AddHomeValueSetting>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001DF")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40001E0")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40001E1")]
				public HIKMCLNDBLK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40001E2")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40001E3")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40001E4")]
				private TaskAwaiter<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60003CB")]
				[Cpp2IlInjected.Address(RVA = "0x20971E0", Offset = "0x2095BE0", VA = "0x1820971E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CC")]
				[Cpp2IlInjected.Address(RVA = "0xB9ACE0", Offset = "0xB996E0", VA = "0x180B9ACE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public LILAAGPMKMO nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public EONLFJLDHJF <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public HIKMCLNDBLK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x2089120", Offset = "0x2087B20", VA = "0x182089120")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void CBHJBEKPBFD(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x2087010", Offset = "0x2085A10", VA = "0x182087010")]
		public EONLFJLDHJF(DBKFEBENKEL NLLPJEKPGDO, HEKHGEOHMEN BMCAAIIMEIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x2086D30", Offset = "0x2085730", VA = "0x182086D30", Slot = "126")]
		protected override void IAGPOKKMKBD(ODBHMKEOHCG PCACEJCPOFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class GNELDMKIILG : NKFGKEJNIDG<OBCKHNPBMEC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override HNCHBMBKAHI FJMKJEMBLNL
		{
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0xA581F0", Offset = "0xA56BF0", VA = "0x180A581F0", Slot = "126")]
			get
			{
				return default(HNCHBMBKAHI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x2088770", Offset = "0x2087170", VA = "0x182088770")]
		public GNELDMKIILG(DBKFEBENKEL NLLPJEKPGDO, OBCKHNPBMEC BMCAAIIMEIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private sealed class IEJIAMNGJFL : FDDKFBJHECJ<IFGJNAHLELN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public override NodeVisualizationKey JDBNAJHLPPP
		{
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0xAC5800", Offset = "0xAC4200", VA = "0x180AC5800", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x208B110", Offset = "0x2089B10", VA = "0x18208B110")]
		public IEJIAMNGJFL(DBKFEBENKEL NLLPJEKPGDO, IFGJNAHLELN AJIEBFICGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "120")]
		protected override void DLJDAFBNPBC(ODBHMKEOHCG PCACEJCPOFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public sealed class FNKHIJCKGKM : FDDKFBJHECJ<EFNDMIIJOHH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public sealed override NodeVisualizationKey JDBNAJHLPPP
		{
			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public sealed override bool CEDMOJHLHMA
		{
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected sealed override bool CNAPMEAKAOF
		{
			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x2088380", Offset = "0x2086D80", VA = "0x182088380")]
		public FNKHIJCKGKM(DBKFEBENKEL NLLPJEKPGDO, EFNDMIIJOHH AJIEBFICGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x2087FF0", Offset = "0x20869F0", VA = "0x182087FF0", Slot = "120")]
		protected override void DLJDAFBNPBC(ODBHMKEOHCG PCACEJCPOFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x2087FB0", Offset = "0x20869B0", VA = "0x182087FB0")]
		private int CIOELGCDCNM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x2088320", Offset = "0x2086D20", VA = "0x182088320")]
		private void ELGJFNLEKAM(int NPGBIOOADNL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public class IPEJBCPKOFP : JECBEABJJGB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x208B8D0", Offset = "0x208A2D0", VA = "0x18208B8D0")]
		public IPEJBCPKOFP(DBKFEBENKEL NLLPJEKPGDO, GNMLBPFILMD AJIEBFICGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "120")]
		protected override void DLJDAFBNPBC(ODBHMKEOHCG PCACEJCPOFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class DFNPCLJOEKK : JBEJAGBKFDJ<BDNKONLFGAL>
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x207DD50", Offset = "0x207C750", VA = "0x18207DD50")]
		public DFNPCLJOEKK(DBKFEBENKEL NLLPJEKPGDO, BDNKONLFGAL AJIEBFICGCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public abstract class JBEJAGBKFDJ<TVariableNode> : FDDKFBJHECJ<TVariableNode> where TVariableNode : notnull, BDNKONLFGAL
	{
		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		[CompilerGenerated]
		private sealed class KILNPHGBJFD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public JBEJAGBKFDJ<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public LILAAGPMKMO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public KILNPHGBJFD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x4380EB0", Offset = "0x437F8B0", VA = "0x184380EB0")]
			internal bool EKIMLELLLBK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x4380F70", Offset = "0x437F970", VA = "0x184380F70")]
			internal void JHMMMGBFJBC(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x4380F10", Offset = "0x437F910", VA = "0x184380F10")]
			internal bool FJEBMGILCGL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x4380DF0", Offset = "0x437F7F0", VA = "0x184380DF0")]
			internal void EHDKHGOAOBN(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x4380CC0", Offset = "0x437F6C0", VA = "0x184380CC0")]
			internal bool CCCGDHCBFGD()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		[CompilerGenerated]
		private sealed class LOHAAMPKCPH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public LILAAGPMKMO nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public JBEJAGBKFDJ<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public LOHAAMPKCPH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x4440D70", Offset = "0x443F770", VA = "0x184440D70")]
			internal void CBHJBEKPBFD(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public override NodeVisualizationKey JDBNAJHLPPP
		{
			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0xC2B770", Offset = "0xC2A170", VA = "0x180C2B770", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public override FJJIJFMABPF JMNBGMJNADP
		{
			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x41FD4F0", Offset = "0x41FBEF0", VA = "0x1841FD4F0", Slot = "94")]
			get
			{
				return default(FJJIJFMABPF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x41FD340", Offset = "0x41FBD40", VA = "0x1841FD340")]
		protected JBEJAGBKFDJ(DBKFEBENKEL NLLPJEKPGDO, TVariableNode AJIEBFICGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x41FCE00", Offset = "0x41FB800", VA = "0x1841FCE00", Slot = "88")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x41FC950", Offset = "0x41FB350", VA = "0x1841FC950", Slot = "120")]
		protected override void DLJDAFBNPBC(ODBHMKEOHCG PCACEJCPOFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x41FCFA0", Offset = "0x41FB9A0", VA = "0x1841FCFA0", Slot = "126")]
		protected virtual void IAGPOKKMKBD(ODBHMKEOHCG PCACEJCPOFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x41FC850", Offset = "0x41FB250", VA = "0x1841FC850", Slot = "105")]
		public override void CGBFLDMMJFM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2066340", Offset = "0x2064D40", VA = "0x182066340")]
	public static JINHCMKFECA MMKGNMBHOIH(DBKFEBENKEL NLLPJEKPGDO, GNMLBPFILMD AJIEBFICGCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public sealed class NKLOFNOLDBM : IAFCDCHFGLG, KOJPNJKNJFD, ACJGAIHJELB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public MLGFJIHMDCD<EGLCODOFCAG> NGEAFFHCABL
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xBE7230", Offset = "0xBE5C30", VA = "0x180BE7230", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(MLGFJIHMDCD<EGLCODOFCAG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public MLGFJIHMDCD<DAEKILKJHLB> JLJJCHLIKIG
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x13AC700", Offset = "0x13AB100", VA = "0x1813AC700", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(MLGFJIHMDCD<DAEKILKJHLB>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x2094D40", Offset = "0x2093740", VA = "0x182094D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private MLGFJIHMDCD<LKMKIJDBGPC> NKLDCHOKGDD
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x908A70", Offset = "0x907470", VA = "0x180908A70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public override MLGFJIHMDCD<IMMAAIMBPJM> INHFEMFLFBI
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x20950A0", Offset = "0x2093AA0", VA = "0x1820950A0", Slot = "20")]
		get
		{
			return default(MLGFJIHMDCD<IMMAAIMBPJM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x20950F0", Offset = "0x2093AF0", VA = "0x1820950F0")]
	private NKLOFNOLDBM(DBKFEBENKEL NLLPJEKPGDO, GNMLBPFILMD AJIEBFICGCI, JDIEKMJLKHH FHAFNBLCNID, MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII, MLGFJIHMDCD<DAEKILKJHLB> NCKPDHPKIAJ, MLGFJIHMDCD<LKMKIJDBGPC> GJDKPLIDILM, bool NEGCLIMIHGF, string HBOONHFLONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x2094D50", Offset = "0x2093750", VA = "0x182094D50")]
	public static NKLOFNOLDBM MMKGNMBHOIH(DBKFEBENKEL NLLPJEKPGDO, GNMLBPFILMD AJIEBFICGCI, JDIEKMJLKHH BFKJNHOPNNA, MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII, MLGFJIHMDCD<LKMKIJDBGPC> GJDKPLIDILM, MLGFJIHMDCD<DAEKILKJHLB> NCKPDHPKIAJ, bool NEGCLIMIHGF, bool FKJMBMGKIEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x2094D40", Offset = "0x2093740", VA = "0x182094D40")]
	internal void FCIJMGABNBF(MLGFJIHMDCD<DAEKILKJHLB> CLMKDBDPNNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public abstract class IAFCDCHFGLG : ACJGAIHJELB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct LPJBBEMBALJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private MANCHNMLDAP? EIMFJLNPHKA;

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x208E860", Offset = "0x208D260", VA = "0x18208E860")]
		public void IMAFILHGCCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x208E7C0", Offset = "0x208D1C0", VA = "0x18208E7C0")]
		public MANCHNMLDAP BKNMOMBGICI(IAFCDCHFGLG BPGPMAFBJJG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	protected readonly DBKFEBENKEL JKIGMMCPDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	protected readonly GNMLBPFILMD NEDOLKOGJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private LPJBBEMBALJ HCANNGOOKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly AAHJDEKMEHM CHHNBMEOLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private readonly List<EEFPMGPGFCG> EMFAKCALLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private readonly List<LNCDCOEEAIA> OBEKHGMGJBA;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	[OIGNFCKIMEJ("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> KBFOEMCIJGM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x208AB10", Offset = "0x2089510", VA = "0x18208AB10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public DisplayKind NMNGEJNNOAO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x893630", Offset = "0x892030", VA = "0x180893630", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public MLGFJIHMDCD<BLDJADOAIME> AIDNCMLHHNN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x2089C70", Offset = "0x2088670", VA = "0x182089C70", Slot = "6")]
		get
		{
			return default(MLGFJIHMDCD<BLDJADOAIME>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public DKFKDKPPDAA<BLDJADOAIME> AHFAGCGOPAC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x208A660", Offset = "0x2089060", VA = "0x18208A660", Slot = "7")]
		get
		{
			return default(DKFKDKPPDAA<BLDJADOAIME>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public MBJMJANGHJB GIJJIENDIAB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x1E05F60", Offset = "0x1E04960", VA = "0x181E05F60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public GEAPEOKANDN CPCGCBLCIEA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x208A8C0", Offset = "0x20892C0", VA = "0x18208A8C0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	protected MANCHNMLDAP ANCLJEENALJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x208A8C0", Offset = "0x20892C0", VA = "0x18208A8C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public PortImage NOKLICCLIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x2089DF0", Offset = "0x20887F0", VA = "0x182089DF0", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public string IAIAEPAKLMP
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x88C8B0", Offset = "0x88B2B0", VA = "0x18088C8B0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x88C840", Offset = "0x88B240", VA = "0x18088C840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public DKFKDKPPDAA<COGPDFLIJHB> JALHLLEIOKL
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x208A690", Offset = "0x2089090", VA = "0x18208A690", Slot = "9")]
		get
		{
			return default(DKFKDKPPDAA<COGPDFLIJHB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public MLGFJIHMDCD<KGKGLKMKAOL> JKNOBIDBNMA
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xB48400", Offset = "0xB46E00", VA = "0x180B48400", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(MLGFJIHMDCD<KGKGLKMKAOL>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x10259D0", Offset = "0x10243D0", VA = "0x1810259D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public abstract MLGFJIHMDCD<IMMAAIMBPJM> INHFEMFLFBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x208AFB0", Offset = "0x20899B0", VA = "0x18208AFB0")]
	protected IAFCDCHFGLG(DBKFEBENKEL NLLPJEKPGDO, GNMLBPFILMD AJIEBFICGCI, AAHJDEKMEHM BPMKLCLFPCJ, MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII, bool NEGCLIMIHGF, string HBOONHFLONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x208ACB0", Offset = "0x20896B0", VA = "0x18208ACB0", Slot = "21")]
	protected virtual void PCEEADECCDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x2089CA0", Offset = "0x20886A0", VA = "0x182089CA0", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x2089C10", Offset = "0x2088610", VA = "0x182089C10", Slot = "14")]
	public void AHPOGGCJBFA(EEFPMGPGFCG MFNDIOIIFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x208AC50", Offset = "0x2089650", VA = "0x18208AC50", Slot = "15")]
	public void OHDMABKHIDG(LNCDCOEEAIA MFNDIOIIFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x2089F20", Offset = "0x2088920", VA = "0x182089F20", Slot = "16")]
	public void FLBJHCHMLNJ(HLEGIHKJLKF FKCOIAIFJKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x208A600", Offset = "0x2089000", VA = "0x18208A600", Slot = "23")]
	protected virtual void HADEFFLENHI(HLEGIHKJLKF FKCOIAIFJKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x208A960", Offset = "0x2089360", VA = "0x18208A960")]
	private void MILKEACEIKA(bool AHPMMDKKKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x208A710", Offset = "0x2089110", VA = "0x18208A710")]
	private void MFMHKCJPMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x208AE00", Offset = "0x2089800", VA = "0x18208AE00")]
	private void PEBHLAFKNKF([In] GOICLIEGCKE LOBGIDOPHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x208A5A0", Offset = "0x2088FA0", VA = "0x18208A5A0", Slot = "17")]
	public void GEJIAOCKFGB(EEFPMGPGFCG MFNDIOIIFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x208A6B0", Offset = "0x20890B0", VA = "0x18208A6B0", Slot = "18")]
	public void KJBKNIIDNIG(LNCDCOEEAIA MFNDIOIIFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x88C840", Offset = "0x88B240", VA = "0x18088C840")]
	internal void NDPONBFNKGN(string HBOONHFLONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x208AAF0", Offset = "0x20894F0", VA = "0x18208AAF0")]
	internal void NPDJAEEDICK(LJIGEMAELHP JPDKLLDNBGD, MBJMJANGHJB NNCMOPPBEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x10259D0", Offset = "0x10243D0", VA = "0x1810259D0")]
	internal void IKDDEFKDECI(MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public sealed class EGFMMEGKJNC : HOFGADJGIDE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class CBPAFBLLMHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public DBKFEBENKEL circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public GNMLBPFILMD node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public MLGFJIHMDCD<KGKGLKMKAOL> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public CBPAFBLLMHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x207D3A0", Offset = "0x207BDA0", VA = "0x18207D3A0")]
		internal NPCBDKKKHLM GNABLHDBGIL((int PortDescIndex, int PortIndex, AKABJABIDDF InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x207D310", Offset = "0x207BD10", VA = "0x18207D310")]
		internal NKLOFNOLDBM BEMLIOHANJE(JDIEKMJLKHH i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct MJBOJNFKLNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public EGFMMEGKJNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private GGPBOBCBBBL <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private TaskAwaiter<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x208F060", Offset = "0x208DA60", VA = "0x18208F060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x208F4C0", Offset = "0x208DEC0", VA = "0x18208F4C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct PKCFEGMJAMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public EGFMMEGKJNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public MLGFJIHMDCD<JCNBPBDCDNO> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private GGPBOBCBBBL <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private TaskAwaiter<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x2096D10", Offset = "0x2095710", VA = "0x182096D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x2097060", Offset = "0x2095A60", VA = "0x182097060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct OBJEEEKJCJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public EGFMMEGKJNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public MLGFJIHMDCD<LKMKIJDBGPC> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private GGPBOBCBBBL <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private TaskAwaiter<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x20953E0", Offset = "0x2093DE0", VA = "0x1820953E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x2095730", Offset = "0x2094130", VA = "0x182095730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct LBAGCLHIEIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public EGFMMEGKJNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public MLGFJIHMDCD<JCNBPBDCDNO> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public MLGFJIHMDCD<JCNBPBDCDNO> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private GGPBOBCBBBL <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private TaskAwaiter<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x208E130", Offset = "0x208CB30", VA = "0x18208E130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x208E480", Offset = "0x208CE80", VA = "0x18208E480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct DIGGBEMEKJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public EGFMMEGKJNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public MLGFJIHMDCD<LKMKIJDBGPC> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public MLGFJIHMDCD<LKMKIJDBGPC> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private GGPBOBCBBBL <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private TaskAwaiter<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x207DDB0", Offset = "0x207C7B0", VA = "0x18207DDB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x207E100", Offset = "0x207CB00", VA = "0x18207E100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct KFIKGHGBBJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public EGFMMEGKJNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private GGPBOBCBBBL <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private TaskAwaiter<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x208D710", Offset = "0x208C110", VA = "0x18208D710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x208DB80", Offset = "0x208C580", VA = "0x18208DB80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct PACBHEDHJME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public EGFMMEGKJNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private GGPBOBCBBBL <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private TaskAwaiter<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x2095FC0", Offset = "0x20949C0", VA = "0x182095FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x2096310", Offset = "0x2094D10", VA = "0x182096310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct IOJCHPBIBLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public EGFMMEGKJNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public MLGFJIHMDCD<JCNBPBDCDNO> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private GGPBOBCBBBL <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private TaskAwaiter<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x208B510", Offset = "0x2089F10", VA = "0x18208B510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x208B860", Offset = "0x208A260", VA = "0x18208B860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct KFPIMBGEIJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public EGFMMEGKJNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public MLGFJIHMDCD<LKMKIJDBGPC> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private GGPBOBCBBBL <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private TaskAwaiter<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x208DBF0", Offset = "0x208C5F0", VA = "0x18208DBF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x208DF40", Offset = "0x208C940", VA = "0x18208DF40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct JAONHOFPFFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public EGFMMEGKJNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public LLBJEPOEBFC type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public MLGFJIHMDCD<JCNBPBDCDNO> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private GGPBOBCBBBL <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private TaskAwaiter<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x208C1C0", Offset = "0x208ABC0", VA = "0x18208C1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x208C550", Offset = "0x208AF50", VA = "0x18208C550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct OIEBDLFHIED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public EGFMMEGKJNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public LLBJEPOEBFC type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public MLGFJIHMDCD<LKMKIJDBGPC> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private GGPBOBCBBBL <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private TaskAwaiter<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x2095B60", Offset = "0x2094560", VA = "0x182095B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x2095EF0", Offset = "0x20948F0", VA = "0x182095EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private readonly bool AIKLEBEODFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly DBKFEBENKEL JKIGMMCPDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private readonly bool LIMMLLOAAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private EKPODPHDKAD<HINBMEFALMJ, NPCBDKKKHLM> LIFOFEMHNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private EKPODPHDKAD<HINBMEFALMJ, MKHMFONGLFO> JMADIJKCAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private readonly GNMLBPFILMD NEDOLKOGJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private EKPODPHDKAD<DAEKILKJHLB, NKLOFNOLDBM> OALNHFIAIND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private EKPODPHDKAD<DAEKILKJHLB, KOJPNJKNJFD> GBCHJJIOLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private string? LCPCAPPCFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private readonly GDGGKNMDGAI HLNKMBLIDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private MLGFJIHMDCD<KGKGLKMKAOL> CJENHPLLFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private readonly bool KFFNPBBIEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	[CompilerGenerated]
	private Action? BJKKNKJFFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	[CompilerGenerated]
	private Action? JDDHMMNNNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	[CompilerGenerated]
	private Action<MLGFJIHMDCD<HINBMEFALMJ>>? JIFEBJBKDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	[CompilerGenerated]
	private Action<MLGFJIHMDCD<DAEKILKJHLB>>? MKMGIPFKJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	[CompilerGenerated]
	private HOFGADJGIDE.MJFPBGHLKDH? POMOMFANADD;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool ILBDIFDCEPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x2080F00", Offset = "0x207F900", VA = "0x182080F00", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool IOKNGDCPDFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x2083A60", Offset = "0x2082460", VA = "0x182083A60", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool LCAKIENEMMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x2082010", Offset = "0x2080A10", VA = "0x182082010", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public DKFKDKPPDAA<BLDJADOAIME> AHFAGCGOPAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x2082F40", Offset = "0x2081940", VA = "0x182082F40", Slot = "7")]
		get
		{
			return default(DKFKDKPPDAA<BLDJADOAIME>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool JJHANFJJNBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x2084210", Offset = "0x2082C10", VA = "0x182084210", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public EKPODPHDKAD<HINBMEFALMJ, MKHMFONGLFO> AAPJDOCLDLP
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x8893E0", Offset = "0x887DE0", VA = "0x1808893E0", Slot = "9")]
		get
		{
			return default(EKPODPHDKAD<HINBMEFALMJ, MKHMFONGLFO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public string IAIAEPAKLMP
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x2083C10", Offset = "0x2082610", VA = "0x182083C10", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public DKFKDKPPDAA<COGPDFLIJHB> JALHLLEIOKL
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x2083AA0", Offset = "0x20824A0", VA = "0x182083AA0", Slot = "11")]
		get
		{
			return default(DKFKDKPPDAA<COGPDFLIJHB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public EKPODPHDKAD<DAEKILKJHLB, KOJPNJKNJFD> ELEBNCKFKPD
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x88C8B0", Offset = "0x88B2B0", VA = "0x18088C8B0", Slot = "12")]
		get
		{
			return default(EKPODPHDKAD<DAEKILKJHLB, KOJPNJKNJFD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public MLGFJIHMDCD<KGKGLKMKAOL> JKNOBIDBNMA
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x9098C0", Offset = "0x9082C0", VA = "0x1809098C0", Slot = "13")]
		get
		{
			return default(MLGFJIHMDCD<KGKGLKMKAOL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action DOMFCIJCGBK
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x2080680", Offset = "0x207F080", VA = "0x182080680", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x2083420", Offset = "0x2081E20", VA = "0x182083420", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action ECABKJMJBGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x2082D10", Offset = "0x2081710", VA = "0x182082D10", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x2083700", Offset = "0x2082100", VA = "0x182083700", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<MLGFJIHMDCD<HINBMEFALMJ>, MLGFJIHMDCD<HINBMEFALMJ>> MPNJEPFNDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x20805C0", Offset = "0x207EFC0", VA = "0x1820805C0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x2084D10", Offset = "0x2083710", VA = "0x182084D10", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<MLGFJIHMDCD<HINBMEFALMJ>, MLGFJIHMDCD<HINBMEFALMJ>> MGKCGEDLBEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x2082DC0", Offset = "0x20817C0", VA = "0x182082DC0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x207FFC0", Offset = "0x207E9C0", VA = "0x18207FFC0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<MLGFJIHMDCD<DAEKILKJHLB>, MLGFJIHMDCD<DAEKILKJHLB>> NHGHGHOLBLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x2081AE0", Offset = "0x20804E0", VA = "0x182081AE0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x2080500", Offset = "0x207EF00", VA = "0x182080500", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<MLGFJIHMDCD<DAEKILKJHLB>, MLGFJIHMDCD<DAEKILKJHLB>> MALNAELHBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x2084EF0", Offset = "0x20838F0", VA = "0x182084EF0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x2080980", Offset = "0x207F380", VA = "0x182080980", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<MLGFJIHMDCD<HINBMEFALMJ>, MKHMFONGLFO> OOFHLNLIBLL
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x2085890", Offset = "0x2084290", VA = "0x182085890", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x2080080", Offset = "0x207EA80", VA = "0x182080080", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<MLGFJIHMDCD<HINBMEFALMJ>> DDKGPCCOIFH
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x2082E80", Offset = "0x2081880", VA = "0x182082E80", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x2083C40", Offset = "0x2082640", VA = "0x182083C40", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<MLGFJIHMDCD<HINBMEFALMJ>, MKHMFONGLFO> FKGLDGJODEC
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x2083870", Offset = "0x2082270", VA = "0x182083870", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x2080860", Offset = "0x207F260", VA = "0x182080860", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<MLGFJIHMDCD<DAEKILKJHLB>, KOJPNJKNJFD> HMNNIJDFHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x20821E0", Offset = "0x2080BE0", VA = "0x1820821E0", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x20822A0", Offset = "0x2080CA0", VA = "0x1820822A0", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<MLGFJIHMDCD<DAEKILKJHLB>> PFDFNCKEPIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x2084020", Offset = "0x2082A20", VA = "0x182084020", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x2082B20", Offset = "0x2081520", VA = "0x182082B20", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<MLGFJIHMDCD<DAEKILKJHLB>, KOJPNJKNJFD> NLKHHBOGOMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x20837B0", Offset = "0x20821B0", VA = "0x1820837B0", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x2084C50", Offset = "0x2083650", VA = "0x182084C50", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x2085E90", Offset = "0x2084890", VA = "0x182085E90")]
	private EGFMMEGKJNC(bool NEGCLIMIHGF, DBKFEBENKEL NLLPJEKPGDO, bool NDNHHLNAIFP, EKPODPHDKAD<HINBMEFALMJ, NPCBDKKKHLM> GMFNNKMEKEL, EKPODPHDKAD<HINBMEFALMJ, MKHMFONGLFO> GKMLFGDAHPG, GNMLBPFILMD AJIEBFICGCI, EKPODPHDKAD<DAEKILKJHLB, NKLOFNOLDBM> IAKPAGICOIM, EKPODPHDKAD<DAEKILKJHLB, KOJPNJKNJFD> FODEKNANLJB, string? NIJGHDOEJIE, GDGGKNMDGAI EJELGELAOJP, MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII, bool FKJMBMGKIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x2084290", Offset = "0x2082C90", VA = "0x182084290")]
	public static EGFMMEGKJNC MMKGNMBHOIH(bool NEGCLIMIHGF, DBKFEBENKEL NLLPJEKPGDO, bool NDNHHLNAIFP, GNMLBPFILMD AJIEBFICGCI, GDGGKNMDGAI EJELGELAOJP, MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII, bool FKJMBMGKIEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x2084FB0", Offset = "0x20839B0", VA = "0x182084FB0")]
	private void PCEEADECCDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x2080FC0", Offset = "0x207F9C0", VA = "0x182080FC0", Slot = "49")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x2083330", Offset = "0x2081D30", VA = "0x182083330", Slot = "38")]
	[AsyncStateMachine(typeof(MJBOJNFKLNH))]
	public Task<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> ILAKANGICEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x2083D00", Offset = "0x2082700", VA = "0x182083D00")]
	private (BGOKAMBNOAC, int)? LMPPPHOGHDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x20834C0", Offset = "0x2081EC0", VA = "0x1820834C0")]
	private void IPOIHMDJAOD(int NDAGDBCPENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x1630DB0", Offset = "0x162F7B0", VA = "0x181630DB0")]
	private void NGNDPIHAECI(int NDAGDBCPENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x2080A40", Offset = "0x207F440", VA = "0x182080A40")]
	private void DFJAHCMONNO(int DCNGKIAMMHF, int IDFIGDOFJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x2082470", Offset = "0x2080E70", VA = "0x182082470")]
	private void GGHIHFPGNLI(int DCNGKIAMMHF, int IDFIGDOFJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x20824D0", Offset = "0x2080ED0", VA = "0x1820824D0")]
	private void GGPFAGDKPPD(int NDAGDBCPENL, MLGFJIHMDCD<HINBMEFALMJ> FOGMHOJBNJL, AKABJABIDDF KPOIIPENPBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x2082B00", Offset = "0x2081500", VA = "0x182082B00")]
	private void GIPOAIHIECA(int AHPMMDKKKFB, MLGFJIHMDCD<HINBMEFALMJ> FOGMHOJBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x2080140", Offset = "0x207EB40", VA = "0x182080140")]
	private void AJEDBLPAOKG(int AHPMMDKKKFB, MLGFJIHMDCD<HINBMEFALMJ> FOGMHOJBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x2084800", Offset = "0x2083200", VA = "0x182084800")]
	private void MNLOPCLJDCL(int NDAGDBCPENL, MLGFJIHMDCD<HINBMEFALMJ> FOGMHOJBNJL, AKABJABIDDF KPOIIPENPBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x2083AC0", Offset = "0x20824C0", VA = "0x182083AC0")]
	private void KNPBNJGDAEB(int NDAGDBCPENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0xC67CE0", Offset = "0xC666E0", VA = "0x180C67CE0")]
	private void OIIAEBCCOEI(int NDAGDBCPENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x2082A10", Offset = "0x2081410", VA = "0x182082A10")]
	private void GIGLNKDGMCC(int NDAGDBCPENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x1630DB0", Offset = "0x162F7B0", VA = "0x181630DB0")]
	private void IIMPOEGHEGJ(int NDAGDBCPENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x2080160", Offset = "0x207EB60", VA = "0x182080160")]
	private void BBJOFMCONHD(int DCNGKIAMMHF, int IDFIGDOFJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x2080920", Offset = "0x207F320", VA = "0x182080920")]
	private void DCCCDNOANPL(int DCNGKIAMMHF, int IDFIGDOFJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x2085950", Offset = "0x2084350", VA = "0x182085950")]
	private void PNLPPCLLHEI(int NDAGDBCPENL, MLGFJIHMDCD<DAEKILKJHLB> FOGMHOJBNJL, JDIEKMJLKHH KPOIIPENPBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x2081AC0", Offset = "0x20804C0", VA = "0x182081AC0")]
	private void EBMMOHKHMAK(int AHPMMDKKKFB, MLGFJIHMDCD<DAEKILKJHLB> FOGMHOJBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x2080840", Offset = "0x207F240", VA = "0x182080840")]
	private void CILNILGFFMB(int AHPMMDKKKFB, MLGFJIHMDCD<DAEKILKJHLB> FOGMHOJBNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x2081BA0", Offset = "0x20805A0", VA = "0x182081BA0")]
	private void EGMJPONOEFH(int NDAGDBCPENL, MLGFJIHMDCD<DAEKILKJHLB> FOGMHOJBNJL, JDIEKMJLKHH KPOIIPENPBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x20835B0", Offset = "0x2081FB0", VA = "0x1820835B0")]
	private void JEDAKGNACGA(int NDAGDBCPENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0xC67CE0", Offset = "0xC666E0", VA = "0x180C67CE0")]
	private void AJNMNKNFCFB(int NDAGDBCPENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x2082360", Offset = "0x2080D60", VA = "0x182082360", Slot = "39")]
	[AsyncStateMachine(typeof(PKCFEGMJAMD))]
	public Task<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> GGGILKHBHLJ(MLGFJIHMDCD<JCNBPBDCDNO> CNBEFMBNOMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x20820D0", Offset = "0x2080AD0", VA = "0x1820820D0", Slot = "40")]
	[AsyncStateMachine(typeof(OBJEEEKJCJD))]
	public Task<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> FDHIPLFCLJP(MLGFJIHMDCD<LKMKIJDBGPC> GJDKPLIDILM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x2080DE0", Offset = "0x207F7E0", VA = "0x182080DE0", Slot = "41")]
	[AsyncStateMachine(typeof(LBAGCLHIEIA))]
	public Task<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> DKHFGLHPHFI(MLGFJIHMDCD<JCNBPBDCDNO> CNBEFMBNOMD, MLGFJIHMDCD<JCNBPBDCDNO> HBDDHDPMAKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x2084DD0", Offset = "0x20837D0", VA = "0x182084DD0", Slot = "42")]
	[AsyncStateMachine(typeof(DIGGBEMEKJH))]
	public Task<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> NPLIOHDDCEL(MLGFJIHMDCD<LKMKIJDBGPC> GJDKPLIDILM, MLGFJIHMDCD<LKMKIJDBGPC> HBDDHDPMAKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x2083F30", Offset = "0x2082930", VA = "0x182083F30", Slot = "43")]
	[AsyncStateMachine(typeof(KFIKGHGBBJO))]
	public Task<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> LPIFFPJCIIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x2080720", Offset = "0x207F120", VA = "0x182080720", Slot = "44")]
	[AsyncStateMachine(typeof(PACBHEDHJME))]
	public Task<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> CFMDAEBLDEM(string CLFPGJNNJGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x2083930", Offset = "0x2082330", VA = "0x182083930", Slot = "45")]
	[AsyncStateMachine(typeof(IOJCHPBIBLN))]
	public Task<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> JOFEONIIBAD(MLGFJIHMDCD<JCNBPBDCDNO> CNBEFMBNOMD, string HBOONHFLONJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x20840E0", Offset = "0x2082AE0", VA = "0x1820840E0", Slot = "46")]
	[AsyncStateMachine(typeof(KFPIMBGEIJE))]
	public Task<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> MDLBHMNDKBM(MLGFJIHMDCD<LKMKIJDBGPC> GJDKPLIDILM, string HBOONHFLONJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x2085760", Offset = "0x2084160", VA = "0x182085760", Slot = "47")]
	[AsyncStateMachine(typeof(JAONHOFPFFN))]
	public Task<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> PGLHKFHOHHD(MLGFJIHMDCD<JCNBPBDCDNO> CNBEFMBNOMD, LLBJEPOEBFC NNCMOPPBEEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x2082BE0", Offset = "0x20815E0", VA = "0x182082BE0", Slot = "48")]
	[AsyncStateMachine(typeof(OIEBDLFHIED))]
	public Task<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> HHKLMKKEFAK(MLGFJIHMDCD<LKMKIJDBGPC> GJDKPLIDILM, LLBJEPOEBFC NNCMOPPBEEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x2082F70", Offset = "0x2081970", VA = "0x182082F70")]
	internal void IKDDEFKDECI(MLGFJIHMDCD<KGKGLKMKAOL> CLMKDBDPNNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public sealed class KGBHMHDIMKJ : PKCCJBPIFIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public interface MAHPLEDMLMD
	{
		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		LJIGEMAELHP MOLLBCHKADG
		{
			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<LOOBEJOIHCO> NAAJIFCLGHH(CancellationToken OGJIGALEPCA);

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<KBMJFJMBCBA> HACJPGLPAIH(CancellationToken OGJIGALEPCA);

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<INHBEABFFKP> BANEIOBNEFA(CancellationToken OGJIGALEPCA);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct EPNPDMAHHDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<KGBHMHDIMKJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public DBKFEBENKEL circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public LOOBEJOIHCO roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public KBMJFJMBCBA superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private MAHPLEDMLMD <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private KBMJFJMBCBA <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter<LOOBEJOIHCO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private TaskAwaiter<KBMJFJMBCBA> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter<INHBEABFFKP> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private TaskAwaiter<LENGACKPANN> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x2087070", Offset = "0x2085A70", VA = "0x182087070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x2087A80", Offset = "0x2086480", VA = "0x182087A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private readonly LENGACKPANN AHBOCBMGDND;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public LENGACKPANN OADFFMICJAL
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x882870", Offset = "0x881270", VA = "0x180882870")]
	private KGBHMHDIMKJ(LENGACKPANN ONLMPGGLPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x208DFD0", Offset = "0x208C9D0", VA = "0x18208DFD0")]
	[AsyncStateMachine(typeof(EPNPDMAHHDL))]
	public static Task<KGBHMHDIMKJ> GFPMOBDCNNE(DBKFEBENKEL NLLPJEKPGDO, LOOBEJOIHCO? HMIHKJIKEGE, KBMJFJMBCBA? KPLKDBDJMCI, CancellationToken OGJIGALEPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x208DFB0", Offset = "0x208C9B0", VA = "0x18208DFB0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public readonly struct GAMHEIBPJLL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct JNEILPCBHLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<object, JNDPMGELPNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public GAMHEIBPJLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public NFPABPCJAGA action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private TaskAwaiter<MOKFKOEPKDB<object, JNDPMGELPNI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x208D220", Offset = "0x208BC20", VA = "0x18208D220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x208D4B0", Offset = "0x208BEB0", VA = "0x18208D4B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct GOFLMCFKDIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<bool, JNDPMGELPNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public HHGPMIDEFHD rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public LOOBEJOIHCO circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public KBMJFJMBCBA superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public GAMHEIBPJLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private NFPABPCJAGA[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private TaskAwaiter<MOKFKOEPKDB<object, JNDPMGELPNI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x20887D0", Offset = "0x20871D0", VA = "0x1820887D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x2088BB0", Offset = "0x20875B0", VA = "0x182088BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct HBECPHGNBBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public GAMHEIBPJLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private TaskAwaiter<MOKFKOEPKDB<object, JNDPMGELPNI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x2088C20", Offset = "0x2087620", VA = "0x182088C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x2088E60", Offset = "0x2087860", VA = "0x182088E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private readonly KOFEPIBJAEI IJPEOKKLOFJ;

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0xACCA10", Offset = "0xACB410", VA = "0x180ACCA10")]
	public GAMHEIBPJLL(KOFEPIBJAEI JKKBNDHDINA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x2088640", Offset = "0x2087040", VA = "0x182088640")]
	[AsyncStateMachine(typeof(JNEILPCBHLD))]
	private Task<MOKFKOEPKDB<object, JNDPMGELPNI>> NIHHGHLONIE(NFPABPCJAGA ENNGIICFMFD, bool PCMIMGJBICJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x20884E0", Offset = "0x2086EE0", VA = "0x1820884E0")]
	[AsyncStateMachine(typeof(GOFLMCFKDIP))]
	public Task<MOKFKOEPKDB<bool, JNDPMGELPNI?>>? IONNCLJBCBD(int KNJCAIGEJEE, HHGPMIDEFHD? BBMHNPDNFDC, LOOBEJOIHCO? HKHFEOGOHFP, KBMJFJMBCBA? KPLKDBDJMCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x20883F0", Offset = "0x2086DF0", VA = "0x1820883F0")]
	[AsyncStateMachine(typeof(HBECPHGNBBB))]
	public Task<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> EPGEGEJNIJO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public sealed class JFEHLNCAMEP : BNEMNAKPOJH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private readonly HEGGPKCIGJE LOLCFKFPCOM;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public HEGGPKCIGJE MEEBKLNPECM
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x882870", Offset = "0x881270", VA = "0x180882870")]
	private JFEHLNCAMEP(HEGGPKCIGJE MFIGIDPMLPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x208CD10", Offset = "0x208B710", VA = "0x18208CD10")]
	public static JFEHLNCAMEP ILDFGHALABA(DBKFEBENKEL NLLPJEKPGDO, HHGPMIDEFHD IEFDEOEDNEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x208CCF0", Offset = "0x208B6F0", VA = "0x18208CCF0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public interface FGDGJDOBGLF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	LENGACKPANN OADFFMICJAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	PKMMAOIOKBP FKKLAFIDJMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	BHJNBBGEABP KKADELEECPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	NBKLJEEPNJG OFKPECLCGAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public interface EJNAILEIMOC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	FGDGJDOBGLF? ACGLHEOFAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	bool PAJCHKNMDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	bool PLBJLDFDNKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<FGDGJDOBGLF?>? HPIKGKOPACM();

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task CIOANLHILOF(DBKFEBENKEL NLLPJEKPGDO, HHGPMIDEFHD IEFDEOEDNEP, LOOBEJOIHCO? DAOACJFLJEO, KBMJFJMBCBA? EDHPPLNGNBK);
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[PIBEOEAKMEE("IStaticCV2Instance")]
public interface PKCCJBPIFIB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	LENGACKPANN OADFFMICJAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[PIBEOEAKMEE("IStaticEVInstance")]
public interface BNEMNAKPOJH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	HEGGPKCIGJE MEEBKLNPECM
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public static class NGJOPJCALOD
{
	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x2094890", Offset = "0x2093290", VA = "0x182094890")]
	public static FHHLCBPGANA<NHMLEAIPHKC, NFPABPCJAGA, DBKFEBENKEL, EINFKNJDJCL.AKGGBJEONCP<NHMLEAIPHKC, NFPABPCJAGA, DBKFEBENKEL>> PAEAKANKHJB([In] this FHHLCBPGANA<NHMLEAIPHKC, NFPABPCJAGA, DBKFEBENKEL, EINFKNJDJCL.AKGGBJEONCP<NHMLEAIPHKC, NFPABPCJAGA, DBKFEBENKEL>> BIMBJPHGMND)
	{
		return default(FHHLCBPGANA<NHMLEAIPHKC, NFPABPCJAGA, DBKFEBENKEL, EINFKNJDJCL.AKGGBJEONCP<NHMLEAIPHKC, NFPABPCJAGA, DBKFEBENKEL>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public sealed class DJKHAIHGHHM : OMCMONEGDKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private readonly DBKFEBENKEL JKIGMMCPDCE;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool PLBJLDFDNKA
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x207E170", Offset = "0x207CB70", VA = "0x18207E170", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x882870", Offset = "0x881270", VA = "0x180882870")]
	internal DJKHAIHGHHM(DBKFEBENKEL NLLPJEKPGDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal sealed class FKHIFIMCDEE : FJLBAIGNHBB
{
	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x2087F10", Offset = "0x2086910", VA = "0x182087F10", Slot = "4")]
	public INNBKNABGEL? NDOIFPDPCKL(string? CJIHBGPABGO, string? NGNHJBJHOHH, string? OHAJOLCGLGE, LPIKACOKPJN.GGDGJHDPGAM.ACKLBDOJEFM DDMDEIADLHA, bool IEDIJDDEIPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public FKHIFIMCDEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public sealed class HOCMAHFMIJJ : IHCEJBEOOBL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private struct JFLLLOIFEHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public AsyncTaskMethodBuilder<FKLLFJIANML> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public HOCMAHFMIJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private TaskAwaiter<FGDGJDOBGLF?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x208CF10", Offset = "0x208B910", VA = "0x18208CF10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x208D1B0", Offset = "0x208BBB0", VA = "0x18208D1B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private readonly DBKFEBENKEL JKIGMMCPDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private IReadOnlyList<DKFKDKPPDAA<CJEPNLHNKAI>>? MPBMOKPKACF;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public FKLLFJIANML? LPENGNKGBMO
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x2089450", Offset = "0x2087E50", VA = "0x182089450", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public NBKLJEEPNJG? CDGCACOHJAD
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x2089B90", Offset = "0x2088590", VA = "0x182089B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool BBOGOMHNCFC
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x2089840", Offset = "0x2088240", VA = "0x182089840", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool LEDMNJGLLBL
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x20891F0", Offset = "0x2087BF0", VA = "0x1820891F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x882870", Offset = "0x881270", VA = "0x180882870")]
	internal HOCMAHFMIJJ(DBKFEBENKEL NLLPJEKPGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x2089AA0", Offset = "0x20884A0", VA = "0x182089AA0", Slot = "7")]
	[AsyncStateMachine(typeof(JFLLLOIFEHD))]
	public Task<FKLLFJIANML> MIGAOJAAAPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x20894D0", Offset = "0x2087ED0", VA = "0x1820894D0", Slot = "9")]
	public IReadOnlyDictionary<DKFKDKPPDAA<BLDJADOAIME>, Guid> GIOAKBFFIDA(IEnumerable<HCMMMILGLPC> BHODGCDJLIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x2089250", Offset = "0x2087C50", VA = "0x182089250")]
	public MOKFKOEPKDB<KFBGHECFDGM, NLHAIFJDFEL> DGMJMGAMLDO([In] KFBGHECFDGM JFJHCOKFGOB, IEnumerable<HCMMMILGLPC> BNFCHGIENII, int NOKPPBCDJBK)
	{
		return default(MOKFKOEPKDB<KFBGHECFDGM, NLHAIFJDFEL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x20898A0", Offset = "0x20882A0", VA = "0x1820898A0", Slot = "8")]
	private MOKFKOEPKDB<KFBGHECFDGM, NLHAIFJDFEL> LIPKFMBMLIG([In] KFBGHECFDGM JFJHCOKFGOB, IEnumerable<HCMMMILGLPC> BNFCHGIENII, int NOKPPBCDJBK)
	{
		return default(MOKFKOEPKDB<KFBGHECFDGM, NLHAIFJDFEL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class NBKLJEEPNJG : FKLLFJIANML
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	internal static class DMPFOENJIIO
	{
		[Cpp2IlInjected.Token(Token = "0x20000CC")]
		[CompilerGenerated]
		private sealed class LBJNCPOHLFN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000294")]
			public LENGACKPANN state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000295")]
			public PDPODFCLEJG spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x60004F7")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public LBJNCPOHLFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F8")]
			[Cpp2IlInjected.Address(RVA = "0x208E4F0", Offset = "0x208CEF0", VA = "0x18208E4F0")]
			internal bool OMACMNANNML(JOCELFKFLIO n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CD")]
		[CompilerGenerated]
		private sealed class ALHGELDDLOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000296")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x60004F9")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public ALHGELDDLOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0x207D220", Offset = "0x207BC20", VA = "0x18207D220")]
			internal void GAHLGJELHIC(JOCELFKFLIO n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x207F0F0", Offset = "0x207DAF0", VA = "0x18207F0F0")]
		public static MOKFKOEPKDB<FKLLFJIANML.PPHEEIEMDFG, HDCNBLKJONM> IIGKFMPFNHH(NBKLJEEPNJG PECHDAFMNOO, [In] FKLLFJIANML.HEOPLLEFPLB EBIJIHILGPC)
		{
			return default(MOKFKOEPKDB<FKLLFJIANML.PPHEEIEMDFG, HDCNBLKJONM>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x207E280", Offset = "0x207CC80", VA = "0x18207E280")]
		internal static MOKFKOEPKDB<(HEJKHOMNPOM, JFDAGIJDAFL), HDCNBLKJONM> GMHNJLEMKLM(NBKLJEEPNJG PECHDAFMNOO, JFDAGIJDAFL HLLKIAHLCOE, bool ILIDEJJDOGN, [In] DKFKDKPPDAA<BLDJADOAIME> KNAIGINJHMI, [In] int? FBPJEHKMDDB, [In] JGEFDJEOPKG? ANMNIFLNFJH, [In] JGEFDJEOPKG? KOKBMPDBFAA)
		{
			return default(MOKFKOEPKDB<(HEJKHOMNPOM, JFDAGIJDAFL), HDCNBLKJONM>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x207FA80", Offset = "0x207E480", VA = "0x18207FA80")]
		private static void JNEHNKAGDJM(bool ILIDEJJDOGN, HCMMMILGLPC GANFOOKIDIA, HEJKHOMNPOM HFANDMGOHNB, [In] DKFKDKPPDAA<BLDJADOAIME> KNAIGINJHMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x207F680", Offset = "0x207E080", VA = "0x18207F680")]
		public static void JALIMALGDBI(EFHLEDMBAEL BLCDKDBLNFO, [In] FKLLFJIANML.KGCIJPBHKII IMGIPAIOFJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x207E190", Offset = "0x207CB90", VA = "0x18207E190")]
		[CompilerGenerated]
		internal static bool GEGGDGEAGDE(LENGACKPANN KDFLNJJCIHI, PDPODFCLEJG JCFEFLGJKEC, JOCELFKFLIO CKDFBEMHALL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x207FEC0", Offset = "0x207E8C0", VA = "0x18207FEC0")]
		[CompilerGenerated]
		internal static bool KLCPLMNDGMA(JOCELFKFLIO CMEDJJCHDOH)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private struct PDCFEAGHAGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public NBKLJEEPNJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public MLGFJIHMDCD<BLDJADOAIME> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public MLGFJIHMDCD<EGLCODOFCAG> srcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public MLGFJIHMDCD<EEPPPKFALIN> dstId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private TaskAwaiter<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x2096380", Offset = "0x2094D80", VA = "0x182096380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x20969D0", Offset = "0x20953D0", VA = "0x1820969D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private struct MIOECBNNAHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public NBKLJEEPNJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public DKFKDKPPDAA<COGPDFLIJHB> inputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public DKFKDKPPDAA<BLDJADOAIME> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public MLGFJIHMDCD<KGKGLKMKAOL> inputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public MLGFJIHMDCD<HINBMEFALMJ> inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private TaskAwaiter<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x208ECB0", Offset = "0x208D6B0", VA = "0x18208ECB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x208EFF0", Offset = "0x208D9F0", VA = "0x18208EFF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[CompilerGenerated]
	private struct JJGEDOCFIMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public NBKLJEEPNJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public DKFKDKPPDAA<COGPDFLIJHB> outputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public DKFKDKPPDAA<BLDJADOAIME> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public MLGFJIHMDCD<KGKGLKMKAOL> outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public MLGFJIHMDCD<DAEKILKJHLB> outputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private TaskAwaiter<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x2099FC0", Offset = "0x20989C0", VA = "0x182099FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x209A300", Offset = "0x2098D00", VA = "0x18209A300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private readonly DBKFEBENKEL JKIGMMCPDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private readonly PKCCJBPIFIB HEADFOLPJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private readonly BNEMNAKPOJH CJPOLFOGMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private readonly OHAODOOFHCE JBCNEBLPAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private readonly HOCMAHFMIJJ HBGANEJHBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private Dictionary<DKFKDKPPDAA<COGPDFLIJHB>, JINHCMKFECA> IGIGJMLLCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	[CompilerGenerated]
	private Action<DKFKDKPPDAA<COGPDFLIJHB>>? FPPKCILJDKM;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public DKFKDKPPDAA<BLDJADOAIME> ELBBGNEMCNB
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x20904B0", Offset = "0x208EEB0", VA = "0x1820904B0", Slot = "4")]
		get
		{
			return default(DKFKDKPPDAA<BLDJADOAIME>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public OHAODOOFHCE NEAKAPOOBHO
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x20637C0", Offset = "0x20621C0", VA = "0x1820637C0", Slot = "5")]
		get
		{
			return default(OHAODOOFHCE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x2094050", Offset = "0x2092A50", VA = "0x182094050")]
	public NBKLJEEPNJG(DBKFEBENKEL NLLPJEKPGDO, PKCCJBPIFIB ANFLFKCPKCA, BNEMNAKPOJH AAPKKOAGECA, HOCMAHFMIJJ KKBCHCFELDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x2090FA0", Offset = "0x208F9A0", VA = "0x182090FA0", Slot = "46")]
	public MLGFJIHMDCD<MNLFEDPFAIF> GBKMBDIDBPI(MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, MLGFJIHMDCD<EEPPPKFALIN> KKKBAAHOPHK)
	{
		return default(MLGFJIHMDCD<MNLFEDPFAIF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x208F770", Offset = "0x208E170", VA = "0x18208F770", Slot = "47")]
	public MLGFJIHMDCD<ACENEFMKIHL> BFPCNBICGIF(MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, MLGFJIHMDCD<EGLCODOFCAG> NCKPDHPKIAJ)
	{
		return default(MLGFJIHMDCD<ACENEFMKIHL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x2091AD0", Offset = "0x20904D0", VA = "0x182091AD0", Slot = "6")]
	public (bool, bool) JBHFDLOAHBF(MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, MLGFJIHMDCD<EGLCODOFCAG> AGEIBEFBAEP, MLGFJIHMDCD<EEPPPKFALIN> DGCOGNPPMJK)
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x2093C80", Offset = "0x2092680", VA = "0x182093C80")]
	public bool PHOJLOAINMI(MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, [In] OBKLBGPBJEH FDLIIFDHANB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x208F7F0", Offset = "0x208E1F0", VA = "0x18208F7F0", Slot = "8")]
	public bool BJKKINEBBOI(MKHMFONGLFO MPIBJGLNNCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x20903C0", Offset = "0x208EDC0", VA = "0x1820903C0", Slot = "9")]
	public bool DLJCPHIPNEF(KOJPNJKNJFD EIALNEFLOCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x2093BD0", Offset = "0x20925D0", VA = "0x182093BD0", Slot = "10")]
	public IEnumerable<MLGFJIHMDCD<OFACNMCCNGG>> ONGAKMHEAMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x2093870", Offset = "0x2092270", VA = "0x182093870", Slot = "11")]
	public string OIPJNAEDPHM(MLGFJIHMDCD<OFACNMCCNGG> JLHIOADPCBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x208F870", Offset = "0x208E270", VA = "0x18208F870", Slot = "12")]
	public string CHMOPIOJIMP(MLGFJIHMDCD<OFACNMCCNGG> JLHIOADPCBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x20929A0", Offset = "0x20913A0", VA = "0x1820929A0")]
	public JINHCMKFECA? LPEFLAKLILP([In] DKFKDKPPDAA<COGPDFLIJHB> ODLOJKBAHLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x20920D0", Offset = "0x2090AD0", VA = "0x1820920D0")]
	public MLGFJIHMDCD<COGPDFLIJHB> LFBCIFELAIG(MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, [In] DKFKDKPPDAA<COGPDFLIJHB> JCDANMIKACO)
	{
		return default(MLGFJIHMDCD<COGPDFLIJHB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x2093FD0", Offset = "0x20929D0", VA = "0x182093FD0", Slot = "24")]
	public MLGFJIHMDCD<COGPDFLIJHB> PLJLDFGOEIO(MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, MLGFJIHMDCD<EEPPPKFALIN> KKKBAAHOPHK)
	{
		return default(MLGFJIHMDCD<COGPDFLIJHB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x2090F20", Offset = "0x208F920", VA = "0x182090F20", Slot = "25")]
	public MLGFJIHMDCD<COGPDFLIJHB> GAKPBMBDHLI(MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, MLGFJIHMDCD<EGLCODOFCAG> NCKPDHPKIAJ)
	{
		return default(MLGFJIHMDCD<COGPDFLIJHB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x2092910", Offset = "0x2091310", VA = "0x182092910")]
	private void LKDDJMEKODJ(DKFKDKPPDAA<COGPDFLIJHB> ODLOJKBAHLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x2092B10", Offset = "0x2091510", VA = "0x182092B10")]
	public IEnumerable<JINHCMKFECA> MEMNPNHGNPO([In] DKFKDKPPDAA<BLDJADOAIME> OJMCAIBKDOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x2093110", Offset = "0x2091B10", VA = "0x182093110", Slot = "23")]
	public MLGFJIHMDCD<EEPPPKFALIN> NBEFBHIDGHE(MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, MLGFJIHMDCD<COGPDFLIJHB> ODLOJKBAHLA, MLGFJIHMDCD<MNLFEDPFAIF> IGFHNMEDLLI)
	{
		return default(MLGFJIHMDCD<EEPPPKFALIN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x20919C0", Offset = "0x20903C0", VA = "0x1820919C0", Slot = "26")]
	public MLGFJIHMDCD<EGLCODOFCAG> INIDHGNGIJC(MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, MLGFJIHMDCD<COGPDFLIJHB> ODLOJKBAHLA, MLGFJIHMDCD<ACENEFMKIHL> EINNMBDFPBJ)
	{
		return default(MLGFJIHMDCD<EGLCODOFCAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x20914B0", Offset = "0x208FEB0", VA = "0x1820914B0")]
	private JINHCMKFECA? HKICBKIKPJN([In] DKFKDKPPDAA<COGPDFLIJHB> ODLOJKBAHLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x208F5F0", Offset = "0x208DFF0", VA = "0x18208F5F0")]
	private JINHCMKFECA AEFEADMIENM([In] DKFKDKPPDAA<COGPDFLIJHB> ODLOJKBAHLA, GNMLBPFILMD AJIEBFICGCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x20926D0", Offset = "0x20910D0", VA = "0x1820926D0")]
	public GNMLBPFILMD? LFCAAAPLOCM([In] DKFKDKPPDAA<COGPDFLIJHB> ODLOJKBAHLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x208F740", Offset = "0x208E140", VA = "0x18208F740")]
	public IDNMHIFJHOJ? NCMIDGNNOKG([In] DKFKDKPPDAA<BLDJADOAIME> OJMCAIBKDOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x20937B0", Offset = "0x20921B0", VA = "0x1820937B0", Slot = "18")]
	public IEnumerable<KKDKPBHKNBH> OFPLDMHAODB(MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x208FFA0", Offset = "0x208E9A0", VA = "0x18208FFA0", Slot = "19")]
	public bool DEMJBNMMGII(MLGFJIHMDCD<OFACNMCCNGG> JLHIOADPCBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x2093520", Offset = "0x2091F20", VA = "0x182093520", Slot = "20")]
	public IEnumerable<OBKLBGPBJEH> ODIMFBPFEBO(MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, MLGFJIHMDCD<EGLCODOFCAG> AGEIBEFBAEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x2090090", Offset = "0x208EA90", VA = "0x182090090", Slot = "21")]
	public IEnumerable<OBKLBGPBJEH> DIFDAJMDKHO(MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, MLGFJIHMDCD<EEPPPKFALIN> DGCOGNPPMJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x2091A50", Offset = "0x2090450", VA = "0x182091A50")]
	public MLGFJIHMDCD<BLDJADOAIME> JBGOGKNKPLD([In] DKFKDKPPDAA<BLDJADOAIME> OJMCAIBKDOI)
	{
		return default(MLGFJIHMDCD<BLDJADOAIME>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x2090310", Offset = "0x208ED10", VA = "0x182090310")]
	public MLGFJIHMDCD<BLDJADOAIME>? HBHPJBNNACA([In] DKFKDKPPDAA<BLDJADOAIME> OJMCAIBKDOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x2092850", Offset = "0x2091250", VA = "0x182092850")]
	private PDPODFCLEJG? LJHPKCOHLFF([In] DKFKDKPPDAA<BLDJADOAIME> OJMCAIBKDOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x208F740", Offset = "0x208E140", VA = "0x18208F740")]
	private IDNMHIFJHOJ? DDPOIPJBHHK([In] DKFKDKPPDAA<BLDJADOAIME> OJMCAIBKDOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x2092AA0", Offset = "0x20914A0", VA = "0x182092AA0", Slot = "30")]
	public DKFKDKPPDAA<BLDJADOAIME> MCMCEANCGLN(MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI)
	{
		return default(DKFKDKPPDAA<BLDJADOAIME>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x2091FD0", Offset = "0x20909D0", VA = "0x182091FD0", Slot = "27")]
	public IEnumerable<LLBJEPOEBFC> JEAGBGDGLBI(NKCNFDFGDAD JLFOGNAMALO, bool EBBMLJPBPOO, bool KLFMDNJDLAO, bool DLHMJFANNEK, bool GJHMNDHDIEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x20938E0", Offset = "0x20922E0", VA = "0x1820938E0", Slot = "28")]
	public LLBJEPOEBFC OJDCIHFGIGB(NKCNFDFGDAD JLFOGNAMALO, ACJGAIHJELB JHIGJDGPDCP, bool EBBMLJPBPOO, bool KLFMDNJDLAO, bool DLHMJFANNEK, bool GJHMNDHDIEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x2090510", Offset = "0x208EF10", VA = "0x182090510")]
	public KKDKPBHKNBH DOMFPKEHEJG(MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, [In] OBKLBGPBJEH FDLIIFDHANB)
	{
		return default(KKDKPBHKNBH);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x2092240", Offset = "0x2090C40", VA = "0x182092240", Slot = "31")]
	public OBKLBGPBJEH KLNAKHLNIBC(MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, MLGFJIHMDCD<EGLCODOFCAG> AGEIBEFBAEP, MLGFJIHMDCD<EEPPPKFALIN> DGCOGNPPMJK)
	{
		return default(OBKLBGPBJEH);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x2091860", Offset = "0x2090260", VA = "0x182091860", Slot = "32")]
	public bool IJLMGALHACC(MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x208F6C0", Offset = "0x208E0C0", VA = "0x18208F6C0", Slot = "33")]
	public bool AMEELABFLIP(MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, MLGFJIHMDCD<EEPPPKFALIN> KKKBAAHOPHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x208FF20", Offset = "0x208E920", VA = "0x18208FF20", Slot = "34")]
	public bool DELOLIDAMIF(MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, MLGFJIHMDCD<EGLCODOFCAG> NCKPDHPKIAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x2090390", Offset = "0x208ED90", VA = "0x182090390")]
	public MOKFKOEPKDB<FKLLFJIANML.PPHEEIEMDFG, HDCNBLKJONM> PJPDJOGOHOJ([In] FKLLFJIANML.HEOPLLEFPLB EBIJIHILGPC)
	{
		return default(MOKFKOEPKDB<FKLLFJIANML.PPHEEIEMDFG, HDCNBLKJONM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x2092BF0", Offset = "0x20915F0", VA = "0x182092BF0", Slot = "36")]
	[AsyncStateMachine(typeof(PDCFEAGHAGB))]
	public Task<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> MFEHALHAMPJ(MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, MLGFJIHMDCD<EGLCODOFCAG> AGEIBEFBAEP, MLGFJIHMDCD<EEPPPKFALIN> DGCOGNPPMJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x2092D20", Offset = "0x2091720", VA = "0x182092D20", Slot = "37")]
	public MOKFKOEPKDB<PLAMMPHLJPN, NLHAIFJDFEL> MHKLOLDJJOL(DKFKDKPPDAA<BLDJADOAIME> OJMCAIBKDOI, PLAMMPHLJPN NFHLOLEOGBB, KKIALALDEMD KHCMLKLCMPM)
	{
		return default(MOKFKOEPKDB<PLAMMPHLJPN, NLHAIFJDFEL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x20914F0", Offset = "0x208FEF0", VA = "0x1820914F0", Slot = "38")]
	[AsyncStateMachine(typeof(MIOECBNNAHL))]
	public Task<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> HOINCFONDMG(DKFKDKPPDAA<BLDJADOAIME> OJMCAIBKDOI, DKFKDKPPDAA<COGPDFLIJHB> BNCPAAIFPLP, MLGFJIHMDCD<KGKGLKMKAOL> KKEDDFFKCKA, MLGFJIHMDCD<HINBMEFALMJ> KKKBAAHOPHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x2090DC0", Offset = "0x208F7C0", VA = "0x182090DC0", Slot = "39")]
	[AsyncStateMachine(typeof(JJGEDOCFIMP))]
	public Task<MOKFKOEPKDB<IEPJDCHMGFO, JNDPMGELPNI>> FFFEEBHMCFF(DKFKDKPPDAA<BLDJADOAIME> OJMCAIBKDOI, DKFKDKPPDAA<COGPDFLIJHB> OBBCHHIHJME, MLGFJIHMDCD<KGKGLKMKAOL> CFCKOJEDDLE, MLGFJIHMDCD<DAEKILKJHLB> NCKPDHPKIAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x2092480", Offset = "0x2090E80", VA = "0x182092480", Slot = "40")]
	public CMCJONAFKAI LAOCPGDGGNF(IEnumerable<HCMMMILGLPC> BNFCHGIENII)
	{
		return default(CMCJONAFKAI);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x2091650", Offset = "0x2090050", VA = "0x182091650", Slot = "41")]
	public CMCJONAFKAI IABILLEHCIB()
	{
		return default(CMCJONAFKAI);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x208F8E0", Offset = "0x208E2E0", VA = "0x18208F8E0")]
	private NDEEDOBLEPI CJPLJGANJOH(NLBHPJJNALL BLBDPKLHAII, MLGFJIHMDCD<BLDJADOAIME> EOGKNMHPMEG, IEnumerable<DKFKDKPPDAA<BLDJADOAIME>> HGDHPNCCKLD, IEnumerable<DKFKDKPPDAA<COGPDFLIJHB>> JFGDEMOPEJJ)
	{
		return default(NDEEDOBLEPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x208FA90", Offset = "0x208E490", VA = "0x18208FA90", Slot = "42")]
	public NDEEDOBLEPI CJPLJGANJOH(NLBHPJJNALL BLBDPKLHAII, MLGFJIHMDCD<BLDJADOAIME> EOGKNMHPMEG, IEnumerable<DKFKDKPPDAA<COGPDFLIJHB>> JFGDEMOPEJJ, IEnumerable<HCMMMILGLPC> BNFCHGIENII)
	{
		return default(NDEEDOBLEPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x20931A0", Offset = "0x2091BA0", VA = "0x1820931A0")]
	private static IEnumerable<DKFKDKPPDAA<BLDJADOAIME>> OBEPIDFBHBJ(IEnumerable<HCMMMILGLPC> BNFCHGIENII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x2091020", Offset = "0x208FA20", VA = "0x182091020")]
	private IEnumerable<DKFKDKPPDAA<COGPDFLIJHB>> HGCJAPFLBHM(IEnumerable<HCMMMILGLPC> BNFCHGIENII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x2091770", Offset = "0x2090170", VA = "0x182091770", Slot = "43")]
	public List<OIDNNMMIODK> IDHKMKLDCGJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x2090680", Offset = "0x208F080", VA = "0x182090680")]
	public (List<OIDNNMMIODK>, bool) DPOMFJGJMDK([In] CFCHGNBNAFA JFDAHOFJDLI, string GJGBLLHIOAC, [In] ONALFDNJHPD IDHADANDAME, PCJKPLCOFFP MHFNPKODAPB, JHOJEGLGEOH AJDDLAHFOHF)
	{
		return default((List<OIDNNMMIODK>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x20918D0", Offset = "0x20902D0", VA = "0x1820918D0", Slot = "45")]
	public bool ILKNLPNJDNK(MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x2091800", Offset = "0x2090200", VA = "0x182091800")]
	internal void IGEBGAAFONO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x2090030", Offset = "0x208EA30", VA = "0x182090030")]
	internal Task DHHKOBNEGEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x2092470", Offset = "0x2090E70", VA = "0x182092470", Slot = "7")]
	private bool KMDLANKMHLD(MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, [In] OBKLBGPBJEH FDLIIFDHANB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x208F740", Offset = "0x208E140", VA = "0x18208F740", Slot = "13")]
	private IDNMHIFJHOJ BAPEBMEGLJM([In] DKFKDKPPDAA<BLDJADOAIME> OJMCAIBKDOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x2091A50", Offset = "0x2090450", VA = "0x182091A50", Slot = "14")]
	private MLGFJIHMDCD<BLDJADOAIME> NPPHHFOALKC([In] DKFKDKPPDAA<BLDJADOAIME> OJMCAIBKDOI)
	{
		return default(MLGFJIHMDCD<BLDJADOAIME>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x2090310", Offset = "0x208ED10", VA = "0x182090310", Slot = "15")]
	private MLGFJIHMDCD<BLDJADOAIME>? DJIOPMLPCOJ([In] DKFKDKPPDAA<BLDJADOAIME> OJMCAIBKDOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x2092150", Offset = "0x2090B50", VA = "0x182092150", Slot = "16")]
	private JINHCMKFECA JLJMGDGCMCJ([In] DKFKDKPPDAA<COGPDFLIJHB> ODLOJKBAHLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x20920D0", Offset = "0x2090AD0", VA = "0x1820920D0", Slot = "17")]
	private MLGFJIHMDCD<COGPDFLIJHB> JGNJNHOPEBE(MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, [In] DKFKDKPPDAA<COGPDFLIJHB> JCDANMIKACO)
	{
		return default(MLGFJIHMDCD<COGPDFLIJHB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x208FE40", Offset = "0x208E840", VA = "0x18208FE40", Slot = "22")]
	private IEnumerable<JINHCMKFECA> DCOGGOPDMIM([In] DKFKDKPPDAA<BLDJADOAIME> OJMCAIBKDOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x2090510", Offset = "0x208EF10", VA = "0x182090510", Slot = "29")]
	private KKDKPBHKNBH EFDHGLJKIAH(MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, [In] OBKLBGPBJEH FDLIIFDHANB)
	{
		return default(KKDKPBHKNBH);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x2090390", Offset = "0x208ED90", VA = "0x182090390", Slot = "35")]
	private MOKFKOEPKDB<FKLLFJIANML.PPHEEIEMDFG, HDCNBLKJONM> DLAMFLMDJHK([In] FKLLFJIANML.HEOPLLEFPLB EBIJIHILGPC)
	{
		return default(MOKFKOEPKDB<FKLLFJIANML.PPHEEIEMDFG, HDCNBLKJONM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x2092670", Offset = "0x2091070", VA = "0x182092670", Slot = "44")]
	private (List<OIDNNMMIODK>, bool) LDGKMMGBOND([In] CFCHGNBNAFA JFDAHOFJDLI, string GJGBLLHIOAC, [In] ONALFDNJHPD IDHADANDAME, PCJKPLCOFFP MHFNPKODAPB, JHOJEGLGEOH AJDDLAHFOHF)
	{
		return default((List<OIDNNMMIODK>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x2092760", Offset = "0x2091160", VA = "0x182092760")]
	[CompilerGenerated]
	private JINHCMKFECA LGHPBLLKFPL(GNMLBPFILMD PPNCECJAFNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x2090D40", Offset = "0x208F740", VA = "0x182090D40")]
	[CompilerGenerated]
	private BPAJMANMFPC ENCKBOFJPGF(MBJMJANGHJB PPNCECJAFNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x208FDD0", Offset = "0x208E7D0", VA = "0x18208FDD0")]
	[CompilerGenerated]
	private GNMLBPFILMD CNNDDGOOFCA(DKFKDKPPDAA<COGPDFLIJHB> PPNCECJAFNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x2090440", Offset = "0x208EE40", VA = "0x182090440")]
	[CompilerGenerated]
	private PDPODFCLEJG DLLMNNEEOEL(DKFKDKPPDAA<BLDJADOAIME> PPNCECJAFNC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class BPAJMANMFPC : LLBJEPOEBFC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private struct NCEOCKKCCCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<MLGFJIHMDCD<JCNBPBDCDNO>, JNDPMGELPNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public BPAJMANMFPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public DKFKDKPPDAA<BLDJADOAIME> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public DKFKDKPPDAA<COGPDFLIJHB> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public MLGFJIHMDCD<KGKGLKMKAOL> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private TaskAwaiter<MOKFKOEPKDB<MLGFJIHMDCD<JCNBPBDCDNO>, JNDPMGELPNI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x209C240", Offset = "0x209AC40", VA = "0x18209C240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x209C4C0", Offset = "0x209AEC0", VA = "0x18209C4C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct GOOPMCBBHEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<MLGFJIHMDCD<LKMKIJDBGPC>, JNDPMGELPNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public BPAJMANMFPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public DKFKDKPPDAA<BLDJADOAIME> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public DKFKDKPPDAA<COGPDFLIJHB> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public MLGFJIHMDCD<KGKGLKMKAOL> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private TaskAwaiter<MOKFKOEPKDB<MLGFJIHMDCD<LKMKIJDBGPC>, JNDPMGELPNI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x2099C30", Offset = "0x2098630", VA = "0x182099C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x2099EB0", Offset = "0x20988B0", VA = "0x182099EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	private readonly MBJMJANGHJB EFDIFHOKMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	private readonly PKCCJBPIFIB HEADFOLPJBA;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public TypeKey GEIDOMINOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x8F2EF0", Offset = "0x8F18F0", VA = "0x1808F2EF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public string KPBBIOHNMLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x2099100", Offset = "0x2097B00", VA = "0x182099100", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public MBJMJANGHJB CNEMCPCFCDA
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x2099410", Offset = "0x2097E10", VA = "0x182099410")]
	public BPAJMANMFPC(MBJMJANGHJB ANMHLKFDAEJ, PKCCJBPIFIB ANFLFKCPKCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x2099130", Offset = "0x2097B30", VA = "0x182099130", Slot = "6")]
	[AsyncStateMachine(typeof(NCEOCKKCCCB))]
	public Task<MOKFKOEPKDB<MLGFJIHMDCD<JCNBPBDCDNO>, JNDPMGELPNI>> NIDKBCHBIHL(DKFKDKPPDAA<BLDJADOAIME> OJMCAIBKDOI, DKFKDKPPDAA<COGPDFLIJHB> ODLOJKBAHLA, MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII, string HBOONHFLONJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x20992A0", Offset = "0x2097CA0", VA = "0x1820992A0", Slot = "7")]
	[AsyncStateMachine(typeof(GOOPMCBBHEJ))]
	public Task<MOKFKOEPKDB<MLGFJIHMDCD<LKMKIJDBGPC>, JNDPMGELPNI>> NMJJAFHCPAO(DKFKDKPPDAA<BLDJADOAIME> OJMCAIBKDOI, DKFKDKPPDAA<COGPDFLIJHB> ODLOJKBAHLA, MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII, string HBOONHFLONJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class MANCHNMLDAP : GEAPEOKANDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private readonly MBJMJANGHJB LOHBKDJBPLO;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private static readonly HashSet<MBJMJANGHJB> EBGKHPECAIM;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private static readonly HashSet<MBJMJANGHJB> IEHOHLIFOMG;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private static readonly HashSet<MBJMJANGHJB> KJLPGLGGCNL;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public TypeKey JDBNAJHLPPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x209C0D0", Offset = "0x209AAD0", VA = "0x18209C0D0", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool MCPNKNFEHFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x209C0C0", Offset = "0x209AAC0", VA = "0x18209C0C0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool COGHGBNKACP
	{
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x209C120", Offset = "0x209AB20", VA = "0x18209C120", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool DNMFCFAGACK
	{
		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x209C040", Offset = "0x209AA40", VA = "0x18209C040", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x209AB10", Offset = "0x2099510", VA = "0x18209AB10")]
	public bool KOMOPENKLIM(string CLMKDBDPNNH, [Out] BPBPADENKEG HIHPMDKMFAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x882870", Offset = "0x881270", VA = "0x180882870")]
	public MANCHNMLDAP(MBJMJANGHJB BMCAAIIMEIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x209AD80", Offset = "0x2099780", VA = "0x18209AD80")]
	internal static TypeKey PEBIBHFDFBK(MBJMJANGHJB NNCMOPPBEEE)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x2099100", Offset = "0x2097B00", VA = "0x182099100", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public readonly struct DIPFAMBLOCO : ANNAAHFLNJO.DKEFHINECGE<NFPABPCJAGA, IEPJDCHMGFO>
{
	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x2099750", Offset = "0x2098150", VA = "0x182099750", Slot = "4")]
	public int JGBFLPLHHLJ(IEPJDCHMGFO AHPMMDKKKFB, NFPABPCJAGA ENNGIICFMFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x2099700", Offset = "0x2098100", VA = "0x182099700", Slot = "5")]
	public NFPABPCJAGA CKBJJJGPPEO(IEPJDCHMGFO AHPMMDKKKFB, NFPABPCJAGA ENNGIICFMFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x20997B0", Offset = "0x20981B0", VA = "0x1820997B0", Slot = "6")]
	public NFPABPCJAGA PJPJEMIDHMD(IEPJDCHMGFO AHPMMDKKKFB, NFPABPCJAGA ENNGIICFMFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x2099790", Offset = "0x2098190", VA = "0x182099790", Slot = "7")]
	public IReadOnlyList<NFPABPCJAGA> PBNJLJHGIGN(IEPJDCHMGFO AHPMMDKKKFB, NFPABPCJAGA ENNGIICFMFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x2099690", Offset = "0x2098090", VA = "0x182099690", Slot = "8")]
	public NFPABPCJAGA[] AIBIMLDJALO(IEPJDCHMGFO AHPMMDKKKFB, NFPABPCJAGA ENNGIICFMFD, int LMJFDJEJKKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x2099770", Offset = "0x2098170", VA = "0x182099770", Slot = "9")]
	public bool LNFDJKKHEFH(IEPJDCHMGFO AHPMMDKKKFB, NFPABPCJAGA ENNGIICFMFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x20996C0", Offset = "0x20980C0", VA = "0x1820996C0", Slot = "10")]
	public bool BOLIHFNKIFL(IEPJDCHMGFO AHPMMDKKKFB, NFPABPCJAGA ENNGIICFMFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x20996E0", Offset = "0x20980E0", VA = "0x1820996E0", Slot = "11")]
	public bool BPAJHJBADAE(IEPJDCHMGFO AHPMMDKKKFB, NFPABPCJAGA ENNGIICFMFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x20996A0", Offset = "0x20980A0", VA = "0x1820996A0", Slot = "12")]
	public bool AJGJBFPEFBH(IEPJDCHMGFO AHPMMDKKKFB, NFPABPCJAGA ENNGIICFMFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x2099710", Offset = "0x2098110", VA = "0x182099710", Slot = "13")]
	public bool DBJAJEJAONM(IEPJDCHMGFO MECLDEDDNIH, NFPABPCJAGA ENNGIICFMFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x2099730", Offset = "0x2098130", VA = "0x182099730", Slot = "14")]
	public bool FLPCILMLGCE(IEPJDCHMGFO AHPMMDKKKFB, NFPABPCJAGA ENNGIICFMFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public abstract class JJDEDFMNPOK : FGJJJMLAIHN
{
	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public LFJFEJENMAL.LAFIJMAPJJK ALFOLJLEKMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x2099F20", Offset = "0x2098920", VA = "0x182099F20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public abstract JABOMEANPDH.OHKBAAKBJKG DBLCJLJPDJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public abstract DBKFEBENKEL.PBFANLMFFHJ KGAIHLCPKIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public abstract KGBHMHDIMKJ.MAHPLEDMLMD GALMEBLKBEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public EINFKNJDJCL.AKGGBJEONCP<NHMLEAIPHKC, NFPABPCJAGA, DBKFEBENKEL> DNIHNBMNJGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x2099F70", Offset = "0x2098970", VA = "0x182099F70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public abstract GGPBOBCBBBL HAGLPGOJPIM
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public abstract JKBJEGHLFGB OAAGBCECAOK
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public abstract KKJMEFJPJNE MONEBCMICAC
	{
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public abstract JBACPDMAHMM OCJLAIAMCHG
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public abstract HMFKENPLIJJ HJNDFLPCOEB
	{
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	protected JJDEDFMNPOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class PNFEBGJJNKD : DLDHJHIFOIH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct LPHCMLMIBMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<object, JNDPMGELPNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public PNFEBGJJNKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public NFPABPCJAGA action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private TaskAwaiter<MOKFKOEPKDB<object, JNDPMGELPNI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x209A800", Offset = "0x2099200", VA = "0x18209A800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x209AAA0", Offset = "0x20994A0", VA = "0x18209AAA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct GBDFPHKBCBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<ACBJJNFNOGH, JNDPMGELPNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public PNFEBGJJNKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public IReadOnlyList<NFPABPCJAGA> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private TaskAwaiter<MOKFKOEPKDB<object, JNDPMGELPNI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x20997E0", Offset = "0x20981E0", VA = "0x1820997E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x2099B60", Offset = "0x2098560", VA = "0x182099B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	private readonly KOFEPIBJAEI IJPEOKKLOFJ;

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x882870", Offset = "0x881270", VA = "0x180882870")]
	public PNFEBGJJNKD(KOFEPIBJAEI JKKBNDHDINA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x209C660", Offset = "0x209B060", VA = "0x18209C660")]
	[AsyncStateMachine(typeof(LPHCMLMIBMD))]
	private Task<MOKFKOEPKDB<object, JNDPMGELPNI>> NIHHGHLONIE(NFPABPCJAGA ENNGIICFMFD, bool PCMIMGJBICJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x209C530", Offset = "0x209AF30", VA = "0x18209C530", Slot = "4")]
	[AsyncStateMachine(typeof(GBDFPHKBCBI))]
	public Task<MOKFKOEPKDB<ACBJJNFNOGH, JNDPMGELPNI>> HOHJHLFBIOH(IReadOnlyList<NFPABPCJAGA> IKJNEEELGKE, bool PCMIMGJBICJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public struct GEPNOKDIMAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	internal EPHCHAFCMJN<AHKOCGAJLIM, NFPABPCJAGA, DHAPMEEADOP> LOHBKDJBPLO;

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x20679B0", Offset = "0x20663B0", VA = "0x1820679B0")]
	private GEPNOKDIMAF([In] EPHCHAFCMJN<AHKOCGAJLIM, NFPABPCJAGA, DHAPMEEADOP> FNCOFPIIDJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x2099BD0", Offset = "0x20985D0", VA = "0x182099BD0")]
	public static GEPNOKDIMAF MMKGNMBHOIH()
	{
		return default(GEPNOKDIMAF);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public static class MPHFFJNDONA
{
	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0xA34E90", Offset = "0xA33890", VA = "0x180A34E90")]
	public static EPHCHAFCMJN<AHKOCGAJLIM, NFPABPCJAGA, DHAPMEEADOP> KEGDHAIEAFL(this GEPNOKDIMAF PECHDAFMNOO)
	{
		return default(EPHCHAFCMJN<AHKOCGAJLIM, NFPABPCJAGA, DHAPMEEADOP>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public struct DHAPMEEADOP : GBFHIILLPPM.FHNGFMAJJPP<AHKOCGAJLIM, NFPABPCJAGA>
{
	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x20994B0", Offset = "0x2097EB0", VA = "0x1820994B0", Slot = "5")]
	public NFPABPCJAGA BJAEMBONFCI(AHKOCGAJLIM[] OOKFMJBGDKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x17E4DC0", Offset = "0x17E37C0", VA = "0x1817E4DC0")]
	public int EHFFPDNMOAK([In] AHKOCGAJLIM PMGGDOBDIHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x17E4DC0", Offset = "0x17E37C0", VA = "0x1817E4DC0", Slot = "4")]
	private int ACLLGBOGGIO([In] AHKOCGAJLIM EAPHMCPHHID)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public struct JNKOJEMIDNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	internal BLDJLBDICJP<HDFPFIHLLBE, NFPABPCJAGA, ABDHEJDFKFD> LOHBKDJBPLO;

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x20679B0", Offset = "0x20663B0", VA = "0x1820679B0")]
	private JNKOJEMIDNA([In] BLDJLBDICJP<HDFPFIHLLBE, NFPABPCJAGA, ABDHEJDFKFD> IIMMPKIMMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x209A370", Offset = "0x2098D70", VA = "0x18209A370")]
	public static JNKOJEMIDNA MMKGNMBHOIH()
	{
		return default(JNKOJEMIDNA);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public static class BLHDNCGNCMN
{
	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0xA34E90", Offset = "0xA33890", VA = "0x180A34E90")]
	public static BLDJLBDICJP<HDFPFIHLLBE, NFPABPCJAGA, ABDHEJDFKFD> KEGDHAIEAFL(this JNKOJEMIDNA PECHDAFMNOO)
	{
		return default(BLDJLBDICJP<HDFPFIHLLBE, NFPABPCJAGA, ABDHEJDFKFD>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public struct ABDHEJDFKFD : ICPGHKDAIBI.CBBAIOAJAHJ<HDFPFIHLLBE, NFPABPCJAGA>
{
	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x17E4DC0", Offset = "0x17E37C0", VA = "0x1817E4DC0")]
	public int DKNOOLPMHNK([In] HDFPFIHLLBE PMGGDOBDIHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x2098610", Offset = "0x2097010", VA = "0x182098610", Slot = "5")]
	public NFPABPCJAGA DKBHDLBEJGD(HDFPFIHLLBE[] GGGGOKFIPCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x17E4DC0", Offset = "0x17E37C0", VA = "0x1817E4DC0", Slot = "4")]
	private int ABEMJKODMGI([In] HDFPFIHLLBE PMGGDOBDIHE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public class KPPFAPJHIAA : IPGCPDAOJFL, HDCNBLKJONM, JNDPMGELPNI, NLHAIFJDFEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private readonly NLHAIFJDFEL? OLIJEBEFGHG;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public CBCDHCFHELM DHMOHOICOCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x889410", Offset = "0x887E10", VA = "0x180889410", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(CBCDHCFHELM);
		}
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x889400", Offset = "0x887E00", VA = "0x180889400")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public override NLHAIFJDFEL? NBJBNIHJPCP
	{
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x8869A0", Offset = "0x8853A0", VA = "0x1808869A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x209A640", Offset = "0x2099040", VA = "0x18209A640", Slot = "7")]
	public override string PDDPMMJGDDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x209A7C0", Offset = "0x20991C0", VA = "0x18209A7C0")]
	private KPPFAPJHIAA(CBCDHCFHELM OIKBGDLAKHG, NLHAIFJDFEL? LKJEELEDJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x209A4E0", Offset = "0x2098EE0", VA = "0x18209A4E0")]
	public static KPPFAPJHIAA JBDDEIALKJE(NLHAIFJDFEL LKJEELEDJEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x209A5D0", Offset = "0x2098FD0", VA = "0x18209A5D0")]
	public static KPPFAPJHIAA OLKDLBIFEAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x209A560", Offset = "0x2098F60", VA = "0x18209A560")]
	public static KPPFAPJHIAA JDMCPLOCKNN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class HFKMOLCANIB
{
	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x2C96170", Offset = "0x2C94B70", VA = "0x182C96170")]
	public static MOKFKOEPKDB<TOk, HDCNBLKJONM> MBCFKJBGMHD<TOk>([In] this MOKFKOEPKDB<TOk, HDCNBLKJONM> PECHDAFMNOO, NLHAIFJDFEL LKJEELEDJEF) where TOk : notnull
	{
		return default(MOKFKOEPKDB<TOk, HDCNBLKJONM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x2C96070", Offset = "0x2C94A70", VA = "0x182C96070")]
	public static MOKFKOEPKDB<TOk?, HDCNBLKJONM?> ECLJKAELJKN<TOk>([In] this MOKFKOEPKDB<TOk, HDCNBLKJONM> PECHDAFMNOO)
	{
		return default(MOKFKOEPKDB<TOk, HDCNBLKJONM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x2C96260", Offset = "0x2C94C60", VA = "0x182C96260")]
	public static MOKFKOEPKDB<TOk?, HDCNBLKJONM?> PFFGICAMCPD<TOk>([In] this MOKFKOEPKDB<TOk, HDCNBLKJONM> PECHDAFMNOO)
	{
		return default(MOKFKOEPKDB<TOk, HDCNBLKJONM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public interface GGPBOBCBBBL
{
	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DEJMAAGBLPE([In] MOKFKOEPKDB<IEPJDCHMGFO, NLHAIFJDFEL> DFEFBOIIPKP);
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public static class PJNENJPHGNN
{
	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x2E4CDB0", Offset = "0x2E4B7B0", VA = "0x182E4CDB0")]
	public static bool DEJMAAGBLPE<TOk, TErr>(this GGPBOBCBBBL PECHDAFMNOO, [In] MOKFKOEPKDB<TOk, TErr> DFEFBOIIPKP) where TOk : notnull where TErr : notnull, NLHAIFJDFEL
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public interface JKBJEGHLFGB
{
	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	FGBLACBKADK PDNMMHJIOBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public interface KKJMEFJPJNE
{
	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GICBDAJODOB HFOLKGOLIMP(int FMHFHPFEEOH);
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public interface NHEKBDPOHND
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	string IAIAEPAKLMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public interface ANIGOBCBNHN
{
	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MNJFMADAKPN? IOLGIBLNOHP(MLGFJIHMDCD<KGKGLKMKAOL> PJAEGAAFNII);
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public interface FKLLIDMJMFL
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	string IAIAEPAKLMP
	{
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public interface MNJFMADAKPN
{
	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	string IAIAEPAKLMP
	{
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FKLLIDMJMFL? GNDLHDLNODI(MLGFJIHMDCD<JCNBPBDCDNO> CNBEFMBNOMD);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NHEKBDPOHND? GNMNMBPCHJD(MLGFJIHMDCD<LKMKIJDBGPC> GJDKPLIDILM);
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public interface JBACPDMAHMM
{
	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> BCMNDBFBLKL(string CLMKDBDPNNH, string GJGBLLHIOAC);
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public interface HMFKENPLIJJ
{
	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ANIGOBCBNHN? OLOBOCFCPBC([In] DKFKDKPPDAA<CJEPNLHNKAI> OOKDOMDIEOG);
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class ALAFAIAICCO
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	private struct JPIKHBJEBCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public int MOMFAOPBBMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public LOOBEJOIHCO? HGCLELGNAFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public LOOBEJOIHCO? DCHMIPKMDJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public readonly List<NFPABPCJAGA> AJNMDAHOMCJ;

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x209A490", Offset = "0x2098E90", VA = "0x18209A490")]
		private JPIKHBJEBCN(int EBDDHAPIAHH, LOOBEJOIHCO? GAKBGDPGIPK, LOOBEJOIHCO? NHDJIHCDDAG, List<NFPABPCJAGA> IKJNEEELGKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x209A3D0", Offset = "0x2098DD0", VA = "0x18209A3D0")]
		public static JPIKHBJEBCN MMKGNMBHOIH()
		{
			return default(JPIKHBJEBCN);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private readonly HCHONMDAAAH<JPIKHBJEBCN> OFOIGAPJBCA;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public static ALAFAIAICCO LPENGNKGBMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x20988B0", Offset = "0x20972B0", VA = "0x1820988B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool PIAMOIAAMGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F70D0", VA = "0x1809F86D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0xB6A7A0", Offset = "0xB691A0", VA = "0x180B6A7A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x20987F0", Offset = "0x20971F0", VA = "0x1820987F0")]
	public void DAAGHALLMOM(LENGACKPANN NHDJIHCDDAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x2098C60", Offset = "0x2097660", VA = "0x182098C60")]
	public void PDLDHLDEFOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x2098900", Offset = "0x2097300", VA = "0x182098900")]
	private static string? JNBHOKCFJON([In] JPIKHBJEBCN KNLIAJIENMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x2099050", Offset = "0x2097A50", VA = "0x182099050")]
	public ALAFAIAICCO()
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
