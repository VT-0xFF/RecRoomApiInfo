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
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87AEC0", VA = "0x18087C6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FB79B0", Offset = "0x5FB61B0", VA = "0x185FB79B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87D9C0", Offset = "0x87C1C0", VA = "0x18087D9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87DA00", Offset = "0x87C200", VA = "0x18087DA00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PLBGCIENHLF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GBMNPHMLGKB<Texture2D> HPCHJGLEAGB(string OJJODEJMFNM, [Optional] uint? FBABBDDKDBO, bool KIJNNIHLMGD = false, LJJAJNHCBMC IEHNDNOEGLA = LJJAJNHCBMC.Default);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GBMNPHMLGKB<Texture2D> MDALOPPFCPD(AJFLCNMCCKM DJKOBHKEIHL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GBMNPHMLGKB<Texture2D> MEOICIDLHOB(HICMLOEIMJH DLIPDDEBGHD);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GBMNPHMLGKB<Texture2D> FNMPHFNIJAA(FKMOANNDEEK GKJIJIDECHF);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GBMNPHMLGKB<Texture2D> KIANOKLPOFM(CCBKILLIDJI LKOIGKNKCON);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GBMNPHMLGKB<Texture2D> MLDKKFDBFGG(IOLICGHKGEC PEJGBKMEEOI);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class DHDKCDBHMEN : PLBGCIENHLF
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private readonly struct PIFBGEMOFJA : IEquatable<PIFBGEMOFJA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly string PCDEDLEEEKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly uint? ALGCGNGPGBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly bool DFOBMOHOLCE;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5FB7D30", Offset = "0x5FB6530", VA = "0x185FB7D30")]
		public PIFBGEMOFJA(string OJJODEJMFNM, uint? FBABBDDKDBO, bool KIJNNIHLMGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5FB7AE0", Offset = "0x5FB62E0", VA = "0x185FB7AE0", Slot = "4")]
		public bool Equals(PIFBGEMOFJA OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5FB7A30", Offset = "0x5FB6230", VA = "0x185FB7A30", Slot = "0")]
		public override bool Equals(object MEAFIMADMKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5FB7BA0", Offset = "0x5FB63A0", VA = "0x185FB7BA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5FB7C20", Offset = "0x5FB6420", VA = "0x185FB7C20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct NAEPJODFCMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public AsyncTaskMethodBuilder<byte[]> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public PIFBGEMOFJA imageId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5FB76A0", Offset = "0x5FB5EA0", VA = "0x185FB76A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5FB7940", Offset = "0x5FB6140", VA = "0x185FB7940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct GBODKAAIICD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AsyncTaskMethodBuilder<GBMNPHMLGKB<Texture2D>> <>t__builder;

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
		public DHDKCDBHMEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public LJJAJNHCBMC textureLoadOptions;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5FB6BA0", Offset = "0x5FB53A0", VA = "0x185FB6BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5FB6D90", Offset = "0x5FB5590", VA = "0x185FB6D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct DECKBBAOIFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder<GBMNPHMLGKB<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AJFLCNMCCKM room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public DHDKCDBHMEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private TaskAwaiter<GBMNPHMLGKB<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5FB55A0", Offset = "0x5FB3DA0", VA = "0x185FB55A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5FB58D0", Offset = "0x5FB40D0", VA = "0x185FB58D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct LKGHDNCCGIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public AsyncTaskMethodBuilder<GBMNPHMLGKB<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public HICMLOEIMJH invention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public DHDKCDBHMEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<GBMNPHMLGKB<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5FB7300", Offset = "0x5FB5B00", VA = "0x185FB7300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5FB7630", Offset = "0x5FB5E30", VA = "0x185FB7630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct HKJONHNHILP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<GBMNPHMLGKB<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public FKMOANNDEEK playerEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public DHDKCDBHMEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter<AJFLCNMCCKM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<GBMNPHMLGKB<Texture2D>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5FB6E00", Offset = "0x5FB5600", VA = "0x185FB6E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5FB7290", Offset = "0x5FB5A90", VA = "0x185FB7290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct PIOKHFGCMDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<GBMNPHMLGKB<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public CCBKILLIDJI account;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public DHDKCDBHMEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<GBMNPHMLGKB<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5FB7D70", Offset = "0x5FB6570", VA = "0x185FB7D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5FB80B0", Offset = "0x5FB68B0", VA = "0x185FB80B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct CGIPMGGFBFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<GBMNPHMLGKB<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public IOLICGHKGEC announcement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public DHDKCDBHMEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<GBMNPHMLGKB<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5FB5270", Offset = "0x5FB3A70", VA = "0x185FB5270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5FB5530", Offset = "0x5FB3D30", VA = "0x185FB5530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly APFLEJIGEHE.Resolution GMAFALJNHHP;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly APFLEJIGEHE.Resolution IINFGJAMINF;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly APFLEJIGEHE.Resolution NGGHBOKEEME;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly APFLEJIGEHE.Resolution MKLIHCAAMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly GHPLFHOENBL<PIFBGEMOFJA> DLHFODPNGML;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5FB6120", Offset = "0x5FB4920", VA = "0x185FB6120")]
	[GDGALFJPCGE(JMIPDAHBNNG.GameOnly)]
	private static void LAHBKIPICAO(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5FB69F0", Offset = "0x5FB51F0", VA = "0x185FB69F0")]
	[Preserve]
	internal DHDKCDBHMEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5FB5CD0", Offset = "0x5FB44D0", VA = "0x185FB5CD0", Slot = "4")]
	public GBMNPHMLGKB<Texture2D> HPCHJGLEAGB(string OJJODEJMFNM, [Optional] uint? FBABBDDKDBO, bool KIJNNIHLMGD = false, LJJAJNHCBMC IEHNDNOEGLA = LJJAJNHCBMC.Default)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5FB6220", Offset = "0x5FB4A20", VA = "0x185FB6220", Slot = "5")]
	public GBMNPHMLGKB<Texture2D> MDALOPPFCPD(AJFLCNMCCKM DJKOBHKEIHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5FB6360", Offset = "0x5FB4B60", VA = "0x185FB6360", Slot = "6")]
	public GBMNPHMLGKB<Texture2D> MEOICIDLHOB(HICMLOEIMJH DLIPDDEBGHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5FB5A50", Offset = "0x5FB4250", VA = "0x185FB5A50", Slot = "7")]
	public GBMNPHMLGKB<Texture2D> FNMPHFNIJAA(FKMOANNDEEK GKJIJIDECHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5FB5FE0", Offset = "0x5FB47E0", VA = "0x185FB5FE0", Slot = "8")]
	public GBMNPHMLGKB<Texture2D> KIANOKLPOFM(CCBKILLIDJI LKOIGKNKCON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5FB65B0", Offset = "0x5FB4DB0", VA = "0x185FB65B0", Slot = "9")]
	public GBMNPHMLGKB<Texture2D> MLDKKFDBFGG(IOLICGHKGEC PEJGBKMEEOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5FB5BA0", Offset = "0x5FB43A0", VA = "0x185FB5BA0")]
	[AsyncStateMachine(typeof(NAEPJODFCMF))]
	private Task<byte[]> GGJHEPAHIGI(PIFBGEMOFJA EOLNKNNGNPB, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5FB5E80", Offset = "0x5FB4680", VA = "0x185FB5E80")]
	[AsyncStateMachine(typeof(GBODKAAIICD))]
	private Task<GBMNPHMLGKB<Texture2D>> KAPLOMDGJNE(string OJJODEJMFNM, [Optional] uint? FBABBDDKDBO, bool KIJNNIHLMGD = false, LJJAJNHCBMC IEHNDNOEGLA = LJJAJNHCBMC.Default)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5FB66F0", Offset = "0x5FB4EF0", VA = "0x185FB66F0")]
	[AsyncStateMachine(typeof(DECKBBAOIFJ))]
	private Task<GBMNPHMLGKB<Texture2D>> OICHHMMNBEG(AJFLCNMCCKM DJKOBHKEIHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5FB6800", Offset = "0x5FB5000", VA = "0x185FB6800")]
	[AsyncStateMachine(typeof(LKGHDNCCGIL))]
	private Task<GBMNPHMLGKB<Texture2D>> PLMCJJDOFCG(HICMLOEIMJH DLIPDDEBGHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5FB5D60", Offset = "0x5FB4560", VA = "0x185FB5D60")]
	[AsyncStateMachine(typeof(HKJONHNHILP))]
	private Task<GBMNPHMLGKB<Texture2D>> IJGMNKNLMON(FKMOANNDEEK GKJIJIDECHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5FB64A0", Offset = "0x5FB4CA0", VA = "0x185FB64A0")]
	[AsyncStateMachine(typeof(PIOKHFGCMDD))]
	private Task<GBMNPHMLGKB<Texture2D>> MGPBKAKOFEI(CCBKILLIDJI LKOIGKNKCON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5FB5940", Offset = "0x5FB4140", VA = "0x185FB5940")]
	[AsyncStateMachine(typeof(CGIPMGGFBFM))]
	private Task<GBMNPHMLGKB<Texture2D>> BJHCKCDMLNB(IOLICGHKGEC PEJGBKMEEOI)
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
