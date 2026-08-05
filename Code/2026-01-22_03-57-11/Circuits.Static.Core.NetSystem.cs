using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Circuits.Shared.Api;
using Circuits.Static.Api;
using Circuits.Static.Utilities;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		[Cpp2IlInjected.Address(RVA = "0x28FF230", Offset = "0x28FDA30", VA = "0x1828FF230")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD7810", Offset = "0xAD6010", VA = "0x180AD7810")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD7850", Offset = "0xAD6050", VA = "0x180AD7850")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Static.Core.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class WHUAKVBDJDS : UKTPHMNXTOY
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x28FF2B0", Offset = "0x28FDAB0", VA = "0x1828FF2B0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28FF220", Offset = "0x28FDA20", VA = "0x1828FF220")]
		private WHUAKVBDJDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x28FF2E0", Offset = "0x28FDAE0", VA = "0x1828FF2E0")]
		public static WHUAKVBDJDS New()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct PartialActionReassembly<TPartialAction, TPartialActionId, TFullAction, TDeps> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull where TDeps : notnull, OHANVWTTLEX.BZZUHUVHMDL<TPartialAction, TPartialActionId, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class NJLUHOEHTBO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private readonly TPartialAction?[] VSYRIOZHHNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			private int UUEFZQLDTHN;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xDC39E0", Offset = "0xDC21E0", VA = "0x180DC39E0")]
			private NJLUHOEHTBO(TPartialAction[] a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x58873E0", Offset = "0x5885BE0", VA = "0x1858873E0")]
			public static PartialActionReassembly<TPartialAction, TPartialActionId, TFullAction, TDeps>.NJLUHOEHTBO New(int expectedCount)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x58879D0", Offset = "0x58861D0", VA = "0x1858879D0")]
			public Option<TFullAction> QGZMXVQZVBC(TPartialAction a, TDeps b)
			{
				return default(Option<TFullAction>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private Dictionary<TPartialActionId, NJLUHOEHTBO>? _reassemblers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private TDeps _deps;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Dictionary<TPartialActionId, NJLUHOEHTBO> EVUCEEECBCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5ADE020", Offset = "0x5ADC820", VA = "0x185ADE020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5ADFA30", Offset = "0x5ADE230", VA = "0x185ADFA30")]
		private PartialActionReassembly(Dictionary<TPartialActionId, NJLUHOEHTBO>? reassemblers, TDeps deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5ADE0C0", Offset = "0x5ADC8C0", VA = "0x185ADE0C0")]
		public static PartialActionReassembly<TPartialAction, TPartialActionId, TFullAction, TDeps> New(TDeps deps)
		{
			return default(PartialActionReassembly<TPartialAction, TPartialActionId, TFullAction, TDeps>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5ADF2D0", Offset = "0x5ADDAD0", VA = "0x185ADF2D0")]
		public Result<Option<TFullAction>, SPRIBHSTRKT> QGZMXVQZVBC(TPartialAction a)
		{
			return default(Result<Option<TFullAction>, SPRIBHSTRKT>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5ADF790", Offset = "0x5ADDF90", VA = "0x185ADF790")]
		public void YUKJSIWTWIS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class OHANVWTTLEX
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface BZZUHUVHMDL<a, out b, out c> where a : notnull where b : notnull where c : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			int FEVSAZTRSPX([In] a partialAction);

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "1")]
			int RIRNHMVXCNA([In] a partialAction);

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "2")]
			b ORCJTGZXCZJ([In] a partialAction);

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "3")]
			c AHOKIEHYJYH(a[] a);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SnapshotReassembly<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : RBJXPEJGOQC.BZUNKOBKCSC<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal TPartialSnapshot[] _snapshotParts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal int _snapshotCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal TDeps _deps;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5EEED00", Offset = "0x5EED500", VA = "0x185EEED00")]
		internal SnapshotReassembly(TPartialSnapshot[] snapshotParts, int snapshotCount, TDeps deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5EEECA0", Offset = "0x5EED4A0", VA = "0x185EEECA0")]
		public static SnapshotReassembly<TPartialSnapshot, TFullSnapshot, TDeps> New(TDeps deps)
		{
			return default(SnapshotReassembly<TPartialSnapshot, TFullSnapshot, TDeps>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class RBJXPEJGOQC
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public interface BZUNKOBKCSC<a, b>
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "0")]
			int EYFDHNJDTRJ([In] a partialSnapshot);

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "1")]
			b YBIGNVMPIEJ(a[] a);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x397C940", Offset = "0x397B140", VA = "0x18397C940")]
		public static Option<b> QGZMXVQZVBC<b, a, c>(this SnapshotReassembly<a, b, c> a, a b) where c : BZUNKOBKCSC<a, b>
		{
			return default(Option<b>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x397C390", Offset = "0x397AB90", VA = "0x18397C390")]
		public static bool Discard<TPartialSnapshot, TFullSnapshot, TDeps>(this SnapshotReassembly<TPartialSnapshot, TFullSnapshot, TDeps> self, TPartialSnapshot partialSnapshot) where TDeps : BZUNKOBKCSC<TPartialSnapshot, TFullSnapshot>
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public sealed class JPBYYXFRYWZ : UKTPHMNXTOY
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x28FF1F0", Offset = "0x28FD9F0", VA = "0x1828FF1F0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28FF220", Offset = "0x28FDA20", VA = "0x1828FF220")]
		public JPBYYXFRYWZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class VHQOYNGRXXL<a, b, c, d, e, f, g, h> where d : WJCXSIBAOJT.PGUVLZIIUJS<a, b> where e : WJCXSIBAOJT.IOXFUTEZPJN<a, c> where f : WJCXSIBAOJT.HMLSSQKIODE<a, g> where h : WJCXSIBAOJT.BZZUHUVHMDL<d, e, f>
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private interface IMFSPOJHDRR
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void BUOXEXDSTHV([In] Result<object, SPRIBHSTRKT> result);

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Result<object, SPRIBHSTRKT> GYPADSAGBQE();
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private sealed class HTMLBQQUYBH : IMFSPOJHDRR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private readonly List<Result<object, ZVSGMZZHZEF>> FMBNHZOWHPQ;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x4F4CD60", Offset = "0x4F4B560", VA = "0x184F4CD60")]
			public static HTMLBQQUYBH New()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x4F4C8C0", Offset = "0x4F4B0C0", VA = "0x184F4C8C0")]
			public void BUOXEXDSTHV([In] Result<object, SPRIBHSTRKT> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x4F4C9C0", Offset = "0x4F4B1C0", VA = "0x184F4C9C0", Slot = "5")]
			public Result<object, SPRIBHSTRKT> GYPADSAGBQE()
			{
				return default(Result<object, SPRIBHSTRKT>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x4F4CEB0", Offset = "0x4F4B6B0", VA = "0x184F4CEB0")]
			public HTMLBQQUYBH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x4F4C8C0", Offset = "0x4F4B0C0", VA = "0x184F4C8C0", Slot = "4")]
			private void MLMWHKOQQUA([In] Result<object, SPRIBHSTRKT> result)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		private sealed class MYKMSHJYZFM : IMFSPOJHDRR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private Result<object, SPRIBHSTRKT> HABHYPEDKMN;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5810810", Offset = "0x580F010", VA = "0x185810810")]
			public static MYKMSHJYZFM New()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x22C5850", Offset = "0x22C4050", VA = "0x1822C5850")]
			public void BUOXEXDSTHV([In] Result<object, SPRIBHSTRKT> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xC7C0A0", Offset = "0xC7A8A0", VA = "0x180C7C0A0", Slot = "5")]
			public Result<object, SPRIBHSTRKT> GYPADSAGBQE()
			{
				return default(Result<object, SPRIBHSTRKT>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public MYKMSHJYZFM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x22C5850", Offset = "0x22C4050", VA = "0x1822C5850", Slot = "4")]
			private void MLMWHKOQQUA([In] Result<object, SPRIBHSTRKT> result)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct <ProcessAction>d__31 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public VHQOYNGRXXL<a, b, c, d, e, f, g, h> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public b receiverNetSys;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public a action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public g root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public c receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public IMFSPOJHDRR completionSink;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private IEnumerator<a> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private IMFSPOJHDRR <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<Result<object?, SPRIBHSTRKT>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x50AE9C0", Offset = "0x50AD1C0", VA = "0x1850AE9C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x50B1E80", Offset = "0x50B0680", VA = "0x1850B1E80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct <ReceiveAction>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public AsyncTaskMethodBuilder<Result<object, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public VHQOYNGRXXL<a, b, c, d, e, f, g, h> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public g root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public b receiverNetSys;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public c receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Id32<ZORKRESYKMD> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public a action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private TaskAwaiter<Result<object, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x50F82D0", Offset = "0x50F6AD0", VA = "0x1850F82D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x50F90B0", Offset = "0x50F78B0", VA = "0x1850F90B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct <ReceiveActionAsync>d__27 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public AsyncTaskMethodBuilder<Result<object, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public VHQOYNGRXXL<a, b, c, d, e, f, g, h> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public g root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Task lastReceive;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public Id32<ZORKRESYKMD> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public c receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public b receiverNetSys;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public a action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private bool <wasWaitingForSnapshot>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private bool <isMyAction>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private IMFSPOJHDRR <completion>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x50F4CA0", Offset = "0x50F34A0", VA = "0x1850F4CA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x50F7ED0", Offset = "0x50F66D0", VA = "0x1850F7ED0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private struct <SendActionToAll>d__24 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public AsyncTaskMethodBuilder<Result<object, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public VHQOYNGRXXL<a, b, c, d, e, f, g, h> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public g root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public Id32<ZORKRESYKMD> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public a action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private TaskAwaiter<Result<object, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x52C3BA0", Offset = "0x52C23A0", VA = "0x1852C3BA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A70", Offset = "0x52C3270", VA = "0x1852C4A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private struct <SendSnapshot>d__34 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public a[] snapshotActions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public VHQOYNGRXXL<a, b, c, d, e, f, g, h> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public g root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public b receiverNetSys;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public Id32<ZORKRESYKMD> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x52CEE00", Offset = "0x52CD600", VA = "0x1852CEE00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x52CF130", Offset = "0x52CD930", VA = "0x1852CF130", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct <SplitSendActionToAll>d__25 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public AsyncTaskMethodBuilder<Result<object, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public a[] actions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public VHQOYNGRXXL<a, b, c, d, e, f, g, h> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public g root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public Id32<ZORKRESYKMD> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private int <i>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private TaskAwaiter<Result<object, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x53AA9A0", Offset = "0x53A91A0", VA = "0x1853AA9A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x53AAE50", Offset = "0x53A9650", VA = "0x1853AAE50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly h FPRKQLVLHLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool KRYTZJUIVKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int YJNAXPFFQKQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private Task MYNGIVHTHSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int YFEWPAAJMXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private int OZXKTKFJGYV;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private d LWSNPQXCZQP
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x62C0040", Offset = "0x62BE840", VA = "0x1862C0040")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private f ZFZDSYKPXUR
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x62BF500", Offset = "0x62BDD00", VA = "0x1862BF500")]
			get
			{
				return (f)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private e WEZIQYCHWJG
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x62BF6D0", Offset = "0x62BDED0", VA = "0x1862BF6D0")]
			get
			{
				return (e)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool LXJWXKXCYAZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xB85310", Offset = "0xB83B10", VA = "0x180B85310")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xB85B40", Offset = "0xB84340", VA = "0x180B85B40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int VGPNVMCBRDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xB5F300", Offset = "0xB5DB00", VA = "0x180B5F300")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int KLVPJPBBRVG
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xABE4C0", Offset = "0xABCCC0", VA = "0x180ABE4C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int GUEACNVQJRH
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xAD58C0", Offset = "0xAD40C0", VA = "0x180AD58C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x62C46F0", Offset = "0x62C2EF0", VA = "0x1862C46F0")]
		public VHQOYNGRXXL(h a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x62C18A0", Offset = "0x62C00A0", VA = "0x1862C18A0")]
		public Task<Result<object, SPRIBHSTRKT>> WOSCAFSXEFP(g a, b b, Id32<ZORKRESYKMD> c, a d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x62C1CC0", Offset = "0x62C04C0", VA = "0x1862C1CC0")]
		[AsyncStateMachine(typeof(VHQOYNGRXXL<, , , , , , , >.<SendActionToAll>d__24))]
		private Task<Result<object, SPRIBHSTRKT>> WOSCAFSXEFP(g a, Id32<ZORKRESYKMD> b, a c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x62C06B0", Offset = "0x62BEEB0", VA = "0x1862C06B0")]
		[AsyncStateMachine(typeof(VHQOYNGRXXL<, , , , , , , >.<SplitSendActionToAll>d__25))]
		private Task<Result<object, SPRIBHSTRKT>> URJLCAPBVLZ(g a, Id32<ZORKRESYKMD> b, a[] c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x62BFA00", Offset = "0x62BE200", VA = "0x1862BFA00")]
		[AsyncStateMachine(typeof(VHQOYNGRXXL<, , , , , , , >.<ReceiveAction>d__26))]
		public Task<Result<object, SPRIBHSTRKT>> NPBBJAIZAHE(g a, b b, c c, Id32<ZORKRESYKMD> d, a e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x62BECD0", Offset = "0x62BD4D0", VA = "0x1862BECD0")]
		[AsyncStateMachine(typeof(VHQOYNGRXXL<, , , , , , , >.<ReceiveActionAsync>d__27))]
		private Task<Result<object, SPRIBHSTRKT>> HINEETVKLKG(g a, b b, c c, Id32<ZORKRESYKMD> d, a e, Task f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x62C0810", Offset = "0x62BF010", VA = "0x1862C0810")]
		[AsyncStateMachine(typeof(VHQOYNGRXXL<, , , , , , , >.<ProcessAction>d__31))]
		private Task UZUTVENVFZE(g a, b b, c c, a d, IMFSPOJHDRR e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x62BE3A0", Offset = "0x62BCBA0", VA = "0x1862BE3A0")]
		private void FTIULQEQHIC(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x62C3C60", Offset = "0x62C2460", VA = "0x1862C3C60")]
		private void XXOAGLMBKRN(g a, b b, c c, Id32<ZORKRESYKMD> d, a e, bool f, bool g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x62BEB90", Offset = "0x62BD390", VA = "0x1862BEB90")]
		[AsyncStateMachine(typeof(VHQOYNGRXXL<, , , , , , , >.<SendSnapshot>d__34))]
		public Task HGSSKFYALJP(g a, b b, Id32<ZORKRESYKMD> c, a[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x62BD650", Offset = "0x62BBE50", VA = "0x1862BD650")]
		private (a, int) CYOMTNRDFJU(g a, b b, a c)
		{
			return default((a, int));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class WJCXSIBAOJT
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public interface PGUVLZIIUJS<a, b>
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(Slot = "0")]
			int FHCWOIETFTQ(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(Slot = "1")]
			a ILNGCYDVHQF(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(Slot = "2")]
			a HXTCSKWYRJQ(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			IReadOnlyList<a> GTIRSZPGYJC(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			a[] SPKZRULCSLZ(b a, a b, int c);

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			bool YGDHOHTXEPS(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			bool SVHKTAHJAHA(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "7")]
			bool BJMUWMPQKZC(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(Slot = "8")]
			bool NINDFFGAYJA(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(Slot = "9")]
			bool CBJNMOXSGOY(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(Slot = "10")]
			bool YNMWOWWNDMV(b a, a b);
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public interface BZZUHUVHMDL<a, b, c>
		{
			[Cpp2IlInjected.Token(Token = "0x17000009")]
			a LWSNPQXCZQP
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			b WEZIQYCHWJG
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			c ZFZDSYKPXUR
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public interface IOXFUTEZPJN<a, b> where a : notnull where b : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "0")]
			Id32<ZORKRESYKMD> KRXXVVLKKZK(b a);

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void XJBBNLIOUNZ(b a);

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Task<Result<object, SPRIBHSTRKT>> NPBBJAIZAHE(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(Slot = "3")]
			a[] PNLTOGLYJII(b a);
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public interface HMLSSQKIODE<a, b>
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(Slot = "0")]
			int WSOGVUHINFS(b a);

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			int VYEZWTOFYRG(b a);

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			int NZSPPUAEWSL(b a);

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			int IRNSUYDTTQH(b a);

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void ZLEQPNFHISW(b a);

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(Slot = "5")]
			bool DSHGFRIPKZJ(b a, Id32<ZORKRESYKMD> b, a[] c);

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "6")]
			bool LBWGEGASKVP(b a, int b);

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "7")]
			Task<Result<object, SPRIBHSTRKT>> WOSCAFSXEFP(b a, Id32<ZORKRESYKMD> b, a c, bool d = true);
		}
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
