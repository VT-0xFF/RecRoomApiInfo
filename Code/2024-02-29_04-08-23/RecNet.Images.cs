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
		[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5757870", Offset = "0x5756670", VA = "0x185757870")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D4330", Offset = "0x7D3130", VA = "0x1807D4330")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D4370", Offset = "0x7D3170", VA = "0x1807D4370")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PBCIAHHBDFC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CINGBHLEODA<Texture2D> MIDEAEEOOCK(string DCHICAAFAFA, [Optional] uint? FMKLAMLAIBE, bool CHDLHLEBLDG = false, OJMDAFAHIJP LNMOJMMLDKI = OJMDAFAHIJP.Default);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CINGBHLEODA<Texture2D> OBMCEJPIGPL(LAAMBNLCPBF PDEOOPLKLKJ);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CINGBHLEODA<Texture2D> DAKAHHKIBOI(GBDNHOGGPCL CPHCENFJNMB);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CINGBHLEODA<Texture2D> MGLCBNNDFOO(HILELHEEFEE KCANKJLIOLC);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CINGBHLEODA<Texture2D> DHEBFJKLPPJ(LPEHNEOEOJD ICGHNBDKIHP);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CINGBHLEODA<Texture2D> DCOFDKNJKOA(LIGBIAAPEAM OOEPEPKKNBC);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class EKMINNMPPNI : PBCIAHHBDFC
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private readonly struct HMHAJJHKOLM : IEquatable<HMHAJJHKOLM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly string OLCMOIJLBLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly uint? JFABJCLJEGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly bool BICNLGGCIJA;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5756D20", Offset = "0x5755B20", VA = "0x185756D20")]
		public HMHAJJHKOLM(string DCHICAAFAFA, uint? FMKLAMLAIBE, bool CHDLHLEBLDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5756AD0", Offset = "0x57558D0", VA = "0x185756AD0", Slot = "4")]
		public bool Equals(HMHAJJHKOLM FPEEGIOMOFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5756A30", Offset = "0x5755830", VA = "0x185756A30", Slot = "0")]
		public override bool Equals(object NHLNHJGAONN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5756B90", Offset = "0x5755990", VA = "0x185756B90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5756C10", Offset = "0x5755A10", VA = "0x185756C10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private sealed class MDCECNPDIFN : KGABHDDFELA<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct CKILGDEFPEE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Task<PPOFINEEFFF<Task<Texture2D>>> outerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private TaskAwaiter<PPOFINEEFFF<Task<Texture2D>>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private TaskAwaiter<Texture2D> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5754BD0", Offset = "0x57539D0", VA = "0x185754BD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5754E90", Offset = "0x5753C90", VA = "0x185754E90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private struct GAEHHBEPEGK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Task<PPOFINEEFFF<Task<Texture2D>>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private TaskAwaiter<PPOFINEEFFF<Task<Texture2D>>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5756480", Offset = "0x5755280", VA = "0x185756480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5756630", Offset = "0x5755430", VA = "0x185756630", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Task<PPOFINEEFFF<Task<Texture2D>>> MAFCNBCKJPK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override Task<Texture2D> NCKLPNIOLLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7A81F0", Offset = "0x7A6FF0", VA = "0x1807A81F0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override DOPLGHLIBGN<Texture2D> BGHMBBEJALJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7A8200", Offset = "0x7A7000", VA = "0x1807A8200", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x57573D0", Offset = "0x57561D0", VA = "0x1857573D0")]
		public MDCECNPDIFN(Task<PPOFINEEFFF<Task<Texture2D>>> IMKKNGNMOEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5757100", Offset = "0x5755F00", VA = "0x185757100", Slot = "10")]
		protected override void DDABGGLCGBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x57572E0", Offset = "0x57560E0", VA = "0x1857572E0")]
		[AsyncStateMachine(typeof(CKILGDEFPEE))]
		[CompilerGenerated]
		internal static Task<Texture2D> KJIADNBIGLM(Task<PPOFINEEFFF<Task<Texture2D>>> ICGEAHPKMPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5757210", Offset = "0x5756010", VA = "0x185757210")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(GAEHHBEPEGK))]
		internal static Task KENIICBGLJJ(Task<PPOFINEEFFF<Task<Texture2D>>> IMKKNGNMOEA)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct NMPONDINPNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder<byte[]> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public HMHAJJHKOLM imageId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5757560", Offset = "0x5756360", VA = "0x185757560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5757800", Offset = "0x5756600", VA = "0x185757800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct FIPBJIBEGDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public AsyncTaskMethodBuilder<PPOFINEEFFF<Task<Texture2D>>> <>t__builder;

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
		public EKMINNMPPNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public OJMDAFAHIJP textureLoadOptions;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5756220", Offset = "0x5755020", VA = "0x185756220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5756410", Offset = "0x5755210", VA = "0x185756410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct LPFMGPFBDGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<PPOFINEEFFF<Task<Texture2D>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public LAAMBNLCPBF room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public EKMINNMPPNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private TaskAwaiter<PPOFINEEFFF<Task<Texture2D>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5756D60", Offset = "0x5755B60", VA = "0x185756D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5757090", Offset = "0x5755E90", VA = "0x185757090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct HABCDAIEEMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public AsyncTaskMethodBuilder<PPOFINEEFFF<Task<Texture2D>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public GBDNHOGGPCL invention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public EKMINNMPPNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<PPOFINEEFFF<Task<Texture2D>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5756690", Offset = "0x5755490", VA = "0x185756690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x57569C0", Offset = "0x57557C0", VA = "0x1857569C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct PEMJDNKIMBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<PPOFINEEFFF<Task<Texture2D>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public HILELHEEFEE playerEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public EKMINNMPPNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter<LAAMBNLCPBF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<PPOFINEEFFF<Task<Texture2D>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5757CA0", Offset = "0x5756AA0", VA = "0x185757CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5758130", Offset = "0x5756F30", VA = "0x185758130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct OBPOLMCCPKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<PPOFINEEFFF<Task<Texture2D>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public LPEHNEOEOJD account;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public EKMINNMPPNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private TaskAwaiter<PPOFINEEFFF<Task<Texture2D>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x57578F0", Offset = "0x57566F0", VA = "0x1857578F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5757C30", Offset = "0x5756A30", VA = "0x185757C30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct CEDBMMFBAMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public AsyncTaskMethodBuilder<PPOFINEEFFF<Task<Texture2D>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public LIGBIAAPEAM announcement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public EKMINNMPPNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter<PPOFINEEFFF<Task<Texture2D>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x57548A0", Offset = "0x57536A0", VA = "0x1857548A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5754B60", Offset = "0x5753960", VA = "0x185754B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly DIFEMOKAIDJ.Resolution EBBLAFEKOHC;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly DIFEMOKAIDJ.Resolution LOEDMNCODFI;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly DIFEMOKAIDJ.Resolution GIADBBIFDHN;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly DIFEMOKAIDJ.Resolution JGEKAIJEHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly MNJKINHNHKA<HMHAJJHKOLM> BDGBLAGCMNL;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5755E90", Offset = "0x5754C90", VA = "0x185755E90")]
	[NAAAALLPNIA(PBKIGNPNCFO.GameOnly)]
	private static void OJLJIBMHFJA(IBPIJCMLLGH PPDHICBEIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5756070", Offset = "0x5754E70", VA = "0x185756070")]
	[Preserve]
	internal EKMINNMPPNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5755A10", Offset = "0x5754810", VA = "0x185755A10", Slot = "4")]
	public CINGBHLEODA<Texture2D> MIDEAEEOOCK(string DCHICAAFAFA, [Optional] uint? FMKLAMLAIBE, bool CHDLHLEBLDG = false, OJMDAFAHIJP LNMOJMMLDKI = OJMDAFAHIJP.Default)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5755C20", Offset = "0x5754A20", VA = "0x185755C20", Slot = "5")]
	public CINGBHLEODA<Texture2D> OBMCEJPIGPL(LAAMBNLCPBF PDEOOPLKLKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5755010", Offset = "0x5753E10", VA = "0x185755010", Slot = "6")]
	public CINGBHLEODA<Texture2D> DAKAHHKIBOI(GBDNHOGGPCL CPHCENFJNMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x57558A0", Offset = "0x57546A0", VA = "0x1857558A0", Slot = "7")]
	public CINGBHLEODA<Texture2D> MGLCBNNDFOO(HILELHEEFEE KCANKJLIOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x57554F0", Offset = "0x57542F0", VA = "0x1857554F0", Slot = "8")]
	public CINGBHLEODA<Texture2D> DHEBFJKLPPJ(LPEHNEOEOJD ICGHNBDKIHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5755280", Offset = "0x5754080", VA = "0x185755280", Slot = "9")]
	public CINGBHLEODA<Texture2D> DCOFDKNJKOA(LIGBIAAPEAM OOEPEPKKNBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5755770", Offset = "0x5754570", VA = "0x185755770")]
	[AsyncStateMachine(typeof(NMPONDINPNH))]
	private Task<byte[]> LPCMHOKJGMA(HMHAJJHKOLM LMOCCFFILJG, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5755AC0", Offset = "0x57548C0", VA = "0x185755AC0")]
	[AsyncStateMachine(typeof(FIPBJIBEGDB))]
	private Task<PPOFINEEFFF<Task<Texture2D>>> MOFIAAFMBOK(string DCHICAAFAFA, [Optional] uint? FMKLAMLAIBE, bool CHDLHLEBLDG = false, OJMDAFAHIJP LNMOJMMLDKI = OJMDAFAHIJP.Default)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5755D80", Offset = "0x5754B80", VA = "0x185755D80")]
	[AsyncStateMachine(typeof(LPFMGPFBDGA))]
	private Task<PPOFINEEFFF<Task<Texture2D>>> OHABOMCJOLD(LAAMBNLCPBF PDEOOPLKLKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x57553E0", Offset = "0x57541E0", VA = "0x1857553E0")]
	[AsyncStateMachine(typeof(HABCDAIEEMD))]
	private Task<PPOFINEEFFF<Task<Texture2D>>> DEAMFCHOBJE(GBDNHOGGPCL CPHCENFJNMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5755650", Offset = "0x5754450", VA = "0x185755650")]
	[AsyncStateMachine(typeof(PEMJDNKIMBM))]
	private Task<PPOFINEEFFF<Task<Texture2D>>> HLEJDLJJOIA(HILELHEEFEE KCANKJLIOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5755170", Offset = "0x5753F70", VA = "0x185755170")]
	[AsyncStateMachine(typeof(OBPOLMCCPKM))]
	private Task<PPOFINEEFFF<Task<Texture2D>>> DCMEPDIAOEP(LPEHNEOEOJD ICGHNBDKIHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5754F00", Offset = "0x5753D00", VA = "0x185754F00")]
	[AsyncStateMachine(typeof(CEDBMMFBAMO))]
	private Task<PPOFINEEFFF<Task<Texture2D>>> AHDOAAMHNCB(LIGBIAAPEAM OOEPEPKKNBC)
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
