using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
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
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5FEBF60", Offset = "0x5FEAB60", VA = "0x185FEBF60")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86E660", Offset = "0x86D260", VA = "0x18086E660")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E6A0", Offset = "0x86D2A0", VA = "0x18086E6A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LPGJBIJPEIO
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OBOGMAPJNLF<Texture2D> PHOCILKIMBC(string ODMDHGIMIKM, [Optional] uint? AGNDOCPJEHI, bool DJDBONEMPMD = false, HLBJBNGNANI ODKPCLDMMIH = HLBJBNGNANI.Default);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OBOGMAPJNLF<Texture2D> JMMGBGILJLP(AEAIGAFEFHM NBBIEGKGBPO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OBOGMAPJNLF<Texture2D> JGNNAJPMIED(CLFLDCHFDBM BJGDKBBOEPF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OBOGMAPJNLF<Texture2D> COMHIOHJMIB(JIHOIIMOPPH LLLGDHDOFJD);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OBOGMAPJNLF<Texture2D> PCOFICAIMGI(NBMPOJDPANG LIMJHGOCNEB);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OBOGMAPJNLF<Texture2D> NBMICFAPKID(DBMIHAPODIP BHHOCFAPHFD);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class JCOCBHLCLGF : LPGJBIJPEIO
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private readonly struct CFNLLONNLBI : IEquatable<CFNLLONNLBI>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly string OKBMEIEFIOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly uint? OKHOLDKNKEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly bool GIFHOFPHMCO;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5FE9B80", Offset = "0x5FE8780", VA = "0x185FE9B80")]
		public CFNLLONNLBI(string ODMDHGIMIKM, uint? AGNDOCPJEHI, bool DJDBONEMPMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5FE9880", Offset = "0x5FE8480", VA = "0x185FE9880", Slot = "4")]
		public bool Equals(CFNLLONNLBI OCNJFCPHJLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5FE9940", Offset = "0x5FE8540", VA = "0x185FE9940", Slot = "0")]
		public override bool Equals(object HAHECKLGOJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5FE99F0", Offset = "0x5FE85F0", VA = "0x185FE99F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5FE9A70", Offset = "0x5FE8670", VA = "0x185FE9A70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct HIAJNDNFDKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public AsyncTaskMethodBuilder<byte[]> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public CFNLLONNLBI imageId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5FEA2A0", Offset = "0x5FE8EA0", VA = "0x185FEA2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5FEA540", Offset = "0x5FE9140", VA = "0x185FEA540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct NJHCJFNACAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AsyncTaskMethodBuilder<OBOGMAPJNLF<Texture2D>> <>t__builder;

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
		public JCOCBHLCLGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public HLBJBNGNANI textureLoadOptions;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5FEBD00", Offset = "0x5FEA900", VA = "0x185FEBD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5FEBEF0", Offset = "0x5FEAAF0", VA = "0x185FEBEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct BPPILNHJEDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder<OBOGMAPJNLF<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AEAIGAFEFHM room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public JCOCBHLCLGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private TaskAwaiter<OBOGMAPJNLF<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5FE94E0", Offset = "0x5FE80E0", VA = "0x185FE94E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5FE9810", Offset = "0x5FE8410", VA = "0x185FE9810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct PJGLEODGEKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public AsyncTaskMethodBuilder<OBOGMAPJNLF<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public CLFLDCHFDBM invention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public JCOCBHLCLGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<OBOGMAPJNLF<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5FEBFE0", Offset = "0x5FEABE0", VA = "0x185FEBFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5FEC310", Offset = "0x5FEAF10", VA = "0x185FEC310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct KIIKEJPEJCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<OBOGMAPJNLF<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public JIHOIIMOPPH playerEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JCOCBHLCLGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter<AEAIGAFEFHM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<OBOGMAPJNLF<Texture2D>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5FEB800", Offset = "0x5FEA400", VA = "0x185FEB800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5FEBC90", Offset = "0x5FEA890", VA = "0x185FEBC90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct HGHHIGJAMCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<OBOGMAPJNLF<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public NBMPOJDPANG account;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public JCOCBHLCLGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<OBOGMAPJNLF<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5FE9EF0", Offset = "0x5FE8AF0", VA = "0x185FE9EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5FEA230", Offset = "0x5FE8E30", VA = "0x185FEA230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct HDNMJPPGFPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<OBOGMAPJNLF<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public DBMIHAPODIP announcement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public JCOCBHLCLGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<OBOGMAPJNLF<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5FE9BC0", Offset = "0x5FE87C0", VA = "0x185FE9BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5FE9E80", Offset = "0x5FE8A80", VA = "0x185FE9E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly IPBKJDGLCMF.Resolution MAAKEIDOBHM;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly IPBKJDGLCMF.Resolution PDFADFBIDJG;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly IPBKJDGLCMF.Resolution OCBONEODLHF;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IPBKJDGLCMF.Resolution FGALIIGCKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly APPJKCLOGHF<CFNLLONNLBI> IGICHPBFFJJ;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5FEAF50", Offset = "0x5FE9B50", VA = "0x185FEAF50")]
	[FJJFAIMPJIC(JBEKPLNNIEC.GameOnly)]
	private static void JPDDIPCAKKO(LLIMAHMFNLB INBELNINGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5FEB650", Offset = "0x5FEA250", VA = "0x185FEB650")]
	[Preserve]
	internal JCOCBHLCLGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5FEB4E0", Offset = "0x5FEA0E0", VA = "0x185FEB4E0", Slot = "4")]
	public OBOGMAPJNLF<Texture2D> PHOCILKIMBC(string ODMDHGIMIKM, [Optional] uint? AGNDOCPJEHI, bool DJDBONEMPMD = false, HLBJBNGNANI ODKPCLDMMIH = HLBJBNGNANI.Default)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5FEAE10", Offset = "0x5FE9A10", VA = "0x185FEAE10", Slot = "5")]
	public OBOGMAPJNLF<Texture2D> JMMGBGILJLP(AEAIGAFEFHM NBBIEGKGBPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5FEACD0", Offset = "0x5FE98D0", VA = "0x185FEACD0", Slot = "6")]
	public OBOGMAPJNLF<Texture2D> JGNNAJPMIED(CLFLDCHFDBM BJGDKBBOEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5FEA6C0", Offset = "0x5FE92C0", VA = "0x185FEA6C0", Slot = "7")]
	public OBOGMAPJNLF<Texture2D> COMHIOHJMIB(JIHOIIMOPPH LLLGDHDOFJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5FEB3A0", Offset = "0x5FE9FA0", VA = "0x185FEB3A0", Slot = "8")]
	public OBOGMAPJNLF<Texture2D> PCOFICAIMGI(NBMPOJDPANG LIMJHGOCNEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5FEB040", Offset = "0x5FE9C40", VA = "0x185FEB040", Slot = "9")]
	public OBOGMAPJNLF<Texture2D> NBMICFAPKID(DBMIHAPODIP BHHOCFAPHFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5FEAA90", Offset = "0x5FE9690", VA = "0x185FEAA90")]
	[AsyncStateMachine(typeof(HIAJNDNFDKF))]
	private Task<byte[]> HJBIPPOCGFI(CFNLLONNLBI FGCGIIIOGME, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5FEA930", Offset = "0x5FE9530", VA = "0x185FEA930")]
	[AsyncStateMachine(typeof(NJHCJFNACAK))]
	private Task<OBOGMAPJNLF<Texture2D>> GBGOMCNBKKO(string ODMDHGIMIKM, [Optional] uint? AGNDOCPJEHI, bool DJDBONEMPMD = false, HLBJBNGNANI ODKPCLDMMIH = HLBJBNGNANI.Default)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5FEA5B0", Offset = "0x5FE91B0", VA = "0x185FEA5B0")]
	[AsyncStateMachine(typeof(BPPILNHJEDN))]
	private Task<OBOGMAPJNLF<Texture2D>> BKOEIIFPOLE(AEAIGAFEFHM NBBIEGKGBPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5FEB290", Offset = "0x5FE9E90", VA = "0x185FEB290")]
	[AsyncStateMachine(typeof(PJGLEODGEKE))]
	private Task<OBOGMAPJNLF<Texture2D>> OABOEGFOMHN(CLFLDCHFDBM BJGDKBBOEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5FEA810", Offset = "0x5FE9410", VA = "0x185FEA810")]
	[AsyncStateMachine(typeof(KIIKEJPEJCF))]
	private Task<OBOGMAPJNLF<Texture2D>> FNMBENKEEGI(JIHOIIMOPPH LLLGDHDOFJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5FEABC0", Offset = "0x5FE97C0", VA = "0x185FEABC0")]
	[AsyncStateMachine(typeof(HGHHIGJAMCD))]
	private Task<OBOGMAPJNLF<Texture2D>> HOOPIGNMGPP(NBMPOJDPANG LIMJHGOCNEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5FEB180", Offset = "0x5FE9D80", VA = "0x185FEB180")]
	[AsyncStateMachine(typeof(HDNMJPPGFPP))]
	private Task<OBOGMAPJNLF<Texture2D>> NFLDHFAHDGG(DBMIHAPODIP BHHOCFAPHFD)
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
