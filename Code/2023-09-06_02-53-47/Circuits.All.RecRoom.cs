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
using Google.Protobuf.Collections;
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
		[Cpp2IlInjected.Address(RVA = "0x91C600", Offset = "0x91AC00", VA = "0x18091C600")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2201060", Offset = "0x21FF660", VA = "0x182201060")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x986BA0", Offset = "0x9851A0", VA = "0x180986BA0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x11F2200", Offset = "0x11F0800", VA = "0x1811F2200")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class MGMBHHHNCIH : IDisposable, LNEAKPKCALF, LDJGPNHFJNP, KCMAOKILPGE, KGDOFNLJPCK, OLMJLAHMCDC
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private readonly struct MDODBKEEIBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67A2F0", Offset = "0x6796F0")]
		public readonly AGPOGEDCCII<IJBLNCALADF, NJNNNDNOLHN, MGMBHHHNCIH, ILLEHKNENGB.MIACHIBEEKI<IJBLNCALADF, NJNNNDNOLHN, MGMBHHHNCIH>> KIAIEGBMNCJ;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1E6B660", Offset = "0x1E69C60", VA = "0x181E6B660")]
		internal MDODBKEEIBJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67A3C0", Offset = "0x6797C0")] AGPOGEDCCII<IJBLNCALADF, NJNNNDNOLHN, MGMBHHHNCIH, ILLEHKNENGB.MIACHIBEEKI<IJBLNCALADF, NJNNNDNOLHN, MGMBHHHNCIH>> PMIAAPCBGPN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class PHEMNOFDINF : ILLEHKNENGB.MIACHIBEEKI<IJBLNCALADF, NJNNNDNOLHN, MGMBHHHNCIH>
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly PHEMNOFDINF HAMPJMKDJOL;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		private PHEMNOFDINF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xAD8DB0", Offset = "0xAD73B0", VA = "0x180AD8DB0", Slot = "4")]
		public IJBLNCALADF GHLDCAHMBCP(NJNNNDNOLHN CDBMADFDGCE)
		{
			return default(IJBLNCALADF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		public void FCOKBJPDICD(MGMBHHHNCIH AIMNENJKCBP, NJNNNDNOLHN ILLCNPCAHGD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class DBKFJEAIDDA : OIHNLCKABAD
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int DACICCMFDDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x58C9080", Offset = "0x58C7680", VA = "0x1858C9080", Slot = "5")]
		public JGNIOMAODHJ CBIBKFJJEBN(DCNCJACIPJA.HAOKLNODKCD IAFBKNNAACG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void DAINDIEMFMF();

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void OAEBHIBCKMG();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		protected DBKFJEAIDDA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface OIHNLCKABAD
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int DACICCMFDDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		JGNIOMAODHJ CBIBKFJJEBN(DCNCJACIPJA.HAOKLNODKCD IAFBKNNAACG);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void DAINDIEMFMF();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OAEBHIBCKMG();
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct IHFCPPNOHGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67A420", Offset = "0x679820")]
		public PPBNKPLHMKG<IJBLNCALADF, NJNNNDNOLHN, MGMBHHHNCIH, ILLEHKNENGB.MIACHIBEEKI<IJBLNCALADF, NJNNNDNOLHN, MGMBHHHNCIH>> KIAIEGBMNCJ;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1E69BF0", Offset = "0x1E681F0", VA = "0x181E69BF0")]
		internal IHFCPPNOHGJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67A480", Offset = "0x679880")] PPBNKPLHMKG<IJBLNCALADF, NJNNNDNOLHN, MGMBHHHNCIH, ILLEHKNENGB.MIACHIBEEKI<IJBLNCALADF, NJNNNDNOLHN, MGMBHHHNCIH>> PMIAAPCBGPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x58CA2E0", Offset = "0x58C88E0", VA = "0x1858CA2E0")]
		public static IHFCPPNOHGJ OGNDBCBGIDA()
		{
			return default(IHFCPPNOHGJ);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct FNMDMLDPEJE : MNIMKIJILKL.FHHPGKODBDP<KKELMEPCMHJ, NJNNNDNOLHN, MGMBHHHNCIH>
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class MIFJLCGHMJA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67A580", Offset = "0x679980")]
			public AsyncTaskMethodBuilder<GLOEKJIOMHK<object, EKJAOIMOODA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public MGMBHHHNCIH receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NJNNNDNOLHN action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public FNMDMLDPEJE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67A5E0", Offset = "0x6799E0")]
			private GLOEKJIOMHK<object, EKJAOIMOODA> <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67A640", Offset = "0x679A40")]
			private TaskAwaiter<GLOEKJIOMHK<object, EKJAOIMOODA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
			public MIFJLCGHMJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x58CD230", Offset = "0x58CB830", VA = "0x1858CD230", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x98B280", Offset = "0x989880", VA = "0x18098B280", Slot = "4")]
		public LFFHALFGHGE<KKELMEPCMHJ> EMLNGJPMCAN(MGMBHHHNCIH BAJMCEMGHIM)
		{
			return default(LFFHALFGHGE<KKELMEPCMHJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x58C91F0", Offset = "0x58C77F0", VA = "0x1858C91F0", Slot = "5")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(MIFJLCGHMJA))]
		public Task<GLOEKJIOMHK<object, EKJAOIMOODA>> KLGLCBGCMMF(MGMBHHHNCIH BAJMCEMGHIM, NJNNNDNOLHN ILLCNPCAHGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x58C91D0", Offset = "0x58C77D0", VA = "0x1858C91D0", Slot = "6")]
		public NJNNNDNOLHN[] CGINEEAGDMA(MGMBHHHNCIH BAJMCEMGHIM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class LPNGEKMKIGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67A6A0", Offset = "0x679AA0")]
		public AsyncTaskMethodBuilder<GLOEKJIOMHK<bool, EKJAOIMOODA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public ODHDHNAJIAC rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public LJPOEFCNFMG circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public EOBAFPPEEPC superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public MGMBHHHNCIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67A700", Offset = "0x679B00")]
		private GLOEKJIOMHK<bool, EKJAOIMOODA> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67A760", Offset = "0x679B60")]
		private TaskAwaiter<GLOEKJIOMHK<bool, EKJAOIMOODA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public LPNGEKMKIGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x58CCD00", Offset = "0x58CB300", VA = "0x1858CCD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class HDMBOHADHBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67A7C0", Offset = "0x679BC0")]
		public AsyncTaskMethodBuilder<GLOEKJIOMHK<bool, EKJAOIMOODA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public MGMBHHHNCIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67A820", Offset = "0x679C20")]
		private GLOEKJIOMHK<bool, EKJAOIMOODA> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67A880", Offset = "0x679C80")]
		private TaskAwaiter<GLOEKJIOMHK<bool, EKJAOIMOODA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public HDMBOHADHBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x58C9410", Offset = "0x58C7A10", VA = "0x1858C9410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class IALBEDGMOPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67A8E0", Offset = "0x679CE0")]
		public AsyncTaskMethodBuilder<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public MGMBHHHNCIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67A940", Offset = "0x679D40")]
		private GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67A9A0", Offset = "0x679DA0")]
		private TaskAwaiter<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public IALBEDGMOPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x58CA110", Offset = "0x58C8710", VA = "0x1858CA110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class MCDGENEGBEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67AA00", Offset = "0x679E00")]
		public AsyncTaskMethodBuilder<GLOEKJIOMHK<object, EKJAOIMOODA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public NJNNNDNOLHN action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public MGMBHHHNCIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private GLOEKJIOMHK<object, EKJAOIMOODA> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter<GLOEKJIOMHK<object, EKJAOIMOODA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public MCDGENEGBEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x58CCFA0", Offset = "0x58CB5A0", VA = "0x1858CCFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class JNNKMFNGFKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67AA60", Offset = "0x679E60")]
		public AsyncTaskMethodBuilder<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public MGMBHHHNCIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67AAC0", Offset = "0x679EC0")]
		private GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA> <r>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67AB20", Offset = "0x679F20")]
		private GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA> <destroyRes>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67AB80", Offset = "0x679F80")]
		private GLOEKJIOMHK<bool, EKJAOIMOODA> <createRes>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67ABE0", Offset = "0x679FE0")]
		private GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA> <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67AC40", Offset = "0x67A040")]
		private GLOEKJIOMHK<bool, EKJAOIMOODA> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67ACA0", Offset = "0x67A0A0")]
		private TaskAwaiter<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67AD00", Offset = "0x67A100")]
		private TaskAwaiter<GLOEKJIOMHK<bool, EKJAOIMOODA>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public JNNKMFNGFKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x58CC690", Offset = "0x58CAC90", VA = "0x1858CC690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x679B80", Offset = "0x678F80")]
	private readonly LFFHALFGHGE<KKELMEPCMHJ> IIKEHCHNBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly MDODBKEEIBJ GICJOHGFDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly AMOPADIKIFI PNELDEJOGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly EAEOEGJDDBD MILBJGFKLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly EJLCIIOOAFC.GHCAAJGPMIG GMCAJJNOPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly EIIDCKACEOG EBDODEIKLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly KGFMLKNKLFF FOKOIICJJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly JHGNKMCIPFL IBGCBPIDPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly LIONNJLFGMG MPOJAKLKAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private CECOOELNCEG KEFPDDLFPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private KCPDMLCCFKP AMLNGKEHEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal readonly AMOPADIKIFI.PJKBPKAIJDK MNAFJEDFFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly BHNDNNIFJAB BIKCPNFECHI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public AMOPADIKIFI ACOOJHCDKNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x21FD6C0", Offset = "0x21FBCC0", VA = "0x1821FD6C0")]
		get
		{
			return default(AMOPADIKIFI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal OIHNLCKABAD BBDGFDLKJID
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x21FD670", Offset = "0x21FBC70", VA = "0x1821FD670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal JGNIOMAODHJ AHBEEDIDIOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x96A570", Offset = "0x968B70", VA = "0x18096A570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x969AD0", Offset = "0x9680D0", VA = "0x180969AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool MJOAAEMFFDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xC77340", Offset = "0xC75940", VA = "0x180C77340")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xDE93A0", Offset = "0xDE79A0", VA = "0x180DE93A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public LEIEPKIKLJD MBBDAODFLHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9DA620", Offset = "0x9D8C20", VA = "0x1809DA620", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IFJCOEAPEFE AIGLDFNFIOC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA7AB30", Offset = "0xA79130", VA = "0x180A7AB30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public OELOJFCFNIH FDBLMNLDEMN
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA37B90", Offset = "0xA36190", VA = "0x180A37B90", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public KJCGCACGAOA MLAOAOEMHEE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9F3250", Offset = "0x9F1850", VA = "0x1809F3250", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private LGIHHDHNBJI? IPKKHFPPJDM
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x21FD830", Offset = "0x21FBE30", VA = "0x1821FD830", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private HCEHOPPCJNP? MKHKFKMCENA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x21FDEC0", Offset = "0x21FC4C0", VA = "0x1821FDEC0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x21FE140", Offset = "0x21FC740", VA = "0x1821FE140")]
	private MGMBHHHNCIH(EAEOEGJDDBD KOBLJDIMIFH, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x679D10", Offset = "0x679110")] LFFHALFGHGE<KKELMEPCMHJ> FCNDKEMFAHH, MDODBKEEIBJ PDOLBINOAGJ, AMOPADIKIFI ANEACCBHMEN, JGNIOMAODHJ NMLCLDDPDNM, in EJLCIIOOAFC.GHCAAJGPMIG BIDCFDFPKNI, AMOPADIKIFI.PJKBPKAIJDK PBMPLEADPOB, BHNDNNIFJAB HLEPCMNNHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x21FD960", Offset = "0x21FBF60", VA = "0x1821FD960")]
	public static MGMBHHHNCIH OGNDBCBGIDA(EAEOEGJDDBD IAFBKNNAACG, AMOPADIKIFI.MDEKKPCONKH NGHLDPNJPOH, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x679D70", Offset = "0x679170")] LFFHALFGHGE<KKELMEPCMHJ> FCNDKEMFAHH, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x679DD0", Offset = "0x6791D0")] LFFHALFGHGE<JFBHGMMHIPP> ILCBJNBBIKN, BONGOLGIJCE CAJJAGENDFK, KLDBKIILLAH CCLBNPNIFLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x21FDA10", Offset = "0x21FC010", VA = "0x1821FDA10")]
	public static MGMBHHHNCIH OGNDBCBGIDA(EAEOEGJDDBD KOBLJDIMIFH, in AMOPADIKIFI ANEACCBHMEN, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x679E90", Offset = "0x679290")] LFFHALFGHGE<KKELMEPCMHJ> FCNDKEMFAHH, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x679F50", Offset = "0x679350")] LFFHALFGHGE<JFBHGMMHIPP> ILCBJNBBIKN, BONGOLGIJCE CAJJAGENDFK, KLDBKIILLAH CCLBNPNIFLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x21FD450", Offset = "0x21FBA50", VA = "0x1821FD450", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x21FD280", Offset = "0x21FB880", VA = "0x1821FD280")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LPNGEKMKIGE))]
	internal Task<GLOEKJIOMHK<bool, EKJAOIMOODA>> DIKAMOLFFCF(ODHDHNAJIAC JJCCABKNMNO, LJPOEFCNFMG LJPDCOPADII, EOBAFPPEEPC FNCCJLEJOEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x21FDFF0", Offset = "0x21FC5F0", VA = "0x1821FDFF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HDMBOHADHBC))]
	public Task<GLOEKJIOMHK<bool, EKJAOIMOODA>> OODLODAEDKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x21FCA10", Offset = "0x21FB010", VA = "0x1821FCA10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IALBEDGMOPJ))]
	public Task<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> BHKBLPGPJBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x21FD040", Offset = "0x21FB640", VA = "0x1821FD040")]
	internal void COBGKEALNJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x21FD750", Offset = "0x21FBD50", VA = "0x1821FD750")]
	internal PGBDAGMDGBE<NJNNNDNOLHN> KNKJMLEMPAB(in EIGGGDGKGEO FPGDCFICIOM)
	{
		return default(PGBDAGMDGBE<NJNNNDNOLHN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x21FD7D0", Offset = "0x21FBDD0", VA = "0x1821FD7D0")]
	internal bool NCMNMGKAMEE(in EIGGGDGKGEO FPGDCFICIOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x21FD6D0", Offset = "0x21FBCD0", VA = "0x1821FD6D0")]
	internal PGBDAGMDGBE<NJNNNDNOLHN> KINNPJFBMJB(in OMCOJBJDFLN ECEDCPCIGDK)
	{
		return default(PGBDAGMDGBE<NJNNNDNOLHN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x21FCB60", Offset = "0x21FB160", VA = "0x1821FCB60")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MCDGENEGBEN))]
	internal Task<GLOEKJIOMHK<object, EKJAOIMOODA>> CFINALMJCBM(NJNNNDNOLHN ILLCNPCAHGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x21FCCD0", Offset = "0x21FB2D0", VA = "0x1821FCCD0")]
	private NJNNNDNOLHN[] CGINEEAGDMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x21FDD60", Offset = "0x21FC360", VA = "0x1821FDD60")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JNNKMFNGFKL))]
	public Task<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> OIFGOLHFNNP(Guid EGFDOJMAONI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class NIEKNBEJIBK<TData> : BNAKFCOEFAL, GMMNHDMGPAJ, BONKIFBLCIE where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67AD60", Offset = "0x67A160")]
	private readonly AMHGAJFIDOK<FJPOKNNDJKJ>? PDEGBIKOMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly string APNBCBOBIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly TData JEFFIAODLOM;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67AF10", Offset = "0x67A310")]
	public AMHGAJFIDOK<FJPOKNNDJKJ>? PLBHHPMNEIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x271E0A0", Offset = "0x271C6A0", VA = "0x18271E0A0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x9B2080", Offset = "0x9B0680", VA = "0x1809B2080", Slot = "7")]
	public override string KDCKINHCHKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x271E0B0", Offset = "0x271C6B0", VA = "0x18271E0B0")]
	internal NIEKNBEJIBK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67AE40", Offset = "0x67A240")] in AMHGAJFIDOK<FJPOKNNDJKJ>? KCBFJJNAFEF, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67AEB0", Offset = "0x67A2B0")] LFFHALFGHGE<AGCDOBKINFJ>? GJONMEDHIIF, IOKind? FFCFFABEDNH, string DPAJDIEBNKM, in TData JAIGDBINGHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class KMAJDCNGGOI
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x21FB570", Offset = "0x21F9B70", VA = "0x1821FB570")]
	public static GLOEKJIOMHK<NGLKIJNHAPK, GMMNHDMGPAJ> CKFNKHHCCHF(this in GABBGCBMEFF<IDHHIOPCOIG> GMOFBNBPACH)
	{
		return default(GLOEKJIOMHK<NGLKIJNHAPK, GMMNHDMGPAJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xF3C8B0", Offset = "0xF3AEB0", VA = "0x180F3C8B0")]
	public static GLOEKJIOMHK<TOk, GMMNHDMGPAJ> ELEKDMHIBJD<TOk>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67AF80", Offset = "0x67A380")] this in GLOEKJIOMHK<TOk, GMMNHDMGPAJ> CDBMADFDGCE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67AFF0", Offset = "0x67A3F0")] in AMHGAJFIDOK<FJPOKNNDJKJ>? KCBFJJNAFEF, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67B060", Offset = "0x67A460")] LFFHALFGHGE<AGCDOBKINFJ>? GJONMEDHIIF, IOKind? FFCFFABEDNH, string DPAJDIEBNKM) where TOk : notnull
	{
		return default(GLOEKJIOMHK<TOk, GMMNHDMGPAJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class CJCNPIEKMED
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x191CEC0", Offset = "0x191B4C0", VA = "0x18191CEC0")]
	public static HLKFBKIOHKM<(TPrev?, MGMBHHHNCIH?), HCEHOPPCJNP> DLFANMOBEAB<TPrev>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67B100", Offset = "0x67A500")] this in HLKFBKIOHKM<TPrev?, MGMBHHHNCIH?> CDBMADFDGCE)
	{
		return default(HLKFBKIOHKM<(TPrev, MGMBHHHNCIH), HCEHOPPCJNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x191D160", Offset = "0x191B760", VA = "0x18191D160")]
	public static HLKFBKIOHKM<TPrev?, MGMBHHHNCIH?> ILCHIMCNCAG<TPrev>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67B170", Offset = "0x67A570")] this in HLKFBKIOHKM<TPrev?, MGMBHHHNCIH?> CDBMADFDGCE)
	{
		return default(HLKFBKIOHKM<TPrev, MGMBHHHNCIH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface EAEOEGJDDBD
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	CEHKONMONKB.APFOKPPKJNI CDMAIBCPMMN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	DCNCJACIPJA.HAOKLNODKCD IHLKECDAIOB
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	MGMBHHHNCIH.OIHNLCKABAD CPEHPHFMMND
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	MAPIAIAFEBO.DIFOAAFEIGI JEJHEOCGHDE
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	ILLEHKNENGB.MIACHIBEEKI<IJBLNCALADF, NJNNNDNOLHN, MGMBHHHNCIH> CKCJMJBKFBI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	HEEHAPCKPNK OGFDBBPHLAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	JKPIEHOAJOM NCAKJLENJPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	HEKAMFEJFFG CLCKCDPLIBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	HGCAIGHNICF MHJLJPEOOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	AKPAAILGPPI EKPELLHDDCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct JAPAANJKKBL
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class PBAIBFIJPAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67B280", Offset = "0x67A680")]
		public AsyncTaskMethodBuilder<GLOEKJIOMHK<MDAIIAIHCFN, EKJAOIMOODA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public MGMBHHHNCIH root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public JAPAANJKKBL self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67B2E0", Offset = "0x67A6E0")]
		private GLOEKJIOMHK<MDAIIAIHCFN, EKJAOIMOODA> <r1>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67B340", Offset = "0x67A740")]
		private GLOEKJIOMHK<object, BONKIFBLCIE>[] <aggregateResult>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67B3A0", Offset = "0x67A7A0")]
		private GLOEKJIOMHK<object, BONKIFBLCIE> <r2>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67B400", Offset = "0x67A800")]
		private GLOEKJIOMHK<object, BONKIFBLCIE>[] <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67B460", Offset = "0x67A860")]
		private GLOEKJIOMHK<object, EKJAOIMOODA> <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67B4C0", Offset = "0x67A8C0")]
		private TaskAwaiter<GLOEKJIOMHK<object, EKJAOIMOODA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public PBAIBFIJPAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x58CD400", Offset = "0x58CBA00", VA = "0x1858CD400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly IReadOnlyList<NJNNNDNOLHN> GBOEPNIIMMC;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x9C1FF0", Offset = "0x9C05F0", VA = "0x1809C1FF0")]
	private JAPAANJKKBL(IReadOnlyList<NJNNNDNOLHN> CPNBDMBECHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x21F7C60", Offset = "0x21F6260", VA = "0x1821F7C60")]
	public static NJNNNDNOLHN AEKPEIAMCHF(IReadOnlyList<NJNNNDNOLHN> CPNBDMBECHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x21F7EA0", Offset = "0x21F64A0", VA = "0x1821F7EA0")]
	public static PELCPHJCILN<IJBLNCALADF, JAPAANJKKBL> HHPMNNGMHOH(NJNNNDNOLHN EGOPHCLHLNH)
	{
		return default(PELCPHJCILN<IJBLNCALADF, JAPAANJKKBL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x21F7D30", Offset = "0x21F6330", VA = "0x1821F7D30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PBAIBFIJPAO))]
	public static Task<GLOEKJIOMHK<MDAIIAIHCFN, EKJAOIMOODA>> CFINALMJCBM(MGMBHHHNCIH AIMNENJKCBP, JAPAANJKKBL CDBMADFDGCE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class HFJIAOEMCJK
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x21F65B0", Offset = "0x21F4BB0", VA = "0x1821F65B0")]
	public static NJNNNDNOLHN AFCJFMOFPFE(this NJNNNDNOLHN CDBMADFDGCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x21F66D0", Offset = "0x21F4CD0", VA = "0x1821F66D0")]
	public static NJNNNDNOLHN LCNLGGJCFDD(this IIGIHGFPBEM CDBMADFDGCE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct OJKFGEJAJLE
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class AJEFOGMKEDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67B5E0", Offset = "0x67A9E0")]
		public AsyncTaskMethodBuilder<GLOEKJIOMHK<CMCGOMMIJLE, EFMPBCAAJAD?>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public MGMBHHHNCIH root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public OJKFGEJAJLE self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67B640", Offset = "0x67AA40")]
		private GLOEKJIOMHK<CMCGOMMIJLE, EFMPBCAAJAD?> <r>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private bool <shouldDiscard>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public AJEFOGMKEDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x58C8A40", Offset = "0x58C7040", VA = "0x1858C8A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly ODHDHNAJIAC? GNDHAELHOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly LJPOEFCNFMG? AFMMJLPJGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly EOBAFPPEEPC? DPDMNGLJBAH;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x97D180", Offset = "0x97B780", VA = "0x18097D180")]
	private OJKFGEJAJLE(ODHDHNAJIAC? JJCCABKNMNO, LJPOEFCNFMG? LJPDCOPADII, EOBAFPPEEPC? FNCCJLEJOEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2201AD0", Offset = "0x22000D0", VA = "0x182201AD0")]
	public static NJNNNDNOLHN? AEKPEIAMCHF(ODHDHNAJIAC? JJCCABKNMNO, LJPOEFCNFMG? LJPDCOPADII, EOBAFPPEEPC? FNCCJLEJOEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2201D50", Offset = "0x2200350", VA = "0x182201D50")]
	public static PELCPHJCILN<IJBLNCALADF, OJKFGEJAJLE> HHPMNNGMHOH(NJNNNDNOLHN EGOPHCLHLNH)
	{
		return default(PELCPHJCILN<IJBLNCALADF, OJKFGEJAJLE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2201BD0", Offset = "0x22001D0", VA = "0x182201BD0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AJEFOGMKEDD))]
	public static Task<GLOEKJIOMHK<CMCGOMMIJLE, EFMPBCAAJAD>> CFINALMJCBM(MGMBHHHNCIH AIMNENJKCBP, OJKFGEJAJLE CDBMADFDGCE)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct AJLKMBPLPBM
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x21E8660", Offset = "0x21E6C60", VA = "0x1821E8660")]
	public static NJNNNDNOLHN AEKPEIAMCHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x21E8780", Offset = "0x21E6D80", VA = "0x1821E8780")]
	public static PELCPHJCILN<IJBLNCALADF, AJLKMBPLPBM> HHPMNNGMHOH(NJNNNDNOLHN EGOPHCLHLNH)
	{
		return default(PELCPHJCILN<IJBLNCALADF, AJLKMBPLPBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x21E8700", Offset = "0x21E6D00", VA = "0x1821E8700")]
	public static GLOEKJIOMHK<CMCGOMMIJLE, EFMPBCAAJAD> GKDMFBNGFFM(MGMBHHHNCIH AIMNENJKCBP, in AJLKMBPLPBM CDBMADFDGCE)
	{
		return default(GLOEKJIOMHK<CMCGOMMIJLE, EFMPBCAAJAD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct EIGGGDGKGEO
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class CIBNGINAACL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67B750", Offset = "0x67AB50")]
		public AsyncTaskMethodBuilder<GLOEKJIOMHK<bool, EFMPBCAAJAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public MGMBHHHNCIH root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public EIGGGDGKGEO self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67B7B0", Offset = "0x67ABB0")]
		private GLOEKJIOMHK<bool, EFMPBCAAJAD> <r>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private bool <shouldDiscard>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private NJNNNDNOLHN <value>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67B810", Offset = "0x67AC10")]
		private TaskAwaiter<GLOEKJIOMHK<CMCGOMMIJLE, EFMPBCAAJAD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public CIBNGINAACL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x21E9A30", Offset = "0x21E8030", VA = "0x1821E9A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly int AEJJJIDCFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int FIFIFGFPIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly byte[] JEFFIAODLOM;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0xBED800", Offset = "0xBEBE00", VA = "0x180BED800")]
	private EIGGGDGKGEO(int FJLPCOJGEJP, int OLGOBCPPPBB, byte[] JAIGDBINGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x21EB5C0", Offset = "0x21E9BC0", VA = "0x1821EB5C0")]
	public static NJNNNDNOLHN AEKPEIAMCHF(int FJLPCOJGEJP, int OLGOBCPPPBB, ByteString JAIGDBINGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x21EB950", Offset = "0x21E9F50", VA = "0x1821EB950")]
	public static NJNNNDNOLHN?[]? PHKCJEMJKML(int FMEBMFODBBO, ODHDHNAJIAC? JJCCABKNMNO, LJPOEFCNFMG? LJPDCOPADII, EOBAFPPEEPC? FNCCJLEJOEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x21EB830", Offset = "0x21E9E30", VA = "0x1821EB830")]
	public static PELCPHJCILN<IJBLNCALADF, EIGGGDGKGEO> HHPMNNGMHOH(NJNNNDNOLHN EGOPHCLHLNH)
	{
		return default(PELCPHJCILN<IJBLNCALADF, EIGGGDGKGEO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x21EB6C0", Offset = "0x21E9CC0", VA = "0x1821EB6C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CIBNGINAACL))]
	public static Task<GLOEKJIOMHK<bool, EFMPBCAAJAD>> CFINALMJCBM(MGMBHHHNCIH AIMNENJKCBP, EIGGGDGKGEO CDBMADFDGCE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct IIGIHGFPBEM
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class AFBFBMADJGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67B8E0", Offset = "0x67ACE0")]
		public AsyncTaskMethodBuilder<GLOEKJIOMHK<object, EKJAOIMOODA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public MGMBHHHNCIH root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public IIGIHGFPBEM self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67B940", Offset = "0x67AD40")]
		private GLOEKJIOMHK<object, EKJAOIMOODA> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67B9A0", Offset = "0x67ADA0")]
		private TaskAwaiter<GLOEKJIOMHK<object, EKJAOIMOODA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public AFBFBMADJGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x21E82F0", Offset = "0x21E68F0", VA = "0x1821E82F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly ByteString INKIKMDHKDA;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x9C1FF0", Offset = "0x9C05F0", VA = "0x1809C1FF0")]
	private IIGIHGFPBEM(ByteString MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x21F75D0", Offset = "0x21F5BD0", VA = "0x1821F75D0")]
	public static NJNNNDNOLHN AEKPEIAMCHF(ByteString MOLEJFDINLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x21F7800", Offset = "0x21F5E00", VA = "0x1821F7800")]
	public static PELCPHJCILN<IJBLNCALADF, IIGIHGFPBEM> HHPMNNGMHOH(NJNNNDNOLHN EGOPHCLHLNH)
	{
		return default(PELCPHJCILN<IJBLNCALADF, IIGIHGFPBEM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x21F7690", Offset = "0x21F5C90", VA = "0x1821F7690")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AFBFBMADJGG))]
	public static Task<GLOEKJIOMHK<object, EKJAOIMOODA>> CFINALMJCBM(MGMBHHHNCIH AIMNENJKCBP, IIGIHGFPBEM CDBMADFDGCE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct OMCOJBJDFLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly int AEJJJIDCFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly int FIFIFGFPIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public readonly byte[] JEFFIAODLOM;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xBED800", Offset = "0xBEBE00", VA = "0x180BED800")]
	private OMCOJBJDFLN(int FJLPCOJGEJP, int OLGOBCPPPBB, byte[] JAIGDBINGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2201EA0", Offset = "0x22004A0", VA = "0x182201EA0")]
	public static NJNNNDNOLHN AEKPEIAMCHF(int FJLPCOJGEJP, int OLGOBCPPPBB, ByteString JAIGDBINGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x22021E0", Offset = "0x22007E0", VA = "0x1822021E0")]
	public static NJNNNDNOLHN[] NPJILMCBPLG(NJNNNDNOLHN ILLCNPCAHGD, int FMEBMFODBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x22020C0", Offset = "0x22006C0", VA = "0x1822020C0")]
	public static PELCPHJCILN<IJBLNCALADF, OMCOJBJDFLN> HHPMNNGMHOH(NJNNNDNOLHN EGOPHCLHLNH)
	{
		return default(PELCPHJCILN<IJBLNCALADF, OMCOJBJDFLN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2201FA0", Offset = "0x22005A0", VA = "0x182201FA0")]
	public static GLOEKJIOMHK<NJNNNDNOLHN, EFMPBCAAJAD> GKDMFBNGFFM(MGMBHHHNCIH AIMNENJKCBP, in OMCOJBJDFLN CDBMADFDGCE)
	{
		return default(GLOEKJIOMHK<NJNNNDNOLHN, EFMPBCAAJAD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface OFAHEJLINJF
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	string OMBLKOFJABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DFOCIDEGBPP? DJCMNNDGPCL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67BA00", Offset = "0x67AE00")] LFFHALFGHGE<OCECEILCCEK?> DPKPHMBFEDO);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HIICJMFOLJA? BGLFAHLHLJC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67BA60", Offset = "0x67AE60")] LFFHALFGHGE<OGGCMDMBDIL?> BIINHNDDAPM);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface HIICJMFOLJA
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	string OMBLKOFJABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface HEEHAPCKPNK
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MLIABJIBINN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67BAC0", Offset = "0x67AEC0")] in GLOEKJIOMHK<CMCGOMMIJLE, BONKIFBLCIE> NKONLKNLFIB);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class PGBAHLIDKHB
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2308450", Offset = "0x2306A50", VA = "0x182308450")]
	public static bool MLIABJIBINN<TOk, TErr>(this HEEHAPCKPNK CDBMADFDGCE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67BB30", Offset = "0x67AF30")] in GLOEKJIOMHK<TOk, TErr> NKONLKNLFIB) where TOk : notnull where TErr : notnull, BONKIFBLCIE
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface HGCAIGHNICF
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> HJEGLHFFMBF(string MOLEJFDINLH, string MFPELEJLJLD);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface AKPAAILGPPI
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KILNKDLFEEM? OLKEAJKBOHM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67BBA0", Offset = "0x67AFA0")] in AMHGAJFIDOK<OFPDHDDFGIH?> DIKNKMJHNFE);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface DFOCIDEGBPP
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	string OMBLKOFJABM
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface JKPIEHOAJOM
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	MAJEALHBJKL OHHEIFMKEHE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface KILNKDLFEEM
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OFAHEJLINJF? POCAKBGBPAF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67BC10", Offset = "0x67B010")] LFFHALFGHGE<NKHIKPDNMME?> EDLAGDLJLID);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface HEKAMFEJFFG
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NDMAHCEMKBI AGHJEDIMLBC(int MJINPOOBPFB);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class JGKLCCEJBFB
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private struct IMEGGFNCAAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int FIFIFGFPIHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public LJPOEFCNFMG? AEGNBEDAGHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public LJPOEFCNFMG? NMHJONLODDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public readonly List<NJNNNDNOLHN> GBOEPNIIMMC;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x35BF5F0", Offset = "0x35BDBF0", VA = "0x1835BF5F0")]
		private IMEGGFNCAAB(int OLGOBCPPPBB, LJPOEFCNFMG? GCDCNNGBIFF, LJPOEFCNFMG? ANKFLFIBDIB, List<NJNNNDNOLHN> CPNBDMBECHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x58CA390", Offset = "0x58C8990", VA = "0x1858CA390")]
		public static IMEGGFNCAAB OGNDBCBGIDA()
		{
			return default(IMEGGFNCAAB);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private int HGMOCGOENNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly MJFIOODNFMO<IMEGGFNCAAB> IFNNDKCJGKA;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static JGKLCCEJBFB HAMPJMKDJOL
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x21F8970", Offset = "0x21F6F70", VA = "0x1821F8970")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool LMDFJDHFPHG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x979990", Offset = "0x977F90", VA = "0x180979990")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x979740", Offset = "0x977D40", VA = "0x180979740")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x21F81D0", Offset = "0x21F67D0", VA = "0x1821F81D0")]
	public void FGIPJMPNBFO(EJLCIIOOAFC ANKFLFIBDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x21F8660", Offset = "0x21F6C60", VA = "0x1821F8660")]
	public void IOIKOKGJLFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x21F82B0", Offset = "0x21F68B0", VA = "0x1821F82B0")]
	private static string? GEALFGCFOLO(in IMEGGFNCAAB JEFLIFENMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x21F8AD0", Offset = "0x21F70D0", VA = "0x1821F8AD0")]
	public JGKLCCEJBFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class EIIDCKACEOG : LEIEPKIKLJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly MGMBHHHNCIH EOPJACEKJNO;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public LBPPHHKECGH? HAMPJMKDJOL
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x21EBB60", Offset = "0x21EA160", VA = "0x1821EBB60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0xA0C770", Offset = "0xA0AD70", VA = "0x180A0C770")]
	internal EIIDCKACEOG(MGMBHHHNCIH LAKMIJDGKNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class FLNFDAOBKGC : LJMGIDIDEKA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly IPBLBNMFKKF HACFAKNKMFJ;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public IPBLBNMFKKF PGNAPMIAACG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xA0C770", Offset = "0xA0AD70", VA = "0x180A0C770")]
	private FLNFDAOBKGC(IPBLBNMFKKF MGGKBMJJPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x21ED870", Offset = "0x21EBE70", VA = "0x1821ED870")]
	public static FLNFDAOBKGC LKBINHHANLF(MGMBHHHNCIH LAKMIJDGKNI, ODHDHNAJIAC DEFLADKHHGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x21ED850", Offset = "0x21EBE50", VA = "0x1821ED850", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class FHAKBFIDIOA : NEOEDMKFMDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly JEFKKIMMHNA PPHLNLFEKDF;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static readonly HashSet<JEFKKIMMHNA> BGBMPHJFOBC;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly HashSet<JEFKKIMMHNA> KBMHKHONGBI;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly HashSet<JEFKKIMMHNA> ICMCGEPIHGE;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public TypeKey GGPPGDHBOOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x21ED320", Offset = "0x21EB920", VA = "0x1821ED320", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool OCOHBAHDALJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x21ED310", Offset = "0x21EB910", VA = "0x1821ED310", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool COHLKOLLMEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x21ED380", Offset = "0x21EB980", VA = "0x1821ED380", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool FMHPEKDFJBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x21ED280", Offset = "0x21EB880", VA = "0x1821ED280", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x21EBDE0", Offset = "0x21EA3E0", VA = "0x1821EBDE0")]
	public bool JPKCPKADLHL(string MOLEJFDINLH, out GNCPIKAEHID HIEIMGIMMGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0xA0C770", Offset = "0xA0AD70", VA = "0x180A0C770")]
	public FHAKBFIDIOA(JEFKKIMMHNA PMIAAPCBGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x21EBC50", Offset = "0x21EA250", VA = "0x1821EBC50")]
	internal static TypeKey DPEEAHCAHBE(JEFKKIMMHNA KLGGKKGCLHM)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x21EC0B0", Offset = "0x21EA6B0", VA = "0x1821EC0B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class MLKECFDPLME
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67BCB0", Offset = "0x67B0B0")]
	private sealed class PJBPFPFCNJJ : HJDBMEEAPJB<KGFNIILIIAM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override NodeVisualizationKey GGPPGDHBOOI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x11236A0", Offset = "0x1121CA0", VA = "0x1811236A0", Slot = "82")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x58CD940", Offset = "0x58CBF40", VA = "0x1858CD940")]
		public PJBPFPFCNJJ(MGMBHHHNCIH LAKMIJDGKNI, KGFNIILIIAM ELLNBMOONAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67BD10", Offset = "0x67B110")]
	private abstract class OGNNNOPLFKB<TNode> : HJDBMEEAPJB<TNode> where TNode : notnull, EGGOPABEAKI
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class GOCMNJMKIFO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67C090", Offset = "0x67B490")]
			public AsyncTaskMethodBuilder<GLOEKJIOMHK<LFFHALFGHGE<NKHIKPDNMME>, EKJAOIMOODA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public OGNNNOPLFKB<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			private GLOEKJIOMHK<LFFHALFGHGE<NKHIKPDNMME>, EKJAOIMOODA> <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private TaskAwaiter<GLOEKJIOMHK<LFFHALFGHGE<NKHIKPDNMME>, EKJAOIMOODA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
			public GOCMNJMKIFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x33C88D0", Offset = "0x33C6ED0", VA = "0x1833C88D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class CBDLDEIGCOB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67C0F0", Offset = "0x67B4F0")]
			public AsyncTaskMethodBuilder<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67C150", Offset = "0x67B550")]
			public LFFHALFGHGE<NKHIKPDNMME> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public OGNNNOPLFKB<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA> <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private TaskAwaiter<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
			public CBDLDEIGCOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x2B6DC10", Offset = "0x2B6C210", VA = "0x182B6DC10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67BFC0", Offset = "0x67B3C0")]
		public override AMHGAJFIDOK<CPCENLDIBPJ>? EJJDBCNKMMC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x17AC740", Offset = "0x17AAD40", VA = "0x1817AC740", Slot = "110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67C030", Offset = "0x67B430")]
		public override LFFHALFGHGE<NKHIKPDNMME>? BEGFCIKKOEH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x2F2E150", Offset = "0x2F2C750", VA = "0x182F2E150", Slot = "114")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2494160", Offset = "0x2492760", VA = "0x182494160")]
		public OGNNNOPLFKB(MGMBHHHNCIH LAKMIJDGKNI, TNode ELLNBMOONAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2F2DC40", Offset = "0x2F2C240", VA = "0x182F2DC40", Slot = "92")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(OGNNNOPLFKB<>.GOCMNJMKIFO))]
		public override Task<GLOEKJIOMHK<LFFHALFGHGE<NKHIKPDNMME>, EKJAOIMOODA>> AKBLOGGFFAO(string ECMAPGHKHFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2F2DF20", Offset = "0x2F2C520", VA = "0x182F2DF20", Slot = "117")]
		public sealed override bool MOMNBNNIIMO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67BDD0", Offset = "0x67B1D0")] LFFHALFGHGE<NKHIKPDNMME> EDLAGDLJLID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2F2DE80", Offset = "0x2F2C480", VA = "0x182F2DE80", Slot = "106")]
		protected sealed override bool JPJKPGOLAFL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67BE30", Offset = "0x67B230")] LFFHALFGHGE<NKHIKPDNMME> EDLAGDLJLID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2F2DDE0", Offset = "0x2F2C3E0", VA = "0x182F2DDE0", Slot = "107")]
		protected override bool FCCKBICJCBN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67BE90", Offset = "0x67B290")] LFFHALFGHGE<NKHIKPDNMME> EDLAGDLJLID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2F2DFC0", Offset = "0x2F2C5C0", VA = "0x182F2DFC0", Slot = "93")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(OGNNNOPLFKB<>.CBDLDEIGCOB))]
		public override Task<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> NLIIADOKBHB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67BF60", Offset = "0x67B360")] LFFHALFGHGE<NKHIKPDNMME> EDLAGDLJLID)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67C1B0", Offset = "0x67B5B0")]
	private sealed class CAJLOABECNP : HJDBMEEAPJB<IFJIKCFPAEG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override NodeVisualizationKey GGPPGDHBOOI
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xA3B6B0", Offset = "0xA39CB0", VA = "0x180A3B6B0", Slot = "82")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x58C9020", Offset = "0x58C7620", VA = "0x1858C9020")]
		public CAJLOABECNP(MGMBHHHNCIH LAKMIJDGKNI, IFJIKCFPAEG ELLNBMOONAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67C210", Offset = "0x67B610")]
	private sealed class MBHLDAJKPBC : HJDBMEEAPJB<KOLPIACHKPC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override NodeVisualizationKey GGPPGDHBOOI
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x999A30", Offset = "0x998030", VA = "0x180999A30", Slot = "82")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x58CCF40", Offset = "0x58CB540", VA = "0x1858CCF40")]
		public MBHLDAJKPBC(MGMBHHHNCIH LAKMIJDGKNI, KOLPIACHKPC ELLNBMOONAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67C270", Offset = "0x67B670")]
	private sealed class HHFIHJHPFHC : OGNNNOPLFKB<OLDOLAAKKEO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override bool EPHKEPDJLLI
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x7EB370", Offset = "0x7E9970", VA = "0x1807EB370", Slot = "84")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override NodeVisualizationKey GGPPGDHBOOI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x93ACA0", Offset = "0x9392A0", VA = "0x18093ACA0", Slot = "82")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x58C9640", Offset = "0x58C7C40", VA = "0x1858C9640")]
		public HHFIHJHPFHC(MGMBHHHNCIH LAKMIJDGKNI, OLDOLAAKKEO ELLNBMOONAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67C2D0", Offset = "0x67B6D0")]
	private sealed class DLAIPEFCIKA : HJDBMEEAPJB<BOPJKHMPABD>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override NodeVisualizationKey GGPPGDHBOOI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xD57810", Offset = "0xD55E10", VA = "0x180D57810", Slot = "82")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x58C90E0", Offset = "0x58C76E0", VA = "0x1858C90E0")]
		public DLAIPEFCIKA(MGMBHHHNCIH LAKMIJDGKNI, BOPJKHMPABD ELLNBMOONAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67C330", Offset = "0x67B730")]
	private sealed class PCNOLPPBHMB : KJHPGFBGOCF<MFGFCABBFFP>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override NodeVisualizationKey GGPPGDHBOOI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x952C20", Offset = "0x951220", VA = "0x180952C20", Slot = "82")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x58CD880", Offset = "0x58CBE80", VA = "0x1858CD880")]
		public PCNOLPPBHMB(MGMBHHHNCIH LAKMIJDGKNI, MFGFCABBFFP ELLNBMOONAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class HJDBMEEAPJB<TNode> : BDNEGBLDEEE, IDisposable where TNode : notnull, CCFBALPMCKN
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class GGLPJBGKBLG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public HJDBMEEAPJB<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public MGMBHHHNCIH circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
			public GGLPJBGKBLG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x24E0F00", Offset = "0x24DF500", VA = "0x1824E0F00")]
			internal HDGHEEOCBGG PDJHEAFEGKP(GFIEFCLJIOE portGroup, int index)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class MNHOPHLDFLF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67D6D0", Offset = "0x67CAD0")]
			public AsyncTaskMethodBuilder<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public JLPKIKAFHCH? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public ANPHIDGEMNH? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public HJDBMEEAPJB<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA> <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			private TaskAwaiter<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
			public MNHOPHLDFLF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x2414EB0", Offset = "0x24134B0", VA = "0x182414EB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class PHEAONCKOHE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67D730", Offset = "0x67CB30")]
			public AsyncTaskMethodBuilder<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public HJDBMEEAPJB<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA> <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private TaskAwaiter<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
			public PHEAONCKOHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x1F13FB0", Offset = "0x1F125B0", VA = "0x181F13FB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private MGMBHHHNCIH EOPJACEKJNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67C390", Offset = "0x67B790")]
		private LLGEOEEHMEJ<NKHIKPDNMME, HDGHEEOCBGG> KGBFOKNNLID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67C3F0", Offset = "0x67B7F0")]
		private LLGEOEEHMEJ<NKHIKPDNMME, FCKKIELDCKA> IIFJPIGIGDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[CompilerGenerated]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67C7D0", Offset = "0x67BBD0")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<LFFHALFGHGE<NKHIKPDNMME>> MHGAFCODFLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67C850", Offset = "0x67BC50")]
		private Action<LFFHALFGHGE<NKHIKPDNMME>, FCKKIELDCKA> ADMMLLAMANG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67C950", Offset = "0x67BD50")]
		private Action<LFFHALFGHGE<NKHIKPDNMME>, LFFHALFGHGE<NKHIKPDNMME>> CJHPKNPMLBN;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected TNode NGJEANNFDAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x913730", Offset = "0x911D30", VA = "0x180913730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67D160", Offset = "0x67C560")]
		public AMHGAJFIDOK<OFPDHDDFGIH> NHMKFPOABLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xCEA020", Offset = "0xCE8620", VA = "0x180CEA020", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(AMHGAJFIDOK<OFPDHDDFGIH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public object LKMDIOHLICO
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x1CDD830", Offset = "0x1CDBE30", VA = "0x181CDD830", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public virtual bool EFLCEMLBOLH
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x7EB370", Offset = "0x7E9970", VA = "0x1807EB370", Slot = "80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int CEEHBGNNGJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2192360", Offset = "0x2190960", VA = "0x182192360", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public NDMAHCEMKBI MJHHPFMDOCL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x2192320", Offset = "0x2190920", VA = "0x182192320", Slot = "9")]
			get
			{
				return default(NDMAHCEMKBI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public string KCBBJLFJHCP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x2192720", Offset = "0x2190D20", VA = "0x182192720", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public virtual NodeVisualizationKey GGPPGDHBOOI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x7F4B40", Offset = "0x7F3140", VA = "0x1807F4B40", Slot = "82")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67D1C0", Offset = "0x67C5C0")]
		public LFFHALFGHGE<JEOHGPHNHML> IOEEHJKGCJH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x9B35B0", Offset = "0x9B1BB0", VA = "0x1809B35B0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(LFFHALFGHGE<JEOHGPHNHML>);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x9B35A0", Offset = "0x9B1BA0", VA = "0x1809B35A0")]
			[CompilerGenerated]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67CA30", Offset = "0x67BE30")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public virtual bool EHLOGMHAIIH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "83")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public virtual bool EPHKEPDJLLI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "84")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public virtual bool BDKHOCCAJMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "85")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public virtual HDDHPLJMIAP NHHGMHDAFAP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x9C9A90", Offset = "0x9C8090", VA = "0x1809C9A90", Slot = "86")]
			get
			{
				return default(HDDHPLJMIAP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool PHBAMEPJEHF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x21921A0", Offset = "0x21907A0", VA = "0x1821921A0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool CCENDLMMDAM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x21921E0", Offset = "0x21907E0", VA = "0x1821921E0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public bool DLCIGPIKKMG
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x2192220", Offset = "0x2190820", VA = "0x182192220", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int FAKPDJKMHBE
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x2192590", Offset = "0x2190B90", VA = "0x182192590", Slot = "19")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool KENAIAAHDBM
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x21924D0", Offset = "0x2190AD0", VA = "0x1821924D0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public string BEOEDGKJCMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x2192400", Offset = "0x2190A00", VA = "0x182192400", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool ILDHKGMHKEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x21922A0", Offset = "0x21908A0", VA = "0x1821922A0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool OBNAJAOCNDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x7F0180", Offset = "0x7EE780", VA = "0x1807F0180", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x9DBE00", Offset = "0x9DA400", VA = "0x1809DBE00")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public virtual bool DKIKHNHAMFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "87")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public virtual bool FAMEIKLMHFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x2192260", Offset = "0x2190860", VA = "0x182192260", Slot = "88")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool FBIAFPKENFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x2192440", Offset = "0x2190A40", VA = "0x182192440", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public JLPKIKAFHCH BMIKEFPDJIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x2192510", Offset = "0x2190B10", VA = "0x182192510", Slot = "27")]
			get
			{
				return default(JLPKIKAFHCH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public ANPHIDGEMNH BFLAMDMHHOD
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x2192550", Offset = "0x2190B50", VA = "0x182192550", Slot = "29")]
			get
			{
				return default(ANPHIDGEMNH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public virtual bool FMCAAEEOCNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "101")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public virtual MLEOAHKMHMF? GLAKGNIEIMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x7F4B40", Offset = "0x7F3140", VA = "0x1807F4B40", Slot = "102")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public virtual EMGJFLIDACG? EAHCLADEBCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x7F4B40", Offset = "0x7F3140", VA = "0x1807F4B40", Slot = "103")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67D220", Offset = "0x67C620")]
		public virtual IEnumerable<AMHGAJFIDOK<FJPOKNNDJKJ>> PCDJIHOMDNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x7F4B40", Offset = "0x7F3140", VA = "0x1807F4B40", Slot = "104")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public bool GPHMBNEJEND
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x21922E0", Offset = "0x21908E0", VA = "0x1821922E0", Slot = "108")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67D280", Offset = "0x67C680")]
		public AMHGAJFIDOK<CPCENLDIBPJ> AOLFPPELGFC
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x2192390", Offset = "0x2190990", VA = "0x182192390", Slot = "54")]
			get
			{
				return default(AMHGAJFIDOK<CPCENLDIBPJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual bool KNFJHDCIMDF
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "109")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67D2F0", Offset = "0x67C6F0")]
		public virtual AMHGAJFIDOK<CPCENLDIBPJ>? EJJDBCNKMMC
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x21923D0", Offset = "0x21909D0", VA = "0x1821923D0", Slot = "110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool EPKOHIHBHOF
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x2192480", Offset = "0x2190A80", VA = "0x182192480", Slot = "59")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public virtual string OMBLKOFJABM
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x974F50", Offset = "0x973550", VA = "0x180974F50", Slot = "111")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0xA7E0B0", Offset = "0xA7C6B0", VA = "0x180A7E0B0", Slot = "112")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67D360", Offset = "0x67C760")]
		public AMHGAJFIDOK<FJPOKNNDJKJ> IBMJAOCIOEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x21925C0", Offset = "0x2190BC0", VA = "0x1821925C0", Slot = "60")]
			get
			{
				return default(AMHGAJFIDOK<FJPOKNNDJKJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67D3D0", Offset = "0x67C7D0")]
		public AMHGAJFIDOK<FJPOKNNDJKJ>? BDFPHFAOEOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x2192600", Offset = "0x2190C00", VA = "0x182192600", Slot = "113")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67D430", Offset = "0x67C830")]
		public BNJEIPJOCHH<NKHIKPDNMME, FCKKIELDCKA> ANDEACOMPID
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x21926E0", Offset = "0x2190CE0", VA = "0x1821926E0", Slot = "62")]
			get
			{
				return default(BNJEIPJOCHH<NKHIKPDNMME, FCKKIELDCKA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67D490", Offset = "0x67C890")]
		public virtual LFFHALFGHGE<NKHIKPDNMME>? BEGFCIKKOEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7F4B40", Offset = "0x7F3140", VA = "0x1807F4B40", Slot = "114")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action JGENDBMNHJP
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x218FA40", Offset = "0x218E040", VA = "0x18218FA40", Slot = "35")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x218EE70", Offset = "0x218D470", VA = "0x18218EE70", Slot = "36")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event MBOMNGGKMKK FCEPEMDFBCI
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x218F900", Offset = "0x218DF00", VA = "0x18218F900", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x218F7A0", Offset = "0x218DDA0", VA = "0x18218F7A0", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event JGMPOKKMEAO JNBDANEOOBO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x218EFD0", Offset = "0x218D5D0", VA = "0x18218EFD0", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x218E200", Offset = "0x218C800", VA = "0x18218E200", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action BLKAAALHEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x2190D10", Offset = "0x218F310", VA = "0x182190D10", Slot = "41")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x218F850", Offset = "0x218DE50", VA = "0x18218F850", Slot = "42")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action BOAEFJEJIJF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x21911E0", Offset = "0x218F7E0", VA = "0x1821911E0", Slot = "43")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x218E7E0", Offset = "0x218CDE0", VA = "0x18218E7E0", Slot = "44")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<LFFHALFGHGE<NKHIKPDNMME>, FCKKIELDCKA> AMPMMFAABNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x218EF20", Offset = "0x218D520", VA = "0x18218EF20", Slot = "64")]
			[CompilerGenerated]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67CCD0", Offset = "0x67C0D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x2191D40", Offset = "0x2190340", VA = "0x182191D40", Slot = "65")]
			[CompilerGenerated]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67CD30", Offset = "0x67C130")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<LFFHALFGHGE<NKHIKPDNMME>, FCKKIELDCKA> JPFPFMEANMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x2191050", Offset = "0x218F650", VA = "0x182191050", Slot = "68")]
			[CompilerGenerated]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67CD90", Offset = "0x67C190")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x21904D0", Offset = "0x218EAD0", VA = "0x1821904D0", Slot = "69")]
			[CompilerGenerated]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67CDF0", Offset = "0x67C1F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<LFFHALFGHGE<NKHIKPDNMME>> ECJLDGOEFJP
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x2191540", Offset = "0x218FB40", VA = "0x182191540", Slot = "66")]
			[CompilerGenerated]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67CE50", Offset = "0x67C250")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x218E3C0", Offset = "0x218C9C0", VA = "0x18218E3C0", Slot = "67")]
			[CompilerGenerated]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67CEB0", Offset = "0x67C2B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<LFFHALFGHGE<NKHIKPDNMME>, LFFHALFGHGE<NKHIKPDNMME>> EHKPDBJAKNF
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x218EDC0", Offset = "0x218D3C0", VA = "0x18218EDC0", Slot = "70")]
			[CompilerGenerated]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67CF10", Offset = "0x67C310")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x2191130", Offset = "0x218F730", VA = "0x182191130", Slot = "71")]
			[CompilerGenerated]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67CF70", Offset = "0x67C370")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<LFFHALFGHGE<NKHIKPDNMME>, FCKKIELDCKA> OCPFKACMBAH
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x2191490", Offset = "0x218FA90", VA = "0x182191490", Slot = "72")]
			[CompilerGenerated]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67CFD0", Offset = "0x67C3D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x2190DC0", Offset = "0x218F3C0", VA = "0x182190DC0", Slot = "73")]
			[CompilerGenerated]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67D030", Offset = "0x67C430")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2191EC0", Offset = "0x21904C0", VA = "0x182191EC0")]
		[DFIJCPAOBAF("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		[DFIJCPAOBAF("Need to handle `Name` better.")]
		public HJDBMEEAPJB(MGMBHHHNCIH LAKMIJDGKNI, TNode ELLNBMOONAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2190720", Offset = "0x218ED20", VA = "0x182190720", Slot = "78")]
		protected virtual void GMAKAKECEDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x218F0D0", Offset = "0x218D6D0", VA = "0x18218F0D0", Slot = "79")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2190CD0", Offset = "0x218F2D0", VA = "0x182190CD0", Slot = "81")]
		public virtual void GMPPPOHLMCN(int JJFJOIIBDFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x218E370", Offset = "0x218C970", VA = "0x18218E370")]
		public bool AEMJAJFBJEJ(in JLPKIKAFHCH MOLEJFDINLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x218E5F0", Offset = "0x218CBF0", VA = "0x18218E5F0")]
		public bool BDAGEKPJKOA(in ANPHIDGEMNH MOLEJFDINLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x218FC30", Offset = "0x218E230", VA = "0x18218FC30", Slot = "89")]
		public virtual void FFNDANIPALD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x218FC70", Offset = "0x218E270", VA = "0x18218FC70", Slot = "32")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(HJDBMEEAPJB<>.MNHOPHLDFLF))]
		public Task<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> FKNHGFOADCN(JLPKIKAFHCH? IPKLBGKEJKA, ANPHIDGEMNH? EOGEEAFFCFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "90")]
		public virtual void ENFAENJKACP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "91")]
		public virtual void PBHODNDNDMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x924EA0", Offset = "0x9234A0", VA = "0x180924EA0")]
		protected void IGPEEKDIHNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x924EC0", Offset = "0x9234C0", VA = "0x180924EC0")]
		protected void OFFDAEEIGEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2191470", Offset = "0x218FA70", VA = "0x182191470")]
		private void LMEMPLEFDOP(in ANPHIDGEMNH MEHKCJCIOOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x218E470", Offset = "0x218CA70", VA = "0x18218E470", Slot = "92")]
		public virtual Task<GLOEKJIOMHK<LFFHALFGHGE<NKHIKPDNMME>, EKJAOIMOODA>> AKBLOGGFFAO(string ECMAPGHKHFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2191BA0", Offset = "0x21901A0", VA = "0x182191BA0", Slot = "93")]
		public virtual Task<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> NLIIADOKBHB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67CAF0", Offset = "0x67BEF0")] LFFHALFGHGE<NKHIKPDNMME> EDLAGDLJLID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2191C90", Offset = "0x2190290", VA = "0x182191C90", Slot = "94")]
		public virtual void NLJCLBJDOFI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67CB50", Offset = "0x67BF50")] LFFHALFGHGE<NKHIKPDNMME> OLGOBCPPPBB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67CBB0", Offset = "0x67BFB0")] LFFHALFGHGE<NKHIKPDNMME> LIGIEJOGFAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x218E2B0", Offset = "0x218C8B0", VA = "0x18218E2B0", Slot = "95")]
		public virtual IEnumerable<NJNNNDNOLHN> AEBFPHJIODB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2191CD0", Offset = "0x21902D0", VA = "0x182191CD0", Slot = "96")]
		public GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA> OEHLNNNKDHE(string LLANGCBOGPN)
		{
			return default(GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x21919E0", Offset = "0x218FFE0", VA = "0x1821919E0", Slot = "45")]
		public bool MMJJIIJNLEI(out Guid GNJOACJHOLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2191B60", Offset = "0x2190160", VA = "0x182191B60", Slot = "97")]
		public virtual bool MNMJODFEDNE(in Guid DJLOBGOMBEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2191350", Offset = "0x218F950", VA = "0x182191350", Slot = "98")]
		public virtual void KINBCCGCMFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "99")]
		public virtual void GJJGEEHMPCF(bool ABFAMKPLDKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7F4B40", Offset = "0x7F3140", VA = "0x1807F4B40", Slot = "100")]
		public virtual AMOAGKAEJLC CFAJHMAJIPA(in LOJCOEJFIFP PIKJOHGNIDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2190580", Offset = "0x218EB80", VA = "0x182190580")]
		protected void GKPBOHHMDEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "105")]
		protected virtual void PPIOGAOABGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2191100", Offset = "0x218F700", VA = "0x182191100", Slot = "106")]
		protected virtual bool JPJKPGOLAFL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67CC10", Offset = "0x67C010")] LFFHALFGHGE<NKHIKPDNMME> EDLAGDLJLID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "107")]
		protected virtual bool FCCKBICJCBN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67CC70", Offset = "0x67C070")] LFFHALFGHGE<NKHIKPDNMME> EDLAGDLJLID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "115")]
		protected virtual void DBCAFFKAIKC(JOBONKABJLO ONIHHALDGBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "116")]
		protected virtual void IAKGMEPLBFK(JOBONKABJLO NKOKKLFFALB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x218F080", Offset = "0x218D680", VA = "0x18218F080", Slot = "74")]
		public void DHGJHPGINDB(JOBONKABJLO NKOKKLFFALB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x218FB70", Offset = "0x218E170", VA = "0x18218FB70", Slot = "75")]
		public KCGJJJGDPIJ FFJABCOLCJH()
		{
			return default(KCGJJJGDPIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "117")]
		public virtual bool MOMNBNNIIMO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67D090", Offset = "0x67C490")] LFFHALFGHGE<NKHIKPDNMME> EDLAGDLJLID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2191E70", Offset = "0x2190470", VA = "0x182191E70")]
		private void OMFLGODHPCE(in JLPKIKAFHCH POOFJFBIOJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2191290", Offset = "0x218F890", VA = "0x182191290")]
		private void KGLAJHPHLDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x218FE20", Offset = "0x218E420", VA = "0x18218FE20")]
		private void FMCEGBLJGOI(int OFMJBLGHNCL, GFIEFCLJIOE BMGHCBLCOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x218F9B0", Offset = "0x218DFB0", VA = "0x18218F9B0")]
		private void EIKGIAMAIEH(int OLGOBCPPPBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2190E70", Offset = "0x218F470", VA = "0x182190E70")]
		private void IKPLOKKGHHH(int OLGOBCPPPBB, GFIEFCLJIOE DHOAHDFNOJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x21915F0", Offset = "0x218FBF0", VA = "0x1821915F0")]
		private void MKHNHHBGBKO(int KLIEGKKEBOC, int DBOEPKGNLGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2190660", Offset = "0x218EC60", VA = "0x182190660")]
		private void GLAGKEFCJCP(int KLIEGKKEBOC, int DBOEPKGNLGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x218E560", Offset = "0x218CB60", VA = "0x18218E560")]
		private void ANLHCBENEBG(int OLGOBCPPPBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x218E890", Offset = "0x218CE90", VA = "0x18218E890")]
		private void CGOCAHBMGCO(int OFMJBLGHNCL, GFIEFCLJIOE BMGHCBLCOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x21913C0", Offset = "0x218F9C0", VA = "0x1821913C0")]
		private void LDIMOEKJDDB(int OLGOBCPPPBB, GFIEFCLJIOE DHOAHDFNOJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x218E640", Offset = "0x218CC40", VA = "0x18218E640", Slot = "118")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(HJDBMEEAPJB<>.PHEAONCKOHE))]
		public virtual Task<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> BEJPGKILFFH(string LLANGCBOGPN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x2191DF0", Offset = "0x21903F0", VA = "0x182191DF0", Slot = "52")]
		private void OIAODDNHFNP(object CAKNHMJIOFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x218FAF0", Offset = "0x218E0F0", VA = "0x18218FAF0", Slot = "53")]
		private void FEECIHLCFFC(object CAKNHMJIOFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2191E90", Offset = "0x2190490", VA = "0x182191E90", Slot = "28")]
		private bool OOPIDDHMBON(in JLPKIKAFHCH MOLEJFDINLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2191390", Offset = "0x218F990", VA = "0x182191390", Slot = "30")]
		private bool KOMOLJHEACK(in ANPHIDGEMNH MOLEJFDINLH)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67D790", Offset = "0x67CB90")]
	private sealed class JFAILMFKLDG : HJDBMEEAPJB<ADOENEBNJGB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public override NodeVisualizationKey GGPPGDHBOOI
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x8C58E0", Offset = "0x8C3EE0", VA = "0x1808C58E0", Slot = "82")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x58CC630", Offset = "0x58CAC30", VA = "0x1858CC630")]
		public JFAILMFKLDG(MGMBHHHNCIH LAKMIJDGKNI, ADOENEBNJGB ELLNBMOONAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67D7F0", Offset = "0x67CBF0")]
	private sealed class BABGDIMIFJH : KJHPGFBGOCF<LCPOOFCEBOK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public override NodeVisualizationKey GGPPGDHBOOI
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0xBABDD0", Offset = "0xBAA3D0", VA = "0x180BABDD0", Slot = "82")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x58C8F60", Offset = "0x58C7560", VA = "0x1858C8F60")]
		public BABGDIMIFJH(MGMBHHHNCIH LAKMIJDGKNI, LCPOOFCEBOK ELLNBMOONAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67D850", Offset = "0x67CC50")]
	private abstract class KJHPGFBGOCF<TNode> : HJDBMEEAPJB<TNode> where TNode : notnull, NEDIPHJGDKK
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private sealed class AHEDCKDNALD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67DB60", Offset = "0x67CF60")]
			public AsyncTaskMethodBuilder<GLOEKJIOMHK<LFFHALFGHGE<NKHIKPDNMME>, EKJAOIMOODA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public KJHPGFBGOCF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private GLOEKJIOMHK<LFFHALFGHGE<NKHIKPDNMME>, EKJAOIMOODA> <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private TaskAwaiter<GLOEKJIOMHK<LFFHALFGHGE<NKHIKPDNMME>, EKJAOIMOODA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
			public AHEDCKDNALD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x29E3C80", Offset = "0x29E2280", VA = "0x1829E3C80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private sealed class OMACJMLHBJE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67DBC0", Offset = "0x67CFC0")]
			public AsyncTaskMethodBuilder<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67DC20", Offset = "0x67D020")]
			public LFFHALFGHGE<NKHIKPDNMME> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public KJHPGFBGOCF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			private GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA> <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private TaskAwaiter<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
			public OMACJMLHBJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x2912890", Offset = "0x2910E90", VA = "0x182912890", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public sealed override bool KNFJHDCIMDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x7EB370", Offset = "0x7E9970", VA = "0x1807EB370", Slot = "109")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67DB00", Offset = "0x67CF00")]
		public sealed override LFFHALFGHGE<NKHIKPDNMME>? BEGFCIKKOEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x265B610", Offset = "0x2659C10", VA = "0x18265B610", Slot = "114")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x2494160", Offset = "0x2492760", VA = "0x182494160")]
		public KJHPGFBGOCF(MGMBHHHNCIH LAKMIJDGKNI, TNode ELLNBMOONAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x265B100", Offset = "0x2659700", VA = "0x18265B100", Slot = "92")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(KJHPGFBGOCF<>.AHEDCKDNALD))]
		public override Task<GLOEKJIOMHK<LFFHALFGHGE<NKHIKPDNMME>, EKJAOIMOODA>> AKBLOGGFFAO(string ECMAPGHKHFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x265B3E0", Offset = "0x26599E0", VA = "0x18265B3E0", Slot = "117")]
		public sealed override bool MOMNBNNIIMO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67D920", Offset = "0x67CD20")] LFFHALFGHGE<NKHIKPDNMME> EDLAGDLJLID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x265B340", Offset = "0x2659940", VA = "0x18265B340", Slot = "106")]
		protected sealed override bool JPJKPGOLAFL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67D980", Offset = "0x67CD80")] LFFHALFGHGE<NKHIKPDNMME> EDLAGDLJLID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x265B2A0", Offset = "0x26598A0", VA = "0x18265B2A0", Slot = "107")]
		protected override bool FCCKBICJCBN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67D9E0", Offset = "0x67CDE0")] LFFHALFGHGE<NKHIKPDNMME> EDLAGDLJLID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x265B480", Offset = "0x2659A80", VA = "0x18265B480", Slot = "93")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(KJHPGFBGOCF<>.OMACJMLHBJE))]
		public override Task<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> NLIIADOKBHB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67DAA0", Offset = "0x67CEA0")] LFFHALFGHGE<NKHIKPDNMME> EDLAGDLJLID)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67DC80", Offset = "0x67D080")]
	private sealed class EBDLPIEICHE : OGNNNOPLFKB<OLBHGEICAIL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public override NodeVisualizationKey GGPPGDHBOOI
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x952150", Offset = "0x950750", VA = "0x180952150", Slot = "82")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public override bool BDKHOCCAJMH
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x7EB370", Offset = "0x7E9970", VA = "0x1807EB370", Slot = "85")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x58C9140", Offset = "0x58C7740", VA = "0x1858C9140")]
		public EBDLPIEICHE(MGMBHHHNCIH LAKMIJDGKNI, OLBHGEICAIL ELLNBMOONAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67DCE0", Offset = "0x67D0E0")]
	private sealed class IMBHPEOEEDG : HJDBMEEAPJB<BILPLFHDBLB>
	{
		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public override NodeVisualizationKey GGPPGDHBOOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x95FC80", Offset = "0x95E280", VA = "0x18095FC80", Slot = "82")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x58CA330", Offset = "0x58C8930", VA = "0x1858CA330")]
		public IMBHPEOEEDG(MGMBHHHNCIH LAKMIJDGKNI, BILPLFHDBLB ELLNBMOONAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67DD40", Offset = "0x67D140")]
	private sealed class BHFEKNIOLEF : HJDBMEEAPJB<GJOMFJCEOJF>
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public override NodeVisualizationKey GGPPGDHBOOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x93AF20", Offset = "0x939520", VA = "0x18093AF20", Slot = "82")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x58C8FC0", Offset = "0x58C75C0", VA = "0x1858C8FC0")]
		public BHFEKNIOLEF(MGMBHHHNCIH LAKMIJDGKNI, GJOMFJCEOJF ELLNBMOONAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67DDA0", Offset = "0x67D1A0")]
	private sealed class LIKIOCNFEFO : HJDBMEEAPJB<PCADHMBICHO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public override NodeVisualizationKey GGPPGDHBOOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x802390", Offset = "0x800990", VA = "0x180802390", Slot = "82")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x58CCCA0", Offset = "0x58CB2A0", VA = "0x1858CCCA0")]
		public LIKIOCNFEFO(MGMBHHHNCIH LAKMIJDGKNI, PCADHMBICHO ELLNBMOONAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7EB370", Offset = "0x7E9970", VA = "0x1807EB370", Slot = "106")]
		protected override bool JPJKPGOLAFL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67DE00", Offset = "0x67D200")] LFFHALFGHGE<NKHIKPDNMME> EDLAGDLJLID)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x21FE7F0", Offset = "0x21FCDF0", VA = "0x1821FE7F0")]
	internal static BDNEGBLDEEE OGNDBCBGIDA(MGMBHHHNCIH LAKMIJDGKNI, CCFBALPMCKN ELLNBMOONAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class JKCALCJMAJA
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x21F96D0", Offset = "0x21F7CD0", VA = "0x1821F96D0")]
	public static PPBNKPLHMKG<IJBLNCALADF, NJNNNDNOLHN, MGMBHHHNCIH, ILLEHKNENGB.MIACHIBEEKI<IJBLNCALADF, NJNNNDNOLHN, MGMBHHHNCIH>> BJJOJDAGBIJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67DE60", Offset = "0x67D260")] this in PPBNKPLHMKG<IJBLNCALADF, NJNNNDNOLHN, MGMBHHHNCIH, ILLEHKNENGB.MIACHIBEEKI<IJBLNCALADF, NJNNNDNOLHN, MGMBHHHNCIH>> FGGEDBICGOH)
	{
		return default(PPBNKPLHMKG<IJBLNCALADF, NJNNNDNOLHN, MGMBHHHNCIH, ILLEHKNENGB.MIACHIBEEKI<IJBLNCALADF, NJNNNDNOLHN, MGMBHHHNCIH>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public readonly struct BHNDNNIFJAB
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class LEIGCGLPJKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67E010", Offset = "0x67D410")]
		public AsyncTaskMethodBuilder<GLOEKJIOMHK<object, EKJAOIMOODA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public NJNNNDNOLHN action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public BHNDNNIFJAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private GLOEKJIOMHK<object, EKJAOIMOODA> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private TaskAwaiter<GLOEKJIOMHK<object, EKJAOIMOODA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public LEIGCGLPJKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x21FBBA0", Offset = "0x21FA1A0", VA = "0x1821FBBA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class AKDPCGECGIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67E070", Offset = "0x67D470")]
		public AsyncTaskMethodBuilder<GLOEKJIOMHK<bool, EKJAOIMOODA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public ODHDHNAJIAC rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public LJPOEFCNFMG circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public EOBAFPPEEPC superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public BHNDNNIFJAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67E0D0", Offset = "0x67D4D0")]
		private NJNNNDNOLHN[] <actions>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67E130", Offset = "0x67D530")]
		private GLOEKJIOMHK<object, EKJAOIMOODA> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private bool <isFirst>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67E190", Offset = "0x67D590")]
		private NJNNNDNOLHN[] <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private int <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private NJNNNDNOLHN <action>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67E1F0", Offset = "0x67D5F0")]
		private GLOEKJIOMHK<object, EKJAOIMOODA> <thisResult>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67E250", Offset = "0x67D650")]
		private GLOEKJIOMHK<object, EKJAOIMOODA> <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67E2B0", Offset = "0x67D6B0")]
		private TaskAwaiter<GLOEKJIOMHK<object, EKJAOIMOODA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public AKDPCGECGIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x21E87F0", Offset = "0x21E6DF0", VA = "0x1821E87F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class JEAFOMIHKPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67E310", Offset = "0x67D710")]
		public AsyncTaskMethodBuilder<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public BHNDNNIFJAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67E370", Offset = "0x67D770")]
		private GLOEKJIOMHK<object, EKJAOIMOODA> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67E3D0", Offset = "0x67D7D0")]
		private TaskAwaiter<GLOEKJIOMHK<object, EKJAOIMOODA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public JEAFOMIHKPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x21F7F50", Offset = "0x21F6550", VA = "0x1821F7F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly BONGOLGIJCE DIDHOFKFBFK;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x9C1FF0", Offset = "0x9C05F0", VA = "0x1809C1FF0")]
	public BHNDNNIFJAB(BONGOLGIJCE CAJJAGENDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x21E9480", Offset = "0x21E7A80", VA = "0x1821E9480")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LEIGCGLPJKJ))]
	private Task<GLOEKJIOMHK<object, EKJAOIMOODA>> DFIAIEFKDPJ(NJNNNDNOLHN ILLCNPCAHGD, bool JJAEMOEGKLD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x21E92A0", Offset = "0x21E78A0", VA = "0x1821E92A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AKDPCGECGIG))]
	public Task<GLOEKJIOMHK<bool, EKJAOIMOODA?>>? CCFNCBEOMEG(int FMEBMFODBBO, ODHDHNAJIAC? JJCCABKNMNO, LJPOEFCNFMG? LJPDCOPADII, EOBAFPPEEPC? FNCCJLEJOEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x21E9150", Offset = "0x21E7750", VA = "0x1821E9150")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JEAFOMIHKPB))]
	public Task<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> AFFJDJOCMDN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public sealed class NPOMMFKLGCE : NDCDFGGNNBE
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	internal static class JDGJEFAJFIN
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class MFPBBMALCJL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public IDDDNAMPPIE spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
			public MFPBBMALCJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x58CD180", Offset = "0x58CB780", VA = "0x1858CD180")]
			internal bool PMHCLNBEFDN(HADEAJADJDO n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		[CompilerGenerated]
		private sealed class FEGNMHIOGEA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
			public FEGNMHIOGEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x58C91A0", Offset = "0x58C77A0", VA = "0x1858C91A0")]
			internal void CPPHDEFCLOP(HADEAJADJDO n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x58CBBE0", Offset = "0x58CA1E0", VA = "0x1858CBBE0")]
		public static GLOEKJIOMHK<NDCDFGGNNBE.IMGCLAKPFMF, BONKIFBLCIE> IHAIHLFLKNG(NPOMMFKLGCE CDBMADFDGCE, in NDCDFGGNNBE.LOMFLGBLGOH CHPIMGNELOI)
		{
			return default(GLOEKJIOMHK<NDCDFGGNNBE.IMGCLAKPFMF, BONKIFBLCIE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x58CA8B0", Offset = "0x58C8EB0", VA = "0x1858CA8B0")]
		internal static GLOEKJIOMHK<IDGKFCANIFJ, EKJAOIMOODA> GIKOCLGFKFA(NPOMMFKLGCE CDBMADFDGCE, OHLDCMFLDOJ NBFOGDHJNNN, bool NNJNPPDBNDJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67E990", Offset = "0x67DD90")] in AMHGAJFIDOK<CPCENLDIBPJ> FPLBGCHBIMI, in int? OICBAMHBFCK, in KCGJJJGDPIJ? BDLBAAHLBJC, in KCGJJJGDPIJ? HBCEJPIOKLD)
		{
			return default(GLOEKJIOMHK<IDGKFCANIFJ, EKJAOIMOODA>);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x58CB710", Offset = "0x58C9D10", VA = "0x1858CB710")]
		private static void GKNFEHHGPCJ(bool NNJNPPDBNDJ, JBONOKEIOMH OCHIEFNOGPK, IDGKFCANIFJ KMLIGCJPGMC, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67EA00", Offset = "0x67DE00")] in AMHGAJFIDOK<CPCENLDIBPJ> FPLBGCHBIMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x58CC0A0", Offset = "0x58CA6A0", VA = "0x1858CC0A0")]
		public static void JJPHDCOENHB(AHFLOONOAIK BJOHHCIJDGM, in NDCDFGGNNBE.AHBCDHAGJJK IHCGNCMOALA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly MGMBHHHNCIH EOPJACEKJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly EOHNPEDGNED EJAIGKJOGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private readonly LJMGIDIDEKA MODJGMJAOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly OBNMCJECFNB CPABMGHIJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly JHGNKMCIPFL GIBDBCIDGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67E430", Offset = "0x67D830")]
	private Dictionary<AMHGAJFIDOK<FJPOKNNDJKJ>, BDNEGBLDEEE> JLKICJBIPGF;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x2200D20", Offset = "0x21FF320", VA = "0x182200D20")]
	public NPOMMFKLGCE(MGMBHHHNCIH LAKMIJDGKNI, EOHNPEDGNED IGPPHICNNON, LJMGIDIDEKA GBGKBIEGBHI, JHGNKMCIPFL CLIHKAAMLIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x2200710", Offset = "0x21FED10", VA = "0x182200710")]
	public BDNEGBLDEEE? IMFAGPDBIJO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67E490", Offset = "0x67D890")] in AMHGAJFIDOK<FJPOKNNDJKJ?> NEDBLEJEGBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x2200C20", Offset = "0x21FF220", VA = "0x182200C20")]
	private void NKKJGIEBNNE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67E500", Offset = "0x67D900")] AMHGAJFIDOK<FJPOKNNDJKJ> NEDBLEJEGBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x2200C80", Offset = "0x21FF280", VA = "0x182200C80")]
	private BDNEGBLDEEE? PMOELCLIBJA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67E560", Offset = "0x67D960")] in AMHGAJFIDOK<FJPOKNNDJKJ?> NEDBLEJEGBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x21FF770", Offset = "0x21FDD70", VA = "0x1821FF770")]
	public CCFBALPMCKN? AOMPLFPDDJM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67E5D0", Offset = "0x67D9D0")] in AMHGAJFIDOK<FJPOKNNDJKJ?> NEDBLEJEGBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x2200050", Offset = "0x21FE650", VA = "0x182200050")]
	public FFHHEAJKPKI? EENBNBBJNNA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67E640", Offset = "0x67DA40")] in AMHGAJFIDOK<CPCENLDIBPJ?> DJLOBGOMBEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2200850", Offset = "0x21FEE50", VA = "0x182200850")]
	private IDDDNAMPPIE? IPIBHMIDDOI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67E6B0", Offset = "0x67DAB0")] in AMHGAJFIDOK<CPCENLDIBPJ?> DJLOBGOMBEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2200520", Offset = "0x21FEB20", VA = "0x182200520")]
	private FFHHEAJKPKI? GJJAAFBFCFK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67E720", Offset = "0x67DB20")] in AMHGAJFIDOK<CPCENLDIBPJ?> DJLOBGOMBEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2200420", Offset = "0x21FEA20", VA = "0x182200420", Slot = "6")]
	public IEnumerable<FPFDPIBJPCK> GHNLODGBFNP(bool KGIMHJEFNJC, bool PMCFIDGPHHN, bool OHFNCDIFBEO, bool EHCJCMAEJAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2200B80", Offset = "0x21FF180", VA = "0x182200B80")]
	public GLOEKJIOMHK<NDCDFGGNNBE.IMGCLAKPFMF, BONKIFBLCIE> NBHCAABMKMP(in NDCDFGGNNBE.LOMFLGBLGOH CHPIMGNELOI)
	{
		return default(GLOEKJIOMHK<NDCDFGGNNBE.IMGCLAKPFMF, BONKIFBLCIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2200950", Offset = "0x21FEF50", VA = "0x182200950", Slot = "8")]
	public PIFINICDENF KHAPHBBJGFD(IEnumerable<JBONOKEIOMH> GPOBFAFHJEO)
	{
		return default(PIFINICDENF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x21FF620", Offset = "0x21FDC20", VA = "0x1821FF620", Slot = "9")]
	public PIFINICDENF AJDMGPFMBAN()
	{
		return default(PIFINICDENF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x21FF7F0", Offset = "0x21FDDF0", VA = "0x1821FF7F0")]
	private JJDBAJLPDCP BIAMPNMMFDM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67E790", Offset = "0x67DB90")] IEnumerable<AMHGAJFIDOK<CPCENLDIBPJ>> EJDGMLFHMBE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67E7F0", Offset = "0x67DBF0")] IEnumerable<AMHGAJFIDOK<FJPOKNNDJKJ>> MCOEIFFGHPL, NKLGLEHLAFP CCMKPHLLAIM)
	{
		return default(JJDBAJLPDCP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x21FF9A0", Offset = "0x21FDFA0", VA = "0x1821FF9A0", Slot = "10")]
	public JJDBAJLPDCP BIAMPNMMFDM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67E850", Offset = "0x67DC50")] IEnumerable<AMHGAJFIDOK<FJPOKNNDJKJ>> MCOEIFFGHPL, IEnumerable<JBONOKEIOMH> GPOBFAFHJEO, NKLGLEHLAFP CCMKPHLLAIM = NKLGLEHLAFP.CopyPaste)
	{
		return default(JJDBAJLPDCP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x21FFCE0", Offset = "0x21FE2E0", VA = "0x1821FFCE0")]
	private static IEnumerable<AMHGAJFIDOK<CPCENLDIBPJ>> CPFAMPGHKFI(IEnumerable<JBONOKEIOMH> GPOBFAFHJEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2200060", Offset = "0x21FE660", VA = "0x182200060")]
	private IEnumerable<AMHGAJFIDOK<FJPOKNNDJKJ>> FOJMODAGGBO(IEnumerable<JBONOKEIOMH> GPOBFAFHJEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2200050", Offset = "0x21FE650", VA = "0x182200050", Slot = "4")]
	private FFHHEAJKPKI MDNAIAKCGGI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67E8B0", Offset = "0x67DCB0")] in AMHGAJFIDOK<CPCENLDIBPJ> DJLOBGOMBEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2200710", Offset = "0x21FED10", VA = "0x182200710", Slot = "5")]
	private BDNEGBLDEEE JHHHOIJMFKP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67E920", Offset = "0x67DD20")] in AMHGAJFIDOK<FJPOKNNDJKJ> NEDBLEJEGBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x2200B80", Offset = "0x21FF180", VA = "0x182200B80", Slot = "7")]
	private GLOEKJIOMHK<NDCDFGGNNBE.IMGCLAKPFMF, BONKIFBLCIE> KLFFCGHDOAF(in NDCDFGGNNBE.LOMFLGBLGOH CHPIMGNELOI)
	{
		return default(GLOEKJIOMHK<NDCDFGGNNBE.IMGCLAKPFMF, BONKIFBLCIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x21FFFE0", Offset = "0x21FE5E0", VA = "0x1821FFFE0")]
	[CompilerGenerated]
	private HLBHEHCEMDL DOGADCAOPCD(JEFKKIMMHNA GPAKLECDLDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2200BB0", Offset = "0x21FF1B0", VA = "0x182200BB0")]
	[CompilerGenerated]
	private CCFBALPMCKN MDMBINHKPCG(AMHGAJFIDOK<FJPOKNNDJKJ> GPAKLECDLDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x22008E0", Offset = "0x21FEEE0", VA = "0x1822008E0")]
	[CompilerGenerated]
	private IDDDNAMPPIE JDJKJFMOHNI(AMHGAJFIDOK<CPCENLDIBPJ> GPAKLECDLDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public sealed class MAPIAIAFEBO : EOHNPEDGNED, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public interface DIFOAAFEIGI
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		NJPEDNOPJMN LFCCGMCGDCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<LJPOEFCNFMG> DDGOBKFLIHG(CancellationToken KEGMOCPJOHL);

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<EOBAFPPEEPC> ANKLLCHAENM(CancellationToken KEGMOCPJOHL);

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<HGNNMOIGKME> ILIKPLOBGBF(CancellationToken KEGMOCPJOHL);
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class HKOAPLDPPHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public AsyncTaskMethodBuilder<MAPIAIAFEBO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public MGMBHHHNCIH circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public LJPOEFCNFMG roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public EOBAFPPEEPC superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private DIFOAAFEIGI <selfDeps>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private LJPOEFCNFMG <downloadedRoomData>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private EOBAFPPEEPC <downloadedSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private MAEECBDHDKH <cloudDataLedgerData>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private RepeatedField<ENNOLBELGHN> <rewardData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private IOCAPHBIEMF <progressionTableData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private EOBAFPPEEPC <finalSuperRoomData>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private HGNNMOIGKME <playerSaveData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private EJLCIIOOAFC <cv2State>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private LJPOEFCNFMG <>s__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private EOBAFPPEEPC <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private HGNNMOIGKME <>s__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67EAE0", Offset = "0x67DEE0")]
		private TaskAwaiter<LJPOEFCNFMG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67EB40", Offset = "0x67DF40")]
		private TaskAwaiter<EOBAFPPEEPC> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67EBA0", Offset = "0x67DFA0")]
		private TaskAwaiter<HGNNMOIGKME> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public HKOAPLDPPHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x58C96A0", Offset = "0x58C7CA0", VA = "0x1858C96A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly EJLCIIOOAFC LLENDAPMILE;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public EJLCIIOOAFC JPBKHEMKKDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0xA0C770", Offset = "0xA0AD70", VA = "0x180A0C770")]
	private MAPIAIAFEBO(EJLCIIOOAFC FOEAAMFFDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x21FC630", Offset = "0x21FAC30", VA = "0x1821FC630")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HKOAPLDPPHJ))]
	public static Task<MAPIAIAFEBO> DKGDNODEIAG(MGMBHHHNCIH LAKMIJDGKNI, LJPOEFCNFMG? KDIGEENFCDC, EOBAFPPEEPC? FNCCJLEJOEO, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x21FC7F0", Offset = "0x21FADF0", VA = "0x1821FC7F0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[MFHNDIPIEJO("IStaticEVInstance")]
public interface LJMGIDIDEKA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000060")]
	IPBLBNMFKKF PGNAPMIAACG
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public sealed class DCNCJACIPJA : JGNIOMAODHJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public interface HAOKLNODKCD
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<PGDHNEIMLCC> BKCPPBLJHNK(MGMBHHHNCIH LAKMIJDGKNI, ODHDHNAJIAC DEFLADKHHGD, LJPOEFCNFMG? MAENDAJLLDO, EOBAFPPEEPC? EJPEPNIOMEH, CancellationToken KEGMOCPJOHL);

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LMPGBOJKEAC();

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void FHGKGHFAOLB();
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public abstract class LCFCLBBDCGF : HAOKLNODKCD
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private sealed class BAAIKKKMKEG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public AsyncTaskMethodBuilder<PGDHNEIMLCC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public MGMBHHHNCIH circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public ODHDHNAJIAC evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public LJPOEFCNFMG cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public EOBAFPPEEPC cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public LCFCLBBDCGF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			private CEHKONMONKB <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67EDA0", Offset = "0x67E1A0")]
			private TaskAwaiter<CEHKONMONKB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
			public BAAIKKKMKEG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x58C8DA0", Offset = "0x58C73A0", VA = "0x1858C8DA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x21FB990", Offset = "0x21F9F90", VA = "0x1821FB990", Slot = "4")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(BAAIKKKMKEG))]
		public Task<PGDHNEIMLCC> BKCPPBLJHNK(MGMBHHHNCIH LAKMIJDGKNI, ODHDHNAJIAC DEFLADKHHGD, LJPOEFCNFMG? MAENDAJLLDO, EOBAFPPEEPC? EJPEPNIOMEH, CancellationToken KEGMOCPJOHL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void LMPGBOJKEAC();

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void FHGKGHFAOLB();

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		protected LCFCLBBDCGF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class LKLAMDMMJAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public AsyncTaskMethodBuilder<PGDHNEIMLCC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public DCNCJACIPJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private TaskAwaiter<CMCGOMMIJLE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public LKLAMDMMJAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x21FC470", Offset = "0x21FAA70", VA = "0x1821FC470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class JNIDIFOBGFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public MGMBHHHNCIH circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public ODHDHNAJIAC evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public LJPOEFCNFMG cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public EOBAFPPEEPC cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public DCNCJACIPJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private PGDHNEIMLCC <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private Exception <ex>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67EE00", Offset = "0x67E200")]
		private TaskAwaiter<PGDHNEIMLCC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public JNIDIFOBGFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x21F9BD0", Offset = "0x21F81D0", VA = "0x1821F9BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly HAOKLNODKCD FGEFLJHGFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly TaskCompletionSource<CMCGOMMIJLE> HKGIFLEKHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly TaskCompletionSource<CMCGOMMIJLE> EIPMLJCHMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly CancellationTokenSource PJAANOCFNAE;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public bool MJOAAEMFFDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA2E160", Offset = "0xA2C760", VA = "0x180A2E160", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA2DCC0", Offset = "0xA2C2C0", VA = "0x180A2DCC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool DONKHGNKKGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xB91100", Offset = "0xB8F700", VA = "0x180B91100", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xB910E0", Offset = "0xB8F6E0", VA = "0x180B910E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool PEHMKHMIMPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xED4B10", Offset = "0xED3110", VA = "0x180ED4B10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x21EA7E0", Offset = "0x21E8DE0", VA = "0x1821EA7E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public PGDHNEIMLCC? EIJGCHPDHDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7F65D0", Offset = "0x7F4BD0", VA = "0x1807F65D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x9B3590", Offset = "0x9B1B90", VA = "0x1809B3590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x21EA4D0", Offset = "0x21E8AD0", VA = "0x1821EA4D0", Slot = "7")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LKLAMDMMJAL))]
	public Task<PGDHNEIMLCC> FMEDCEFANNF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x21EA7F0", Offset = "0x21E8DF0", VA = "0x1821EA7F0")]
	public DCNCJACIPJA(HAOKLNODKCD IAFBKNNAACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x21EA620", Offset = "0x21E8C20", VA = "0x1821EA620", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JNIDIFOBGFP))]
	public Task IEAKACNFJBC(MGMBHHHNCIH LAKMIJDGKNI, ODHDHNAJIAC DEFLADKHHGD, LJPOEFCNFMG? MAENDAJLLDO, EOBAFPPEEPC? EJPEPNIOMEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x21EA320", Offset = "0x21E8920", VA = "0x1821EA320", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[MFHNDIPIEJO("IStaticCV2Instance")]
public interface EOHNPEDGNED : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	EJLCIIOOAFC JPBKHEMKKDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public sealed class LIONNJLFGMG : KJCGCACGAOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly MGMBHHHNCIH EOPJACEKJNO;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public FMJJIBCIPIK? HAMPJMKDJOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x21FC120", Offset = "0x21FA720", VA = "0x1821FC120", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0xA0C770", Offset = "0xA0AD70", VA = "0x180A0C770")]
	internal LIONNJLFGMG(MGMBHHHNCIH LAKMIJDGKNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal sealed class LAFCEOLFFKL : ABBGALNGIDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly NPOMMFKLGCE AKDDCIHNDDK;

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0xA0C770", Offset = "0xA0AD70", VA = "0x180A0C770")]
	public LAFCEOLFFKL(NPOMMFKLGCE IBEAGFELFIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public sealed class LEPFJNPEFMO : KCNGDCICGCL, CMPLANLPCHM, CKPPDDJJHNL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67F1D0", Offset = "0x67E5D0")]
	public LFFHALFGHGE<AKFNAADPEJD> EDJNEFLMKOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x9AE850", Offset = "0x9ACE50", VA = "0x1809AE850", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(LFFHALFGHGE<AKFNAADPEJD>);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x15FCAF0", Offset = "0x15FB0F0", VA = "0x1815FCAF0")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67EF30", Offset = "0x67E330")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67F230", Offset = "0x67E630")]
	public override LFFHALFGHGE<AGCDOBKINFJ> PGCOFHGGFKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x21FC090", Offset = "0x21FA690", VA = "0x1821FC090", Slot = "19")]
		get
		{
			return default(LFFHALFGHGE<AGCDOBKINFJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x21FC0D0", Offset = "0x21FA6D0", VA = "0x1821FC0D0")]
	private LEPFJNPEFMO(MGMBHHHNCIH LAKMIJDGKNI, CCFBALPMCKN ELLNBMOONAG, GFIPMBLNIOC DKKLJONADKG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67EF90", Offset = "0x67E390")] LFFHALFGHGE<NKHIKPDNMME> EDLAGDLJLID, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67EFF0", Offset = "0x67E3F0")] LFFHALFGHGE<AKFNAADPEJD> BDPIAJBEPLI, bool DMHDCFFFBIK, string ECMAPGHKHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x21FBD90", Offset = "0x21FA390", VA = "0x1821FBD90")]
	public static LEPFJNPEFMO OGNDBCBGIDA(MGMBHHHNCIH LAKMIJDGKNI, CCFBALPMCKN ELLNBMOONAG, GFIPMBLNIOC NOBPCAEDFEG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67F050", Offset = "0x67E450")] LFFHALFGHGE<NKHIKPDNMME> EDLAGDLJLID, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67F0B0", Offset = "0x67E4B0")] LFFHALFGHGE<OGGCMDMBDIL> BIINHNDDAPM, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67F110", Offset = "0x67E510")] LFFHALFGHGE<AKFNAADPEJD> BDPIAJBEPLI, bool DMHDCFFFBIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x15FCAF0", Offset = "0x15FB0F0", VA = "0x1815FCAF0")]
	internal void PIJPLCJIBLK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67F170", Offset = "0x67E570")] LFFHALFGHGE<AKFNAADPEJD> MOLEJFDINLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public sealed class HLBHEHCEMDL : FPFDPIBJPCK
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class LJIIIOPCDJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67F5B0", Offset = "0x67E9B0")]
		public AsyncTaskMethodBuilder<GLOEKJIOMHK<LFFHALFGHGE<OCECEILCCEK>, EKJAOIMOODA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67F610", Offset = "0x67EA10")]
		public AMHGAJFIDOK<CPCENLDIBPJ> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67F670", Offset = "0x67EA70")]
		public AMHGAJFIDOK<FJPOKNNDJKJ> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67F6D0", Offset = "0x67EAD0")]
		public LFFHALFGHGE<NKHIKPDNMME> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public HLBHEHCEMDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private GLOEKJIOMHK<LFFHALFGHGE<OCECEILCCEK>, EKJAOIMOODA> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private TaskAwaiter<GLOEKJIOMHK<LFFHALFGHGE<OCECEILCCEK>, EKJAOIMOODA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public LJIIIOPCDJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x21FC210", Offset = "0x21FA810", VA = "0x1821FC210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class CKMNNIIEKIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67F730", Offset = "0x67EB30")]
		public AsyncTaskMethodBuilder<GLOEKJIOMHK<LFFHALFGHGE<OGGCMDMBDIL>, EKJAOIMOODA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67F790", Offset = "0x67EB90")]
		public AMHGAJFIDOK<CPCENLDIBPJ> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67F7F0", Offset = "0x67EBF0")]
		public AMHGAJFIDOK<FJPOKNNDJKJ> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67F850", Offset = "0x67EC50")]
		public LFFHALFGHGE<NKHIKPDNMME> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public HLBHEHCEMDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private GLOEKJIOMHK<LFFHALFGHGE<OGGCMDMBDIL>, EKJAOIMOODA> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private TaskAwaiter<GLOEKJIOMHK<LFFHALFGHGE<OGGCMDMBDIL>, EKJAOIMOODA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public CKMNNIIEKIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x21EA0C0", Offset = "0x21E86C0", VA = "0x1821EA0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly JEFKKIMMHNA KCPOLKIFEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly EOHNPEDGNED EJAIGKJOGOM;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public string GMDPKKLADFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x21EC0B0", Offset = "0x21EA6B0", VA = "0x1821EC0B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x21F6E40", Offset = "0x21F5440", VA = "0x1821F6E40")]
	public HLBHEHCEMDL(JEFKKIMMHNA MICKEPMGONE, EOHNPEDGNED IGPPHICNNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x21F6C70", Offset = "0x21F5270", VA = "0x1821F6C70", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LJIIIOPCDJF))]
	public Task<GLOEKJIOMHK<LFFHALFGHGE<OCECEILCCEK>, EKJAOIMOODA>> NDAIIDDNLIO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67F300", Offset = "0x67E700")] AMHGAJFIDOK<CPCENLDIBPJ> DJLOBGOMBEL, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67F360", Offset = "0x67E760")] AMHGAJFIDOK<FJPOKNNDJKJ> NEDBLEJEGBK, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67F3C0", Offset = "0x67E7C0")] LFFHALFGHGE<NKHIKPDNMME> EDLAGDLJLID, string ECMAPGHKHFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x21F6AA0", Offset = "0x21F50A0", VA = "0x1821F6AA0", Slot = "6")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CKMNNIIEKIO))]
	public Task<GLOEKJIOMHK<LFFHALFGHGE<OGGCMDMBDIL>, EKJAOIMOODA>> KDMHNJIILDA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67F490", Offset = "0x67E890")] AMHGAJFIDOK<CPCENLDIBPJ> DJLOBGOMBEL, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67F4F0", Offset = "0x67E8F0")] AMHGAJFIDOK<FJPOKNNDJKJ> NEDBLEJEGBK, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67F550", Offset = "0x67E950")] LFFHALFGHGE<NKHIKPDNMME> EDLAGDLJLID, string ECMAPGHKHFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public sealed class CEHKONMONKB : PGDHNEIMLCC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public interface APFOKPPKJNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<EOHNPEDGNED> FGGCJLHEAKF(MGMBHHHNCIH LAKMIJDGKNI, LJPOEFCNFMG? MAENDAJLLDO, EOBAFPPEEPC? EJPEPNIOMEH, CancellationToken KEGMOCPJOHL);

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		LJMGIDIDEKA IOMGEDJKBHB(MGMBHHHNCIH LAKMIJDGKNI, ODHDHNAJIAC DEFLADKHHGD);
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public sealed class EBMDKBLILMI : APFOKPPKJNI
	{
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class IPDGCJMFPIO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public AsyncTaskMethodBuilder<EOHNPEDGNED> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public MGMBHHHNCIH circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public LJPOEFCNFMG cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public EOBAFPPEEPC cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public EBMDKBLILMI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			private MAPIAIAFEBO <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67F970", Offset = "0x67ED70")]
			private TaskAwaiter<MAPIAIAFEBO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
			public IPDGCJMFPIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x58CA440", Offset = "0x58C8A40", VA = "0x1858CA440", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly EBMDKBLILMI HAMPJMKDJOL;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		private EBMDKBLILMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x21EADF0", Offset = "0x21E93F0", VA = "0x1821EADF0", Slot = "4")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(IPDGCJMFPIO))]
		public Task<EOHNPEDGNED> FGGCJLHEAKF(MGMBHHHNCIH LAKMIJDGKNI, LJPOEFCNFMG? MAENDAJLLDO, EOBAFPPEEPC? EJPEPNIOMEH, CancellationToken KEGMOCPJOHL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x21EAFE0", Offset = "0x21E95E0", VA = "0x1821EAFE0", Slot = "5")]
		public LJMGIDIDEKA IOMGEDJKBHB(MGMBHHHNCIH LAKMIJDGKNI, ODHDHNAJIAC DEFLADKHHGD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class OJFPEFONHDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public AsyncTaskMethodBuilder<CEHKONMONKB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public MGMBHHHNCIH circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public ODHDHNAJIAC evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public LJPOEFCNFMG cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public EOBAFPPEEPC cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private APFOKPPKJNI <selfDeps>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private EOHNPEDGNED <cv2RootSys>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private LJMGIDIDEKA <evRootSys>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private EOHNPEDGNED <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67F9D0", Offset = "0x67EDD0")]
		private TaskAwaiter<EOHNPEDGNED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public OJFPEFONHDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x2201580", Offset = "0x21FFB80", VA = "0x182201580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private readonly EOHNPEDGNED EJAIGKJOGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private readonly LJMGIDIDEKA MODJGMJAOBC;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public LGIHHDHNBJI OAOLJLMPFMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x21E9930", Offset = "0x21E7F30", VA = "0x1821E9930", Slot = "4")]
		get
		{
			return default(LGIHHDHNBJI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public HCEHOPPCJNP DAKIBDBPLGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x21E98C0", Offset = "0x21E7EC0", VA = "0x1821E98C0", Slot = "5")]
		get
		{
			return default(HCEHOPPCJNP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public NANMMLKGADC IEAGLCPNEAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8BD370", Offset = "0x8BB970", VA = "0x1808BD370", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public NPOMMFKLGCE PDBKJPDKAPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x913730", Offset = "0x911D30", VA = "0x180913730", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public HHICGIGILGO OLCICGLDEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8BD300", Offset = "0x8BB900", VA = "0x1808BD300", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x21E99A0", Offset = "0x21E7FA0", VA = "0x1821E99A0")]
	private CEHKONMONKB(EOHNPEDGNED IGPPHICNNON, LJMGIDIDEKA GBGKBIEGBHI, NANMMLKGADC EFIPODHCKJG, NPOMMFKLGCE IBEAGFELFIL, HHICGIGILGO OCIEIDBHPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x21E9670", Offset = "0x21E7C70", VA = "0x1821E9670")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OJFPEFONHDJ))]
	public static Task<CEHKONMONKB> DKGDNODEIAG(MGMBHHHNCIH LAKMIJDGKNI, ODHDHNAJIAC DEFLADKHHGD, LJPOEFCNFMG? MAENDAJLLDO, EOBAFPPEEPC? EJPEPNIOMEH, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x21E9860", Offset = "0x21E7E60", VA = "0x1821E9860", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public interface JGNIOMAODHJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	PGDHNEIMLCC? EIJGCHPDHDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	bool DONKHGNKKGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool MJOAAEMFFDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<PGDHNEIMLCC?>? FMEDCEFANNF();

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task IEAKACNFJBC(MGMBHHHNCIH LAKMIJDGKNI, ODHDHNAJIAC DEFLADKHHGD, LJPOEFCNFMG? MAENDAJLLDO, EOBAFPPEEPC? EJPEPNIOMEH);
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public sealed class HHICGIGILGO : FMJJIBCIPIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly EOHNPEDGNED EJAIGKJOGOM;

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public NMHMACIGOCC DFIAIEFKDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x21F6890", Offset = "0x21F4E90", VA = "0x1821F6890", Slot = "4")]
		get
		{
			return default(NMHMACIGOCC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public GDGAHNFAEDI HIALPKPBAJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x21F67E0", Offset = "0x21F4DE0", VA = "0x1821F67E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67FB10", Offset = "0x67EF10")]
	public AMHGAJFIDOK<CPCENLDIBPJ> GLCFBMPDJII
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x21F68F0", Offset = "0x21F4EF0", VA = "0x1821F68F0", Slot = "6")]
		get
		{
			return default(AMHGAJFIDOK<CPCENLDIBPJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public EJLCIIOOAFC JGKJEDKNFHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x21F6840", Offset = "0x21F4E40", VA = "0x1821F6840", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0xA0C770", Offset = "0xA0AD70", VA = "0x180A0C770")]
	public HHICGIGILGO(EOHNPEDGNED IGPPHICNNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x21F6770", Offset = "0x21F4D70", VA = "0x1821F6770")]
	public bool APJODMABPPL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67FA30", Offset = "0x67EE30")] in AMHGAJFIDOK<CPCENLDIBPJ> DJLOBGOMBEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x21F6770", Offset = "0x21F4D70", VA = "0x1821F6770", Slot = "8")]
	private bool JCJPEKHGDAK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67FAA0", Offset = "0x67EEA0")] in AMHGAJFIDOK<CPCENLDIBPJ> DJLOBGOMBEL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public sealed class GEKFEJPFGKP : KCNGDCICGCL, EFBONPMAHDN, CKPPDDJJHNL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class PCLBBIAGGHP
	{
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		private sealed class <<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public HEEHAPCKPNK errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			public PCLBBIAGGHP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			private GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA> <result>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			private GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA> <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			private TaskAwaiter<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
			public <<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x58CD9A0", Offset = "0x58CBFA0", VA = "0x1858CD9A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public GEKFEJPFGKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public PCLBBIAGGHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x22026C0", Offset = "0x2200CC0", VA = "0x1822026C0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task AOFLGNMLOIO(HEEHAPCKPNK errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class GDEBJGLAJNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public GEKFEJPFGKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private bool <isPure>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private GNCPIKAEHID <signal>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA> <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private bool <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private TaskAwaiter<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public GDEBJGLAJNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x21EDE20", Offset = "0x21EC420", VA = "0x1821EDE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class HHIIBCCBCNJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		private sealed class <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000170")]
			public HEEHAPCKPNK errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000171")]
			public HHIIBCCBCNJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000172")]
			private GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA> <result>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			private GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA> <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000174")]
			private TaskAwaiter<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
			public <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x58CDC10", Offset = "0x58CC210", VA = "0x1858CDC10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public GEKFEJPFGKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public HHIIBCCBCNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x21F6950", Offset = "0x21F4F50", VA = "0x1821F6950")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task NOCHEKABHHE(HEEHAPCKPNK errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly NCKLHJJBCHJ FCIGNBDHJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly ICollection<EFFEBMANFPB> BFNCNBNLMPM;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	private EAEOEGJDDBD JCCHKOFODOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x21EF2A0", Offset = "0x21ED8A0", VA = "0x1821EF2A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67FF10", Offset = "0x67F310")]
	public LFFHALFGHGE<NBMOEMODALK> AMNJPJMOOJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x1ED2020", Offset = "0x1ED0620", VA = "0x181ED2020", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(LFFHALFGHGE<NBMOEMODALK>);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x1ED0010", Offset = "0x1ECE610", VA = "0x181ED0010")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67FC00", Offset = "0x67F000")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67FF70", Offset = "0x67F370")]
	public override LFFHALFGHGE<AGCDOBKINFJ> PGCOFHGGFKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x21F0900", Offset = "0x21EEF00", VA = "0x1821F0900", Slot = "19")]
		get
		{
			return default(LFFHALFGHGE<AGCDOBKINFJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public bool GJHPHLPCGBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x21EFC50", Offset = "0x21EE250", VA = "0x1821EFC50", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x21F0E10", Offset = "0x21EF410", VA = "0x1821F0E10")]
	private GEKFEJPFGKP(MGMBHHHNCIH LAKMIJDGKNI, CCFBALPMCKN ELLNBMOONAG, NCKLHJJBCHJ DKIBLPLIAEG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67FC60", Offset = "0x67F060")] LFFHALFGHGE<NKHIKPDNMME> EDLAGDLJLID, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67FCC0", Offset = "0x67F0C0")] LFFHALFGHGE<NBMOEMODALK> EPALKMLIING, bool DMHDCFFFBIK, string ECMAPGHKHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x21F0590", Offset = "0x21EEB90", VA = "0x1821F0590")]
	public static GEKFEJPFGKP OGNDBCBGIDA(MGMBHHHNCIH LAKMIJDGKNI, CCFBALPMCKN ELLNBMOONAG, NCKLHJJBCHJ JDCGNJBJHCM, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67FD20", Offset = "0x67F120")] LFFHALFGHGE<NKHIKPDNMME> EDLAGDLJLID, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67FD80", Offset = "0x67F180")] LFFHALFGHGE<OCECEILCCEK> DPKPHMBFEDO, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67FDE0", Offset = "0x67F1E0")] LFFHALFGHGE<NBMOEMODALK> EPALKMLIING, bool DMHDCFFFBIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x21EFAA0", Offset = "0x21EE0A0", VA = "0x1821EFAA0", Slot = "20")]
	protected override void GMAKAKECEDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x21EF0F0", Offset = "0x21ED6F0", VA = "0x1821EF0F0", Slot = "21")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x21EE310", Offset = "0x21EC910", VA = "0x1821EE310", Slot = "28")]
	public void ACHHBMCJMBM(EFFEBMANFPB BCLLGAPHFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x21F0940", Offset = "0x21EEF40", VA = "0x1821F0940", Slot = "25")]
	public void PFHCBNAGEJJ(OMECEFKBGHM BOBMEJNNCCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x21EE770", Offset = "0x21ECD70", VA = "0x1821EE770", Slot = "26")]
	public void DHGJHPGINDB(OOFOPODPDHP IPLFKJLIHFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x21EF970", Offset = "0x21EDF70", VA = "0x1821EF970", Slot = "22")]
	protected override void FKCFOIEOOIL(AMGGHOEHCDK DCHHAOJEFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x21EE5E0", Offset = "0x21ECBE0", VA = "0x1821EE5E0", Slot = "30")]
	public string DDBNCPPHIPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x21EF490", Offset = "0x21EDA90", VA = "0x1821EF490", Slot = "27")]
	public string FCFNJJPHPGB(int FHFGMPLDCMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x21EF790", Offset = "0x21EDD90", VA = "0x1821EF790")]
	private void FJLAGPLOJMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x21F0120", Offset = "0x21EE720", VA = "0x1821F0120", Slot = "29")]
	public void LAKCFMKDGPC(EFFEBMANFPB BCLLGAPHFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x21F0C20", Offset = "0x21EF220", VA = "0x1821F0C20")]
	private void PPPHDHMLAFM(bool MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x21EF340", Offset = "0x21ED940", VA = "0x1821EF340", Slot = "31")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GDEBJGLAJNI))]
	public Task EKOBJGGGICP(string MOLEJFDINLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x21F01E0", Offset = "0x21EE7E0", VA = "0x1821F01E0")]
	public void LJHKHENDMEB(string MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x21EFEA0", Offset = "0x21EE4A0", VA = "0x1821EFEA0")]
	private void KDOGADEEADD(int MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x1ED0010", Offset = "0x1ECE610", VA = "0x181ED0010")]
	internal void DKKOLHPPJEG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67FEB0", Offset = "0x67F2B0")] LFFHALFGHGE<NBMOEMODALK> MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x21F0420", Offset = "0x21EEA20", VA = "0x1821F0420")]
	[CompilerGenerated]
	private bool MCENOJHAKOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x21F0B50", Offset = "0x21EF150", VA = "0x1821F0B50")]
	[CompilerGenerated]
	private bool PKIPPHGHIAP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x21EE3D0", Offset = "0x21EC9D0", VA = "0x1821EE3D0")]
	[CompilerGenerated]
	private int PILCLACMBJN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x21F0080", Offset = "0x21EE680", VA = "0x1821F0080")]
	[CompilerGenerated]
	private bool KJBDGGFENHE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x21EE420", Offset = "0x21ECA20", VA = "0x1821EE420")]
	[CompilerGenerated]
	private bool BBLLFFEDLBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x21EFA50", Offset = "0x21EE050", VA = "0x1821EFA50")]
	[CompilerGenerated]
	private bool GLNAHAELAAF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x21F04F0", Offset = "0x21EEAF0", VA = "0x1821F04F0")]
	[CompilerGenerated]
	private bool NMJAAGKKGCB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x21EE3D0", Offset = "0x21EC9D0", VA = "0x1821EE3D0")]
	[CompilerGenerated]
	private int AFHEGHIJEIG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x21EE4F0", Offset = "0x21ECAF0", VA = "0x1821EE4F0")]
	[CompilerGenerated]
	private bool BJNCJKJHLCM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x21EFE50", Offset = "0x21EE450", VA = "0x1821EFE50")]
	[CompilerGenerated]
	private int INCFJOEMEFC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x21EF2C0", Offset = "0x21ED8C0", VA = "0x1821EF2C0")]
	[CompilerGenerated]
	private void EKCBLGBKMFD(object MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x21F0330", Offset = "0x21EE930", VA = "0x1821F0330")]
	[CompilerGenerated]
	private bool LKMKEAEJGNL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal static class IEFKPMMBAMO
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private class LOCHPELGGGD<TGraph> : FFHHEAJKPKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		protected readonly TGraph HPJBKEBEJFO;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public virtual HMFIPCPPLIH? HNPCMLHHDAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x9C9A40", Offset = "0x9C8040", VA = "0x1809C9A40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x1F085A0", Offset = "0x1F06BA0", VA = "0x181F085A0")]
		public LOCHPELGGGD(TGraph PNOPANKHPJB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x676C40", Offset = "0x676040")]
	private sealed class OFPPMCLCFJC : LOCHPELGGGD<ODLNABBOFLC>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override HMFIPCPPLIH? HNPCMLHHDAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x2201490", Offset = "0x21FFA90", VA = "0x182201490", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x22014B0", Offset = "0x21FFAB0", VA = "0x1822014B0")]
		public OFPPMCLCFJC(ODLNABBOFLC DGIKDBDOACL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x21F7280", Offset = "0x21F5880", VA = "0x1821F7280")]
	public static FFHHEAJKPKI OGNDBCBGIDA(IDDDNAMPPIE PNOPANKHPJB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public sealed class KGFMLKNKLFF : IFJCOEAPEFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly MGMBHHHNCIH EOPJACEKJNO;

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool MJOAAEMFFDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x21FB490", Offset = "0x21F9A90", VA = "0x1821FB490", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xA0C770", Offset = "0xA0AD70", VA = "0x180A0C770")]
	internal KGFMLKNKLFF(MGMBHHHNCIH LAKMIJDGKNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public abstract class KCNGDCICGCL : CKPPDDJJHNL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private struct HBLELIOOKIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private FHAKBFIDIOA? NOFGIFCJEPG;

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x37CA7E0", Offset = "0x37C8DE0", VA = "0x1837CA7E0")]
		public void FBJOPIHCMHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x58C9380", Offset = "0x58C7980", VA = "0x1858C9380")]
		public FHAKBFIDIOA JPEGEFEMMAA(KCNGDCICGCL PCAMCJHFBMF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	protected readonly MGMBHHHNCIH EOPJACEKJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	protected readonly CCFBALPMCKN MLOKDGONNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private HBLELIOOKIN BOKIEDONPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly BCAFPIENNHC PLJFAEEBPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly List<ONFACDGNMLN> AEIPGDNKLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly List<BJDPEOMIFEF> OIKGCPJAPOE;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public IEnumerable<StaticEdge> HDPAMNPKPOP
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x21FA9E0", Offset = "0x21F8FE0", VA = "0x1821FA9E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public DisplayKind EHMIELADFKD
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x9B35B0", Offset = "0x9B1BB0", VA = "0x1809B35B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x676E90", Offset = "0x676290")]
	public AMHGAJFIDOK<CPCENLDIBPJ> AOLFPPELGFC
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x21FA9B0", Offset = "0x21F8FB0", VA = "0x1821FA9B0", Slot = "6")]
		get
		{
			return default(AMHGAJFIDOK<CPCENLDIBPJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	protected JEFKKIMMHNA HLMHNEKNEKK
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x1AF1480", Offset = "0x1AEFA80", VA = "0x181AF1480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public NEOEDMKFMDE EHKILHGABEB
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x21FA810", Offset = "0x21F8E10", VA = "0x1821FA810", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	protected FHAKBFIDIOA FLCLOPMMIFF
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x21FA810", Offset = "0x21F8E10", VA = "0x1821FA810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public PortImage CFAOFJEPGNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x21FA440", Offset = "0x21F8A40", VA = "0x1821FA440", Slot = "12")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public string OMBLKOFJABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x7F64D0", Offset = "0x7F4AD0", VA = "0x1807F64D0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x9B35C0", Offset = "0x9B1BC0", VA = "0x1809B35C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x676F00", Offset = "0x676300")]
	public AMHGAJFIDOK<FJPOKNNDJKJ> IBMJAOCIOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x21FA1B0", Offset = "0x21F87B0", VA = "0x1821FA1B0", Slot = "8")]
		get
		{
			return default(AMHGAJFIDOK<FJPOKNNDJKJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x676F70", Offset = "0x676370")]
	public LFFHALFGHGE<NKHIKPDNMME> FKLIIILGOOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x9DA640", Offset = "0x9D8C40", VA = "0x1809DA640", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(LFFHALFGHGE<NKHIKPDNMME>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x9D94D0", Offset = "0x9D7AD0", VA = "0x1809D94D0")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x676D70", Offset = "0x676170")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x676FD0", Offset = "0x6763D0")]
	public abstract LFFHALFGHGE<AGCDOBKINFJ> PGCOFHGGFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x21FB2F0", Offset = "0x21F98F0", VA = "0x1821FB2F0")]
	protected KCNGDCICGCL(MGMBHHHNCIH LAKMIJDGKNI, CCFBALPMCKN ELLNBMOONAG, BCAFPIENNHC HPBEOMAJDPG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x676DD0", Offset = "0x6761D0")] LFFHALFGHGE<NKHIKPDNMME> EDLAGDLJLID, bool DMHDCFFFBIK, string ECMAPGHKHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x21FA4F0", Offset = "0x21F8AF0", VA = "0x1821FA4F0", Slot = "20")]
	protected virtual void GMAKAKECEDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x21FA1D0", Offset = "0x21F87D0", VA = "0x1821FA1D0", Slot = "21")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x21FB290", Offset = "0x21F9890", VA = "0x1821FB290", Slot = "13")]
	public void PEAEFBGEBGN(ONFACDGNMLN OLNCGAFBPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x21FA320", Offset = "0x21F8920", VA = "0x1821FA320", Slot = "14")]
	public void EHNHNKLCEDN(BJDPEOMIFEF OLNCGAFBPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x21FAD10", Offset = "0x21F9310", VA = "0x1821FAD10", Slot = "15")]
	public void PDIBPEHFFKE(AMGGHOEHCDK DCHHAOJEFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x21FA3E0", Offset = "0x21F89E0", VA = "0x1821FA3E0", Slot = "22")]
	protected virtual void FKCFOIEOOIL(AMGGHOEHCDK DCHHAOJEFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x21FA6A0", Offset = "0x21F8CA0", VA = "0x1821FA6A0")]
	private void IENOLJHHLEB(bool OINELIMPDDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x21FA820", Offset = "0x21F8E20", VA = "0x1821FA820")]
	private void KNDMBEJINEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x21FAB80", Offset = "0x21F9180", VA = "0x1821FAB80")]
	private void NAHDDKIOHOL(in NIBAFFIHLND HKMHLFMKDAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x21FA380", Offset = "0x21F8980", VA = "0x1821FA380", Slot = "16")]
	public void FGDGEMIOLOD(ONFACDGNMLN OLNCGAFBPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x21FA640", Offset = "0x21F8C40", VA = "0x1821FA640", Slot = "17")]
	public void IBNICOFHMGE(BJDPEOMIFEF OLNCGAFBPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x9B35C0", Offset = "0x9B1BC0", VA = "0x1809B35C0")]
	internal void HCDDLAMALGI(string ECMAPGHKHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x9D94D0", Offset = "0x9D7AD0", VA = "0x1809D94D0")]
	internal void HPEHJBMFIMO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x676E30", Offset = "0x676230")] LFFHALFGHGE<NKHIKPDNMME> EDLAGDLJLID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public sealed class NANMMLKGADC : LBPPHHKECGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly MGMBHHHNCIH EOPJACEKJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly EOHNPEDGNED EJAIGKJOGOM;

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x8C5A00", Offset = "0x8C4000", VA = "0x1808C5A00")]
	public NANMMLKGADC(MGMBHHHNCIH LAKMIJDGKNI, EOHNPEDGNED IGPPHICNNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x21FECE0", Offset = "0x21FD2E0", VA = "0x1821FECE0", Slot = "4")]
	public GLOEKJIOMHK<NGLKIJNHAPK, GMMNHDMGPAJ> EJKBBIHOFEK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677050", Offset = "0x676450")] AMHGAJFIDOK<FJPOKNNDJKJ> NEDBLEJEGBK, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6770B0", Offset = "0x6764B0")] LFFHALFGHGE<NKHIKPDNMME> EDLAGDLJLID, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677110", Offset = "0x676510")] LFFHALFGHGE<NBMOEMODALK> EPALKMLIING)
	{
		return default(GLOEKJIOMHK<NGLKIJNHAPK, GMMNHDMGPAJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x21FEFB0", Offset = "0x21FD5B0", VA = "0x1821FEFB0", Slot = "5")]
	public GLOEKJIOMHK<NGLKIJNHAPK, GMMNHDMGPAJ> JICAPCPCGJO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677170", Offset = "0x676570")] AMHGAJFIDOK<FJPOKNNDJKJ> NEDBLEJEGBK, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6771D0", Offset = "0x6765D0")] LFFHALFGHGE<NKHIKPDNMME> EDLAGDLJLID, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677230", Offset = "0x676630")] LFFHALFGHGE<AKFNAADPEJD> BDPIAJBEPLI)
	{
		return default(GLOEKJIOMHK<NGLKIJNHAPK, GMMNHDMGPAJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public sealed class JHGNKMCIPFL : OELOJFCFNIH
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class IPKEKAMBKPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public AsyncTaskMethodBuilder<NDCDFGGNNBE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public JHGNKMCIPFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private PGDHNEIMLCC <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6773A0", Offset = "0x6767A0")]
		private TaskAwaiter<PGDHNEIMLCC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public IPKEKAMBKPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x58CA5F0", Offset = "0x58C8BF0", VA = "0x1858CA5F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly MGMBHHHNCIH EOPJACEKJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6772D0", Offset = "0x6766D0")]
	private IReadOnlyList<AMHGAJFIDOK<OFPDHDDFGIH>> JGKCDMDJJIM;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public NDCDFGGNNBE? HAMPJMKDJOL
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x21F9550", Offset = "0x21F7B50", VA = "0x1821F9550", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool BKDNPDHDJDD
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x21F92A0", Offset = "0x21F78A0", VA = "0x1821F92A0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool DBCBCEMJALC
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x21F8FD0", Offset = "0x21F75D0", VA = "0x1821F8FD0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0xA0C770", Offset = "0xA0AD70", VA = "0x180A0C770")]
	internal JHGNKMCIPFL(MGMBHHHNCIH LAKMIJDGKNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x21F8E80", Offset = "0x21F7480", VA = "0x1821F8E80", Slot = "7")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IPKEKAMBKPC))]
	public Task<NDCDFGGNNBE> AMEDGLOJDJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x21F8B90", Offset = "0x21F7190", VA = "0x1821F8B90")]
	internal Dictionary<AMHGAJFIDOK<CPCENLDIBPJ>, Guid> AFHBDLJHMKH(IEnumerable<JBONOKEIOMH> PGMDDHEPBHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x21F9030", Offset = "0x21F7630", VA = "0x1821F9030")]
	public GLOEKJIOMHK<BFFBNLPIMLM, BONKIFBLCIE> CJGNBCOLIEF(in BFFBNLPIMLM ODOKMLCNHAI, IEnumerable<JBONOKEIOMH> GPOBFAFHJEO, int ECAAMANNADO)
	{
		return default(GLOEKJIOMHK<BFFBNLPIMLM, BONKIFBLCIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x21F9640", Offset = "0x21F7C40", VA = "0x1821F9640")]
	internal static KCGJJJGDPIJ OFPGGHNDBJD(EGDBIKPAJBM EEPOIDPKDBK, CCFBALPMCKN ELLNBMOONAG)
	{
		return default(KCGJJJGDPIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x21F9690", Offset = "0x21F7C90", VA = "0x1821F9690", Slot = "8")]
	private GLOEKJIOMHK<BFFBNLPIMLM, BONKIFBLCIE> OKLHPJIKMLO(in BFFBNLPIMLM ODOKMLCNHAI, IEnumerable<JBONOKEIOMH> GPOBFAFHJEO, int ECAAMANNADO)
	{
		return default(GLOEKJIOMHK<BFFBNLPIMLM, BONKIFBLCIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x21F9300", Offset = "0x21F7900", VA = "0x1821F9300")]
	[CompilerGenerated]
	internal static KCGJJJGDPIJ GOAKDONNFFI(EGDBIKPAJBM BGIGEPIJBDL, CCFBALPMCKN CFOBOPCJAFI)
	{
		return default(KCGJJJGDPIJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public interface PGDHNEIMLCC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	LGIHHDHNBJI OAOLJLMPFMF
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	HCEHOPPCJNP DAKIBDBPLGE
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	NANMMLKGADC IEAGLCPNEAC
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	HHICGIGILGO OLCICGLDEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	NPOMMFKLGCE PDBKJPDKAPL
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public sealed class HDGHEEOCBGG : FCKKIELDCKA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private sealed class ANFKABOCLMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public MGMBHHHNCIH circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public CCFBALPMCKN node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678FE0", Offset = "0x6783E0")]
		public LFFHALFGHGE<NKHIKPDNMME> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public bool canInteract;

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public ANFKABOCLMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x21E9070", Offset = "0x21E7670", VA = "0x1821E9070")]
		internal GEKFEJPFGKP ICNNJMMBCPK((int PortDescIndex, int PortIndex, NCKLHJJBCHJ InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x21E8F90", Offset = "0x21E7590", VA = "0x1821E8F90")]
		internal LEPFJNPEFMO DNMFLECNKOA(GFIPMBLNIOC i, int idx)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class EGJHOBIMOPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6790F0", Offset = "0x6784F0")]
		public AsyncTaskMethodBuilder<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public HDGHEEOCBGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x679150", Offset = "0x678550")]
		private GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA> <r>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private HEEHAPCKPNK <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6791B0", Offset = "0x6785B0")]
		private (KCALKOIDKAC PortDesc, int PortDescIndex)? <input>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private KCALKOIDKAC <portDesc>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private int <portDescIndex>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA> <result>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA> <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private TaskAwaiter<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public EGJHOBIMOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x21EB0D0", Offset = "0x21E96D0", VA = "0x1821EB0D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class PBCBGCLMCHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x679280", Offset = "0x678680")]
		public AsyncTaskMethodBuilder<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6792E0", Offset = "0x6786E0")]
		public LFFHALFGHGE<OCECEILCCEK> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public HDGHEEOCBGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private HEEHAPCKPNK <errReporting>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private TaskAwaiter<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public PBCBGCLMCHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x2202330", Offset = "0x2200930", VA = "0x182202330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class ALPHIMEMHNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x679340", Offset = "0x678740")]
		public AsyncTaskMethodBuilder<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6793A0", Offset = "0x6787A0")]
		public LFFHALFGHGE<OGGCMDMBDIL> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public HDGHEEOCBGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private HEEHAPCKPNK <errReporting>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private TaskAwaiter<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public ALPHIMEMHNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x21E8C00", Offset = "0x21E7200", VA = "0x1821E8C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class NFLMLAIGEEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x679400", Offset = "0x678800")]
		public AsyncTaskMethodBuilder<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x679460", Offset = "0x678860")]
		public LFFHALFGHGE<OCECEILCCEK> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6794C0", Offset = "0x6788C0")]
		public LFFHALFGHGE<OCECEILCCEK> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public HDGHEEOCBGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private HEEHAPCKPNK <errReporting>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private TaskAwaiter<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public NFLMLAIGEEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x21FF280", Offset = "0x21FD880", VA = "0x1821FF280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class IOJIIANAHLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x679520", Offset = "0x678920")]
		public AsyncTaskMethodBuilder<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x679580", Offset = "0x678980")]
		public LFFHALFGHGE<OGGCMDMBDIL> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6795E0", Offset = "0x6789E0")]
		public LFFHALFGHGE<OGGCMDMBDIL> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public HDGHEEOCBGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private HEEHAPCKPNK <errReporting>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private TaskAwaiter<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public IOJIIANAHLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x21F78C0", Offset = "0x21F5EC0", VA = "0x1821F78C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class FPONINDOIIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x679640", Offset = "0x678A40")]
		public AsyncTaskMethodBuilder<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public HDGHEEOCBGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6796A0", Offset = "0x678AA0")]
		private GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA> <r>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private HEEHAPCKPNK <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x679700", Offset = "0x678B00")]
		private (KCALKOIDKAC PortDesc, int PortDescIndex)? <input>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private KCALKOIDKAC <portDesc>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private int <portDescIndex>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private int <inputPortCount>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private int <portIndex>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA> <result>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA> <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private TaskAwaiter<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public FPONINDOIIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x21ED900", Offset = "0x21EBF00", VA = "0x1821ED900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class HNJNMMEECDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6797D0", Offset = "0x678BD0")]
		public AsyncTaskMethodBuilder<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public HDGHEEOCBGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private HEEHAPCKPNK <errReporting>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private TaskAwaiter<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public HNJNMMEECDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x21F6EF0", Offset = "0x21F54F0", VA = "0x1821F6EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class OFOOICIPDHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x679830", Offset = "0x678C30")]
		public AsyncTaskMethodBuilder<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x679890", Offset = "0x678C90")]
		public LFFHALFGHGE<OCECEILCCEK> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public HDGHEEOCBGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private HEEHAPCKPNK <errReporting>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private TaskAwaiter<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public OFOOICIPDHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x22010F0", Offset = "0x21FF6F0", VA = "0x1822010F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class FIICJPCCBCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6798F0", Offset = "0x678CF0")]
		public AsyncTaskMethodBuilder<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x679950", Offset = "0x678D50")]
		public LFFHALFGHGE<OGGCMDMBDIL> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public HDGHEEOCBGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private HEEHAPCKPNK <errReporting>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private TaskAwaiter<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public FIICJPCCBCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x21ED4B0", Offset = "0x21EBAB0", VA = "0x1821ED4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private readonly bool PHIAGNPPMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly MGMBHHHNCIH EOPJACEKJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly bool HLGDMKODGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677400", Offset = "0x676800")]
	private BNJEIPJOCHH<NBMOEMODALK, GEKFEJPFGKP> MCJKPBJHOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677460", Offset = "0x676860")]
	private BNJEIPJOCHH<NBMOEMODALK, EFBONPMAHDN> JKCEFNGIGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly CCFBALPMCKN MLOKDGONNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6774C0", Offset = "0x6768C0")]
	private BNJEIPJOCHH<AKFNAADPEJD, LEPFJNPEFMO> KHEMPEHKCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677520", Offset = "0x676920")]
	private BNJEIPJOCHH<AKFNAADPEJD, CMPLANLPCHM> GJPBGCNIIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private string? CDKKAHJGJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly GFIEFCLJIOE FLNPGENIHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677580", Offset = "0x676980")]
	private LFFHALFGHGE<NKHIKPDNMME> GFAHBDKJLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action? GJIGDMEFINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action? BIEKDBKEIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677860", Offset = "0x676C60")]
	private Action<LFFHALFGHGE<NBMOEMODALK>> JKNMAFKBNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677A60", Offset = "0x676E60")]
	private Action<LFFHALFGHGE<AKFNAADPEJD>> NICIBFEDJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private FCKKIELDCKA.MNLLGMFJAEG? ANDDFNBPLPK;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public bool GCGFFMDIKNB
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x21F17A0", Offset = "0x21EFDA0", VA = "0x1821F17A0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public bool PHHLPPEJAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x21F3A40", Offset = "0x21F2040", VA = "0x1821F3A40", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool NNBANHBIBFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x21F2140", Offset = "0x21F0740", VA = "0x1821F2140", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678AE0", Offset = "0x677EE0")]
	public AMHGAJFIDOK<CPCENLDIBPJ> AOLFPPELGFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x21F5010", Offset = "0x21F3610", VA = "0x1821F5010", Slot = "7")]
		get
		{
			return default(AMHGAJFIDOK<CPCENLDIBPJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool LGANENJBILB
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x21F1E50", Offset = "0x21F0450", VA = "0x1821F1E50", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678B50", Offset = "0x677F50")]
	public BNJEIPJOCHH<NBMOEMODALK, EFBONPMAHDN> KCEABAGBGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8BD300", Offset = "0x8BB900", VA = "0x1808BD300", Slot = "9")]
		get
		{
			return default(BNJEIPJOCHH<NBMOEMODALK, EFBONPMAHDN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public string OMBLKOFJABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x21F4030", Offset = "0x21F2630", VA = "0x1821F4030", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678BB0", Offset = "0x677FB0")]
	public AMHGAJFIDOK<FJPOKNNDJKJ> IBMJAOCIOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x21F1D90", Offset = "0x21F0390", VA = "0x1821F1D90", Slot = "11")]
		get
		{
			return default(AMHGAJFIDOK<FJPOKNNDJKJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678C20", Offset = "0x678020")]
	public BNJEIPJOCHH<AKFNAADPEJD, CMPLANLPCHM> LBAELMJBOME
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x7F64D0", Offset = "0x7F4AD0", VA = "0x1807F64D0", Slot = "12")]
		get
		{
			return default(BNJEIPJOCHH<AKFNAADPEJD, CMPLANLPCHM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678C80", Offset = "0x678080")]
	public LFFHALFGHGE<NKHIKPDNMME> FKLIIILGOOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xA2D310", Offset = "0xA2B910", VA = "0x180A2D310", Slot = "13")]
		get
		{
			return default(LFFHALFGHGE<NKHIKPDNMME>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action NNJNDJHMDLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x21F4F70", Offset = "0x21F3570", VA = "0x1821F4F70", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x21F60D0", Offset = "0x21F46D0", VA = "0x1821F60D0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action<LFFHALFGHGE<NBMOEMODALK>, LFFHALFGHGE<NBMOEMODALK>> BHPPCONIAJG
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x21F2A60", Offset = "0x21F1060", VA = "0x1821F2A60", Slot = "16")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677BA0", Offset = "0x676FA0")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x21F4D10", Offset = "0x21F3310", VA = "0x1821F4D10", Slot = "17")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677C00", Offset = "0x677000")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<LFFHALFGHGE<AKFNAADPEJD>, LFFHALFGHGE<AKFNAADPEJD>> KJJGELDBIOM
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x21F4DB0", Offset = "0x21F33B0", VA = "0x1821F4DB0", Slot = "18")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677C60", Offset = "0x677060")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x21F1DB0", Offset = "0x21F03B0", VA = "0x1821F1DB0", Slot = "19")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677CC0", Offset = "0x6770C0")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<LFFHALFGHGE<NBMOEMODALK>, EFBONPMAHDN> AOFFBNJLIBO
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x21F4710", Offset = "0x21F2D10", VA = "0x1821F4710", Slot = "20")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677D20", Offset = "0x677120")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x21F6030", Offset = "0x21F4630", VA = "0x1821F6030", Slot = "21")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677D80", Offset = "0x677180")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<LFFHALFGHGE<NBMOEMODALK>> FMIADOIKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x21F6430", Offset = "0x21F4A30", VA = "0x1821F6430", Slot = "22")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677DE0", Offset = "0x6771E0")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x21F47B0", Offset = "0x21F2DB0", VA = "0x1821F47B0", Slot = "23")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677E40", Offset = "0x677240")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<LFFHALFGHGE<NBMOEMODALK>, EFBONPMAHDN> DOLLJNDCGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x21F39A0", Offset = "0x21F1FA0", VA = "0x1821F39A0", Slot = "24")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677EA0", Offset = "0x6772A0")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x21F3200", Offset = "0x21F1800", VA = "0x1821F3200", Slot = "25")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677F00", Offset = "0x677300")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<LFFHALFGHGE<AKFNAADPEJD>, CMPLANLPCHM> IGOOGGENGGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x21F5830", Offset = "0x21F3E30", VA = "0x1821F5830", Slot = "26")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677F60", Offset = "0x677360")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x21F41D0", Offset = "0x21F27D0", VA = "0x1821F41D0", Slot = "27")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677FC0", Offset = "0x6773C0")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<LFFHALFGHGE<AKFNAADPEJD>> GBIDLFNNBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x21F3F90", Offset = "0x21F2590", VA = "0x1821F3F90", Slot = "28")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678020", Offset = "0x677420")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x21F4850", Offset = "0x21F2E50", VA = "0x1821F4850", Slot = "29")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678080", Offset = "0x677480")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<LFFHALFGHGE<AKFNAADPEJD>, CMPLANLPCHM> JBKMDKNKEKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x21F5790", Offset = "0x21F3D90", VA = "0x1821F5790", Slot = "30")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6780E0", Offset = "0x6774E0")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x21F1CF0", Offset = "0x21F02F0", VA = "0x1821F1CF0", Slot = "31")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678140", Offset = "0x677540")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x21F64D0", Offset = "0x21F4AD0", VA = "0x1821F64D0")]
	private HDGHEEOCBGG(bool DMHDCFFFBIK, MGMBHHHNCIH LAKMIJDGKNI, bool HFBAPLDKHAL, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6781A0", Offset = "0x6775A0")] BNJEIPJOCHH<NBMOEMODALK, GEKFEJPFGKP> LGEKNPGAONK, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678200", Offset = "0x677600")] BNJEIPJOCHH<NBMOEMODALK, EFBONPMAHDN> JPBCPEBHGFJ, CCFBALPMCKN ELLNBMOONAG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678260", Offset = "0x677660")] BNJEIPJOCHH<AKFNAADPEJD, LEPFJNPEFMO> KGIOEMKMJKF, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6782C0", Offset = "0x6776C0")] BNJEIPJOCHH<AKFNAADPEJD, CMPLANLPCHM> MHBDKDLNBME, string? FFCOANNLBKA, GFIEFCLJIOE BMGHCBLCOIG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678320", Offset = "0x677720")] LFFHALFGHGE<NKHIKPDNMME> EDLAGDLJLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x21F58D0", Offset = "0x21F3ED0", VA = "0x1821F58D0")]
	public static HDGHEEOCBGG OGNDBCBGIDA(bool DMHDCFFFBIK, MGMBHHHNCIH LAKMIJDGKNI, bool HFBAPLDKHAL, CCFBALPMCKN ELLNBMOONAG, GFIEFCLJIOE BMGHCBLCOIG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678380", Offset = "0x677780")] LFFHALFGHGE<NKHIKPDNMME> EDLAGDLJLID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x21F33F0", Offset = "0x21F19F0", VA = "0x1821F33F0")]
	private void GMAKAKECEDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x21F2200", Offset = "0x21F0800", VA = "0x1821F2200", Slot = "41")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x21F2B00", Offset = "0x21F1100", VA = "0x1821F2B00", Slot = "32")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EGJHOBIMOPG))]
	public Task<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> EOOHPIOABKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x21F1EE0", Offset = "0x21F04E0", VA = "0x1821F1EE0")]
	private (KCALKOIDKAC, int)? CMEPIBBCDPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x21F4060", Offset = "0x21F2660", VA = "0x1821F4060")]
	private void JJBKJDKFCFJ(int GMOOFIBNNDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x924EC0", Offset = "0x9234C0", VA = "0x180924EC0")]
	private void ACGEKGPNGEF(int GMOOFIBNNDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x21F1070", Offset = "0x21EF670", VA = "0x1821F1070")]
	private void BJMHDKCEKFO(int LLCPJGPEICN, int AJEPHMOBMMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x1AAE190", Offset = "0x1AAC790", VA = "0x181AAE190")]
	private void IMKGEBJGNJK(int GMOOFIBNNDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x21F2C50", Offset = "0x21F1250", VA = "0x1821F2C50")]
	private void FBPGAECPJJL(int GMOOFIBNNDG, int JJNHCDGFBNL, NCKLHJJBCHJ GKJPNIMIKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x21F4EE0", Offset = "0x21F34E0", VA = "0x1821F4EE0")]
	private void KPGOICBGPBJ(int OINELIMPDDO, int JJNHCDGFBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x21F4E50", Offset = "0x21F3450", VA = "0x1821F4E50")]
	private void KLGDMPLHEJD(int OINELIMPDDO, int JJNHCDGFBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x21F1860", Offset = "0x21EFE60", VA = "0x1821F1860")]
	private void CBIHPLLGLPL(int GMOOFIBNNDG, int JJNHCDGFBNL, NCKLHJJBCHJ GKJPNIMIKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x21F0F00", Offset = "0x21EF500", VA = "0x1821F0F00")]
	private void ALBMHFPFFAD(int GMOOFIBNNDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x924EC0", Offset = "0x9234C0", VA = "0x180924EC0")]
	private void PIJNHIEFDBK(int GMOOFIBNNDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x21F48F0", Offset = "0x21F2EF0", VA = "0x1821F48F0")]
	private void KEEFKJCMOGB(int LLCPJGPEICN, int AJEPHMOBMMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x1AAE190", Offset = "0x1AAC790", VA = "0x181AAE190")]
	private void PJGDDGBFKDE(int GMOOFIBNNDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x21F5040", Offset = "0x21F3640", VA = "0x1821F5040")]
	private void MNHJNOGKMHC(int GMOOFIBNNDG, int JJNHCDGFBNL, GFIPMBLNIOC GKJPNIMIKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x21F3F00", Offset = "0x21F2500", VA = "0x1821F3F00")]
	private void IAMLNHFDKBH(int OINELIMPDDO, int JJNHCDGFBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x21F5E10", Offset = "0x21F4410", VA = "0x1821F5E10")]
	private void OIMKHHJDJKK(int OINELIMPDDO, int JJNHCDGFBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x21F4270", Offset = "0x21F2870", VA = "0x1821F4270")]
	private void JMHMJGNOCBB(int GMOOFIBNNDG, int JJNHCDGFBNL, GFIPMBLNIOC GKJPNIMIKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x21F62D0", Offset = "0x21F48D0", VA = "0x1821F62D0", Slot = "33")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PBCBGCLMCHM))]
	public Task<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> PLACCEIBFMK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6784B0", Offset = "0x6778B0")] LFFHALFGHGE<OCECEILCCEK> DPKPHMBFEDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x21F6170", Offset = "0x21F4770", VA = "0x1821F6170", Slot = "34")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ALPHIMEMHNH))]
	public Task<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> PGILBABPGKM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678580", Offset = "0x677980")] LFFHALFGHGE<OGGCMDMBDIL> BIINHNDDAPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x21F5610", Offset = "0x21F3C10", VA = "0x1821F5610", Slot = "35")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NFLMLAIGEEP))]
	public Task<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> OBJNFLDNEFM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678640", Offset = "0x677A40")] LFFHALFGHGE<OCECEILCCEK> DPKPHMBFEDO, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6786A0", Offset = "0x677AA0")] LFFHALFGHGE<OCECEILCCEK> DBOEPKGNLGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x21F1490", Offset = "0x21EFA90", VA = "0x1821F1490", Slot = "36")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IOJIIANAHLO))]
	public Task<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> BKAADALELBL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678760", Offset = "0x677B60")] LFFHALFGHGE<OGGCMDMBDIL> BIINHNDDAPM, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6787C0", Offset = "0x677BC0")] LFFHALFGHGE<OGGCMDMBDIL> DBOEPKGNLGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x21F32A0", Offset = "0x21F18A0", VA = "0x1821F32A0", Slot = "37")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FPONINDOIIL))]
	public Task<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> GLKEGEKAIBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x21F3A90", Offset = "0x21F2090", VA = "0x1821F3A90", Slot = "38")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HNJNMMEECDH))]
	public Task<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> HHOPFJNBNHM(string LLANGCBOGPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x21F1610", Offset = "0x21EFC10", VA = "0x1821F1610", Slot = "39")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OFOOICIPDHE))]
	public Task<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> BKGEJMHMHIA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678950", Offset = "0x677D50")] LFFHALFGHGE<OCECEILCCEK> DPKPHMBFEDO, string ECMAPGHKHFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x21F5EA0", Offset = "0x21F44A0", VA = "0x1821F5EA0", Slot = "40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FIICJPCCBCL))]
	public Task<GLOEKJIOMHK<CMCGOMMIJLE, EKJAOIMOODA>> PBMHPNOANJB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678A20", Offset = "0x677E20")] LFFHALFGHGE<OGGCMDMBDIL> BIINHNDDAPM, string ECMAPGHKHFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x21F3C00", Offset = "0x21F2200", VA = "0x1821F3C00")]
	internal void HPEHJBMFIMO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678A80", Offset = "0x677E80")] LFFHALFGHGE<NKHIKPDNMME> MOLEJFDINLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct KCPDMLCCFKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6799B0", Offset = "0x678DB0")]
	internal DFKAPDCKOEP<OMCOJBJDFLN, NJNNNDNOLHN, PFBFDKEKABJ> PPHLNLFEKDF;

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x1E6B660", Offset = "0x1E69C60", VA = "0x181E6B660")]
	private KCPDMLCCFKP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x679AD0", Offset = "0x678ED0")] in DFKAPDCKOEP<OMCOJBJDFLN, NJNNNDNOLHN, PFBFDKEKABJ> GAPJOEBMKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x21FB430", Offset = "0x21F9A30", VA = "0x1821FB430")]
	public static KCPDMLCCFKP OGNDBCBGIDA()
	{
		return default(KCPDMLCCFKP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public static class KPCLJHBKNLH
{
	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x974F00", Offset = "0x973500", VA = "0x180974F00")]
	public static DFKAPDCKOEP<OMCOJBJDFLN, NJNNNDNOLHN, PFBFDKEKABJ> BJALLOEIMBB(this ref KCPDMLCCFKP CDBMADFDGCE)
	{
		return default(DFKAPDCKOEP<OMCOJBJDFLN, NJNNNDNOLHN, PFBFDKEKABJ>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
public readonly struct DGILLDFMLKI : MNIMKIJILKL.MKFDJAPFCAJ<NJNNNDNOLHN, CMCGOMMIJLE>
{
	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x21EABF0", Offset = "0x21E91F0", VA = "0x1821EABF0", Slot = "4")]
	public int MAEKPPCBHNH(CMCGOMMIJLE OINELIMPDDO, NJNNNDNOLHN ILLCNPCAHGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x21EAAD0", Offset = "0x21E90D0", VA = "0x1821EAAD0", Slot = "5")]
	public NJNNNDNOLHN JJAFCOEIKJJ(CMCGOMMIJLE OINELIMPDDO, NJNNNDNOLHN ILLCNPCAHGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x21EA9F0", Offset = "0x21E8FF0", VA = "0x1821EA9F0", Slot = "6")]
	public NJNNNDNOLHN FMEILAJINKK(CMCGOMMIJLE OINELIMPDDO, NJNNNDNOLHN ILLCNPCAHGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x21EA950", Offset = "0x21E8F50", VA = "0x1821EA950", Slot = "7")]
	public IReadOnlyList<NJNNNDNOLHN> EEFFMCCGFHF(CMCGOMMIJLE OINELIMPDDO, NJNNNDNOLHN ILLCNPCAHGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x21EACA0", Offset = "0x21E92A0", VA = "0x1821EACA0", Slot = "8")]
	public NJNNNDNOLHN[] OPPPAGNGFKC(CMCGOMMIJLE OINELIMPDDO, NJNNNDNOLHN ILLCNPCAHGD, int JFLPEKGNCDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x21EAC40", Offset = "0x21E9240", VA = "0x1821EAC40", Slot = "9")]
	public bool NIGOEKAHABO(CMCGOMMIJLE OINELIMPDDO, NJNNNDNOLHN ILLCNPCAHGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x21EAC10", Offset = "0x21E9210", VA = "0x1821EAC10", Slot = "10")]
	public bool MIPKNOAONMP(CMCGOMMIJLE OINELIMPDDO, NJNNNDNOLHN ILLCNPCAHGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x21EA8F0", Offset = "0x21E8EF0", VA = "0x1821EA8F0", Slot = "11")]
	public bool AMPNOPEHACI(CMCGOMMIJLE OINELIMPDDO, NJNNNDNOLHN ILLCNPCAHGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x21EA920", Offset = "0x21E8F20", VA = "0x1821EA920", Slot = "12")]
	public bool BLMDOCCCIDI(CMCGOMMIJLE OINELIMPDDO, NJNNNDNOLHN ILLCNPCAHGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x21EAC70", Offset = "0x21E9270", VA = "0x1821EAC70", Slot = "13")]
	public bool OBBCDGDJJAC(CMCGOMMIJLE LANBLKPOCMB, NJNNNDNOLHN ILLCNPCAHGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x21EAAA0", Offset = "0x21E90A0", VA = "0x1821EAAA0", Slot = "14")]
	public bool IIPMLGDPHPH(CMCGOMMIJLE OINELIMPDDO, NJNNNDNOLHN ILLCNPCAHGD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public abstract class KGKPCBMJBOC : EAEOEGJDDBD
{
	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public CEHKONMONKB.APFOKPPKJNI CDMAIBCPMMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x21FB510", Offset = "0x21F9B10", VA = "0x1821FB510", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public abstract DCNCJACIPJA.HAOKLNODKCD IHLKECDAIOB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public abstract MGMBHHHNCIH.OIHNLCKABAD CPEHPHFMMND
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public abstract MAPIAIAFEBO.DIFOAAFEIGI JEJHEOCGHDE
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public ILLEHKNENGB.MIACHIBEEKI<IJBLNCALADF, NJNNNDNOLHN, MGMBHHHNCIH> CKCJMJBKFBI
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x21FB4B0", Offset = "0x21F9AB0", VA = "0x1821FB4B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public abstract HEEHAPCKPNK OGFDBBPHLAN
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public abstract JKPIEHOAJOM NCAKJLENJPI
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public abstract HEKAMFEJFFG CLCKCDPLIBH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public abstract HGCAIGHNICF MHJLJPEOOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public abstract AKPAAILGPPI EKPELLHDDCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	protected KGKPCBMJBOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public sealed class AEEIOMKCPHI : GDGAHNFAEDI
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class MFIFKBAECJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x679CB0", Offset = "0x6790B0")]
		public AsyncTaskMethodBuilder<GLOEKJIOMHK<object, EKJAOIMOODA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public NJNNNDNOLHN action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public AEEIOMKCPHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private GLOEKJIOMHK<object, EKJAOIMOODA> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private TaskAwaiter<GLOEKJIOMHK<object, EKJAOIMOODA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public MFIFKBAECJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x21FC810", Offset = "0x21FAE10", VA = "0x1821FC810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class MKFNBJGHBMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x679E30", Offset = "0x679230")]
		public AsyncTaskMethodBuilder<GLOEKJIOMHK<MDAIIAIHCFN, EKJAOIMOODA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x679EF0", Offset = "0x6792F0")]
		public IReadOnlyList<NJNNNDNOLHN> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public AEEIOMKCPHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x679FB0", Offset = "0x6793B0")]
		private GLOEKJIOMHK<object, EKJAOIMOODA> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67A080", Offset = "0x679480")]
		private TaskAwaiter<GLOEKJIOMHK<object, EKJAOIMOODA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public MKFNBJGHBMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x21FE440", Offset = "0x21FCA40", VA = "0x1821FE440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private readonly BONGOLGIJCE DIDHOFKFBFK;

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0xA0C770", Offset = "0xA0AD70", VA = "0x180A0C770")]
	public AEEIOMKCPHI(BONGOLGIJCE CAJJAGENDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x21E8160", Offset = "0x21E6760", VA = "0x1821E8160")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MFIFKBAECJE))]
	private Task<GLOEKJIOMHK<object, EKJAOIMOODA>> DFIAIEFKDPJ(NJNNNDNOLHN ILLCNPCAHGD, bool JJAEMOEGKLD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x21E7FD0", Offset = "0x21E65D0", VA = "0x1821E7FD0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MKFNBJGHBMD))]
	public Task<GLOEKJIOMHK<MDAIIAIHCFN, EKJAOIMOODA>> DBNGKFFODEA(IReadOnlyList<NJNNNDNOLHN> CPNBDMBECHB, bool JJAEMOEGKLD)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000090")]
public struct IHHEKOMCLBG : OHFNHLBFMOL.DGHFHGFFECK<EIGGGDGKGEO, NJNNNDNOLHN>
{
	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0xBF9BB0", Offset = "0xBF81B0", VA = "0x180BF9BB0")]
	public int POLEDGIGENI(in EIGGGDGKGEO OECKMOGBCHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x21F7400", Offset = "0x21F5A00", VA = "0x1821F7400", Slot = "5")]
	public NJNNNDNOLHN OOIBGOPNIPH(EIGGGDGKGEO[] KOOGENLHMGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0xBF9BB0", Offset = "0xBF81B0", VA = "0x180BF9BB0", Slot = "4")]
	private int IHHBLMJFKBJ(in EIGGGDGKGEO OECKMOGBCHC)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000092")]
public struct PFBFDKEKABJ : EEDNNJOPIFF.DFDEKIGKHBM<OMCOJBJDFLN, NJNNNDNOLHN>
{
	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x2202810", Offset = "0x2200E10", VA = "0x182202810", Slot = "5")]
	public NJNNNDNOLHN FOOABHOMGGH(OMCOJBJDFLN[] OJGAOODOKJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0xBF9BB0", Offset = "0xBF81B0", VA = "0x180BF9BB0")]
	public int EAMJCJGILBJ(in OMCOJBJDFLN OECKMOGBCHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0xBF9BB0", Offset = "0xBF81B0", VA = "0x180BF9BB0", Slot = "4")]
	private int NKDIHDMHFCL(in OMCOJBJDFLN GINJKJNOECL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct CECOOELNCEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67A290", Offset = "0x679690")]
	internal GDFMBIIJGNO<EIGGGDGKGEO, NJNNNDNOLHN, IHHEKOMCLBG> PPHLNLFEKDF;

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x1E6B660", Offset = "0x1E69C60", VA = "0x181E6B660")]
	private CECOOELNCEG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x67A350", Offset = "0x679750")] in GDFMBIIJGNO<EIGGGDGKGEO, NJNNNDNOLHN, IHHEKOMCLBG> KAPPNFEELAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x21E9610", Offset = "0x21E7C10", VA = "0x1821E9610")]
	public static CECOOELNCEG OGNDBCBGIDA()
	{
		return default(CECOOELNCEG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class LBHFOLPEIDF
{
	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x974F00", Offset = "0x973500", VA = "0x180974F00")]
	public static GDFMBIIJGNO<EIGGGDGKGEO, NJNNNDNOLHN, IHHEKOMCLBG> BJALLOEIMBB(this ref CECOOELNCEG CDBMADFDGCE)
	{
		return default(GDFMBIIJGNO<EIGGGDGKGEO, NJNNNDNOLHN, IHHEKOMCLBG>);
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
