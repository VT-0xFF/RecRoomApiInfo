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
		[Cpp2IlInjected.Address(RVA = "0x7BA380", Offset = "0x7B8D80", VA = "0x1807BA380")]
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
		[Cpp2IlInjected.Address(RVA = "0x5759EE0", Offset = "0x57588E0", VA = "0x185759EE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7BA560", Offset = "0x7B8F60", VA = "0x1807BA560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BA5A0", Offset = "0x7B8FA0", VA = "0x1807BA5A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JBOKMCFNCOF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GDNMOKOHIIO<Texture2D> OEINPHAIBJE(string NMDHFOJFGDH, [Optional] uint? EPLEIABFFCM, bool GIHNLNPCKAL = false, FOGBINHLPDK FBIFILCIDNL = FOGBINHLPDK.Default);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GDNMOKOHIIO<Texture2D> PHPPEJLNFDD(OLAJKMBDGMB CLLJMNNNICI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GDNMOKOHIIO<Texture2D> BGMIKEMPLCF(PPJOAGMNPPB HMIDDBGIOGE);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GDNMOKOHIIO<Texture2D> JJKJEHKFEGN(EPMACIOCLIA CHFDAFHNIME);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GDNMOKOHIIO<Texture2D> ELKOFBIIKJC(GBMJGIENLCC KPPLFMNJFMG);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GDNMOKOHIIO<Texture2D> PGHOKMLPIND(HJEABDBEGJK KCBFJGCIJLP);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class FNKPNFAHMAC : JBOKMCFNCOF
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private readonly struct CIAINGGOGJM : IEquatable<CIAINGGOGJM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly string HCCONPMFDEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly uint? NDMFPFJDAJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly bool JNDCGDFPFOF;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5756840", Offset = "0x5755240", VA = "0x185756840")]
		public CIAINGGOGJM(string NMDHFOJFGDH, uint? EPLEIABFFCM, bool GIHNLNPCKAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5756550", Offset = "0x5754F50", VA = "0x185756550", Slot = "4")]
		public bool Equals(CIAINGGOGJM CGDFJMJIABO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5756610", Offset = "0x5755010", VA = "0x185756610", Slot = "0")]
		public override bool Equals(object GKNPKJAGNGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x57566B0", Offset = "0x57550B0", VA = "0x1857566B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5756730", Offset = "0x5755130", VA = "0x185756730", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private sealed class JIJMDHMKMNI : PGIJLLFCBAB<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct IEEFJGFHNDO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Task<OGDBMBLCOHC<Task<Texture2D>>> outerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private TaskAwaiter<OGDBMBLCOHC<Task<Texture2D>>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private TaskAwaiter<Texture2D> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5758840", Offset = "0x5757240", VA = "0x185758840", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5758B00", Offset = "0x5757500", VA = "0x185758B00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private struct EHJCGCCEOMH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Task<OGDBMBLCOHC<Task<Texture2D>>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private TaskAwaiter<OGDBMBLCOHC<Task<Texture2D>>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5756FE0", Offset = "0x57559E0", VA = "0x185756FE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5757190", Offset = "0x5755B90", VA = "0x185757190", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Task<OGDBMBLCOHC<Task<Texture2D>>> NAEDBEDAJLN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override Task<Texture2D> LKACNNIFJCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x793B40", Offset = "0x792540", VA = "0x180793B40", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override HECHONBOMGO<Texture2D> GKLDEHMEPDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x793910", Offset = "0x792310", VA = "0x180793910", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5758E40", Offset = "0x5757840", VA = "0x185758E40")]
		public JIJMDHMKMNI(Task<OGDBMBLCOHC<Task<Texture2D>>> HGLNIMPGIKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5758D30", Offset = "0x5757730", VA = "0x185758D30", Slot = "10")]
		protected override void NCEPPALKHML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5758B70", Offset = "0x5757570", VA = "0x185758B70")]
		[AsyncStateMachine(typeof(IEEFJGFHNDO))]
		[CompilerGenerated]
		internal static Task<Texture2D> BMMNINOGNON(Task<OGDBMBLCOHC<Task<Texture2D>>> HDLHFCOBHJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5758C60", Offset = "0x5757660", VA = "0x185758C60")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(EHJCGCCEOMH))]
		internal static Task LGJCOGEMDDK(Task<OGDBMBLCOHC<Task<Texture2D>>> HGLNIMPGIKP)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct NFIIFHDJPHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder<byte[]> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public CIAINGGOGJM imageId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5759BD0", Offset = "0x57585D0", VA = "0x185759BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5759E70", Offset = "0x5758870", VA = "0x185759E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct DLEKFCFKKJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public AsyncTaskMethodBuilder<OGDBMBLCOHC<Task<Texture2D>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public uint? resizeWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public bool cropSquare;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public FNKPNFAHMAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public FOGBINHLPDK textureLoadOptions;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5756880", Offset = "0x5755280", VA = "0x185756880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5756A70", Offset = "0x5755470", VA = "0x185756A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct KJJPHNPKCEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<OGDBMBLCOHC<Task<Texture2D>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public OLAJKMBDGMB room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public FNKPNFAHMAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private TaskAwaiter<OGDBMBLCOHC<Task<Texture2D>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5759370", Offset = "0x5757D70", VA = "0x185759370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x57596A0", Offset = "0x57580A0", VA = "0x1857596A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct KFCLIJNDKDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public AsyncTaskMethodBuilder<OGDBMBLCOHC<Task<Texture2D>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public PPJOAGMNPPB invention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public FNKPNFAHMAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<OGDBMBLCOHC<Task<Texture2D>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5758FD0", Offset = "0x57579D0", VA = "0x185758FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5759300", Offset = "0x5757D00", VA = "0x185759300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct DLNDDLOBAOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<OGDBMBLCOHC<Task<Texture2D>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public EPMACIOCLIA playerEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public FNKPNFAHMAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter<OLAJKMBDGMB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<OGDBMBLCOHC<Task<Texture2D>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5756AE0", Offset = "0x57554E0", VA = "0x185756AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5756F70", Offset = "0x5755970", VA = "0x185756F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct MPLHNGIGJBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<OGDBMBLCOHC<Task<Texture2D>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public GBMJGIENLCC account;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public FNKPNFAHMAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private TaskAwaiter<OGDBMBLCOHC<Task<Texture2D>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5759710", Offset = "0x5758110", VA = "0x185759710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5759B60", Offset = "0x5758560", VA = "0x185759B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct GFEGACPJFJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public AsyncTaskMethodBuilder<OGDBMBLCOHC<Task<Texture2D>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public HJEABDBEGJK announcement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public FNKPNFAHMAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter<OGDBMBLCOHC<Task<Texture2D>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5758510", Offset = "0x5756F10", VA = "0x185758510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x57587D0", Offset = "0x57571D0", VA = "0x1857587D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly JEALLOBGGKM.Resolution ONGKEMPPHJL;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly JEALLOBGGKM.Resolution EAOBALOEMNN;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly JEALLOBGGKM.Resolution FNCLCIBEPGM;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly JEALLOBGGKM.Resolution OPOJJABDEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly NOIBPHNHGNL<CIAINGGOGJM> DJBKJGGDOCK;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5758070", Offset = "0x5756A70", VA = "0x185758070")]
	[BBBFDPEBAMC(HLEKCCEDPHP.GameOnly)]
	private static void PIIFFCABCNO(AFDLAPABCDH DFLLKHNKNDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5758360", Offset = "0x5756D60", VA = "0x185758360")]
	[Preserve]
	internal FNKPNFAHMAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5757D00", Offset = "0x5756700", VA = "0x185757D00", Slot = "4")]
	public GDNMOKOHIIO<Texture2D> OEINPHAIBJE(string NMDHFOJFGDH, [Optional] uint? EPLEIABFFCM, bool GIHNLNPCKAL = false, FOGBINHLPDK FBIFILCIDNL = FOGBINHLPDK.Default)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5757F10", Offset = "0x5756910", VA = "0x185757F10", Slot = "5")]
	public GDNMOKOHIIO<Texture2D> PHPPEJLNFDD(OLAJKMBDGMB CLLJMNNNICI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x57571F0", Offset = "0x5755BF0", VA = "0x1857571F0", Slot = "6")]
	public GDNMOKOHIIO<Texture2D> BGMIKEMPLCF(PPJOAGMNPPB HMIDDBGIOGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5757900", Offset = "0x5756300", VA = "0x185757900", Slot = "7")]
	public GDNMOKOHIIO<Texture2D> JJKJEHKFEGN(EPMACIOCLIA CHFDAFHNIME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5757460", Offset = "0x5755E60", VA = "0x185757460", Slot = "8")]
	public GDNMOKOHIIO<Texture2D> ELKOFBIIKJC(GBMJGIENLCC KPPLFMNJFMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5757DB0", Offset = "0x57567B0", VA = "0x185757DB0", Slot = "9")]
	public GDNMOKOHIIO<Texture2D> PGHOKMLPIND(HJEABDBEGJK KCBFJGCIJLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5757A70", Offset = "0x5756470", VA = "0x185757A70")]
	[AsyncStateMachine(typeof(NFIIFHDJPHE))]
	private Task<byte[]> LIOBKDHFAEO(CIAINGGOGJM JPDEAPBDCNA, CancellationToken EAPNOLMLMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5757BA0", Offset = "0x57565A0", VA = "0x185757BA0")]
	[AsyncStateMachine(typeof(DLEKFCFKKJB))]
	private Task<OGDBMBLCOHC<Task<Texture2D>>> MBNOEOOACPM(string NMDHFOJFGDH, [Optional] uint? EPLEIABFFCM, bool GIHNLNPCKAL = false, FOGBINHLPDK FBIFILCIDNL = FOGBINHLPDK.Default)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5757350", Offset = "0x5755D50", VA = "0x185757350")]
	[AsyncStateMachine(typeof(KJJPHNPKCEM))]
	private Task<OGDBMBLCOHC<Task<Texture2D>>> CEBGHHCDJBH(OLAJKMBDGMB CLLJMNNNICI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x57575C0", Offset = "0x5755FC0", VA = "0x1857575C0")]
	[AsyncStateMachine(typeof(KFCLIJNDKDO))]
	private Task<OGDBMBLCOHC<Task<Texture2D>>> EMOPAPKKMGI(PPJOAGMNPPB HMIDDBGIOGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x57576D0", Offset = "0x57560D0", VA = "0x1857576D0")]
	[AsyncStateMachine(typeof(DLNDDLOBAOA))]
	private Task<OGDBMBLCOHC<Task<Texture2D>>> GOMCODMJLMA(EPMACIOCLIA CHFDAFHNIME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5758170", Offset = "0x5756B70", VA = "0x185758170")]
	[AsyncStateMachine(typeof(MPLHNGIGJBO))]
	private Task<OGDBMBLCOHC<Task<Texture2D>>> PKCACMLCGDE(GBMJGIENLCC KPPLFMNJFMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x57577F0", Offset = "0x57561F0", VA = "0x1857577F0")]
	[AsyncStateMachine(typeof(GFEGACPJFJO))]
	private Task<OGDBMBLCOHC<Task<Texture2D>>> ICMLBAGKMEE(HJEABDBEGJK KCBFJGCIJLP)
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
