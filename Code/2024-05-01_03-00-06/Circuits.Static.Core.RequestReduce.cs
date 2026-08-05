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
		[Cpp2IlInjected.Address(RVA = "0x7D9A20", Offset = "0x7D8820", VA = "0x1807D9A20")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E40E30", Offset = "0x1E3FC30", VA = "0x181E40E30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D9DC0", Offset = "0x7D8BC0", VA = "0x1807D9DC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D9E00", Offset = "0x7D8C00", VA = "0x1807D9E00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate LFOHHNFLFGN<TActionKind, TPayload> JIFLGJPHODB<TActionKind, TSerializedAction, TPayload>(TSerializedAction BFHAAOCMHEC);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface CCFEMCJBAFL<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PJPNKGNAEHO<object, IIPPAHIAEHC>> LBLAEHNKFCE(TDeps GLJEJHKFIBB, TRoot GDOPFEEANMP, TSerializedAction BFHAAOCMHEC);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class ENPBDCMFKJO<TActionKind, TSerializedAction, TRoot, TDeps> : IPEMGGHMFOC where TDeps : PGMKEMAFMAD.GAGKNKPIFPH<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps PIBJMGMHGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction JMOMDMMLJAI;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x34C3F60", Offset = "0x34C2D60", VA = "0x1834C3F60")]
	public ENPBDCMFKJO([In] TDeps GLJEJHKFIBB, [In] TSerializedAction BFHAAOCMHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x34C3D50", Offset = "0x34C2B50", VA = "0x1834C3D50", Slot = "7")]
	public override string AGPNECGLHAF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct LFOHHNFLFGN<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind GPCJJGLOPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload LPCKNNNEBHD;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3DB4F20", Offset = "0x3DB3D20", VA = "0x183DB4F20")]
	internal LFOHHNFLFGN(TActionKind DGKODMCLAID, [In] TPayload PENMOOOPINK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class BEFEFAIAIOO
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x26A6A60", Offset = "0x26A5860", VA = "0x1826A6A60")]
	public static LFOHHNFLFGN<TActionKind, TPayload> KHDJPNLCMFA<TActionKind, TPayload>([In] TActionKind DGKODMCLAID, [In] TPayload PENMOOOPINK)
	{
		return default(LFOHHNFLFGN<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<PJPNKGNAEHO<TOk, TErr>> PMOLADDLANE<TRoot, TPayload, TOk, TErr>(TRoot GDOPFEEANMP, TPayload PENMOOOPINK);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate PJPNKGNAEHO<TOk, TErr> HDLJCCCNDAM<TRoot, TPayload, TOk, TErr>(TRoot GDOPFEEANMP, [In] TPayload PENMOOOPINK);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct AKJFNCGCPPF<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : PGMKEMAFMAD.GAGKNKPIFPH<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct MEPDDJDJGCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<PJPNKGNAEHO<object, IIPPAHIAEHC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AKJFNCGCPPF<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<PJPNKGNAEHO<object, IIPPAHIAEHC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3F872A0", Offset = "0x3F860A0", VA = "0x183F872A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3F87B70", Offset = "0x3F86970", VA = "0x183F87B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, CCFEMCJBAFL<TSerializedAction, TRoot, TDeps>> AGPNHDADCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps PIBJMGMHGME;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x93C520", Offset = "0x93B320", VA = "0x18093C520")]
	internal AKJFNCGCPPF(Dictionary<TActionKind, CCFEMCJBAFL<TSerializedAction, TRoot, TDeps>> OEDPMLJKHAB, TDeps GLJEJHKFIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3917740", Offset = "0x3916540", VA = "0x183917740")]
	[AsyncStateMachine(typeof(AKJFNCGCPPF<, , , >.MEPDDJDJGCG))]
	public Task<PJPNKGNAEHO<object, IIPPAHIAEHC>> LBLAEHNKFCE(TRoot GDOPFEEANMP, TSerializedAction BFHAAOCMHEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class PGMKEMAFMAD
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface GAGKNKPIFPH<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind GNHCHALAOLJ(TSerializedAction ILACEKALGJH);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DJPPEIKOENF(TRoot GDOPFEEANMP, TSerializedAction GOECALGCLOK);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void FOBIBACMGDG(TRoot GDOPFEEANMP, TSerializedAction GOECALGCLOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2909A00", Offset = "0x2908800", VA = "0x182909A00")]
	internal static AKJFNCGCPPF<TActionKind, TSerializedAction, TRoot, TDeps> KHDJPNLCMFA<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, CCFEMCJBAFL<TSerializedAction, TRoot, TDeps>> OEDPMLJKHAB, TDeps GLJEJHKFIBB) where TDeps : GAGKNKPIFPH<TActionKind, TSerializedAction, TRoot>
	{
		return default(AKJFNCGCPPF<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class LGGKLCCGCGP<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, CCFEMCJBAFL<TSerializedAction, TRoot, TDeps>> HPEFDIKKMBE;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7B1CB0", Offset = "0x7B0AB0", VA = "0x1807B1CB0")]
	private LGGKLCCGCGP(Dictionary<TActionKind, CCFEMCJBAFL<TSerializedAction, TRoot, TDeps>> OEDPMLJKHAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3DB61D0", Offset = "0x3DB4FD0", VA = "0x183DB61D0")]
	public static LGGKLCCGCGP<TActionKind, TSerializedAction, TRoot, TDeps> KHDJPNLCMFA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct NMEJLDLFDMG<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, PGMKEMAFMAD.GAGKNKPIFPH<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class KGMBCBOOKEC<TPayload, TOk, TErr> : CCFEMCJBAFL<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, IIPPAHIAEHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly JIFLGJPHODB<TActionKind, TSerializedAction, TPayload> CMDFJBEGCGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly HDLJCCCNDAM<TRoot, TPayload, TOk, TErr> JBEGBAHCOCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool LFHJEHNCFOI;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3D07CD0", Offset = "0x3D06AD0", VA = "0x183D07CD0")]
		public KGMBCBOOKEC(JIFLGJPHODB<TActionKind, TSerializedAction, TPayload> BJDABDGHLNN, HDLJCCCNDAM<TRoot, TPayload, TOk, TErr> EELEKNDCIIO, bool NHPBNIABEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3D00910", Offset = "0x3CFF710", VA = "0x183D00910", Slot = "4")]
		public Task<PJPNKGNAEHO<object, IIPPAHIAEHC>> LBLAEHNKFCE(TDeps GLJEJHKFIBB, TRoot GDOPFEEANMP, TSerializedAction BFHAAOCMHEC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class PFDHFLNMEIN<TPayload, TOk, TErr> : CCFEMCJBAFL<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, IIPPAHIAEHC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct HJPEFLPOKNL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<PJPNKGNAEHO<object?, IIPPAHIAEHC>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public TDeps deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public TRoot root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public TSerializedAction serializedAction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public PFDHFLNMEIN<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private PJPNKGNAEHO<object?, IIPPAHIAEHC> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<PJPNKGNAEHO<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x39C77A0", Offset = "0x39C65A0", VA = "0x1839C77A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x39C8E20", Offset = "0x39C7C20", VA = "0x1839C8E20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly JIFLGJPHODB<TActionKind, TSerializedAction, TPayload> CMDFJBEGCGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly PMOLADDLANE<TRoot, TPayload, TOk, TErr> JBEGBAHCOCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool LFHJEHNCFOI;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3D07CD0", Offset = "0x3D06AD0", VA = "0x183D07CD0")]
		public PFDHFLNMEIN(JIFLGJPHODB<TActionKind, TSerializedAction, TPayload> BJDABDGHLNN, PMOLADDLANE<TRoot, TPayload, TOk, TErr> EELEKNDCIIO, bool NHPBNIABEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x41CBFC0", Offset = "0x41CADC0", VA = "0x1841CBFC0", Slot = "4")]
		[AsyncStateMachine(typeof(PFDHFLNMEIN<, , >.HJPEFLPOKNL))]
		public Task<PJPNKGNAEHO<object, IIPPAHIAEHC>> LBLAEHNKFCE(TDeps GLJEJHKFIBB, TRoot GDOPFEEANMP, TSerializedAction BFHAAOCMHEC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly LGGKLCCGCGP<TActionKind, TSerializedAction, TRoot, TDeps> EOMDOAOMKBD;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x93C860", Offset = "0x93B660", VA = "0x18093C860")]
	private NMEJLDLFDMG(LGGKLCCGCGP<TActionKind, TSerializedAction, TRoot, TDeps> LHODDAGAJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4047E70", Offset = "0x4046C70", VA = "0x184047E70")]
	public static NMEJLDLFDMG<TActionKind, TSerializedAction, TRoot, TDeps> KHDJPNLCMFA()
	{
		return default(NMEJLDLFDMG<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x27E5E50", Offset = "0x27E4C50", VA = "0x1827E5E50")]
	public NMEJLDLFDMG<TActionKind, TSerializedAction, TRoot, TDeps> BPPJPMNLLJC<TPayload, TOk, TErr>(TActionKind DGKODMCLAID, JIFLGJPHODB<TActionKind, TSerializedAction, TPayload> BJDABDGHLNN, HDLJCCCNDAM<TRoot, TPayload, TOk, TErr> EELEKNDCIIO, bool NHPBNIABEKB = true) where TPayload : notnull where TOk : notnull where TErr : notnull, IIPPAHIAEHC
	{
		return default(NMEJLDLFDMG<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x27E5E50", Offset = "0x27E4C50", VA = "0x1827E5E50")]
	public NMEJLDLFDMG<TActionKind, TSerializedAction, TRoot, TDeps> LICMAPFMDKB<TPayload, TOk, TErr>(TActionKind DGKODMCLAID, JIFLGJPHODB<TActionKind, TSerializedAction, TPayload> BJDABDGHLNN, PMOLADDLANE<TRoot, TPayload, TOk, TErr> EELEKNDCIIO, bool NHPBNIABEKB = true) where TPayload : notnull where TOk : notnull where TErr : notnull, IIPPAHIAEHC
	{
		return default(NMEJLDLFDMG<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4047F00", Offset = "0x4046D00", VA = "0x184047F00")]
	public AKJFNCGCPPF<TActionKind, TSerializedAction, TRoot, TDeps> KOHIIJEKJDE(TDeps GLJEJHKFIBB)
	{
		return default(AKJFNCGCPPF<TActionKind, TSerializedAction, TRoot, TDeps>);
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
