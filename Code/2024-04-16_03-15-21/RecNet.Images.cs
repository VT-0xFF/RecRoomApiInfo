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
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
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
		[Cpp2IlInjected.Address(RVA = "0x588E560", Offset = "0x588D760", VA = "0x18588E560")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
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
public interface KNAAAACJEJO
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DHELPBBEMKN<Texture2D> IKHOKDPPDCE(string MCJHBJKBBPP, [Optional] uint? HOKNNOGDLOC, bool CMNMPHKHPBL = false, GGEOFOPGBDM DIIDIHNLHLB = GGEOFOPGBDM.Default);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DHELPBBEMKN<Texture2D> PGHDKFBEKFF(EJFPLDPBHOB NHOJJFCMNCL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DHELPBBEMKN<Texture2D> HGJIKAEEABB(MEKLPFNEFBH JALBIGLMNBG);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DHELPBBEMKN<Texture2D> DBIFNFMABPI(BOIGPPJKBAO AHEPGDLAIGF);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DHELPBBEMKN<Texture2D> NGOGLGMJPFA(DHHDICHIKAO JGCDEFFCMHE);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DHELPBBEMKN<Texture2D> IBICEDPOCLA(IFOLCOHBDEN KGIAHADHDFL);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class NGAHBBIDPBE : KNAAAACJEJO
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private readonly struct FDNLKJFAAOI : IEquatable<FDNLKJFAAOI>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly string IPDHIDHCLLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly uint? KFEFOHBCBHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly bool FILGJPJAJOL;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x588BD70", Offset = "0x588AF70", VA = "0x18588BD70")]
		public FDNLKJFAAOI(string MCJHBJKBBPP, uint? HOKNNOGDLOC, bool CMNMPHKHPBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x588BB20", Offset = "0x588AD20", VA = "0x18588BB20", Slot = "4")]
		public bool Equals(FDNLKJFAAOI MEJMHKPOODP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x588BA80", Offset = "0x588AC80", VA = "0x18588BA80", Slot = "0")]
		public override bool Equals(object GLMGCMELGFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x588BBE0", Offset = "0x588ADE0", VA = "0x18588BBE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x588BC60", Offset = "0x588AE60", VA = "0x18588BC60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct OMPAEFHEAFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public AsyncTaskMethodBuilder<byte[]> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public FDNLKJFAAOI imageId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x588E5E0", Offset = "0x588D7E0", VA = "0x18588E5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x588E880", Offset = "0x588DA80", VA = "0x18588E880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct GCAIAJHFPEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AsyncTaskMethodBuilder<DHELPBBEMKN<Texture2D>> <>t__builder;

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
		public NGAHBBIDPBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public GGEOFOPGBDM textureLoadOptions;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x588C150", Offset = "0x588B350", VA = "0x18588C150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x588C340", Offset = "0x588B540", VA = "0x18588C340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct GANLGHEJONB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder<DHELPBBEMKN<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public EJFPLDPBHOB room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public NGAHBBIDPBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private TaskAwaiter<DHELPBBEMKN<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x588BDB0", Offset = "0x588AFB0", VA = "0x18588BDB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x588C0E0", Offset = "0x588B2E0", VA = "0x18588C0E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct IGMKOHEFCIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public AsyncTaskMethodBuilder<DHELPBBEMKN<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public MEKLPFNEFBH invention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public NGAHBBIDPBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<DHELPBBEMKN<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x588C760", Offset = "0x588B960", VA = "0x18588C760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x588CA90", Offset = "0x588BC90", VA = "0x18588CA90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct JLAENACHOCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<DHELPBBEMKN<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public BOIGPPJKBAO playerEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public NGAHBBIDPBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter<EJFPLDPBHOB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<DHELPBBEMKN<Texture2D>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x588CB00", Offset = "0x588BD00", VA = "0x18588CB00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x588CF90", Offset = "0x588C190", VA = "0x18588CF90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct HAJHIALBLGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<DHELPBBEMKN<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public DHHDICHIKAO account;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public NGAHBBIDPBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<DHELPBBEMKN<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x588C3B0", Offset = "0x588B5B0", VA = "0x18588C3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x588C6F0", Offset = "0x588B8F0", VA = "0x18588C6F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct LINACGGHKNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<DHELPBBEMKN<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public IFOLCOHBDEN announcement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public NGAHBBIDPBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<DHELPBBEMKN<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x588D000", Offset = "0x588C200", VA = "0x18588D000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x588D2C0", Offset = "0x588C4C0", VA = "0x18588D2C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly DHIGFMCKBPO.Resolution LBMJDKDBKJG;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly DHIGFMCKBPO.Resolution MBALGJKNMCM;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly DHIGFMCKBPO.Resolution OAPNDPGMJAK;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly DHIGFMCKBPO.Resolution MLNOHHHFBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly EIKIBIEOABF<FDNLKJFAAOI> FPELAOPDBBD;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x588E0C0", Offset = "0x588D2C0", VA = "0x18588E0C0")]
	[BDCLMMIIFOD(CIJFMPALMOO.GameOnly)]
	private static void PBBGMOAEECN(JGBEMAKPOMJ BIBKBFDHJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x588E3B0", Offset = "0x588D5B0", VA = "0x18588E3B0")]
	[Preserve]
	internal NGAHBBIDPBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x588DBC0", Offset = "0x588CDC0", VA = "0x18588DBC0", Slot = "4")]
	public DHELPBBEMKN<Texture2D> IKHOKDPPDCE(string MCJHBJKBBPP, [Optional] uint? HOKNNOGDLOC, bool CMNMPHKHPBL = false, GGEOFOPGBDM DIIDIHNLHLB = GGEOFOPGBDM.Default)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x588E1B0", Offset = "0x588D3B0", VA = "0x18588E1B0", Slot = "5")]
	public DHELPBBEMKN<Texture2D> PGHDKFBEKFF(EJFPLDPBHOB NHOJJFCMNCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x588D6C0", Offset = "0x588C8C0", VA = "0x18588D6C0", Slot = "6")]
	public DHELPBBEMKN<Texture2D> HGJIKAEEABB(MEKLPFNEFBH JALBIGLMNBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x588D330", Offset = "0x588C530", VA = "0x18588D330", Slot = "7")]
	public DHELPBBEMKN<Texture2D> DBIFNFMABPI(BOIGPPJKBAO AHEPGDLAIGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x588DE70", Offset = "0x588D070", VA = "0x18588DE70", Slot = "8")]
	public DHELPBBEMKN<Texture2D> NGOGLGMJPFA(DHHDICHIKAO JGCDEFFCMHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x588D800", Offset = "0x588CA00", VA = "0x18588D800", Slot = "9")]
	public DHELPBBEMKN<Texture2D> IBICEDPOCLA(IFOLCOHBDEN KGIAHADHDFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x588D590", Offset = "0x588C790", VA = "0x18588D590")]
	[AsyncStateMachine(typeof(OMPAEFHEAFK))]
	private Task<byte[]> HBNIDNADMPL(FDNLKJFAAOI GOEJBLBFENF, CancellationToken IOOGCHJMBIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x588D940", Offset = "0x588CB40", VA = "0x18588D940")]
	[AsyncStateMachine(typeof(GCAIAJHFPEE))]
	private Task<DHELPBBEMKN<Texture2D>> IBILDNJNDEB(string MCJHBJKBBPP, [Optional] uint? HOKNNOGDLOC, bool CMNMPHKHPBL = false, GGEOFOPGBDM DIIDIHNLHLB = GGEOFOPGBDM.Default)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x588DD60", Offset = "0x588CF60", VA = "0x18588DD60")]
	[AsyncStateMachine(typeof(GANLGHEJONB))]
	private Task<DHELPBBEMKN<Texture2D>> LMEHLDKFKBL(EJFPLDPBHOB NHOJJFCMNCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x588DC50", Offset = "0x588CE50", VA = "0x18588DC50")]
	[AsyncStateMachine(typeof(IGMKOHEFCIG))]
	private Task<DHELPBBEMKN<Texture2D>> JADHAACIDOB(MEKLPFNEFBH JALBIGLMNBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x588DAA0", Offset = "0x588CCA0", VA = "0x18588DAA0")]
	[AsyncStateMachine(typeof(JLAENACHOCG))]
	private Task<DHELPBBEMKN<Texture2D>> ICNAEEIENNP(BOIGPPJKBAO AHEPGDLAIGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x588D480", Offset = "0x588C680", VA = "0x18588D480")]
	[AsyncStateMachine(typeof(HAJHIALBLGE))]
	private Task<DHELPBBEMKN<Texture2D>> DBLDDLDALLP(DHHDICHIKAO JGCDEFFCMHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x588DFB0", Offset = "0x588D1B0", VA = "0x18588DFB0")]
	[AsyncStateMachine(typeof(LINACGGHKNH))]
	private Task<DHELPBBEMKN<Texture2D>> OENLHAOABOC(IFOLCOHBDEN KGIAHADHDFL)
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
