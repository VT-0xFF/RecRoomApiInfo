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
		[Cpp2IlInjected.Address(RVA = "0x24DEE00", Offset = "0x24DE000", VA = "0x1824DEE00")]
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
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
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
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class LMPMALFKFKJ : IDisposable, HHAGAEMNCPC, CHBAGBMGJDK, OGGAKHJBHAG, BFGGIJPNFBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class DOOMODFBFAE : ONFFFKFPEHG
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int HOMIJHLECLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x24CF3F0", Offset = "0x24CE5F0", VA = "0x1824CF3F0", Slot = "5")]
		public LGJADAHPADD FIOFONBKPGC(MPIJDDEDEEJ.DJJONGDOFCF KHICLIFOGCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void MABFOAHJNNE();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void OLDGOBEHDAK();

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x24CF540", Offset = "0x24CE740", VA = "0x1824CF540", Slot = "13")]
		public virtual void HGGHFLPIMLB(LMPMALFKFKJ AAKAOKDAEPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x24CF580", Offset = "0x24CE780", VA = "0x1824CF580", Slot = "14")]
		public virtual void JGNIOJOFFDK(LMPMALFKFKJ AAKAOKDAEPH, NAGMPGBKIGM KOMGLJOLBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		protected DOOMODFBFAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface ONFFFKFPEHG
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int HOMIJHLECLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "1")]
		LGJADAHPADD FIOFONBKPGC(MPIJDDEDEEJ.DJJONGDOFCF KHICLIFOGCP);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void MABFOAHJNNE();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OLDGOBEHDAK();

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void HGGHFLPIMLB(LMPMALFKFKJ AAKAOKDAEPH);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void JGNIOJOFFDK(LMPMALFKFKJ AAKAOKDAEPH, NAGMPGBKIGM KOMGLJOLBFC);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct JAPBLGHOGIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly FPMCEKNKPNH<MELNNHKBONO, NAGMPGBKIGM, LMPMALFKFKJ, PICIEGNBDJL.EEIAMFPGFEG<MELNNHKBONO, NAGMPGBKIGM, LMPMALFKFKJ>> ONHFMDHDOEK;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x24D46A0", Offset = "0x24D38A0", VA = "0x1824D46A0")]
		internal JAPBLGHOGIH(FPMCEKNKPNH<MELNNHKBONO, NAGMPGBKIGM, LMPMALFKFKJ, PICIEGNBDJL.EEIAMFPGFEG<MELNNHKBONO, NAGMPGBKIGM, LMPMALFKFKJ>> CMFHMEJHOAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class IOCCECDMGLI : PICIEGNBDJL.EEIAMFPGFEG<MELNNHKBONO, NAGMPGBKIGM, LMPMALFKFKJ>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly IOCCECDMGLI CLACNPDFIIL;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		private IOCCECDMGLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x983250", Offset = "0x982450", VA = "0x180983250", Slot = "4")]
		public MELNNHKBONO EGBNBHDFPKI(NAGMPGBKIGM MLNFAKCEGNM)
		{
			return default(MELNNHKBONO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x24D3EB0", Offset = "0x24D30B0", VA = "0x1824D3EB0", Slot = "5")]
		public void HGGHFLPIMLB(LMPMALFKFKJ DONMCNODAED, NAGMPGBKIGM KOMGLJOLBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x24D3FB0", Offset = "0x24D31B0", VA = "0x1824D3FB0", Slot = "6")]
		public void JGNIOJOFFDK(LMPMALFKFKJ DONMCNODAED, NAGMPGBKIGM KOMGLJOLBFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct AFKCEIFIJCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public IHLMHPIPNGI<MELNNHKBONO, NAGMPGBKIGM, LMPMALFKFKJ, PICIEGNBDJL.EEIAMFPGFEG<MELNNHKBONO, NAGMPGBKIGM, LMPMALFKFKJ>> ONHFMDHDOEK;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x24C2090", Offset = "0x24C1290", VA = "0x1824C2090")]
		internal AFKCEIFIJCK(IHLMHPIPNGI<MELNNHKBONO, NAGMPGBKIGM, LMPMALFKFKJ, PICIEGNBDJL.EEIAMFPGFEG<MELNNHKBONO, NAGMPGBKIGM, LMPMALFKFKJ>> CMFHMEJHOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x24C2040", Offset = "0x24C1240", VA = "0x1824C2040")]
		public static AFKCEIFIJCK PAJOIGLPBMN()
		{
			return default(AFKCEIFIJCK);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct AHLCLONOALP : FHADEGJBDFM.MNBEIFBBPMF<NAGMPGBKIGM, LMPMALFKFKJ>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct JEKLPNPDHLH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<EBOICGKKPAM<object?, LKEBDJCDIFL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public LMPMALFKFKJ receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public NAGMPGBKIGM action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AHLCLONOALP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<EBOICGKKPAM<object?, LKEBDJCDIFL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x24D4930", Offset = "0x24D3B30", VA = "0x1824D4930", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x24D4B10", Offset = "0x24D3D10", VA = "0x1824D4B10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xD350D0", Offset = "0xD342D0", VA = "0x180D350D0", Slot = "4")]
		public ANHNAJIBLBK<AKJMODAIHHM> BBDMMLDCEOJ(LMPMALFKFKJ LFLGFFHCMEJ)
		{
			return default(ANHNAJIBLBK<AKJMODAIHHM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x24CCEA0", Offset = "0x24CC0A0", VA = "0x1824CCEA0", Slot = "5")]
		public void ENKIEPGDJHE(LMPMALFKFKJ LFLGFFHCMEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x24CCF00", Offset = "0x24CC100", VA = "0x1824CCF00", Slot = "6")]
		[AsyncStateMachine(typeof(JEKLPNPDHLH))]
		public Task<EBOICGKKPAM<object, LKEBDJCDIFL>> GKHIPAFGJIF(LMPMALFKFKJ LFLGFFHCMEJ, NAGMPGBKIGM KOMGLJOLBFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x24CD030", Offset = "0x24CC230", VA = "0x1824CD030", Slot = "7")]
		public NAGMPGBKIGM[] GPPEHGEIEDL(LMPMALFKFKJ LFLGFFHCMEJ)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct LIBJJFIOOEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<bool, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public LMPMALFKFKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public BOGHAPBEAMM rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public NHLHHLCCGOO circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public CGFMNABJBKA superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<EBOICGKKPAM<bool, LKEBDJCDIFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x24D83E0", Offset = "0x24D75E0", VA = "0x1824D83E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x24D8660", Offset = "0x24D7860", VA = "0x1824D8660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct KAJFKJICGBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<bool, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public LMPMALFKFKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<EBOICGKKPAM<bool, LKEBDJCDIFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x24D4E20", Offset = "0x24D4020", VA = "0x1824D4E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x24D50B0", Offset = "0x24D42B0", VA = "0x1824D50B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct MCEFKAHGKBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public LMPMALFKFKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x24DCAA0", Offset = "0x24DBCA0", VA = "0x1824DCAA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x24DCC80", Offset = "0x24DBE80", VA = "0x1824DCC80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct IOHEBKIGKGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<object?, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public LMPMALFKFKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public NAGMPGBKIGM action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<EBOICGKKPAM<object?, LKEBDJCDIFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x24D4140", Offset = "0x24D3340", VA = "0x1824D4140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x24D4330", Offset = "0x24D3530", VA = "0x1824D4330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct NILBEINNCDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public LMPMALFKFKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private TaskAwaiter<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<EBOICGKKPAM<bool, LKEBDJCDIFL>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x24DE450", Offset = "0x24DD650", VA = "0x1824DE450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x24DEC30", Offset = "0x24DDE30", VA = "0x1824DEC30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly ANHNAJIBLBK<AKJMODAIHHM> MKKDAHJMPMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly JAPBLGHOGIH IGIGJPICFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly IPOEJJIKHNB GMADOENJOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly AGPFNCJAMOH OCGFJBPPDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AD8")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly EFDENJBCFFC CFHCLEHKHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AE0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly MBGMEAFLNHF.GGPMGPHBBPM ABMFNEALCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B00")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly PEEMHCNCMDC ELEFEHANMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B08")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly AKKMBPLHKIN JBJLEHICHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly DKKPOMAIAMK MAOBHHKHMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly LLMBKOBKCNP IAMEHOKGLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B20")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private JDNJHBCKNLI EOADDPINFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private BPDLGHAILDK NPOOJJIGJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B50")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly IPOEJJIKHNB.EKNNDMFEGPA IGLFEDDHDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B58")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly BOFLHCMGKBM KECKLCNLPCB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public IPOEJJIKHNB LJCJHOPIIHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x24DBF10", Offset = "0x24DB110", VA = "0x1824DBF10")]
		get
		{
			return default(IPOEJJIKHNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal ONFFFKFPEHG NOMJGAKCPDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x24DC1D0", Offset = "0x24DB3D0", VA = "0x1824DC1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal LGJADAHPADD CJEDBFAHFHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x24DB110", Offset = "0x24DA310", VA = "0x1824DB110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x24DC1B0", Offset = "0x24DB3B0", VA = "0x1824DC1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool PBJAGLFIPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x24DBF20", Offset = "0x24DB120", VA = "0x1824DBF20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x24DB6E0", Offset = "0x24DA8E0", VA = "0x1824DB6E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ONOEOCIMGNH PLDJJAGBLMP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x24DCA60", Offset = "0x24DBC60", VA = "0x1824DCA60", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GEHPPECDDFO HPBAPBLLHGK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x24DCA70", Offset = "0x24DBC70", VA = "0x1824DCA70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public NOOIGCIPMNI BFPCFJPMDBM
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x24DCA90", Offset = "0x24DBC90", VA = "0x1824DCA90", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public INDGHAOOEDB OCBNJIFMPEK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x24DCA80", Offset = "0x24DBC80", VA = "0x1824DCA80", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public MBGMEAFLNHF? DHKOPMPHGOM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x24DB930", Offset = "0x24DAB30", VA = "0x1824DB930", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private CGAOFJCMGML? KKJIIHKJCKP
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x24DB3A0", Offset = "0x24DA5A0", VA = "0x1824DB3A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x24DC760", Offset = "0x24DB960", VA = "0x1824DC760")]
	private LMPMALFKFKJ(EFDENJBCFFC DNIPNOKEENP, ANHNAJIBLBK<AKJMODAIHHM> NEKLIKCEFAN, [In] JAPBLGHOGIH KHABIBKECIB, [In] IPOEJJIKHNB NMOOHILANMC, [In] AGPFNCJAMOH PJABOJNFIHK, LGJADAHPADD BGLNCPCCEJG, [In] MBGMEAFLNHF.GGPMGPHBBPM ICGODFJPKEB, IPOEJJIKHNB.EKNNDMFEGPA EMIMJLHALGK, BOFLHCMGKBM HMGGPEMONEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x24DC620", Offset = "0x24DB820", VA = "0x1824DC620")]
	public static LMPMALFKFKJ PAJOIGLPBMN(EFDENJBCFFC KHICLIFOGCP, [In] BBONECPGADD JACBPGLHJLL, LOKJBFDMHEG IFOIDMIDMEO, [In] AJLFLHJNKCC EHJOJICNAKF, CKCEJMHJGIM HILOHMBAJKE, ANHNAJIBLBK<AKJMODAIHHM> NEKLIKCEFAN, ANHNAJIBLBK<FIHLPILAOOA> IICPOGACHHM, NOJMHINMKNJ LECMOIOCNBJ, OGPACHGILCM BPOKNOLPDGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x24DC340", Offset = "0x24DB540", VA = "0x1824DC340")]
	public static LMPMALFKFKJ PAJOIGLPBMN(EFDENJBCFFC DNIPNOKEENP, [In] IPOEJJIKHNB NMOOHILANMC, [In] AGPFNCJAMOH PJABOJNFIHK, ANHNAJIBLBK<AKJMODAIHHM> NEKLIKCEFAN, ANHNAJIBLBK<FIHLPILAOOA> IICPOGACHHM, NOJMHINMKNJ LECMOIOCNBJ, OGPACHGILCM BPOKNOLPDGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x24DB6F0", Offset = "0x24DA8F0", VA = "0x1824DB6F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x24DB9B0", Offset = "0x24DABB0", VA = "0x1824DB9B0")]
	[AsyncStateMachine(typeof(LIBJJFIOOEB))]
	internal Task<EBOICGKKPAM<bool, LKEBDJCDIFL>> FKBBECELAAL(BOGHAPBEAMM HENCMBBFEOD, NHLHHLCCGOO OOOHBNNMLEC, CGFMNABJBKA JBBABNEKIMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x24DB2B0", Offset = "0x24DA4B0", VA = "0x1824DB2B0")]
	[AsyncStateMachine(typeof(KAJFKJICGBA))]
	public Task<EBOICGKKPAM<bool, LKEBDJCDIFL>> CJKCINJJLBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x24DC0C0", Offset = "0x24DB2C0", VA = "0x1824DC0C0")]
	[AsyncStateMachine(typeof(MCEFKAHGKBO))]
	public Task<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> LMLPKOHFABE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x24DB4D0", Offset = "0x24DA6D0", VA = "0x1824DB4D0")]
	internal void DBIPOHKPNBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x24DB230", Offset = "0x24DA430", VA = "0x1824DB230")]
	internal IIKGGOMPAPK<NAGMPGBKIGM> BMCOMFLKKOI([In] KPCEIBCGPGH CJEOOJLBAIA)
	{
		return default(IIKGGOMPAPK<NAGMPGBKIGM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x24DBEA0", Offset = "0x24DB0A0", VA = "0x1824DBEA0")]
	internal bool HMFFILEJDOA([In] KPCEIBCGPGH CJEOOJLBAIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x24DBF30", Offset = "0x24DB130", VA = "0x1824DBF30")]
	internal EBOICGKKPAM<NAGMPGBKIGM, LKEBDJCDIFL> JPDIOBOBNFI([In] IKLKOHELGEA HPNDAGMPPKE)
	{
		return default(EBOICGKKPAM<NAGMPGBKIGM, LKEBDJCDIFL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x24DB8E0", Offset = "0x24DAAE0", VA = "0x1824DB8E0")]
	private void ENKIEPGDJHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x24DB120", Offset = "0x24DA320", VA = "0x1824DB120")]
	[AsyncStateMachine(typeof(IOHEBKIGKGA))]
	internal Task<EBOICGKKPAM<object, LKEBDJCDIFL>> AJBLLGJMNMF(NAGMPGBKIGM KOMGLJOLBFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x24DBB10", Offset = "0x24DAD10", VA = "0x1824DBB10")]
	private NAGMPGBKIGM[] GPPEHGEIEDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x24DC220", Offset = "0x24DB420", VA = "0x1824DC220")]
	[AsyncStateMachine(typeof(NILBEINNCDL))]
	public Task<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> OABODDKODCN(Guid GAMKBDPOIDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class NEIEPHCBGMF
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x33F23F0", Offset = "0x33F15F0", VA = "0x1833F23F0")]
	public static EFNKEENBBOI<(TPrev?, LMPMALFKFKJ?), CGAOFJCMGML> GLIHCNCJPPD<TPrev>([In] this EFNKEENBBOI<TPrev, LMPMALFKFKJ> MLNFAKCEGNM)
	{
		return default(EFNKEENBBOI<(TPrev, LMPMALFKFKJ), CGAOFJCMGML>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x33F26B0", Offset = "0x33F18B0", VA = "0x1833F26B0")]
	public static EFNKEENBBOI<TPrev?, LMPMALFKFKJ?> NOIFHHGDJKN<TPrev>([In] this EFNKEENBBOI<TPrev, LMPMALFKFKJ> MLNFAKCEGNM)
	{
		return default(EFNKEENBBOI<TPrev, LMPMALFKFKJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class DBMGEGLGFLE<TData> : ENAONJKJOID, DJFMDEHFALI, MNCKOMAJMKB where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly BDPEADCNJIF<COBLBOLGAKJ>? AKMABIBPLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly string DCDNDNHHMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly TData ELDOIBMHPAJ;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public BDPEADCNJIF<COBLBOLGAKJ>? FPINDLKEJIM
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x271D120", Offset = "0x271C320", VA = "0x18271D120", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8FD8F0", Offset = "0x8FCAF0", VA = "0x1808FD8F0", Slot = "7")]
	public override string OEJBHPKDIJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x604E620", Offset = "0x604D820", VA = "0x18604E620")]
	internal DBMGEGLGFLE([In] BDPEADCNJIF<COBLBOLGAKJ>? HLLLMBLEKAH, ANHNAJIBLBK<ECPNEAEENPI>? CIDNFNLDHMP, IOKind? POPJNNKEPMI, string CBCJFCINKPJ, [In] TData LFDKFEEPNFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class CEKGGMAEEEM
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x24CDD30", Offset = "0x24CCF30", VA = "0x1824CDD30")]
	public static EBOICGKKPAM<KIEJAMKEENB, DJFMDEHFALI> OGFBKGANIGE([In] this MFHFBGAIEDD<HOJNAMOBCNE> BNODGOECFLP)
	{
		return default(EBOICGKKPAM<KIEJAMKEENB, DJFMDEHFALI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x30B9DC0", Offset = "0x30B8FC0", VA = "0x1830B9DC0")]
	public static EBOICGKKPAM<TOk, DJFMDEHFALI> CDBAHPACLKP<TOk>([In] this EBOICGKKPAM<TOk, DJFMDEHFALI> MLNFAKCEGNM, [In] BDPEADCNJIF<COBLBOLGAKJ>? HLLLMBLEKAH, ANHNAJIBLBK<ECPNEAEENPI>? CIDNFNLDHMP, IOKind? POPJNNKEPMI, string CBCJFCINKPJ) where TOk : notnull
	{
		return default(EBOICGKKPAM<TOk, DJFMDEHFALI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface EFDENJBCFFC
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	BLCBNMLEBHK.GNJBOAKJPCG HFPNPNEPDHA
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	MPIJDDEDEEJ.DJJONGDOFCF AJDNEJLNIEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	LMPMALFKFKJ.ONFFFKFPEHG KCCDIPDGBKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	PNCACGINIMH.LINOLILKBJL OOPOGDHJJAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	PICIEGNBDJL.EEIAMFPGFEG<MELNNHKBONO, NAGMPGBKIGM, LMPMALFKFKJ> NDHEDMALAFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	KDFMCIEGIOL IFODINBCCPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	MEBKPIJAJOK NLFJFFEPKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	AMMMNIHCPLN GCCEAHEOIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	JJCFPHNFHFO INJJABJLIAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	NHKHFEIKFGM AFDMBBGBNIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class KKBJELBAACA
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x24D5750", Offset = "0x24D4950", VA = "0x1824D5750")]
	public static NAGMPGBKIGM OJCIGJGLGMD(this NAGMPGBKIGM MLNFAKCEGNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x24D5680", Offset = "0x24D4880", VA = "0x1824D5680")]
	public static NAGMPGBKIGM CDHFGLJFOGI(this JCBDCCBMEOK MLNFAKCEGNM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct JCBDCCBMEOK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct HMJELLBFBDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<object?, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public LMPMALFKFKJ root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public JCBDCCBMEOK self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private TaskAwaiter<EBOICGKKPAM<object?, LKEBDJCDIFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x24D1D70", Offset = "0x24D0F70", VA = "0x1824D1D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x24D2030", Offset = "0x24D1230", VA = "0x1824D2030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly ByteString ELOFPHHKCIM;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xBC2740", Offset = "0xBC1940", VA = "0x180BC2740")]
	private JCBDCCBMEOK(ByteString OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x24D47C0", Offset = "0x24D39C0", VA = "0x1824D47C0")]
	public static NAGMPGBKIGM FPFJGFOHENJ(ByteString OMEFCJCOLII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x24D4880", Offset = "0x24D3A80", VA = "0x1824D4880")]
	public static EHOGFMPDNAM<MELNNHKBONO, JCBDCCBMEOK> PIEBFGHIFLB(NAGMPGBKIGM JICJCJGENCH)
	{
		return default(EHOGFMPDNAM<MELNNHKBONO, JCBDCCBMEOK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x24D46B0", Offset = "0x24D38B0", VA = "0x1824D46B0")]
	[AsyncStateMachine(typeof(HMJELLBFBDH))]
	public static Task<EBOICGKKPAM<object, LKEBDJCDIFL>> AJBLLGJMNMF(LMPMALFKFKJ DONMCNODAED, JCBDCCBMEOK MLNFAKCEGNM)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct EDHPAGLCOFH
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x24CFBE0", Offset = "0x24CEDE0", VA = "0x1824CFBE0")]
	public static NAGMPGBKIGM FPFJGFOHENJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x24CFC80", Offset = "0x24CEE80", VA = "0x1824CFC80")]
	public static EHOGFMPDNAM<MELNNHKBONO, EDHPAGLCOFH> PIEBFGHIFLB(NAGMPGBKIGM JICJCJGENCH)
	{
		return default(EHOGFMPDNAM<MELNNHKBONO, EDHPAGLCOFH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x24CFB60", Offset = "0x24CED60", VA = "0x1824CFB60")]
	public static EBOICGKKPAM<HEGEDEFNLEJ, ODKGPKGHBED> EKFOLBMLNHA(LMPMALFKFKJ DONMCNODAED, [In] EDHPAGLCOFH MLNFAKCEGNM)
	{
		return default(EBOICGKKPAM<HEGEDEFNLEJ, ODKGPKGHBED>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct DIEKNNPADMP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct CKDECADNCGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<HEGEDEFNLEJ, ODKGPKGHBED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public LMPMALFKFKJ root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public DIEKNNPADMP self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private EBOICGKKPAM<HEGEDEFNLEJ, ODKGPKGHBED> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x24CE360", Offset = "0x24CD560", VA = "0x1824CE360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x24CE6D0", Offset = "0x24CD8D0", VA = "0x1824CE6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly BOGHAPBEAMM? GILPMNKPIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly NHLHHLCCGOO? NHELKEIMKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly CGFMNABJBKA? MEELOHMDMEG;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x23FB600", Offset = "0x23FA800", VA = "0x1823FB600")]
	private DIEKNNPADMP(BOGHAPBEAMM? HENCMBBFEOD, NHLHHLCCGOO? OOOHBNNMLEC, CGFMNABJBKA? JBBABNEKIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x24CF1E0", Offset = "0x24CE3E0", VA = "0x1824CF1E0")]
	public static NAGMPGBKIGM? FPFJGFOHENJ(BOGHAPBEAMM? HENCMBBFEOD, NHLHHLCCGOO? OOOHBNNMLEC, CGFMNABJBKA? JBBABNEKIMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x24CF2E0", Offset = "0x24CE4E0", VA = "0x1824CF2E0")]
	public static EHOGFMPDNAM<MELNNHKBONO, DIEKNNPADMP> PIEBFGHIFLB(NAGMPGBKIGM JICJCJGENCH)
	{
		return default(EHOGFMPDNAM<MELNNHKBONO, DIEKNNPADMP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x24CF0A0", Offset = "0x24CE2A0", VA = "0x1824CF0A0")]
	[AsyncStateMachine(typeof(CKDECADNCGD))]
	public static Task<EBOICGKKPAM<HEGEDEFNLEJ, ODKGPKGHBED>> AJBLLGJMNMF(LMPMALFKFKJ DONMCNODAED, DIEKNNPADMP MLNFAKCEGNM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct FAJJCBFENOC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct PLMGGIPMFNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<BFCNMIIHFAN, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public FAJJCBFENOC self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public LMPMALFKFKJ root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private EBOICGKKPAM<BFCNMIIHFAN, LKEBDJCDIFL> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private EBOICGKKPAM<object?, MNCKOMAJMKB>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private EBOICGKKPAM<object?, MNCKOMAJMKB> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private EBOICGKKPAM<object?, MNCKOMAJMKB>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter<EBOICGKKPAM<object?, LKEBDJCDIFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x24DF330", Offset = "0x24DE530", VA = "0x1824DF330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x24DF790", Offset = "0x24DE990", VA = "0x1824DF790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly IReadOnlyList<NAGMPGBKIGM> HJEAOLCMDDP;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xBC2740", Offset = "0xBC1940", VA = "0x180BC2740")]
	private FAJJCBFENOC(IReadOnlyList<NAGMPGBKIGM> MPDFABPCMPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x24D01D0", Offset = "0x24CF3D0", VA = "0x1824D01D0")]
	public static NAGMPGBKIGM FPFJGFOHENJ(IReadOnlyList<NAGMPGBKIGM> MPDFABPCMPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x24D0290", Offset = "0x24CF490", VA = "0x1824D0290")]
	public static EHOGFMPDNAM<MELNNHKBONO, FAJJCBFENOC> PIEBFGHIFLB(NAGMPGBKIGM JICJCJGENCH)
	{
		return default(EHOGFMPDNAM<MELNNHKBONO, FAJJCBFENOC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x24D0090", Offset = "0x24CF290", VA = "0x1824D0090")]
	[AsyncStateMachine(typeof(PLMGGIPMFNK))]
	public static Task<EBOICGKKPAM<BFCNMIIHFAN, LKEBDJCDIFL>> AJBLLGJMNMF(LMPMALFKFKJ DONMCNODAED, FAJJCBFENOC MLNFAKCEGNM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct IKLKOHELGEA
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class KEEGMAJEEHB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class EGAEHJAJJEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public BDPEADCNJIF<KEEGMAJEEHB> actionId;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public EGAEHJAJJEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x24CFCF0", Offset = "0x24CEEF0", VA = "0x1824CFCF0")]
		internal NAGMPGBKIGM CIPFMPLKDCL(int count, int index, [In] ReadOnlySpan<byte> span)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly BDPEADCNJIF<KEEGMAJEEHB> HOAPCPABFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly int BIMHEMDFFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly int JDABKJNJMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly byte[] ELDOIBMHPAJ;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x24D2860", Offset = "0x24D1A60", VA = "0x1824D2860")]
	private IKLKOHELGEA(BDPEADCNJIF<KEEGMAJEEHB> KHCNLNALDMB, int EOKNBJLIKEG, int CPLNODNGKGB, byte[] LFDKFEEPNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x24D24F0", Offset = "0x24D16F0", VA = "0x1824D24F0")]
	public static NAGMPGBKIGM FPFJGFOHENJ(BDPEADCNJIF<KEEGMAJEEHB> KHCNLNALDMB, int EOKNBJLIKEG, int CPLNODNGKGB, ByteString LFDKFEEPNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x24D2600", Offset = "0x24D1800", VA = "0x1824D2600")]
	public static NAGMPGBKIGM[] LELOFPJHDNA(NAGMPGBKIGM KOMGLJOLBFC, int GCCOAFCFPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x24D2710", Offset = "0x24D1910", VA = "0x1824D2710")]
	public static EHOGFMPDNAM<MELNNHKBONO, IKLKOHELGEA> PIEBFGHIFLB(NAGMPGBKIGM JICJCJGENCH)
	{
		return default(EHOGFMPDNAM<MELNNHKBONO, IKLKOHELGEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x24D2350", Offset = "0x24D1550", VA = "0x1824D2350")]
	public static EBOICGKKPAM<NAGMPGBKIGM, LKEBDJCDIFL> EKFOLBMLNHA(LMPMALFKFKJ DONMCNODAED, [In] IKLKOHELGEA MLNFAKCEGNM)
	{
		return default(EBOICGKKPAM<NAGMPGBKIGM, LKEBDJCDIFL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct KPCEIBCGPGH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct FGJEGPLDLGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<bool, ODKGPKGHBED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public LMPMALFKFKJ root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public KPCEIBCGPGH self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private EBOICGKKPAM<bool, ODKGPKGHBED> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<EBOICGKKPAM<HEGEDEFNLEJ, ODKGPKGHBED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x24D0420", Offset = "0x24CF620", VA = "0x1824D0420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x24D0A60", Offset = "0x24CFC60", VA = "0x1824D0A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly int BIMHEMDFFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly int JDABKJNJMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly byte[] ELDOIBMHPAJ;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABDAE0", VA = "0x180ABE8E0")]
	private KPCEIBCGPGH(int EOKNBJLIKEG, int CPLNODNGKGB, byte[] LFDKFEEPNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x24D62F0", Offset = "0x24D54F0", VA = "0x1824D62F0")]
	public static NAGMPGBKIGM FPFJGFOHENJ(int EOKNBJLIKEG, int CPLNODNGKGB, ByteString LFDKFEEPNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x24D60F0", Offset = "0x24D52F0", VA = "0x1824D60F0")]
	public static NAGMPGBKIGM?[]? EJODOJJOHIL(int GCCOAFCFPIK, BOGHAPBEAMM? HENCMBBFEOD, NHLHHLCCGOO? OOOHBNNMLEC, CGFMNABJBKA? JBBABNEKIMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x24D63D0", Offset = "0x24D55D0", VA = "0x1824D63D0")]
	public static EHOGFMPDNAM<MELNNHKBONO, KPCEIBCGPGH> PIEBFGHIFLB(NAGMPGBKIGM JICJCJGENCH)
	{
		return default(EHOGFMPDNAM<MELNNHKBONO, KPCEIBCGPGH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x24D5FC0", Offset = "0x24D51C0", VA = "0x1824D5FC0")]
	[AsyncStateMachine(typeof(FGJEGPLDLGP))]
	public static Task<EBOICGKKPAM<bool, ODKGPKGHBED>> AJBLLGJMNMF(LMPMALFKFKJ DONMCNODAED, KPCEIBCGPGH MLNFAKCEGNM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class PEEMHCNCMDC : ONOEOCIMGNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly LMPMALFKFKJ FPODCAIMPFE;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public DFBICJIHHKM? CLACNPDFIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x24DF230", Offset = "0x24DE430", VA = "0x1824DF230", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x902B20", Offset = "0x901D20", VA = "0x180902B20")]
	internal PEEMHCNCMDC(LMPMALFKFKJ AAKAOKDAEPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class BNEGCEMMIBM : DFBICJIHHKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly LMPMALFKFKJ FPODCAIMPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly HPMNCAGGPMJ NIKFCHNIJKK;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8FD3B0", Offset = "0x8FC5B0", VA = "0x1808FD3B0")]
	public BNEGCEMMIBM(LMPMALFKFKJ AAKAOKDAEPH, HPMNCAGGPMJ DHDIHDEIOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x24CD910", Offset = "0x24CCB10", VA = "0x1824CD910", Slot = "4")]
	public EBOICGKKPAM<KIEJAMKEENB, DJFMDEHFALI> IAICLPGJBJH(BDPEADCNJIF<COBLBOLGAKJ> MFMLNNMNGAP, ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO, ANHNAJIBLBK<DPCEHNODIAE> CFHBDBIEIEP)
	{
		return default(EBOICGKKPAM<KIEJAMKEENB, DJFMDEHFALI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x24CD630", Offset = "0x24CC830", VA = "0x1824CD630", Slot = "5")]
	public EBOICGKKPAM<KIEJAMKEENB, DJFMDEHFALI> GNANIMDCHCE(BDPEADCNJIF<COBLBOLGAKJ> MFMLNNMNGAP, ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO, ANHNAJIBLBK<IOGABLMALHO> KGKPKEDHPHA)
	{
		return default(EBOICGKKPAM<KIEJAMKEENB, DJFMDEHFALI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class BLCBNMLEBHK : JKADNBJIIJM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface GNJBOAKJPCG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<HPMNCAGGPMJ> FMGPHKAOBEA(LMPMALFKFKJ AAKAOKDAEPH, NHLHHLCCGOO? FNFHKHEPBDF, CGFMNABJBKA? JIEGKCDEJMM, CancellationToken BGEKICMONBE);

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		FFDLFADJEBF DDDEPCKHGGJ(LMPMALFKFKJ AAKAOKDAEPH, BOGHAPBEAMM LMACDEEEICM);
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class MFMHMKFJIDO : GNJBOAKJPCG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private struct GMHCLHEHDIL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AsyncTaskMethodBuilder<HPMNCAGGPMJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public LMPMALFKFKJ circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public NHLHHLCCGOO cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public CGFMNABJBKA cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private TaskAwaiter<PNCACGINIMH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x24D1630", Offset = "0x24D0830", VA = "0x1824D1630", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x24D1800", Offset = "0x24D0A00", VA = "0x1824D1800", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly MFMHMKFJIDO CLACNPDFIIL;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		private MFMHMKFJIDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x24DCD80", Offset = "0x24DBF80", VA = "0x1824DCD80", Slot = "4")]
		[AsyncStateMachine(typeof(GMHCLHEHDIL))]
		public Task<HPMNCAGGPMJ> FMGPHKAOBEA(LMPMALFKFKJ AAKAOKDAEPH, NHLHHLCCGOO? FNFHKHEPBDF, CGFMNABJBKA? JIEGKCDEJMM, CancellationToken BGEKICMONBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x24DCD60", Offset = "0x24DBF60", VA = "0x1824DCD60", Slot = "5")]
		public FFDLFADJEBF DDDEPCKHGGJ(LMPMALFKFKJ AAKAOKDAEPH, BOGHAPBEAMM LMACDEEEICM)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct ECPDEFFHIBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public AsyncTaskMethodBuilder<BLCBNMLEBHK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public LMPMALFKFKJ circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public NHLHHLCCGOO cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public CGFMNABJBKA cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public BOGHAPBEAMM evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private GNJBOAKJPCG <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private TaskAwaiter<HPMNCAGGPMJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x24CF600", Offset = "0x24CE800", VA = "0x1824CF600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x24CFAF0", Offset = "0x24CECF0", VA = "0x1824CFAF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly HPMNCAGGPMJ NIKFCHNIJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly FFDLFADJEBF GIOOPEBNCMO;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public MBGMEAFLNHF DHKOPMPHGOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x24CD3B0", Offset = "0x24CC5B0", VA = "0x1824CD3B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public CGAOFJCMGML KBGKKMPDGBF
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x24CD570", Offset = "0x24CC770", VA = "0x1824CD570", Slot = "5")]
		get
		{
			return default(CGAOFJCMGML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public BNEGCEMMIBM NKLAOACKIPA
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public ICAAAPILHBO KNJIABIFCHP
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8F85D0", Offset = "0x8F77D0", VA = "0x1808F85D0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xDCCE00", Offset = "0xDCC000", VA = "0x180DCCE00")]
	private BLCBNMLEBHK(HPMNCAGGPMJ DHDIHDEIOFL, FFDLFADJEBF CADJMLCOBPH, BNEGCEMMIBM MDLFDCPLIKM, ICAAAPILHBO PIKBPAKFMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x24CD400", Offset = "0x24CC600", VA = "0x1824CD400")]
	[AsyncStateMachine(typeof(ECPDEFFHIBL))]
	public static Task<BLCBNMLEBHK> JBKCFEIEBFA(LMPMALFKFKJ AAKAOKDAEPH, BOGHAPBEAMM LMACDEEEICM, NHLHHLCCGOO? FNFHKHEPBDF, CGFMNABJBKA? JIEGKCDEJMM, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x24CD350", Offset = "0x24CC550", VA = "0x1824CD350", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class MPIJDDEDEEJ : LGJADAHPADD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface DJJONGDOFCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<JKADNBJIIJM> IKBFCCPEINP(LMPMALFKFKJ AAKAOKDAEPH, BOGHAPBEAMM LMACDEEEICM, NHLHHLCCGOO? FNFHKHEPBDF, CGFMNABJBKA? JIEGKCDEJMM, CancellationToken BGEKICMONBE);

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MMPFLADDJCC();

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void MOFEODMBIIF();
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public abstract class NLOANPACGJD : DJJONGDOFCF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private struct OIEHPOLKFGG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<JKADNBJIIJM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public LMPMALFKFKJ circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public BOGHAPBEAMM evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public NHLHHLCCGOO cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public CGFMNABJBKA cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private TaskAwaiter<BLCBNMLEBHK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x24DEE80", Offset = "0x24DE080", VA = "0x1824DEE80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x24DF1C0", Offset = "0x24DE3C0", VA = "0x1824DF1C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x24DECA0", Offset = "0x24DDEA0", VA = "0x1824DECA0", Slot = "4")]
		[AsyncStateMachine(typeof(OIEHPOLKFGG))]
		public Task<JKADNBJIIJM> IKBFCCPEINP(LMPMALFKFKJ AAKAOKDAEPH, BOGHAPBEAMM LMACDEEEICM, NHLHHLCCGOO? FNFHKHEPBDF, CGFMNABJBKA? JIEGKCDEJMM, CancellationToken BGEKICMONBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void MMPFLADDJCC();

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void MOFEODMBIIF();

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		protected NLOANPACGJD()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct GKPHPAIDJBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder<JKADNBJIIJM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public MPIJDDEDEEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter<HEGEDEFNLEJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x24D13C0", Offset = "0x24D05C0", VA = "0x1824D13C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x24D15C0", Offset = "0x24D07C0", VA = "0x1824D15C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct GFEMKJLNMOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public MPIJDDEDEEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public LMPMALFKFKJ circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public BOGHAPBEAMM evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public NHLHHLCCGOO cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public CGFMNABJBKA cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private TaskAwaiter<JKADNBJIIJM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x24D0E30", Offset = "0x24D0030", VA = "0x1824D0E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x24D1360", Offset = "0x24D0560", VA = "0x1824D1360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly DJJONGDOFCF PHOHCHAEDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly TaskCompletionSource<HEGEDEFNLEJ> IBPFFJLJFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly TaskCompletionSource<HEGEDEFNLEJ> NFFMLLCKKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly CancellationTokenSource OGFBNDJJDDJ;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool PBJAGLFIPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x920F50", Offset = "0x920150", VA = "0x180920F50", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x920CD0", Offset = "0x91FED0", VA = "0x180920CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool EHPNJBGMJGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xC5A5C0", Offset = "0xC597C0", VA = "0x180C5A5C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1106B50", Offset = "0x1105D50", VA = "0x181106B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool HHKCKCCEANC
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x174F9F0", Offset = "0x174EBF0", VA = "0x18174F9F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x24DDE90", Offset = "0x24DD090", VA = "0x1824DDE90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public JKADNBJIIJM? CDMKBKDKAHK
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0E0", Offset = "0x8FA2E0", VA = "0x1808FB0E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0C0", Offset = "0x8FA2C0", VA = "0x1808FB0C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x24DDEA0", Offset = "0x24DD0A0", VA = "0x1824DDEA0", Slot = "7")]
	[AsyncStateMachine(typeof(GKPHPAIDJBN))]
	public Task<JKADNBJIIJM> LKAKBMIBPMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x24DDF90", Offset = "0x24DD190", VA = "0x1824DDF90")]
	public MPIJDDEDEEJ(DJJONGDOFCF KHICLIFOGCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x24DDBB0", Offset = "0x24DCDB0", VA = "0x1824DDBB0", Slot = "8")]
	[AsyncStateMachine(typeof(GFEMKJLNMOD))]
	public Task BJBGDKKFAIP(LMPMALFKFKJ AAKAOKDAEPH, BOGHAPBEAMM LMACDEEEICM, NHLHHLCCGOO? FNFHKHEPBDF, CGFMNABJBKA? JIEGKCDEJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x24DDD10", Offset = "0x24DCF10", VA = "0x1824DDD10", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class EMPMCHMGHDK : GKHKGLAECNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly ICAAAPILHBO ENGMAJCPLAO;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x902B20", Offset = "0x901D20", VA = "0x180902B20")]
	public EMPMCHMGHDK(ICAAAPILHBO PIKBPAKFMNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class CHIJHHLLMGA
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class LEOGJHMAPDP<TGraph> : DNEKCIMOOPN where TGraph : ONIEEENHFNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		protected readonly TGraph AMPMKALIKAP;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public virtual AAIFPGADEEE? IACBENLBDIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x1573400", Offset = "0x1572600", VA = "0x181573400", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public ANHNAJIBLBK<KJENBNHGDMG> HEKKAKHLFJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x49DE3D0", Offset = "0x49DD5D0", VA = "0x1849DE3D0", Slot = "5")]
			get
			{
				return default(ANHNAJIBLBK<KJENBNHGDMG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public ANHNAJIBLBK<KJENBNHGDMG>? NAEOBJBFFOH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x49DE350", Offset = "0x49DD550", VA = "0x1849DE350", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x902B20", Offset = "0x901D20", VA = "0x180902B20")]
		public LEOGJHMAPDP(TGraph CEJADBPEGGM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private sealed class MGMKKCCCBBB : LEOGJHMAPDP<CEOLEAMCNJN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override AAIFPGADEEE? IACBENLBDIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x24DCF60", Offset = "0x24DC160", VA = "0x1824DCF60", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x24DCF80", Offset = "0x24DC180", VA = "0x1824DCF80")]
		public MGMKKCCCBBB(CEOLEAMCNJN KOFJOMAFGLF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x24CE1D0", Offset = "0x24CD3D0", VA = "0x1824CE1D0")]
	public static DNEKCIMOOPN PAJOIGLPBMN(ONIEEENHFNK CEJADBPEGGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class LKPOHMDECEE : AKIDJEJCFMD, FHPPJBGMDGJ, LIKJLNMKBIK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class FBCALONKLEF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private struct <<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public FBCALONKLEF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public KDFMCIEGIOL errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private TaskAwaiter<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x24DF920", Offset = "0x24DEB20", VA = "0x1824DF920", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x24DFB90", Offset = "0x24DED90", VA = "0x1824DFB90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public LKPOHMDECEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public FBCALONKLEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x24D0330", Offset = "0x24CF530", VA = "0x1824D0330")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task FEJMGNHAAND(KDFMCIEGIOL errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct KFOFOPAPFCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public bool checkStringPurity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public LKPOHMDECEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x24D5120", Offset = "0x24D4320", VA = "0x1824D5120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x24D5620", Offset = "0x24D4820", VA = "0x1824D5620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class AEJEKNMDEEL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private struct <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public AEJEKNMDEEL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private TaskAwaiter<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x24DFBF0", Offset = "0x24DEDF0", VA = "0x1824DFBF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x24DFED0", Offset = "0x24DF0D0", VA = "0x1824DFED0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public LKPOHMDECEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public AEJEKNMDEEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x24C1F70", Offset = "0x24C1170", VA = "0x1824C1F70")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task HMBPEBDOBNA(KDFMCIEGIOL errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly LNOFCFGPJLL CCLPHIMAFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly ICollection<OEAGHNHKIHN> KFHHFANDINO;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private EFDENJBCFFC JBLDPABKGNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x24D9C50", Offset = "0x24D8E50", VA = "0x1824D9C50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public ANHNAJIBLBK<DPCEHNODIAE> NKNGCFFAFNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xA56480", Offset = "0xA55680", VA = "0x180A56480", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(ANHNAJIBLBK<DPCEHNODIAE>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xD6DA00", Offset = "0xD6CC00", VA = "0x180D6DA00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private ANHNAJIBLBK<NEMHENHHKIC> MGCNDIKGOLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1102830", Offset = "0x1101A30", VA = "0x181102830")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public ANHNAJIBLBK<FOIPKNJPLLP> IDAJEAGEPOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x91AA20", Offset = "0x919C20", VA = "0x18091AA20", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(ANHNAJIBLBK<FOIPKNJPLLP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public override ANHNAJIBLBK<ECPNEAEENPI> MPAJDBLAMHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x24DA750", Offset = "0x24D9950", VA = "0x1824DA750", Slot = "20")]
		get
		{
			return default(ANHNAJIBLBK<ECPNEAEENPI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool PNCHNGOFFGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x24D98B0", Offset = "0x24D8AB0", VA = "0x1824D98B0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x24DAEF0", Offset = "0x24DA0F0", VA = "0x1824DAEF0")]
	private LKPOHMDECEE(LMPMALFKFKJ AAKAOKDAEPH, HGHEIBELGCA NGCBLOEDNKL, LNOFCFGPJLL FCAFDDOJLEC, ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO, ANHNAJIBLBK<DPCEHNODIAE> CFHBDBIEIEP, ANHNAJIBLBK<NEMHENHHKIC> JIAOICBDGLF, bool KIKLCLPKJOJ, string LMOANCJLHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x24DAB30", Offset = "0x24D9D30", VA = "0x1824DAB30")]
	public static LKPOHMDECEE PAJOIGLPBMN(LMPMALFKFKJ AAKAOKDAEPH, HGHEIBELGCA NGCBLOEDNKL, LNOFCFGPJLL DFKGLBJBJGD, ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO, ANHNAJIBLBK<NEMHENHHKIC> JIAOICBDGLF, ANHNAJIBLBK<DPCEHNODIAE> CFHBDBIEIEP, bool KIKLCLPKJOJ, bool GHBLBJBGAAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x24D9B60", Offset = "0x24D8D60", VA = "0x1824D9B60", Slot = "21")]
	protected override void GGPOBANFNOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x24D9730", Offset = "0x24D8930", VA = "0x1824D9730", Slot = "22")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x24D97D0", Offset = "0x24D89D0", VA = "0x1824D97D0", Slot = "30")]
	public void EDAAMNKHBBE(OEAGHNHKIHN JHLOPMEHFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x24D9200", Offset = "0x24D8400", VA = "0x1824D9200", Slot = "27")]
	public void CLFPDPLHKNH(LGJDJIFEEMP NNBFLOJBBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x24D8760", Offset = "0x24D7960", VA = "0x1824D8760", Slot = "28")]
	public void BJKGIDOIOFI(AAGABJKPGDE IDJLKPNCPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x24DA920", Offset = "0x24D9B20", VA = "0x1824DA920", Slot = "23")]
	protected override void OBFBIIMLAOP(OGFNKIKFPAG KGHPJPIDAEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x24DA490", Offset = "0x24D9690", VA = "0x1824DA490", Slot = "32")]
	public string KLKNBKBBOPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x24DA180", Offset = "0x24D9380", VA = "0x1824DA180", Slot = "29")]
	public string KCEDIJKAOKC(int ODKEIFCIJNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x24D9F60", Offset = "0x24D9160", VA = "0x1824D9F60")]
	private void KADLLOEGGHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x24DA7A0", Offset = "0x24D99A0", VA = "0x1824DA7A0", Slot = "31")]
	public void NGKCGDAGOIC(OEAGHNHKIHN JHLOPMEHFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x24D9570", Offset = "0x24D8770", VA = "0x1824D9570")]
	private void DIHHBNFJOIE(bool OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x24D90F0", Offset = "0x24D82F0", VA = "0x1824D90F0", Slot = "33")]
	[AsyncStateMachine(typeof(KFOFOPAPFCC))]
	public Task CJGKBMLEJPP(string OMEFCJCOLII, bool NNFNDCAGIHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x24D9E10", Offset = "0x24D9010", VA = "0x1824D9E10")]
	public void JPEPEKBBPLD(string OMEFCJCOLII, bool NNFNDCAGIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x24D99C0", Offset = "0x24D8BC0", VA = "0x1824D99C0")]
	private void GBJBPHOHIAP(int OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0xD6DA00", Offset = "0xD6CC00", VA = "0x180D6DA00")]
	internal void DIPDLDGLAFL(ANHNAJIBLBK<DPCEHNODIAE> OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x24D9C70", Offset = "0x24D8E70", VA = "0x1824D9C70")]
	[CompilerGenerated]
	private void IBGJPLCHOKA(string OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x24D9D50", Offset = "0x24D8F50", VA = "0x1824D9D50")]
	[CompilerGenerated]
	private bool JBBLFEKBEIN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x24DA860", Offset = "0x24D9A60", VA = "0x1824DA860")]
	[CompilerGenerated]
	private bool NPEALAJJJCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x24D9C00", Offset = "0x24D8E00", VA = "0x1824D9C00")]
	[CompilerGenerated]
	private int NIMDBCLLIJE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x24D9930", Offset = "0x24D8B30", VA = "0x1824D9930")]
	[CompilerGenerated]
	private bool FOBMADAGOKJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x24DAEE0", Offset = "0x24DA0E0", VA = "0x1824DAEE0")]
	[CompilerGenerated]
	private void PBPGCDDJDPD(string OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x24DAA70", Offset = "0x24D9C70", VA = "0x1824DAA70")]
	[CompilerGenerated]
	private bool OCJJMGEMIFL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x24DA440", Offset = "0x24D9640", VA = "0x1824DA440")]
	[CompilerGenerated]
	private bool KLGPBNAGMEF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x24D86D0", Offset = "0x24D78D0", VA = "0x1824D86D0")]
	[CompilerGenerated]
	private bool BIJPDAKHEKM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x24D9C00", Offset = "0x24D8E00", VA = "0x1824D9C00")]
	[CompilerGenerated]
	private int GJKIIDAALEJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x24DA600", Offset = "0x24D9800", VA = "0x1824DA600")]
	[CompilerGenerated]
	private bool KNLCHMJHFME()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x24D9830", Offset = "0x24D8A30", VA = "0x1824D9830")]
	[CompilerGenerated]
	private object EHEAMGCCAEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x24DA6D0", Offset = "0x24D98D0", VA = "0x1824DA6D0")]
	[CompilerGenerated]
	private void LPEMMGILCLF(object OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x24D9C80", Offset = "0x24D8E80", VA = "0x1824D9C80")]
	[CompilerGenerated]
	private bool INNLANDJMKG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class INCKJGPNJCP
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private sealed class JABHBMBEAHN : PHHDBLBBBNE<MOFEDABPJJN>
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class DFAPMCNCNGK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public JABHBMBEAHN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public CBPIPCCOCCI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public DFAPMCNCNGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x24CEF60", Offset = "0x24CE160", VA = "0x1824CEF60")]
			internal object CNNDFCIODJA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x24CEFD0", Offset = "0x24CE1D0", VA = "0x1824CEFD0")]
			internal void OHJIDAACGDJ(object value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x24D4630", Offset = "0x24D3830", VA = "0x1824D4630")]
		public JABHBMBEAHN(LMPMALFKFKJ AAKAOKDAEPH, MOFEDABPJJN CMFHMEJHOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x24D43A0", Offset = "0x24D35A0", VA = "0x1824D43A0", Slot = "122")]
		protected override void OOGPOIIHFKH(MMBCHPEGPFF FNGALEILPLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class AKOEICNLHPH : JKMCFJIDALI<EECDGBNOOCA>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override OGABAALDEPD ABDBJAFGNNM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xA79BB0", Offset = "0xA78DB0", VA = "0x180A79BB0", Slot = "128")]
			get
			{
				return default(OGABAALDEPD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x24CD050", Offset = "0x24CC250", VA = "0x1824CD050")]
		public AKOEICNLHPH(LMPMALFKFKJ AAKAOKDAEPH, EECDGBNOOCA CMFHMEJHOAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public sealed class GAKCPBJFOHB : PHHDBLBBBNE<DBGEDIIGOJF>
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x24D0DC0", Offset = "0x24CFFC0", VA = "0x1824D0DC0")]
		public GAKCPBJFOHB(LMPMALFKFKJ AAKAOKDAEPH, DBGEDIIGOJF NGCBLOEDNKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x24D0C40", Offset = "0x24CFE40", VA = "0x1824D0C40", Slot = "122")]
		protected override void OOGPOIIHFKH(MMBCHPEGPFF FNGALEILPLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x24D0AD0", Offset = "0x24CFCD0", VA = "0x1824D0AD0")]
		[CompilerGenerated]
		private bool KPKCPNABGKG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x24D0B20", Offset = "0x24CFD20", VA = "0x1824D0B20")]
		[CompilerGenerated]
		private void LIIAKGANHCF(bool OMEFCJCOLII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class NFCPPOKEGNM : PHHDBLBBBNE<JHLMOFFBEGG>
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class HIMDCEADDIM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public CBPIPCCOCCI nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public NFCPPOKEGNM <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public HIMDCEADDIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x24D1B60", Offset = "0x24D0D60", VA = "0x1824D1B60")]
			internal void CNNDFCIODJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x24D1D20", Offset = "0x24D0F20", VA = "0x1824D1D20")]
			internal bool OHJIDAACGDJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x24D1B10", Offset = "0x24D0D10", VA = "0x1824D1B10")]
			internal bool CHECEAOKJII()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x24D1BB0", Offset = "0x24D0DB0", VA = "0x1824D1BB0")]
			internal void FGLIKLLHBNH(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x24D1CD0", Offset = "0x24D0ED0", VA = "0x1824D1CD0")]
			internal bool FHEGOLGOMJG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x24DE3E0", Offset = "0x24DD5E0", VA = "0x1824DE3E0")]
		public NFCPPOKEGNM(LMPMALFKFKJ AAKAOKDAEPH, JHLMOFFBEGG NGCBLOEDNKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x24DE0A0", Offset = "0x24DD2A0", VA = "0x1824DE0A0", Slot = "122")]
		protected override void OOGPOIIHFKH(MMBCHPEGPFF FNGALEILPLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class DEGKIOPIPBN : PHHDBLBBBNE<KCDDMJJBFMG>
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private sealed class KMIGAADAHLK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public CBPIPCCOCCI nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public DEGKIOPIPBN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public KMIGAADAHLK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x24D59C0", Offset = "0x24D4BC0", VA = "0x1824D59C0")]
			internal object CNNDFCIODJA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x24D5F40", Offset = "0x24D5140", VA = "0x1824D5F40")]
			internal bool PHECLJCFGBO(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x24D5CF0", Offset = "0x24D4EF0", VA = "0x1824D5CF0")]
			internal void OHJIDAACGDJ(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x24D5860", Offset = "0x24D4A60", VA = "0x1824D5860")]
			internal string CHECEAOKJII(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x24D5B10", Offset = "0x24D4D10", VA = "0x1824D5B10")]
			internal IReadOnlyList<object> FGLIKLLHBNH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x24D5B60", Offset = "0x24D4D60", VA = "0x1824D5B60")]
			internal bool FHEGOLGOMJG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x24D5AC0", Offset = "0x24D4CC0", VA = "0x1824D5AC0")]
			internal bool DNFOIEHJGKL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x24D5BD0", Offset = "0x24D4DD0", VA = "0x1824D5BD0")]
			internal void JLCENCAMMIH(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x24CEEF0", Offset = "0x24CE0F0", VA = "0x1824CEEF0")]
		public DEGKIOPIPBN(LMPMALFKFKJ AAKAOKDAEPH, KCDDMJJBFMG NGCBLOEDNKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x24CE7A0", Offset = "0x24CD9A0", VA = "0x1824CE7A0", Slot = "122")]
		protected override void OOGPOIIHFKH(MMBCHPEGPFF FNGALEILPLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public sealed class BKAFHCDNNFN : PHHDBLBBBNE<ACAJFCPKFNK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[CompilerGenerated]
		private sealed class JILJINLOCOP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public BKAFHCDNNFN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public CBPIPCCOCCI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public JILJINLOCOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x24D4BD0", Offset = "0x24D3DD0", VA = "0x1824D4BD0")]
			internal bool CNNDFCIODJA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x24D4C20", Offset = "0x24D3E20", VA = "0x1824D4C20")]
			internal void OHJIDAACGDJ(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x24D4B80", Offset = "0x24D3D80", VA = "0x1824D4B80")]
			internal bool CHECEAOKJII()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x24CD2E0", Offset = "0x24CC4E0", VA = "0x1824CD2E0")]
		public BKAFHCDNNFN(LMPMALFKFKJ AAKAOKDAEPH, ACAJFCPKFNK NGCBLOEDNKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x24CD0B0", Offset = "0x24CC2B0", VA = "0x1824CD0B0", Slot = "122")]
		protected override void OOGPOIIHFKH(MMBCHPEGPFF FNGALEILPLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class HLLJHJFDKAI<TNode> : PHHDBLBBBNE<TNode> where TNode : notnull, IDDJLIJAFOE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private struct ADCOAPLFMPD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public AsyncTaskMethodBuilder<EBOICGKKPAM<ANHNAJIBLBK<GIDHHIIAAHA>, LKEBDJCDIFL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public HLLJHJFDKAI<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private TaskAwaiter<EBOICGKKPAM<ANHNAJIBLBK<GIDHHIIAAHA>, LKEBDJCDIFL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x4417810", Offset = "0x4416A10", VA = "0x184417810", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x4417C00", Offset = "0x4416E00", VA = "0x184417C00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private struct AHJDFALMNMC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public AsyncTaskMethodBuilder<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public HLLJHJFDKAI<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public ANHNAJIBLBK<GIDHHIIAAHA> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			private TaskAwaiter<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x45291A0", Offset = "0x45283A0", VA = "0x1845291A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x4529590", Offset = "0x4528790", VA = "0x184529590", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public sealed override bool MLGMNJKGJAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override ANHNAJIBLBK<GIDHHIIAAHA>? BAIBCJGKKEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x44E9BE0", Offset = "0x44E8DE0", VA = "0x1844E9BE0", Slot = "121")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x44E9B90", Offset = "0x44E8D90", VA = "0x1844E9B90")]
		protected HLLJHJFDKAI(LMPMALFKFKJ AAKAOKDAEPH, TNode NGCBLOEDNKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x44E9820", Offset = "0x44E8A20", VA = "0x1844E9820", Slot = "102")]
		[AsyncStateMachine(typeof(HLLJHJFDKAI<>.ADCOAPLFMPD))]
		public override Task<EBOICGKKPAM<ANHNAJIBLBK<GIDHHIIAAHA>, LKEBDJCDIFL>> GACGGMGJKPH(string LMOANCJLHKC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x44E99E0", Offset = "0x44E8BE0", VA = "0x1844E99E0", Slot = "126")]
		public sealed override bool MAPJNEMPDOI(ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x44E9940", Offset = "0x44E8B40", VA = "0x1844E9940", Slot = "114")]
		protected sealed override bool KPOOHONDFHN(ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x44E9780", Offset = "0x44E8980", VA = "0x1844E9780", Slot = "115")]
		protected override bool BOFNEEJFBDF(ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x44E9A80", Offset = "0x44E8C80", VA = "0x1844E9A80", Slot = "103")]
		[AsyncStateMachine(typeof(HLLJHJFDKAI<>.AHJDFALMNMC))]
		public override Task<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> PJMOGAHAJNG(ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public sealed class HPLBNGECCJD : DCOHGAPPALO<BGNFONLHPDH>
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private sealed class CBMIHPAFLIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public HPLBNGECCJD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public CBPIPCCOCCI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public CBMIHPAFLIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x24CDCB0", Offset = "0x24CCEB0", VA = "0x1824CDCB0")]
			internal bool NDAPLDKBDJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x24CDBF0", Offset = "0x24CCDF0", VA = "0x1824CDBF0")]
			internal void KCAIGKLOHLF(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x24D22F0", Offset = "0x24D14F0", VA = "0x1824D22F0")]
		public HPLBNGECCJD(LMPMALFKFKJ AAKAOKDAEPH, BGNFONLHPDH CMFHMEJHOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x24D20A0", Offset = "0x24D12A0", VA = "0x1824D20A0", Slot = "128")]
		protected override void MGLGHHPEHGC(MMBCHPEGPFF FNGALEILPLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private sealed class DDEEEAKPPIB : BENPMJLEHAB<LCMDLDBEEFG>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override NodeVisualizationKey CHCLNDNNNEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xA8A350", Offset = "0xA89550", VA = "0x180A8A350", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x24CE740", Offset = "0x24CD940", VA = "0x1824CE740")]
		public DDEEEAKPPIB(LMPMALFKFKJ AAKAOKDAEPH, LCMDLDBEEFG NGCBLOEDNKL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public abstract class BENPMJLEHAB<TNode> : PHHDBLBBBNE<TNode> where TNode : notnull, BPLMIHLJDMD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private struct KOPMDILBEGD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public AsyncTaskMethodBuilder<EBOICGKKPAM<ANHNAJIBLBK<GIDHHIIAAHA>, LKEBDJCDIFL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public BENPMJLEHAB<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private TaskAwaiter<EBOICGKKPAM<ANHNAJIBLBK<GIDHHIIAAHA>, LKEBDJCDIFL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x49568A0", Offset = "0x4955AA0", VA = "0x1849568A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x4956D30", Offset = "0x4955F30", VA = "0x184956D30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct GOKPNJJIPOM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public AsyncTaskMethodBuilder<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public BENPMJLEHAB<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public ANHNAJIBLBK<GIDHHIIAAHA> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			private TaskAwaiter<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x445DE60", Offset = "0x445D060", VA = "0x18445DE60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x445E2D0", Offset = "0x445D4D0", VA = "0x18445E2D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		[CompilerGenerated]
		private struct AMAKJOFCKLD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public AsyncTaskMethodBuilder<EBOICGKKPAM<BFCNMIIHFAN, LKEBDJCDIFL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public BENPMJLEHAB<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private TaskAwaiter<EBOICGKKPAM<BFCNMIIHFAN, LKEBDJCDIFL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x4534B80", Offset = "0x4533D80", VA = "0x184534B80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x4535230", Offset = "0x4534430", VA = "0x184535230", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class AGLJPOHAKPH
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000054")]
			private struct <<BuildConfigMenuInternal>b__7>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public AGLJPOHAKPH <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000158")]
				[Cpp2IlInjected.Address(RVA = "0x3C19D40", Offset = "0x3C18F40", VA = "0x183C19D40", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000159")]
				[Cpp2IlInjected.Address(RVA = "0x949E40", Offset = "0x949040", VA = "0x180949E40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public MMBCHPEGPFF configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public CBPIPCCOCCI nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public BENPMJLEHAB<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public Func<string, bool> <>9__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public Action <>9__7;

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public AGLJPOHAKPH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x4421F60", Offset = "0x4421160", VA = "0x184421F60")]
			internal bool JLCENCAMMIH(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x4421C80", Offset = "0x4420E80", VA = "0x184421C80")]
			internal void CNNDFCIODJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x4422430", Offset = "0x4421630", VA = "0x184422430")]
			[AsyncStateMachine(typeof(BENPMJLEHAB<>.AGLJPOHAKPH.<<BuildConfigMenuInternal>b__7>d))]
			internal void PHECLJCFGBO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x4422040", Offset = "0x4421240", VA = "0x184422040")]
			internal bool OHJIDAACGDJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		[CompilerGenerated]
		private sealed class NOEHGPANBPO
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000056")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public NOEHGPANBPO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				private TaskAwaiter<TaskStatus> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600015F")]
				[Cpp2IlInjected.Address(RVA = "0x3C199D0", Offset = "0x3C18BD0", VA = "0x183C199D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000160")]
				[Cpp2IlInjected.Address(RVA = "0x949E40", Offset = "0x949040", VA = "0x180949E40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public string newFunctionName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public AGLJPOHAKPH CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public Func<string> <>9__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public Action<string> <>9__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public Action <>9__5;

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public NOEHGPANBPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x4CA8510", Offset = "0x4CA7710", VA = "0x184CA8510")]
			internal void CHECEAOKJII()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
			internal string FGLIKLLHBNH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x8F54A0", Offset = "0x8F46A0", VA = "0x1808F54A0")]
			internal void FHEGOLGOMJG(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x4CA8910", Offset = "0x4CA7B10", VA = "0x184CA8910")]
			[AsyncStateMachine(typeof(BENPMJLEHAB<>.NOEHGPANBPO.<<BuildConfigMenuInternal>b__5>d))]
			internal void DNFOIEHJGKL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class ILHECGOBEOD
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000058")]
			private struct <<AddDynamicNodeGroupSettingV2>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000109")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010A")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010B")]
				public ILHECGOBEOD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010C")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000174")]
				[Cpp2IlInjected.Address(RVA = "0x3C19500", Offset = "0x3C18700", VA = "0x183C19500", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000175")]
				[Cpp2IlInjected.Address(RVA = "0x949E40", Offset = "0x949040", VA = "0x180949E40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000059")]
			private struct <<AddDynamicNodeGroupSettingV2>b__6>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public ILHECGOBEOD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				private TaskAwaiter<EBOICGKKPAM<ANHNAJIBLBK<NEMHENHHKIC>, LKEBDJCDIFL>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000176")]
				[Cpp2IlInjected.Address(RVA = "0x3C196E0", Offset = "0x3C188E0", VA = "0x183C196E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000177")]
				[Cpp2IlInjected.Address(RVA = "0x949E40", Offset = "0x949040", VA = "0x180949E40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005A")]
			private struct <<AddDynamicNodeGroupSettingV2>b__10>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000112")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000113")]
				public ILHECGOBEOD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000114")]
				private TaskAwaiter<EBOICGKKPAM<ANHNAJIBLBK<LFJPMKFPODE>, LKEBDJCDIFL>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000178")]
				[Cpp2IlInjected.Address(RVA = "0x3C18E50", Offset = "0x3C18050", VA = "0x183C18E50", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000179")]
				[Cpp2IlInjected.Address(RVA = "0x949E40", Offset = "0x949040", VA = "0x180949E40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public BENPMJLEHAB<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public ANHNAJIBLBK<GIDHHIIAAHA> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public MMBCHPEGPFF configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public CBPIPCCOCCI nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public NFKPPHIGIKA nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public int minGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public int maxGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public BKCDGFOGEGO selectedInputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public string newInputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public List<FPMIHIDLPCO> inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public BKCDGFOGEGO selectedOutputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public string newOutputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public List<FPMIHIDLPCO> outputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public Func<string, bool> <>9__17;

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public ILHECGOBEOD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x464F7A0", Offset = "0x464E9A0", VA = "0x18464F7A0")]
			internal bool EEJODCLAIBF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x464FE30", Offset = "0x464F030", VA = "0x18464FE30")]
			internal void OOPBLCCAJEJ(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x464FCA0", Offset = "0x464EEA0", VA = "0x18464FCA0")]
			internal bool NPGMBKAJOAI(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x464FA30", Offset = "0x464EC30", VA = "0x18464FA30")]
			internal bool JLJIFPBODEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x464F520", Offset = "0x464E720", VA = "0x18464F520")]
			[AsyncStateMachine(typeof(BENPMJLEHAB<>.ILHECGOBEOD.<<AddDynamicNodeGroupSettingV2>b__2>d))]
			internal void AGAJCOCMNMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x464FA70", Offset = "0x464EC70", VA = "0x18464FA70")]
			internal bool KDGJLCGMAFD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x464F680", Offset = "0x464E880", VA = "0x18464F680")]
			internal void CPCELBHPLBO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x464FD80", Offset = "0x464EF80", VA = "0x18464FD80")]
			internal bool OJLFDNCOEKH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x464F5C0", Offset = "0x464E7C0", VA = "0x18464F5C0")]
			internal void BCOLICPOCGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x464FBF0", Offset = "0x464EDF0", VA = "0x18464FBF0")]
			internal bool NEDBLNHDAHM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x464F880", Offset = "0x464EA80", VA = "0x18464F880")]
			internal bool GDNHEGCLGBB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x464F810", Offset = "0x464EA10", VA = "0x18464F810")]
			internal void EOELFAFAPPO(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x464FAB0", Offset = "0x464ECB0", VA = "0x18464FAB0")]
			[AsyncStateMachine(typeof(BENPMJLEHAB<>.ILHECGOBEOD.<<AddDynamicNodeGroupSettingV2>b__6>d))]
			internal void LCPFCPKHALC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x464F740", Offset = "0x464E940", VA = "0x18464F740")]
			internal bool DFEEFBKFGJG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x464F950", Offset = "0x464EB50", VA = "0x18464F950")]
			internal bool GPCFIFNGOHA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x464F9C0", Offset = "0x464EBC0", VA = "0x18464F9C0")]
			internal void JGDJHOPIEML(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x464FB50", Offset = "0x464ED50", VA = "0x18464FB50")]
			[AsyncStateMachine(typeof(BENPMJLEHAB<>.ILHECGOBEOD.<<AddDynamicNodeGroupSettingV2>b__10>d))]
			internal void MIIMFIPNKPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x464F8F0", Offset = "0x464EAF0", VA = "0x18464F8F0")]
			internal bool GHCIMKDENMC()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private sealed class HDCDOOAFKAB
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005C")]
			private struct <<AddDynamicNodeGroupSettingV2>b__16>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				public HDCDOOAFKAB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011D")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011E")]
				private TaskAwaiter<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600017F")]
				[Cpp2IlInjected.Address(RVA = "0x3C19140", Offset = "0x3C18340", VA = "0x183C19140", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000180")]
				[Cpp2IlInjected.Address(RVA = "0x949E40", Offset = "0x949040", VA = "0x180949E40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public ILHECGOBEOD CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public Func<string> <>9__14;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public Action<string> <>9__15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public Action <>9__16;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public HDCDOOAFKAB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x44C1B90", Offset = "0x44C0D90", VA = "0x1844C1B90")]
			internal void JJGOPKACKAB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
			internal string NMBFNAOHMNG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x8F54A0", Offset = "0x8F46A0", VA = "0x1808F54A0")]
			internal void GBBFBODEGPP(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x44C1AF0", Offset = "0x44C0CF0", VA = "0x1844C1AF0")]
			[AsyncStateMachine(typeof(BENPMJLEHAB<>.HDCDOOAFKAB.<<AddDynamicNodeGroupSettingV2>b__16>d))]
			internal void AEEEAMDDEBH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		[CompilerGenerated]
		private sealed class HHLFHGGMOJL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public NFKPPHIGIKA nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public List<FPMIHIDLPCO> portMenu;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public BENPMJLEHAB<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public ANHNAJIBLBK<GIDHHIIAAHA> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public int portCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public Func<bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public HHLFHGGMOJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x44DD5F0", Offset = "0x44DC7F0", VA = "0x1844DD5F0")]
			internal bool LBGACFAKHKP()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		[CompilerGenerated]
		private sealed class GDKEKCNABFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public LIKJLNMKBIK port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public HHLFHGGMOJL CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public GDKEKCNABFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x43B3310", Offset = "0x43B2510", VA = "0x1843B3310")]
			internal void BBHMEBMNENB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x43B32C0", Offset = "0x43B24C0", VA = "0x1843B32C0")]
			internal bool AIJCHFJPJKO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x43B3480", Offset = "0x43B2680", VA = "0x1843B3480")]
			internal void KFOPFMGBFBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x43B3420", Offset = "0x43B2620", VA = "0x1843B3420")]
			internal bool FJKEIMKFDIM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class HNDNMAJOCLE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public FPMIHIDLPCO portControls;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public GDKEKCNABFE CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public HNDNMAJOCLE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x44EE550", Offset = "0x44ED750", VA = "0x1844EE550")]
			internal void BDOLNIABABH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000060")]
		[CompilerGenerated]
		private sealed class PIPOKMBAKEN
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000061")]
			private struct <<CreatePortItemV2>b__3>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000131")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000133")]
				public PIPOKMBAKEN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000134")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000135")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000136")]
				private TaskAwaiter<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000190")]
				[Cpp2IlInjected.Address(RVA = "0x3C1B170", Offset = "0x3C1A370", VA = "0x183C1B170", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000191")]
				[Cpp2IlInjected.Address(RVA = "0x949E40", Offset = "0x949040", VA = "0x180949E40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public List<object> allTypeObjects;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public BKCDGFOGEGO selectedType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public NFKPPHIGIKA nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public LIKJLNMKBIK port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public CBPIPCCOCCI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public PIPOKMBAKEN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x4F3C110", Offset = "0x4F3B310", VA = "0x184F3C110")]
			internal int NAPBFLNLFMI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x4F3BD30", Offset = "0x4F3AF30", VA = "0x184F3BD30")]
			internal void CLDGPPOJJDB(int val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x8FB0E0", Offset = "0x8FA2E0", VA = "0x1808FB0E0")]
			internal string GCDCCEOJHML()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x4F3C050", Offset = "0x4F3B250", VA = "0x184F3C050")]
			[AsyncStateMachine(typeof(BENPMJLEHAB<>.PIPOKMBAKEN.<<CreatePortItemV2>b__3>d))]
			internal void JHNNPBADJCM(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x4F3BF70", Offset = "0x4F3B170", VA = "0x184F3BF70")]
			internal bool HIJNGGINIOG(string text)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private readonly Dictionary<ANHNAJIBLBK<GIDHHIIAAHA>, bool> AOMHDIEFLAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly Dictionary<ANHNAJIBLBK<GIDHHIIAAHA>, bool> EMEGJJNHAAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly Dictionary<ANHNAJIBLBK<GIDHHIIAAHA>, bool> COOPNPMBKOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private Dictionary<ANHNAJIBLBK<GIDHHIIAAHA>, bool> EMEKANCKIEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private Dictionary<ANHNAJIBLBK<GIDHHIIAAHA>, bool> DFFKNBJNFDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private Dictionary<ANHNAJIBLBK<GIDHHIIAAHA>, bool> IHGCIMIPOKM;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool CDDCKJGLFPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "124")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected virtual bool OHNGIFJPOGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "128")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected virtual bool KILHBBCDOHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "129")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected virtual bool NGDAJPOOOMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override ANHNAJIBLBK<KJENBNHGDMG>? ADMIMLPKILN
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x5642DA0", Offset = "0x5641FA0", VA = "0x185642DA0", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override ANHNAJIBLBK<GIDHHIIAAHA>? BAIBCJGKKEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x5643070", Offset = "0x5642270", VA = "0x185643070", Slot = "121")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override IEnumerable<BDPEADCNJIF<COBLBOLGAKJ>>? MIABGOMOPFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x5642E60", Offset = "0x5642060", VA = "0x185642E60", Slot = "113")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x5642B80", Offset = "0x5641D80", VA = "0x185642B80")]
		public BENPMJLEHAB(LMPMALFKFKJ AAKAOKDAEPH, TNode NGCBLOEDNKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "131")]
		protected virtual bool DLFJNFINKMN(int LLOIGEGCOKO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "132")]
		protected virtual bool ILDOGJPACFL(int LLOIGEGCOKO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "133")]
		protected virtual bool FEIDJGLOHOO(int LLOIGEGCOKO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "134")]
		protected virtual void EFEHNDIBJJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x5641F80", Offset = "0x5641180", VA = "0x185641F80", Slot = "126")]
		public override bool MAPJNEMPDOI(ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x563EEA0", Offset = "0x563E0A0", VA = "0x18563EEA0", Slot = "102")]
		[AsyncStateMachine(typeof(BENPMJLEHAB<>.KOPMDILBEGD))]
		public override Task<EBOICGKKPAM<ANHNAJIBLBK<GIDHHIIAAHA>, LKEBDJCDIFL>> GACGGMGJKPH(string LMOANCJLHKC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x5642A70", Offset = "0x5641C70", VA = "0x185642A70", Slot = "103")]
		[AsyncStateMachine(typeof(BENPMJLEHAB<>.GOKPNJJIPOM))]
		public override Task<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> PJMOGAHAJNG(ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x563ECA0", Offset = "0x563DEA0", VA = "0x18563ECA0", Slot = "104")]
		public override void EHDIFFIDGNH(ANHNAJIBLBK<GIDHHIIAAHA> CPLNODNGKGB, ANHNAJIBLBK<GIDHHIIAAHA> MKMPLOHPJDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x563F050", Offset = "0x563E250", VA = "0x18563F050", Slot = "105")]
		public override IEnumerable<NAGMPGBKIGM> HLAIHECDPID()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x563E260", Offset = "0x563D460", VA = "0x18563E260")]
		[AsyncStateMachine(typeof(BENPMJLEHAB<>.AMAKJOFCKLD))]
		private Task<EBOICGKKPAM<BFCNMIIHFAN, LKEBDJCDIFL>> BFCJJHOHFML()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "135")]
		protected virtual bool EIJGMJNOJFC(ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "136")]
		protected virtual bool OGLHJOJIKDJ(ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "137")]
		protected virtual bool COCNLJPCJKF(ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "138")]
		protected virtual bool AEAIJFNKGMO(ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "139")]
		protected virtual bool PLCGFKCMBKP(ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO, int AICPOKMPBMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "140")]
		protected virtual bool COFCBKHOGEP(ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO, int AICPOKMPBMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "141")]
		protected virtual bool KHMOELPGJJM(ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO, int JMGEJBIPMNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "142")]
		protected virtual bool DOAIOGFFJLD(ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO, int JMGEJBIPMNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "143")]
		protected virtual bool NNGJIDHLBIA(ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO, int JKBGDBBPBCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "144")]
		protected virtual bool PEIEHFJEHKJ(ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO, int KPAHGANODGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x563F2C0", Offset = "0x563E4C0", VA = "0x18563F2C0", Slot = "145")]
		protected virtual List<BKCDGFOGEGO> IPCDIGOAOOP(ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "146")]
		protected virtual void BDEJDLINFHF(MMBCHPEGPFF FNGALEILPLM, ABJEMCCJPAH DIJLCDOPFJK, NFKPPHIGIKA CEHLDMDGJEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x5642020", Offset = "0x5641220", VA = "0x185642020", Slot = "122")]
		protected override void OOGPOIIHFKH(MMBCHPEGPFF FNGALEILPLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5640660", Offset = "0x563F860", VA = "0x185640660")]
		private ABJEMCCJPAH KFHJGODGAAP(MMBCHPEGPFF FNGALEILPLM, NFKPPHIGIKA CEHLDMDGJEP, ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x563F540", Offset = "0x563E740", VA = "0x18563F540")]
		private List<FPMIHIDLPCO> JBJCFGGJCLP(MMBCHPEGPFF FNGALEILPLM, NFKPPHIGIKA CEHLDMDGJEP, ABJEMCCJPAH AGMBILFCLIN, bool CMFAFHOHLCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x563E360", Offset = "0x563D560", VA = "0x18563E360")]
		private List<FPMIHIDLPCO> CCFFLKOODBB(MMBCHPEGPFF FNGALEILPLM, NFKPPHIGIKA CEHLDMDGJEP, LIKJLNMKBIK JPKKDDIAAIN, bool CMFAFHOHLCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5641D90", Offset = "0x5640F90", VA = "0x185641D90")]
		private BKCDGFOGEGO LJNHAICAIEF(List<BKCDGFOGEGO> FDOKJNLABPI, LIKJLNMKBIK JPKKDDIAAIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x563EFC0", Offset = "0x563E1C0", VA = "0x18563EFC0")]
		[CompilerGenerated]
		private NAGMPGBKIGM HHIOPHODJMK(HGHEIBELGCA KPGFBDAMCDA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class EMEJELBLADN : PHHDBLBBBNE<EIMMDGDMCCF>
	{
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		[CompilerGenerated]
		private sealed class JJFNINBJJJJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public EMEJELBLADN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public CBPIPCCOCCI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public JJFNINBJJJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x24D4D40", Offset = "0x24D3F40", VA = "0x1824D4D40")]
			internal int CNNDFCIODJA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x24D4D90", Offset = "0x24D3F90", VA = "0x1824D4D90")]
			internal void OHJIDAACGDJ(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override NodeVisualizationKey CHCLNDNNNEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xED8260", Offset = "0xED7460", VA = "0x180ED8260", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x24D0020", Offset = "0x24CF220", VA = "0x1824D0020")]
		public EMEJELBLADN(LMPMALFKFKJ AAKAOKDAEPH, EIMMDGDMCCF NGCBLOEDNKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x24CFE60", Offset = "0x24CF060", VA = "0x1824CFE60", Slot = "122")]
		protected override void OOGPOIIHFKH(MMBCHPEGPFF FNGALEILPLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public sealed class GOKCNEJGNKB : DCOHGAPPALO<IOILHBDJFEC>
	{
		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class POCBBPMCKFN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public GOKCNEJGNKB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public CBPIPCCOCCI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public POCBBPMCKFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x24DF8A0", Offset = "0x24DEAA0", VA = "0x1824DF8A0")]
			internal int NDAPLDKBDJO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x24DF800", Offset = "0x24DEA00", VA = "0x1824DF800")]
			internal void KCAIGKLOHLF(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x24D1AB0", Offset = "0x24D0CB0", VA = "0x1824D1AB0")]
		public GOKCNEJGNKB(LMPMALFKFKJ AAKAOKDAEPH, IOILHBDJFEC CMFHMEJHOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x24D1870", Offset = "0x24D0A70", VA = "0x1824D1870", Slot = "128")]
		protected override void MGLGHHPEHGC(MMBCHPEGPFF FNGALEILPLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	private sealed class MEOCNKCFAKH : PHHDBLBBBNE<KFIIBKEDFFC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey CHCLNDNNNEA
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xBFCD80", Offset = "0xBFBF80", VA = "0x180BFCD80", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x24DCCF0", Offset = "0x24DBEF0", VA = "0x1824DCCF0")]
		public MEOCNKCFAKH(LMPMALFKFKJ AAKAOKDAEPH, KFIIBKEDFFC NGCBLOEDNKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "122")]
		protected override void OOGPOIIHFKH(MMBCHPEGPFF FNGALEILPLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public sealed class LALPNGBGDIJ : PHHDBLBBBNE<HHFENABCEFM>
	{
		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class AHHPKFLBPEB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public LALPNGBGDIJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public MMBCHPEGPFF configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public Func<string> <>9__224;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public Action<string> <>9__225;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Func<int> <>9__228;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Action<int> <>9__229;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Func<bool> <>9__230;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Func<bool> <>9__231;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Func<bool> <>9__232;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Func<float> <>9__233;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public Action<float> <>9__234;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Func<bool> <>9__235;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public Func<bool> <>9__236;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public Func<bool> <>9__237;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public Func<string> <>9__238;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public Action<string> <>9__239;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public AHHPKFLBPEB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x24C2DB0", Offset = "0x24C1FB0", VA = "0x1824C2DB0")]
			internal bool CNNDFCIODJA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x24CC370", Offset = "0x24CB570", VA = "0x1824CC370")]
			internal void OHJIDAACGDJ(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x24C39F0", Offset = "0x24C2BF0", VA = "0x1824C39F0")]
			internal bool FHEGOLGOMJG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x24C33F0", Offset = "0x24C25F0", VA = "0x1824C33F0")]
			internal bool DNFOIEHJGKL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x24CAE30", Offset = "0x24CA030", VA = "0x1824CAE30")]
			internal void JLCENCAMMIH(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x24CAB50", Offset = "0x24C9D50", VA = "0x1824CAB50")]
			internal bool JALLPEKDBGL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x24CA910", Offset = "0x24C9B10", VA = "0x1824CA910")]
			internal bool ILMCEIKMBEC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x24C2900", Offset = "0x24C1B00", VA = "0x1824C2900")]
			internal void BMMGFKFOLGP(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x24CC250", Offset = "0x24CB450", VA = "0x1824CC250")]
			internal bool OEBFFAOBKHP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x24C3A90", Offset = "0x24C2C90", VA = "0x1824C3A90")]
			internal bool FOKGNNGDODD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x24CA960", Offset = "0x24C9B60", VA = "0x1824CA960")]
			internal void ILNALCAJDDC(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x24C2390", Offset = "0x24C1590", VA = "0x1824C2390")]
			internal bool ALAIGKGJDDA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x24CAF30", Offset = "0x24CA130", VA = "0x1824CAF30")]
			internal bool JMIEABIGNCO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x24C2A20", Offset = "0x24C1C20", VA = "0x1824C2A20")]
			internal bool BONBEMMCKOE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x24C3C40", Offset = "0x24C2E40", VA = "0x1824C3C40")]
			internal bool GCILJKFKAHL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x24C2F90", Offset = "0x24C2190", VA = "0x1824C2F90")]
			internal bool DGALCIKBFNL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x24C20F0", Offset = "0x24C12F0", VA = "0x1824C20F0")]
			internal bool ABCPJKCGEGB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x24CB4C0", Offset = "0x24CA6C0", VA = "0x1824CB4C0")]
			internal bool KMNDBJJMABN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x24C2190", Offset = "0x24C1390", VA = "0x1824C2190")]
			internal bool AGHLJEFKHJE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x24CAA10", Offset = "0x24C9C10", VA = "0x1824CAA10")]
			internal bool INOOAIKGOIG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x24C28A0", Offset = "0x24C1AA0", VA = "0x1824C28A0")]
			internal void BKGEDGPGEDK(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x24C3800", Offset = "0x24C2A00", VA = "0x1824C3800")]
			internal bool FDFMPBEBIHM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x24CA780", Offset = "0x24C9980", VA = "0x1824CA780")]
			internal bool IGLFGHDDGLM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x24CB5B0", Offset = "0x24CA7B0", VA = "0x1824CB5B0")]
			internal bool LAAEJNEKPKJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x24C21E0", Offset = "0x24C13E0", VA = "0x1824C21E0")]
			internal bool AHIOAHOGLAB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x24CB380", Offset = "0x24CA580", VA = "0x1824CB380")]
			internal bool KLHAFHGCBAO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x24C4400", Offset = "0x24C3600", VA = "0x1824C4400")]
			internal bool HNMPEKCNDNL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x24C20A0", Offset = "0x24C12A0", VA = "0x1824C20A0")]
			internal bool AAOPPNIDOOO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x24C3A40", Offset = "0x24C2C40", VA = "0x1824C3A40")]
			internal bool FMLOKKJCJOP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x24C2840", Offset = "0x24C1A40", VA = "0x1824C2840")]
			internal void BJLFPFEPMOI(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x24CAA60", Offset = "0x24C9C60", VA = "0x1824CAA60")]
			internal bool IOKEEIBIICK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x24CAE90", Offset = "0x24CA090", VA = "0x1824CAE90")]
			internal bool JLCPNOGGLLB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x24CB6A0", Offset = "0x24CA8A0", VA = "0x1824CB6A0")]
			internal void LFDDHPDOLKE(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x24CB940", Offset = "0x24CAB40", VA = "0x1824CB940")]
			internal bool MANLJKBCNGC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x24C3E40", Offset = "0x24C3040", VA = "0x1824C3E40")]
			internal bool GFFFILOBDDM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x24CB9E0", Offset = "0x24CABE0", VA = "0x1824CB9E0")]
			internal void MFFNOLNFPIH(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x24C45D0", Offset = "0x24C37D0", VA = "0x1824C45D0")]
			internal List<FPMIHIDLPCO> IELOMMKAOBN(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x24CC6D0", Offset = "0x24CB8D0", VA = "0x1824CC6D0")]
			internal bool PCCDAJPADMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x24C2450", Offset = "0x24C1650", VA = "0x1824C2450")]
			internal int AMGNNOKGBGC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x24CCD50", Offset = "0x24CBF50", VA = "0x1824CCD50")]
			internal void PLKFJAAHLKP(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x24CB470", Offset = "0x24CA670", VA = "0x1824CB470")]
			internal bool KMEBFNPFBFB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x24CB240", Offset = "0x24CA440", VA = "0x1824CB240")]
			internal bool KHEOCDKLIJN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x24CCBD0", Offset = "0x24CBDD0", VA = "0x1824CCBD0")]
			internal bool PIKIABDKGGF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x24C24A0", Offset = "0x24C16A0", VA = "0x1824C24A0")]
			internal int AMKFGABGAAJ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x24C38A0", Offset = "0x24C2AA0", VA = "0x1824C38A0")]
			internal void FEFPMPNDKHF(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x24CC070", Offset = "0x24CB270", VA = "0x1824CC070")]
			internal bool NJNCLLMANPC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x24CC770", Offset = "0x24CB970", VA = "0x1824CC770")]
			internal bool PGMPOJNENLJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x24C4160", Offset = "0x24C3360", VA = "0x1824C4160")]
			internal bool HAIEHDGEEAJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x24CC680", Offset = "0x24CB880", VA = "0x1824CC680")]
			internal bool PBJGHBCJJLJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x24C27F0", Offset = "0x24C19F0", VA = "0x1824C27F0")]
			internal bool BJKNDDBCFIK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x24C3EE0", Offset = "0x24C30E0", VA = "0x1824C3EE0")]
			internal bool GKGBODFAHAG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x24C3620", Offset = "0x24C2820", VA = "0x1824C3620")]
			internal string EFLDPDJGIFK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x24CC300", Offset = "0x24CB500", VA = "0x1824CC300")]
			internal void OGDIMEOLAMJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x24C3900", Offset = "0x24C2B00", VA = "0x1824C3900")]
			internal int FFHCCMIGDAM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x24CB0A0", Offset = "0x24CA2A0", VA = "0x1824CB0A0")]
			internal void KBLFHLBAGOD(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x24C2E00", Offset = "0x24C2000", VA = "0x1824C2E00")]
			internal bool CPEFNBOOBII()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x24C3B40", Offset = "0x24C2D40", VA = "0x1824C3B40")]
			internal bool GANIOMOHEIG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x24CB1F0", Offset = "0x24CA3F0", VA = "0x1824CB1F0")]
			internal bool KFACNCMMHIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x24CAC00", Offset = "0x24C9E00", VA = "0x1824CAC00")]
			internal float JFALKLDGDAI()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x24C3BE0", Offset = "0x24C2DE0", VA = "0x1824C3BE0")]
			internal void GBMLFENPJGE(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x24C4510", Offset = "0x24C3710", VA = "0x1824C4510")]
			internal bool IALAGAIALMB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x24CCCB0", Offset = "0x24CBEB0", VA = "0x1824CCCB0")]
			internal bool PKCPMJCOHCO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x24C2BB0", Offset = "0x24C1DB0", VA = "0x1824C2BB0")]
			internal bool CDGFEDCBDPO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x24C2CC0", Offset = "0x24C1EC0", VA = "0x1824C2CC0")]
			internal bool CFLIJCMIEBP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x24CAC50", Offset = "0x24C9E50", VA = "0x1824CAC50")]
			internal bool JFGMADCOBJF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x24CA8C0", Offset = "0x24C9AC0", VA = "0x1824CA8C0")]
			internal bool IKKKFOKNPKC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x24CC7C0", Offset = "0x24CB9C0", VA = "0x1824CC7C0")]
			internal void PHMPFGGEHDL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x24CC1B0", Offset = "0x24CB3B0", VA = "0x1824CC1B0")]
			internal string OBFNDLDJAJJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x24CAFE0", Offset = "0x24CA1E0", VA = "0x1824CAFE0")]
			internal void KAEFNBKOJFB(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x24C3850", Offset = "0x24C2A50", VA = "0x1824C3850")]
			internal bool FEBIIEDFIEC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x24C36C0", Offset = "0x24C28C0", VA = "0x1824C36C0")]
			internal bool EMAFGBBPNMI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x24C22D0", Offset = "0x24C14D0", VA = "0x1824C22D0")]
			internal bool AKANLHOPCMK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x24C3120", Offset = "0x24C2320", VA = "0x1824C3120")]
			internal void DKOECCHHPMF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x24CADE0", Offset = "0x24C9FE0", VA = "0x1824CADE0")]
			internal bool JJHIHPKALBM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x24CACA0", Offset = "0x24C9EA0", VA = "0x1824CACA0")]
			internal bool JFHLNCBPPHH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x24C2C00", Offset = "0x24C1E00", VA = "0x1824C2C00")]
			internal bool CELMDLPGMJE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x24C29D0", Offset = "0x24C1BD0", VA = "0x1824C29D0")]
			internal bool BNNKEJKIKGE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x24CB8E0", Offset = "0x24CAAE0", VA = "0x1824CB8E0")]
			internal void LPMEGNMBBHJ(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x24C2AC0", Offset = "0x24C1CC0", VA = "0x1824C2AC0")]
			internal bool BPFMPEIGEBG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x24C2280", Offset = "0x24C1480", VA = "0x1824C2280")]
			internal bool AJKLBMBBHOE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x24C43B0", Offset = "0x24C35B0", VA = "0x1824C43B0")]
			internal bool HNMGLMKJCAN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x24CCB80", Offset = "0x24CBD80", VA = "0x1824CCB80")]
			internal bool PHPPKMPIJGA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x24C2740", Offset = "0x24C1940", VA = "0x1824C2740")]
			internal void BFIPLPJEDOB(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x24CBA40", Offset = "0x24CAC40", VA = "0x1824CBA40")]
			internal bool MGMIBHNIGIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x24CCDB0", Offset = "0x24CBFB0", VA = "0x1824CCDB0")]
			internal bool PMALOOIDHFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x24C2A70", Offset = "0x24C1C70", VA = "0x1824C2A70")]
			internal bool BPCJJMIGKCF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x24CCD00", Offset = "0x24CBF00", VA = "0x1824CCD00")]
			internal bool PLALODMJHGN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x24CBC40", Offset = "0x24CAE40", VA = "0x1824CBC40")]
			internal object MLBHEJFDJJE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x24CCC20", Offset = "0x24CBE20", VA = "0x1824CCC20")]
			internal void PJNFHMJDPIG(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x24CAEE0", Offset = "0x24CA0E0", VA = "0x1824CAEE0")]
			internal bool JMCKAFECCGL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x24CC420", Offset = "0x24CB620", VA = "0x1824CC420")]
			internal bool OJHLGPGEGBE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x24CA820", Offset = "0x24C9A20", VA = "0x1824CA820")]
			internal int IKIDGCOBHGK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x24CB100", Offset = "0x24CA300", VA = "0x1824CB100")]
			internal void KCCCHLJNAHE(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x24CB990", Offset = "0x24CAB90", VA = "0x1824CB990")]
			internal bool MBKPMDJEJFN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x24C3580", Offset = "0x24C2780", VA = "0x1824C3580")]
			internal bool EEBCGCJNDPO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x24CC0C0", Offset = "0x24CB2C0", VA = "0x1824CC0C0")]
			internal int NJPCMBMIEEO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x24CABA0", Offset = "0x24C9DA0", VA = "0x1824CABA0")]
			internal void JCAGCIGALMF(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x24CAD40", Offset = "0x24C9F40", VA = "0x1824CAD40")]
			internal bool JIOJIMAFGJN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x24C3C90", Offset = "0x24C2E90", VA = "0x1824C3C90")]
			internal bool GCJHMFCACPC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x24C2B60", Offset = "0x24C1D60", VA = "0x1824C2B60")]
			internal bool CDAMDLMFBOG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x24C2F40", Offset = "0x24C2140", VA = "0x1824C2F40")]
			internal int DELBGBKHOOE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x24C3F30", Offset = "0x24C3130", VA = "0x1824C3F30")]
			internal void GLCGLGAMCIC(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x24C3760", Offset = "0x24C2960", VA = "0x1824C3760")]
			internal bool ENKDJMFABLP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x24C3670", Offset = "0x24C2870", VA = "0x1824C3670")]
			internal bool ELDHFOFFEEJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x24CA730", Offset = "0x24C9930", VA = "0x1824CA730")]
			internal bool IGBLMLDPCLM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x24C4560", Offset = "0x24C3760", VA = "0x1824C4560")]
			internal object IEEPOBFFGIC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x24CB160", Offset = "0x24CA360", VA = "0x1824CB160")]
			internal void KCEDKCLFANP(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x24CC630", Offset = "0x24CB830", VA = "0x1824CC630")]
			internal bool PAMEGDFDGPC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x24C35D0", Offset = "0x24C27D0", VA = "0x1824C35D0")]
			internal bool EFJPHHHJDKD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x24C2960", Offset = "0x24C1B60", VA = "0x1824C2960")]
			internal object BNDHMDIHIAB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x24C3090", Offset = "0x24C2290", VA = "0x1824C3090")]
			internal void DILHAAOHDFE(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x24CB420", Offset = "0x24CA620", VA = "0x1824CB420")]
			internal bool KMCMHMADHLG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x24CA870", Offset = "0x24C9A70", VA = "0x1824CA870")]
			internal int IKIHIJBGKFL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x24C2FE0", Offset = "0x24C21E0", VA = "0x1824C2FE0")]
			internal void DGPBGEFKCDN(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x24CC3D0", Offset = "0x24CB5D0", VA = "0x1824CC3D0")]
			internal bool OHMBJACKJFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x24CBDA0", Offset = "0x24CAFA0", VA = "0x1824CBDA0")]
			internal bool NAICOMCDMFD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x24CBEE0", Offset = "0x24CB0E0", VA = "0x1824CBEE0")]
			internal bool NFMFENKBDDO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x24C3950", Offset = "0x24C2B50", VA = "0x1824C3950")]
			internal int FFHJOMJCHPL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x24CC2A0", Offset = "0x24CB4A0", VA = "0x1824CC2A0")]
			internal void OFCNAEFHKBK(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x24CB650", Offset = "0x24CA850", VA = "0x1824CB650")]
			internal bool LCFFMJPACIO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x24CA7D0", Offset = "0x24C99D0", VA = "0x1824CA7D0")]
			internal bool IHPODCKFHGF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x24CBA90", Offset = "0x24CAC90", VA = "0x1824CBA90")]
			internal bool MHCBLKIHDDM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x24C41B0", Offset = "0x24C33B0", VA = "0x1824C41B0")]
			internal float HCFKELIPNEB()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x24C26E0", Offset = "0x24C18E0", VA = "0x1824C26E0")]
			internal void BCJFNAIOMBG(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x24C34E0", Offset = "0x24C26E0", VA = "0x1824C34E0")]
			internal bool EAHLDCMDHII()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x24CB560", Offset = "0x24CA760", VA = "0x1824CB560")]
			internal bool KPMCNELDKAB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x24CC160", Offset = "0x24CB360", VA = "0x1824CC160")]
			internal bool OAOFMGBGCMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x24CB700", Offset = "0x24CA900", VA = "0x1824CB700")]
			internal float LIBGHHFMHJG()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x24C3AE0", Offset = "0x24C2CE0", VA = "0x1824C3AE0")]
			internal void GAEBKBPNHNF(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x24C3B90", Offset = "0x24C2D90", VA = "0x1824C3B90")]
			internal bool GBFBDIOAILO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x24CB7A0", Offset = "0x24CA9A0", VA = "0x1824CB7A0")]
			internal bool LLCPEPNDIMH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x24CB840", Offset = "0x24CAA40", VA = "0x1824CB840")]
			internal string LNBHEGOEPJD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x24C44A0", Offset = "0x24C36A0", VA = "0x1824C44A0")]
			internal void IADHDECHMCG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x24C4310", Offset = "0x24C3510", VA = "0x1824C4310")]
			internal bool HGLPPFAAIPN(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x24CB890", Offset = "0x24CAA90", VA = "0x1824CB890")]
			internal bool LPBOAEDGOHB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x24C3710", Offset = "0x24C2910", VA = "0x1824C3710")]
			internal bool EMIFIOGMGAJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x24CAD90", Offset = "0x24C9F90", VA = "0x1824CAD90")]
			internal bool JIOLGGPEMIF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x24C25D0", Offset = "0x24C17D0", VA = "0x1824C25D0")]
			internal string APOIDMGNMPE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x24C4030", Offset = "0x24C3230", VA = "0x1824C4030")]
			internal void GNEHMMGOCHE(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x24C2EF0", Offset = "0x24C20F0", VA = "0x1824C2EF0")]
			internal bool DCKIAHHLLMJ(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x24CB2E0", Offset = "0x24CA4E0", VA = "0x1824CB2E0")]
			internal bool KKCLIHMLEFG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x24C40A0", Offset = "0x24C32A0", VA = "0x1824C40A0")]
			internal bool GNOAMBGFBEG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x24C39A0", Offset = "0x24C2BA0", VA = "0x1824C39A0")]
			internal bool FGLLEMDLDCD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x24CC110", Offset = "0x24CB310", VA = "0x1824CC110")]
			internal string NPHOIEFBLPC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x24CBBD0", Offset = "0x24CADD0", VA = "0x1824CBBD0")]
			internal void MKNPOCABKCE(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x24C3CE0", Offset = "0x24C2EE0", VA = "0x1824C3CE0")]
			internal bool GCLLOAAKDKK(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x24CA6E0", Offset = "0x24C98E0", VA = "0x1824CA6E0")]
			internal bool IFLNECOGLJI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x24C3530", Offset = "0x24C2730", VA = "0x1824C3530")]
			internal bool EDBOFFEFNMC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x24CB7F0", Offset = "0x24CA9F0", VA = "0x1824CB7F0")]
			internal bool LMJHMIFDBDH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x24C2140", Offset = "0x24C1340", VA = "0x1824C2140")]
			internal string ADHGFPLHGAC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x24C40F0", Offset = "0x24C32F0", VA = "0x1824C40F0")]
			internal void HAAECLFEEFN(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x24CBE90", Offset = "0x24CB090", VA = "0x1824CBE90")]
			internal bool NFLOHEJPIOF(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x24C3FE0", Offset = "0x24C31E0", VA = "0x1824C3FE0")]
			internal bool GMMIDCHDFFP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x24CBAE0", Offset = "0x24CACE0", VA = "0x1824CBAE0")]
			internal bool MHHNPFMDCGI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x24CBE40", Offset = "0x24CB040", VA = "0x1824CBE40")]
			internal bool NEOBKPPIDNE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x24CBFD0", Offset = "0x24CB1D0", VA = "0x1824CBFD0")]
			internal string NJBOKHDPNNG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x24C2560", Offset = "0x24C1760", VA = "0x1824C2560")]
			internal void AOGPLCIIBNO(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x24C3D30", Offset = "0x24C2F30", VA = "0x1824C3D30")]
			internal bool GEJBEBIKOBF(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x24C3D80", Offset = "0x24C2F80", VA = "0x1824C3D80")]
			internal bool GENFLHPCKLA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x24CC590", Offset = "0x24CB790", VA = "0x1824CC590")]
			internal bool OPGDOONDKBD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x24CBF80", Offset = "0x24CB180", VA = "0x1824CBF80")]
			internal bool NGHFHGMNHNF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x24CC020", Offset = "0x24CB220", VA = "0x1824CC020")]
			internal string NJMIADCLJKO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x24C3DD0", Offset = "0x24C2FD0", VA = "0x1824C3DD0")]
			internal void GENFOOLIFAD(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x24C42C0", Offset = "0x24C34C0", VA = "0x1824C42C0")]
			internal bool HGEJOLNDNDH(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x24C4270", Offset = "0x24C3470", VA = "0x1824C4270")]
			internal bool HGCEBJOKBKJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x24C4360", Offset = "0x24C3560", VA = "0x1824C4360")]
			internal bool HJBJMCOEAMO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x24CB750", Offset = "0x24CA950", VA = "0x1824CB750")]
			internal bool LKCNEAKEAHP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x24CBDF0", Offset = "0x24CAFF0", VA = "0x1824CBDF0")]
			internal string NEEIPKFLOCJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x24C24F0", Offset = "0x24C16F0", VA = "0x1824C24F0")]
			internal void ANDMJOGDCKL(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x24CBCB0", Offset = "0x24CAEB0", VA = "0x1824CBCB0")]
			internal bool MLIJEEKEIBF(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x24CBD50", Offset = "0x24CAF50", VA = "0x1824CBD50")]
			internal bool MONDBAIFIFE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x24CCE50", Offset = "0x24CC050", VA = "0x1824CCE50")]
			internal bool PMLILLNCJLA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x24CB600", Offset = "0x24CA800", VA = "0x1824CB600")]
			internal bool LAIHPJOGOMD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x24C2B10", Offset = "0x24C1D10", VA = "0x1824C2B10")]
			internal string CBCCKJEAGAG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x24C4200", Offset = "0x24C3400", VA = "0x1824C4200")]
			internal void HDNCHMEHHBK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x24CC5E0", Offset = "0x24CB7E0", VA = "0x1824CC5E0")]
			internal bool OPPGGCHMDCB(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x24CAB00", Offset = "0x24C9D00", VA = "0x1824CAB00")]
			internal bool IOOJHAFMEHB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x24C3E90", Offset = "0x24C3090", VA = "0x1824C3E90")]
			internal bool GHNKOACHNHL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x24CC540", Offset = "0x24CB740", VA = "0x1824CC540")]
			internal bool OOEDBNLCJFO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x24C4450", Offset = "0x24C3650", VA = "0x1824C4450")]
			internal string HODJNEAFLLP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x24C2320", Offset = "0x24C1520", VA = "0x1824C2320")]
			internal void AKJIMNGEBOL(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x24CA9C0", Offset = "0x24C9BC0", VA = "0x1824CA9C0")]
			internal bool INJKGPKIOPN(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x24C27A0", Offset = "0x24C19A0", VA = "0x1824C27A0")]
			internal bool BFNAJDKIKGK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x24CBB80", Offset = "0x24CAD80", VA = "0x1824CBB80")]
			internal bool MJHPCOBOCHF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x24C2230", Offset = "0x24C1430", VA = "0x1824C2230")]
			internal bool AIMLODIBDMO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x24CB290", Offset = "0x24CA490", VA = "0x1824CB290")]
			internal string KJAALBJPNBH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x24C23E0", Offset = "0x24C15E0", VA = "0x1824C23E0")]
			internal void AMENAMIBDHG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x24C2D10", Offset = "0x24C1F10", VA = "0x1824C2D10")]
			internal bool CJOCMAEDBIP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x24C3490", Offset = "0x24C2690", VA = "0x1824C3490")]
			internal bool DOKMNNGILBJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x24CBF30", Offset = "0x24CB130", VA = "0x1824CBF30")]
			internal bool NGCEMLEAAAP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x24CBD00", Offset = "0x24CAF00", VA = "0x1824CBD00")]
			internal string MMKMAOEPFAN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x24C2670", Offset = "0x24C1870", VA = "0x1824C2670")]
			internal void BCBJFMEDDGG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x24CC720", Offset = "0x24CB920", VA = "0x1824CC720")]
			internal bool PFEPELMCCPH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x24CB510", Offset = "0x24CA710", VA = "0x1824CB510")]
			internal bool KNLNGEJHJCA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x24C37B0", Offset = "0x24C29B0", VA = "0x1824C37B0")]
			internal bool EOMNHJNKIOJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x24CB3D0", Offset = "0x24CA5D0", VA = "0x1824CB3D0")]
			internal string KLJILEOELJB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x24CC4D0", Offset = "0x24CB6D0", VA = "0x1824CC4D0")]
			internal void OKLBCFFFNPE(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x24CC200", Offset = "0x24CB400", VA = "0x1824CC200")]
			internal bool OBIJMDMAPGL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x24C3F90", Offset = "0x24C3190", VA = "0x1824C3F90")]
			internal bool GLFGCPFJPHD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x24CCE00", Offset = "0x24CC000", VA = "0x1824CCE00")]
			internal bool PMKOLLJKOOC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x24CB330", Offset = "0x24CA530", VA = "0x1824CB330")]
			internal string KKGGMOAEHMD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x24C2C50", Offset = "0x24C1E50", VA = "0x1824C2C50")]
			internal void CEPNGCPKDAK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x24CAAB0", Offset = "0x24C9CB0", VA = "0x1824CAAB0")]
			internal bool IOKMFJEFGFO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x24CACF0", Offset = "0x24C9EF0", VA = "0x1824CACF0")]
			internal bool JHHNGAKKKCP(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x24CB050", Offset = "0x24CA250", VA = "0x1824CB050")]
			internal float KAHONCLJKJJ()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x24CC470", Offset = "0x24CB670", VA = "0x1824CC470")]
			internal void OJILHJLFEPN(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x24C2E50", Offset = "0x24C2050", VA = "0x1824C2E50")]
			internal bool DBBJHKHHJOH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x24C2EA0", Offset = "0x24C20A0", VA = "0x1824C2EA0")]
			internal bool DCJBDBIPLII()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x24CBB30", Offset = "0x24CAD30", VA = "0x1824CBB30")]
			internal bool MJHEMJEBDAD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x24C2D60", Offset = "0x24C1F60", VA = "0x1824C2D60")]
			internal int CMNINBIFNID()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x24CAF80", Offset = "0x24CA180", VA = "0x1824CAF80")]
			internal void JPPEELFAPAN(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x24C2620", Offset = "0x24C1820", VA = "0x1824C2620")]
			internal bool BCAMPCEEMLO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x24C3440", Offset = "0x24C2640", VA = "0x1824C3440")]
			internal bool DNNMBIEJBBP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x24C3040", Offset = "0x24C2240", VA = "0x1824C3040")]
			internal bool DGPHNHHIEAI()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class MMIKMLPKHDG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public string secondaryLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public AHHPKFLBPEB CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public MMIKMLPKHDG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x24DD050", Offset = "0x24DC250", VA = "0x1824DD050")]
			internal void LILJNMMOLPN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class KHDJIFABNIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public char[] swizzleChars;

			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public KHDJIFABNIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x24EFD20", Offset = "0x24EEF20", VA = "0x1824EFD20")]
			internal bool NHHPOEMPJDB(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private readonly JNAMLBBBLIH EIABKFPGMJP;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x24D8280", Offset = "0x24D7480", VA = "0x1824D8280")]
		public LALPNGBGDIJ(LMPMALFKFKJ AAKAOKDAEPH, HHFENABCEFM NGCBLOEDNKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x24D64B0", Offset = "0x24D56B0", VA = "0x1824D64B0", Slot = "122")]
		protected override void OOGPOIIHFKH(MMBCHPEGPFF FNGALEILPLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public sealed class EDFLEHKOMDL : PHHDBLBBBNE<AJFLGBIPPJD>
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private sealed class NNIIKHOGLDO
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006E")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400017B")]
				public NNIIKHOGLDO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400017C")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				private TaskAwaiter<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002AE")]
				[Cpp2IlInjected.Address(RVA = "0x24FBAB0", Offset = "0x24FACB0", VA = "0x1824FBAB0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002AF")]
				[Cpp2IlInjected.Address(RVA = "0x949E40", Offset = "0x949040", VA = "0x180949E40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public EDFLEHKOMDL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public CBPIPCCOCCI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public NNIIKHOGLDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x24F90C0", Offset = "0x24F82C0", VA = "0x1824F90C0")]
			internal string CNNDFCIODJA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x24F91A0", Offset = "0x24F83A0", VA = "0x1824F91A0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void OHJIDAACGDJ(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x24F9070", Offset = "0x24F8270", VA = "0x1824F9070")]
			internal int CHECEAOKJII()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x24F9110", Offset = "0x24F8310", VA = "0x1824F9110")]
			internal void FGLIKLLHBNH(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override NodeVisualizationKey CHCLNDNNNEA
		{
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0xED8260", Offset = "0xED7460", VA = "0x180ED8260", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x24E4AF0", Offset = "0x24E3CF0", VA = "0x1824E4AF0")]
		public EDFLEHKOMDL(LMPMALFKFKJ AAKAOKDAEPH, AJFLGBIPPJD CMFHMEJHOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x24E47A0", Offset = "0x24E39A0", VA = "0x1824E47A0", Slot = "122")]
		protected override void OOGPOIIHFKH(MMBCHPEGPFF FNGALEILPLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class HPFKCCAKIBK : PHHDBLBBBNE<NOAGEKEDBBB>
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class MJDLMDPHAGF
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000071")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000181")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000182")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000183")]
				public MJDLMDPHAGF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000184")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000185")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				private TaskAwaiter<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002C3")]
				[Cpp2IlInjected.Address(RVA = "0x24FB770", Offset = "0x24FA970", VA = "0x1824FB770", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C4")]
				[Cpp2IlInjected.Address(RVA = "0x949E40", Offset = "0x949040", VA = "0x180949E40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000072")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000188")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000189")]
				public MJDLMDPHAGF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400018A")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400018B")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400018C")]
				private TaskAwaiter<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002C5")]
				[Cpp2IlInjected.Address(RVA = "0x24FBDC0", Offset = "0x24FAFC0", VA = "0x1824FBDC0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C6")]
				[Cpp2IlInjected.Address(RVA = "0x949E40", Offset = "0x949040", VA = "0x180949E40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public HPFKCCAKIBK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public CBPIPCCOCCI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public MJDLMDPHAGF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x24F81B0", Offset = "0x24F73B0", VA = "0x1824F81B0")]
			internal string CNNDFCIODJA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x24F85B0", Offset = "0x24F77B0", VA = "0x1824F85B0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void OHJIDAACGDJ(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x24F8110", Offset = "0x24F7310", VA = "0x1824F8110")]
			internal int CHECEAOKJII()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x24F82D0", Offset = "0x24F74D0", VA = "0x1824F82D0")]
			internal void FGLIKLLHBNH(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x24F8360", Offset = "0x24F7560", VA = "0x1824F8360")]
			internal string FHEGOLGOMJG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x24F8200", Offset = "0x24F7400", VA = "0x1824F8200")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void DNFOIEHJGKL(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x24F84F0", Offset = "0x24F76F0", VA = "0x1824F84F0")]
			internal bool JLCENCAMMIH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0x24F8680", Offset = "0x24F7880", VA = "0x1824F8680")]
			internal void PHECLJCFGBO(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x24F8160", Offset = "0x24F7360", VA = "0x1824F8160")]
			internal bool CKMDLJNDAHA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x24F8460", Offset = "0x24F7660", VA = "0x1824F8460")]
			internal void JALLPEKDBGL(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x24F8410", Offset = "0x24F7610", VA = "0x1824F8410")]
			internal float ILMCEIKMBEC()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x24F8080", Offset = "0x24F7280", VA = "0x1824F8080")]
			internal void BMMGFKFOLGP(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x24F83B0", Offset = "0x24F75B0", VA = "0x1824F83B0")]
			internal int HIHCEMBABJB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x24F7FE0", Offset = "0x24F71E0", VA = "0x1824F7FE0")]
			internal void BCOEMKJPCAL(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x24F8540", Offset = "0x24F7740", VA = "0x1824F8540")]
			internal bool OEBFFAOBKHP()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey CHCLNDNNNEA
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0xED8260", Offset = "0xED7460", VA = "0x180ED8260", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x24E7F60", Offset = "0x24E7160", VA = "0x1824E7F60")]
		public HPFKCCAKIBK(LMPMALFKFKJ AAKAOKDAEPH, NOAGEKEDBBB NGCBLOEDNKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x24E7520", Offset = "0x24E6720", VA = "0x1824E7520", Slot = "122")]
		protected override void OOGPOIIHFKH(MMBCHPEGPFF FNGALEILPLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public sealed class LLHAPEDJDBC : PHHDBLBBBNE<EONAFDJLGGI>
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private sealed class IMJADNKPJCG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public CBPIPCCOCCI nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public LLHAPEDJDBC <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public IMJADNKPJCG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x24EF3E0", Offset = "0x24EE5E0", VA = "0x1824EF3E0")]
			internal Dictionary<string, JHEAKECEBKA> CNNDFCIODJA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x24EF500", Offset = "0x24EE700", VA = "0x1824EF500")]
			internal int OHJIDAACGDJ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x24EF2C0", Offset = "0x24EE4C0", VA = "0x1824EF2C0")]
			internal void CHECEAOKJII(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x24EF480", Offset = "0x24EE680", VA = "0x1824EF480")]
			internal bool FGLIKLLHBNH()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey CHCLNDNNNEA
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0xED8260", Offset = "0xED7460", VA = "0x180ED8260", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x24F0A20", Offset = "0x24EFC20", VA = "0x1824F0A20")]
		public LLHAPEDJDBC(LMPMALFKFKJ AAKAOKDAEPH, EONAFDJLGGI CMFHMEJHOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x24F0750", Offset = "0x24EF950", VA = "0x1824F0750", Slot = "122")]
		protected override void OOGPOIIHFKH(MMBCHPEGPFF FNGALEILPLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public sealed class FKPPMDOLBIM : PHHDBLBBBNE<NNNGILJGHED>
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class JKDMEGIJKMM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public CBPIPCCOCCI nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public FKPPMDOLBIM <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public JKDMEGIJKMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x24EFC10", Offset = "0x24EEE10", VA = "0x1824EFC10")]
			internal void CNNDFCIODJA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey CHCLNDNNNEA
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xED8260", Offset = "0xED7460", VA = "0x180ED8260", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x24E5830", Offset = "0x24E4A30", VA = "0x1824E5830")]
		public FKPPMDOLBIM(LMPMALFKFKJ AAKAOKDAEPH, NNNGILJGHED CMFHMEJHOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x24E56B0", Offset = "0x24E48B0", VA = "0x1824E56B0", Slot = "122")]
		protected override void OOGPOIIHFKH(MMBCHPEGPFF FNGALEILPLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class HKJPPGAIJMD<TNode> : BENPMJLEHAB<TNode> where TNode : notnull, DCLOEDFHILL
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool PGOANJFLHFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override KJHLFPAFBGL? BLJCHLICJGH
		{
			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x44E4BD0", Offset = "0x44E3DD0", VA = "0x1844E4BD0", Slot = "112")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override bool LJNMLLCGGNL
		{
			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x44E4C80", Offset = "0x44E3E80", VA = "0x1844E4C80", Slot = "119")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override NodeVisualizationKey CHCLNDNNNEA
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0xC15750", Offset = "0xC14950", VA = "0x180C15750", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x44E4C40", Offset = "0x44E3E40", VA = "0x1844E4C40")]
		public HKJPPGAIJMD(LMPMALFKFKJ AAKAOKDAEPH, TNode NGCBLOEDNKL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class ACCHNMOHHBM : HKJPPGAIJMD<JPGPCIMCEOE>
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		[CompilerGenerated]
		private sealed class MAFOLHDBDPL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public ACCHNMOHHBM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public CBPIPCCOCCI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public MAFOLHDBDPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x24F7D20", Offset = "0x24F6F20", VA = "0x1824F7D20")]
			internal object CNNDFCIODJA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x24F7D90", Offset = "0x24F6F90", VA = "0x1824F7D90")]
			internal void OHJIDAACGDJ(object v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x24F7C40", Offset = "0x24F6E40", VA = "0x1824F7C40")]
			internal void CHECEAOKJII()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private static object[]? HJLOICGFBNJ;

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x24E08D0", Offset = "0x24DFAD0", VA = "0x1824E08D0")]
		public ACCHNMOHHBM(LMPMALFKFKJ AAKAOKDAEPH, JPGPCIMCEOE NGCBLOEDNKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x24E0320", Offset = "0x24DF520", VA = "0x1824E0320", Slot = "122")]
		protected override void OOGPOIIHFKH(MMBCHPEGPFF FNGALEILPLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class AICFHHLLAJC : PHHDBLBBBNE<AGAKIMLPINF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override NodeVisualizationKey CHCLNDNNNEA
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xB333A0", Offset = "0xB325A0", VA = "0x180B333A0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x24E0C20", Offset = "0x24DFE20", VA = "0x1824E0C20")]
		public AICFHHLLAJC(LMPMALFKFKJ AAKAOKDAEPH, AGAKIMLPINF NGCBLOEDNKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "122")]
		protected override void OOGPOIIHFKH(MMBCHPEGPFF FNGALEILPLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private sealed class FLMNNECFMKD : PHHDBLBBBNE<FFBLPCGMJPO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override NodeVisualizationKey CHCLNDNNNEA
		{
			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0xA740D0", Offset = "0xA732D0", VA = "0x180A740D0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x24E58A0", Offset = "0x24E4AA0", VA = "0x1824E58A0")]
		public FLMNNECFMKD(LMPMALFKFKJ AAKAOKDAEPH, FFBLPCGMJPO NGCBLOEDNKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "114")]
		protected override bool KPOOHONDFHN(ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "122")]
		protected override void OOGPOIIHFKH(MMBCHPEGPFF FNGALEILPLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private sealed class DNFNHHJEFHK : PHHDBLBBBNE<OLMLIFEKFHE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override NodeVisualizationKey CHCLNDNNNEA
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0xA48600", Offset = "0xA47800", VA = "0x180A48600", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override bool HNOJBHJNLND
		{
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x24E4670", Offset = "0x24E3870", VA = "0x1824E4670", Slot = "94")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected override bool GJFDIFCADMG
		{
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x24E4600", Offset = "0x24E3800", VA = "0x1824E4600")]
		public DNFNHHJEFHK(LMPMALFKFKJ AAKAOKDAEPH, OLMLIFEKFHE NGCBLOEDNKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "122")]
		protected override void OOGPOIIHFKH(MMBCHPEGPFF FNGALEILPLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private sealed class HDDEEKFPHDJ : PHHDBLBBBNE<GCLGCPNBBKL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override NodeVisualizationKey CHCLNDNNNEA
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0xA79BB0", Offset = "0xA78DB0", VA = "0x180A79BB0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool HNOJBHJNLND
		{
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x24E73F0", Offset = "0x24E65F0", VA = "0x1824E73F0", Slot = "94")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		protected override bool GJFDIFCADMG
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x24E7380", Offset = "0x24E6580", VA = "0x1824E7380")]
		public HDDEEKFPHDJ(LMPMALFKFKJ AAKAOKDAEPH, GCLGCPNBBKL NGCBLOEDNKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "122")]
		protected override void OOGPOIIHFKH(MMBCHPEGPFF FNGALEILPLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public sealed class GLBGLFLFDLI : DCOHGAPPALO<NAHHOOCEGMP>
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		[CompilerGenerated]
		private sealed class LLNJBGEBBGI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public GLBGLFLFDLI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public CBPIPCCOCCI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public LLNJBGEBBGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x24F1C10", Offset = "0x24F0E10", VA = "0x1824F1C10")]
			internal float NDAPLDKBDJO()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x24F1B70", Offset = "0x24F0D70", VA = "0x1824F1B70")]
			internal void KCAIGKLOHLF(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x24E6CB0", Offset = "0x24E5EB0", VA = "0x1824E6CB0")]
		public GLBGLFLFDLI(LMPMALFKFKJ AAKAOKDAEPH, NAHHOOCEGMP CMFHMEJHOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x24E6A30", Offset = "0x24E5C30", VA = "0x1824E6A30", Slot = "128")]
		protected override void MGLGHHPEHGC(MMBCHPEGPFF FNGALEILPLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public sealed class AIHDJBNGKCC : PHHDBLBBBNE<DJFDLJKGHKN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000081")]
		[CompilerGenerated]
		private sealed class GOIHJILEEJO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public AIHDJBNGKCC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public CBPIPCCOCCI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public GOIHJILEEJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x24E7210", Offset = "0x24E6410", VA = "0x1824E7210")]
			internal bool CNNDFCIODJA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x24E7260", Offset = "0x24E6460", VA = "0x1824E7260")]
			internal void OHJIDAACGDJ(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x24E0F30", Offset = "0x24E0130", VA = "0x1824E0F30")]
		public AIHDJBNGKCC(LMPMALFKFKJ AAKAOKDAEPH, DJFDLJKGHKN CMFHMEJHOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x24E0C90", Offset = "0x24DFE90", VA = "0x1824E0C90", Slot = "122")]
		protected override void OOGPOIIHFKH(MMBCHPEGPFF FNGALEILPLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class OFIMHGCLMDM : PHHDBLBBBNE<FIMDPPKDNMG>
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class BPLFBMEMIOG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public CBPIPCCOCCI nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public OFIMHGCLMDM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public BPLFBMEMIOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x24E2A20", Offset = "0x24E1C20", VA = "0x1824E2A20")]
			internal object CNNDFCIODJA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x24E2FD0", Offset = "0x24E21D0", VA = "0x1824E2FD0")]
			internal bool PHECLJCFGBO(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x24E2D80", Offset = "0x24E1F80", VA = "0x1824E2D80")]
			internal void OHJIDAACGDJ(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x24E28C0", Offset = "0x24E1AC0", VA = "0x1824E28C0")]
			internal string CHECEAOKJII(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x24E2BA0", Offset = "0x24E1DA0", VA = "0x1824E2BA0")]
			internal IReadOnlyList<object> FGLIKLLHBNH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x24E2BF0", Offset = "0x24E1DF0", VA = "0x1824E2BF0")]
			internal bool FHEGOLGOMJG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x24E2B50", Offset = "0x24E1D50", VA = "0x1824E2B50")]
			internal bool DNFOIEHJGKL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x24E2C60", Offset = "0x24E1E60", VA = "0x1824E2C60")]
			internal void JLCENCAMMIH(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x24F9AD0", Offset = "0x24F8CD0", VA = "0x1824F9AD0")]
		public OFIMHGCLMDM(LMPMALFKFKJ AAKAOKDAEPH, FIMDPPKDNMG CMFHMEJHOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x24F92D0", Offset = "0x24F84D0", VA = "0x1824F92D0", Slot = "122")]
		protected override void OOGPOIIHFKH(MMBCHPEGPFF FNGALEILPLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class EMKGHFOIDGI : HLLJHJFDKAI<IJPLDADNIIJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override NodeVisualizationKey CHCLNDNNNEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0xC1AE90", Offset = "0xC1A090", VA = "0x180C1AE90", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x24E4B60", Offset = "0x24E3D60", VA = "0x1824E4B60")]
		public EMKGHFOIDGI(LMPMALFKFKJ AAKAOKDAEPH, IJPLDADNIIJ NGCBLOEDNKL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class AENPLGBFFNE : DCOHGAPPALO<EHAJJCGIPFN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		[CompilerGenerated]
		private sealed class MIONAHOBLGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public AENPLGBFFNE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public CBPIPCCOCCI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public MIONAHOBLGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x24F7F60", Offset = "0x24F7160", VA = "0x1824F7F60")]
			internal int NDAPLDKBDJO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x24F7EC0", Offset = "0x24F70C0", VA = "0x1824F7EC0")]
			internal void KCAIGKLOHLF(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x24E0BC0", Offset = "0x24DFDC0", VA = "0x1824E0BC0")]
		public AENPLGBFFNE(LMPMALFKFKJ AAKAOKDAEPH, EHAJJCGIPFN CMFHMEJHOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x24E0930", Offset = "0x24DFB30", VA = "0x1824E0930", Slot = "128")]
		protected override void MGLGHHPEHGC(MMBCHPEGPFF FNGALEILPLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class FHKMIJAIEJC : PHHDBLBBBNE<GMLFJPLJABJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		[CompilerGenerated]
		private sealed class FILLHJIFOCA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public FHKMIJAIEJC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public CBPIPCCOCCI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public FILLHJIFOCA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x24E55D0", Offset = "0x24E47D0", VA = "0x1824E55D0")]
			internal bool CNNDFCIODJA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x24E5620", Offset = "0x24E4820", VA = "0x1824E5620")]
			internal void OHJIDAACGDJ(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x24E5560", Offset = "0x24E4760", VA = "0x1824E5560")]
		public FHKMIJAIEJC(LMPMALFKFKJ AAKAOKDAEPH, GMLFJPLJABJ CMFHMEJHOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x24E5380", Offset = "0x24E4580", VA = "0x1824E5380", Slot = "122")]
		protected override void OOGPOIIHFKH(MMBCHPEGPFF FNGALEILPLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class CPHDLEECLCI : PHHDBLBBBNE<KLGFCDMGHLK>
	{
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		[CompilerGenerated]
		private sealed class NKCFAMAPNJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public CPHDLEECLCI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public CBPIPCCOCCI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public NKCFAMAPNJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x24F8F30", Offset = "0x24F8130", VA = "0x1824F8F30")]
			internal bool CNNDFCIODJA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x24F8F80", Offset = "0x24F8180", VA = "0x1824F8F80")]
			internal void OHJIDAACGDJ(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x24E44F0", Offset = "0x24E36F0", VA = "0x1824E44F0")]
		public CPHDLEECLCI(LMPMALFKFKJ AAKAOKDAEPH, KLGFCDMGHLK CMFHMEJHOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x24E4310", Offset = "0x24E3510", VA = "0x1824E4310", Slot = "122")]
		protected override void OOGPOIIHFKH(MMBCHPEGPFF FNGALEILPLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public sealed class CFMAMEFDHEJ : PHHDBLBBBNE<BNOCGHJPDIP>
	{
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		[CompilerGenerated]
		private sealed class HOHJMEIDPLB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public CFMAMEFDHEJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public CBPIPCCOCCI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public HOHJMEIDPLB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x24E7440", Offset = "0x24E6640", VA = "0x1824E7440")]
			internal int CNNDFCIODJA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x24E7490", Offset = "0x24E6690", VA = "0x1824E7490")]
			internal void OHJIDAACGDJ(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x24E3850", Offset = "0x24E2A50", VA = "0x1824E3850")]
		public CFMAMEFDHEJ(LMPMALFKFKJ AAKAOKDAEPH, BNOCGHJPDIP CMFHMEJHOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x24E35E0", Offset = "0x24E27E0", VA = "0x1824E35E0", Slot = "122")]
		protected override void OOGPOIIHFKH(MMBCHPEGPFF FNGALEILPLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public sealed class MDBAEHFGHEG : JKMCFJIDALI<OJLCKHNGOMD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override OGABAALDEPD ABDBJAFGNNM
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0xA8A350", Offset = "0xA89550", VA = "0x180A8A350", Slot = "128")]
			get
			{
				return default(OGABAALDEPD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x24F7E60", Offset = "0x24F7060", VA = "0x1824F7E60")]
		public MDBAEHFGHEG(LMPMALFKFKJ AAKAOKDAEPH, OJLCKHNGOMD CMFHMEJHOAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public class CEBOMBBLHLK : PHHDBLBBBNE<HGHEIBELGCA>
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x24E3450", Offset = "0x24E2650", VA = "0x1824E3450")]
		public CEBOMBBLHLK(LMPMALFKFKJ AAKAOKDAEPH, HGHEIBELGCA NGCBLOEDNKL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public abstract class PHHDBLBBBNE<TNode> : CCPJLKCOOAF, IDisposable where TNode : notnull, HGHEIBELGCA
	{
		[Cpp2IlInjected.Token(Token = "0x2000090")]
		[CompilerGenerated]
		private sealed class PPJMIFADGIB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public PHHDBLBBBNE<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public LMPMALFKFKJ circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public PPJMIFADGIB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x4F5DC80", Offset = "0x4F5CE80", VA = "0x184F5DC80")]
			internal LPIAIGGALEL MLGCCJBDMDH(IIOLNKDBICB portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000091")]
		[CompilerGenerated]
		private struct EMECMCILFHC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public PHHDBLBBBNE<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			private TaskAwaiter<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x3F223D0", Offset = "0x3F215D0", VA = "0x183F223D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x949E40", Offset = "0x949040", VA = "0x180949E40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000092")]
		[CompilerGenerated]
		private struct DHIHCEPPAAA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public AsyncTaskMethodBuilder<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public PHHDBLBBBNE<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public NFONEEMNPCB? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public JODENAIICMG? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			private TaskAwaiter<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x6076DF0", Offset = "0x6075FF0", VA = "0x186076DF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x6077090", Offset = "0x6076290", VA = "0x186077090", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000093")]
		[CompilerGenerated]
		private sealed class EANMBNDCAIK
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000094")]
			private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CF")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D0")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D1")]
				public EANMBNDCAIK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D2")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60003A7")]
				[Cpp2IlInjected.Address(RVA = "0x3C19F40", Offset = "0x3C19140", VA = "0x183C19F40", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003A8")]
				[Cpp2IlInjected.Address(RVA = "0x949E40", Offset = "0x949040", VA = "0x180949E40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public Func<string, bool> submitValidator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public CBPIPCCOCCI nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			public PHHDBLBBBNE<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public MMBCHPEGPFF configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public EANMBNDCAIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
			internal string IJLNLCANGPL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x8F54A0", Offset = "0x8F46A0", VA = "0x1808F54A0")]
			internal void FMDKHDHLBEG(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x3ECCF10", Offset = "0x3ECC110", VA = "0x183ECCF10")]
			[AsyncStateMachine(typeof(PHHDBLBBBNE<>.EANMBNDCAIK.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void CPHBOEBFMMO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		[CompilerGenerated]
		private sealed class AJJNGFGPCNK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public CBPIPCCOCCI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public AJJNGFGPCNK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x452F4E0", Offset = "0x452E6E0", VA = "0x18452F4E0")]
			internal bool EBMACJHGAJE(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x452F5C0", Offset = "0x452E7C0", VA = "0x18452F5C0")]
			internal bool FPCJHKMKFBP(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000096")]
		[CompilerGenerated]
		private struct OJINLIAANNM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public AsyncTaskMethodBuilder<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public PHHDBLBBBNE<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			private TaskAwaiter<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x4DC2230", Offset = "0x4DC1430", VA = "0x184DC2230", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x4DC25B0", Offset = "0x4DC17B0", VA = "0x184DC25B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private readonly LMPMALFKFKJ FPODCAIMPFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private readonly bool KMJJILGOGKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private GKMBLDOBBJD<GIDHHIIAAHA, LPIAIGGALEL> AMDDKLEBGJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private GKMBLDOBBJD<GIDHHIIAAHA, NFKPPHIGIKA> EGDHOFGHBLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private List<Action> CELLLILEGBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		[CompilerGenerated]
		private Action<ANHNAJIBLBK<GIDHHIIAAHA>>? GBJGPFDBHLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[CompilerGenerated]
		private Action<ANHNAJIBLBK<GIDHHIIAAHA>, NFKPPHIGIKA>? HHNKLPIEDDL;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		protected ALBLMFHGEEB KNJIABIFCHP
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x4F36760", Offset = "0x4F35960", VA = "0x184F36760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		protected CBPIPCCOCCI AOLKBPHKGLG
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x4F34C70", Offset = "0x4F33E70", VA = "0x184F34C70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		protected TNode OMEBCHLIOJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x8F4D20", Offset = "0x8F3F20", VA = "0x1808F4D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public BDPEADCNJIF<FDEAEAJKEFN> CAOELBEPEAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x1153B40", Offset = "0x1152D40", VA = "0x181153B40", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(BDPEADCNJIF<FDEAEAJKEFN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public ANHNAJIBLBK<KGOBMFADMHP> BCDENPLKFHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x4F38860", Offset = "0x4F37A60", VA = "0x184F38860", Slot = "6")]
			get
			{
				return default(ANHNAJIBLBK<KGOBMFADMHP>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public object COLLFNBHNEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x3FAD610", Offset = "0x3FAC810", VA = "0x183FAD610", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public virtual bool BOJILMPDEJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public int GOJFOHDEPKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x4F384C0", Offset = "0x4F376C0", VA = "0x184F384C0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public FNNBEFDBEDH LLKKEMMOODM
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x4F38460", Offset = "0x4F37660", VA = "0x184F38460", Slot = "10")]
			get
			{
				return default(FNNBEFDBEDH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public string EPAINLLKCDM
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x4F38A60", Offset = "0x4F37C60", VA = "0x184F38A60", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		protected virtual bool GJFDIFCADMG
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public virtual NodeVisualizationKey CHCLNDNNNEA
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public ANHNAJIBLBK<HCKHKBFGAJN> NCKEGAAEADC
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0xCDEF50", Offset = "0xCDE150", VA = "0x180CDEF50", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(ANHNAJIBLBK<HCKHKBFGAJN>);
			}
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0xCEC810", Offset = "0xCEBA10", VA = "0x180CEC810")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual bool HNOJBHJNLND
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "94")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual bool PGOANJFLHFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public virtual EKAAGEGHDBN LKEOHNBFKGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0xDB3960", Offset = "0xDB2B60", VA = "0x180DB3960", Slot = "96")]
			get
			{
				return default(EKAAGEGHDBN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool PKHLIEPCOEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x4F381D0", Offset = "0x4F373D0", VA = "0x184F381D0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool HBBMBFBIOAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x4F38230", Offset = "0x4F37430", VA = "0x184F38230", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public bool FBGAGNPFMON
		{
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x4F38290", Offset = "0x4F37490", VA = "0x184F38290", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public int IJIKODCJGLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x4F38810", Offset = "0x4F37A10", VA = "0x184F38810", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool HGFFEAHOLCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x4F38640", Offset = "0x4F37840", VA = "0x184F38640", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool NGLDALKDLPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x4F383A0", Offset = "0x4F375A0", VA = "0x184F383A0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool AAKCOFEHGBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x4F38340", Offset = "0x4F37540", VA = "0x184F38340", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public bool HNCFLBNMFLI
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0xD5AB20", Offset = "0xD59D20", VA = "0x180D5AB20", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x1147C40", Offset = "0x1146E40", VA = "0x181147C40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual bool NHFGEGPNHDO
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "97")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public virtual bool EAEOAFKGBFI
		{
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x4F382F0", Offset = "0x4F374F0", VA = "0x184F382F0", Slot = "98")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool DFIFMGEJFGO
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x4F38570", Offset = "0x4F37770", VA = "0x184F38570", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public NFONEEMNPCB MLGLPLALOCO
		{
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x4F38750", Offset = "0x4F37950", VA = "0x184F38750", Slot = "28")]
			get
			{
				return default(NFONEEMNPCB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public JODENAIICMG FPDDOGEDCML
		{
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x4F387B0", Offset = "0x4F379B0", VA = "0x184F387B0", Slot = "30")]
			get
			{
				return default(JODENAIICMG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual bool CFLBDEJCHJL
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual BGIBCKDIGHD? ALGAPAFIENH
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual KJHLFPAFBGL? BLJCHLICJGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "112")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public virtual IEnumerable<BDPEADCNJIF<COBLBOLGAKJ>>? MIABGOMOPFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "113")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool EFKPHOMDDDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x4F38400", Offset = "0x4F37600", VA = "0x184F38400", Slot = "116")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public BDPEADCNJIF<KJENBNHGDMG> JNBCPLMNHFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x4F38690", Offset = "0x4F37890", VA = "0x184F38690", Slot = "62")]
			get
			{
				return default(BDPEADCNJIF<KJENBNHGDMG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public ANHNAJIBLBK<KJENBNHGDMG> HEKKAKHLFJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x4F38510", Offset = "0x4F37710", VA = "0x184F38510", Slot = "56")]
			get
			{
				return default(ANHNAJIBLBK<KJENBNHGDMG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public virtual bool MLGMNJKGJAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public virtual ANHNAJIBLBK<KJENBNHGDMG>? ADMIMLPKILN
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public virtual bool LJNMLLCGGNL
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "119")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool DHFBHOIABPF
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x4F385D0", Offset = "0x4F377D0", VA = "0x184F385D0", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public string PCMLNMEPCBI
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x8F9230", Offset = "0x8F8430", VA = "0x1808F9230", Slot = "65")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x8F9270", Offset = "0x8F8470", VA = "0x1808F9270")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public string HLGDKJJGHLF
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x8F91E0", Offset = "0x8F83E0", VA = "0x1808F91E0", Slot = "66")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x8F92A0", Offset = "0x8F84A0", VA = "0x1808F92A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public ANHNAJIBLBK<COBLBOLGAKJ> GBLKJPFBIEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x4F388E0", Offset = "0x4F37AE0", VA = "0x184F388E0", Slot = "63")]
			get
			{
				return default(ANHNAJIBLBK<COBLBOLGAKJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public BDPEADCNJIF<COBLBOLGAKJ> LNBJEOAMEGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x4F386F0", Offset = "0x4F378F0", VA = "0x184F386F0", Slot = "64")]
			get
			{
				return default(BDPEADCNJIF<COBLBOLGAKJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public BDPEADCNJIF<COBLBOLGAKJ>? EDJINGFKHHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x4F38940", Offset = "0x4F37B40", VA = "0x184F38940", Slot = "120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public PIGMDFNHJOI<GIDHHIIAAHA, NFKPPHIGIKA> OJOLJJBIIOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x4F38A20", Offset = "0x4F37C20", VA = "0x184F38A20", Slot = "67")]
			get
			{
				return default(PIGMDFNHJOI<GIDHHIIAAHA, NFKPPHIGIKA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public virtual ANHNAJIBLBK<GIDHHIIAAHA>? BAIBCJGKKEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "121")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public virtual bool CDDCKJGLFPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "124")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public virtual bool COFBJDECCLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "125")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action BBHLKPDBDGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x4F346B0", Offset = "0x4F338B0", VA = "0x184F346B0", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x4F35530", Offset = "0x4F34730", VA = "0x184F35530", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event JJGKLHJGNOF FJICPELGOAO
		{
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x4F359C0", Offset = "0x4F34BC0", VA = "0x184F359C0", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x4F33D90", Offset = "0x4F32F90", VA = "0x184F33D90", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event FDEHELOGKEI PJPNGAMDMMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x4F33A60", Offset = "0x4F32C60", VA = "0x184F33A60", Slot = "41")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x4F34BD0", Offset = "0x4F33DD0", VA = "0x184F34BD0", Slot = "42")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action IFBDFJEIGMI
		{
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x4F36150", Offset = "0x4F35350", VA = "0x184F36150", Slot = "43")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x4F360F0", Offset = "0x4F352F0", VA = "0x184F360F0", Slot = "44")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action PCBFOHHHBBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x4F33B00", Offset = "0x4F32D00", VA = "0x184F33B00", Slot = "45")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x4F36260", Offset = "0x4F35460", VA = "0x184F36260", Slot = "46")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<ANHNAJIBLBK<GIDHHIIAAHA>, NFKPPHIGIKA> HBNAMKJCMKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x4F339A0", Offset = "0x4F32BA0", VA = "0x184F339A0", Slot = "69")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x4F34750", Offset = "0x4F33950", VA = "0x184F34750", Slot = "70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<ANHNAJIBLBK<GIDHHIIAAHA>, NFKPPHIGIKA> PODMEAGPALL
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x4F33C10", Offset = "0x4F32E10", VA = "0x184F33C10", Slot = "73")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x4F36030", Offset = "0x4F35230", VA = "0x184F36030", Slot = "74")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<ANHNAJIBLBK<GIDHHIIAAHA>> JPABFAMMADH
		{
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x4F365E0", Offset = "0x4F357E0", VA = "0x184F365E0", Slot = "71")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x4F338E0", Offset = "0x4F32AE0", VA = "0x184F338E0", Slot = "72")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<ANHNAJIBLBK<GIDHHIIAAHA>, ANHNAJIBLBK<GIDHHIIAAHA>> FOJECDCNIKM
		{
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0x4F33510", Offset = "0x4F32710", VA = "0x184F33510", Slot = "75")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0x4F33130", Offset = "0x4F32330", VA = "0x184F33130", Slot = "76")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<ANHNAJIBLBK<GIDHHIIAAHA>, NFKPPHIGIKA> FPAJDNOIPGH
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0x4F35470", Offset = "0x4F34670", VA = "0x184F35470", Slot = "77")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x4F366A0", Offset = "0x4F358A0", VA = "0x184F366A0", Slot = "78")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<ANHNAJIBLBK<GIDHHIIAAHA>, ANHNAJIBLBK<GIDHHIIAAHA>> NOFPIPHDJAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0x4F33CD0", Offset = "0x4F32ED0", VA = "0x184F33CD0", Slot = "79")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(RVA = "0x4F36830", Offset = "0x4F35A30", VA = "0x184F36830", Slot = "80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x4F37C00", Offset = "0x4F36E00", VA = "0x184F37C00")]
		[CKOGIBPDLCN("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		[CKOGIBPDLCN("Need to handle `Name` better.")]
		protected PHHDBLBBBNE(LMPMALFKFKJ AAKAOKDAEPH, TNode NGCBLOEDNKL, bool GHBLBJBGAAF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x4F34D50", Offset = "0x4F33F50", VA = "0x184F34D50", Slot = "89")]
		protected virtual void GGPOBANFNOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x4F33E30", Offset = "0x4F33030", VA = "0x184F33E30", Slot = "90")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x4F368F0", Offset = "0x4F35AF0", VA = "0x184F368F0", Slot = "9")]
		[AsyncStateMachine(typeof(PHHDBLBBBNE<>.EMECMCILFHC))]
		public void NEBKIKHFEFE(int OJHPNLJAJHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x4F369E0", Offset = "0x4F35BE0", VA = "0x184F369E0")]
		public bool NGOFMIFOBEM([In] NFONEEMNPCB OMEFCJCOLII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x4F33280", Offset = "0x4F32480", VA = "0x184F33280")]
		public bool AIHJPCDMCFI([In] JODENAIICMG OMEFCJCOLII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x4F37840", Offset = "0x4F36A40", VA = "0x184F37840", Slot = "32")]
		public void PCIEIKFANDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x4F349B0", Offset = "0x4F33BB0", VA = "0x184F349B0", Slot = "33")]
		[AsyncStateMachine(typeof(PHHDBLBBBNE<>.DHIHCEPPAAA))]
		public Task<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> FPKLGDHJHJO(NFONEEMNPCB? ONLMFNGKLOH, JODENAIICMG? IBAINNMCHCO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "99")]
		public virtual void KKGHCPIADDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "100")]
		public virtual void FKAHIHELFJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "101")]
		public virtual void PDLJOLEMFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xD3AB50", Offset = "0xD39D50", VA = "0x180D3AB50")]
		protected void DHHJNNPLJJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xDAC460", Offset = "0xDAB660", VA = "0x180DAC460")]
		protected void IFMLICOFOJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x2723160", Offset = "0x2722360", VA = "0x182723160")]
		private void DOCFAHFDJOA([In] JODENAIICMG EGIHDGHICMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x4F34B00", Offset = "0x4F33D00", VA = "0x184F34B00", Slot = "102")]
		public virtual Task<EBOICGKKPAM<ANHNAJIBLBK<GIDHHIIAAHA>, LKEBDJCDIFL>> GACGGMGJKPH(string LMOANCJLHKC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x4F37B30", Offset = "0x4F36D30", VA = "0x184F37B30", Slot = "103")]
		public virtual Task<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> PJMOGAHAJNG(ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "104")]
		public virtual void EHDIFFIDGNH(ANHNAJIBLBK<GIDHHIIAAHA> DFEOMGGJCIJ, ANHNAJIBLBK<GIDHHIIAAHA> CIJKJGOAJFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x4F35A60", Offset = "0x4F34C60", VA = "0x184F35A60", Slot = "105")]
		public virtual IEnumerable<NAGMPGBKIGM> HLAIHECDPID()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x4F331F0", Offset = "0x4F323F0", VA = "0x184F331F0", Slot = "106")]
		public EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL> ABLCEPHLPHH(string JLOPIPPDIOP)
		{
			return default(EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x4F379E0", Offset = "0x4F36BE0", VA = "0x184F379E0", Slot = "47")]
		public bool PFANAILLAAM([Out] Guid PLPDDKCBLNA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x4F36E60", Offset = "0x4F36060", VA = "0x184F36E60")]
		public bool OCIADHKFODK([In] Guid KMGNKJBKEAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "107")]
		public virtual void OKECIINHNOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "108")]
		public virtual void LLMCCEIDHHB(bool AJIDCPCPLNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "109")]
		public virtual JMLHCBDEKMK IGHBAHBEPGH([In] CBFDAIIFLGG LBOAOLCHKLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x4F37130", Offset = "0x4F36330", VA = "0x184F37130")]
		protected void OKHLGPLEEDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x4F36220", Offset = "0x4F35420", VA = "0x184F36220", Slot = "114")]
		protected virtual bool KPOOHONDFHN(ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "115")]
		protected virtual bool BOFNEEJFBDF(ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "122")]
		protected virtual void OOGPOIIHFKH(MMBCHPEGPFF EODCAOGHMAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x4F355D0", Offset = "0x4F347D0", VA = "0x184F355D0")]
		protected void GNFJDMNNIEH(MMBCHPEGPFF FNGALEILPLM, Func<string> FABKEDHDCPK, Action<string> LKMANNBCJJD, string LLKCFADCAAF, string CFJAFCCCMKO, string PPIEGIJOANG, DGJMJHHBEJA DOPOEPENJEI, EEMCJEPBKOD KOBOEJEGMDM, Func<string, bool> CEEPHJMMFMA, string APJNCGCDOGL, Func<string, bool> FHBINGPEAMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x4F36300", Offset = "0x4F35500", VA = "0x184F36300")]
		protected void LKBEOOOBCEA(MMBCHPEGPFF FNGALEILPLM, Func<string> FABKEDHDCPK, Action<string> LKMANNBCJJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x4F33360", Offset = "0x4F32560", VA = "0x184F33360", Slot = "123")]
		protected virtual void APKHBJPGGOO(MMBCHPEGPFF FNGALEILPLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x4F33700", Offset = "0x4F32900", VA = "0x184F33700", Slot = "82")]
		public void BJKGIDOIOFI(MMBCHPEGPFF FNGALEILPLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x4F33750", Offset = "0x4F32950", VA = "0x184F33750", Slot = "83")]
		public PDAHHPHGJBJ BJLDFOMGPCE()
		{
			return default(PDAHHPHGJBJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "126")]
		public virtual bool MAPJNEMPDOI(ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x1CD3C90", Offset = "0x1CD2E90", VA = "0x181CD3C90")]
		private void IPHKECEHAOK([In] NFONEEMNPCB FCKJMOMOHAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x4F376F0", Offset = "0x4F368F0", VA = "0x184F376F0")]
		private void PBJNCKLPENN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x4F35AF0", Offset = "0x4F34CF0", VA = "0x184F35AF0")]
		private void HNLGIGCGMHL(ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO, IIOLNKDBICB LOAGOAPIFOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xECE080", Offset = "0xECD280", VA = "0x180ECE080")]
		private void MNCGLOCNKPJ(ANHNAJIBLBK<GIDHHIIAAHA> BEHEHKFONGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x4F335D0", Offset = "0x4F327D0", VA = "0x184F335D0")]
		private void BEMEEFEEKDM(ANHNAJIBLBK<GIDHHIIAAHA> BEHEHKFONGA, IIOLNKDBICB KGBBMHOOJBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x4F37310", Offset = "0x4F36510", VA = "0x184F37310")]
		private void OLCMGIHELHK(ANHNAJIBLBK<GIDHHIIAAHA> DFEOMGGJCIJ, ANHNAJIBLBK<GIDHHIIAAHA> CIJKJGOAJFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0xECE650", Offset = "0xECD850", VA = "0x180ECE650")]
		private void JJCBDEGDAPJ(ANHNAJIBLBK<GIDHHIIAAHA> DFEOMGGJCIJ, ANHNAJIBLBK<GIDHHIIAAHA> CIJKJGOAJFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x4F37110", Offset = "0x4F36310", VA = "0x184F37110")]
		private void OGBCGIEJCLE(ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x4F36A50", Offset = "0x4F35C50", VA = "0x184F36A50")]
		private void NNJAPPMIAJF(ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO, IIOLNKDBICB LOAGOAPIFOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x4F33BA0", Offset = "0x4F32DA0", VA = "0x184F33BA0")]
		private void DGEHIKBAECL(ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO, IIOLNKDBICB KGBBMHOOJBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x4F34850", Offset = "0x4F33A50", VA = "0x184F34850", Slot = "127")]
		[AsyncStateMachine(typeof(PHHDBLBBBNE<>.OJINLIAANNM))]
		public Task<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> FHDDFMDFFJE(string JLOPIPPDIOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x4F367C0", Offset = "0x4F359C0", VA = "0x184F367C0", Slot = "54")]
		private void NCMLDMDKODC(object KBHIOCPBLDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x4F332F0", Offset = "0x4F324F0", VA = "0x184F332F0", Slot = "55")]
		private void AOAAONKAGDF(object KBHIOCPBLDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x4F34810", Offset = "0x4F33A10", VA = "0x184F34810", Slot = "29")]
		private bool FCLOGNBCKNG([In] NFONEEMNPCB OMEFCJCOLII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x4F369A0", Offset = "0x4F35BA0", VA = "0x184F369A0", Slot = "31")]
		private bool NGMCPOLDFKO([In] JODENAIICMG OMEFCJCOLII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x4F34970", Offset = "0x4F33B70", VA = "0x184F34970", Slot = "48")]
		private bool FLCJHLPFNAL([In] Guid KMGNKJBKEAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x4F376B0", Offset = "0x4F368B0", VA = "0x184F376B0")]
		[CompilerGenerated]
		private string OPNNOAFBLNM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x4F33840", Offset = "0x4F32A40", VA = "0x184F33840")]
		[CompilerGenerated]
		private void BMHNEPLGGMI(string LMOANCJLHKC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public sealed class OLAEJKIMGMO : HLLJHJFDKAI<ELLGMKGJNIB>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override NodeVisualizationKey CHCLNDNNNEA
		{
			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0xBFBE90", Offset = "0xBFB090", VA = "0x180BFBE90", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x24F9C00", Offset = "0x24F8E00", VA = "0x1824F9C00")]
		public OLAEJKIMGMO(LMPMALFKFKJ AAKAOKDAEPH, ELLGMKGJNIB NGCBLOEDNKL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private sealed class ODGCEENBMDB : BENPMJLEHAB<FIDGPFKJPIH>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public override NodeVisualizationKey CHCLNDNNNEA
		{
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0xA8A350", Offset = "0xA89550", VA = "0x180A8A350", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x24F9270", Offset = "0x24F8470", VA = "0x1824F9270")]
		public ODGCEENBMDB(LMPMALFKFKJ AAKAOKDAEPH, FIDGPFKJPIH NGCBLOEDNKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "122")]
		protected override void OOGPOIIHFKH(MMBCHPEGPFF FNGALEILPLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public abstract class JKMCFJIDALI<T> : PHHDBLBBBNE<T> where T : notnull, EFBNIMNHJHE
	{
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		[CompilerGenerated]
		private sealed class FCJODMKCDOK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public IReadOnlyList<KeyValuePair<string, JHEAKECEBKA>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public JKMCFJIDALI<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public CBPIPCCOCCI nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public OGABAALDEPD clipType;

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public FCJODMKCDOK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
			internal IReadOnlyList<KeyValuePair<string, JHEAKECEBKA>> CNNDFCIODJA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x42DDCB0", Offset = "0x42DCEB0", VA = "0x1842DDCB0")]
			internal int OHJIDAACGDJ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x42DD670", Offset = "0x42DC870", VA = "0x1842DD670")]
			internal void CHECEAOKJII(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x42DD960", Offset = "0x42DCB60", VA = "0x1842DD960")]
			internal void FGLIKLLHBNH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x42DD9B0", Offset = "0x42DCBB0", VA = "0x1842DD9B0")]
			internal void FHEGOLGOMJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x42DD8D0", Offset = "0x42DCAD0", VA = "0x1842DD8D0")]
			internal bool DNFOIEHJGKL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x42DDC60", Offset = "0x42DCE60", VA = "0x1842DDC60")]
			internal void JLCENCAMMIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x42DD8D0", Offset = "0x42DCAD0", VA = "0x1842DD8D0")]
			internal bool PHECLJCFGBO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x42DD880", Offset = "0x42DCA80", VA = "0x1842DD880")]
			internal float CKMDLJNDAHA()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x42DDBA0", Offset = "0x42DCDA0", VA = "0x1842DDBA0")]
			internal void JALLPEKDBGL(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x42DDB50", Offset = "0x42DCD50", VA = "0x1842DDB50")]
			internal float ILMCEIKMBEC()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0x42DD5B0", Offset = "0x42DC7B0", VA = "0x1842DD5B0")]
			internal void BMMGFKFOLGP(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x42DDB00", Offset = "0x42DCD00", VA = "0x1842DDB00")]
			internal float HIHCEMBABJB()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x42DD4F0", Offset = "0x42DC6F0", VA = "0x1842DD4F0")]
			internal void BCOEMKJPCAL(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public override NodeVisualizationKey CHCLNDNNNEA
		{
			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0xED8260", Offset = "0xED7460", VA = "0x180ED8260", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public abstract OGABAALDEPD ABDBJAFGNNM
		{
			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(Slot = "128")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x481E630", Offset = "0x481D830", VA = "0x18481E630")]
		public JKMCFJIDALI(LMPMALFKFKJ AAKAOKDAEPH, T NGCBLOEDNKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x4832600", Offset = "0x4831800", VA = "0x184832600", Slot = "122")]
		protected sealed override void OOGPOIIHFKH(MMBCHPEGPFF FNGALEILPLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	private sealed class NJJFIOJMOEL : PHHDBLBBBNE<JEPCIIIMIBM>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public override NodeVisualizationKey CHCLNDNNNEA
		{
			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0xC08450", Offset = "0xC07650", VA = "0x180C08450", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x24F8EC0", Offset = "0x24F80C0", VA = "0x1824F8EC0")]
		public NJJFIOJMOEL(LMPMALFKFKJ AAKAOKDAEPH, JEPCIIIMIBM NGCBLOEDNKL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class LLHGLJMDMEL : PHHDBLBBBNE<NPEGMOGJFGK>
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class EAAIHAMPGPJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public LLHGLJMDMEL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public CBPIPCCOCCI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public EAAIHAMPGPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0x24E4750", Offset = "0x24E3950", VA = "0x1824E4750")]
			internal int OHJIDAACGDJ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x24E46C0", Offset = "0x24E38C0", VA = "0x1824E46C0")]
			internal void CHECEAOKJII(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private static Dictionary<string, JHEAKECEBKA>? JMDFINFKGCM;

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x24F0E20", Offset = "0x24F0020", VA = "0x1824F0E20")]
		public LLHGLJMDMEL(LMPMALFKFKJ AAKAOKDAEPH, NPEGMOGJFGK NGCBLOEDNKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x24F0A90", Offset = "0x24EFC90", VA = "0x1824F0A90", Slot = "122")]
		protected override void OOGPOIIHFKH(MMBCHPEGPFF FNGALEILPLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class GFEACEGJGBE : JKMCFJIDALI<LEIMGMJJEOB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public override OGABAALDEPD ABDBJAFGNNM
		{
			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "128")]
			get
			{
				return default(OGABAALDEPD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x24E65A0", Offset = "0x24E57A0", VA = "0x1824E65A0")]
		public GFEACEGJGBE(LMPMALFKFKJ AAKAOKDAEPH, LEIMGMJJEOB CMFHMEJHOAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private sealed class NMIAFIOOJBI : BENPMJLEHAB<BOGLONDJIDP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override NodeVisualizationKey CHCLNDNNNEA
		{
			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0xA8A350", Offset = "0xA89550", VA = "0x180A8A350", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x24F9010", Offset = "0x24F8210", VA = "0x1824F9010")]
		public NMIAFIOOJBI(LMPMALFKFKJ AAKAOKDAEPH, BOGLONDJIDP NGCBLOEDNKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "122")]
		protected override void OOGPOIIHFKH(MMBCHPEGPFF FNGALEILPLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private sealed class OKOAPAGCALE : BENPMJLEHAB<AEGGMLBMONE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public override NodeVisualizationKey CHCLNDNNNEA
		{
			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0xA8A350", Offset = "0xA89550", VA = "0x180A8A350", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x24F9BA0", Offset = "0x24F8DA0", VA = "0x1824F9BA0")]
		public OKOAPAGCALE(LMPMALFKFKJ AAKAOKDAEPH, AEGGMLBMONE NGCBLOEDNKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "122")]
		protected override void OOGPOIIHFKH(MMBCHPEGPFF FNGALEILPLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public sealed class KKMHHFJNPPH : DCOHGAPPALO<MFOJCFBPCCG>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		[CompilerGenerated]
		private sealed class GEJAPJIFDLL
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000A4")]
			private struct <<AddHomeValueSetting>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E6")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40001E7")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40001E8")]
				public GEJAPJIFDLL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40001E9")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40001EA")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40001EB")]
				private TaskAwaiter<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60003DC")]
				[Cpp2IlInjected.Address(RVA = "0x24FB460", Offset = "0x24FA660", VA = "0x1824FB460", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003DD")]
				[Cpp2IlInjected.Address(RVA = "0x949E40", Offset = "0x949040", VA = "0x180949E40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			public CBPIPCCOCCI nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public KKMHHFJNPPH <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public GEJAPJIFDLL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x24E6000", Offset = "0x24E5200", VA = "0x1824E6000")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void NDAPLDKBDJO(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x24F0330", Offset = "0x24EF530", VA = "0x1824F0330")]
		public KKMHHFJNPPH(LMPMALFKFKJ AAKAOKDAEPH, MFOJCFBPCCG CMFHMEJHOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x24F0050", Offset = "0x24EF250", VA = "0x1824F0050", Slot = "128")]
		protected override void MGLGHHPEHGC(MMBCHPEGPFF FNGALEILPLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public sealed class ANJDMLLGCGK : JKMCFJIDALI<AOBCFPODMEJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public override OGABAALDEPD ABDBJAFGNNM
		{
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0xA48600", Offset = "0xA47800", VA = "0x180A48600", Slot = "128")]
			get
			{
				return default(OGABAALDEPD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x24E24E0", Offset = "0x24E16E0", VA = "0x1824E24E0")]
		public ANJDMLLGCGK(LMPMALFKFKJ AAKAOKDAEPH, AOBCFPODMEJ CMFHMEJHOAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	private sealed class GGGJKMLDDEK : PHHDBLBBBNE<BDIIOBGNKEI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public override NodeVisualizationKey CHCLNDNNNEA
		{
			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0xBF3E20", Offset = "0xBF3020", VA = "0x180BF3E20", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x24E69C0", Offset = "0x24E5BC0", VA = "0x1824E69C0")]
		public GGGJKMLDDEK(LMPMALFKFKJ AAKAOKDAEPH, BDIIOBGNKEI NGCBLOEDNKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "122")]
		protected override void OOGPOIIHFKH(MMBCHPEGPFF FNGALEILPLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public sealed class IFJPEKMIMBC : PHHDBLBBBNE<BBMKKGHFHKH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public sealed override NodeVisualizationKey CHCLNDNNNEA
		{
			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public sealed override bool HNOJBHJNLND
		{
			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "94")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		protected sealed override bool GJFDIFCADMG
		{
			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x24EF250", Offset = "0x24EE450", VA = "0x1824EF250")]
		public IFJPEKMIMBC(LMPMALFKFKJ AAKAOKDAEPH, BBMKKGHFHKH NGCBLOEDNKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x24EEF80", Offset = "0x24EE180", VA = "0x1824EEF80", Slot = "122")]
		protected override void OOGPOIIHFKH(MMBCHPEGPFF FNGALEILPLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x24EEF40", Offset = "0x24EE140", VA = "0x1824EEF40")]
		private int LKGHJBIOLNL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x24EEEE0", Offset = "0x24EE0E0", VA = "0x1824EEEE0")]
		private void IJFFJKKGJJC(int NEBBNLAKKGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public class MJMFMONCPND : CEBOMBBLHLK
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x24E3450", Offset = "0x24E2650", VA = "0x1824E3450")]
		public MJMFMONCPND(LMPMALFKFKJ AAKAOKDAEPH, HGHEIBELGCA NGCBLOEDNKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "122")]
		protected override void OOGPOIIHFKH(MMBCHPEGPFF FNGALEILPLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public sealed class OGGFIMNPFAH : DCOHGAPPALO<GBDKAEBMEKA>
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x24F9B40", Offset = "0x24F8D40", VA = "0x1824F9B40")]
		public OGGFIMNPFAH(LMPMALFKFKJ AAKAOKDAEPH, GBDKAEBMEKA NGCBLOEDNKL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public abstract class DCOHGAPPALO<TVariableNode> : PHHDBLBBBNE<TVariableNode> where TVariableNode : notnull, GBDKAEBMEKA
	{
		[Cpp2IlInjected.Token(Token = "0x20000AB")]
		[CompilerGenerated]
		private sealed class IJFILKJONDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			public DCOHGAPPALO<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			public CBPIPCCOCCI nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public IJFILKJONDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x4648550", Offset = "0x4647750", VA = "0x184648550")]
			internal bool CNNDFCIODJA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0x4648720", Offset = "0x4647920", VA = "0x184648720")]
			internal void OHJIDAACGDJ(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0x46484F0", Offset = "0x46476F0", VA = "0x1846484F0")]
			internal bool CHECEAOKJII()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0x46485B0", Offset = "0x46477B0", VA = "0x1846485B0")]
			internal void FGLIKLLHBNH(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x4648670", Offset = "0x4647870", VA = "0x184648670")]
			internal bool FHEGOLGOMJG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AC")]
		[CompilerGenerated]
		private sealed class JGMEABNPCCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			public CBPIPCCOCCI nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			public DCOHGAPPALO<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public JGMEABNPCCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FB")]
			[Cpp2IlInjected.Address(RVA = "0x482AB80", Offset = "0x4829D80", VA = "0x18482AB80")]
			internal void NDAPLDKBDJO(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public override NodeVisualizationKey CHCLNDNNNEA
		{
			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0xA78250", Offset = "0xA77450", VA = "0x180A78250", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public override EKAAGEGHDBN LKEOHNBFKGN
		{
			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0x6055570", Offset = "0x6054770", VA = "0x186055570", Slot = "96")]
			get
			{
				return default(EKAAGEGHDBN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x60553D0", Offset = "0x60545D0", VA = "0x1860553D0")]
		protected DCOHGAPPALO(LMPMALFKFKJ AAKAOKDAEPH, TVariableNode NGCBLOEDNKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x6054950", Offset = "0x6053B50", VA = "0x186054950", Slot = "90")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x6054F40", Offset = "0x6054140", VA = "0x186054F40", Slot = "122")]
		protected override void OOGPOIIHFKH(MMBCHPEGPFF FNGALEILPLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x6054AD0", Offset = "0x6053CD0", VA = "0x186054AD0", Slot = "128")]
		protected virtual void MGLGHHPEHGC(MMBCHPEGPFF FNGALEILPLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x6054E50", Offset = "0x6054050", VA = "0x186054E50", Slot = "107")]
		public override void OKECIINHNOA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x24D2880", Offset = "0x24D1A80", VA = "0x1824D2880")]
	public static CCPJLKCOOAF PAJOIGLPBMN(LMPMALFKFKJ AAKAOKDAEPH, HGHEIBELGCA NGCBLOEDNKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public sealed class CGCGEEHJEKH : AKIDJEJCFMD, KNMOPJPJIGL, LIKJLNMKBIK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public ANHNAJIBLBK<GMJCCLIJBIB> MDMJKNHFMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xBFC380", Offset = "0xBFB580", VA = "0x180BFC380", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(ANHNAJIBLBK<GMJCCLIJBIB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public ANHNAJIBLBK<IOGABLMALHO> FICGEECNFMA
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xCE9B40", Offset = "0xCE8D40", VA = "0x180CE9B40", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(ANHNAJIBLBK<IOGABLMALHO>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x24E38C0", Offset = "0x24E2AC0", VA = "0x1824E38C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	private ANHNAJIBLBK<LFJPMKFPODE> LGGDKKCBIBM
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xBFDD90", Offset = "0xBFCF90", VA = "0x180BFDD90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public override ANHNAJIBLBK<ECPNEAEENPI> MPAJDBLAMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x24E38D0", Offset = "0x24E2AD0", VA = "0x1824E38D0", Slot = "20")]
		get
		{
			return default(ANHNAJIBLBK<ECPNEAEENPI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x24E3C70", Offset = "0x24E2E70", VA = "0x1824E3C70")]
	private CGCGEEHJEKH(LMPMALFKFKJ AAKAOKDAEPH, HGHEIBELGCA NGCBLOEDNKL, LBBPBCPKAKG KMAFGMKACFL, ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO, ANHNAJIBLBK<IOGABLMALHO> KGKPKEDHPHA, ANHNAJIBLBK<LFJPMKFPODE> IHGCLKEMIIO, bool KIKLCLPKJOJ, string LMOANCJLHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x24E3920", Offset = "0x24E2B20", VA = "0x1824E3920")]
	public static CGCGEEHJEKH PAJOIGLPBMN(LMPMALFKFKJ AAKAOKDAEPH, HGHEIBELGCA NGCBLOEDNKL, LBBPBCPKAKG LFONJKFDBPG, ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO, ANHNAJIBLBK<LFJPMKFPODE> IHGCLKEMIIO, ANHNAJIBLBK<IOGABLMALHO> KGKPKEDHPHA, bool KIKLCLPKJOJ, bool GHBLBJBGAAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x24E38C0", Offset = "0x24E2AC0", VA = "0x1824E38C0")]
	internal void CFGFLAGIHBK(ANHNAJIBLBK<IOGABLMALHO> OMEFCJCOLII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public abstract class AKIDJEJCFMD : LIKJLNMKBIK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	private struct GNBAJAMNJOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private LCOBKOMKBJM? IPIKCIINACL;

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x24E6DB0", Offset = "0x24E5FB0", VA = "0x1824E6DB0")]
		public void DBGBEIOBMKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x24E6D10", Offset = "0x24E5F10", VA = "0x1824E6D10")]
		public LCOBKOMKBJM BJCHLKDAMLP(AKIDJEJCFMD MBLAAMIMJIC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	protected readonly LMPMALFKFKJ FPODCAIMPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	protected readonly HGHEIBELGCA FEFDIJFFCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private GNBAJAMNJOF BFIBAJNBOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private readonly LNEBPECIPBD MEFIIELCNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private readonly List<APPFCOKPNPB> JKAKBBIJAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private readonly List<BEDHKKEBPDB> DANJEPAKADH;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	[CKOGIBPDLCN("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> FJAOAJBOKHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x24E2080", Offset = "0x24E1280", VA = "0x1824E2080", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public DisplayKind MJGJKGHAGJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x903060", Offset = "0x902260", VA = "0x180903060", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public ANHNAJIBLBK<KJENBNHGDMG> HEKKAKHLFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x24E2330", Offset = "0x24E1530", VA = "0x1824E2330", Slot = "6")]
		get
		{
			return default(ANHNAJIBLBK<KJENBNHGDMG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public BDPEADCNJIF<KJENBNHGDMG> JNBCPLMNHFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x24E1E70", Offset = "0x24E1070", VA = "0x1824E1E70", Slot = "7")]
		get
		{
			return default(BDPEADCNJIF<KJENBNHGDMG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public OKEMALFPLKA DJOBCKAAHKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0xBD7960", Offset = "0xBD6B60", VA = "0x180BD7960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public LFEFKPMBDPG BMPABGIKEFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x24E2230", Offset = "0x24E1430", VA = "0x1824E2230", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	protected LCOBKOMKBJM PJACKOAHJGP
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x24E2230", Offset = "0x24E1430", VA = "0x1824E2230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public PortImage BELIFDGMAEE
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x24E1390", Offset = "0x24E0590", VA = "0x1824E1390", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public string PCMLNMEPCBI
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x8F9330", Offset = "0x8F8530", VA = "0x1808F9330", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x8F9240", Offset = "0x8F8440", VA = "0x1808F9240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public BDPEADCNJIF<COBLBOLGAKJ> LNBJEOAMEGL
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x24E1020", Offset = "0x24E0220", VA = "0x1824E1020", Slot = "9")]
		get
		{
			return default(BDPEADCNJIF<COBLBOLGAKJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public ANHNAJIBLBK<GIDHHIIAAHA> DKMIPKGIKMM
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0xBBA3B0", Offset = "0xBB95B0", VA = "0x180BBA3B0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(ANHNAJIBLBK<GIDHHIIAAHA>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0xCE9190", Offset = "0xCE8390", VA = "0x180CE9190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public abstract ANHNAJIBLBK<ECPNEAEENPI> MPAJDBLAMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x24E2360", Offset = "0x24E1560", VA = "0x1824E2360")]
	protected AKIDJEJCFMD(LMPMALFKFKJ AAKAOKDAEPH, HGHEIBELGCA NGCBLOEDNKL, LNEBPECIPBD JPKKDDIAAIN, ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO, bool KIKLCLPKJOJ, string LMOANCJLHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x24E14C0", Offset = "0x24E06C0", VA = "0x1824E14C0", Slot = "21")]
	protected virtual void GGPOBANFNOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x24E10A0", Offset = "0x24E02A0", VA = "0x1824E10A0", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x24E1040", Offset = "0x24E0240", VA = "0x1824E1040", Slot = "14")]
	public void BCHBGBKOJPD(APPFCOKPNPB PCOKPLBMBPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x24E21D0", Offset = "0x24E13D0", VA = "0x1824E21D0", Slot = "15")]
	public void MHOBNPLANKM(BEDHKKEBPDB PCOKPLBMBPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x24E1610", Offset = "0x24E0810", VA = "0x1824E1610", Slot = "16")]
	public void GOJKEIDHDCM(OGFNKIKFPAG KGHPJPIDAEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x24E22D0", Offset = "0x24E14D0", VA = "0x1824E22D0", Slot = "23")]
	protected virtual void OBFBIIMLAOP(OGFNKIKFPAG KGHPJPIDAEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x24E1EA0", Offset = "0x24E10A0", VA = "0x1824E1EA0")]
	private void HLPALNJLCDI(bool PIEFIBOFCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x24E1CC0", Offset = "0x24E0EC0", VA = "0x1824E1CC0")]
	private void HGFBKJKBIGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x24E11F0", Offset = "0x24E03F0", VA = "0x1824E11F0")]
	private void EACOAFODIIL([In] GHPEFICDANB ODILHHNEECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x24E2020", Offset = "0x24E1220", VA = "0x1824E2020", Slot = "17")]
	public void HNEJLNKHEMF(APPFCOKPNPB PCOKPLBMBPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x24E0FC0", Offset = "0x24E01C0", VA = "0x1824E0FC0", Slot = "18")]
	public void AIILCKPDCBE(BEDHKKEBPDB PCOKPLBMBPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x8F9240", Offset = "0x8F8440", VA = "0x1808F9240")]
	internal void ADCMMHFLCDB(string LMOANCJLHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x24E0FA0", Offset = "0x24E01A0", VA = "0x1824E0FA0")]
	internal void AEHBEPEGABC(CHIANFIEHED KHICLIFOGCP, OKEMALFPLKA MDOOANEGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0xCE9190", Offset = "0xCE8390", VA = "0x180CE9190")]
	internal void HBADALKNBJO(ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public sealed class LPIAIGGALEL : NFKPPHIGIKA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class CEHHNMHMKFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public LMPMALFKFKJ circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public HGHEIBELGCA node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public ANHNAJIBLBK<GIDHHIIAAHA> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public CEHHNMHMKFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x24E3550", Offset = "0x24E2750", VA = "0x1824E3550")]
		internal LKPOHMDECEE KHCDFNHMOFN((int PortDescIndex, int PortIndex, LNOFCFGPJLL InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x24E34C0", Offset = "0x24E26C0", VA = "0x1824E34C0")]
		internal CGCGEEHJEKH ILJIMFJDDHD(LBBPBCPKAKG i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct GFCJALNHOMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public LPIAIGGALEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private KDFMCIEGIOL <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private TaskAwaiter<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x24E60D0", Offset = "0x24E52D0", VA = "0x1824E60D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x24E6530", Offset = "0x24E5730", VA = "0x1824E6530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct LDDJOAOKHOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public LPIAIGGALEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public ANHNAJIBLBK<NEMHENHHKIC> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private KDFMCIEGIOL <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private TaskAwaiter<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x24F0390", Offset = "0x24EF590", VA = "0x1824F0390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x24F06E0", Offset = "0x24EF8E0", VA = "0x1824F06E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct FCIJOJIBEKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public LPIAIGGALEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public ANHNAJIBLBK<LFJPMKFPODE> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private KDFMCIEGIOL <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private TaskAwaiter<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x24E4BC0", Offset = "0x24E3DC0", VA = "0x1824E4BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x24E4F10", Offset = "0x24E4110", VA = "0x1824E4F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct GGDIEPGEHEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public LPIAIGGALEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public ANHNAJIBLBK<NEMHENHHKIC> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public ANHNAJIBLBK<NEMHENHHKIC> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private KDFMCIEGIOL <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private TaskAwaiter<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x24E6600", Offset = "0x24E5800", VA = "0x1824E6600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x24E6950", Offset = "0x24E5B50", VA = "0x1824E6950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct JIDBKJBJBAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public LPIAIGGALEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public ANHNAJIBLBK<LFJPMKFPODE> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public ANHNAJIBLBK<LFJPMKFPODE> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private KDFMCIEGIOL <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private TaskAwaiter<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x24EF850", Offset = "0x24EEA50", VA = "0x1824EF850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x24EFBA0", Offset = "0x24EEDA0", VA = "0x1824EFBA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct FPMEBPGKPED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public LPIAIGGALEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private KDFMCIEGIOL <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private TaskAwaiter<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x24E5B20", Offset = "0x24E4D20", VA = "0x1824E5B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x24E5F90", Offset = "0x24E5190", VA = "0x1824E5F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct PFAMKBCLGBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public LPIAIGGALEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private KDFMCIEGIOL <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private TaskAwaiter<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x24FAB50", Offset = "0x24F9D50", VA = "0x1824FAB50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x24FAEA0", Offset = "0x24FA0A0", VA = "0x1824FAEA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct POOMMKALMMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public LPIAIGGALEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public ANHNAJIBLBK<NEMHENHHKIC> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private KDFMCIEGIOL <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private TaskAwaiter<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x24FB0A0", Offset = "0x24FA2A0", VA = "0x1824FB0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x24FB3F0", Offset = "0x24FA5F0", VA = "0x1824FB3F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct CMOODJOKIID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public LPIAIGGALEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public ANHNAJIBLBK<LFJPMKFPODE> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private KDFMCIEGIOL <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private TaskAwaiter<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x24E3F50", Offset = "0x24E3150", VA = "0x1824E3F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x24E42A0", Offset = "0x24E34A0", VA = "0x1824E42A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct FENGFHNPHKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public LPIAIGGALEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public BKCDGFOGEGO type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public ANHNAJIBLBK<NEMHENHHKIC> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private KDFMCIEGIOL <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private TaskAwaiter<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x24E4F80", Offset = "0x24E4180", VA = "0x1824E4F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x24E5310", Offset = "0x24E4510", VA = "0x1824E5310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct CABDNLHANDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public LPIAIGGALEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public BKCDGFOGEGO type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public ANHNAJIBLBK<LFJPMKFPODE> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private KDFMCIEGIOL <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private TaskAwaiter<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x24E3050", Offset = "0x24E2250", VA = "0x1824E3050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x24E33E0", Offset = "0x24E25E0", VA = "0x1824E33E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private readonly bool JBLILEOBJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private readonly LMPMALFKFKJ FPODCAIMPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private readonly bool KIFEMLGFGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private PIGMDFNHJOI<DPCEHNODIAE, LKPOHMDECEE> HLEJGMMIKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private PIGMDFNHJOI<DPCEHNODIAE, FHPPJBGMDGJ> MFENDCNAHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private readonly HGHEIBELGCA FEFDIJFFCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private PIGMDFNHJOI<IOGABLMALHO, CGCGEEHJEKH> GLABENMMBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private PIGMDFNHJOI<IOGABLMALHO, KNMOPJPJIGL> DILDKPHPDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private string? MBHJMLHOKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	private readonly IIOLNKDBICB FAHAHFEOCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private ANHNAJIBLBK<GIDHHIIAAHA> IBIPMKOGGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private readonly bool KMJJILGOGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	[CompilerGenerated]
	private Action? HJFAGPCPDOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	[CompilerGenerated]
	private Action? DOIHFMBKFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	[CompilerGenerated]
	private Action<ANHNAJIBLBK<DPCEHNODIAE>>? GMONAEMCPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	[CompilerGenerated]
	private Action<ANHNAJIBLBK<IOGABLMALHO>>? KHJEHFHENEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	[CompilerGenerated]
	private NFKPPHIGIKA.EAIGLABPLEF? IIHGBNLFOBG;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool BAOJJAGPOAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x24F2290", Offset = "0x24F1490", VA = "0x1824F2290", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool PBDOEGKADFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x24F3EF0", Offset = "0x24F30F0", VA = "0x1824F3EF0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool FIOBCLKNDBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x24F6790", Offset = "0x24F5990", VA = "0x1824F6790", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public BDPEADCNJIF<KJENBNHGDMG> JNBCPLMNHFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x24F57B0", Offset = "0x24F49B0", VA = "0x1824F57B0", Slot = "7")]
		get
		{
			return default(BDPEADCNJIF<KJENBNHGDMG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool NNBJDOEKHCM
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x24F2350", Offset = "0x24F1550", VA = "0x1824F2350", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public PIGMDFNHJOI<DPCEHNODIAE, FHPPJBGMDGJ> GPOOMBKGOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D20", Offset = "0x8F3F20", VA = "0x1808F4D20", Slot = "9")]
		get
		{
			return default(PIGMDFNHJOI<DPCEHNODIAE, FHPPJBGMDGJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public string PCMLNMEPCBI
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x24F1C90", Offset = "0x24F0E90", VA = "0x1824F1C90", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public BDPEADCNJIF<COBLBOLGAKJ> LNBJEOAMEGL
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x24F1DD0", Offset = "0x24F0FD0", VA = "0x1824F1DD0", Slot = "11")]
		get
		{
			return default(BDPEADCNJIF<COBLBOLGAKJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public PIGMDFNHJOI<IOGABLMALHO, KNMOPJPJIGL> PPDHIAAHKGE
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x8F9330", Offset = "0x8F8530", VA = "0x1808F9330", Slot = "12")]
		get
		{
			return default(PIGMDFNHJOI<IOGABLMALHO, KNMOPJPJIGL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public ANHNAJIBLBK<GIDHHIIAAHA> DKMIPKGIKMM
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0xA56060", Offset = "0xA55260", VA = "0x180A56060", Slot = "13")]
		get
		{
			return default(ANHNAJIBLBK<GIDHHIIAAHA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action EPFBEOBJGMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x24F2480", Offset = "0x24F1680", VA = "0x1824F2480", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x24F72C0", Offset = "0x24F64C0", VA = "0x1824F72C0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action OLPOECDNELD
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x24F23D0", Offset = "0x24F15D0", VA = "0x1824F23D0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x24F6EC0", Offset = "0x24F60C0", VA = "0x1824F6EC0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<ANHNAJIBLBK<DPCEHNODIAE>, ANHNAJIBLBK<DPCEHNODIAE>> LPBDECPNCKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x24F66D0", Offset = "0x24F58D0", VA = "0x1824F66D0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x24F5E20", Offset = "0x24F5020", VA = "0x1824F5E20", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<ANHNAJIBLBK<DPCEHNODIAE>, ANHNAJIBLBK<DPCEHNODIAE>> GJGDHBDAHMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x24F21D0", Offset = "0x24F13D0", VA = "0x1824F21D0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x24F6610", Offset = "0x24F5810", VA = "0x1824F6610", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<ANHNAJIBLBK<IOGABLMALHO>, ANHNAJIBLBK<IOGABLMALHO>> CMLODKIFLJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x24F3D50", Offset = "0x24F2F50", VA = "0x1824F3D50", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x24F3E30", Offset = "0x24F3030", VA = "0x1824F3E30", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<ANHNAJIBLBK<IOGABLMALHO>, ANHNAJIBLBK<IOGABLMALHO>> JAIGAPHICOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x24F6850", Offset = "0x24F5A50", VA = "0x1824F6850", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x24F3390", Offset = "0x24F2590", VA = "0x1824F3390", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<ANHNAJIBLBK<DPCEHNODIAE>, FHPPJBGMDGJ> HGHPLPABHIO
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x24F6550", Offset = "0x24F5750", VA = "0x1824F6550", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x24F2110", Offset = "0x24F1310", VA = "0x1824F2110", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<ANHNAJIBLBK<DPCEHNODIAE>> AIEEHBPALIE
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x24F4AA0", Offset = "0x24F3CA0", VA = "0x1824F4AA0", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x24F3510", Offset = "0x24F2710", VA = "0x1824F3510", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<ANHNAJIBLBK<DPCEHNODIAE>, FHPPJBGMDGJ> GJKJGPPFDFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x24F6E00", Offset = "0x24F6000", VA = "0x1824F6E00", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x24F1F00", Offset = "0x24F1100", VA = "0x1824F1F00", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<ANHNAJIBLBK<IOGABLMALHO>, KNMOPJPJIGL> HAHFIAODJMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x24F7A80", Offset = "0x24F6C80", VA = "0x1824F7A80", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x24F2520", Offset = "0x24F1720", VA = "0x1824F2520", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<ANHNAJIBLBK<IOGABLMALHO>> NBEKFCOFCBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x24F3450", Offset = "0x24F2650", VA = "0x1824F3450", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x24F2710", Offset = "0x24F1910", VA = "0x1824F2710", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<ANHNAJIBLBK<IOGABLMALHO>, KNMOPJPJIGL> CLIKKMDNDCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x24F7360", Offset = "0x24F6560", VA = "0x1824F7360", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x24F27D0", Offset = "0x24F19D0", VA = "0x1824F27D0", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x24F7B40", Offset = "0x24F6D40", VA = "0x1824F7B40")]
	private LPIAIGGALEL(bool KIKLCLPKJOJ, LMPMALFKFKJ AAKAOKDAEPH, bool ODKFFLCKECN, PIGMDFNHJOI<DPCEHNODIAE, LKPOHMDECEE> CMFAFHOHLCM, PIGMDFNHJOI<DPCEHNODIAE, FHPPJBGMDGJ> KCLFDAKHCOI, HGHEIBELGCA NGCBLOEDNKL, PIGMDFNHJOI<IOGABLMALHO, CGCGEEHJEKH> LFMCIIJJCKJ, PIGMDFNHJOI<IOGABLMALHO, KNMOPJPJIGL> DIADNLIPIHC, string? PEAAHBKJJAH, IIOLNKDBICB LOAGOAPIFOH, ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO, bool GHBLBJBGAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x24F7420", Offset = "0x24F6620", VA = "0x1824F7420")]
	public static LPIAIGGALEL PAJOIGLPBMN(bool KIKLCLPKJOJ, LMPMALFKFKJ AAKAOKDAEPH, bool ODKFFLCKECN, HGHEIBELGCA NGCBLOEDNKL, IIOLNKDBICB LOAGOAPIFOH, ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO, bool GHBLBJBGAAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x24F42F0", Offset = "0x24F34F0", VA = "0x1824F42F0")]
	private void GGPOBANFNOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x24F2890", Offset = "0x24F1A90", VA = "0x1824F2890", Slot = "49")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x24F6460", Offset = "0x24F5660", VA = "0x1824F6460", Slot = "38")]
	[AsyncStateMachine(typeof(GFCJALNHOMC))]
	public Task<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> JJELCHAIIJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x24F7090", Offset = "0x24F6290", VA = "0x1824F7090")]
	private (LFGDAPJCGGN, int)? NAFANFBHNKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x24F5840", Offset = "0x24F4A40", VA = "0x1824F5840")]
	private void HHJBGDAKGDJ(int DPGPGLMOKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x1CF48B0", Offset = "0x1CF3AB0", VA = "0x181CF48B0")]
	private void IOFDEKNELKF(int DPGPGLMOKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x24F3F50", Offset = "0x24F3150", VA = "0x1824F3F50")]
	private void GDAMELPGHGH(int EDKCCGPGEGE, int NDMPLNINPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x24F57E0", Offset = "0x24F49E0", VA = "0x1824F57E0")]
	private void HHFBGNGFMBD(int EDKCCGPGEGE, int NDMPLNINPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x24F36E0", Offset = "0x24F28E0", VA = "0x1824F36E0")]
	private void EIMJMLLGODC(int DPGPGLMOKLB, ANHNAJIBLBK<DPCEHNODIAE> JACBAHLBGNA, LNOFCFGPJLL GBPBPMJPBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x24F3F30", Offset = "0x24F3130", VA = "0x1824F3F30")]
	private void FICNBOJBAOP(int PIEFIBOFCOC, ANHNAJIBLBK<DPCEHNODIAE> JACBAHLBGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x24F3E10", Offset = "0x24F3010", VA = "0x1824F3E10")]
	private void FBABLJBACEL(int PIEFIBOFCOC, ANHNAJIBLBK<DPCEHNODIAE> JACBAHLBGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x24F5EE0", Offset = "0x24F50E0", VA = "0x1824F5EE0")]
	private void IHKDMMMMMJO(int DPGPGLMOKLB, ANHNAJIBLBK<DPCEHNODIAE> JACBAHLBGNA, LNOFCFGPJLL GBPBPMJPBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x24F1FC0", Offset = "0x24F11C0", VA = "0x1824F1FC0")]
	private void BIFPNPFMGDO(int DPGPGLMOKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x1103000", Offset = "0x1102200", VA = "0x181103000")]
	private void GCAIGEFKLEM(int DPGPGLMOKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x24F1CE0", Offset = "0x24F0EE0", VA = "0x1824F1CE0")]
	private void AGOLKOHCKDO(int DPGPGLMOKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x1CF48B0", Offset = "0x1CF3AB0", VA = "0x181CF48B0")]
	private void BECMKJLEMFP(int DPGPGLMOKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x24F5A80", Offset = "0x24F4C80", VA = "0x1824F5A80")]
	private void HJMJIEFICMJ(int EDKCCGPGEGE, int NDMPLNINPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x24F6930", Offset = "0x24F5B30", VA = "0x1824F6930")]
	private void LAMMDELMAND(int EDKCCGPGEGE, int NDMPLNINPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x24F4B60", Offset = "0x24F3D60", VA = "0x1824F4B60")]
	private void GJGIJIALKKC(int DPGPGLMOKLB, ANHNAJIBLBK<IOGABLMALHO> JACBAHLBGNA, LBBPBCPKAKG GBPBPMJPBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x24F1CC0", Offset = "0x24F0EC0", VA = "0x1824F1CC0")]
	private void AFFLIBAHGFK(int PIEFIBOFCOC, ANHNAJIBLBK<IOGABLMALHO> JACBAHLBGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x24F6910", Offset = "0x24F5B10", VA = "0x1824F6910")]
	private void LAMJHJNHFCJ(int PIEFIBOFCOC, ANHNAJIBLBK<IOGABLMALHO> JACBAHLBGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x24F6990", Offset = "0x24F5B90", VA = "0x1824F6990")]
	private void LELMECMMMML(int DPGPGLMOKLB, ANHNAJIBLBK<IOGABLMALHO> JACBAHLBGNA, LBBPBCPKAKG GBPBPMJPBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x24F5930", Offset = "0x24F4B30", VA = "0x1824F5930")]
	private void HHNMEGFNOML(int DPGPGLMOKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x1103000", Offset = "0x1102200", VA = "0x181103000")]
	private void GDKHPADKHDM(int DPGPGLMOKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x24F1DF0", Offset = "0x24F0FF0", VA = "0x1824F1DF0", Slot = "39")]
	[AsyncStateMachine(typeof(LDDJOAOKHOL))]
	public Task<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> BAOBBHABHJP(ANHNAJIBLBK<NEMHENHHKIC> JIAOICBDGLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x24F35D0", Offset = "0x24F27D0", VA = "0x1824F35D0", Slot = "40")]
	[AsyncStateMachine(typeof(FCIJOJIBEKH))]
	public Task<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> EFOIOLLMEBK(ANHNAJIBLBK<LFJPMKFPODE> IHGCLKEMIIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x24F51D0", Offset = "0x24F43D0", VA = "0x1824F51D0", Slot = "41")]
	[AsyncStateMachine(typeof(GGDIEPGEHEI))]
	public Task<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> GNKNJIDBIPB(ANHNAJIBLBK<NEMHENHHKIC> JIAOICBDGLF, ANHNAJIBLBK<NEMHENHHKIC> JHJLHBPEGPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x24F52F0", Offset = "0x24F44F0", VA = "0x1824F52F0", Slot = "42")]
	[AsyncStateMachine(typeof(JIDBKJBJBAO))]
	public Task<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> GOIGHJKAHMH(ANHNAJIBLBK<LFJPMKFPODE> IHGCLKEMIIO, ANHNAJIBLBK<LFJPMKFPODE> JHJLHBPEGPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x24F7990", Offset = "0x24F6B90", VA = "0x1824F7990", Slot = "43")]
	[AsyncStateMachine(typeof(FPMEBPGKPED))]
	public Task<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> PCJNKNMAJLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x24F6F70", Offset = "0x24F6170", VA = "0x1824F6F70", Slot = "44")]
	[AsyncStateMachine(typeof(PFAMKBCLGBH))]
	public Task<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> MDOALDPIKLH(string JLOPIPPDIOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x24F6330", Offset = "0x24F5530", VA = "0x1824F6330", Slot = "45")]
	[AsyncStateMachine(typeof(POOMMKALMMD))]
	public Task<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> JELNGLOFGHG(ANHNAJIBLBK<NEMHENHHKIC> JIAOICBDGLF, string LMOANCJLHKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x24F3C20", Offset = "0x24F2E20", VA = "0x1824F3C20", Slot = "46")]
	[AsyncStateMachine(typeof(CMOODJOKIID))]
	public Task<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> EJBABBNAPGN(ANHNAJIBLBK<LFJPMKFPODE> IHGCLKEMIIO, string LMOANCJLHKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x24F50A0", Offset = "0x24F42A0", VA = "0x1824F50A0", Slot = "47")]
	[AsyncStateMachine(typeof(FENGFHNPHKK))]
	public Task<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> GJGINOLIOCG(ANHNAJIBLBK<NEMHENHHKIC> JIAOICBDGLF, BKCDGFOGEGO MDOOANEGCAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x24F25E0", Offset = "0x24F17E0", VA = "0x1824F25E0", Slot = "48")]
	[AsyncStateMachine(typeof(CABDNLHANDD))]
	public Task<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> DNHDCBPPOJF(ANHNAJIBLBK<LFJPMKFPODE> IHGCLKEMIIO, BKCDGFOGEGO MDOOANEGCAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x24F5410", Offset = "0x24F4610", VA = "0x1824F5410")]
	internal void HBADALKNBJO(ANHNAJIBLBK<GIDHHIIAAHA> OMEFCJCOLII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public sealed class PNCACGINIMH : HPMNCAGGPMJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public interface LINOLILKBJL
	{
		[Cpp2IlInjected.Token(Token = "0x20000C1")]
		public readonly struct DLGMDJADLLN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400026A")]
			public readonly IReadOnlyDictionary<BDPEADCNJIF<KJENBNHGDMG>, Guid>? AFBNIFKGPAL;

			[Cpp2IlInjected.Token(Token = "0x6000493")]
			[Cpp2IlInjected.Address(RVA = "0xBC2740", Offset = "0xBC1940", VA = "0x180BC2740")]
			public DLGMDJADLLN(IReadOnlyDictionary<BDPEADCNJIF<KJENBNHGDMG>, Guid>? AFBNIFKGPAL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		CHIANFIEHED OKIJOPNFMDN
		{
			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<NHLHHLCCGOO> AAKPENCOGDK(CancellationToken BGEKICMONBE);

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<CGFMNABJBKA> JCAFKONHAPA(CancellationToken BGEKICMONBE);

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<NCMNDHGNHEG> ONBADNMEGLI(CancellationToken BGEKICMONBE);

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<DLGMDJADLLN> EKLFPPNEFLG(CancellationToken BGEKICMONBE);

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<CDBOHIAHHFA> IBDHOFOOLLF(CancellationToken BGEKICMONBE);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct OOJDNOJHDLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public AsyncTaskMethodBuilder<PNCACGINIMH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public LMPMALFKFKJ circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public NHLHHLCCGOO roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public CGFMNABJBKA superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private LINOLILKBJL <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private NHLHHLCCGOO <downloadedRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private NHLHHLCCGOO <actualRoomData>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private CDBOHIAHHFA <actualStaticConfig>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private CGFMNABJBKA <finalSuperRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private NCMNDHGNHEG <playerSaveData>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private TaskAwaiter<NHLHHLCCGOO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private NHLHHLCCGOO <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private TaskAwaiter<CDBOHIAHHFA> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private TaskAwaiter<CGFMNABJBKA> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private TaskAwaiter<NCMNDHGNHEG> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private TaskAwaiter<LINOLILKBJL.DLGMDJADLLN> <>u__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private TaskAwaiter<MBGMEAFLNHF> <>u__6;

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x24F9C60", Offset = "0x24F8E60", VA = "0x1824F9C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x24FAAE0", Offset = "0x24F9CE0", VA = "0x1824FAAE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private readonly MBGMEAFLNHF ACDCEDNHCPG;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public MBGMEAFLNHF DHKOPMPHGOM
	{
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x902B20", Offset = "0x901D20", VA = "0x180902B20")]
	private PNCACGINIMH(MBGMEAFLNHF FDJHAMGLPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x24FAF30", Offset = "0x24FA130", VA = "0x1824FAF30")]
	[AsyncStateMachine(typeof(OOJDNOJHDLB))]
	public static Task<PNCACGINIMH> JBKCFEIEBFA(LMPMALFKFKJ AAKAOKDAEPH, NHLHHLCCGOO? JPGPNLNCOHG, CGFMNABJBKA? JBBABNEKIMJ, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x24FAF10", Offset = "0x24FA110", VA = "0x1824FAF10", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public readonly struct BOFLHCMGKBM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private struct JBCHAAFLJGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<object, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public BOFLHCMGKBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public NAGMPGBKIGM action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private TaskAwaiter<EBOICGKKPAM<object, LKEBDJCDIFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x24EF550", Offset = "0x24EE750", VA = "0x1824EF550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x24EF7E0", Offset = "0x24EE9E0", VA = "0x1824EF7E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private struct GNIHMLOPNHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<bool, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public BOGHAPBEAMM rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public NHLHHLCCGOO circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public CGFMNABJBKA superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public BOFLHCMGKBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private NAGMPGBKIGM[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private TaskAwaiter<EBOICGKKPAM<object, LKEBDJCDIFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x24E6DC0", Offset = "0x24E5FC0", VA = "0x1824E6DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x24E71A0", Offset = "0x24E63A0", VA = "0x1824E71A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private struct KICEGFNCGMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public BOFLHCMGKBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private TaskAwaiter<EBOICGKKPAM<object, LKEBDJCDIFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x24EFDA0", Offset = "0x24EEFA0", VA = "0x1824EFDA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x24EFFE0", Offset = "0x24EF1E0", VA = "0x1824EFFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private readonly NOJMHINMKNJ BIPEKGMIANC;

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0xBC2740", Offset = "0xBC1940", VA = "0x180BC2740")]
	public BOFLHCMGKBM(NOJMHINMKNJ LECMOIOCNBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x24E2540", Offset = "0x24E1740", VA = "0x1824E2540")]
	[AsyncStateMachine(typeof(JBCHAAFLJGD))]
	private Task<EBOICGKKPAM<object, LKEBDJCDIFL>> IECLPOHOKAN(NAGMPGBKIGM KOMGLJOLBFC, bool MMLBLFDFKKN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x24E2760", Offset = "0x24E1960", VA = "0x1824E2760")]
	[AsyncStateMachine(typeof(GNIHMLOPNHN))]
	public Task<EBOICGKKPAM<bool, LKEBDJCDIFL?>>? LEIALIMADAM(int GCCOAFCFPIK, BOGHAPBEAMM? HENCMBBFEOD, NHLHHLCCGOO? OOOHBNNMLEC, CGFMNABJBKA? JBBABNEKIMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x24E2670", Offset = "0x24E1870", VA = "0x1824E2670")]
	[AsyncStateMachine(typeof(KICEGFNCGMD))]
	public Task<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> LEGDOGAINAB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public sealed class FPGAMNLECFF : FFDLFADJEBF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private readonly PECNFONAIGO GADPPJIKNLE;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public PECNFONAIGO FHPKNBINLNG
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x902B20", Offset = "0x901D20", VA = "0x180902B20")]
	private FPGAMNLECFF(PECNFONAIGO CGNENGJHAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x24E5930", Offset = "0x24E4B30", VA = "0x1824E5930")]
	public static FPGAMNLECFF LAEIJKNHIPI(LMPMALFKFKJ AAKAOKDAEPH, BOGHAPBEAMM LMACDEEEICM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x24E5910", Offset = "0x24E4B10", VA = "0x1824E5910", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public interface JKADNBJIIJM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	MBGMEAFLNHF DHKOPMPHGOM
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	CGAOFJCMGML KBGKKMPDGBF
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	BNEGCEMMIBM NKLAOACKIPA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	ICAAAPILHBO KNJIABIFCHP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public interface LGJADAHPADD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	JKADNBJIIJM? CDMKBKDKAHK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	bool EHPNJBGMJGK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	bool PBJAGLFIPMM
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<JKADNBJIIJM?>? LKAKBMIBPMB();

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task BJBGDKKFAIP(LMPMALFKFKJ AAKAOKDAEPH, BOGHAPBEAMM LMACDEEEICM, NHLHHLCCGOO? FNFHKHEPBDF, CGFMNABJBKA? JIEGKCDEJMM);
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[JEPHFDPHFND("IStaticCV2Instance")]
public interface HPMNCAGGPMJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	MBGMEAFLNHF DHKOPMPHGOM
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[JEPHFDPHFND("IStaticEVInstance")]
public interface FFDLFADJEBF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	PECNFONAIGO FHPKNBINLNG
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public static class MJOBMEHNFNG
{
	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x24F8710", Offset = "0x24F7910", VA = "0x1824F8710")]
	public static IHLMHPIPNGI<MELNNHKBONO, NAGMPGBKIGM, LMPMALFKFKJ, PICIEGNBDJL.EEIAMFPGFEG<MELNNHKBONO, NAGMPGBKIGM, LMPMALFKFKJ>> LOMOLFODDED([In] this IHLMHPIPNGI<MELNNHKBONO, NAGMPGBKIGM, LMPMALFKFKJ, PICIEGNBDJL.EEIAMFPGFEG<MELNNHKBONO, NAGMPGBKIGM, LMPMALFKFKJ>> NEBBEBFFPMG)
	{
		return default(IHLMHPIPNGI<MELNNHKBONO, NAGMPGBKIGM, LMPMALFKFKJ, PICIEGNBDJL.EEIAMFPGFEG<MELNNHKBONO, NAGMPGBKIGM, LMPMALFKFKJ>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public sealed class AKKMBPLHKIN : GEHPPECDDFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private readonly LMPMALFKFKJ FPODCAIMPFE;

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool PBJAGLFIPMM
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x24E24C0", Offset = "0x24E16C0", VA = "0x1824E24C0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x902B20", Offset = "0x901D20", VA = "0x180902B20")]
	internal AKKMBPLHKIN(LMPMALFKFKJ AAKAOKDAEPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal sealed class DKKPOMAIAMK : INDGHAOOEDB
{
	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x24E4560", Offset = "0x24E3760", VA = "0x1824E4560", Slot = "4")]
	public KHOCFJPALNE? IBAIGAMJPMP(string? GOIOAGLFIIC, string? CGHHENAEJKH, string? KGADDLANHJD, NNHLHKOAFBF.JAFJGHIHMGF.BLCGJKAIMEH GKNDJBAGDMJ, bool NOGJIGADDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public DKKPOMAIAMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public sealed class LLMBKOBKCNP : NOOIGCIPMNI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private struct MMLOIMOOOPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public AsyncTaskMethodBuilder<ALBLMFHGEEB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public LLMBKOBKCNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private TaskAwaiter<JKADNBJIIJM?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x24F8BC0", Offset = "0x24F7DC0", VA = "0x1824F8BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x24F8E50", Offset = "0x24F8050", VA = "0x1824F8E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private readonly LMPMALFKFKJ FPODCAIMPFE;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public ALBLMFHGEEB? CLACNPDFIIL
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x24F11A0", Offset = "0x24F03A0", VA = "0x1824F11A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public ICAAAPILHBO? LAAPHGEDIKL
	{
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x24F0E90", Offset = "0x24F0090", VA = "0x1824F0E90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool NAPAOCJADDI
	{
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x24F1550", Offset = "0x24F0750", VA = "0x1824F1550", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool BKDNDAODIHH
	{
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x24F1920", Offset = "0x24F0B20", VA = "0x1824F1920", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x24F1980", Offset = "0x24F0B80", VA = "0x1824F1980")]
	internal LLMBKOBKCNP(LMPMALFKFKJ AAKAOKDAEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x24F10B0", Offset = "0x24F02B0", VA = "0x1824F10B0", Slot = "7")]
	[AsyncStateMachine(typeof(MMLOIMOOOPD))]
	public Task<ALBLMFHGEEB> CBPFFPGPIIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x24F15B0", Offset = "0x24F07B0", VA = "0x1824F15B0", Slot = "9")]
	public IReadOnlyDictionary<BDPEADCNJIF<KJENBNHGDMG>, Guid> JJPGNPCPCLC(IEnumerable<INLFGDDOIPN> MCFHJJMDJMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x24F1220", Offset = "0x24F0420", VA = "0x1824F1220", Slot = "10")]
	public CHMGLCHDKIC EDIOAINJJHK(IEnumerable<INLFGDDOIPN> MCFHJJMDJMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x24F13B0", Offset = "0x24F05B0", VA = "0x1824F13B0")]
	public EBOICGKKPAM<DPCHNDCNHNM, MNCKOMAJMKB> HMKBDINHMPK([In] DPCHNDCNHNM LKMIDPBHECJ)
	{
		return default(EBOICGKKPAM<DPCHNDCNHNM, MNCKOMAJMKB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x24F0F10", Offset = "0x24F0110", VA = "0x1824F0F10", Slot = "8")]
	private EBOICGKKPAM<DPCHNDCNHNM, MNCKOMAJMKB> CBOPLPDCKAJ([In] DPCHNDCNHNM LKMIDPBHECJ)
	{
		return default(EBOICGKKPAM<DPCHNDCNHNM, MNCKOMAJMKB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public sealed class ICAAAPILHBO : ALBLMFHGEEB
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	internal static class CICDHBBCEAP
	{
		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		[CompilerGenerated]
		private sealed class PBLDCGOPCEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002A6")]
			public MBGMEAFLNHF state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002A7")]
			public ONIEEENHFNK spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x600051F")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public PBLDCGOPCEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000520")]
			[Cpp2IlInjected.Address(RVA = "0x2504E30", Offset = "0x2504030", VA = "0x182504E30")]
			internal bool AMOPPLGGAPB(PBBLFFOPPPF n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		[CompilerGenerated]
		private sealed class JPNGONNMNJD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002A8")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x6000521")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public JPNGONNMNJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000522")]
			[Cpp2IlInjected.Address(RVA = "0x2502320", Offset = "0x2501520", VA = "0x182502320")]
			internal void PPDPJMPDKGC(PBBLFFOPPPF n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x24FDDE0", Offset = "0x24FCFE0", VA = "0x1824FDDE0")]
		public static EBOICGKKPAM<ALBLMFHGEEB.NLBJDMHOHKG, CKNADPBHIII> BOIJOOGLJMA(ICAAAPILHBO MLNFAKCEGNM, [In] ALBLMFHGEEB.FLKEDFFFMGF OKBEKNPNPIM)
		{
			return default(EBOICGKKPAM<ALBLMFHGEEB.NLBJDMHOHKG, CKNADPBHIII>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x24FE840", Offset = "0x24FDA40", VA = "0x1824FE840")]
		internal static EBOICGKKPAM<(OMABDNNEKDE, MDALCOKINHG), CKNADPBHIII> NPLOLIELEPF(ICAAAPILHBO MLNFAKCEGNM, MDALCOKINHG ODCMEPCKAIB, bool ANNGLNBKOCN, [In] BDPEADCNJIF<KJENBNHGDMG> ALMMNANMBIM, [In] int? LKLDOAEMJLI, [In] PDAHHPHGJBJ? JCAFNFOPCHL, [In] PDAHHPHGJBJ? OPHIOJNLCHL)
		{
			return default(EBOICGKKPAM<(OMABDNNEKDE, MDALCOKINHG), CKNADPBHIII>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x24FF760", Offset = "0x24FE960", VA = "0x1824FF760")]
		private static void PCLEPJIAIII(bool ANNGLNBKOCN, INLFGDDOIPN HMHIBHFIJPG, OMABDNNEKDE ANMIIEDDBJA, [In] BDPEADCNJIF<KJENBNHGDMG> ALMMNANMBIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x24FE440", Offset = "0x24FD640", VA = "0x1824FE440")]
		public static void LJNOFDCBGHL(HONBLNKEJDH OFNHGNOPMPC, [In] ALBLMFHGEEB.MAJEHADJCFO DLFOEFAPLGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x24FE320", Offset = "0x24FD520", VA = "0x1824FE320")]
		[CompilerGenerated]
		internal static bool JKMNABEDDOJ(MBGMEAFLNHF DCLBHCBCMIN, ONIEEENHFNK PJKBFBEBEHM, PBBLFFOPPPF IIGBCPLCPJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x24FE410", Offset = "0x24FD610", VA = "0x1824FE410")]
		[CompilerGenerated]
		internal static bool KKHPIKMCPAH(PBBLFFOPPPF HLMPJHIDIOP)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct HOBMAKPMHGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public ICAAAPILHBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public ANHNAJIBLBK<KJENBNHGDMG> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public ANHNAJIBLBK<COBLBOLGAKJ> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public NFONEEMNPCB offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public bool deleteBoard;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private TaskAwaiter<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x2501540", Offset = "0x2500740", VA = "0x182501540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x2501790", Offset = "0x2500990", VA = "0x182501790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct OFPAAABKIDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public ICAAAPILHBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public ANHNAJIBLBK<KJENBNHGDMG> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public BDPEADCNJIF<COBLBOLGAKJ> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public List<ANHNAJIBLBK<COBLBOLGAKJ>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public NFONEEMNPCB localBoardPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public JODENAIICMG localBoardRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public NFONEEMNPCB offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private TaskAwaiter<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x2504B00", Offset = "0x2503D00", VA = "0x182504B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x2504DC0", Offset = "0x2503FC0", VA = "0x182504DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct FHDDBIMANBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public ICAAAPILHBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public ANHNAJIBLBK<KJENBNHGDMG> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public BDPEADCNJIF<COBLBOLGAKJ> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public List<ANHNAJIBLBK<COBLBOLGAKJ>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private TaskAwaiter<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x2500600", Offset = "0x24FF800", VA = "0x182500600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x2500840", Offset = "0x24FFA40", VA = "0x182500840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct NGKOCELDKGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public ICAAAPILHBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public ANHNAJIBLBK<KJENBNHGDMG> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public BDPEADCNJIF<COBLBOLGAKJ> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public ANHNAJIBLBK<KJENBNHGDMG> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public List<ANHNAJIBLBK<COBLBOLGAKJ>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private TaskAwaiter<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x25045F0", Offset = "0x25037F0", VA = "0x1825045F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x2504830", Offset = "0x2503A30", VA = "0x182504830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private struct IAKDLICIMJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public ICAAAPILHBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public BDPEADCNJIF<KJENBNHGDMG> legacyGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public BDPEADCNJIF<COBLBOLGAKJ> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public IReadOnlyList<BDPEADCNJIF<COBLBOLGAKJ>> nodeLegacyIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public IReadOnlyDictionary<EPPICOBLCPG, (ANHNAJIBLBK<GIDHHIIAAHA>, ANHNAJIBLBK<DPCEHNODIAE>)> inputMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public IReadOnlyDictionary<AAAPEEEHHLJ, (ANHNAJIBLBK<GIDHHIIAAHA>, ANHNAJIBLBK<IOGABLMALHO>)> outputMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private TaskAwaiter<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x2501800", Offset = "0x2500A00", VA = "0x182501800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x2501DB0", Offset = "0x2500FB0", VA = "0x182501DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct AFDAEMAGJCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public ICAAAPILHBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public ANHNAJIBLBK<KJENBNHGDMG> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public ANHNAJIBLBK<GMJCCLIJBIB> srcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public ANHNAJIBLBK<FOIPKNJPLLP> dstId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private TaskAwaiter<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x24FD6C0", Offset = "0x24FC8C0", VA = "0x1824FD6C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x24FDD10", Offset = "0x24FCF10", VA = "0x1824FDD10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[CompilerGenerated]
	private struct MLBLCGKAAHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public ICAAAPILHBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public BDPEADCNJIF<COBLBOLGAKJ> inputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public BDPEADCNJIF<KJENBNHGDMG> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public ANHNAJIBLBK<GIDHHIIAAHA> inputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public ANHNAJIBLBK<DPCEHNODIAE> inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private TaskAwaiter<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x2503DB0", Offset = "0x2502FB0", VA = "0x182503DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x25040F0", Offset = "0x25032F0", VA = "0x1825040F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private struct PPAGALKMIBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public ICAAAPILHBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public BDPEADCNJIF<COBLBOLGAKJ> outputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public BDPEADCNJIF<KJENBNHGDMG> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public ANHNAJIBLBK<GIDHHIIAAHA> outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public ANHNAJIBLBK<IOGABLMALHO> outputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private TaskAwaiter<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x2504F20", Offset = "0x2504120", VA = "0x182504F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x2505260", Offset = "0x2504460", VA = "0x182505260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private readonly LMPMALFKFKJ FPODCAIMPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	private readonly HPMNCAGGPMJ NIKFCHNIJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	private readonly FFDLFADJEBF GIOOPEBNCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	private readonly JNAMLBBBLIH EIABKFPGMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	private readonly LLMBKOBKCNP ECOBGLPACEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	private Dictionary<BDPEADCNJIF<COBLBOLGAKJ>, CCPJLKCOOAF> PEKEAABANAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	[CompilerGenerated]
	private Action<BDPEADCNJIF<COBLBOLGAKJ>>? IFBDFJEIGMI;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public BDPEADCNJIF<KJENBNHGDMG> CNJHPNBBGPE
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x24EB4B0", Offset = "0x24EA6B0", VA = "0x1824EB4B0", Slot = "4")]
		get
		{
			return default(BDPEADCNJIF<KJENBNHGDMG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public JNAMLBBBLIH ICKLMHPBMMB
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x24DBF10", Offset = "0x24DB110", VA = "0x1824DBF10", Slot = "5")]
		get
		{
			return default(JNAMLBBBLIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x24EE9C0", Offset = "0x24EDBC0", VA = "0x1824EE9C0")]
	public ICAAAPILHBO(LMPMALFKFKJ AAKAOKDAEPH, HPMNCAGGPMJ DHDIHDEIOFL, FFDLFADJEBF CADJMLCOBPH, LLMBKOBKCNP PBIHLCBAANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x24EE010", Offset = "0x24ED210", VA = "0x1824EE010", Slot = "63")]
	public ANHNAJIBLBK<KNFFGCFEOGG> OPHCPKOCDMI(ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<FOIPKNJPLLP> CFHBDBIEIEP)
	{
		return default(ANHNAJIBLBK<KNFFGCFEOGG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x24ECFA0", Offset = "0x24EC1A0", VA = "0x1824ECFA0", Slot = "64")]
	public ANHNAJIBLBK<HHEEBPMGKBH> MCNBCNLJAEB(ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<GMJCCLIJBIB> KGKPKEDHPHA)
	{
		return default(ANHNAJIBLBK<HHEEBPMGKBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x24EBD50", Offset = "0x24EAF50", VA = "0x1824EBD50", Slot = "6")]
	public (bool, bool) JLGMGEHPKID(ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<GMJCCLIJBIB> GACGPNNNIMO, ANHNAJIBLBK<FOIPKNJPLLP> PANLMNAHCML)
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x24EE540", Offset = "0x24ED740", VA = "0x1824EE540")]
	public bool PKLPAIDIMDC(ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, [In] FECOLOJALFF FIMIODHINLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x24EDC60", Offset = "0x24ECE60", VA = "0x1824EDC60", Slot = "8")]
	public bool OAMBLDPIHPN(FHPPJBGMDGJ AHGGACHFIEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x24EB510", Offset = "0x24EA710", VA = "0x1824EB510", Slot = "9")]
	public bool HDBIDBAJKGB(KNMOPJPJIGL EHBJEOGIDPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x24EC4E0", Offset = "0x24EB6E0", VA = "0x1824EC4E0", Slot = "10")]
	public NABIBIJKKJM? KPPPFFKFPGF(ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<FOIPKNJPLLP> CFHBDBIEIEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x24EE100", Offset = "0x24ED300", VA = "0x1824EE100", Slot = "11")]
	public LDLLOAGMLGL? PGCBALMNHHC(ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<GMJCCLIJBIB> KGKPKEDHPHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x24E8CE0", Offset = "0x24E7EE0", VA = "0x1824E8CE0", Slot = "12")]
	public ANHNAJIBLBK<GMJCCLIJBIB>? AKLKGLFLMLK(ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<COBLBOLGAKJ> MFMLNNMNGAP, ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO, ANHNAJIBLBK<IOGABLMALHO> KPAHGANODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x24E9A20", Offset = "0x24E8C20", VA = "0x1824E9A20", Slot = "13")]
	public ANHNAJIBLBK<FOIPKNJPLLP>? EGHCONNLAAB(ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<COBLBOLGAKJ> MFMLNNMNGAP, ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO, ANHNAJIBLBK<DPCEHNODIAE> JKBGDBBPBCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x24E9520", Offset = "0x24E8720", VA = "0x1824E9520", Slot = "14")]
	public IEnumerable<ANHNAJIBLBK<KJENBNHGDMG>> CAOKMDHJAIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x24EDF60", Offset = "0x24ED160", VA = "0x1824EDF60", Slot = "15")]
	public IEnumerable<ANHNAJIBLBK<PEOLKLIEBJB>> OIGIAAHIINI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x24EE090", Offset = "0x24ED290", VA = "0x1824EE090", Slot = "16")]
	public string OPIPDAICNMI(ANHNAJIBLBK<PEOLKLIEBJB> DBFALLLDDEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x24EB590", Offset = "0x24EA790", VA = "0x1824EB590", Slot = "17")]
	public string HFGJHHNAHNL(ANHNAJIBLBK<PEOLKLIEBJB> DBFALLLDDEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x24ED4E0", Offset = "0x24EC6E0", VA = "0x1824ED4E0")]
	public CCPJLKCOOAF? NACHKDGHBAK([In] BDPEADCNJIF<COBLBOLGAKJ> MFMLNNMNGAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x24EB010", Offset = "0x24EA210", VA = "0x1824EB010", Slot = "23")]
	public ANHNAJIBLBK<KGOBMFADMHP> GBPMJFJOCHJ(ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<COBLBOLGAKJ> MFMLNNMNGAP)
	{
		return default(ANHNAJIBLBK<KGOBMFADMHP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x24ED460", Offset = "0x24EC660", VA = "0x1824ED460")]
	public ANHNAJIBLBK<COBLBOLGAKJ> MNLBBAAIFOJ(ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, [In] BDPEADCNJIF<COBLBOLGAKJ> NFFLINKDNFB)
	{
		return default(ANHNAJIBLBK<COBLBOLGAKJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x24EB690", Offset = "0x24EA890", VA = "0x1824EB690", Slot = "33")]
	public ANHNAJIBLBK<COBLBOLGAKJ> HOLLPFLEPJB(ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<FOIPKNJPLLP> CFHBDBIEIEP)
	{
		return default(ANHNAJIBLBK<COBLBOLGAKJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x24EB7A0", Offset = "0x24EA9A0", VA = "0x1824EB7A0", Slot = "34")]
	public ANHNAJIBLBK<COBLBOLGAKJ> IDJKJFIPAEM(ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<GMJCCLIJBIB> KGKPKEDHPHA)
	{
		return default(ANHNAJIBLBK<COBLBOLGAKJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x24EB600", Offset = "0x24EA800", VA = "0x1824EB600")]
	public ANHNAJIBLBK<COBLBOLGAKJ>? HGAPOOCAADN(ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, [In] BDPEADCNJIF<COBLBOLGAKJ> NFFLINKDNFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x24EA320", Offset = "0x24E9520", VA = "0x1824EA320", Slot = "25")]
	public OPPEJNNDGGO? FAFDOPMCGHP(ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x24E9630", Offset = "0x24E8830", VA = "0x1824E9630", Slot = "26")]
	public long CIPBLBIOIEP()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x24EB710", Offset = "0x24EA910", VA = "0x1824EB710")]
	private void HPAAGABGDDD(BDPEADCNJIF<COBLBOLGAKJ> MFMLNNMNGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x24EBCA0", Offset = "0x24EAEA0", VA = "0x1824EBCA0", Slot = "31")]
	public IEnumerable<(ANHNAJIBLBK<KJENBNHGDMG>, ANHNAJIBLBK<COBLBOLGAKJ>)> JDKBGAHBHJA(ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x24E9AB0", Offset = "0x24E8CB0", VA = "0x1824E9AB0", Slot = "32")]
	public ANHNAJIBLBK<FOIPKNJPLLP> EGHCONNLAAB(ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<COBLBOLGAKJ> MFMLNNMNGAP, ANHNAJIBLBK<KNFFGCFEOGG> JKBGDBBPBCM)
	{
		return default(ANHNAJIBLBK<FOIPKNJPLLP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x24E8C50", Offset = "0x24E7E50", VA = "0x1824E8C50", Slot = "35")]
	public ANHNAJIBLBK<GMJCCLIJBIB> AKLKGLFLMLK(ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<COBLBOLGAKJ> MFMLNNMNGAP, ANHNAJIBLBK<HHEEBPMGKBH> KPAHGANODGF)
	{
		return default(ANHNAJIBLBK<GMJCCLIJBIB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x24E8FF0", Offset = "0x24E81F0", VA = "0x1824E8FF0")]
	private CCPJLKCOOAF? BAKLCAIPHIC([In] BDPEADCNJIF<COBLBOLGAKJ> MFMLNNMNGAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x24EC3E0", Offset = "0x24EB5E0", VA = "0x1824EC3E0")]
	public HGHEIBELGCA? KMMCNCCOEMG([In] BDPEADCNJIF<COBLBOLGAKJ> MFMLNNMNGAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x24EB090", Offset = "0x24EA290", VA = "0x1824EB090")]
	public DNEKCIMOOPN? PGOKDPACCLD([In] BDPEADCNJIF<KJENBNHGDMG> KMGNKJBKEAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x24E7FD0", Offset = "0x24E71D0", VA = "0x1824E7FD0", Slot = "27")]
	public IEnumerable<LHFOJNAIIDF> AAMKLOAGHOK(ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x24EBC10", Offset = "0x24EAE10", VA = "0x1824EBC10", Slot = "28")]
	public bool JBFOGPPNONC(ANHNAJIBLBK<PEOLKLIEBJB> DBFALLLDDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x24EDCE0", Offset = "0x24ECEE0", VA = "0x1824EDCE0", Slot = "29")]
	public IEnumerable<FECOLOJALFF> OBJGEDFCCDL(ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<GMJCCLIJBIB> GACGPNNNIMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x24E8D70", Offset = "0x24E7F70", VA = "0x1824E8D70", Slot = "30")]
	public IEnumerable<FECOLOJALFF> BACNEIDIKGM(ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<FOIPKNJPLLP> PANLMNAHCML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x24E88D0", Offset = "0x24E7AD0", VA = "0x1824E88D0")]
	public ANHNAJIBLBK<KJENBNHGDMG> AFBFIDBALGC([In] BDPEADCNJIF<KJENBNHGDMG> KMGNKJBKEAL)
	{
		return default(ANHNAJIBLBK<KJENBNHGDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x24EDBE0", Offset = "0x24ECDE0", VA = "0x1824EDBE0")]
	public ANHNAJIBLBK<KJENBNHGDMG>? PABPGHHAGND([In] BDPEADCNJIF<KJENBNHGDMG> KMGNKJBKEAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x24EB0C0", Offset = "0x24EA2C0", VA = "0x1824EB0C0")]
	private ONIEEENHFNK? GFMDLLKFHLG([In] BDPEADCNJIF<KJENBNHGDMG> KMGNKJBKEAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x24EB090", Offset = "0x24EA290", VA = "0x1824EB090")]
	private DNEKCIMOOPN? HAMNOHFBECC([In] BDPEADCNJIF<KJENBNHGDMG> KMGNKJBKEAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x24EC2B0", Offset = "0x24EB4B0", VA = "0x1824EC2B0", Slot = "21")]
	public ANHNAJIBLBK<KJENBNHGDMG>? KIMMANNDIPL(ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<COBLBOLGAKJ> MFMLNNMNGAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x24E94B0", Offset = "0x24E86B0", VA = "0x1824E94B0", Slot = "39")]
	public BDPEADCNJIF<KJENBNHGDMG> BPMPEKEBACP(ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL)
	{
		return default(BDPEADCNJIF<KJENBNHGDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x24E97B0", Offset = "0x24E89B0", VA = "0x1824E97B0", Slot = "36")]
	public IEnumerable<BKCDGFOGEGO> DMEKNABGMNB(NCNKIDAFABK GODHIMDEOOG, bool FFKHHEDCKIB, bool ICMOJHPAFID, bool PDGKEPNGIML, bool HMCCLJGOKDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x24E8950", Offset = "0x24E7B50", VA = "0x1824E8950", Slot = "37")]
	public BKCDGFOGEGO AIMPDJCGLFO(NCNKIDAFABK GODHIMDEOOG, LIKJLNMKBIK FPOHALNJMFL, bool FFKHHEDCKIB, bool ICMOJHPAFID, bool PDGKEPNGIML, bool HMCCLJGOKDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x24E98B0", Offset = "0x24E8AB0", VA = "0x1824E98B0")]
	public LHFOJNAIIDF ECDDMGJENPF(ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, [In] FECOLOJALFF FIMIODHINLC)
	{
		return default(LHFOJNAIIDF);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x24E9200", Offset = "0x24E8400", VA = "0x1824E9200", Slot = "40")]
	public FECOLOJALFF BKGCGODDCPF(ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<GMJCCLIJBIB> GACGPNNNIMO, ANHNAJIBLBK<FOIPKNJPLLP> PANLMNAHCML)
	{
		return default(FECOLOJALFF);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x24EE870", Offset = "0x24EDA70", VA = "0x1824EE870", Slot = "41")]
	[AsyncStateMachine(typeof(HOBMAKPMHGP))]
	public Task<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> PMBFBAFMNOD(ANHNAJIBLBK<KJENBNHGDMG> NEOMAOEKAOA, ANHNAJIBLBK<COBLBOLGAKJ> CMBLHJGJOGC, NFONEEMNPCB KLICPJBJAIA, bool ONLHIPFLNGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x24E8090", Offset = "0x24E7290", VA = "0x1824E8090", Slot = "42")]
	[AsyncStateMachine(typeof(OFPAAABKIDM))]
	public Task<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> ACFMLOOFILN(ANHNAJIBLBK<KJENBNHGDMG> NEOMAOEKAOA, BDPEADCNJIF<COBLBOLGAKJ> CMBLHJGJOGC, List<ANHNAJIBLBK<COBLBOLGAKJ>> ELNNIKFBABG, NFONEEMNPCB EFINDBCJABN, JODENAIICMG MNPKBHFBPII, NFONEEMNPCB KLICPJBJAIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x24EBAC0", Offset = "0x24EACC0", VA = "0x1824EBAC0", Slot = "45")]
	[AsyncStateMachine(typeof(FHDDBIMANBB))]
	public Task<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> JAHMCKADNPB(ANHNAJIBLBK<KJENBNHGDMG> NEOMAOEKAOA, BDPEADCNJIF<COBLBOLGAKJ> CMBLHJGJOGC, List<ANHNAJIBLBK<COBLBOLGAKJ>> ELNNIKFBABG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x24E90A0", Offset = "0x24E82A0", VA = "0x1824E90A0", Slot = "46")]
	[AsyncStateMachine(typeof(NGKOCELDKGF))]
	public Task<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> BHPGLEKABDP(ANHNAJIBLBK<KJENBNHGDMG> NEOMAOEKAOA, BDPEADCNJIF<COBLBOLGAKJ> CMBLHJGJOGC, ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, List<ANHNAJIBLBK<COBLBOLGAKJ>> ELNNIKFBABG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x24EB1E0", Offset = "0x24EA3E0", VA = "0x1824EB1E0", Slot = "43")]
	public (IReadOnlyDictionary<EPPICOBLCPG, (ANHNAJIBLBK<GIDHHIIAAHA>, ANHNAJIBLBK<DPCEHNODIAE>)>, IReadOnlyDictionary<AAAPEEEHHLJ, (ANHNAJIBLBK<GIDHHIIAAHA>, ANHNAJIBLBK<IOGABLMALHO>)>) GLPECNDGNGJ(BDPEADCNJIF<KJENBNHGDMG> PPKDIBCCEAF, ANHNAJIBLBK<COBLBOLGAKJ> CMBLHJGJOGC)
	{
		return default((IReadOnlyDictionary<EPPICOBLCPG, (ANHNAJIBLBK<GIDHHIIAAHA>, ANHNAJIBLBK<DPCEHNODIAE>)>, IReadOnlyDictionary<AAAPEEEHHLJ, (ANHNAJIBLBK<GIDHHIIAAHA>, ANHNAJIBLBK<IOGABLMALHO>)>));
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x24ED650", Offset = "0x24EC850", VA = "0x1824ED650", Slot = "44")]
	[AsyncStateMachine(typeof(IAKDLICIMJO))]
	public Task NEANFDINKEI(BDPEADCNJIF<KJENBNHGDMG> PPKDIBCCEAF, BDPEADCNJIF<COBLBOLGAKJ> CMBLHJGJOGC, IReadOnlyList<BDPEADCNJIF<COBLBOLGAKJ>> KHHDOPKAJGP, IReadOnlyDictionary<EPPICOBLCPG, (ANHNAJIBLBK<GIDHHIIAAHA>, ANHNAJIBLBK<DPCEHNODIAE>)> LLKLEABGADP, IReadOnlyDictionary<AAAPEEEHHLJ, (ANHNAJIBLBK<GIDHHIIAAHA>, ANHNAJIBLBK<IOGABLMALHO>)> ICFDMJABLEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x24EC470", Offset = "0x24EB670", VA = "0x1824EC470", Slot = "47")]
	public bool KOHEAELNKLF(ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x24ED020", Offset = "0x24EC220", VA = "0x1824ED020", Slot = "48")]
	public bool MENAIMMBNJO(ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<FOIPKNJPLLP> CFHBDBIEIEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x24EB820", Offset = "0x24EAA20", VA = "0x1824EB820", Slot = "49")]
	public bool IEOOLDCDFPC(ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<GMJCCLIJBIB> KGKPKEDHPHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x24ECF70", Offset = "0x24EC170", VA = "0x1824ECF70")]
	public EBOICGKKPAM<ALBLMFHGEEB.NLBJDMHOHKG, CKNADPBHIII> OADMBJCPDGI([In] ALBLMFHGEEB.FLKEDFFFMGF OKBEKNPNPIM)
	{
		return default(EBOICGKKPAM<ALBLMFHGEEB.NLBJDMHOHKG, CKNADPBHIII>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x24EB990", Offset = "0x24EAB90", VA = "0x1824EB990", Slot = "51")]
	[AsyncStateMachine(typeof(AFDAEMAGJCC))]
	public Task<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> IMMJKEMFGGL(ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<GMJCCLIJBIB> GACGPNNNIMO, ANHNAJIBLBK<FOIPKNJPLLP> PANLMNAHCML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x24ED0A0", Offset = "0x24EC2A0", VA = "0x1824ED0A0", Slot = "52")]
	public EBOICGKKPAM<NGAKIMPLMFH, MNCKOMAJMKB> MGBHJJAFECK(BDPEADCNJIF<KJENBNHGDMG> KMGNKJBKEAL, NGAKIMPLMFH HDKJPNEPCBC, JODENAIICMG GJBBMENEFHA)
	{
		return default(EBOICGKKPAM<NGAKIMPLMFH, MNCKOMAJMKB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x24EB350", Offset = "0x24EA550", VA = "0x1824EB350", Slot = "53")]
	[AsyncStateMachine(typeof(MLBLCGKAAHD))]
	public Task<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> GMIHLAIIBBB(BDPEADCNJIF<KJENBNHGDMG> KMGNKJBKEAL, BDPEADCNJIF<COBLBOLGAKJ> HFLKOCAIDPP, ANHNAJIBLBK<GIDHHIIAAHA> IDIDHICFIOF, ANHNAJIBLBK<DPCEHNODIAE> CFHBDBIEIEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x24EA450", Offset = "0x24E9650", VA = "0x1824EA450", Slot = "54")]
	[AsyncStateMachine(typeof(PPAGALKMIBH))]
	public Task<EBOICGKKPAM<HEGEDEFNLEJ, LKEBDJCDIFL>> FCIHJPFLNBB(BDPEADCNJIF<KJENBNHGDMG> KMGNKJBKEAL, BDPEADCNJIF<COBLBOLGAKJ> PHNKFOEPPMG, ANHNAJIBLBK<GIDHHIIAAHA> BDPLNNFAKNJ, ANHNAJIBLBK<IOGABLMALHO> KGKPKEDHPHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x24EA040", Offset = "0x24E9240", VA = "0x1824EA040", Slot = "55")]
	public AEEABDGFDJC EMKBPMLAGKH()
	{
		return default(AEEABDGFDJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x24E9690", Offset = "0x24E8890", VA = "0x1824E9690", Slot = "56")]
	public AEEABDGFDJC CNKAGMFAOME()
	{
		return default(AEEABDGFDJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x24EDA30", Offset = "0x24ECC30", VA = "0x1824EDA30")]
	private MCOONHFPOKL NHKOEKJPHDH(AOHBAKFOKKA EHNHCHLCCLA, ANHNAJIBLBK<KJENBNHGDMG> EBGABJEGGHF, IEnumerable<BDPEADCNJIF<KJENBNHGDMG>> DEGMDHDMEPI, IEnumerable<BDPEADCNJIF<COBLBOLGAKJ>> ELNNIKFBABG)
	{
		return default(MCOONHFPOKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x24ED7A0", Offset = "0x24EC9A0", VA = "0x1824ED7A0", Slot = "57")]
	public MCOONHFPOKL NHKOEKJPHDH(AOHBAKFOKKA EHNHCHLCCLA, ANHNAJIBLBK<KJENBNHGDMG> EBGABJEGGHF, IEnumerable<BDPEADCNJIF<COBLBOLGAKJ>> ELNNIKFBABG, IEnumerable<INLFGDDOIPN> NDJPKPBNOCG)
	{
		return default(MCOONHFPOKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x24EE1C0", Offset = "0x24ED3C0", VA = "0x1824EE1C0")]
	private static IEnumerable<BDPEADCNJIF<KJENBNHGDMG>> PHPKMHCIMNE(IEnumerable<INLFGDDOIPN> NDJPKPBNOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x24E9B40", Offset = "0x24E8D40", VA = "0x1824E9B40")]
	private IEnumerable<BDPEADCNJIF<COBLBOLGAKJ>> EHJFNMDBEBD(IEnumerable<INLFGDDOIPN> NDJPKPBNOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x24EAF80", Offset = "0x24EA180", VA = "0x1824EAF80", Slot = "58")]
	public List<IKEEIOJNBGG> GBGAFBGBPPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x24E8210", Offset = "0x24E7410", VA = "0x1824E8210")]
	public (List<IKEEIOJNBGG>, bool) AEJEAMHGBDI([In] AOALJLEMKNF PLOPFCGHMIM, string GCGNIOHLIKK, [In] JLKKPODDDIL BHPJGJJKBNN, BDDBNBNBOBH KEGNEJMMBFD, AKKPIFOEMFJ AOJKDGJHHCJ)
	{
		return default((List<IKEEIOJNBGG>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x24EB8A0", Offset = "0x24EAAA0", VA = "0x1824EB8A0", Slot = "60")]
	public bool IHENADJNFAP(ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x24E9FE0", Offset = "0x24E91E0", VA = "0x1824E9FE0")]
	internal void EMEGOCJFNOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x24EB180", Offset = "0x24EA380", VA = "0x1824EB180")]
	internal Task GJINJHPPNBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x24EA5B0", Offset = "0x24E97B0", VA = "0x1824EA5B0", Slot = "61")]
	public EBOICGKKPAM<ANHNAJIBLBK<GMJCCLIJBIB>?, LKEBDJCDIFL> FCNFKMELBKH(ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<COBLBOLGAKJ> MFMLNNMNGAP, ANHNAJIBLBK<FOIPKNJPLLP> CFHBDBIEIEP)
	{
		return default(EBOICGKKPAM<ANHNAJIBLBK<GMJCCLIJBIB>?, LKEBDJCDIFL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x24EC5A0", Offset = "0x24EB7A0", VA = "0x1824EC5A0", Slot = "62")]
	public EBOICGKKPAM<ANHNAJIBLBK<FOIPKNJPLLP>?, LKEBDJCDIFL> LHGEIPEJFDL(ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<COBLBOLGAKJ> MFMLNNMNGAP, ANHNAJIBLBK<GMJCCLIJBIB> KGKPKEDHPHA)
	{
		return default(EBOICGKKPAM<ANHNAJIBLBK<FOIPKNJPLLP>?, LKEBDJCDIFL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x24E9430", Offset = "0x24E8630", VA = "0x1824E9430", Slot = "7")]
	private bool BNLKNNPCHPE(ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, [In] FECOLOJALFF FIMIODHINLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x24EB090", Offset = "0x24EA290", VA = "0x1824EB090", Slot = "18")]
	private DNEKCIMOOPN GDBJKGHHPEP([In] BDPEADCNJIF<KJENBNHGDMG> KMGNKJBKEAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x24EB680", Offset = "0x24EA880", VA = "0x1824EB680", Slot = "19")]
	private ANHNAJIBLBK<KJENBNHGDMG> HLJACCCCBDK([In] BDPEADCNJIF<KJENBNHGDMG> KMGNKJBKEAL)
	{
		return default(ANHNAJIBLBK<KJENBNHGDMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x24EDBE0", Offset = "0x24ECDE0", VA = "0x1824EDBE0", Slot = "20")]
	private ANHNAJIBLBK<KJENBNHGDMG>? NKPNLPEPNLP([In] BDPEADCNJIF<KJENBNHGDMG> KMGNKJBKEAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x24EA160", Offset = "0x24E9360", VA = "0x1824EA160", Slot = "22")]
	private CCPJLKCOOAF EOGJAJBJEOA([In] BDPEADCNJIF<COBLBOLGAKJ> MFMLNNMNGAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x24ED460", Offset = "0x24EC660", VA = "0x1824ED460", Slot = "24")]
	private ANHNAJIBLBK<COBLBOLGAKJ> NNAAPELHLCA(ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, [In] BDPEADCNJIF<COBLBOLGAKJ> NFFLINKDNFB)
	{
		return default(ANHNAJIBLBK<COBLBOLGAKJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x24E98B0", Offset = "0x24E8AB0", VA = "0x1824E98B0", Slot = "38")]
	private LHFOJNAIIDF MJAGFIBPMBP(ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, [In] FECOLOJALFF FIMIODHINLC)
	{
		return default(LHFOJNAIIDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x24ECF70", Offset = "0x24EC170", VA = "0x1824ECF70", Slot = "50")]
	private EBOICGKKPAM<ALBLMFHGEEB.NLBJDMHOHKG, CKNADPBHIII> LLHGKFCBEEK([In] ALBLMFHGEEB.FLKEDFFFMGF OKBEKNPNPIM)
	{
		return default(EBOICGKKPAM<ALBLMFHGEEB.NLBJDMHOHKG, CKNADPBHIII>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x24EC250", Offset = "0x24EB450", VA = "0x1824EC250", Slot = "59")]
	private (List<IKEEIOJNBGG>, bool) KEFEPJGKLCI([In] AOALJLEMKNF PLOPFCGHMIM, string GCGNIOHLIKK, [In] JLKKPODDDIL BHPJGJJKBNN, BDDBNBNBOBH KEGNEJMMBFD, AKKPIFOEMFJ AOJKDGJHHCJ)
	{
		return default((List<IKEEIOJNBGG>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x24E95B0", Offset = "0x24E87B0", VA = "0x1824E95B0")]
	[CompilerGenerated]
	private NDLIBLALBBE CAPMCBOOFBF(OKEMALFPLKA KPGFBDAMCDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x24EA2B0", Offset = "0x24E94B0", VA = "0x1824EA2B0")]
	[CompilerGenerated]
	private HGHEIBELGCA EPOFLADLEDK(BDPEADCNJIF<COBLBOLGAKJ> KPGFBDAMCDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x24E9440", Offset = "0x24E8640", VA = "0x1824E9440")]
	[CompilerGenerated]
	private ONIEEENHFNK BOMJADHKEJM(BDPEADCNJIF<KJENBNHGDMG> KPGFBDAMCDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class NDLIBLALBBE : BKCDGFOGEGO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[CompilerGenerated]
	private struct HFMLHDIAIFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<ANHNAJIBLBK<NEMHENHHKIC>, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public NDLIBLALBBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public BDPEADCNJIF<KJENBNHGDMG> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public BDPEADCNJIF<COBLBOLGAKJ> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public ANHNAJIBLBK<GIDHHIIAAHA> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private TaskAwaiter<EBOICGKKPAM<ANHNAJIBLBK<NEMHENHHKIC>, LKEBDJCDIFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x2500950", Offset = "0x24FFB50", VA = "0x182500950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x2500BD0", Offset = "0x24FFDD0", VA = "0x182500BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[CompilerGenerated]
	private struct FEMPPMEIHPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<ANHNAJIBLBK<LFJPMKFPODE>, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public NDLIBLALBBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public BDPEADCNJIF<KJENBNHGDMG> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public BDPEADCNJIF<COBLBOLGAKJ> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public ANHNAJIBLBK<GIDHHIIAAHA> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private TaskAwaiter<EBOICGKKPAM<ANHNAJIBLBK<LFJPMKFPODE>, LKEBDJCDIFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x24FFF20", Offset = "0x24FF120", VA = "0x1824FFF20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x25001A0", Offset = "0x24FF3A0", VA = "0x1825001A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private readonly OKEMALFPLKA AKPJGDALHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private readonly HPMNCAGGPMJ NIKFCHNIJKK;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public TypeKey BPLFOCMKLAG
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0xA960C0", Offset = "0xA952C0", VA = "0x180A960C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public string GANBCBOFIED
	{
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x2502740", Offset = "0x2501940", VA = "0x182502740", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public OKEMALFPLKA HGLNKIFAHHO
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x2504440", Offset = "0x2503640", VA = "0x182504440")]
	public NDLIBLALBBE(OKEMALFPLKA AELDBGIHIAJ, HPMNCAGGPMJ DHDIHDEIOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x25042D0", Offset = "0x25034D0", VA = "0x1825042D0", Slot = "6")]
	[AsyncStateMachine(typeof(HFMLHDIAIFL))]
	public Task<EBOICGKKPAM<ANHNAJIBLBK<NEMHENHHKIC>, LKEBDJCDIFL>> PACLPJDMKII(BDPEADCNJIF<KJENBNHGDMG> KMGNKJBKEAL, BDPEADCNJIF<COBLBOLGAKJ> MFMLNNMNGAP, ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO, string LMOANCJLHKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x2504160", Offset = "0x2503360", VA = "0x182504160", Slot = "7")]
	[AsyncStateMachine(typeof(FEMPPMEIHPF))]
	public Task<EBOICGKKPAM<ANHNAJIBLBK<LFJPMKFPODE>, LKEBDJCDIFL>> FIAHOMMLFNP(BDPEADCNJIF<KJENBNHGDMG> KMGNKJBKEAL, BDPEADCNJIF<COBLBOLGAKJ> MFMLNNMNGAP, ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO, string LMOANCJLHKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class LCOBKOMKBJM : LFEFKPMBDPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private readonly OKEMALFPLKA NLOBHOMPDGD;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	private static readonly HashSet<OKEMALFPLKA> OHOPKCBGDIO;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	private static readonly HashSet<OKEMALFPLKA> MIOHIFFMNGD;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	private static readonly HashSet<OKEMALFPLKA> ILPMMNCIHHM;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public TypeKey CHCLNDNNNEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x2503930", Offset = "0x2502B30", VA = "0x182503930", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool JBBLDOHBOCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x2503920", Offset = "0x2502B20", VA = "0x182503920", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool KAAEIGAFDML
	{
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x2503980", Offset = "0x2502B80", VA = "0x182503980", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public bool NACAEEHLHHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x25038A0", Offset = "0x2502AA0", VA = "0x1825038A0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x25024D0", Offset = "0x25016D0", VA = "0x1825024D0")]
	public bool NGEDLBELLEN(string OMEFCJCOLII, [Out] KOOPGIHLLMI JECHPONIGPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x902B20", Offset = "0x901D20", VA = "0x180902B20")]
	public LCOBKOMKBJM(OKEMALFPLKA CMFHMEJHOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x2502340", Offset = "0x2501540", VA = "0x182502340")]
	internal static TypeKey JLOJCDKIFEG(OKEMALFPLKA MDOOANEGCAH)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x2502740", Offset = "0x2501940", VA = "0x182502740", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public readonly struct DMNGGLIOCBM : FHADEGJBDFM.MFDCCLJBDBF<NAGMPGBKIGM, HEGEDEFNLEJ>
{
	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x24FFED0", Offset = "0x24FF0D0", VA = "0x1824FFED0", Slot = "4")]
	public int OBMGHINPMMA(HEGEDEFNLEJ PIEFIBOFCOC, NAGMPGBKIGM KOMGLJOLBFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x24FFE30", Offset = "0x24FF030", VA = "0x1824FFE30", Slot = "5")]
	public NAGMPGBKIGM FMHNLBIJCID(HEGEDEFNLEJ PIEFIBOFCOC, NAGMPGBKIGM KOMGLJOLBFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x24FFEA0", Offset = "0x24FF0A0", VA = "0x1824FFEA0", Slot = "6")]
	public NAGMPGBKIGM OAPPIJMPIOC(HEGEDEFNLEJ PIEFIBOFCOC, NAGMPGBKIGM KOMGLJOLBFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x24FFE60", Offset = "0x24FF060", VA = "0x1824FFE60", Slot = "7")]
	public IReadOnlyList<NAGMPGBKIGM> MNKMLKAENBA(HEGEDEFNLEJ PIEFIBOFCOC, NAGMPGBKIGM KOMGLJOLBFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x24FFF10", Offset = "0x24FF110", VA = "0x1824FFF10", Slot = "8")]
	public NAGMPGBKIGM[] PLEKHILGIEK(HEGEDEFNLEJ PIEFIBOFCOC, NAGMPGBKIGM KOMGLJOLBFC, int JGGMFAOHDMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x24FFE80", Offset = "0x24FF080", VA = "0x1824FFE80", Slot = "9")]
	public bool MPHGHCMPDFK(HEGEDEFNLEJ PIEFIBOFCOC, NAGMPGBKIGM KOMGLJOLBFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x24FFE40", Offset = "0x24FF040", VA = "0x1824FFE40", Slot = "10")]
	public bool HFLMCELKABM(HEGEDEFNLEJ PIEFIBOFCOC, NAGMPGBKIGM KOMGLJOLBFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x24FFE10", Offset = "0x24FF010", VA = "0x1824FFE10", Slot = "11")]
	public bool EFNNOHFJNOH(HEGEDEFNLEJ PIEFIBOFCOC, NAGMPGBKIGM KOMGLJOLBFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x24FFDF0", Offset = "0x24FEFF0", VA = "0x1824FFDF0", Slot = "12")]
	public bool CJCJMDKOFBF(HEGEDEFNLEJ PIEFIBOFCOC, NAGMPGBKIGM KOMGLJOLBFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x24FFEF0", Offset = "0x24FF0F0", VA = "0x1824FFEF0", Slot = "13")]
	public bool PKONFMBJMIA(HEGEDEFNLEJ MCKMDFNNJAO, NAGMPGBKIGM KOMGLJOLBFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x24FFDD0", Offset = "0x24FEFD0", VA = "0x1824FFDD0", Slot = "14")]
	public bool AIENDFOFIKC(HEGEDEFNLEJ PIEFIBOFCOC, NAGMPGBKIGM KOMGLJOLBFC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public abstract class GECJFMOLNBI : EFDENJBCFFC
{
	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public BLCBNMLEBHK.GNJBOAKJPCG HFPNPNEPDHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x2500900", Offset = "0x24FFB00", VA = "0x182500900", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public abstract MPIJDDEDEEJ.DJJONGDOFCF AJDNEJLNIEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public abstract LMPMALFKFKJ.ONFFFKFPEHG KCCDIPDGBKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public abstract PNCACGINIMH.LINOLILKBJL OOPOGDHJJAN
	{
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public PICIEGNBDJL.EEIAMFPGFEG<MELNNHKBONO, NAGMPGBKIGM, LMPMALFKFKJ> NDHEDMALAFI
	{
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x25008B0", Offset = "0x24FFAB0", VA = "0x1825008B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public abstract KDFMCIEGIOL IFODINBCCPP
	{
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public abstract MEBKPIJAJOK NLFJFFEPKEL
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public abstract AMMMNIHCPLN GCCEAHEOIIH
	{
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public abstract JJCFPHNFHFO INJJABJLIAO
	{
		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public abstract NHKHFEIKFGM AFDMBBGBNIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	protected GECJFMOLNBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public sealed class OAHNDOGJJDN : DLICIEMIIJE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private struct LGAEIKBDMHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<object, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public OAHNDOGJJDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public NAGMPGBKIGM action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private TaskAwaiter<EBOICGKKPAM<object, LKEBDJCDIFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x2503AA0", Offset = "0x2502CA0", VA = "0x182503AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x2503D40", Offset = "0x2502F40", VA = "0x182503D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private struct FGJJEMMPKCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public AsyncTaskMethodBuilder<EBOICGKKPAM<BFCNMIIHFAN, LKEBDJCDIFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public OAHNDOGJJDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public IReadOnlyList<NAGMPGBKIGM> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private TaskAwaiter<EBOICGKKPAM<object, LKEBDJCDIFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x2500210", Offset = "0x24FF410", VA = "0x182500210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x2500590", Offset = "0x24FF790", VA = "0x182500590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000305")]
	private readonly NOJMHINMKNJ BIPEKGMIANC;

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x902B20", Offset = "0x901D20", VA = "0x180902B20")]
	public OAHNDOGJJDN(NOJMHINMKNJ LECMOIOCNBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x25049D0", Offset = "0x2503BD0", VA = "0x1825049D0")]
	[AsyncStateMachine(typeof(LGAEIKBDMHL))]
	private Task<EBOICGKKPAM<object, LKEBDJCDIFL>> IECLPOHOKAN(NAGMPGBKIGM KOMGLJOLBFC, bool MMLBLFDFKKN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x25048A0", Offset = "0x2503AA0", VA = "0x1825048A0", Slot = "4")]
	[AsyncStateMachine(typeof(FGJJEMMPKCE))]
	public Task<EBOICGKKPAM<BFCNMIIHFAN, LKEBDJCDIFL>> HCHNNLDHBKE(IReadOnlyList<NAGMPGBKIGM> MPDFABPCMPJ, bool MMLBLFDFKKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public struct BPDLGHAILDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	internal KBCKNICHPFB<IKLKOHELGEA, BDPEADCNJIF<IKLKOHELGEA.KEEGMAJEEHB>, NAGMPGBKIGM, JPAEEEJEAAJ> NLOBHOMPDGD;

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x24D46A0", Offset = "0x24D38A0", VA = "0x1824D46A0")]
	private BPDLGHAILDK([In] KBCKNICHPFB<IKLKOHELGEA, BDPEADCNJIF<IKLKOHELGEA.KEEGMAJEEHB>, NAGMPGBKIGM, JPAEEEJEAAJ> LFAKEPFEOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x24FDD80", Offset = "0x24FCF80", VA = "0x1824FDD80")]
	public static BPDLGHAILDK PAJOIGLPBMN()
	{
		return default(BPDLGHAILDK);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public static class LPHHADBGJOL
{
	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0xB3B5B0", Offset = "0xB3A7B0", VA = "0x180B3B5B0")]
	public static KBCKNICHPFB<IKLKOHELGEA, BDPEADCNJIF<IKLKOHELGEA.KEEGMAJEEHB>, NAGMPGBKIGM, JPAEEEJEAAJ> GLEFABANAOD(this BPDLGHAILDK MLNFAKCEGNM)
	{
		return default(KBCKNICHPFB<IKLKOHELGEA, BDPEADCNJIF<IKLKOHELGEA.KEEGMAJEEHB>, NAGMPGBKIGM, JPAEEEJEAAJ>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public struct JPAEEEJEAAJ : CFEDDCLOBJC.CFPENBFLDIP<IKLKOHELGEA, BDPEADCNJIF<IKLKOHELGEA.KEEGMAJEEHB>, NAGMPGBKIGM>
{
	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x2502120", Offset = "0x2501320", VA = "0x182502120", Slot = "7")]
	public NAGMPGBKIGM FFHLKJGHGNP(IKLKOHELGEA[] JJGGCJKJBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x108FEF0", Offset = "0x108F0F0", VA = "0x18108FEF0")]
	public BDPEADCNJIF<IKLKOHELGEA.KEEGMAJEEHB> PEMKHMIOCGO([In] IKLKOHELGEA LOFGLLJCJAF)
	{
		return default(BDPEADCNJIF<IKLKOHELGEA.KEEGMAJEEHB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0xEE6AC0", Offset = "0xEE5CC0", VA = "0x180EE6AC0")]
	public int IBPKJJILNNA([In] IKLKOHELGEA BDCMLPFJHGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x2502310", Offset = "0x2501510", VA = "0x182502310")]
	public int KCGGEJMJGBK([In] IKLKOHELGEA LOFGLLJCJAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0xEE6AC0", Offset = "0xEE5CC0", VA = "0x180EE6AC0", Slot = "4")]
	private int IBODACBBBAG([In] IKLKOHELGEA LOFGLLJCJAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x2502310", Offset = "0x2501510", VA = "0x182502310", Slot = "5")]
	private int HNDHOMJDDKK([In] IKLKOHELGEA LOFGLLJCJAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x108FEF0", Offset = "0x108F0F0", VA = "0x18108FEF0", Slot = "6")]
	private BDPEADCNJIF<IKLKOHELGEA.KEEGMAJEEHB> OPJNLDBOOLO([In] IKLKOHELGEA LOFGLLJCJAF)
	{
		return default(BDPEADCNJIF<IKLKOHELGEA.KEEGMAJEEHB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public struct JDNJHBCKNLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	internal NHJEFOOFDDM<KPCEIBCGPGH, NAGMPGBKIGM, COINGJAEGKM> NLOBHOMPDGD;

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x24D46A0", Offset = "0x24D38A0", VA = "0x1824D46A0")]
	private JDNJHBCKNLI([In] NHJEFOOFDDM<KPCEIBCGPGH, NAGMPGBKIGM, COINGJAEGKM> ALJLCMNICCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x25020C0", Offset = "0x25012C0", VA = "0x1825020C0")]
	public static JDNJHBCKNLI PAJOIGLPBMN()
	{
		return default(JDNJHBCKNLI);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public static class OOHAMMOEMEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0xB3B5B0", Offset = "0xB3A7B0", VA = "0x180B3B5B0")]
	public static NHJEFOOFDDM<KPCEIBCGPGH, NAGMPGBKIGM, COINGJAEGKM> GLEFABANAOD(this JDNJHBCKNLI MLNFAKCEGNM)
	{
		return default(NHJEFOOFDDM<KPCEIBCGPGH, NAGMPGBKIGM, COINGJAEGKM>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public struct COINGJAEGKM : HHLPFDIAPLP.FEFNKGKBFKF<KPCEIBCGPGH, NAGMPGBKIGM>
{
	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x1ECCDB0", Offset = "0x1ECBFB0", VA = "0x181ECCDB0")]
	public int NMKOKFLDMMB([In] KPCEIBCGPGH BDCMLPFJHGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x24FFBE0", Offset = "0x24FEDE0", VA = "0x1824FFBE0", Slot = "5")]
	public NAGMPGBKIGM IAGBNNGHCGD(KPCEIBCGPGH[] CHEFBECCHOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x1ECCDB0", Offset = "0x1ECBFB0", VA = "0x181ECCDB0", Slot = "4")]
	private int HGFKIDOAEMD([In] KPCEIBCGPGH BDCMLPFJHGM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public class IHCBDCHFHKI : ENAONJKJOID, CKNADPBHIII, LKEBDJCDIFL, MNCKOMAJMKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000319")]
	private readonly MNCKOMAJMKB? PJJLEBAJGCH;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public GOGEOCGPFLI BGMNFNIOAKG
	{
		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D30", Offset = "0x8F3F30", VA = "0x1808F4D30", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(GOGEOCGPFLI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x8F54B0", Offset = "0x8F46B0", VA = "0x1808F54B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public override MNCKOMAJMKB? DCBIEDBIADO
	{
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x2501F70", Offset = "0x2501170", VA = "0x182501F70", Slot = "7")]
	public override string OEJBHPKDIJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x2502080", Offset = "0x2501280", VA = "0x182502080")]
	private IHCBDCHFHKI(GOGEOCGPFLI BGJHPMCGJDB, MNCKOMAJMKB? EAFAODGJKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x2501EF0", Offset = "0x25010F0", VA = "0x182501EF0")]
	public static IHCBDCHFHKI IINCOEOLCFD(MNCKOMAJMKB EAFAODGJKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x2501E10", Offset = "0x2501010", VA = "0x182501E10")]
	public static IHCBDCHFHKI EDLFJJDNNMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x2501E80", Offset = "0x2501080", VA = "0x182501E80")]
	public static IHCBDCHFHKI HIELBMPDLGC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public static class NGPKMFJNEFH
{
	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x33F3CF0", Offset = "0x33F2EF0", VA = "0x1833F3CF0")]
	public static EBOICGKKPAM<TOk, CKNADPBHIII> NPANAEHKAPG<TOk>([In] this EBOICGKKPAM<TOk, CKNADPBHIII> MLNFAKCEGNM, MNCKOMAJMKB EAFAODGJKAE) where TOk : notnull
	{
		return default(EBOICGKKPAM<TOk, CKNADPBHIII>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x33F3B00", Offset = "0x33F2D00", VA = "0x1833F3B00")]
	public static EBOICGKKPAM<TOk?, CKNADPBHIII?> BIGMIKDGBOE<TOk>([In] this EBOICGKKPAM<TOk, CKNADPBHIII> MLNFAKCEGNM)
	{
		return default(EBOICGKKPAM<TOk, CKNADPBHIII>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x33F3BF0", Offset = "0x33F2DF0", VA = "0x1833F3BF0")]
	public static EBOICGKKPAM<TOk?, CKNADPBHIII?> ENLNGNLOLJI<TOk>([In] this EBOICGKKPAM<TOk, CKNADPBHIII> MLNFAKCEGNM)
	{
		return default(EBOICGKKPAM<TOk, CKNADPBHIII>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public interface KDFMCIEGIOL
{
	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AAIHKLAKHHF([In] EBOICGKKPAM<HEGEDEFNLEJ, MNCKOMAJMKB> NJFLHCEDIDN);
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public static class MCMDBLAOPII
{
	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x3366850", Offset = "0x3365A50", VA = "0x183366850")]
	public static bool AAIHKLAKHHF<TOk, TErr>(this KDFMCIEGIOL MLNFAKCEGNM, [In] EBOICGKKPAM<TOk, TErr> NJFLHCEDIDN) where TOk : notnull where TErr : notnull, MNCKOMAJMKB
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public interface MEBKPIJAJOK
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	ACFFPBMKLGP GIELHKOPEIC
	{
		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public interface AMMMNIHCPLN
{
	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FNNBEFDBEDH NLIHOGFIEJE(int BODFLPCGHLA);
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public interface GKLCCIDJCKF
{
	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	string PCMLNMEPCBI
	{
		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public interface LLNGOIFBPFO
{
	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PMBKINALHPP? FAEBHAKKFGP(ANHNAJIBLBK<GIDHHIIAAHA> JJMNOOJEKNO);
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public interface LNDBAMAGKOD
{
	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	string PCMLNMEPCBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public interface PMBKINALHPP
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	string PCMLNMEPCBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LNDBAMAGKOD? KGBMCBKOFHI(ANHNAJIBLBK<NEMHENHHKIC> JIAOICBDGLF);

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GKLCCIDJCKF? IGFFBJONFCC(ANHNAJIBLBK<LFJPMKFPODE> IHGCLKEMIIO);
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public interface JJCFPHNFHFO
{
	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> CCJPLLKCAAL(string OMEFCJCOLII, string GCGNIOHLIKK);
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public interface NHKHFEIKFGM
{
	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LLNGOIFBPFO? GDKKDIGCCPJ([In] BDPEADCNJIF<FDEAEAJKEFN> LANFDEKIDKD);
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class HGIAHNCOMCG
{
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	private struct NFDEDLBPNHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public int JDABKJNJMBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public NHLHHLCCGOO? OMEANMHKDIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public NHLHHLCCGOO? KMBDFGMEIDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public readonly List<NAGMPGBKIGM> HJEAOLCMDDP;

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x25045A0", Offset = "0x25037A0", VA = "0x1825045A0")]
		private NFDEDLBPNHM(int CPLNODNGKGB, NHLHHLCCGOO? BIGLDKIBHEL, NHLHHLCCGOO? KDMFENANFFF, List<NAGMPGBKIGM> MPDFABPCMPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x25044E0", Offset = "0x25036E0", VA = "0x1825044E0")]
		public static NFDEDLBPNHM PAJOIGLPBMN()
		{
			return default(NFDEDLBPNHM);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	private readonly GEBCCEKIGFD<NFDEDLBPNHM> BFFLIFOHNLO;

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public static HGIAHNCOMCG CLACNPDFIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x2500D00", Offset = "0x24FFF00", VA = "0x182500D00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public bool ANIGGDAEEIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0xB24780", Offset = "0xB23980", VA = "0x180B24780")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0xB24BA0", Offset = "0xB23DA0", VA = "0x180B24BA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x2500C40", Offset = "0x24FFE40", VA = "0x182500C40")]
	public void BDIMAFCPLGE(MBGMEAFLNHF KDMFENANFFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x2501090", Offset = "0x2500290", VA = "0x182501090")]
	public void HNDBMOEHNML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x2500D50", Offset = "0x24FFF50", VA = "0x182500D50")]
	private static string? CJKJDDCMBBG([In] NFDEDLBPNHM GBACACJHOKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x2501490", Offset = "0x2500690", VA = "0x182501490")]
	public HGIAHNCOMCG()
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
