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
using RecRoom.DataLayer.Registration;
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
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x75B1540", Offset = "0x75B0140", VA = "0x1875B1540")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA87960", Offset = "0xA86560", VA = "0x180A87960")]
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
		[Cpp2IlInjected.Address(RVA = "0xA879A0", Offset = "0xA865A0", VA = "0x180A879A0")]
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
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x75B1640", Offset = "0x75B0240", VA = "0x1875B1640", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28B3880", Offset = "0x28B2480", VA = "0x1828B3880")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PKLMFLKMMDC
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MNDBKMIALLI<Texture2D> COGIMICADME(string HIGFGBDCIBL, [Optional] uint? HMHPGOBBFLE, bool AGBEBNHIHEN = false, IEEHPBFOCPK LFPHNFNNALI = IEEHPBFOCPK.Default);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MNDBKMIALLI<Texture2D> KBALPJBEJPF(HPDLOIOKHEC MNIHBKOBKFN);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MNDBKMIALLI<Texture2D> KKFEGHMFLKD(NKCMADKHIOE KGEJMBAJIIJ);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MNDBKMIALLI<Texture2D> NMIKKNKBILC(KMKOHDDPKAO PJGEOCANCKO);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MNDBKMIALLI<Texture2D> DDKMHCMFNBB(JMMHNAHBEDG CJBENHDEDBF);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MNDBKMIALLI<Texture2D> HDLFMIAIFAF(HONPKPHEEIH MPMBFIDCODD);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal class GBJCFJJICBE : PKLMFLKMMDC
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct NBLGJGIDJPA : IEquatable<NBLGJGIDJPA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly string JANGKCMCKOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly uint? OFKEIGMJHLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly bool POLCJFPKGNO;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x75B1500", Offset = "0x75B0100", VA = "0x1875B1500")]
		public NBLGJGIDJPA(string HIGFGBDCIBL, uint? HMHPGOBBFLE, bool AGBEBNHIHEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x75B12B0", Offset = "0x75AFEB0", VA = "0x1875B12B0", Slot = "4")]
		public bool Equals(NBLGJGIDJPA IIOGPDPGOLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x75B1200", Offset = "0x75AFE00", VA = "0x1875B1200", Slot = "0")]
		public override bool Equals(object KOJLNGLNBMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x75B1370", Offset = "0x75AFF70", VA = "0x1875B1370", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x75B13F0", Offset = "0x75AFFF0", VA = "0x1875B13F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct ANIGPCLGOPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public AsyncTaskMethodBuilder<byte[]> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public NBLGJGIDJPA imageId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x75AE710", Offset = "0x75AD310", VA = "0x1875AE710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x75AE9B0", Offset = "0x75AD5B0", VA = "0x1875AE9B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct GDNMEKMHJOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AsyncTaskMethodBuilder<MNDBKMIALLI<Texture2D>> <>t__builder;

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
		public GBJCFJJICBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public IEEHPBFOCPK textureLoadOptions;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x75B0520", Offset = "0x75AF120", VA = "0x1875B0520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x75B0710", Offset = "0x75AF310", VA = "0x1875B0710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct JDNPDLFOKIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder<MNDBKMIALLI<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public HPDLOIOKHEC room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public GBJCFJJICBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private TaskAwaiter<MNDBKMIALLI<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x75B0E60", Offset = "0x75AFA60", VA = "0x1875B0E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x75B1190", Offset = "0x75AFD90", VA = "0x1875B1190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct FMLALABPGPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public AsyncTaskMethodBuilder<MNDBKMIALLI<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public NKCMADKHIOE invention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public GBJCFJJICBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<MNDBKMIALLI<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x75AEF20", Offset = "0x75ADB20", VA = "0x1875AEF20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x75AF250", Offset = "0x75ADE50", VA = "0x1875AF250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct FDEJOPOFKHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<MNDBKMIALLI<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public KMKOHDDPKAO playerEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public GBJCFJJICBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter<HPDLOIOKHEC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<MNDBKMIALLI<Texture2D>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x75AEA20", Offset = "0x75AD620", VA = "0x1875AEA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x75AEEB0", Offset = "0x75ADAB0", VA = "0x1875AEEB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct IHBDNNPONLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<MNDBKMIALLI<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public JMMHNAHBEDG account;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public GBJCFJJICBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<MNDBKMIALLI<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x75B0780", Offset = "0x75AF380", VA = "0x1875B0780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x75B0AC0", Offset = "0x75AF6C0", VA = "0x1875B0AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct JDGICHFFBJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<MNDBKMIALLI<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public HONPKPHEEIH announcement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public GBJCFJJICBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<MNDBKMIALLI<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x75B0B30", Offset = "0x75AF730", VA = "0x1875B0B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x75B0DF0", Offset = "0x75AF9F0", VA = "0x1875B0DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly PHOALEPLHFM.Resolution JICPGGIMFHG;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly PHOALEPLHFM.Resolution GPNCLJMNLCL;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly PHOALEPLHFM.Resolution KGBLLDLJEOD;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly PHOALEPLHFM.Resolution JDDCFJMFLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly PJNPPEJNENI<NBLGJGIDJPA> HLABDJILJPC;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x75AF2C0", Offset = "0x75ADEC0", VA = "0x1875AF2C0")]
	[HHMPGEJNNFC.JKDCLEHGFFF.OKMFHHNNKLI]
	internal static void ACFPPHCGFGC(LGPCNHIHIDJ EHEGCBFMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x75B0370", Offset = "0x75AEF70", VA = "0x1875B0370")]
	[RecRoom.NoEngine.Common.Preserve]
	internal GBJCFJJICBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x75AF4D0", Offset = "0x75AE0D0", VA = "0x1875AF4D0", Slot = "4")]
	public MNDBKMIALLI<Texture2D> COGIMICADME(string HIGFGBDCIBL, [Optional] uint? HMHPGOBBFLE, bool AGBEBNHIHEN = false, IEEHPBFOCPK LFPHNFNNALI = IEEHPBFOCPK.Default)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x75AFB30", Offset = "0x75AE730", VA = "0x1875AFB30", Slot = "5")]
	public MNDBKMIALLI<Texture2D> KBALPJBEJPF(HPDLOIOKHEC MNIHBKOBKFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x75AFC70", Offset = "0x75AE870", VA = "0x1875AFC70", Slot = "6")]
	public MNDBKMIALLI<Texture2D> KKFEGHMFLKD(NKCMADKHIOE KGEJMBAJIIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x75B0030", Offset = "0x75AEC30", VA = "0x1875B0030", Slot = "7")]
	public MNDBKMIALLI<Texture2D> NMIKKNKBILC(KMKOHDDPKAO PJGEOCANCKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x75AF670", Offset = "0x75AE270", VA = "0x1875AF670", Slot = "8")]
	public MNDBKMIALLI<Texture2D> DDKMHCMFNBB(JMMHNAHBEDG CJBENHDEDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x75AF9F0", Offset = "0x75AE5F0", VA = "0x1875AF9F0", Slot = "9")]
	public MNDBKMIALLI<Texture2D> HDLFMIAIFAF(HONPKPHEEIH MPMBFIDCODD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x75AF7B0", Offset = "0x75AE3B0", VA = "0x1875AF7B0")]
	[AsyncStateMachine(typeof(ANIGPCLGOPF))]
	private Task<byte[]> DIPBJDIMJGA(NBLGJGIDJPA CIFEPPLPMJI, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x75AFED0", Offset = "0x75AEAD0", VA = "0x1875AFED0")]
	[AsyncStateMachine(typeof(GDNMEKMHJOJ))]
	private Task<MNDBKMIALLI<Texture2D>> MLJHICLBEKI(string HIGFGBDCIBL, [Optional] uint? HMHPGOBBFLE, bool AGBEBNHIHEN = false, IEEHPBFOCPK LFPHNFNNALI = IEEHPBFOCPK.Default)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x75AF3C0", Offset = "0x75ADFC0", VA = "0x1875AF3C0")]
	[AsyncStateMachine(typeof(JDNPDLFOKIF))]
	private Task<MNDBKMIALLI<Texture2D>> BCFNAHEEOAB(HPDLOIOKHEC MNIHBKOBKFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x75AF8E0", Offset = "0x75AE4E0", VA = "0x1875AF8E0")]
	[AsyncStateMachine(typeof(FMLALABPGPE))]
	private Task<MNDBKMIALLI<Texture2D>> FGLAGPCFMHE(NKCMADKHIOE KGEJMBAJIIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x75AFDB0", Offset = "0x75AE9B0", VA = "0x1875AFDB0")]
	[AsyncStateMachine(typeof(FDEJOPOFKHL))]
	private Task<MNDBKMIALLI<Texture2D>> KNFPBFBHOFL(KMKOHDDPKAO PJGEOCANCKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x75B0180", Offset = "0x75AED80", VA = "0x1875B0180")]
	[AsyncStateMachine(typeof(IHBDNNPONLO))]
	private Task<MNDBKMIALLI<Texture2D>> OAMBLIAOHFO(JMMHNAHBEDG CJBENHDEDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x75AF560", Offset = "0x75AE160", VA = "0x1875AF560")]
	[AsyncStateMachine(typeof(JDGICHFFBJN))]
	private Task<MNDBKMIALLI<Texture2D>> DBJHGNBNLMJ(HONPKPHEEIH MPMBFIDCODD)
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
