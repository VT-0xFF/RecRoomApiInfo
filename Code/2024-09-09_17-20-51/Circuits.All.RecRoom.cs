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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x20FD3F0", Offset = "0x20FBDF0", VA = "0x1820FD3F0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
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
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class GMEBKHPMCKK : IDisposable, EFNNNNKBIGG, NCLIGNLNHNG, LLCMAEHNHBI, OEPAEDBCGMP
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class LPIAHLLEFOE : JPBDFPOHFFK
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int PFOPPAPLJOG
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x20FBE00", Offset = "0x20FA800", VA = "0x1820FBE00", Slot = "5")]
		public LJNMGFEFBDE BBGNGIHDPEN(KPNHMONLLAE.FJNFJIILGJL HBFCALFCDLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void HIEKDBCKPJO();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void JFJJIPOAIPJ();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x20FBF50", Offset = "0x20FA950", VA = "0x1820FBF50", Slot = "13")]
		public virtual void JKGALBKMEDM(GMEBKHPMCKK EDAFBGDMGIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x20FBF90", Offset = "0x20FA990", VA = "0x1820FBF90", Slot = "14")]
		public virtual void PIFIKLBEDIP(GMEBKHPMCKK EDAFBGDMGIM, ONPEDCCMFKN GGEEGOKOMKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		protected LPIAHLLEFOE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface JPBDFPOHFFK
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int PFOPPAPLJOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		LJNMGFEFBDE BBGNGIHDPEN(KPNHMONLLAE.FJNFJIILGJL HBFCALFCDLO);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void HIEKDBCKPJO();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JFJJIPOAIPJ();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void JKGALBKMEDM(GMEBKHPMCKK EDAFBGDMGIM);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void PIFIKLBEDIP(GMEBKHPMCKK EDAFBGDMGIM, ONPEDCCMFKN GGEEGOKOMKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct MGBEKKEILLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly EDODEPLDHJM<GDONOGCEMNE, ONPEDCCMFKN, GMEBKHPMCKK, DAPKHMLEODH.HCJIIBBHIBA<GDONOGCEMNE, ONPEDCCMFKN, GMEBKHPMCKK>> CIALMPKLFAP;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x20FC6C0", Offset = "0x20FB0C0", VA = "0x1820FC6C0")]
		internal MGBEKKEILLL(EDODEPLDHJM<GDONOGCEMNE, ONPEDCCMFKN, GMEBKHPMCKK, DAPKHMLEODH.HCJIIBBHIBA<GDONOGCEMNE, ONPEDCCMFKN, GMEBKHPMCKK>> KCEPABIAINB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class MMCLPKOLLNC : DAPKHMLEODH.HCJIIBBHIBA<GDONOGCEMNE, ONPEDCCMFKN, GMEBKHPMCKK>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly MMCLPKOLLNC GHBFIIGNNDE;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		private MMCLPKOLLNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1274CE0", Offset = "0x12736E0", VA = "0x181274CE0", Slot = "4")]
		public GDONOGCEMNE KJGAFLNMMEF(ONPEDCCMFKN NKCEKILMAAM)
		{
			return default(GDONOGCEMNE);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x20FCC90", Offset = "0x20FB690", VA = "0x1820FCC90", Slot = "5")]
		public void JKGALBKMEDM(GMEBKHPMCKK BAFHJDFHJHD, ONPEDCCMFKN GGEEGOKOMKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x20FCD90", Offset = "0x20FB790", VA = "0x1820FCD90", Slot = "6")]
		public void PIFIKLBEDIP(GMEBKHPMCKK BAFHJDFHJHD, ONPEDCCMFKN GGEEGOKOMKJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct CBNBMIMOBMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public JMCKBGJHBBD<GDONOGCEMNE, ONPEDCCMFKN, GMEBKHPMCKK, DAPKHMLEODH.HCJIIBBHIBA<GDONOGCEMNE, ONPEDCCMFKN, GMEBKHPMCKK>> CIALMPKLFAP;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x20F13A0", Offset = "0x20EFDA0", VA = "0x1820F13A0")]
		internal CBNBMIMOBMH(JMCKBGJHBBD<GDONOGCEMNE, ONPEDCCMFKN, GMEBKHPMCKK, DAPKHMLEODH.HCJIIBBHIBA<GDONOGCEMNE, ONPEDCCMFKN, GMEBKHPMCKK>> KCEPABIAINB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x20F1350", Offset = "0x20EFD50", VA = "0x1820F1350")]
		public static CBNBMIMOBMH OOAFHJGKFEK()
		{
			return default(CBNBMIMOBMH);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct OBCDELNANAP : PNEKFBGJCCL.LDOMONGBNEC<ONPEDCCMFKN, GMEBKHPMCKK>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct PBBCOIKKONF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<CDOLGFBAJII<object, IDHCEFLHBPO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public GMEBKHPMCKK receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ONPEDCCMFKN action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public OBCDELNANAP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<CDOLGFBAJII<object, IDHCEFLHBPO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x20FDD80", Offset = "0x20FC780", VA = "0x1820FDD80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x20FDF60", Offset = "0x20FC960", VA = "0x1820FDF60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x985810", Offset = "0x984210", VA = "0x180985810", Slot = "4")]
		public OPGJAFEOJCM<POCJNEBPFKP> JBBGMPMFMJK(GMEBKHPMCKK KEFFHAHOJNE)
		{
			return default(OPGJAFEOJCM<POCJNEBPFKP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x20FD470", Offset = "0x20FBE70", VA = "0x1820FD470", Slot = "5")]
		[AsyncStateMachine(typeof(PBBCOIKKONF))]
		public Task<CDOLGFBAJII<object, IDHCEFLHBPO>> JBACHCPNJLB(GMEBKHPMCKK KEFFHAHOJNE, ONPEDCCMFKN GGEEGOKOMKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x20FD5A0", Offset = "0x20FBFA0", VA = "0x1820FD5A0", Slot = "6")]
		public ONPEDCCMFKN[] LHOHJDNGINO(GMEBKHPMCKK KEFFHAHOJNE)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct HBGJCGEJNLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<bool, IDHCEFLHBPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public GMEBKHPMCKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public AOFBLOPPMID rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public JEEOGCMCDDH circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public GHGEAPMBJNK superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<CDOLGFBAJII<bool, IDHCEFLHBPO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x20F65D0", Offset = "0x20F4FD0", VA = "0x1820F65D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x20F6850", Offset = "0x20F5250", VA = "0x1820F6850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct BFCMOHOBAPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<bool, IDHCEFLHBPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public GMEBKHPMCKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<CDOLGFBAJII<bool, IDHCEFLHBPO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x20ED0F0", Offset = "0x20EBAF0", VA = "0x1820ED0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x20ED380", Offset = "0x20EBD80", VA = "0x1820ED380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct LGAFLHALCMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public GMEBKHPMCKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x20FB380", Offset = "0x20F9D80", VA = "0x1820FB380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x20FB560", Offset = "0x20F9F60", VA = "0x1820FB560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct EIIFFNAEMGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<object, IDHCEFLHBPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public GMEBKHPMCKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public ONPEDCCMFKN action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<CDOLGFBAJII<object, IDHCEFLHBPO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x20F3390", Offset = "0x20F1D90", VA = "0x1820F3390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x20F3580", Offset = "0x20F1F80", VA = "0x1820F3580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct CDHHKFOKJKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public GMEBKHPMCKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<CDOLGFBAJII<bool, IDHCEFLHBPO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x20F13B0", Offset = "0x20EFDB0", VA = "0x1820F13B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x20F1BB0", Offset = "0x20F05B0", VA = "0x1820F1BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly OPGJAFEOJCM<POCJNEBPFKP> EOGPOCOOHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly MGBEKKEILLL HFIGCLNIHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly COIDJEHDBNF IMAGAOFJAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly INNDKAJKODB LFBAMEHOLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1930")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly GBEIBNGLACM NEGNKNJNNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1938")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly LFOCNAGFDKF.FNEABHNBJPE OONDDIFPNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1958")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly JNPAGNDLNLG ONGJIOGHBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1960")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly JMKHPDKENOB PONKMMDJFIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1968")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly LCPKMGHEDPI OGIHMOJMNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1970")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly HFGOLDDEIJH CONALMIENDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1978")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private KBMCEGEMGLH KAFOPDGBDPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1988")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private BEEDCPAFGOD LDAKKBJAEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19A8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly COIDJEHDBNF.EINKENCKLMJ PCAKBLKJFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19B0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly CBLIJNFJOJM IADHFMOHFNE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public COIDJEHDBNF OGFOAIMKBAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x20F4D00", Offset = "0x20F3700", VA = "0x1820F4D00")]
		get
		{
			return default(COIDJEHDBNF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal JPBDFPOHFFK BKJIDJOLKMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x20F51A0", Offset = "0x20F3BA0", VA = "0x1820F51A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal LJNMGFEFBDE EGHCLNHCBIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x20F57A0", Offset = "0x20F41A0", VA = "0x1820F57A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x20F4C60", Offset = "0x20F3660", VA = "0x1820F4C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool LJKCINAHMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x20F52E0", Offset = "0x20F3CE0", VA = "0x1820F52E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x20F5190", Offset = "0x20F3B90", VA = "0x1820F5190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public KLJIIPKLDCC MPAHBDLDICJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x20F62F0", Offset = "0x20F4CF0", VA = "0x1820F62F0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public EGGGBLOFHJH FAJBEBIDBEL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x20F6300", Offset = "0x20F4D00", VA = "0x1820F6300", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public BJILIBHIONC DCANFAKJIMN
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x20F6320", Offset = "0x20F4D20", VA = "0x1820F6320", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public HBAOCEPIKMJ PMMMLOEMJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x20F6310", Offset = "0x20F4D10", VA = "0x1820F6310", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public LFOCNAGFDKF? HCAMAEAOKKI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x20F4C80", Offset = "0x20F3680", VA = "0x1820F4C80", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private JHMFKMNAMLF? OEDJHACJOCM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x20F5820", Offset = "0x20F4220", VA = "0x1820F5820", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x20F5FF0", Offset = "0x20F49F0", VA = "0x1820F5FF0")]
	private GMEBKHPMCKK(GBEIBNGLACM FGHAHIFNFEN, OPGJAFEOJCM<POCJNEBPFKP> EKEAKMCADMP, [In] MGBEKKEILLL JDKLMOMCNPO, [In] COIDJEHDBNF KHENLBEFCFA, [In] INNDKAJKODB CNPCOKMJKPM, LJNMGFEFBDE PDIDAIJMDNI, [In] LFOCNAGFDKF.FNEABHNBJPE EGNHJJEKHEA, COIDJEHDBNF.EINKENCKLMJ KAGHBIFLJGB, CBLIJNFJOJM HNOMAGGBOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x20F5E30", Offset = "0x20F4830", VA = "0x1820F5E30")]
	public static GMEBKHPMCKK OOAFHJGKFEK(GBEIBNGLACM HBFCALFCDLO, [In] NFNHMAIBLLI MCJPMEFEBCC, POKHIIMHMNI HKGNKBPHHOG, [In] OHGOKGMOMMO FHJPIHECAGB, OHIAHHDNCLE LCJFFFKBJNG, OPGJAFEOJCM<POCJNEBPFKP> EKEAKMCADMP, OPGJAFEOJCM<OJMNDACGHHH> DEKOAEAMKCH, AIKPEKKPPBH KDFJJDIBBPP, FHPALJILLKN OPAOOBGIKPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x20F5B50", Offset = "0x20F4550", VA = "0x1820F5B50")]
	public static GMEBKHPMCKK OOAFHJGKFEK(GBEIBNGLACM FGHAHIFNFEN, [In] COIDJEHDBNF KHENLBEFCFA, [In] INNDKAJKODB CNPCOKMJKPM, OPGJAFEOJCM<POCJNEBPFKP> EKEAKMCADMP, OPGJAFEOJCM<OJMNDACGHHH> DEKOAEAMKCH, AIKPEKKPPBH KDFJJDIBBPP, FHPALJILLKN OPAOOBGIKPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x20F4D10", Offset = "0x20F3710", VA = "0x1820F4D10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x20F4B00", Offset = "0x20F3500", VA = "0x1820F4B00")]
	[AsyncStateMachine(typeof(HBGJCGEJNLP))]
	internal Task<CDOLGFBAJII<bool, IDHCEFLHBPO>> ABFMHPBABEF(AOFBLOPPMID JEEJGNKFMDN, JEEOGCMCDDH KGELNLDDLAB, GHGEAPMBJNK IPPFHGIBMOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x20F51F0", Offset = "0x20F3BF0", VA = "0x1820F51F0")]
	[AsyncStateMachine(typeof(BFCMOHOBAPC))]
	public Task<CDOLGFBAJII<bool, IDHCEFLHBPO>> KBLANFDALIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x20F5A60", Offset = "0x20F4460", VA = "0x1820F5A60")]
	[AsyncStateMachine(typeof(LGAFLHALCMG))]
	public Task<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> OMHILDLGKLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x20F4F00", Offset = "0x20F3900", VA = "0x1820F4F00")]
	internal void EMMIBHJKIFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x20F5110", Offset = "0x20F3B10", VA = "0x1820F5110")]
	internal CPOGLEEFNCN<ONPEDCCMFKN> FEHJKALCLLA([In] NFJDODEFJPE ICIMLJKCLEJ)
	{
		return default(CPOGLEEFNCN<ONPEDCCMFKN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x20F57B0", Offset = "0x20F41B0", VA = "0x1820F57B0")]
	internal bool MNJMJFAKNEM([In] NFJDODEFJPE ICIMLJKCLEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x20F5F70", Offset = "0x20F4970", VA = "0x1820F5F70")]
	internal CPOGLEEFNCN<ONPEDCCMFKN> PLOABLOJAHL([In] PKEFCEJJNDJ FPHHMLECOLM)
	{
		return default(CPOGLEEFNCN<ONPEDCCMFKN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x20F5950", Offset = "0x20F4350", VA = "0x1820F5950")]
	[AsyncStateMachine(typeof(EIIFFNAEMGA))]
	internal Task<CDOLGFBAJII<object, IDHCEFLHBPO>> OJMMCJIHMML(ONPEDCCMFKN GGEEGOKOMKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x20F5410", Offset = "0x20F3E10", VA = "0x1820F5410")]
	private ONPEDCCMFKN[] LHOHJDNGINO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x20F52F0", Offset = "0x20F3CF0", VA = "0x1820F52F0")]
	[AsyncStateMachine(typeof(CDHHKFOKJKK))]
	public Task<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> KHKFDIFIHHL(Guid AFEKGINPPPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class OIABDHPBPHN
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2F01F10", Offset = "0x2F00910", VA = "0x182F01F10")]
	public static KNOGBKNKKCK<(TPrev?, GMEBKHPMCKK?), JHMFKMNAMLF> KEAAFEAAPHJ<TPrev>([In] this KNOGBKNKKCK<TPrev, GMEBKHPMCKK> NKCEKILMAAM)
	{
		return default(KNOGBKNKKCK<(TPrev, GMEBKHPMCKK), JHMFKMNAMLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2F021D0", Offset = "0x2F00BD0", VA = "0x182F021D0")]
	public static KNOGBKNKKCK<TPrev?, GMEBKHPMCKK?> POIOPGDKFKM<TPrev>([In] this KNOGBKNKKCK<TPrev, GMEBKHPMCKK> NKCEKILMAAM)
	{
		return default(KNOGBKNKKCK<TPrev, GMEBKHPMCKK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class KNOFMKNDDLN<TData> : PKNKGFKCKHA, AFIACLEPAHL, NEIFONLMJBM where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly GBPONPDANLH<BOAKMKENONJ>? BLMIACFPLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly string LCPAEDDGIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly TData EIPGALGMOJD;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public GBPONPDANLH<BOAKMKENONJ>? LDEPBBNIFFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x232A2C0", Offset = "0x2328CC0", VA = "0x18232A2C0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x889090", Offset = "0x887A90", VA = "0x180889090", Slot = "7")]
	public override string OIFECEDJIAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x43E8FC0", Offset = "0x43E79C0", VA = "0x1843E8FC0")]
	internal KNOFMKNDDLN([In] GBPONPDANLH<BOAKMKENONJ>? IGMBHLDAMOF, OPGJAFEOJCM<KGPCIMGKNIP>? OIANBBKHCCH, IOKind? LGGNJEDNFNF, string BBDGOIMNDJI, [In] TData LNCKNHNHHDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class POMMBMHAKKO
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2109990", Offset = "0x2108390", VA = "0x182109990")]
	public static CDOLGFBAJII<OJMILIDCABE, AFIACLEPAHL> NMICDKOOCME([In] this MNJLGDBAFOC<KMBMIEKACIK> GDNJILNIADC)
	{
		return default(CDOLGFBAJII<OJMILIDCABE, AFIACLEPAHL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2F1B350", Offset = "0x2F19D50", VA = "0x182F1B350")]
	public static CDOLGFBAJII<TOk, AFIACLEPAHL> FDJOLFNDJEH<TOk>([In] this CDOLGFBAJII<TOk, AFIACLEPAHL> NKCEKILMAAM, [In] GBPONPDANLH<BOAKMKENONJ>? IGMBHLDAMOF, OPGJAFEOJCM<KGPCIMGKNIP>? OIANBBKHCCH, IOKind? LGGNJEDNFNF, string BBDGOIMNDJI) where TOk : notnull
	{
		return default(CDOLGFBAJII<TOk, AFIACLEPAHL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface GBEIBNGLACM
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	FAKPMAHIMHF.MLPHOBLLFGD BHLHAPBHMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	KPNHMONLLAE.FJNFJIILGJL NPPMEEOBIME
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	GMEBKHPMCKK.JPBDFPOHFFK MEGOFBJHICJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	IBLIGLOHNNH.PPLIKKPEOIF NCCELMBLIPH
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DAPKHMLEODH.HCJIIBBHIBA<GDONOGCEMNE, ONPEDCCMFKN, GMEBKHPMCKK> FAPEJMHOIKN
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	NMFMPDHEBKA JGKJMDKJKKC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	LHDHOLENDNO DCLIABFDPCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	LNCHKHJNHBM HBBKOEOKAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	FKNCPEAGLOC BCPMKIDDGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	HFJBFBNHNDM DDADIMGBAEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class FFKFJNJODEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x20F49F0", Offset = "0x20F33F0", VA = "0x1820F49F0")]
	public static ONPEDCCMFKN MFIBKEGIBAC(this ONPEDCCMFKN NKCEKILMAAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x20F4920", Offset = "0x20F3320", VA = "0x1820F4920")]
	public static ONPEDCCMFKN IGICMHEPHHH(this DCAEHFGCCOD NKCEKILMAAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct DCAEHFGCCOD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct LNGKMIILIGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<object, IDHCEFLHBPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public GMEBKHPMCKK root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public DCAEHFGCCOD self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<CDOLGFBAJII<object, IDHCEFLHBPO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x20FBAD0", Offset = "0x20FA4D0", VA = "0x1820FBAD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x20FBD90", Offset = "0x20FA790", VA = "0x1820FBD90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly ByteString ADJCIFCGLHC;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xB63000", Offset = "0xB61A00", VA = "0x180B63000")]
	private DCAEHFGCCOD(ByteString IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x20F2270", Offset = "0x20F0C70", VA = "0x1820F2270")]
	public static ONPEDCCMFKN CJEGFEPCLMN(ByteString IPHMAHBENGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x20F2330", Offset = "0x20F0D30", VA = "0x1820F2330")]
	public static BJDDGKIBOMA<GDONOGCEMNE, DCAEHFGCCOD> KCBOCCOLDJK(ONPEDCCMFKN CLFFAPGBPPK)
	{
		return default(BJDDGKIBOMA<GDONOGCEMNE, DCAEHFGCCOD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x20F23E0", Offset = "0x20F0DE0", VA = "0x1820F23E0")]
	[AsyncStateMachine(typeof(LNGKMIILIGG))]
	public static Task<CDOLGFBAJII<object, IDHCEFLHBPO>> OJMMCJIHMML(GMEBKHPMCKK BAFHJDFHJHD, DCAEHFGCCOD NKCEKILMAAM)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct IKKEDPIIKLJ
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x20F7010", Offset = "0x20F5A10", VA = "0x1820F7010")]
	public static ONPEDCCMFKN CJEGFEPCLMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x20F70B0", Offset = "0x20F5AB0", VA = "0x1820F70B0")]
	public static BJDDGKIBOMA<GDONOGCEMNE, IKKEDPIIKLJ> KCBOCCOLDJK(ONPEDCCMFKN CLFFAPGBPPK)
	{
		return default(BJDDGKIBOMA<GDONOGCEMNE, IKKEDPIIKLJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x20F7120", Offset = "0x20F5B20", VA = "0x1820F7120")]
	public static CDOLGFBAJII<AJBBHDJGBPP, ILCEMBFLKNK> NGKMHBIDPIH(GMEBKHPMCKK BAFHJDFHJHD, [In] IKKEDPIIKLJ NKCEKILMAAM)
	{
		return default(CDOLGFBAJII<AJBBHDJGBPP, ILCEMBFLKNK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct BIAALGMOHJD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct FCAAAGAMEEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<AJBBHDJGBPP, ILCEMBFLKNK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public GMEBKHPMCKK root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public BIAALGMOHJD self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private CDOLGFBAJII<AJBBHDJGBPP, ILCEMBFLKNK> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x20F43E0", Offset = "0x20F2DE0", VA = "0x1820F43E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x20F4750", Offset = "0x20F3150", VA = "0x1820F4750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly AOFBLOPPMID? NOOPEEOKGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly JEEOGCMCDDH? APFNGJCFGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly GHGEAPMBJNK? APNLBHFNCBH;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2027E50", Offset = "0x2026850", VA = "0x182027E50")]
	private BIAALGMOHJD(AOFBLOPPMID? JEEJGNKFMDN, JEEOGCMCDDH? KGELNLDDLAB, GHGEAPMBJNK? IPPFHGIBMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x20F0A70", Offset = "0x20EF470", VA = "0x1820F0A70")]
	public static ONPEDCCMFKN? CJEGFEPCLMN(AOFBLOPPMID? JEEJGNKFMDN, JEEOGCMCDDH? KGELNLDDLAB, GHGEAPMBJNK? IPPFHGIBMOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x20F0B70", Offset = "0x20EF570", VA = "0x1820F0B70")]
	public static BJDDGKIBOMA<GDONOGCEMNE, BIAALGMOHJD> KCBOCCOLDJK(ONPEDCCMFKN CLFFAPGBPPK)
	{
		return default(BJDDGKIBOMA<GDONOGCEMNE, BIAALGMOHJD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x20F0C80", Offset = "0x20EF680", VA = "0x1820F0C80")]
	[AsyncStateMachine(typeof(FCAAAGAMEEA))]
	public static Task<CDOLGFBAJII<AJBBHDJGBPP, ILCEMBFLKNK>> OJMMCJIHMML(GMEBKHPMCKK BAFHJDFHJHD, BIAALGMOHJD NKCEKILMAAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct LICDFKKLPKM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct PLMPAHNIOLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<DNFFJMPIELO, IDHCEFLHBPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public LICDFKKLPKM self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public GMEBKHPMCKK root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private CDOLGFBAJII<DNFFJMPIELO, IDHCEFLHBPO> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private CDOLGFBAJII<object, NEIFONLMJBM>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private CDOLGFBAJII<object, NEIFONLMJBM> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private CDOLGFBAJII<object, NEIFONLMJBM>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<CDOLGFBAJII<object, IDHCEFLHBPO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x21093F0", Offset = "0x2107DF0", VA = "0x1821093F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2109850", Offset = "0x2108250", VA = "0x182109850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IReadOnlyList<ONPEDCCMFKN> EIPKICMIHGD;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xB63000", Offset = "0xB61A00", VA = "0x180B63000")]
	private LICDFKKLPKM(IReadOnlyList<ONPEDCCMFKN> HENJBBKOCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x20FB5D0", Offset = "0x20F9FD0", VA = "0x1820FB5D0")]
	public static ONPEDCCMFKN CJEGFEPCLMN(IReadOnlyList<ONPEDCCMFKN> HENJBBKOCMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x20FB690", Offset = "0x20FA090", VA = "0x1820FB690")]
	public static BJDDGKIBOMA<GDONOGCEMNE, LICDFKKLPKM> KCBOCCOLDJK(ONPEDCCMFKN CLFFAPGBPPK)
	{
		return default(BJDDGKIBOMA<GDONOGCEMNE, LICDFKKLPKM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x20FB730", Offset = "0x20FA130", VA = "0x1820FB730")]
	[AsyncStateMachine(typeof(PLMPAHNIOLE))]
	public static Task<CDOLGFBAJII<DNFFJMPIELO, IDHCEFLHBPO>> OJMMCJIHMML(GMEBKHPMCKK BAFHJDFHJHD, LICDFKKLPKM NKCEKILMAAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct PKEFCEJJNDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly int LEDCMOMLPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int BDIPFIAMOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly byte[] EIPGALGMOJD;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1E3F180", Offset = "0x1E3DB80", VA = "0x181E3F180")]
	private PKEFCEJJNDJ(int CMNDBGDABDM, int ENMILGHAHOM, byte[] LNCKNHNHHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2108FE0", Offset = "0x21079E0", VA = "0x182108FE0")]
	public static ONPEDCCMFKN CJEGFEPCLMN(int CMNDBGDABDM, int ENMILGHAHOM, ByteString LNCKNHNHHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x21090C0", Offset = "0x2107AC0", VA = "0x1821090C0")]
	public static ONPEDCCMFKN[] JGBJJOOPBKB(ONPEDCCMFKN GGEEGOKOMKJ, int HPAFBMIDAIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x21091F0", Offset = "0x2107BF0", VA = "0x1821091F0")]
	public static BJDDGKIBOMA<GDONOGCEMNE, PKEFCEJJNDJ> KCBOCCOLDJK(ONPEDCCMFKN CLFFAPGBPPK)
	{
		return default(BJDDGKIBOMA<GDONOGCEMNE, PKEFCEJJNDJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x21092D0", Offset = "0x2107CD0", VA = "0x1821092D0")]
	public static CDOLGFBAJII<ONPEDCCMFKN, ILCEMBFLKNK> NGKMHBIDPIH(GMEBKHPMCKK BAFHJDFHJHD, [In] PKEFCEJJNDJ NKCEKILMAAM)
	{
		return default(CDOLGFBAJII<ONPEDCCMFKN, ILCEMBFLKNK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct NFJDODEFJPE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct JEEJCKCCPAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<bool, ILCEMBFLKNK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public GMEBKHPMCKK root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NFJDODEFJPE self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private CDOLGFBAJII<bool, ILCEMBFLKNK> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<CDOLGFBAJII<AJBBHDJGBPP, ILCEMBFLKNK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x20F7390", Offset = "0x20F5D90", VA = "0x1820F7390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x20F79D0", Offset = "0x20F63D0", VA = "0x1820F79D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly int LEDCMOMLPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int BDIPFIAMOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly byte[] EIPGALGMOJD;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1E3F180", Offset = "0x1E3DB80", VA = "0x181E3F180")]
	private NFJDODEFJPE(int CMNDBGDABDM, int ENMILGHAHOM, byte[] LNCKNHNHHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x20FCF10", Offset = "0x20FB910", VA = "0x1820FCF10")]
	public static ONPEDCCMFKN CJEGFEPCLMN(int CMNDBGDABDM, int ENMILGHAHOM, ByteString LNCKNHNHHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x20FD200", Offset = "0x20FBC00", VA = "0x1820FD200")]
	public static ONPEDCCMFKN?[]? PEHPMJHMJCA(int HPAFBMIDAIO, AOFBLOPPMID? JEEJGNKFMDN, JEEOGCMCDDH? KGELNLDDLAB, GHGEAPMBJNK? IPPFHGIBMOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x20FCFF0", Offset = "0x20FB9F0", VA = "0x1820FCFF0")]
	public static BJDDGKIBOMA<GDONOGCEMNE, NFJDODEFJPE> KCBOCCOLDJK(ONPEDCCMFKN CLFFAPGBPPK)
	{
		return default(BJDDGKIBOMA<GDONOGCEMNE, NFJDODEFJPE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x20FD0D0", Offset = "0x20FBAD0", VA = "0x1820FD0D0")]
	[AsyncStateMachine(typeof(JEEJCKCCPAC))]
	public static Task<CDOLGFBAJII<bool, ILCEMBFLKNK>> OJMMCJIHMML(GMEBKHPMCKK BAFHJDFHJHD, NFJDODEFJPE NKCEKILMAAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class JNPAGNDLNLG : KLJIIPKLDCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly GMEBKHPMCKK ABJOCPNGLEO;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public LJONKAKIJNA? GHBFIIGNNDE
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x20F7DF0", Offset = "0x20F67F0", VA = "0x1820F7DF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8913E0", Offset = "0x88FDE0", VA = "0x1808913E0")]
	internal JNPAGNDLNLG(GMEBKHPMCKK EDAFBGDMGIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class MKFNKAGPMND : LJONKAKIJNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly GMEBKHPMCKK ABJOCPNGLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly GBCABGGBFOO BMIJOGNCAGE;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x887590", Offset = "0x885F90", VA = "0x180887590")]
	public MKFNKAGPMND(GMEBKHPMCKK EDAFBGDMGIM, GBCABGGBFOO NCACNCENMBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x20FC6D0", Offset = "0x20FB0D0", VA = "0x1820FC6D0", Slot = "4")]
	public CDOLGFBAJII<OJMILIDCABE, AFIACLEPAHL> KGCIMNJPDBH(GBPONPDANLH<BOAKMKENONJ> HEPLADJNIKE, OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB, OPGJAFEOJCM<LBLICMJLFMO> MIGAOACKAPI)
	{
		return default(CDOLGFBAJII<OJMILIDCABE, AFIACLEPAHL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x20FC9B0", Offset = "0x20FB3B0", VA = "0x1820FC9B0", Slot = "5")]
	public CDOLGFBAJII<OJMILIDCABE, AFIACLEPAHL> MNPKKLCGLNO(GBPONPDANLH<BOAKMKENONJ> HEPLADJNIKE, OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB, OPGJAFEOJCM<LENKNJAGABN> AENNIDBABCK)
	{
		return default(CDOLGFBAJII<OJMILIDCABE, AFIACLEPAHL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class FAKPMAHIMHF : GPEIGHCONNK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface MLPHOBLLFGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<GBCABGGBFOO> IILDPNLGNIO(GMEBKHPMCKK EDAFBGDMGIM, JEEOGCMCDDH? KFKAHAGCIAI, GHGEAPMBJNK? NCPAHAKHNEN, CancellationToken LOIOCMLGMKH);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		OPOFBFBNFLL GEACLIEMHFG(GMEBKHPMCKK EDAFBGDMGIM, AOFBLOPPMID AFFOANBOJBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class KIAPJOOMDJD : MLPHOBLLFGD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct BGMMCKBCPMF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public AsyncTaskMethodBuilder<GBCABGGBFOO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public GMEBKHPMCKK circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public JEEOGCMCDDH cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public GHGEAPMBJNK cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter<IBLIGLOHNNH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x20EE9A0", Offset = "0x20ED3A0", VA = "0x1820EE9A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x20EEB70", Offset = "0x20ED570", VA = "0x1820EEB70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly KIAPJOOMDJD GHBFIIGNNDE;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		private KIAPJOOMDJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x20F8270", Offset = "0x20F6C70", VA = "0x1820F8270", Slot = "4")]
		[AsyncStateMachine(typeof(BGMMCKBCPMF))]
		public Task<GBCABGGBFOO> IILDPNLGNIO(GMEBKHPMCKK EDAFBGDMGIM, JEEOGCMCDDH? KFKAHAGCIAI, GHGEAPMBJNK? NCPAHAKHNEN, CancellationToken LOIOCMLGMKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x20F8250", Offset = "0x20F6C50", VA = "0x1820F8250", Slot = "5")]
		public OPOFBFBNFLL GEACLIEMHFG(GMEBKHPMCKK EDAFBGDMGIM, AOFBLOPPMID AFFOANBOJBJ)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct IDCMKEBHOOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder<FAKPMAHIMHF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public GMEBKHPMCKK circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public JEEOGCMCDDH cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public GHGEAPMBJNK cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AOFBLOPPMID evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private MLPHOBLLFGD <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter<GBCABGGBFOO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x20F6AA0", Offset = "0x20F54A0", VA = "0x1820F6AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x20F6FA0", Offset = "0x20F59A0", VA = "0x1820F6FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly GBCABGGBFOO BMIJOGNCAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly OPOFBFBNFLL LACMFFPNPNG;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public LFOCNAGFDKF HCAMAEAOKKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x20F39A0", Offset = "0x20F23A0", VA = "0x1820F39A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public JHMFKMNAMLF MKPLIINLPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x20F3BC0", Offset = "0x20F25C0", VA = "0x1820F3BC0", Slot = "5")]
		get
		{
			return default(JHMFKMNAMLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public MKFNKAGPMND NCHJDMICGAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public APEFKHFCOML ABMJDGEOAHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x888EA0", Offset = "0x8878A0", VA = "0x180888EA0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x9FD280", Offset = "0x9FBC80", VA = "0x1809FD280")]
	private FAKPMAHIMHF(GBCABGGBFOO NCACNCENMBN, OPOFBFBNFLL NONKDHONIJG, MKFNKAGPMND FOFNABHNGNJ, APEFKHFCOML CGEHCGBMFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x20F39F0", Offset = "0x20F23F0", VA = "0x1820F39F0")]
	[AsyncStateMachine(typeof(IDCMKEBHOOL))]
	public static Task<FAKPMAHIMHF> CKOGJCECCLG(GMEBKHPMCKK EDAFBGDMGIM, AOFBLOPPMID AFFOANBOJBJ, JEEOGCMCDDH? KFKAHAGCIAI, GHGEAPMBJNK? NCPAHAKHNEN, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x20F3B60", Offset = "0x20F2560", VA = "0x1820F3B60", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class KPNHMONLLAE : LJNMGFEFBDE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface FJNFJIILGJL
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<GPEIGHCONNK> GEGKEGLJBCC(GMEBKHPMCKK EDAFBGDMGIM, AOFBLOPPMID AFFOANBOJBJ, JEEOGCMCDDH? KFKAHAGCIAI, GHGEAPMBJNK? NCPAHAKHNEN, CancellationToken LOIOCMLGMKH);

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GPILNHPODHJ();

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OPLBKLIILOP();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class FEJKCPCGINI : FJNFJIILGJL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct EMAJJMBHKJG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public AsyncTaskMethodBuilder<GPEIGHCONNK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public GMEBKHPMCKK circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AOFBLOPPMID evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public JEEOGCMCDDH cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public GHGEAPMBJNK cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private TaskAwaiter<FAKPMAHIMHF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x20F35F0", Offset = "0x20F1FF0", VA = "0x1820F35F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x20F3930", Offset = "0x20F2330", VA = "0x1820F3930", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x20F47C0", Offset = "0x20F31C0", VA = "0x1820F47C0", Slot = "4")]
		[AsyncStateMachine(typeof(EMAJJMBHKJG))]
		public Task<GPEIGHCONNK> GEGKEGLJBCC(GMEBKHPMCKK EDAFBGDMGIM, AOFBLOPPMID AFFOANBOJBJ, JEEOGCMCDDH? KFKAHAGCIAI, GHGEAPMBJNK? NCPAHAKHNEN, CancellationToken LOIOCMLGMKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void GPILNHPODHJ();

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void OPLBKLIILOP();

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		protected FEJKCPCGINI()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct JMPLHDMMBGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder<GPEIGHCONNK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public KPNHMONLLAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter<AJBBHDJGBPP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x20F7B80", Offset = "0x20F6580", VA = "0x1820F7B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x20F7D80", Offset = "0x20F6780", VA = "0x1820F7D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct BMCNFLCLELC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public KPNHMONLLAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public GMEBKHPMCKK circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AOFBLOPPMID evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public JEEOGCMCDDH cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public GHGEAPMBJNK cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<GPEIGHCONNK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x20F0DC0", Offset = "0x20EF7C0", VA = "0x1820F0DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x20F12F0", Offset = "0x20EFCF0", VA = "0x1820F12F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly FJNFJIILGJL GBEKAPOEJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly TaskCompletionSource<AJBBHDJGBPP> KAIEGFLLILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly TaskCompletionSource<AJBBHDJGBPP> HFNMHIIMANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly CancellationTokenSource NPFCIKJFBEG;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool LJKCINAHMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xC320D0", Offset = "0xC30AD0", VA = "0x180C320D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xD12ED0", Offset = "0xD118D0", VA = "0x180D12ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool HACHFHFHEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xD12EA0", Offset = "0xD118A0", VA = "0x180D12EA0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xD12EB0", Offset = "0xD118B0", VA = "0x180D12EB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool KAIKMJBJGJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x13382C0", Offset = "0x1336CC0", VA = "0x1813382C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x20F8440", Offset = "0x20F6E40", VA = "0x1820F8440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public GPEIGHCONNK? GDCICNAOEOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8892A0", Offset = "0x887CA0", VA = "0x1808892A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x88B260", Offset = "0x889C60", VA = "0x18088B260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x20F85D0", Offset = "0x20F6FD0", VA = "0x1820F85D0", Slot = "7")]
	[AsyncStateMachine(typeof(JMPLHDMMBGB))]
	public Task<GPEIGHCONNK> GEFHGIJKJDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x20F8820", Offset = "0x20F7220", VA = "0x1820F8820")]
	public KPNHMONLLAE(FJNFJIILGJL HBFCALFCDLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x20F86C0", Offset = "0x20F70C0", VA = "0x1820F86C0", Slot = "8")]
	[AsyncStateMachine(typeof(BMCNFLCLELC))]
	public Task LKFJGPLGKIN(GMEBKHPMCKK EDAFBGDMGIM, AOFBLOPPMID AFFOANBOJBJ, JEEOGCMCDDH? KFKAHAGCIAI, GHGEAPMBJNK? NCPAHAKHNEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x20F8450", Offset = "0x20F6E50", VA = "0x1820F8450", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class NFCEIPPDNLN : LJAJEDLFHOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly APEFKHFCOML HDLEGKNLNIG;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8913E0", Offset = "0x88FDE0", VA = "0x1808913E0")]
	public NFCEIPPDNLN(APEFKHFCOML CGEHCGBMFPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class JCGGNDEBCDH
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class COBKCDCOEAA<TGraph> : LGAFBGLPDCL where TGraph : BGJBIHJGJNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		protected readonly TGraph NEPEGDNLHPH;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public virtual ONPMKOFGDJB? OIBGNOCCEFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x117BAF0", Offset = "0x117A4F0", VA = "0x18117BAF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public OPGJAFEOJCM<BLMFKKELJGG> HNNILBPOLMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x57A8570", Offset = "0x57A6F70", VA = "0x1857A8570", Slot = "5")]
			get
			{
				return default(OPGJAFEOJCM<BLMFKKELJGG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public OPGJAFEOJCM<BLMFKKELJGG>? MEEEKPPDCBE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x57A8590", Offset = "0x57A6F90", VA = "0x1857A8590", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8913E0", Offset = "0x88FDE0", VA = "0x1808913E0")]
		public COBKCDCOEAA(TGraph OAHHBCOOBCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class HDFKILBDKNE : COBKCDCOEAA<OJJFNHHCLDI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override ONPMKOFGDJB? OIBGNOCCEFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x20F68C0", Offset = "0x20F52C0", VA = "0x1820F68C0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x20F68E0", Offset = "0x20F52E0", VA = "0x1820F68E0")]
		public HDFKILBDKNE(OJJFNHHCLDI EOHJEFGAMAF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x20F7200", Offset = "0x20F5C00", VA = "0x1820F7200")]
	public static LGAFBGLPDCL OOAFHJGKFEK(BGJBIHJGJNA OAHHBCOOBCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class LFLBFBCNCBE : PAHHDFCJJAM, ICPCFJHFNLO, CGHMBKNDPCI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class ICLGHGOCHGB
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
			public ICLGHGOCHGB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public NMFMPDHEBKA errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x2109E30", Offset = "0x2108830", VA = "0x182109E30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x210A0A0", Offset = "0x2108AA0", VA = "0x18210A0A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public LFLBFBCNCBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public ICLGHGOCHGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x20F69B0", Offset = "0x20F53B0", VA = "0x1820F69B0")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task BPDBDBMJCMG(NMFMPDHEBKA errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct DBNHGFIKFJH : IAsyncStateMachine
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
		public LFLBFBCNCBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x20F1D00", Offset = "0x20F0700", VA = "0x1820F1D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x20F2210", Offset = "0x20F0C10", VA = "0x1820F2210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class PNAKIFHOOKO
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
			public PNAKIFHOOKO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x210A100", Offset = "0x2108B00", VA = "0x18210A100", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x210A3E0", Offset = "0x2108DE0", VA = "0x18210A3E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public LFLBFBCNCBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public PNAKIFHOOKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x21098C0", Offset = "0x21082C0", VA = "0x1821098C0")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task LCBBMJAMDCD(NMFMPDHEBKA errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly JMDNCKPHILD FDOEGAGDMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly ICollection<EOEKNIAGPMC> OCELGNLOLLD;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private GBEIBNGLACM IAOFHDDJJCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x20FA9E0", Offset = "0x20F93E0", VA = "0x1820FA9E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public OPGJAFEOJCM<LBLICMJLFMO> AGHNIMIDAPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9BB850", Offset = "0x9BA250", VA = "0x1809BB850", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(OPGJAFEOJCM<LBLICMJLFMO>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9BD110", Offset = "0x9BBB10", VA = "0x1809BD110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private OPGJAFEOJCM<OGBOHDOOEJL> LCDIBABONCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xD089C0", Offset = "0xD073C0", VA = "0x180D089C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public OPGJAFEOJCM<IBKOEPKMBDC> GOGMMJFNFIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8AB7F0", Offset = "0x8AA1F0", VA = "0x1808AB7F0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(OPGJAFEOJCM<IBKOEPKMBDC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public override OPGJAFEOJCM<KGPCIMGKNIP> GEIFKBEGPML
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x20F9520", Offset = "0x20F7F20", VA = "0x1820F9520", Slot = "20")]
		get
		{
			return default(OPGJAFEOJCM<KGPCIMGKNIP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool IMHHKDAHFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x20F9EF0", Offset = "0x20F88F0", VA = "0x1820F9EF0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x20FB160", Offset = "0x20F9B60", VA = "0x1820FB160")]
	private LFLBFBCNCBE(GMEBKHPMCKK EDAFBGDMGIM, KGLMPAAGOHB AOOGCKADIHP, JMDNCKPHILD KPHNDGANEKA, OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB, OPGJAFEOJCM<LBLICMJLFMO> MIGAOACKAPI, OPGJAFEOJCM<OGBOHDOOEJL> AMMAKLHFFNJ, bool HIJGEDHEKJL, string DDDMPLCOGIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x20FAC10", Offset = "0x20F9610", VA = "0x1820FAC10")]
	public static LFLBFBCNCBE OOAFHJGKFEK(GMEBKHPMCKK EDAFBGDMGIM, KGLMPAAGOHB AOOGCKADIHP, JMDNCKPHILD AHBBCFFJCCJ, OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB, OPGJAFEOJCM<OGBOHDOOEJL> AMMAKLHFFNJ, OPGJAFEOJCM<LBLICMJLFMO> MIGAOACKAPI, bool HIJGEDHEKJL, bool DPIHLNCJPKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x20F9360", Offset = "0x20F7D60", VA = "0x1820F9360", Slot = "21")]
	protected override void HINDDHMAHAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x20F8FD0", Offset = "0x20F79D0", VA = "0x1820F8FD0", Slot = "22")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x20F94C0", Offset = "0x20F7EC0", VA = "0x1820F94C0", Slot = "30")]
	public void HOHKHANJDCN(EOEKNIAGPMC FABMIOIJDPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x20F8AF0", Offset = "0x20F74F0", VA = "0x1820F8AF0", Slot = "27")]
	public void CCNLCBADFKK(KJPHKCIKPOL FILDHCDHHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x20F9F70", Offset = "0x20F8970", VA = "0x1820F9F70", Slot = "28")]
	public void LNLJGILCAFB(LMGPENDMPPN CLODEOAEONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x20FAA00", Offset = "0x20F9400", VA = "0x1820FAA00", Slot = "23")]
	protected override void OBIMCBNLFOE(FPBJAJPEPML NAPHHBACMBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x20F9730", Offset = "0x20F8130", VA = "0x1820F9730", Slot = "32")]
	public string JKMDCNBOBGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x20F9C30", Offset = "0x20F8630", VA = "0x1820F9C30", Slot = "29")]
	public string LGGMLFHMPJE(int CIJNMEICJJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x20F9970", Offset = "0x20F8370", VA = "0x1820F9970")]
	private void KNBLCMHPECA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x20F9400", Offset = "0x20F7E00", VA = "0x1820F9400", Slot = "31")]
	public void HJOKBLOPCKP(EOEKNIAGPMC FABMIOIJDPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x20F8930", Offset = "0x20F7330", VA = "0x1820F8930")]
	private void BKOMJPCAFNK(bool IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x20F8EC0", Offset = "0x20F78C0", VA = "0x1820F8EC0", Slot = "33")]
	[AsyncStateMachine(typeof(DBNHGFIKFJH))]
	public Task DPGCFFINIDN(string IPHMAHBENGI, bool JLEFELPOLED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x20FB010", Offset = "0x20F9A10", VA = "0x1820FB010")]
	public void PJPNOKHNBGO(string IPHMAHBENGI, bool JLEFELPOLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x20F91C0", Offset = "0x20F7BC0", VA = "0x1820F91C0")]
	private void GCDOICGHNNN(int IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x9BD110", Offset = "0x9BBB10", VA = "0x1809BD110")]
	internal void IFCLOGCEAPE(OPGJAFEOJCM<LBLICMJLFMO> IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x20F8E60", Offset = "0x20F7860", VA = "0x1820F8E60")]
	[CompilerGenerated]
	private void CKNEAJBFHLH(string IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x20F9070", Offset = "0x20F7A70", VA = "0x1820F9070")]
	[CompilerGenerated]
	private bool EHKHKABPOBB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x20F9570", Offset = "0x20F7F70", VA = "0x1820F9570")]
	[CompilerGenerated]
	private bool INJBOIOIPAN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x20F8E70", Offset = "0x20F7870", VA = "0x1820F8E70")]
	[CompilerGenerated]
	private int CKNNMJAFAFC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x20F9BA0", Offset = "0x20F85A0", VA = "0x1820F9BA0")]
	[CompilerGenerated]
	private bool KOOALLOJMLI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x20F9960", Offset = "0x20F8360", VA = "0x1820F9960")]
	[CompilerGenerated]
	private void KFNCGKAKJMG(string IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x20FAB50", Offset = "0x20F9550", VA = "0x1820FAB50")]
	[CompilerGenerated]
	private bool OFKLLPLOCEK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x20FAFC0", Offset = "0x20F99C0", VA = "0x1820FAFC0")]
	[CompilerGenerated]
	private bool PFLMHLPFHOG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x20F9130", Offset = "0x20F7B30", VA = "0x1820F9130")]
	[CompilerGenerated]
	private bool EIHICBOJMCO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x20F8E70", Offset = "0x20F7870", VA = "0x1820F8E70")]
	[CompilerGenerated]
	private int LENDKDNDMKE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x20F9890", Offset = "0x20F8290", VA = "0x1820F9890")]
	[CompilerGenerated]
	private bool JLCGPKFDIKF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x20F9630", Offset = "0x20F8030", VA = "0x1820F9630")]
	[CompilerGenerated]
	private object JDBMFIPGHPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x20F96B0", Offset = "0x20F80B0", VA = "0x1820F96B0")]
	[CompilerGenerated]
	private void JIFOMNJJOHE(object IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x20FA910", Offset = "0x20F9310", VA = "0x1820FA910")]
	[CompilerGenerated]
	private bool NGOLBIBDDDK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class BFKNHGJDPLJ
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class IPHOAEBOLFO : MCHNGCHGFDC<GJDKFMFJAMK>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override EGELDPBGJHP EOBLIPBNCDC
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x975980", Offset = "0x974380", VA = "0x180975980", Slot = "126")]
			get
			{
				return default(EGELDPBGJHP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x20F71A0", Offset = "0x20F5BA0", VA = "0x1820F71A0")]
		public IPHOAEBOLFO(GMEBKHPMCKK EDAFBGDMGIM, GJDKFMFJAMK KCEPABIAINB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class DNMNBHFCEOB : CLAILBDGLKK<LNPLGGKGPFJ>
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x20F27E0", Offset = "0x20F11E0", VA = "0x1820F27E0")]
		public DNMNBHFCEOB(GMEBKHPMCKK EDAFBGDMGIM, LNPLGGKGPFJ AOOGCKADIHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x20F2660", Offset = "0x20F1060", VA = "0x1820F2660", Slot = "120")]
		protected override void MOPFLJOMLEP(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x20F2610", Offset = "0x20F1010", VA = "0x1820F2610")]
		[CompilerGenerated]
		private bool KJPJAHMADLA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x20F24F0", Offset = "0x20F0EF0", VA = "0x1820F24F0")]
		[CompilerGenerated]
		private void JKMMFINHNOO(bool IPHMAHBENGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class MFEDLDPGCEL : CLAILBDGLKK<EDEGGKKEGGC>
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class LJKLMJCPGEP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public KDNINCNMOIH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public MFEDLDPGCEL <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public LJKLMJCPGEP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x20FB910", Offset = "0x20FA310", VA = "0x1820FB910")]
			internal void GFLLLBNKMEP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x20FB870", Offset = "0x20FA270", VA = "0x1820FB870")]
			internal bool CCIPCJDAKEC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x20FBA80", Offset = "0x20FA480", VA = "0x1820FBA80")]
			internal bool NCGMKKAOMNL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x20FB960", Offset = "0x20FA360", VA = "0x1820FB960")]
			internal void INGCPGDHMAE(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x20FB8C0", Offset = "0x20FA2C0", VA = "0x1820FB8C0")]
			internal bool DFEDGPCFJKJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x20FC650", Offset = "0x20FB050", VA = "0x1820FC650")]
		public MFEDLDPGCEL(GMEBKHPMCKK EDAFBGDMGIM, EDEGGKKEGGC AOOGCKADIHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x20FC310", Offset = "0x20FAD10", VA = "0x1820FC310", Slot = "120")]
		protected override void MOPFLJOMLEP(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class OIFEANHNMDK : CLAILBDGLKK<FDGLFHEMKKN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class FBOCAPBENPA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public KDNINCNMOIH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public OIFEANHNMDK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public FBOCAPBENPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x20F40E0", Offset = "0x20F2AE0", VA = "0x1820F40E0")]
			internal object GFLLLBNKMEP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x20F3DA0", Offset = "0x20F27A0", VA = "0x1820F3DA0")]
			internal bool BGACIDJCELO(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x20F3E20", Offset = "0x20F2820", VA = "0x1820F3E20")]
			internal void CCIPCJDAKEC(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x20F4280", Offset = "0x20F2C80", VA = "0x1820F4280")]
			internal string NCGMKKAOMNL(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x20F4230", Offset = "0x20F2C30", VA = "0x1820F4230")]
			internal IReadOnlyList<object> INGCPGDHMAE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x20F4070", Offset = "0x20F2A70", VA = "0x1820F4070")]
			internal bool DFEDGPCFJKJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x20F41E0", Offset = "0x20F2BE0", VA = "0x1820F41E0")]
			internal bool HKOPNGOPLAM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x20F3C80", Offset = "0x20F2680", VA = "0x1820F3C80")]
			internal void BBGOGIALLJO(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x20FDD10", Offset = "0x20FC710", VA = "0x1820FDD10")]
		public OIFEANHNMDK(GMEBKHPMCKK EDAFBGDMGIM, FDGLFHEMKKN AOOGCKADIHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x20FD5C0", Offset = "0x20FBFC0", VA = "0x1820FD5C0", Slot = "120")]
		protected override void MOPFLJOMLEP(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class MFDHILLELBB : CLAILBDGLKK<ONENLPGEPPJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class KEJEEHJLDGJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public MFDHILLELBB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public KDNINCNMOIH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public KEJEEHJLDGJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x20F81B0", Offset = "0x20F6BB0", VA = "0x1820F81B0")]
			internal bool GFLLLBNKMEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x20F8090", Offset = "0x20F6A90", VA = "0x1820F8090")]
			internal void CCIPCJDAKEC(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x20F8200", Offset = "0x20F6C00", VA = "0x1820F8200")]
			internal bool NCGMKKAOMNL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x20FC2A0", Offset = "0x20FACA0", VA = "0x1820FC2A0")]
		public MFDHILLELBB(GMEBKHPMCKK EDAFBGDMGIM, ONENLPGEPPJ AOOGCKADIHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x20FC070", Offset = "0x20FAA70", VA = "0x1820FC070", Slot = "120")]
		protected override void MOPFLJOMLEP(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public abstract class DGPBFEOJDOC<TNode> : CLAILBDGLKK<TNode> where TNode : notnull, KGACBJGBGAL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct HKFBGOIKAEA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public AsyncTaskMethodBuilder<CDOLGFBAJII<OPGJAFEOJCM<EKKGGLMMLBB>, IDHCEFLHBPO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public DGPBFEOJDOC<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private TaskAwaiter<CDOLGFBAJII<OPGJAFEOJCM<EKKGGLMMLBB>, IDHCEFLHBPO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x3FC58F0", Offset = "0x3FC42F0", VA = "0x183FC58F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x3FC5CE0", Offset = "0x3FC46E0", VA = "0x183FC5CE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct NFAHDKFBFJL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public AsyncTaskMethodBuilder<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public DGPBFEOJDOC<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public OPGJAFEOJCM<EKKGGLMMLBB> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private TaskAwaiter<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x47958E0", Offset = "0x47942E0", VA = "0x1847958E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x4795CD0", Offset = "0x47946D0", VA = "0x184795CD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public sealed override bool INMNKCHJBBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "115")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override OPGJAFEOJCM<EKKGGLMMLBB>? MEHMJPFABEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x5A96320", Offset = "0x5A94D20", VA = "0x185A96320", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x44B8E10", Offset = "0x44B7810", VA = "0x1844B8E10")]
		protected DGPBFEOJDOC(GMEBKHPMCKK EDAFBGDMGIM, TNode AOOGCKADIHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5A960F0", Offset = "0x5A94AF0", VA = "0x185A960F0", Slot = "100")]
		[AsyncStateMachine(typeof(DGPBFEOJDOC<>.HKFBGOIKAEA))]
		public override Task<CDOLGFBAJII<OPGJAFEOJCM<EKKGGLMMLBB>, IDHCEFLHBPO>> MNFDODKKMDA(string DDDMPLCOGIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5A96050", Offset = "0x5A94A50", VA = "0x185A96050", Slot = "124")]
		public sealed override bool KMAOIOBGFKE(OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5A95F10", Offset = "0x5A94910", VA = "0x185A95F10", Slot = "112")]
		protected sealed override bool AOLCGCECJMC(OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5A95FB0", Offset = "0x5A949B0", VA = "0x185A95FB0", Slot = "113")]
		protected override bool CJOODHFGHJE(OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5A96210", Offset = "0x5A94C10", VA = "0x185A96210", Slot = "101")]
		[AsyncStateMachine(typeof(DGPBFEOJDOC<>.NFAHDKFBFJL))]
		public override Task<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> POLCECDFDGL(OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class PJBMNHICCAJ : INIJGFFMGIL<CBGDODGPLLK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class JIKLDDHBPLP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public PJBMNHICCAJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public KDNINCNMOIH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public JIKLDDHBPLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x20F7B00", Offset = "0x20F6500", VA = "0x1820F7B00")]
			internal bool HLGCIODKNJJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x20F7A40", Offset = "0x20F6440", VA = "0x1820F7A40")]
			internal void BEFFAGEJHMH(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2108F80", Offset = "0x2107980", VA = "0x182108F80")]
		public PJBMNHICCAJ(GMEBKHPMCKK EDAFBGDMGIM, CBGDODGPLLK KCEPABIAINB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2108D30", Offset = "0x2107730", VA = "0x182108D30", Slot = "126")]
		protected override void FDEFOKGCBMK(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class MCLFNOPMLOE : AAHALLLOAMD<CGNNKNIMNJN>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override NodeVisualizationKey NJIIHIBALEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x913B40", Offset = "0x912540", VA = "0x180913B40", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x20FC010", Offset = "0x20FAA10", VA = "0x1820FC010")]
		public MCLFNOPMLOE(GMEBKHPMCKK EDAFBGDMGIM, CGNNKNIMNJN AOOGCKADIHP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public abstract class AAHALLLOAMD<TNode> : CLAILBDGLKK<TNode> where TNode : notnull, FEJECFFDHND
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct MGIGHHMKOCI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public AsyncTaskMethodBuilder<CDOLGFBAJII<OPGJAFEOJCM<EKKGGLMMLBB>, IDHCEFLHBPO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public AAHALLLOAMD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			private TaskAwaiter<CDOLGFBAJII<OPGJAFEOJCM<EKKGGLMMLBB>, IDHCEFLHBPO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x4695160", Offset = "0x4693B60", VA = "0x184695160", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x46955F0", Offset = "0x4693FF0", VA = "0x1846955F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct MCCODMPAGEN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public AsyncTaskMethodBuilder<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public AAHALLLOAMD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public OPGJAFEOJCM<EKKGGLMMLBB> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private TaskAwaiter<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x468F340", Offset = "0x468DD40", VA = "0x18468F340", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x468F7B0", Offset = "0x468E1B0", VA = "0x18468F7B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct GPIGGIPGCJN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public AsyncTaskMethodBuilder<CDOLGFBAJII<DNFFJMPIELO, IDHCEFLHBPO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public AAHALLLOAMD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private TaskAwaiter<CDOLGFBAJII<DNFFJMPIELO, IDHCEFLHBPO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x3EE5EE0", Offset = "0x3EE48E0", VA = "0x183EE5EE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x3EE65B0", Offset = "0x3EE4FB0", VA = "0x183EE65B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private sealed class BKNEDOFDMBN
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
				public BKNEDOFDMBN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0x3749CA0", Offset = "0x37486A0", VA = "0x183749CA0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000150")]
				[Cpp2IlInjected.Address(RVA = "0x8D8CD0", Offset = "0x8D76D0", VA = "0x1808D8CD0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public LHLFFPAPFAD configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public KDNINCNMOIH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public AAHALLLOAMD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public Func<string, bool> <>9__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public Action <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public BKNEDOFDMBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x50F48C0", Offset = "0x50F32C0", VA = "0x1850F48C0")]
			internal bool BBGOGIALLJO(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x50F4EB0", Offset = "0x50F38B0", VA = "0x1850F4EB0")]
			internal void GFLLLBNKMEP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x50F49A0", Offset = "0x50F33A0", VA = "0x1850F49A0")]
			[AsyncStateMachine(typeof(AAHALLLOAMD<>.BKNEDOFDMBN.<<BuildConfigMenuInternal>b__7>d))]
			internal void BGACIDJCELO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x50F4A40", Offset = "0x50F3440", VA = "0x1850F4A40")]
			internal bool CCIPCJDAKEC()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class DPGEAPGMLJC
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
				public DPGEAPGMLJC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				private TaskAwaiter<TaskStatus> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000156")]
				[Cpp2IlInjected.Address(RVA = "0x3749930", Offset = "0x3748330", VA = "0x183749930", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000157")]
				[Cpp2IlInjected.Address(RVA = "0x8D8CD0", Offset = "0x8D76D0", VA = "0x1808D8CD0", Slot = "5")]
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
			public BKNEDOFDMBN CS$<>8__locals1;

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
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public DPGEAPGMLJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x5AA9FC0", Offset = "0x5AA89C0", VA = "0x185AA9FC0")]
			internal void NCGMKKAOMNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
			internal string INGCPGDHMAE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x8855F0", Offset = "0x883FF0", VA = "0x1808855F0")]
			internal void DFEDGPCFJKJ(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x5AA9F20", Offset = "0x5AA8920", VA = "0x185AA9F20")]
			[AsyncStateMachine(typeof(AAHALLLOAMD<>.DPGEAPGMLJC.<<BuildConfigMenuInternal>b__5>d))]
			internal void HKOPNGOPLAM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class OHCGGLPHMPG
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
				public OHCGGLPHMPG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016B")]
				[Cpp2IlInjected.Address(RVA = "0x3749460", Offset = "0x3747E60", VA = "0x183749460", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0x8D8CD0", Offset = "0x8D76D0", VA = "0x1808D8CD0", Slot = "5")]
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
				public OHCGGLPHMPG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010C")]
				private TaskAwaiter<CDOLGFBAJII<OPGJAFEOJCM<OGBOHDOOEJL>, IDHCEFLHBPO>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0x3749640", Offset = "0x3748040", VA = "0x183749640", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016E")]
				[Cpp2IlInjected.Address(RVA = "0x8D8CD0", Offset = "0x8D76D0", VA = "0x1808D8CD0", Slot = "5")]
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
				public OHCGGLPHMPG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				private TaskAwaiter<CDOLGFBAJII<OPGJAFEOJCM<MINNOGPCNLA>, IDHCEFLHBPO>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0x3748DA0", Offset = "0x37477A0", VA = "0x183748DA0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0x8D8CD0", Offset = "0x8D76D0", VA = "0x1808D8CD0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public AAHALLLOAMD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public OPGJAFEOJCM<EKKGGLMMLBB> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public LHLFFPAPFAD configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public KDNINCNMOIH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public KPJCIDKPECI nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public int minGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public int maxGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public IDJOALMKCOO selectedInputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public string newInputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public List<MPBJKKGONPG> inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public IDJOALMKCOO selectedOutputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public string newOutputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public List<MPBJKKGONPG> outputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public Func<string, bool> <>9__17;

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public OHCGGLPHMPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x48FDC70", Offset = "0x48FC670", VA = "0x1848FDC70")]
			internal bool HBDEFFOJAED()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x48FD8A0", Offset = "0x48FC2A0", VA = "0x1848FD8A0")]
			internal void ANPCNCGCFID(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x48FDEA0", Offset = "0x48FC8A0", VA = "0x1848FDEA0")]
			internal bool LBDCKJOJNHG(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x48FDB00", Offset = "0x48FC500", VA = "0x1848FDB00")]
			internal bool EODKCICJMAC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x48FE030", Offset = "0x48FCA30", VA = "0x1848FE030")]
			[AsyncStateMachine(typeof(AAHALLLOAMD<>.OHCGGLPHMPG.<<AddDynamicNodeGroupSettingV2>b__2>d))]
			internal void MBALMNCDFBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x48FE130", Offset = "0x48FCB30", VA = "0x1848FE130")]
			internal bool OANBAFDKBLN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x48FDCE0", Offset = "0x48FC6E0", VA = "0x1848FDCE0")]
			internal void HJLLNAPLOGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x48FE170", Offset = "0x48FCB70", VA = "0x1848FE170")]
			internal bool PKABJNBKDCJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x48FDBB0", Offset = "0x48FC5B0", VA = "0x1848FDBB0")]
			internal void GFOGJGNKHCD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x48FDF80", Offset = "0x48FC980", VA = "0x1848FDF80")]
			internal bool LEMDNJOKKEK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x48FDA20", Offset = "0x48FC420", VA = "0x1848FDA20")]
			internal bool DGJAHFLIKBB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x48FDA90", Offset = "0x48FC490", VA = "0x1848FDA90")]
			internal void DODABHMIGMI(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x48FDE00", Offset = "0x48FC800", VA = "0x1848FDE00")]
			[AsyncStateMachine(typeof(AAHALLLOAMD<>.OHCGGLPHMPG.<<AddDynamicNodeGroupSettingV2>b__6>d))]
			internal void KIOIKEHPFDL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x48FE0D0", Offset = "0x48FCAD0", VA = "0x1848FE0D0")]
			internal bool NMGGOHKFBNC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x48FDB40", Offset = "0x48FC540", VA = "0x1848FDB40")]
			internal bool FJBCDLCEDHI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x48FD9B0", Offset = "0x48FC3B0", VA = "0x1848FD9B0")]
			internal void CDBDBOBNBHJ(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x48FD910", Offset = "0x48FC310", VA = "0x1848FD910")]
			[AsyncStateMachine(typeof(AAHALLLOAMD<>.OHCGGLPHMPG.<<AddDynamicNodeGroupSettingV2>b__10>d))]
			internal void BOBFFCNLMBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x48FDDA0", Offset = "0x48FC7A0", VA = "0x1848FDDA0")]
			internal bool IODCBOJBEPN()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class GGEAMPNFKGA
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
				public GGEAMPNFKGA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				private TaskAwaiter<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000176")]
				[Cpp2IlInjected.Address(RVA = "0x3749090", Offset = "0x3747A90", VA = "0x183749090", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000177")]
				[Cpp2IlInjected.Address(RVA = "0x8D8CD0", Offset = "0x8D76D0", VA = "0x1808D8CD0", Slot = "5")]
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
			public OHCGGLPHMPG CS$<>8__locals1;

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
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public GGEAMPNFKGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x3ED1530", Offset = "0x3ECFF30", VA = "0x183ED1530")]
			internal void AFDAPLAJFCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
			internal string AOIBCNEOLML()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x8855F0", Offset = "0x883FF0", VA = "0x1808855F0")]
			internal void CHMHLPEGKEF(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x3ED1940", Offset = "0x3ED0340", VA = "0x183ED1940")]
			[AsyncStateMachine(typeof(AAHALLLOAMD<>.GGEAMPNFKGA.<<AddDynamicNodeGroupSettingV2>b__16>d))]
			internal void NCFEBAHGBFP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		[CompilerGenerated]
		private sealed class HHCJLDPBJGG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public KPJCIDKPECI nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public List<MPBJKKGONPG> portMenu;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public AAHALLLOAMD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public OPGJAFEOJCM<EKKGGLMMLBB> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public int portCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public Func<bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public HHCJLDPBJGG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x3F5E090", Offset = "0x3F5CA90", VA = "0x183F5E090")]
			internal bool DGFHNBDNEDA()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private sealed class JELAPJCHAEI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public CGHMBKNDPCI port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public HHCJLDPBJGG CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public JELAPJCHAEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x42EBCE0", Offset = "0x42EA6E0", VA = "0x1842EBCE0")]
			internal void HBHHNHLNKFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x42EBF70", Offset = "0x42EA970", VA = "0x1842EBF70")]
			internal bool NNEHNOEIPDE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x42EBDF0", Offset = "0x42EA7F0", VA = "0x1842EBDF0")]
			internal void JOHKEKFDAIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x42EBF10", Offset = "0x42EA910", VA = "0x1842EBF10")]
			internal bool NGFKKNAIKFD()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private sealed class GJAKJGDACDJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public MPBJKKGONPG portControls;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public JELAPJCHAEI CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public GJAKJGDACDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x3EDB210", Offset = "0x3ED9C10", VA = "0x183EDB210")]
			internal void BBDOALCMIFG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class DINLPKKPMHG
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
				public DINLPKKPMHG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000130")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000131")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				private TaskAwaiter<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000187")]
				[Cpp2IlInjected.Address(RVA = "0x374B0D0", Offset = "0x3749AD0", VA = "0x18374B0D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000188")]
				[Cpp2IlInjected.Address(RVA = "0x8D8CD0", Offset = "0x8D76D0", VA = "0x1808D8CD0", Slot = "5")]
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
			public IDJOALMKCOO selectedType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public KPJCIDKPECI nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public CGHMBKNDPCI port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public KDNINCNMOIH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public DINLPKKPMHG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x5A9CB50", Offset = "0x5A9B550", VA = "0x185A9CB50")]
			internal int HCLMICOAELO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x5A9CB90", Offset = "0x5A9B590", VA = "0x185A9CB90")]
			internal void HMCALAJDMMF(int val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8892A0", Offset = "0x887CA0", VA = "0x1808892A0")]
			internal string BDMGDGLALLE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x5A9CA90", Offset = "0x5A9B490", VA = "0x185A9CA90")]
			[AsyncStateMachine(typeof(AAHALLLOAMD<>.DINLPKKPMHG.<<CreatePortItemV2>b__3>d))]
			internal void DFHMBHFCMEO(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x5A9C9B0", Offset = "0x5A9B3B0", VA = "0x185A9C9B0")]
			internal bool CBDNHFGNMJH(string text)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly Dictionary<OPGJAFEOJCM<EKKGGLMMLBB>, bool> FIHCGJGNBHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private readonly Dictionary<OPGJAFEOJCM<EKKGGLMMLBB>, bool> ICGGIOHDJBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private readonly Dictionary<OPGJAFEOJCM<EKKGGLMMLBB>, bool> ENCPEOKNGOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Dictionary<OPGJAFEOJCM<EKKGGLMMLBB>, bool> ONPCHKMLMKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private Dictionary<OPGJAFEOJCM<EKKGGLMMLBB>, bool> OLOJFJKOMIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private Dictionary<OPGJAFEOJCM<EKKGGLMMLBB>, bool> DKEEEMPANOO;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool OOLONFPPOAK
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected virtual bool IAANKCJIKCI
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "126")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected virtual bool GINLJENEIDF
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "127")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected virtual bool IJLDAAIHHGF
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "128")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override OPGJAFEOJCM<BLMFKKELJGG>? BJAHJDJKOGO
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x3E78290", Offset = "0x3E76C90", VA = "0x183E78290", Slot = "116")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override OPGJAFEOJCM<EKKGGLMMLBB>? MEHMJPFABEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x3E78550", Offset = "0x3E76F50", VA = "0x183E78550", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override IEnumerable<GBPONPDANLH<BOAKMKENONJ>>? OLOEHKFADLM
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x3E78350", Offset = "0x3E76D50", VA = "0x183E78350", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3E78070", Offset = "0x3E76A70", VA = "0x183E78070")]
		public AAHALLLOAMD(GMEBKHPMCKK EDAFBGDMGIM, TNode AOOGCKADIHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "129")]
		protected virtual bool KDMNDLNMIHA(int DAJDGMGIPNG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "130")]
		protected virtual bool HDHGJPDJFMA(int DAJDGMGIPNG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "131")]
		protected virtual bool HIIBJBGHHJL(int DAJDGMGIPNG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "132")]
		protected virtual void EJHJKIJECAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x3E772B0", Offset = "0x3E75CB0", VA = "0x183E772B0", Slot = "124")]
		public override bool KMAOIOBGFKE(OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x3E773E0", Offset = "0x3E75DE0", VA = "0x183E773E0", Slot = "100")]
		[AsyncStateMachine(typeof(AAHALLLOAMD<>.MGIGHHMKOCI))]
		public override Task<CDOLGFBAJII<OPGJAFEOJCM<EKKGGLMMLBB>, IDHCEFLHBPO>> MNFDODKKMDA(string DDDMPLCOGIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x3E77F60", Offset = "0x3E76960", VA = "0x183E77F60", Slot = "101")]
		[AsyncStateMachine(typeof(AAHALLLOAMD<>.MCCODMPAGEN))]
		public override Task<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> POLCECDFDGL(OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x3E74E50", Offset = "0x3E73850", VA = "0x183E74E50", Slot = "102")]
		public override void BODGKFHEPAN(OPGJAFEOJCM<EKKGGLMMLBB> ENMILGHAHOM, OPGJAFEOJCM<EKKGGLMMLBB> CDHECNAFHCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x3E75150", Offset = "0x3E73B50", VA = "0x183E75150", Slot = "103")]
		public override IEnumerable<ONPEDCCMFKN> FELFMDEACLP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x3E75050", Offset = "0x3E73A50", VA = "0x183E75050")]
		[AsyncStateMachine(typeof(AAHALLLOAMD<>.GPIGGIPGCJN))]
		private Task<CDOLGFBAJII<DNFFJMPIELO, IDHCEFLHBPO>> DLOJHFKLDPP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "133")]
		protected virtual bool JPPGKIAKNCF(OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "134")]
		protected virtual bool NGOHBNAOHFC(OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "135")]
		protected virtual bool MDACGJLINKG(OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "136")]
		protected virtual bool EFBCFOBIELN(OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "137")]
		protected virtual bool MHKKMNKDFCC(OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB, int OBFDPILAHJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "138")]
		protected virtual bool JJIFPJAPNGG(OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB, int OBFDPILAHJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "139")]
		protected virtual bool KHCMHBAMBEO(OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB, int MKCBGBBALLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "140")]
		protected virtual bool ECBKELDLECE(OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB, int MKCBGBBALLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "141")]
		protected virtual bool MEGKKMOBNJA(OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB, int FHNDLLDGKOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "142")]
		protected virtual bool KFBABEFKAAH(OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB, int CMLMOJMPJCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3E75CF0", Offset = "0x3E746F0", VA = "0x183E75CF0", Slot = "143")]
		protected virtual List<IDJOALMKCOO> GHMGBPGHBLO(OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "144")]
		protected virtual void LCDJBGMOEJC(LHLFFPAPFAD FEGOCLLNBGG, DPCIDIKHKAE KPKOPOHLECO, KPJCIDKPECI NNFOHIAAKIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x3E77500", Offset = "0x3E75F00", VA = "0x183E77500", Slot = "120")]
		protected override void MOPFLJOMLEP(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x3E73720", Offset = "0x3E72120", VA = "0x183E73720")]
		private DPCIDIKHKAE BKEDJMIODHA(LHLFFPAPFAD FEGOCLLNBGG, KPJCIDKPECI NNFOHIAAKIP, OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x3E76180", Offset = "0x3E74B80", VA = "0x183E76180")]
		private List<MPBJKKGONPG> JMAOFIDKFIJ(LHLFFPAPFAD FEGOCLLNBGG, KPJCIDKPECI NNFOHIAAKIP, DPCIDIKHKAE HLHBOOMAJDD, bool BAEJABIFIKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x3E753B0", Offset = "0x3E73DB0", VA = "0x183E753B0")]
		private List<MPBJKKGONPG> FFKNCBIPLLE(LHLFFPAPFAD FEGOCLLNBGG, KPJCIDKPECI NNFOHIAAKIP, CGHMBKNDPCI FKLKJMACJGM, bool BAEJABIFIKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3E75F90", Offset = "0x3E74990", VA = "0x183E75F90")]
		private IDJOALMKCOO GPFFCFKAOGI(List<IDJOALMKCOO> DICONDEDONN, CGHMBKNDPCI FKLKJMACJGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x3E77350", Offset = "0x3E75D50", VA = "0x183E77350")]
		[CompilerGenerated]
		private ONPEDCCMFKN MCNHCOIEPDK(KGLMPAAGOHB ELMEOKPKOPN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public sealed class AHOABBPKECL : CLAILBDGLKK<KDEKFEJEAIG>
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class CDJLGMLDJJP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public AHOABBPKECL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public KDNINCNMOIH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public CDJLGMLDJJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x20F1CB0", Offset = "0x20F06B0", VA = "0x1820F1CB0")]
			internal int GFLLLBNKMEP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x20F1C20", Offset = "0x20F0620", VA = "0x1820F1C20")]
			internal void CCIPCJDAKEC(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override NodeVisualizationKey NJIIHIBALEA
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xB06C30", Offset = "0xB05630", VA = "0x180B06C30", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x20ED080", Offset = "0x20EBA80", VA = "0x1820ED080")]
		public AHOABBPKECL(GMEBKHPMCKK EDAFBGDMGIM, KDEKFEJEAIG AOOGCKADIHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x20ECEC0", Offset = "0x20EB8C0", VA = "0x1820ECEC0", Slot = "120")]
		protected override void MOPFLJOMLEP(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public sealed class GOKMPKNIBEE : INIJGFFMGIL<NFMIBNJBNEA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class KBOGHLNBDGA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public GOKMPKNIBEE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public KDNINCNMOIH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public KBOGHLNBDGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x20F7F90", Offset = "0x20F6990", VA = "0x1820F7F90")]
			internal int HLGCIODKNJJ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x20F7EF0", Offset = "0x20F68F0", VA = "0x1820F7EF0")]
			internal void BEFFAGEJHMH(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x20F6570", Offset = "0x20F4F70", VA = "0x1820F6570")]
		public GOKMPKNIBEE(GMEBKHPMCKK EDAFBGDMGIM, NFMIBNJBNEA KCEPABIAINB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x20F6330", Offset = "0x20F4D30", VA = "0x1820F6330", Slot = "126")]
		protected override void FDEFOKGCBMK(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private sealed class BGEMEGBPCBL : CLAILBDGLKK<GNNDENCKHHB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey NJIIHIBALEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xADF070", Offset = "0xADDA70", VA = "0x180ADF070", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x20EE930", Offset = "0x20ED330", VA = "0x1820EE930")]
		public BGEMEGBPCBL(GMEBKHPMCKK EDAFBGDMGIM, GNNDENCKHHB AOOGCKADIHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "120")]
		protected override void MOPFLJOMLEP(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public sealed class BHKDDJKNFJN : CLAILBDGLKK<JJJHEEJPDED>
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class PBCGDAGMEBK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public BHKDDJKNFJN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public LHLFFPAPFAD configure;

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
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public PBCGDAGMEBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x20FF9C0", Offset = "0x20FE3C0", VA = "0x1820FF9C0")]
			internal bool GFLLLBNKMEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x20FE7A0", Offset = "0x20FD1A0", VA = "0x1820FE7A0")]
			internal void CCIPCJDAKEC(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x20FEC60", Offset = "0x20FD660", VA = "0x1820FEC60")]
			internal bool DFEDGPCFJKJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x20FFEF0", Offset = "0x20FE8F0", VA = "0x1820FFEF0")]
			internal bool HKOPNGOPLAM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x20FE1D0", Offset = "0x20FCBD0", VA = "0x1820FE1D0")]
			internal void BBGOGIALLJO(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x2107B90", Offset = "0x2106590", VA = "0x182107B90")]
			internal bool MLLFANMCCOK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x21087A0", Offset = "0x21071A0", VA = "0x1821087A0")]
			internal bool OKDIBFOOGOM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x21087F0", Offset = "0x21071F0", VA = "0x1821087F0")]
			internal void OOFNDCOJEIO(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x2107950", Offset = "0x2106350", VA = "0x182107950")]
			internal bool MGANEFLHHEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x2106E90", Offset = "0x2105890", VA = "0x182106E90")]
			internal bool KIFHNPDJPOF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x2108900", Offset = "0x2107300", VA = "0x182108900")]
			internal void OPHEEFPFEPH(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x20FEDA0", Offset = "0x20FD7A0", VA = "0x1820FEDA0")]
			internal bool DNPGFLGNMPK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x20FE910", Offset = "0x20FD310", VA = "0x1820FE910")]
			internal bool CGPIPADDKME()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x20FFE00", Offset = "0x20FE800", VA = "0x1820FFE00")]
			internal bool HFHFHCIMJKK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x2107340", Offset = "0x2105D40", VA = "0x182107340")]
			internal bool LFILINBPPBB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x20FF620", Offset = "0x20FE020", VA = "0x1820FF620")]
			internal bool FHLGBIOJLOK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x2106A00", Offset = "0x2105400", VA = "0x182106A00")]
			internal bool JHHJIKEANGK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x2106940", Offset = "0x2105340", VA = "0x182106940")]
			internal bool JGDAGNOLOPL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x2108A50", Offset = "0x2107450", VA = "0x182108A50")]
			internal bool PDAMFDJKION()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x2106AF0", Offset = "0x21054F0", VA = "0x182106AF0")]
			internal bool JLPFGLAFNNO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x2107F30", Offset = "0x2106930", VA = "0x182107F30")]
			internal void NOMEJLNMFAC(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x20FEE80", Offset = "0x20FD880", VA = "0x1820FEE80")]
			internal bool ECEAAHKAKHD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x2106AA0", Offset = "0x21054A0", VA = "0x182106AA0")]
			internal bool JKDGMHDFHBB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x20FF3E0", Offset = "0x20FDDE0", VA = "0x1820FF3E0")]
			internal bool FDMIKAALJAJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x2107640", Offset = "0x2106040", VA = "0x182107640")]
			internal bool LKPLCDIHDMK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x21003F0", Offset = "0x20FEDF0", VA = "0x1821003F0")]
			internal bool IAJIBJJJBPH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x21067B0", Offset = "0x21051B0", VA = "0x1821067B0")]
			internal bool IMOLCABAACA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x20FF970", Offset = "0x20FE370", VA = "0x1820FF970")]
			internal bool GEENGILDNMF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x2108960", Offset = "0x2107360", VA = "0x182108960")]
			internal bool PAMJACNFHCI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x2106CF0", Offset = "0x21056F0", VA = "0x182106CF0")]
			internal void KCPMMBPBOLM(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x2108750", Offset = "0x2107150", VA = "0x182108750")]
			internal bool OJCIHOEEGIH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x2108CE0", Offset = "0x21076E0", VA = "0x182108CE0")]
			internal bool PNBOEHDADKF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x21088A0", Offset = "0x21072A0", VA = "0x1821088A0")]
			internal void OPCDKHKONDL(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x20FEAC0", Offset = "0x20FD4C0", VA = "0x1820FEAC0")]
			internal bool CLGGGFDKPBF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x21002B0", Offset = "0x20FECB0", VA = "0x1821002B0")]
			internal bool HMHFOIKCBKA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x20FF2E0", Offset = "0x20FDCE0", VA = "0x1820FF2E0")]
			internal void FAOBNCDJJKN(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x2100440", Offset = "0x20FEE40", VA = "0x182100440")]
			internal List<MPBJKKGONPG> IAKGBDALBDB(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x2106B90", Offset = "0x2105590", VA = "0x182106B90")]
			internal bool JMLMBBBJCDM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x20FEB60", Offset = "0x20FD560", VA = "0x1820FEB60")]
			internal int CMIOIDBGDLJ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x20FF7B0", Offset = "0x20FE1B0", VA = "0x1820FF7B0")]
			internal void FLPEPMPPBIH(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x2108570", Offset = "0x2106F70", VA = "0x182108570")]
			internal bool ODNMLIKJDDD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x2108AA0", Offset = "0x21074A0", VA = "0x182108AA0")]
			internal bool PDPLNNIIDMF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x20FFA60", Offset = "0x20FE460", VA = "0x1820FFA60")]
			internal bool GGOBNKNFCKD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x20FE960", Offset = "0x20FD360", VA = "0x1820FE960")]
			internal int CHEIJIGNDOH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x2107220", Offset = "0x2105C20", VA = "0x182107220")]
			internal void LEDNMBJMJMD(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x2107390", Offset = "0x2105D90", VA = "0x182107390")]
			internal bool LGOGJGBLDKL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x2107EE0", Offset = "0x21068E0", VA = "0x182107EE0")]
			internal bool NOJDPGBGBHA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x2108430", Offset = "0x2106E30", VA = "0x182108430")]
			internal bool NPLHMNALHKM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x2107840", Offset = "0x2106240", VA = "0x182107840")]
			internal bool MCKLCFDIBPM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x20FE3C0", Offset = "0x20FCDC0", VA = "0x1820FE3C0")]
			internal bool BFAPAACEOHN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x21086B0", Offset = "0x21070B0", VA = "0x1821086B0")]
			internal bool OGJPNNDEIMG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x21066B0", Offset = "0x21050B0", VA = "0x1821066B0")]
			internal string IJCMDABFAPH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x20FE070", Offset = "0x20FCA70", VA = "0x1820FE070")]
			internal void ABNDHDBBJBN(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x2107CF0", Offset = "0x21066F0", VA = "0x182107CF0")]
			internal int NBLCAGFGMLC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x20FE740", Offset = "0x20FD140", VA = "0x1820FE740")]
			internal void CCAFKHFJHDI(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x20FED00", Offset = "0x20FD700", VA = "0x1820FED00")]
			internal bool DIJHIJPMFPE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x20FF8B0", Offset = "0x20FE2B0", VA = "0x1820FF8B0")]
			internal bool GAPGPPDAENN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x2108AF0", Offset = "0x21074F0", VA = "0x182108AF0")]
			internal bool PEJPNKMGJLF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x20FFB00", Offset = "0x20FE500", VA = "0x1820FFB00")]
			internal float GKHKBOIKFOO()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x21078F0", Offset = "0x21062F0", VA = "0x1821078F0")]
			internal void MFIBAFHJAOM(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x2106C30", Offset = "0x2105630", VA = "0x182106C30")]
			internal bool KABEEDHHDPG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x21084D0", Offset = "0x2106ED0", VA = "0x1821084D0")]
			internal bool OAHDJKFLNFF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x2107430", Offset = "0x2105E30", VA = "0x182107430")]
			internal bool LHHDJEPODOH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x2108340", Offset = "0x2106D40", VA = "0x182108340")]
			internal bool NPFMOFJFOFJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x21089B0", Offset = "0x21073B0", VA = "0x1821089B0")]
			internal bool PBACNDDBHEL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x20FDFD0", Offset = "0x20FC9D0", VA = "0x1820FDFD0")]
			internal bool AAPFONHMFLG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x2107F90", Offset = "0x2106990", VA = "0x182107F90")]
			internal void NOPGICMANJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x2106850", Offset = "0x2105250", VA = "0x182106850")]
			internal string JANIKOMLHMF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x21075D0", Offset = "0x2105FD0", VA = "0x1821075D0")]
			internal void LKCJKNOJMGP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x20FF390", Offset = "0x20FDD90", VA = "0x1820FF390")]
			internal bool FCJJMKJKMBA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x21074E0", Offset = "0x2105EE0", VA = "0x1821074E0")]
			internal bool LHNNMPBMAFN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x20FE520", Offset = "0x20FCF20", VA = "0x1820FE520")]
			internal bool BLIKAJFDFPM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x20FFF40", Offset = "0x20FE940", VA = "0x1820FFF40")]
			internal void HKOPPMJCNPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x20FE5E0", Offset = "0x20FCFE0", VA = "0x1820FE5E0")]
			internal bool BNBBPAPLGCO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x21077A0", Offset = "0x21061A0", VA = "0x1821077A0")]
			internal bool MBIKAGPAFGL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x20FF4D0", Offset = "0x20FDED0", VA = "0x1820FF4D0")]
			internal bool FEKEGLJNEKG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x2108850", Offset = "0x2107250", VA = "0x182108850")]
			internal bool OOPBLIABCOE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x2100250", Offset = "0x20FEC50", VA = "0x182100250")]
			internal void HLNDDDHPMAP(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x2108C30", Offset = "0x2107630", VA = "0x182108C30")]
			internal bool PIEPGHLKGHE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x20FE180", Offset = "0x20FCB80", VA = "0x1820FE180")]
			internal bool AKIEDBLAEOF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x2106DA0", Offset = "0x21057A0", VA = "0x182106DA0")]
			internal bool KGDFBJGIFGF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x20FE0E0", Offset = "0x20FCAE0", VA = "0x1820FE0E0")]
			internal bool AFADEHEPDKA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x20FF520", Offset = "0x20FDF20", VA = "0x1820FF520")]
			internal void FGAKMHHCLPJ(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x20FECB0", Offset = "0x20FD6B0", VA = "0x1820FECB0")]
			internal bool DGHJOFDDECM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x20FED50", Offset = "0x20FD750", VA = "0x1820FED50")]
			internal bool DNOACDGPAEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x2108B40", Offset = "0x2107540", VA = "0x182108B40")]
			internal bool PEMMKGFBAAN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x20FEB10", Offset = "0x20FD510", VA = "0x1820FEB10")]
			internal bool CMBCHFPMNNG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x20FFC40", Offset = "0x20FE640", VA = "0x1820FFC40")]
			internal object HBELILAILMC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x2107A40", Offset = "0x2106440", VA = "0x182107A40")]
			internal void MHPCJDBGILA(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x21003A0", Offset = "0x20FEDA0", VA = "0x1821003A0")]
			internal bool HOGIDKKJDMH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x2106B40", Offset = "0x2105540", VA = "0x182106B40")]
			internal bool JMJCOCHJOAM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x2107690", Offset = "0x2106090", VA = "0x182107690")]
			internal int MALBMFALBLB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x20FF280", Offset = "0x20FDC80", VA = "0x1820FF280")]
			internal void EPDCBKOAOEG(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x2107280", Offset = "0x2105C80", VA = "0x182107280")]
			internal bool LEFNOJEOHJG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x20FFA10", Offset = "0x20FE410", VA = "0x1820FFA10")]
			internal bool GGEIOGPGIAF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x20FF340", Offset = "0x20FDD40", VA = "0x1820FF340")]
			internal int FBOHOENFBAN()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x2107480", Offset = "0x2105E80", VA = "0x182107480")]
			internal void LHIGPMHMHJF(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x20FEF40", Offset = "0x20FD940", VA = "0x1820FEF40")]
			internal bool ECMNJOKKBHA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x20FFB50", Offset = "0x20FE550", VA = "0x1820FFB50")]
			internal bool GLIADADMPAO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x2107530", Offset = "0x2105F30", VA = "0x182107530")]
			internal bool LIBOKHEMFOF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x20FF230", Offset = "0x20FDC30", VA = "0x1820FF230")]
			internal int EMEBPOCCBEA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x2107890", Offset = "0x2106290", VA = "0x182107890")]
			internal void MDOJBHMCGLK(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x2107750", Offset = "0x2106150", VA = "0x182107750")]
			internal bool MBFGDHBAKPG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x20FE480", Offset = "0x20FCE80", VA = "0x1820FE480")]
			internal bool BGCMNGNHDGG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x20FFE50", Offset = "0x20FE850", VA = "0x1820FFE50")]
			internal bool HIAKCCKGFHI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x2107E20", Offset = "0x2106820", VA = "0x182107E20")]
			internal object NKBAEPELIHE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x20FEDF0", Offset = "0x20FD7F0", VA = "0x1820FEDF0")]
			internal void EAOJEDBKIHA(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x20FF5D0", Offset = "0x20FDFD0", VA = "0x1820FF5D0")]
			internal bool FHFGEFEPDGN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x21071D0", Offset = "0x2105BD0", VA = "0x1821071D0")]
			internal bool LDPFHNAENEF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x20FE570", Offset = "0x20FCF70", VA = "0x1820FE570")]
			internal object BMMKAFIBKGK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x2107D40", Offset = "0x2106740", VA = "0x182107D40")]
			internal void NEJAOMCGKLL(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x20FF670", Offset = "0x20FE070", VA = "0x1820FF670")]
			internal bool FIGMAFDMMBN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x20FF810", Offset = "0x20FE210", VA = "0x1820FF810")]
			internal int FNABPNEAEEH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x2106F30", Offset = "0x2105930", VA = "0x182106F30")]
			internal void KKAGDHOCENM(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x21065C0", Offset = "0x2104FC0", VA = "0x1821065C0")]
			internal bool IHBONCDCDIO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x20FE870", Offset = "0x20FD270", VA = "0x1820FE870")]
			internal bool CEGLAFMBMDB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x2108390", Offset = "0x2106D90", VA = "0x182108390")]
			internal bool NPHHBMAFMPI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x2107080", Offset = "0x2105A80", VA = "0x182107080")]
			internal int KOAPJKFEBMD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x20FFD50", Offset = "0x20FE750", VA = "0x1820FFD50")]
			internal void HEGOPIFBIGC(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x2106570", Offset = "0x2104F70", VA = "0x182106570")]
			internal bool IGJDJHFALME()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x2107DD0", Offset = "0x21067D0", VA = "0x182107DD0")]
			internal bool NJAAIKDFFHN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x20FF760", Offset = "0x20FE160", VA = "0x1820FF760")]
			internal bool FLLECBBEOFH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x20FE8C0", Offset = "0x20FD2C0", VA = "0x1820FE8C0")]
			internal float CGAKDFEPNEH()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x2108C80", Offset = "0x2107680", VA = "0x182108C80")]
			internal void PIJOFAEDGAB(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x20FE4D0", Offset = "0x20FCED0", VA = "0x1820FE4D0")]
			internal bool BKJHJJBDHNJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x20FF580", Offset = "0x20FDF80", VA = "0x1820FF580")]
			internal bool FGKHOCHOJBJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x2106520", Offset = "0x2104F20", VA = "0x182106520")]
			internal bool ICMNLOMKLDN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x20FF030", Offset = "0x20FDA30", VA = "0x1820FF030")]
			internal float EEEAOIADGFL()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x20FEC00", Offset = "0x20FD600", VA = "0x1820FEC00")]
			internal void DAIBOPJNPKD(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x20FF860", Offset = "0x20FE260", VA = "0x1820FF860")]
			internal bool GAJEADMBBNC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x20FF430", Offset = "0x20FDE30", VA = "0x1820FF430")]
			internal bool FEBKHPELGJC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x2106610", Offset = "0x2105010", VA = "0x182106610")]
			internal string IHIKGNBFCMB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x2107C30", Offset = "0x2106630", VA = "0x182107C30")]
			internal void MODMHKGDKAA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x21085C0", Offset = "0x2106FC0", VA = "0x1821085C0")]
			internal bool OEBFPIONLPC(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x20FEBB0", Offset = "0x20FD5B0", VA = "0x1820FEBB0")]
			internal bool CPJEHOPPCEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x2108480", Offset = "0x2106E80", VA = "0x182108480")]
			internal bool NPMABNPAIGB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x2108700", Offset = "0x2107100", VA = "0x182108700")]
			internal bool OHCMGDPAPGH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x2106E40", Offset = "0x2105840", VA = "0x182106E40")]
			internal string KHDENABDKDA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x2106C80", Offset = "0x2105680", VA = "0x182106C80")]
			internal void KBAKEDLJEGC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x20FF1E0", Offset = "0x20FDBE0", VA = "0x1820FF1E0")]
			internal bool ELHMEMMOCMP(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x20FFAB0", Offset = "0x20FE4B0", VA = "0x1820FFAB0")]
			internal bool GHAHPDNBGPJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x2106660", Offset = "0x2105060", VA = "0x182106660")]
			internal bool IJCEIBAGCNP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x2106BE0", Offset = "0x21055E0", VA = "0x182106BE0")]
			internal bool JODNKNEEGDG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x2106A50", Offset = "0x2105450", VA = "0x182106A50")]
			internal string JJLBBAHCFMK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x2106990", Offset = "0x2105390", VA = "0x182106990")]
			internal void JHDGLLPGLKE(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x21083E0", Offset = "0x2106DE0", VA = "0x1821083E0")]
			internal bool NPLCJNBLBEK(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x21068A0", Offset = "0x21052A0", VA = "0x1821068A0")]
			internal bool JBONEIEAGBC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x20FE2D0", Offset = "0x20FCCD0", VA = "0x1820FE2D0")]
			internal bool BDBBJIMJILD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x2108B90", Offset = "0x2107590", VA = "0x182108B90")]
			internal bool PGOAAIGEOJK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x2108520", Offset = "0x2106F20", VA = "0x182108520")]
			internal string ODELMFBMIFE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x20FE6D0", Offset = "0x20FD0D0", VA = "0x1820FE6D0")]
			internal void CAIPIJEDHOJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x2107BE0", Offset = "0x21065E0", VA = "0x182107BE0")]
			internal bool MNDFJNCAPCO(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x21079F0", Offset = "0x21063F0", VA = "0x1821079F0")]
			internal bool MHDIGMJPFAA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x20FFEA0", Offset = "0x20FE8A0", VA = "0x1820FFEA0")]
			internal bool HJOBCLCAEJP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x20FEF90", Offset = "0x20FD990", VA = "0x1820FEF90")]
			internal bool EDEILLLJJLB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x20FF140", Offset = "0x20FDB40", VA = "0x1820FF140")]
			internal string EKMFFAHAJLP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x2107AD0", Offset = "0x21064D0", VA = "0x182107AD0")]
			internal void MILMNMHMNBC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x20FE320", Offset = "0x20FCD20", VA = "0x1820FE320")]
			internal bool BDEPPIPGMBH(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x20FF710", Offset = "0x20FE110", VA = "0x1820FF710")]
			internal bool FKAFKKAOCAI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x2106700", Offset = "0x2105100", VA = "0x182106700")]
			internal bool ILKDHNDBCDH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x2106EE0", Offset = "0x21058E0", VA = "0x182106EE0")]
			internal bool KJEKHADCLHP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x2107030", Offset = "0x2105A30", VA = "0x182107030")]
			internal string KNJIMKDOHAI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x20FF080", Offset = "0x20FDA80", VA = "0x1820FF080")]
			internal void EFBPHNAOABF(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x2107580", Offset = "0x2105F80", VA = "0x182107580")]
			internal bool LJOHGFGJHPH(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x21079A0", Offset = "0x21063A0", VA = "0x1821079A0")]
			internal bool MHBHNHNIBGD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x20FF190", Offset = "0x20FDB90", VA = "0x1820FF190")]
			internal bool EKMHKEAKGKD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x20FE280", Offset = "0x20FCC80", VA = "0x1820FE280")]
			internal bool BCKKIMAEIPH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x20FF6C0", Offset = "0x20FE0C0", VA = "0x1820FF6C0")]
			internal string FJBEGHCIFOF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x20FEED0", Offset = "0x20FD8D0", VA = "0x1820FEED0")]
			internal void ECLLONOAHAI(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x2108660", Offset = "0x2107060", VA = "0x182108660")]
			internal bool OGIEPJIGLBC(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x20FFDB0", Offset = "0x20FE7B0", VA = "0x1820FFDB0")]
			internal bool HEMDPNMEKKN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x20FE020", Offset = "0x20FCA20", VA = "0x1820FE020")]
			internal bool ABILFHGNKOF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x20FE370", Offset = "0x20FCD70", VA = "0x1820FE370")]
			internal bool BDFJMPKBFNM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x20FE9B0", Offset = "0x20FD3B0", VA = "0x1820FE9B0")]
			internal string CIDGPBPLHGM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x21072D0", Offset = "0x2105CD0", VA = "0x1821072D0")]
			internal void LEMDNLEOPOE(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x21070D0", Offset = "0x2105AD0", VA = "0x1821070D0")]
			internal bool LAJIJILCHAC(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x2100300", Offset = "0x20FED00", VA = "0x182100300")]
			internal bool HMJBJNCHDID()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x20FF0F0", Offset = "0x20FDAF0", VA = "0x1820FF0F0")]
			internal bool EFNJNGOCLLB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x20FFBA0", Offset = "0x20FE5A0", VA = "0x1820FFBA0")]
			internal bool GNAECPEHCAM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x20FFD00", Offset = "0x20FE700", VA = "0x1820FFD00")]
			internal string HEEIAMBGGIG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x20FE800", Offset = "0x20FD200", VA = "0x1820FE800")]
			internal void CDJBDLEFFGJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x2100200", Offset = "0x20FEC00", VA = "0x182100200")]
			internal bool HLICIFKNNGA(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x21073E0", Offset = "0x2105DE0", VA = "0x1821073E0")]
			internal bool LHABOBLCAAL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x2107CA0", Offset = "0x21066A0", VA = "0x182107CA0")]
			internal bool NBECDKGKGAA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x2107180", Offset = "0x2105B80", VA = "0x182107180")]
			internal bool LDLOEOCEOHA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x21077F0", Offset = "0x21061F0", VA = "0x1821077F0")]
			internal string MCACKHFHPHN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x21076E0", Offset = "0x21060E0", VA = "0x1821076E0")]
			internal void MBEIFGADCFI(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x20FEFE0", Offset = "0x20FD9E0", VA = "0x1820FEFE0")]
			internal bool EDMOCKBAOHF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x2106DF0", Offset = "0x21057F0", VA = "0x182106DF0")]
			internal bool KHDBMCJGMGE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x21064D0", Offset = "0x2104ED0", VA = "0x1821064D0")]
			internal bool ICCFFKLLDGO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x20FE680", Offset = "0x20FD080", VA = "0x1820FE680")]
			internal string BOOJBENJMJA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x20FEA00", Offset = "0x20FD400", VA = "0x1820FEA00")]
			internal void CJCIMLAKBFI(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x2108A00", Offset = "0x2107400", VA = "0x182108A00")]
			internal bool PCLMOCGDKIC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x2106D50", Offset = "0x2105750", VA = "0x182106D50")]
			internal bool KEFEDOJKKHE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x20FE630", Offset = "0x20FD030", VA = "0x1820FE630")]
			internal bool BOINGCFJOEK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x20FE130", Offset = "0x20FCB30", VA = "0x1820FE130")]
			internal string AJCMFMPDJBK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x20FE410", Offset = "0x20FCE10", VA = "0x1820FE410")]
			internal void BFDHHLILBAH(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x2107B40", Offset = "0x2106540", VA = "0x182107B40")]
			internal bool MJCGJOCCODG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x2107E90", Offset = "0x2106890", VA = "0x182107E90")]
			internal bool NNJCEOHPPJA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x2106F90", Offset = "0x2105990", VA = "0x182106F90")]
			internal bool KKGBPIDPALG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x20FEA70", Offset = "0x20FD470", VA = "0x1820FEA70")]
			internal string CKOFBBFGENM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x20FF900", Offset = "0x20FE300", VA = "0x1820FF900")]
			internal void GCEGOMPBGDF(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x20FF480", Offset = "0x20FDE80", VA = "0x1820FF480")]
			internal bool FEDHEJNLGMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x2108610", Offset = "0x2107010", VA = "0x182108610")]
			internal bool OGFDLHDHMPK(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x21068F0", Offset = "0x21052F0", VA = "0x1821068F0")]
			internal float JCAKBGFEMDD()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x2106750", Offset = "0x2105150", VA = "0x182106750")]
			internal void IMECDJHFBPM(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x20FE230", Offset = "0x20FCC30", VA = "0x1820FE230")]
			internal bool BBNGMJALAAC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x2100350", Offset = "0x20FED50", VA = "0x182100350")]
			internal bool HNIPENFFKLB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x2106800", Offset = "0x2105200", VA = "0x182106800")]
			internal bool INFNEMBJMHO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x2108BE0", Offset = "0x21075E0", VA = "0x182108BE0")]
			internal int PHCCGAHKKEJ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x2107120", Offset = "0x2105B20", VA = "0x182107120")]
			internal void LBEBDBALJCC(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x20FFCB0", Offset = "0x20FE6B0", VA = "0x1820FFCB0")]
			internal bool HDKMGGMIHLO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x20FFBF0", Offset = "0x20FE5F0", VA = "0x1820FFBF0")]
			internal bool GNBOBFJEHGB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x2106FE0", Offset = "0x21059E0", VA = "0x182106FE0")]
			internal bool KMAILEEOGID()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class EELIPDABNIB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public string secondaryLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public PBCGDAGMEBK CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public EELIPDABNIB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x20F2850", Offset = "0x20F1250", VA = "0x1820F2850")]
			internal void NLFFGDAONLJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class KCOIGEOIEAH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public char[] swizzleChars;

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public KCOIGEOIEAH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x20F8010", Offset = "0x20F6A10", VA = "0x1820F8010")]
			internal bool MHEBFBGIDAM(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly MMNMKBKKIJH FFHNMAFMJAF;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x20F0910", Offset = "0x20EF310", VA = "0x1820F0910")]
		public BHKDDJKNFJN(GMEBKHPMCKK EDAFBGDMGIM, JJJHEEJPDED AOOGCKADIHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x20EEBE0", Offset = "0x20ED5E0", VA = "0x1820EEBE0", Slot = "120")]
		protected override void MOPFLJOMLEP(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public sealed class GKFKAOOAHJP : CLAILBDGLKK<PNNFFOACIEN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class BPMKKPCPLCA
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
				public BPMKKPCPLCA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				private TaskAwaiter<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002A5")]
				[Cpp2IlInjected.Address(RVA = "0x2126690", Offset = "0x2125090", VA = "0x182126690", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A6")]
				[Cpp2IlInjected.Address(RVA = "0x8D8CD0", Offset = "0x8D76D0", VA = "0x1808D8CD0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public GKFKAOOAHJP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public KDNINCNMOIH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public BPMKKPCPLCA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x2112370", Offset = "0x2110D70", VA = "0x182112370")]
			internal string GFLLLBNKMEP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x21122A0", Offset = "0x2110CA0", VA = "0x1821122A0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void CCIPCJDAKEC(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x2112450", Offset = "0x2110E50", VA = "0x182112450")]
			internal int NCGMKKAOMNL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x21123C0", Offset = "0x2110DC0", VA = "0x1821123C0")]
			internal void INGCPGDHMAE(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override NodeVisualizationKey NJIIHIBALEA
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xB06C30", Offset = "0xB05630", VA = "0x180B06C30", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x211BCE0", Offset = "0x211A6E0", VA = "0x18211BCE0")]
		public GKFKAOOAHJP(GMEBKHPMCKK EDAFBGDMGIM, PNNFFOACIEN KCEPABIAINB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x211B990", Offset = "0x211A390", VA = "0x18211B990", Slot = "120")]
		protected override void MOPFLJOMLEP(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public sealed class MOMIPGKDCCA : CLAILBDGLKK<FDGPEPPNMBD>
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private sealed class FAOINPDKIBG
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
				public FAOINPDKIBG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000180")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000181")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000182")]
				private TaskAwaiter<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BA")]
				[Cpp2IlInjected.Address(RVA = "0x21269A0", Offset = "0x21253A0", VA = "0x1821269A0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BB")]
				[Cpp2IlInjected.Address(RVA = "0x8D8CD0", Offset = "0x8D76D0", VA = "0x1808D8CD0", Slot = "5")]
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
				public FAOINPDKIBG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000188")]
				private TaskAwaiter<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x2126CE0", Offset = "0x21256E0", VA = "0x182126CE0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0x8D8CD0", Offset = "0x8D76D0", VA = "0x1808D8CD0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public MOMIPGKDCCA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public KDNINCNMOIH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public FAOINPDKIBG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x211A7F0", Offset = "0x21191F0", VA = "0x18211A7F0")]
			internal string GFLLLBNKMEP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x211A630", Offset = "0x2119030", VA = "0x18211A630")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void CCIPCJDAKEC(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x211AB50", Offset = "0x2119550", VA = "0x18211AB50")]
			internal int NCGMKKAOMNL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x211A9C0", Offset = "0x21193C0", VA = "0x18211A9C0")]
			internal void INGCPGDHMAE(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x211A700", Offset = "0x2119100", VA = "0x18211A700")]
			internal string DFEDGPCFJKJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x211A840", Offset = "0x2119240", VA = "0x18211A840")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void HKOPNGOPLAM(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x211A550", Offset = "0x2118F50", VA = "0x18211A550")]
			internal bool BBGOGIALLJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x211A5A0", Offset = "0x2118FA0", VA = "0x18211A5A0")]
			internal void BGACIDJCELO(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x211A910", Offset = "0x2119310", VA = "0x18211A910")]
			internal bool HKPAGECAHBK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x211AAC0", Offset = "0x21194C0", VA = "0x18211AAC0")]
			internal void MLLFANMCCOK(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x211ABA0", Offset = "0x21195A0", VA = "0x18211ABA0")]
			internal float OKDIBFOOGOM()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x211ABF0", Offset = "0x21195F0", VA = "0x18211ABF0")]
			internal void OOFNDCOJEIO(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x211A960", Offset = "0x2119360", VA = "0x18211A960")]
			internal int IEOEANPIKDD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x211A750", Offset = "0x2119150", VA = "0x18211A750")]
			internal void EOPCOJIDNAJ(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x211AA50", Offset = "0x2119450", VA = "0x18211AA50")]
			internal bool MGANEFLHHEP()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey NJIIHIBALEA
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0xB06C30", Offset = "0xB05630", VA = "0x180B06C30", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x2123210", Offset = "0x2121C10", VA = "0x182123210")]
		public MOMIPGKDCCA(GMEBKHPMCKK EDAFBGDMGIM, FDGPEPPNMBD AOOGCKADIHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x21227C0", Offset = "0x21211C0", VA = "0x1821227C0", Slot = "120")]
		protected override void MOPFLJOMLEP(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class KDDLJENFAFA : CLAILBDGLKK<DOFDLFNNMJE>
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class CPHDPJBJACG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public KDNINCNMOIH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public KDDLJENFAFA <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public CPHDPJBJACG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x2112BE0", Offset = "0x21115E0", VA = "0x182112BE0")]
			internal Dictionary<string, BIECMIJGBJH> GFLLLBNKMEP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x2112B90", Offset = "0x2111590", VA = "0x182112B90")]
			internal int CCIPCJDAKEC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x2112D00", Offset = "0x2111700", VA = "0x182112D00")]
			internal void NCGMKKAOMNL(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x2112C80", Offset = "0x2111680", VA = "0x182112C80")]
			internal bool INGCPGDHMAE()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey NJIIHIBALEA
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0xB06C30", Offset = "0xB05630", VA = "0x180B06C30", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x211EA40", Offset = "0x211D440", VA = "0x18211EA40")]
		public KDDLJENFAFA(GMEBKHPMCKK EDAFBGDMGIM, DOFDLFNNMJE KCEPABIAINB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x211E770", Offset = "0x211D170", VA = "0x18211E770", Slot = "120")]
		protected override void MOPFLJOMLEP(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class HCLJEHOHMNG : CLAILBDGLKK<NNLCKMHKEHL>
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private sealed class GPCGKGMCGEN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public KDNINCNMOIH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public HCLJEHOHMNG <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public GPCGKGMCGEN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x211BD50", Offset = "0x211A750", VA = "0x18211BD50")]
			internal void GFLLLBNKMEP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey NJIIHIBALEA
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0xB06C30", Offset = "0xB05630", VA = "0x180B06C30", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x211BFE0", Offset = "0x211A9E0", VA = "0x18211BFE0")]
		public HCLJEHOHMNG(GMEBKHPMCKK EDAFBGDMGIM, NNLCKMHKEHL KCEPABIAINB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x211BE60", Offset = "0x211A860", VA = "0x18211BE60", Slot = "120")]
		protected override void MOPFLJOMLEP(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private sealed class BGMLNGOPNAI : AAHALLLOAMD<KAKINJEFKIJ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool GEBLOKMJHNM
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override bool AIKBBGAOENE
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x21117D0", Offset = "0x21101D0", VA = "0x1821117D0", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override NodeVisualizationKey NJIIHIBALEA
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x98ED40", Offset = "0x98D740", VA = "0x18098ED40", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x2111770", Offset = "0x2110170", VA = "0x182111770")]
		public BGMLNGOPNAI(GMEBKHPMCKK EDAFBGDMGIM, KAKINJEFKIJ AOOGCKADIHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "120")]
		protected override void MOPFLJOMLEP(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	private sealed class FLMJIOPEAEF : CLAILBDGLKK<ILBOKOINMCB>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override NodeVisualizationKey NJIIHIBALEA
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xAD57F0", Offset = "0xAD41F0", VA = "0x180AD57F0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x211B0C0", Offset = "0x2119AC0", VA = "0x18211B0C0")]
		public FLMJIOPEAEF(GMEBKHPMCKK EDAFBGDMGIM, ILBOKOINMCB AOOGCKADIHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "120")]
		protected override void MOPFLJOMLEP(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class NKLBBDHPECE : CLAILBDGLKK<BNFFDINAJBN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override NodeVisualizationKey NJIIHIBALEA
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0xB21460", Offset = "0xB1FE60", VA = "0x180B21460", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x2123280", Offset = "0x2121C80", VA = "0x182123280")]
		public NKLBBDHPECE(GMEBKHPMCKK EDAFBGDMGIM, BNFFDINAJBN AOOGCKADIHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "112")]
		protected override bool AOLCGCECJMC(OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "120")]
		protected override void MOPFLJOMLEP(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class LGLOFLBINCH : CLAILBDGLKK<JEEFCJMADCD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override NodeVisualizationKey NJIIHIBALEA
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x975850", Offset = "0x974250", VA = "0x180975850", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool FLIOCAFJIBO
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x21218D0", Offset = "0x21202D0", VA = "0x1821218D0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected override bool HIFLNILCFNM
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x2121860", Offset = "0x2120260", VA = "0x182121860")]
		public LGLOFLBINCH(GMEBKHPMCKK EDAFBGDMGIM, JEEFCJMADCD AOOGCKADIHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "120")]
		protected override void MOPFLJOMLEP(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private sealed class LLAGAPEOHCN : CLAILBDGLKK<LAEHPJONIPN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override NodeVisualizationKey NJIIHIBALEA
		{
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x975980", Offset = "0x974380", VA = "0x180975980", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override bool FLIOCAFJIBO
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x2121990", Offset = "0x2120390", VA = "0x182121990", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		protected override bool HIFLNILCFNM
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x2121920", Offset = "0x2120320", VA = "0x182121920")]
		public LLAGAPEOHCN(GMEBKHPMCKK EDAFBGDMGIM, LAEHPJONIPN AOOGCKADIHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "120")]
		protected override void MOPFLJOMLEP(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public sealed class MEAFIJPGDOA : INIJGFFMGIL<KKKNJPMLFCF>
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		[CompilerGenerated]
		private sealed class HNCKBKLPCCJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public MEAFIJPGDOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public KDNINCNMOIH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public HNCKBKLPCCJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x211CB70", Offset = "0x211B570", VA = "0x18211CB70")]
			internal float HLGCIODKNJJ()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x211CAD0", Offset = "0x211B4D0", VA = "0x18211CAD0")]
			internal void BEFFAGEJHMH(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x2121C60", Offset = "0x2120660", VA = "0x182121C60")]
		public MEAFIJPGDOA(GMEBKHPMCKK EDAFBGDMGIM, KKKNJPMLFCF KCEPABIAINB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x21219E0", Offset = "0x21203E0", VA = "0x1821219E0", Slot = "126")]
		protected override void FDEFOKGCBMK(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public sealed class OPLDJMDEMMC : CLAILBDGLKK<LEOMEIKCKLN>
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		[CompilerGenerated]
		private sealed class EDLMHPBLBOE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public OPLDJMDEMMC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public KDNINCNMOIH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public EDLMHPBLBOE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x21142E0", Offset = "0x2112CE0", VA = "0x1821142E0")]
			internal bool GFLLLBNKMEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x21141C0", Offset = "0x2112BC0", VA = "0x1821141C0")]
			internal void CCIPCJDAKEC(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x2123D60", Offset = "0x2122760", VA = "0x182123D60")]
		public OPLDJMDEMMC(GMEBKHPMCKK EDAFBGDMGIM, LEOMEIKCKLN KCEPABIAINB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x2123AB0", Offset = "0x21224B0", VA = "0x182123AB0", Slot = "120")]
		protected override void MOPFLJOMLEP(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public sealed class IJOAIKLNEIB : CLAILBDGLKK<MGNCBIDNOBD>
	{
		[Cpp2IlInjected.Token(Token = "0x200007D")]
		[CompilerGenerated]
		private sealed class DFHGNNAHMDA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public KDNINCNMOIH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public IJOAIKLNEIB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public DFHGNNAHMDA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x2113A00", Offset = "0x2112400", VA = "0x182113A00")]
			internal object GFLLLBNKMEP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x21136C0", Offset = "0x21120C0", VA = "0x1821136C0")]
			internal bool BGACIDJCELO(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x2113740", Offset = "0x2112140", VA = "0x182113740")]
			internal void CCIPCJDAKEC(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x2113BD0", Offset = "0x21125D0", VA = "0x182113BD0")]
			internal string NCGMKKAOMNL(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x2113B80", Offset = "0x2112580", VA = "0x182113B80")]
			internal IReadOnlyList<object> INGCPGDHMAE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x2113990", Offset = "0x2112390", VA = "0x182113990")]
			internal bool DFEDGPCFJKJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x2113B30", Offset = "0x2112530", VA = "0x182113B30")]
			internal bool HKOPNGOPLAM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x21135A0", Offset = "0x2111FA0", VA = "0x1821135A0")]
			internal void BBGOGIALLJO(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x211DB60", Offset = "0x211C560", VA = "0x18211DB60")]
		public IJOAIKLNEIB(GMEBKHPMCKK EDAFBGDMGIM, MGNCBIDNOBD KCEPABIAINB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x211D350", Offset = "0x211BD50", VA = "0x18211D350", Slot = "120")]
		protected override void MOPFLJOMLEP(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public sealed class BODNCOHBBEE : DGPBFEOJDOC<NJOOMENECAF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override NodeVisualizationKey NJIIHIBALEA
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x988DD0", Offset = "0x9877D0", VA = "0x180988DD0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x2111F30", Offset = "0x2110930", VA = "0x182111F30")]
		public BODNCOHBBEE(GMEBKHPMCKK EDAFBGDMGIM, NJOOMENECAF AOOGCKADIHP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public sealed class FDCLOJCPJIG : INIJGFFMGIL<ICMFMPMMFDF>
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class BNDNEGKHKFN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public FDCLOJCPJIG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public KDNINCNMOIH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public BNDNEGKHKFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x2111EB0", Offset = "0x21108B0", VA = "0x182111EB0")]
			internal int HLGCIODKNJJ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x2111E10", Offset = "0x2110810", VA = "0x182111E10")]
			internal void BEFFAGEJHMH(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x211AF80", Offset = "0x2119980", VA = "0x18211AF80")]
		public FDCLOJCPJIG(GMEBKHPMCKK EDAFBGDMGIM, ICMFMPMMFDF KCEPABIAINB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x211ACF0", Offset = "0x21196F0", VA = "0x18211ACF0", Slot = "126")]
		protected override void FDEFOKGCBMK(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public sealed class EFIABKICEEH : CLAILBDGLKK<LNFCKHAPCLI>
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		[CompilerGenerated]
		private sealed class DMODBKGDCKP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public EFIABKICEEH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public KDNINCNMOIH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public DMODBKGDCKP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x2114100", Offset = "0x2112B00", VA = "0x182114100")]
			internal bool GFLLLBNKMEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x2114070", Offset = "0x2112A70", VA = "0x182114070")]
			internal void CCIPCJDAKEC(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x2114510", Offset = "0x2112F10", VA = "0x182114510")]
		public EFIABKICEEH(GMEBKHPMCKK EDAFBGDMGIM, LNFCKHAPCLI KCEPABIAINB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x2114330", Offset = "0x2112D30", VA = "0x182114330", Slot = "120")]
		protected override void MOPFLJOMLEP(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class JEOACBCKAEK : CLAILBDGLKK<EFAFKFAFKGC>
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		[CompilerGenerated]
		private sealed class LDKGLOOEIPJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public JEOACBCKAEK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public KDNINCNMOIH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public LDKGLOOEIPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x2121810", Offset = "0x2120210", VA = "0x182121810")]
			internal bool GFLLLBNKMEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x2121780", Offset = "0x2120180", VA = "0x182121780")]
			internal void CCIPCJDAKEC(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x211E170", Offset = "0x211CB70", VA = "0x18211E170")]
		public JEOACBCKAEK(GMEBKHPMCKK EDAFBGDMGIM, EFAFKFAFKGC KCEPABIAINB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x211DF90", Offset = "0x211C990", VA = "0x18211DF90", Slot = "120")]
		protected override void MOPFLJOMLEP(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class DLHDONIEEID : CLAILBDGLKK<JLFMMGJOHPP>
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		[CompilerGenerated]
		private sealed class FECCCNCOEPH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public DLHDONIEEID <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public KDNINCNMOIH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public FECCCNCOEPH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x211B070", Offset = "0x2119A70", VA = "0x18211B070")]
			internal int GFLLLBNKMEP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x211AFE0", Offset = "0x21199E0", VA = "0x18211AFE0")]
			internal void CCIPCJDAKEC(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x2113FA0", Offset = "0x21129A0", VA = "0x182113FA0")]
		public DLHDONIEEID(GMEBKHPMCKK EDAFBGDMGIM, JLFMMGJOHPP KCEPABIAINB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x2113D30", Offset = "0x2112730", VA = "0x182113D30", Slot = "120")]
		protected override void MOPFLJOMLEP(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class BIKPFJGFPNP : MCHNGCHGFDC<OMENLGDKBMD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override EGELDPBGJHP EOBLIPBNCDC
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x913B40", Offset = "0x912540", VA = "0x180913B40", Slot = "126")]
			get
			{
				return default(EGELDPBGJHP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x2111D50", Offset = "0x2110750", VA = "0x182111D50")]
		public BIKPFJGFPNP(GMEBKHPMCKK EDAFBGDMGIM, OMENLGDKBMD KCEPABIAINB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class FCDLDJLIPCI : CLAILBDGLKK<KGLMPAAGOHB>
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x211AC80", Offset = "0x2119680", VA = "0x18211AC80")]
		public FCDLDJLIPCI(GMEBKHPMCKK EDAFBGDMGIM, KGLMPAAGOHB AOOGCKADIHP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public abstract class CLAILBDGLKK<TNode> : DKCJHFLDAAD, IDisposable where TNode : notnull, KGLMPAAGOHB
	{
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		[CompilerGenerated]
		private sealed class GKJDPOLCACK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public CLAILBDGLKK<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			public GMEBKHPMCKK circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public GKJDPOLCACK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x3EDE100", Offset = "0x3EDCB00", VA = "0x183EDE100")]
			internal FAHHEMGEBFL HLCFJOENPLM(IHEAGLBOCOB portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		[CompilerGenerated]
		private struct GMPJOFKDGJC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public CLAILBDGLKK<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private TaskAwaiter<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x3EE1FF0", Offset = "0x3EE09F0", VA = "0x183EE1FF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x8D8CD0", Offset = "0x8D76D0", VA = "0x1808D8CD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		[CompilerGenerated]
		private struct NKPPHNPLGID : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public AsyncTaskMethodBuilder<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public CLAILBDGLKK<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public NPLPCBACIIN? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public DDFABOMDEOH? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			private TaskAwaiter<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x47F4220", Offset = "0x47F2C20", VA = "0x1847F4220", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x47F44C0", Offset = "0x47F2EC0", VA = "0x1847F44C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008D")]
		[CompilerGenerated]
		private sealed class KKFDIDGJKNM
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
				public KKFDIDGJKNM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CB")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000396")]
				[Cpp2IlInjected.Address(RVA = "0x3749EA0", Offset = "0x37488A0", VA = "0x183749EA0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000397")]
				[Cpp2IlInjected.Address(RVA = "0x8D8CD0", Offset = "0x8D76D0", VA = "0x1808D8CD0", Slot = "5")]
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
			public KDNINCNMOIH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public CLAILBDGLKK<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public LHLFFPAPFAD configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public KKFDIDGJKNM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
			internal string NHCPEJBGHGF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x8855F0", Offset = "0x883FF0", VA = "0x1808855F0")]
			internal void DGFCLAKCEFE(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0x43DE0F0", Offset = "0x43DCAF0", VA = "0x1843DE0F0")]
			[AsyncStateMachine(typeof(CLAILBDGLKK<>.KKFDIDGJKNM.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void GKGJPOCAMHH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		[CompilerGenerated]
		private sealed class JGFKEHOBLMD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public KDNINCNMOIH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public JGFKEHOBLMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x42F61B0", Offset = "0x42F4BB0", VA = "0x1842F61B0")]
			internal bool BDECAFBOEHF(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x42F6290", Offset = "0x42F4C90", VA = "0x1842F6290")]
			internal bool IBBAIJFKGMK(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000090")]
		[CompilerGenerated]
		private struct FGKDAJFKODP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public AsyncTaskMethodBuilder<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public CLAILBDGLKK<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			private TaskAwaiter<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x3DF46B0", Offset = "0x3DF30B0", VA = "0x183DF46B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x3DF4A40", Offset = "0x3DF3440", VA = "0x183DF4A40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private readonly GMEBKHPMCKK ABJOCPNGLEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly bool ONDGAPDNHNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private LONKLMLKJDA<EKKGGLMMLBB, FAHHEMGEBFL> DDMMNIDAKPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private LONKLMLKJDA<EKKGGLMMLBB, KPJCIDKPECI> JADOCNIFIMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private List<Action> NLAANPMBHBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[CompilerGenerated]
		private Action<OPGJAFEOJCM<EKKGGLMMLBB>>? BPIGGCHCLOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[CompilerGenerated]
		private Action<OPGJAFEOJCM<EKKGGLMMLBB>, KPJCIDKPECI>? GODNEJGLLOM;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		protected IAAIBGHJPDJ ABMJDGEOAHB
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x55CA870", Offset = "0x55C9270", VA = "0x1855CA870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		protected KDNINCNMOIH FCEFMKNKMFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x55CDBB0", Offset = "0x55CC5B0", VA = "0x1855CDBB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		protected TNode PJGLMOMMKFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x885660", Offset = "0x884060", VA = "0x180885660")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public GBPONPDANLH<APFAGICDDPN> PDCPPGLCOLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0xD77A40", Offset = "0xD76440", VA = "0x180D77A40", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(GBPONPDANLH<APFAGICDDPN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public OPGJAFEOJCM<JPLNNLLINGO> AGFCHCIJMFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x55CFBE0", Offset = "0x55CE5E0", VA = "0x1855CFBE0", Slot = "6")]
			get
			{
				return default(OPGJAFEOJCM<JPLNNLLINGO>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public object ILOIGOCAOMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x3A92E90", Offset = "0x3A91890", VA = "0x183A92E90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public virtual bool BDFMKPPEPAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int CBBLFCJPJBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x55CF840", Offset = "0x55CE240", VA = "0x1855CF840", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public MKENJLKFIDM NKADPPHMABO
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x55CF7E0", Offset = "0x55CE1E0", VA = "0x1855CF7E0", Slot = "10")]
			get
			{
				return default(MKENJLKFIDM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string HJFBCPBGIBC
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x55CFD80", Offset = "0x55CE780", VA = "0x1855CFD80", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		protected virtual bool HIFLNILCFNM
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual NodeVisualizationKey NJIIHIBALEA
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public OPGJAFEOJCM<GHODFJBNMGI> BHAKIGCECHA
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x8FDDD0", Offset = "0x8FC7D0", VA = "0x1808FDDD0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(OPGJAFEOJCM<GHODFJBNMGI>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x900260", Offset = "0x8FEC60", VA = "0x180900260")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual bool FLIOCAFJIBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual bool GEBLOKMJHNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual MHFNHHDJPKL FEGADHCNIOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x9CEC30", Offset = "0x9CD630", VA = "0x1809CEC30", Slot = "94")]
			get
			{
				return default(MHFNHHDJPKL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool MOHDKHCCMHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x55CF550", Offset = "0x55CDF50", VA = "0x1855CF550", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool OBIIDBKAIDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x55CF5B0", Offset = "0x55CDFB0", VA = "0x1855CF5B0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool MDHCDCMIIGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x55CF610", Offset = "0x55CE010", VA = "0x1855CF610", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int EGICEBGBOCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x55CFB90", Offset = "0x55CE590", VA = "0x1855CFB90", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool BFKFIDGLMNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x55CF9C0", Offset = "0x55CE3C0", VA = "0x1855CF9C0", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool EEAPJOOFIOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x55CF720", Offset = "0x55CE120", VA = "0x1855CF720", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool ILHJJDEFMPE
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x55CF6C0", Offset = "0x55CE0C0", VA = "0x1855CF6C0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool GKFLOAMFGEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x9B5050", Offset = "0x9B3A50", VA = "0x1809B5050", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0xEADA80", Offset = "0xEAC480", VA = "0x180EADA80")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public virtual bool KCELBINGOPN
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual bool EOFEKINBCEO
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x55CF670", Offset = "0x55CE070", VA = "0x1855CF670", Slot = "96")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool CGKMBGHNFID
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x55CF8F0", Offset = "0x55CE2F0", VA = "0x1855CF8F0", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public NPLPCBACIIN AIFDJMPCLHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x55CFAD0", Offset = "0x55CE4D0", VA = "0x1855CFAD0", Slot = "28")]
			get
			{
				return default(NPLPCBACIIN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public DDFABOMDEOH HCLPIOBIAKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x55CFB30", Offset = "0x55CE530", VA = "0x1855CFB30", Slot = "30")]
			get
			{
				return default(DDFABOMDEOH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool PMKNOHGCCBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "108")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual HLFGPJBOCAM? KKDDNJLFEGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240", Slot = "109")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual OHGNMKFBAID? COCNDMIBKHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240", Slot = "110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual IEnumerable<GBPONPDANLH<BOAKMKENONJ>>? OLOEHKFADLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool CEHIICHFFMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x55CF780", Offset = "0x55CE180", VA = "0x1855CF780", Slot = "114")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public GBPONPDANLH<BLMFKKELJGG> BJFLPCFEENJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x55CFA10", Offset = "0x55CE410", VA = "0x1855CFA10", Slot = "62")]
			get
			{
				return default(GBPONPDANLH<BLMFKKELJGG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public OPGJAFEOJCM<BLMFKKELJGG> HNNILBPOLMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x55CF890", Offset = "0x55CE290", VA = "0x1855CF890", Slot = "56")]
			get
			{
				return default(OPGJAFEOJCM<BLMFKKELJGG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public virtual bool INMNKCHJBBG
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "115")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public virtual OPGJAFEOJCM<BLMFKKELJGG>? BJAHJDJKOGO
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240", Slot = "116")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public virtual bool AIKBBGAOENE
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool MGIEOPNHBEE
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x55CF950", Offset = "0x55CE350", VA = "0x1855CF950", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public string FMJDNGHFJGI
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x883D40", Offset = "0x882740", VA = "0x180883D40", Slot = "64")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x883E00", Offset = "0x882800", VA = "0x180883E00")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		private string KFEAENKILJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x883E40", Offset = "0x882840", VA = "0x180883E40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public GBPONPDANLH<BOAKMKENONJ> NFJNIMMLANP
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x55CFA70", Offset = "0x55CE470", VA = "0x1855CFA70", Slot = "63")]
			get
			{
				return default(GBPONPDANLH<BOAKMKENONJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public GBPONPDANLH<BOAKMKENONJ>? CEPNJKAEBIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x55CFC60", Offset = "0x55CE660", VA = "0x1855CFC60", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public GNGCBGLJKKH<EKKGGLMMLBB, KPJCIDKPECI> BKNECKJCLHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x55CFD40", Offset = "0x55CE740", VA = "0x1855CFD40", Slot = "65")]
			get
			{
				return default(GNGCBGLJKKH<EKKGGLMMLBB, KPJCIDKPECI>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public virtual OPGJAFEOJCM<EKKGGLMMLBB>? MEHMJPFABEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public virtual bool OOLONFPPOAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public virtual bool OEIFKFMLAMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "123")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action KCOGDEMIBOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x55CD220", Offset = "0x55CBC20", VA = "0x1855CD220", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x55CBB40", Offset = "0x55CA540", VA = "0x1855CBB40", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event ABMHDKMGDEK GIKAPBDCOCD
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x55CE880", Offset = "0x55CD280", VA = "0x1855CE880", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x55CB9E0", Offset = "0x55CA3E0", VA = "0x1855CB9E0", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event DCHGJIGFKBD BFHPCJDCPNO
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x55CAF40", Offset = "0x55C9940", VA = "0x1855CAF40", Slot = "41")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x55CBC70", Offset = "0x55CA670", VA = "0x1855CBC70", Slot = "42")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action MJNEGMFEIOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x55CA710", Offset = "0x55C9110", VA = "0x1855CA710", Slot = "43")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x55CDEE0", Offset = "0x55CC8E0", VA = "0x1855CDEE0", Slot = "44")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action FBGABMDKPKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x55CBDB0", Offset = "0x55CA7B0", VA = "0x1855CBDB0", Slot = "45")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x55CA600", Offset = "0x55C9000", VA = "0x1855CA600", Slot = "46")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<OPGJAFEOJCM<EKKGGLMMLBB>, KPJCIDKPECI> KCCBPHBEENF
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x55CDE20", Offset = "0x55CC820", VA = "0x1855CDE20", Slot = "67")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x55CA940", Offset = "0x55C9340", VA = "0x1855CA940", Slot = "68")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<OPGJAFEOJCM<EKKGGLMMLBB>, KPJCIDKPECI> HHLHFIBPPEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x55CE0D0", Offset = "0x55CCAD0", VA = "0x1855CE0D0", Slot = "71")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x55CEAA0", Offset = "0x55CD4A0", VA = "0x1855CEAA0", Slot = "72")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<OPGJAFEOJCM<EKKGGLMMLBB>> MGDNNEDMKKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x55CEBD0", Offset = "0x55CD5D0", VA = "0x1855CEBD0", Slot = "69")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x55CC9D0", Offset = "0x55CB3D0", VA = "0x1855CC9D0", Slot = "70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<OPGJAFEOJCM<EKKGGLMMLBB>, OPGJAFEOJCM<EKKGGLMMLBB>> LANAHDLAFCF
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x55CA540", Offset = "0x55C8F40", VA = "0x1855CA540", Slot = "73")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x55CDF40", Offset = "0x55CC940", VA = "0x1855CDF40", Slot = "74")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<OPGJAFEOJCM<EKKGGLMMLBB>, KPJCIDKPECI> PJGNKMPNCDB
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x55CE9E0", Offset = "0x55CD3E0", VA = "0x1855CE9E0", Slot = "75")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x55CE920", Offset = "0x55CD320", VA = "0x1855CE920", Slot = "76")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<OPGJAFEOJCM<EKKGGLMMLBB>, OPGJAFEOJCM<EKKGGLMMLBB>> CBBMFLEGMPM
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x55CBA80", Offset = "0x55CA480", VA = "0x1855CBA80", Slot = "77")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x55CAFE0", Offset = "0x55C99E0", VA = "0x1855CAFE0", Slot = "78")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x55CEF80", Offset = "0x55CD980", VA = "0x1855CEF80")]
		[EMMEDCCEFKJ("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		[EMMEDCCEFKJ("Need to handle `Name` better.")]
		protected CLAILBDGLKK(GMEBKHPMCKK EDAFBGDMGIM, TNode AOOGCKADIHP, bool DPIHLNCJPKH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x55CC2B0", Offset = "0x55CACB0", VA = "0x1855CC2B0", Slot = "87")]
		protected virtual void HINDDHMAHAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x55CB0A0", Offset = "0x55C9AA0", VA = "0x1855CB0A0", Slot = "88")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x55CB930", Offset = "0x55CA330", VA = "0x1855CB930", Slot = "9")]
		[AsyncStateMachine(typeof(CLAILBDGLKK<>.GMPJOFKDGJC))]
		public void EGPBEKNPEHH(int OBHMGNDMIPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x55CEB60", Offset = "0x55CD560", VA = "0x1855CEB60")]
		public bool PAMNIEEAHMJ([In] NPLPCBACIIN IPHMAHBENGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x55CA6A0", Offset = "0x55C90A0", VA = "0x1855CA6A0")]
		public bool BLLOKILOEAA([In] DDFABOMDEOH IPHMAHBENGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x55CE4C0", Offset = "0x55CCEC0", VA = "0x1855CE4C0", Slot = "32")]
		public void NHMAOPHOBCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x55CD2C0", Offset = "0x55CBCC0", VA = "0x1855CD2C0", Slot = "33")]
		[AsyncStateMachine(typeof(CLAILBDGLKK<>.NKPPHNPLGID))]
		public Task<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> JGLFCDMCMLC(NPLPCBACIIN? BJDMPNAKILN, DDFABOMDEOH? GPDCENANAMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "97")]
		public virtual void PBHFEIHLGKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "98")]
		public virtual void DJHLAEIKEAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "99")]
		public virtual void EIINMAAAMBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x98C2B0", Offset = "0x98ACB0", VA = "0x18098C2B0")]
		protected void DLDALICLFOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x9CB8A0", Offset = "0x9CA2A0", VA = "0x1809CB8A0")]
		protected void NGFCAMALAKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x231B7E0", Offset = "0x231A1E0", VA = "0x18231B7E0")]
		private void JJOPPMFNKJF([In] DDFABOMDEOH PCIAHIPKDFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x55CE000", Offset = "0x55CCA00", VA = "0x1855CE000", Slot = "100")]
		public virtual Task<CDOLGFBAJII<OPGJAFEOJCM<EKKGGLMMLBB>, IDHCEFLHBPO>> MNFDODKKMDA(string DDDMPLCOGIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x55CEEB0", Offset = "0x55CD8B0", VA = "0x1855CEEB0", Slot = "101")]
		public virtual Task<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> POLCECDFDGL(OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "102")]
		public virtual void BODGKFHEPAN(OPGJAFEOJCM<EKKGGLMMLBB> KAPKACHKPDJ, OPGJAFEOJCM<EKKGGLMMLBB> ODLFLNHIHIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x55CBBE0", Offset = "0x55CA5E0", VA = "0x1855CBBE0", Slot = "103")]
		public virtual IEnumerable<ONPEDCCMFKN> FELFMDEACLP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x55CA7E0", Offset = "0x55C91E0", VA = "0x1855CA7E0", Slot = "104")]
		public CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO> BPNHOIFIJAL(string LABADBANLNP)
		{
			return default(CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x55CCA90", Offset = "0x55CB490", VA = "0x1855CCA90", Slot = "47")]
		public bool ICIGIDOAALP([Out] Guid LHBBGMKOKEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x55CD410", Offset = "0x55CBE10", VA = "0x1855CD410")]
		public bool KLPHHHGHDDK([In] Guid FAABINMBEKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "105")]
		public virtual void NJEMNKBBDAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "106")]
		public virtual void LOPOJDBCHAF(bool OHPBLBMIGFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240", Slot = "107")]
		public virtual ELGALNCGBLP JPFKPCMPNLK([In] FHKBIOHAJLC HIHLFPAGMML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x55CD030", Offset = "0x55CBA30", VA = "0x1855CD030")]
		protected void JDPAGPJGOPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x55CA500", Offset = "0x55C8F00", VA = "0x1855CA500", Slot = "112")]
		protected virtual bool AOLCGCECJMC(OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "113")]
		protected virtual bool CJOODHFGHJE(OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "120")]
		protected virtual void MOPFLJOMLEP(LHLFFPAPFAD GLNDEBHNGKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x55CD6C0", Offset = "0x55CC0C0", VA = "0x1855CD6C0")]
		protected void KNFFPICHBLF(LHLFFPAPFAD FEGOCLLNBGG, Func<string> MJPGFHCLPIE, Action<string> FILFEKAOKDN, string CFJHFIEEHLI, string CIGHHPNODGB, string LIELDBIHDCM, GPBPHNHFHBH BOCCLCCOLLA, MPMJHNKDLAO MMPFOCHDJOK, Func<string, bool> NHNODPIMBEM, string ODBBMAOEEFF, Func<string, bool> OPJDBDCAIJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x55CE1D0", Offset = "0x55CCBD0", VA = "0x1855CE1D0")]
		protected void NALLJLDAMHI(LHLFFPAPFAD FEGOCLLNBGG, Func<string> MJPGFHCLPIE, Action<string> FILFEKAOKDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x55CEC90", Offset = "0x55CD690", VA = "0x1855CEC90", Slot = "121")]
		protected virtual void PNOGBFFMEFN(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x55CDCA0", Offset = "0x55CC6A0", VA = "0x1855CDCA0", Slot = "80")]
		public void LNLJGILCAFB(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x55CDAC0", Offset = "0x55CC4C0", VA = "0x1855CDAC0", Slot = "81")]
		public NFCBEHPCJJE LJGOOIMCHEM()
		{
			return default(NFCBEHPCJJE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "124")]
		public virtual bool KMAOIOBGFKE(OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x17461E0", Offset = "0x1744BE0", VA = "0x1817461E0")]
		private void OBDNKMKMJNG([In] NPLPCBACIIN EJEBFMEPKGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x55CE730", Offset = "0x55CD130", VA = "0x1855CE730")]
		private void NOIBOLOFJNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x55CAA00", Offset = "0x55C9400", VA = "0x1855CAA00")]
		private void DBJHPGPBCEE(OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB, IHEAGLBOCOB LKFCDKLBHDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0xAF2C30", Offset = "0xAF1630", VA = "0x180AF2C30")]
		private void IEGBJFHFHAB(OPGJAFEOJCM<EKKGGLMMLBB> DNICIAANFHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x55CDCF0", Offset = "0x55CC6F0", VA = "0x1855CDCF0")]
		private void MBNJHPKMICP(OPGJAFEOJCM<EKKGGLMMLBB> DNICIAANFHD, IHEAGLBOCOB DJKPNPACGPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x55CBF00", Offset = "0x55CA900", VA = "0x1855CBF00")]
		private void HHIJEGHKCDB(OPGJAFEOJCM<EKKGGLMMLBB> KAPKACHKPDJ, OPGJAFEOJCM<EKKGGLMMLBB> ODLFLNHIHIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xAF1C40", Offset = "0xAF0640", VA = "0x180AF1C40")]
		private void IMFCPKNEIKG(OPGJAFEOJCM<EKKGGLMMLBB> KAPKACHKPDJ, OPGJAFEOJCM<EKKGGLMMLBB> ODLFLNHIHIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x510C8F0", Offset = "0x510B2F0", VA = "0x18510C8F0")]
		private void ONJAAGFNAMD(OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x55CCBE0", Offset = "0x55CB5E0", VA = "0x1855CCBE0")]
		private void ICOBNOIDOEO(OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB, IHEAGLBOCOB LKFCDKLBHDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x55CBE90", Offset = "0x55CA890", VA = "0x1855CBE90")]
		private void HDLBNGCOIEE(OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB, IHEAGLBOCOB DJKPNPACGPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x55CA3E0", Offset = "0x55C8DE0", VA = "0x1855CA3E0", Slot = "125")]
		[AsyncStateMachine(typeof(CLAILBDGLKK<>.FGKDAJFKODP))]
		public Task<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> AELJMMJPAGA(string LABADBANLNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x55CA8D0", Offset = "0x55C92D0", VA = "0x1855CA8D0", Slot = "54")]
		private void CKBNEBEOPAI(object EGLKLFGDOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x55CE6C0", Offset = "0x55CD0C0", VA = "0x1855CE6C0", Slot = "55")]
		private void NIAINIPKCNO(object EGLKLFGDOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x55CCFF0", Offset = "0x55CB9F0", VA = "0x1855CCFF0", Slot = "29")]
		private bool IKABLHGIMPD([In] NPLPCBACIIN IPHMAHBENGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x55CE190", Offset = "0x55CCB90", VA = "0x1855CE190", Slot = "31")]
		private bool MPJCOFNIIJF([In] DDFABOMDEOH IPHMAHBENGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x55CBE50", Offset = "0x55CA850", VA = "0x1855CBE50", Slot = "48")]
		private bool GJEHGFHNOCJ([In] Guid FAABINMBEKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x4F06260", Offset = "0x4F04C60", VA = "0x184F06260")]
		[CompilerGenerated]
		private string IFNFPAMBNFP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x55CBD10", Offset = "0x55CA710", VA = "0x1855CBD10")]
		[CompilerGenerated]
		private void GEBHOAFENDD(string DDDMPLCOGIM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public sealed class DLPEMCBKFHC : DGPBFEOJDOC<NAEKOJPNFJM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public override NodeVisualizationKey NJIIHIBALEA
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x14A9080", Offset = "0x14A7A80", VA = "0x1814A9080", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x2114010", Offset = "0x2112A10", VA = "0x182114010")]
		public DLPEMCBKFHC(GMEBKHPMCKK EDAFBGDMGIM, NAEKOJPNFJM AOOGCKADIHP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class JPDIGBMPLEO : AAHALLLOAMD<NMGBALBJILD>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public override NodeVisualizationKey NJIIHIBALEA
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x913B40", Offset = "0x912540", VA = "0x180913B40", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x211E6B0", Offset = "0x211D0B0", VA = "0x18211E6B0")]
		public JPDIGBMPLEO(GMEBKHPMCKK EDAFBGDMGIM, NMGBALBJILD AOOGCKADIHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "120")]
		protected override void MOPFLJOMLEP(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public abstract class MCHNGCHGFDC<T> : CLAILBDGLKK<T> where T : notnull, JLHEHDLKMID
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class KFCKPFGKHID
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public IReadOnlyList<KeyValuePair<string, BIECMIJGBJH>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public MCHNGCHGFDC<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public KDNINCNMOIH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public EGELDPBGJHP clipType;

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public KFCKPFGKHID()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
			internal IReadOnlyList<KeyValuePair<string, BIECMIJGBJH>> GFLLLBNKMEP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x43D2B20", Offset = "0x43D1520", VA = "0x1843D2B20")]
			internal int CCIPCJDAKEC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x43D3040", Offset = "0x43D1A40", VA = "0x1843D3040")]
			internal void NCGMKKAOMNL(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x43D2F30", Offset = "0x43D1930", VA = "0x1843D2F30")]
			internal void INGCPGDHMAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x43D2C80", Offset = "0x43D1680", VA = "0x1843D2C80")]
			internal void DFEDGPCFJKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x43D2A90", Offset = "0x43D1490", VA = "0x1843D2A90")]
			internal bool HKOPNGOPLAM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x43D2A40", Offset = "0x43D1440", VA = "0x1843D2A40")]
			internal void BBGOGIALLJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x43D2A90", Offset = "0x43D1490", VA = "0x1843D2A90")]
			internal bool BGACIDJCELO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x43D2E90", Offset = "0x43D1890", VA = "0x1843D2E90")]
			internal float HKPAGECAHBK()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x43D2F80", Offset = "0x43D1980", VA = "0x1843D2F80")]
			internal void MLLFANMCCOK(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x43D3260", Offset = "0x43D1C60", VA = "0x1843D3260")]
			internal float OKDIBFOOGOM()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x43D32B0", Offset = "0x43D1CB0", VA = "0x1843D32B0")]
			internal void OOFNDCOJEIO(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x43D2EE0", Offset = "0x43D18E0", VA = "0x1843D2EE0")]
			internal float IEOEANPIKDD()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x43D2DD0", Offset = "0x43D17D0", VA = "0x1843D2DD0")]
			internal void EOPCOJIDNAJ(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override NodeVisualizationKey NJIIHIBALEA
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0xB06C30", Offset = "0xB05630", VA = "0x180B06C30", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public abstract EGELDPBGJHP EOBLIPBNCDC
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(Slot = "126")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x4690FE0", Offset = "0x468F9E0", VA = "0x184690FE0")]
		public MCHNGCHGFDC(GMEBKHPMCKK EDAFBGDMGIM, T AOOGCKADIHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x4690500", Offset = "0x468EF00", VA = "0x184690500", Slot = "120")]
		protected sealed override void MOPFLJOMLEP(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private sealed class HFDHCAKICJP : CLAILBDGLKK<CHHJGPPJICE>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public override NodeVisualizationKey NJIIHIBALEA
		{
			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x983C20", Offset = "0x982620", VA = "0x180983C20", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x211C050", Offset = "0x211AA50", VA = "0x18211C050")]
		public HFDHCAKICJP(GMEBKHPMCKK EDAFBGDMGIM, CHHJGPPJICE AOOGCKADIHP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class ONHNPMGJECH : CLAILBDGLKK<KCDGLCKMBKH>
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class AKHMMFAJNJG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public ONHNPMGJECH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public KDNINCNMOIH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public AKHMMFAJNJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x210BA00", Offset = "0x210A400", VA = "0x18210BA00")]
			internal int CCIPCJDAKEC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x210BA50", Offset = "0x210A450", VA = "0x18210BA50")]
			internal void NCGMKKAOMNL(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private static Dictionary<string, BIECMIJGBJH>? NFBIBIIMDLA;

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x2123A40", Offset = "0x2122440", VA = "0x182123A40")]
		public ONHNPMGJECH(GMEBKHPMCKK EDAFBGDMGIM, KCDGLCKMBKH AOOGCKADIHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x21236D0", Offset = "0x21220D0", VA = "0x1821236D0", Slot = "120")]
		protected override void MOPFLJOMLEP(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class KAMNEEGPJLA : MCHNGCHGFDC<JDIFFCIBOHC>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public override EGELDPBGJHP EOBLIPBNCDC
		{
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240", Slot = "126")]
			get
			{
				return default(EGELDPBGJHP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x211E710", Offset = "0x211D110", VA = "0x18211E710")]
		public KAMNEEGPJLA(GMEBKHPMCKK EDAFBGDMGIM, JDIFFCIBOHC KCEPABIAINB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class BOFFOABJAEB : AAHALLLOAMD<NJPPPKIDOBK>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public override NodeVisualizationKey NJIIHIBALEA
		{
			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x913B40", Offset = "0x912540", VA = "0x180913B40", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x2111F90", Offset = "0x2110990", VA = "0x182111F90")]
		public BOFFOABJAEB(GMEBKHPMCKK EDAFBGDMGIM, NJPPPKIDOBK AOOGCKADIHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "120")]
		protected override void MOPFLJOMLEP(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	private sealed class BMMANMKGAOF : AAHALLLOAMD<BECFCIMOBFF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public override NodeVisualizationKey NJIIHIBALEA
		{
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x913B40", Offset = "0x912540", VA = "0x180913B40", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x2111DB0", Offset = "0x21107B0", VA = "0x182111DB0")]
		public BMMANMKGAOF(GMEBKHPMCKK EDAFBGDMGIM, BECFCIMOBFF AOOGCKADIHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "120")]
		protected override void MOPFLJOMLEP(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class KOLNADNHKOM : INIJGFFMGIL<FIHPHNDEFAI>
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class PHLJFLMMMAA
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
				public PHLJFLMMMAA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40001E2")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40001E3")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40001E4")]
				private TaskAwaiter<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60003CB")]
				[Cpp2IlInjected.Address(RVA = "0x2126380", Offset = "0x2124D80", VA = "0x182126380", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CC")]
				[Cpp2IlInjected.Address(RVA = "0x8D8CD0", Offset = "0x8D76D0", VA = "0x1808D8CD0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public KDNINCNMOIH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public KOLNADNHKOM <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public PHLJFLMMMAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x2125E60", Offset = "0x2124860", VA = "0x182125E60")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void HLGCIODKNJJ(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x211F260", Offset = "0x211DC60", VA = "0x18211F260")]
		public KOLNADNHKOM(GMEBKHPMCKK EDAFBGDMGIM, FIHPHNDEFAI KCEPABIAINB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x211EF80", Offset = "0x211D980", VA = "0x18211EF80", Slot = "126")]
		protected override void FDEFOKGCBMK(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class CGICGKCEJMP : MCHNGCHGFDC<OEJCOCDJEND>
	{
		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override EGELDPBGJHP EOBLIPBNCDC
		{
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0x975850", Offset = "0x974250", VA = "0x180975850", Slot = "126")]
			get
			{
				return default(EGELDPBGJHP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x2112820", Offset = "0x2111220", VA = "0x182112820")]
		public CGICGKCEJMP(GMEBKHPMCKK EDAFBGDMGIM, OEJCOCDJEND KCEPABIAINB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private sealed class DNCMJKNBKHI : CLAILBDGLKK<GKGCBIFDEII>
	{
		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public override NodeVisualizationKey NJIIHIBALEA
		{
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0xB52300", Offset = "0xB50D00", VA = "0x180B52300", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x2114150", Offset = "0x2112B50", VA = "0x182114150")]
		public DNCMJKNBKHI(GMEBKHPMCKK EDAFBGDMGIM, GKGCBIFDEII AOOGCKADIHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "120")]
		protected override void MOPFLJOMLEP(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public sealed class MKPFLEFBLNE : CLAILBDGLKK<FEGKNJHPPEC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public sealed override NodeVisualizationKey NJIIHIBALEA
		{
			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public sealed override bool FLIOCAFJIBO
		{
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected sealed override bool HIFLNILCFNM
		{
			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x2122450", Offset = "0x2120E50", VA = "0x182122450")]
		public MKPFLEFBLNE(GMEBKHPMCKK EDAFBGDMGIM, FEGKNJHPPEC AOOGCKADIHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x2122120", Offset = "0x2120B20", VA = "0x182122120", Slot = "120")]
		protected override void MOPFLJOMLEP(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x2122080", Offset = "0x2120A80", VA = "0x182122080")]
		private int AGLCNAADLAP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x21220C0", Offset = "0x2120AC0", VA = "0x1821220C0")]
		private void EDPPMEEPMMO(int OEDIDFDHHOH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public class ICGKBNFKAHA : FCDLDJLIPCI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x211AC80", Offset = "0x2119680", VA = "0x18211AC80")]
		public ICGKBNFKAHA(GMEBKHPMCKK EDAFBGDMGIM, KGLMPAAGOHB AOOGCKADIHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "120")]
		protected override void MOPFLJOMLEP(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class BHHFAAFGALO : INIJGFFMGIL<NILIJIEDDBF>
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x2111810", Offset = "0x2110210", VA = "0x182111810")]
		public BHHFAAFGALO(GMEBKHPMCKK EDAFBGDMGIM, NILIJIEDDBF AOOGCKADIHP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public abstract class INIJGFFMGIL<TVariableNode> : CLAILBDGLKK<TVariableNode> where TVariableNode : notnull, NILIJIEDDBF
	{
		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		[CompilerGenerated]
		private sealed class OGKNDBKOFAF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public INIJGFFMGIL<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public KDNINCNMOIH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public OGKNDBKOFAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x48FD120", Offset = "0x48FBB20", VA = "0x1848FD120")]
			internal bool GFLLLBNKMEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x48FCFB0", Offset = "0x48FB9B0", VA = "0x1848FCFB0")]
			internal void CCIPCJDAKEC(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x48FD240", Offset = "0x48FBC40", VA = "0x1848FD240")]
			internal bool NCGMKKAOMNL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x48FD180", Offset = "0x48FBB80", VA = "0x1848FD180")]
			internal void INGCPGDHMAE(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x48FD070", Offset = "0x48FBA70", VA = "0x1848FD070")]
			internal bool DFEDGPCFJKJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		[CompilerGenerated]
		private sealed class EHPONEBCHIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public KDNINCNMOIH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public INIJGFFMGIL<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public EHPONEBCHIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x3A1A230", Offset = "0x3A18C30", VA = "0x183A1A230")]
			internal void HLGCIODKNJJ(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public override NodeVisualizationKey NJIIHIBALEA
		{
			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0xCD1250", Offset = "0xCCFC50", VA = "0x180CD1250", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public override MHFNHHDJPKL FEGADHCNIOA
		{
			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x40CD5C0", Offset = "0x40CBFC0", VA = "0x1840CD5C0", Slot = "94")]
			get
			{
				return default(MHFNHHDJPKL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x40CD420", Offset = "0x40CBE20", VA = "0x1840CD420")]
		protected INIJGFFMGIL(GMEBKHPMCKK EDAFBGDMGIM, TVariableNode AOOGCKADIHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x40CC990", Offset = "0x40CB390", VA = "0x1840CC990", Slot = "88")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x40CCEA0", Offset = "0x40CB8A0", VA = "0x1840CCEA0", Slot = "120")]
		protected override void MOPFLJOMLEP(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x40CCB10", Offset = "0x40CB510", VA = "0x1840CCB10", Slot = "126")]
		protected virtual void FDEFOKGCBMK(LHLFFPAPFAD FEGOCLLNBGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x40CD330", Offset = "0x40CBD30", VA = "0x1840CD330", Slot = "105")]
		public override void NJEMNKBBDAD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x20ED3F0", Offset = "0x20EBDF0", VA = "0x1820ED3F0")]
	public static DKCJHFLDAAD OOAFHJGKFEK(GMEBKHPMCKK EDAFBGDMGIM, KGLMPAAGOHB AOOGCKADIHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public sealed class ANGNLEBIGCJ : PAHHDFCJJAM, JLPONLFAJEE, CGHMBKNDPCI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public OPGJAFEOJCM<KJIBBALNENC> JLKKDKGFNJK
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x9363A0", Offset = "0x934DA0", VA = "0x1809363A0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(OPGJAFEOJCM<KJIBBALNENC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public OPGJAFEOJCM<LENKNJAGABN> EKJDJCBFNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x9363C0", Offset = "0x934DC0", VA = "0x1809363C0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(OPGJAFEOJCM<LENKNJAGABN>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x210BFD0", Offset = "0x210A9D0", VA = "0x18210BFD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private OPGJAFEOJCM<MINNOGPCNLA> IEMLIAJPPKL
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x996A80", Offset = "0x995480", VA = "0x180996A80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public override OPGJAFEOJCM<KGPCIMGKNIP> GEIFKBEGPML
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x210BFE0", Offset = "0x210A9E0", VA = "0x18210BFE0", Slot = "20")]
		get
		{
			return default(OPGJAFEOJCM<KGPCIMGKNIP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x210C380", Offset = "0x210AD80", VA = "0x18210C380")]
	private ANGNLEBIGCJ(GMEBKHPMCKK EDAFBGDMGIM, KGLMPAAGOHB AOOGCKADIHP, MDJOJKEOELK BPJECOEGMCE, OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB, OPGJAFEOJCM<LENKNJAGABN> AENNIDBABCK, OPGJAFEOJCM<MINNOGPCNLA> GGADFIEHJHB, bool HIJGEDHEKJL, string DDDMPLCOGIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x210C030", Offset = "0x210AA30", VA = "0x18210C030")]
	public static ANGNLEBIGCJ OOAFHJGKFEK(GMEBKHPMCKK EDAFBGDMGIM, KGLMPAAGOHB AOOGCKADIHP, MDJOJKEOELK GECGGIHOOIJ, OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB, OPGJAFEOJCM<MINNOGPCNLA> GGADFIEHJHB, OPGJAFEOJCM<LENKNJAGABN> AENNIDBABCK, bool HIJGEDHEKJL, bool DPIHLNCJPKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x210BFD0", Offset = "0x210A9D0", VA = "0x18210BFD0")]
	internal void BBLDLJNOENF(OPGJAFEOJCM<LENKNJAGABN> IPHMAHBENGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public abstract class PAHHDFCJJAM : CGHMBKNDPCI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct GABMLMDAOEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private OLJEKIMOJHP? EHALEGGFGJI;

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x211B5D0", Offset = "0x2119FD0", VA = "0x18211B5D0")]
		public void ODPBLJHKGDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x211B530", Offset = "0x2119F30", VA = "0x18211B530")]
		public OLJEKIMOJHP LALOILKBDGJ(PAHHDFCJJAM HOPLOAABACG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	protected readonly GMEBKHPMCKK ABJOCPNGLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	protected readonly KGLMPAAGOHB GLAIEJJLGLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private GABMLMDAOEJ KKLKDDAAFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly ELNPOIIFOJK KMADHNNGMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private readonly List<HPKKJGMDMPG> JPMEFAODHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private readonly List<JDEMDIOIKGF> APPJGPDGFOJ;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	[EMMEDCCEFKJ("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> KDDLLOKDAJI
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x2124840", Offset = "0x2123240", VA = "0x182124840", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public DisplayKind JPNDNMHNBBK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x893070", Offset = "0x891A70", VA = "0x180893070", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public OPGJAFEOJCM<BLMFKKELJGG> HNNILBPOLMM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x2124DA0", Offset = "0x21237A0", VA = "0x182124DA0", Slot = "6")]
		get
		{
			return default(OPGJAFEOJCM<BLMFKKELJGG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public GBPONPDANLH<BLMFKKELJGG> BJFLPCFEENJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x2125A80", Offset = "0x2124480", VA = "0x182125A80", Slot = "7")]
		get
		{
			return default(GBPONPDANLH<BLMFKKELJGG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public GJHLAECHCCP HPALOINBIMG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x1F50460", Offset = "0x1F4EE60", VA = "0x181F50460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public OGPEJKGOPJN FFGMEBAPLGA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x2124CA0", Offset = "0x21236A0", VA = "0x182124CA0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	protected OLJEKIMOJHP CLJLBDIGPPF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x2124CA0", Offset = "0x21236A0", VA = "0x182124CA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public PortImage EGPHLBCNMIM
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x2125AB0", Offset = "0x21244B0", VA = "0x182125AB0", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public string FMJDNGHFJGI
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x883D50", Offset = "0x882750", VA = "0x180883D50", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x883E30", Offset = "0x882830", VA = "0x180883E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public GBPONPDANLH<BOAKMKENONJ> NFJNIMMLANP
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x2124B30", Offset = "0x2123530", VA = "0x182124B30", Slot = "9")]
		get
		{
			return default(GBPONPDANLH<BOAKMKENONJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public OPGJAFEOJCM<EKKGGLMMLBB> CJFDAOCKINN
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x9361B0", Offset = "0x934BB0", VA = "0x1809361B0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(OPGJAFEOJCM<EKKGGLMMLBB>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x935270", Offset = "0x933C70", VA = "0x180935270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public abstract OPGJAFEOJCM<KGPCIMGKNIP> GEIFKBEGPML
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x2125BE0", Offset = "0x21245E0", VA = "0x182125BE0")]
	protected PAHHDFCJJAM(GMEBKHPMCKK EDAFBGDMGIM, KGLMPAAGOHB AOOGCKADIHP, ELNPOIIFOJK FKLKJMACJGM, OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB, bool HIJGEDHEKJL, string DDDMPLCOGIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x2124E30", Offset = "0x2123830", VA = "0x182124E30", Slot = "21")]
	protected virtual void HINDDHMAHAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x2124B50", Offset = "0x2123550", VA = "0x182124B50", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x21259A0", Offset = "0x21243A0", VA = "0x1821259A0", Slot = "14")]
	public void JLLFCIFBLPB(HPKKJGMDMPG DCNJJNPNFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x2124D40", Offset = "0x2123740", VA = "0x182124D40", Slot = "15")]
	public void FJBHBAIMJAO(JDEMDIOIKGF DCNJJNPNFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x21252C0", Offset = "0x2123CC0", VA = "0x1821252C0", Slot = "16")]
	public void IGNGIBKMIBO(FPBJAJPEPML NAPHHBACMBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x2125A20", Offset = "0x2124420", VA = "0x182125A20", Slot = "23")]
	protected virtual void OBIMCBNLFOE(FPBJAJPEPML NAPHHBACMBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x2125130", Offset = "0x2123B30", VA = "0x182125130")]
	private void HNHNOMOAPCO(bool DICHKFJDHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x2124980", Offset = "0x2123380", VA = "0x182124980")]
	private void BJNMLOFNBGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x2124F80", Offset = "0x2123980", VA = "0x182124F80")]
	private void HNFNFNMOJHC([In] EJMEKLPMJIF LIGBEPPCMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x2124DD0", Offset = "0x21237D0", VA = "0x182124DD0", Slot = "17")]
	public void HICFNJFLONJ(HPKKJGMDMPG DCNJJNPNFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x2125940", Offset = "0x2124340", VA = "0x182125940", Slot = "18")]
	public void ILBFGKLDKHA(JDEMDIOIKGF DCNJJNPNFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x883E30", Offset = "0x882830", VA = "0x180883E30")]
	internal void LMMDIKNJOEO(string DDDMPLCOGIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x2125A00", Offset = "0x2124400", VA = "0x182125A00")]
	internal void NAIPOGBFEPL(AHJIOLBHNBN HBFCALFCDLO, GJHLAECHCCP AOGCIMANLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x935270", Offset = "0x933C70", VA = "0x180935270")]
	internal void ALBKLINDOLJ(OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public sealed class FAHHEMGEBFL : KPJCIDKPECI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class PBEHPFJGNDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public GMEBKHPMCKK circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public KGLMPAAGOHB node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public OPGJAFEOJCM<EKKGGLMMLBB> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public PBEHPFJGNDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x2125DD0", Offset = "0x21247D0", VA = "0x182125DD0")]
		internal LFLBFBCNCBE OHONGPBLHDA((int PortDescIndex, int PortIndex, JMDNCKPHILD InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x2125D40", Offset = "0x2124740", VA = "0x182125D40")]
		internal ANGNLEBIGCJ FODMFEFPGOC(MDJOJKEOELK i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct KLOBNPEJIKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public FAHHEMGEBFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private NMFMPDHEBKA <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private TaskAwaiter<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x211EAB0", Offset = "0x211D4B0", VA = "0x18211EAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x211EF10", Offset = "0x211D910", VA = "0x18211EF10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct DBMMLLLELAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public FAHHEMGEBFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public OPGJAFEOJCM<OGBOHDOOEJL> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private NMFMPDHEBKA <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private TaskAwaiter<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x21131E0", Offset = "0x2111BE0", VA = "0x1821131E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x2113530", Offset = "0x2111F30", VA = "0x182113530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct OFBOFEACFBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public FAHHEMGEBFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public OPGJAFEOJCM<MINNOGPCNLA> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private NMFMPDHEBKA <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private TaskAwaiter<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x2123310", Offset = "0x2121D10", VA = "0x182123310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x2123660", Offset = "0x2122060", VA = "0x182123660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct AGEOOOJLLHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public FAHHEMGEBFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public OPGJAFEOJCM<OGBOHDOOEJL> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public OPGJAFEOJCM<OGBOHDOOEJL> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private NMFMPDHEBKA <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private TaskAwaiter<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x210B640", Offset = "0x210A040", VA = "0x18210B640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x210B990", Offset = "0x210A390", VA = "0x18210B990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct IDPOKECGCID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public FAHHEMGEBFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public OPGJAFEOJCM<MINNOGPCNLA> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public OPGJAFEOJCM<MINNOGPCNLA> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private NMFMPDHEBKA <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private TaskAwaiter<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x211CF90", Offset = "0x211B990", VA = "0x18211CF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x211D2E0", Offset = "0x211BCE0", VA = "0x18211D2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct BIANJJLKBJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public FAHHEMGEBFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private NMFMPDHEBKA <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private TaskAwaiter<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x2111870", Offset = "0x2110270", VA = "0x182111870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x2111CE0", Offset = "0x21106E0", VA = "0x182111CE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct JENFEMAOONO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public FAHHEMGEBFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private NMFMPDHEBKA <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private TaskAwaiter<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x211DBD0", Offset = "0x211C5D0", VA = "0x18211DBD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x211DF20", Offset = "0x211C920", VA = "0x18211DF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct CPJNIDCDIKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public FAHHEMGEBFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public OPGJAFEOJCM<OGBOHDOOEJL> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private NMFMPDHEBKA <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private TaskAwaiter<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x2112E20", Offset = "0x2111820", VA = "0x182112E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x2113170", Offset = "0x2111B70", VA = "0x182113170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct MKBBDMCEFBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public FAHHEMGEBFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public OPGJAFEOJCM<MINNOGPCNLA> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private NMFMPDHEBKA <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private TaskAwaiter<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x2121CC0", Offset = "0x21206C0", VA = "0x182121CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x2122010", Offset = "0x2120A10", VA = "0x182122010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct ANBDCGINNNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public FAHHEMGEBFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public IDJOALMKCOO type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public OPGJAFEOJCM<OGBOHDOOEJL> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private NMFMPDHEBKA <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private TaskAwaiter<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x210BBD0", Offset = "0x210A5D0", VA = "0x18210BBD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x210BF60", Offset = "0x210A960", VA = "0x18210BF60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct FLMJLLJFNKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public FAHHEMGEBFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public IDJOALMKCOO type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public OPGJAFEOJCM<MINNOGPCNLA> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private NMFMPDHEBKA <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private TaskAwaiter<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x211B130", Offset = "0x2119B30", VA = "0x18211B130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x211B4C0", Offset = "0x2119EC0", VA = "0x18211B4C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private readonly bool BCPGPCGOGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly GMEBKHPMCKK ABJOCPNGLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private readonly bool BNNPGDGOANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private GNGCBGLJKKH<LBLICMJLFMO, LFLBFBCNCBE> GBKJDJGBDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private GNGCBGLJKKH<LBLICMJLFMO, ICPCFJHFNLO> LKIEBEPDBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private readonly KGLMPAAGOHB GLAIEJJLGLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private GNGCBGLJKKH<LENKNJAGABN, ANGNLEBIGCJ> FLOPNNNIAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private GNGCBGLJKKH<LENKNJAGABN, JLPONLFAJEE> AJNDEOLKFPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private string? EOIJGPHNHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private readonly IHEAGLBOCOB IFJPNHPLJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private OPGJAFEOJCM<EKKGGLMMLBB> BFAPMJBENHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private readonly bool ONDGAPDNHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	[CompilerGenerated]
	private Action? BNBJOMBJMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	[CompilerGenerated]
	private Action? MPGMFHBBAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	[CompilerGenerated]
	private Action<OPGJAFEOJCM<LBLICMJLFMO>>? EPIAGAELLGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	[CompilerGenerated]
	private Action<OPGJAFEOJCM<LENKNJAGABN>>? HOLMEEFKNJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	[CompilerGenerated]
	private KPJCIDKPECI.GOAJJPNAJBK? AGJHLDNCDJK;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool DHGBEGFNAJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x2117C60", Offset = "0x2116660", VA = "0x182117C60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool CKGPEGHICMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x2119B40", Offset = "0x2118540", VA = "0x182119B40", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool GAGDJBMBHPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x211A120", Offset = "0x2118B20", VA = "0x18211A120", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public GBPONPDANLH<BLMFKKELJGG> BJFLPCFEENJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x211A0F0", Offset = "0x2118AF0", VA = "0x18211A0F0", Slot = "7")]
		get
		{
			return default(GBPONPDANLH<BLMFKKELJGG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool JNLFFEPEIPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x2115B50", Offset = "0x2114550", VA = "0x182115B50", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public GNGCBGLJKKH<LBLICMJLFMO, ICPCFJHFNLO> EMCGBNEDFLO
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x885660", Offset = "0x884060", VA = "0x180885660", Slot = "9")]
		get
		{
			return default(GNGCBGLJKKH<LBLICMJLFMO, ICPCFJHFNLO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public string FMJDNGHFJGI
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x2114580", Offset = "0x2112F80", VA = "0x182114580", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public GBPONPDANLH<BOAKMKENONJ> NFJNIMMLANP
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x2115B30", Offset = "0x2114530", VA = "0x182115B30", Slot = "11")]
		get
		{
			return default(GBPONPDANLH<BOAKMKENONJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public GNGCBGLJKKH<LENKNJAGABN, JLPONLFAJEE> BBGDCHBMBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x883D50", Offset = "0x882750", VA = "0x180883D50", Slot = "12")]
		get
		{
			return default(GNGCBGLJKKH<LENKNJAGABN, JLPONLFAJEE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public OPGJAFEOJCM<EKKGGLMMLBB> CJFDAOCKINN
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x9363B0", Offset = "0x934DB0", VA = "0x1809363B0", Slot = "13")]
		get
		{
			return default(OPGJAFEOJCM<EKKGGLMMLBB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action GGFFOGKOPKC
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x2114A20", Offset = "0x2113420", VA = "0x182114A20", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x2114AC0", Offset = "0x21134C0", VA = "0x182114AC0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action MILINKNJLMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x2118D90", Offset = "0x2117790", VA = "0x182118D90", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x2118F60", Offset = "0x2117960", VA = "0x182118F60", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<OPGJAFEOJCM<LBLICMJLFMO>, OPGJAFEOJCM<LBLICMJLFMO>> OBALKGCPKDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x2115340", Offset = "0x2113D40", VA = "0x182115340", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x2116DF0", Offset = "0x21157F0", VA = "0x182116DF0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<OPGJAFEOJCM<LBLICMJLFMO>, OPGJAFEOJCM<LBLICMJLFMO>> AGKOGJECJII
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x2118C10", Offset = "0x2117610", VA = "0x182118C10", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x2115400", Offset = "0x2113E00", VA = "0x182115400", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<OPGJAFEOJCM<LENKNJAGABN>, OPGJAFEOJCM<LENKNJAGABN>> PFKFKFNAGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x211A1E0", Offset = "0x2118BE0", VA = "0x18211A1E0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x211A390", Offset = "0x2118D90", VA = "0x18211A390", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<OPGJAFEOJCM<LENKNJAGABN>, OPGJAFEOJCM<LENKNJAGABN>> NGPLGHKAOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x2115F70", Offset = "0x2114970", VA = "0x182115F70", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x21186B0", Offset = "0x21170B0", VA = "0x1821186B0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<OPGJAFEOJCM<LBLICMJLFMO>, ICPCFJHFNLO> JEPAKDHDDCL
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x2118CD0", Offset = "0x21176D0", VA = "0x182118CD0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x2119160", Offset = "0x2117B60", VA = "0x182119160", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<OPGJAFEOJCM<LBLICMJLFMO>> GAADNMACLCL
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x2119350", Offset = "0x2117D50", VA = "0x182119350", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x2117E40", Offset = "0x2116840", VA = "0x182117E40", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<OPGJAFEOJCM<LBLICMJLFMO>, ICPCFJHFNLO> AIPKPPFCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x21187B0", Offset = "0x21171B0", VA = "0x1821187B0", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x2116C20", Offset = "0x2115620", VA = "0x182116C20", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<OPGJAFEOJCM<LENKNJAGABN>, JLPONLFAJEE> CBBGFHONMCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x2117990", Offset = "0x2116390", VA = "0x182117990", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x2115280", Offset = "0x2113C80", VA = "0x182115280", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<OPGJAFEOJCM<LENKNJAGABN>> FFPALIHAPII
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x2119850", Offset = "0x2118250", VA = "0x182119850", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x2119520", Offset = "0x2117F20", VA = "0x182119520", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<OPGJAFEOJCM<LENKNJAGABN>, JLPONLFAJEE> KPJEELAHLLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x2119640", Offset = "0x2118040", VA = "0x182119640", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x2115090", Offset = "0x2113A90", VA = "0x182115090", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x211A450", Offset = "0x2118E50", VA = "0x18211A450")]
	private FAHHEMGEBFL(bool HIJGEDHEKJL, GMEBKHPMCKK EDAFBGDMGIM, bool GLFGHMONAPB, GNGCBGLJKKH<LBLICMJLFMO, LFLBFBCNCBE> BAEJABIFIKO, GNGCBGLJKKH<LBLICMJLFMO, ICPCFJHFNLO> GCIJAHABNEK, KGLMPAAGOHB AOOGCKADIHP, GNGCBGLJKKH<LENKNJAGABN, ANGNLEBIGCJ> HAOMFAELCOC, GNGCBGLJKKH<LENKNJAGABN, JLPONLFAJEE> CAFAOOJLBJN, string? KEDGCCLDEOK, IHEAGLBOCOB LKFCDKLBHDN, OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB, bool DPIHLNCJPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x2119B80", Offset = "0x2118580", VA = "0x182119B80")]
	public static FAHHEMGEBFL OOAFHJGKFEK(bool HIJGEDHEKJL, GMEBKHPMCKK EDAFBGDMGIM, bool GLFGHMONAPB, KGLMPAAGOHB AOOGCKADIHP, IHEAGLBOCOB LKFCDKLBHDN, OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB, bool DPIHLNCJPKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x2117F00", Offset = "0x2116900", VA = "0x182117F00")]
	private void HINDDHMAHAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x2116030", Offset = "0x2114A30", VA = "0x182116030", Slot = "49")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x2119430", Offset = "0x2117E30", VA = "0x182119430", Slot = "38")]
	[AsyncStateMachine(typeof(KLOBNPEJIKM))]
	public Task<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> MPHFFCNMMBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x2119910", Offset = "0x2118310", VA = "0x182119910")]
	private (KNBEAEHFBHG, int)? OLCNMDJHCMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x2117A50", Offset = "0x2116450", VA = "0x182117A50")]
	private void GBAOMNFMLDP(int HHPIMAEIDDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x1766A20", Offset = "0x1765420", VA = "0x181766A20")]
	private void AMBJFEOIENP(int HHPIMAEIDDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x2118870", Offset = "0x2117270", VA = "0x182118870")]
	private void IMEOMENPIIL(int IAJDLMDGOBN, int BLKGBDGLAHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x2114F20", Offset = "0x2113920", VA = "0x182114F20")]
	private void ALCMHIGAGBD(int IAJDLMDGOBN, int BLKGBDGLAHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x2117430", Offset = "0x2115E30", VA = "0x182117430")]
	private void FIPBJOEOBFO(int HHPIMAEIDDC, OPGJAFEOJCM<LBLICMJLFMO> DGCLDFGDPKJ, JMDNCKPHILD DKCAIIDABEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x2117970", Offset = "0x2116370", VA = "0x182117970")]
	private void FJKHCOFJJFH(int DICHKFJDHIG, OPGJAFEOJCM<LBLICMJLFMO> DGCLDFGDPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x2118790", Offset = "0x2117190", VA = "0x182118790")]
	private void IFIKDBODLED(int DICHKFJDHIG, OPGJAFEOJCM<LBLICMJLFMO> DGCLDFGDPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x2116EB0", Offset = "0x21158B0", VA = "0x182116EB0")]
	private void FEMJEJIMFNJ(int HHPIMAEIDDC, OPGJAFEOJCM<LBLICMJLFMO> DGCLDFGDPKJ, JMDNCKPHILD DKCAIIDABEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x2119010", Offset = "0x2117A10", VA = "0x182119010")]
	private void KGDPKABACJB(int HHPIMAEIDDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0xD09090", Offset = "0xD07A90", VA = "0x180D09090")]
	private void GMAOILFKEJB(int HHPIMAEIDDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x211A2A0", Offset = "0x2118CA0", VA = "0x18211A2A0")]
	private void PKOGFMCCMPF(int HHPIMAEIDDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x1766A20", Offset = "0x1765420", VA = "0x181766A20")]
	private void JDPJOCBEJNH(int HHPIMAEIDDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x2115BD0", Offset = "0x21145D0", VA = "0x182115BD0")]
	private void DMGMDBMELFO(int IAJDLMDGOBN, int BLKGBDGLAHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x21195E0", Offset = "0x2117FE0", VA = "0x1821195E0")]
	private void NMBKLDJOKJB(int IAJDLMDGOBN, int BLKGBDGLAHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x21155F0", Offset = "0x2113FF0", VA = "0x1821155F0")]
	private void DAKIMMCPBNI(int HHPIMAEIDDC, OPGJAFEOJCM<LENKNJAGABN> DGCLDFGDPKJ, MDJOJKEOELK DKCAIIDABEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x2119410", Offset = "0x2117E10", VA = "0x182119410")]
	private void MODOFECLIMC(int DICHKFJDHIG, OPGJAFEOJCM<LENKNJAGABN> DGCLDFGDPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x2118770", Offset = "0x2117170", VA = "0x182118770")]
	private void IBJJANJCAJF(int DICHKFJDHIG, OPGJAFEOJCM<LENKNJAGABN> DGCLDFGDPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x21145B0", Offset = "0x2112FB0", VA = "0x1821145B0")]
	private void ABMGDMGLLDI(int HHPIMAEIDDC, OPGJAFEOJCM<LENKNJAGABN> DGCLDFGDPKJ, MDJOJKEOELK DKCAIIDABEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x2119700", Offset = "0x2118100", VA = "0x182119700")]
	private void OAODOMAMLCB(int HHPIMAEIDDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0xD09090", Offset = "0xD07A90", VA = "0x180D09090")]
	private void LDNGJFCAKJH(int HHPIMAEIDDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x2116CE0", Offset = "0x21156E0", VA = "0x182116CE0", Slot = "39")]
	[AsyncStateMachine(typeof(DBMMLLLELAC))]
	public Task<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> EJEDBAGCCKG(OPGJAFEOJCM<OGBOHDOOEJL> AMMAKLHFFNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x2114F80", Offset = "0x2113980", VA = "0x182114F80", Slot = "40")]
	[AsyncStateMachine(typeof(OFBOFEACFBD))]
	public Task<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> BBGJMFCJAON(OPGJAFEOJCM<MINNOGPCNLA> GGADFIEHJHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x2117D20", Offset = "0x2116720", VA = "0x182117D20", Slot = "41")]
	[AsyncStateMachine(typeof(AGEOOOJLLHB))]
	public Task<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> HCIPEEAFGDM(OPGJAFEOJCM<OGBOHDOOEJL> AMMAKLHFFNJ, OPGJAFEOJCM<OGBOHDOOEJL> FCBHLAMJJBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x2117B40", Offset = "0x2116540", VA = "0x182117B40", Slot = "42")]
	[AsyncStateMachine(typeof(IDPOKECGCID))]
	public Task<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> GDMFPCJBILP(OPGJAFEOJCM<MINNOGPCNLA> GGADFIEHJHB, OPGJAFEOJCM<MINNOGPCNLA> FCBHLAMJJBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x2116B30", Offset = "0x2115530", VA = "0x182116B30", Slot = "43")]
	[AsyncStateMachine(typeof(BIANJJLKBJI))]
	public Task<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> EBHCGGBHNBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x2118E40", Offset = "0x2117840", VA = "0x182118E40", Slot = "44")]
	[AsyncStateMachine(typeof(JENFEMAOONO))]
	public Task<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> KCHNIODIODL(string LABADBANLNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x2119220", Offset = "0x2117C20", VA = "0x182119220", Slot = "45")]
	[AsyncStateMachine(typeof(CPJNIDCDIKK))]
	public Task<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> LCCMNHIPCHK(OPGJAFEOJCM<OGBOHDOOEJL> AMMAKLHFFNJ, string DDDMPLCOGIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x2117300", Offset = "0x2115D00", VA = "0x182117300", Slot = "46")]
	[AsyncStateMachine(typeof(MKBBDMCEFBD))]
	public Task<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> FHOEJIEAEEL(OPGJAFEOJCM<MINNOGPCNLA> GGADFIEHJHB, string DDDMPLCOGIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x21154C0", Offset = "0x2113EC0", VA = "0x1821154C0", Slot = "47")]
	[AsyncStateMachine(typeof(ANBDCGINNNC))]
	public Task<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> CPCHMIACFIE(OPGJAFEOJCM<OGBOHDOOEJL> AMMAKLHFFNJ, IDJOALMKCOO AOGCIMANLIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x2115150", Offset = "0x2113B50", VA = "0x182115150", Slot = "48")]
	[AsyncStateMachine(typeof(FLMJLLJFNKA))]
	public Task<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> BEIMGCDJOIP(OPGJAFEOJCM<MINNOGPCNLA> GGADFIEHJHB, IDJOALMKCOO AOGCIMANLIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x2114B60", Offset = "0x2113560", VA = "0x182114B60")]
	internal void ALBKLINDOLJ(OPGJAFEOJCM<EKKGGLMMLBB> IPHMAHBENGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public sealed class IBLIGLOHNNH : GBCABGGBFOO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public interface PPLIKKPEOIF
	{
		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		AHJIOLBHNBN CGBGBIMLKEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<JEEOGCMCDDH> NGDJMMLGOPG(CancellationToken LOIOCMLGMKH);

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<GHGEAPMBJNK> GIMILCADADE(CancellationToken LOIOCMLGMKH);

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<NHAKOHKGGMG> IJFCBPAGFJO(CancellationToken LOIOCMLGMKH);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct PABJCIMHPJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<IBLIGLOHNNH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public GMEBKHPMCKK circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public JEEOGCMCDDH roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public GHGEAPMBJNK superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private PPLIKKPEOIF <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private GHGEAPMBJNK <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter<JEEOGCMCDDH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private TaskAwaiter<GHGEAPMBJNK> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter<NHAKOHKGGMG> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private TaskAwaiter<LFOCNAGFDKF> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x2123DD0", Offset = "0x21227D0", VA = "0x182123DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x21247D0", Offset = "0x21231D0", VA = "0x1821247D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private readonly LFOCNAGFDKF DGOMJOADFPO;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public LFOCNAGFDKF HCAMAEAOKKI
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x8913E0", Offset = "0x88FDE0", VA = "0x1808913E0")]
	private IBLIGLOHNNH(LFOCNAGFDKF EFNGACKJAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x211CE10", Offset = "0x211B810", VA = "0x18211CE10")]
	[AsyncStateMachine(typeof(PABJCIMHPJK))]
	public static Task<IBLIGLOHNNH> CKOGJCECCLG(GMEBKHPMCKK EDAFBGDMGIM, JEEOGCMCDDH? HCKNFILJEND, GHGEAPMBJNK? IPPFHGIBMOF, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x211CF70", Offset = "0x211B970", VA = "0x18211CF70", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public readonly struct CBLIJNFJOJM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct MLCGIAFNIFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<object, IDHCEFLHBPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public CBLIJNFJOJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public ONPEDCCMFKN action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private TaskAwaiter<CDOLGFBAJII<object, IDHCEFLHBPO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x21224C0", Offset = "0x2120EC0", VA = "0x1821224C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x2122750", Offset = "0x2121150", VA = "0x182122750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct PIEPPJFDMMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<bool, IDHCEFLHBPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public AOFBLOPPMID rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public JEEOGCMCDDH circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public GHGEAPMBJNK superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public CBLIJNFJOJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private ONPEDCCMFKN[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private TaskAwaiter<CDOLGFBAJII<object, IDHCEFLHBPO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x2125F30", Offset = "0x2124930", VA = "0x182125F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x2126310", Offset = "0x2124D10", VA = "0x182126310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct BOLOBEPNDBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public CBLIJNFJOJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private TaskAwaiter<CDOLGFBAJII<object, IDHCEFLHBPO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x2111FF0", Offset = "0x21109F0", VA = "0x182111FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x2112230", Offset = "0x2110C30", VA = "0x182112230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private readonly AIKPEKKPPBH HKPNJMPGDEA;

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0xB63000", Offset = "0xB61A00", VA = "0x180B63000")]
	public CBLIJNFJOJM(AIKPEKKPPBH KDFJJDIBBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x2112600", Offset = "0x2111000", VA = "0x182112600")]
	[AsyncStateMachine(typeof(MLCGIAFNIFE))]
	private Task<CDOLGFBAJII<object, IDHCEFLHBPO>> BPLAKGEIDOG(ONPEDCCMFKN GGEEGOKOMKJ, bool BGANBAIIPIN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x21124A0", Offset = "0x2110EA0", VA = "0x1821124A0")]
	[AsyncStateMachine(typeof(PIEPPJFDMMN))]
	public Task<CDOLGFBAJII<bool, IDHCEFLHBPO?>>? AMIGCCNBJPO(int HPAFBMIDAIO, AOFBLOPPMID? JEEJGNKFMDN, JEEOGCMCDDH? KGELNLDDLAB, GHGEAPMBJNK? IPPFHGIBMOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x2112730", Offset = "0x2111130", VA = "0x182112730")]
	[AsyncStateMachine(typeof(BOLOBEPNDBC))]
	public Task<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> MOGENANDEFO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public sealed class HOMNHBFKLKB : OPOFBFBNFLL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private readonly HKFACOBGNDH EFFEFGNIFEB;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public HKFACOBGNDH BNNMGLKACKK
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x8913E0", Offset = "0x88FDE0", VA = "0x1808913E0")]
	private HOMNHBFKLKB(HKFACOBGNDH BEHBIMLEJBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x211CC10", Offset = "0x211B610", VA = "0x18211CC10")]
	public static HOMNHBFKLKB MPIHBHFBPAP(GMEBKHPMCKK EDAFBGDMGIM, AOFBLOPPMID AFFOANBOJBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x211CBF0", Offset = "0x211B5F0", VA = "0x18211CBF0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public interface GPEIGHCONNK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	LFOCNAGFDKF HCAMAEAOKKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	JHMFKMNAMLF MKPLIINLPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	MKFNKAGPMND NCHJDMICGAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	APEFKHFCOML ABMJDGEOAHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public interface LJNMGFEFBDE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	GPEIGHCONNK? GDCICNAOEOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	bool HACHFHFHEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	bool LJKCINAHMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<GPEIGHCONNK?>? GEFHGIJKJDF();

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task LKFJGPLGKIN(GMEBKHPMCKK EDAFBGDMGIM, AOFBLOPPMID AFFOANBOJBJ, JEEOGCMCDDH? KFKAHAGCIAI, GHGEAPMBJNK? NCPAHAKHNEN);
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[PHGLEGCCOGA("IStaticCV2Instance")]
public interface GBCABGGBFOO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	LFOCNAGFDKF HCAMAEAOKKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[PHGLEGCCOGA("IStaticEVInstance")]
public interface OPOFBFBNFLL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	HKFACOBGNDH BNNMGLKACKK
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public static class JMFIJGKLJGN
{
	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x211E1E0", Offset = "0x211CBE0", VA = "0x18211E1E0")]
	public static JMCKBGJHBBD<GDONOGCEMNE, ONPEDCCMFKN, GMEBKHPMCKK, DAPKHMLEODH.HCJIIBBHIBA<GDONOGCEMNE, ONPEDCCMFKN, GMEBKHPMCKK>> DEGPAACPCEH([In] this JMCKBGJHBBD<GDONOGCEMNE, ONPEDCCMFKN, GMEBKHPMCKK, DAPKHMLEODH.HCJIIBBHIBA<GDONOGCEMNE, ONPEDCCMFKN, GMEBKHPMCKK>> JCPCCJPIGNG)
	{
		return default(JMCKBGJHBBD<GDONOGCEMNE, ONPEDCCMFKN, GMEBKHPMCKK, DAPKHMLEODH.HCJIIBBHIBA<GDONOGCEMNE, ONPEDCCMFKN, GMEBKHPMCKK>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public sealed class JMKHPDKENOB : EGGGBLOFHJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private readonly GMEBKHPMCKK ABJOCPNGLEO;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool LJKCINAHMCL
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x211E690", Offset = "0x211D090", VA = "0x18211E690", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x8913E0", Offset = "0x88FDE0", VA = "0x1808913E0")]
	internal JMKHPDKENOB(GMEBKHPMCKK EDAFBGDMGIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal sealed class LCPKMGHEDPI : HBAOCEPIKMJ
{
	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x2121020", Offset = "0x211FA20", VA = "0x182121020", Slot = "4")]
	public AICDOOAPPDN? OBIEHPFIOCG(string? GFHFEOKMPEP, string? BOPODNCNGJN, string? BBHODNIJHOC, LJPADBAMDDF.NJENHPLLDDM.ONFKIIEFMEE FCBHHEHGPOB, bool GGFOPMELKGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public LCPKMGHEDPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public sealed class HFGOLDDEIJH : BJILIBHIONC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private struct CLOOHMAELAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public AsyncTaskMethodBuilder<IAAIBGHJPDJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public HFGOLDDEIJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private TaskAwaiter<GPEIGHCONNK?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x2112880", Offset = "0x2111280", VA = "0x182112880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x2112B20", Offset = "0x2111520", VA = "0x182112B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private readonly GMEBKHPMCKK ABJOCPNGLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private IReadOnlyList<GBPONPDANLH<APFAGICDDPN>>? IEDDJHBHPLC;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public IAAIBGHJPDJ? GHBFIIGNNDE
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x211C430", Offset = "0x211AE30", VA = "0x18211C430", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public APEFKHFCOML? KGEKHABKOAI
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x211C3B0", Offset = "0x211ADB0", VA = "0x18211C3B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool OAMAHNIEAPB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x211CA10", Offset = "0x211B410", VA = "0x18211CA10", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool NOBAEMBIDJA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x211CA70", Offset = "0x211B470", VA = "0x18211CA70", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x8913E0", Offset = "0x88FDE0", VA = "0x1808913E0")]
	internal HFGOLDDEIJH(GMEBKHPMCKK EDAFBGDMGIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x211C2C0", Offset = "0x211ACC0", VA = "0x18211C2C0", Slot = "7")]
	[AsyncStateMachine(typeof(CLOOHMAELAF))]
	public Task<IAAIBGHJPDJ> IFMEPPKGFMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x211C6A0", Offset = "0x211B0A0", VA = "0x18211C6A0", Slot = "9")]
	public IReadOnlyDictionary<GBPONPDANLH<BLMFKKELJGG>, Guid> KJBIBHOFAHF(IEnumerable<OEAGPMFPCEL> NLGECFIIBEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x211C0C0", Offset = "0x211AAC0", VA = "0x18211C0C0")]
	public CDOLGFBAJII<NODDDHELECK, NEIFONLMJBM> EANHDFKJAIP([In] NODDDHELECK DEOLCFAHDMN, IEnumerable<OEAGPMFPCEL> IDIHGMMGLOE, int DKICLEGAADF)
	{
		return default(CDOLGFBAJII<NODDDHELECK, NEIFONLMJBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x211C4B0", Offset = "0x211AEB0", VA = "0x18211C4B0", Slot = "8")]
	private CDOLGFBAJII<NODDDHELECK, NEIFONLMJBM> JMHNHGDFHEP([In] NODDDHELECK DEOLCFAHDMN, IEnumerable<OEAGPMFPCEL> IDIHGMMGLOE, int DKICLEGAADF)
	{
		return default(CDOLGFBAJII<NODDDHELECK, NEIFONLMJBM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class APEFKHFCOML : IAAIBGHJPDJ
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	internal static class KPOEFMNLMDL
	{
		[Cpp2IlInjected.Token(Token = "0x20000CC")]
		[CompilerGenerated]
		private sealed class ALDDMJKDICO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000294")]
			public LFOCNAGFDKF state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000295")]
			public BGJBIHJGJNA spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x60004F9")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public ALDDMJKDICO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0x210BAE0", Offset = "0x210A4E0", VA = "0x18210BAE0")]
			internal bool BFGPJCECKNL(FLBNNHOHAHM n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CD")]
		[CompilerGenerated]
		private sealed class OAAEHIBOHCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000296")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public OAAEHIBOHCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FC")]
			[Cpp2IlInjected.Address(RVA = "0x21232F0", Offset = "0x2121CF0", VA = "0x1821232F0")]
			internal void HHOIMNOGNHJ(FLBNNHOHAHM n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x2120620", Offset = "0x211F020", VA = "0x182120620")]
		public static CDOLGFBAJII<IAAIBGHJPDJ.FOEPNJCNKMI, CLNHCBPGBDN> KELODGGKPBN(APEFKHFCOML NKCEKILMAAM, [In] IAAIBGHJPDJ.JCCKIAJLDIB BBLLNFBCDFH)
		{
			return default(CDOLGFBAJII<IAAIBGHJPDJ.FOEPNJCNKMI, CLNHCBPGBDN>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x211F7B0", Offset = "0x211E1B0", VA = "0x18211F7B0")]
		internal static CDOLGFBAJII<(OCPOIEPIPAO, JDGKLFNKDFE), CLNHCBPGBDN> JABOBPEICIA(APEFKHFCOML NKCEKILMAAM, JDGKLFNKDFE MIMLKPMBKDG, bool KJPLOCMGHPA, [In] GBPONPDANLH<BLMFKKELJGG> GKGLCFADDME, [In] int? CMJFGIJBOFE, [In] NFCBEHPCJJE? GNDBBFFCGLK, [In] NFCBEHPCJJE? AABHNBAHOEE)
		{
			return default(CDOLGFBAJII<(OCPOIEPIPAO, JDGKLFNKDFE), CLNHCBPGBDN>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x2120BE0", Offset = "0x211F5E0", VA = "0x182120BE0")]
		private static void PNOCAICFHAI(bool KJPLOCMGHPA, OEAGPMFPCEL OKFKNACKKGK, OCPOIEPIPAO GHGENHCIFEP, [In] GBPONPDANLH<BLMFKKELJGG> GKGLCFADDME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x211F2C0", Offset = "0x211DCC0", VA = "0x18211F2C0")]
		public static void BMCONCIHCBF(HLMIBCLLBGJ FNNLONFNFNN, [In] IAAIBGHJPDJ.KFNNAMDNILH GFHPCJPOKAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x211F6C0", Offset = "0x211E0C0", VA = "0x18211F6C0")]
		[CompilerGenerated]
		internal static bool CCEIONOCBNM(LFOCNAGFDKF DLNDOIELBIH, BGJBIHJGJNA AFELLKDLLEN, FLBNNHOHAHM KDGGADNNKNL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x2120BB0", Offset = "0x211F5B0", VA = "0x182120BB0")]
		[CompilerGenerated]
		internal static bool KGNKMMAIJAK(FLBNNHOHAHM EDAMHICEDPD)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private struct LDJENGNHFAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public APEFKHFCOML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public OPGJAFEOJCM<BLMFKKELJGG> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public OPGJAFEOJCM<KJIBBALNENC> srcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public OPGJAFEOJCM<IBKOEPKMBDC> dstId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private TaskAwaiter<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x21210C0", Offset = "0x211FAC0", VA = "0x1821210C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x2121710", Offset = "0x2120110", VA = "0x182121710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private struct GJAGOCJBJCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public APEFKHFCOML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public GBPONPDANLH<BOAKMKENONJ> inputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public GBPONPDANLH<BLMFKKELJGG> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public OPGJAFEOJCM<EKKGGLMMLBB> inputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public OPGJAFEOJCM<LBLICMJLFMO> inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private TaskAwaiter<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x211B5E0", Offset = "0x2119FE0", VA = "0x18211B5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x211B920", Offset = "0x211A320", VA = "0x18211B920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[CompilerGenerated]
	private struct EGCJLMDFPJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public APEFKHFCOML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public GBPONPDANLH<BOAKMKENONJ> outputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public GBPONPDANLH<BLMFKKELJGG> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public OPGJAFEOJCM<EKKGGLMMLBB> outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public OPGJAFEOJCM<LENKNJAGABN> outputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private TaskAwaiter<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x2127CC0", Offset = "0x21266C0", VA = "0x182127CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x2128000", Offset = "0x2126A00", VA = "0x182128000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private readonly GMEBKHPMCKK ABJOCPNGLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private readonly GBCABGGBFOO BMIJOGNCAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private readonly OPOFBFBNFLL LACMFFPNPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private readonly MMNMKBKKIJH FFHNMAFMJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private readonly HFGOLDDEIJH BMKPJCILPHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private Dictionary<GBPONPDANLH<BOAKMKENONJ>, DKCJHFLDAAD> FOCDAGNDBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	[CompilerGenerated]
	private Action<GBPONPDANLH<BOAKMKENONJ>>? MJNEGMFEIOL;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public GBPONPDANLH<BLMFKKELJGG> EFGEAKODBMK
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x210D920", Offset = "0x210C320", VA = "0x18210D920", Slot = "4")]
		get
		{
			return default(GBPONPDANLH<BLMFKKELJGG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public MMNMKBKKIJH JHPHPBKEEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x20F4D00", Offset = "0x20F3700", VA = "0x1820F4D00", Slot = "5")]
		get
		{
			return default(MMNMKBKKIJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x2111250", Offset = "0x210FC50", VA = "0x182111250")]
	public APEFKHFCOML(GMEBKHPMCKK EDAFBGDMGIM, GBCABGGBFOO NCACNCENMBN, OPOFBFBNFLL NONKDHONIJG, HFGOLDDEIJH NJEJJEGFFOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x210D2C0", Offset = "0x210BCC0", VA = "0x18210D2C0", Slot = "48")]
	public OPGJAFEOJCM<LLKLIFEENGP> BBKEBDMMGGO(OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, OPGJAFEOJCM<IBKOEPKMBDC> MIGAOACKAPI)
	{
		return default(OPGJAFEOJCM<LLKLIFEENGP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x210DFF0", Offset = "0x210C9F0", VA = "0x18210DFF0", Slot = "49")]
	public OPGJAFEOJCM<MOGOMEGKBLF> EILDFCAIABJ(OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, OPGJAFEOJCM<KJIBBALNENC> AENNIDBABCK)
	{
		return default(OPGJAFEOJCM<MOGOMEGKBLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x210F4A0", Offset = "0x210DEA0", VA = "0x18210F4A0", Slot = "6")]
	public (bool, bool) LKNFPOOHMNK(OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, OPGJAFEOJCM<KJIBBALNENC> FJPJPEKDOIB, OPGJAFEOJCM<IBKOEPKMBDC> CIDMDLIIFGN)
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x210D980", Offset = "0x210C380", VA = "0x18210D980")]
	public bool DBIOJHABMEI(OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, [In] DJKAGHJLBBN NACOIEPJAEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x210F280", Offset = "0x210DC80", VA = "0x18210F280", Slot = "8")]
	public bool KKIBJLNGLPC(ICPCFJHFNLO MAFBNADLPNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x210E410", Offset = "0x210CE10", VA = "0x18210E410", Slot = "9")]
	public bool HBIEMHMHMMC(JLPONLFAJEE CJCODJPJAND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x2110BA0", Offset = "0x210F5A0", VA = "0x182110BA0", Slot = "10")]
	public PCGECOKOPGD? OCPCGNFCNKJ(OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, OPGJAFEOJCM<IBKOEPKMBDC> MIGAOACKAPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x210F3E0", Offset = "0x210DDE0", VA = "0x18210F3E0", Slot = "11")]
	public OHNMJEBJIEI? LFABEKMAEHP(OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, OPGJAFEOJCM<KJIBBALNENC> AENNIDBABCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x210E360", Offset = "0x210CD60", VA = "0x18210E360", Slot = "12")]
	public IEnumerable<OPGJAFEOJCM<OPCHHPIPDIC>> GOGGFDDJPLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x210EDC0", Offset = "0x210D7C0", VA = "0x18210EDC0", Slot = "13")]
	public string ILHMGOCBAED(OPGJAFEOJCM<OPCHHPIPDIC> OIMAPBBDPND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x210F300", Offset = "0x210DD00", VA = "0x18210F300", Slot = "14")]
	public string LAACIOGBPOH(OPGJAFEOJCM<OPCHHPIPDIC> OIMAPBBDPND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x2110CC0", Offset = "0x210F6C0", VA = "0x182110CC0")]
	public DKCJHFLDAAD? PDNHCOGPKKO([In] GBPONPDANLH<BOAKMKENONJ> HEPLADJNIKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x210DCD0", Offset = "0x210C6D0", VA = "0x18210DCD0")]
	public OPGJAFEOJCM<BOAKMKENONJ> IIOLMHOGPAH(OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, [In] GBPONPDANLH<BOAKMKENONJ> BEGILJGHCOF)
	{
		return default(OPGJAFEOJCM<BOAKMKENONJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x210D8A0", Offset = "0x210C2A0", VA = "0x18210D8A0", Slot = "26")]
	public OPGJAFEOJCM<BOAKMKENONJ> CKNCHJNLKFH(OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, OPGJAFEOJCM<IBKOEPKMBDC> MIGAOACKAPI)
	{
		return default(OPGJAFEOJCM<BOAKMKENONJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x210D820", Offset = "0x210C220", VA = "0x18210D820", Slot = "27")]
	public OPGJAFEOJCM<BOAKMKENONJ> CDLMAMOMIOJ(OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, OPGJAFEOJCM<KJIBBALNENC> AENNIDBABCK)
	{
		return default(OPGJAFEOJCM<BOAKMKENONJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x210FE60", Offset = "0x210E860", VA = "0x18210FE60")]
	private void MLIDGJEFIIO(GBPONPDANLH<BOAKMKENONJ> HEPLADJNIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x210EFB0", Offset = "0x210D9B0", VA = "0x18210EFB0")]
	public IEnumerable<DKCJHFLDAAD> JGJGBIPHPFP([In] GBPONPDANLH<BLMFKKELJGG> FAABINMBEKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x210E490", Offset = "0x210CE90", VA = "0x18210E490", Slot = "25")]
	public OPGJAFEOJCM<IBKOEPKMBDC> HDLNKGPHEJJ(OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, OPGJAFEOJCM<BOAKMKENONJ> HEPLADJNIKE, OPGJAFEOJCM<LLKLIFEENGP> FHNDLLDGKOE)
	{
		return default(OPGJAFEOJCM<IBKOEPKMBDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x210EF20", Offset = "0x210D920", VA = "0x18210EF20", Slot = "28")]
	public OPGJAFEOJCM<KJIBBALNENC> IPIOFDNICGN(OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, OPGJAFEOJCM<BOAKMKENONJ> HEPLADJNIKE, OPGJAFEOJCM<MOGOMEGKBLF> CMLMOJMPJCC)
	{
		return default(OPGJAFEOJCM<KJIBBALNENC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x210E160", Offset = "0x210CB60", VA = "0x18210E160")]
	private DKCJHFLDAAD? GHOFLJGBADK([In] GBPONPDANLH<BOAKMKENONJ> HEPLADJNIKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x210FD90", Offset = "0x210E790", VA = "0x18210FD90")]
	private DKCJHFLDAAD MICDDDLBEIC([In] GBPONPDANLH<BOAKMKENONJ> HEPLADJNIKE, KGLMPAAGOHB AOOGCKADIHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x210DF50", Offset = "0x210C950", VA = "0x18210DF50")]
	public KGLMPAAGOHB? EGBHEFIJBGN([In] GBPONPDANLH<BOAKMKENONJ> HEPLADJNIKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x210D7F0", Offset = "0x210C1F0", VA = "0x18210D7F0")]
	public LGAFBGLPDCL? HLFFBGFHAPC([In] GBPONPDANLH<BLMFKKELJGG> FAABINMBEKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x210EB40", Offset = "0x210D540", VA = "0x18210EB40", Slot = "20")]
	public IEnumerable<COGJOLMLAEM> HLAAGJBMFHG(OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x210D340", Offset = "0x210BD40", VA = "0x18210D340", Slot = "21")]
	public bool BHGNIHNICML(OPGJAFEOJCM<OPCHHPIPDIC> OIMAPBBDPND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x2110E40", Offset = "0x210F840", VA = "0x182110E40", Slot = "22")]
	public IEnumerable<DJKAGHJLBBN> PMCOEGFIKMM(OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, OPGJAFEOJCM<KJIBBALNENC> FJPJPEKDOIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x2110920", Offset = "0x210F320", VA = "0x182110920", Slot = "23")]
	public IEnumerable<DJKAGHJLBBN> OBBFBBFPPLP(OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, OPGJAFEOJCM<IBKOEPKMBDC> CIDMDLIIFGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x210D690", Offset = "0x210C090", VA = "0x18210D690")]
	public OPGJAFEOJCM<BLMFKKELJGG> CCCLHAPHING([In] GBPONPDANLH<BLMFKKELJGG> FAABINMBEKH)
	{
		return default(OPGJAFEOJCM<BLMFKKELJGG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x210E0E0", Offset = "0x210CAE0", VA = "0x18210E0E0")]
	public OPGJAFEOJCM<BLMFKKELJGG>? KFGDDMLBIPJ([In] GBPONPDANLH<BLMFKKELJGG> FAABINMBEKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x210E1A0", Offset = "0x210CBA0", VA = "0x18210E1A0")]
	private BGJBIHJGJNA? GIOPHFCBEOG([In] GBPONPDANLH<BLMFKKELJGG> FAABINMBEKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x210D7F0", Offset = "0x210C1F0", VA = "0x18210D7F0")]
	private LGAFBGLPDCL? CCIDBPBKFNF([In] GBPONPDANLH<BLMFKKELJGG> FAABINMBEKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x21111E0", Offset = "0x210FBE0", VA = "0x1821111E0", Slot = "32")]
	public GBPONPDANLH<BLMFKKELJGG> PPEKFDLFILG(OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH)
	{
		return default(GBPONPDANLH<BLMFKKELJGG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x210CD30", Offset = "0x210B730", VA = "0x18210CD30", Slot = "29")]
	public IEnumerable<IDJOALMKCOO> ADIIBOJDGHC(JGKBEDODIID HLKIMOOPDOA, bool DAPPLAJEDMD, bool JNBOAKJKKEN, bool IPOIIFBLDGM, bool IBDEHFLIFJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x2110210", Offset = "0x210EC10", VA = "0x182110210", Slot = "30")]
	public IDJOALMKCOO NGNANGEPAJH(JGKBEDODIID HLKIMOOPDOA, CGHMBKNDPCI JNANAKBLJPH, bool DAPPLAJEDMD, bool JNBOAKJKKEN, bool IPOIIFBLDGM, bool IBDEHFLIFJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x210DD80", Offset = "0x210C780", VA = "0x18210DD80")]
	public COGJOLMLAEM DNMHGNOONOI(OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, [In] DJKAGHJLBBN NACOIEPJAEL)
	{
		return default(COGJOLMLAEM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x210FFE0", Offset = "0x210E9E0", VA = "0x18210FFE0", Slot = "33")]
	public DJKAGHJLBBN NBOIPLGKBGL(OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, OPGJAFEOJCM<KJIBBALNENC> FJPJPEKDOIB, OPGJAFEOJCM<IBKOEPKMBDC> CIDMDLIIFGN)
	{
		return default(DJKAGHJLBBN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x210E070", Offset = "0x210CA70", VA = "0x18210E070", Slot = "34")]
	public bool FEJEILDHFJG(OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x2110DC0", Offset = "0x210F7C0", VA = "0x182110DC0", Slot = "35")]
	public bool PLFEJHGFPLG(OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, OPGJAFEOJCM<IBKOEPKMBDC> MIGAOACKAPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x210E260", Offset = "0x210CC60", VA = "0x18210E260", Slot = "36")]
	public bool GLGMBHEOGFN(OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, OPGJAFEOJCM<KJIBBALNENC> AENNIDBABCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x210DD50", Offset = "0x210C750", VA = "0x18210DD50")]
	public CDOLGFBAJII<IAAIBGHJPDJ.FOEPNJCNKMI, CLNHCBPGBDN> DIMHDODDPDJ([In] IAAIBGHJPDJ.JCCKIAJLDIB BBLLNFBCDFH)
	{
		return default(CDOLGFBAJII<IAAIBGHJPDJ.FOEPNJCNKMI, CLNHCBPGBDN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x210E520", Offset = "0x210CF20", VA = "0x18210E520", Slot = "38")]
	[AsyncStateMachine(typeof(LDJENGNHFAM))]
	public Task<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> HECAOBILDDI(OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, OPGJAFEOJCM<KJIBBALNENC> FJPJPEKDOIB, OPGJAFEOJCM<IBKOEPKMBDC> CIDMDLIIFGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x210F9A0", Offset = "0x210E3A0", VA = "0x18210F9A0", Slot = "39")]
	public CDOLGFBAJII<HACEBHIEHFF, NEIFONLMJBM> LPDBFHEKGBE(GBPONPDANLH<BLMFKKELJGG> FAABINMBEKH, HACEBHIEHFF ICOOGJKJOKN, DDFABOMDEOH CCOOEMFPDIH)
	{
		return default(CDOLGFBAJII<HACEBHIEHFF, NEIFONLMJBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x210D3D0", Offset = "0x210BDD0", VA = "0x18210D3D0", Slot = "40")]
	[AsyncStateMachine(typeof(GJAGOCJBJCK))]
	public Task<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> BJKEGKILNOE(GBPONPDANLH<BLMFKKELJGG> FAABINMBEKH, GBPONPDANLH<BOAKMKENONJ> BCMAHLFKIKI, OPGJAFEOJCM<EKKGGLMMLBB> BENKMDAEEDP, OPGJAFEOJCM<LBLICMJLFMO> MIGAOACKAPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x210D530", Offset = "0x210BF30", VA = "0x18210D530", Slot = "41")]
	[AsyncStateMachine(typeof(EGCJLMDFPJI))]
	public Task<CDOLGFBAJII<AJBBHDJGBPP, IDHCEFLHBPO>> CAOGIFJMAEA(GBPONPDANLH<BLMFKKELJGG> FAABINMBEKH, GBPONPDANLH<BOAKMKENONJ> MHBDLCOLGBA, OPGJAFEOJCM<EKKGGLMMLBB> MPIHEAHHLKN, OPGJAFEOJCM<LENKNJAGABN> AENNIDBABCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x210F090", Offset = "0x210DA90", VA = "0x18210F090", Slot = "42")]
	public HBMGPNHDFMG JHBPCLIDEGG(IEnumerable<OEAGPMFPCEL> IDIHGMMGLOE)
	{
		return default(HBMGPNHDFMG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x21110C0", Offset = "0x210FAC0", VA = "0x1821110C0", Slot = "43")]
	public HBMGPNHDFMG POLOKFPCAHF()
	{
		return default(HBMGPNHDFMG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x210E990", Offset = "0x210D390", VA = "0x18210E990")]
	private JCCMINNEILE HIGNEAEHPIK(NMMDMJGAOGB LPIAAJLJDLN, OPGJAFEOJCM<BLMFKKELJGG> BKFAMEGJCEJ, IEnumerable<GBPONPDANLH<BLMFKKELJGG>> NKFHAIFEDPI, IEnumerable<GBPONPDANLH<BOAKMKENONJ>> MKENKKGAFLA)
	{
		return default(JCCMINNEILE);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x210E650", Offset = "0x210D050", VA = "0x18210E650", Slot = "44")]
	public JCCMINNEILE HIGNEAEHPIK(NMMDMJGAOGB LPIAAJLJDLN, OPGJAFEOJCM<BLMFKKELJGG> BKFAMEGJCEJ, IEnumerable<GBPONPDANLH<BOAKMKENONJ>> MKENKKGAFLA, IEnumerable<OEAGPMFPCEL> IDIHGMMGLOE)
	{
		return default(JCCMINNEILE);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x2110510", Offset = "0x210EF10", VA = "0x182110510")]
	private static IEnumerable<GBPONPDANLH<BLMFKKELJGG>> NJLPGINGJPB(IEnumerable<OEAGPMFPCEL> IDIHGMMGLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x210CE30", Offset = "0x210B830", VA = "0x18210CE30")]
	private IEnumerable<GBPONPDANLH<BOAKMKENONJ>> AEDHBBBLCPD(IEnumerable<OEAGPMFPCEL> IDIHGMMGLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x2110890", Offset = "0x210F290", VA = "0x182110890", Slot = "45")]
	public List<ENPDIODPMBG> NNLLAEOENCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x210C670", Offset = "0x210B070", VA = "0x18210C670")]
	public (List<ENPDIODPMBG>, bool) ACNCOPKJHFJ([In] JJCEKPKNIPP LPJLLPKGIKI, string MPOBGCPIOEI, [In] BFIAAFJLAAA HCLAHEHHLIM, KJBPMODKDEM AJHJNONECMN, ICDOFBIDDKC BEMCJHPOHBP)
	{
		return default((List<ENPDIODPMBG>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x210FEF0", Offset = "0x210E8F0", VA = "0x18210FEF0", Slot = "47")]
	public bool MNLPJJBAKEG(OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x210DEF0", Offset = "0x210C8F0", VA = "0x18210DEF0")]
	internal void EGAFGOPEIGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x210EC00", Offset = "0x210D600", VA = "0x18210EC00")]
	internal Task HMLLCFPHIAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x210DFE0", Offset = "0x210C9E0", VA = "0x18210DFE0", Slot = "7")]
	private bool EHHCEIKIBOL(OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, [In] DJKAGHJLBBN NACOIEPJAEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x210D7F0", Offset = "0x210C1F0", VA = "0x18210D7F0", Slot = "15")]
	private LGAFBGLPDCL KPLPDBAFCLE([In] GBPONPDANLH<BLMFKKELJGG> FAABINMBEKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x210D690", Offset = "0x210C090", VA = "0x18210D690", Slot = "16")]
	private OPGJAFEOJCM<BLMFKKELJGG> FLPPLNGAMGM([In] GBPONPDANLH<BLMFKKELJGG> FAABINMBEKH)
	{
		return default(OPGJAFEOJCM<BLMFKKELJGG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x210E0E0", Offset = "0x210CAE0", VA = "0x18210E0E0", Slot = "17")]
	private OPGJAFEOJCM<BLMFKKELJGG>? FNPMMBAKJNI([In] GBPONPDANLH<BLMFKKELJGG> FAABINMBEKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x210EE30", Offset = "0x210D830", VA = "0x18210EE30", Slot = "18")]
	private DKCJHFLDAAD INPBACKKKFN([In] GBPONPDANLH<BOAKMKENONJ> HEPLADJNIKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x210DCD0", Offset = "0x210C6D0", VA = "0x18210DCD0", Slot = "19")]
	private OPGJAFEOJCM<BOAKMKENONJ> DFGODLCFIIE(OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, [In] GBPONPDANLH<BOAKMKENONJ> BEGILJGHCOF)
	{
		return default(OPGJAFEOJCM<BOAKMKENONJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x210D710", Offset = "0x210C110", VA = "0x18210D710", Slot = "24")]
	private IEnumerable<DKCJHFLDAAD> CCGGBNEPAPF([In] GBPONPDANLH<BLMFKKELJGG> FAABINMBEKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x210DD80", Offset = "0x210C780", VA = "0x18210DD80", Slot = "31")]
	private COGJOLMLAEM LFNCEAGIPMA(OPGJAFEOJCM<BLMFKKELJGG> FAABINMBEKH, [In] DJKAGHJLBBN NACOIEPJAEL)
	{
		return default(COGJOLMLAEM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x210DD50", Offset = "0x210C750", VA = "0x18210DD50", Slot = "37")]
	private CDOLGFBAJII<IAAIBGHJPDJ.FOEPNJCNKMI, CLNHCBPGBDN> EDJPHEMAKOP([In] IAAIBGHJPDJ.JCCKIAJLDIB BBLLNFBCDFH)
	{
		return default(CDOLGFBAJII<IAAIBGHJPDJ.FOEPNJCNKMI, CLNHCBPGBDN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x2110C60", Offset = "0x210F660", VA = "0x182110C60", Slot = "46")]
	private (List<ENPDIODPMBG>, bool) OGGFIJNNLLA([In] JJCEKPKNIPP LPJLLPKGIKI, string MPOBGCPIOEI, [In] BFIAAFJLAAA HCLAHEHHLIM, KJBPMODKDEM AJHJNONECMN, ICDOFBIDDKC BEMCJHPOHBP)
	{
		return default((List<ENPDIODPMBG>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x210EC60", Offset = "0x210D660", VA = "0x18210EC60")]
	[CompilerGenerated]
	private DKCJHFLDAAD HNLJIJBHHCJ(KGLMPAAGOHB ELMEOKPKOPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x210E2E0", Offset = "0x210CCE0", VA = "0x18210E2E0")]
	[CompilerGenerated]
	private HJAEBFEEDJG GNLAINPJLOI(GJHLAECHCCP ELMEOKPKOPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x210F370", Offset = "0x210DD70", VA = "0x18210F370")]
	[CompilerGenerated]
	private KGLMPAAGOHB LDBADBFPDDD(GBPONPDANLH<BOAKMKENONJ> ELMEOKPKOPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x210ED50", Offset = "0x210D750", VA = "0x18210ED50")]
	[CompilerGenerated]
	private BGJBIHJGJNA IHKNIMNDDIF(GBPONPDANLH<BLMFKKELJGG> ELMEOKPKOPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class HJAEBFEEDJG : IDJOALMKCOO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private struct PBCEKMOPMLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<OPGJAFEOJCM<OGBOHDOOEJL>, IDHCEFLHBPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public HJAEBFEEDJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public GBPONPDANLH<BLMFKKELJGG> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public GBPONPDANLH<BOAKMKENONJ> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public OPGJAFEOJCM<EKKGGLMMLBB> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private TaskAwaiter<CDOLGFBAJII<OPGJAFEOJCM<OGBOHDOOEJL>, IDHCEFLHBPO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x212B0E0", Offset = "0x2129AE0", VA = "0x18212B0E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x212B360", Offset = "0x2129D60", VA = "0x18212B360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct BDHBCKOBPCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<OPGJAFEOJCM<MINNOGPCNLA>, IDHCEFLHBPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public HJAEBFEEDJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public GBPONPDANLH<BLMFKKELJGG> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public GBPONPDANLH<BOAKMKENONJ> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public OPGJAFEOJCM<EKKGGLMMLBB> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private TaskAwaiter<CDOLGFBAJII<OPGJAFEOJCM<MINNOGPCNLA>, IDHCEFLHBPO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x2127860", Offset = "0x2126260", VA = "0x182127860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x2127AE0", Offset = "0x21264E0", VA = "0x182127AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	private readonly GJHLAECHCCP ENIAKBJLFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	private readonly GBCABGGBFOO BMIJOGNCAGE;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public TypeKey PIAAFNDMDGH
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x92EC80", Offset = "0x92D680", VA = "0x18092EC80", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public string OLAMLJIPIPG
	{
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x21289E0", Offset = "0x21273E0", VA = "0x1821289E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public GJHLAECHCCP MMKKPAFMMNO
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x2128CF0", Offset = "0x21276F0", VA = "0x182128CF0")]
	public HJAEBFEEDJG(GJHLAECHCCP AMJNNPOFFLI, GBCABGGBFOO NCACNCENMBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x2128B80", Offset = "0x2127580", VA = "0x182128B80", Slot = "6")]
	[AsyncStateMachine(typeof(PBCEKMOPMLK))]
	public Task<CDOLGFBAJII<OPGJAFEOJCM<OGBOHDOOEJL>, IDHCEFLHBPO>> MCFAJCDBCDA(GBPONPDANLH<BLMFKKELJGG> FAABINMBEKH, GBPONPDANLH<BOAKMKENONJ> HEPLADJNIKE, OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB, string DDDMPLCOGIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x2128A10", Offset = "0x2127410", VA = "0x182128A10", Slot = "7")]
	[AsyncStateMachine(typeof(BDHBCKOBPCG))]
	public Task<CDOLGFBAJII<OPGJAFEOJCM<MINNOGPCNLA>, IDHCEFLHBPO>> GMKAFELLFCD(GBPONPDANLH<BLMFKKELJGG> FAABINMBEKH, GBPONPDANLH<BOAKMKENONJ> HEPLADJNIKE, OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB, string DDDMPLCOGIM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class OLJEKIMOJHP : OGPEJKGOPJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private readonly GJHLAECHCCP JNBNLEMDFMF;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private static readonly HashSet<GJHLAECHCCP> DPMDDEIIOFO;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private static readonly HashSet<GJHLAECHCCP> GGEEDJIBHFA;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private static readonly HashSet<GJHLAECHCCP> BEINILOJLAH;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public TypeKey NJIIHIBALEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x212AF70", Offset = "0x2129970", VA = "0x18212AF70", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool CPHNHCMOIEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x212AF60", Offset = "0x2129960", VA = "0x18212AF60", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool AMABBKBABHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x212AFC0", Offset = "0x21299C0", VA = "0x18212AFC0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool ALPGPBJHIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x212AEE0", Offset = "0x21298E0", VA = "0x18212AEE0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x2129A10", Offset = "0x2128410", VA = "0x182129A10")]
	public bool FFCLAJHKIMH(string IPHMAHBENGI, [Out] PMAHOAFDKKB AJDDINKOCHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x8913E0", Offset = "0x88FDE0", VA = "0x1808913E0")]
	public OLJEKIMOJHP(GJHLAECHCCP KCEPABIAINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x2129C80", Offset = "0x2128680", VA = "0x182129C80")]
	internal static TypeKey IAKKAJPMFJK(GJHLAECHCCP AOGCIMANLIJ)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x21289E0", Offset = "0x21273E0", VA = "0x1821289E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public readonly struct HPLEPLGJCKL : PNEKFBGJCCL.KGDGBFNNNOA<ONPEDCCMFKN, AJBBHDJGBPP>
{
	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x2128EA0", Offset = "0x21278A0", VA = "0x182128EA0", Slot = "4")]
	public int NBKBBADGAGE(AJBBHDJGBPP DICHKFJDHIG, ONPEDCCMFKN GGEEGOKOMKJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x2128E50", Offset = "0x2127850", VA = "0x182128E50", Slot = "5")]
	public ONPEDCCMFKN HCDOLCAFGGL(AJBBHDJGBPP DICHKFJDHIG, ONPEDCCMFKN GGEEGOKOMKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x2128DE0", Offset = "0x21277E0", VA = "0x182128DE0", Slot = "6")]
	public ONPEDCCMFKN CHCLAHIDCBB(AJBBHDJGBPP DICHKFJDHIG, ONPEDCCMFKN GGEEGOKOMKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x2128D90", Offset = "0x2127790", VA = "0x182128D90", Slot = "7")]
	public IReadOnlyList<ONPEDCCMFKN> BGALOOOEPJP(AJBBHDJGBPP DICHKFJDHIG, ONPEDCCMFKN GGEEGOKOMKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x2128DD0", Offset = "0x21277D0", VA = "0x182128DD0", Slot = "8")]
	public ONPEDCCMFKN[] CFAGPGHNGJM(AJBBHDJGBPP DICHKFJDHIG, ONPEDCCMFKN GGEEGOKOMKJ, int JMAGMPLKGDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x2128E30", Offset = "0x2127830", VA = "0x182128E30", Slot = "9")]
	public bool GFNDCINPGKA(AJBBHDJGBPP DICHKFJDHIG, ONPEDCCMFKN GGEEGOKOMKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x2128DB0", Offset = "0x21277B0", VA = "0x182128DB0", Slot = "10")]
	public bool BPEMKAKLPEB(AJBBHDJGBPP DICHKFJDHIG, ONPEDCCMFKN GGEEGOKOMKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x2128E80", Offset = "0x2127880", VA = "0x182128E80", Slot = "11")]
	public bool LLMMABFHAJL(AJBBHDJGBPP DICHKFJDHIG, ONPEDCCMFKN GGEEGOKOMKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x2128EC0", Offset = "0x21278C0", VA = "0x182128EC0", Slot = "12")]
	public bool PKJHGGAPEFH(AJBBHDJGBPP DICHKFJDHIG, ONPEDCCMFKN GGEEGOKOMKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x2128E60", Offset = "0x2127860", VA = "0x182128E60", Slot = "13")]
	public bool JCNDPADPLKN(AJBBHDJGBPP PJAMCMOCBJH, ONPEDCCMFKN GGEEGOKOMKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x2128E10", Offset = "0x2127810", VA = "0x182128E10", Slot = "14")]
	public bool ENGLCGGJJLF(AJBBHDJGBPP DICHKFJDHIG, ONPEDCCMFKN GGEEGOKOMKJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public abstract class AJPACMLFOKH : GBEIBNGLACM
{
	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public FAKPMAHIMHF.MLPHOBLLFGD BHLHAPBHMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x21277C0", Offset = "0x21261C0", VA = "0x1821277C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public abstract KPNHMONLLAE.FJNFJIILGJL NPPMEEOBIME
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public abstract GMEBKHPMCKK.JPBDFPOHFFK MEGOFBJHICJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public abstract IBLIGLOHNNH.PPLIKKPEOIF NCCELMBLIPH
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public DAPKHMLEODH.HCJIIBBHIBA<GDONOGCEMNE, ONPEDCCMFKN, GMEBKHPMCKK> FAPEJMHOIKN
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x2127810", Offset = "0x2126210", VA = "0x182127810", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public abstract NMFMPDHEBKA JGKJMDKJKKC
	{
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public abstract LHDHOLENDNO DCLIABFDPCD
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public abstract LNCHKHJNHBM HBBKOEOKAFG
	{
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public abstract FKNCPEAGLOC BCPMKIDDGDA
	{
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public abstract HFJBFBNHNDM DDADIMGBAEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	protected AJPACMLFOKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class FAFMCCMEMEE : HHFAJGCMIBO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct PHPJNPPGGMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<object, IDHCEFLHBPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public FAFMCCMEMEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public ONPEDCCMFKN action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private TaskAwaiter<CDOLGFBAJII<object, IDHCEFLHBPO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x212B3D0", Offset = "0x2129DD0", VA = "0x18212B3D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x212B670", Offset = "0x212A070", VA = "0x18212B670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct FGDAFHKEACK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<DNFFJMPIELO, IDHCEFLHBPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public FAFMCCMEMEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public IReadOnlyList<ONPEDCCMFKN> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private TaskAwaiter<CDOLGFBAJII<object, IDHCEFLHBPO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x21282D0", Offset = "0x2126CD0", VA = "0x1821282D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x2128650", Offset = "0x2127050", VA = "0x182128650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	private readonly AIKPEKKPPBH HKPNJMPGDEA;

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x8913E0", Offset = "0x88FDE0", VA = "0x1808913E0")]
	public FAFMCCMEMEE(AIKPEKKPPBH KDFJJDIBBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x2128070", Offset = "0x2126A70", VA = "0x182128070")]
	[AsyncStateMachine(typeof(PHPJNPPGGMI))]
	private Task<CDOLGFBAJII<object, IDHCEFLHBPO>> BPLAKGEIDOG(ONPEDCCMFKN GGEEGOKOMKJ, bool BGANBAIIPIN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x21281A0", Offset = "0x2126BA0", VA = "0x1821281A0", Slot = "4")]
	[AsyncStateMachine(typeof(FGDAFHKEACK))]
	public Task<CDOLGFBAJII<DNFFJMPIELO, IDHCEFLHBPO>> DOJAFELPMMJ(IReadOnlyList<ONPEDCCMFKN> HENJBBKOCMO, bool BGANBAIIPIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public struct BEEDCPAFGOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	internal PPMFJJMLPMN<PKEFCEJJNDJ, ONPEDCCMFKN, PJPACMHAOCL> JNBNLEMDFMF;

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x20FC6C0", Offset = "0x20FB0C0", VA = "0x1820FC6C0")]
	private BEEDCPAFGOD([In] PPMFJJMLPMN<PKEFCEJJNDJ, ONPEDCCMFKN, PJPACMHAOCL> JPNFNPBLLHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x2127B50", Offset = "0x2126550", VA = "0x182127B50")]
	public static BEEDCPAFGOD OOAFHJGKFEK()
	{
		return default(BEEDCPAFGOD);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public static class DIOEABILKML
{
	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x933670", Offset = "0x932070", VA = "0x180933670")]
	public static PPMFJJMLPMN<PKEFCEJJNDJ, ONPEDCCMFKN, PJPACMHAOCL> IAFJKNFKKON(this BEEDCPAFGOD NKCEKILMAAM)
	{
		return default(PPMFJJMLPMN<PKEFCEJJNDJ, ONPEDCCMFKN, PJPACMHAOCL>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public struct PJPACMHAOCL : JGACIGOPMKG.KBKOACPPCHI<PKEFCEJJNDJ, ONPEDCCMFKN>
{
	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x212B6E0", Offset = "0x212A0E0", VA = "0x18212B6E0", Slot = "5")]
	public ONPEDCCMFKN PAJLEINJMFM(PKEFCEJJNDJ[] KJONIHBDAGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x1903E70", Offset = "0x1902870", VA = "0x181903E70")]
	public int AHFNMKBHDPJ([In] PKEFCEJJNDJ JHEDMCNFEIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x1903E70", Offset = "0x1902870", VA = "0x181903E70", Slot = "4")]
	private int NAHCHCKGJFO([In] PKEFCEJJNDJ LMHIPCBJMMO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public struct KBMCEGEMGLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	internal OLNCCHFEDMA<NFJDODEFJPE, ONPEDCCMFKN, OFJEMOBCNDN> JNBNLEMDFMF;

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x20FC6C0", Offset = "0x20FB0C0", VA = "0x1820FC6C0")]
	private KBMCEGEMGLH([In] OLNCCHFEDMA<NFJDODEFJPE, ONPEDCCMFKN, OFJEMOBCNDN> CADAHABEPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x2128EE0", Offset = "0x21278E0", VA = "0x182128EE0")]
	public static KBMCEGEMGLH OOAFHJGKFEK()
	{
		return default(KBMCEGEMGLH);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public static class DMBFILOBDGF
{
	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x933670", Offset = "0x932070", VA = "0x180933670")]
	public static OLNCCHFEDMA<NFJDODEFJPE, ONPEDCCMFKN, OFJEMOBCNDN> IAFJKNFKKON(this KBMCEGEMGLH NKCEKILMAAM)
	{
		return default(OLNCCHFEDMA<NFJDODEFJPE, ONPEDCCMFKN, OFJEMOBCNDN>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public struct OFJEMOBCNDN : EAILNJEAAHK.KFBIGMCBFCK<NFJDODEFJPE, ONPEDCCMFKN>
{
	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x1903E70", Offset = "0x1902870", VA = "0x181903E70")]
	public int AFHKAFJPKHL([In] NFJDODEFJPE JHEDMCNFEIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x2129830", Offset = "0x2128230", VA = "0x182129830", Slot = "5")]
	public ONPEDCCMFKN HCENHIBLALA(NFJDODEFJPE[] GIODPEIHDDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x1903E70", Offset = "0x1902870", VA = "0x181903E70", Slot = "4")]
	private int CGBKNGAAOIJ([In] NFJDODEFJPE JHEDMCNFEIE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public class FOOFFIOJGGH : PKNKGFKCKHA, CLNHCBPGBDN, IDHCEFLHBPO, NEIFONLMJBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private readonly NEIFONLMJBM? NMJLGIJBBNC;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public GEHDHCCLNBA KHMHENJHBMM
	{
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x883E10", Offset = "0x882810", VA = "0x180883E10", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(GEHDHCCLNBA);
		}
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x885600", Offset = "0x884000", VA = "0x180885600")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public override NEIFONLMJBM? ICHHGKLOEOB
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x21287B0", Offset = "0x21271B0", VA = "0x1821287B0", Slot = "7")]
	public override string OIFECEDJIAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x21289A0", Offset = "0x21273A0", VA = "0x1821289A0")]
	private FOOFFIOJGGH(GEHDHCCLNBA CJJFHMMBLHB, NEIFONLMJBM? OEFKHEOMANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x21286C0", Offset = "0x21270C0", VA = "0x1821286C0")]
	public static FOOFFIOJGGH EGEFILDJACH(NEIFONLMJBM OEFKHEOMANJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x2128740", Offset = "0x2127140", VA = "0x182128740")]
	public static FOOFFIOJGGH EHCEMHPFHIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x2128930", Offset = "0x2127330", VA = "0x182128930")]
	public static FOOFFIOJGGH OIPANALNNMM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class KPLFFBGKAHF
{
	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x2E16230", Offset = "0x2E14C30", VA = "0x182E16230")]
	public static CDOLGFBAJII<TOk, CLNHCBPGBDN> PIGJDOPADFB<TOk>([In] this CDOLGFBAJII<TOk, CLNHCBPGBDN> NKCEKILMAAM, NEIFONLMJBM OEFKHEOMANJ) where TOk : notnull
	{
		return default(CDOLGFBAJII<TOk, CLNHCBPGBDN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x2E16040", Offset = "0x2E14A40", VA = "0x182E16040")]
	public static CDOLGFBAJII<TOk?, CLNHCBPGBDN?> EBAJENBILGL<TOk>([In] this CDOLGFBAJII<TOk, CLNHCBPGBDN> NKCEKILMAAM)
	{
		return default(CDOLGFBAJII<TOk, CLNHCBPGBDN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x2E16130", Offset = "0x2E14B30", VA = "0x182E16130")]
	public static CDOLGFBAJII<TOk?, CLNHCBPGBDN?> KEKGPMEPKJN<TOk>([In] this CDOLGFBAJII<TOk, CLNHCBPGBDN> NKCEKILMAAM)
	{
		return default(CDOLGFBAJII<TOk, CLNHCBPGBDN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public interface NMFMPDHEBKA
{
	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NDNAOADLEAO([In] CDOLGFBAJII<AJBBHDJGBPP, NEIFONLMJBM> NLAECIHBKHE);
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public static class LOPHKCHPLLL
{
	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x2E5A2F0", Offset = "0x2E58CF0", VA = "0x182E5A2F0")]
	public static bool NDNAOADLEAO<TOk, TErr>(this NMFMPDHEBKA NKCEKILMAAM, [In] CDOLGFBAJII<TOk, TErr> NLAECIHBKHE) where TOk : notnull where TErr : notnull, NEIFONLMJBM
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public interface LHDHOLENDNO
{
	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	BKBIKMDBJMM KEAAJJLPOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public interface LNCHKHJNHBM
{
	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MKENJLKFIDM OPMOOIICINC(int NAKAEDDMOMP);
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public interface NBOGFJLOBOL
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	string FMJDNGHFJGI
	{
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public interface CMOEMJBELHG
{
	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NKDOMPAHOJI? PGMFNDBLHFL(OPGJAFEOJCM<EKKGGLMMLBB> MPBGJJOJNLB);
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public interface BEABPNCBGMJ
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	string FMJDNGHFJGI
	{
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public interface NKDOMPAHOJI
{
	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	string FMJDNGHFJGI
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BEABPNCBGMJ? DHOHDAHEAKK(OPGJAFEOJCM<OGBOHDOOEJL> AMMAKLHFFNJ);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NBOGFJLOBOL? AHHAPGCJHFM(OPGJAFEOJCM<MINNOGPCNLA> GGADFIEHJHB);
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public interface FKNCPEAGLOC
{
	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> IKIEHAFIBLM(string IPHMAHBENGI, string MPOBGCPIOEI);
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public interface HFJBFBNHNDM
{
	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CMOEMJBELHG? APOFKOLIEFM([In] GBPONPDANLH<APFAGICDDPN> CJAFIPOBEOJ);
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class NAJICKFFGEJ
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	private struct BOIJKJOBGDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public int BDIPFIAMOOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public JEEOGCMCDDH? PLMIFNGBJMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public JEEOGCMCDDH? BCLKPKCPOPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public readonly List<ONPEDCCMFKN> EIPKICMIHGD;

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x2127C70", Offset = "0x2126670", VA = "0x182127C70")]
		private BOIJKJOBGDH(int ENMILGHAHOM, JEEOGCMCDDH? PKDBNAMGKMO, JEEOGCMCDDH? ABCIDAHNAJM, List<ONPEDCCMFKN> HENJBBKOCMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x2127BB0", Offset = "0x21265B0", VA = "0x182127BB0")]
		public static BOIJKJOBGDH OOAFHJGKFEK()
		{
			return default(BOIJKJOBGDH);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private readonly MBLIOBFEBHI<BOIJKJOBGDH> EJJJPDIBDGA;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public static NAJICKFFGEJ GHBFIIGNNDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x2129630", Offset = "0x2128030", VA = "0x182129630")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool HGBFPJLGBGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x913F50", Offset = "0x912950", VA = "0x180913F50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x913F60", Offset = "0x912960", VA = "0x180913F60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x2129280", Offset = "0x2127C80", VA = "0x182129280")]
	public void CCCOEEENPBC(LFOCNAGFDKF ABCIDAHNAJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x2129340", Offset = "0x2127D40", VA = "0x182129340")]
	public void IIHCIKOOMGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x2128F40", Offset = "0x2127940", VA = "0x182128F40")]
	private static string? BILMIEFJGPI([In] BOIJKJOBGDH NNGDKNFLBLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x2129780", Offset = "0x2128180", VA = "0x182129780")]
	public NAJICKFFGEJ()
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
