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
		[Cpp2IlInjected.Address(RVA = "0x7E01F0", Offset = "0x7DE9F0", VA = "0x1807E01F0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2029600", Offset = "0x2027E00", VA = "0x182029600")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7EEC40", Offset = "0x7ED440", VA = "0x1807EEC40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA14660", Offset = "0xA12E60", VA = "0x180A14660")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class GILANFAFAJM : IDisposable, KFJDJDLIPJA, MOFOMIJNOFJ, BHNPGCBKCIC, FPKEJMMKNPE, OGOCHFODJCI
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private readonly struct DAMFPGIJKHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670240", Offset = "0x66F640")]
		public readonly LKNEPLGEPHC<OMKODJJIJCE, CIBICCNJBCB, GILANFAFAJM, MBBIGIBBKAC.LEFMHIHNJNB<OMKODJJIJCE, CIBICCNJBCB, GILANFAFAJM>> MOJFAFLNEFM;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2017D10", Offset = "0x2016510", VA = "0x182017D10")]
		internal DAMFPGIJKHM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6702A0", Offset = "0x66F6A0")] LKNEPLGEPHC<OMKODJJIJCE, CIBICCNJBCB, GILANFAFAJM, MBBIGIBBKAC.LEFMHIHNJNB<OMKODJJIJCE, CIBICCNJBCB, GILANFAFAJM>> PBDNMEDOHIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class ODCCIOOJJAA : MBBIGIBBKAC.LEFMHIHNJNB<OMKODJJIJCE, CIBICCNJBCB, GILANFAFAJM>
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly ODCCIOOJJAA OEFAOPMNMGM;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		private ODCCIOOJJAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xB5E5B0", Offset = "0xB5CDB0", VA = "0x180B5E5B0", Slot = "4")]
		public OMKODJJIJCE DNKDNLEOMMI(CIBICCNJBCB PECDBPPMOJP)
		{
			return default(OMKODJJIJCE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		public void KFGAMBKHJCE(GILANFAFAJM CEABICNIABB, CIBICCNJBCB COPPLLLOGLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class EFBPMGMOBOC : MAFDKMBBDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int KDIOFGPJJFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2018C50", Offset = "0x2017450", VA = "0x182018C50", Slot = "5")]
		public HDOLDAMCNME HMPEHFLDIHO(PAPCPEKFGLB.COHJBFHKJIC BPNALAJICIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void FGOKFAKAKLJ();

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void MLBGMCJDFDD();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		protected EFBPMGMOBOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface MAFDKMBBDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int KDIOFGPJJFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		HDOLDAMCNME HMPEHFLDIHO(PAPCPEKFGLB.COHJBFHKJIC BPNALAJICIC);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void FGOKFAKAKLJ();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void MLBGMCJDFDD();
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct PCMAFHIODGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670300", Offset = "0x66F700")]
		public PAIOLPCBHBC<OMKODJJIJCE, CIBICCNJBCB, GILANFAFAJM, MBBIGIBBKAC.LEFMHIHNJNB<OMKODJJIJCE, CIBICCNJBCB, GILANFAFAJM>> MOJFAFLNEFM;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2030410", Offset = "0x202EC10", VA = "0x182030410")]
		internal PCMAFHIODGN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670360", Offset = "0x66F760")] PAIOLPCBHBC<OMKODJJIJCE, CIBICCNJBCB, GILANFAFAJM, MBBIGIBBKAC.LEFMHIHNJNB<OMKODJJIJCE, CIBICCNJBCB, GILANFAFAJM>> PBDNMEDOHIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x20303C0", Offset = "0x202EBC0", VA = "0x1820303C0")]
		public static PCMAFHIODGN NKAIHPJAMOL()
		{
			return default(PCMAFHIODGN);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct LLGNLHNJGMM : FGGGLGANPGN.CLHNGOAMPHN<GCDMCLKLFED, CIBICCNJBCB, GILANFAFAJM>
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class OIKNMOBADOK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670460", Offset = "0x66F860")]
			public AsyncTaskMethodBuilder<DLDMCIANGML<object, KCPGGCLIGHK>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public GILANFAFAJM receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public CIBICCNJBCB action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public LLGNLHNJGMM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6704C0", Offset = "0x66F8C0")]
			private DLDMCIANGML<object, KCPGGCLIGHK> <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670520", Offset = "0x66F920")]
			private TaskAwaiter<DLDMCIANGML<object, KCPGGCLIGHK>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
			public OIKNMOBADOK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6C99B40", Offset = "0x6C98340", VA = "0x186C99B40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xB74FA0", Offset = "0xB737A0", VA = "0x180B74FA0", Slot = "4")]
		public JIGIFEGHNPP<GCDMCLKLFED> IHJFLLOODLJ(GILANFAFAJM PIJFGKNLICL)
		{
			return default(JIGIFEGHNPP<GCDMCLKLFED>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2024EA0", Offset = "0x20236A0", VA = "0x182024EA0", Slot = "5")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(OIKNMOBADOK))]
		public Task<DLDMCIANGML<object, KCPGGCLIGHK>> HHEOCCNKDGJ(GILANFAFAJM PIJFGKNLICL, CIBICCNJBCB COPPLLLOGLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2024E80", Offset = "0x2023680", VA = "0x182024E80", Slot = "6")]
		public CIBICCNJBCB[] CKGNHACFAFE(GILANFAFAJM PIJFGKNLICL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class LHLFCFHMFOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670580", Offset = "0x66F980")]
		public AsyncTaskMethodBuilder<DLDMCIANGML<bool, KCPGGCLIGHK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public INDICKEOBNO rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public MCEGKBNFGBJ circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public PKMIHDKHPIO superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public GILANFAFAJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6705E0", Offset = "0x66F9E0")]
		private DLDMCIANGML<bool, KCPGGCLIGHK> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670640", Offset = "0x66FA40")]
		private TaskAwaiter<DLDMCIANGML<bool, KCPGGCLIGHK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public LHLFCFHMFOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2024C20", Offset = "0x2023420", VA = "0x182024C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class DPIPDKBNIDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6706A0", Offset = "0x66FAA0")]
		public AsyncTaskMethodBuilder<DLDMCIANGML<bool, KCPGGCLIGHK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public GILANFAFAJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670700", Offset = "0x66FB00")]
		private DLDMCIANGML<bool, KCPGGCLIGHK> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670760", Offset = "0x66FB60")]
		private TaskAwaiter<DLDMCIANGML<bool, KCPGGCLIGHK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public DPIPDKBNIDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x20187C0", Offset = "0x2016FC0", VA = "0x1820187C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class EDBIPBKCIOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6707C0", Offset = "0x66FBC0")]
		public AsyncTaskMethodBuilder<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public GILANFAFAJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670820", Offset = "0x66FC20")]
		private DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670880", Offset = "0x66FC80")]
		private TaskAwaiter<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public EDBIPBKCIOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2018A20", Offset = "0x2017220", VA = "0x182018A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class ONBKLPPGIAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6708E0", Offset = "0x66FCE0")]
		public AsyncTaskMethodBuilder<DLDMCIANGML<object, KCPGGCLIGHK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public CIBICCNJBCB action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public GILANFAFAJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private DLDMCIANGML<object, KCPGGCLIGHK> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter<DLDMCIANGML<object, KCPGGCLIGHK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public ONBKLPPGIAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x202F790", Offset = "0x202DF90", VA = "0x18202F790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class MGFFOBPBBCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670940", Offset = "0x66FD40")]
		public AsyncTaskMethodBuilder<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public GILANFAFAJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6709A0", Offset = "0x66FDA0")]
		private DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK> <r>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670A00", Offset = "0x66FE00")]
		private DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK> <destroyRes>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670A60", Offset = "0x66FE60")]
		private DLDMCIANGML<bool, KCPGGCLIGHK> <createRes>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670AC0", Offset = "0x66FEC0")]
		private DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK> <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670B20", Offset = "0x66FF20")]
		private DLDMCIANGML<bool, KCPGGCLIGHK> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670B80", Offset = "0x66FF80")]
		private TaskAwaiter<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670BE0", Offset = "0x66FFE0")]
		private TaskAwaiter<DLDMCIANGML<bool, KCPGGCLIGHK>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public MGFFOBPBBCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2025690", Offset = "0x2023E90", VA = "0x182025690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66FCE0", Offset = "0x66F0E0")]
	private readonly JIGIFEGHNPP<GCDMCLKLFED> PNGHLGKLJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly DAMFPGIJKHM CPCOHHDOFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly KGCPCEDNICE AEPFHKAGPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly PEKNFFFIPLC MOFJPCHJINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly KAEGPHJIFMG.HKFLMGCDNKI KDIKCHJGJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly NMFAOHENEAK MFJLOHGPDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly PLPEOAGOFIB KKEFDKDLLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly FGJNHGAJLLO EKAFBPCEHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly HEDEBKJNHAI ODNDBCJDNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private HKNBMMOIMEJ HDNMIACHMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private OGIAINCGGEC MNMDLODGLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal readonly KGCPCEDNICE.JHPCOAKHCCP NIGMCAJPKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly NEAKMNNGOFF FFLMGJCJDKG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public KGCPCEDNICE MPKPFLBEPME
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x201F5E0", Offset = "0x201DDE0", VA = "0x18201F5E0")]
		get
		{
			return default(KGCPCEDNICE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal MAFDKMBBDLJ DMFIBNEMKNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x201EE50", Offset = "0x201D650", VA = "0x18201EE50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal HDOLDAMCNME GDJEIJCNANO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8FC280", Offset = "0x8FAA80", VA = "0x1808FC280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0F0", Offset = "0x8F98F0", VA = "0x1808FB0F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool FBEBNCKOPPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAEE830", Offset = "0xAED030", VA = "0x180AEE830")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC00620", Offset = "0xBFEE20", VA = "0x180C00620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CFMOHCPBEHC FNFAPBEGEIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7F0CD0", Offset = "0x7EF4D0", VA = "0x1807F0CD0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IPFCHCAJIKF CCEIAKBKAOH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7F39B0", Offset = "0x7F21B0", VA = "0x1807F39B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public NOHDHFCBIBG PAMDEBEPCPG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA0BDA0", Offset = "0xA0A5A0", VA = "0x180A0BDA0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public ONCJHPFAHMG OONKKIEFOML
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA52590", Offset = "0xA50D90", VA = "0x180A52590", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private PGMINICGNBB? JJEPLBHKAEM
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x201E560", Offset = "0x201CD60", VA = "0x18201E560", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private OEGGFMGBBEP? AMIPCAALIIG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x201FB80", Offset = "0x201E380", VA = "0x18201FB80", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x201FCB0", Offset = "0x201E4B0", VA = "0x18201FCB0")]
	private GILANFAFAJM(PEKNFFFIPLC KPIFGFBCKLO, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66FDA0", Offset = "0x66F1A0")] JIGIFEGHNPP<GCDMCLKLFED> LJCAAKGDCPF, DAMFPGIJKHM CPNEIHOCHMK, KGCPCEDNICE DGMEPFOJPGH, HDOLDAMCNME PBHLNILGHAP, in KAEGPHJIFMG.HKFLMGCDNKI MLKMPDOGDDI, KGCPCEDNICE.JHPCOAKHCCP GIFHBKCAFLM, NEAKMNNGOFF OKLGDLBKBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x201F960", Offset = "0x201E160", VA = "0x18201F960")]
	public static GILANFAFAJM NKAIHPJAMOL(PEKNFFFIPLC BPNALAJICIC, KGCPCEDNICE.KCCGBECPBBN HPHHKAEDOLI, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66FE00", Offset = "0x66F200")] JIGIFEGHNPP<GCDMCLKLFED> LJCAAKGDCPF, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66FEC0", Offset = "0x66F2C0")] JIGIFEGHNPP<DAIFGMDNPNG> DONOJDPOGHF, CELMKNFEGPN JCNAAEGICGN, PLAOCMMDMIG HOOHLNPIFJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x201F5F0", Offset = "0x201DDF0", VA = "0x18201F5F0")]
	public static GILANFAFAJM NKAIHPJAMOL(PEKNFFFIPLC KPIFGFBCKLO, in KGCPCEDNICE DGMEPFOJPGH, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66FF90", Offset = "0x66F390")] JIGIFEGHNPP<GCDMCLKLFED> LJCAAKGDCPF, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66FFF0", Offset = "0x66F3F0")] JIGIFEGHNPP<DAIFGMDNPNG> DONOJDPOGHF, CELMKNFEGPN JCNAAEGICGN, PLAOCMMDMIG HOOHLNPIFJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x201EC30", Offset = "0x201D430", VA = "0x18201EC30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x201E690", Offset = "0x201CE90", VA = "0x18201E690")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LHLFCFHMFOP))]
	internal Task<DLDMCIANGML<bool, KCPGGCLIGHK>> BHIAHHJOABE(INDICKEOBNO KKFNLGBAEPM, MCEGKBNFGBJ BHONCCCIJNM, PKMIHDKHPIO GGGHMACDDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x201EEA0", Offset = "0x201D6A0", VA = "0x18201EEA0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DPIPDKBNIDM))]
	public Task<DLDMCIANGML<bool, KCPGGCLIGHK>> EMGLAPGBMNO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x201F410", Offset = "0x201DC10", VA = "0x18201F410")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EDBIPBKCIOD))]
	public Task<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> JHBFJPDPKOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x201F150", Offset = "0x201D950", VA = "0x18201F150")]
	internal void HNJNACOJFMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x201F390", Offset = "0x201DB90", VA = "0x18201F390")]
	internal IEHOCFMJKHE<CIBICCNJBCB> IMDLBCAKNFK(in LOCAKMOCMEO HDPLEIMCCEL)
	{
		return default(IEHOCFMJKHE<CIBICCNJBCB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x201EBD0", Offset = "0x201D3D0", VA = "0x18201EBD0")]
	internal bool DEGMCPEKHBP(in LOCAKMOCMEO HDPLEIMCCEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x201F560", Offset = "0x201DD60", VA = "0x18201F560")]
	internal IEHOCFMJKHE<CIBICCNJBCB> LGJJFELBDFD(in OCLLBHJNOKO FBDBDFLPDGM)
	{
		return default(IEHOCFMJKHE<CIBICCNJBCB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x201FA10", Offset = "0x201E210", VA = "0x18201FA10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ONBKLPPGIAA))]
	internal Task<DLDMCIANGML<object, KCPGGCLIGHK>> OAHKEGAGCNL(CIBICCNJBCB COPPLLLOGLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x201E860", Offset = "0x201D060", VA = "0x18201E860")]
	private CIBICCNJBCB[] CKGNHACFAFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x201EFF0", Offset = "0x201D7F0", VA = "0x18201EFF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MGFFOBPBBCH))]
	public Task<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> FLAIADFIHDA(Guid POGNGLFPNDP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class IKCGCBLMCOJ<TData> : CFJKAHNEDBL, IGMNMEMCLHH, BBDACGBJONE where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670C40", Offset = "0x670040")]
	private readonly GKDFBGMIKKM<BHJBCAJLFJP>? ODBKKEPNFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly string LLPPEEKFHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly TData AHNOMKDBOML;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670DF0", Offset = "0x6701F0")]
	public GKDFBGMIKKM<BHJBCAJLFJP>? BAIOBEBMLBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x24A7A20", Offset = "0x24A6220", VA = "0x1824A7A20", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8A69F0", Offset = "0x8A51F0", VA = "0x1808A69F0", Slot = "7")]
	public override string MOHEBAOGHEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x24A7AC0", Offset = "0x24A62C0", VA = "0x1824A7AC0")]
	internal IKCGCBLMCOJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670D20", Offset = "0x670120")] in GKDFBGMIKKM<BHJBCAJLFJP>? ECJDGHLPLCL, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670D90", Offset = "0x670190")] JIGIFEGHNPP<BNDKBOKJBHP>? OAOEMHKMDBG, IOKind? OBBFLJFPPMF, string AKADEFDGONP, in TData NFBDMLCENEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class PNEGCPIALFG
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x20304A0", Offset = "0x202ECA0", VA = "0x1820304A0")]
	public static DLDMCIANGML<PFGINJDODDN, IGMNMEMCLHH> APHJLLICELJ(this in GECGAMHLOPE<ONGOFBANLBM> OHAMGBOHLHI)
	{
		return default(DLDMCIANGML<PFGINJDODDN, IGMNMEMCLHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x22FC400", Offset = "0x22FAC00", VA = "0x1822FC400")]
	public static DLDMCIANGML<TOk, IGMNMEMCLHH> CJANDIOOODK<TOk>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670E60", Offset = "0x670260")] this in DLDMCIANGML<TOk, IGMNMEMCLHH> PECDBPPMOJP, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670ED0", Offset = "0x6702D0")] in GKDFBGMIKKM<BHJBCAJLFJP>? ECJDGHLPLCL, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670F40", Offset = "0x670340")] JIGIFEGHNPP<BNDKBOKJBHP>? OAOEMHKMDBG, IOKind? OBBFLJFPPMF, string AKADEFDGONP) where TOk : notnull
	{
		return default(DLDMCIANGML<TOk, IGMNMEMCLHH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class JDPDIHBGOJC
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x111D5E0", Offset = "0x111BDE0", VA = "0x18111D5E0")]
	public static CMBIDCFHPND<(TPrev?, GILANFAFAJM?), OEGGFMGBBEP> CPCOLJAPCNL<TPrev>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670FE0", Offset = "0x6703E0")] this in CMBIDCFHPND<TPrev?, GILANFAFAJM?> PECDBPPMOJP)
	{
		return default(CMBIDCFHPND<(TPrev, GILANFAFAJM), OEGGFMGBBEP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x111D880", Offset = "0x111C080", VA = "0x18111D880")]
	public static CMBIDCFHPND<TPrev?, GILANFAFAJM?> ILHLDKOACAJ<TPrev>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671050", Offset = "0x670450")] this in CMBIDCFHPND<TPrev?, GILANFAFAJM?> PECDBPPMOJP)
	{
		return default(CMBIDCFHPND<TPrev, GILANFAFAJM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface PEKNFFFIPLC
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	AHPGBJHGGCL.BNDOMCLPFDE LPCKKDMPACK
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	PAPCPEKFGLB.COHJBFHKJIC PDBOCKHGHBE
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	GILANFAFAJM.MAFDKMBBDLJ DFBEIDCADGL
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	HFPPLEGGLFK.KPIJIOFCIOH ADGAOGMBDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	MBBIGIBBKAC.LEFMHIHNJNB<OMKODJJIJCE, CIBICCNJBCB, GILANFAFAJM> FBLIAEABADN
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	PBFEAEKKBFJ HCHGMJCABJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	IMEOIGKPJFM BGOCLIJOFGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	CKPFHKIEPCH HEHGACOMDEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	MEPEGPJDDLA LJDNBBKIAPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	NAFFONMJPBI FBFDLCNLMNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct EMHNJJDFHPL
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class PACGLAIEELK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671160", Offset = "0x670560")]
		public AsyncTaskMethodBuilder<DLDMCIANGML<JBNOLOHMHCO, KCPGGCLIGHK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public GILANFAFAJM root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public EMHNJJDFHPL self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6711C0", Offset = "0x6705C0")]
		private DLDMCIANGML<JBNOLOHMHCO, KCPGGCLIGHK> <r1>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671220", Offset = "0x670620")]
		private DLDMCIANGML<object, BBDACGBJONE>[] <aggregateResult>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671280", Offset = "0x670680")]
		private DLDMCIANGML<object, BBDACGBJONE> <r2>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6712E0", Offset = "0x6706E0")]
		private DLDMCIANGML<object, BBDACGBJONE>[] <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671340", Offset = "0x670740")]
		private DLDMCIANGML<object, KCPGGCLIGHK> <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6713A0", Offset = "0x6707A0")]
		private TaskAwaiter<DLDMCIANGML<object, KCPGGCLIGHK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public PACGLAIEELK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x202F970", Offset = "0x202E170", VA = "0x18202F970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly IReadOnlyList<CIBICCNJBCB> OHCHHHKCMFA;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x9E4D50", Offset = "0x9E3550", VA = "0x1809E4D50")]
	private EMHNJJDFHPL(IReadOnlyList<CIBICCNJBCB> JMIJOGDAJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2018F90", Offset = "0x2017790", VA = "0x182018F90")]
	public static CIBICCNJBCB EMCOGFDOAHI(IReadOnlyList<CIBICCNJBCB> JMIJOGDAJKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x20191D0", Offset = "0x20179D0", VA = "0x1820191D0")]
	public static PJOMKDKOOPO<OMKODJJIJCE, EMHNJJDFHPL> ONMGDFINOGO(CIBICCNJBCB DHLIACOLAOI)
	{
		return default(PJOMKDKOOPO<OMKODJJIJCE, EMHNJJDFHPL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2019060", Offset = "0x2017860", VA = "0x182019060")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PACGLAIEELK))]
	public static Task<DLDMCIANGML<JBNOLOHMHCO, KCPGGCLIGHK>> OAHKEGAGCNL(GILANFAFAJM CEABICNIABB, EMHNJJDFHPL PECDBPPMOJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class EJGHKKOJDNG
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2018D70", Offset = "0x2017570", VA = "0x182018D70")]
	public static CIBICCNJBCB AHLKKKIGNGO(this CIBICCNJBCB PECDBPPMOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2018E90", Offset = "0x2017690", VA = "0x182018E90")]
	public static CIBICCNJBCB JFAAJMIOAKH(this CPPIOGMICON PECDBPPMOJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct DGHIGNDCJON
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class FENHKCMLMJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6714F0", Offset = "0x6708F0")]
		public AsyncTaskMethodBuilder<DLDMCIANGML<GADODCKGMOI, DLCHKDEOFEA?>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public GILANFAFAJM root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public DGHIGNDCJON self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671550", Offset = "0x670950")]
		private DLDMCIANGML<GADODCKGMOI, DLCHKDEOFEA?> <r>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private bool <shouldDiscard>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public FENHKCMLMJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x20194E0", Offset = "0x2017CE0", VA = "0x1820194E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly INDICKEOBNO? HGNJHJKDGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly MCEGKBNFGBJ? KBEJJLAKJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly PKMIHDKHPIO? MIJFJKCFIED;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xD365D0", Offset = "0xD34DD0", VA = "0x180D365D0")]
	private DGHIGNDCJON(INDICKEOBNO? KKFNLGBAEPM, MCEGKBNFGBJ? BHONCCCIJNM, PKMIHDKHPIO? GGGHMACDDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2018390", Offset = "0x2016B90", VA = "0x182018390")]
	public static CIBICCNJBCB? EMCOGFDOAHI(INDICKEOBNO? KKFNLGBAEPM, MCEGKBNFGBJ? BHONCCCIJNM, PKMIHDKHPIO? GGGHMACDDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2018610", Offset = "0x2016E10", VA = "0x182018610")]
	public static PJOMKDKOOPO<OMKODJJIJCE, DGHIGNDCJON> ONMGDFINOGO(CIBICCNJBCB DHLIACOLAOI)
	{
		return default(PJOMKDKOOPO<OMKODJJIJCE, DGHIGNDCJON>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2018490", Offset = "0x2016C90", VA = "0x182018490")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FENHKCMLMJD))]
	public static Task<DLDMCIANGML<GADODCKGMOI, DLCHKDEOFEA>> OAHKEGAGCNL(GILANFAFAJM CEABICNIABB, DGHIGNDCJON PECDBPPMOJP)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct GOMEEKCBCGL
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2020030", Offset = "0x201E830", VA = "0x182020030")]
	public static CIBICCNJBCB EMCOGFDOAHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x20200D0", Offset = "0x201E8D0", VA = "0x1820200D0")]
	public static PJOMKDKOOPO<OMKODJJIJCE, GOMEEKCBCGL> ONMGDFINOGO(CIBICCNJBCB DHLIACOLAOI)
	{
		return default(PJOMKDKOOPO<OMKODJJIJCE, GOMEEKCBCGL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x201FFB0", Offset = "0x201E7B0", VA = "0x18201FFB0")]
	public static DLDMCIANGML<GADODCKGMOI, DLCHKDEOFEA> CCPPFNMIKFD(GILANFAFAJM CEABICNIABB, in GOMEEKCBCGL PECDBPPMOJP)
	{
		return default(DLDMCIANGML<GADODCKGMOI, DLCHKDEOFEA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct LOCAKMOCMEO
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class JBDOKEBELLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671660", Offset = "0x670A60")]
		public AsyncTaskMethodBuilder<DLDMCIANGML<bool, DLCHKDEOFEA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public GILANFAFAJM root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public LOCAKMOCMEO self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6716C0", Offset = "0x670AC0")]
		private DLDMCIANGML<bool, DLCHKDEOFEA> <r>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private bool <shouldDiscard>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private CIBICCNJBCB <value>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671720", Offset = "0x670B20")]
		private TaskAwaiter<DLDMCIANGML<GADODCKGMOI, DLCHKDEOFEA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public JBDOKEBELLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2022CE0", Offset = "0x20214E0", VA = "0x182022CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly int GKGAEPJBJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int JNDMMPHMODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly byte[] AHNOMKDBOML;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0xBCEF60", Offset = "0xBCD760", VA = "0x180BCEF60")]
	private LOCAKMOCMEO(int JMKNAPEFDDB, int AMOEKOMGDLG, byte[] NFBDMLCENEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2025090", Offset = "0x2023890", VA = "0x182025090")]
	public static CIBICCNJBCB EMCOGFDOAHI(int JMKNAPEFDDB, int AMOEKOMGDLG, ByteString NFBDMLCENEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2025420", Offset = "0x2023C20", VA = "0x182025420")]
	public static CIBICCNJBCB?[]? PLFJOGMNHCP(int DACBEJHBOIP, INDICKEOBNO? KKFNLGBAEPM, MCEGKBNFGBJ? BHONCCCIJNM, PKMIHDKHPIO? GGGHMACDDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2025300", Offset = "0x2023B00", VA = "0x182025300")]
	public static PJOMKDKOOPO<OMKODJJIJCE, LOCAKMOCMEO> ONMGDFINOGO(CIBICCNJBCB DHLIACOLAOI)
	{
		return default(PJOMKDKOOPO<OMKODJJIJCE, LOCAKMOCMEO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2025190", Offset = "0x2023990", VA = "0x182025190")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JBDOKEBELLB))]
	public static Task<DLDMCIANGML<bool, DLCHKDEOFEA>> OAHKEGAGCNL(GILANFAFAJM CEABICNIABB, LOCAKMOCMEO PECDBPPMOJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct CPPIOGMICON
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class AEJPDCBNBFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671820", Offset = "0x670C20")]
		public AsyncTaskMethodBuilder<DLDMCIANGML<object, KCPGGCLIGHK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public GILANFAFAJM root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public CPPIOGMICON self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671880", Offset = "0x670C80")]
		private DLDMCIANGML<object, KCPGGCLIGHK> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6718E0", Offset = "0x670CE0")]
		private TaskAwaiter<DLDMCIANGML<object, KCPGGCLIGHK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public AEJPDCBNBFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2015670", Offset = "0x2013E70", VA = "0x182015670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly ByteString PGHJLABHLGJ;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x9E4D50", Offset = "0x9E3550", VA = "0x1809E4D50")]
	private CPPIOGMICON(ByteString MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2017A20", Offset = "0x2016220", VA = "0x182017A20")]
	public static CIBICCNJBCB EMCOGFDOAHI(ByteString MENBIMCLIOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2017C50", Offset = "0x2016450", VA = "0x182017C50")]
	public static PJOMKDKOOPO<OMKODJJIJCE, CPPIOGMICON> ONMGDFINOGO(CIBICCNJBCB DHLIACOLAOI)
	{
		return default(PJOMKDKOOPO<OMKODJJIJCE, CPPIOGMICON>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2017AE0", Offset = "0x20162E0", VA = "0x182017AE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AEJPDCBNBFC))]
	public static Task<DLDMCIANGML<object, KCPGGCLIGHK>> OAHKEGAGCNL(GILANFAFAJM CEABICNIABB, CPPIOGMICON PECDBPPMOJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct OCLLBHJNOKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly int GKGAEPJBJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly int JNDMMPHMODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public readonly byte[] AHNOMKDBOML;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xBCEF60", Offset = "0xBCD760", VA = "0x180BCEF60")]
	private OCLLBHJNOKO(int JMKNAPEFDDB, int AMOEKOMGDLG, byte[] NFBDMLCENEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2029900", Offset = "0x2028100", VA = "0x182029900")]
	public static CIBICCNJBCB EMCOGFDOAHI(int JMKNAPEFDDB, int AMOEKOMGDLG, ByteString NFBDMLCENEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2029690", Offset = "0x2027E90", VA = "0x182029690")]
	public static CIBICCNJBCB[] CAIIMPIFBLI(CIBICCNJBCB COPPLLLOGLG, int DACBEJHBOIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2029A00", Offset = "0x2028200", VA = "0x182029A00")]
	public static PJOMKDKOOPO<OMKODJJIJCE, OCLLBHJNOKO> ONMGDFINOGO(CIBICCNJBCB DHLIACOLAOI)
	{
		return default(PJOMKDKOOPO<OMKODJJIJCE, OCLLBHJNOKO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x20297E0", Offset = "0x2027FE0", VA = "0x1820297E0")]
	public static DLDMCIANGML<CIBICCNJBCB, DLCHKDEOFEA> CCPPFNMIKFD(GILANFAFAJM CEABICNIABB, in OCLLBHJNOKO PECDBPPMOJP)
	{
		return default(DLDMCIANGML<CIBICCNJBCB, DLCHKDEOFEA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface BBELJOLPEOI
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	string EHNKIECOKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NDNGLPKGOBB? JAHDHCBHDIE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671940", Offset = "0x670D40")] JIGIFEGHNPP<MGCIEENFDNB?> MAJGNMADALN);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HHMOBECEEMB? IANOLGBBHKB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6719A0", Offset = "0x670DA0")] JIGIFEGHNPP<DFLJDHCNLJI?> JMGMPHDCILN);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface HHMOBECEEMB
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	string EHNKIECOKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface PBFEAEKKBFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JGHFJBLFGDP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671A00", Offset = "0x670E00")] in DLDMCIANGML<GADODCKGMOI, BBDACGBJONE> LACIMGIMLFK);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class LHAFGEFCHIL
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1DACEC0", Offset = "0x1DAB6C0", VA = "0x181DACEC0")]
	public static bool JGHFJBLFGDP<TOk, TErr>(this PBFEAEKKBFJ PECDBPPMOJP, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671A70", Offset = "0x670E70")] in DLDMCIANGML<TOk, TErr> LACIMGIMLFK) where TOk : notnull where TErr : notnull, BBDACGBJONE
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface MEPEGPJDDLA
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> APMNILJDHGG(string MENBIMCLIOI, string HNBDDLBIIOF);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface NAFFONMJPBI
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "0")]
	COPCFKLKDHE? AJEFPIFNGHN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671AE0", Offset = "0x670EE0")] in GKDFBGMIKKM<PPONKCOFGNF?> IBIJNIEJBJJ);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface NDNGLPKGOBB
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	string EHNKIECOKGD
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface IMEOIGKPJFM
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	BDOFNACKDNG MNKHILOEAAN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface COPCFKLKDHE
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BBELJOLPEOI? IFKHCCEHHLP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671B50", Offset = "0x670F50")] JIGIFEGHNPP<MEKIJODJIIO?> JCELOBPNEDG);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface CKPFHKIEPCH
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	APPACPHBIIO BOLPHAFFFBD(int JOGKLMKACMD);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class CFJGHGPBIKD
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private struct AJKOAKIIBGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int JNDMMPHMODJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public MCEGKBNFGBJ? NGODIMKGDKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public MCEGKBNFGBJ? FNJBHBCLDKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public readonly List<CIBICCNJBCB> OHCHHHKCMFA;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2015CC0", Offset = "0x20144C0", VA = "0x182015CC0")]
		private AJKOAKIIBGB(int AMOEKOMGDLG, MCEGKBNFGBJ? FNHCEBFICKE, MCEGKBNFGBJ? NJALGAHDDCF, List<CIBICCNJBCB> JMIJOGDAJKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2015C10", Offset = "0x2014410", VA = "0x182015C10")]
		public static AJKOAKIIBGB NKAIHPJAMOL()
		{
			return default(AJKOAKIIBGB);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private int PBPHKHFDBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly HKGMBAPMCNL<AJKOAKIIBGB> KHFIJBIFFBK;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static CFJGHGPBIKD OEFAOPMNMGM
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2016E30", Offset = "0x2015630", VA = "0x182016E30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool KKBJJIDLFDM
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x97D920", Offset = "0x97C120", VA = "0x18097D920")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x97D930", Offset = "0x97C130", VA = "0x18097D930")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2016D50", Offset = "0x2015550", VA = "0x182016D50")]
	public void FPECHEPBFDF(KAEGPHJIFMG NJALGAHDDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2016A40", Offset = "0x2015240", VA = "0x182016A40")]
	public void ENIGBEHHMNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2016E90", Offset = "0x2015690", VA = "0x182016E90")]
	private static string? NPLPKFMIFED(in AJKOAKIIBGB OHKPBFPMBDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2017340", Offset = "0x2015B40", VA = "0x182017340")]
	public CFJGHGPBIKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class NMFAOHENEAK : CFMOHCPBEHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly GILANFAFAJM GJALPMNMBCB;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public BGJKBHGMKHG? OEFAOPMNMGM
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x20294B0", Offset = "0x2027CB0", VA = "0x1820294B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8BA230", Offset = "0x8B8A30", VA = "0x1808BA230")]
	internal NMFAOHENEAK(GILANFAFAJM EDJAAIKGPBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class IIDEFNKIDFO : KMBJICBPCON, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly NADNAKENHPO NIOOMDIIMPO;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public NADNAKENHPO ONDCBOHIOGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7DF170", Offset = "0x7DD970", VA = "0x1807DF170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8BA230", Offset = "0x8B8A30", VA = "0x1808BA230")]
	private IIDEFNKIDFO(NADNAKENHPO AHCKLEOBMDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2020C90", Offset = "0x201F490", VA = "0x182020C90")]
	public static IIDEFNKIDFO KLHPMPNNHAA(GILANFAFAJM EDJAAIKGPBN, INDICKEOBNO FAMFGECHFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2020C70", Offset = "0x201F470", VA = "0x182020C70", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class FIHLLMBOGGN : ABFKNOKEKPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly HDPBOFJILOB MPCPGABGLGK;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static readonly HashSet<HDPBOFJILOB> INHOBIHHHCC;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly HashSet<HDPBOFJILOB> CBGINBLDAHO;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly HashSet<HDPBOFJILOB> FEDHEFAJPKK;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public TypeKey ADLHPEIHCMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x201C3E0", Offset = "0x201ABE0", VA = "0x18201C3E0", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool NAGMFCFGKPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x201C3D0", Offset = "0x201ABD0", VA = "0x18201C3D0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool AKLKMFAPHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x201C440", Offset = "0x201AC40", VA = "0x18201C440", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool GJHMMLPCHNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x201C340", Offset = "0x201AB40", VA = "0x18201C340", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x201B000", Offset = "0x2019800", VA = "0x18201B000")]
	public bool GKFFIOHEPOP(string MENBIMCLIOI, out MJEMGCCGKGC MMAFINKHIGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8BA230", Offset = "0x8B8A30", VA = "0x1808BA230")]
	public FIHLLMBOGGN(HDPBOFJILOB PBDNMEDOHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x201AE70", Offset = "0x2019670", VA = "0x18201AE70")]
	internal static TypeKey DLCFBMEEBHF(HDPBOFJILOB EIOLDDJPDLH)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x201B2D0", Offset = "0x2019AD0", VA = "0x18201B2D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class CKHHOHLHFHP
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671BF0", Offset = "0x670FF0")]
	private sealed class EKBGGFOENGE : DJPFAPHJALC<DOJJHKNCOOE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override NodeVisualizationKey ADLHPEIHCMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xAAEC30", Offset = "0xAAD430", VA = "0x180AAEC30", Slot = "77")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x2018F30", Offset = "0x2017730", VA = "0x182018F30")]
		public EKBGGFOENGE(GILANFAFAJM EDJAAIKGPBN, DOJJHKNCOOE LJMPFLMBPKN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671C50", Offset = "0x671050")]
	private abstract class GOEPPOEFNBM<TNode> : DJPFAPHJALC<TNode> where TNode : notnull, OENAGMNNKIK
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class BKJNCLGLFKG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671FE0", Offset = "0x6713E0")]
			public AsyncTaskMethodBuilder<DLDMCIANGML<JIGIFEGHNPP<MEKIJODJIIO>, KCPGGCLIGHK>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public GOEPPOEFNBM<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			private DLDMCIANGML<JIGIFEGHNPP<MEKIJODJIIO>, KCPGGCLIGHK> <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private TaskAwaiter<DLDMCIANGML<JIGIFEGHNPP<MEKIJODJIIO>, KCPGGCLIGHK>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
			public BKJNCLGLFKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x219E120", Offset = "0x219C920", VA = "0x18219E120", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class JJBBPDGJKKH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672040", Offset = "0x671440")]
			public AsyncTaskMethodBuilder<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6720A0", Offset = "0x6714A0")]
			public JIGIFEGHNPP<MEKIJODJIIO> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public GOEPPOEFNBM<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK> <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private TaskAwaiter<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
			public JJBBPDGJKKH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x2C54190", Offset = "0x2C52990", VA = "0x182C54190", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671F10", Offset = "0x671310")]
		public override GKDFBGMIKKM<NEABDLEHKAA>? LIJKMDLOHJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x2789E90", Offset = "0x2788690", VA = "0x182789E90", Slot = "101")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671F80", Offset = "0x671380")]
		public override JIGIFEGHNPP<MEKIJODJIIO>? KABCOGNLBFB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x41E1780", Offset = "0x41DFF80", VA = "0x1841E1780", Slot = "105")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x21FA990", Offset = "0x21F9190", VA = "0x1821FA990")]
		public GOEPPOEFNBM(GILANFAFAJM EDJAAIKGPBN, TNode LJMPFLMBPKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x41E1270", Offset = "0x41DFA70", VA = "0x1841E1270", Slot = "86")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(GOEPPOEFNBM<>.BKJNCLGLFKG))]
		public override Task<DLDMCIANGML<JIGIFEGHNPP<MEKIJODJIIO>, KCPGGCLIGHK>> BBAALLGDFAC(string MDOAADHDBMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x41E1410", Offset = "0x41DFC10", VA = "0x1841E1410", Slot = "107")]
		public sealed override bool FBJFAJJNNNN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671D20", Offset = "0x671120")] JIGIFEGHNPP<MEKIJODJIIO> JCELOBPNEDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x41E16E0", Offset = "0x41DFEE0", VA = "0x1841E16E0", Slot = "98")]
		protected sealed override bool OOINFGPLHHE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671D80", Offset = "0x671180")] JIGIFEGHNPP<MEKIJODJIIO> JCELOBPNEDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x41E1640", Offset = "0x41DFE40", VA = "0x1841E1640", Slot = "99")]
		protected override bool LDGIPBFHNKM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671DE0", Offset = "0x6711E0")] JIGIFEGHNPP<MEKIJODJIIO> JCELOBPNEDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x41E14B0", Offset = "0x41DFCB0", VA = "0x1841E14B0", Slot = "87")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(GOEPPOEFNBM<>.JJBBPDGJKKH))]
		public override Task<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> HKCLGBJKBCI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671EB0", Offset = "0x6712B0")] JIGIFEGHNPP<MEKIJODJIIO> JCELOBPNEDG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672100", Offset = "0x671500")]
	private sealed class NPEBHELEBJL : DJPFAPHJALC<GDFADAGCGGB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override NodeVisualizationKey ADLHPEIHCMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x94E5A0", Offset = "0x94CDA0", VA = "0x18094E5A0", Slot = "77")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x20295A0", Offset = "0x2027DA0", VA = "0x1820295A0")]
		public NPEBHELEBJL(GILANFAFAJM EDJAAIKGPBN, GDFADAGCGGB LJMPFLMBPKN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672160", Offset = "0x671560")]
	private sealed class LEHNJJHAFOE : DJPFAPHJALC<CEEBCHMJIDL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override NodeVisualizationKey ADLHPEIHCMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xC77D80", Offset = "0xC76580", VA = "0x180C77D80", Slot = "77")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x20237C0", Offset = "0x2021FC0", VA = "0x1820237C0")]
		public LEHNJJHAFOE(GILANFAFAJM EDJAAIKGPBN, CEEBCHMJIDL LJMPFLMBPKN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6721C0", Offset = "0x6715C0")]
	private sealed class MDLPOFFGAON : GOEPPOEFNBM<EPOKEIBEBOP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override bool LBDJBGAKNFD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x7EE860", Offset = "0x7ED060", VA = "0x1807EE860", Slot = "79")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override NodeVisualizationKey ADLHPEIHCMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x91DB20", Offset = "0x91C320", VA = "0x18091DB20", Slot = "77")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2025630", Offset = "0x2023E30", VA = "0x182025630")]
		public MDLPOFFGAON(GILANFAFAJM EDJAAIKGPBN, EPOKEIBEBOP LJMPFLMBPKN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672220", Offset = "0x671620")]
	private sealed class CCLIJDOIFMM : DJPFAPHJALC<EGKNBAILGOB>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override NodeVisualizationKey ADLHPEIHCMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xE36B40", Offset = "0xE35340", VA = "0x180E36B40", Slot = "77")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x20169E0", Offset = "0x20151E0", VA = "0x1820169E0")]
		public CCLIJDOIFMM(GILANFAFAJM EDJAAIKGPBN, EGKNBAILGOB LJMPFLMBPKN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672280", Offset = "0x671680")]
	private sealed class KMBCNMBHPKC : OGCFLHDHJHB<CCOKNNGJCLA>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override NodeVisualizationKey ADLHPEIHCMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x7E1570", Offset = "0x7DFD70", VA = "0x1807E1570", Slot = "77")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2023760", Offset = "0x2021F60", VA = "0x182023760")]
		public KMBCNMBHPKC(GILANFAFAJM EDJAAIKGPBN, CCOKNNGJCLA LJMPFLMBPKN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class DJPFAPHJALC<TNode> : ALDKPKNIDDP, IDisposable where TNode : notnull, BKFPHCKALON
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class LBOHCNPGJAD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public DJPFAPHJALC<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public GILANFAFAJM circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
			public LBOHCNPGJAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x24D1720", Offset = "0x24CFF20", VA = "0x1824D1720")]
			internal OFHGNAHJOPO MIHJNCOGKOK(MCFFNFPLKCM portGroup, int index)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class FGBKNLGDIND : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673490", Offset = "0x672890")]
			public AsyncTaskMethodBuilder<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public DJPFAPHJALC<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK> <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			private TaskAwaiter<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
			public FGBKNLGDIND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x348FA90", Offset = "0x348E290", VA = "0x18348FA90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private GILANFAFAJM GJALPMNMBCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6722E0", Offset = "0x6716E0")]
		private MMFKEOMPKBP<MEKIJODJIIO, OFHGNAHJOPO> GEPKODACBHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672340", Offset = "0x671740")]
		private MMFKEOMPKBP<MEKIJODJIIO, EJLBLHEPNCC> OHHKDFPLGNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672660", Offset = "0x671A60")]
		private Action<JIGIFEGHNPP<MEKIJODJIIO>> EOJJOCJNJAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6726E0", Offset = "0x671AE0")]
		private Action<JIGIFEGHNPP<MEKIJODJIIO>, EJLBLHEPNCC> JCDKPFLJPGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[CompilerGenerated]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6727E0", Offset = "0x671BE0")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<JIGIFEGHNPP<MEKIJODJIIO>, JIGIFEGHNPP<MEKIJODJIIO>> JGMLMHIFHPG;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected TNode FLACIKEBOKD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x8A5F80", Offset = "0x8A4780", VA = "0x1808A5F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public object JCLOAFMPDNI
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x1792D60", Offset = "0x1791560", VA = "0x181792D60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public virtual bool JIGBLJANHOF
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x7EE860", Offset = "0x7ED060", VA = "0x1807EE860", Slot = "75")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int NJNDBMKLJIN
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x2CB7A40", Offset = "0x2CB6240", VA = "0x182CB7A40", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public APPACPHBIIO HOGGHMFHEMF
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x2CB7A00", Offset = "0x2CB6200", VA = "0x182CB7A00", Slot = "8")]
			get
			{
				return default(APPACPHBIIO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public virtual NodeVisualizationKey ADLHPEIHCMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x893100", Offset = "0x891900", VA = "0x180893100", Slot = "77")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672F80", Offset = "0x672380")]
		public JIGIFEGHNPP<JFGIFFMMNDO> AGPAOGJNGPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x8E8B70", Offset = "0x8E7370", VA = "0x1808E8B70", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(JIGIFEGHNPP<JFGIFFMMNDO>);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xBBF230", Offset = "0xBBDA30", VA = "0x180BBF230")]
			[CompilerGenerated]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6728C0", Offset = "0x671CC0")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public virtual bool PLOFBNAPHNK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "78")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public virtual bool LBDJBGAKNFD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "79")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public virtual bool MPLLGDLEGIE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool EOMGPNGHBKE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x2CB7880", Offset = "0x2CB6080", VA = "0x182CB7880", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool NIIMKFEHCNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x2CB78C0", Offset = "0x2CB60C0", VA = "0x182CB78C0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool FDANLDHHKGG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x2CB7900", Offset = "0x2CB6100", VA = "0x182CB7900", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int CABDFCPMNDG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x2CB7C70", Offset = "0x2CB6470", VA = "0x182CB7C70", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool ADFNOAEMJLO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x2CB7BB0", Offset = "0x2CB63B0", VA = "0x182CB7BB0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public string OHPNGKKMEJH
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x2CB7AE0", Offset = "0x2CB62E0", VA = "0x182CB7AE0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool IIFMAHFOKDB
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x2CB7980", Offset = "0x2CB6180", VA = "0x182CB7980", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool LJAEONKJJOP
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xDCCFE0", Offset = "0xDCB7E0", VA = "0x180DCCFE0", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xDCD110", Offset = "0xDCB910", VA = "0x180DCD110")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public virtual bool GFABOKJMHBA
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "81")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public virtual bool NKACNBFCAPE
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x2CB7940", Offset = "0x2CB6140", VA = "0x182CB7940", Slot = "82")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool KICKFIILIDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x2CB7B20", Offset = "0x2CB6320", VA = "0x182CB7B20", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public JOHDMLNNNLC NKFGMFOLDDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x2CB7BF0", Offset = "0x2CB63F0", VA = "0x182CB7BF0", Slot = "24")]
			get
			{
				return default(JOHDMLNNNLC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public IOEJAOKEBMJ FBEABAEGHCD
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x2CB7C30", Offset = "0x2CB6430", VA = "0x182CB7C30", Slot = "26")]
			get
			{
				return default(IOEJAOKEBMJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public virtual bool LKHAAEFOAID
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public virtual DGJMGPIBBII? FPCOLLCBJPG
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x893100", Offset = "0x891900", VA = "0x180893100", Slot = "94")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public virtual HNCIKDBJOJH? LGGGOHONOOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x893100", Offset = "0x891900", VA = "0x180893100", Slot = "95")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672FE0", Offset = "0x6723E0")]
		public virtual IEnumerable<BKFPHCKALON> NBPGECHMDNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x893100", Offset = "0x891900", VA = "0x180893100", Slot = "96")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool HIKOOKAOAGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x2CB79C0", Offset = "0x2CB61C0", VA = "0x182CB79C0", Slot = "48")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673040", Offset = "0x672440")]
		public GKDFBGMIKKM<NEABDLEHKAA> NACHHCKGAFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x2CB7A70", Offset = "0x2CB6270", VA = "0x182CB7A70", Slot = "49")]
			get
			{
				return default(GKDFBGMIKKM<NEABDLEHKAA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public virtual bool FDICMDJCOAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "100")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6730B0", Offset = "0x6724B0")]
		public virtual GKDFBGMIKKM<NEABDLEHKAA>? LIJKMDLOHJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x2CB7AB0", Offset = "0x2CB62B0", VA = "0x182CB7AB0", Slot = "101")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public bool LEFHNKIAJGG
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x2CB7B60", Offset = "0x2CB6360", VA = "0x182CB7B60", Slot = "53")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual string EHNKIECOKGD
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x8A9EE0", Offset = "0x8A86E0", VA = "0x1808A9EE0", Slot = "102")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x8A9EF0", Offset = "0x8A86F0", VA = "0x1808A9EF0", Slot = "103")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673120", Offset = "0x672520")]
		public GKDFBGMIKKM<BHJBCAJLFJP> CHECEAIAHJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x2CB7CA0", Offset = "0x2CB64A0", VA = "0x182CB7CA0", Slot = "54")]
			get
			{
				return default(GKDFBGMIKKM<BHJBCAJLFJP>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673190", Offset = "0x672590")]
		public GKDFBGMIKKM<BHJBCAJLFJP>? KBCEDDIOJMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x2CB7CE0", Offset = "0x2CB64E0", VA = "0x182CB7CE0", Slot = "104")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6731F0", Offset = "0x6725F0")]
		public BHOOABHAPCP<MEKIJODJIIO, EJLBLHEPNCC> GIMGENFFGPP
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x2CB7DC0", Offset = "0x2CB65C0", VA = "0x182CB7DC0", Slot = "56")]
			get
			{
				return default(BHOOABHAPCP<MEKIJODJIIO, EJLBLHEPNCC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673250", Offset = "0x672650")]
		public virtual JIGIFEGHNPP<MEKIJODJIIO>? KABCOGNLBFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x893100", Offset = "0x891900", VA = "0x180893100", Slot = "105")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action DEEJJICAANN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x2CB6FC0", Offset = "0x2CB57C0", VA = "0x182CB6FC0", Slot = "31")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x2CB4650", Offset = "0x2CB2E50", VA = "0x182CB4650", Slot = "32")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event KBEFBFEKCKC CAINOCFDBBF
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x2CB7280", Offset = "0x2CB5A80", VA = "0x182CB7280", Slot = "33")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x2CB6F10", Offset = "0x2CB5710", VA = "0x182CB6F10", Slot = "34")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event KMFLNCBHPDK NHFJPIKFPFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x2CB64C0", Offset = "0x2CB4CC0", VA = "0x182CB64C0", Slot = "35")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x2CB6320", Offset = "0x2CB4B20", VA = "0x182CB6320", Slot = "36")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action JIPJNKODPJP
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x2CB6CF0", Offset = "0x2CB54F0", VA = "0x182CB6CF0", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x2CB7120", Offset = "0x2CB5920", VA = "0x182CB7120", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action DJHCEFLLNIB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x2CB6B00", Offset = "0x2CB5300", VA = "0x182CB6B00", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x2CB6BB0", Offset = "0x2CB53B0", VA = "0x182CB6BB0", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<JIGIFEGHNPP<MEKIJODJIIO>, EJLBLHEPNCC> NAPDMELMLNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x2CB6410", Offset = "0x2CB4C10", VA = "0x182CB6410", Slot = "58")]
			[CompilerGenerated]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672B00", Offset = "0x671F00")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x2CB6820", Offset = "0x2CB5020", VA = "0x182CB6820", Slot = "59")]
			[CompilerGenerated]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672B60", Offset = "0x671F60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<JIGIFEGHNPP<MEKIJODJIIO>, EJLBLHEPNCC> NDHOKPMNOOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x2CB7070", Offset = "0x2CB5870", VA = "0x182CB7070", Slot = "62")]
			[CompilerGenerated]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672BC0", Offset = "0x671FC0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x2CB7440", Offset = "0x2CB5C40", VA = "0x182CB7440", Slot = "63")]
			[CompilerGenerated]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672C20", Offset = "0x672020")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<JIGIFEGHNPP<MEKIJODJIIO>> GIOLNBPIHKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x2CB4D80", Offset = "0x2CB3580", VA = "0x182CB4D80", Slot = "60")]
			[CompilerGenerated]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672C80", Offset = "0x672080")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x2CB5E80", Offset = "0x2CB4680", VA = "0x182CB5E80", Slot = "61")]
			[CompilerGenerated]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672CE0", Offset = "0x6720E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<JIGIFEGHNPP<MEKIJODJIIO>, JIGIFEGHNPP<MEKIJODJIIO>> GLBGDFENEFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x2CB74F0", Offset = "0x2CB5CF0", VA = "0x182CB74F0", Slot = "64")]
			[CompilerGenerated]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672D40", Offset = "0x672140")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x2CB68D0", Offset = "0x2CB50D0", VA = "0x182CB68D0", Slot = "65")]
			[CompilerGenerated]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672DA0", Offset = "0x6721A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<JIGIFEGHNPP<MEKIJODJIIO>, EJLBLHEPNCC> HGDFNIELLNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x2CB4740", Offset = "0x2CB2F40", VA = "0x182CB4740", Slot = "66")]
			[CompilerGenerated]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672E00", Offset = "0x672200")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x2CB6A50", Offset = "0x2CB5250", VA = "0x182CB6A50", Slot = "67")]
			[CompilerGenerated]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672E60", Offset = "0x672260")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2CB75E0", Offset = "0x2CB5DE0", VA = "0x182CB75E0")]
		[MHJPGPDBDDN("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		[MHJPGPDBDDN("Need to handle `Name` better.")]
		public DJPFAPHJALC(GILANFAFAJM EDJAAIKGPBN, TNode LJMPFLMBPKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2CB3EC0", Offset = "0x2CB26C0", VA = "0x182CB3EC0", Slot = "73")]
		protected virtual void BDCEDMLOOPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4E30", Offset = "0x2CB3630", VA = "0x182CB4E30", Slot = "74")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2CB75A0", Offset = "0x2CB5DA0", VA = "0x182CB75A0", Slot = "76")]
		public virtual void PJECAPAIAGH(int ABHPADJOEGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6A00", Offset = "0x2CB5200", VA = "0x182CB6A00")]
		public bool KFDLIJACOBF(in JOHDMLNNNLC MENBIMCLIOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6980", Offset = "0x2CB5180", VA = "0x182CB6980")]
		public bool KBGOAGBBAAK(in IOEJAOKEBMJ MENBIMCLIOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2CB47F0", Offset = "0x2CB2FF0", VA = "0x182CB47F0", Slot = "83")]
		public virtual void CKDPOLDCCLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "84")]
		public virtual void CLMEBCBAPBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "85")]
		public virtual void JADJCIAPCAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8A4520", Offset = "0x8A2D20", VA = "0x1808A4520")]
		protected void CJNKNKGOHLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9083C0", Offset = "0x906BC0", VA = "0x1809083C0")]
		protected void IFLOOLPKHOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6800", Offset = "0x2CB5000", VA = "0x182CB6800")]
		private void JIFIMPPMLDJ(in IOEJAOKEBMJ APAHFEOKBOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2CB3DD0", Offset = "0x2CB25D0", VA = "0x182CB3DD0", Slot = "86")]
		public virtual Task<DLDMCIANGML<JIGIFEGHNPP<MEKIJODJIIO>, KCPGGCLIGHK>> BBAALLGDFAC(string MDOAADHDBMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6570", Offset = "0x2CB4D70", VA = "0x182CB6570", Slot = "87")]
		public virtual Task<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> HKCLGBJKBCI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672920", Offset = "0x671D20")] JIGIFEGHNPP<MEKIJODJIIO> JCELOBPNEDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2CB63D0", Offset = "0x2CB4BD0", VA = "0x182CB63D0", Slot = "88")]
		public virtual void GOICONLCIFP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672980", Offset = "0x671D80")] JIGIFEGHNPP<MEKIJODJIIO> AMOEKOMGDLG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6729E0", Offset = "0x671DE0")] JIGIFEGHNPP<MEKIJODJIIO> BEELAINJGPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2CB3D10", Offset = "0x2CB2510", VA = "0x182CB3D10", Slot = "89")]
		public virtual IEnumerable<CIBICCNJBCB> AOOGPKEAMIB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2CB7210", Offset = "0x2CB5A10", VA = "0x182CB7210", Slot = "41")]
		public DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK> OHHPPOPDELK(string DMLGLOOFFOG)
		{
			return default(DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2CB5500", Offset = "0x2CB3D00", VA = "0x182CB5500", Slot = "42")]
		public bool ECLDBOLNNMC(out Guid AFHPIAFJGIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4700", Offset = "0x2CB2F00", VA = "0x182CB4700", Slot = "90")]
		public virtual bool CEMAIFIGKFN(in Guid IBOAMBHJEOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2CB71D0", Offset = "0x2CB59D0", VA = "0x182CB71D0", Slot = "91")]
		public virtual void OGPDBFFONOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "92")]
		public virtual void MKHDDIDADIM(bool CDDDBHJPPFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2CB7360", Offset = "0x2CB5B60", VA = "0x182CB7360")]
		protected void PBKFMHMEEAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "97")]
		protected virtual void PGGKFIMBEAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2CB7330", Offset = "0x2CB5B30", VA = "0x182CB7330", Slot = "98")]
		protected virtual bool OOINFGPLHHE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672A40", Offset = "0x671E40")] JIGIFEGHNPP<MEKIJODJIIO> JCELOBPNEDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "99")]
		protected virtual bool LDGIPBFHNKM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672AA0", Offset = "0x671EA0")] JIGIFEGHNPP<MEKIJODJIIO> JCELOBPNEDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "106")]
		public virtual void PKCDEANJGJP(PJJEICCLACM CCIGHOFOEJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2CB3C50", Offset = "0x2CB2450", VA = "0x182CB3C50", Slot = "69")]
		public NBGMGGOIOJB AGFPJCDKJJO()
		{
			return default(NBGMGGOIOJB);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "107")]
		public virtual bool FBJFAJJNNNN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672EC0", Offset = "0x6722C0")] JIGIFEGHNPP<MEKIJODJIIO> JCELOBPNEDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4D60", Offset = "0x2CB3560", VA = "0x182CB4D60")]
		private void DDNNHEFMBAG(in JOHDMLNNNLC PAOMABBDKAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6DA0", Offset = "0x2CB55A0", VA = "0x182CB6DA0")]
		private void LPIPCNDKFND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2CB5740", Offset = "0x2CB3F40", VA = "0x182CB5740")]
		private void EJJPJEDEFHF(int JNICNFKMPBI, MCFFNFPLKCM FEPHIIFNOJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6C60", Offset = "0x2CB5460", VA = "0x182CB6C60")]
		private void LNNPDGLFKCM(int AMOEKOMGDLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4470", Offset = "0x2CB2C70", VA = "0x182CB4470")]
		private void CBNOKLABEFJ(int AMOEKOMGDLG, MCFFNFPLKCM PBGLEJHCJMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2CB5F30", Offset = "0x2CB4730", VA = "0x182CB5F30")]
		private void FMCLNMOKFAC(int MADLOICHEAO, int CGKGGOHJOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2CB5680", Offset = "0x2CB3E80", VA = "0x182CB5680")]
		private void EEINFFBMLLM(int MADLOICHEAO, int CGKGGOHJOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2CB5DF0", Offset = "0x2CB45F0", VA = "0x182CB5DF0")]
		private void ENBILMPKCGI(int AMOEKOMGDLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4830", Offset = "0x2CB3030", VA = "0x182CB4830")]
		private void DBKAFNHJHKL(int JNICNFKMPBI, MCFFNFPLKCM FEPHIIFNOJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6E60", Offset = "0x2CB5660", VA = "0x182CB6E60")]
		private void MDAAEIOKGOI(int AMOEKOMGDLG, MCFFNFPLKCM PBGLEJHCJMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6660", Offset = "0x2CB4E60", VA = "0x182CB6660", Slot = "108")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(DJPFAPHJALC<>.FGBKNLGDIND))]
		public virtual Task<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> JHAGLOLMINM(string DMLGLOOFFOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2CB69D0", Offset = "0x2CB51D0", VA = "0x182CB69D0", Slot = "25")]
		private bool KDHMEEEAOKL(in JOHDMLNNNLC MENBIMCLIOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2836010", Offset = "0x2834810", VA = "0x182836010", Slot = "27")]
		private bool IIBFLOJNPGG(in IOEJAOKEBMJ MENBIMCLIOI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6734F0", Offset = "0x6728F0")]
	private sealed class PHIOGJNIDAO : DJPFAPHJALC<AIGFILHFAIG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public override NodeVisualizationKey ADLHPEIHCMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x892A20", Offset = "0x891220", VA = "0x180892A20", Slot = "77")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x2030420", Offset = "0x202EC20", VA = "0x182030420")]
		public PHIOGJNIDAO(GILANFAFAJM EDJAAIKGPBN, AIGFILHFAIG LJMPFLMBPKN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673550", Offset = "0x672950")]
	private sealed class LOAGCGJKDIC : OGCFLHDHJHB<NHIJBHLNGGJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public override NodeVisualizationKey ADLHPEIHCMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0xC77D90", Offset = "0xC76590", VA = "0x180C77D90", Slot = "77")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2025030", Offset = "0x2023830", VA = "0x182025030")]
		public LOAGCGJKDIC(GILANFAFAJM EDJAAIKGPBN, NHIJBHLNGGJ LJMPFLMBPKN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6735B0", Offset = "0x6729B0")]
	private abstract class OGCFLHDHJHB<TNode> : DJPFAPHJALC<TNode> where TNode : notnull, ABHGPLBHDNA
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class AOGNGIKICOO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6738C0", Offset = "0x672CC0")]
			public AsyncTaskMethodBuilder<DLDMCIANGML<JIGIFEGHNPP<MEKIJODJIIO>, KCPGGCLIGHK>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public OGCFLHDHJHB<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private DLDMCIANGML<JIGIFEGHNPP<MEKIJODJIIO>, KCPGGCLIGHK> <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private TaskAwaiter<DLDMCIANGML<JIGIFEGHNPP<MEKIJODJIIO>, KCPGGCLIGHK>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
			public AOGNGIKICOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x2705450", Offset = "0x2703C50", VA = "0x182705450", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private sealed class DMBIEGMOHMN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673920", Offset = "0x672D20")]
			public AsyncTaskMethodBuilder<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673980", Offset = "0x672D80")]
			public JIGIFEGHNPP<MEKIJODJIIO> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public OGCFLHDHJHB<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK> <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
			public DMBIEGMOHMN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x27EC340", Offset = "0x27EAB40", VA = "0x1827EC340", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public sealed override bool FDICMDJCOAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x7EE860", Offset = "0x7ED060", VA = "0x1807EE860", Slot = "100")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673860", Offset = "0x672C60")]
		public sealed override JIGIFEGHNPP<MEKIJODJIIO>? KABCOGNLBFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x21FA9C0", Offset = "0x21F91C0", VA = "0x1821FA9C0", Slot = "105")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x21FA990", Offset = "0x21F9190", VA = "0x1821FA990")]
		public OGCFLHDHJHB(GILANFAFAJM EDJAAIKGPBN, TNode LJMPFLMBPKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x21FA480", Offset = "0x21F8C80", VA = "0x1821FA480", Slot = "86")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(OGCFLHDHJHB<>.AOGNGIKICOO))]
		public override Task<DLDMCIANGML<JIGIFEGHNPP<MEKIJODJIIO>, KCPGGCLIGHK>> BBAALLGDFAC(string MDOAADHDBMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x21FA620", Offset = "0x21F8E20", VA = "0x1821FA620", Slot = "107")]
		public sealed override bool FBJFAJJNNNN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673680", Offset = "0x672A80")] JIGIFEGHNPP<MEKIJODJIIO> JCELOBPNEDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x21FA8F0", Offset = "0x21F90F0", VA = "0x1821FA8F0", Slot = "98")]
		protected sealed override bool OOINFGPLHHE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6736E0", Offset = "0x672AE0")] JIGIFEGHNPP<MEKIJODJIIO> JCELOBPNEDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x21FA850", Offset = "0x21F9050", VA = "0x1821FA850", Slot = "99")]
		protected override bool LDGIPBFHNKM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673740", Offset = "0x672B40")] JIGIFEGHNPP<MEKIJODJIIO> JCELOBPNEDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x21FA6C0", Offset = "0x21F8EC0", VA = "0x1821FA6C0", Slot = "87")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(OGCFLHDHJHB<>.DMBIEGMOHMN))]
		public override Task<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> HKCLGBJKBCI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673800", Offset = "0x672C00")] JIGIFEGHNPP<MEKIJODJIIO> JCELOBPNEDG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6739E0", Offset = "0x672DE0")]
	private sealed class JDLCPFKEFID : GOEPPOEFNBM<PMEPHJJEDIE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public override NodeVisualizationKey ADLHPEIHCMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x7F0C80", Offset = "0x7EF480", VA = "0x1807F0C80", Slot = "77")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public override bool MPLLGDLEGIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x7EE860", Offset = "0x7ED060", VA = "0x1807EE860", Slot = "80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x2023370", Offset = "0x2021B70", VA = "0x182023370")]
		public JDLCPFKEFID(GILANFAFAJM EDJAAIKGPBN, PMEPHJJEDIE LJMPFLMBPKN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673A40", Offset = "0x672E40")]
	private sealed class HMKEGOKMGOO : DJPFAPHJALC<KPHCLKNENBG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public override NodeVisualizationKey ADLHPEIHCMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x7E0C80", Offset = "0x7DF480", VA = "0x1807E0C80", Slot = "77")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x2020C10", Offset = "0x201F410", VA = "0x182020C10")]
		public HMKEGOKMGOO(GILANFAFAJM EDJAAIKGPBN, KPHCLKNENBG LJMPFLMBPKN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673AA0", Offset = "0x672EA0")]
	private sealed class EEEFAAKIOJD : DJPFAPHJALC<KFKOCKFHLIA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public override NodeVisualizationKey ADLHPEIHCMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x8AEBE0", Offset = "0x8AD3E0", VA = "0x1808AEBE0", Slot = "77")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x2018BF0", Offset = "0x20173F0", VA = "0x182018BF0")]
		public EEEFAAKIOJD(GILANFAFAJM EDJAAIKGPBN, KFKOCKFHLIA LJMPFLMBPKN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673B00", Offset = "0x672F00")]
	private sealed class DNBPFEJHKOJ : DJPFAPHJALC<MLOFLKDFOCI>
	{
		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public override NodeVisualizationKey ADLHPEIHCMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x8AE990", Offset = "0x8AD190", VA = "0x1808AE990", Slot = "77")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x2018760", Offset = "0x2016F60", VA = "0x182018760")]
		public DNBPFEJHKOJ(GILANFAFAJM EDJAAIKGPBN, MLOFLKDFOCI LJMPFLMBPKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7EE860", Offset = "0x7ED060", VA = "0x1807EE860", Slot = "98")]
		protected override bool OOINFGPLHHE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673B60", Offset = "0x672F60")] JIGIFEGHNPP<MEKIJODJIIO> JCELOBPNEDG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2017400", Offset = "0x2015C00", VA = "0x182017400")]
	internal static ALDKPKNIDDP NKAIHPJAMOL(GILANFAFAJM EDJAAIKGPBN, BKFPHCKALON LJMPFLMBPKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class PNLMAIGGLIO
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x20308C0", Offset = "0x202F0C0", VA = "0x1820308C0")]
	public static PAIOLPCBHBC<OMKODJJIJCE, CIBICCNJBCB, GILANFAFAJM, MBBIGIBBKAC.LEFMHIHNJNB<OMKODJJIJCE, CIBICCNJBCB, GILANFAFAJM>> NFCHJBIICFJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673BC0", Offset = "0x672FC0")] this in PAIOLPCBHBC<OMKODJJIJCE, CIBICCNJBCB, GILANFAFAJM, MBBIGIBBKAC.LEFMHIHNJNB<OMKODJJIJCE, CIBICCNJBCB, GILANFAFAJM>> BNOMDEIMEKL)
	{
		return default(PAIOLPCBHBC<OMKODJJIJCE, CIBICCNJBCB, GILANFAFAJM, MBBIGIBBKAC.LEFMHIHNJNB<OMKODJJIJCE, CIBICCNJBCB, GILANFAFAJM>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public readonly struct NEAKMNNGOFF
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class AMHIBODFNIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673D90", Offset = "0x673190")]
		public AsyncTaskMethodBuilder<DLDMCIANGML<object, KCPGGCLIGHK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public CIBICCNJBCB action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public NEAKMNNGOFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private DLDMCIANGML<object, KCPGGCLIGHK> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private TaskAwaiter<DLDMCIANGML<object, KCPGGCLIGHK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public AMHIBODFNIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6C96590", Offset = "0x6C94D90", VA = "0x186C96590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class NHMKGCFFFEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673DF0", Offset = "0x6731F0")]
		public AsyncTaskMethodBuilder<DLDMCIANGML<bool, KCPGGCLIGHK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public INDICKEOBNO rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public MCEGKBNFGBJ circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public PKMIHDKHPIO superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public NEAKMNNGOFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673E50", Offset = "0x673250")]
		private CIBICCNJBCB[] <actions>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673EB0", Offset = "0x6732B0")]
		private DLDMCIANGML<object, KCPGGCLIGHK> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private bool <isFirst>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673F10", Offset = "0x673310")]
		private CIBICCNJBCB[] <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private CIBICCNJBCB <action>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673F70", Offset = "0x673370")]
		private DLDMCIANGML<object, KCPGGCLIGHK> <thisResult>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673FD0", Offset = "0x6733D0")]
		private DLDMCIANGML<object, KCPGGCLIGHK> <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674030", Offset = "0x673430")]
		private TaskAwaiter<DLDMCIANGML<object, KCPGGCLIGHK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public NHMKGCFFFEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x6C992D0", Offset = "0x6C97AD0", VA = "0x186C992D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class OFDHIGKKHBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674090", Offset = "0x673490")]
		public AsyncTaskMethodBuilder<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public NEAKMNNGOFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6740F0", Offset = "0x6734F0")]
		private DLDMCIANGML<object, KCPGGCLIGHK> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674150", Offset = "0x673550")]
		private TaskAwaiter<DLDMCIANGML<object, KCPGGCLIGHK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public OFDHIGKKHBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x6C99790", Offset = "0x6C97F90", VA = "0x186C99790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly CELMKNFEGPN AECMGGEMGHM;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x9E4D50", Offset = "0x9E3550", VA = "0x1809E4D50")]
	public NEAKMNNGOFF(CELMKNFEGPN JCNAAEGICGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2028FF0", Offset = "0x20277F0", VA = "0x182028FF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AMHIBODFNIK))]
	private Task<DLDMCIANGML<object, KCPGGCLIGHK>> CGMPFMLEDLN(CIBICCNJBCB COPPLLLOGLG, bool EPNDOMPHDOP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x20292D0", Offset = "0x2027AD0", VA = "0x1820292D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NHMKGCFFFEP))]
	public Task<DLDMCIANGML<bool, KCPGGCLIGHK?>>? ODDOFEIHEKG(int DACBEJHBOIP, INDICKEOBNO? KKFNLGBAEPM, MCEGKBNFGBJ? BHONCCCIJNM, PKMIHDKHPIO? GGGHMACDDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x2029180", Offset = "0x2027980", VA = "0x182029180")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OFDHIGKKHBE))]
	public Task<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> CLOOKKNDFON()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public sealed class IMNLBNCLGOG : NHDCGAOKDNJ
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	internal static class GEENAPOEBGH
	{
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private sealed class OELENONHGGA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public LILOKLOLLLP spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
			public OELENONHGGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x6C996E0", Offset = "0x6C97EE0", VA = "0x186C996E0")]
			internal bool MLHPMLPIKPF(HJBBGODFLND n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class FAHKJJMMKOM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
			public FAHKJJMMKOM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x6C97520", Offset = "0x6C95D20", VA = "0x186C97520")]
			internal void LLHPLAAOHFI(HJBBGODFLND n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x201C570", Offset = "0x201AD70", VA = "0x18201C570")]
		public static DLDMCIANGML<NHDCGAOKDNJ.BEJJBCHJEJG, BBDACGBJONE> JELDACCCIFL(IMNLBNCLGOG PECDBPPMOJP, in NHDCGAOKDNJ.JNCOFJAGIEN HPDOEALAHJH)
		{
			return default(DLDMCIANGML<NHDCGAOKDNJ.BEJJBCHJEJG, BBDACGBJONE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x201CFC0", Offset = "0x201B7C0", VA = "0x18201CFC0")]
		internal static DLDMCIANGML<BAFDAIGBFJB, KCPGGCLIGHK> KHHFFMHCNAD(IMNLBNCLGOG PECDBPPMOJP, JMIBFLLBPBF GIJBEHLCCDP, bool GKKIHDGELJK, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6746B0", Offset = "0x673AB0")] in GKDFBGMIKKM<NEABDLEHKAA> JLLLJCGCNHO, in int? NEAKMGPHPFO, in NBGMGGOIOJB? DJKJEAJLJEG, in NBGMGGOIOJB? CCEJNDEDBFO)
		{
			return default(DLDMCIANGML<BAFDAIGBFJB, KCPGGCLIGHK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x201DE20", Offset = "0x201C620", VA = "0x18201DE20")]
		private static void OILCJIOGNPJ(bool GKKIHDGELJK, GPPNCPPLGEE AOPICFKOEII, BAFDAIGBFJB JBONBBFHLMJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674720", Offset = "0x673B20")] in GKDFBGMIKKM<NEABDLEHKAA> JLLLJCGCNHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x201CA30", Offset = "0x201B230", VA = "0x18201CA30")]
		public static void KABOPHLNAPM(LMCIJCALDNI IJNKCHKDHCD, in NHDCGAOKDNJ.FLKGEAFMGEF PJGJLDPIOKJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly GILANFAFAJM GJALPMNMBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly CLNFDCFOHAN GHKHIKDLINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly KMBJICBPCON BJOODMCNDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly JHIANKIOGOC JLHAFFGMJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly FGJNHGAJLLO HBBPKHPFPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6741B0", Offset = "0x6735B0")]
	private Dictionary<GKDFBGMIKKM<BHJBCAJLFJP>, ALDKPKNIDDP> PCKHALMIGLF;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x20228E0", Offset = "0x20210E0", VA = "0x1820228E0")]
	public IMNLBNCLGOG(GILANFAFAJM EDJAAIKGPBN, CLNFDCFOHAN LDFHKMDLPBI, KMBJICBPCON CNNGGHEGAFL, FGJNHGAJLLO GDJGKFKBIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x2021600", Offset = "0x201FE00", VA = "0x182021600")]
	public ALDKPKNIDDP? FOFBABEKMOD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674210", Offset = "0x673610")] in GKDFBGMIKKM<BHJBCAJLFJP?> KJOHEJEFBGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x2021210", Offset = "0x201FA10", VA = "0x182021210")]
	private void BAKACCALGHA(BKFPHCKALON LJMPFLMBPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2021290", Offset = "0x201FA90", VA = "0x182021290")]
	private ALDKPKNIDDP? BBEIHKDELEJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674280", Offset = "0x673680")] in GKDFBGMIKKM<BHJBCAJLFJP?> KJOHEJEFBGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x2021FA0", Offset = "0x20207A0", VA = "0x182021FA0")]
	public BKFPHCKALON? NBDFAGCFEAH([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6742F0", Offset = "0x6736F0")] in GKDFBGMIKKM<BHJBCAJLFJP?> KJOHEJEFBGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2021D80", Offset = "0x2020580", VA = "0x182021D80")]
	public NEIEHGNJAFK? JLEBGIOIKLH([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674360", Offset = "0x673760")] in GKDFBGMIKKM<NEABDLEHKAA?> IBOAMBHJEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x2022450", Offset = "0x2020C50", VA = "0x182022450")]
	private LILOKLOLLLP? NKNFHNLMDKM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6743D0", Offset = "0x6737D0")] in GKDFBGMIKKM<NEABDLEHKAA?> IBOAMBHJEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2021D80", Offset = "0x2020580", VA = "0x182021D80")]
	private NEIEHGNJAFK? MJHBAJBCDKJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674440", Offset = "0x673840")] in GKDFBGMIKKM<NEABDLEHKAA?> IBOAMBHJEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x20227E0", Offset = "0x2020FE0", VA = "0x1820227E0", Slot = "6")]
	public IEnumerable<CJPNOMHHEOA> PHKMNJJJDMO(bool GIABINBNCHG, bool NNOEJLDIIPJ, bool DNHBGKOHBJC, bool EKGPKPNPBME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2021330", Offset = "0x201FB30", VA = "0x182021330")]
	public DLDMCIANGML<NHDCGAOKDNJ.BEJJBCHJEJG, BBDACGBJONE> BIGFPBMPMEP(in NHDCGAOKDNJ.JNCOFJAGIEN HPDOEALAHJH)
	{
		return default(DLDMCIANGML<NHDCGAOKDNJ.BEJJBCHJEJG, BBDACGBJONE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x20213D0", Offset = "0x201FBD0", VA = "0x1820213D0", Slot = "8")]
	public LJNJNEBPEAC DOCGNPFHGPD(IEnumerable<GPPNCPPLGEE> IPPBOEDJIEJ)
	{
		return default(LJNJNEBPEAC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x2021C30", Offset = "0x2020430", VA = "0x182021C30", Slot = "9")]
	public LJNJNEBPEAC JIJNNNOKKDB()
	{
		return default(LJNJNEBPEAC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x2021A80", Offset = "0x2020280", VA = "0x182021A80")]
	private HFIIAJPCLKM HGFAOLNCPBL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6744B0", Offset = "0x6738B0")] IEnumerable<GKDFBGMIKKM<NEABDLEHKAA>> KAFNMMOKLJE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674510", Offset = "0x673910")] IEnumerable<GKDFBGMIKKM<BHJBCAJLFJP>> BFGMAJKDDAK, CHFDCBPIOCJ GHDOIEKDNHG)
	{
		return default(HFIIAJPCLKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x2021740", Offset = "0x201FF40", VA = "0x182021740", Slot = "10")]
	public HFIIAJPCLKM HGFAOLNCPBL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674570", Offset = "0x673970")] IEnumerable<GKDFBGMIKKM<BHJBCAJLFJP>> BFGMAJKDDAK, IEnumerable<GPPNCPPLGEE> IPPBOEDJIEJ, CHFDCBPIOCJ GHDOIEKDNHG = CHFDCBPIOCJ.CopyPaste)
	{
		return default(HFIIAJPCLKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x20224E0", Offset = "0x2020CE0", VA = "0x1820224E0")]
	private static IEnumerable<GKDFBGMIKKM<NEABDLEHKAA>> OFHBHONEHOD(IEnumerable<GPPNCPPLGEE> IPPBOEDJIEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x2022020", Offset = "0x2020820", VA = "0x182022020")]
	private IEnumerable<GKDFBGMIKKM<BHJBCAJLFJP>> NEMDFEPEJIB(IEnumerable<GPPNCPPLGEE> IPPBOEDJIEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2021F20", Offset = "0x2020720", VA = "0x182021F20", Slot = "4")]
	private NEIEHGNJAFK KJJPGEGIOEI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6745D0", Offset = "0x6739D0")] in GKDFBGMIKKM<NEABDLEHKAA> IBOAMBHJEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x2021600", Offset = "0x201FE00", VA = "0x182021600", Slot = "5")]
	private ALDKPKNIDDP OCHAHHADPAH([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674640", Offset = "0x673A40")] in GKDFBGMIKKM<BHJBCAJLFJP> KJOHEJEFBGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2021330", Offset = "0x201FB30", VA = "0x182021330", Slot = "7")]
	private DLDMCIANGML<NHDCGAOKDNJ.BEJJBCHJEJG, BBDACGBJONE> MPCOOFHMJGC(in NHDCGAOKDNJ.JNCOFJAGIEN HPDOEALAHJH)
	{
		return default(DLDMCIANGML<NHDCGAOKDNJ.BEJJBCHJEJG, BBDACGBJONE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2021360", Offset = "0x201FB60", VA = "0x182021360")]
	[CompilerGenerated]
	private HJMMPLJEPHI CAMOODMBPNB(HDPBOFJILOB NLNOELCPLOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x20223E0", Offset = "0x2020BE0", VA = "0x1820223E0")]
	[CompilerGenerated]
	private BKFPHCKALON NHOJAMOJEDC(GKDFBGMIKKM<BHJBCAJLFJP> NLNOELCPLOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2021F30", Offset = "0x2020730", VA = "0x182021F30")]
	[CompilerGenerated]
	private LILOKLOLLLP KPKJLGODNFG(GKDFBGMIKKM<NEABDLEHKAA> NLNOELCPLOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public sealed class HFPPLEGGLFK : CLNFDCFOHAN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public interface KPIJIOFCIOH
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		PNOKGMHBDDG DJLGHEBBCIN
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<MCEGKBNFGBJ> FOKFIEJKNJI(CancellationToken NNLBJPBEHPF);

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<PKMIHDKHPIO> HKMBKJACMGL(CancellationToken NNLBJPBEHPF);

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<KPJPJIKAGDF> BHFILJMMOFE(CancellationToken NNLBJPBEHPF);
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class FICGKIFKDJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public AsyncTaskMethodBuilder<HFPPLEGGLFK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public GILANFAFAJM circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public MCEGKBNFGBJ roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public PKMIHDKHPIO superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private KPIJIOFCIOH <selfDeps>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private MCEGKBNFGBJ <downloadedRoomData>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private PKMIHDKHPIO <downloadedSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private HAMAAJHNHDC <cloudDataLedgerData>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private RepeatedField<NKEBGADLPOO> <rewardData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private MENBBKNIPAF <progressionTableData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private PKMIHDKHPIO <finalSuperRoomData>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private KPJPJIKAGDF <playerSaveData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private KAEGPHJIFMG <cv2State>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private MCEGKBNFGBJ <>s__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private PKMIHDKHPIO <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private KPJPJIKAGDF <>s__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6747F0", Offset = "0x673BF0")]
		private TaskAwaiter<MCEGKBNFGBJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674850", Offset = "0x673C50")]
		private TaskAwaiter<PKMIHDKHPIO> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6748B0", Offset = "0x673CB0")]
		private TaskAwaiter<KPJPJIKAGDF> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public FICGKIFKDJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x201A460", Offset = "0x2018C60", VA = "0x18201A460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly KAEGPHJIFMG CIHNMECEJFP;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public KAEGPHJIFMG LCACPFECHII
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7DF170", Offset = "0x7DD970", VA = "0x1807DF170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x8BA230", Offset = "0x8B8A30", VA = "0x1808BA230")]
	private HFPPLEGGLFK(KAEGPHJIFMG OAKOIMBAIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x2020340", Offset = "0x201EB40", VA = "0x182020340")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FICGKIFKDJC))]
	public static Task<HFPPLEGGLFK> JHGIOCBPJAI(GILANFAFAJM EDJAAIKGPBN, MCEGKBNFGBJ? LHKEKFAGIAO, PKMIHDKHPIO? GGGHMACDDAC, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2020320", Offset = "0x201EB20", VA = "0x182020320", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[KEDNLIFCNEC("IStaticEVInstance")]
public interface KMBJICBPCON : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	NADNAKENHPO ONDCBOHIOGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public sealed class PAPCPEKFGLB : HDOLDAMCNME, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public interface COHJBFHKJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<MLLLEIDCNOL> JFAEHKKNNHJ(GILANFAFAJM EDJAAIKGPBN, INDICKEOBNO FAMFGECHFDC, MCEGKBNFGBJ? AHMNPGOGKMJ, PKMIHDKHPIO? OAAJLMOBFKN, CancellationToken NNLBJPBEHPF);

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OFJBICJLLAA();

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void HBGOBOJJAOC();
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public abstract class NDJKKHGFCKC : COHJBFHKJIC
	{
		[Cpp2IlInjected.Token(Token = "0x2000059")]
		[CompilerGenerated]
		private sealed class OLOEIGFFFJD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public AsyncTaskMethodBuilder<MLLLEIDCNOL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public GILANFAFAJM circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public INDICKEOBNO evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public MCEGKBNFGBJ cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public PKMIHDKHPIO cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public NDJKKHGFCKC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			private AHPGBJHGGCL <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674AE0", Offset = "0x673EE0")]
			private TaskAwaiter<AHPGBJHGGCL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
			public OLOEIGFFFJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x6C99D10", Offset = "0x6C98510", VA = "0x186C99D10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6C98D60", Offset = "0x6C97560", VA = "0x186C98D60", Slot = "4")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(OLOEIGFFFJD))]
		public Task<MLLLEIDCNOL> JFAEHKKNNHJ(GILANFAFAJM EDJAAIKGPBN, INDICKEOBNO FAMFGECHFDC, MCEGKBNFGBJ? AHMNPGOGKMJ, PKMIHDKHPIO? OAAJLMOBFKN, CancellationToken NNLBJPBEHPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void OFJBICJLLAA();

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void HBGOBOJJAOC();

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		protected NDJKKHGFCKC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class FGJPLAALPEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public AsyncTaskMethodBuilder<MLLLEIDCNOL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public PAPCPEKFGLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private TaskAwaiter<GADODCKGMOI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public FGJPLAALPEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x6C97550", Offset = "0x6C95D50", VA = "0x186C97550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class JHDAFLMHMPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public GILANFAFAJM circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public INDICKEOBNO evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public MCEGKBNFGBJ cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public PKMIHDKHPIO cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public PAPCPEKFGLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private MLLLEIDCNOL <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private Exception <ex>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674B40", Offset = "0x673F40")]
		private TaskAwaiter<MLLLEIDCNOL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public JHDAFLMHMPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x6C97DC0", Offset = "0x6C965C0", VA = "0x186C97DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly COHJBFHKJIC PGKHJDIFGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly TaskCompletionSource<GADODCKGMOI> PGAOFPBAJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly TaskCompletionSource<GADODCKGMOI> DOMGDHHGNOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly CancellationTokenSource BFABJOGLDBE;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool FBEBNCKOPPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7ECD80", Offset = "0x7EB580", VA = "0x1807ECD80", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7ECD90", Offset = "0x7EB590", VA = "0x1807ECD90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool CENAPLLCNNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x1089650", Offset = "0x1087E50", VA = "0x181089650", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x1089640", Offset = "0x1087E40", VA = "0x181089640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool CFNNHILLGLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xD04670", Offset = "0xD02E70", VA = "0x180D04670")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x20302B0", Offset = "0x202EAB0", VA = "0x1820302B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public MLLLEIDCNOL? JPBINEKDEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7ED740", Offset = "0x7EBF40", VA = "0x1807ED740", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7ED730", Offset = "0x7EBF30", VA = "0x1807ED730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x2030160", Offset = "0x202E960", VA = "0x182030160", Slot = "7")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FGJPLAALPEM))]
	public Task<MLLLEIDCNOL> HBIHLNDHPCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x20302C0", Offset = "0x202EAC0", VA = "0x1820302C0")]
	public PAPCPEKFGLB(COHJBFHKJIC BPNALAJICIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x202FDF0", Offset = "0x202E5F0", VA = "0x18202FDF0", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JHDAFLMHMPM))]
	public Task BDGHBBNODAD(GILANFAFAJM EDJAAIKGPBN, INDICKEOBNO FAMFGECHFDC, MCEGKBNFGBJ? AHMNPGOGKMJ, PKMIHDKHPIO? OAAJLMOBFKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x202FFB0", Offset = "0x202E7B0", VA = "0x18202FFB0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[KEDNLIFCNEC("IStaticCV2Instance")]
public interface CLNFDCFOHAN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000062")]
	KAEGPHJIFMG LCACPFECHII
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class HEDEBKJNHAI : ONCJHPFAHMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly GILANFAFAJM GJALPMNMBCB;

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public IGIAFBPHCAD? OEFAOPMNMGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x2020230", Offset = "0x201EA30", VA = "0x182020230", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x8BA230", Offset = "0x8B8A30", VA = "0x1808BA230")]
	internal HEDEBKJNHAI(GILANFAFAJM EDJAAIKGPBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal sealed class CKPJFGAIOBM : PLBGJIOGMKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly IMNLBNCLGOG PLCIINFLODL;

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x8BA230", Offset = "0x8B8A30", VA = "0x1808BA230")]
	public CKPJFGAIOBM(IMNLBNCLGOG HPIHGGMAOLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public sealed class KDOCNBFJGPP : LHJELFAKJMC, ECJLNBJJJIP, KOPCDEMDFLI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000064")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674F10", Offset = "0x674310")]
	public JIGIFEGHNPP<AGLPHDPGOKH> KJDGFEOLDLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8B81A0", Offset = "0x8B69A0", VA = "0x1808B81A0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(JIGIFEGHNPP<AGLPHDPGOKH>);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x15E1F10", Offset = "0x15E0710", VA = "0x1815E1F10")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674C70", Offset = "0x674070")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674F70", Offset = "0x674370")]
	public override JIGIFEGHNPP<BNDKBOKJBHP> DMOEGHPBAKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x20236D0", Offset = "0x2021ED0", VA = "0x1820236D0", Slot = "19")]
		get
		{
			return default(JIGIFEGHNPP<BNDKBOKJBHP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x2023710", Offset = "0x2021F10", VA = "0x182023710")]
	private KDOCNBFJGPP(GILANFAFAJM EDJAAIKGPBN, BKFPHCKALON LJMPFLMBPKN, MHBPOFIDFBL DFGNDAJKDAN, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674CD0", Offset = "0x6740D0")] JIGIFEGHNPP<MEKIJODJIIO> JCELOBPNEDG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674D30", Offset = "0x674130")] JIGIFEGHNPP<AGLPHDPGOKH> FMLFHBLLJFA, bool KMCFGIEEEOM, string MDOAADHDBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x20233D0", Offset = "0x2021BD0", VA = "0x1820233D0")]
	public static KDOCNBFJGPP NKAIHPJAMOL(GILANFAFAJM EDJAAIKGPBN, BKFPHCKALON LJMPFLMBPKN, MHBPOFIDFBL HNICMLCBLOB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674D90", Offset = "0x674190")] JIGIFEGHNPP<MEKIJODJIIO> JCELOBPNEDG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674DF0", Offset = "0x6741F0")] JIGIFEGHNPP<DFLJDHCNLJI> JMGMPHDCILN, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674E50", Offset = "0x674250")] JIGIFEGHNPP<AGLPHDPGOKH> FMLFHBLLJFA, bool KMCFGIEEEOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x15E1F10", Offset = "0x15E0710", VA = "0x1815E1F10")]
	internal void NLPFLFIHJJM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674EB0", Offset = "0x6742B0")] JIGIFEGHNPP<AGLPHDPGOKH> MENBIMCLIOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public sealed class HJMMPLJEPHI : CJPNOMHHEOA
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class HGGBMCHGCLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6752E0", Offset = "0x6746E0")]
		public AsyncTaskMethodBuilder<DLDMCIANGML<JIGIFEGHNPP<MGCIEENFDNB>, KCPGGCLIGHK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675340", Offset = "0x674740")]
		public GKDFBGMIKKM<NEABDLEHKAA> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6753A0", Offset = "0x6747A0")]
		public GKDFBGMIKKM<BHJBCAJLFJP> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675400", Offset = "0x674800")]
		public JIGIFEGHNPP<MEKIJODJIIO> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public HJMMPLJEPHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private DLDMCIANGML<JIGIFEGHNPP<MGCIEENFDNB>, KCPGGCLIGHK> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private TaskAwaiter<DLDMCIANGML<JIGIFEGHNPP<MGCIEENFDNB>, KCPGGCLIGHK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public HGGBMCHGCLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x2020500", Offset = "0x201ED00", VA = "0x182020500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class FAHBNHKKIKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675460", Offset = "0x674860")]
		public AsyncTaskMethodBuilder<DLDMCIANGML<JIGIFEGHNPP<DFLJDHCNLJI>, KCPGGCLIGHK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6754C0", Offset = "0x6748C0")]
		public GKDFBGMIKKM<NEABDLEHKAA> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675520", Offset = "0x674920")]
		public GKDFBGMIKKM<BHJBCAJLFJP> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675580", Offset = "0x674980")]
		public JIGIFEGHNPP<MEKIJODJIIO> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public HJMMPLJEPHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private DLDMCIANGML<JIGIFEGHNPP<DFLJDHCNLJI>, KCPGGCLIGHK> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private TaskAwaiter<DLDMCIANGML<JIGIFEGHNPP<DFLJDHCNLJI>, KCPGGCLIGHK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public FAHBNHKKIKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x2019280", Offset = "0x2017A80", VA = "0x182019280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly HDPBOFJILOB OCKCHDKLECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly CLNFDCFOHAN GHKHIKDLINP;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public string HAOMEAELKNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x201B2D0", Offset = "0x2019AD0", VA = "0x18201B2D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x2020B00", Offset = "0x201F300", VA = "0x182020B00")]
	public HJMMPLJEPHI(HDPBOFJILOB CPNKNDDHBCC, CLNFDCFOHAN LDFHKMDLPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x2020760", Offset = "0x201EF60", VA = "0x182020760", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HGGBMCHGCLO))]
	public Task<DLDMCIANGML<JIGIFEGHNPP<MGCIEENFDNB>, KCPGGCLIGHK>> IMFOBGPPIOK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675030", Offset = "0x674430")] GKDFBGMIKKM<NEABDLEHKAA> IBOAMBHJEOF, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675090", Offset = "0x674490")] GKDFBGMIKKM<BHJBCAJLFJP> KJOHEJEFBGI, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6750F0", Offset = "0x6744F0")] JIGIFEGHNPP<MEKIJODJIIO> JCELOBPNEDG, string MDOAADHDBMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x2020930", Offset = "0x201F130", VA = "0x182020930", Slot = "6")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FAHBNHKKIKE))]
	public Task<DLDMCIANGML<JIGIFEGHNPP<DFLJDHCNLJI>, KCPGGCLIGHK>> MPAEBLGPIBO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6751C0", Offset = "0x6745C0")] GKDFBGMIKKM<NEABDLEHKAA> IBOAMBHJEOF, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675220", Offset = "0x674620")] GKDFBGMIKKM<BHJBCAJLFJP> KJOHEJEFBGI, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675280", Offset = "0x674680")] JIGIFEGHNPP<MEKIJODJIIO> JCELOBPNEDG, string MDOAADHDBMA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public sealed class AHPGBJHGGCL : MLLLEIDCNOL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public interface BNDOMCLPFDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CLNFDCFOHAN> HKOFBANMNOP(GILANFAFAJM EDJAAIKGPBN, MCEGKBNFGBJ? AHMNPGOGKMJ, PKMIHDKHPIO? OAAJLMOBFKN, CancellationToken NNLBJPBEHPF);

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		KMBJICBPCON JIGLHFPPGPJ(GILANFAFAJM EDJAAIKGPBN, INDICKEOBNO FAMFGECHFDC);
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public sealed class MLCMODBHKLF : BNDOMCLPFDE
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class AMOBJGJFNJA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public AsyncTaskMethodBuilder<CLNFDCFOHAN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public GILANFAFAJM circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public MCEGKBNFGBJ cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public PKMIHDKHPIO cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public MLCMODBHKLF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			private HFPPLEGGLFK <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6756A0", Offset = "0x674AA0")]
			private TaskAwaiter<HFPPLEGGLFK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
			public AMOBJGJFNJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x6C96800", Offset = "0x6C95000", VA = "0x186C96800", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly MLCMODBHKLF OEFAOPMNMGM;

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		private MLCMODBHKLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2026260", Offset = "0x2024A60", VA = "0x182026260", Slot = "4")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(AMOBJGJFNJA))]
		public Task<CLNFDCFOHAN> HKOFBANMNOP(GILANFAFAJM EDJAAIKGPBN, MCEGKBNFGBJ? AHMNPGOGKMJ, PKMIHDKHPIO? OAAJLMOBFKN, CancellationToken NNLBJPBEHPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2026450", Offset = "0x2024C50", VA = "0x182026450", Slot = "5")]
		public KMBJICBPCON JIGLHFPPGPJ(GILANFAFAJM EDJAAIKGPBN, INDICKEOBNO FAMFGECHFDC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class APBBGMPLLHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public AsyncTaskMethodBuilder<AHPGBJHGGCL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public GILANFAFAJM circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public INDICKEOBNO evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public MCEGKBNFGBJ cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public PKMIHDKHPIO cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private BNDOMCLPFDE <selfDeps>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private CLNFDCFOHAN <cv2RootSys>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private KMBJICBPCON <evRootSys>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private CLNFDCFOHAN <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675700", Offset = "0x674B00")]
		private TaskAwaiter<CLNFDCFOHAN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public APBBGMPLLHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x2015D10", Offset = "0x2014510", VA = "0x182015D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly CLNFDCFOHAN GHKHIKDLINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly KMBJICBPCON BJOODMCNDHN;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public PGMINICGNBB HOIMNKDHKFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2015850", Offset = "0x2014050", VA = "0x182015850", Slot = "4")]
		get
		{
			return default(PGMINICGNBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public OEGGFMGBBEP MMNBJANCLKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2015920", Offset = "0x2014120", VA = "0x182015920", Slot = "5")]
		get
		{
			return default(OEGGFMGBBEP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public BLHNLBFCNMK NHHMBPCLBNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7EC6C0", Offset = "0x7EAEC0", VA = "0x1807EC6C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public IMNLBNCLGOG IAGNPKLGHAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8A5F80", Offset = "0x8A4780", VA = "0x1808A5F80", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public APBBHFKIJFF NOHAGEIHOIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7F3350", Offset = "0x7F1B50", VA = "0x1807F3350", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x2015B80", Offset = "0x2014380", VA = "0x182015B80")]
	private AHPGBJHGGCL(CLNFDCFOHAN LDFHKMDLPBI, KMBJICBPCON CNNGGHEGAFL, BLHNLBFCNMK CHOACICGAEP, IMNLBNCLGOG HPIHGGMAOLE, APBBHFKIJFF DJFFOEJEOIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x2015990", Offset = "0x2014190", VA = "0x182015990")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(APBBGMPLLHG))]
	public static Task<AHPGBJHGGCL> JHGIOCBPJAI(GILANFAFAJM EDJAAIKGPBN, INDICKEOBNO FAMFGECHFDC, MCEGKBNFGBJ? AHMNPGOGKMJ, PKMIHDKHPIO? OAAJLMOBFKN, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x20158C0", Offset = "0x20140C0", VA = "0x1820158C0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface HDOLDAMCNME : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	MLLLEIDCNOL? JPBINEKDEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	bool CENAPLLCNNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	bool FBEBNCKOPPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<MLLLEIDCNOL?>? HBIHLNDHPCN();

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task BDGHBBNODAD(GILANFAFAJM EDJAAIKGPBN, INDICKEOBNO FAMFGECHFDC, MCEGKBNFGBJ? AHMNPGOGKMJ, PKMIHDKHPIO? OAAJLMOBFKN);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public sealed class APBBHFKIJFF : IGIAFBPHCAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly CLNFDCFOHAN GHKHIKDLINP;

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public FAJFIDENOBG CGMPFMLEDLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x20162D0", Offset = "0x2014AD0", VA = "0x1820162D0", Slot = "4")]
		get
		{
			return default(FAJFIDENOBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public GLJAAMLLPGN GHFAFPLHFCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x2016390", Offset = "0x2014B90", VA = "0x182016390", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675840", Offset = "0x674C40")]
	public GKDFBGMIKKM<NEABDLEHKAA> LJJCJDIBNNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x2016330", Offset = "0x2014B30", VA = "0x182016330", Slot = "6")]
		get
		{
			return default(GKDFBGMIKKM<NEABDLEHKAA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public KAEGPHJIFMG MLCPFJLJEPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x20163F0", Offset = "0x2014BF0", VA = "0x1820163F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x8BA230", Offset = "0x8B8A30", VA = "0x1808BA230")]
	public APBBHFKIJFF(CLNFDCFOHAN LDFHKMDLPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x2016260", Offset = "0x2014A60", VA = "0x182016260")]
	public bool CGLLBMDIJMD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675760", Offset = "0x674B60")] in GKDFBGMIKKM<NEABDLEHKAA> IBOAMBHJEOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x2016260", Offset = "0x2014A60", VA = "0x182016260", Slot = "8")]
	private bool DAIPFAFLJIK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6757D0", Offset = "0x674BD0")] in GKDFBGMIKKM<NEABDLEHKAA> IBOAMBHJEOF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public sealed class MNKIJCDNIMP : LHJELFAKJMC, CGNNJOCFJBI, KOPCDEMDFLI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class JJNHKGJMGAI
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		private sealed class <<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public PBFEAEKKBFJ errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			public JJNHKGJMGAI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK> <result>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			private DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK> <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private TaskAwaiter<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
			public <<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x6C9A3C0", Offset = "0x6C98BC0", VA = "0x186C9A3C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public MNKIJCDNIMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public JJNHKGJMGAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x6C98400", Offset = "0x6C96C00", VA = "0x186C98400")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task KODAAEIAAPF(PBFEAEKKBFJ errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class IKBFCGIPCCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public MNKIJCDNIMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private bool <isPure>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private MJEMGCCGKGC <signal>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK> <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private bool <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private TaskAwaiter<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public IKBFCGIPCCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x2020D20", Offset = "0x201F520", VA = "0x182020D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class JOIPILLJPAI
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		private sealed class <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public PBFEAEKKBFJ errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public JOIPILLJPAI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			private DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK> <result>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			private DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK> <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			private TaskAwaiter<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
			public <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x6C9A630", Offset = "0x6C98E30", VA = "0x186C9A630", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public MNKIJCDNIMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public JOIPILLJPAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x6C98550", Offset = "0x6C96D50", VA = "0x186C98550")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task HKHGJLIODLI(PBFEAEKKBFJ errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly CMGNJJFKFPK HFPGONBKEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly ICollection<NDMHLBLAMGC> NMAFNPAIFOA;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	private PEKNFFFIPLC BPGJHNHKDED
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x2026BE0", Offset = "0x20253E0", VA = "0x182026BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675C40", Offset = "0x675040")]
	public JIGIFEGHNPP<FEMJHLKFHDN> FJFGNPDMCHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x20279E0", Offset = "0x20261E0", VA = "0x1820279E0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(JIGIFEGHNPP<FEMJHLKFHDN>);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x2026620", Offset = "0x2024E20", VA = "0x182026620")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675930", Offset = "0x674D30")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675CA0", Offset = "0x6750A0")]
	public override JIGIFEGHNPP<BNDKBOKJBHP> DMOEGHPBAKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x2028330", Offset = "0x2026B30", VA = "0x182028330", Slot = "19")]
		get
		{
			return default(JIGIFEGHNPP<BNDKBOKJBHP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public bool OGGJFCKIBCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x2026E10", Offset = "0x2025610", VA = "0x182026E10", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x2028F00", Offset = "0x2027700", VA = "0x182028F00")]
	private MNKIJCDNIMP(GILANFAFAJM EDJAAIKGPBN, BKFPHCKALON LJMPFLMBPKN, CMGNJJFKFPK PPNAKGNMEAG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675990", Offset = "0x674D90")] JIGIFEGHNPP<MEKIJODJIIO> JCELOBPNEDG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6759F0", Offset = "0x674DF0")] JIGIFEGHNPP<FEMJHLKFHDN> LJFMEHDMBLN, bool KMCFGIEEEOM, string MDOAADHDBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x2027F20", Offset = "0x2026720", VA = "0x182027F20")]
	public static MNKIJCDNIMP NKAIHPJAMOL(GILANFAFAJM EDJAAIKGPBN, BKFPHCKALON LJMPFLMBPKN, CMGNJJFKFPK OADMIGAEKPI, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675A50", Offset = "0x674E50")] JIGIFEGHNPP<MEKIJODJIIO> JCELOBPNEDG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675AB0", Offset = "0x674EB0")] JIGIFEGHNPP<MGCIEENFDNB> MAJGNMADALN, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675B10", Offset = "0x674F10")] JIGIFEGHNPP<FEMJHLKFHDN> LJFMEHDMBLN, bool KMCFGIEEEOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x2026630", Offset = "0x2024E30", VA = "0x182026630", Slot = "20")]
	protected override void BDCEDMLOOPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2026A30", Offset = "0x2025230", VA = "0x182026A30", Slot = "21")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x2027010", Offset = "0x2025810", VA = "0x182027010", Slot = "28")]
	public void ELKJGPOKOIF(NDMHLBLAMGC EPMHFCHCFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x20273B0", Offset = "0x2025BB0", VA = "0x1820273B0", Slot = "25")]
	public void HPLHJDCJGOM(BFNNHCILPAN OFKKDLGDDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x2028580", Offset = "0x2026D80", VA = "0x182028580", Slot = "26")]
	public void PKCDEANJGJP(MCIBKBIHGGH MIDGMLEOBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x2026540", Offset = "0x2024D40", VA = "0x182026540", Slot = "22")]
	protected override void AGCLABBHLDA(EAJDMMNECCM NECIEIPLPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x2026C80", Offset = "0x2025480", VA = "0x182026C80", Slot = "30")]
	public string EJAABDIHEKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x20279F0", Offset = "0x20261F0", VA = "0x1820279F0", Slot = "27")]
	public string MCPEGOFCHEB(int GLAKJJLMGLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x2027800", Offset = "0x2026000", VA = "0x182027800")]
	private void MBEGIKJDLFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x2026920", Offset = "0x2025120", VA = "0x182026920", Slot = "29")]
	public void CEIBNKNLMIG(NDMHLBLAMGC EPMHFCHCFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x2028370", Offset = "0x2026B70", VA = "0x182028370")]
	private void OEFKHMGOGBO(bool MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x20270D0", Offset = "0x20258D0", VA = "0x1820270D0", Slot = "31")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IKBFCGIPCCI))]
	public Task FJHMKDLFNLD(string MENBIMCLIOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x2028430", Offset = "0x2026C30", VA = "0x182028430")]
	public void OHFNGAHPDEN(string MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x20272F0", Offset = "0x2025AF0", VA = "0x1820272F0")]
	private void HLOPMAIDGED(int MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x2026620", Offset = "0x2024E20", VA = "0x182026620")]
	internal void AILHEPEKBBN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675BE0", Offset = "0x674FE0")] JIGIFEGHNPP<FEMJHLKFHDN> MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x2027640", Offset = "0x2025E40", VA = "0x182027640")]
	[CompilerGenerated]
	private bool JHGLEIBBLKI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x2027D60", Offset = "0x2026560", VA = "0x182027D60")]
	[CompilerGenerated]
	private bool MHPKJELKNCN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x20268D0", Offset = "0x20250D0", VA = "0x1820268D0")]
	[CompilerGenerated]
	private int JKJHGKHKGAE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x2027E80", Offset = "0x2026680", VA = "0x182027E80")]
	[CompilerGenerated]
	private bool NIOELIDEEPF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x2027220", Offset = "0x2025A20", VA = "0x182027220")]
	[CompilerGenerated]
	private bool HIHLBGCFGIK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x20269E0", Offset = "0x20251E0", VA = "0x1820269E0")]
	[CompilerGenerated]
	private bool CFMJCPNJPKL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x2028290", Offset = "0x2026A90", VA = "0x182028290")]
	[CompilerGenerated]
	private bool NLKMKADJALO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x20268D0", Offset = "0x20250D0", VA = "0x1820268D0")]
	[CompilerGenerated]
	private int BNBKDAPKCAG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x20267E0", Offset = "0x2024FE0", VA = "0x1820267E0")]
	[CompilerGenerated]
	private bool BLGENBDOMNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x2027E30", Offset = "0x2026630", VA = "0x182027E30")]
	[CompilerGenerated]
	private int NBJCCFNIFFO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x2026C00", Offset = "0x2025400", VA = "0x182026C00")]
	[CompilerGenerated]
	private void EFKPEJKEPPD(object MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x2027710", Offset = "0x2025F10", VA = "0x182027710")]
	[CompilerGenerated]
	private bool LOGDMOFKNCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class DCCLJFOEGNA
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private class FEPKNAFANEE<TGraph> : NEIEHGNJAFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		protected readonly TGraph NFALINFCCKB;

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public virtual FIHMEKPAFJI? JANOEPGGLHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0xA64BE0", Offset = "0xA633E0", VA = "0x180A64BE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x18FBCA0", Offset = "0x18FA4A0", VA = "0x1818FBCA0")]
		public FEPKNAFANEE(TGraph KKKAOJMKPJF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66CAE0", Offset = "0x66BEE0")]
	private sealed class HBMHALJOJEJ : FEPKNAFANEE<HBLFMGJCIOM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public override FIHMEKPAFJI? JANOEPGGLHD
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x2020140", Offset = "0x201E940", VA = "0x182020140", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x2020160", Offset = "0x201E960", VA = "0x182020160")]
		public HBMHALJOJEJ(HBLFMGJCIOM CFGBHAAEMGO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x2017D20", Offset = "0x2016520", VA = "0x182017D20")]
	public static NEIEHGNJAFK NKAIHPJAMOL(LILOKLOLLLP KKKAOJMKPJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public sealed class PLPEOAGOFIB : IPFCHCAJIKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private readonly GILANFAFAJM GJALPMNMBCB;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public bool FBEBNCKOPPG
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x2030480", Offset = "0x202EC80", VA = "0x182030480", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x8BA230", Offset = "0x8B8A30", VA = "0x1808BA230")]
	internal PLPEOAGOFIB(GILANFAFAJM EDJAAIKGPBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class LHJELFAKJMC : KOPCDEMDFLI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private struct ADJKGGOGKDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private FIHLLMBOGGN? ILGCJOGENIB;

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x2015660", Offset = "0x2013E60", VA = "0x182015660")]
		public void EEMEPIGIECC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x20155C0", Offset = "0x2013DC0", VA = "0x1820155C0")]
		public FIHLLMBOGGN EAMMEMGABFA(LHJELFAKJMC PKIIOMGHHMM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	protected readonly GILANFAFAJM GJALPMNMBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	protected readonly BKFPHCKALON LBEDBNKIAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private ADJKGGOGKDC HDFMCCOIDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly HDFGCBNNDPI GHBKDNAEMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly List<DPOCJJLLFLP> NBLHDBGHKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly List<AMFBCKOLIMD> FJGOJJNECEP;

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public IEnumerable<StaticEdge> DKBFIAPLMCN
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x2024940", Offset = "0x2023140", VA = "0x182024940", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public DisplayKind FAKDKNNKAAM
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7ED780", Offset = "0x7EBF80", VA = "0x1807ED780", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66CD30", Offset = "0x66C130")]
	public GKDFBGMIKKM<NEABDLEHKAA> NACHHCKGAFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x2023CF0", Offset = "0x20224F0", VA = "0x182023CF0", Slot = "6")]
		get
		{
			return default(GKDFBGMIKKM<NEABDLEHKAA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	protected HDPBOFJILOB PPNHHFEBJEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x1BF9C60", Offset = "0x1BF8460", VA = "0x181BF9C60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public ABFKNOKEKPO DPPOAKODGAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x2023EF0", Offset = "0x20226F0", VA = "0x182023EF0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	protected FIHLLMBOGGN KDILOMFNMDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x2023EF0", Offset = "0x20226F0", VA = "0x182023EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public PortImage FLBJOHOKCLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x20247A0", Offset = "0x2022FA0", VA = "0x1820247A0", Slot = "12")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public string EHNKIECOKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x7DFCD0", Offset = "0x7DE4D0", VA = "0x1807DFCD0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x7ED760", Offset = "0x7EBF60", VA = "0x1807ED760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66CDA0", Offset = "0x66C1A0")]
	public GKDFBGMIKKM<BHJBCAJLFJP> CHECEAIAHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x2023E70", Offset = "0x2022670", VA = "0x182023E70", Slot = "8")]
		get
		{
			return default(GKDFBGMIKKM<BHJBCAJLFJP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66CE10", Offset = "0x66C210")]
	public JIGIFEGHNPP<MEKIJODJIIO> COMOHJGFJJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD60", Offset = "0x7DE560", VA = "0x1807DFD60", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(JIGIFEGHNPP<MEKIJODJIIO>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xD58E00", Offset = "0xD57600", VA = "0x180D58E00")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66CC10", Offset = "0x66C010")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66CE70", Offset = "0x66C270")]
	public abstract JIGIFEGHNPP<BNDKBOKJBHP> DMOEGHPBAKO
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x2024AE0", Offset = "0x20232E0", VA = "0x182024AE0")]
	protected LHJELFAKJMC(GILANFAFAJM EDJAAIKGPBN, BKFPHCKALON LJMPFLMBPKN, HDFGCBNNDPI DACABOPDKMD, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66CC70", Offset = "0x66C070")] JIGIFEGHNPP<MEKIJODJIIO> JCELOBPNEDG, bool KMCFGIEEEOM, string MDOAADHDBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x2023880", Offset = "0x2022080", VA = "0x182023880", Slot = "20")]
	protected virtual void BDCEDMLOOPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2023D20", Offset = "0x2022520", VA = "0x182023D20", Slot = "21")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2024740", Offset = "0x2022F40", VA = "0x182024740", Slot = "13")]
	public void MDOPLOJPMIJ(DPOCJJLLFLP JFHBAKFJNGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x20248E0", Offset = "0x20230E0", VA = "0x1820248E0", Slot = "14")]
	public void NMDIMNIALML(AMFBCKOLIMD JFHBAKFJNGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x2023FF0", Offset = "0x20227F0", VA = "0x182023FF0", Slot = "15")]
	public void KAHLLCNFPAH(EAJDMMNECCM NECIEIPLPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x2023820", Offset = "0x2022020", VA = "0x182023820", Slot = "22")]
	protected virtual void AGCLABBHLDA(EAJDMMNECCM NECIEIPLPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x20245D0", Offset = "0x2022DD0", VA = "0x1820245D0")]
	private void KNBDCEMGABH(bool FFEHKCANNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x20239D0", Offset = "0x20221D0", VA = "0x1820239D0")]
	private void BFFJNLLBCOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x2023B60", Offset = "0x2022360", VA = "0x182023B60")]
	private void BLDLOBKDDPH(in EJJAFPFMHIA AEFFHHGAGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x2023E90", Offset = "0x2022690", VA = "0x182023E90", Slot = "16")]
	public void HGAGFJFHPOL(DPOCJJLLFLP JFHBAKFJNGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x2023F90", Offset = "0x2022790", VA = "0x182023F90", Slot = "17")]
	public void JDNIHIDKBEJ(AMFBCKOLIMD JFHBAKFJNGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x7ED760", Offset = "0x7EBF60", VA = "0x1807ED760")]
	internal void NEFEDGHHENM(string MDOAADHDBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0xD58E00", Offset = "0xD57600", VA = "0x180D58E00")]
	internal void LFFCDIMBAPL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66CCD0", Offset = "0x66C0D0")] JIGIFEGHNPP<MEKIJODJIIO> JCELOBPNEDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public sealed class BLHNLBFCNMK : BGJKBHGMKHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly GILANFAFAJM GJALPMNMBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly CLNFDCFOHAN GHKHIKDLINP;

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x8A72C0", Offset = "0x8A5AC0", VA = "0x1808A72C0")]
	public BLHNLBFCNMK(GILANFAFAJM EDJAAIKGPBN, CLNFDCFOHAN LDFHKMDLPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x2016710", Offset = "0x2014F10", VA = "0x182016710", Slot = "4")]
	public DLDMCIANGML<PFGINJDODDN, IGMNMEMCLHH> PPIBLFAFEDH([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66CF50", Offset = "0x66C350")] GKDFBGMIKKM<BHJBCAJLFJP> KJOHEJEFBGI, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66CFB0", Offset = "0x66C3B0")] JIGIFEGHNPP<MEKIJODJIIO> JCELOBPNEDG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66D010", Offset = "0x66C410")] JIGIFEGHNPP<FEMJHLKFHDN> LJFMEHDMBLN)
	{
		return default(DLDMCIANGML<PFGINJDODDN, IGMNMEMCLHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x2016440", Offset = "0x2014C40", VA = "0x182016440", Slot = "5")]
	public DLDMCIANGML<PFGINJDODDN, IGMNMEMCLHH> ONODELIIPNJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66D070", Offset = "0x66C470")] GKDFBGMIKKM<BHJBCAJLFJP> KJOHEJEFBGI, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66D0D0", Offset = "0x66C4D0")] JIGIFEGHNPP<MEKIJODJIIO> JCELOBPNEDG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66D130", Offset = "0x66C530")] JIGIFEGHNPP<AGLPHDPGOKH> FMLFHBLLJFA)
	{
		return default(DLDMCIANGML<PFGINJDODDN, IGMNMEMCLHH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public sealed class FGJNHGAJLLO : NOHDHFCBIBG
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class GEHMCBOBAFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public AsyncTaskMethodBuilder<NHDCGAOKDNJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public FGJNHGAJLLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private MLLLEIDCNOL <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66D200", Offset = "0x66C600")]
		private TaskAwaiter<MLLLEIDCNOL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public GEHMCBOBAFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x201E2F0", Offset = "0x201CAF0", VA = "0x18201E2F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private readonly GILANFAFAJM GJALPMNMBCB;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public NHDCGAOKDNJ? OEFAOPMNMGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x2019D90", Offset = "0x2018590", VA = "0x182019D90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public bool GGLCIPFNFJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x201A3B0", Offset = "0x2018BB0", VA = "0x18201A3B0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool KMNJCBIGPMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x201A060", Offset = "0x2018860", VA = "0x18201A060", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x8BA230", Offset = "0x8B8A30", VA = "0x1808BA230")]
	internal FGJNHGAJLLO(GILANFAFAJM EDJAAIKGPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x2019C40", Offset = "0x2018440", VA = "0x182019C40", Slot = "7")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GEHMCBOBAFB))]
	public Task<NHDCGAOKDNJ> CPOMFKCBFFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x201A0C0", Offset = "0x20188C0", VA = "0x18201A0C0")]
	internal Dictionary<GKDFBGMIKKM<NEABDLEHKAA>, Guid> MBNGJHLJLDH(IEnumerable<GPPNCPPLGEE> AFFGOCGNNEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x2019A00", Offset = "0x2018200", VA = "0x182019A00")]
	public DLDMCIANGML<HEKACILBIGL, BBDACGBJONE> AMKOOMLAKKC(in HEKACILBIGL ELCAMLHOAJL, IEnumerable<GPPNCPPLGEE> IPPBOEDJIEJ, int EIGBHIAFDGO)
	{
		return default(DLDMCIANGML<HEKACILBIGL, BBDACGBJONE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x201A410", Offset = "0x2018C10", VA = "0x18201A410")]
	internal static NBGMGGOIOJB OHNICNFEPDD(FILLNEJFELL HACFIGJKHKB, BKFPHCKALON LJMPFLMBPKN)
	{
		return default(NBGMGGOIOJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x2019C00", Offset = "0x2018400", VA = "0x182019C00", Slot = "8")]
	private DLDMCIANGML<HEKACILBIGL, BBDACGBJONE> CPHHFIAFLDA(in HEKACILBIGL ELCAMLHOAJL, IEnumerable<GPPNCPPLGEE> IPPBOEDJIEJ, int EIGBHIAFDGO)
	{
		return default(DLDMCIANGML<HEKACILBIGL, BBDACGBJONE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x2019E10", Offset = "0x2018610", VA = "0x182019E10")]
	[CompilerGenerated]
	internal static NBGMGGOIOJB LCBLHGBDDPM(FILLNEJFELL JMJIJLOCIHP, BKFPHCKALON PAPOBOBJDDB)
	{
		return default(NBGMGGOIOJB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public interface MLLLEIDCNOL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	PGMINICGNBB HOIMNKDHKFG
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	OEGGFMGBBEP MMNBJANCLKG
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	BLHNLBFCNMK NHHMBPCLBNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	APBBHFKIJFF NOHAGEIHOIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	IMNLBNCLGOG IAGNPKLGHAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public sealed class OFHGNAHJOPO : EJLBLHEPNCC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class OIBDCJDAFME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public GILANFAFAJM circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public BKFPHCKALON node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66EE40", Offset = "0x66E240")]
		public JIGIFEGHNPP<MEKIJODJIIO> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public bool canInteract;

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public OIBDCJDAFME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6C99980", Offset = "0x6C98180", VA = "0x186C99980")]
		internal MNKIJCDNIMP EOMKLACFNHF((int PortDescIndex, int PortIndex, CMGNJJFKFPK InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x6C99A60", Offset = "0x6C98260", VA = "0x186C99A60")]
		internal KDOCNBFJGPP LNPJLEADNPC(MHBPOFIDFBL i, int idx)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private sealed class BAGDLJHDLOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66EF50", Offset = "0x66E350")]
		public AsyncTaskMethodBuilder<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public OFHGNAHJOPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66EFB0", Offset = "0x66E3B0")]
		private DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK> <r>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private PBFEAEKKBFJ <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66F010", Offset = "0x66E410")]
		private (PBCOFJLIMMD PortDesc, int PortDescIndex)? <input>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private PBCOFJLIMMD <portDesc>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private int <portDescIndex>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK> <result>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK> <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private TaskAwaiter<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public BAGDLJHDLOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6C96D00", Offset = "0x6C95500", VA = "0x186C96D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class ANNOKOCACBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66F0E0", Offset = "0x66E4E0")]
		public AsyncTaskMethodBuilder<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66F140", Offset = "0x66E540")]
		public JIGIFEGHNPP<MGCIEENFDNB> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public OFHGNAHJOPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private PBFEAEKKBFJ <errReporting>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private TaskAwaiter<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public ANNOKOCACBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6C969B0", Offset = "0x6C951B0", VA = "0x186C969B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class HNFCECDFPFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66F1A0", Offset = "0x66E5A0")]
		public AsyncTaskMethodBuilder<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66F200", Offset = "0x66E600")]
		public JIGIFEGHNPP<DFLJDHCNLJI> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public OFHGNAHJOPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private PBFEAEKKBFJ <errReporting>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private TaskAwaiter<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public HNFCECDFPFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x6C97A70", Offset = "0x6C96270", VA = "0x186C97A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class GJBMHFOAMDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66F260", Offset = "0x66E660")]
		public AsyncTaskMethodBuilder<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66F2C0", Offset = "0x66E6C0")]
		public JIGIFEGHNPP<MGCIEENFDNB> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66F320", Offset = "0x66E720")]
		public JIGIFEGHNPP<MGCIEENFDNB> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public OFHGNAHJOPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private PBFEAEKKBFJ <errReporting>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private TaskAwaiter<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public GJBMHFOAMDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x6C97710", Offset = "0x6C95F10", VA = "0x186C97710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class DKBNEOJOHPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66F380", Offset = "0x66E780")]
		public AsyncTaskMethodBuilder<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66F3E0", Offset = "0x66E7E0")]
		public JIGIFEGHNPP<DFLJDHCNLJI> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66F440", Offset = "0x66E840")]
		public JIGIFEGHNPP<DFLJDHCNLJI> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public OFHGNAHJOPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private PBFEAEKKBFJ <errReporting>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private TaskAwaiter<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public DKBNEOJOHPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x6C971C0", Offset = "0x6C959C0", VA = "0x186C971C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class PIJAHIANBNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66F4A0", Offset = "0x66E8A0")]
		public AsyncTaskMethodBuilder<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public OFHGNAHJOPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66F500", Offset = "0x66E900")]
		private DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK> <r>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private PBFEAEKKBFJ <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66F560", Offset = "0x66E960")]
		private (PBCOFJLIMMD PortDesc, int PortDescIndex)? <input>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private PBCOFJLIMMD <portDesc>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private int <portDescIndex>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private int <inputPortCount>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private int <portIndex>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK> <result>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK> <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private TaskAwaiter<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public PIJAHIANBNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x6C99ED0", Offset = "0x6C986D0", VA = "0x186C99ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class MDBAFBFCMPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66F630", Offset = "0x66EA30")]
		public AsyncTaskMethodBuilder<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public OFHGNAHJOPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private PBFEAEKKBFJ <errReporting>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private TaskAwaiter<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public MDBAFBFCMPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x6C98A00", Offset = "0x6C97200", VA = "0x186C98A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class NEKEDINEHMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66F690", Offset = "0x66EA90")]
		public AsyncTaskMethodBuilder<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66F6F0", Offset = "0x66EAF0")]
		public JIGIFEGHNPP<MGCIEENFDNB> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public OFHGNAHJOPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private PBFEAEKKBFJ <errReporting>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private TaskAwaiter<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public NEKEDINEHMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x6C98F70", Offset = "0x6C97770", VA = "0x186C98F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class KMMGMGGJPMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66F750", Offset = "0x66EB50")]
		public AsyncTaskMethodBuilder<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66F7B0", Offset = "0x66EBB0")]
		public JIGIFEGHNPP<DFLJDHCNLJI> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public OFHGNAHJOPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private PBFEAEKKBFJ <errReporting>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private TaskAwaiter<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public KMMGMGGJPMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x6C986A0", Offset = "0x6C96EA0", VA = "0x186C986A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly bool CAIKEEIDJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly GILANFAFAJM GJALPMNMBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly bool GMPANGCOCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66D260", Offset = "0x66C660")]
	private BHOOABHAPCP<FEMJHLKFHDN, MNKIJCDNIMP> IBCJKDPFCFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66D2C0", Offset = "0x66C6C0")]
	private BHOOABHAPCP<FEMJHLKFHDN, CGNNJOCFJBI> FMLEHOLDCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private readonly BKFPHCKALON LBEDBNKIAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66D320", Offset = "0x66C720")]
	private BHOOABHAPCP<AGLPHDPGOKH, KDOCNBFJGPP> GIKCBEEOFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66D380", Offset = "0x66C780")]
	private BHOOABHAPCP<AGLPHDPGOKH, ECJLNBJJJIP> LKIPEJOJKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private string? JDPONDJLKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private readonly MCFFNFPLKCM EENHJIFDLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66D3E0", Offset = "0x66C7E0")]
	private JIGIFEGHNPP<MEKIJODJIIO> CMPBMAAOLEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action? FKMMMGLJNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action? AMJPFFABBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66D6C0", Offset = "0x66CAC0")]
	private Action<JIGIFEGHNPP<FEMJHLKFHDN>> CCOFBMFBIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	[CompilerGenerated]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66D8C0", Offset = "0x66CCC0")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<JIGIFEGHNPP<AGLPHDPGOKH>> CNIHKMIGOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EJLBLHEPNCC.JCOGBJENNJF? DLHHIEDPNIM;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool OJPBIKEDNLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x202D930", Offset = "0x202C130", VA = "0x18202D930", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool HOCPIHFMACG
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x202C390", Offset = "0x202AB90", VA = "0x18202C390", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public bool NJAHPOKLIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x202C2D0", Offset = "0x202AAD0", VA = "0x18202C2D0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66E940", Offset = "0x66DD40")]
	public GKDFBGMIKKM<NEABDLEHKAA> NACHHCKGAFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x202AFB0", Offset = "0x20297B0", VA = "0x18202AFB0", Slot = "7")]
		get
		{
			return default(GKDFBGMIKKM<NEABDLEHKAA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public bool EMLOFPMGGFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x202AC50", Offset = "0x2029450", VA = "0x18202AC50", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66E9B0", Offset = "0x66DDB0")]
	public BHOOABHAPCP<FEMJHLKFHDN, CGNNJOCFJBI> MCHLGAHFLKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x7F3350", Offset = "0x7F1B50", VA = "0x1807F3350", Slot = "9")]
		get
		{
			return default(BHOOABHAPCP<FEMJHLKFHDN, CGNNJOCFJBI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public string EHNKIECOKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x202CE20", Offset = "0x202B620", VA = "0x18202CE20", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66EA10", Offset = "0x66DE10")]
	public GKDFBGMIKKM<BHJBCAJLFJP> CHECEAIAHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x202C780", Offset = "0x202AF80", VA = "0x18202C780", Slot = "11")]
		get
		{
			return default(GKDFBGMIKKM<BHJBCAJLFJP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66EA80", Offset = "0x66DE80")]
	public BHOOABHAPCP<AGLPHDPGOKH, ECJLNBJJJIP> EMPMCDCNJNC
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x7DFCD0", Offset = "0x7DE4D0", VA = "0x1807DFCD0", Slot = "12")]
		get
		{
			return default(BHOOABHAPCP<AGLPHDPGOKH, ECJLNBJJJIP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66EAE0", Offset = "0x66DEE0")]
	public JIGIFEGHNPP<MEKIJODJIIO> COMOHJGFJJH
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x8B9C00", Offset = "0x8B8400", VA = "0x1808B9C00", Slot = "13")]
		get
		{
			return default(JIGIFEGHNPP<MEKIJODJIIO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action AKNPHPDDJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x202A680", Offset = "0x2028E80", VA = "0x18202A680", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x202C230", Offset = "0x202AA30", VA = "0x18202C230", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action<JIGIFEGHNPP<FEMJHLKFHDN>, JIGIFEGHNPP<FEMJHLKFHDN>> AIGNPCMICCB
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x202E410", Offset = "0x202CC10", VA = "0x18202E410", Slot = "16")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66DA00", Offset = "0x66CE00")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x202AE70", Offset = "0x2029670", VA = "0x18202AE70", Slot = "17")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66DA60", Offset = "0x66CE60")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<JIGIFEGHNPP<AGLPHDPGOKH>, JIGIFEGHNPP<AGLPHDPGOKH>> GBPHHOFDPNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x202A720", Offset = "0x2028F20", VA = "0x18202A720", Slot = "18")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66DAC0", Offset = "0x66CEC0")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x202EBF0", Offset = "0x202D3F0", VA = "0x18202EBF0", Slot = "19")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66DB20", Offset = "0x66CF20")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<JIGIFEGHNPP<FEMJHLKFHDN>, CGNNJOCFJBI> HNKBKJMNMNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x202DDF0", Offset = "0x202C5F0", VA = "0x18202DDF0", Slot = "20")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66DB80", Offset = "0x66CF80")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x202CC20", Offset = "0x202B420", VA = "0x18202CC20", Slot = "21")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66DBE0", Offset = "0x66CFE0")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<JIGIFEGHNPP<FEMJHLKFHDN>> FNFMEEGJEDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x202C8F0", Offset = "0x202B0F0", VA = "0x18202C8F0", Slot = "22")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66DC40", Offset = "0x66D040")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x202E370", Offset = "0x202CB70", VA = "0x18202E370", Slot = "23")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66DCA0", Offset = "0x66D0A0")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<JIGIFEGHNPP<FEMJHLKFHDN>, CGNNJOCFJBI> LKBPACPHLFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x202E4B0", Offset = "0x202CCB0", VA = "0x18202E4B0", Slot = "24")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66DD00", Offset = "0x66D100")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x202DE90", Offset = "0x202C690", VA = "0x18202DE90", Slot = "25")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66DD60", Offset = "0x66D160")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<JIGIFEGHNPP<AGLPHDPGOKH>, ECJLNBJJJIP> AELHGCJDCCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x202AF10", Offset = "0x2029710", VA = "0x18202AF10", Slot = "26")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66DDC0", Offset = "0x66D1C0")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x202DC00", Offset = "0x202C400", VA = "0x18202DC00", Slot = "27")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66DE20", Offset = "0x66D220")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<JIGIFEGHNPP<AGLPHDPGOKH>> DCLOGKBIFGP
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x202F0B0", Offset = "0x202D8B0", VA = "0x18202F0B0", Slot = "28")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66DE80", Offset = "0x66D280")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x202E230", Offset = "0x202CA30", VA = "0x18202E230", Slot = "29")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66DEE0", Offset = "0x66D2E0")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<JIGIFEGHNPP<AGLPHDPGOKH>, ECJLNBJJJIP> CJNHIEBLHHL
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x202E2D0", Offset = "0x202CAD0", VA = "0x18202E2D0", Slot = "30")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66DF40", Offset = "0x66D340")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x202D9F0", Offset = "0x202C1F0", VA = "0x18202D9F0", Slot = "31")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66DFA0", Offset = "0x66D3A0")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x202F150", Offset = "0x202D950", VA = "0x18202F150")]
	private OFHGNAHJOPO(bool KMCFGIEEEOM, GILANFAFAJM EDJAAIKGPBN, bool JCOOEGLFOPH, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66E000", Offset = "0x66D400")] BHOOABHAPCP<FEMJHLKFHDN, MNKIJCDNIMP> CKHMKHEKKFO, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66E060", Offset = "0x66D460")] BHOOABHAPCP<FEMJHLKFHDN, CGNNJOCFJBI> LHIDIIDEPKO, BKFPHCKALON LJMPFLMBPKN, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66E0C0", Offset = "0x66D4C0")] BHOOABHAPCP<AGLPHDPGOKH, KDOCNBFJGPP> LNNACBBEDGK, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66E120", Offset = "0x66D520")] BHOOABHAPCP<AGLPHDPGOKH, ECJLNBJJJIP> JLFDOFCPKAE, string? ENMOAABKBFE, MCFFNFPLKCM FEPHIIFNOJN, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66E180", Offset = "0x66D580")] JIGIFEGHNPP<MEKIJODJIIO> JCELOBPNEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x202E550", Offset = "0x202CD50", VA = "0x18202E550")]
	public static OFHGNAHJOPO NKAIHPJAMOL(bool KMCFGIEEEOM, GILANFAFAJM EDJAAIKGPBN, bool JCOOEGLFOPH, BKFPHCKALON LJMPFLMBPKN, MCFFNFPLKCM FEPHIIFNOJN, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66E1E0", Offset = "0x66D5E0")] JIGIFEGHNPP<MEKIJODJIIO> JCELOBPNEDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x2029F50", Offset = "0x2028750", VA = "0x182029F50")]
	private void BDCEDMLOOPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x202B400", Offset = "0x2029C00", VA = "0x18202B400", Slot = "41")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x202C7A0", Offset = "0x202AFA0", VA = "0x18202C7A0", Slot = "32")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BAGDLJHDLOC))]
	public Task<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> GHDONLGJJJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x2029CF0", Offset = "0x20284F0", VA = "0x182029CF0")]
	private (PBCOFJLIMMD, int)? ALCIDBCCNPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x2029B80", Offset = "0x2028380", VA = "0x182029B80")]
	private void AKMIEDOFJPE(int PHHDFKJAAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x908360", Offset = "0x906B60", VA = "0x180908360")]
	private void GCLFOKMNLDB(int PHHDFKJAAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x202EC90", Offset = "0x202D490", VA = "0x18202EC90")]
	private void PGKICPJFHED(int AMKIGPHCCNE, int LPMDNDDBAGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x8AA840", Offset = "0x8A9040", VA = "0x1808AA840")]
	private void BPMLKDEDBNL(int PHHDFKJAAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x202CE50", Offset = "0x202B650", VA = "0x18202CE50")]
	private void HMFIIMIKFMI(int PHHDFKJAAMH, int NKLKLCPALJO, CMGNJJFKFPK HLLBMEGLPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x202C6F0", Offset = "0x202AEF0", VA = "0x18202C6F0")]
	private void GCLCFMNKKIG(int FFEHKCANNDI, int NKLKLCPALJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x202D8A0", Offset = "0x202C0A0", VA = "0x18202D8A0")]
	private void ICMADILPDKI(int FFEHKCANNDI, int NKLKLCPALJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x202A7C0", Offset = "0x2028FC0", VA = "0x18202A7C0")]
	private void BJPOMAAKNEK(int PHHDFKJAAMH, int NKLKLCPALJO, CMGNJJFKFPK HLLBMEGLPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x202DA90", Offset = "0x202C290", VA = "0x18202DA90")]
	private void JDBFJJFMICL(int PHHDFKJAAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x908360", Offset = "0x906B60", VA = "0x180908360")]
	private void CBMPELLOBIH(int PHHDFKJAAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x202AFE0", Offset = "0x20297E0", VA = "0x18202AFE0")]
	private void DBFIJIPFKAN(int AMKIGPHCCNE, int LPMDNDDBAGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x8AA840", Offset = "0x8A9040", VA = "0x1808AA840")]
	private void MAPDHEHGMEM(int PHHDFKJAAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x202BC60", Offset = "0x202A460", VA = "0x18202BC60")]
	private void EDOAHGFENDD(int PHHDFKJAAMH, int NKLKLCPALJO, MHBPOFIDFBL HLLBMEGLPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x202CA20", Offset = "0x202B220", VA = "0x18202CA20")]
	private void GMNOPPIKFOL(int FFEHKCANNDI, int NKLKLCPALJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x202C990", Offset = "0x202B190", VA = "0x18202C990")]
	private void GLKEJCDLECJ(int FFEHKCANNDI, int NKLKLCPALJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x202D400", Offset = "0x202BC00", VA = "0x18202D400")]
	private void IBILDNJGMGJ(int PHHDFKJAAMH, int NKLKLCPALJO, MHBPOFIDFBL HLLBMEGLPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x202CCC0", Offset = "0x202B4C0", VA = "0x18202CCC0", Slot = "33")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ANNOKOCACBC))]
	public Task<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> GPGNGDAFOFI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66E310", Offset = "0x66D710")] JIGIFEGHNPP<MGCIEENFDNB> MAJGNMADALN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x202EA90", Offset = "0x202D290", VA = "0x18202EA90", Slot = "34")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HNFCECDFPFN))]
	public Task<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> OGEPNMPCHDK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66E3D0", Offset = "0x66D7D0")] JIGIFEGHNPP<DFLJDHCNLJI> JMGMPHDCILN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x202A500", Offset = "0x2028D00", VA = "0x18202A500", Slot = "35")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GJBMHFOAMDL))]
	public Task<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> BEGNIFKLJPE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66E490", Offset = "0x66D890")] JIGIFEGHNPP<MGCIEENFDNB> MAJGNMADALN, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66E4F0", Offset = "0x66D8F0")] JIGIFEGHNPP<MGCIEENFDNB> CGKGGOHJOOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x202C3E0", Offset = "0x202ABE0", VA = "0x18202C3E0", Slot = "36")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DKBNEOJOHPL))]
	public Task<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> ELIFGEIMJEN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66E5B0", Offset = "0x66D9B0")] JIGIFEGHNPP<DFLJDHCNLJI> JMGMPHDCILN, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66E610", Offset = "0x66DA10")] JIGIFEGHNPP<DFLJDHCNLJI> CGKGGOHJOOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x202DCA0", Offset = "0x202C4A0", VA = "0x18202DCA0", Slot = "37")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PIJAHIANBNA))]
	public Task<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> JODODAGJBBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x202CAB0", Offset = "0x202B2B0", VA = "0x18202CAB0", Slot = "38")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MDBAFBFCMPK))]
	public Task<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> GNACEJMAOCN(string DMLGLOOFFOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x202C560", Offset = "0x202AD60", VA = "0x18202C560", Slot = "39")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NEKEDINEHMH))]
	public Task<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> FLFOIGDJNFK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66E7B0", Offset = "0x66DBB0")] JIGIFEGHNPP<MGCIEENFDNB> MAJGNMADALN, string MDOAADHDBMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x202ACE0", Offset = "0x20294E0", VA = "0x18202ACE0", Slot = "40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KMMGMGGJPMO))]
	public Task<DLDMCIANGML<GADODCKGMOI, KCPGGCLIGHK>> CDCGGCJDDBE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66E880", Offset = "0x66DC80")] JIGIFEGHNPP<DFLJDHCNLJI> JMGMPHDCILN, string MDOAADHDBMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x202DF30", Offset = "0x202C730", VA = "0x18202DF30")]
	internal void LFFCDIMBAPL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66E8E0", Offset = "0x66DCE0")] JIGIFEGHNPP<MEKIJODJIIO> MENBIMCLIOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct OGIAINCGGEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66F810", Offset = "0x66EC10")]
	internal OBJEHNPADPA<OCLLBHJNOKO, CIBICCNJBCB, FGDEAMNKKDI> MPCPGABGLGK;

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x2017D10", Offset = "0x2016510", VA = "0x182017D10")]
	private OGIAINCGGEC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66F870", Offset = "0x66EC70")] in OBJEHNPADPA<OCLLBHJNOKO, CIBICCNJBCB, FGDEAMNKKDI> EEEFPBNFHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x202F230", Offset = "0x202DA30", VA = "0x18202F230")]
	public static OGIAINCGGEC NKAIHPJAMOL()
	{
		return default(OGIAINCGGEC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public static class PGFCOENMNGP
{
	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x907390", Offset = "0x905B90", VA = "0x180907390")]
	public static OBJEHNPADPA<OCLLBHJNOKO, CIBICCNJBCB, FGDEAMNKKDI> MOOHLFEKHJG(this ref OGIAINCGGEC PECDBPPMOJP)
	{
		return default(OBJEHNPADPA<OCLLBHJNOKO, CIBICCNJBCB, FGDEAMNKKDI>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
public readonly struct OKNIEDIADOG : FGGGLGANPGN.EAICNMBKHLG<CIBICCNJBCB, GADODCKGMOI>
{
	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x202F770", Offset = "0x202DF70", VA = "0x18202F770", Slot = "4")]
	public int OLEJKBOLIFD(GADODCKGMOI FFEHKCANNDI, CIBICCNJBCB COPPLLLOGLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x202F440", Offset = "0x202DC40", VA = "0x18202F440", Slot = "5")]
	public CIBICCNJBCB CLKAFELBKIP(GADODCKGMOI FFEHKCANNDI, CIBICCNJBCB COPPLLLOGLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x202F690", Offset = "0x202DE90", VA = "0x18202F690", Slot = "6")]
	public CIBICCNJBCB MENAFPACPJM(GADODCKGMOI FFEHKCANNDI, CIBICCNJBCB COPPLLLOGLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x202F590", Offset = "0x202DD90", VA = "0x18202F590", Slot = "7")]
	public IReadOnlyList<CIBICCNJBCB> INHCGOOJJLB(GADODCKGMOI FFEHKCANNDI, CIBICCNJBCB COPPLLLOGLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x202F2C0", Offset = "0x202DAC0", VA = "0x18202F2C0", Slot = "8")]
	public CIBICCNJBCB[] BNPBDIDBHGI(GADODCKGMOI FFEHKCANNDI, CIBICCNJBCB COPPLLLOGLG, int MDKBDOPCENF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x202F410", Offset = "0x202DC10", VA = "0x18202F410", Slot = "9")]
	public bool CCKLCBDNPKO(GADODCKGMOI FFEHKCANNDI, CIBICCNJBCB COPPLLLOGLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x202F740", Offset = "0x202DF40", VA = "0x18202F740", Slot = "10")]
	public bool OJMPHNMMMIO(GADODCKGMOI FFEHKCANNDI, CIBICCNJBCB COPPLLLOGLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x202F560", Offset = "0x202DD60", VA = "0x18202F560", Slot = "11")]
	public bool FPMGJEJAHED(GADODCKGMOI FFEHKCANNDI, CIBICCNJBCB COPPLLLOGLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x202F630", Offset = "0x202DE30", VA = "0x18202F630", Slot = "12")]
	public bool JDBLKCNHJLK(GADODCKGMOI FFEHKCANNDI, CIBICCNJBCB COPPLLLOGLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x202F290", Offset = "0x202DA90", VA = "0x18202F290", Slot = "13")]
	public bool AMMHEIJAAMB(GADODCKGMOI ENAMOCLNABA, CIBICCNJBCB COPPLLLOGLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x202F660", Offset = "0x202DE60", VA = "0x18202F660", Slot = "14")]
	public bool JPHOAJELJKO(GADODCKGMOI FFEHKCANNDI, CIBICCNJBCB COPPLLLOGLG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public abstract class IONNBKJAODM : PEKNFFFIPLC
{
	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public AHPGBJHGGCL.BNDOMCLPFDE LPCKKDMPACK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x2022C20", Offset = "0x2021420", VA = "0x182022C20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public abstract PAPCPEKFGLB.COHJBFHKJIC PDBOCKHGHBE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public abstract GILANFAFAJM.MAFDKMBBDLJ DFBEIDCADGL
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public abstract HFPPLEGGLFK.KPIJIOFCIOH ADGAOGMBDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public MBBIGIBBKAC.LEFMHIHNJNB<OMKODJJIJCE, CIBICCNJBCB, GILANFAFAJM> FBLIAEABADN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x2022C80", Offset = "0x2021480", VA = "0x182022C80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public abstract PBFEAEKKBFJ HCHGMJCABJP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public abstract IMEOIGKPJFM BGOCLIJOFGM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public abstract CKPFHKIEPCH HEHGACOMDEP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public abstract MEPEGPJDDLA LJDNBBKIAPN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public abstract NAFFONMJPBI FBFDLCNLMNC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	protected IONNBKJAODM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public sealed class DFBNBAHLEEO : GLJAAMLLPGN
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class MJDJPADBLLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66F9F0", Offset = "0x66EDF0")]
		public AsyncTaskMethodBuilder<DLDMCIANGML<object, KCPGGCLIGHK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public CIBICCNJBCB action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public DFBNBAHLEEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private DLDMCIANGML<object, KCPGGCLIGHK> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private TaskAwaiter<DLDMCIANGML<object, KCPGGCLIGHK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public MJDJPADBLLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x2025FE0", Offset = "0x20247E0", VA = "0x182025FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class ACNLMNLHJMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66FB10", Offset = "0x66EF10")]
		public AsyncTaskMethodBuilder<DLDMCIANGML<JBNOLOHMHCO, KCPGGCLIGHK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66FB70", Offset = "0x66EF70")]
		public IReadOnlyList<CIBICCNJBCB> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public DFBNBAHLEEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66FC80", Offset = "0x66F080")]
		private DLDMCIANGML<object, KCPGGCLIGHK> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66FD40", Offset = "0x66F140")]
		private TaskAwaiter<DLDMCIANGML<object, KCPGGCLIGHK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public ACNLMNLHJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x2015210", Offset = "0x2013A10", VA = "0x182015210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private readonly CELMKNFEGPN AECMGGEMGHM;

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x8BA230", Offset = "0x8B8A30", VA = "0x1808BA230")]
	public DFBNBAHLEEO(CELMKNFEGPN JCNAAEGICGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x2018070", Offset = "0x2016870", VA = "0x182018070")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MJDJPADBLLG))]
	private Task<DLDMCIANGML<object, KCPGGCLIGHK>> CGMPFMLEDLN(CIBICCNJBCB COPPLLLOGLG, bool EPNDOMPHDOP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x2018200", Offset = "0x2016A00", VA = "0x182018200", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ACNLMNLHJMN))]
	public Task<DLDMCIANGML<JBNOLOHMHCO, KCPGGCLIGHK>> MNBHJJAKPCH(IReadOnlyList<CIBICCNJBCB> JMIJOGDAJKN, bool EPNDOMPHDOP)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct DELBBMMBHHM : KLMKGCDGGBP.CDIPGHIIHJH<LOCAKMOCMEO, CIBICCNJBCB>
{
	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0xB74FC0", Offset = "0xB737C0", VA = "0x180B74FC0")]
	public int EADEPLBBPHE(in LOCAKMOCMEO EEHLCCCMIOG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x2017EA0", Offset = "0x20166A0", VA = "0x182017EA0", Slot = "5")]
	public CIBICCNJBCB JMHFDNFGNOP(LOCAKMOCMEO[] KHPOEDMHAEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0xB74FC0", Offset = "0xB737C0", VA = "0x180B74FC0", Slot = "4")]
	private int IMPGDLOODJO(in LOCAKMOCMEO EEHLCCCMIOG)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000091")]
public struct FGDEAMNKKDI : NJMLELDIEOP.HMKMFBEKEIC<OCLLBHJNOKO, CIBICCNJBCB>
{
	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x2019830", Offset = "0x2018030", VA = "0x182019830", Slot = "5")]
	public CIBICCNJBCB PFAFLMEFFHL(OCLLBHJNOKO[] AGFHHAGEHJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0xB74FC0", Offset = "0xB737C0", VA = "0x180B74FC0")]
	public int FHMDIKIHJNO(in OCLLBHJNOKO EEHLCCCMIOG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0xB74FC0", Offset = "0xB737C0", VA = "0x180B74FC0", Slot = "4")]
	private int MHPIPGGLAPG(in OCLLBHJNOKO LEPAFNOLPHG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct HKNBMMOIMEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66FE60", Offset = "0x66F260")]
	internal DMHOLDNDLMN<LOCAKMOCMEO, CIBICCNJBCB, DELBBMMBHHM> MPCPGABGLGK;

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x2017D10", Offset = "0x2016510", VA = "0x182017D10")]
	private HKNBMMOIMEJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66FF20", Offset = "0x66F320")] in DMHOLDNDLMN<LOCAKMOCMEO, CIBICCNJBCB, DELBBMMBHHM> DPCIMBNMPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x2020BB0", Offset = "0x201F3B0", VA = "0x182020BB0")]
	public static HKNBMMOIMEJ NKAIHPJAMOL()
	{
		return default(HKNBMMOIMEJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class LOBIBMMJMEM
{
	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x907390", Offset = "0x905B90", VA = "0x180907390")]
	public static DMHOLDNDLMN<LOCAKMOCMEO, CIBICCNJBCB, DELBBMMBHHM> MOOHLFEKHJG(this ref HKNBMMOIMEJ PECDBPPMOJP)
	{
		return default(DMHOLDNDLMN<LOCAKMOCMEO, CIBICCNJBCB, DELBBMMBHHM>);
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
