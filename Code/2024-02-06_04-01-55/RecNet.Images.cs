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
		[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8920", VA = "0x1807C9520")]
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
		[Cpp2IlInjected.Address(RVA = "0x580A650", Offset = "0x5809A50", VA = "0x18580A650")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7CA360", Offset = "0x7C9760", VA = "0x1807CA360")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CA3A0", Offset = "0x7C97A0", VA = "0x1807CA3A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NHNKJHIAEBD
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MCDOFGKDLFK<Texture2D> HCAAMLGJOGG(string GALKOCCKJLH, [Optional] uint? IGBJPMDFABH, bool IHINMPJNBKG = false, NFGOMEFEGBH HDCMNJIAGNP = NFGOMEFEGBH.Default);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MCDOFGKDLFK<Texture2D> AAFHEGMHDID(EFOAPBPFKPP GCDLOCBJJOE);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MCDOFGKDLFK<Texture2D> KKFGECCAAEO(HKBLIMJAMOE GDELGACBDCD);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MCDOFGKDLFK<Texture2D> LMJFCKAMEKD(MFMCMAPBJOO HCJNKCMJDLE);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MCDOFGKDLFK<Texture2D> CKABHKEKOEK(FOBHEOKDPHL JOENAJMINEK);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MCDOFGKDLFK<Texture2D> LPOBJFEILNC(NJIANBONNDP GHCMAANPAPA);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class HNPDIFDIMPD : NHNKJHIAEBD
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private readonly struct KMJBIBOKOAJ : IEquatable<KMJBIBOKOAJ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly string ONEKDNOLHGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly uint? GKNPAHOMAPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly bool FNPMJDDNBNF;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x580A300", Offset = "0x5809700", VA = "0x18580A300")]
		public KMJBIBOKOAJ(string GALKOCCKJLH, uint? IGBJPMDFABH, bool IHINMPJNBKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x580A010", Offset = "0x5809410", VA = "0x18580A010", Slot = "4")]
		public bool Equals(KMJBIBOKOAJ KMJGEHGGFFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x580A0D0", Offset = "0x58094D0", VA = "0x18580A0D0", Slot = "0")]
		public override bool Equals(object BHPOPDOKECN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x580A170", Offset = "0x5809570", VA = "0x18580A170", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x580A1F0", Offset = "0x58095F0", VA = "0x18580A1F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private sealed class FCLLFMKELNL : BGAJOJOMPDJ<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct GECAGMFFFOO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Task<NJKEHFGOEOH<Task<Texture2D>>> outerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private TaskAwaiter<NJKEHFGOEOH<Task<Texture2D>>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private TaskAwaiter<Texture2D> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5807DE0", Offset = "0x58071E0", VA = "0x185807DE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x58080A0", Offset = "0x58074A0", VA = "0x1858080A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private struct PMACDGLMMEO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Task<NJKEHFGOEOH<Task<Texture2D>>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private TaskAwaiter<NJKEHFGOEOH<Task<Texture2D>>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x580AA70", Offset = "0x5809E70", VA = "0x18580AA70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x580AC20", Offset = "0x580A020", VA = "0x18580AC20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Task<NJKEHFGOEOH<Task<Texture2D>>> GKFMOIFFOKO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override Task<Texture2D> ACFAKOCIEPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7A2680", Offset = "0x7A1A80", VA = "0x1807A2680", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override GKAGCLBDDCM<Texture2D> OODGNLKMCLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7A26F0", Offset = "0x7A1AF0", VA = "0x1807A26F0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5807C50", Offset = "0x5807050", VA = "0x185807C50")]
		public FCLLFMKELNL(Task<NJKEHFGOEOH<Task<Texture2D>>> CMOICIKGDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5807A70", Offset = "0x5806E70", VA = "0x185807A70", Slot = "10")]
		protected override void EHCMNGOBIAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5807980", Offset = "0x5806D80", VA = "0x185807980")]
		[AsyncStateMachine(typeof(GECAGMFFFOO))]
		[CompilerGenerated]
		internal static Task<Texture2D> BDIDAPKNHEI(Task<NJKEHFGOEOH<Task<Texture2D>>> ADCDIFKJFPK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5807B80", Offset = "0x5806F80", VA = "0x185807B80")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(PMACDGLMMEO))]
		internal static Task NGONECJPDDM(Task<NJKEHFGOEOH<Task<Texture2D>>> CMOICIKGDPA)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct LHHFEKFALGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder<byte[]> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public KMJBIBOKOAJ imageId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x580A340", Offset = "0x5809740", VA = "0x18580A340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x580A5E0", Offset = "0x58099E0", VA = "0x18580A5E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct CPJKHCLDGJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public AsyncTaskMethodBuilder<NJKEHFGOEOH<Task<Texture2D>>> <>t__builder;

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
		public HNPDIFDIMPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public NFGOMEFEGBH textureLoadOptions;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5807380", Offset = "0x5806780", VA = "0x185807380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5807570", Offset = "0x5806970", VA = "0x185807570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct DAGIJOBCJNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<NJKEHFGOEOH<Task<Texture2D>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public EFOAPBPFKPP room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public HNPDIFDIMPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private TaskAwaiter<NJKEHFGOEOH<Task<Texture2D>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x58075E0", Offset = "0x58069E0", VA = "0x1858075E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5807910", Offset = "0x5806D10", VA = "0x185807910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct PLCGIHKFEPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public AsyncTaskMethodBuilder<NJKEHFGOEOH<Task<Texture2D>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public HKBLIMJAMOE invention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public HNPDIFDIMPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<NJKEHFGOEOH<Task<Texture2D>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x580A6D0", Offset = "0x5809AD0", VA = "0x18580A6D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x580AA00", Offset = "0x5809E00", VA = "0x18580AA00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct INFNDKCGELD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<NJKEHFGOEOH<Task<Texture2D>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public MFMCMAPBJOO playerEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public HNPDIFDIMPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter<EFOAPBPFKPP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<NJKEHFGOEOH<Task<Texture2D>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5809430", Offset = "0x5808830", VA = "0x185809430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x58098C0", Offset = "0x5808CC0", VA = "0x1858098C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct KGDBAHKNGEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<NJKEHFGOEOH<Task<Texture2D>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public FOBHEOKDPHL account;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public HNPDIFDIMPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private TaskAwaiter<NJKEHFGOEOH<Task<Texture2D>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5809C60", Offset = "0x5809060", VA = "0x185809C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5809FA0", Offset = "0x58093A0", VA = "0x185809FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct JIDPCLLHOKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public AsyncTaskMethodBuilder<NJKEHFGOEOH<Task<Texture2D>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public NJIANBONNDP announcement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public HNPDIFDIMPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter<NJKEHFGOEOH<Task<Texture2D>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5809930", Offset = "0x5808D30", VA = "0x185809930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5809BF0", Offset = "0x5808FF0", VA = "0x185809BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly HODFAHHHMAF.Resolution JAFOIDFHGFD;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HODFAHHHMAF.Resolution FKEICMLFNMJ;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly HODFAHHHMAF.Resolution MDLOHHIECBN;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly HODFAHHHMAF.Resolution HHEEMFLJOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly BBHMEFJNMJJ<KMJBIBOKOAJ> LELMCFHANIC;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x58090A0", Offset = "0x58084A0", VA = "0x1858090A0")]
	[HMKFFNEGBBO(FMOKCMPGPEB.GameOnly)]
	private static void MNMFKBHJLGC(FJIKPBKCIMI BHGHMPIHGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5809280", Offset = "0x5808680", VA = "0x185809280")]
	[Preserve]
	internal HNPDIFDIMPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5808A90", Offset = "0x5807E90", VA = "0x185808A90", Slot = "4")]
	public MCDOFGKDLFK<Texture2D> HCAAMLGJOGG(string GALKOCCKJLH, [Optional] uint? IGBJPMDFABH, bool IHINMPJNBKG = false, NFGOMEFEGBH HDCMNJIAGNP = NFGOMEFEGBH.Default)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5808110", Offset = "0x5807510", VA = "0x185808110", Slot = "5")]
	public MCDOFGKDLFK<Texture2D> AAFHEGMHDID(EFOAPBPFKPP GCDLOCBJJOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5808C70", Offset = "0x5808070", VA = "0x185808C70", Slot = "6")]
	public MCDOFGKDLFK<Texture2D> KKFGECCAAEO(HKBLIMJAMOE GDELGACBDCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5808DD0", Offset = "0x58081D0", VA = "0x185808DD0", Slot = "7")]
	public MCDOFGKDLFK<Texture2D> LMJFCKAMEKD(MFMCMAPBJOO HCJNKCMJDLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x58084A0", Offset = "0x58078A0", VA = "0x1858084A0", Slot = "8")]
	public MCDOFGKDLFK<Texture2D> CKABHKEKOEK(FOBHEOKDPHL JOENAJMINEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5808F40", Offset = "0x5808340", VA = "0x185808F40", Slot = "9")]
	public MCDOFGKDLFK<Texture2D> LPOBJFEILNC(NJIANBONNDP GHCMAANPAPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5808B40", Offset = "0x5807F40", VA = "0x185808B40")]
	[AsyncStateMachine(typeof(LHHFEKFALGH))]
	private Task<byte[]> KJMLNHELBGO(KMJBIBOKOAJ MBAFOFFCCNB, CancellationToken PPJMMMGPFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5808710", Offset = "0x5807B10", VA = "0x185808710")]
	[AsyncStateMachine(typeof(CPJKHCLDGJO))]
	private Task<NJKEHFGOEOH<Task<Texture2D>>> EPEIFNLEFGH(string GALKOCCKJLH, [Optional] uint? IGBJPMDFABH, bool IHINMPJNBKG = false, NFGOMEFEGBH HDCMNJIAGNP = NFGOMEFEGBH.Default)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5808390", Offset = "0x5807790", VA = "0x185808390")]
	[AsyncStateMachine(typeof(DAGIJOBCJNF))]
	private Task<NJKEHFGOEOH<Task<Texture2D>>> CHPJPDEGKGO(EFOAPBPFKPP GCDLOCBJJOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5808980", Offset = "0x5807D80", VA = "0x185808980")]
	[AsyncStateMachine(typeof(PLCGIHKFEPJ))]
	private Task<NJKEHFGOEOH<Task<Texture2D>>> FJCJHHCOMOI(HKBLIMJAMOE GDELGACBDCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5808270", Offset = "0x5807670", VA = "0x185808270")]
	[AsyncStateMachine(typeof(INFNDKCGELD))]
	private Task<NJKEHFGOEOH<Task<Texture2D>>> BFAKGMDAFFM(MFMCMAPBJOO HCJNKCMJDLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5808870", Offset = "0x5807C70", VA = "0x185808870")]
	[AsyncStateMachine(typeof(KGDBAHKNGEH))]
	private Task<NJKEHFGOEOH<Task<Texture2D>>> FBNLIEBDMMC(FOBHEOKDPHL JOENAJMINEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5808600", Offset = "0x5807A00", VA = "0x185808600")]
	[AsyncStateMachine(typeof(JIDPCLLHOKJ))]
	private Task<NJKEHFGOEOH<Task<Texture2D>>> ECJNHIBMANJ(NJIANBONNDP GHCMAANPAPA)
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
