using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer.Attributes;
using RecRoom.NoEngine.Common;
using UnityEngine;

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
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6270940", Offset = "0x626F340", VA = "0x186270940")]
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
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
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
namespace _AssemblyRegistry.RecNet_Images
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : FDEGBGNEMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6270DE0", Offset = "0x626F7E0", VA = "0x186270DE0", Slot = "8")]
		public override void CPJKPCOPIOF(INNEGFJDCKJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x626DEE0", Offset = "0x626C8E0", VA = "0x18626DEE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface OJPFIJFBAHG
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NNLLBGLJADF<Texture2D> LDDNGIJBCJA(string OGGIFNPDOEB, [Optional] uint? JJPJCMLGNIM, bool OHIDNGIHKAO = false, HKPGJGACGBP DCCKKAJIDDH = HKPGJGACGBP.Default);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NNLLBGLJADF<Texture2D> OGINFCLCDJC(BAMGIEGLIFC JBNNOLFNFCI);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NNLLBGLJADF<Texture2D> MCKMJONLACI(LMILNFEIOFA FFLOFABNLIF);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NNLLBGLJADF<Texture2D> FBCMDCMHPEB(LCGJOFALIMM MNPJGCOMHEP);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NNLLBGLJADF<Texture2D> GEJEKIGKIEJ(LAAPBDLOOLG ALNPOKPJAPO);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NNLLBGLJADF<Texture2D> GJENBDCHGMI(COBGJALOLPL IDGGBILMEOP);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal class MPPNEALPPFC : OJPFIJFBAHG
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct HMIMPPJKABP : IEquatable<HMIMPPJKABP>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly string MANECPCHKFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly uint? EMFJEIPFOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly bool BPMJJODJPLJ;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x626EFF0", Offset = "0x626D9F0", VA = "0x18626EFF0")]
		public HMIMPPJKABP(string OGGIFNPDOEB, uint? JJPJCMLGNIM, bool OHIDNGIHKAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x626ED00", Offset = "0x626D700", VA = "0x18626ED00", Slot = "4")]
		public bool Equals(HMIMPPJKABP CGCLEIBHLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x626EDC0", Offset = "0x626D7C0", VA = "0x18626EDC0", Slot = "0")]
		public override bool Equals(object FHFDEAHMMBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x626EE60", Offset = "0x626D860", VA = "0x18626EE60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x626EEE0", Offset = "0x626D8E0", VA = "0x18626EEE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct ABBAMAAEBMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public AsyncTaskMethodBuilder<byte[]> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public HMIMPPJKABP imageId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x626DEF0", Offset = "0x626C8F0", VA = "0x18626DEF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x626E190", Offset = "0x626CB90", VA = "0x18626E190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct CBODCGLGCBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AsyncTaskMethodBuilder<NNLLBGLJADF<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public uint? resizeWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public bool cropSquare;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public MPPNEALPPFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public HKPGJGACGBP textureLoadOptions;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x626E200", Offset = "0x626CC00", VA = "0x18626E200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x626E3F0", Offset = "0x626CDF0", VA = "0x18626E3F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct CNLEONKHLML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder<NNLLBGLJADF<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public BAMGIEGLIFC room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public MPPNEALPPFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private TaskAwaiter<NNLLBGLJADF<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x626E460", Offset = "0x626CE60", VA = "0x18626E460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x626E790", Offset = "0x626D190", VA = "0x18626E790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct NPCEFFNDGPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public AsyncTaskMethodBuilder<NNLLBGLJADF<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public LMILNFEIOFA invention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public MPPNEALPPFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<NNLLBGLJADF<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x62705A0", Offset = "0x626EFA0", VA = "0x1862705A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x62708D0", Offset = "0x626F2D0", VA = "0x1862708D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct HKGPFPKCDCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<NNLLBGLJADF<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public LCGJOFALIMM playerEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public MPPNEALPPFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter<BAMGIEGLIFC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<NNLLBGLJADF<Texture2D>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x626E800", Offset = "0x626D200", VA = "0x18626E800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x626EC90", Offset = "0x626D690", VA = "0x18626EC90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct PEACIAPCJON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<NNLLBGLJADF<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public LAAPBDLOOLG account;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public MPPNEALPPFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<NNLLBGLJADF<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x62709C0", Offset = "0x626F3C0", VA = "0x1862709C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6270D00", Offset = "0x626F700", VA = "0x186270D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct MFMNAACFHNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<NNLLBGLJADF<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public COBGJALOLPL announcement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public MPPNEALPPFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<NNLLBGLJADF<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x626F030", Offset = "0x626DA30", VA = "0x18626F030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x626F2F0", Offset = "0x626DCF0", VA = "0x18626F2F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly AEBJPABOMAL.Resolution CHBCBLIKKJA;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly AEBJPABOMAL.Resolution IBEEEFAJJCE;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly AEBJPABOMAL.Resolution GHAGCJBOFCI;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly AEBJPABOMAL.Resolution FGPFDFNLIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly MNDMKLKOINM<HMIMPPJKABP> LAEMBNLBKKB;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x626F360", Offset = "0x626DD60", VA = "0x18626F360")]
	[MDINNNLEANF.FIHKBCJDGBK.GBDNBGLLJBG]
	internal static void AABKCNFOEAJ(FNNNJBMCDDC NKDOKEFKKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x62703F0", Offset = "0x626EDF0", VA = "0x1862703F0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal MPPNEALPPFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x626FF10", Offset = "0x626E910", VA = "0x18626FF10", Slot = "4")]
	public NNLLBGLJADF<Texture2D> LDDNGIJBCJA(string OGGIFNPDOEB, [Optional] uint? JJPJCMLGNIM, bool OHIDNGIHKAO = false, HKPGJGACGBP DCCKKAJIDDH = HKPGJGACGBP.Default)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x62700E0", Offset = "0x626EAE0", VA = "0x1862700E0", Slot = "5")]
	public NNLLBGLJADF<Texture2D> OGINFCLCDJC(BAMGIEGLIFC JBNNOLFNFCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x626FFA0", Offset = "0x626E9A0", VA = "0x18626FFA0", Slot = "6")]
	public NNLLBGLJADF<Texture2D> MCKMJONLACI(LMILNFEIOFA FFLOFABNLIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x626F6D0", Offset = "0x626E0D0", VA = "0x18626F6D0", Slot = "7")]
	public NNLLBGLJADF<Texture2D> FBCMDCMHPEB(LCGJOFALIMM MNPJGCOMHEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x626F820", Offset = "0x626E220", VA = "0x18626F820", Slot = "8")]
	public NNLLBGLJADF<Texture2D> GEJEKIGKIEJ(LAAPBDLOOLG ALNPOKPJAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x626FA70", Offset = "0x626E470", VA = "0x18626FA70", Slot = "9")]
	public NNLLBGLJADF<Texture2D> GJENBDCHGMI(COBGJALOLPL IDGGBILMEOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x626FDE0", Offset = "0x626E7E0", VA = "0x18626FDE0")]
	[AsyncStateMachine(typeof(ABBAMAAEBMD))]
	private Task<byte[]> LCOPOFPJLIN(HMIMPPJKABP HPJLKKIKNBF, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x626F460", Offset = "0x626DE60", VA = "0x18626F460")]
	[AsyncStateMachine(typeof(CBODCGLGCBA))]
	private Task<NNLLBGLJADF<Texture2D>> DIGDLNGIGMH(string OGGIFNPDOEB, [Optional] uint? JJPJCMLGNIM, bool OHIDNGIHKAO = false, HKPGJGACGBP DCCKKAJIDDH = HKPGJGACGBP.Default)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x626F5C0", Offset = "0x626DFC0", VA = "0x18626F5C0")]
	[AsyncStateMachine(typeof(CNLEONKHLML))]
	private Task<NNLLBGLJADF<Texture2D>> ECMNJFELOAD(BAMGIEGLIFC JBNNOLFNFCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x626F960", Offset = "0x626E360", VA = "0x18626F960")]
	[AsyncStateMachine(typeof(NPCEFFNDGPF))]
	private Task<NNLLBGLJADF<Texture2D>> GGHAPJEJDOD(LMILNFEIOFA FFLOFABNLIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x626FBB0", Offset = "0x626E5B0", VA = "0x18626FBB0")]
	[AsyncStateMachine(typeof(HKGPFPKCDCB))]
	private Task<NNLLBGLJADF<Texture2D>> IOMGPEJLGLE(LCGJOFALIMM MNPJGCOMHEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6270220", Offset = "0x626EC20", VA = "0x186270220")]
	[AsyncStateMachine(typeof(PEACIAPCJON))]
	private Task<NNLLBGLJADF<Texture2D>> PGIIKMNKHPB(LAAPBDLOOLG ALNPOKPJAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x626FCD0", Offset = "0x626E6D0", VA = "0x18626FCD0")]
	[AsyncStateMachine(typeof(MFMNAACFHNH))]
	private Task<NNLLBGLJADF<Texture2D>> JPNLLGFFJJH(COBGJALOLPL IDGGBILMEOP)
	{
		return null;
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
