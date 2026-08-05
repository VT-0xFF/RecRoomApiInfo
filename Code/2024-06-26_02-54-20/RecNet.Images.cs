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
		[Cpp2IlInjected.Address(RVA = "0x88C9F0", Offset = "0x88AFF0", VA = "0x18088C9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6037AF0", Offset = "0x60360F0", VA = "0x186037AF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x88D740", Offset = "0x88BD40", VA = "0x18088D740")]
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
		[Cpp2IlInjected.Address(RVA = "0x88D780", Offset = "0x88BD80", VA = "0x18088D780")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FGFNPOBMNEM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FMHOFFFMGIN<Texture2D> DGELFMNMOPP(string BOAMEGEOPOJ, [Optional] uint? HDPBLNGDBJK, bool FDLCDMDNGCC = false, DLHENFGBHJG OJGHEHPOFMO = DLHENFGBHJG.Default);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FMHOFFFMGIN<Texture2D> DBACEFPLBGP(ENMNGNJNNLB CANBHFHBMDA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FMHOFFFMGIN<Texture2D> CHNKIIGDIAH(OFOKKLOCKIO GJODPGLOIMM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FMHOFFFMGIN<Texture2D> KDJHJIHMLPO(ECEKJCDPLNJ CMOEEOPBGGM);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FMHOFFFMGIN<Texture2D> DBHMDPHJHNL(MFKCBOOGHPL OKABCACGDAD);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FMHOFFFMGIN<Texture2D> HCCDMLGBBLM(GGIMMPIIANA GHKJEFGHNIH);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class FBCIBOPMGKI : FGFNPOBMNEM
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private readonly struct IFFCAFHGDAM : IEquatable<IFFCAFHGDAM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly string JMLCMNHNFBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly uint? FDMEGHPAIEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly bool FLJJMHDADPB;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x60373F0", Offset = "0x60359F0", VA = "0x1860373F0")]
		public IFFCAFHGDAM(string BOAMEGEOPOJ, uint? HDPBLNGDBJK, bool FDLCDMDNGCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x60371A0", Offset = "0x60357A0", VA = "0x1860371A0", Slot = "4")]
		public bool Equals(IFFCAFHGDAM LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6037100", Offset = "0x6035700", VA = "0x186037100", Slot = "0")]
		public override bool Equals(object HBFCGFKGCAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6037260", Offset = "0x6035860", VA = "0x186037260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x60372E0", Offset = "0x60358E0", VA = "0x1860372E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct LOKNPGHKIFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public AsyncTaskMethodBuilder<byte[]> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public IFFCAFHGDAM imageId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x60377E0", Offset = "0x6035DE0", VA = "0x1860377E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6037A80", Offset = "0x6036080", VA = "0x186037A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct FNMFNJLKMMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AsyncTaskMethodBuilder<FMHOFFFMGIN<Texture2D>> <>t__builder;

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
		public FBCIBOPMGKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public DLHENFGBHJG textureLoadOptions;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x60369A0", Offset = "0x6034FA0", VA = "0x1860369A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6036B90", Offset = "0x6035190", VA = "0x186036B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct ACHKPBJIDKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder<FMHOFFFMGIN<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public ENMNGNJNNLB room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public FBCIBOPMGKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private TaskAwaiter<FMHOFFFMGIN<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6034CD0", Offset = "0x60332D0", VA = "0x186034CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6035000", Offset = "0x6033600", VA = "0x186035000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct DHPIBLMFEIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public AsyncTaskMethodBuilder<FMHOFFFMGIN<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public OFOKKLOCKIO invention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public FBCIBOPMGKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<FMHOFFFMGIN<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6035070", Offset = "0x6033670", VA = "0x186035070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x60353A0", Offset = "0x60339A0", VA = "0x1860353A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct HFNDHGHFGHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<FMHOFFFMGIN<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public ECEKJCDPLNJ playerEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public FBCIBOPMGKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter<ENMNGNJNNLB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<FMHOFFFMGIN<Texture2D>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6036C00", Offset = "0x6035200", VA = "0x186036C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6037090", Offset = "0x6035690", VA = "0x186037090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct JJLFHNAFAOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<FMHOFFFMGIN<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public MFKCBOOGHPL account;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public FBCIBOPMGKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<FMHOFFFMGIN<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6037430", Offset = "0x6035A30", VA = "0x186037430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6037770", Offset = "0x6035D70", VA = "0x186037770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct EAAKDMHPGPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<FMHOFFFMGIN<Texture2D>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public GGIMMPIIANA announcement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public FBCIBOPMGKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<FMHOFFFMGIN<Texture2D>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6035410", Offset = "0x6033A10", VA = "0x186035410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x60356D0", Offset = "0x6033CD0", VA = "0x1860356D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly CEMNOGHBOMC.Resolution HGIBJELFJOE;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly CEMNOGHBOMC.Resolution ODFFIPEOCEP;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly CEMNOGHBOMC.Resolution JNBHKIDJPKC;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly CEMNOGHBOMC.Resolution GFFMIOLHIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly ONLDAMIDLOI<IFFCAFHGDAM> IKHFIMGOCHN;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x60364B0", Offset = "0x6034AB0", VA = "0x1860364B0")]
	[PECFDJPHGEK(BOIKMOKIOJG.GameOnly)]
	private static void PDECJEAEPFN(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x60367F0", Offset = "0x6034DF0", VA = "0x1860367F0")]
	[Preserve]
	internal FBCIBOPMGKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6035E50", Offset = "0x6034450", VA = "0x186035E50", Slot = "4")]
	public FMHOFFFMGIN<Texture2D> DGELFMNMOPP(string BOAMEGEOPOJ, [Optional] uint? HDPBLNGDBJK, bool FDLCDMDNGCC = false, DLHENFGBHJG OJGHEHPOFMO = DLHENFGBHJG.Default)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6035AC0", Offset = "0x60340C0", VA = "0x186035AC0", Slot = "5")]
	public FMHOFFFMGIN<Texture2D> DBACEFPLBGP(ENMNGNJNNLB CANBHFHBMDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6035980", Offset = "0x6033F80", VA = "0x186035980", Slot = "6")]
	public FMHOFFFMGIN<Texture2D> CHNKIIGDIAH(OFOKKLOCKIO GJODPGLOIMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6036130", Offset = "0x6034730", VA = "0x186036130", Slot = "7")]
	public FMHOFFFMGIN<Texture2D> KDJHJIHMLPO(ECEKJCDPLNJ CMOEEOPBGGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6035C00", Offset = "0x6034200", VA = "0x186035C00", Slot = "8")]
	public FMHOFFFMGIN<Texture2D> DBHMDPHJHNL(MFKCBOOGHPL OKABCACGDAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6035FF0", Offset = "0x60345F0", VA = "0x186035FF0", Slot = "9")]
	public FMHOFFFMGIN<Texture2D> HCCDMLGBBLM(GGIMMPIIANA GHKJEFGHNIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6035740", Offset = "0x6033D40", VA = "0x186035740")]
	[AsyncStateMachine(typeof(LOKNPGHKIFN))]
	private Task<byte[]> AEIJOJNFOJM(IFFCAFHGDAM EKDHMPINGII, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x60365B0", Offset = "0x6034BB0", VA = "0x1860365B0")]
	[AsyncStateMachine(typeof(FNMFNJLKMMD))]
	private Task<FMHOFFFMGIN<Texture2D>> POCDLPBEIIP(string BOAMEGEOPOJ, [Optional] uint? HDPBLNGDBJK, bool FDLCDMDNGCC = false, DLHENFGBHJG OJGHEHPOFMO = DLHENFGBHJG.Default)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6036280", Offset = "0x6034880", VA = "0x186036280")]
	[AsyncStateMachine(typeof(ACHKPBJIDKD))]
	private Task<FMHOFFFMGIN<Texture2D>> NENMIPECPDN(ENMNGNJNNLB CANBHFHBMDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6035EE0", Offset = "0x60344E0", VA = "0x186035EE0")]
	[AsyncStateMachine(typeof(DHPIBLMFEIK))]
	private Task<FMHOFFFMGIN<Texture2D>> GGHPBNAJIJM(OFOKKLOCKIO GJODPGLOIMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6036390", Offset = "0x6034990", VA = "0x186036390")]
	[AsyncStateMachine(typeof(HFNDHGHFGHI))]
	private Task<FMHOFFFMGIN<Texture2D>> NOOHEPLMNGD(ECEKJCDPLNJ CMOEEOPBGGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6035D40", Offset = "0x6034340", VA = "0x186035D40")]
	[AsyncStateMachine(typeof(JJLFHNAFAOG))]
	private Task<FMHOFFFMGIN<Texture2D>> DFLJBLKKFBA(MFKCBOOGHPL OKABCACGDAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6035870", Offset = "0x6033E70", VA = "0x186035870")]
	[AsyncStateMachine(typeof(EAAKDMHPGPJ))]
	private Task<FMHOFFFMGIN<Texture2D>> BPEGOPKGCOC(GGIMMPIIANA GHKJEFGHNIH)
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
