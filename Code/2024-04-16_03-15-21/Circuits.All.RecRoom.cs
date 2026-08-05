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
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1DEA4E0", Offset = "0x1DE96E0", VA = "0x181DEA4E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DED90", Offset = "0x7DDF90", VA = "0x1807DED90")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DEDD0", Offset = "0x7DDFD0", VA = "0x1807DEDD0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class FNFHONBFHOC : IDisposable, GDGILCLOAKN, GJCEJCEIMJD, AHMMCMDLHLI, KLMHCLAPDGK
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class AGFEMBBDPKI : CECGGNIPDGH
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public abstract int BILGJJBNLJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1DD2480", Offset = "0x1DD1680", VA = "0x181DD2480", Slot = "5")]
		public IJNDIKJPOPI HGLJLGALFCH(IEDBNMJFFCL.LOAGNIFEEIL OAENIJAKBHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void CJANGLNPMPG();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void ACFIAGALNNK();

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1DD2650", Offset = "0x1DD1850", VA = "0x181DD2650", Slot = "13")]
		public virtual void OPMLPCHMJJF(FNFHONBFHOC JIPGCHPOGGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1DD25D0", Offset = "0x1DD17D0", VA = "0x181DD25D0", Slot = "14")]
		public virtual void KIILDMIKMMA(FNFHONBFHOC JIPGCHPOGGF, OLNEDDGCOEI OFOIHENMFDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		protected AGFEMBBDPKI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface CECGGNIPDGH
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		int BILGJJBNLJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IJNDIKJPOPI HGLJLGALFCH(IEDBNMJFFCL.LOAGNIFEEIL OAENIJAKBHE);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void CJANGLNPMPG();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ACFIAGALNNK();

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void OPMLPCHMJJF(FNFHONBFHOC JIPGCHPOGGF);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void KIILDMIKMMA(FNFHONBFHOC JIPGCHPOGGF, OLNEDDGCOEI OFOIHENMFDE);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct JIOLAKJMMDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly MDBEBAFIHMA<APPDEKGDMED, OLNEDDGCOEI, FNFHONBFHOC, COLNEMPFNPK.FCBAIHGFHME<APPDEKGDMED, OLNEDDGCOEI, FNFHONBFHOC>> PGAIFKPODHO;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1DDF2A0", Offset = "0x1DDE4A0", VA = "0x181DDF2A0")]
		internal JIOLAKJMMDM(MDBEBAFIHMA<APPDEKGDMED, OLNEDDGCOEI, FNFHONBFHOC, COLNEMPFNPK.FCBAIHGFHME<APPDEKGDMED, OLNEDDGCOEI, FNFHONBFHOC>> HMEKKAINJCD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class IDGMINHPMJF : COLNEMPFNPK.FCBAIHGFHME<APPDEKGDMED, OLNEDDGCOEI, FNFHONBFHOC>
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly IDGMINHPMJF EELHBDDPCDG;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		private IDGMINHPMJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xAD3000", Offset = "0xAD2200", VA = "0x180AD3000", Slot = "4")]
		public APPDEKGDMED OMAGDDJEFPP(OLNEDDGCOEI AOFIGDLFNLH)
		{
			return default(APPDEKGDMED);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1DD8510", Offset = "0x1DD7710", VA = "0x181DD8510", Slot = "5")]
		public void OPMLPCHMJJF(FNFHONBFHOC MFIBAFBMCBA, OLNEDDGCOEI OFOIHENMFDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1DD8400", Offset = "0x1DD7600", VA = "0x181DD8400", Slot = "6")]
		public void KIILDMIKMMA(FNFHONBFHOC MFIBAFBMCBA, OLNEDDGCOEI OFOIHENMFDE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct AEOFICILDHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public GGDJONELNKI<APPDEKGDMED, OLNEDDGCOEI, FNFHONBFHOC, COLNEMPFNPK.FCBAIHGFHME<APPDEKGDMED, OLNEDDGCOEI, FNFHONBFHOC>> PGAIFKPODHO;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1DD2470", Offset = "0x1DD1670", VA = "0x181DD2470")]
		internal AEOFICILDHN(GGDJONELNKI<APPDEKGDMED, OLNEDDGCOEI, FNFHONBFHOC, COLNEMPFNPK.FCBAIHGFHME<APPDEKGDMED, OLNEDDGCOEI, FNFHONBFHOC>> HMEKKAINJCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1DD2420", Offset = "0x1DD1620", VA = "0x181DD2420")]
		public static AEOFICILDHN DHBNKMCPKNO()
		{
			return default(AEOFICILDHN);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct DIDAPKFMBMH : FFJBPGDBKED.MNAOPLHOPPL<OLNEDDGCOEI, FNFHONBFHOC>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct MLIDOBHOELA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<OAAHAKNOJDO<object, AHFOEFCGOPM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public FNFHONBFHOC receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public OLNEDDGCOEI action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public DIDAPKFMBMH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private TaskAwaiter<OAAHAKNOJDO<object, AHFOEFCGOPM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1DE2EF0", Offset = "0x1DE20F0", VA = "0x181DE2EF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x1DE30D0", Offset = "0x1DE22D0", VA = "0x181DE30D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xAB8180", Offset = "0xAB7380", VA = "0x180AB8180", Slot = "4")]
		public KHCIOCBLCGC<PDFIKAKPMHI> PAGLKDJPLKP(FNFHONBFHOC INAHCHDLNPA)
		{
			return default(KHCIOCBLCGC<PDFIKAKPMHI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1DD4B60", Offset = "0x1DD3D60", VA = "0x181DD4B60", Slot = "5")]
		[AsyncStateMachine(typeof(MLIDOBHOELA))]
		public Task<OAAHAKNOJDO<object, AHFOEFCGOPM>> DLGPBLIMLGJ(FNFHONBFHOC INAHCHDLNPA, OLNEDDGCOEI OFOIHENMFDE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1DD4C90", Offset = "0x1DD3E90", VA = "0x181DD4C90", Slot = "6")]
		public OLNEDDGCOEI[] MMCPEIHNFFL(FNFHONBFHOC INAHCHDLNPA)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct FEHFCCHAOOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<OAAHAKNOJDO<bool, AHFOEFCGOPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public FNFHONBFHOC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public POMHAFMABIA rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public FNCJPDBCHMD circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public KDBNAJDNMLL superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<OAAHAKNOJDO<bool, AHFOEFCGOPM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1DD53F0", Offset = "0x1DD45F0", VA = "0x181DD53F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1DD5670", Offset = "0x1DD4870", VA = "0x181DD5670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct KMLMFPEEENO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public AsyncTaskMethodBuilder<OAAHAKNOJDO<bool, AHFOEFCGOPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public FNFHONBFHOC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter<OAAHAKNOJDO<bool, AHFOEFCGOPM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1DE0B60", Offset = "0x1DDFD60", VA = "0x181DE0B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1DE0DF0", Offset = "0x1DDFFF0", VA = "0x181DE0DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct PPFLBDIICHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public FNFHONBFHOC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1DEDA80", Offset = "0x1DECC80", VA = "0x181DEDA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1DEDC60", Offset = "0x1DECE60", VA = "0x181DEDC60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct CNHBMKAIJHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<OAAHAKNOJDO<object, AHFOEFCGOPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public FNFHONBFHOC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public OLNEDDGCOEI action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private TaskAwaiter<OAAHAKNOJDO<object, AHFOEFCGOPM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1DD45D0", Offset = "0x1DD37D0", VA = "0x181DD45D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1DD47C0", Offset = "0x1DD39C0", VA = "0x181DD47C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct NLIMPBHDJGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public FNFHONBFHOC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private TaskAwaiter<OAAHAKNOJDO<bool, AHFOEFCGOPM>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1DE6CE0", Offset = "0x1DE5EE0", VA = "0x181DE6CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x1DE74D0", Offset = "0x1DE66D0", VA = "0x181DE74D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly KHCIOCBLCGC<PDFIKAKPMHI> EIAAHAKCPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly JIOLAKJMMDM HLAAENDMCNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly BMEPKNKOPNE EPHBPGFFEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly KACLKDLHAGO NKDAPDICJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10D8")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly LEKMIPCMIOG HMODOJNAIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10E0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly FBNGBBCEEJI.IHGJPLDOKNJ KDHAGAAEHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1100")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly PNPLBLDGIFO AFFIBEPLANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1108")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly KHIGFOCAGKL FKEPPGBEIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1110")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly EIEHJHABEEC CENELOKHMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1118")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly PDBJABDNAFE LHAKDFCIEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1120")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal readonly DOBPBNGABAL LNEKFOMCGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1128")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private GBCPELNDKJC MLNPEFDJCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1138")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private AABNJICNLHP LPMKDMOFMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1158")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly BMEPKNKOPNE.PFFDDLNAJHP MKMBFIIOGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1160")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	internal readonly LKJELOBJLDH GOGJLKFKJOE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public BMEPKNKOPNE HMFKAFHOLLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1DD5AA0", Offset = "0x1DD4CA0", VA = "0x181DD5AA0")]
		get
		{
			return default(BMEPKNKOPNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal CECGGNIPDGH PCAJKPAJBML
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1DD64E0", Offset = "0x1DD56E0", VA = "0x181DD64E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal IJNDIKJPOPI IAHELLAFDGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1DD6620", Offset = "0x1DD5820", VA = "0x181DD6620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1DD6630", Offset = "0x1DD5830", VA = "0x181DD6630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool OOHKCKOHADI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1DD6AE0", Offset = "0x1DD5CE0", VA = "0x181DD6AE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1DD6AD0", Offset = "0x1DD5CD0", VA = "0x181DD6AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CCOAMBAMKHF FNHMCPGCBAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7430", Offset = "0x1DD6630", VA = "0x181DD7430", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IJMBNNPIBKJ MOOBCHPHAJP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7450", Offset = "0x1DD6650", VA = "0x181DD7450", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public FMHILGEAADL MEKAFJDABMA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7470", Offset = "0x1DD6670", VA = "0x181DD7470", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public GCNHELABFLM KKIIGIGDKID
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7440", Offset = "0x1DD6640", VA = "0x181DD7440", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public KBMBJKCGDCH JKEFLLHEBKM
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7460", Offset = "0x1DD6660", VA = "0x181DD7460", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private ALIDKHFLOPJ? FLKLLOBLFBO
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1DD6E80", Offset = "0x1DD6080", VA = "0x181DD6E80", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private GFGEBGOAOOO? MMCBPFALPOE
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1DD6FB0", Offset = "0x1DD61B0", VA = "0x181DD6FB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1DD70E0", Offset = "0x1DD62E0", VA = "0x181DD70E0")]
	private FNFHONBFHOC(LEKMIPCMIOG DPHCKILALEN, KHCIOCBLCGC<PDFIKAKPMHI> BJLBPPPFCJE, [In] JIOLAKJMMDM EHEDCLOPFLK, [In] BMEPKNKOPNE NDHNADPLILO, [In] KACLKDLHAGO FOJDLLDEODK, IJNDIKJPOPI IKNKOKAIKIN, [In] FBNGBBCEEJI.IHGJPLDOKNJ CLKGOCIAELO, BMEPKNKOPNE.PFFDDLNAJHP PABHHKFBBPF, LKJELOBJLDH FBAPKAMKHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1DD5AB0", Offset = "0x1DD4CB0", VA = "0x181DD5AB0")]
	public static FNFHONBFHOC DHBNKMCPKNO(LEKMIPCMIOG OAENIJAKBHE, BMEPKNKOPNE.MINMEEAFONK BALHKENLCEH, KHCIOCBLCGC<PDFIKAKPMHI> BJLBPPPFCJE, KHCIOCBLCGC<FIPNIBCAPJF> CEIHFDNKJHJ, PGMGGHNJIBF BADMILBHCII, CMOKJMFMKDB HBEEJOENKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1DD5C90", Offset = "0x1DD4E90", VA = "0x181DD5C90")]
	public static FNFHONBFHOC DHBNKMCPKNO(LEKMIPCMIOG DPHCKILALEN, [In] BMEPKNKOPNE NDHNADPLILO, [In] KACLKDLHAGO FOJDLLDEODK, KHCIOCBLCGC<PDFIKAKPMHI> BJLBPPPFCJE, KHCIOCBLCGC<FIPNIBCAPJF> CEIHFDNKJHJ, PGMGGHNJIBF BADMILBHCII, CMOKJMFMKDB HBEEJOENKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1DD5FF0", Offset = "0x1DD51F0", VA = "0x181DD5FF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1DD67D0", Offset = "0x1DD59D0", VA = "0x181DD67D0")]
	[AsyncStateMachine(typeof(FEHFCCHAOOM))]
	internal Task<OAAHAKNOJDO<bool, AHFOEFCGOPM>> IOMBNKHENNG(POMHAFMABIA IONGJKOKPIH, FNCJPDBCHMD KDILEBHEHDL, KDBNAJDNMLL KAODCEBKJOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1DD6530", Offset = "0x1DD5730", VA = "0x181DD6530")]
	[AsyncStateMachine(typeof(KMLMFPEEENO))]
	public Task<OAAHAKNOJDO<bool, AHFOEFCGOPM>> GACDFNKLMNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1DD63F0", Offset = "0x1DD55F0", VA = "0x181DD63F0")]
	[AsyncStateMachine(typeof(PPFLBDIICHP))]
	public Task<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> ENNLAPCMDNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1DD61E0", Offset = "0x1DD53E0", VA = "0x181DD61E0")]
	internal void EAJMLHCKEBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1DD6930", Offset = "0x1DD5B30", VA = "0x181DD6930")]
	internal DIGJANEAKHC<OLNEDDGCOEI> KJJPLJOKDJC([In] BCJOPPPBPBI IOABFIJONIG)
	{
		return default(DIGJANEAKHC<OLNEDDGCOEI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1DD6650", Offset = "0x1DD5850", VA = "0x181DD6650")]
	internal bool IDDMKKHNFMI([In] BCJOPPPBPBI IOABFIJONIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1DD5F70", Offset = "0x1DD5170", VA = "0x181DD5F70")]
	internal DIGJANEAKHC<OLNEDDGCOEI> DOBEJOBNKJH([In] PBLDLJBIPCL PEDJAGJFPPK)
	{
		return default(DIGJANEAKHC<OLNEDDGCOEI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1DD66C0", Offset = "0x1DD58C0", VA = "0x181DD66C0")]
	[AsyncStateMachine(typeof(CNHBMKAIJHE))]
	internal Task<OAAHAKNOJDO<object, AHFOEFCGOPM>> IDLLCDENMMC(OLNEDDGCOEI OFOIHENMFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1DD6AF0", Offset = "0x1DD5CF0", VA = "0x181DD6AF0")]
	private OLNEDDGCOEI[] MMCPEIHNFFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1DD69B0", Offset = "0x1DD5BB0", VA = "0x181DD69B0")]
	[AsyncStateMachine(typeof(NLIMPBHDJGG))]
	public Task<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> KMOPNFIIFPF(Guid KELLCJKMJGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class KNNGFCCBNCP
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2904B70", Offset = "0x2903D70", VA = "0x182904B70")]
	public static DOGIDKPKNAP<(TPrev?, FNFHONBFHOC?), GFGEBGOAOOO> CMNDGLMICFK<TPrev>([In] this DOGIDKPKNAP<TPrev, FNFHONBFHOC> AOFIGDLFNLH)
	{
		return default(DOGIDKPKNAP<(TPrev, FNFHONBFHOC), GFGEBGOAOOO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2904950", Offset = "0x2903B50", VA = "0x182904950")]
	public static DOGIDKPKNAP<TPrev?, FNFHONBFHOC?> BEJIINBJDEF<TPrev>([In] this DOGIDKPKNAP<TPrev, FNFHONBFHOC> AOFIGDLFNLH)
	{
		return default(DOGIDKPKNAP<TPrev, FNFHONBFHOC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class MEDHMIMPDFK<TData> : EPJKOMMHEAH, KEPBCEAGDIP, GJOBCCNBLIC where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly EIMAHFBCFHK<GGOIHKGODHF>? AAMBOLEMJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly string NMCIIMABILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly TData FHDMPGOGOOJ;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public EIMAHFBCFHK<GGOIHKGODHF>? KFIJCLLGKCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1FBC260", Offset = "0x1FBB460", VA = "0x181FBC260", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7BF640", Offset = "0x7BE840", VA = "0x1807BF640", Slot = "7")]
	public override string OFOGPFNLIGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3F12980", Offset = "0x3F11B80", VA = "0x183F12980")]
	internal MEDHMIMPDFK([In] EIMAHFBCFHK<GGOIHKGODHF>? LMGLHIFCAGM, KHCIOCBLCGC<AFBNAACJOMK>? ICNGOFHDKAJ, IOKind? OCCIBIJBKIC, string FFDOAJJEAOK, [In] TData MJGHOBDIDHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class LDCNEDMFAOI
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1DE1D90", Offset = "0x1DE0F90", VA = "0x181DE1D90")]
	public static OAAHAKNOJDO<MMEADCLJECA, KEPBCEAGDIP> CPBCNGBIOEE([In] this EDGOHDGIALA<OFDFIHDPCHF> EILDAJPCCAK)
	{
		return default(OAAHAKNOJDO<MMEADCLJECA, KEPBCEAGDIP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2907FD0", Offset = "0x29071D0", VA = "0x182907FD0")]
	public static OAAHAKNOJDO<TOk, KEPBCEAGDIP> IBIKMLIMEMA<TOk>([In] this OAAHAKNOJDO<TOk, KEPBCEAGDIP> AOFIGDLFNLH, [In] EIMAHFBCFHK<GGOIHKGODHF>? LMGLHIFCAGM, KHCIOCBLCGC<AFBNAACJOMK>? ICNGOFHDKAJ, IOKind? OCCIBIJBKIC, string FFDOAJJEAOK) where TOk : notnull
	{
		return default(OAAHAKNOJDO<TOk, KEPBCEAGDIP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface LEKMIPCMIOG
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	NGBHNACKADH.HCDCGJGJKGL EIINJKCFIKN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	IEDBNMJFFCL.LOAGNIFEEIL FHBFDGICLAB
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	FNFHONBFHOC.CECGGNIPDGH HPMJMCNKABC
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	KPJLMCGFILG.JDGOCGDPDLF HDDDKDJJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	COLNEMPFNPK.FCBAIHGFHME<APPDEKGDMED, OLNEDDGCOEI, FNFHONBFHOC> CDHCPJNDMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	BHHPNLGMNNB CNEMGIOBEPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	LFPLNNMJIPA KGBGOAKDCCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	OMIAKFHGILK AILNDJCFFFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	BINOIGOJMJL NDGNMCEIEIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	AAKEGACABAD PFBCDBJJOIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class AMDFHMOBLLP
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1DD28F0", Offset = "0x1DD1AF0", VA = "0x181DD28F0")]
	public static OLNEDDGCOEI HNNOKOKEKEL(this OLNEDDGCOEI AOFIGDLFNLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1DD2820", Offset = "0x1DD1A20", VA = "0x181DD2820")]
	public static OLNEDDGCOEI CKFEDOAMPLJ(this OCFMCGIPPIH AOFIGDLFNLH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct OCFMCGIPPIH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct IDNFNAKOMPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder<OAAHAKNOJDO<object, AHFOEFCGOPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public FNFHONBFHOC root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public OCFMCGIPPIH self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private TaskAwaiter<OAAHAKNOJDO<object, AHFOEFCGOPM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1DD8690", Offset = "0x1DD7890", VA = "0x181DD8690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1DD8950", Offset = "0x1DD7B50", VA = "0x181DD8950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly ByteString LJLHDNLHLNB;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x93E850", Offset = "0x93DA50", VA = "0x18093E850")]
	private OCFMCGIPPIH(ByteString EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1DEA800", Offset = "0x1DE9A00", VA = "0x181DEA800")]
	public static OLNEDDGCOEI GBLFCMLLPNO(ByteString EKDDCPALANJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1DEA9D0", Offset = "0x1DE9BD0", VA = "0x181DEA9D0")]
	public static EGEKHADCDEI<APPDEKGDMED, OCFMCGIPPIH> KMDHMPADJGJ(OLNEDDGCOEI IDGNLIGICAG)
	{
		return default(EGEKHADCDEI<APPDEKGDMED, OCFMCGIPPIH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1DEA8C0", Offset = "0x1DE9AC0", VA = "0x181DEA8C0")]
	[AsyncStateMachine(typeof(IDNFNAKOMPL))]
	public static Task<OAAHAKNOJDO<object, AHFOEFCGOPM>> IDLLCDENMMC(FNFHONBFHOC MFIBAFBMCBA, OCFMCGIPPIH AOFIGDLFNLH)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct KDALEOCPOPD
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1DE04D0", Offset = "0x1DDF6D0", VA = "0x181DE04D0")]
	public static OLNEDDGCOEI GBLFCMLLPNO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1DE05F0", Offset = "0x1DDF7F0", VA = "0x181DE05F0")]
	public static EGEKHADCDEI<APPDEKGDMED, KDALEOCPOPD> KMDHMPADJGJ(OLNEDDGCOEI IDGNLIGICAG)
	{
		return default(EGEKHADCDEI<APPDEKGDMED, KDALEOCPOPD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1DE0570", Offset = "0x1DDF770", VA = "0x181DE0570")]
	public static OAAHAKNOJDO<NFDBFOHCHGK, HINLGFGENCJ> IMCCPHFOFAD(FNFHONBFHOC MFIBAFBMCBA, [In] KDALEOCPOPD AOFIGDLFNLH)
	{
		return default(OAAHAKNOJDO<NFDBFOHCHGK, HINLGFGENCJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct OCHEIMPPNFI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct JJFKKIEKNMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public AsyncTaskMethodBuilder<OAAHAKNOJDO<NFDBFOHCHGK, HINLGFGENCJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public FNFHONBFHOC root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public OCHEIMPPNFI self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private OAAHAKNOJDO<NFDBFOHCHGK, HINLGFGENCJ> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1DDF2B0", Offset = "0x1DDE4B0", VA = "0x181DDF2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1DDF620", Offset = "0x1DDE820", VA = "0x181DDF620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly POMHAFMABIA? CPEHNJJOJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly FNCJPDBCHMD? GNGKDDDNNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly KDBNAJDNMLL? ANPEDHAJAFB;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1B34B80", Offset = "0x1B33D80", VA = "0x181B34B80")]
	private OCHEIMPPNFI(POMHAFMABIA? IONGJKOKPIH, FNCJPDBCHMD? KDILEBHEHDL, KDBNAJDNMLL? KAODCEBKJOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1DEAA80", Offset = "0x1DE9C80", VA = "0x181DEAA80")]
	public static OLNEDDGCOEI? GBLFCMLLPNO(POMHAFMABIA? IONGJKOKPIH, FNCJPDBCHMD? KDILEBHEHDL, KDBNAJDNMLL? KAODCEBKJOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1DEACC0", Offset = "0x1DE9EC0", VA = "0x181DEACC0")]
	public static EGEKHADCDEI<APPDEKGDMED, OCHEIMPPNFI> KMDHMPADJGJ(OLNEDDGCOEI IDGNLIGICAG)
	{
		return default(EGEKHADCDEI<APPDEKGDMED, OCHEIMPPNFI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1DEAB80", Offset = "0x1DE9D80", VA = "0x181DEAB80")]
	[AsyncStateMachine(typeof(JJFKKIEKNMM))]
	public static Task<OAAHAKNOJDO<NFDBFOHCHGK, HINLGFGENCJ>> IDLLCDENMMC(FNFHONBFHOC MFIBAFBMCBA, OCHEIMPPNFI AOFIGDLFNLH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct OAPOGLBKONN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct AOIJAHGBCIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AsyncTaskMethodBuilder<OAAHAKNOJDO<GBCBPCFFANE, AHFOEFCGOPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public OAPOGLBKONN self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public FNFHONBFHOC root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private OAAHAKNOJDO<GBCBPCFFANE, AHFOEFCGOPM> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private OAAHAKNOJDO<object, GJOBCCNBLIC>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private OAAHAKNOJDO<object, GJOBCCNBLIC> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private OAAHAKNOJDO<object, GJOBCCNBLIC>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<OAAHAKNOJDO<object, AHFOEFCGOPM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1DD2EE0", Offset = "0x1DD20E0", VA = "0x181DD2EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3350", Offset = "0x1DD2550", VA = "0x181DD3350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly IReadOnlyList<OLNEDDGCOEI> OMMJJNMJNMO;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x93E850", Offset = "0x93DA50", VA = "0x18093E850")]
	private OAPOGLBKONN(IReadOnlyList<OLNEDDGCOEI> PGBGGHKPAIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1DEA560", Offset = "0x1DE9760", VA = "0x181DEA560")]
	public static OLNEDDGCOEI GBLFCMLLPNO(IReadOnlyList<OLNEDDGCOEI> PGBGGHKPAIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1DEA760", Offset = "0x1DE9960", VA = "0x181DEA760")]
	public static EGEKHADCDEI<APPDEKGDMED, OAPOGLBKONN> KMDHMPADJGJ(OLNEDDGCOEI IDGNLIGICAG)
	{
		return default(EGEKHADCDEI<APPDEKGDMED, OAPOGLBKONN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1DEA620", Offset = "0x1DE9820", VA = "0x181DEA620")]
	[AsyncStateMachine(typeof(AOIJAHGBCIL))]
	public static Task<OAAHAKNOJDO<GBCBPCFFANE, AHFOEFCGOPM>> IDLLCDENMMC(FNFHONBFHOC MFIBAFBMCBA, OAPOGLBKONN AOFIGDLFNLH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct PBLDLJBIPCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int GIHIJMKOGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly int ABDHHHCLNNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly byte[] FHDMPGOGOOJ;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x18C8FE0", Offset = "0x18C81E0", VA = "0x1818C8FE0")]
	private PBLDLJBIPCL(int KMJOEPJMADC, int MBGANDEDPDN, byte[] MJGHOBDIDHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1DEC150", Offset = "0x1DEB350", VA = "0x181DEC150")]
	public static OLNEDDGCOEI GBLFCMLLPNO(int KMJOEPJMADC, int MBGANDEDPDN, ByteString MJGHOBDIDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1DEC020", Offset = "0x1DEB220", VA = "0x181DEC020")]
	public static OLNEDDGCOEI[] FJFGAJLGONH(OLNEDDGCOEI OFOIHENMFDE, int JJJEMBFGPIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1DEC350", Offset = "0x1DEB550", VA = "0x181DEC350")]
	public static EGEKHADCDEI<APPDEKGDMED, PBLDLJBIPCL> KMDHMPADJGJ(OLNEDDGCOEI IDGNLIGICAG)
	{
		return default(EGEKHADCDEI<APPDEKGDMED, PBLDLJBIPCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1DEC230", Offset = "0x1DEB430", VA = "0x181DEC230")]
	public static OAAHAKNOJDO<OLNEDDGCOEI, HINLGFGENCJ> IMCCPHFOFAD(FNFHONBFHOC MFIBAFBMCBA, [In] PBLDLJBIPCL AOFIGDLFNLH)
	{
		return default(OAAHAKNOJDO<OLNEDDGCOEI, HINLGFGENCJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct BCJOPPPBPBI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct PIPKCLDNJNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder<OAAHAKNOJDO<bool, HINLGFGENCJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public FNFHONBFHOC root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public BCJOPPPBPBI self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private OAAHAKNOJDO<bool, HINLGFGENCJ> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private TaskAwaiter<OAAHAKNOJDO<NFDBFOHCHGK, HINLGFGENCJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1DEC7F0", Offset = "0x1DEB9F0", VA = "0x181DEC7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1DECE30", Offset = "0x1DEC030", VA = "0x181DECE30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int GIHIJMKOGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly int ABDHHHCLNNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly byte[] FHDMPGOGOOJ;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x18C8FE0", Offset = "0x18C81E0", VA = "0x1818C8FE0")]
	private BCJOPPPBPBI(int KMJOEPJMADC, int MBGANDEDPDN, byte[] MJGHOBDIDHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1DD3610", Offset = "0x1DD2810", VA = "0x181DD3610")]
	public static OLNEDDGCOEI GBLFCMLLPNO(int KMJOEPJMADC, int MBGANDEDPDN, ByteString MJGHOBDIDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1DD3420", Offset = "0x1DD2620", VA = "0x181DD3420")]
	public static OLNEDDGCOEI?[]? ANKHPBDJNAH(int JJJEMBFGPIM, POMHAFMABIA? IONGJKOKPIH, FNCJPDBCHMD? KDILEBHEHDL, KDBNAJDNMLL? KAODCEBKJOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1DD3820", Offset = "0x1DD2A20", VA = "0x181DD3820")]
	public static EGEKHADCDEI<APPDEKGDMED, BCJOPPPBPBI> KMDHMPADJGJ(OLNEDDGCOEI IDGNLIGICAG)
	{
		return default(EGEKHADCDEI<APPDEKGDMED, BCJOPPPBPBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1DD36F0", Offset = "0x1DD28F0", VA = "0x181DD36F0")]
	[AsyncStateMachine(typeof(PIPKCLDNJNN))]
	public static Task<OAAHAKNOJDO<bool, HINLGFGENCJ>> IDLLCDENMMC(FNFHONBFHOC MFIBAFBMCBA, BCJOPPPBPBI AOFIGDLFNLH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class PNPLBLDGIFO : CCOAMBAMKHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly FNFHONBFHOC DEPGNJNBHGB;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public FGPHLELPACC? EELHBDDPCDG
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1DED570", Offset = "0x1DEC770", VA = "0x181DED570", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7C19B0", Offset = "0x7C0BB0", VA = "0x1807C19B0")]
	internal PNPLBLDGIFO(FNFHONBFHOC JIPGCHPOGGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class AANKHINPJEL : FGPHLELPACC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly FNFHONBFHOC DEPGNJNBHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly LBIGLAFBHAC PNEFIEGFOPH;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7B8ED0", Offset = "0x7B80D0", VA = "0x1807B8ED0")]
	public AANKHINPJEL(FNFHONBFHOC JIPGCHPOGGF, LBIGLAFBHAC MBONFJGCAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1DD1D80", Offset = "0x1DD0F80", VA = "0x181DD1D80", Slot = "4")]
	public OAAHAKNOJDO<MMEADCLJECA, KEPBCEAGDIP> OCJLDCNDCLH(EIMAHFBCFHK<GGOIHKGODHF> MBBENIIFGEP, KHCIOCBLCGC<GHMMCINEBDI> CIHLOOFFIBE, KHCIOCBLCGC<NKGANNEHNHO> HNCOCKJDHMH)
	{
		return default(OAAHAKNOJDO<MMEADCLJECA, KEPBCEAGDIP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1DD1AB0", Offset = "0x1DD0CB0", VA = "0x181DD1AB0", Slot = "5")]
	public OAAHAKNOJDO<MMEADCLJECA, KEPBCEAGDIP> HFJAEDDDMMC(EIMAHFBCFHK<GGOIHKGODHF> MBBENIIFGEP, KHCIOCBLCGC<GHMMCINEBDI> CIHLOOFFIBE, KHCIOCBLCGC<PFOFHIJPHON> BDBHJLOOAPB)
	{
		return default(OAAHAKNOJDO<MMEADCLJECA, KEPBCEAGDIP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class NGBHNACKADH : JMPKLAJPDEP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface HCDCGJGJKGL
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<LBIGLAFBHAC> CGDIDDAGEOP(FNFHONBFHOC JIPGCHPOGGF, FNCJPDBCHMD? JDBEELGHEEL, KDBNAJDNMLL? BDNMOIODFHD, CancellationToken IOOGCHJMBIE);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		MPJHGOEDKGI IDNJBFDALAJ(FNFHONBFHOC JIPGCHPOGGF, POMHAFMABIA PPOHHIBGHKH);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class CBNICLOHBOH : HCDCGJGJKGL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct OFJAGLOLALM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AsyncTaskMethodBuilder<LBIGLAFBHAC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public FNFHONBFHOC circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public FNCJPDBCHMD cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public KDBNAJDNMLL cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private TaskAwaiter<KPJLMCGFILG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x1DEAE40", Offset = "0x1DEA040", VA = "0x181DEAE40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x1DEB160", Offset = "0x1DEA360", VA = "0x181DEB160", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly CBNICLOHBOH EELHBDDPCDG;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		private CBNICLOHBOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1DD4020", Offset = "0x1DD3220", VA = "0x181DD4020", Slot = "4")]
		[AsyncStateMachine(typeof(OFJAGLOLALM))]
		public Task<LBIGLAFBHAC> CGDIDDAGEOP(FNFHONBFHOC JIPGCHPOGGF, FNCJPDBCHMD? JDBEELGHEEL, KDBNAJDNMLL? BDNMOIODFHD, CancellationToken IOOGCHJMBIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1DD4180", Offset = "0x1DD3380", VA = "0x181DD4180", Slot = "5")]
		public MPJHGOEDKGI IDNJBFDALAJ(FNFHONBFHOC JIPGCHPOGGF, POMHAFMABIA PPOHHIBGHKH)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct NHDGBFAHGNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public AsyncTaskMethodBuilder<NGBHNACKADH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public FNFHONBFHOC circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public FNCJPDBCHMD cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public KDBNAJDNMLL cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public POMHAFMABIA evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private HCDCGJGJKGL <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private TaskAwaiter<LBIGLAFBHAC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1DE5CD0", Offset = "0x1DE4ED0", VA = "0x181DE5CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1DE6210", Offset = "0x1DE5410", VA = "0x181DE6210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly LBIGLAFBHAC PNEFIEGFOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly MPJHGOEDKGI DPCKBEGACHJ;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ALIDKHFLOPJ NDEHOLFCELJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1DE5BE0", Offset = "0x1DE4DE0", VA = "0x181DE5BE0", Slot = "4")]
		get
		{
			return default(ALIDKHFLOPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public GFGEBGOAOOO JDBGACGNEHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1DE5B20", Offset = "0x1DE4D20", VA = "0x181DE5B20", Slot = "5")]
		get
		{
			return default(GFGEBGOAOOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public AANKHINPJEL NJKLHEPALCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7B40E0", Offset = "0x7B32E0", VA = "0x1807B40E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public JHKLFLADBGI GFOPJDOLCMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7B4130", Offset = "0x7B3330", VA = "0x1807B4130", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public HCGKCGKKLOD GKIIFEOGEFI
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1DE5C40", Offset = "0x1DE4E40", VA = "0x181DE5C40")]
	private NGBHNACKADH(LBIGLAFBHAC MBONFJGCAML, MPJHGOEDKGI OLCFMIOBOJB, AANKHINPJEL KOBOJPIGOBH, JHKLFLADBGI MENAKNBEFCD, HCGKCGKKLOD LEMCBNKCCIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1DE5950", Offset = "0x1DE4B50", VA = "0x181DE5950")]
	[AsyncStateMachine(typeof(NHDGBFAHGNC))]
	public static Task<NGBHNACKADH> CKNHCMMCEJD(FNFHONBFHOC JIPGCHPOGGF, POMHAFMABIA PPOHHIBGHKH, FNCJPDBCHMD? JDBEELGHEEL, KDBNAJDNMLL? BDNMOIODFHD, CancellationToken IOOGCHJMBIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1DE5AC0", Offset = "0x1DE4CC0", VA = "0x181DE5AC0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class IEDBNMJFFCL : IJNDIKJPOPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface LOAGNIFEEIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<JMPKLAJPDEP> NKHPLHHBPIJ(FNFHONBFHOC JIPGCHPOGGF, POMHAFMABIA PPOHHIBGHKH, FNCJPDBCHMD? JDBEELGHEEL, KDBNAJDNMLL? BDNMOIODFHD, CancellationToken IOOGCHJMBIE);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MFOIJEPABJI();

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void IHJAOLCNCFA();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class OPNKAGLKNNG : LOAGNIFEEIL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct GDLDHBAFMBM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<JMPKLAJPDEP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public FNFHONBFHOC circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public POMHAFMABIA evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public FNCJPDBCHMD cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public KDBNAJDNMLL cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private TaskAwaiter<NGBHNACKADH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1DD7700", Offset = "0x1DD6900", VA = "0x181DD7700", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x1DD7A40", Offset = "0x1DD6C40", VA = "0x181DD7A40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x1DEBEC0", Offset = "0x1DEB0C0", VA = "0x181DEBEC0", Slot = "4")]
		[AsyncStateMachine(typeof(GDLDHBAFMBM))]
		public Task<JMPKLAJPDEP> NKHPLHHBPIJ(FNFHONBFHOC JIPGCHPOGGF, POMHAFMABIA PPOHHIBGHKH, FNCJPDBCHMD? JDBEELGHEEL, KDBNAJDNMLL? BDNMOIODFHD, CancellationToken IOOGCHJMBIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void MFOIJEPABJI();

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void IHJAOLCNCFA();

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		protected OPNKAGLKNNG()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct PLNGDFJIJDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder<JMPKLAJPDEP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public IEDBNMJFFCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter<NFDBFOHCHGK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1DED2A0", Offset = "0x1DEC4A0", VA = "0x181DED2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1DED4A0", Offset = "0x1DEC6A0", VA = "0x181DED4A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct JJOEJKNOICC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public IEDBNMJFFCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public FNFHONBFHOC circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public POMHAFMABIA evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public FNCJPDBCHMD cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public KDBNAJDNMLL cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private TaskAwaiter<JMPKLAJPDEP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x1DDF690", Offset = "0x1DDE890", VA = "0x181DDF690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1DDFBC0", Offset = "0x1DDEDC0", VA = "0x181DDFBC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly LOAGNIFEEIL IDCMPNFONAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly TaskCompletionSource<NFDBFOHCHGK> KHNKMECKHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly TaskCompletionSource<NFDBFOHCHGK> GIAOCEOJECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly CancellationTokenSource HGMIADABKAH;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool OOHKCKOHADI
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x880780", Offset = "0x87F980", VA = "0x180880780", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x95D8F0", Offset = "0x95CAF0", VA = "0x18095D8F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool HKJFMKICGME
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x95D930", Offset = "0x95CB30", VA = "0x18095D930", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x95D8E0", Offset = "0x95CAE0", VA = "0x18095D8E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool CKLNCAKIDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xF6AC50", Offset = "0xF69E50", VA = "0x180F6AC50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1DD8D80", Offset = "0x1DD7F80", VA = "0x181DD8D80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public JMPKLAJPDEP? FEBKJCFCFJF
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7B7560", Offset = "0x7B6760", VA = "0x1807B7560", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7B7530", Offset = "0x7B6730", VA = "0x1807B7530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1DD8C90", Offset = "0x1DD7E90", VA = "0x181DD8C90", Slot = "7")]
	[AsyncStateMachine(typeof(PLNGDFJIJDB))]
	public Task<JMPKLAJPDEP> IGADFLMPGFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1DD8D90", Offset = "0x1DD7F90", VA = "0x181DD8D90")]
	public IEDBNMJFFCL(LOAGNIFEEIL OAENIJAKBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1DD8B30", Offset = "0x1DD7D30", VA = "0x181DD8B30", Slot = "8")]
	[AsyncStateMachine(typeof(JJOEJKNOICC))]
	public Task HNAKOCBGCBL(FNFHONBFHOC JIPGCHPOGGF, POMHAFMABIA PPOHHIBGHKH, FNCJPDBCHMD? JDBEELGHEEL, KDBNAJDNMLL? BDNMOIODFHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1DD89C0", Offset = "0x1DD7BC0", VA = "0x181DD89C0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class EKLCINGOHFL : GIBIOLHIDMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly JHKLFLADBGI HFLLLJPMJEF;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7C19B0", Offset = "0x7C0BB0", VA = "0x1807C19B0")]
	public EKLCINGOHFL(JHKLFLADBGI MENAKNBEFCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class FOOAKCCLDHL
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class KGCAEEKPELP<TGraph> : FPEOKPOCNAP where TGraph : BBKDABEKLHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		protected readonly TGraph GFCGHGNAGLC;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual HMOOIDNELKL? HOCFOAEELJI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xDB38C0", Offset = "0xDB2AC0", VA = "0x180DB38C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7C19B0", Offset = "0x7C0BB0", VA = "0x1807C19B0")]
		public KGCAEEKPELP(TGraph AOFKLCLPNLP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class GBLACJGJJGI : KGCAEEKPELP<JBKGONFNOAP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override HMOOIDNELKL? HOCFOAEELJI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x1DD7610", Offset = "0x1DD6810", VA = "0x181DD7610", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7630", Offset = "0x1DD6830", VA = "0x181DD7630")]
		public GBLACJGJJGI(JBKGONFNOAP KDPINLLMPFJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x1DD7480", Offset = "0x1DD6680", VA = "0x181DD7480")]
	public static FPEOKPOCNAP DHBNKMCPKNO(BBKDABEKLHF AOFKLCLPNLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class NOENLEIAHEB : MPIHIIPHJNI, DMCBIEHMGNK, JFJJGGLOICA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class JCEAAPJMELK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
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
			public JCEAAPJMELK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public BHHPNLGMNNB errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private TaskAwaiter<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x1DEDFE0", Offset = "0x1DED1E0", VA = "0x181DEDFE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x1DEE250", Offset = "0x1DED450", VA = "0x181DEE250", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public NOENLEIAHEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public JCEAAPJMELK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x1DDF1B0", Offset = "0x1DDE3B0", VA = "0x181DDF1B0")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task PNIMAPOFAJJ(BHHPNLGMNNB errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct IAPFCDMMNOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public NOENLEIAHEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7F30", Offset = "0x1DD7130", VA = "0x181DD7F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x1DD83A0", Offset = "0x1DD75A0", VA = "0x181DD83A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class MBKPMNOJNKM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private struct <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public MBKPMNOJNKM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private TaskAwaiter<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x1DEE2B0", Offset = "0x1DED4B0", VA = "0x181DEE2B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x1DEE590", Offset = "0x1DED790", VA = "0x181DEE590", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public NOENLEIAHEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public MBKPMNOJNKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x1DE2950", Offset = "0x1DE1B50", VA = "0x181DE2950")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task LMLJBNELDLC(BHHPNLGMNNB errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly BDONGKFFHAG JPKOKMBNPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly ICollection<ELDBMKMLHPB> CPKIJJMHDIH;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private LEKMIPCMIOG ODBKJNALJGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x1DE9D70", Offset = "0x1DE8F70", VA = "0x181DE9D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public KHCIOCBLCGC<NKGANNEHNHO> CHGCOCOGJPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x87F720", Offset = "0x87E920", VA = "0x18087F720", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(KHCIOCBLCGC<NKGANNEHNHO>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xB25F50", Offset = "0xB25150", VA = "0x180B25F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private KHCIOCBLCGC<HJOFJJKDLOL> POIABKHCBCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x955FF0", Offset = "0x9551F0", VA = "0x180955FF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public KHCIOCBLCGC<GHLBDMPMDKP> BODFMBJKHBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7DBFB0", Offset = "0x7DB1B0", VA = "0x1807DBFB0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(KHCIOCBLCGC<GHLBDMPMDKP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public override KHCIOCBLCGC<AFBNAACJOMK> HLBGBLHJOLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x1DE9D90", Offset = "0x1DE8F90", VA = "0x181DE9D90", Slot = "20")]
		get
		{
			return default(KHCIOCBLCGC<AFBNAACJOMK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool JECAGGGABBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1DE9FF0", Offset = "0x1DE91F0", VA = "0x181DE9FF0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1DEA360", Offset = "0x1DE9560", VA = "0x181DEA360")]
	private NOENLEIAHEB(FNFHONBFHOC JIPGCHPOGGF, MDCFLBIEIKO JCCACJKHFKB, BDONGKFFHAG PIBDKEDHCCE, KHCIOCBLCGC<GHMMCINEBDI> CIHLOOFFIBE, KHCIOCBLCGC<NKGANNEHNHO> HNCOCKJDHMH, KHCIOCBLCGC<HJOFJJKDLOL> OFKCKILNIKB, bool OCACIDPCKEA, string MPENHPFDCDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1DE8090", Offset = "0x1DE7290", VA = "0x181DE8090")]
	public static NOENLEIAHEB DHBNKMCPKNO(FNFHONBFHOC JIPGCHPOGGF, MDCFLBIEIKO JCCACJKHFKB, BDONGKFFHAG BHCBEHDFPNA, KHCIOCBLCGC<GHMMCINEBDI> CIHLOOFFIBE, KHCIOCBLCGC<HJOFJJKDLOL> OFKCKILNIKB, KHCIOCBLCGC<NKGANNEHNHO> HNCOCKJDHMH, bool OCACIDPCKEA, bool OANFEFALLEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1DE9830", Offset = "0x1DE8A30", VA = "0x181DE9830", Slot = "21")]
	protected override void MEJEOBIHPJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1DE84A0", Offset = "0x1DE76A0", VA = "0x181DE84A0", Slot = "22")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1DE8FE0", Offset = "0x1DE81E0", VA = "0x181DE8FE0", Slot = "30")]
	public void FMFJPHOLNPE(ELDBMKMLHPB GBKEAOIILFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1DE79B0", Offset = "0x1DE6BB0", VA = "0x181DE79B0", Slot = "27")]
	public void BKFBAIACBII(EKHEMDKEJNH IOHAMMFMFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1DE8660", Offset = "0x1DE7860", VA = "0x181DE8660", Slot = "28")]
	public void FBAKAKILGLB(NHMEILLDDMD BFNGMPEIHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1DE7F60", Offset = "0x1DE7160", VA = "0x181DE7F60", Slot = "23")]
	protected override void CIHJIIFPICP(NEDHBJNPGKG GMKDFLEHPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1DE9610", Offset = "0x1DE8810", VA = "0x181DE9610", Slot = "32")]
	public string LFLEGMJODAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1DE99F0", Offset = "0x1DE8BF0", VA = "0x181DE99F0", Slot = "29")]
	public string NHJNMIDHFAB(int AJAOOILJBID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1DE9DD0", Offset = "0x1DE8FD0", VA = "0x181DE9DD0")]
	private void OJEOKHNNAME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1DE9770", Offset = "0x1DE8970", VA = "0x181DE9770", Slot = "31")]
	public void LHDPLHHMNPN(ELDBMKMLHPB GBKEAOIILFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1DEA1A0", Offset = "0x1DE93A0", VA = "0x181DEA1A0")]
	private void ONIALBCJINC(bool EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1DE7E60", Offset = "0x1DE7060", VA = "0x181DE7E60", Slot = "33")]
	[AsyncStateMachine(typeof(IAPFCDMMNOP))]
	public Task CDEDGNAMFKG(string EKDDCPALANJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1DE90D0", Offset = "0x1DE82D0", VA = "0x181DE90D0")]
	public void GOHMKCANCGO(string EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1DE93A0", Offset = "0x1DE85A0", VA = "0x181DE93A0")]
	private void IFNINBJLBMN(int EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0xB25F50", Offset = "0xB25150", VA = "0x180B25F50")]
	internal void CFDLMNEGFBO(KHCIOCBLCGC<NKGANNEHNHO> EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1DE7860", Offset = "0x1DE6A60", VA = "0x181DE7860")]
	[CompilerGenerated]
	private bool BIGKLCNJEAJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1DE9250", Offset = "0x1DE8450", VA = "0x181DE9250")]
	[CompilerGenerated]
	private bool HKLMMCMHNGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1DE9200", Offset = "0x1DE8400", VA = "0x181DE9200")]
	[CompilerGenerated]
	private int HDNCKKDHAIP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1DE9040", Offset = "0x1DE8240", VA = "0x181DE9040")]
	[CompilerGenerated]
	private bool GGJLBAJPEBG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1DE7690", Offset = "0x1DE6890", VA = "0x181DE7690")]
	[CompilerGenerated]
	private bool BBGNHLLLFLG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1DE9D20", Offset = "0x1DE8F20", VA = "0x181DE9D20")]
	[CompilerGenerated]
	private bool NOAGMPBAMAD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1DE7600", Offset = "0x1DE6800", VA = "0x181DE7600")]
	[CompilerGenerated]
	private bool ADBCMNHHMPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1DE9200", Offset = "0x1DE8400", VA = "0x181DE9200")]
	[CompilerGenerated]
	private int LIIEHGNGDGH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1DE9540", Offset = "0x1DE8740", VA = "0x181DE9540")]
	[CompilerGenerated]
	private bool IPCBENBAICC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1DE8040", Offset = "0x1DE7240", VA = "0x181DE8040")]
	[CompilerGenerated]
	private int DAFNIHDPOMI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1DE77E0", Offset = "0x1DE69E0", VA = "0x181DE77E0")]
	[CompilerGenerated]
	private void BCJABKFHMCA(object EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1DE7D90", Offset = "0x1DE6F90", VA = "0x181DE7D90")]
	[CompilerGenerated]
	private bool BLHOFLHJOHK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class NBKANIGJBFD
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class MLNNKBDBBCH : GPPJJNIKAHL<NCGPKFLEDHJ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override IIHJGLGJJHA INBPAPFLEJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x900780", Offset = "0x8FF980", VA = "0x180900780", Slot = "123")]
			get
			{
				return default(IIHJGLGJJHA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x1DE3140", Offset = "0x1DE2340", VA = "0x181DE3140")]
		public MLNNKBDBBCH(FNFHONBFHOC JIPGCHPOGGF, NCGPKFLEDHJ HMEKKAINJCD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class PDOLMPJMMMJ : ANCAPCLKANC<CJJGFFBNNPM>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1DEC720", Offset = "0x1DEB920", VA = "0x181DEC720")]
		public PDOLMPJMMMJ(FNFHONBFHOC JIPGCHPOGGF, CJJGFFBNNPM JCCACJKHFKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x1DEC480", Offset = "0x1DEB680", VA = "0x181DEC480", Slot = "118")]
		protected override void EOKPLNJLEIK(MFMPAAIODNH BBNLLJAKNKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1DEC430", Offset = "0x1DEB630", VA = "0x181DEC430")]
		[CompilerGenerated]
		private bool DENIKNJGBME()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x1DEC600", Offset = "0x1DEB800", VA = "0x181DEC600")]
		[CompilerGenerated]
		private void IDPPDFNCGEK(bool EKDDCPALANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class ADPCLHFHGLF : ANCAPCLKANC<PJPAJKNPNDK>
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class DDKCLCNCHOP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public EDDHNGIHGDG nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public ADPCLHFHGLF <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
			public DDKCLCNCHOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x1DD4950", Offset = "0x1DD3B50", VA = "0x181DD4950")]
			internal void DDLIKKLHEDH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x1DD4A40", Offset = "0x1DD3C40", VA = "0x181DD4A40")]
			internal bool PAJCNBDFGOP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x1DD49F0", Offset = "0x1DD3BF0", VA = "0x181DD49F0")]
			internal bool KJLAMBPDHEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x1DD4830", Offset = "0x1DD3A30", VA = "0x181DD4830")]
			internal void AAKENNIOEND(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x1DD49A0", Offset = "0x1DD3BA0", VA = "0x181DD49A0")]
			internal bool KEJAPJHFBFP()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1DD2350", Offset = "0x1DD1550", VA = "0x181DD2350")]
		public ADPCLHFHGLF(FNFHONBFHOC JIPGCHPOGGF, PJPAJKNPNDK JCCACJKHFKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x1DD2050", Offset = "0x1DD1250", VA = "0x181DD2050", Slot = "118")]
		protected override void EOKPLNJLEIK(MFMPAAIODNH BBNLLJAKNKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class LNCDMEMLGKM : ANCAPCLKANC<MAINOMDFMNL>
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class OJALOJELNHL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public EDDHNGIHGDG nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public LNCDMEMLGKM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public Predicate<Guid> <>9__11;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
			public OJALOJELNHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x1DEB2C0", Offset = "0x1DEA4C0", VA = "0x181DEB2C0")]
			internal object DDLIKKLHEDH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x1DEB5C0", Offset = "0x1DEA7C0", VA = "0x181DEB5C0")]
			internal bool KMIJNIJLOIN(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x1DEB820", Offset = "0x1DEAA20", VA = "0x181DEB820")]
			internal void PAJCNBDFGOP(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x1DEB460", Offset = "0x1DEA660", VA = "0x181DEB460")]
			internal string KJLAMBPDHEP(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x1DEB1D0", Offset = "0x1DEA3D0", VA = "0x181DEB1D0")]
			internal IReadOnlyList<object> AAKENNIOEND()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x1DEB410", Offset = "0x1DEA610", VA = "0x181DEB410")]
			internal bool KEJAPJHFBFP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x1DEB690", Offset = "0x1DEA890", VA = "0x181DEB690")]
			internal bool LGMIFPGEJAG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x1DEB640", Offset = "0x1DEA840", VA = "0x181DEB640")]
			internal void LBFIGCKNBNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x1DEB220", Offset = "0x1DEA420", VA = "0x181DEB220")]
			internal bool BAADNABJCCN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x1DEB3C0", Offset = "0x1DEA5C0", VA = "0x181DEB3C0")]
			internal bool HCPMCJCLKJJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x1DEB700", Offset = "0x1DEA900", VA = "0x181DEB700")]
			internal void MBOJBNJJJDK(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x1DEB270", Offset = "0x1DEA470", VA = "0x181DEB270")]
			internal bool CLHHGHJJBGO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x1DE2870", Offset = "0x1DE1A70", VA = "0x181DE2870")]
		public LNCDMEMLGKM(FNFHONBFHOC JIPGCHPOGGF, MAINOMDFMNL JCCACJKHFKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x1DE2240", Offset = "0x1DE1440", VA = "0x181DE2240", Slot = "118")]
		protected override void EOKPLNJLEIK(MFMPAAIODNH BBNLLJAKNKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class JKOIBNFLGLA : ANCAPCLKANC<CONMDFKLONJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class OKBOPPGOBJA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public JKOIBNFLGLA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public EDDHNGIHGDG nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
			public OKBOPPGOBJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x1DEBB90", Offset = "0x1DEAD90", VA = "0x181DEBB90")]
			internal bool DDLIKKLHEDH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x1DEBC80", Offset = "0x1DEAE80", VA = "0x181DEBC80")]
			internal void PAJCNBDFGOP(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x1DEBC30", Offset = "0x1DEAE30", VA = "0x181DEBC30")]
			internal bool KJLAMBPDHEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x1DEBA70", Offset = "0x1DEAC70", VA = "0x181DEBA70")]
			internal void AAKENNIOEND(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x1DEBBE0", Offset = "0x1DEADE0", VA = "0x181DEBBE0")]
			internal bool KEJAPJHFBFP()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x1DDFF20", Offset = "0x1DDF120", VA = "0x181DDFF20")]
		public JKOIBNFLGLA(FNFHONBFHOC JIPGCHPOGGF, CONMDFKLONJ HMEKKAINJCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x1DDFC20", Offset = "0x1DDEE20", VA = "0x181DDFC20", Slot = "118")]
		protected override void EOKPLNJLEIK(MFMPAAIODNH BBNLLJAKNKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public abstract class NDFHKGDJBDH<TNode> : ANCAPCLKANC<TNode> where TNode : notnull, LDIPJIIDFHM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct PLLDDLHENII : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public AsyncTaskMethodBuilder<OAAHAKNOJDO<KHCIOCBLCGC<GHMMCINEBDI>, AHFOEFCGOPM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public NDFHKGDJBDH<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private TaskAwaiter<OAAHAKNOJDO<KHCIOCBLCGC<GHMMCINEBDI>, AHFOEFCGOPM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x41BA130", Offset = "0x41B9330", VA = "0x1841BA130", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x41BA4F0", Offset = "0x41B96F0", VA = "0x1841BA4F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct FDFBHDIJAKK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public AsyncTaskMethodBuilder<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public NDFHKGDJBDH<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public KHCIOCBLCGC<GHMMCINEBDI> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private TaskAwaiter<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x3765550", Offset = "0x3764750", VA = "0x183765550", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x3765910", Offset = "0x3764B10", VA = "0x183765910", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public sealed override bool BFCHFFCPMDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x7CF450", Offset = "0x7CE650", VA = "0x1807CF450", Slot = "113")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override KHCIOCBLCGC<GHMMCINEBDI>? NPPMGHOLJBA
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x3FC71E0", Offset = "0x3FC63E0", VA = "0x183FC71E0", Slot = "117")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3A43C70", Offset = "0x3A42E70", VA = "0x183A43C70")]
		protected NDFHKGDJBDH(FNFHONBFHOC JIPGCHPOGGF, TNode JCCACJKHFKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x3FC70C0", Offset = "0x3FC62C0", VA = "0x183FC70C0", Slot = "98")]
		[AsyncStateMachine(typeof(NDFHKGDJBDH<>.PLLDDLHENII))]
		public override Task<OAAHAKNOJDO<KHCIOCBLCGC<GHMMCINEBDI>, AHFOEFCGOPM>> MCBGNEGJJGM(string MPENHPFDCDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x3FC6DD0", Offset = "0x3FC5FD0", VA = "0x183FC6DD0", Slot = "121")]
		public sealed override bool BBMLNHBLJBA(KHCIOCBLCGC<GHMMCINEBDI> CIHLOOFFIBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3FC6E70", Offset = "0x3FC6070", VA = "0x183FC6E70", Slot = "110")]
		protected sealed override bool FCDBPMGKMHJ(KHCIOCBLCGC<GHMMCINEBDI> CIHLOOFFIBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3FC6F10", Offset = "0x3FC6110", VA = "0x183FC6F10", Slot = "111")]
		protected override bool JKHGLBPNLLM(KHCIOCBLCGC<GHMMCINEBDI> CIHLOOFFIBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x3FC6FB0", Offset = "0x3FC61B0", VA = "0x183FC6FB0", Slot = "99")]
		[AsyncStateMachine(typeof(NDFHKGDJBDH<>.FDFBHDIJAKK))]
		public override Task<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> LHFMFLNGGEM(KHCIOCBLCGC<GHMMCINEBDI> CIHLOOFFIBE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class NLHKBIHBCDD : NIIPGLKCBOI<JFPGEBHPLFJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class IKAMLFGCINO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public NLHKBIHBCDD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public EDDHNGIHGDG nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
			public IKAMLFGCINO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x1DD8EA0", Offset = "0x1DD80A0", VA = "0x181DD8EA0")]
			internal bool HJELBGLOMMB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x1DD8F20", Offset = "0x1DD8120", VA = "0x181DD8F20")]
			internal void MDMMNIMCCFB(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x1DE6C80", Offset = "0x1DE5E80", VA = "0x181DE6C80")]
		public NLHKBIHBCDD(FNFHONBFHOC JIPGCHPOGGF, JFPGEBHPLFJ HMEKKAINJCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x1DE6A30", Offset = "0x1DE5C30", VA = "0x181DE6A30", Slot = "123")]
		protected override void BKNDBNHBHHP(MFMPAAIODNH BBNLLJAKNKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class HDAAMBNJKEF : IHECMDJHCGB<AECIPHDJMFA>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override NodeVisualizationKey NFEHEBDHPKF
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x879D40", Offset = "0x878F40", VA = "0x180879D40", Slot = "89")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7ED0", Offset = "0x1DD70D0", VA = "0x181DD7ED0")]
		public HDAAMBNJKEF(FNFHONBFHOC JIPGCHPOGGF, AECIPHDJMFA JCCACJKHFKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private abstract class IHECMDJHCGB<TNode> : ANCAPCLKANC<TNode> where TNode : notnull, EFPOLDJEDKE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct EHMFIGDLMDC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public AsyncTaskMethodBuilder<OAAHAKNOJDO<KHCIOCBLCGC<GHMMCINEBDI>, AHFOEFCGOPM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public IHECMDJHCGB<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			private TaskAwaiter<OAAHAKNOJDO<KHCIOCBLCGC<GHMMCINEBDI>, AHFOEFCGOPM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x341F4A0", Offset = "0x341E6A0", VA = "0x18341F4A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x341F800", Offset = "0x341EA00", VA = "0x18341F800", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct AFACDLJGEIJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public AsyncTaskMethodBuilder<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public IHECMDJHCGB<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public KHCIOCBLCGC<GHMMCINEBDI> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			private TaskAwaiter<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x383C7F0", Offset = "0x383B9F0", VA = "0x18383C7F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x383CB20", Offset = "0x383BD20", VA = "0x18383CB20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override KHCIOCBLCGC<NJGFNHCPFKD>? AFOAALLAALN
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x3A43CA0", Offset = "0x3A42EA0", VA = "0x183A43CA0", Slot = "114")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override KHCIOCBLCGC<GHMMCINEBDI>? NPPMGHOLJBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x3A43D50", Offset = "0x3A42F50", VA = "0x183A43D50", Slot = "117")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3A43C70", Offset = "0x3A42E70", VA = "0x183A43C70")]
		public IHECMDJHCGB(FNFHONBFHOC JIPGCHPOGGF, TNode JCCACJKHFKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x3A43B50", Offset = "0x3A42D50", VA = "0x183A43B50", Slot = "98")]
		[AsyncStateMachine(typeof(IHECMDJHCGB<>.EHMFIGDLMDC))]
		public override Task<OAAHAKNOJDO<KHCIOCBLCGC<GHMMCINEBDI>, AHFOEFCGOPM>> MCBGNEGJJGM(string MPENHPFDCDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x3A43860", Offset = "0x3A42A60", VA = "0x183A43860", Slot = "121")]
		public sealed override bool BBMLNHBLJBA(KHCIOCBLCGC<GHMMCINEBDI> CIHLOOFFIBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x3A43900", Offset = "0x3A42B00", VA = "0x183A43900", Slot = "110")]
		protected sealed override bool FCDBPMGKMHJ(KHCIOCBLCGC<GHMMCINEBDI> CIHLOOFFIBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x3A439A0", Offset = "0x3A42BA0", VA = "0x183A439A0", Slot = "111")]
		protected override bool JKHGLBPNLLM(KHCIOCBLCGC<GHMMCINEBDI> CIHLOOFFIBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x3A43A40", Offset = "0x3A42C40", VA = "0x183A43A40", Slot = "99")]
		[AsyncStateMachine(typeof(IHECMDJHCGB<>.AFACDLJGEIJ))]
		public override Task<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> LHFMFLNGGEM(KHCIOCBLCGC<GHMMCINEBDI> CIHLOOFFIBE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class EDCIILEBKLO : NIIPGLKCBOI<CNLDBOHGKJC>
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private sealed class OMNKBFECPGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public EDCIILEBKLO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public EDDHNGIHGDG nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
			public OMNKBFECPGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x1DEBDA0", Offset = "0x1DEAFA0", VA = "0x181DEBDA0")]
			internal int HJELBGLOMMB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x1DEBE20", Offset = "0x1DEB020", VA = "0x181DEBE20")]
			internal void MDMMNIMCCFB(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x1DD4F60", Offset = "0x1DD4160", VA = "0x181DD4F60")]
		public EDCIILEBKLO(FNFHONBFHOC JIPGCHPOGGF, CNLDBOHGKJC HMEKKAINJCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x1DD4CB0", Offset = "0x1DD3EB0", VA = "0x181DD4CB0", Slot = "123")]
		protected override void BKNDBNHBHHP(MFMPAAIODNH BBNLLJAKNKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class EFKEADLNBFN : ANCAPCLKANC<MGCAPOLNJBO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override NodeVisualizationKey NFEHEBDHPKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xA40450", Offset = "0xA3F650", VA = "0x180A40450", Slot = "89")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x1DD4FC0", Offset = "0x1DD41C0", VA = "0x181DD4FC0")]
		public EFKEADLNBFN(FNFHONBFHOC JIPGCHPOGGF, MGCAPOLNJBO JCCACJKHFKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private sealed class NFPCEJNAGLB : IHECMDJHCGB<EKGJJLIODCJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool MELDFJHDGJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x7CF450", Offset = "0x7CE650", VA = "0x1807CF450", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override bool JHDAHBKEBJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x1DE5910", Offset = "0x1DE4B10", VA = "0x181DE5910", Slot = "115")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override NodeVisualizationKey NFEHEBDHPKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x91AFE0", Offset = "0x91A1E0", VA = "0x18091AFE0", Slot = "89")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x1DE58B0", Offset = "0x1DE4AB0", VA = "0x181DE58B0")]
		public NFPCEJNAGLB(FNFHONBFHOC JIPGCHPOGGF, EKGJJLIODCJ JCCACJKHFKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private sealed class LFGCFCHPHLM : ANCAPCLKANC<PHLFBFGPGEI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override NodeVisualizationKey NFEHEBDHPKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x1051100", Offset = "0x1050300", VA = "0x181051100", Slot = "89")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x1DE2170", Offset = "0x1DE1370", VA = "0x181DE2170")]
		public LFGCFCHPHLM(FNFHONBFHOC JIPGCHPOGGF, PHLFBFGPGEI JCCACJKHFKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private sealed class JLJEOECIEIL : ANCAPCLKANC<CECECBEPJGP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override NodeVisualizationKey NFEHEBDHPKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x91C370", Offset = "0x91B570", VA = "0x18091C370", Slot = "89")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x1DDFF90", Offset = "0x1DDF190", VA = "0x181DDFF90")]
		public JLJEOECIEIL(FNFHONBFHOC JIPGCHPOGGF, CECECBEPJGP JCCACJKHFKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7CF450", Offset = "0x7CE650", VA = "0x1807CF450", Slot = "110")]
		protected override bool FCDBPMGKMHJ(KHCIOCBLCGC<GHMMCINEBDI> CIHLOOFFIBE)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private sealed class NMJCDKNJKLE : ANCAPCLKANC<ECHMGBKEFIP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey NFEHEBDHPKF
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x929D00", Offset = "0x928F00", VA = "0x180929D00", Slot = "89")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool JACPAHNOEEL
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x1DE75B0", Offset = "0x1DE67B0", VA = "0x181DE75B0", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		protected override bool PIIJAGBFINL
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x7CF450", Offset = "0x7CE650", VA = "0x1807CF450", Slot = "88")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x1DE7540", Offset = "0x1DE6740", VA = "0x181DE7540")]
		public NMJCDKNJKLE(FNFHONBFHOC JIPGCHPOGGF, ECHMGBKEFIP JCCACJKHFKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private sealed class MNPHOAIMCHJ : ANCAPCLKANC<NBLCJMECMIF>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey NFEHEBDHPKF
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x900780", Offset = "0x8FF980", VA = "0x180900780", Slot = "89")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override bool JACPAHNOEEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x1DE3210", Offset = "0x1DE2410", VA = "0x181DE3210", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		protected override bool PIIJAGBFINL
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x7CF450", Offset = "0x7CE650", VA = "0x1807CF450", Slot = "88")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x1DE31A0", Offset = "0x1DE23A0", VA = "0x181DE31A0")]
		public MNPHOAIMCHJ(FNFHONBFHOC JIPGCHPOGGF, NBLCJMECMIF JCCACJKHFKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public sealed class AELPPJACOAH : NDFHKGDJBDH<BKINDDGOMEC>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override NodeVisualizationKey NFEHEBDHPKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x928330", Offset = "0x927530", VA = "0x180928330", Slot = "89")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x1DD23C0", Offset = "0x1DD15C0", VA = "0x181DD23C0")]
		public AELPPJACOAH(FNFHONBFHOC JIPGCHPOGGF, BKINDDGOMEC JCCACJKHFKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public sealed class BIFINPJCHEL : NIIPGLKCBOI<LOEMGGNEPKC>
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class AGPBDCJPHOG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public BIFINPJCHEL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public EDDHNGIHGDG nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
			public AGPBDCJPHOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x1DD2690", Offset = "0x1DD1890", VA = "0x181DD2690")]
			internal int HJELBGLOMMB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x1DD2710", Offset = "0x1DD1910", VA = "0x181DD2710")]
			internal void MDMMNIMCCFB(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3C00", Offset = "0x1DD2E00", VA = "0x181DD3C00")]
		public BIFINPJCHEL(FNFHONBFHOC JIPGCHPOGGF, LOEMGGNEPKC HMEKKAINJCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3900", Offset = "0x1DD2B00", VA = "0x181DD3900", Slot = "123")]
		protected override void BKNDBNHBHHP(MFMPAAIODNH BBNLLJAKNKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class NHICFNBALAN : GPPJJNIKAHL<CKNAIKDEHMJ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override IIHJGLGJJHA INBPAPFLEJK
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x879D40", Offset = "0x878F40", VA = "0x180879D40", Slot = "123")]
			get
			{
				return default(IIHJGLGJJHA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x1DE6280", Offset = "0x1DE5480", VA = "0x181DE6280")]
		public NHICFNBALAN(FNFHONBFHOC JIPGCHPOGGF, CKNAIKDEHMJ HMEKKAINJCD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class AJADKKBPCGD : ANCAPCLKANC<MDCFLBIEIKO>
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x1DD27B0", Offset = "0x1DD19B0", VA = "0x181DD27B0")]
		public AJADKKBPCGD(FNFHONBFHOC JIPGCHPOGGF, MDCFLBIEIKO JCCACJKHFKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public abstract class ANCAPCLKANC<TNode> : CGNGINGKBKI, IDisposable where TNode : notnull, MDCFLBIEIKO
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		protected readonly struct PCAIEOOCJCC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public readonly string PBJMNMFOOGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public readonly string JHMMLFHBLCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public readonly string LALIIMMABOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public readonly MPGMJDCCCED DHJDDBGALPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public readonly IFNMGGNNKDG MPLBPHGFLAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public readonly Func<string, bool> AKMHMFFBFFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public readonly string NEEJGPGEKNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public readonly Func<string, bool> MBGKNAFKPDO;

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x4195000", Offset = "0x4194200", VA = "0x184195000")]
			public PCAIEOOCJCC(string CKJMJIGGHHA, string NKJLJGHDNBH, string DJPACKHPHFP, MPGMJDCCCED HFGECFCFAOE, IFNMGGNNKDG CBADDMBIIDB, Func<string, bool> BCACEJCJCMK, string BFLGBFFLLPE, Func<string, bool> KNACINAHHOK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class NKKAHBEFAIB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public ANCAPCLKANC<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public FNFHONBFHOC circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
			public NKKAHBEFAIB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x3FF8CF0", Offset = "0x3FF7EF0", VA = "0x183FF8CF0")]
			internal ILBDOLNKHAI KAMOLECOHLK(EPNMOEANLDB portGroup, int index)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		[CompilerGenerated]
		private struct GFGJCPDIFME : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public ANCAPCLKANC<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			private TaskAwaiter<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x3860BF0", Offset = "0x385FDF0", VA = "0x183860BF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x893800", Offset = "0x892A00", VA = "0x180893800", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		[CompilerGenerated]
		private struct GGHKLLKMKEL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public AsyncTaskMethodBuilder<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public ANCAPCLKANC<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public ODDJOGHGEHC? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public FGFCDGHHJFA? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			private TaskAwaiter<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x3863050", Offset = "0x3862250", VA = "0x183863050", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x38632E0", Offset = "0x38624E0", VA = "0x1838632E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class CJKLJAOEIIH
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000060")]
			private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				public CJKLJAOEIIH <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D1")]
				[Cpp2IlInjected.Address(RVA = "0x321A780", Offset = "0x3219980", VA = "0x18321A780", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D2")]
				[Cpp2IlInjected.Address(RVA = "0x893800", Offset = "0x892A00", VA = "0x180893800", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public Func<string, bool> submitValidator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public EDDHNGIHGDG nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public ANCAPCLKANC<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public MFMPAAIODNH configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
			public CJKLJAOEIIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
			internal string EGJCLNLCKBD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x7B4120", Offset = "0x7B3320", VA = "0x1807B4120")]
			internal void FHICGELFOAM(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x4A22C40", Offset = "0x4A21E40", VA = "0x184A22C40")]
			[AsyncStateMachine(typeof(ANCAPCLKANC<>.CJKLJAOEIIH.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void KHPMENOAGGG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class BJHBOJGPHCG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public EDDHNGIHGDG nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
			public BJHBOJGPHCG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x47C7E60", Offset = "0x47C7060", VA = "0x1847C7E60")]
			internal bool DNGOHMODKIJ(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x47C7F40", Offset = "0x47C7140", VA = "0x1847C7F40")]
			internal bool IJIPIMMEFPE(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		[CompilerGenerated]
		private struct ACIPJGAIKHM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public AsyncTaskMethodBuilder<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public ANCAPCLKANC<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			private TaskAwaiter<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x38343D0", Offset = "0x38335D0", VA = "0x1838343D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x3834730", Offset = "0x3833930", VA = "0x183834730", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly FNFHONBFHOC DEPGNJNBHGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly bool DIMHLHFPDOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private FBMOHDMJAEI<GHMMCINEBDI, ILBDOLNKHAI> OMFCEHNJIKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private FBMOHDMJAEI<GHMMCINEBDI, JEIDPNIPILI> FAABLJADJCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private List<Action> HBIEBPLKBME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		[CompilerGenerated]
		private Action<KHCIOCBLCGC<GHMMCINEBDI>>? DHPIFIOBENP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		[CompilerGenerated]
		private Action<KHCIOCBLCGC<GHMMCINEBDI>, JEIDPNIPILI>? PHGPHAFBKEF;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		protected EDDHNGIHGDG FNMCFLHJNJK
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x38BBB40", Offset = "0x38BAD40", VA = "0x1838BBB40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		protected TNode KAGFLFNBIHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public EIMAHFBCFHK<JPNBFHLCDNL> PPCJGDBKOOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x9B29A0", Offset = "0x9B1BA0", VA = "0x1809B29A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(EIMAHFBCFHK<JPNBFHLCDNL>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public KHCIOCBLCGC<EPFPOAIBINI> MEIFLPDOALK
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x38BF1A0", Offset = "0x38BE3A0", VA = "0x1838BF1A0", Slot = "6")]
			get
			{
				return default(KHCIOCBLCGC<EPFPOAIBINI>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public object PAOMFBJFMLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x347A500", Offset = "0x3479700", VA = "0x18347A500", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public virtual bool JHAKPOFIIOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x7CF450", Offset = "0x7CE650", VA = "0x1807CF450", Slot = "87")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int BGOBLBNPHCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x38BEEC0", Offset = "0x38BE0C0", VA = "0x1838BEEC0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public KGIEMHEELDO JJMGJIIEELA
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x38BEE80", Offset = "0x38BE080", VA = "0x1838BEE80", Slot = "10")]
			get
			{
				return default(KGIEMHEELDO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string LCNJDIOHANM
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x38BF330", Offset = "0x38BE530", VA = "0x1838BF330", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		protected virtual bool PIIJAGBFINL
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "88")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public virtual NodeVisualizationKey NFEHEBDHPKF
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610", Slot = "89")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public KHCIOCBLCGC<IPBMAMLCMLC> HKCKGPKBAEG
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x9451E0", Offset = "0x9443E0", VA = "0x1809451E0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(KHCIOCBLCGC<IPBMAMLCMLC>);
			}
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x9B4720", Offset = "0x9B3920", VA = "0x1809B4720")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public virtual bool JACPAHNOEEL
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public virtual bool MELDFJHDGJI
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual IOJAKCMGOOF MMPDCMGFFGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x918C70", Offset = "0x917E70", VA = "0x180918C70", Slot = "92")]
			get
			{
				return default(IOJAKCMGOOF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool BHGJDCFFBIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x38BECB0", Offset = "0x38BDEB0", VA = "0x1838BECB0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool ALMJIMCOPEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x38BED00", Offset = "0x38BDF00", VA = "0x1838BED00", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public bool EFJCGKLAJBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x38BED50", Offset = "0x38BDF50", VA = "0x1838BED50", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public int AAHDFJGFADM
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x38BF160", Offset = "0x38BE360", VA = "0x1838BF160", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public bool EPFFJCNKBKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x38BEFF0", Offset = "0x38BE1F0", VA = "0x1838BEFF0", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public bool LJLILFKMPLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x38BEDE0", Offset = "0x38BDFE0", VA = "0x1838BEDE0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public bool MLLJFAKCHAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xAF6D80", Offset = "0xAF5F80", VA = "0x180AF6D80", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xAF6D70", Offset = "0xAF5F70", VA = "0x180AF6D70")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public virtual bool HPJEBKDCCKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual bool EKAPMDKLDFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x38BEDA0", Offset = "0x38BDFA0", VA = "0x1838BEDA0", Slot = "94")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool FPDFOCKHHJM
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x38BEF50", Offset = "0x38BE150", VA = "0x1838BEF50", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public ODDJOGHGEHC LBCBIKCAOAC
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x38BF0C0", Offset = "0x38BE2C0", VA = "0x1838BF0C0", Slot = "27")]
			get
			{
				return default(ODDJOGHGEHC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public FGFCDGHHJFA HLNGFPFIIBO
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x38BF110", Offset = "0x38BE310", VA = "0x1838BF110", Slot = "29")]
			get
			{
				return default(FGFCDGHHJFA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public virtual bool EPGFPBCGEIP
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public virtual CEGJKLKFGIM? NPBKJMDFLCF
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610", Slot = "107")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public virtual IEBKMLMOLKJ? COAMHILLIGC
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610", Slot = "108")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public virtual IEnumerable<EIMAHFBCFHK<GGOIHKGODHF>>? OPKLLPFDGBI
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610", Slot = "109")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool ANLKEEHBBNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x38BEE30", Offset = "0x38BE030", VA = "0x1838BEE30", Slot = "112")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public EIMAHFBCFHK<NJGFNHCPFKD> HPIAJNEBHBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x38BF030", Offset = "0x38BE230", VA = "0x1838BF030", Slot = "55")]
			get
			{
				return default(EIMAHFBCFHK<NJGFNHCPFKD>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public KHCIOCBLCGC<NJGFNHCPFKD> NEOPDODJINO
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x38BEF00", Offset = "0x38BE100", VA = "0x1838BEF00", Slot = "56")]
			get
			{
				return default(KHCIOCBLCGC<NJGFNHCPFKD>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public virtual bool BFCHFFCPMDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "113")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual KHCIOCBLCGC<NJGFNHCPFKD>? AFOAALLAALN
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610", Slot = "114")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public virtual bool JHDAHBKEBJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "115")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool AJOJADKIFLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x38BEFA0", Offset = "0x38BE1A0", VA = "0x1838BEFA0", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public string FLDBLPHJNKM
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x7BD4B0", Offset = "0x7BC6B0", VA = "0x1807BD4B0", Slot = "63")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x7BD440", Offset = "0x7BC640", VA = "0x1807BD440")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public EIMAHFBCFHK<GGOIHKGODHF> PDIDEAPHNFB
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x38BF080", Offset = "0x38BE280", VA = "0x1838BF080", Slot = "62")]
			get
			{
				return default(EIMAHFBCFHK<GGOIHKGODHF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public EIMAHFBCFHK<GGOIHKGODHF>? PALNLLKCENO
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x38BF210", Offset = "0x38BE410", VA = "0x1838BF210", Slot = "116")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public EPKIAMCHGOM<GHMMCINEBDI, JEIDPNIPILI> GFFKEDFPDAP
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x38BF2F0", Offset = "0x38BE4F0", VA = "0x1838BF2F0", Slot = "64")]
			get
			{
				return default(EPKIAMCHGOM<GHMMCINEBDI, JEIDPNIPILI>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual KHCIOCBLCGC<GHMMCINEBDI>? NPPMGHOLJBA
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610", Slot = "117")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public virtual bool CKFGOFAKNFD
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action COIOMNELGCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x38BDAA0", Offset = "0x38BCCA0", VA = "0x1838BDAA0", Slot = "36")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x38BE130", Offset = "0x38BD330", VA = "0x1838BE130", Slot = "37")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event MGMLNJPBGEB AEIDKCOPACN
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x38BA2F0", Offset = "0x38B94F0", VA = "0x1838BA2F0", Slot = "38")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x38BE090", Offset = "0x38BD290", VA = "0x1838BE090", Slot = "39")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event HLKDMLJLDFB CBKJFDGCFBA
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x38BE740", Offset = "0x38BD940", VA = "0x1838BE740", Slot = "40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x38BCA50", Offset = "0x38BBC50", VA = "0x1838BCA50", Slot = "41")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action BBJBMDAJANF
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x38BC9A0", Offset = "0x38BBBA0", VA = "0x1838BC9A0", Slot = "42")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x38BDC00", Offset = "0x38BCE00", VA = "0x1838BDC00", Slot = "43")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action NKONDOPDHNE
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x38BB4F0", Offset = "0x38BA6F0", VA = "0x1838BB4F0", Slot = "44")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x38BDA00", Offset = "0x38BCC00", VA = "0x1838BDA00", Slot = "45")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<KHCIOCBLCGC<GHMMCINEBDI>, JEIDPNIPILI> AGJKJPIKBKO
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x38BAAE0", Offset = "0x38B9CE0", VA = "0x1838BAAE0", Slot = "66")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x38BDB40", Offset = "0x38BCD40", VA = "0x1838BDB40", Slot = "67")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<KHCIOCBLCGC<GHMMCINEBDI>, JEIDPNIPILI> KMJAJGBHABH
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x38BA790", Offset = "0x38B9990", VA = "0x1838BA790", Slot = "70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x38BC820", Offset = "0x38BBA20", VA = "0x1838BC820", Slot = "71")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<KHCIOCBLCGC<GHMMCINEBDI>> MPBNFAFFOPP
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x38BA390", Offset = "0x38B9590", VA = "0x1838BA390", Slot = "68")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x38BD090", Offset = "0x38BC290", VA = "0x1838BD090", Slot = "69")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<KHCIOCBLCGC<GHMMCINEBDI>, KHCIOCBLCGC<GHMMCINEBDI>> CBDKCMNJNIK
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x38BAA20", Offset = "0x38B9C20", VA = "0x1838BAA20", Slot = "72")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x38BE680", Offset = "0x38BD880", VA = "0x1838BE680", Slot = "73")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<KHCIOCBLCGC<GHMMCINEBDI>, JEIDPNIPILI> MJCAKIIFNPI
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x38BC8E0", Offset = "0x38BBAE0", VA = "0x1838BC8E0", Slot = "74")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x38BBD70", Offset = "0x38BAF70", VA = "0x1838BBD70", Slot = "75")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<KHCIOCBLCGC<GHMMCINEBDI>, KHCIOCBLCGC<GHMMCINEBDI>> OIGABGEDOCP
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x38BC760", Offset = "0x38BB960", VA = "0x1838BC760", Slot = "76")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x38BD910", Offset = "0x38BCB10", VA = "0x1838BD910", Slot = "77")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x38BE7E0", Offset = "0x38BD9E0", VA = "0x1838BE7E0")]
		[OGJCPCCKFOF("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		[OGJCPCCKFOF("Need to handle `Name` better.")]
		protected ANCAPCLKANC(FNFHONBFHOC JIPGCHPOGGF, TNode JCCACJKHFKB, bool OANFEFALLEF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x38BD150", Offset = "0x38BC350", VA = "0x1838BD150", Slot = "85")]
		protected virtual void MEJEOBIHPJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x38BACF0", Offset = "0x38B9EF0", VA = "0x1838BACF0", Slot = "86")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x38BCB70", Offset = "0x38BBD70", VA = "0x1838BCB70", Slot = "9")]
		[AsyncStateMachine(typeof(ANCAPCLKANC<>.GFGJCPDIFME))]
		public void ILMJEHBLLPF(int LKEAIGJBCCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x38BE040", Offset = "0x38BD240", VA = "0x1838BE040")]
		public bool OJMCEBCCLFG([In] ODDJOGHGEHC EKDDCPALANJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x38B9F80", Offset = "0x38B9180", VA = "0x1838B9F80")]
		public bool AKLPLPACOFJ([In] FGFCDGHHJFA EKDDCPALANJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x38BA850", Offset = "0x38B9A50", VA = "0x1838BA850", Slot = "31")]
		public void COCLAPHOEAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x38B9E30", Offset = "0x38B9030", VA = "0x1838B9E30", Slot = "32")]
		[AsyncStateMachine(typeof(ANCAPCLKANC<>.GGHKLLKMKEL))]
		public Task<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> AJDDNMOFFBL(ODDJOGHGEHC? OCBBPFAEPEN, FGFCDGHHJFA? IKIEOLKACCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "95")]
		public virtual void DBDFPKLBGGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "96")]
		public virtual void CPCIAMBNGKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "97")]
		public virtual void HHGKIBPAEBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x1B2F750", Offset = "0x1B2E950", VA = "0x181B2F750")]
		protected void KCJKKCALGFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x38BAC10", Offset = "0x38B9E10", VA = "0x1838BAC10")]
		protected void DFOGCIIODBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x1FC8CA0", Offset = "0x1FC7EA0", VA = "0x181FC8CA0")]
		private void GCNAHCIGHDE([In] FGFCDGHHJFA ECLCOOPOABI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x38BCFC0", Offset = "0x38BC1C0", VA = "0x1838BCFC0", Slot = "98")]
		public virtual Task<OAAHAKNOJDO<KHCIOCBLCGC<GHMMCINEBDI>, AHFOEFCGOPM>> MCBGNEGJJGM(string MPENHPFDCDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x38BCEF0", Offset = "0x38BC0F0", VA = "0x1838BCEF0", Slot = "99")]
		public virtual Task<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> LHFMFLNGGEM(KHCIOCBLCGC<GHMMCINEBDI> CIHLOOFFIBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "100")]
		public virtual void OHCAPDPJNOB(KHCIOCBLCGC<GHMMCINEBDI> MBGANDEDPDN, KHCIOCBLCGC<GHMMCINEBDI> JGFCAMDGBLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x38BA450", Offset = "0x38B9650", VA = "0x1838BA450", Slot = "101")]
		public virtual IEnumerable<OLNEDDGCOEI> CFAEMENHFJL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x38BCAF0", Offset = "0x38BBCF0", VA = "0x1838BCAF0", Slot = "102")]
		public OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM> IEAABEHAANA(string EECPMAAEBOO)
		{
			return default(OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x38BBC30", Offset = "0x38BAE30", VA = "0x1838BBC30", Slot = "46")]
		public bool FFMBEIIGKKA([Out] Guid OBEDGDNAKOD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x38BA050", Offset = "0x38B9250", VA = "0x1838BA050")]
		public bool BFHAANBMJGI([In] Guid KEAGJDNLFNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "103")]
		public virtual void GKFNPGBHNDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "104")]
		public virtual void EMEHLCMKNNF(bool NALMMJJHNMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610", Slot = "105")]
		public virtual LNKIGGKBHAM PMBHOOEEMOC([In] FFNKCPKKHFK JBGGNBICAFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x38BA5D0", Offset = "0x38B97D0", VA = "0x1838BA5D0")]
		protected void CKOFBGGFCFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x38BBB10", Offset = "0x38BAD10", VA = "0x1838BBB10", Slot = "110")]
		protected virtual bool FCDBPMGKMHJ(KHCIOCBLCGC<GHMMCINEBDI> CIHLOOFFIBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "111")]
		protected virtual bool JKHGLBPNLLM(KHCIOCBLCGC<GHMMCINEBDI> CIHLOOFFIBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "118")]
		protected virtual void EOKPLNJLEIK(MFMPAAIODNH FOIDGMBMFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x38BC270", Offset = "0x38BB470", VA = "0x1838BC270")]
		protected void GNONFLFGPDG(MFMPAAIODNH BBNLLJAKNKO, Func<string> GJEEJKJPNOL, Action<string> NGEFKAMJCOP, PCAIEOOCJCC FJIDAJDLPID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x38BBE30", Offset = "0x38BB030", VA = "0x1838BBE30")]
		protected void FMOLLOMHDKL(MFMPAAIODNH BBNLLJAKNKO, Func<string> GJEEJKJPNOL, Action<string> NGEFKAMJCOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x38BD7E0", Offset = "0x38BC9E0", VA = "0x1838BD7E0", Slot = "119")]
		protected virtual void MIGHJPFDIEK(MFMPAAIODNH BBNLLJAKNKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x38BBAC0", Offset = "0x38BACC0", VA = "0x1838BBAC0", Slot = "79")]
		public void FBAKAKILGLB(MFMPAAIODNH BBNLLJAKNKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x38BC1A0", Offset = "0x38BB3A0", VA = "0x1838BC1A0", Slot = "80")]
		public BLGOMLCKDJD GBKEIOEAAAB()
		{
			return default(BLGOMLCKDJD);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "121")]
		public virtual bool BBMLNHBLJBA(KHCIOCBLCGC<GHMMCINEBDI> CIHLOOFFIBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x124FE20", Offset = "0x124F020", VA = "0x18124FE20")]
		private void CLHAJEGELIE([In] ODDJOGHGEHC JCMPCLFLJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x38BA4E0", Offset = "0x38B96E0", VA = "0x1838BA4E0")]
		private void CHMFPNFLLHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x38BB590", Offset = "0x38BA790", VA = "0x1838BB590")]
		private void ENFEBJIDCBC(int LAAODHABCDF, EPNMOEANLDB JEPOKPLCHDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x38BA000", Offset = "0x38B9200", VA = "0x1838BA000")]
		private void BEDHDCGCLOB(int MBGANDEDPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x38BCC20", Offset = "0x38BBE20", VA = "0x1838BCC20")]
		private void IPCJOJDGLHO(int MBGANDEDPDN, EPNMOEANLDB LFGFGNLMMAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x38BDC90", Offset = "0x38BCE90", VA = "0x1838BDC90")]
		private void OFFLBCFMAIP(int CCBLIMCJEOM, int HJGOBNGHGAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x38BC140", Offset = "0x38BB340", VA = "0x1838BC140")]
		private void GBEKKCCCAMN(int CCBLIMCJEOM, int HJGOBNGHGAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x38BC710", Offset = "0x38BB910", VA = "0x1838BC710")]
		private void GOAHDJCLHHN(int MBGANDEDPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x38BE1D0", Offset = "0x38BD3D0", VA = "0x1838BE1D0")]
		private void OMOEHCNNAFJ(int LAAODHABCDF, EPNMOEANLDB JEPOKPLCHDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x38BE600", Offset = "0x38BD800", VA = "0x1838BE600")]
		private void OODCAGCIOOA(int MBGANDEDPDN, EPNMOEANLDB LFGFGNLMMAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x38BCDD0", Offset = "0x38BBFD0", VA = "0x1838BCDD0", Slot = "122")]
		[AsyncStateMachine(typeof(ANCAPCLKANC<>.ACIPJGAIKHM))]
		public Task<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> KNGLAKJOPKD(string EECPMAAEBOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x38BABA0", Offset = "0x38B9DA0", VA = "0x1838BABA0", Slot = "53")]
		private void DEEDBLLDBAK(object MIMEGFFPKFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x38BCD60", Offset = "0x38BBF60", VA = "0x1838BCD60", Slot = "54")]
		private void JDJAHBEOCFI(object MIMEGFFPKFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x38BD9D0", Offset = "0x38BCBD0", VA = "0x1838BD9D0", Slot = "28")]
		private bool MLBFPNAELGN([In] ODDJOGHGEHC EKDDCPALANJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x38BAC30", Offset = "0x38B9E30", VA = "0x1838BAC30", Slot = "30")]
		private bool DPIDLFLKHCE([In] FGFCDGHHJFA EKDDCPALANJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x38B9FD0", Offset = "0x38B91D0", VA = "0x1838B9FD0", Slot = "47")]
		private bool BAKPNCAPPFM([In] Guid KEAGJDNLFNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x38BDC60", Offset = "0x38BCE60", VA = "0x1838BDC60")]
		[CompilerGenerated]
		private string OCADKBPFBFG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x38BAC60", Offset = "0x38B9E60", VA = "0x1838BAC60")]
		[CompilerGenerated]
		private void DPPBDMPLLAK(string MPENHPFDCDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public sealed class NHMCKGDJFFL : NDFHKGDJBDH<EOEHFNHMAMA>
	{
		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public override NodeVisualizationKey NFEHEBDHPKF
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xC1BDA0", Offset = "0xC1AFA0", VA = "0x180C1BDA0", Slot = "89")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x1DE62E0", Offset = "0x1DE54E0", VA = "0x181DE62E0")]
		public NHMCKGDJFFL(FNFHONBFHOC JIPGCHPOGGF, EOEHFNHMAMA JCCACJKHFKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private sealed class AOJMMHNGAGN : IHECMDJHCGB<GFCOEMBDLPF>
	{
		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public override NodeVisualizationKey NFEHEBDHPKF
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x879D40", Offset = "0x878F40", VA = "0x180879D40", Slot = "89")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x1DD33C0", Offset = "0x1DD25C0", VA = "0x181DD33C0")]
		public AOJMMHNGAGN(FNFHONBFHOC JIPGCHPOGGF, GFCOEMBDLPF JCCACJKHFKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public abstract class GPPJJNIKAHL<T> : ANCAPCLKANC<T> where T : notnull, NNBCDHIPGDL
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class BKHNOGCHJDO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public IReadOnlyList<KeyValuePair<string, EIEGMJHHHDC>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public GPPJJNIKAHL<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public EDDHNGIHGDG nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public IIHJGLGJJHA clipType;

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
			public BKHNOGCHJDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
			internal IReadOnlyList<KeyValuePair<string, EIEGMJHHHDC>> DDLIKKLHEDH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x47D5C90", Offset = "0x47D4E90", VA = "0x1847D5C90")]
			internal int PAJCNBDFGOP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x47D58D0", Offset = "0x47D4AD0", VA = "0x1847D58D0")]
			internal void KJLAMBPDHEP(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x47D5730", Offset = "0x47D4930", VA = "0x1847D5730")]
			internal void AAKENNIOEND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x47D5880", Offset = "0x47D4A80", VA = "0x1847D5880")]
			internal float KEJAPJHFBFP()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x47D5B30", Offset = "0x47D4D30", VA = "0x1847D5B30")]
			internal void LGMIFPGEJAG(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x47D5AE0", Offset = "0x47D4CE0", VA = "0x1847D5AE0")]
			internal float LBFIGCKNBNN()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x47D5780", Offset = "0x47D4980", VA = "0x1847D5780")]
			internal void BAADNABJCCN(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x47D5830", Offset = "0x47D4A30", VA = "0x1847D5830")]
			internal float HCPMCJCLKJJ()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x47D5BE0", Offset = "0x47D4DE0", VA = "0x1847D5BE0")]
			internal void MBOJBNJJJDK(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public override NodeVisualizationKey NFEHEBDHPKF
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x8D4EF0", Offset = "0x8D40F0", VA = "0x1808D4EF0", Slot = "89")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public abstract IIHJGLGJJHA INBPAPFLEJK
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(Slot = "123")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x3836940", Offset = "0x3835B40", VA = "0x183836940")]
		public GPPJJNIKAHL(FNFHONBFHOC JIPGCHPOGGF, T JCCACJKHFKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x389FEA0", Offset = "0x389F0A0", VA = "0x18389FEA0", Slot = "118")]
		protected sealed override void EOKPLNJLEIK(MFMPAAIODNH BBNLLJAKNKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	private sealed class ODGBLIEDJJK : ANCAPCLKANC<GMFBKCGPMOP>
	{
		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public override NodeVisualizationKey NFEHEBDHPKF
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x8D4FA0", Offset = "0x8D41A0", VA = "0x1808D4FA0", Slot = "89")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x1DEADD0", Offset = "0x1DE9FD0", VA = "0x181DEADD0")]
		public ODGBLIEDJJK(FNFHONBFHOC JIPGCHPOGGF, GMFBKCGPMOP JCCACJKHFKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public sealed class PNCHADMIIDN : GPPJJNIKAHL<DHGMOKCJMIG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public override IIHJGLGJJHA INBPAPFLEJK
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610", Slot = "123")]
			get
			{
				return default(IIHJGLGJJHA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x1DED510", Offset = "0x1DEC710", VA = "0x181DED510")]
		public PNCHADMIIDN(FNFHONBFHOC JIPGCHPOGGF, DHGMOKCJMIG HMEKKAINJCD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private sealed class MKNJPGCDGOO : IHECMDJHCGB<MOEOJIBENJM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public override NodeVisualizationKey NFEHEBDHPKF
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x879D40", Offset = "0x878F40", VA = "0x180879D40", Slot = "89")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x1DE2E90", Offset = "0x1DE2090", VA = "0x181DE2E90")]
		public MKNJPGCDGOO(FNFHONBFHOC JIPGCHPOGGF, MOEOJIBENJM JCCACJKHFKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private sealed class GNMIDBAOFGJ : IHECMDJHCGB<IKIEKBJAAEI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public override NodeVisualizationKey NFEHEBDHPKF
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x879D40", Offset = "0x878F40", VA = "0x180879D40", Slot = "89")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7E70", Offset = "0x1DD7070", VA = "0x181DD7E70")]
		public GNMIDBAOFGJ(FNFHONBFHOC JIPGCHPOGGF, IKIEKBJAAEI JCCACJKHFKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public sealed class LBJNOJBFKFI : NIIPGLKCBOI<ILOOOMIICFH>
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private sealed class DHNKNHMKEHB
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006D")]
			private struct <<AddHomeValueSetting>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000120")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000121")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000122")]
				public DHNKNHMKEHB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000123")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000124")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000125")]
				private TaskAwaiter<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60001F7")]
				[Cpp2IlInjected.Address(RVA = "0x1DEDCD0", Offset = "0x1DECED0", VA = "0x181DEDCD0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001F8")]
				[Cpp2IlInjected.Address(RVA = "0x893800", Offset = "0x892A00", VA = "0x180893800", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public EDDHNGIHGDG nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public LBJNOJBFKFI <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
			public DHNKNHMKEHB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x1DD4A90", Offset = "0x1DD3C90", VA = "0x181DD4A90")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void HJELBGLOMMB(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x1DE1D30", Offset = "0x1DE0F30", VA = "0x181DE1D30")]
		public LBJNOJBFKFI(FNFHONBFHOC JIPGCHPOGGF, ILOOOMIICFH HMEKKAINJCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x1DE1A50", Offset = "0x1DE0C50", VA = "0x181DE1A50", Slot = "123")]
		protected override void BKNDBNHBHHP(MFMPAAIODNH BBNLLJAKNKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public sealed class LLNLCJDPFLB : GPPJJNIKAHL<IEFCLPGOBAJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public override IIHJGLGJJHA INBPAPFLEJK
		{
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x929D00", Offset = "0x928F00", VA = "0x180929D00", Slot = "123")]
			get
			{
				return default(IIHJGLGJJHA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x1DE21E0", Offset = "0x1DE13E0", VA = "0x181DE21E0")]
		public LLNLCJDPFLB(FNFHONBFHOC JIPGCHPOGGF, IEFCLPGOBAJ HMEKKAINJCD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private sealed class LPJLFMHOBEO : ANCAPCLKANC<JEKJMHIFAON>
	{
		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public override NodeVisualizationKey NFEHEBDHPKF
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0xC467E0", Offset = "0xC459E0", VA = "0x180C467E0", Slot = "89")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x1DE28E0", Offset = "0x1DE1AE0", VA = "0x181DE28E0")]
		public LPJLFMHOBEO(FNFHONBFHOC JIPGCHPOGGF, JEKJMHIFAON JCCACJKHFKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public sealed class NJKFDNHONCI : ANCAPCLKANC<IHCNMBDBCBN>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private readonly Dictionary<string, EIEGMJHHHDC> OJAJMFCFDEF;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public sealed override NodeVisualizationKey NFEHEBDHPKF
		{
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610", Slot = "89")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public sealed override bool JACPAHNOEEL
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x7CF450", Offset = "0x7CE650", VA = "0x1807CF450", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		protected sealed override bool PIIJAGBFINL
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x7CF450", Offset = "0x7CE650", VA = "0x1807CF450", Slot = "88")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x1DE6600", Offset = "0x1DE5800", VA = "0x181DE6600")]
		public NJKFDNHONCI(FNFHONBFHOC JIPGCHPOGGF, IHCNMBDBCBN JCCACJKHFKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x1DE63A0", Offset = "0x1DE55A0", VA = "0x181DE63A0", Slot = "118")]
		protected override void EOKPLNJLEIK(MFMPAAIODNH BBNLLJAKNKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x1DE65C0", Offset = "0x1DE57C0", VA = "0x181DE65C0")]
		private int KFCNBILGAPG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x1DE6340", Offset = "0x1DE5540", VA = "0x181DE6340")]
		private void BIJJIEBLGBP(int CDEGJDLAKFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class PFPFCKHOIIO : NIIPGLKCBOI<JBFMLHHONMD>
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x1DEC790", Offset = "0x1DEB990", VA = "0x181DEC790")]
		public PFPFCKHOIIO(FNFHONBFHOC JIPGCHPOGGF, JBFMLHHONMD JCCACJKHFKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public abstract class NIIPGLKCBOI<TVariableNode> : ANCAPCLKANC<TVariableNode> where TVariableNode : notnull, JBFMLHHONMD
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private sealed class CNODBBDJODL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public NIIPGLKCBOI<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public EDDHNGIHGDG nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
			public CNODBBDJODL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x4BE6820", Offset = "0x4BE5A20", VA = "0x184BE6820")]
			internal bool DDLIKKLHEDH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x4BE69D0", Offset = "0x4BE5BD0", VA = "0x184BE69D0")]
			internal void PAJCNBDFGOP(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x4BE6980", Offset = "0x4BE5B80", VA = "0x184BE6980")]
			internal bool KJLAMBPDHEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x4BE6770", Offset = "0x4BE5970", VA = "0x184BE6770")]
			internal void AAKENNIOEND(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x4BE6870", Offset = "0x4BE5A70", VA = "0x184BE6870")]
			internal bool KEJAPJHFBFP()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private sealed class LIPHLIMKJCJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public EDDHNGIHGDG nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public NIIPGLKCBOI<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
			public LIPHLIMKJCJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x3D62150", Offset = "0x3D61350", VA = "0x183D62150")]
			internal void HJELBGLOMMB(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public override NodeVisualizationKey NFEHEBDHPKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x91B970", Offset = "0x91AB70", VA = "0x18091B970", Slot = "89")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public override IOJAKCMGOOF MMPDCMGFFGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x3FF5F70", Offset = "0x3FF5170", VA = "0x183FF5F70", Slot = "92")]
			get
			{
				return default(IOJAKCMGOOF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x3FF5E20", Offset = "0x3FF5020", VA = "0x183FF5E20")]
		protected NIIPGLKCBOI(FNFHONBFHOC JIPGCHPOGGF, TVariableNode JCCACJKHFKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x3FF57D0", Offset = "0x3FF49D0", VA = "0x183FF57D0", Slot = "86")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x3FF5910", Offset = "0x3FF4B10", VA = "0x183FF5910", Slot = "118")]
		protected override void EOKPLNJLEIK(MFMPAAIODNH BBNLLJAKNKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x3FF5480", Offset = "0x3FF4680", VA = "0x183FF5480", Slot = "123")]
		protected virtual void BKNDBNHBHHP(MFMPAAIODNH BBNLLJAKNKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x3FF5D60", Offset = "0x3FF4F60", VA = "0x183FF5D60", Slot = "103")]
		public override void GKFNPGBHNDK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x1DE4BA0", Offset = "0x1DE3DA0", VA = "0x181DE4BA0")]
	internal static CGNGINGKBKI DHBNKMCPKNO(FNFHONBFHOC JIPGCHPOGGF, MDCFLBIEIKO JCCACJKHFKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public sealed class KGBJFJMKANI : MPIHIIPHJNI, ONAMHLFMDIA, JFJJGGLOICA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public KHCIOCBLCGC<NJIFMIKHJJL> CJCDPPOKFLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xDB5AB0", Offset = "0xDB4CB0", VA = "0x180DB5AB0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(KHCIOCBLCGC<NJIFMIKHJJL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public KHCIOCBLCGC<PFOFHIJPHON> DOGCPAAEICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x1079740", Offset = "0x1078940", VA = "0x181079740", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(KHCIOCBLCGC<PFOFHIJPHON>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x1DE0A00", Offset = "0x1DDFC00", VA = "0x181DE0A00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private KHCIOCBLCGC<HGFONCOECHI> ODHHOBJFLHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xA45CF0", Offset = "0xA44EF0", VA = "0x180A45CF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public override KHCIOCBLCGC<AFBNAACJOMK> HLBGBLHJOLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x1DE0A10", Offset = "0x1DDFC10", VA = "0x181DE0A10", Slot = "20")]
		get
		{
			return default(KHCIOCBLCGC<AFBNAACJOMK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x1DE0A50", Offset = "0x1DDFC50", VA = "0x181DE0A50")]
	private KGBJFJMKANI(FNFHONBFHOC JIPGCHPOGGF, MDCFLBIEIKO JCCACJKHFKB, IILPCOKMFGM NHBMPJEELHH, KHCIOCBLCGC<GHMMCINEBDI> CIHLOOFFIBE, KHCIOCBLCGC<PFOFHIJPHON> BDBHJLOOAPB, KHCIOCBLCGC<HGFONCOECHI> IHLICNJPHKN, bool OCACIDPCKEA, string MPENHPFDCDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x1DE0660", Offset = "0x1DDF860", VA = "0x181DE0660")]
	public static KGBJFJMKANI DHBNKMCPKNO(FNFHONBFHOC JIPGCHPOGGF, MDCFLBIEIKO JCCACJKHFKB, IILPCOKMFGM OCMENJCDIMP, KHCIOCBLCGC<GHMMCINEBDI> CIHLOOFFIBE, KHCIOCBLCGC<HGFONCOECHI> IHLICNJPHKN, KHCIOCBLCGC<PFOFHIJPHON> BDBHJLOOAPB, bool OCACIDPCKEA, bool OANFEFALLEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x1DE0A00", Offset = "0x1DDFC00", VA = "0x181DE0A00")]
	internal void OJOMJOINKEP(KHCIOCBLCGC<PFOFHIJPHON> EKDDCPALANJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public abstract class MPIHIIPHJNI : JFJJGGLOICA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private struct MEOGLAKIAPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private KPCFAHCGMCF? HFHHIFAENPJ;

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x1DE2DE0", Offset = "0x1DE1FE0", VA = "0x181DE2DE0")]
		public void DBHKOJLPIHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x1DE2DF0", Offset = "0x1DE1FF0", VA = "0x181DE2DF0")]
		public KPCFAHCGMCF POEDJHDMOLN(MPIHIIPHJNI NNHNKNFPCKG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	protected readonly FNFHONBFHOC DEPGNJNBHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	protected readonly MDCFLBIEIKO NJBMJHLJLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private MEOGLAKIAPD PMCLOGBMJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private readonly GIKPILGHGDL JNMMJPAEDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private readonly List<JBEKJGAKLEI> BGBBDGGNPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private readonly List<JDLDNJDNFNL> EHAKLFIECFH;

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public IEnumerable<StaticEdge> PPGFKGGOICP
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x1DE38D0", Offset = "0x1DE2AD0", VA = "0x181DE38D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public DisplayKind PGGGNEJGMOM
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x7C3F50", Offset = "0x7C3150", VA = "0x1807C3F50", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public KHCIOCBLCGC<NJGFNHCPFKD> NEOPDODJINO
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x1DE3300", Offset = "0x1DE2500", VA = "0x181DE3300", Slot = "6")]
		get
		{
			return default(KHCIOCBLCGC<NJGFNHCPFKD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public EIMAHFBCFHK<NJGFNHCPFKD> HPIAJNEBHBL
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x1DE3E30", Offset = "0x1DE3030", VA = "0x181DE3E30", Slot = "7")]
		get
		{
			return default(EIMAHFBCFHK<NJGFNHCPFKD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public JPPMLKCJMLE LOANLDFBPCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x19CEE90", Offset = "0x19CE090", VA = "0x1819CEE90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public PBJEKJJMLKH CBGANAEOJHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x1DE3260", Offset = "0x1DE2460", VA = "0x181DE3260", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	protected KPCFAHCGMCF DMPGIBGCDHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x1DE3260", Offset = "0x1DE2460", VA = "0x181DE3260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public PortImage NKCPDKAHLIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x1DE3D00", Offset = "0x1DE2F00", VA = "0x181DE3D00", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public string FLDBLPHJNKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x7B7520", Offset = "0x7B6720", VA = "0x1807B7520", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x7B7550", Offset = "0x7B6750", VA = "0x1807B7550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public EIMAHFBCFHK<GGOIHKGODHF> PDIDEAPHNFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x1DE3FE0", Offset = "0x1DE31E0", VA = "0x181DE3FE0", Slot = "9")]
		get
		{
			return default(EIMAHFBCFHK<GGOIHKGODHF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public KHCIOCBLCGC<GHMMCINEBDI> OALIGAOAOJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x858950", Offset = "0x857B50", VA = "0x180858950", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(KHCIOCBLCGC<GHMMCINEBDI>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x187A840", Offset = "0x1879A40", VA = "0x18187A840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public abstract KHCIOCBLCGC<AFBNAACJOMK> HLBGBLHJOLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x1DE4680", Offset = "0x1DE3880", VA = "0x181DE4680")]
	protected MPIHIIPHJNI(FNFHONBFHOC JIPGCHPOGGF, MDCFLBIEIKO JCCACJKHFKB, GIKPILGHGDL PFKMNBCMKBC, KHCIOCBLCGC<GHMMCINEBDI> CIHLOOFFIBE, bool OCACIDPCKEA, string MPENHPFDCDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x1DE3BB0", Offset = "0x1DE2DB0", VA = "0x181DE3BB0", Slot = "21")]
	protected virtual void MEJEOBIHPJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x1DE3760", Offset = "0x1DE2960", VA = "0x181DE3760", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x1DE3500", Offset = "0x1DE2700", VA = "0x181DE3500", Slot = "14")]
	public void CJMJHOABMLI(JBEKJGAKLEI NABAFNOEEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x1DE3390", Offset = "0x1DE2590", VA = "0x181DE3390", Slot = "15")]
	public void CBJBKPPKLNK(JDLDNJDNFNL NABAFNOEEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x1DE4000", Offset = "0x1DE3200", VA = "0x181DE4000", Slot = "16")]
	public void PJPIAHPFAPN(NEDHBJNPGKG GMKDFLEHPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x1DE34A0", Offset = "0x1DE26A0", VA = "0x181DE34A0", Slot = "23")]
	protected virtual void CIHJIIFPICP(NEDHBJNPGKG GMKDFLEHPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x1DE3E60", Offset = "0x1DE3060", VA = "0x181DE3E60")]
	private void PDHMPLKIHCN(bool KCEAHMBEPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x1DE35B0", Offset = "0x1DE27B0", VA = "0x181DE35B0")]
	private void CNCLOCNLPDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x1DE3A10", Offset = "0x1DE2C10", VA = "0x181DE3A10")]
	private void MCGAJJEDFCK([In] LFINHBELEPH BFJLFDJLAGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x1DE3440", Offset = "0x1DE2640", VA = "0x181DE3440", Slot = "17")]
	public void CDBHGCFCGIP(JBEKJGAKLEI NABAFNOEEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x1DE3330", Offset = "0x1DE2530", VA = "0x181DE3330", Slot = "18")]
	public void APPMFGJGKNI(JDLDNJDNFNL NABAFNOEEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x7B7550", Offset = "0x7B6750", VA = "0x1807B7550")]
	internal void IJEAENNDAAC(string MPENHPFDCDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x1DE38B0", Offset = "0x1DE2AB0", VA = "0x181DE38B0")]
	internal void EOALBNKECDH(GFLNBEOGKAC OAENIJAKBHE, JPPMLKCJMLE MJMAEGDPBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x187A840", Offset = "0x1879A40", VA = "0x18187A840")]
	internal void ABILJOKJCBN(KHCIOCBLCGC<GHMMCINEBDI> CIHLOOFFIBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public sealed class ILBDOLNKHAI : JEIDPNIPILI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class IPMCFPNDOOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public FNFHONBFHOC circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public MDCFLBIEIKO node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public KHCIOCBLCGC<GHMMCINEBDI> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public IPMCFPNDOOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x1DDF120", Offset = "0x1DDE320", VA = "0x181DDF120")]
		internal NOENLEIAHEB NAJKKOIDOOI((int PortDescIndex, int PortIndex, BDONGKFFHAG InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x1DDF090", Offset = "0x1DDE290", VA = "0x181DDF090")]
		internal KGBJFJMKANI EONDINPFAFB(IILPCOKMFGM i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct JPKMMLNHHNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public AsyncTaskMethodBuilder<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public ILBDOLNKHAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private BHHPNLGMNNB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private TaskAwaiter<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x1DE0000", Offset = "0x1DDF200", VA = "0x181DE0000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x1DE0460", Offset = "0x1DDF660", VA = "0x181DE0460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private struct BIGNBFACHDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public AsyncTaskMethodBuilder<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public ILBDOLNKHAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public KHCIOCBLCGC<HJOFJJKDLOL> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private BHHPNLGMNNB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private TaskAwaiter<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3C60", Offset = "0x1DD2E60", VA = "0x181DD3C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3FB0", Offset = "0x1DD31B0", VA = "0x181DD3FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private struct CFEKKNPLALK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public AsyncTaskMethodBuilder<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public ILBDOLNKHAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public KHCIOCBLCGC<HGFONCOECHI> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private BHHPNLGMNNB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TaskAwaiter<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x1DD4210", Offset = "0x1DD3410", VA = "0x181DD4210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x1DD4560", Offset = "0x1DD3760", VA = "0x181DD4560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct NANDPBBNNBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public AsyncTaskMethodBuilder<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public ILBDOLNKHAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public KHCIOCBLCGC<HJOFJJKDLOL> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public KHCIOCBLCGC<HJOFJJKDLOL> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private BHHPNLGMNNB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private TaskAwaiter<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x1DE47E0", Offset = "0x1DE39E0", VA = "0x181DE47E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x1DE4B30", Offset = "0x1DE3D30", VA = "0x181DE4B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct GMKFBJDLNKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public AsyncTaskMethodBuilder<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public ILBDOLNKHAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public KHCIOCBLCGC<HGFONCOECHI> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public KHCIOCBLCGC<HGFONCOECHI> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private BHHPNLGMNNB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private TaskAwaiter<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7AB0", Offset = "0x1DD6CB0", VA = "0x181DD7AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x1DD7E00", Offset = "0x1DD7000", VA = "0x181DD7E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct ANEJPJLGPED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public AsyncTaskMethodBuilder<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public ILBDOLNKHAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private BHHPNLGMNNB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private TaskAwaiter<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x1DD2A00", Offset = "0x1DD1C00", VA = "0x181DD2A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x1DD2E70", Offset = "0x1DD2070", VA = "0x181DD2E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private struct MEFMDOPHEAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public AsyncTaskMethodBuilder<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public ILBDOLNKHAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private BHHPNLGMNNB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private TaskAwaiter<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x1DE2A20", Offset = "0x1DE1C20", VA = "0x181DE2A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x1DE2D70", Offset = "0x1DE1F70", VA = "0x181DE2D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private struct FMIAPONAAAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public AsyncTaskMethodBuilder<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public ILBDOLNKHAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public KHCIOCBLCGC<HJOFJJKDLOL> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private BHHPNLGMNNB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private TaskAwaiter<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x1DD56E0", Offset = "0x1DD48E0", VA = "0x181DD56E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x1DD5A30", Offset = "0x1DD4C30", VA = "0x181DD5A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private struct EOJNNDOMFBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public AsyncTaskMethodBuilder<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public ILBDOLNKHAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public KHCIOCBLCGC<HGFONCOECHI> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private BHHPNLGMNNB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private TaskAwaiter<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x1DD5030", Offset = "0x1DD4230", VA = "0x181DD5030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x1DD5380", Offset = "0x1DD4580", VA = "0x181DD5380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private struct POCDJLJICAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public AsyncTaskMethodBuilder<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public ILBDOLNKHAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public OAFCAJHBNGL type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public KHCIOCBLCGC<HJOFJJKDLOL> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private BHHPNLGMNNB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private TaskAwaiter<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x1DED680", Offset = "0x1DEC880", VA = "0x181DED680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x1DEDA10", Offset = "0x1DECC10", VA = "0x181DEDA10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct PKJOBJLALLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public AsyncTaskMethodBuilder<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public ILBDOLNKHAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public OAFCAJHBNGL type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public KHCIOCBLCGC<HGFONCOECHI> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private BHHPNLGMNNB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private TaskAwaiter<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x1DECEA0", Offset = "0x1DEC0A0", VA = "0x181DECEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x1DED230", Offset = "0x1DEC430", VA = "0x181DED230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly bool JLJDIOAFMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly FNFHONBFHOC DEPGNJNBHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly bool HJLLKOEPPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private EPKIAMCHGOM<NKGANNEHNHO, NOENLEIAHEB> HAFILOEPIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private EPKIAMCHGOM<NKGANNEHNHO, DMCBIEHMGNK> IENEAIHNIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly MDCFLBIEIKO NJBMJHLJLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private EPKIAMCHGOM<PFOFHIJPHON, KGBJFJMKANI> ENBFEHNLPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private EPKIAMCHGOM<PFOFHIJPHON, ONAMHLFMDIA> POEIGDHCHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private string? KLMJGGAFLBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly EPNMOEANLDB KOMHCJLOFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private KHCIOCBLCGC<GHMMCINEBDI> KIBMLANKBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly bool DIMHLHFPDOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	[CompilerGenerated]
	private Action? BFOGPHIELPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[CompilerGenerated]
	private Action? NEFKDFAIMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[CompilerGenerated]
	private Action<KHCIOCBLCGC<NKGANNEHNHO>>? DHHGFLOCBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[CompilerGenerated]
	private Action<KHCIOCBLCGC<PFOFHIJPHON>>? NLLJOMGIPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[CompilerGenerated]
	private JEIDPNIPILI.IKBKDFHHDHC? GPKNKJBIHIB;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool MEGAFDALENK
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x1DDC310", Offset = "0x1DDB510", VA = "0x181DDC310", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool MHMOLONPPGK
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x1DDBE60", Offset = "0x1DDB060", VA = "0x181DDBE60", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool KGHCOAKOOIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x1DDC9C0", Offset = "0x1DDBBC0", VA = "0x181DDC9C0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public EIMAHFBCFHK<NJGFNHCPFKD> HPIAJNEBHBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x1DDE750", Offset = "0x1DDD950", VA = "0x181DDE750", Slot = "7")]
		get
		{
			return default(EIMAHFBCFHK<NJGFNHCPFKD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool EJBKFNKAJLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x1DDC830", Offset = "0x1DDBA30", VA = "0x181DDC830", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public EPKIAMCHGOM<NKGANNEHNHO, DMCBIEHMGNK> KAKNBLEBMCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "9")]
		get
		{
			return default(EPKIAMCHGOM<NKGANNEHNHO, DMCBIEHMGNK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public string FLDBLPHJNKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x1DDE540", Offset = "0x1DDD740", VA = "0x181DDE540", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public EIMAHFBCFHK<GGOIHKGODHF> PDIDEAPHNFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x1DDED60", Offset = "0x1DDDF60", VA = "0x181DDED60", Slot = "11")]
		get
		{
			return default(EIMAHFBCFHK<GGOIHKGODHF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public EPKIAMCHGOM<PFOFHIJPHON, ONAMHLFMDIA> GOFKEJIILLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7B7520", Offset = "0x7B6720", VA = "0x1807B7520", Slot = "12")]
		get
		{
			return default(EPKIAMCHGOM<PFOFHIJPHON, ONAMHLFMDIA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public KHCIOCBLCGC<GHMMCINEBDI> OALIGAOAOJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xA46730", Offset = "0xA45930", VA = "0x180A46730", Slot = "13")]
		get
		{
			return default(KHCIOCBLCGC<GHMMCINEBDI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action JKEEAFLBHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x1DDED80", Offset = "0x1DDDF80", VA = "0x181DDED80", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x1DDC790", Offset = "0x1DDB990", VA = "0x181DDC790", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action ICPCDJFNDNP
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x1DD9F20", Offset = "0x1DD9120", VA = "0x181DD9F20", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x1DDEEE0", Offset = "0x1DDE0E0", VA = "0x181DDEEE0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<KHCIOCBLCGC<NKGANNEHNHO>, KHCIOCBLCGC<NKGANNEHNHO>> BMPDBAELICN
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x1DDE9B0", Offset = "0x1DDDBB0", VA = "0x181DDE9B0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x1DDBF90", Offset = "0x1DDB190", VA = "0x181DDBF90", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<KHCIOCBLCGC<NKGANNEHNHO>, KHCIOCBLCGC<NKGANNEHNHO>> HLONKCLMIEC
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x1DDC3D0", Offset = "0x1DDB5D0", VA = "0x181DDC3D0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x1DDE480", Offset = "0x1DDD680", VA = "0x181DDE480", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<KHCIOCBLCGC<PFOFHIJPHON>, KHCIOCBLCGC<PFOFHIJPHON>> AHJCCCKKPNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x1DDC250", Offset = "0x1DDB450", VA = "0x181DDC250", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x1DDA1F0", Offset = "0x1DD93F0", VA = "0x181DDA1F0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<KHCIOCBLCGC<PFOFHIJPHON>, KHCIOCBLCGC<PFOFHIJPHON>> MCOMLGILGEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x1DDE3C0", Offset = "0x1DDD5C0", VA = "0x181DDE3C0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x1DDC610", Offset = "0x1DDB810", VA = "0x181DDC610", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<KHCIOCBLCGC<NKGANNEHNHO>, DMCBIEHMGNK> JOIABOHFHNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x1DDC6D0", Offset = "0x1DDB8D0", VA = "0x181DDC6D0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x1DDEB90", Offset = "0x1DDDD90", VA = "0x181DDEB90", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<KHCIOCBLCGC<NKGANNEHNHO>> IFKCPJKHKBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x1DDA090", Offset = "0x1DD9290", VA = "0x181DDA090", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x1DDEA70", Offset = "0x1DDDC70", VA = "0x181DDEA70", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<KHCIOCBLCGC<NKGANNEHNHO>, DMCBIEHMGNK> ANMHCEJCGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x1DDD730", Offset = "0x1DDC930", VA = "0x181DDD730", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x1DD9FD0", Offset = "0x1DD91D0", VA = "0x181DD9FD0", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<KHCIOCBLCGC<PFOFHIJPHON>, ONAMHLFMDIA> FEAGIEGOCBH
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x1DDEE20", Offset = "0x1DDE020", VA = "0x181DDEE20", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x1DDCF50", Offset = "0x1DDC150", VA = "0x181DDCF50", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<KHCIOCBLCGC<PFOFHIJPHON>> NHJJIKDCABG
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x1DD9E60", Offset = "0x1DD9060", VA = "0x181DD9E60", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x1DDC550", Offset = "0x1DDB750", VA = "0x181DDC550", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<KHCIOCBLCGC<PFOFHIJPHON>, ONAMHLFMDIA> IDPLDPHEDAP
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x1DDC490", Offset = "0x1DDB690", VA = "0x181DDC490", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x1DDDA60", Offset = "0x1DDCC60", VA = "0x181DDDA60", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x1DDEF90", Offset = "0x1DDE190", VA = "0x181DDEF90")]
	private ILBDOLNKHAI(bool OCACIDPCKEA, FNFHONBFHOC JIPGCHPOGGF, bool DFEGBFKHLKN, EPKIAMCHGOM<NKGANNEHNHO, NOENLEIAHEB> BIFMLIGMEOK, EPKIAMCHGOM<NKGANNEHNHO, DMCBIEHMGNK> KBOCBBIMKCG, MDCFLBIEIKO JCCACJKHFKB, EPKIAMCHGOM<PFOFHIJPHON, KGBJFJMKANI> JDEIDENAEGI, EPKIAMCHGOM<PFOFHIJPHON, ONAMHLFMDIA> AFGMDEFBDJL, string? LBJAANPIFFH, EPNMOEANLDB JEPOKPLCHDF, KHCIOCBLCGC<GHMMCINEBDI> CIHLOOFFIBE, bool OANFEFALLEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x1DDA930", Offset = "0x1DD9B30", VA = "0x181DDA930")]
	public static ILBDOLNKHAI DHBNKMCPKNO(bool OCACIDPCKEA, FNFHONBFHOC JIPGCHPOGGF, bool DFEGBFKHLKN, MDCFLBIEIKO JCCACJKHFKB, EPNMOEANLDB JEPOKPLCHDF, KHCIOCBLCGC<GHMMCINEBDI> CIHLOOFFIBE, bool OANFEFALLEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x1DDDC10", Offset = "0x1DDCE10", VA = "0x181DDDC10")]
	private void MEJEOBIHPJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x1DDAEA0", Offset = "0x1DDA0A0", VA = "0x181DDAEA0", Slot = "49")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x1DDBEA0", Offset = "0x1DDB0A0", VA = "0x181DDBEA0", Slot = "38")]
	[AsyncStateMachine(typeof(JPKMMLNHHNA))]
	public Task<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> EKHAIGJAHGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x1DDE780", Offset = "0x1DDD980", VA = "0x181DDE780")]
	private (BNFKCLPHEAK, int)? ODBMDCOBLHA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x1DDE660", Offset = "0x1DDD860", VA = "0x181DDE660")]
	private void NMHDDMMFAEG(int BJGKPGJPELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x126B190", Offset = "0x126A390", VA = "0x18126B190")]
	private void NCIANKDPALG(int BJGKPGJPELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x1DDB9A0", Offset = "0x1DDABA0", VA = "0x181DDB9A0")]
	private void ECMBPNLLFJM(int OGAFEEKHHNM, int FBAELPBINPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x1DDC0A0", Offset = "0x1DDB2A0", VA = "0x181DDC0A0")]
	private void FGCCBGINFGI(int OGAFEEKHHNM, int FBAELPBINPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x1DD97F0", Offset = "0x1DD89F0", VA = "0x181DD97F0")]
	private void AHJJNNICJIA(int BJGKPGJPELO, int EEDMAHMJMCC, BDONGKFFHAG HIFBGLLPLPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x1DDA150", Offset = "0x1DD9350", VA = "0x181DDA150")]
	private void CBCJCMEEICG(int KCEAHMBEPHE, int EEDMAHMJMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x1DDC050", Offset = "0x1DDB250", VA = "0x181DDC050")]
	private void ENLEGJCKLDB(int KCEAHMBEPHE, int EEDMAHMJMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x1DD9390", Offset = "0x1DD8590", VA = "0x181DD9390")]
	private void AHGMOFMFLPA(int BJGKPGJPELO, int EEDMAHMJMCC, BDONGKFFHAG HIFBGLLPLPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD7F0", Offset = "0x1DDC9F0", VA = "0x181DDD7F0")]
	private void LCLIDBDOKMB(int BJGKPGJPELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x8982A0", Offset = "0x8974A0", VA = "0x1808982A0")]
	private void BDCGJJJODAF(int BJGKPGJPELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x1DDDB20", Offset = "0x1DDCD20", VA = "0x181DDDB20")]
	private void LNOPHPJKNEH(int BJGKPGJPELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x126B190", Offset = "0x126A390", VA = "0x18126B190")]
	private void JENIILMFIGN(int BJGKPGJPELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD010", Offset = "0x1DDC210", VA = "0x181DDD010")]
	private void KCJOIBLNBAM(int OGAFEEKHHNM, int FBAELPBINPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x1DDEB30", Offset = "0x1DDDD30", VA = "0x181DDEB30")]
	private void OGGCKDOJEHH(int OGAFEEKHHNM, int FBAELPBINPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x1DDA2B0", Offset = "0x1DD94B0", VA = "0x181DDA2B0")]
	private void DEHKPHCCEHN(int BJGKPGJPELO, int EEDMAHMJMCC, IILPCOKMFGM HIFBGLLPLPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x1DDA1A0", Offset = "0x1DD93A0", VA = "0x181DDA1A0")]
	private void CNJJHOAEHGL(int KCEAHMBEPHE, int EEDMAHMJMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x1DDCA80", Offset = "0x1DDBC80", VA = "0x181DDCA80")]
	private void JFPHBHJFDBG(int KCEAHMBEPHE, int EEDMAHMJMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x1DDCAD0", Offset = "0x1DDBCD0", VA = "0x181DDCAD0")]
	private void JIJDMLFPDEC(int BJGKPGJPELO, int EEDMAHMJMCC, IILPCOKMFGM HIFBGLLPLPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x1DDC100", Offset = "0x1DDB300", VA = "0x181DDC100")]
	private void FHPLGDMNCDI(int BJGKPGJPELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x8982A0", Offset = "0x8974A0", VA = "0x1808982A0")]
	private void MPCAOJPIBAC(int BJGKPGJPELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x1DDC8B0", Offset = "0x1DDBAB0", VA = "0x181DDC8B0", Slot = "39")]
	[AsyncStateMachine(typeof(BIGNBFACHDL))]
	public Task<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> INKCGEEFCBD(KHCIOCBLCGC<HJOFJJKDLOL> OFKCKILNIKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x1DDEC50", Offset = "0x1DDDE50", VA = "0x181DDEC50", Slot = "40")]
	[AsyncStateMachine(typeof(CFEKKNPLALK))]
	public Task<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> PBAGJFINLPM(KHCIOCBLCGC<HGFONCOECHI> IHLICNJPHKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD4E0", Offset = "0x1DDC6E0", VA = "0x181DDD4E0", Slot = "41")]
	[AsyncStateMachine(typeof(NANDPBBNNBJ))]
	public Task<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> KIPCEDAFIKA(KHCIOCBLCGC<HJOFJJKDLOL> OFKCKILNIKB, KHCIOCBLCGC<HJOFJJKDLOL> HJGOBNGHGAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD940", Offset = "0x1DDCB40", VA = "0x181DDD940", Slot = "42")]
	[AsyncStateMachine(typeof(GMKFBJDLNKC))]
	public Task<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> LDACGADBJKD(KHCIOCBLCGC<HGFONCOECHI> IHLICNJPHKN, KHCIOCBLCGC<HGFONCOECHI> HJGOBNGHGAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x1DDE570", Offset = "0x1DDD770", VA = "0x181DDE570", Slot = "43")]
	[AsyncStateMachine(typeof(ANEJPJLGPED))]
	public Task<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> NDJFEJAGAHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x1DDBD40", Offset = "0x1DDAF40", VA = "0x181DDBD40", Slot = "44")]
	[AsyncStateMachine(typeof(MEFMDOPHEAA))]
	public Task<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> EDMNOGAJCEH(string EECPMAAEBOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x1DD9D30", Offset = "0x1DD8F30", VA = "0x181DD9D30", Slot = "45")]
	[AsyncStateMachine(typeof(FMIAPONAAAC))]
	public Task<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> AOMBENLAMCB(KHCIOCBLCGC<HJOFJJKDLOL> OFKCKILNIKB, string MPENHPFDCDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD3B0", Offset = "0x1DDC5B0", VA = "0x181DDD3B0", Slot = "46")]
	[AsyncStateMachine(typeof(EOJNNDOMFBF))]
	public Task<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> KHDKHLKFMKH(KHCIOCBLCGC<HGFONCOECHI> IHLICNJPHKN, string MPENHPFDCDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x1DDA800", Offset = "0x1DD9A00", VA = "0x181DDA800", Slot = "47")]
	[AsyncStateMachine(typeof(POCDJLJICAC))]
	public Task<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> DEMPJPALMJJ(KHCIOCBLCGC<HJOFJJKDLOL> OFKCKILNIKB, OAFCAJHBNGL MJMAEGDPBNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x1DDD600", Offset = "0x1DDC800", VA = "0x181DDD600", Slot = "48")]
	[AsyncStateMachine(typeof(PKJOBJLALLJ))]
	public Task<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> KMONOEKIGKB(KHCIOCBLCGC<HGFONCOECHI> IHLICNJPHKN, OAFCAJHBNGL MJMAEGDPBNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x1DD8FE0", Offset = "0x1DD81E0", VA = "0x181DD8FE0")]
	internal void ABILJOKJCBN(KHCIOCBLCGC<GHMMCINEBDI> EKDDCPALANJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public sealed class KPJLMCGFILG : LBIGLAFBHAC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public interface JDGOCGDPDLF
	{
		[Cpp2IlInjected.Token(Token = "0x17000095")]
		GFLNBEOGKAC BABCNPKMKGO
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<FNCJPDBCHMD> BJIMEGGHLCG(CancellationToken IOOGCHJMBIE);

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<KDBNAJDNMLL> IJEPKHACPEP(CancellationToken IOOGCHJMBIE);

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<ICNEFIGEDNO> BMIADBFJGHJ(CancellationToken IOOGCHJMBIE);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private struct KNBLHAOIHID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public AsyncTaskMethodBuilder<KPJLMCGFILG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public FNFHONBFHOC circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public FNCJPDBCHMD roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public KDBNAJDNMLL superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private JDGOCGDPDLF <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private KDBNAJDNMLL <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private TaskAwaiter<FNCJPDBCHMD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private TaskAwaiter<KDBNAJDNMLL> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private TaskAwaiter<ICNEFIGEDNO> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private TaskAwaiter<FBNGBBCEEJI> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x1DE0E60", Offset = "0x1DE0060", VA = "0x181DE0E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x1DE1860", Offset = "0x1DE0A60", VA = "0x181DE1860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly FBNGBBCEEJI BBMGBGIJGHB;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public FBNGBBCEEJI NFPELOHHCDD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x7C19B0", Offset = "0x7C0BB0", VA = "0x1807C19B0")]
	private KPJLMCGFILG(FBNGBBCEEJI DLPPBGJHHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x1DE18D0", Offset = "0x1DE0AD0", VA = "0x181DE18D0")]
	[AsyncStateMachine(typeof(KNBLHAOIHID))]
	public static Task<KPJLMCGFILG> CKNHCMMCEJD(FNFHONBFHOC JIPGCHPOGGF, FNCJPDBCHMD? MDDPLLFCMCP, KDBNAJDNMLL? KAODCEBKJOA, CancellationToken IOOGCHJMBIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x1DE1A30", Offset = "0x1DE0C30", VA = "0x181DE1A30", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public readonly struct LKJELOBJLDH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct AEHLOMDGJAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public AsyncTaskMethodBuilder<OAAHAKNOJDO<object, AHFOEFCGOPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public LKJELOBJLDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public OLNEDDGCOEI action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private TaskAwaiter<OAAHAKNOJDO<object, AHFOEFCGOPM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x1DEF090", Offset = "0x1DEE290", VA = "0x181DEF090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x1DEF290", Offset = "0x1DEE490", VA = "0x181DEF290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct NILBIJGNBAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public AsyncTaskMethodBuilder<OAAHAKNOJDO<bool, AHFOEFCGOPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public POMHAFMABIA rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public FNCJPDBCHMD circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public KDBNAJDNMLL superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public LKJELOBJLDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private OLNEDDGCOEI[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private TaskAwaiter<OAAHAKNOJDO<object, AHFOEFCGOPM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x1DF6DF0", Offset = "0x1DF5FF0", VA = "0x181DF6DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x1DF71D0", Offset = "0x1DF63D0", VA = "0x181DF71D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct MCCNJOMEJLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public AsyncTaskMethodBuilder<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public LKJELOBJLDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private TaskAwaiter<OAAHAKNOJDO<object, AHFOEFCGOPM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x1DF6B40", Offset = "0x1DF5D40", VA = "0x181DF6B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x1DF6D80", Offset = "0x1DF5F80", VA = "0x181DF6D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private readonly PGMGGHNJIBF JHBAMMCMILI;

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x93E850", Offset = "0x93DA50", VA = "0x18093E850")]
	public LKJELOBJLDH(PGMGGHNJIBF BADMILBHCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x1DF6760", Offset = "0x1DF5960", VA = "0x181DF6760")]
	[AsyncStateMachine(typeof(AEHLOMDGJAI))]
	private Task<OAAHAKNOJDO<object, AHFOEFCGOPM>> COGGDLOLIKN(OLNEDDGCOEI OFOIHENMFDE, bool DMBCFIFLHLH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x1DF6890", Offset = "0x1DF5A90", VA = "0x181DF6890")]
	[AsyncStateMachine(typeof(NILBIJGNBAN))]
	public Task<OAAHAKNOJDO<bool, AHFOEFCGOPM?>>? KFKIMJCLGHL(int JJJEMBFGPIM, POMHAFMABIA? IONGJKOKPIH, FNCJPDBCHMD? KDILEBHEHDL, KDBNAJDNMLL? KAODCEBKJOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x1DF6670", Offset = "0x1DF5870", VA = "0x181DF6670")]
	[AsyncStateMachine(typeof(MCCNJOMEJLM))]
	public Task<OAAHAKNOJDO<NFDBFOHCHGK, AHFOEFCGOPM>> CJPKHGMGMMP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public sealed class GAENADOFCOF : MPJHGOEDKGI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private readonly IFKOIELLEJC GEKJGKNMNHK;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public IFKOIELLEJC NNBMBEELCCC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x7C19B0", Offset = "0x7C0BB0", VA = "0x1807C19B0")]
	private GAENADOFCOF(IFKOIELLEJC DBDFFFLIOEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x1DEFB30", Offset = "0x1DEED30", VA = "0x181DEFB30")]
	public static GAENADOFCOF MAOCPLNNJJM(FNFHONBFHOC JIPGCHPOGGF, POMHAFMABIA PPOHHIBGHKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x1DEFB10", Offset = "0x1DEED10", VA = "0x181DEFB10", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public interface JMPKLAJPDEP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000097")]
	ALIDKHFLOPJ NDEHOLFCELJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	GFGEBGOAOOO JDBGACGNEHL
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	AANKHINPJEL NJKLHEPALCG
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	HCGKCGKKLOD GKIIFEOGEFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	JHKLFLADBGI GFOPJDOLCMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public interface IJNDIKJPOPI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	JMPKLAJPDEP? FEBKJCFCFJF
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	bool HKJFMKICGME
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	bool OOHKCKOHADI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<JMPKLAJPDEP?>? IGADFLMPGFJ();

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task HNAKOCBGCBL(FNFHONBFHOC JIPGCHPOGGF, POMHAFMABIA PPOHHIBGHKH, FNCJPDBCHMD? JDBEELGHEEL, KDBNAJDNMLL? BDNMOIODFHD);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[NOKNADFMENB("IStaticCV2Instance")]
public interface LBIGLAFBHAC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	FBNGBBCEEJI NFPELOHHCDD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[NOKNADFMENB("IStaticEVInstance")]
public interface MPJHGOEDKGI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	IFKOIELLEJC NNBMBEELCCC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public sealed class DOBPBNGABAL : GCNHELABFLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private readonly FNFHONBFHOC DEPGNJNBHGB;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public CDGHIMNJHCN? EELHBDDPCDG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x1DEF700", Offset = "0x1DEE900", VA = "0x181DEF700", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x7C19B0", Offset = "0x7C0BB0", VA = "0x1807C19B0")]
	internal DOBPBNGABAL(FNFHONBFHOC JIPGCHPOGGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public sealed class HCGKCGKKLOD : CDGHIMNJHCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private readonly LBIGLAFBHAC PNEFIEGFOPH;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public LLMLBNEIDBP COGGDLOLIKN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x1DEFEF0", Offset = "0x1DEF0F0", VA = "0x181DEFEF0", Slot = "4")]
		get
		{
			return default(LLMLBNEIDBP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public JDGOBIPLEMC GPDEMIFHPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x1DEFDD0", Offset = "0x1DEEFD0", VA = "0x181DEFDD0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public EIMAHFBCFHK<NJGFNHCPFKD> PAMKGDJPKKI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x1DEFD70", Offset = "0x1DEEF70", VA = "0x181DEFD70", Slot = "6")]
		get
		{
			return default(EIMAHFBCFHK<NJGFNHCPFKD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public FBNGBBCEEJI KIEECJNHIND
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x1DEFE30", Offset = "0x1DEF030", VA = "0x181DEFE30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x7C19B0", Offset = "0x7C0BB0", VA = "0x1807C19B0")]
	public HCGKCGKKLOD(LBIGLAFBHAC MBONFJGCAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x1DEFE80", Offset = "0x1DEF080", VA = "0x181DEFE80")]
	public bool PFFDPCKPLPK([In] EIMAHFBCFHK<NJGFNHCPFKD> KEAGJDNLFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x1DEFE80", Offset = "0x1DEF080", VA = "0x181DEFE80", Slot = "8")]
	private bool LBFIGEJGGJK([In] EIMAHFBCFHK<NJGFNHCPFKD> KEAGJDNLFNN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class PMFMNHJKONB
{
	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x1DF91D0", Offset = "0x1DF83D0", VA = "0x181DF91D0")]
	public static GGDJONELNKI<APPDEKGDMED, OLNEDDGCOEI, FNFHONBFHOC, COLNEMPFNPK.FCBAIHGFHME<APPDEKGDMED, OLNEDDGCOEI, FNFHONBFHOC>> CDDDJKPKLFC([In] this GGDJONELNKI<APPDEKGDMED, OLNEDDGCOEI, FNFHONBFHOC, COLNEMPFNPK.FCBAIHGFHME<APPDEKGDMED, OLNEDDGCOEI, FNFHONBFHOC>> MANLEDPFGEA)
	{
		return default(GGDJONELNKI<APPDEKGDMED, OLNEDDGCOEI, FNFHONBFHOC, COLNEMPFNPK.FCBAIHGFHME<APPDEKGDMED, OLNEDDGCOEI, FNFHONBFHOC>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public sealed class KHIGFOCAGKL : IJMBNNPIBKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private readonly FNFHONBFHOC DEPGNJNBHGB;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool OOHKCKOHADI
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x1DF4EA0", Offset = "0x1DF40A0", VA = "0x181DF4EA0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x7C19B0", Offset = "0x7C0BB0", VA = "0x1807C19B0")]
	internal KHIGFOCAGKL(FNFHONBFHOC JIPGCHPOGGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
internal sealed class EIEHJHABEEC : KBMBJKCGDCH
{
	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x1DEFA70", Offset = "0x1DEEC70", VA = "0x181DEFA70", Slot = "4")]
	public DDCIFNILHLP? PLNIICGLPKK(string? PAAKNFFIMGD, string? JCJAFGHKOPL, string? MJEKOOOKGEE, CGMCLOJONPJ.EDAMAFPGBDD.KALDBCKNHHI FFFAGEIBKFI, bool EDKGHPDEDDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public EIEHJHABEEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public sealed class PDBJABDNAFE : FMHILGEAADL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct JIOABLGGCGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public AsyncTaskMethodBuilder<HNODNIOAPDG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public PDBJABDNAFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private TaskAwaiter<JMPKLAJPDEP?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x1DF2F80", Offset = "0x1DF2180", VA = "0x181DF2F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x1DF3220", Offset = "0x1DF2420", VA = "0x181DF3220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private readonly FNFHONBFHOC DEPGNJNBHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private IReadOnlyList<EIMAHFBCFHK<JPNBFHLCDNL>>? PJAADJJBFKM;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public HNODNIOAPDG? EELHBDDPCDG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x1DF8270", Offset = "0x1DF7470", VA = "0x181DF8270", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public JHKLFLADBGI? OBPFPKILGDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x1DF7EE0", Offset = "0x1DF70E0", VA = "0x181DF7EE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public bool ANAPPLDDHGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x1DF81B0", Offset = "0x1DF73B0", VA = "0x181DF81B0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool OJDOPIMJNNB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x1DF8210", Offset = "0x1DF7410", VA = "0x181DF8210", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x7C19B0", Offset = "0x7C0BB0", VA = "0x1807C19B0")]
	internal PDBJABDNAFE(FNFHONBFHOC JIPGCHPOGGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x1DF7D70", Offset = "0x1DF6F70", VA = "0x181DF7D70", Slot = "7")]
	[AsyncStateMachine(typeof(JIOABLGGCGH))]
	public Task<HNODNIOAPDG> DJDFJOFJJIK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x1DF82F0", Offset = "0x1DF74F0", VA = "0x181DF82F0")]
	internal Dictionary<EIMAHFBCFHK<NJGFNHCPFKD>, Guid> MAIPKBGEMGD(IEnumerable<FFGBBHHFHNK> BDNJHMPIDDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x1DF7B00", Offset = "0x1DF6D00", VA = "0x181DF7B00")]
	public OAAHAKNOJDO<IGIAHDELKMN, GJOBCCNBLIC> BMEACNNMDIM([In] IGIAHDELKMN CFHBHBBPDNN, IEnumerable<FFGBBHHFHNK> CBDJPPIKEEL, int JGOHOAOFMDK)
	{
		return default(OAAHAKNOJDO<IGIAHDELKMN, GJOBCCNBLIC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x1DF7E60", Offset = "0x1DF7060", VA = "0x181DF7E60")]
	internal static BLGOMLCKDJD FHLBCHGBHJO(GGHDBICAMON JLECAPGEKMA, MDCFLBIEIKO JCCACJKHFKB)
	{
		return default(BLGOMLCKDJD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x1DF7EA0", Offset = "0x1DF70A0", VA = "0x181DF7EA0", Slot = "8")]
	private OAAHAKNOJDO<IGIAHDELKMN, GJOBCCNBLIC> GCFEDPGJCAJ([In] IGIAHDELKMN CFHBHBBPDNN, IEnumerable<FFGBBHHFHNK> CBDJPPIKEEL, int JGOHOAOFMDK)
	{
		return default(OAAHAKNOJDO<IGIAHDELKMN, GJOBCCNBLIC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x1DF7F60", Offset = "0x1DF7160", VA = "0x181DF7F60")]
	[CompilerGenerated]
	internal static BLGOMLCKDJD HGHLDMMAINO(GGHDBICAMON BAGBEOOGGNH, MDCFLBIEIKO BAACENIKGKD)
	{
		return default(BLGOMLCKDJD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public sealed class JHKLFLADBGI : HNODNIOAPDG
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	internal static class KEKDJLEMPFC
	{
		[Cpp2IlInjected.Token(Token = "0x200009C")]
		[CompilerGenerated]
		private sealed class JBAEHCDDGKA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public FBNGBBCEEJI state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public BBKDABEKLHF spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
			public JBAEHCDDGKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x1DEFFF0", Offset = "0x1DEF1F0", VA = "0x181DEFFF0")]
			internal bool MPPNAONOOIG(KBALILDBOKO n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class KLOAENEPMJF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
			public KLOAENEPMJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x1DF4EC0", Offset = "0x1DF40C0", VA = "0x181DF4EC0")]
			internal void JHBAGNJFFLD(KBALILDBOKO n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x1DF4960", Offset = "0x1DF3B60", VA = "0x181DF4960")]
		public static OAAHAKNOJDO<HNODNIOAPDG.MOPHOCAOMJE, GJOBCCNBLIC> OFGPKDDGEPG(JHKLFLADBGI AOFIGDLFNLH, [In] HNODNIOAPDG.MJFLKEJFMFI FJIDAJDLPID)
		{
			return default(OAAHAKNOJDO<HNODNIOAPDG.MOPHOCAOMJE, GJOBCCNBLIC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x1DF3290", Offset = "0x1DF2490", VA = "0x181DF3290")]
		internal static OAAHAKNOJDO<(DGBBJLELJKB, FMKPAOFLGNN), AHFOEFCGOPM> APAAJNOPOLO(JHKLFLADBGI AOFIGDLFNLH, FMKPAOFLGNN AFIMPIBIAAK, bool BKGJNGPGLLK, [In] EIMAHFBCFHK<NJGFNHCPFKD> IPMCKLDIBFF, [In] int? JBDAAHCBFJH, [In] BLGOMLCKDJD? KHCPIEPPKHC, [In] BLGOMLCKDJD? JGDIMOJHGHG)
		{
			return default(OAAHAKNOJDO<(DGBBJLELJKB, FMKPAOFLGNN), AHFOEFCGOPM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x1DF44E0", Offset = "0x1DF36E0", VA = "0x181DF44E0")]
		private static void NBOODMGJLAF(bool BKGJNGPGLLK, FFGBBHHFHNK NANIEKCKHKN, DGBBJLELJKB CPFKOMODIHI, [In] EIMAHFBCFHK<NJGFNHCPFKD> IPMCKLDIBFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x1DF3FE0", Offset = "0x1DF31E0", VA = "0x181DF3FE0")]
		public static void BBIPONLHJID(EEIOMGFFLAM JJGNJOLPHMO, [In] HNODNIOAPDG.BOBHPCKEHPK PHOBDPPPOPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x1DF43F0", Offset = "0x1DF35F0", VA = "0x181DF43F0")]
		[CompilerGenerated]
		internal static bool GMJOFMMPOKK(FBNGBBCEEJI FKBFIACFCHN, BBKDABEKLHF NLLFEFIHOFP, KBALILDBOKO CAHIGCOEKKG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private readonly FNFHONBFHOC DEPGNJNBHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private readonly LBIGLAFBHAC PNEFIEGFOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private readonly MPJHGOEDKGI DPCKBEGACHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private readonly AMIBIPFCBAO AGBBAMAEHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private readonly PDBJABDNAFE BJGKNFOEDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private Dictionary<EIMAHFBCFHK<GGOIHKGODHF>, CGNGINGKBKI> NNHAGOEDFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	[CompilerGenerated]
	private Action<EIMAHFBCFHK<GGOIHKGODHF>>? BBJBMDAJANF;

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x1DF2C10", Offset = "0x1DF1E10", VA = "0x181DF2C10")]
	public JHKLFLADBGI(FNFHONBFHOC JIPGCHPOGGF, LBIGLAFBHAC MBONFJGCAML, MPJHGOEDKGI OLCFMIOBOJB, PDBJABDNAFE LEPPKCKJCCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x1DF1FF0", Offset = "0x1DF11F0", VA = "0x181DF1FF0", Slot = "4")]
	public bool MGMJLKIFIJC(KHCIOCBLCGC<NJGFNHCPFKD> KEAGJDNLFNN, KHCIOCBLCGC<NJIFMIKHJJL> PAFLPPOBMOG, KHCIOCBLCGC<GHLBDMPMDKP> HKGFBLIPGLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x1DF1D60", Offset = "0x1DF0F60", VA = "0x181DF1D60")]
	public CGNGINGKBKI? KLPNOBJHHHE([In] EIMAHFBCFHK<GGOIHKGODHF> MBBENIIFGEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x1DF1ED0", Offset = "0x1DF10D0", VA = "0x181DF1ED0")]
	private void KOHGHIPKIMO(EIMAHFBCFHK<GGOIHKGODHF> MBBENIIFGEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x1DF1CB0", Offset = "0x1DF0EB0", VA = "0x181DF1CB0")]
	private CGNGINGKBKI? KJDBLNFOFMG([In] EIMAHFBCFHK<GGOIHKGODHF> MBBENIIFGEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x1DF0A80", Offset = "0x1DEFC80", VA = "0x181DF0A80")]
	public MDCFLBIEIKO? CCFPGEALLFA([In] EIMAHFBCFHK<GGOIHKGODHF> MBBENIIFGEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x1DF0980", Offset = "0x1DEFB80", VA = "0x181DF0980")]
	public FPEOKPOCNAP? AOHHHPFGNHM([In] EIMAHFBCFHK<NJGFNHCPFKD> KEAGJDNLFNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x1DF1F50", Offset = "0x1DF1150", VA = "0x181DF1F50")]
	private BBKDABEKLHF? LEGKDPIDHBI([In] EIMAHFBCFHK<NJGFNHCPFKD> KEAGJDNLFNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x1DF0980", Offset = "0x1DEFB80", VA = "0x181DF0980")]
	private FPEOKPOCNAP? CHBDNKJIBMJ([In] EIMAHFBCFHK<NJGFNHCPFKD> KEAGJDNLFNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x1DF1320", Offset = "0x1DF0520", VA = "0x181DF1320")]
	public KHCIOCBLCGC<GHLBDMPMDKP> FDCJFEBGMAA(KHCIOCBLCGC<NJGFNHCPFKD> KEAGJDNLFNN, KHCIOCBLCGC<GGOIHKGODHF> MBBENIIFGEP, int HINLAFIDFIB)
	{
		return default(KHCIOCBLCGC<GHLBDMPMDKP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x1DF1530", Offset = "0x1DF0730", VA = "0x181DF1530")]
	public KHCIOCBLCGC<NJIFMIKHJJL> HEFNJJNIBMA(KHCIOCBLCGC<NJGFNHCPFKD> KEAGJDNLFNN, KHCIOCBLCGC<GGOIHKGODHF> MBBENIIFGEP, int LFCCAAPCEFP)
	{
		return default(KHCIOCBLCGC<NJIFMIKHJJL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x1DF1BB0", Offset = "0x1DF0DB0", VA = "0x181DF1BB0", Slot = "7")]
	public IEnumerable<OAFCAJHBNGL> KCBEAOLAKFB(IOJOMBCPPMK BDDBNLOKCGJ, bool LNDOHFMNPPI, bool DPBNFKGPBCK, bool EIMPFLMCIPH, bool HKDDJJLFDKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x1DF1030", Offset = "0x1DF0230", VA = "0x181DF1030", Slot = "8")]
	public OAFCAJHBNGL DPPKGOKEKGD(IOJOMBCPPMK BDDBNLOKCGJ, JFJJGGLOICA BLNKMFEGBOO, bool DPBNFKGPBCK, bool EIMPFLMCIPH, bool HKDDJJLFDKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x1DF0F70", Offset = "0x1DF0170", VA = "0x181DF0F70")]
	public OAAHAKNOJDO<HNODNIOAPDG.MOPHOCAOMJE, GJOBCCNBLIC> EHLHBGCNKBL([In] HNODNIOAPDG.MJFLKEJFMFI FJIDAJDLPID)
	{
		return default(OAAHAKNOJDO<HNODNIOAPDG.MOPHOCAOMJE, GJOBCCNBLIC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x1DF0B80", Offset = "0x1DEFD80", VA = "0x181DF0B80", Slot = "10")]
	public OAAHAKNOJDO<GIEAOPKADBL, GJOBCCNBLIC> CHDOBDDGGMB(EIMAHFBCFHK<NJGFNHCPFKD> KEAGJDNLFNN, GIEAOPKADBL DEPPIIDOGLE, FGFCDGHHJFA MLOLLCEJDFL)
	{
		return default(OAAHAKNOJDO<GIEAOPKADBL, GJOBCCNBLIC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x1DF2550", Offset = "0x1DF1750", VA = "0x181DF2550", Slot = "11")]
	public BHNMOGOJBGK MGOAHMBBGLL(IEnumerable<FFGBBHHFHNK> CBDJPPIKEEL)
	{
		return default(BHNMOGOJBGK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x1DF1410", Offset = "0x1DF0610", VA = "0x181DF1410", Slot = "12")]
	public BHNMOGOJBGK GPCCKGAGCND()
	{
		return default(BHNMOGOJBGK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x1DF0490", Offset = "0x1DEF690", VA = "0x181DF0490")]
	private LBIMACPIOKG AAJANGOIPKE(GMCHBHAOJKA HCBMHPALCEO, KHCIOCBLCGC<NJGFNHCPFKD> JEJBJOCKHCL, IEnumerable<EIMAHFBCFHK<NJGFNHCPFKD>> BJFLEBCMBCA, IEnumerable<EIMAHFBCFHK<GGOIHKGODHF>> NPOPNHOBJPP)
	{
		return default(LBIMACPIOKG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x1DF0640", Offset = "0x1DEF840", VA = "0x181DF0640", Slot = "13")]
	public LBIMACPIOKG AAJANGOIPKE(GMCHBHAOJKA HCBMHPALCEO, KHCIOCBLCGC<NJGFNHCPFKD> JEJBJOCKHCL, IEnumerable<EIMAHFBCFHK<GGOIHKGODHF>> NPOPNHOBJPP, IEnumerable<FFGBBHHFHNK> CBDJPPIKEEL)
	{
		return default(LBIMACPIOKG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x1DF2740", Offset = "0x1DF1940", VA = "0x181DF2740")]
	private static IEnumerable<EIMAHFBCFHK<NJGFNHCPFKD>> NMLGGCAOMIH(IEnumerable<FFGBBHHFHNK> CBDJPPIKEEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x1DF15C0", Offset = "0x1DF07C0", VA = "0x181DF15C0")]
	private IEnumerable<EIMAHFBCFHK<GGOIHKGODHF>> HJOGIPBKEGL(IEnumerable<FFGBBHHFHNK> CBDJPPIKEEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x1DF0FA0", Offset = "0x1DF01A0", VA = "0x181DF0FA0", Slot = "14")]
	public List<NHPANOLNFIK> DOLHFLDGBAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x1DF1A60", Offset = "0x1DF0C60", VA = "0x181DF1A60", Slot = "15")]
	public bool HNFFLBIIFPP(KHCIOCBLCGC<NJGFNHCPFKD> KEAGJDNLFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x1DF13B0", Offset = "0x1DF05B0", VA = "0x181DF13B0")]
	internal void FEHOAJFKPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x1DF0A20", Offset = "0x1DEFC20", VA = "0x181DF0A20")]
	internal Task BJFBCPEOAKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x1DF0980", Offset = "0x1DEFB80", VA = "0x181DF0980", Slot = "5")]
	private FPEOKPOCNAP PBCELADAAKK([In] EIMAHFBCFHK<NJGFNHCPFKD> KEAGJDNLFNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x1DF2AC0", Offset = "0x1DF1CC0", VA = "0x181DF2AC0", Slot = "6")]
	private CGNGINGKBKI PDGKFIGNGNG([In] EIMAHFBCFHK<GGOIHKGODHF> MBBENIIFGEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x1DF0F70", Offset = "0x1DF0170", VA = "0x181DF0F70", Slot = "9")]
	private OAAHAKNOJDO<HNODNIOAPDG.MOPHOCAOMJE, GJOBCCNBLIC> DKCHODDDAHP([In] HNODNIOAPDG.MJFLKEJFMFI FJIDAJDLPID)
	{
		return default(OAAHAKNOJDO<HNODNIOAPDG.MOPHOCAOMJE, GJOBCCNBLIC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x1DF1B30", Offset = "0x1DF0D30", VA = "0x181DF1B30")]
	[CompilerGenerated]
	private JCCNHJLHHOJ IKLFBJLGLNC(JPPMLKCJMLE IBNKLDKLAGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x1DF0B10", Offset = "0x1DEFD10", VA = "0x181DF0B10")]
	[CompilerGenerated]
	private MDCFLBIEIKO CGCNGCNJILA(EIMAHFBCFHK<GGOIHKGODHF> IBNKLDKLAGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x1DF09B0", Offset = "0x1DEFBB0", VA = "0x181DF09B0")]
	[CompilerGenerated]
	private BBKDABEKLHF BDKAHEGMIHJ(EIMAHFBCFHK<NJGFNHCPFKD> IBNKLDKLAGI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public sealed class JCCNHJLHHOJ : OAFCAJHBNGL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private struct PBCDILGIAIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public AsyncTaskMethodBuilder<OAAHAKNOJDO<KHCIOCBLCGC<HJOFJJKDLOL>, AHFOEFCGOPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public JCCNHJLHHOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public EIMAHFBCFHK<NJGFNHCPFKD> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public EIMAHFBCFHK<GGOIHKGODHF> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public KHCIOCBLCGC<GHMMCINEBDI> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private TaskAwaiter<OAAHAKNOJDO<KHCIOCBLCGC<HJOFJJKDLOL>, AHFOEFCGOPM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x1DF7810", Offset = "0x1DF6A10", VA = "0x181DF7810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x1DF7A90", Offset = "0x1DF6C90", VA = "0x181DF7A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private struct AMLNBDFAAAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public AsyncTaskMethodBuilder<OAAHAKNOJDO<KHCIOCBLCGC<HGFONCOECHI>, AHFOEFCGOPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public JCCNHJLHHOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public EIMAHFBCFHK<NJGFNHCPFKD> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public EIMAHFBCFHK<GGOIHKGODHF> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public KHCIOCBLCGC<GHMMCINEBDI> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private TaskAwaiter<OAAHAKNOJDO<KHCIOCBLCGC<HGFONCOECHI>, AHFOEFCGOPM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x1DEF300", Offset = "0x1DEE500", VA = "0x181DEF300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x1DEF580", Offset = "0x1DEE780", VA = "0x181DEF580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private readonly JPPMLKCJMLE CFNCDLINJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private readonly LBIGLAFBHAC PNEFIEGFOPH;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public TypeKey KCEHIOIAALP
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x95D910", Offset = "0x95CB10", VA = "0x18095D910", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public string GLJAENJCCED
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x1DF03C0", Offset = "0x1DEF5C0", VA = "0x181DF03C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public JPPMLKCJMLE GCKHDNBEAFE
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x1DF03F0", Offset = "0x1DEF5F0", VA = "0x181DF03F0")]
	public JCCNHJLHHOJ(JPPMLKCJMLE EPFCPEFFOFA, LBIGLAFBHAC MBONFJGCAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x1DF00E0", Offset = "0x1DEF2E0", VA = "0x181DF00E0", Slot = "6")]
	[AsyncStateMachine(typeof(PBCDILGIAIN))]
	public Task<OAAHAKNOJDO<KHCIOCBLCGC<HJOFJJKDLOL>, AHFOEFCGOPM>> HPKAFLHOACD(EIMAHFBCFHK<NJGFNHCPFKD> KEAGJDNLFNN, EIMAHFBCFHK<GGOIHKGODHF> MBBENIIFGEP, KHCIOCBLCGC<GHMMCINEBDI> CIHLOOFFIBE, string MPENHPFDCDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x1DF0250", Offset = "0x1DEF450", VA = "0x181DF0250", Slot = "7")]
	[AsyncStateMachine(typeof(AMLNBDFAAAN))]
	public Task<OAAHAKNOJDO<KHCIOCBLCGC<HGFONCOECHI>, AHFOEFCGOPM>> ILDDPDKBOOK(EIMAHFBCFHK<NJGFNHCPFKD> KEAGJDNLFNN, EIMAHFBCFHK<GGOIHKGODHF> MBBENIIFGEP, KHCIOCBLCGC<GHMMCINEBDI> CIHLOOFFIBE, string MPENHPFDCDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public sealed class KPCFAHCGMCF : PBJEKJJMLKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private readonly JPPMLKCJMLE LELKBKGFBNC;

	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private static readonly HashSet<JPPMLKCJMLE> PKPBPFNJIBE;

	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private static readonly HashSet<JPPMLKCJMLE> DKDDNBEPFBJ;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly HashSet<JPPMLKCJMLE> MIPOAAEHKPH;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public TypeKey NFEHEBDHPKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x1DF6320", Offset = "0x1DF5520", VA = "0x181DF6320", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool NLBCNLCNHEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x1DF6310", Offset = "0x1DF5510", VA = "0x181DF6310", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool OKLFENGNPBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x1DF6370", Offset = "0x1DF5570", VA = "0x181DF6370", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool OLFEECPFALP
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x1DF6290", Offset = "0x1DF5490", VA = "0x181DF6290", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x1DF5070", Offset = "0x1DF4270", VA = "0x181DF5070")]
	public bool OCHONHBNPAK(string EKDDCPALANJ, [Out] NKAMIBLIEAE FMLLCNDLBMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x7C19B0", Offset = "0x7C0BB0", VA = "0x1807C19B0")]
	public KPCFAHCGMCF(JPPMLKCJMLE HMEKKAINJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x1DF4EE0", Offset = "0x1DF40E0", VA = "0x181DF4EE0")]
	internal static TypeKey GHHOPOLNJGJ(JPPMLKCJMLE MJMAEGDPBNJ)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x1DF03C0", Offset = "0x1DEF5C0", VA = "0x181DF03C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public readonly struct LNKIIGDCDEC : FFJBPGDBKED.PEEMLKGMIGO<OLNEDDGCOEI, NFDBFOHCHGK>
{
	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x1DF6B20", Offset = "0x1DF5D20", VA = "0x181DF6B20", Slot = "4")]
	public int OJHNOKBLPEJ(NFDBFOHCHGK KCEAHMBEPHE, OLNEDDGCOEI OFOIHENMFDE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x1DF6A30", Offset = "0x1DF5C30", VA = "0x181DF6A30", Slot = "5")]
	public OLNEDDGCOEI APLPFEBIBGA(NFDBFOHCHGK KCEAHMBEPHE, OLNEDDGCOEI OFOIHENMFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x1DF6AE0", Offset = "0x1DF5CE0", VA = "0x181DF6AE0", Slot = "6")]
	public OLNEDDGCOEI NFHJKCOMJNH(NFDBFOHCHGK KCEAHMBEPHE, OLNEDDGCOEI OFOIHENMFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x1DF6A40", Offset = "0x1DF5C40", VA = "0x181DF6A40", Slot = "7")]
	public IReadOnlyList<OLNEDDGCOEI> BMCEFPOMAKG(NFDBFOHCHGK KCEAHMBEPHE, OLNEDDGCOEI OFOIHENMFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x1DF6B10", Offset = "0x1DF5D10", VA = "0x181DF6B10", Slot = "8")]
	public OLNEDDGCOEI[] NLAJODKCOKE(NFDBFOHCHGK KCEAHMBEPHE, OLNEDDGCOEI OFOIHENMFDE, int AGHGAGHMJLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x1DF6AA0", Offset = "0x1DF5CA0", VA = "0x181DF6AA0", Slot = "9")]
	public bool GGBJNDFFPPD(NFDBFOHCHGK KCEAHMBEPHE, OLNEDDGCOEI OFOIHENMFDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x1DF6AC0", Offset = "0x1DF5CC0", VA = "0x181DF6AC0", Slot = "10")]
	public bool MOJNNLDHDGD(NFDBFOHCHGK KCEAHMBEPHE, OLNEDDGCOEI OFOIHENMFDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x1DF6A60", Offset = "0x1DF5C60", VA = "0x181DF6A60", Slot = "11")]
	public bool FMCGAHPEFMN(NFDBFOHCHGK KCEAHMBEPHE, OLNEDDGCOEI OFOIHENMFDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x1DF69F0", Offset = "0x1DF5BF0", VA = "0x181DF69F0", Slot = "12")]
	public bool ALMCNFBEBGK(NFDBFOHCHGK KCEAHMBEPHE, OLNEDDGCOEI OFOIHENMFDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x1DF6A10", Offset = "0x1DF5C10", VA = "0x181DF6A10", Slot = "13")]
	public bool AMLDEKGPJIH(NFDBFOHCHGK OMHJAKBKALO, OLNEDDGCOEI OFOIHENMFDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x1DF6A80", Offset = "0x1DF5C80", VA = "0x181DF6A80", Slot = "14")]
	public bool GAPGCLOCDPF(NFDBFOHCHGK KCEAHMBEPHE, OLNEDDGCOEI OFOIHENMFDE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public abstract class IAFMMOEOLOB : LEKMIPCMIOG
{
	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public NGBHNACKADH.HCDCGJGJKGL EIINJKCFIKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x1DEFF50", Offset = "0x1DEF150", VA = "0x181DEFF50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public abstract IEDBNMJFFCL.LOAGNIFEEIL FHBFDGICLAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public abstract FNFHONBFHOC.CECGGNIPDGH HPMJMCNKABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public abstract KPJLMCGFILG.JDGOCGDPDLF HDDDKDJJKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public COLNEMPFNPK.FCBAIHGFHME<APPDEKGDMED, OLNEDDGCOEI, FNFHONBFHOC> CDHCPJNDMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x1DEFFA0", Offset = "0x1DEF1A0", VA = "0x181DEFFA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public abstract BHHPNLGMNNB CNEMGIOBEPL
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public abstract LFPLNNMJIPA KGBGOAKDCCK
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public abstract OMIAKFHGILK AILNDJCFFFO
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public abstract BINOIGOJMJL NDGNMCEIEIB
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public abstract AAKEGACABAD PFBCDBJJOIN
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	protected IAFMMOEOLOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public sealed class EAADMEANGHO : JDGOBIPLEMC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private struct PMENOLFHFJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public AsyncTaskMethodBuilder<OAAHAKNOJDO<object, AHFOEFCGOPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public EAADMEANGHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public OLNEDDGCOEI action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private TaskAwaiter<OAAHAKNOJDO<object, AHFOEFCGOPM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x1DF8F50", Offset = "0x1DF8150", VA = "0x181DF8F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9160", Offset = "0x1DF8360", VA = "0x181DF9160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct OHDACDFAOBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public AsyncTaskMethodBuilder<OAAHAKNOJDO<GBCBPCFFANE, AHFOEFCGOPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public EAADMEANGHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public IReadOnlyList<OLNEDDGCOEI> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private TaskAwaiter<OAAHAKNOJDO<object, AHFOEFCGOPM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x1DF7240", Offset = "0x1DF6440", VA = "0x181DF7240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x1DF75C0", Offset = "0x1DF67C0", VA = "0x181DF75C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly PGMGGHNJIBF JHBAMMCMILI;

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x7C19B0", Offset = "0x7C0BB0", VA = "0x1807C19B0")]
	public EAADMEANGHO(PGMGGHNJIBF BADMILBHCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x1DEF810", Offset = "0x1DEEA10", VA = "0x181DEF810")]
	[AsyncStateMachine(typeof(PMENOLFHFJI))]
	private Task<OAAHAKNOJDO<object, AHFOEFCGOPM>> COGGDLOLIKN(OLNEDDGCOEI OFOIHENMFDE, bool DMBCFIFLHLH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x1DEF940", Offset = "0x1DEEB40", VA = "0x181DEF940", Slot = "4")]
	[AsyncStateMachine(typeof(OHDACDFAOBI))]
	public Task<OAAHAKNOJDO<GBCBPCFFANE, AHFOEFCGOPM>> JCALJMMEOLO(IReadOnlyList<OLNEDDGCOEI> PGBGGHKPAIE, bool DMBCFIFLHLH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct AABNJICNLHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	internal HNJJLFJMJMI<PBLDLJBIPCL, OLNEDDGCOEI, OHFKMOCFOKF> LELKBKGFBNC;

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x1DDF2A0", Offset = "0x1DDE4A0", VA = "0x181DDF2A0")]
	private AABNJICNLHP([In] HNJJLFJMJMI<PBLDLJBIPCL, OLNEDDGCOEI, OHFKMOCFOKF> MLDCDLJNLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x1DEF030", Offset = "0x1DEE230", VA = "0x181DEF030")]
	public static AABNJICNLHP DHBNKMCPKNO()
	{
		return default(AABNJICNLHP);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public static class ANKCNBLPIAL
{
	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x8788E0", Offset = "0x877AE0", VA = "0x1808788E0")]
	public static HNJJLFJMJMI<PBLDLJBIPCL, OLNEDDGCOEI, OHFKMOCFOKF> CGNFDLLANLP(this AABNJICNLHP AOFIGDLFNLH)
	{
		return default(HNJJLFJMJMI<PBLDLJBIPCL, OLNEDDGCOEI, OHFKMOCFOKF>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public struct OHFKMOCFOKF : NIGDKLBMHAH.JJECJNEHMNO<PBLDLJBIPCL, OLNEDDGCOEI>
{
	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x1DF7630", Offset = "0x1DF6830", VA = "0x181DF7630", Slot = "5")]
	public OLNEDDGCOEI JEHBFCLIKLL(PBLDLJBIPCL[] FJPJEJAECKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x13E4320", Offset = "0x13E3520", VA = "0x1813E4320")]
	public int KCLEIDIEAFC([In] PBLDLJBIPCL ALILPODFOKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x13E4320", Offset = "0x13E3520", VA = "0x1813E4320", Slot = "4")]
	private int COMKJJNOEPL([In] PBLDLJBIPCL DDDCAKNMCLD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public struct GBCPELNDKJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	internal OGHBCKLAJFC<BCJOPPPBPBI, OLNEDDGCOEI, LIGKALKIFME> LELKBKGFBNC;

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x1DDF2A0", Offset = "0x1DDE4A0", VA = "0x181DDF2A0")]
	private GBCPELNDKJC([In] OGHBCKLAJFC<BCJOPPPBPBI, OLNEDDGCOEI, LIGKALKIFME> MOAEJBIGDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x1DEFD10", Offset = "0x1DEEF10", VA = "0x181DEFD10")]
	public static GBCPELNDKJC DHBNKMCPKNO()
	{
		return default(GBCPELNDKJC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public static class MJGHFFHLKLI
{
	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x8788E0", Offset = "0x877AE0", VA = "0x1808788E0")]
	public static OGHBCKLAJFC<BCJOPPPBPBI, OLNEDDGCOEI, LIGKALKIFME> CGNFDLLANLP(this GBCPELNDKJC AOFIGDLFNLH)
	{
		return default(OGHBCKLAJFC<BCJOPPPBPBI, OLNEDDGCOEI, LIGKALKIFME>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public struct LIGKALKIFME : HNPGLGMOFCE.KHEHBCHHPAI<BCJOPPPBPBI, OLNEDDGCOEI>
{
	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x13E4320", Offset = "0x13E3520", VA = "0x1813E4320")]
	public int GHLLLNFBPHN([In] BCJOPPPBPBI ALILPODFOKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x1DF6490", Offset = "0x1DF5690", VA = "0x181DF6490", Slot = "5")]
	public OLNEDDGCOEI MOGDHAFMNKG(BCJOPPPBPBI[] NPHOLDKMBHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x13E4320", Offset = "0x13E3520", VA = "0x1813E4320", Slot = "4")]
	private int CALAHDIIAKN([In] BCJOPPPBPBI ALILPODFOKH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public interface BHHPNLGMNNB
{
	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PADDGALKNMF([In] OAAHAKNOJDO<NFDBFOHCHGK, GJOBCCNBLIC> IFJGEIAONPI);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public static class CHLLACGCPPN
{
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x26C8A10", Offset = "0x26C7C10", VA = "0x1826C8A10")]
	public static bool PADDGALKNMF<TOk, TErr>(this BHHPNLGMNNB AOFIGDLFNLH, [In] OAAHAKNOJDO<TOk, TErr> IFJGEIAONPI) where TOk : notnull where TErr : notnull, GJOBCCNBLIC
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public interface LFPLNNMJIPA
{
	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	CNFPODIMHHB PLHKLOOJMHB
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public interface OMIAKFHGILK
{
	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KGIEMHEELDO EFMJGFGOFGJ(int MJGOEAJIMBB);
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public interface IAHONCMNBCG
{
	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	string FLDBLPHJNKM
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public interface BONAAEIPPFF
{
	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DCFLIKJADHE? NBKOJCOFCHA(KHCIOCBLCGC<GHMMCINEBDI> CIHLOOFFIBE);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public interface KCKIMBJHLAL
{
	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	string FLDBLPHJNKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public interface DCFLIKJADHE
{
	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	string FLDBLPHJNKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KCKIMBJHLAL? NOKBDGBNKPF(KHCIOCBLCGC<HJOFJJKDLOL> OFKCKILNIKB);

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IAHONCMNBCG? CICMNFFCMIJ(KHCIOCBLCGC<HGFONCOECHI> IHLICNJPHKN);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public interface BINOIGOJMJL
{
	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> PCMOFOPCBAF(string EKDDCPALANJ, string DPGBKIGAHAN);
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public interface AAKEGACABAD
{
	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BONAAEIPPFF? KHIANJGJNAL([In] EIMAHFBCFHK<JPNBFHLCDNL> AAFHAJELNPF);
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public sealed class PJIDCHGOJPC
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private struct AOHIMJGMJJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public int ABDHHHCLNNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public FNCJPDBCHMD? OCFPLHGOJMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public FNCJPDBCHMD? FHMAJFDDDIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public readonly List<OLNEDDGCOEI> OMMJJNMJNMO;

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x1DEF6B0", Offset = "0x1DEE8B0", VA = "0x181DEF6B0")]
		private AOHIMJGMJJM(int MBGANDEDPDN, FNCJPDBCHMD? JMDMNGNHCMB, FNCJPDBCHMD? BOGDHPMCBKK, List<OLNEDDGCOEI> PGBGGHKPAIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x1DEF5F0", Offset = "0x1DEE7F0", VA = "0x181DEF5F0")]
		public static AOHIMJGMJJM DHBNKMCPKNO()
		{
			return default(AOHIMJGMJJM);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private readonly ODHLLOELCDE<AOHIMJGMJJM> CBGLCKBFEJE;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public static PJIDCHGOJPC EELHBDDPCDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x1DF8D50", Offset = "0x1DF7F50", VA = "0x181DF8D50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool GOIDHGIPCLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x806F10", Offset = "0x806110", VA = "0x180806F10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x86F7F0", Offset = "0x86E9F0", VA = "0x18086F7F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x1DF8950", Offset = "0x1DF7B50", VA = "0x181DF8950")]
	public void IOJHPJIGAPE(FBNGBBCEEJI BOGDHPMCBKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x1DF8660", Offset = "0x1DF7860", VA = "0x181DF8660")]
	public void DHKMKNPMGBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x1DF8A10", Offset = "0x1DF7C10", VA = "0x181DF8A10")]
	private static string? LLEJKAHCABJ([In] AOHIMJGMJJM GLNEJECHAID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x1DF8EA0", Offset = "0x1DF80A0", VA = "0x181DF8EA0")]
	public PJIDCHGOJPC()
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
