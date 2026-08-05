using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
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
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70")]
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
		[Cpp2IlInjected.Address(RVA = "0x4971380", Offset = "0x496FD80", VA = "0x184971380")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x847190", Offset = "0x845B90", VA = "0x180847190")]
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
		[Cpp2IlInjected.Address(RVA = "0x143BBF0", Offset = "0x143A5F0", VA = "0x18143BBF0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class LOCBHAFLAKB : IDisposable, PBHHBKAHGHI, NLOLFDCJIBO, OBBIBFDBILK, MGKNGMIFLFP, JOFIILBJLJG
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class HLMFOLAEBBJ : JIPIMLDPMNP
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public abstract int GEONGMLCOKM
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x496C4B0", Offset = "0x496AEB0", VA = "0x18496C4B0", Slot = "5")]
		public FJDFMLPGFAO BCLIFFDFOAD(GFDLFKLHEEO.ONEIDCCMKKM KIMLKGPEIDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void INOGAGNJKFO();

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void GGIFNIPIACE();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		protected HLMFOLAEBBJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface JIPIMLDPMNP
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		int GEONGMLCOKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "1")]
		FJDFMLPGFAO BCLIFFDFOAD(GFDLFKLHEEO.ONEIDCCMKKM KIMLKGPEIDL);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void INOGAGNJKFO();

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void GGIFNIPIACE();
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct LFFHFMAGDOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DF000", Offset = "0x6DE400")]
		public readonly global::BDBCGFMDOEA<MLLDPAIKBLN, BDNOBKCCDPH, LOCBHAFLAKB, GJDCAHCJAOL> IKPFPMKENNC;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x94C490", Offset = "0x94AE90", VA = "0x18094C490")]
		internal LFFHFMAGDOD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DF060", Offset = "0x6DE460")] global::BDBCGFMDOEA<MLLDPAIKBLN, BDNOBKCCDPH, LOCBHAFLAKB, GJDCAHCJAOL> NPGEFAIHGBA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class GANDBPGLIAM : GJDCAHCJAOL
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly GANDBPGLIAM FINLHCLDLDF;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		private GANDBPGLIAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1C2E530", Offset = "0x1C2CF30", VA = "0x181C2E530", Slot = "4")]
		public MLLDPAIKBLN LDKDFELJEPF(BDNOBKCCDPH IKHBPJOEIEB)
		{
			return default(MLLDPAIKBLN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "5")]
		public void HOMCECDGLNH(LOCBHAFLAKB MNGLAEJHIMG, BDNOBKCCDPH DJJNLDOINEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct OCELNPCLGNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DF0E0", Offset = "0x6DE4E0")]
		public global::APCEBBGPJOF<MLLDPAIKBLN, BDNOBKCCDPH, LOCBHAFLAKB, GJDCAHCJAOL> IKPFPMKENNC;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4971C40", Offset = "0x4970640", VA = "0x184971C40")]
		internal OCELNPCLGNL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DF140", Offset = "0x6DE540")] global::APCEBBGPJOF<MLLDPAIKBLN, BDNOBKCCDPH, LOCBHAFLAKB, GJDCAHCJAOL> NPGEFAIHGBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4971BF0", Offset = "0x49705F0", VA = "0x184971BF0")]
		public static OCELNPCLGNL IDLIIDOEAFG()
		{
			return default(OCELNPCLGNL);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct JOIKNHFCPHL : HNKPLKBHMMN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct PJIONBCLGNH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DF220", Offset = "0x6DE620")]
			public AsyncTaskMethodBuilder<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public LOCBHAFLAKB receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public BDNOBKCCDPH action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public JOIKNHFCPHL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DF280", Offset = "0x6DE680")]
			private TaskAwaiter<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x4972630", Offset = "0x4971030", VA = "0x184972630", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x49727C0", Offset = "0x49711C0", VA = "0x1849727C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1C2E530", Offset = "0x1C2CF30", VA = "0x181C2E530", Slot = "4")]
		public global::JKMOEKGCPOM<EJMOAPMNGEL> AEABDFEANCH(LOCBHAFLAKB LFFLKCJEJDN)
		{
			return default(global::JKMOEKGCPOM<EJMOAPMNGEL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x496DAB0", Offset = "0x496C4B0", VA = "0x18496DAB0", Slot = "5")]
		[AsyncStateMachine(typeof(PJIONBCLGNH))]
		public Task<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> FONJCDBDFLB(LOCBHAFLAKB LFFLKCJEJDN, BDNOBKCCDPH DJJNLDOINEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x496DA90", Offset = "0x496C490", VA = "0x18496DA90", Slot = "6")]
		public BDNOBKCCDPH[] EGPMPHFMILK(LOCBHAFLAKB LFFLKCJEJDN)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct PGILJCKMNPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DF2E0", Offset = "0x6DE6E0")]
		public AsyncTaskMethodBuilder<global::DAOEJNFJJPJ<bool, PCIJMHLMKIF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public LOCBHAFLAKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public DGKGPJMHHCJ rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public LHIEOLPDLKP circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public OJPOLICDEIN superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DF340", Offset = "0x6DE740")]
		private TaskAwaiter<global::DAOEJNFJJPJ<bool, PCIJMHLMKIF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x49721D0", Offset = "0x4970BD0", VA = "0x1849721D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4972400", Offset = "0x4970E00", VA = "0x184972400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct LAMGDJDDNBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DF3A0", Offset = "0x6DE7A0")]
		public AsyncTaskMethodBuilder<global::DAOEJNFJJPJ<LEKKGHCNCEK, PCIJMHLMKIF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public LOCBHAFLAKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DF400", Offset = "0x6DE800")]
		private TaskAwaiter<global::DAOEJNFJJPJ<LEKKGHCNCEK, PCIJMHLMKIF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x496EE00", Offset = "0x496D800", VA = "0x18496EE00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x496EF90", Offset = "0x496D990", VA = "0x18496EF90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct IJFABFFAAOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DF460", Offset = "0x6DE860")]
		public AsyncTaskMethodBuilder<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public LOCBHAFLAKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public BDNOBKCCDPH action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x496CA60", Offset = "0x496B460", VA = "0x18496CA60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x496CC00", Offset = "0x496B600", VA = "0x18496CC00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct DOBBECIEFHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DF4C0", Offset = "0x6DE8C0")]
		public AsyncTaskMethodBuilder<global::DAOEJNFJJPJ<LEKKGHCNCEK, PCIJMHLMKIF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public LOCBHAFLAKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DF520", Offset = "0x6DE920")]
		private TaskAwaiter<global::DAOEJNFJJPJ<LEKKGHCNCEK, PCIJMHLMKIF>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DF580", Offset = "0x6DE980")]
		private TaskAwaiter<global::DAOEJNFJJPJ<bool, PCIJMHLMKIF>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4965EF0", Offset = "0x49648F0", VA = "0x184965EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x49666F0", Offset = "0x49650F0", VA = "0x1849666F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DEC40", Offset = "0x6DE040")]
	private readonly global::JKMOEKGCPOM<EJMOAPMNGEL> KINLFIEHPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly LFFHFMAGDOD INLFLGOHKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly MNEEGBPAHJG CMMLEIKBOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly FOOKOIAKPIG HOGPINGPEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly CEIPFNODIPL.HLOIHHOEJBC JGBMLOPNBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly LGBGOPDAAOO GGMCBDHMALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly KFKCMFABOLB EOFEHIILPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly OMMOCONOFOL LGBCHBAEGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private DOPHOCMHFBF AIPPKIBLJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	internal readonly MNEEGBPAHJG.HKPCNJBCGDG PNJNFKONNOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly EJMMHGIKCHN HJEPNEMLNBM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public MNEEGBPAHJG NOBDGLFOPLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xBE1510", Offset = "0xBDFF10", VA = "0x180BE1510")]
		get
		{
			return default(MNEEGBPAHJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal JIPIMLDPMNP LLAIILPIFGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4970040", Offset = "0x496EA40", VA = "0x184970040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal FJDFMLPGFAO NOIKFDKCMFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x895EB0", Offset = "0x8948B0", VA = "0x180895EB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x895F00", Offset = "0x894900", VA = "0x180895F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool DAKCDIOKICE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xEFD5B0", Offset = "0xEFBFB0", VA = "0x180EFD5B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xEFD6B0", Offset = "0xEFC0B0", VA = "0x180EFD6B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public LJINNHOPCDP JNOBGCPPHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7D6740", Offset = "0x7D5140", VA = "0x1807D6740", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IAALAPHFDHA GKGKGHIGAIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7D70B0", Offset = "0x7D5AB0", VA = "0x1807D70B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IFAFCIOCDJM PKPFMHCNAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7D6780", Offset = "0x7D5180", VA = "0x1807D6780", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private DNNGJJOMGAC? OAPBNNAPGIN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4970090", Offset = "0x496EA90", VA = "0x184970090", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private AJCOPPHGCHE? CJLNOAGNJLO
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x496FF10", Offset = "0x496E910", VA = "0x18496FF10", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4970B40", Offset = "0x496F540", VA = "0x184970B40")]
	private LOCBHAFLAKB(FOOKOIAKPIG NBNNHBDAJHF, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DECA0", Offset = "0x6DE0A0")] global::JKMOEKGCPOM<EJMOAPMNGEL> LFEHPMJHPFJ, LFFHFMAGDOD DPJOGKMMJOL, MNEEGBPAHJG MFOBOPGILLD, FJDFMLPGFAO PADNNEGLENL, in CEIPFNODIPL.HLOIHHOEJBC KPPFBCBDKLO, MNEEGBPAHJG.HKPCNJBCGDG MMPIPJOELJP, EJMMHGIKCHN FFIGPELMGOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x49701C0", Offset = "0x496EBC0", VA = "0x1849701C0")]
	public static LOCBHAFLAKB IDLIIDOEAFG(FOOKOIAKPIG KIMLKGPEIDL, MNEEGBPAHJG.FNEOIAEGDIM CINPEGLAIOM, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DED00", Offset = "0x6DE100")] global::JKMOEKGCPOM<EJMOAPMNGEL> LFEHPMJHPFJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DED60", Offset = "0x6DE160")] global::JKMOEKGCPOM<FKHEGJAMPKG> KABFBKOGANC, PECPPOEDGCC ONFKCAGLEMD, BPCMNALGGNI HLCFMNGDPIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4970270", Offset = "0x496EC70", VA = "0x184970270")]
	public static LOCBHAFLAKB IDLIIDOEAFG(FOOKOIAKPIG NBNNHBDAJHF, in MNEEGBPAHJG MFOBOPGILLD, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DEDC0", Offset = "0x6DE1C0")] global::JKMOEKGCPOM<EJMOAPMNGEL> LFEHPMJHPFJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DEE20", Offset = "0x6DE220")] global::JKMOEKGCPOM<FKHEGJAMPKG> KABFBKOGANC, PECPPOEDGCC ONFKCAGLEMD, BPCMNALGGNI HLCFMNGDPIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x496F980", Offset = "0x496E380", VA = "0x18496F980", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x49705E0", Offset = "0x496EFE0", VA = "0x1849705E0")]
	[AsyncStateMachine(typeof(PGILJCKMNPA))]
	[FGCFFGCIPKG("This should be a separate method `RequestInitializeFromSave()` which does the versioning for you and has no parameters. We should have an additional method`RequestInitializeFromSnapshot()` which requires the parameters.")]
	public Task<global::DAOEJNFJJPJ<bool, PCIJMHLMKIF?>>? IFADBDOCFCI(DGKGPJMHHCJ? CFECPIOHNOK, LHIEOLPDLKP? KNHIBFPGGCC, OJPOLICDEIN? IDDLPCBPDDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x49707E0", Offset = "0x496F1E0", VA = "0x1849707E0")]
	[AsyncStateMachine(typeof(LAMGDJDDNBE))]
	public Task<global::DAOEJNFJJPJ<LEKKGHCNCEK, PCIJMHLMKIF>> NFJGJCEJAEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4970900", Offset = "0x496F300", VA = "0x184970900")]
	internal void OJEJAIEEPKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4970760", Offset = "0x496F160", VA = "0x184970760")]
	internal global::DOMIPLFCMFE<BDNOBKCCDPH> NBAOAGBPGCA(in KKDKMMIMFJC GALMJDLACOG)
	{
		return default(global::DOMIPLFCMFE<BDNOBKCCDPH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x496F690", Offset = "0x496E090", VA = "0x18496F690")]
	internal bool APAMNGIJJCF(in KKDKMMIMFJC GALMJDLACOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x496F6F0", Offset = "0x496E0F0", VA = "0x18496F6F0")]
	[AsyncStateMachine(typeof(IJFABFFAAOE))]
	internal Task<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> BJGIECHGBLO(BDNOBKCCDPH DJJNLDOINEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x496FBA0", Offset = "0x496E5A0", VA = "0x18496FBA0")]
	private BDNOBKCCDPH[] EGPMPHFMILK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x496F830", Offset = "0x496E230", VA = "0x18496F830")]
	[AsyncStateMachine(typeof(DOBBECIEFHM))]
	public Task<global::DAOEJNFJJPJ<LEKKGHCNCEK, PCIJMHLMKIF>> DEOFIPCADAA(Guid CHJCCNCEPHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class BGHHPMBMAOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x383A7C0", Offset = "0x38391C0", VA = "0x18383A7C0")]
	public static global::GOOHMHGLEHM<(TPrev?, LOCBHAFLAKB?), AJCOPPHGCHE> DCMGLMLBANC<TPrev>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DF620", Offset = "0x6DEA20")] this in global::GOOHMHGLEHM<TPrev?, LOCBHAFLAKB?> IKHBPJOEIEB)
	{
		return default(global::GOOHMHGLEHM<(TPrev, LOCBHAFLAKB), AJCOPPHGCHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x383AA60", Offset = "0x3839460", VA = "0x18383AA60")]
	public static global::GOOHMHGLEHM<TPrev?, LOCBHAFLAKB?> EJEOBMCOMPO<TPrev>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DF690", Offset = "0x6DEA90")] this in global::GOOHMHGLEHM<TPrev?, LOCBHAFLAKB?> IKHBPJOEIEB)
	{
		return default(global::GOOHMHGLEHM<TPrev, LOCBHAFLAKB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface FOOKOIAKPIG
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	BNBJHFKLBOJ.HKOMPEMLNON PJMKBDBMGFE
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	GFDLFKLHEEO.ONEIDCCMKKM NGHNCMCMBPI
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	LOCBHAFLAKB.JIPIMLDPMNP GFBHKMJKCNA
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	IHJIFALALPI.HCBBMAOAHIB JBHIABEEJKL
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	GJDCAHCJAOL NGBGDCAOIIC
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class LHIILCNLOAK
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x496EFE0", Offset = "0x496D9E0", VA = "0x18496EFE0")]
	public static BDNOBKCCDPH AEKCJGOEOKK(this BDNOBKCCDPH IKHBPJOEIEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x496F0F0", Offset = "0x496DAF0", VA = "0x18496F0F0")]
	public static BDNOBKCCDPH JHEINKDLBLG(this GMMLGPIDCDJ IKHBPJOEIEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct GMMLGPIDCDJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct ACNHPMLOCEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DF7F0", Offset = "0x6DEBF0")]
		public AsyncTaskMethodBuilder<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public LOCBHAFLAKB root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public GMMLGPIDCDJ self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DF850", Offset = "0x6DEC50")]
		private TaskAwaiter<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4963E80", Offset = "0x4962880", VA = "0x184963E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4964020", Offset = "0x4962A20", VA = "0x184964020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly ByteString ONBMIOJBCHK;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x875C70", Offset = "0x874670", VA = "0x180875C70")]
	private GMMLGPIDCDJ(ByteString MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x496A9D0", Offset = "0x49693D0", VA = "0x18496A9D0")]
	public static BDNOBKCCDPH CNPJOBBPGBB(ByteString MFBGAMJDOKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x496A920", Offset = "0x4969320", VA = "0x18496A920")]
	public static global::FKMCMMBLGFF<MLLDPAIKBLN, GMMLGPIDCDJ> BOMDCKBFMIG(BDNOBKCCDPH JGCAHALAOHG)
	{
		return default(global::FKMCMMBLGFF<MLLDPAIKBLN, GMMLGPIDCDJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x496A7E0", Offset = "0x49691E0", VA = "0x18496A7E0")]
	[AsyncStateMachine(typeof(ACNHPMLOCEF))]
	public static Task<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> BJGIECHGBLO(LOCBHAFLAKB MNGLAEJHIMG, GMMLGPIDCDJ IKHBPJOEIEB)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct ECGMFCKCJJG
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4966960", Offset = "0x4965360", VA = "0x184966960")]
	public static BDNOBKCCDPH CNPJOBBPGBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x49668F0", Offset = "0x49652F0", VA = "0x1849668F0")]
	public static global::FKMCMMBLGFF<MLLDPAIKBLN, ECGMFCKCJJG> BOMDCKBFMIG(BDNOBKCCDPH JGCAHALAOHG)
	{
		return default(global::FKMCMMBLGFF<MLLDPAIKBLN, ECGMFCKCJJG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4966870", Offset = "0x4965270", VA = "0x184966870")]
	public static global::DAOEJNFJJPJ<LEKKGHCNCEK, NNOGOJMPBNO> BJKLJBGJKDK(LOCBHAFLAKB MNGLAEJHIMG, in ECGMFCKCJJG IKHBPJOEIEB)
	{
		return default(global::DAOEJNFJJPJ<LEKKGHCNCEK, NNOGOJMPBNO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct BAAOBDCCKCM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct BMACIAAHAMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DF910", Offset = "0x6DED10")]
		public AsyncTaskMethodBuilder<global::DAOEJNFJJPJ<LEKKGHCNCEK, NNOGOJMPBNO?>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public LOCBHAFLAKB root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public BAAOBDCCKCM self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DF970", Offset = "0x6DED70")]
		private global::DAOEJNFJJPJ<LEKKGHCNCEK, NNOGOJMPBNO?> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x49643C0", Offset = "0x4962DC0", VA = "0x1849643C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x49646D0", Offset = "0x49630D0", VA = "0x1849646D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly DGKGPJMHHCJ? PPPPOJBEKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly LHIEOLPDLKP? DBNAGENMLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly OJPOLICDEIN? CNKOILFKDGI;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x875B60", Offset = "0x874560", VA = "0x180875B60")]
	private BAAOBDCCKCM(DGKGPJMHHCJ? CFECPIOHNOK, LHIEOLPDLKP? KNHIBFPGGCC, OJPOLICDEIN? IDDLPCBPDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x49642D0", Offset = "0x4962CD0", VA = "0x1849642D0")]
	public static BDNOBKCCDPH? CNPJOBBPGBB(DGKGPJMHHCJ? CFECPIOHNOK, LHIEOLPDLKP? KNHIBFPGGCC, OJPOLICDEIN? IDDLPCBPDDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x49641C0", Offset = "0x4962BC0", VA = "0x1849641C0")]
	public static global::FKMCMMBLGFF<MLLDPAIKBLN, BAAOBDCCKCM> BOMDCKBFMIG(BDNOBKCCDPH JGCAHALAOHG)
	{
		return default(global::FKMCMMBLGFF<MLLDPAIKBLN, BAAOBDCCKCM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4964070", Offset = "0x4962A70", VA = "0x184964070")]
	[AsyncStateMachine(typeof(BMACIAAHAMD))]
	public static Task<global::DAOEJNFJJPJ<LEKKGHCNCEK, NNOGOJMPBNO>> BJGIECHGBLO(LOCBHAFLAKB MNGLAEJHIMG, BAAOBDCCKCM IKHBPJOEIEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct FNFPFNANMIH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct JNLLCLAMAIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DFA60", Offset = "0x6DEE60")]
		public AsyncTaskMethodBuilder<global::DAOEJNFJJPJ<DGLEMNOHALK, PCIJMHLMKIF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public FNFPFNANMIH self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public LOCBHAFLAKB root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DFAC0", Offset = "0x6DEEC0")]
		private global::DAOEJNFJJPJ<DGLEMNOHALK, PCIJMHLMKIF> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DFB20", Offset = "0x6DEF20")]
		private global::DAOEJNFJJPJ<object, GEPHFINPONA>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DFB80", Offset = "0x6DEF80")]
		private global::DAOEJNFJJPJ<object, GEPHFINPONA> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DFBE0", Offset = "0x6DEFE0")]
		private TaskAwaiter<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x496D600", Offset = "0x496C000", VA = "0x18496D600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x496D9F0", Offset = "0x496C3F0", VA = "0x18496D9F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly IReadOnlyList<BDNOBKCCDPH> JJFDCEHGPCF;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x875C70", Offset = "0x874670", VA = "0x180875C70")]
	private FNFPFNANMIH(IReadOnlyList<BDNOBKCCDPH> PMCDLKFEOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4969690", Offset = "0x4968090", VA = "0x184969690")]
	public static BDNOBKCCDPH CNPJOBBPGBB(IReadOnlyList<BDNOBKCCDPH> PMCDLKFEOPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x49695F0", Offset = "0x4967FF0", VA = "0x1849695F0")]
	public static global::FKMCMMBLGFF<MLLDPAIKBLN, FNFPFNANMIH> BOMDCKBFMIG(BDNOBKCCDPH JGCAHALAOHG)
	{
		return default(global::FKMCMMBLGFF<MLLDPAIKBLN, FNFPFNANMIH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x49694B0", Offset = "0x4967EB0", VA = "0x1849694B0")]
	[AsyncStateMachine(typeof(JNLLCLAMAIB))]
	public static Task<global::DAOEJNFJJPJ<DGLEMNOHALK, PCIJMHLMKIF>> BJGIECHGBLO(LOCBHAFLAKB MNGLAEJHIMG, FNFPFNANMIH IKHBPJOEIEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct KKDKMMIMFJC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct DGEPIFGLFOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DFC90", Offset = "0x6DF090")]
		public AsyncTaskMethodBuilder<global::DAOEJNFJJPJ<bool, NNOGOJMPBNO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public LOCBHAFLAKB root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public KKDKMMIMFJC self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DFCF0", Offset = "0x6DF0F0")]
		private global::DAOEJNFJJPJ<bool, NNOGOJMPBNO> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DFD50", Offset = "0x6DF150")]
		private TaskAwaiter<global::DAOEJNFJJPJ<LEKKGHCNCEK, NNOGOJMPBNO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x49658C0", Offset = "0x49642C0", VA = "0x1849658C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4965EA0", Offset = "0x49648A0", VA = "0x184965EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly int GNKNLJGDNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly int EOGKCECFNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly byte[] LAEHDPABEIH;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2507180", Offset = "0x2505B80", VA = "0x182507180")]
	private KKDKMMIMFJC(int HGMGPFAJPJI, int ALJOMNDNEBM, byte[] MNILNHMNKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x496E9E0", Offset = "0x496D3E0", VA = "0x18496E9E0")]
	public static BDNOBKCCDPH CNPJOBBPGBB(int HGMGPFAJPJI, int ALJOMNDNEBM, ByteString MNILNHMNKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x496EAC0", Offset = "0x496D4C0", VA = "0x18496EAC0")]
	public static BDNOBKCCDPH?[]? KPJJEKNBDOB(int EOHNPMNNACI, DGKGPJMHHCJ? CFECPIOHNOK, LHIEOLPDLKP? KNHIBFPGGCC, OJPOLICDEIN? IDDLPCBPDDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x496E900", Offset = "0x496D300", VA = "0x18496E900")]
	public static global::FKMCMMBLGFF<MLLDPAIKBLN, KKDKMMIMFJC> BOMDCKBFMIG(BDNOBKCCDPH JGCAHALAOHG)
	{
		return default(global::FKMCMMBLGFF<MLLDPAIKBLN, KKDKMMIMFJC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x496E7C0", Offset = "0x496D1C0", VA = "0x18496E7C0")]
	[AsyncStateMachine(typeof(DGEPIFGLFOG))]
	public static Task<global::DAOEJNFJJPJ<bool, NNOGOJMPBNO>> BJGIECHGBLO(LOCBHAFLAKB MNGLAEJHIMG, KKDKMMIMFJC IKHBPJOEIEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal static class PCDBIFOOLPG
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class MJJPBMHKKLK<TGraph> : MCEFJGHJHEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		protected readonly TGraph HJJMOOEEJGA;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public virtual ENLJPOMFPDA? HJMPGGNCLJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x26D68D0", Offset = "0x26D52D0", VA = "0x1826D68D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x34E7CA0", Offset = "0x34E66A0", VA = "0x1834E7CA0")]
		public MJJPBMHKKLK(TGraph POGLEAIHAIK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DFDB0", Offset = "0x6DF1B0")]
	private sealed class DPABNEADCKE : MJJPBMHKKLK<NJMANHBGGHJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override ENLJPOMFPDA? HJMPGGNCLJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x406CCD0", Offset = "0x406B6D0", VA = "0x18406CCD0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x49667A0", Offset = "0x49651A0", VA = "0x1849667A0")]
		public DPABNEADCKE(NJMANHBGGHJ CJIDKICMLLF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4972050", Offset = "0x4970A50", VA = "0x184972050")]
	public static MCEFJGHJHEH IDLIIDOEAFG(KFNDAELMEFJ POGLEAIHAIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class FHMLCMGDNNE
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class BAAMCGLDEFB<TNode> : DBJMGDBOPBM where TNode : IJMDHCHELAG?
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[CompilerGenerated]
		private Action<int>? KMGMJGJMPGE;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		protected TNode CJNBJKFNLCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object HMIBJCBNLDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x25114D0", Offset = "0x250FED0", VA = "0x1825114D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Guid EJGAABFMHPF
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x4695230", Offset = "0x4693C30", VA = "0x184695230", Slot = "5")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Guid KPEEJHGOIJK
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x4695470", Offset = "0x4693E70", VA = "0x184695470", Slot = "6")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public virtual string KPDCCEJPHFL
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "66")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7D2590", Offset = "0x7D0F90", VA = "0x1807D2590", Slot = "67")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool DHMBKACNNOH
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x4695180", Offset = "0x4693B80", VA = "0x184695180", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public virtual bool ICHALELMALD
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7FDE80", Offset = "0x7FC880", VA = "0x1807FDE80", Slot = "68")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public int BGBMACABLOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x4695200", Offset = "0x4693C00", VA = "0x184695200", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public PBGDJAJMFOL BBCOJDNMAHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x46951C0", Offset = "0x4693BC0", VA = "0x1846951C0", Slot = "13")]
			get
			{
				return default(PBGDJAJMFOL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public virtual NodeVisualizationKey LAPHJCILMHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x7373B0", Offset = "0x735DB0", VA = "0x1807373B0", Slot = "71")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DFFB0", Offset = "0x6DF3B0")]
		public global::JKMOEKGCPOM<GOMEMMEIIJD?> CMDGDJFIDGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x7D3CF0", Offset = "0x7D26F0", VA = "0x1807D3CF0", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(global::JKMOEKGCPOM<GOMEMMEIIJD>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x7D4380", Offset = "0x7D2D80", VA = "0x1807D4380")]
			[CompilerGenerated]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DFF50", Offset = "0x6DF350")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public virtual bool PPHDKJKLGAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7373D0", Offset = "0x735DD0", VA = "0x1807373D0", Slot = "72")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public virtual Guid OCPKOAFJPFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x4695270", Offset = "0x4693C70", VA = "0x184695270", Slot = "73")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public virtual bool ALBKNHCNPOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x7373D0", Offset = "0x735DD0", VA = "0x1807373D0", Slot = "74")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public virtual bool KCGJNLCFFKA
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x7373D0", Offset = "0x735DD0", VA = "0x1807373D0", Slot = "75")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool INBICKDOCCC
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x3F7F4E0", Offset = "0x3F7DEE0", VA = "0x183F7F4E0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool NPMFOKNBFJH
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x3F7F4A0", Offset = "0x3F7DEA0", VA = "0x183F7F4A0", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public virtual bool KKMAMJOBFAH
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x7373D0", Offset = "0x735DD0", VA = "0x1807373D0", Slot = "76")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool JDOHJMKPPFD
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x3F7F520", Offset = "0x3F7DF20", VA = "0x183F7F520", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public int KJCGLDJEHMC
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x4695440", Offset = "0x4693E40", VA = "0x184695440", Slot = "24")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool KKLKFKFBKFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x4695390", Offset = "0x4693D90", VA = "0x184695390", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool DNFLPGCGCOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x4695340", Offset = "0x4693D40", VA = "0x184695340", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public string CCDKBGBFHFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x46952D0", Offset = "0x4693CD0", VA = "0x1846952D0", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public virtual bool KNOGLBFJFEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x7373D0", Offset = "0x735DD0", VA = "0x1807373D0", Slot = "77")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool MPFICAPBPMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x4695140", Offset = "0x4693B40", VA = "0x184695140", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool NJGACAKBLDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x884700", Offset = "0x883100", VA = "0x180884700", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x8848C0", Offset = "0x8832C0", VA = "0x1808848C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public virtual bool PFPFBLNBBII
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x7373D0", Offset = "0x735DD0", VA = "0x1807373D0", Slot = "78")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public virtual bool LBDNHGOOOGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x4695100", Offset = "0x4693B00", VA = "0x184695100", Slot = "79")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool CALLMKCFDGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x4695300", Offset = "0x4693D00", VA = "0x184695300", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public OCMKEFEOMKM ICHCLDFIPAC
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x46953C0", Offset = "0x4693DC0", VA = "0x1846953C0", Slot = "34")]
			get
			{
				return default(OCMKEFEOMKM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public KHNNLKCFFOP MKBNFPHEILA
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x4695400", Offset = "0x4693E00", VA = "0x184695400", Slot = "36")]
			get
			{
				return default(KHNNLKCFFOP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public virtual bool KJEJIIDKCHM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x7373D0", Offset = "0x735DD0", VA = "0x1807373D0", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public virtual bool DCGOJFCEFCJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7373D0", Offset = "0x735DD0", VA = "0x1807373D0", Slot = "94")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public virtual JMOLPNHDPKC? AIGHOENAJOL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x7373B0", Offset = "0x735DB0", VA = "0x1807373B0", Slot = "95")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public virtual OJJHHFPICJD? JILLGDBJCHH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x7373B0", Offset = "0x735DB0", VA = "0x1807373B0", Slot = "96")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0010", Offset = "0x6DF410")]
		public virtual IEnumerable<IJMDHCHELAG?>? ODFDNFOFMPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x7373B0", Offset = "0x735DB0", VA = "0x1807373B0", Slot = "97")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action? DNMFNLHOCEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x4694CC0", Offset = "0x46936C0", VA = "0x184694CC0", Slot = "41")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x4694660", Offset = "0x4693060", VA = "0x184694660", Slot = "42")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event FHADPLBANHD? LGDCOEPNFAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x46940E0", Offset = "0x4692AE0", VA = "0x1846940E0", Slot = "43")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x46948F0", Offset = "0x46932F0", VA = "0x1846948F0", Slot = "44")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event CJLMKEDHMCB? LDFOKGCCBPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x46949C0", Offset = "0x46933C0", VA = "0x1846949C0", Slot = "45")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x46944F0", Offset = "0x4692EF0", VA = "0x1846944F0", Slot = "46")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action? CBDCHEAHPCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x4694750", Offset = "0x4693150", VA = "0x184694750", Slot = "47")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x4694840", Offset = "0x4693240", VA = "0x184694840", Slot = "48")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public virtual event Action<int>? LBIKEHKILJA
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x4693C70", Offset = "0x4692670", VA = "0x184693C70", Slot = "83")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x4694B40", Offset = "0x4693540", VA = "0x184694B40", Slot = "84")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action? GOEDMLEGPOO
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x4694BD0", Offset = "0x46935D0", VA = "0x184694BD0", Slot = "51")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x4693BC0", Offset = "0x46925C0", VA = "0x184693BC0", Slot = "52")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4694DE0", Offset = "0x46937E0", VA = "0x184694DE0")]
		[FGCFFGCIPKG("Need to handle `Name` better.")]
		public BAAMCGLDEFB(TNode GBBOAEGAMHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x4693DB0", Offset = "0x46927B0", VA = "0x184693DB0", Slot = "69")]
		public virtual void CJFIEIBIELL(string EADDAKLOGHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x4694AC0", Offset = "0x46934C0", VA = "0x184694AC0", Slot = "70")]
		public virtual void LOGIOOFAOIB(int KCOABAJPMAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4694090", Offset = "0x4692A90", VA = "0x184694090")]
		public void EGKMOCALEBJ(in OCMKEFEOMKM MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x46944A0", Offset = "0x4692EA0", VA = "0x1846944A0")]
		public void HFAOKGBEHGM(in KHNNLKCFFOP MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x4694800", Offset = "0x4693200", VA = "0x184694800", Slot = "80")]
		public virtual void KAOOPJPJNEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "81")]
		public virtual void AFHPOPJNFPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "82")]
		public virtual void EEEJNMOODGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1F43F20", Offset = "0x1F42920", VA = "0x181F43F20")]
		protected void CDLIECHNKOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x19AE8C0", Offset = "0x19AD2C0", VA = "0x1819AE8C0")]
		protected void ENDPOFAEKDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x4694190", Offset = "0x4692B90", VA = "0x184694190")]
		private void FNCNNFDJHKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x4693E30", Offset = "0x4692830", VA = "0x184693E30", Slot = "85")]
		public virtual void EDMHNICKBIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x46949A0", Offset = "0x46933A0", VA = "0x1846949A0")]
		private void KKBNMICBDBM(in OCMKEFEOMKM LHCEFCJDGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x4694BB0", Offset = "0x46935B0", VA = "0x184694BB0")]
		private void NBKLJGNHPBM(in KHNNLKCFFOP FDBNIAOOEMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x4694A70", Offset = "0x4693470", VA = "0x184694A70")]
		private void LABDENGIKCF(int ALJOMNDNEBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x46945A0", Offset = "0x4692FA0", VA = "0x1846945A0")]
		private void HIJHAOFDNLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x4694B00", Offset = "0x4693500", VA = "0x184694B00", Slot = "86")]
		public virtual bool MBHBOJBBALM(int COLJAJBODOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x4694C80", Offset = "0x4693680", VA = "0x184694C80", Slot = "87")]
		public virtual void NEAAGELNIDK(string KMEGKECOLPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4694710", Offset = "0x4693110", VA = "0x184694710", Slot = "88")]
		public virtual void IANEGJJNDMD(int ALJOMNDNEBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x4693CB0", Offset = "0x46926B0", VA = "0x184693CB0", Slot = "89")]
		public virtual IEnumerable<BDNOBKCCDPH> CAHLGCAMAAO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x4694D70", Offset = "0x4693770", VA = "0x184694D70", Slot = "57")]
		public global::DAOEJNFJJPJ<LEKKGHCNCEK, PCIJMHLMKIF> OEBOBIKBMFI(string EADDAKLOGHO)
		{
			return default(global::DAOEJNFJJPJ<LEKKGHCNCEK, PCIJMHLMKIF>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x4694320", Offset = "0x4692D20", VA = "0x184694320", Slot = "58")]
		public bool HCJPOJOHKNB(out Guid OKGJDJPHJBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4693DF0", Offset = "0x46927F0", VA = "0x184693DF0", Slot = "90")]
		public virtual bool DMAJOCHGGNM(in Guid HPEIPIPPKPE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x4693D70", Offset = "0x4692770", VA = "0x184693D70", Slot = "91")]
		public virtual void CIPJLEDKNPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "92")]
		public virtual void AIJOMDMMFKG(bool KBCFCALPJHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x4694260", Offset = "0x4692C60", VA = "0x184694260", Slot = "65")]
		public HIMAPHINPEC GNEAIDMBMLF()
		{
			return default(HIMAPHINPEC);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x410B890", Offset = "0x410A290", VA = "0x18410B890", Slot = "35")]
		private void FCHCFEDEFPO(in OCMKEFEOMKM MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x4694B80", Offset = "0x4693580", VA = "0x184694B80", Slot = "37")]
		private void MPGFFEFGPPB(in KHNNLKCFFOP MFBGAMJDOKA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4969440", Offset = "0x4967E40", VA = "0x184969440")]
	internal static DBJMGDBOPBM IDLIIDOEAFG(IJMDHCHELAG GBBOAEGAMHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class IHJIFALALPI : JBMKBCOAINH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface HCBBMAOAHIB
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		HFJLCINNLCM MGIDKKJEDEP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<LHIEOLPDLKP> GFHANAMKLBL(CancellationToken FAPLHFKLMOL);

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<OJPOLICDEIN> AMOHNFEOGPJ(CancellationToken FAPLHFKLMOL);

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<HPIHEAOFAFL> AAEDLLDILAO(CancellationToken FAPLHFKLMOL);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct OAIHILONLHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<IHJIFALALPI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public LOCBHAFLAKB circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public LHIEOLPDLKP roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public OJPOLICDEIN superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private HCBBMAOAHIB <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private OJPOLICDEIN <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E00E0", Offset = "0x6DF4E0")]
		private TaskAwaiter<LHIEOLPDLKP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0140", Offset = "0x6DF540")]
		private TaskAwaiter<OJPOLICDEIN> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E01A0", Offset = "0x6DF5A0")]
		private TaskAwaiter<HPIHEAOFAFL> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4971410", Offset = "0x496FE10", VA = "0x184971410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4971BA0", Offset = "0x49705A0", VA = "0x184971BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly CEIPFNODIPL NJMFFAAAFLK;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public CEIPFNODIPL CCMIDDFAHAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x82DEC0", Offset = "0x82C8C0", VA = "0x18082DEC0")]
	private IHJIFALALPI(CEIPFNODIPL JPNFNPIKKDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x496C7A0", Offset = "0x496B1A0", VA = "0x18496C7A0")]
	[AsyncStateMachine(typeof(OAIHILONLHK))]
	public static Task<IHJIFALALPI> AIEGLGGAGMD(LOCBHAFLAKB GAMCJNFOIFI, LHIEOLPDLKP? EIFFMACPBMC, OJPOLICDEIN? IDDLPCBPDDP, CancellationToken FAPLHFKLMOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x496C920", Offset = "0x496B320", VA = "0x18496C920", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class BNBJHFKLBOJ : CFDKJILCGGD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public interface HKOMPEMLNON
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<JBMKBCOAINH> AKIECAOEBKE(LOCBHAFLAKB GAMCJNFOIFI, LHIEOLPDLKP? DGFMIMDCALP, OJPOLICDEIN? IAMKAILKGFN, CancellationToken FAPLHFKLMOL);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		PAPKGGACHLN GIIDAJDGMBC(LOCBHAFLAKB GAMCJNFOIFI, DGKGPJMHHCJ PIIEIJKAAPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class BMBOPADALCC : HKOMPEMLNON
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private struct FENPHALEMDG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AsyncTaskMethodBuilder<JBMKBCOAINH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public LOCBHAFLAKB circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public LHIEOLPDLKP cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public OJPOLICDEIN cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E02E0", Offset = "0x6DF6E0")]
			private TaskAwaiter<IHJIFALALPI> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x49690F0", Offset = "0x4967AF0", VA = "0x1849690F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x49693F0", Offset = "0x4967DF0", VA = "0x1849693F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly BMBOPADALCC FINLHCLDLDF;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		private BMBOPADALCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4964720", Offset = "0x4963120", VA = "0x184964720", Slot = "4")]
		[AsyncStateMachine(typeof(FENPHALEMDG))]
		public Task<JBMKBCOAINH> AKIECAOEBKE(LOCBHAFLAKB GAMCJNFOIFI, LHIEOLPDLKP? DGFMIMDCALP, OJPOLICDEIN? IAMKAILKGFN, CancellationToken FAPLHFKLMOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4964890", Offset = "0x4963290", VA = "0x184964890", Slot = "5")]
		public PAPKGGACHLN GIIDAJDGMBC(LOCBHAFLAKB GAMCJNFOIFI, DGKGPJMHHCJ PIIEIJKAAPJ)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct IJPGNECFGAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public AsyncTaskMethodBuilder<BNBJHFKLBOJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public LOCBHAFLAKB circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public LHIEOLPDLKP cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public OJPOLICDEIN cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public DGKGPJMHHCJ evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private HKOMPEMLNON <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0340", Offset = "0x6DF740")]
		private TaskAwaiter<JBMKBCOAINH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x496CC50", Offset = "0x496B650", VA = "0x18496CC50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x496D0A0", Offset = "0x496BAA0", VA = "0x18496D0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly JBMKBCOAINH DCOPOJMOCJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly PAPKGGACHLN MGFACDJFFOL;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DNNGJJOMGAC KKEKKHKMJII
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4964BD0", Offset = "0x49635D0", VA = "0x184964BD0", Slot = "4")]
		get
		{
			return default(DNNGJJOMGAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public AJCOPPHGCHE FEHJPGLHPPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x4964B70", Offset = "0x4963570", VA = "0x184964B70", Slot = "5")]
		get
		{
			return default(AJCOPPHGCHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public EFFBNMKJGLJ FHMMFICCODH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public MDMELGEFHHJ ODAHEBDONKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x737430", Offset = "0x735E30", VA = "0x180737430", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x19C2840", Offset = "0x19C1240", VA = "0x1819C2840")]
	private BNBJHFKLBOJ(JBMKBCOAINH AOLKLCHPOGB, PAPKGGACHLN DAFCLLCMEDI, EFFBNMKJGLJ CMDPNINKCOK, MDMELGEFHHJ ENBPFDMAMNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4964980", Offset = "0x4963380", VA = "0x184964980")]
	[AsyncStateMachine(typeof(IJPGNECFGAJ))]
	public static Task<BNBJHFKLBOJ> AIEGLGGAGMD(LOCBHAFLAKB GAMCJNFOIFI, DGKGPJMHHCJ PIIEIJKAAPJ, LHIEOLPDLKP? DGFMIMDCALP, OJPOLICDEIN? IAMKAILKGFN, CancellationToken FAPLHFKLMOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4964B10", Offset = "0x4963510", VA = "0x184964B10", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class GFDLFKLHEEO : FJDFMLPGFAO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface ONEIDCCMKKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CFDKJILCGGD> OOOCFOJBJIK(LOCBHAFLAKB GAMCJNFOIFI, DGKGPJMHHCJ PIIEIJKAAPJ, LHIEOLPDLKP? DGFMIMDCALP, OJPOLICDEIN? IAMKAILKGFN, CancellationToken FAPLHFKLMOL);

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FNNMFIBDJBB();

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void IDAMDJFNMBM();
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public abstract class EJMJOIJAACP : ONEIDCCMKKM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private struct ELFCJKJOAGF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<CFDKJILCGGD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public LOCBHAFLAKB circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public DGKGPJMHHCJ evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public LHIEOLPDLKP cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public OJPOLICDEIN cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E04E0", Offset = "0x6DF8E0")]
			private TaskAwaiter<BNBJHFKLBOJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x4968960", Offset = "0x4967360", VA = "0x184968960", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x4968C70", Offset = "0x4967670", VA = "0x184968C70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x4968080", Offset = "0x4966A80", VA = "0x184968080", Slot = "4")]
		[AsyncStateMachine(typeof(ELFCJKJOAGF))]
		public Task<CFDKJILCGGD> OOOCFOJBJIK(LOCBHAFLAKB GAMCJNFOIFI, DGKGPJMHHCJ PIIEIJKAAPJ, LHIEOLPDLKP? DGFMIMDCALP, OJPOLICDEIN? IAMKAILKGFN, CancellationToken FAPLHFKLMOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void FNNMFIBDJBB();

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void IDAMDJFNMBM();

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		protected EJMJOIJAACP()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct NPKBHDGDALE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder<CFDKJILCGGD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public GFDLFKLHEEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter<LEKKGHCNCEK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x4971190", Offset = "0x496FB90", VA = "0x184971190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x4971330", Offset = "0x496FD30", VA = "0x184971330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct JKIPMGCJMOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public GFDLFKLHEEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public LOCBHAFLAKB circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public DGKGPJMHHCJ evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public LHIEOLPDLKP cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public OJPOLICDEIN cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0540", Offset = "0x6DF940")]
		private TaskAwaiter<CFDKJILCGGD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x496D0F0", Offset = "0x496BAF0", VA = "0x18496D0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9396C0", Offset = "0x9380C0", VA = "0x1809396C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly ONEIDCCMKKM FHGLBJEIIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly TaskCompletionSource<LEKKGHCNCEK> HDPFLFAHACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly TaskCompletionSource<LEKKGHCNCEK> GBIPHHMOEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly CancellationTokenSource CGOKBIFMDAC;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool DAKCDIOKICE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x83BF80", Offset = "0x83A980", VA = "0x18083BF80", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x83BFA0", Offset = "0x83A9A0", VA = "0x18083BFA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool FFCJMMOGLGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x83BF90", Offset = "0x83A990", VA = "0x18083BF90", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x83BFB0", Offset = "0x83A9B0", VA = "0x18083BFB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool PJKBDAJACGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xDC90D0", Offset = "0xDC7AD0", VA = "0x180DC90D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xDC9170", Offset = "0xDC7B70", VA = "0x180DC9170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public CFDKJILCGGD? CLKLBEIBBGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7374F0", Offset = "0x735EF0", VA = "0x1807374F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8464B0", Offset = "0x844EB0", VA = "0x1808464B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x496A2F0", Offset = "0x4968CF0", VA = "0x18496A2F0", Slot = "7")]
	[AsyncStateMachine(typeof(NPKBHDGDALE))]
	public Task<CFDKJILCGGD> HBLOLDBCELF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x496A580", Offset = "0x4968F80", VA = "0x18496A580")]
	public GFDLFKLHEEO(ONEIDCCMKKM KIMLKGPEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x496A410", Offset = "0x4968E10", VA = "0x18496A410", Slot = "8")]
	[AsyncStateMachine(typeof(JKIPMGCJMOK))]
	public Task MDLDGFFMOGC(LOCBHAFLAKB GAMCJNFOIFI, DGKGPJMHHCJ PIIEIJKAAPJ, LHIEOLPDLKP? DGFMIMDCALP, OJPOLICDEIN? IAMKAILKGFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x496A140", Offset = "0x4968B40", VA = "0x18496A140", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct EJMMHGIKCHN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct MJDMDGLDMKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E06E0", Offset = "0x6DFAE0")]
		public AsyncTaskMethodBuilder<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public EJMMHGIKCHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public BDNOBKCCDPH action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private TaskAwaiter<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x4970FA0", Offset = "0x496F9A0", VA = "0x184970FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x4971140", Offset = "0x496FB40", VA = "0x184971140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct BNEILPGAHPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0740", Offset = "0x6DFB40")]
		public AsyncTaskMethodBuilder<global::DAOEJNFJJPJ<bool, PCIJMHLMKIF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public DGKGPJMHHCJ rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public LHIEOLPDLKP circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public OJPOLICDEIN superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public EJMMHGIKCHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E07A0", Offset = "0x6DFBA0")]
		private BDNOBKCCDPH[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0800", Offset = "0x6DFC00")]
		private TaskAwaiter<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4964C30", Offset = "0x4963630", VA = "0x184964C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4964F60", Offset = "0x4963960", VA = "0x184964F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct PMLHMIIDIJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0860", Offset = "0x6DFC60")]
		public AsyncTaskMethodBuilder<global::DAOEJNFJJPJ<LEKKGHCNCEK, PCIJMHLMKIF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public EJMMHGIKCHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E08C0", Offset = "0x6DFCC0")]
		private TaskAwaiter<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4972810", Offset = "0x4971210", VA = "0x184972810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x4972A70", Offset = "0x4971470", VA = "0x184972A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly PECPPOEDGCC KDFLGNKEHPL;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x875C70", Offset = "0x874670", VA = "0x180875C70")]
	public EJMMHGIKCHN(PECPPOEDGCC ONFKCAGLEMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4968320", Offset = "0x4966D20", VA = "0x184968320")]
	[AsyncStateMachine(typeof(MJDMDGLDMKA))]
	private Task<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> NOKPAJOFHOJ(BDNOBKCCDPH DJJNLDOINEG, bool HPNIJKGKNLH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4968470", Offset = "0x4966E70", VA = "0x184968470")]
	[AsyncStateMachine(typeof(BNEILPGAHPJ))]
	public Task<global::DAOEJNFJJPJ<bool, PCIJMHLMKIF?>>? OPCDDADDJAN(int EOHNPMNNACI, DGKGPJMHHCJ? CFECPIOHNOK, LHIEOLPDLKP? KNHIBFPGGCC, OJPOLICDEIN? IDDLPCBPDDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4968200", Offset = "0x4966C00", VA = "0x184968200")]
	[AsyncStateMachine(typeof(PMLHMIIDIJF))]
	public Task<global::DAOEJNFJJPJ<LEKKGHCNCEK, PCIJMHLMKIF>> EDLFOMBBBBL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class IFINPGIFEOG : PAPKGGACHLN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly LBJNIHPEGAB JAIEDBNJMLM;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public LBJNIHPEGAB MLODEJJGECO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x82DEC0", Offset = "0x82C8C0", VA = "0x18082DEC0")]
	private IFINPGIFEOG(LBJNIHPEGAB LEIBONLMGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x496C6F0", Offset = "0x496B0F0", VA = "0x18496C6F0")]
	public static IFINPGIFEOG AIBDMMJCKEC(LOCBHAFLAKB GAMCJNFOIFI, DGKGPJMHHCJ PIIEIJKAAPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x496C780", Offset = "0x496B180", VA = "0x18496C780", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[KMCFPCOAJNM("IStaticCV2Instance")]
public interface JBMKBCOAINH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	CEIPFNODIPL CCMIDDFAHAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface CFDKJILCGGD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	DNNGJJOMGAC KKEKKHKMJII
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	AJCOPPHGCHE FEHJPGLHPPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	EFFBNMKJGLJ FHMMFICCODH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	MDMELGEFHHJ ODAHEBDONKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface FJDFMLPGFAO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	CFDKJILCGGD? CLKLBEIBBGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool FFCJMMOGLGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool DAKCDIOKICE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<CFDKJILCGGD?>? HBLOLDBCELF();

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task MDLDGFFMOGC(LOCBHAFLAKB GAMCJNFOIFI, DGKGPJMHHCJ PIIEIJKAAPJ, LHIEOLPDLKP? DGFMIMDCALP, OJPOLICDEIN? IAMKAILKGFN);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[KMCFPCOAJNM("IStaticEVInstance")]
public interface PAPKGGACHLN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	LBJNIHPEGAB MLODEJJGECO
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class OMMOCONOFOL : IFAFCIOCDJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly LOCBHAFLAKB LPHFFOLBBOP;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public CALEEIJDEAM? FINLHCLDLDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4971C50", Offset = "0x4970650", VA = "0x184971C50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x82DEC0", Offset = "0x82C8C0", VA = "0x18082DEC0")]
	internal OMMOCONOFOL(LOCBHAFLAKB GAMCJNFOIFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class MDMELGEFHHJ : CALEEIJDEAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly JBMKBCOAINH DCOPOJMOCJI;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public GMEBCKEIMEA NOKPAJOFHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4970DA0", Offset = "0x496F7A0", VA = "0x184970DA0", Slot = "4")]
		get
		{
			return default(GMEBCKEIMEA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public LFDGMHNKEOB HAECIEFADDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4970ED0", Offset = "0x496F8D0", VA = "0x184970ED0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0AA0", Offset = "0x6DFEA0")]
	public global::FPEOKLIPFFB<JPNFGIKIKAL> HBNELNLIJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x4970E00", Offset = "0x496F800", VA = "0x184970E00", Slot = "6")]
		get
		{
			return default(global::FPEOKLIPFFB<JPNFGIKIKAL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public CEIPFNODIPL OHGHBJNJDJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x4970F30", Offset = "0x496F930", VA = "0x184970F30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x82DEC0", Offset = "0x82C8C0", VA = "0x18082DEC0")]
	public MDMELGEFHHJ(JBMKBCOAINH AOLKLCHPOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x4970E60", Offset = "0x496F860", VA = "0x184970E60")]
	public bool KPAEANCLEGA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E09C0", Offset = "0x6DFDC0")] in global::FPEOKLIPFFB<JPNFGIKIKAL> HPEIPIPPKPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x4970E60", Offset = "0x496F860", VA = "0x184970E60", Slot = "8")]
	private bool NLMOOHIMNMI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0A30", Offset = "0x6DFE30")] in global::FPEOKLIPFFB<JPNFGIKIKAL> HPEIPIPPKPE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class EMMGDCMOBBJ
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x4968CC0", Offset = "0x49676C0", VA = "0x184968CC0")]
	public static global::APCEBBGPJOF<MLLDPAIKBLN, BDNOBKCCDPH, LOCBHAFLAKB, GJDCAHCJAOL> ADNLCPPHBDP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0B10", Offset = "0x6DFF10")] this in global::APCEBBGPJOF<MLLDPAIKBLN, BDNOBKCCDPH, LOCBHAFLAKB, GJDCAHCJAOL> DKHBEILLLGM)
	{
		return default(global::APCEBBGPJOF<MLLDPAIKBLN, BDNOBKCCDPH, LOCBHAFLAKB, GJDCAHCJAOL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class LGBGOPDAAOO : LJINNHOPCDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly LOCBHAFLAKB LPHFFOLBBOP;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool DAKCDIOKICE
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x17D0F30", Offset = "0x17CF930", VA = "0x1817D0F30", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x82DEC0", Offset = "0x82C8C0", VA = "0x18082DEC0")]
	internal LGBGOPDAAOO(LOCBHAFLAKB GAMCJNFOIFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public sealed class KFKCMFABOLB : IAALAPHFDHA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct LMDFNJNMIBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public AsyncTaskMethodBuilder<IMANAEBLADE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public KFKCMFABOLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0BD0", Offset = "0x6DFFD0")]
		private TaskAwaiter<CFDKJILCGGD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x496F400", Offset = "0x496DE00", VA = "0x18496F400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x496F640", Offset = "0x496E040", VA = "0x18496F640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly LOCBHAFLAKB LPHFFOLBBOP;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public IMANAEBLADE? FINLHCLDLDF
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x496E500", Offset = "0x496CF00", VA = "0x18496E500", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool HHMPBICPLHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x496E180", Offset = "0x496CB80", VA = "0x18496E180", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool KIFKIDPHIOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x496DC00", Offset = "0x496C600", VA = "0x18496DC00", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x82DEC0", Offset = "0x82C8C0", VA = "0x18082DEC0")]
	internal KFKCMFABOLB(LOCBHAFLAKB GAMCJNFOIFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x496E1E0", Offset = "0x496CBE0", VA = "0x18496E1E0", Slot = "7")]
	[AsyncStateMachine(typeof(LMDFNJNMIBI))]
	public Task<IMANAEBLADE> EAGBJCGEKBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x496DEA0", Offset = "0x496C8A0", VA = "0x18496DEA0")]
	internal Dictionary<global::FPEOKLIPFFB<JPNFGIKIKAL>, Guid> BAJBPLCLBML(IEnumerable<NMCMOHGEFMP> DPHAKJPNHAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x496E580", Offset = "0x496CF80", VA = "0x18496E580")]
	public global::DAOEJNFJJPJ<IINJNPOIFCN, GEPHFINPONA> KPJODOCOFMG(in IINJNPOIFCN CLDLKMLEOND, IEnumerable<NMCMOHGEFMP> HKJCJDDOJPF, int NHPPPABFPID)
	{
		return default(global::DAOEJNFJJPJ<IINJNPOIFCN, GEPHFINPONA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x496E780", Offset = "0x496D180", VA = "0x18496E780")]
	internal static HIMAPHINPEC MDKKPEIBGHJ(GONEJMAIGKC MKHHJCCLDBN, IJMDHCHELAG GBBOAEGAMHF)
	{
		return default(HIMAPHINPEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x496E300", Offset = "0x496CD00", VA = "0x18496E300", Slot = "8")]
	private global::DAOEJNFJJPJ<IINJNPOIFCN, GEPHFINPONA> EKEANMOKBCM(in IINJNPOIFCN CLDLKMLEOND, IEnumerable<NMCMOHGEFMP> HKJCJDDOJPF, int NHPPPABFPID)
	{
		return default(global::DAOEJNFJJPJ<IINJNPOIFCN, GEPHFINPONA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x496DC60", Offset = "0x496C660", VA = "0x18496DC60")]
	[CompilerGenerated]
	internal static HIMAPHINPEC AFGKKOGICFG(GONEJMAIGKC NAMBPLECMJG, IJMDHCHELAG GECLGBBLEHM)
	{
		return default(HIMAPHINPEC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class EFFBNMKJGLJ : IMANAEBLADE
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	internal static class GOKINHHHFJG
	{
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private sealed class JOFCODPPNCC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public KFNDAELMEFJ spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
			public JOFCODPPNCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x496DA40", Offset = "0x496C440", VA = "0x18496DA40")]
			internal bool <InitializeCircuitsV2Remapping>b__0(DOHFCHGLGCP n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class MGEMKHHGAGI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
			public MGEMKHHGAGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x4970F80", Offset = "0x496F980", VA = "0x184970F80")]
			internal void <InitializeCircuitsV2Remapping>b__1(DOHFCHGLGCP n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x496AE70", Offset = "0x4969870", VA = "0x18496AE70")]
		public static global::DAOEJNFJJPJ<IMANAEBLADE.KGEBEKDEKJK, GEPHFINPONA> MCLENAJGMPM(EFFBNMKJGLJ IKHBPJOEIEB, in IMANAEBLADE.MCNGMJFIJNM LIKLGHJBPPH)
		{
			return default(global::DAOEJNFJJPJ<IMANAEBLADE.KGEBEKDEKJK, GEPHFINPONA>);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x496B6F0", Offset = "0x496A0F0", VA = "0x18496B6F0")]
		internal static global::DAOEJNFJJPJ<BOPAIOPECHM, PCIJMHLMKIF> PCNAHOIDNMO(EFFBNMKJGLJ IKHBPJOEIEB, GFGFGIBJMHF LBAIOJDGDJG, bool KKDKEPKEOLM, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E10D0", Offset = "0x6E04D0")] in global::FPEOKLIPFFB<JPNFGIKIKAL> ECPBCDLJEMD, in int? LOODFKBBGDD, in HIMAPHINPEC? COMHMJDBMJK, in HIMAPHINPEC? POJDKLLGPPD)
		{
			return default(global::DAOEJNFJJPJ<BOPAIOPECHM, PCIJMHLMKIF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x496B2C0", Offset = "0x4969CC0", VA = "0x18496B2C0")]
		private static void NHHKFKBECKJ(bool KKDKEPKEOLM, NMCMOHGEFMP LIACPJLMENB, BOPAIOPECHM GLOHGKFAECB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1140", Offset = "0x6E0540")] in global::FPEOKLIPFFB<JPNFGIKIKAL> ECPBCDLJEMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x496AA90", Offset = "0x4969490", VA = "0x18496AA90")]
		public static void KKGDLLHJJKA(GNCENFPMGOH BMPCAGOJIPJ, IReadOnlyCollection<ByteString> JKAJCHMMMHN, IReadOnlyCollection<ByteString> JHPJMGGIIOF, IReadOnlyCollection<ByteString> KCHMLNONGKM)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly JBMKBCOAINH DCOPOJMOCJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly PAPKGGACHLN MGFACDJFFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly KFKCMFABOLB JFGFFABFDND;

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x9C4CD0", Offset = "0x9C36D0", VA = "0x1809C4CD0")]
	public EFFBNMKJGLJ(JBMKBCOAINH AOLKLCHPOGB, PAPKGGACHLN DAFCLLCMEDI, KFKCMFABOLB GHINIMMGBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x49671D0", Offset = "0x4965BD0", VA = "0x1849671D0")]
	public DBJMGDBOPBM? JIAFHBAMDBD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0C30", Offset = "0x6E0030")] in global::FPEOKLIPFFB<NGJJKHMEJHA?> EEKEBONOBOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x4967D80", Offset = "0x4966780", VA = "0x184967D80")]
	private DBJMGDBOPBM? NFJCKKDOEAO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0CA0", Offset = "0x6E00A0")] in global::FPEOKLIPFFB<NGJJKHMEJHA?> EEKEBONOBOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x4967D00", Offset = "0x4966700", VA = "0x184967D00")]
	private IJMDHCHELAG? MPEONBLAKKN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0D10", Offset = "0x6E0110")] in global::FPEOKLIPFFB<NGJJKHMEJHA?> EEKEBONOBOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x4966DE0", Offset = "0x49657E0", VA = "0x184966DE0")]
	public MCEFJGHJHEH? CLDHMMPGIHA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0D80", Offset = "0x6E0180")] in global::FPEOKLIPFFB<JPNFGIKIKAL?> HPEIPIPPKPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x4967FF0", Offset = "0x49669F0", VA = "0x184967FF0")]
	private KFNDAELMEFJ? ODAIFMBMIMJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0DF0", Offset = "0x6E01F0")] in global::FPEOKLIPFFB<JPNFGIKIKAL?> HPEIPIPPKPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4967E70", Offset = "0x4966870", VA = "0x184967E70")]
	private MCEFJGHJHEH? NFJJIDADGOP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0E60", Offset = "0x6E0260")] in global::FPEOKLIPFFB<JPNFGIKIKAL?> HPEIPIPPKPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x4966AC0", Offset = "0x49654C0", VA = "0x184966AC0")]
	public global::DAOEJNFJJPJ<IMANAEBLADE.KGEBEKDEKJK, GEPHFINPONA> ELJCJNJJOON(in IMANAEBLADE.MCNGMJFIJNM LIKLGHJBPPH)
	{
		return default(global::DAOEJNFJJPJ<IMANAEBLADE.KGEBEKDEKJK, GEPHFINPONA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x4966FE0", Offset = "0x49659E0", VA = "0x184966FE0", Slot = "7")]
	public NLKMIIHHIFK EGLHLJGOMOB(IEnumerable<NMCMOHGEFMP> HKJCJDDOJPF)
	{
		return default(NLKMIIHHIFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x49672B0", Offset = "0x4965CB0", VA = "0x1849672B0", Slot = "8")]
	public NLKMIIHHIFK HIAGMMEPCOF()
	{
		return default(NLKMIIHHIFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4967430", Offset = "0x4965E30", VA = "0x184967430")]
	private DPOILFIHAJM LEKIBNCMGAK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0ED0", Offset = "0x6E02D0")] IEnumerable<global::FPEOKLIPFFB<JPNFGIKIKAL>> HNIECMGBDHL, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0F30", Offset = "0x6E0330")] IEnumerable<global::FPEOKLIPFFB<NGJJKHMEJHA>> ELMHONHNFEP)
	{
		return default(DPOILFIHAJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x49675E0", Offset = "0x4965FE0", VA = "0x1849675E0", Slot = "9")]
	public DPOILFIHAJM LEKIBNCMGAK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0F90", Offset = "0x6E0390")] IEnumerable<global::FPEOKLIPFFB<NGJJKHMEJHA>> ELMHONHNFEP, IEnumerable<NMCMOHGEFMP> HKJCJDDOJPF)
	{
		return default(DPOILFIHAJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4966AF0", Offset = "0x49654F0", VA = "0x184966AF0")]
	private static IEnumerable<global::FPEOKLIPFFB<JPNFGIKIKAL>> BPILKLLLOKH(IEnumerable<NMCMOHGEFMP> HKJCJDDOJPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4967910", Offset = "0x4966310", VA = "0x184967910")]
	private IEnumerable<global::FPEOKLIPFFB<NGJJKHMEJHA>> MHDGBKDKPKO(IEnumerable<NMCMOHGEFMP> HKJCJDDOJPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x4967900", Offset = "0x4966300", VA = "0x184967900", Slot = "4")]
	private MCEFJGHJHEH MGLDJIOHJPD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0FF0", Offset = "0x6E03F0")] in global::FPEOKLIPFFB<JPNFGIKIKAL> HPEIPIPPKPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x49671D0", Offset = "0x4965BD0", VA = "0x1849671D0", Slot = "5")]
	private DBJMGDBOPBM FFFGNHCBCMD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1060", Offset = "0x6E0460")] in global::FPEOKLIPFFB<NGJJKHMEJHA> EEKEBONOBOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x4966AC0", Offset = "0x49654C0", VA = "0x184966AC0", Slot = "6")]
	private global::DAOEJNFJJPJ<IMANAEBLADE.KGEBEKDEKJK, GEPHFINPONA> BGADLEEHNJB(in IMANAEBLADE.MCNGMJFIJNM LIKLGHJBPPH)
	{
		return default(global::DAOEJNFJJPJ<IMANAEBLADE.KGEBEKDEKJK, GEPHFINPONA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x49673C0", Offset = "0x4965DC0", VA = "0x1849673C0")]
	[CompilerGenerated]
	private IJMDHCHELAG KBJBDGBKGGH(global::FPEOKLIPFFB<NGJJKHMEJHA> HLFOHCODFGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x4966F70", Offset = "0x4965970", VA = "0x184966F70")]
	[CompilerGenerated]
	private KFNDAELMEFJ DBGANHKGFGA(global::FPEOKLIPFFB<JPNFGIKIKAL> HLFOHCODFGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class DDFGEEHDNLJ : ACEDACMFFHJ, PKOAJNDBMML
{
	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public Action KNPCJDAMPBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public string JAEOPOEMFIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public Func<bool>? LLHPKKJMABK
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public Func<bool>? JGKPENJAEOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x737430", Offset = "0x735E30", VA = "0x180737430", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public Func<bool>? BFEEPNKPLEM
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x738BA0", Offset = "0x7375A0", VA = "0x180738BA0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool DMLJBODFIAN
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x878090", Offset = "0x876A90", VA = "0x180878090", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x4965820", Offset = "0x4964220", VA = "0x184965820")]
	public DDFGEEHDNLJ(Action DPMBNOBJALN, string JFJHIJABEFF = "", [Optional] Func<bool>? AACNJILNKAK, [Optional] Func<bool>? ELBAJPPIHOG, [Optional] Func<bool>? BDKEHNBBCHA, bool JOANHGFFEFL = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class EEMBFAMGJBO : JJCMOMJBDLL, PKOAJNDBMML
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public Func<int> HEAKCGIAIKA
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Action<int> PMHHDIAFCOI
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public Func<bool>? LLHPKKJMABK
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Func<bool>? JGKPENJAEOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x737430", Offset = "0x735E30", VA = "0x180737430", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool MIGJOGNADKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x83BF80", Offset = "0x83A980", VA = "0x18083BF80", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public string JAEOPOEMFIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7374F0", Offset = "0x735EF0", VA = "0x1807374F0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Func<bool>? BFEEPNKPLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x73EEB0", Offset = "0x73D8B0", VA = "0x18073EEB0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public bool ICOOFLJMNHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x899750", Offset = "0x898150", VA = "0x180899750", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool DMLJBODFIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x10E8B10", Offset = "0x10E7510", VA = "0x1810E8B10", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x4966A00", Offset = "0x4965400", VA = "0x184966A00")]
	public EEMBFAMGJBO(Func<int> PGONNOJMOEM, Action<int> JIGBDLJGJCJ, [Optional] Func<bool>? AACNJILNKAK, [Optional] Func<bool>? ELBAJPPIHOG, bool OOBHIGFDCOM = false, string JFJHIJABEFF = "Color", [Optional] Func<bool>? BDKEHNBBCHA, bool MOHLJOCDIGH = true, bool JOANHGFFEFL = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public sealed class GGLHDNKMBEC : GCLFOCGMJCN, PKOAJNDBMML
{
	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public Dictionary<string, KNPMJIHCBMO> LJJCFNEDFFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public Func<int> HEAKCGIAIKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Action<int> PMHHDIAFCOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public string JAEOPOEMFIG
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x737430", Offset = "0x735E30", VA = "0x180737430", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public string KPJIEKCNLMC
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x738BA0", Offset = "0x7375A0", VA = "0x180738BA0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public string CIPNOGOPLAA
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7374F0", Offset = "0x735EF0", VA = "0x1807374F0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public string LKBIBIFGHFH
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x73EEB0", Offset = "0x73D8B0", VA = "0x18073EEB0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Action? DDIIPGLOCKP
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x73B590", Offset = "0x739F90", VA = "0x18073B590", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Action? ECNDNMNLMKA
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7516F0", Offset = "0x7500F0", VA = "0x1807516F0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Func<bool>? LLHPKKJMABK
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x741FC0", Offset = "0x7409C0", VA = "0x180741FC0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Func<bool>? JGKPENJAEOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7D7060", Offset = "0x7D5A60", VA = "0x1807D7060", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E13B0", Offset = "0x6E07B0")]
	public Func<int, string> HBNOPGOAMBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7D7940", Offset = "0x7D6340", VA = "0x1807D7940", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool OPMCIPNFCNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xCAC960", Offset = "0xCAB360", VA = "0x180CAC960", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool AFBNEFJALIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xE85680", Offset = "0xE84080", VA = "0x180E85680", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool DMLJBODFIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x110B360", Offset = "0x1109D60", VA = "0x18110B360", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1410", Offset = "0x6E0810")]
	public Action<MEFMDBCIAHG> MHHPOKFENGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7D5680", Offset = "0x7D4080", VA = "0x1807D5680", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x496A680", Offset = "0x4969080", VA = "0x18496A680")]
	public GGLHDNKMBEC(Dictionary<string, KNPMJIHCBMO> BMKGEKNDEIG, Func<int> PGONNOJMOEM, Action<int> JIGBDLJGJCJ, string JFJHIJABEFF, string KKICLBBHIOE = "", string NPFFBHNCPIM = "", string HPIFBNOHEJB = "", [Optional] Action? FAKIEIANANL, [Optional] Action? BINEJELNMCN, [Optional] Func<bool>? AACNJILNKAK, [Optional] Func<bool>? ELBAJPPIHOG, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E12F0", Offset = "0x6E06F0")] Func<int, string> FOIPLMJGIBD, bool GPHANOBAGDK = true, bool NLIDOAIEKKP = true, bool JOANHGFFEFL = true, [Optional] Action? CFMLOLCNKNO, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1350", Offset = "0x6E0750")] Action<MEFMDBCIAHG> NKEPFBBGMIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public sealed class HNNPJMOALOJ : DJENFDFEFJG, PKOAJNDBMML
{
	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Func<Dictionary<string, KNPMJIHCBMO>> HAFJOLCJDAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Func<int> HEAKCGIAIKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Action<int> PMHHDIAFCOI
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public string JAEOPOEMFIG
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x737430", Offset = "0x735E30", VA = "0x180737430", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public string KPJIEKCNLMC
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x738BA0", Offset = "0x7375A0", VA = "0x180738BA0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public string CIPNOGOPLAA
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7374F0", Offset = "0x735EF0", VA = "0x1807374F0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public string LKBIBIFGHFH
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x73EEB0", Offset = "0x73D8B0", VA = "0x18073EEB0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public Func<bool>? LLHPKKJMABK
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x73B590", Offset = "0x739F90", VA = "0x18073B590", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public Func<bool>? JGKPENJAEOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7516F0", Offset = "0x7500F0", VA = "0x1807516F0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public Func<bool>? NHOOILPAGPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x741FC0", Offset = "0x7409C0", VA = "0x180741FC0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1540", Offset = "0x6E0940")]
	public Func<int, string> HBNOPGOAMBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7D7060", Offset = "0x7D5A60", VA = "0x1807D7060", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool OPMCIPNFCNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xDE8C70", Offset = "0xDE7670", VA = "0x180DE8C70", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public bool AFBNEFJALIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x10AD0B0", Offset = "0x10ABAB0", VA = "0x1810AD0B0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public bool DMLJBODFIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x137DD60", Offset = "0x137C760", VA = "0x18137DD60", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x496C5D0", Offset = "0x496AFD0", VA = "0x18496C5D0")]
	public HNNPJMOALOJ(Func<Dictionary<string, KNPMJIHCBMO>> LFABKIBMAHC, Func<int> PGONNOJMOEM, Action<int> JIGBDLJGJCJ, string JFJHIJABEFF, string KKICLBBHIOE = "", string NPFFBHNCPIM = "", string HPIFBNOHEJB = "", [Optional] Func<bool>? AACNJILNKAK, [Optional] Func<bool>? ELBAJPPIHOG, [Optional] Func<bool>? JKDJBBAAMCK, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E14E0", Offset = "0x6E08E0")] Func<int, string> FOIPLMJGIBD, bool GPHANOBAGDK = true, bool NLIDOAIEKKP = true, bool JOANHGFFEFL = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class CJAPBOKPJLC : BNMGHOIIMHE, PKOAJNDBMML
{
	[Cpp2IlInjected.Token(Token = "0x17000081")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1740", Offset = "0x6E0B40")]
	public Func<List<KeyValuePair<string, KNPMJIHCBMO>>> HAFJOLCJDAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Func<int> HEAKCGIAIKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Action<int> PMHHDIAFCOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public string JAEOPOEMFIG
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x737430", Offset = "0x735E30", VA = "0x180737430", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public string KPJIEKCNLMC
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x738BA0", Offset = "0x7375A0", VA = "0x180738BA0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public string CIPNOGOPLAA
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7374F0", Offset = "0x735EF0", VA = "0x1807374F0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public string LKBIBIFGHFH
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x73EEB0", Offset = "0x73D8B0", VA = "0x18073EEB0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public Func<bool>? LLHPKKJMABK
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x73B590", Offset = "0x739F90", VA = "0x18073B590", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public Func<bool>? JGKPENJAEOL
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7516F0", Offset = "0x7500F0", VA = "0x1807516F0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public Func<bool>? NHOOILPAGPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x741FC0", Offset = "0x7409C0", VA = "0x180741FC0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E17A0", Offset = "0x6E0BA0")]
	public Func<int, string> HBNOPGOAMBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7D7060", Offset = "0x7D5A60", VA = "0x1807D7060", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public Action? DDIIPGLOCKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7D7940", Offset = "0x7D6340", VA = "0x1807D7940", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public Action? ECNDNMNLMKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7D7B40", Offset = "0x7D6540", VA = "0x1807D7B40", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool OPMCIPNFCNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xC54C20", Offset = "0xC53620", VA = "0x180C54C20", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public bool AFBNEFJALIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xE65620", Offset = "0xE64020", VA = "0x180E65620", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public bool DMLJBODFIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x11E7C20", Offset = "0x11E6620", VA = "0x1811E7C20", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x4964FB0", Offset = "0x49639B0", VA = "0x184964FB0")]
	public CJAPBOKPJLC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1680", Offset = "0x6E0A80")] Func<List<KeyValuePair<string, KNPMJIHCBMO>>> LFABKIBMAHC, Func<int> PGONNOJMOEM, Action<int> JIGBDLJGJCJ, string JFJHIJABEFF, string KKICLBBHIOE = "", string NPFFBHNCPIM = "", string HPIFBNOHEJB = "", [Optional] Func<bool>? AACNJILNKAK, [Optional] Func<bool>? ELBAJPPIHOG, [Optional] Func<bool>? JKDJBBAAMCK, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E16E0", Offset = "0x6E0AE0")] Func<int, string> FOIPLMJGIBD, [Optional] Action? FAKIEIANANL, [Optional] Action? BINEJELNMCN, bool GPHANOBAGDK = true, bool NLIDOAIEKKP = true, bool JOANHGFFEFL = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public sealed class IINFJIFHOGM : LCJDMJEFBAA, PKOAJNDBMML
{
	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public Func<string> KJIHGAGGJJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Action<string> HILJLEFHBBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int DBBKNMOHDAA
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7D3CF0", Offset = "0x7D26F0", VA = "0x1807D3CF0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E18D0", Offset = "0x6E0CD0")]
	public Func<string, bool> OOIPAPNANFA
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x737430", Offset = "0x735E30", VA = "0x180737430", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public string? GEAMOIKEBDK
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x738BA0", Offset = "0x7375A0", VA = "0x180738BA0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public Func<bool>? LLHPKKJMABK
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7374F0", Offset = "0x735EF0", VA = "0x1807374F0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public Func<bool>? JGKPENJAEOL
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x73EEB0", Offset = "0x73D8B0", VA = "0x18073EEB0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public string JAEOPOEMFIG
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x73B590", Offset = "0x739F90", VA = "0x18073B590", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public string KPJIEKCNLMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7516F0", Offset = "0x7500F0", VA = "0x1807516F0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public string CIPNOGOPLAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x741FC0", Offset = "0x7409C0", VA = "0x180741FC0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public string LKBIBIFGHFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7D7060", Offset = "0x7D5A60", VA = "0x1807D7060", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool PEHPKIMNPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xDE8C70", Offset = "0xDE7670", VA = "0x180DE8C70", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool DMLJBODFIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xC54C20", Offset = "0xC53620", VA = "0x180C54C20", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x496C940", Offset = "0x496B340", VA = "0x18496C940")]
	public IINFJIFHOGM(Func<string> JCPIEMLJAFG, Action<string> GIGGGLCFKOL, int AMBKMCPGLHI = 1000, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1870", Offset = "0x6E0C70")] Func<string, bool> PBMOAMJCKMG, [Optional] string? FFEBBDPKOAC, [Optional] Func<bool>? AACNJILNKAK, [Optional] Func<bool>? ELBAJPPIHOG, string JFJHIJABEFF = "", string KKICLBBHIOE = "", string NPFFBHNCPIM = "", string HPIFBNOHEJB = "", bool DHDHDOKAGND = false, [Optional] Func<bool>? BDKEHNBBCHA, bool JOANHGFFEFL = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class LAMDGDGLMMF : ADCIOHLGLMK, PKOAJNDBMML
{
	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Func<float> KJIHGAGGJJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Action<float> HILJLEFHBBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public float DEECNCDAOFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7D2AD0", Offset = "0x7D14D0", VA = "0x1807D2AD0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float AFHBOOEIFKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7E44F0", Offset = "0x7E2EF0", VA = "0x1807E44F0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Func<bool>? DHMOJABFEKP
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x737430", Offset = "0x735E30", VA = "0x180737430", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public int KEHKJHPKLBK
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8EDA80", Offset = "0x8EC480", VA = "0x1808EDA80", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public string JAEOPOEMFIG
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7374F0", Offset = "0x735EF0", VA = "0x1807374F0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public string KPJIEKCNLMC
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x73EEB0", Offset = "0x73D8B0", VA = "0x18073EEB0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public string DELKKJKLCCC
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x73B590", Offset = "0x739F90", VA = "0x18073B590", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public string CIPNOGOPLAA
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7516F0", Offset = "0x7500F0", VA = "0x1807516F0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public string LKBIBIFGHFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x741FC0", Offset = "0x7409C0", VA = "0x180741FC0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public Func<float, float>? CADHHABOFDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7D7060", Offset = "0x7D5A60", VA = "0x1807D7060", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public Func<float, float>? ONCMAEHIDHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7D7940", Offset = "0x7D6340", VA = "0x1807D7940", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Func<bool>? BFEEPNKPLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x7D7B40", Offset = "0x7D6540", VA = "0x1807D7B40", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool DMLJBODFIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xC54C20", Offset = "0xC53620", VA = "0x180C54C20", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x496ECD0", Offset = "0x496D6D0", VA = "0x18496ECD0")]
	public LAMDGDGLMMF(Func<float> JCPIEMLJAFG, Action<float> GIGGGLCFKOL, float AEPLKIDICFN = 0f, float EMKECFFJOLI = 1000f, [Optional] Func<bool>? GMLCJNKDCBP, int DFPMIMDPJCM = -1, string JFJHIJABEFF = "", string KKICLBBHIOE = "", string DHKAMOKKBDN = "", string NPFFBHNCPIM = "", string HPIFBNOHEJB = "", [Optional] Func<float, float>? BONHPPJCJHK, [Optional] Func<float, float>? FDMCNMLOMHE, [Optional] Func<bool>? BDKEHNBBCHA, bool JOANHGFFEFL = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public sealed class JPFLLNFGGEC : KACLPIDGBBH, PKOAJNDBMML
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public PKOAJNDBMML MKEHCCAAEPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x82DEC0", Offset = "0x82C8C0", VA = "0x18082DEC0")]
	public JPFLLNFGGEC(PKOAJNDBMML BAOLKJHEBFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class DBOBCEGEEGN : KBPAGEMFBJN, PKOAJNDBMML
{
	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public Func<string> KJIHGAGGJJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public Action<string> HILJLEFHBBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public Func<bool>? LLHPKKJMABK
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public Func<bool>? JGKPENJAEOL
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x737430", Offset = "0x735E30", VA = "0x180737430", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public int? PIDKOECELBF
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x738BA0", Offset = "0x7375A0", VA = "0x180738BA0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool JNBLMNEEMHM
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x878090", Offset = "0x876A90", VA = "0x180878090", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public string JAEOPOEMFIG
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x73EEB0", Offset = "0x73D8B0", VA = "0x18073EEB0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public string CIPNOGOPLAA
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x73B590", Offset = "0x739F90", VA = "0x18073B590", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public string LKBIBIFGHFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7516F0", Offset = "0x7500F0", VA = "0x1807516F0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Func<bool>? BFEEPNKPLEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x741FC0", Offset = "0x7409C0", VA = "0x180741FC0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool DMLJBODFIAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x877E80", Offset = "0x876880", VA = "0x180877E80", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x4965740", Offset = "0x4964140", VA = "0x184965740")]
	public DBOBCEGEEGN(Func<string> JCPIEMLJAFG, Action<string> GIGGGLCFKOL, [Optional] Func<bool>? AACNJILNKAK, [Optional] Func<bool>? ELBAJPPIHOG, [Optional] int? HMCHJMPIAGI, bool DHDHDOKAGND = false, string JFJHIJABEFF = "", string NPFFBHNCPIM = "", string HPIFBNOHEJB = "", [Optional] Func<bool>? BDKEHNBBCHA, bool JOANHGFFEFL = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public sealed class PIOOKADDIHI : FDFLDBAAFMF, PKOAJNDBMML
{
	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public int DBBKNMOHDAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x755A00", Offset = "0x754400", VA = "0x180755A00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1A00", Offset = "0x6E0E00")]
	public Func<string, bool> OOIPAPNANFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public string CIPNOGOPLAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public string LKBIBIFGHFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x737430", Offset = "0x735E30", VA = "0x180737430", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Func<bool>? JGKPENJAEOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x738BA0", Offset = "0x7375A0", VA = "0x180738BA0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Func<bool>? BFEEPNKPLEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x7374F0", Offset = "0x735EF0", VA = "0x1807374F0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Func<bool>? LLHPKKJMABK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x73EEB0", Offset = "0x73D8B0", VA = "0x18073EEB0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public string JAEOPOEMFIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x73B590", Offset = "0x739F90", VA = "0x18073B590", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public string? GEAMOIKEBDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7516F0", Offset = "0x7500F0", VA = "0x1807516F0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public string KPJIEKCNLMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x741FC0", Offset = "0x7409C0", VA = "0x180741FC0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool JNBLMNEEMHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x877E80", Offset = "0x876880", VA = "0x180877E80", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool DMLJBODFIAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xCA7930", Offset = "0xCA6330", VA = "0x180CA7930", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public APAEMMGAFGP EFFMKCNPJPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xD06E00", Offset = "0xD05800", VA = "0x180D06E00", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return default(APAEMMGAFGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public Func<string> KJIHGAGGJJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7D7940", Offset = "0x7D6340", VA = "0x1807D7940", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public Action<string> HILJLEFHBBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7D7B40", Offset = "0x7D6540", VA = "0x1807D7B40", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x4972510", Offset = "0x4970F10", VA = "0x184972510")]
	public PIOOKADDIHI(Func<string> JCPIEMLJAFG, Action<string> GIGGGLCFKOL, int AMBKMCPGLHI = 1000, APAEMMGAFGP HEJAGAGJOGC = APAEMMGAFGP.Alphanumeric, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E19A0", Offset = "0x6E0DA0")] Func<string, bool> PBMOAMJCKMG, [Optional] string? FFEBBDPKOAC, [Optional] Func<bool>? AACNJILNKAK, [Optional] Func<bool>? ELBAJPPIHOG, string JFJHIJABEFF = "", string KKICLBBHIOE = "", string NPFFBHNCPIM = "", string HPIFBNOHEJB = "", bool DHDHDOKAGND = false, [Optional] Func<bool>? BDKEHNBBCHA, bool JOANHGFFEFL = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public sealed class HLJLBNKKAPL : CKBIMNOFNLB, PKOAJNDBMML
{
	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public Func<string> KJIHGAGGJJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public Action<string> HILJLEFHBBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public Action KNPCJDAMPBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Func<bool>? LLHPKKJMABK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x737430", Offset = "0x735E30", VA = "0x180737430", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public APAEMMGAFGP EFFMKCNPJPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8EDA80", Offset = "0x8EC480", VA = "0x1808EDA80", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(APAEMMGAFGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public string JAEOPOEMFIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7374F0", Offset = "0x735EF0", VA = "0x1807374F0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public string CIPNOGOPLAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x73EEB0", Offset = "0x73D8B0", VA = "0x18073EEB0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public string LKBIBIFGHFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x73B590", Offset = "0x739F90", VA = "0x18073B590", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public string AGPNMJNJOBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7516F0", Offset = "0x7500F0", VA = "0x1807516F0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public string JICLDIJJJEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x741FC0", Offset = "0x7409C0", VA = "0x180741FC0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public bool DMLJBODFIAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x877E80", Offset = "0x876880", VA = "0x180877E80", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x496C3C0", Offset = "0x496ADC0", VA = "0x18496C3C0")]
	public HLJLBNKKAPL(Func<string> JCPIEMLJAFG, Action<string> GIGGGLCFKOL, Action DPMBNOBJALN, [Optional] Func<bool>? AACNJILNKAK, APAEMMGAFGP EMKINACMDLO = APAEMMGAFGP.Alphanumeric, string JFJHIJABEFF = "", string NPFFBHNCPIM = "", string HPIFBNOHEJB = "", string HFGKLEFHPEE = "", string DJDIOGKHMML = "", bool JOANHGFFEFL = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public sealed class PPNJDHPLOMF : OBMNHAAKPON, PKOAJNDBMML
{
	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public Func<string> KJIHGAGGJJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public Action<string> HILJLEFHBBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public Func<bool>? LLHPKKJMABK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public Func<bool>? JGKPENJAEOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x737430", Offset = "0x735E30", VA = "0x180737430", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public int? PIDKOECELBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x738BA0", Offset = "0x7375A0", VA = "0x180738BA0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool JNBLMNEEMHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x878090", Offset = "0x876A90", VA = "0x180878090", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public string JAEOPOEMFIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x73EEB0", Offset = "0x73D8B0", VA = "0x18073EEB0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public string CIPNOGOPLAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x73B590", Offset = "0x739F90", VA = "0x18073B590", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public string LKBIBIFGHFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7516F0", Offset = "0x7500F0", VA = "0x1807516F0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public Func<bool>? BFEEPNKPLEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x741FC0", Offset = "0x7409C0", VA = "0x180741FC0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public bool DMLJBODFIAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x877E80", Offset = "0x876880", VA = "0x180877E80", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x4965740", Offset = "0x4964140", VA = "0x184965740")]
	public PPNJDHPLOMF(Func<string> JCPIEMLJAFG, Action<string> GIGGGLCFKOL, [Optional] Func<bool>? AACNJILNKAK, [Optional] Func<bool>? ELBAJPPIHOG, [Optional] int? HMCHJMPIAGI, bool DHDHDOKAGND = false, string JFJHIJABEFF = "", string NPFFBHNCPIM = "", string HPIFBNOHEJB = "", [Optional] Func<bool>? BDKEHNBBCHA, bool JOANHGFFEFL = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public sealed class GPJBAMIKMAN : MKKFFPJLENI, PKOAJNDBMML
{
	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public string EEOGNEMNDDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public Func<bool>? LLHPKKJMABK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x84CDF0", Offset = "0x84B7F0", VA = "0x18084CDF0")]
	public GPJBAMIKMAN(string MHOCGHKABIN, [Optional] Func<bool>? AACNJILNKAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public sealed class OMNBGDAEOPL : EEFOGMMBMHM, PKOAJNDBMML
{
	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public Func<bool> KJIHGAGGJJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public Action<bool> HILJLEFHBBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public Func<bool>? LLHPKKJMABK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public Func<bool>? JGKPENJAEOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x737430", Offset = "0x735E30", VA = "0x180737430", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public string JAEOPOEMFIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x738BA0", Offset = "0x7375A0", VA = "0x180738BA0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public string KPJIEKCNLMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x7374F0", Offset = "0x735EF0", VA = "0x1807374F0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public string CIPNOGOPLAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x73EEB0", Offset = "0x73D8B0", VA = "0x18073EEB0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public string LKBIBIFGHFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x73B590", Offset = "0x739F90", VA = "0x18073B590", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public int PNPDJPOHNLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x976970", Offset = "0x975370", VA = "0x180976970", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public Func<bool>? BFEEPNKPLEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x741FC0", Offset = "0x7409C0", VA = "0x180741FC0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool DMLJBODFIAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x877E80", Offset = "0x876880", VA = "0x180877E80", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x4971D50", Offset = "0x4970750", VA = "0x184971D50")]
	public OMNBGDAEOPL(Func<bool> JCPIEMLJAFG, Action<bool> GIGGGLCFKOL, [Optional] Func<bool>? AACNJILNKAK, [Optional] Func<bool>? ELBAJPPIHOG, string JFJHIJABEFF = "", string KKICLBBHIOE = "", string NPFFBHNCPIM = "", string HPIFBNOHEJB = "", int ALIOAOHFFLI = 999, [Optional] Func<bool>? BDKEHNBBCHA, bool JOANHGFFEFL = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public sealed class BCFPFOPJPFO : ICEDACOMDCD, PKOAJNDBMML
{
	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public string JAEOPOEMFIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Func<object> FKGHKOCFKPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public Action<object> HDEAGNJMMAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public Func<object, string> DOFLNHMHGKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x737430", Offset = "0x735E30", VA = "0x180737430", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Func<IReadOnlyList<object>> MDDNILGCEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x738BA0", Offset = "0x7375A0", VA = "0x180738BA0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public Func<bool> LLHPKKJMABK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7374F0", Offset = "0x735EF0", VA = "0x1807374F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x3A93F40", Offset = "0x3A92940", VA = "0x183A93F40")]
	public BCFPFOPJPFO(string JFJHIJABEFF, Func<object> DOLCNFJPPKL, Action<object> BBLDDKBFDEE, Func<object, string> MDGLNOGFEAA, Func<IReadOnlyList<object>> MABKMLMGFAG, Func<bool> AACNJILNKAK)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public readonly struct COHHPAHDDMD : MGEHCCLGOOE
{
	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x49653F0", Offset = "0x4963DF0", VA = "0x1849653F0", Slot = "4")]
	public int HGFHNMIJBOH(LEKKGHCNCEK NHAGEBCMLPC, BDNOBKCCDPH DJJNLDOINEG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x4965410", Offset = "0x4963E10", VA = "0x184965410", Slot = "5")]
	public BDNOBKCCDPH LKMMMKHLJHG(LEKKGHCNCEK NHAGEBCMLPC, BDNOBKCCDPH DJJNLDOINEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x4965560", Offset = "0x4963F60", VA = "0x184965560", Slot = "6")]
	public BDNOBKCCDPH NMEALMNEDOH(LEKKGHCNCEK NHAGEBCMLPC, BDNOBKCCDPH DJJNLDOINEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x4965600", Offset = "0x4964000", VA = "0x184965600", Slot = "7")]
	public IReadOnlyList<BDNOBKCCDPH> PJKODJINCLC(LEKKGHCNCEK NHAGEBCMLPC, BDNOBKCCDPH DJJNLDOINEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x4965520", Offset = "0x4963F20", VA = "0x184965520", Slot = "8")]
	public bool MHBILDAHLGM(LEKKGHCNCEK NHAGEBCMLPC, BDNOBKCCDPH DJJNLDOINEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x4965540", Offset = "0x4963F40", VA = "0x184965540", Slot = "9")]
	public bool MHNFFAFAAEK(LEKKGHCNCEK NHAGEBCMLPC, BDNOBKCCDPH DJJNLDOINEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x49653B0", Offset = "0x4963DB0", VA = "0x1849653B0", Slot = "10")]
	public bool EKJEEEIDACP(LEKKGHCNCEK NHAGEBCMLPC, BDNOBKCCDPH DJJNLDOINEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x49653D0", Offset = "0x4963DD0", VA = "0x1849653D0", Slot = "11")]
	public bool HDCHDMHBEPN(LEKKGHCNCEK NHAGEBCMLPC, BDNOBKCCDPH DJJNLDOINEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x4965390", Offset = "0x4963D90", VA = "0x184965390", Slot = "12")]
	public bool CHDGOKOLEDG(LEKKGHCNCEK NHAGEBCMLPC, BDNOBKCCDPH DJJNLDOINEG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public abstract class PHCOCMNEFFL : FOOKOIAKPIG
{
	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public BNBJHFKLBOJ.HKOMPEMLNON PJMKBDBMGFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x4972450", Offset = "0x4970E50", VA = "0x184972450", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public abstract GFDLFKLHEEO.ONEIDCCMKKM NGHNCMCMBPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public abstract LOCBHAFLAKB.JIPIMLDPMNP GFBHKMJKCNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public abstract IHJIFALALPI.HCBBMAOAHIB JBHIABEEJKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public GJDCAHCJAOL NGBGDCAOIIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x49724B0", Offset = "0x4970EB0", VA = "0x1849724B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	protected PHCOCMNEFFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public sealed class CNJLHMGGJAL : LFDGMHNKEOB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct OOOGKADMEMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1B00", Offset = "0x6E0F00")]
		public AsyncTaskMethodBuilder<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public CNJLHMGGJAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public BDNOBKCCDPH action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private TaskAwaiter<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x4971E40", Offset = "0x4970840", VA = "0x184971E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x4972000", Offset = "0x4970A00", VA = "0x184972000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct EKOPHOMKOHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1B60", Offset = "0x6E0F60")]
		public AsyncTaskMethodBuilder<global::DAOEJNFJJPJ<DGLEMNOHALK, PCIJMHLMKIF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public CNJLHMGGJAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1BC0", Offset = "0x6E0FC0")]
		public IReadOnlyList<BDNOBKCCDPH> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1C20", Offset = "0x6E1020")]
		private TaskAwaiter<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x49685F0", Offset = "0x4966FF0", VA = "0x1849685F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x4968910", Offset = "0x4967310", VA = "0x184968910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly PECPPOEDGCC KDFLGNKEHPL;

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x82DEC0", Offset = "0x82C8C0", VA = "0x18082DEC0")]
	public CNJLHMGGJAL(PECPPOEDGCC ONFKCAGLEMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x49650F0", Offset = "0x4963AF0", VA = "0x1849650F0")]
	[AsyncStateMachine(typeof(OOOGKADMEMJ))]
	private Task<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> NOKPAJOFHOJ(BDNOBKCCDPH DJJNLDOINEG, bool HPNIJKGKNLH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x4965240", Offset = "0x4963C40", VA = "0x184965240", Slot = "4")]
	[AsyncStateMachine(typeof(EKOPHOMKOHI))]
	public Task<global::DAOEJNFJJPJ<DGLEMNOHALK, PCIJMHLMKIF>> OKGMBNHMKAJ(IReadOnlyList<BDNOBKCCDPH> PMCDLKFEOPL, bool HPNIJKGKNLH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct DOPHOCMHFBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1C80", Offset = "0x6E1080")]
	internal global::BBNIPIDIKGP<KKDKMMIMFJC, BDNOBKCCDPH, LLGFDPIAONA> HAMBBNLBAKP;

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x94C490", Offset = "0x94AE90", VA = "0x18094C490")]
	private DOPHOCMHFBF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E1CE0", Offset = "0x6E10E0")] in global::BBNIPIDIKGP<KKDKMMIMFJC, BDNOBKCCDPH, LLGFDPIAONA> JFFKFDJEAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x4966740", Offset = "0x4965140", VA = "0x184966740")]
	public static DOPHOCMHFBF IDLIIDOEAFG()
	{
		return default(DOPHOCMHFBF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class PGHNAOAPFJL
{
	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8426B0", Offset = "0x8410B0", VA = "0x1808426B0")]
	public static global::BBNIPIDIKGP<KKDKMMIMFJC, BDNOBKCCDPH, LLGFDPIAONA> JGMCHMGNFJK(this ref DOPHOCMHFBF IKHBPJOEIEB)
	{
		return default(global::BBNIPIDIKGP<KKDKMMIMFJC, BDNOBKCCDPH, LLGFDPIAONA>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct LLGFDPIAONA : MALEKKJJGHG
{
	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0xFE1EE0", Offset = "0xFE08E0", VA = "0x180FE1EE0")]
	public int MJIFHOHKHPO(in KKDKMMIMFJC DCMKKLOFFPA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x496F1E0", Offset = "0x496DBE0", VA = "0x18496F1E0", Slot = "5")]
	public BDNOBKCCDPH ADAJAKDKCKG(KKDKMMIMFJC[] HCGHCPHPODJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0xFE1EE0", Offset = "0xFE08E0", VA = "0x180FE1EE0", Slot = "4")]
	private int LECCPOLIGGJ(in KKDKMMIMFJC DCMKKLOFFPA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public sealed class GADILKCEKOM
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	private struct DBHCKAGCCPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public int EOGKCECFNOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public LHIEOLPDLKP? BFFIIIOLFDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public LHIEOLPDLKP? EFAAFCLEDOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public readonly List<BDNOBKCCDPH> JJFDCEHGPCF;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xD3B200", Offset = "0xD39C00", VA = "0x180D3B200")]
		private DBHCKAGCCPE(int ALJOMNDNEBM, LHIEOLPDLKP? MKIICEIMDLO, LHIEOLPDLKP? IGJAOHNPLOP, List<BDNOBKCCDPH> PMCDLKFEOPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x4965690", Offset = "0x4964090", VA = "0x184965690")]
		public static DBHCKAGCCPE IDLIIDOEAFG()
		{
			return default(DBHCKAGCCPE);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private readonly global::APBOBBIPBGH<DBHCKAGCCPE> FDKMKEMOBMH;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public static GADILKCEKOM FINLHCLDLDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x4969750", Offset = "0x4968150", VA = "0x184969750")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public bool NPKMDPOJEID
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x7E6A20", Offset = "0x7E5420", VA = "0x1807E6A20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x7E6AC0", Offset = "0x7E54C0", VA = "0x1807E6AC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x49697B0", Offset = "0x49681B0", VA = "0x1849697B0")]
	public void IPFELMNMNPE(CEIPFNODIPL IGJAOHNPLOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x4969890", Offset = "0x4968290", VA = "0x184969890")]
	public void NBLNPNDNKIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x4969BA0", Offset = "0x49685A0", VA = "0x184969BA0")]
	private static string? OLEHKFLEOEG(in DBHCKAGCCPE OPCGBJPJIOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x496A030", Offset = "0x4968A30", VA = "0x18496A030")]
	public GADILKCEKOM()
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
