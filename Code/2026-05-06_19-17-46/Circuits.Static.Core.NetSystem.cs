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
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B9EEB0", Offset = "0x2B9D8B0", VA = "0x182B9EEB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD007A0", Offset = "0xCFF1A0", VA = "0x180D007A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD007E0", Offset = "0xCFF1E0", VA = "0x180D007E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Static.Core.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AZXXTSGKQKT : ASXPOOCHMFZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2B9EDF0", Offset = "0x2B9D7F0", VA = "0x182B9EDF0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B9EE70", Offset = "0x2B9D870", VA = "0x182B9EE70")]
		private AZXXTSGKQKT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2B9EE20", Offset = "0x2B9D820", VA = "0x182B9EE20")]
		public static AZXXTSGKQKT New()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct PartialActionReassembly<TPartialAction, TPartialActionId, TFullAction, TDeps> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull where TDeps : notnull, DKNVYVNLIHG.MDFEQTCPLCK<TPartialAction, TPartialActionId, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class RVDMBNBJVNF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private readonly TPartialAction?[] KUGMMFWOEWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			private int XULNQGUOOUE;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x103AF40", Offset = "0x1039940", VA = "0x18103AF40")]
			private RVDMBNBJVNF(TPartialAction[] a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x77632A0", Offset = "0x7761CA0", VA = "0x1877632A0")]
			public static PartialActionReassembly<TPartialAction, TPartialActionId, TFullAction, TDeps>.RVDMBNBJVNF New(int expectedCount)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7762D80", Offset = "0x7761780", VA = "0x187762D80")]
			public Option<TFullAction> EAXIICUCCUD(TPartialAction a, TDeps b)
			{
				return default(Option<TFullAction>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private Dictionary<TPartialActionId, RVDMBNBJVNF>? _reassemblers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private TDeps _deps;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Dictionary<TPartialActionId, RVDMBNBJVNF> RTJXMGEPVLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x7523840", Offset = "0x7522240", VA = "0x187523840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7523C20", Offset = "0x7522620", VA = "0x187523C20")]
		private PartialActionReassembly(Dictionary<TPartialActionId, RVDMBNBJVNF>? reassemblers, TDeps deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7523A20", Offset = "0x7522420", VA = "0x187523A20")]
		public static PartialActionReassembly<TPartialAction, TPartialActionId, TFullAction, TDeps> New(TDeps deps)
		{
			return default(PartialActionReassembly<TPartialAction, TPartialActionId, TFullAction, TDeps>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7523230", Offset = "0x7521C30", VA = "0x187523230")]
		public Result<Option<TFullAction>, SKKNIPYCQUO> EAXIICUCCUD(TPartialAction a)
		{
			return default(Result<Option<TFullAction>, SKKNIPYCQUO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x75237C0", Offset = "0x75221C0", VA = "0x1875237C0")]
		public void GVDDXTLWNLR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class DKNVYVNLIHG
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface MDFEQTCPLCK<a, out b, out c> where a : notnull where b : notnull where c : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			int OSQLGVETQIG([In] a partialAction);

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "1")]
			int GNXXQAYPDCF([In] a partialAction);

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "2")]
			b HUUNNCDMJQG([In] a partialAction);

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "3")]
			c FDGNOCDNXPC(a[] a);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SnapshotReassembly<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : BVIZNESWPRV.MDKLNZWMUNT<TPartialSnapshot, TFullSnapshot>
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
		[Cpp2IlInjected.Address(RVA = "0x7A1A210", Offset = "0x7A18C10", VA = "0x187A1A210")]
		internal SnapshotReassembly(TPartialSnapshot[] snapshotParts, int snapshotCount, TDeps deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7A1A1B0", Offset = "0x7A18BB0", VA = "0x187A1A1B0")]
		public static SnapshotReassembly<TPartialSnapshot, TFullSnapshot, TDeps> New(TDeps deps)
		{
			return default(SnapshotReassembly<TPartialSnapshot, TFullSnapshot, TDeps>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class BVIZNESWPRV
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public interface MDKLNZWMUNT<a, b>
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "0")]
			int GPQQKGDOBMM([In] a partialSnapshot);

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "1")]
			b FOGRNCCRJLU(a[] a);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3726890", Offset = "0x3725290", VA = "0x183726890")]
		public static Option<b> EAXIICUCCUD<b, a, c>(this SnapshotReassembly<a, b, c> a, a b) where c : MDKLNZWMUNT<a, b>
		{
			return default(Option<b>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x37262C0", Offset = "0x3724CC0", VA = "0x1837262C0")]
		public static bool Discard<TPartialSnapshot, TFullSnapshot, TDeps>(this SnapshotReassembly<TPartialSnapshot, TFullSnapshot, TDeps> self, TPartialSnapshot partialSnapshot) where TDeps : MDKLNZWMUNT<TPartialSnapshot, TFullSnapshot>
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public sealed class FQMWRNAAXKE : ASXPOOCHMFZ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B9EE80", Offset = "0x2B9D880", VA = "0x182B9EE80", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B9EE70", Offset = "0x2B9D870", VA = "0x182B9EE70")]
		public FQMWRNAAXKE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class CSRTKGILMEU<a, b, c, d, e, f, g, h> where d : UXOUZHAFSJC.YWYJNPIOPIT<a, b> where e : UXOUZHAFSJC.EIUEKENQCJW<a, c> where f : UXOUZHAFSJC.FWOEJNVWAJL<a, g> where h : UXOUZHAFSJC.MDFEQTCPLCK<d, e, f>
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private interface NEIEYOTQFZS
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void BHZSOAOYUSA([In] Result<object, SKKNIPYCQUO> result);

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Result<object, SKKNIPYCQUO> VHUVDESPQZX();
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private sealed class ESXRJDYYIDI : NEIEYOTQFZS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private readonly List<Result<object, FWOTOTOBXEY>> CIPTSLJTDDB;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5B5F810", Offset = "0x5B5E210", VA = "0x185B5F810")]
			public static ESXRJDYYIDI New()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5B5F580", Offset = "0x5B5DF80", VA = "0x185B5F580")]
			public void BHZSOAOYUSA([In] Result<object, SKKNIPYCQUO> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5B5FA40", Offset = "0x5B5E440", VA = "0x185B5FA40", Slot = "5")]
			public Result<object, SKKNIPYCQUO> VHUVDESPQZX()
			{
				return default(Result<object, SKKNIPYCQUO>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x5B5FB70", Offset = "0x5B5E570", VA = "0x185B5FB70")]
			public ESXRJDYYIDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x5B5F580", Offset = "0x5B5DF80", VA = "0x185B5F580", Slot = "4")]
			private void IWZBUVQEURD([In] Result<object, SKKNIPYCQUO> result)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		private sealed class QXXKSTEBBLF : NEIEYOTQFZS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private Result<object, SKKNIPYCQUO> IHOPIKNJEFY;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x770CEB0", Offset = "0x770B8B0", VA = "0x18770CEB0")]
			public static QXXKSTEBBLF New()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x259CA00", Offset = "0x259B400", VA = "0x18259CA00")]
			public void BHZSOAOYUSA([In] Result<object, SKKNIPYCQUO> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xEFDE50", Offset = "0xEFC850", VA = "0x180EFDE50", Slot = "5")]
			public Result<object, SKKNIPYCQUO> VHUVDESPQZX()
			{
				return default(Result<object, SKKNIPYCQUO>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public QXXKSTEBBLF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x259CA00", Offset = "0x259B400", VA = "0x18259CA00", Slot = "4")]
			private void IWZBUVQEURD([In] Result<object, SKKNIPYCQUO> result)
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
			public CSRTKGILMEU<a, b, c, d, e, f, g, h> <>4__this;

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
			public NEIEYOTQFZS completionSink;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private IEnumerator<a> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private NEIEYOTQFZS <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<Result<object?, SKKNIPYCQUO>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6B0CC60", Offset = "0x6B0B660", VA = "0x186B0CC60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6B13670", Offset = "0x6B12070", VA = "0x186B13670", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public CSRTKGILMEU<a, b, c, d, e, f, g, h> <>4__this;

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
			public Id32<BVHHKRGRDMC> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public a action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private TaskAwaiter<Result<object, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6BC7140", Offset = "0x6BC5B40", VA = "0x186BC7140", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6BC78B0", Offset = "0x6BC62B0", VA = "0x186BC78B0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public CSRTKGILMEU<a, b, c, d, e, f, g, h> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public g root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Task lastReceive;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public Id32<BVHHKRGRDMC> senderId;

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
			private NEIEYOTQFZS <completion>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6BC5B80", Offset = "0x6BC4580", VA = "0x186BC5B80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6BC6630", Offset = "0x6BC5030", VA = "0x186BC6630", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public CSRTKGILMEU<a, b, c, d, e, f, g, h> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public g root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public Id32<BVHHKRGRDMC> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public a action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private TaskAwaiter<Result<object, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6D0A4A0", Offset = "0x6D08EA0", VA = "0x186D0A4A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6D0A9A0", Offset = "0x6D093A0", VA = "0x186D0A9A0", Slot = "5")]
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
			public CSRTKGILMEU<a, b, c, d, e, f, g, h> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public g root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public b receiverNetSys;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public Id32<BVHHKRGRDMC> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6D8FD10", Offset = "0x6D8E710", VA = "0x186D8FD10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6D90140", Offset = "0x6D8EB40", VA = "0x186D90140", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public a[] actions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public CSRTKGILMEU<a, b, c, d, e, f, g, h> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public g root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public Id32<BVHHKRGRDMC> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private int <i>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private TaskAwaiter<Result<object, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6E37200", Offset = "0x6E35C00", VA = "0x186E37200", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6E38850", Offset = "0x6E37250", VA = "0x186E38850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly h RATSQORCBWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool IZUOBDPDUUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int BNNPRPUJLVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private Task XCZKGUELQFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int EJJRZRPMDPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private int UDQJFOBKWEE;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private d CPHRSEMEXMO
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x50206F0", Offset = "0x501F0F0", VA = "0x1850206F0")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private f CXRYLDTXRXC
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x5020A60", Offset = "0x501F460", VA = "0x185020A60")]
			get
			{
				return (f)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private e KYKJOFKQEMR
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x50221D0", Offset = "0x5020BD0", VA = "0x1850221D0")]
			get
			{
				return (e)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool BURQYRWDJGA
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xDE6AF0", Offset = "0xDE54F0", VA = "0x180DE6AF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xDE6F60", Offset = "0xDE5960", VA = "0x180DE6F60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int GGPMPHTRPFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xDF2410", Offset = "0xDF0E10", VA = "0x180DF2410")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int BFHTOSLJBKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xCE7550", Offset = "0xCE5F50", VA = "0x180CE7550")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int WOTTYYQIETG
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xCFE110", Offset = "0xCFCB10", VA = "0x180CFE110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x50258E0", Offset = "0x50242E0", VA = "0x1850258E0")]
		public CSRTKGILMEU(h a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5023D20", Offset = "0x5022720", VA = "0x185023D20")]
		public Task<Result<object, SKKNIPYCQUO>> VWNRQDAMUSS(g a, b b, Id32<BVHHKRGRDMC> c, a d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5022920", Offset = "0x5021320", VA = "0x185022920")]
		[AsyncStateMachine(typeof(CSRTKGILMEU<, , , , , , , >.<SendActionToAll>d__24))]
		private Task<Result<object, SKKNIPYCQUO>> VWNRQDAMUSS(g a, Id32<BVHHKRGRDMC> b, a c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x501F5F0", Offset = "0x501DFF0", VA = "0x18501F5F0")]
		[AsyncStateMachine(typeof(CSRTKGILMEU<, , , , , , , >.<SplitSendActionToAll>d__25))]
		private Task<Result<object, SKKNIPYCQUO>> EVYLBUWVEAG(g a, Id32<BVHHKRGRDMC> b, a[] c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x501EBC0", Offset = "0x501D5C0", VA = "0x18501EBC0")]
		[AsyncStateMachine(typeof(CSRTKGILMEU<, , , , , , , >.<ReceiveAction>d__26))]
		public Task<Result<object, SKKNIPYCQUO>> DHXGMDSKOIZ(g a, b b, c c, Id32<BVHHKRGRDMC> d, a e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x501FEA0", Offset = "0x501E8A0", VA = "0x18501FEA0")]
		[AsyncStateMachine(typeof(CSRTKGILMEU<, , , , , , , >.<ReceiveActionAsync>d__27))]
		private Task<Result<object, SKKNIPYCQUO>> IMUOFIYREFR(g a, b b, c c, Id32<BVHHKRGRDMC> d, a e, Task f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5020BE0", Offset = "0x501F5E0", VA = "0x185020BE0")]
		[AsyncStateMachine(typeof(CSRTKGILMEU<, , , , , , , >.<ProcessAction>d__31))]
		private Task OVWURHOFELT(g a, b b, c c, a d, NEIEYOTQFZS e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x501F0C0", Offset = "0x501DAC0", VA = "0x18501F0C0")]
		private void ERJITGXARVH(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x50250C0", Offset = "0x5023AC0", VA = "0x1850250C0")]
		private void YUCCLUVQRTQ(g a, b b, c c, Id32<BVHHKRGRDMC> d, a e, bool f, bool g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x501F820", Offset = "0x501E220", VA = "0x18501F820")]
		[AsyncStateMachine(typeof(CSRTKGILMEU<, , , , , , , >.<SendSnapshot>d__34))]
		public Task IMRESMSTGSE(g a, b b, Id32<BVHHKRGRDMC> c, a[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5021250", Offset = "0x501FC50", VA = "0x185021250")]
		private (a, int) SYTKCBVZIZR(g a, b b, a c)
		{
			return default((a, int));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class UXOUZHAFSJC
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public interface YWYJNPIOPIT<a, b>
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(Slot = "0")]
			int LJNIWHGZZVL(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(Slot = "1")]
			a SUKXYRHXJHO(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(Slot = "2")]
			a WXBBESHFYXF(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			IReadOnlyList<a> MZIMHHQPCEV(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			a[] HYKGVNEHMWA(b a, a b, int c);

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			bool GKYOVMSGEVH(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			bool NBXLACDXBZL(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "7")]
			bool VBIUYEBHXBL(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(Slot = "8")]
			bool HWBDZBMNVGV(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(Slot = "9")]
			bool BFZIPYUCSBN(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(Slot = "10")]
			bool TYGDSSYZSAW(b a, a b);
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public interface MDFEQTCPLCK<a, b, c>
		{
			[Cpp2IlInjected.Token(Token = "0x17000009")]
			a CPHRSEMEXMO
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			b KYKJOFKQEMR
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			c CXRYLDTXRXC
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public interface EIUEKENQCJW<a, b> where a : notnull where b : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "0")]
			Id32<BVHHKRGRDMC> XZVQGNNGUHF(b a);

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void HXBQZUPHUYU(b a);

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Task<Result<object, SKKNIPYCQUO>> DHXGMDSKOIZ(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(Slot = "3")]
			a[] CZEVWGOVSCB(b a);
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public interface FWOEJNVWAJL<a, b>
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(Slot = "0")]
			int KYLVYZAKZUZ(b a);

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			int MZXFTEGTODR(b a);

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			int NYJIWCTCCNK(b a);

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			int KMWLZYRAKAM(b a);

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void BZOACXAHRRZ(b a);

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(Slot = "5")]
			bool PXSXXPTSZAM(b a, Id32<BVHHKRGRDMC> b, a[] c);

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "6")]
			bool KNXLLWQUBHM(b a, int b);

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "7")]
			Task<Result<object, SKKNIPYCQUO>> VWNRQDAMUSS(b a, Id32<BVHHKRGRDMC> b, a c, bool d = true);
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
