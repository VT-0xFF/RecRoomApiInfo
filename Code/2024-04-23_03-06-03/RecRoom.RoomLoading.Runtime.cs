using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using Google.Protobuf;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecNet;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Common;
using RecRoom.Persistence;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x68DA960", Offset = "0x68D9960", VA = "0x1868DA960")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7EB340", Offset = "0x7EA340", VA = "0x1807EB340")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7EB380", Offset = "0x7EA380", VA = "0x1807EB380")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_RoomLoading_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : PPFIOIJOILA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x68D5640", Offset = "0x68D4640", VA = "0x1868D5640", Slot = "4")]
		public override void GGEFLGLPFBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MPFDMMLMBNP : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x68D6420", Offset = "0x68D5420", VA = "0x1868D6420")]
	public MPFDMMLMBNP(string JJJNODJJIFK, Exception KKEANEMMJJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal class OFFDPHIIMGN : OHOBAABAMCL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct KLAANBEHGDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<IPOEENMLOPF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private TaskAwaiter<KIOJDDLCCBC<IPOEENMLOPF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x68D3B50", Offset = "0x68D2B50", VA = "0x1868D3B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x68D3D90", Offset = "0x68D2D90", VA = "0x1868D3D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct CJGBICNPNHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<AFPKENLHNII>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<AFPKENLHNII>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x68C3DD0", Offset = "0x68C2DD0", VA = "0x1868C3DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x68C3FE0", Offset = "0x68C2FE0", VA = "0x1868C3FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	[UnityEngine.Scripting.Preserve]
	public OFFDPHIIMGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x68DBA50", Offset = "0x68DAA50", VA = "0x1868DBA50", Slot = "4")]
	[AsyncStateMachine(typeof(KLAANBEHGDD))]
	public Task<IReadOnlyList<IPOEENMLOPF>> FNONBAHLALF(long CFLPHBNCGDP, long AKANBGAJAAH, [Optional] CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x68DB940", Offset = "0x68DA940", VA = "0x1868DB940", Slot = "5")]
	[AsyncStateMachine(typeof(CJGBICNPNHI))]
	public Task<IReadOnlyList<AFPKENLHNII>> AFHNOMIIJAJ(IReadOnlyList<int> MAALLOBACHJ, [Optional] CancellationToken GHLJDIEPICD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface AAOPCKENKFF : IEquatable<AAOPCKENKFF>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int EMAKPHMGLPP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	AFPKENLHNII HCGMOBFFFMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime DICBLEFHAPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	HPJPFEAIFHK? MBCCJACHCKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	AGHPKCJFAKP? IOICABMPLDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	HPHLFFBEOND FOHCKDFMJBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<IDAKKNHINME> MAOHEBGKLFM();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum HPHLFFBEOND
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OHOBAABAMCL
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<IPOEENMLOPF>> FNONBAHLALF(long CFLPHBNCGDP, long AKANBGAJAAH, [Optional] CancellationToken GHLJDIEPICD);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<AFPKENLHNII>> AFHNOMIIJAJ(IReadOnlyList<int> MAALLOBACHJ, [Optional] CancellationToken GHLJDIEPICD);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class HCJFEPEMFBD
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class FHCMFOPEKJJ : AAOPCKENKFF, IEquatable<AAOPCKENKFF>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct AIGDPEINHAI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<IDAKKNHINME> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public FHCMFOPEKJJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private NAJBLOEPPBO <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<KPBKEDCLNDD> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<IDAKKNHINME> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x68C1350", Offset = "0x68C0350", VA = "0x1868C1350", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x68C17F0", Offset = "0x68C07F0", VA = "0x1868C17F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly IPOEENMLOPF GHNBHHIMGHM;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int EMAKPHMGLPP
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7C5830", Offset = "0x7C4830", VA = "0x1807C5830", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public AFPKENLHNII HCGMOBFFFMF
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7C2D60", Offset = "0x7C1D60", VA = "0x1807C2D60", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime LGKIIEHDGIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x555E490", Offset = "0x555D490", VA = "0x18555E490", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HPJPFEAIFHK? MBCCJACHCKA
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1A422F0", Offset = "0x1A412F0", VA = "0x181A422F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public AGHPKCJFAKP? IOICABMPLDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x555E570", Offset = "0x555D570", VA = "0x18555E570", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public HPHLFFBEOND FOHCKDFMJBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x883D20", Offset = "0x882D20", VA = "0x180883D20", Slot = "10")]
			get
			{
				return default(HPHLFFBEOND);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x68C7F40", Offset = "0x68C6F40", VA = "0x1868C7F40", Slot = "9")]
		[AsyncStateMachine(typeof(AIGDPEINHAI))]
		public Task<IDAKKNHINME> MAOHEBGKLFM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x68C8040", Offset = "0x68C7040", VA = "0x1868C8040")]
		public FHCMFOPEKJJ(int HDNKLBJLNHO, AFPKENLHNII HNCDANEHGLI, IPOEENMLOPF GHNBHHIMGHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x68C7E30", Offset = "0x68C6E30", VA = "0x1868C7E30", Slot = "11")]
		public bool Equals(AAOPCKENKFF JNHFAFOIKEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x68C7D90", Offset = "0x68C6D90", VA = "0x1868C7D90", Slot = "0")]
		public override bool Equals(object KDEEPMDJGFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x68C7D50", Offset = "0x68C6D50", VA = "0x1868C7D50")]
		private bool BHPBMIGJJCK(FHCMFOPEKJJ JNHFAFOIKEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x68C7EC0", Offset = "0x68C6EC0", VA = "0x1868C7EC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class DPMJHHJALED : AAOPCKENKFF, IEquatable<AAOPCKENKFF>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct BPJPJFNAIGC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<IDAKKNHINME> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public DPMJHHJALED <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<IDAKKNHINME> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x68C3170", Offset = "0x68C2170", VA = "0x1868C3170", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x68C33A0", Offset = "0x68C23A0", VA = "0x1868C33A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly JEENCGOGKPP IAKEPMAFNKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly HPJPFEAIFHK HEJCPPMDDEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly AGHPKCJFAKP JLIGKFILMEM;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int EMAKPHMGLPP
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x68C6670", Offset = "0x68C5670", VA = "0x1868C6670", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public AFPKENLHNII HCGMOBFFFMF
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x68C65E0", Offset = "0x68C55E0", VA = "0x1868C65E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime LGKIIEHDGIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x68C6840", Offset = "0x68C5840", VA = "0x1868C6840", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public HPJPFEAIFHK? MBCCJACHCKA
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x68C67F0", Offset = "0x68C57F0", VA = "0x1868C67F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public AGHPKCJFAKP? IOICABMPLDK
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x68C67A0", Offset = "0x68C57A0", VA = "0x1868C67A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public HPHLFFBEOND FOHCKDFMJBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x90E900", Offset = "0x90D900", VA = "0x18090E900", Slot = "10")]
			get
			{
				return default(HPHLFFBEOND);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xEF5520", Offset = "0xEF4520", VA = "0x180EF5520")]
		public DPMJHHJALED(JEENCGOGKPP NGAIDKANJFL, HPJPFEAIFHK KMJAMEFMHGK, AGHPKCJFAKP LKNOAJJNFHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x68C66B0", Offset = "0x68C56B0", VA = "0x1868C66B0", Slot = "9")]
		[AsyncStateMachine(typeof(BPJPJFNAIGC))]
		public Task<IDAKKNHINME> MAOHEBGKLFM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x68C64C0", Offset = "0x68C54C0", VA = "0x1868C64C0", Slot = "11")]
		public bool Equals(AAOPCKENKFF JNHFAFOIKEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x68C6410", Offset = "0x68C5410", VA = "0x1868C6410", Slot = "0")]
		public override bool Equals(object KDEEPMDJGFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x68C63B0", Offset = "0x68C53B0", VA = "0x1868C63B0")]
		private bool BHPBMIGJJCK(DPMJHHJALED JNHFAFOIKEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x68C6560", Offset = "0x68C5560", VA = "0x1868C6560", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class OLJAAMNBJCD : AAOPCKENKFF, IEquatable<AAOPCKENKFF>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct BNAGFAFHKDB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<IDAKKNHINME> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<IDAKKNHINME> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x68C25E0", Offset = "0x68C15E0", VA = "0x1868C25E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x68C2820", Offset = "0x68C1820", VA = "0x1868C2820", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly AFPKENLHNII DCBPBLABHMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly HPJPFEAIFHK HEJCPPMDDEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly AGHPKCJFAKP JLIGKFILMEM;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int EMAKPHMGLPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x68DD130", Offset = "0x68DC130", VA = "0x1868DD130", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public AFPKENLHNII HCGMOBFFFMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7C35E0", Offset = "0x7C25E0", VA = "0x1807C35E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime LGKIIEHDGIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public HPJPFEAIFHK? MBCCJACHCKA
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x68DD270", Offset = "0x68DC270", VA = "0x1868DD270", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public AGHPKCJFAKP? IOICABMPLDK
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x68DD220", Offset = "0x68DC220", VA = "0x1868DD220", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public HPHLFFBEOND FOHCKDFMJBA
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0", Slot = "10")]
			get
			{
				return default(HPHLFFBEOND);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xEF5520", Offset = "0xEF4520", VA = "0x180EF5520")]
		public OLJAAMNBJCD(AFPKENLHNII HNCDANEHGLI, HPJPFEAIFHK KMJAMEFMHGK, AGHPKCJFAKP LKNOAJJNFHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x68DD150", Offset = "0x68DC150", VA = "0x1868DD150", Slot = "9")]
		[AsyncStateMachine(typeof(BNAGFAFHKDB))]
		public Task<IDAKKNHINME> MAOHEBGKLFM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x68DCF90", Offset = "0x68DBF90", VA = "0x1868DCF90", Slot = "11")]
		public bool Equals(AAOPCKENKFF JNHFAFOIKEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x68DCE70", Offset = "0x68DBE70", VA = "0x1868DCE70", Slot = "0")]
		public override bool Equals(object KDEEPMDJGFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x68DD0A0", Offset = "0x68DC0A0", VA = "0x1868DD0A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x68DCD90", Offset = "0x68DBD90", VA = "0x1868DCD90")]
		private bool BHPBMIGJJCK(OLJAAMNBJCD JNHFAFOIKEO)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct PPKKHKPMMBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<AAOPCKENKFF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public bool forceRefreshSaveHistoryCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public HCJFEPEMFBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<IPOEENMLOPF> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<IPOEENMLOPF>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, AFPKENLHNII account, IPOEENMLOPF roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x68DE620", Offset = "0x68DD620", VA = "0x1868DE620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x68DF400", Offset = "0x68DE400", VA = "0x1868DF400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct CNHMOHPIFCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, AFPKENLHNII account, IPOEENMLOPF roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<IPOEENMLOPF> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public HCJFEPEMFBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<AFPKENLHNII>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x68C4050", Offset = "0x68C3050", VA = "0x1868C4050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x68C4A40", Offset = "0x68C3A40", VA = "0x1868C4A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly JIMHLMOCFGK KBGKELLNBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly OHOBAABAMCL BPGLJMKHEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly OMFPKLCAGCI PKGOCFOEALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly EAOCBIJBBIG<(long, long), IReadOnlyList<IPOEENMLOPF>> NDPGFIMFGIJ;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x68CBD10", Offset = "0x68CAD10", VA = "0x1868CBD10")]
	[UnityEngine.Scripting.Preserve]
	public HCJFEPEMFBD([POILJEECDED(null)] OHOBAABAMCL EDENKLCDAEG, [POILJEECDED(null)] OMFPKLCAGCI ALAJGLNKKDE, [POILJEECDED(null)] JIMHLMOCFGK HJHHBGKAJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x68CB910", Offset = "0x68CA910", VA = "0x1868CB910")]
	[AsyncStateMachine(typeof(PPKKHKPMMBG))]
	public Task<IList<AAOPCKENKFF>> ANAELPILMHC(long CFLPHBNCGDP, long CEJEMJLIMDC, bool LCAAPKPPJML = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x68CBB70", Offset = "0x68CAB70", VA = "0x1868CBB70")]
	private bool IBOIDKGNKJF(DateTime? GJHBKBFDNIM, long CFLPHBNCGDP, long CEJEMJLIMDC, [Out] JEENCGOGKPP OHMDGACKMDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x68CBA60", Offset = "0x68CAA60", VA = "0x1868CBA60")]
	[AsyncStateMachine(typeof(CNHMOHPIFCK))]
	private Task<IReadOnlyList<(int, AFPKENLHNII, IPOEENMLOPF)>> GMMJLJCFOHC(IReadOnlyList<IPOEENMLOPF> KNKHPAIELJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface OMFPKLCAGCI
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<JEENCGOGKPP> KNCCJHMJBOB;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OIJFLPFKILH(long CFLPHBNCGDP, long CEJEMJLIMDC, EIIHNOKEGGJ AFIGHNEJHMM, JDGAAOKDGFM CMMMKALOAEA);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BCJEAEMILJI(long CFLPHBNCGDP, long CEJEMJLIMDC, [Out] JEENCGOGKPP OHMDGACKMDM);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PGMCKEMJIIJ(long CFLPHBNCGDP, long CEJEMJLIMDC, JDGAAOKDGFM CMMMKALOAEA, [Out] JEENCGOGKPP OHMDGACKMDM);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DHBEIFLDLGF(long CFLPHBNCGDP, long CEJEMJLIMDC);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface NALENELDDPM : IHLALIKNOCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool PLNBKCEDNAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task FCEDLFCLIGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EBDIPBHLKAO(Task BKJCIFOIBEF, string EAFOFCAFIPI);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface FLJJPHEOGBK : IHLALIKNOCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IDAKKNHINME> BEBEADCPADP(JEENCGOGKPP OHMDGACKMDM);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KOLAEMINHJM(CancellationToken GHLJDIEPICD);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface AKJNAHIMMAH : IHLALIKNOCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	LACPOPGHEKN LOMEGNMANCM
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LPIPCKKCCDK();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JPMAKBNNGKG();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface IHLALIKNOCJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CJMKLAKCCOG(IONKJBLKHOH CPMFHDAOGEO);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface OIMHDJADCNF
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan LBJALGBCIDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan IMPPDFHKPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan JAOBLGEBJJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan HMOHGKCDEED
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool OOGCJIMJGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool HAAFBPIDDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool FLDHHEHAOAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int KHLGNCBANCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool ADMBLHGOPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool KFCFLEMCAFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum PPCKLJKCOKM
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum FGADKHHKFHK
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	InitialRoomLoad,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	AutoSave,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	SaveToDisk,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	SaveToRecNet,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	RestoreAutoSave,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct LDBJDOIIBIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long LNFKOMHJPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long AKANBGAJAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly PPCKLJKCOKM KBCNAJKPHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception BNEBOBCGFMD;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x68D40C0", Offset = "0x68D30C0", VA = "0x1868D40C0")]
	public LDBJDOIIBIB(long LNFKOMHJPEB, long AKANBGAJAAH, PPCKLJKCOKM KBCNAJKPHNL, [CanBeNull] Exception BNEBOBCGFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x68D4070", Offset = "0x68D3070", VA = "0x1868D4070")]
	public static LDBJDOIIBIB EJAHKPICHNP(BPINABCIEKB LACONHJFCEL, PPCKLJKCOKM KBCNAJKPHNL, [Optional] Exception BNEBOBCGFMD)
	{
		return default(LDBJDOIIBIB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public delegate void IMHCCLLFMEK(LDBJDOIIBIB JAKPAOCDOEJ);
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface KFPLCDDLLIA : IHLALIKNOCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action JKHBAHFBDIH;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event IMHCCLLFMEK KMOODELHBNB;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event IMHCCLLFMEK PBOOFJNADML;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event IMHCCLLFMEK HFNJKNBBAJD;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<FGADKHHKFHK, bool> MEPAOBAEGKM;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IMCFDPCDCGJ();

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LJCKPEIFLPJ(LDBJDOIIBIB JAKPAOCDOEJ);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AIBJAHFEHAJ(LDBJDOIIBIB JAKPAOCDOEJ);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PDKCCHFPCOA(LDBJDOIIBIB JAKPAOCDOEJ);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DJOBBGJGIPG(FGADKHHKFHK BLOFAJKGCBC, bool HBNABJDAFPH);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface MPIFKJJNNCE : IHLALIKNOCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task LGHBNHCIPGP();

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EBFCCNDLCEE();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface NJKCLBHBFPO : IHLALIKNOCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TaskStatus LNGEPDDOPMN
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task EFDGJJHEHPL(BPINABCIEKB DLJENKKADJN, HLHBCDCELMH MLCGPPAAJFP, CancellationToken ICHNHGHOBPK);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class IJPFNNOMPAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x68D22C0", Offset = "0x68D12C0", VA = "0x1868D22C0")]
	public static bool ICAFCNFNMJI(this NJKCLBHBFPO COIBKFDENBL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public delegate Task OLEFILIJHIM(DJJMNPKHNKF LAOLHNNNLCH, CancellationToken KONODCHOCOG);
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface PFHGGCAIBEH : IHLALIKNOCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KGNAHPPFIDN(OLEFILIJHIM LHIPCPBAIDM);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface IONKJBLKHOH : NAJBLOEPPBO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CancellationToken MOEDCHKFCIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	OIEDECFCIPC FKPNFGEALPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	MIMGKGBGIEK AKOCEAJPGOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	OJNGFMPHCML DNIIHKFNDHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	DBOAJANNPMM BNJIHDAPCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	GLLEMKBOHHA KCPDHLOFPKI
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	HMADNGLLKOK LIDPKIDNDBA
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	PAKLMFALEMK DCGLGEHLOCG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	AAGLIDGLEOO JHMOHOMBLGF
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NALENELDDPM LDFDPFMKPFM
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	FLJJPHEOGBK ALKFIKLNDGL
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	KFPLCDDLLIA HDFAJIJEPJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	MPIFKJJNNCE PCPOPEGGJMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	NJKCLBHBFPO FEELJJNBJAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	PFHGGCAIBEH PNBGEMCNFGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	PJJEMCJDJMB PCJFJFCEEBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	GOBDPIDFCMO OOMJPMLMBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	PFLFLIOMLNP DDBBOLHMIMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	LDNGFBNBCGF GAMIJBMLJBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	HJJCDKOEFMD KIJHFILDOCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	NODFFFGJLKO EKJHHIHGALM
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	MGLHCHFIOKJ IBAADMHKPHC
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	POKMPJKENIC MEJOAFNOODK
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	KKINECONBHA GDDBPFGCBHO
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	KBLPGEAPGFP GBIMKMKAFJL
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	AKJNAHIMMAH INPENBKDDAL
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	OIMHDJADCNF JDNCEJKECOC
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	JPEOLCJKIBO HBJBODBMBOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	OMFPKLCAGCI FPJOKJIEJBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	EEFHHNDIGNE OEMGOKCLAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	GKMPPDACLNH BKCPNCGFPCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	DADHIOJBICM EHNBJJJLLAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void FHKBOHEEMBO(HLHBCDCELMH JCHFIJBDJBB);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface PJJEMCJDJMB : IHLALIKNOCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BOEFKPHLFDF BGLDHBEBEIE(Guid IDKMDFCBEHN);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NCLCGNJGAKA(Guid IDKMDFCBEHN);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FNJHMPBDCLD(Guid IDKMDFCBEHN, Task FMLJIOMNMBD);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ACBGBEOCANJ(Guid IDKMDFCBEHN, IDAKKNHINME GMDDDGJHDGI);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(IDAKKNHINME, Task)> ELICDCFOCED(Guid IDKMDFCBEHN);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface FJOFDOAOJCA : IHLALIKNOCJ, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface GOBDPIDFCMO : IHLALIKNOCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DKLPNKJBBJM(GCHMLLGGJOI JJJNODJJIFK);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ODCHEKJGBBB(GCHMLLGGJOI JJJNODJJIFK);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<AMLKNBEIKDJ> GBJBBEMLOFE(CancellationToken IOEMDKJLEKP);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface PFLFLIOMLNP : IHLALIKNOCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BOEFKPHLFDF IHMNHACJEKJ(GCHMLLGGJOI PHJPIBONLOO);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NJOGIFIODMP(Guid IDKMDFCBEHN, Task FMLJIOMNMBD);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface LDNGFBNBCGF : IHLALIKNOCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IDAKKNHINME> GAMIJBMLJBB(GCHMLLGGJOI EJMANJACCLC);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface HJJCDKOEFMD : IHLALIKNOCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IKPHFCIJHCC> PAJFHGEFGOH(NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, BPINABCIEKB DLJENKKADJN, CancellationToken GHLJDIEPICD);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface MGLHCHFIOKJ : IHLALIKNOCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IDAKKNHINME LHKOIDJOCJC(JGGIBKMOPKC KIEKODJAMNJ);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task HEBJAFLMICE(string OCKDOKGOPLB);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface NODFFFGJLKO : IHLALIKNOCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GCHMLLGGJOI> EODMDKEGFGF(GCHMLLGGJOI MJJCOLDOFAC, CKGLENOBMMP LAAALIMMANK, CancellationToken GHLJDIEPICD);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<GCHMLLGGJOI> HKGHLDBECDD(CancellationToken GHLJDIEPICD, CKGLENOBMMP LAAALIMMANK);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MOMAGAAAECB JCEPAJCPPJK(NINLEEMOEAG LIMGMKMBJEL, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MOMAGAAAECB OHDMIHLADGP(NINLEEMOEAG LIMGMKMBJEL, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface POKMPJKENIC : IHLALIKNOCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IDAKKNHINME FIEDIDJHFLI(JGGIBKMOPKC KIEKODJAMNJ, AMLKNBEIKDJ NJGNAINEOMI);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDAKKNHINME ADDKNOHKAIF(JGGIBKMOPKC LDFGEIEBGOO);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface KKINECONBHA
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MACPNBPAHJE(GAMJODHLBNI FAAJEIBDMME);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IKCNAOLAIAA(GAMJODHLBNI FAAJEIBDMME);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IABDPLOCFID(GAMJODHLBNI FAAJEIBDMME);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OICJHNAMEFM(GAMJODHLBNI FAAJEIBDMME);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class GAMJODHLBNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly BPINABCIEKB NFOBKEDJHGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> LECAOOMHKJP;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public NENCAGLHEIB<string> MDMHMPMIMOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D60", Offset = "0x7C1D60", VA = "0x1807C2D60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7C1DE0", Offset = "0x7C0DE0", VA = "0x1807C1DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C50", Offset = "0x7C8C50", VA = "0x1807C9C50")]
	public GAMJODHLBNI(BPINABCIEKB KJLIHJCMFFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x68C8130", Offset = "0x68C7130", VA = "0x1868C8130")]
	public GAMJODHLBNI OEBNGEBAKKL(string OHNEPKBBADL, string LDGMLLMKHLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x68C80A0", Offset = "0x68C70A0", VA = "0x1868C80A0")]
	public bool EJNPFHGBICO([Out] IEnumerable<KeyValuePair<string, string>> KCAGGMMEEJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5BEC220", Offset = "0x5BEB220", VA = "0x185BEC220")]
	public GAMJODHLBNI MEOPOEDFOOC(NENCAGLHEIB<string> OCBBLMCOHCB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface JPEOLCJKIBO
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool KPCHCCEAEBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	string KNBBAKHCGBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool ICNNFHDJPHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NHAGELHAILD();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CBLAKJLFKGM CGEIHLNNFAC(long MPIGBBCKJJM);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HKAACFHKALK<OAKJFJKJCNE, FKEPIPDGFDA> CBFKEPOKJHI(long MPIGBBCKJJM);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HKAACFHKALK<OAKJFJKJCNE, OJAAFLOIAIF> FEDKCDJODHF(long MPIGBBCKJJM);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HKAACFHKALK<long, DNCLMLKIGIO> BMMGLFHLNBI();

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool EADDELAHECN(long MPIGBBCKJJM, [Out] bool JFHILBHFKDA);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<bool> JJJHDLNJEJL(byte[] JEGJKPFGCEN, byte[] AODPHMPACBN, CancellationToken GHLJDIEPICD);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface NAJBLOEPPBO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool ICAFCNFNMJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool HKPBCFGDCLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	HLHBCDCELMH JCDHLNLBBLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action JKHBAHFBDIH;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event IMHCCLLFMEK KMOODELHBNB;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event IMHCCLLFMEK PBOOFJNADML;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event IMHCCLLFMEK HFNJKNBBAJD;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<FGADKHHKFHK, bool> MEPAOBAEGKM;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EBFCCNDLCEE();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	BAAPKIOPEDJ KAJEJACEMFB();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	KIINJFEGLCA IIEAAOKBPML();

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<IDAKKNHINME> BEBEADCPADP(JEENCGOGKPP NGAIDKANJFL);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task KOLAEMINHJM(CancellationToken GHLJDIEPICD);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface GLLEMKBOHHA
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool JPMHCDIEPMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string MJJIJJDNPKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DBBNMDJCMJG(Scene OKDFBGMIDFF);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task NGBBGHECEMH(OGMAALPGOBF KLCDKANLANI, CancellationToken GHLJDIEPICD);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task JGIGAMBHDCG();
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface DBOAJANNPMM
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	LJGNJILFANM DDLGOMBBCHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool IOCDBPEFFKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool HOKCEAPPCDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool HBHKAJPHKLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool IOJNDMCMPIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	int GNCIDNAJDKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool LDHPBALEDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool JEOBCHEENEB
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool FGHHMAIFIGC
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	float PMBDFEFLMEA
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> OCINCBGLPDA;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OIEDECFCIPC BGAKEJMELIM(OIEDECFCIPC NNLLFEJPNEF);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KNAECLHCDAL(OIEDECFCIPC MJBHKMGKNLL);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LMDBAKDKHPK();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task DEEMPMDMBPP(NENCAGLHEIB<string>.OGJMFKKDMDA BMGGCGEBNEH, CancellationToken GHLJDIEPICD);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PLIOIIHCDAH(float GPCKHFHOCME);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OKFIMHFHGIC(string PAHKLFLPMNI);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<ELIEAEEOHNL> PLDKBCCIHBB();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable EPCCGHMLPJG(object DFKOHNJAKHM, ELIEAEEOHNL LHFGOHMNCDD);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	FKEPIPDGFDA BHJNMKGACGF(IEnumerable<FFFNEPAFGPP> JGNHNAKEOBC);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IGAFCDBKPPN(int EMIDNADEKEN);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task LDKLIJDIFPD();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GNJJOLPJPIA();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool BIFOLDBGFDO();

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task IBDAAGGDKLK(CancellationToken GHLJDIEPICD);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task CIMPDMGHFPG(CancellationToken GHLJDIEPICD);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<HHDLMNCBPGC> EPJELICDEPN(DateTime FNIINDCABLP, CancellationToken GHLJDIEPICD);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<bool> AHEGIPKGDIP(CancellationToken GHLJDIEPICD);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void MLLPCGMIPLA(string JJJNODJJIFK = "", float NALPHCAAKLP = 3f);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "24")]
	GLPFJGHGENL GFAJKCPMJKE(NEMIIIGBPPE INKCNKEOKII, GGBJKOCDOKK NIJFMDGDCCJ, OJAAFLOIAIF EJGBACDBHJK, IEnumerable<PersistenceView> FCHKMLBDHJO, JFCACLAEMHA LONOHHHHFFG);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void CHFFIJOLAIE(OJAAFLOIAIF EJGBACDBHJK);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void NBBCEGFOLLD(FFFNEPAFGPP DKFEECFJOGP, [In] GLPFJGHGENL IKOHNLMPJNO);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task DFJDEGGDKGL(OJAAFLOIAIF OIJIGDPADIG, bool BLJAJODNGFF, CancellationToken GHLJDIEPICD);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task FNBKBNGCHOA(CancellationToken GHLJDIEPICD);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void JLANDFFNACG(long CFLPHBNCGDP, long AKANBGAJAAH, KPBKEDCLNDD FMGHPDGBBJI, IPOEENMLOPF DHFJMKIKGOF, EIIHNOKEGGJ AFIGHNEJHMM, KEGLOPNPEGK? HNKOCDGICOF, JCEBIMDNGKK? OFKJCIKEAHL);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void IEJHABKKMME(long CFLPHBNCGDP, long AKANBGAJAAH, JCEBIMDNGKK? OFKJCIKEAHL);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void GMAJMOFNONN(PersistenceView NONLMIAFFIH);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool ABMMBEPOBLK(PersistenceView DNJBPCJBPNH);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool ELMOLOECGEO(FFFNEPAFGPP DKFEECFJOGP, ICALOLDGKCF CMBIELBGLCD, [Out] FHOBACOHIGF NADHEBDFMFI);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task DPBJKCGDMFI(CancellationToken GHLJDIEPICD);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void AIBDHLJLPMK();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "36")]
	IDisposable FCLOBOPPHFA();

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void DPJNEJKADKO(OJAAFLOIAIF OIJIGDPADIG, ICALOLDGKCF CMBIELBGLCD);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<bool> ALBIGOEBCAM(MIMGKGBGIEK GMFPLFAACJJ, CancellationToken GHLJDIEPICD, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void GNBCADJNEEB(CancellationToken GHLJDIEPICD);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<ECDKOBNKCNM> FFFPEIFOBMB(JCNEAEEBPNN MJJCOLDOFAC);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<KPBKEDCLNDD> MGACNAPOFED(long CFLPHBNCGDP, bool ANLCADLBOLB, CancellationToken GHLJDIEPICD);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<IPOEENMLOPF> HKHKDNGPHAN(long CFLPHBNCGDP, long AKANBGAJAAH, long DOJEMLKPGCN, CancellationToken GHLJDIEPICD);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<JFNGOOKNNMM> NPJHKDIDABA(string FNMGFGJPBJD, CancellationToken GHLJDIEPICD);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<JFNGOOKNNMM> MDOLKEAAKJI(string FNMGFGJPBJD, long CFLPHBNCGDP, long AKANBGAJAAH, string GBIPICNEONK, MIFHAEGHLLC.EDGFECBFDOL LAOLHNNNLCH, MIFHAEGHLLC.EDGFECBFDOL AODPHMPACBN, int NDEJNLADIOH);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool DCLMOMBDBEB();

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool LPIIGEJCPFO();

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool NIDBGKHKIKG(IEnumerable<FHOBACOHIGF> JFNLAKGIHNA);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void CPAOHJCAHID(List<GameObject> FNNMOHLPNED);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "50")]
	float EDCDEOALFGB();

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "51")]
	Task<Scene> BBNJNLFCFOF(string DGPOLNCNDIL, LoadSceneMode GPPMGPABKPM, bool DKCODGHGAEK, NENCAGLHEIB<string>.OGJMFKKDMDA OCBBLMCOHCB);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "52")]
	void HEAOKNNECKH();

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void MKMCBBAICJO(bool IEEBLFDNOPE);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void LAEEPDMHMGL(BPINABCIEKB PEMPBFOENGN);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "60")]
	Task GOOKPPJAEOD(NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "61")]
	Task IEHFLFKNLGK(NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "62")]
	Task IJFGHHCNDBG(NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "63")]
	IDisposable EEHAPENKKAM();

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "64")]
	KAABJCANIOP KPMNFPDOFFH();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "65")]
	Task HAOGBHEAPMK(CancellationToken GHLJDIEPICD);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface KAABJCANIOP
{
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DEJDINPCLAN(CancellationToken GHLJDIEPICD);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task OGBCIICMBEH(CancellationToken GHLJDIEPICD);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct GLPFJGHGENL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> KPCNELDLIJD;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum HHDLMNCBPGC : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct NEMIIIGBPPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public string EADCHGAMFPC;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface LJGNJILFANM
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	BPINABCIEKB KHMPOBFCGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	KPBKEDCLNDD DBPOJKPMICE
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	ENIOJCHHHIB FBBJMCGHNNK
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool JMOBLHHDMJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool LIMPCFPKPFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	int EEOFHIJAMKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action PDNPLALHDEE;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> GEAOKEGHFFL;

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KFIACIJDKKF();

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.KKHFKLCNFNC> FEAAOLIAJCH(long MPIGBBCKJJM, [Optional] CancellationToken GHLJDIEPICD);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<EDBPEMLGOJG> MKMHEPACBKB();

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task OILMCLEMHLD();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(BPINABCIEKB, HLHBCDCELMH) DHOENBNJIHE();

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "15")]
	CGFLONACAMI LNAIBAHCEAK();

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KKEFBNFDPJM(long MPIGBBCKJJM);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface KBLPGEAPGFP
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GEDPEMOENON([Out] IEnumerable<int> NNIJDGDHMCP);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IBBONMNLPNB(PIOKGJKNCFA KONODCHOCOG);

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PFBAEHEFHPN(PIOKGJKNCFA KONODCHOCOG);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface KNKCCPIDBGN
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string GINKABGAJCD(IDAKKNHINME PJNPPONDPNA);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface GNJLKLDGKOF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BMKGBGNHJPH(BFJOICLLHIK.AKOOKOGBFEO HNCOMFBHAJC);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NMIEOJMPANA(BFJOICLLHIK.AKOOKOGBFEO HNCOMFBHAJC);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface HMADNGLLKOK : GNJLKLDGKOF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IDAKKNHINME MOINKICNKOH(JGGIBKMOPKC LDFGEIEBGOO);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface PAKLMFALEMK : GNJLKLDGKOF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IDAKKNHINME LHKOIDJOCJC(JGGIBKMOPKC KFFKBJPPNBI);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface CBLAKJLFKGM
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PGLGENBDGKP<OGMAALPGOBF, HBNEILLBGHD>> DDFNBIGOLEG(string GBIPICNEONK, long MPIGBBCKJJM, long? CFLPHBNCGDP, long? AKANBGAJAAH, GCFEKEDMOAJ.IKALHOMOJKH LCLHDGLKCAE, CancellationToken GHLJDIEPICD);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface HKAACFHKALK<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PGLGENBDGKP<MAHHFMJICFI<TData>, HBNEILLBGHD>> GLJPNFCODJO(TGetDataArg OFDFAAHEGDG, CancellationToken GHLJDIEPICD);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal sealed class KIKHLLHGLAE : IONKJBLKHOH, NAJBLOEPPBO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct GKOOPENIHEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AsyncTaskMethodBuilder<IDAKKNHINME> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public KIKHLLHGLAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public JEENCGOGKPP autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<IDAKKNHINME> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x68C9840", Offset = "0x68C8840", VA = "0x1868C9840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x68C9AC0", Offset = "0x68C8AC0", VA = "0x1868C9AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct GPJCPHFNEFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public KIKHLLHGLAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x68CB680", Offset = "0x68CA680", VA = "0x1868CB680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x68CB8B0", Offset = "0x68CA8B0", VA = "0x1868CB8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class GPBCKMHIBCC : IEnumerable<IHLALIKNOCJ>, IEnumerable, IEnumerator<IHLALIKNOCJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private IHLALIKNOCJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public KIKHLLHGLAE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		private IHLALIKNOCJ System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8164C0", Offset = "0x8154C0", VA = "0x1808164C0")]
		[DebuggerHidden]
		public GPBCKMHIBCC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x68CB1D0", Offset = "0x68CA1D0", VA = "0x1868CB1D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x68CB630", Offset = "0x68CA630", VA = "0x1868CB630", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x68CB580", Offset = "0x68CA580", VA = "0x1868CB580", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<IHLALIKNOCJ> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x68CB580", Offset = "0x68CA580", VA = "0x1868CB580", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource PIFJILNMNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly OIEDECFCIPC MJBHKMGKNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool FFEBLLHHGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private DABCJMIPBPK BMLHFLGPEIO;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public MIMGKGBGIEK AKOCEAJPGOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7C6560", Offset = "0x7C5560", VA = "0x1807C6560", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7C6550", Offset = "0x7C5550", VA = "0x1807C6550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public OJNGFMPHCML DNIIHKFNDHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7C79B0", Offset = "0x7C69B0", VA = "0x1807C79B0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7C7970", Offset = "0x7C6970", VA = "0x1807C7970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public DBOAJANNPMM BNJIHDAPCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7C79C0", Offset = "0x7C69C0", VA = "0x1807C79C0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7C7950", Offset = "0x7C6950", VA = "0x1807C7950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public GLLEMKBOHHA KCPDHLOFPKI
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7C7930", Offset = "0x7C6930", VA = "0x1807C7930", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7C7940", Offset = "0x7C6940", VA = "0x1807C7940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public HMADNGLLKOK LIDPKIDNDBA
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7C7980", Offset = "0x7C6980", VA = "0x1807C7980", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7C79A0", Offset = "0x7C69A0", VA = "0x1807C79A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public PAKLMFALEMK DCGLGEHLOCG
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7C7960", Offset = "0x7C6960", VA = "0x1807C7960", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7C7990", Offset = "0x7C6990", VA = "0x1807C7990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public AAGLIDGLEOO JHMOHOMBLGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7F0", Offset = "0x7CA7F0", VA = "0x1807CB7F0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7CB800", Offset = "0x7CA800", VA = "0x1807CB800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public NALENELDDPM LDFDPFMKPFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7CB830", Offset = "0x7CA830", VA = "0x1807CB830", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7CB750", Offset = "0x7CA750", VA = "0x1807CB750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public FLJJPHEOGBK ALKFIKLNDGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7B0", Offset = "0x7CA7B0", VA = "0x1807CB7B0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7CB770", Offset = "0x7CA770", VA = "0x1807CB770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public KFPLCDDLLIA HDFAJIJEPJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x99BB20", Offset = "0x99AB20", VA = "0x18099BB20", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x99BC00", Offset = "0x99AC00", VA = "0x18099BC00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public MPIFKJJNNCE PCPOPEGGJMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7A0", Offset = "0x7CA7A0", VA = "0x1807CB7A0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7CB840", Offset = "0x7CA840", VA = "0x1807CB840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public NJKCLBHBFPO FEELJJNBJAB
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x889620", Offset = "0x888620", VA = "0x180889620", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x889740", Offset = "0x888740", VA = "0x180889740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public PFHGGCAIBEH PNBGEMCNFGB
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7C9E80", Offset = "0x7C8E80", VA = "0x1807C9E80", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7C9E90", Offset = "0x7C8E90", VA = "0x1807C9E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public PJJEMCJDJMB PCJFJFCEEBM
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA26C50", Offset = "0xA25C50", VA = "0x180A26C50", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA2F620", Offset = "0xA2E620", VA = "0x180A2F620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public FJOFDOAOJCA EMJCMDLFCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x96C7D0", Offset = "0x96B7D0", VA = "0x18096C7D0", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x96C7E0", Offset = "0x96B7E0", VA = "0x18096C7E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public GOBDPIDFCMO OOMJPMLMBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9B6C30", Offset = "0x9B5C30", VA = "0x1809B6C30", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA2F5E0", Offset = "0xA2E5E0", VA = "0x180A2F5E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public PFLFLIOMLNP DDBBOLHMIMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8DF280", Offset = "0x8DE280", VA = "0x1808DF280", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA2F660", Offset = "0xA2E660", VA = "0x180A2F660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public LDNGFBNBCGF GAMIJBMLJBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x90BBB0", Offset = "0x90ABB0", VA = "0x18090BBB0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x98E110", Offset = "0x98D110", VA = "0x18098E110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public HJJCDKOEFMD KIJHFILDOCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7C9E50", Offset = "0x7C8E50", VA = "0x1807C9E50", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7C9E10", Offset = "0x7C8E10", VA = "0x1807C9E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public NODFFFGJLKO EKJHHIHGALM
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x890D70", Offset = "0x88FD70", VA = "0x180890D70", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x88EE20", Offset = "0x88DE20", VA = "0x18088EE20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public MGLHCHFIOKJ IBAADMHKPHC
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8E9ED0", Offset = "0x8E8ED0", VA = "0x1808E9ED0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8EA310", Offset = "0x8E9310", VA = "0x1808EA310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public POKMPJKENIC MEJOAFNOODK
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x90BA30", Offset = "0x90AA30", VA = "0x18090BA30", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA2F640", Offset = "0xA2E640", VA = "0x180A2F640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public KKINECONBHA GDDBPFGCBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x890E20", Offset = "0x88FE20", VA = "0x180890E20", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88CB00", VA = "0x18088DB00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public KBLPGEAPGFP GBIMKMKAFJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x90B9D0", Offset = "0x90A9D0", VA = "0x18090B9D0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA2F600", Offset = "0xA2E600", VA = "0x180A2F600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public AKJNAHIMMAH INPENBKDDAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9B5D90", Offset = "0x9B4D90", VA = "0x1809B5D90", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA2F800", Offset = "0xA2E800", VA = "0x180A2F800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public OIMHDJADCNF JDNCEJKECOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8FA4E0", Offset = "0x8F94E0", VA = "0x1808FA4E0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA2F7E0", Offset = "0xA2E7E0", VA = "0x180A2F7E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public JPEOLCJKIBO HBJBODBMBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x86D490", Offset = "0x86C490", VA = "0x18086D490", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA2F740", Offset = "0xA2E740", VA = "0x180A2F740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public OMFPKLCAGCI FPJOKJIEJBN
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x98DFE0", Offset = "0x98CFE0", VA = "0x18098DFE0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public EEFHHNDIGNE OEMGOKCLAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8FA500", Offset = "0x8F9500", VA = "0x1808FA500", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public GKMPPDACLNH BKCPNCGFPCM
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8FA4F0", Offset = "0x8F94F0", VA = "0x1808FA4F0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public DADHIOJBICM EHNBJJJLLAC
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9B5990", Offset = "0x9B4990", VA = "0x1809B5990", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public HLHBCDCELMH JCDHLNLBBLN
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9B5EA0", Offset = "0x9B4EA0", VA = "0x1809B5EA0", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9AC5E0", Offset = "0x9AB5E0", VA = "0x1809AC5E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	private bool MDPDFPBPDFL
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x68D31A0", Offset = "0x68D21A0", VA = "0x1868D31A0", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	private bool HGNPCCMDLGG
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x68D2D00", Offset = "0x68D1D00", VA = "0x1868D2D00", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	private CancellationToken JDCJJBGDPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x68D3090", Offset = "0x68D2090", VA = "0x1868D3090", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	private OIEDECFCIPC HLGLECMOPCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action PFEKGELIHCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x68D2F20", Offset = "0x68D1F20", VA = "0x1868D2F20", Slot = "37")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x68D30B0", Offset = "0x68D20B0", VA = "0x1868D30B0", Slot = "38")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event IMHCCLLFMEK MIBFMEPNFMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x68D3200", Offset = "0x68D2200", VA = "0x1868D3200", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x68D33B0", Offset = "0x68D23B0", VA = "0x1868D33B0", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event IMHCCLLFMEK CGDAJPLJMNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x68D3260", Offset = "0x68D2260", VA = "0x1868D3260", Slot = "41")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x68D3350", Offset = "0x68D2350", VA = "0x1868D3350", Slot = "42")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event IMHCCLLFMEK IPNDLIFKEFG
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x68D2B90", Offset = "0x68D1B90", VA = "0x1868D2B90", Slot = "43")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x68D3690", Offset = "0x68D2690", VA = "0x1868D3690", Slot = "44")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<FGADKHHKFHK, bool> IMELLCNJLCD
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x68D3500", Offset = "0x68D2500", VA = "0x1868D3500", Slot = "45")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x68D35E0", Offset = "0x68D25E0", VA = "0x1868D35E0", Slot = "46")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x9AC5E0", Offset = "0x9AB5E0", VA = "0x1809AC5E0", Slot = "36")]
	public void FHKBOHEEMBO(HLHBCDCELMH JCHFIJBDJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x68D36F0", Offset = "0x68D26F0", VA = "0x1868D36F0")]
	[UnityEngine.Scripting.Preserve]
	internal KIKHLLHGLAE([POILJEECDED(null)] OIEDECFCIPC MJBHKMGKNLL, [POILJEECDED(null)] MIMGKGBGIEK GMFPLFAACJJ, [POILJEECDED(null)] OJNGFMPHCML PAGLFNPNHEC, [POILJEECDED(null)] DBOAJANNPMM AKJKFGAFELN, [POILJEECDED(null)] GLLEMKBOHHA AKJGDJDDNBG, [POILJEECDED(null)] HMADNGLLKOK OHCIMHINJIO, [POILJEECDED(null)] PAKLMFALEMK BJDLIPLDNJB, [POILJEECDED(null)] AAGLIDGLEOO LGAJGGNOGIG, [POILJEECDED(null)] NALENELDDPM AFEDNGDPKGN, [POILJEECDED(null)] FLJJPHEOGBK CACPPGFKECO, [POILJEECDED(null)] KFPLCDDLLIA APPFGNMDKHF, [POILJEECDED(null)] MPIFKJJNNCE APEEPNLANJM, [POILJEECDED(null)] NJKCLBHBFPO COIBKFDENBL, [POILJEECDED(null)] PFHGGCAIBEH ABFGAFGJNGC, [POILJEECDED(null)] PJJEMCJDJMB PNNDKKIMKOD, [POILJEECDED(null)] FJOFDOAOJCA FMHJNFPDPOP, [POILJEECDED(null)] GOBDPIDFCMO ALEKDKNEGOI, [POILJEECDED(null)] PFLFLIOMLNP DPCGBNDFMNH, [POILJEECDED(null)] LDNGFBNBCGF KEFDJBGODEP, [POILJEECDED(null)] HJJCDKOEFMD ODEMEOPLADP, [POILJEECDED(null)] MGLHCHFIOKJ BPFLFEPFBML, [POILJEECDED(null)] NODFFFGJLKO PCFKDKOIMLB, [POILJEECDED(null)] POKMPJKENIC PDPBLEDPOIE, [POILJEECDED(null)] KKINECONBHA JOHOGNMMIIO, [POILJEECDED(null)] KBLPGEAPGFP PCAJJOEGMGK, [POILJEECDED(null)] OIMHDJADCNF MOBEOAJIGJA, [POILJEECDED(null)] JPEOLCJKIBO NFJIIJDAOLL, [POILJEECDED(null)] OMFPKLCAGCI GAEPMONFMPE, [POILJEECDED(null)] EEFHHNDIGNE DJGJABHDKPJ, [POILJEECDED(null)] GKMPPDACLNH PKDJBMMFNAF, [POILJEECDED(null)] DADHIOJBICM MPJHANBOIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x68D2BF0", Offset = "0x68D1BF0", VA = "0x1868D2BF0")]
	private void CJMKLAKCCOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x68D2D80", Offset = "0x68D1D80", VA = "0x1868D2D80", Slot = "55")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x68D3640", Offset = "0x68D2640", VA = "0x1868D3640", Slot = "49")]
	private void OBIMFEPIPBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x68D32C0", Offset = "0x68D22C0", VA = "0x1868D32C0", Slot = "50")]
	private BAAPKIOPEDJ IDGKPIBPGKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x68D3110", Offset = "0x68D2110", VA = "0x1868D3110", Slot = "51")]
	private KIINJFEGLCA HCMMEIKKALN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x68D2F80", Offset = "0x68D1F80", VA = "0x1868D2F80", Slot = "52")]
	[AsyncStateMachine(typeof(GKOOPENIHEF))]
	private Task<IDAKKNHINME> FBLEEPIMCNH(JEENCGOGKPP OHMDGACKMDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x68D3410", Offset = "0x68D2410", VA = "0x1868D3410", Slot = "53")]
	[AsyncStateMachine(typeof(GPJCPHFNEFD))]
	private Task JLCLMDOPPBD(CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x68D3560", Offset = "0x68D2560", VA = "0x1868D3560")]
	[IteratorStateMachine(typeof(GPBCKMHIBCC))]
	private IEnumerable<IHLALIKNOCJ> KCDCAJECMEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x68D2CA0", Offset = "0x68D1CA0", VA = "0x1868D2CA0")]
	[CompilerGenerated]
	private void CKHPBODKLEF(IHLALIKNOCJ MPHIHJDJBKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class JBOEOJFLMJC : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0xDB1A50", Offset = "0xDB0A50", VA = "0x180DB1A50")]
	public JBOEOJFLMJC(string JJJNODJJIFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal class IIJBBBCJBLK : AONMMFNBBGO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct ABBNGKBFGDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public IIJBBBCJBLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x68C0FA0", Offset = "0x68BFFA0", VA = "0x1868C0FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x68C12E0", Offset = "0x68C02E0", VA = "0x1868C12E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly IONKJBLKHOH CPMFHDAOGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly DBOAJANNPMM AKJKFGAFELN;

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7CEA10", Offset = "0x7CDA10", VA = "0x1807CEA10")]
	public IIJBBBCJBLK(IONKJBLKHOH CPMFHDAOGEO, DBOAJANNPMM AKJKFGAFELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x68D21D0", Offset = "0x68D11D0", VA = "0x1868D21D0", Slot = "4")]
	[AsyncStateMachine(typeof(ABBNGKBFGDO))]
	public Task<bool> PMGNBCGIJCP(CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x68D20F0", Offset = "0x68D10F0", VA = "0x1868D20F0")]
	[CompilerGenerated]
	private object BGJHIOBFMKP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal class KFCLCBHANPP : AONMMFNBBGO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct ALEAKIMHHIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public KFCLCBHANPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private float <timeoutTime>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x68C18B0", Offset = "0x68C08B0", VA = "0x1868C18B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x68C1FC0", Offset = "0x68C0FC0", VA = "0x1868C1FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly IONKJBLKHOH CPMFHDAOGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly DBOAJANNPMM AKJKFGAFELN;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private LJGNJILFANM DDLGOMBBCHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x68D2A10", Offset = "0x68D1A10", VA = "0x1868D2A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x7CEA10", Offset = "0x7CDA10", VA = "0x1807CEA10")]
	public KFCLCBHANPP(IONKJBLKHOH CPMFHDAOGEO, DBOAJANNPMM AKJKFGAFELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x68D2A60", Offset = "0x68D1A60", VA = "0x1868D2A60", Slot = "4")]
	[AsyncStateMachine(typeof(ALEAKIMHHIA))]
	public Task<bool> PMGNBCGIJCP(CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x68D2930", Offset = "0x68D1930", VA = "0x1868D2930")]
	[CompilerGenerated]
	private object DPNJJHPAMJC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal class PAMCPMCCODN : AONMMFNBBGO
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class KOCKLHIBOBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public PAMCPMCCODN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public EDBPEMLGOJG result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public BPINABCIEKB newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public KOCKLHIBOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x68D3F80", Offset = "0x68D2F80", VA = "0x1868D3F80")]
		internal object JMBGJHDLMBD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x68D3E70", Offset = "0x68D2E70", VA = "0x1868D3E70")]
		internal object DHEPOMHAGMI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x68D3EE0", Offset = "0x68D2EE0", VA = "0x1868D3EE0")]
		internal object GAHICBHNFFJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct NAELMOGKACE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public PAMCPMCCODN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private KOCKLHIBOBM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<EDBPEMLGOJG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x68D6490", Offset = "0x68D5490", VA = "0x1868D6490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x68D6DC0", Offset = "0x68D5DC0", VA = "0x1868D6DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly IONKJBLKHOH CPMFHDAOGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly DBOAJANNPMM AKJKFGAFELN;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private LJGNJILFANM DDLGOMBBCHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x68DD2C0", Offset = "0x68DC2C0", VA = "0x1868DD2C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x7CEA10", Offset = "0x7CDA10", VA = "0x1807CEA10")]
	public PAMCPMCCODN(IONKJBLKHOH CPMFHDAOGEO, DBOAJANNPMM AKJKFGAFELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x68DD310", Offset = "0x68DC310", VA = "0x1868DD310", Slot = "4")]
	[AsyncStateMachine(typeof(NAELMOGKACE))]
	public Task<bool> PMGNBCGIJCP(CancellationToken GHLJDIEPICD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal interface AONMMFNBBGO
{
	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> PMGNBCGIJCP(CancellationToken GHLJDIEPICD);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal struct POJFDLCJALB
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class AJANECLNOLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public IONKJBLKHOH manager;

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public AJANECLNOLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x68C1860", Offset = "0x68C0860", VA = "0x1868C1860")]
		internal Task NJPIKJOGMFD(DJJMNPKHNKF data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct OJPNOFGEDFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public POJFDLCJALB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private JEENCGOGKPP <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<HHDLMNCBPGC> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TaskAwaiter<IDAKKNHINME> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x68DBB70", Offset = "0x68DAB70", VA = "0x1868DBB70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x68DC100", Offset = "0x68DB100", VA = "0x1868DC100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct IBJGCHNBGHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public POJFDLCJALB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x68D1260", Offset = "0x68D0260", VA = "0x1868D1260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x68D1580", Offset = "0x68D0580", VA = "0x1868D1580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly CancellationToken GHLJDIEPICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly IONKJBLKHOH PGDDBCEFICD;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private MIMGKGBGIEK AKOCEAJPGOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x68DE0A0", Offset = "0x68DD0A0", VA = "0x1868DE0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private DBOAJANNPMM BNJIHDAPCGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x68DE220", Offset = "0x68DD220", VA = "0x1868DE220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private LJGNJILFANM DDLGOMBBCHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x68DE550", Offset = "0x68DD550", VA = "0x1868DE550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private FLJJPHEOGBK ALKFIKLNDGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x68DE5D0", Offset = "0x68DD5D0", VA = "0x1868DE5D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x1E42570", Offset = "0x1E41570", VA = "0x181E42570")]
	public POJFDLCJALB(CancellationToken GHLJDIEPICD, IONKJBLKHOH PGDDBCEFICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x68DDEE0", Offset = "0x68DCEE0", VA = "0x1868DDEE0")]
	public static OLEFILIJHIM AGGJBNMFHMG(IONKJBLKHOH PGDDBCEFICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x68DDF90", Offset = "0x68DCF90", VA = "0x1868DDF90")]
	[AsyncStateMachine(typeof(OJPNOFGEDFM))]
	public Task<bool> AOFLBJDIDMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x68DE340", Offset = "0x68DD340", VA = "0x1868DE340")]
	private bool KOAAALHLEIE([Out] JEENCGOGKPP OHMDGACKMDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x68DE270", Offset = "0x68DD270", VA = "0x1868DE270")]
	[AsyncStateMachine(typeof(IBJGCHNBGHK))]
	private Task KMFLHCNCGBH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x68DE0F0", Offset = "0x68DD0F0", VA = "0x1868DE0F0")]
	private Task<HHDLMNCBPGC> DKLOJBCIBKK(JEENCGOGKPP IBJKPOEGHGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct BOEFKPHLFDF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly PJJEMCJDJMB PNNDKKIMKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly Guid IDKMDFCBEHN;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	private Task<(IDAKKNHINME, Task)> NHOCIMHMHMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x68C30A0", Offset = "0x68C20A0", VA = "0x1868C30A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x3E124E0", Offset = "0x3E114E0", VA = "0x183E124E0")]
	public BOEFKPHLFDF(PJJEMCJDJMB PNNDKKIMKOD, Guid IDKMDFCBEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x68C3050", Offset = "0x68C2050", VA = "0x1868C3050")]
	public TaskAwaiter<(IDAKKNHINME, Task)> KIMBMIDADNK()
	{
		return default(TaskAwaiter<(IDAKKNHINME, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x68C2F80", Offset = "0x68C1F80", VA = "0x1868C2F80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal struct AOMFDFIPIIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly TaskCompletionSource<(IDAKKNHINME, Task)> HLMIIOBIGHC;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public Task<(IDAKKNHINME, Task)> NHOCIMHMHMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x68C21B0", Offset = "0x68C11B0", VA = "0x1868C21B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x68C2280", Offset = "0x68C1280", VA = "0x1868C2280")]
	public AOMFDFIPIIG(TimeSpan EHBCNAICFII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x68C2110", Offset = "0x68C1110", VA = "0x1868C2110")]
	public void JGDIINEDEMD(Task FMLJIOMNMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x68C2080", Offset = "0x68C1080", VA = "0x1868C2080")]
	public void HDHKAGFKPFD(IDAKKNHINME PJNPPONDPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x68C2030", Offset = "0x68C1030", VA = "0x1868C2030")]
	public void FNEIKOBGOOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x68C21F0", Offset = "0x68C11F0", VA = "0x1868C21F0")]
	internal void PDELDLONLKL(string JJJNODJJIFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class EHIEJAECIIJ
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class NLIGGJKMHOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public IPOEENMLOPF subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public NLIGGJKMHOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x68DA930", Offset = "0x68D9930", VA = "0x1868DA930")]
		internal bool JOFFNNNDLIJ(ENIOJCHHHIB s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x68C6D10", Offset = "0x68C5D10", VA = "0x1868C6D10")]
	public static IKPHFCIJHCC EOFBBDOECDH(long LNFKOMHJPEB, long AKANBGAJAAH, string FNMGFGJPBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x68C6C50", Offset = "0x68C5C50", VA = "0x1868C6C50")]
	public static IKPHFCIJHCC EOFBBDOECDH(long LNFKOMHJPEB, long AKANBGAJAAH, OAKJFJKJCNE JEGJKPFGCEN, long DOJEMLKPGCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x68C6890", Offset = "0x68C5890", VA = "0x1868C6890")]
	public static IKPHFCIJHCC EOFBBDOECDH(ECDKOBNKCNM GJGIGFJIDAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x68C6A20", Offset = "0x68C5A20", VA = "0x1868C6A20")]
	public static IKPHFCIJHCC EOFBBDOECDH(KPBKEDCLNDD PECDOMAFNMF, IPOEENMLOPF LNNIJENLCFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x68C6F30", Offset = "0x68C5F30", VA = "0x1868C6F30")]
	public static IKPHFCIJHCC HOJIDOHGNDE(this IKPHFCIJHCC KKAPFENLPIM, KPBKEDCLNDD EEPCDLMFOLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x68C6DA0", Offset = "0x68C5DA0", VA = "0x1868C6DA0")]
	public static IKPHFCIJHCC FBIOMIINFHA(this IKPHFCIJHCC KKAPFENLPIM, IPOEENMLOPF IDAILCHPKKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[RecRoom.NoEngine.Common.Preserve]
internal class CHHCOLAFILB : NALENELDDPM, IHLALIKNOCJ, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct BNIHNBIKHMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public CHHCOLAFILB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private BEAMBDPEGJL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x68C2890", Offset = "0x68C1890", VA = "0x1868C2890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x68C2F20", Offset = "0x68C1F20", VA = "0x1868C2F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly PIOKGJKNCFA OJHLPFKDAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private string PNGHJPFNLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Task EGIGEHJFKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private IONKJBLKHOH CPMFHDAOGEO;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool PLNBKCEDNAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x68C3A00", Offset = "0x68C2A00", VA = "0x1868C3A00", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public Task FCEDLFCLIGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x68C3CB0", Offset = "0x68C2CB0", VA = "0x1868C3CB0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7C3D80", Offset = "0x7C2D80", VA = "0x1807C3D80", Slot = "7")]
	public void CJMKLAKCCOG(IONKJBLKHOH CPMFHDAOGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x68C3B50", Offset = "0x68C2B50", VA = "0x1868C3B50", Slot = "6")]
	public void EBDIPBHLKAO(Task BKJCIFOIBEF, string EAFOFCAFIPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x68C3A30", Offset = "0x68C2A30", VA = "0x1868C3A30")]
	[AsyncStateMachine(typeof(BNIHNBIKHMJ))]
	private Task BAHLGPFBKNJ(Task OCBHNEHFFGA, string EAFOFCAFIPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x68C3D40", Offset = "0x68C2D40", VA = "0x1868C3D40")]
	public CHHCOLAFILB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class MJBKMIFKPCI : AKJNAHIMMAH, IHLALIKNOCJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool PPCFIHMPPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private LACPOPGHEKN BBCDHMEJALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private MIMGKGBGIEK GMFPLFAACJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private OIMHDJADCNF MOBEOAJIGJA;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public LACPOPGHEKN LOMEGNMANCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x68D63B0", Offset = "0x68D53B0", VA = "0x1868D63B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x68D5F80", Offset = "0x68D4F80", VA = "0x1868D5F80", Slot = "7")]
	public void CJMKLAKCCOG(IONKJBLKHOH CPMFHDAOGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x68D6200", Offset = "0x68D5200", VA = "0x1868D6200", Slot = "5")]
	public void LPIPCKKCCDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x68D6100", Offset = "0x68D5100", VA = "0x1868D6100", Slot = "6")]
	public void JPMAKBNNGKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x68D6140", Offset = "0x68D5140", VA = "0x1868D6140")]
	private Task FGLPLADDOJO(JCFJBKDHGNN GEJMEMCGHEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x68D6100", Offset = "0x68D5100", VA = "0x1868D6100", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public MJBKMIFKPCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class GHODPABOIBE : OIMHDJADCNF
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	private class EJFAGIDPMMP<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly JBCGMADOBCF PMLPBEPMGEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly string OHNEPKBBADL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly T HIFDPDGCHMN;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public T DMDNAKDAMMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x813060", Offset = "0x812060", VA = "0x180813060")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x86B840", Offset = "0x86A840", VA = "0x18086B840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x35156B0", Offset = "0x35146B0", VA = "0x1835156B0")]
		public EJFAGIDPMMP(JBCGMADOBCF PMLPBEPMGEO, string OHNEPKBBADL, T HIFDPDGCHMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x35150E0", Offset = "0x35140E0", VA = "0x1835150E0")]
		private void OLDFOHKNDIE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly JBCGMADOBCF PMLPBEPMGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly EJFAGIDPMMP<TimeSpan> LLJMCAPCKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly EJFAGIDPMMP<TimeSpan> MJLEMPPOHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly EJFAGIDPMMP<TimeSpan> JICEPACHCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly EJFAGIDPMMP<TimeSpan> HJNGGAKPKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly EJFAGIDPMMP<bool> JHEBPIENMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly EJFAGIDPMMP<bool> BNHNFCLPICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly EJFAGIDPMMP<bool> KBEGNKDMEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly EJFAGIDPMMP<int> LGDKPPCCAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly EJFAGIDPMMP<bool> MLCHIHHADOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly EJFAGIDPMMP<bool> JFDFAALBOMJ;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public TimeSpan LBJALGBCIDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x68C9290", Offset = "0x68C8290", VA = "0x1868C9290", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public TimeSpan IMPPDFHKPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x68C91D0", Offset = "0x68C81D0", VA = "0x1868C91D0", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public TimeSpan JAOBLGEBJJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x68C92D0", Offset = "0x68C82D0", VA = "0x1868C92D0", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public TimeSpan HMOHGKCDEED
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x68C9210", Offset = "0x68C8210", VA = "0x1868C9210", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool OOGCJIMJGLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x68C9150", Offset = "0x68C8150", VA = "0x1868C9150", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool HAAFBPIDDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x68C9350", Offset = "0x68C8350", VA = "0x1868C9350", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool FLDHHEHAOAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x68C9390", Offset = "0x68C8390", VA = "0x1868C9390", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public int KHLGNCBANCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x68C9250", Offset = "0x68C8250", VA = "0x1868C9250", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool ADMBLHGOPFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x68C9310", Offset = "0x68C8310", VA = "0x1868C9310", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool KFCFLEMCAFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x68C9190", Offset = "0x68C8190", VA = "0x1868C9190", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x68C93D0", Offset = "0x68C83D0", VA = "0x1868C93D0")]
	[UnityEngine.Scripting.Preserve]
	public GHODPABOIBE([POILJEECDED(null)] JBCGMADOBCF PMLPBEPMGEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[UnityEngine.Scripting.Preserve]
internal class IGFGCBLLIKF : KFPLCDDLLIA, IHLALIKNOCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class INFLMNNOOEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public LDBJDOIIBIB roomEvent;

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public INFLMNNOOEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x68D2310", Offset = "0x68D1310", VA = "0x1868D2310")]
		internal object HIHLEDFBHJM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action JKHBAHFBDIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x68D2050", Offset = "0x68D1050", VA = "0x1868D2050", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x68D1E40", Offset = "0x68D0E40", VA = "0x1868D1E40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event IMHCCLLFMEK KMOODELHBNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x68D1C20", Offset = "0x68D0C20", VA = "0x1868D1C20", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x68D1F80", Offset = "0x68D0F80", VA = "0x1868D1F80", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event IMHCCLLFMEK PBOOFJNADML
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x68D1710", Offset = "0x68D0710", VA = "0x1868D1710", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x68D1CC0", Offset = "0x68D0CC0", VA = "0x1868D1CC0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event IMHCCLLFMEK HFNJKNBBAJD
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x68D1EE0", Offset = "0x68D0EE0", VA = "0x1868D1EE0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x68D17B0", Offset = "0x68D07B0", VA = "0x1868D17B0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<FGADKHHKFHK, bool> MEPAOBAEGKM
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x68D1660", Offset = "0x68D0660", VA = "0x1868D1660", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x68D1D90", Offset = "0x68D0D90", VA = "0x1868D1D90", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "19")]
	public void CJMKLAKCCOG(IONKJBLKHOH CPMFHDAOGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x68D1A20", Offset = "0x68D0A20", VA = "0x1868D1A20", Slot = "14")]
	public void IMCFDPCDCGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x68D1D60", Offset = "0x68D0D60", VA = "0x1868D1D60", Slot = "15")]
	public void LJCKPEIFLPJ(LDBJDOIIBIB JAKPAOCDOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x68D15E0", Offset = "0x68D05E0", VA = "0x1868D15E0", Slot = "16")]
	public void AIBJAHFEHAJ(LDBJDOIIBIB JAKPAOCDOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x68D2020", Offset = "0x68D1020", VA = "0x1868D2020", Slot = "17")]
	public void PDKCCHFPCOA(LDBJDOIIBIB JAKPAOCDOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x68D1610", Offset = "0x68D0610", VA = "0x1868D1610", Slot = "18")]
	public void DJOBBGJGIPG(FGADKHHKFHK BLOFAJKGCBC, bool HBNABJDAFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x68D1850", Offset = "0x68D0850", VA = "0x1868D1850")]
	private void HEGHDPNDHOB(IMHCCLLFMEK LHFGOHMNCDD, LDBJDOIIBIB JAKPAOCDOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public IGFGCBLLIKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[UnityEngine.Scripting.Preserve]
internal class LHKCJHNNDIC : MPIFKJJNNCE, IHLALIKNOCJ, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct JFHNIOEBDGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public LHKCJHNNDIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private BEAMBDPEGJL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x68D23F0", Offset = "0x68D13F0", VA = "0x1868D23F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x68D28D0", Offset = "0x68D18D0", VA = "0x1868D28D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct DBINADPEIOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public LHKCJHNNDIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private BEAMBDPEGJL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x68C4B50", Offset = "0x68C3B50", VA = "0x1868C4B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x68C51B0", Offset = "0x68C41B0", VA = "0x1868C51B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class DOPCGCJEIHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public DOPCGCJEIHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x68C5B80", Offset = "0x68C4B80", VA = "0x1868C5B80")]
		internal object MPDINONCJKD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct DPDJENAMODA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public LHKCJHNNDIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private DOPCGCJEIHL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private BEAMBDPEGJL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x68C5BF0", Offset = "0x68C4BF0", VA = "0x1868C5BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x68C6340", Offset = "0x68C5340", VA = "0x1868C6340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class KMAEKGOACPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public KMAEKGOACPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x68D3E00", Offset = "0x68D2E00", VA = "0x1868D3E00")]
		internal object KAGEBJBKFJL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly NDLEKAMCBHL LAGKGKDNMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private IONKJBLKHOH CPMFHDAOGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private DBOAJANNPMM AKJKFGAFELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private AONMMFNBBGO[] LIEEIFAAMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private CancellationTokenSource EILAHEEOMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private int LLGAIKDIMCM;

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x68D41C0", Offset = "0x68D31C0", VA = "0x1868D41C0", Slot = "6")]
	public void CJMKLAKCCOG(IONKJBLKHOH CPMFHDAOGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x68D4240", Offset = "0x68D3240", VA = "0x1868D4240", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x68D4450", Offset = "0x68D3450", VA = "0x1868D4450", Slot = "8")]
	public void IKNLGAIIHPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x68D4250", Offset = "0x68D3250", VA = "0x1868D4250", Slot = "5")]
	public void EBFCCNDLCEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x68D4770", Offset = "0x68D3770", VA = "0x1868D4770", Slot = "4")]
	[AsyncStateMachine(typeof(JFHNIOEBDGL))]
	public Task LGHBNHCIPGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x68D4A70", Offset = "0x68D3A70", VA = "0x1868D4A70")]
	private void PGMBJEPBJME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x68D4970", Offset = "0x68D3970", VA = "0x1868D4970")]
	[AsyncStateMachine(typeof(DBINADPEIOF))]
	private Task PFOPEDJIPCK(CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x68D4630", Offset = "0x68D3630", VA = "0x1868D4630")]
	[AsyncStateMachine(typeof(DPDJENAMODA))]
	private Task<bool> KPMNCOBDLHM(int GPEHCABDGEJ, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x68D4550", Offset = "0x68D3550", VA = "0x1868D4550")]
	private void IPEBPMBFBNA(int GPEHCABDGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x68D40E0", Offset = "0x68D30E0", VA = "0x1868D40E0")]
	private void BBPGEDNMLEB(int GPEHCABDGEJ, bool HBNABJDAFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x68D4840", Offset = "0x68D3840", VA = "0x1868D4840")]
	private void PAPKLEKMNKI(int GPEHCABDGEJ, Exception DNFOGIGBCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x68D4320", Offset = "0x68D3320", VA = "0x1868D4320")]
	private void HPAEEDFPKEB(CancellationToken GHLJDIEPICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public LHKCJHNNDIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[RecRoom.NoEngine.Common.Preserve]
internal class NLHCDNFKJFF : NJKCLBHBFPO, IHLALIKNOCJ, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct GFAFIMLJNNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public BPINABCIEKB targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public NLHCDNFKJFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public HLHBCDCELMH customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private BEAMBDPEGJL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x68C8790", Offset = "0x68C7790", VA = "0x1868C8790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x68C90F0", Offset = "0x68C80F0", VA = "0x1868C90F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct OKCPGPLOJCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public NLHCDNFKJFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public BPINABCIEKB targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public HLHBCDCELMH customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private NENCAGLHEIB<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private BEAMBDPEGJL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private CKGLENOBMMP <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private GAMJODHLBNI <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x68DC170", Offset = "0x68DB170", VA = "0x1868DC170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x68DCD30", Offset = "0x68DBD30", VA = "0x1868DCD30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class GCOAGMEDMGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public Matchmaking.JBJDGEMELLL result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public MAPGHKPFHLD errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public GCOAGMEDMGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x68C8200", Offset = "0x68C7200", VA = "0x1868C8200")]
		internal object KLNBJNJCOEH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class JACMGGLDPAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public Task<IKPHFCIJHCC> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public JACMGGLDPAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7C35E0", Offset = "0x7C25E0", VA = "0x1807C35E0")]
		internal Task<IKPHFCIJHCC> DDDJEGKMOML(NENCAGLHEIB<string>.OGJMFKKDMDA _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct HEFDNAICNID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public NLHCDNFKJFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public BPINABCIEKB targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public HLHBCDCELMH customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public CKGLENOBMMP joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private JACMGGLDPAC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private HDMJGNJENFH <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private BEAMBDPEGJL <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private BEIPFBBPOOO <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private Task<Matchmaking.KKHFKLCNFNC> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private MJEJKJGKHCO <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private int <i>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private TaskAwaiter<Matchmaking.KKHFKLCNFNC> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private TaskAwaiter<IKPHFCIJHCC> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x68CBE40", Offset = "0x68CAE40", VA = "0x1868CBE40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x68D1000", Offset = "0x68D0000", VA = "0x1868D1000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct PMBIPFNAPAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public NLHCDNFKJFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private BEAMBDPEGJL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x68DD430", Offset = "0x68DC430", VA = "0x1868DD430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x68DDE80", Offset = "0x68DCE80", VA = "0x1868DDE80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct GCPMEHBIEKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public NLHCDNFKJFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private OIEDECFCIPC <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x68C82B0", Offset = "0x68C72B0", VA = "0x1868C82B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x68C8730", Offset = "0x68C7730", VA = "0x1868C8730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct CGBCKCPKHBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public AsyncTaskMethodBuilder<Matchmaking.KKHFKLCNFNC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public BPINABCIEKB targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public NLHCDNFKJFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private TaskAwaiter<Matchmaking.KKHFKLCNFNC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x68C3490", Offset = "0x68C2490", VA = "0x1868C3490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x68C3990", Offset = "0x68C2990", VA = "0x1868C3990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct MDGLCMKKCAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public Matchmaking.KKHFKLCNFNC serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public NLHCDNFKJFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public CKGLENOBMMP joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private BEAMBDPEGJL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private TaskAwaiter<BKJFOMGPGJD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x68D5820", Offset = "0x68D4820", VA = "0x1868D5820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x68D5F20", Offset = "0x68D4F20", VA = "0x1868D5F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class HHCHOPGPHKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public BPINABCIEKB targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public HHCHOPGPHKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x68D1160", Offset = "0x68D0160", VA = "0x1868D1160")]
		internal object EJGFIDNDBBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x68D1060", Offset = "0x68D0060", VA = "0x1868D1060")]
		internal string CLGEDFHGJNG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct FANAGAOOKMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public BPINABCIEKB targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public NLHCDNFKJFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private HHCHOPGPHKK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private BEAMBDPEGJL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x68C7020", Offset = "0x68C6020", VA = "0x1868C7020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x68C7BF0", Offset = "0x68C6BF0", VA = "0x1868C7BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct DENNDOFDNAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public NLHCDNFKJFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public CKGLENOBMMP joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public IKPHFCIJHCC initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public BPINABCIEKB targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public HDMJGNJENFH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x68C5210", Offset = "0x68C4210", VA = "0x1868C5210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x68C5B20", Offset = "0x68C4B20", VA = "0x1868C5B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct GMPMBGALAMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public NLHCDNFKJFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private BEAMBDPEGJL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private CancellationTokenSource <timeoutTcs>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private CancellationToken <timeoutToken>5__7;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x68C9B30", Offset = "0x68C8B30", VA = "0x1868C9B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x68CB170", Offset = "0x68CA170", VA = "0x1868CB170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct LPCLOHIMIOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public DJJMNPKHNKF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public NLHCDNFKJFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private BEAMBDPEGJL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private TaskAwaiter<IDAKKNHINME> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x68D4E20", Offset = "0x68D3E20", VA = "0x1868D4E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x68D55E0", Offset = "0x68D45E0", VA = "0x1868D55E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class BABJIBJDPHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public BPINABCIEKB targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public BABJIBJDPHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x68C2410", Offset = "0x68C1410", VA = "0x1868C2410")]
		internal object DFGOKJBMBBA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class COKOPCKANLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public COKOPCKANLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x68C4AB0", Offset = "0x68C3AB0", VA = "0x1868C4AB0")]
		internal void PBHCLONEMML()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class CBLIEFBFGJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public BPINABCIEKB targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public CBLIEFBFGJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x68C3410", Offset = "0x68C2410", VA = "0x1868C3410")]
		internal object DLEACFCICEE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class FGNLBAFIANO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public BPINABCIEKB targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public FGNLBAFIANO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x68C7C50", Offset = "0x68C6C50", VA = "0x1868C7C50")]
		internal string LKMFOHKEMFM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly NDLEKAMCBHL LAGKGKDNMJM;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly NDLEKAMCBHL MONGEPNLKCO;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly NDLEKAMCBHL ACLDLJIIOKO;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly NDLEKAMCBHL INCEBJBHCJI;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly string GCDJGFHABCG;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly string LKIFBPIEJHG;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static readonly string HHJPDCJJCNI;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static readonly Guid NNBBMBDEGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private AAGLIDGLEOO LGAJGGNOGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private OJNGFMPHCML PAGLFNPNHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private MIMGKGBGIEK GMFPLFAACJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private IONKJBLKHOH CPMFHDAOGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private DBOAJANNPMM AKJKFGAFELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private MPIFKJJNNCE APEEPNLANJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private NALENELDDPM AFEDNGDPKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private KFPLCDDLLIA APPFGNMDKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private GKMPPDACLNH PKDJBMMFNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private EEFHHNDIGNE DJGJABHDKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private IDisposable APCJDKICAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly PIOKGJKNCFA CEBAAIJMEIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly PIOKGJKNCFA DNMHDCOIEPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private MJEJKJGKHCO FMFLDGEHFIP;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public TaskStatus LNGEPDDOPMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xAE6B10", Offset = "0xAE5B10", VA = "0x180AE6B10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0xB35AB0", Offset = "0xB34AB0", VA = "0x180B35AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private LJGNJILFANM DDLGOMBBCHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x68D9DC0", Offset = "0x68D8DC0", VA = "0x1868D9DC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x68D7910", Offset = "0x68D6910", VA = "0x1868D7910", Slot = "6")]
	public void CJMKLAKCCOG(IONKJBLKHOH CPMFHDAOGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x68D7F50", Offset = "0x68D6F50", VA = "0x1868D7F50", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x68D7FA0", Offset = "0x68D6FA0", VA = "0x1868D7FA0", Slot = "5")]
	[AsyncStateMachine(typeof(GFAFIMLJNNN))]
	public Task EFDGJJHEHPL(BPINABCIEKB DLJENKKADJN, HLHBCDCELMH MLCGPPAAJFP, CancellationToken ICHNHGHOBPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x68D92F0", Offset = "0x68D82F0", VA = "0x1868D92F0")]
	[AsyncStateMachine(typeof(OKCPGPLOJCL))]
	private Task JCCKMEIHJOD(BPINABCIEKB DLJENKKADJN, HLHBCDCELMH MLCGPPAAJFP, CancellationToken ICHNHGHOBPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x68D9670", Offset = "0x68D8670", VA = "0x1868D9670")]
	private static void KBPLMOGKFHC(GKMPPDACLNH PKDJBMMFNAF, BPINABCIEKB DLJENKKADJN, Exception DNFOGIGBCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x68D8970", Offset = "0x68D7970", VA = "0x1868D8970")]
	private static void GJGLKJPIEFG(GAMJODHLBNI GKANBDHJGBB, Exception DNFOGIGBCCD, [Optional] List<int> DEBNLIIIOCK, int LLGAIKDIMCM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x68D77B0", Offset = "0x68D67B0", VA = "0x1868D77B0")]
	[AsyncStateMachine(typeof(HEFDNAICNID))]
	private Task CJFBBIMFFOL(NENCAGLHEIB<string>.OGJMFKKDMDA OCBBLMCOHCB, BPINABCIEKB DLJENKKADJN, HLHBCDCELMH MLCGPPAAJFP, CKGLENOBMMP COHHLKNPIPE, CancellationToken ICHNHGHOBPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x68D7660", Offset = "0x68D6660", VA = "0x1868D7660")]
	private void CDPMCOPOOCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x68D9F50", Offset = "0x68D8F50", VA = "0x1868D9F50")]
	[AsyncStateMachine(typeof(PMBIPFNAPAJ))]
	private Task MBNOHEABGPA(NENCAGLHEIB<string>.OGJMFKKDMDA OCBBLMCOHCB, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x68D7330", Offset = "0x68D6330", VA = "0x1868D7330")]
	private void BDCMOFNFIDM(BPINABCIEKB DLJENKKADJN, CancellationToken ICHNHGHOBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x68D9440", Offset = "0x68D8440", VA = "0x1868D9440")]
	private void JINOIIMMCJD(BPINABCIEKB DLJENKKADJN, CKGLENOBMMP COHHLKNPIPE, OperationCanceledException ADMIKHHADLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x68D80E0", Offset = "0x68D70E0", VA = "0x1868D80E0")]
	private void EJBDNCCLDJI(BPINABCIEKB DLJENKKADJN, CKGLENOBMMP COHHLKNPIPE, Exception DNFOGIGBCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x68D8760", Offset = "0x68D7760", VA = "0x1868D8760")]
	private void GHEMDBEDCHL(BPINABCIEKB DLJENKKADJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x68DA1B0", Offset = "0x68D91B0", VA = "0x1868DA1B0")]
	private static LDBJDOIIBIB NHDIPDGFNIB(BPINABCIEKB DLJENKKADJN)
	{
		return default(LDBJDOIIBIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x68D8310", Offset = "0x68D7310", VA = "0x1868D8310")]
	[AsyncStateMachine(typeof(GCPMEHBIEKH))]
	private Task FCOBGLHLKLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x68D8500", Offset = "0x68D7500", VA = "0x1868D8500")]
	[AsyncStateMachine(typeof(CGBCKCPKHBB))]
	private Task<Matchmaking.KKHFKLCNFNC> FEAAOLIAJCH(BPINABCIEKB DLJENKKADJN, NENCAGLHEIB<string>.OGJMFKKDMDA OCBBLMCOHCB, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x68DA210", Offset = "0x68D9210", VA = "0x1868DA210")]
	private static BKJFOMGPGJD OHEOAAMAHNA(Matchmaking.KKHFKLCNFNC PHADIGEGDFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x68D9BE0", Offset = "0x68D8BE0", VA = "0x1868D9BE0")]
	[AsyncStateMachine(typeof(MDGLCMKKCAI))]
	private Task KJFEMMAMDLG(Matchmaking.KKHFKLCNFNC PHADIGEGDFI, CKGLENOBMMP COHHLKNPIPE, NENCAGLHEIB<string>.OGJMFKKDMDA OCBBLMCOHCB, CancellationToken MDHGKEDAODJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x68D9E10", Offset = "0x68D8E10", VA = "0x1868D9E10")]
	[AsyncStateMachine(typeof(FANAGAOOKMH))]
	private Task LFNPMCNGHID(BPINABCIEKB DLJENKKADJN, CancellationTokenSource AFODDMBHLJH, Task HHBMDPHAIBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x68D6E30", Offset = "0x68D5E30", VA = "0x1868D6E30")]
	[AsyncStateMachine(typeof(DENNDOFDNAC))]
	private Task ABNALGOFANC(IKPHFCIJHCC HHGMNMHGNBL, HDMJGNJENFH CPGMMJFAHHO, BPINABCIEKB NIBGGAFEIHJ, CKGLENOBMMP IDHPFCJOMID, NENCAGLHEIB<string>.OGJMFKKDMDA OCBBLMCOHCB, CancellationToken LINNAMEOMLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x68D7030", Offset = "0x68D6030", VA = "0x1868D7030")]
	private CKGLENOBMMP AMPDNCDLOBO(CKGLENOBMMP IDHPFCJOMID, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x68DA080", Offset = "0x68D9080", VA = "0x1868DA080")]
	[AsyncStateMachine(typeof(GMPMBGALAMB))]
	private Task MKGFPJCOFBP(NENCAGLHEIB<string>.OGJMFKKDMDA OCBBLMCOHCB, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x68D83E0", Offset = "0x68D73E0", VA = "0x1868D83E0")]
	[AsyncStateMachine(typeof(LPCLOHIMIOC))]
	private Task FDLAMMMMOAF(DJJMNPKHNKF GPKMLHOONCL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x68D7DD0", Offset = "0x68D6DD0", VA = "0x1868D7DD0")]
	private static void DOHOLPGOLGM(BPINABCIEKB DLJENKKADJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x68DA410", Offset = "0x68D9410", VA = "0x1868DA410")]
	private void ONANKENLCJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x68D9260", Offset = "0x68D8260", VA = "0x1868D9260")]
	private void IBEGHOEEEEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x68D6FA0", Offset = "0x68D5FA0", VA = "0x1868D6FA0")]
	private void ACGJCJCJIIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x68D9D30", Offset = "0x68D8D30", VA = "0x1868D9D30")]
	private void LDPGHGPHNJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x68DA320", Offset = "0x68D9320", VA = "0x1868DA320")]
	private static void OINFOLNDMJO(BPINABCIEKB DLJENKKADJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x68D7220", Offset = "0x68D6220", VA = "0x1868D7220")]
	private static CancellationTokenRegistration ANLJOEPDLFK(BPINABCIEKB DLJENKKADJN, CancellationToken MDHGKEDAODJ)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x68D8660", Offset = "0x68D7660", VA = "0x1868D8660")]
	private static void FLOBPOEEOCA(BPINABCIEKB DLJENKKADJN, Exception DNFOGIGBCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x68D9A30", Offset = "0x68D8A30", VA = "0x1868D9A30")]
	private void KDFABHCAIMG(BPINABCIEKB DLJENKKADJN, Task HHBMDPHAIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x68D9200", Offset = "0x68D8200", VA = "0x1868D9200")]
	private static void HEFADAFEBPD(Func<string> EGLDLFJKHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x68DA860", Offset = "0x68D9860", VA = "0x1868DA860")]
	public NLHCDNFKJFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x68DA5E0", Offset = "0x68D95E0", VA = "0x1868DA5E0")]
	[CompilerGenerated]
	internal static (int, int?) PKFMAFFFKDB(MAPGHKPFHLD GOHOCIPCMMC)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[RecRoom.NoEngine.Common.Preserve]
internal class OCFKIOIBCJC : PFHGGCAIBEH, IHLALIKNOCJ, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private struct AHPCGLMHMJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public OCFKIOIBCJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public DJJMNPKHNKF roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x68E15C0", Offset = "0x68E05C0", VA = "0x1868E15C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x68E1980", Offset = "0x68E0980", VA = "0x1868E1980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class OPHPOPLCOKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public OCFKIOIBCJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public DJJMNPKHNKF roomData;

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public OPHPOPLCOKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x68FE2A0", Offset = "0x68FD2A0", VA = "0x1868FE2A0")]
		internal List<Task> JNFGHBOJIFN(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct JHDCKDHOEIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public OLEFILIJHIM taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public DJJMNPKHNKF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private BEAMBDPEGJL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x68F25B0", Offset = "0x68F15B0", VA = "0x1868F25B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x68F2940", Offset = "0x68F1940", VA = "0x1868F2940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct LMGCCKDEAKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public OCFKIOIBCJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x68F7490", Offset = "0x68F6490", VA = "0x1868F7490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x68F7750", Offset = "0x68F6750", VA = "0x1868F7750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private readonly HashSet<OLEFILIJHIM> IOHCBHDPDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private OJNGFMPHCML PAGLFNPNHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private IONKJBLKHOH CPMFHDAOGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private ELIEAEEOHNL NPKFLENMIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private HCFIPKNNBJL IDCJBPNNBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private IDisposable APCJDKICAOC;

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x68DABA0", Offset = "0x68D9BA0", VA = "0x1868DABA0", Slot = "5")]
	public void CJMKLAKCCOG(IONKJBLKHOH CPMFHDAOGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x68DAE20", Offset = "0x68D9E20", VA = "0x1868DAE20", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x68DB550", Offset = "0x68DA550", VA = "0x1868DB550", Slot = "4")]
	public bool KGNAHPPFIDN(OLEFILIJHIM LHIPCPBAIDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x68DAE80", Offset = "0x68D9E80", VA = "0x1868DAE80")]
	private void FNKCNMDEPAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x68DB5B0", Offset = "0x68DA5B0", VA = "0x1868DB5B0")]
	private void MPOFEHFGOKJ(DJJMNPKHNKF LAOLHNNNLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x68DA9E0", Offset = "0x68D99E0", VA = "0x1868DA9E0")]
	[AsyncStateMachine(typeof(AHPCGLMHMJI))]
	private Task ANEIAGDGKIJ(DJJMNPKHNKF LAOLHNNNLCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x68DAAD0", Offset = "0x68D9AD0", VA = "0x1868DAAD0")]
	private Func<CancellationToken, List<Task>> BGLNDOACNIO(DJJMNPKHNKF LAOLHNNNLCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x68DB100", Offset = "0x68DA100", VA = "0x1868DB100")]
	private List<Task> JBOAEGAEKPG(DJJMNPKHNKF LAOLHNNNLCH, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x68DB790", Offset = "0x68DA790", VA = "0x1868DB790")]
	[AsyncStateMachine(typeof(JHDCKDHOEIK))]
	private Task PDNONKMKOPL(OLEFILIJHIM JKBOPINACMD, DJJMNPKHNKF GPKMLHOONCL, CancellationToken KONODCHOCOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x68DAFB0", Offset = "0x68D9FB0", VA = "0x1868DAFB0")]
	[AsyncStateMachine(typeof(LMGCCKDEAKB))]
	private Task GIHKACEPLOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x68DB080", Offset = "0x68DA080", VA = "0x1868DB080")]
	private void IKNLGAIIHPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x68DB8B0", Offset = "0x68DA8B0", VA = "0x1868DB8B0")]
	public OCFKIOIBCJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[UnityEngine.Scripting.Preserve]
internal sealed class BLPNOPIBGMF : PJJEMCJDJMB, IHLALIKNOCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class GCHIFMCGPGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public GCHIFMCGPGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x68EAC40", Offset = "0x68E9C40", VA = "0x1868EAC40")]
		internal object AMHBBJCEIPO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class OINJAKIBANC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public OINJAKIBANC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x68FD1C0", Offset = "0x68FC1C0", VA = "0x1868FD1C0")]
		internal object NCOIPPJJPEH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class GFPHEDAHOJB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public GFPHEDAHOJB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class NHJMKGNALPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public NHJMKGNALPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x68FC130", Offset = "0x68FB130", VA = "0x1868FC130")]
		internal object EGIGEHNNAEB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class EAELAAOLDHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public EAELAAOLDHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x68E9B50", Offset = "0x68E8B50", VA = "0x1868E9B50")]
		internal object INIEEKMDADH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private readonly Dictionary<Guid, AOMFDFIPIIG> PNNDKKIMKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private readonly TimeSpan BLJDMCBINFH;

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "9")]
	public void CJMKLAKCCOG(IONKJBLKHOH CPMFHDAOGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x68E2CE0", Offset = "0x68E1CE0", VA = "0x1868E2CE0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x68E2AC0", Offset = "0x68E1AC0", VA = "0x1868E2AC0", Slot = "4")]
	public BOEFKPHLFDF BGLDHBEBEIE(Guid IDKMDFCBEHN)
	{
		return default(BOEFKPHLFDF);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x68E32C0", Offset = "0x68E22C0", VA = "0x1868E32C0", Slot = "5")]
	public bool NCLCGNJGAKA(Guid IDKMDFCBEHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x68E2D60", Offset = "0x68E1D60", VA = "0x1868E2D60", Slot = "6")]
	public bool FNJHMPBDCLD(Guid IDKMDFCBEHN, Task FMLJIOMNMBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x68E28E0", Offset = "0x68E18E0", VA = "0x1868E28E0", Slot = "7")]
	public bool ACBGBEOCANJ(Guid IDKMDFCBEHN, IDAKKNHINME PJNPPONDPNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x68E2CF0", Offset = "0x68E1CF0", VA = "0x1868E2CF0", Slot = "8")]
	public Task<(IDAKKNHINME, Task)> ELICDCFOCED(Guid IDKMDFCBEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x68E3090", Offset = "0x68E2090", VA = "0x1868E3090")]
	private void LJKMJJIBDKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x68E34D0", Offset = "0x68E24D0", VA = "0x1868E34D0")]
	public BLPNOPIBGMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[RecRoom.NoEngine.Common.Preserve]
internal class CJNPIODOMDB : FJOFDOAOJCA, IHLALIKNOCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private class GNHDGJPJLEM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private readonly BPINABCIEKB PEMPBFOENGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private readonly CancellationTokenSource EILAHEEOMFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public readonly CancellationToken NIOCJKBAALO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private bool KANGFEIAIBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private bool OBBFCMJHMOD;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x68ED640", Offset = "0x68EC640", VA = "0x1868ED640")]
		public GNHDGJPJLEM(BPINABCIEKB PEMPBFOENGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x68ED4F0", Offset = "0x68EC4F0", VA = "0x1868ED4F0")]
		public void IKNLGAIIHPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x68ED4C0", Offset = "0x68EC4C0", VA = "0x1868ED4C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class LIODKOPKLHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public JCFJBKDHGNN disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public LIODKOPKLHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x68F6E10", Offset = "0x68F5E10", VA = "0x1868F6E10")]
		internal object EBLNHCKFHAH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct LPKEAHMPCDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public JCFJBKDHGNN disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public CJNPIODOMDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private BEAMBDPEGJL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x68F96E0", Offset = "0x68F86E0", VA = "0x1868F96E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x68F9A90", Offset = "0x68F8A90", VA = "0x1868F9A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class IMDEODLINPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public IMDEODLINPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x68F17C0", Offset = "0x68F07C0", VA = "0x1868F17C0")]
		internal object MOBBLLHILDF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct MAHENPFHAGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public CJNPIODOMDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private BEAMBDPEGJL <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x68F9AF0", Offset = "0x68F8AF0", VA = "0x1868F9AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x8A9220", Offset = "0x8A8220", VA = "0x1808A9220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class ICAKCHGJFJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public BPINABCIEKB newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public ICAKCHGJFJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x68EFE50", Offset = "0x68EEE50", VA = "0x1868EFE50")]
		internal object AICOBCNEGNB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x68EFF30", Offset = "0x68EEF30", VA = "0x1868EFF30")]
		internal object JLLICPMFPBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x68EFEF0", Offset = "0x68EEEF0", VA = "0x1868EFEF0")]
		internal object DMGMKLFILDI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class PIPEEJKBICP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public PIPEEJKBICP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x68FE410", Offset = "0x68FD410", VA = "0x1868FE410")]
		internal void AEFPIEJMHEA()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private struct HPLDECCPCPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public BPINABCIEKB newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public CJNPIODOMDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public HLHBCDCELMH customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private ICAKCHGJFJA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private BEAMBDPEGJL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private CancellationTokenRegistration <_>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x68EE900", Offset = "0x68ED900", VA = "0x1868EE900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x68EF880", Offset = "0x68EE880", VA = "0x1868EF880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly NDLEKAMCBHL LAGKGKDNMJM;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly JIFNFLENMDJ.LIMBAIDANHC HBMFDJJCOJC;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly BCNJPGKAJGJ PEECGPHEDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private OJNGFMPHCML PAGLFNPNHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private IONKJBLKHOH CPMFHDAOGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private MPIFKJJNNCE APEEPNLANJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private DBOAJANNPMM AKJKFGAFELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private OIMHDJADCNF MOBEOAJIGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private NJKCLBHBFPO COIBKFDENBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private long DBAOBPPDNAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private GNHDGJPJLEM AHIBKFPMMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private bool IKKJFOOKHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private Task OPKIOHBKBBA;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	private LJGNJILFANM DDLGOMBBCHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x68E43B0", Offset = "0x68E33B0", VA = "0x1868E43B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool AAHNJNKLOEM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x1099780", Offset = "0x1098780", VA = "0x181099780")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x68E3AC0", Offset = "0x68E2AC0", VA = "0x1868E3AC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x68E3820", Offset = "0x68E2820", VA = "0x1868E3820", Slot = "4")]
	public void CJMKLAKCCOG(IONKJBLKHOH CPMFHDAOGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x68E3AD0", Offset = "0x68E2AD0", VA = "0x1868E3AD0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x68E4010", Offset = "0x68E3010", VA = "0x1868E4010")]
	[AsyncStateMachine(typeof(LPKEAHMPCDJ))]
	private Task HDDNCIHOIHD(JCFJBKDHGNN DAMEJDGGGAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x68E4450", Offset = "0x68E3450", VA = "0x1868E4450")]
	private void PDNPLALHDEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x68E3E80", Offset = "0x68E2E80", VA = "0x1868E3E80")]
	private void GLHMMIJFOEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x68E4100", Offset = "0x68E3100", VA = "0x1868E4100")]
	private void HJJNKAHGIMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x68E3C40", Offset = "0x68E2C40", VA = "0x1868E3C40")]
	private bool FELLPIBLBDN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x68E3DB0", Offset = "0x68E2DB0", VA = "0x1868E3DB0")]
	[AsyncStateMachine(typeof(MAHENPFHAGI))]
	private void GEAOKEGHFFL(int PGMBNNJMIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x68E3590", Offset = "0x68E2590", VA = "0x1868E3590")]
	private void BFEDGNEONBF([Out] IDisposable GINCJOJMAMF, [Out] IDisposable NFIKHKKFIKG, [Out] IDisposable LMIPBAHFLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x68E3CB0", Offset = "0x68E2CB0", VA = "0x1868E3CB0")]
	private bool FJCMMNIPCOG(BPINABCIEKB PEMPBFOENGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x68E4400", Offset = "0x68E3400", VA = "0x1868E4400")]
	private void ONIPOCGEBMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x68E4280", Offset = "0x68E3280", VA = "0x1868E4280")]
	[AsyncStateMachine(typeof(HPLDECCPCPM))]
	private Task JCCKMEIHJOD(BPINABCIEKB PEMPBFOENGN, HLHBCDCELMH MLCGPPAAJFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x68E49C0", Offset = "0x68E39C0", VA = "0x1868E49C0")]
	public CJNPIODOMDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[UnityEngine.Scripting.Preserve]
internal sealed class DCNOBFOFNPL : GOBDPIDFCMO, IHLALIKNOCJ, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private struct DPMJBFHCNIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public AsyncTaskMethodBuilder<AMLKNBEIKDJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public DCNOBFOFNPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private TaskAwaiter<AMLKNBEIKDJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x68E9850", Offset = "0x68E8850", VA = "0x1868E9850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x68E9AE0", Offset = "0x68E8AE0", VA = "0x1868E9AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class IFEJADLKOOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public GCHMLLGGJOI message;

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public IFEJADLKOOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x68F0D40", Offset = "0x68EFD40", VA = "0x1868F0D40")]
		internal object PBMOLHJNEPD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class HNCKKKGHHJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public GCHMLLGGJOI messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public HNCKKKGHHJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x68EE8A0", Offset = "0x68ED8A0", VA = "0x1868EE8A0")]
		internal object OHEABPKLDEC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class GMKNABPDLFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public GCHMLLGGJOI request;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public GMKNABPDLFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x68ECDE0", Offset = "0x68EBDE0", VA = "0x1868ECDE0")]
		internal object KIPLJGOGJLN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct BBOKKPACFPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public GCHMLLGGJOI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public DCNOBFOFNPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private BEAMBDPEGJL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private TaskAwaiter<NINLEEMOEAG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x68E1B20", Offset = "0x68E0B20", VA = "0x1868E1B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x68E23E0", Offset = "0x68E13E0", VA = "0x1868E23E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class ABFCJPCMJKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public GCHMLLGGJOI operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public ABFCJPCMJKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x68E0DC0", Offset = "0x68DFDC0", VA = "0x1868E0DC0")]
		internal object MIFMOCLOAPH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct COEKHPHGJNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public GCHMLLGGJOI operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public DCNOBFOFNPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private BEAMBDPEGJL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private CKGLENOBMMP <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private TaskAwaiter<GCHMLLGGJOI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x68E4A90", Offset = "0x68E3A90", VA = "0x1868E4A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x68E5600", Offset = "0x68E4600", VA = "0x1868E5600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct DNLGHMDILAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public AsyncTaskMethodBuilder<NINLEEMOEAG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public DCNOBFOFNPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public GCHMLLGGJOI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private EIIGNJLBDIG.PBFNMBIEPKK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private CKGLENOBMMP <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private TaskAwaiter<GCHMLLGGJOI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x68E92C0", Offset = "0x68E82C0", VA = "0x1868E92C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x68E97E0", Offset = "0x68E87E0", VA = "0x1868E97E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class HLEGFNCEBAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public NINLEEMOEAG operation;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public HLEGFNCEBAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x68EE820", Offset = "0x68ED820", VA = "0x1868EE820")]
		internal object DFBIADBKINN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private struct GELGFCNJHOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public NINLEEMOEAG operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public DCNOBFOFNPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private BEAMBDPEGJL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private NENCAGLHEIB<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x68EACA0", Offset = "0x68E9CA0", VA = "0x1868EACA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x68EB2E0", Offset = "0x68EA2E0", VA = "0x1868EB2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class MKNJNCCCFOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public GCHMLLGGJOI request;

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public MKNJNCCCFOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x68FAD60", Offset = "0x68F9D60", VA = "0x1868FAD60")]
		internal object DBMDOCMBFGI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class NODLGMNIAHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public GCHMLLGGJOI request;

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public NODLGMNIAHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x68FC610", Offset = "0x68FB610", VA = "0x1868FC610")]
		internal object DHECPKCDOEA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private IONKJBLKHOH CPMFHDAOGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private NALENELDDPM AFEDNGDPKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private PFLFLIOMLNP DPCGBNDFMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private NODFFFGJLKO PCFKDKOIMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private MIMGKGBGIEK GMFPLFAACJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private TaskCompletionSource<AMLKNBEIKDJ> IFJGDAHMNCE;

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x68E6380", Offset = "0x68E5380", VA = "0x1868E6380", Slot = "7")]
	public void CJMKLAKCCOG(IONKJBLKHOH CPMFHDAOGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x68E6950", Offset = "0x68E5950", VA = "0x1868E6950", Slot = "6")]
	[AsyncStateMachine(typeof(DPMJBFHCNIL))]
	public Task<AMLKNBEIKDJ> GBJBBEMLOFE(CancellationToken IOEMDKJLEKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x68E65C0", Offset = "0x68E55C0", VA = "0x1868E65C0", Slot = "4")]
	public void DKLPNKJBBJM(GCHMLLGGJOI JJJNODJJIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x68E6C00", Offset = "0x68E5C00", VA = "0x1868E6C00", Slot = "5")]
	public void ODCHEKJGBBB(GCHMLLGGJOI ABKEIICCLNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x68E6060", Offset = "0x68E5060", VA = "0x1868E6060")]
	[AsyncStateMachine(typeof(BBOKKPACFPI))]
	private Task BGGDFMHGKCE(GCHMLLGGJOI MJJCOLDOFAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x68E6A60", Offset = "0x68E5A60", VA = "0x1868E6A60")]
	[AsyncStateMachine(typeof(COEKHPHGJNL))]
	private Task GHFPNKNOMID(GCHMLLGGJOI BOJHMLOHLFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x68E6470", Offset = "0x68E5470", VA = "0x1868E6470")]
	[AsyncStateMachine(typeof(DNLGHMDILAK))]
	private Task<NINLEEMOEAG> DCEFIGDPPII(GCHMLLGGJOI MJJCOLDOFAC, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x68E6B70", Offset = "0x68E5B70", VA = "0x1868E6B70")]
	private CKGLENOBMMP OBMCCGDFGIF(GCHMLLGGJOI EJMANJACCLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x68E6F60", Offset = "0x68E5F60", VA = "0x1868E6F60")]
	[AsyncStateMachine(typeof(GELGFCNJHOO))]
	private Task OEIKINPDDHH(NINLEEMOEAG LNPIDFLJKCD, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x68E6170", Offset = "0x68E5170", VA = "0x1868E6170")]
	private NINLEEMOEAG CEPIMCBJFKH(GCHMLLGGJOI MJJCOLDOFAC, CKGLENOBMMP LAAALIMMANK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x273FD50", Offset = "0x273ED50", VA = "0x18273FD50")]
	private T KDKHILLECBA<T>(T LDGMLLMKHLF) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x68E5CD0", Offset = "0x68E4CD0", VA = "0x1868E5CD0")]
	private NINLEEMOEAG AGEOIGMDNMC(GCHMLLGGJOI MJJCOLDOFAC, CKGLENOBMMP LAAALIMMANK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public DCNOBFOFNPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[UnityEngine.Scripting.Preserve]
internal sealed class DNHPKDEEKOD : PFLFLIOMLNP, IHLALIKNOCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class HFHDAJCFBKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public HFHDAJCFBKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x68ED9B0", Offset = "0x68EC9B0", VA = "0x1868ED9B0")]
		internal object LCOPOFCPFAE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class MLPOANLBOIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public MLPOANLBOIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x68FADC0", Offset = "0x68F9DC0", VA = "0x1868FADC0")]
		internal object ICNJFNNIJGC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private MIMGKGBGIEK GMFPLFAACJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private POKMPJKENIC PDPBLEDPOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private GOBDPIDFCMO ALEKDKNEGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private PJJEMCJDJMB PNNDKKIMKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private KBLPGEAPGFP PCAJJOEGMGK;

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x68E74C0", Offset = "0x68E64C0", VA = "0x1868E74C0", Slot = "6")]
	public void CJMKLAKCCOG(IONKJBLKHOH CPMFHDAOGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x68E7870", Offset = "0x68E6870", VA = "0x1868E7870", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x68E7C30", Offset = "0x68E6C30", VA = "0x1868E7C30", Slot = "4")]
	public BOEFKPHLFDF IHMNHACJEKJ(GCHMLLGGJOI PHJPIBONLOO)
	{
		return default(BOEFKPHLFDF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x68E8790", Offset = "0x68E7790", VA = "0x1868E8790", Slot = "5")]
	public void NJOGIFIODMP(Guid IDKMDFCBEHN, Task FMLJIOMNMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x68E8F40", Offset = "0x68E7F40", VA = "0x1868E8F40")]
	private void OHKMFCPHCAK(byte PCFDAINLDCD, int JHPCJGNGKKC, object PPPLBKGCLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x68E89A0", Offset = "0x68E79A0", VA = "0x1868E89A0")]
	private void OHFMKGNBKAC(INHAJCFKIEO LPDEFAPJANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x68E7920", Offset = "0x68E6920", VA = "0x1868E7920")]
	private void GEEPJHGBOIO(INHAJCFKIEO LPDEFAPJANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x68E7280", Offset = "0x68E6280", VA = "0x1868E7280")]
	private void AMCHAIBCFJL(INHAJCFKIEO LPDEFAPJANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x68E7630", Offset = "0x68E6630", VA = "0x1868E7630")]
	private IDAKKNHINME DBABOJMEMOJ(GCHMLLGGJOI EJMANJACCLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x68E8070", Offset = "0x68E7070", VA = "0x1868E8070")]
	private void INNEOKJOPNH(GCHMLLGGJOI BOJHMLOHLFG, IDAKKNHINME PJNPPONDPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x68E9010", Offset = "0x68E8010", VA = "0x1868E9010")]
	private bool OMGNAHICNLB(GCHMLLGGJOI BOJHMLOHLFG, IDAKKNHINME PJNPPONDPNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x68E8280", Offset = "0x68E7280", VA = "0x1868E8280")]
	private bool LPKOPLLKMIB(GCHMLLGGJOI MAFNGFBEIEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x68E8500", Offset = "0x68E7500", VA = "0x1868E8500")]
	private bool NGCHFLFKKPB(byte PCFDAINLDCD, ExitGames.Client.Photon.Hashtable LPDEFAPJANH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public DNHPKDEEKOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[UnityEngine.Scripting.Preserve]
internal sealed class HFJFJLDPPIO : LDNGFBNBCGF, IHLALIKNOCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class OOKBPGGGIHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public AMLKNBEIKDJ operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public HFJFJLDPPIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public GCHMLLGGJOI roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public OOKBPGGGIHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x68FE230", Offset = "0x68FD230", VA = "0x1868FE230")]
		internal object LGBADFCMEAG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x68FE100", Offset = "0x68FD100", VA = "0x1868FE100")]
		internal object FDPINICMAGA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct LEKCFKPMHNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public AsyncTaskMethodBuilder<IDAKKNHINME> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public HFJFJLDPPIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public GCHMLLGGJOI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private BEAMBDPEGJL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private TaskAwaiter<IDAKKNHINME> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x68F5970", Offset = "0x68F4970", VA = "0x1868F5970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x68F6000", Offset = "0x68F5000", VA = "0x1868F6000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class OCELMBOAENJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public AMLKNBEIKDJ operationType;

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public OCELMBOAENJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x68FD150", Offset = "0x68FC150", VA = "0x1868FD150")]
		internal object BFMIPODLMIP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class HHCBMAOMFAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public GCHMLLGGJOI request;

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public HHCBMAOMFAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x68EDF90", Offset = "0x68ECF90", VA = "0x1868EDF90")]
		internal object BAJFLNODINC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x68EDF20", Offset = "0x68ECF20", VA = "0x1868EDF20")]
		internal object AHBONGKFIKL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x68EE000", Offset = "0x68ED000", VA = "0x1868EE000")]
		internal object HKDNFDFLGFA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private struct ONNLCPIGALJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public AsyncTaskMethodBuilder<IDAKKNHINME> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public GCHMLLGGJOI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public HFJFJLDPPIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private HHCBMAOMFAP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private BEAMBDPEGJL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private BOEFKPHLFDF <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private IDAKKNHINME <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private TaskAwaiter<(IDAKKNHINME validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x68FD220", Offset = "0x68FC220", VA = "0x1868FD220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x68FDAD0", Offset = "0x68FCAD0", VA = "0x1868FDAD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private MIMGKGBGIEK GMFPLFAACJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private POKMPJKENIC PDPBLEDPOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private PFLFLIOMLNP DPCGBNDFMNH;

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x68EDA20", Offset = "0x68ECA20", VA = "0x1868EDA20", Slot = "5")]
	public void CJMKLAKCCOG(IONKJBLKHOH CPMFHDAOGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x68EDE00", Offset = "0x68ECE00", VA = "0x1868EDE00", Slot = "4")]
	[AsyncStateMachine(typeof(LEKCFKPMHNP))]
	private Task<IDAKKNHINME> OANBJGMHFKD(GCHMLLGGJOI EJMANJACCLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x68EDAD0", Offset = "0x68ECAD0", VA = "0x1868EDAD0")]
	private bool JPGINJABGBM(AMLKNBEIKDJ BLOFAJKGCBC, [Out] IDAKKNHINME NIKEINPNLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x68EDCC0", Offset = "0x68ECCC0", VA = "0x1868EDCC0")]
	[AsyncStateMachine(typeof(ONNLCPIGALJ))]
	private Task<IDAKKNHINME> KJBLGLHGECB(GCHMLLGGJOI MJJCOLDOFAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public HFJFJLDPPIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class IDNKNONLJIC : HJJCDKOEFMD, IHLALIKNOCJ, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private struct OAOODDDGIAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public AsyncTaskMethodBuilder<IKPHFCIJHCC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public BPINABCIEKB targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public IDNKNONLJIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private TaskAwaiter<KPBKEDCLNDD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x68FCC30", Offset = "0x68FBC30", VA = "0x1868FCC30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x68FD0E0", Offset = "0x68FC0E0", VA = "0x1868FD0E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class EHBGJOBAICE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public EHBGJOBAICE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x68E9C20", Offset = "0x68E8C20", VA = "0x1868E9C20")]
		internal object NNAAAEJNJNA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private struct GKNPLKEDLJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public AsyncTaskMethodBuilder<KPBKEDCLNDD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public IDNKNONLJIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public BPINABCIEKB targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private EHBGJOBAICE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter<KPBKEDCLNDD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x68EC000", Offset = "0x68EB000", VA = "0x1868EC000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x68EC5F0", Offset = "0x68EB5F0", VA = "0x1868EC5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class ELEHGGAJDGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public ELEHGGAJDGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x15082A0", Offset = "0x15072A0", VA = "0x1815082A0")]
		internal bool MJBMLEJFJMF(ENIOJCHHHIB sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private DBOAJANNPMM AKJKFGAFELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private DADHIOJBICM MPJHANBOIFM;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static readonly (OAKJFJKJCNE superRoomData, long subRoomDataSaveId) PLNJLMHODEM;

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x68F0260", Offset = "0x68EF260", VA = "0x1868F0260", Slot = "5")]
	public void CJMKLAKCCOG(IONKJBLKHOH CPMFHDAOGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x68F0590", Offset = "0x68EF590", VA = "0x1868F0590", Slot = "4")]
	[AsyncStateMachine(typeof(OAOODDDGIAB))]
	public Task<IKPHFCIJHCC> PAJFHGEFGOH(NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, BPINABCIEKB DLJENKKADJN, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x68F0430", Offset = "0x68EF430", VA = "0x1868F0430")]
	[AsyncStateMachine(typeof(GKNPLKEDLJI))]
	private Task<KPBKEDCLNDD> MKKFNNEJHDF(BPINABCIEKB DLJENKKADJN, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x68F02F0", Offset = "0x68EF2F0", VA = "0x1868F02F0")]
	private IKPHFCIJHCC GPAGHAIHACK(BPINABCIEKB DLJENKKADJN, KPBKEDCLNDD KDBBBMAICAI, long CEJEMJLIMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x68EFF70", Offset = "0x68EEF70", VA = "0x1868EFF70")]
	private (OAKJFJKJCNE, long) AFGLOOLPMGJ(BPINABCIEKB DLJENKKADJN, KPBKEDCLNDD KDBBBMAICAI, long CEJEMJLIMDC)
	{
		return default((OAKJFJKJCNE, long));
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public IDNKNONLJIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[UnityEngine.Scripting.Preserve]
internal sealed class IKBMCPLKKCI : NODFFFGJLKO, IHLALIKNOCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class PCLKDOLAKFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public GCHMLLGGJOI request;

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public PCLKDOLAKFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x68FE2D0", Offset = "0x68FD2D0", VA = "0x1868FE2D0")]
		internal object IDIPGODMGIO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct GMPLJLBEHFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public AsyncTaskMethodBuilder<GCHMLLGGJOI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public GCHMLLGGJOI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public IKBMCPLKKCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public CKGLENOBMMP pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private BEAMBDPEGJL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private TaskAwaiter<GCHMLLGGJOI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x68ECE40", Offset = "0x68EBE40", VA = "0x1868ECE40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x68ED450", Offset = "0x68EC450", VA = "0x1868ED450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct DCDCBFKHOKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public AsyncTaskMethodBuilder<GCHMLLGGJOI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public IKBMCPLKKCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public CKGLENOBMMP pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private BEAMBDPEGJL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private TaskAwaiter<AIHBFHDLEDD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x68E5660", Offset = "0x68E4660", VA = "0x1868E5660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x68E5C60", Offset = "0x68E4C60", VA = "0x1868E5C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class GKCJOKKMJCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public GCHMLLGGJOI request;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public GKCJOKKMJCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x68EB340", Offset = "0x68EA340", VA = "0x1868EB340")]
		internal object FCNAHFFLODB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct GKIDEOMHGPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public AsyncTaskMethodBuilder<GCHMLLGGJOI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public GCHMLLGGJOI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public IKBMCPLKKCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public CKGLENOBMMP pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private BEAMBDPEGJL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private GHAPMBGDDIL <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private NPBIFNLOEEC <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private TaskAwaiter<AIHBFHDLEDD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x68EB3A0", Offset = "0x68EA3A0", VA = "0x1868EB3A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x68EBF90", Offset = "0x68EAF90", VA = "0x1868EBF90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private MIMGKGBGIEK GMFPLFAACJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	private AKJNAHIMMAH PEAPOIFCELE;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private LACPOPGHEKN LOMEGNMANCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x68F1700", Offset = "0x68F0700", VA = "0x1868F1700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x68F0E20", Offset = "0x68EFE20", VA = "0x1868F0E20", Slot = "8")]
	public void CJMKLAKCCOG(IONKJBLKHOH CPMFHDAOGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x68F0EB0", Offset = "0x68EFEB0", VA = "0x1868F0EB0", Slot = "4")]
	[AsyncStateMachine(typeof(GMPLJLBEHFB))]
	public Task<GCHMLLGGJOI> EODMDKEGFGF(GCHMLLGGJOI MJJCOLDOFAC, CKGLENOBMMP LAAALIMMANK, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x68F1010", Offset = "0x68F0010", VA = "0x1868F1010", Slot = "5")]
	[AsyncStateMachine(typeof(DCDCBFKHOKM))]
	public Task<GCHMLLGGJOI> HKGHLDBECDD(CancellationToken GHLJDIEPICD, CKGLENOBMMP LAAALIMMANK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x68F1160", Offset = "0x68F0160", VA = "0x1868F1160", Slot = "6")]
	public MOMAGAAAECB JCEPAJCPPJK(NINLEEMOEAG LIMGMKMBJEL, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x68F14D0", Offset = "0x68F04D0", VA = "0x1868F14D0", Slot = "7")]
	public MOMAGAAAECB OHDMIHLADGP(NINLEEMOEAG LIMGMKMBJEL, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x68F1370", Offset = "0x68F0370", VA = "0x1868F1370")]
	[AsyncStateMachine(typeof(GKIDEOMHGPI))]
	private Task<GCHMLLGGJOI> MHHDDJELACL(GCHMLLGGJOI MJJCOLDOFAC, CKGLENOBMMP LAAALIMMANK, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x299C900", Offset = "0x299B900", VA = "0x18299C900")]
	private static byte[] KHNJJCNCKIA(GCHMLLGGJOI JJJNODJJIFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public IKBMCPLKKCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[UnityEngine.Scripting.Preserve]
internal sealed class LFAMLNFOCKB : POKMPJKENIC, IHLALIKNOCJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private HMADNGLLKOK OHCIMHINJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private MIMGKGBGIEK GMFPLFAACJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private NALENELDDPM AFEDNGDPKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private MGLHCHFIOKJ BPFLFEPFBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private DBOAJANNPMM AKJKFGAFELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private NJKCLBHBFPO COIBKFDENBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private PFHGGCAIBEH ABFGAFGJNGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private OIMHDJADCNF MOBEOAJIGJA;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private LJGNJILFANM DDLGOMBBCHN
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x68F6650", Offset = "0x68F5650", VA = "0x1868F6650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private static IDAKKNHINME LBOLOKDADPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x68F6700", Offset = "0x68F5700", VA = "0x1868F6700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x68F6370", Offset = "0x68F5370", VA = "0x1868F6370", Slot = "6")]
	public void CJMKLAKCCOG(IONKJBLKHOH CPMFHDAOGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x68F64E0", Offset = "0x68F54E0", VA = "0x1868F64E0", Slot = "4")]
	public IDAKKNHINME FIEDIDJHFLI(JGGIBKMOPKC KIEKODJAMNJ, AMLKNBEIKDJ NJGNAINEOMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x68F6070", Offset = "0x68F5070", VA = "0x1868F6070", Slot = "5")]
	public IDAKKNHINME ADDKNOHKAIF(JGGIBKMOPKC LDFGEIEBGOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x68F66A0", Offset = "0x68F56A0", VA = "0x1868F66A0")]
	private static IDAKKNHINME PCALKKCJHAL(DBNKOANBHNI KDLIPBNGNPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public LFAMLNFOCKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public class AHJJBBPJKFD : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x68E1580", Offset = "0x68E0580", VA = "0x1868E1580")]
	public AHJJBBPJKFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x5E36E00", Offset = "0x5E35E00", VA = "0x185E36E00")]
	public AHJJBBPJKFD(string JJJNODJJIFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[UnityEngine.Scripting.Preserve]
internal sealed class JIFFAPKMGIB : FLJJPHEOGBK, IHLALIKNOCJ, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct KHGOEBGOEEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AsyncTaskMethodBuilder<IDAKKNHINME> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public JIFFAPKMGIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public JEENCGOGKPP autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private NENCAGLHEIB<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private PEFCMMGNIDO <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private TaskAwaiter<IDAKKNHINME> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x68F4B50", Offset = "0x68F3B50", VA = "0x1868F4B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x68F56E0", Offset = "0x68F46E0", VA = "0x1868F56E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct JAJAMKHIADM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public JIFFAPKMGIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x68F1BC0", Offset = "0x68F0BC0", VA = "0x1868F1BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x68F2310", Offset = "0x68F1310", VA = "0x1868F2310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct KEGIIAOBJBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public JIFFAPKMGIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x68F44C0", Offset = "0x68F34C0", VA = "0x1868F44C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x68F49D0", Offset = "0x68F39D0", VA = "0x1868F49D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct HJMBHNEOFLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public JIFFAPKMGIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x68EE070", Offset = "0x68ED070", VA = "0x1868EE070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x68EE7C0", Offset = "0x68ED7C0", VA = "0x1868EE7C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct DMKCMAJEJLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public JIFFAPKMGIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x68E7080", Offset = "0x68E6080", VA = "0x1868E7080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x68E7220", Offset = "0x68E6220", VA = "0x1868E7220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct GKOMNMLPNOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public JIFFAPKMGIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x68EC660", Offset = "0x68EB660", VA = "0x1868EC660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x68ECD80", Offset = "0x68EBD80", VA = "0x1868ECD80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct LLBODFMABAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public JIFFAPKMGIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private Task <delayTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x68F6FC0", Offset = "0x68F5FC0", VA = "0x1868F6FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x68F7430", Offset = "0x68F6430", VA = "0x1868F7430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct NOFLMPNLAIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public JIFFAPKMGIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public JDGAAOKDGFM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private NENCAGLHEIB<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x68FC670", Offset = "0x68FB670", VA = "0x1868FC670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x68FCBD0", Offset = "0x68FBBD0", VA = "0x1868FCBD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private MIMGKGBGIEK GMFPLFAACJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private IONKJBLKHOH CPMFHDAOGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private DBOAJANNPMM AKJKFGAFELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private NODFFFGJLKO PCFKDKOIMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private NALENELDDPM AFEDNGDPKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private PFHGGCAIBEH ABFGAFGJNGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private CancellationTokenSource IIJDGLGJFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private Task CNFABKHNAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	private TaskCompletionSource<int> NLDBIKMGOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	private int ENODPPMLALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	private int DJHFPAAHPPG;

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x68F2D60", Offset = "0x68F1D60", VA = "0x1868F2D60", Slot = "6")]
	public void CJMKLAKCCOG(IONKJBLKHOH CPMFHDAOGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x910630", Offset = "0x90F630", VA = "0x180910630", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x68F3000", Offset = "0x68F2000", VA = "0x1868F3000")]
	private void EBFNFMJPGHO(float KCHAKFCDBII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x68F2AA0", Offset = "0x68F1AA0", VA = "0x1868F2AA0", Slot = "4")]
	[AsyncStateMachine(typeof(KHGOEBGOEEJ))]
	public Task<IDAKKNHINME> BEBEADCPADP(JEENCGOGKPP OHMDGACKMDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x68F3340", Offset = "0x68F2340", VA = "0x1868F3340", Slot = "5")]
	[AsyncStateMachine(typeof(JAJAMKHIADM))]
	public Task KOLAEMINHJM([Optional] CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x910630", Offset = "0x90F630", VA = "0x180910630")]
	public void BKPHPIFFFDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x68F31D0", Offset = "0x68F21D0", VA = "0x1868F31D0")]
	private PEFCMMGNIDO GNBKNOKIJIM(JEENCGOGKPP OHMDGACKMDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x68F3690", Offset = "0x68F2690", VA = "0x1868F3690")]
	[AsyncStateMachine(typeof(KEGIIAOBJBL))]
	private Task MFLPLECJDDE(DJJMNPKHNKF GEJMEMCGHEN, CancellationToken ICHNHGHOBPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x68F29A0", Offset = "0x68F19A0", VA = "0x1868F29A0")]
	[AsyncStateMachine(typeof(HJMBHNEOFLO))]
	private Task APDBHGBPGLL(CancellationToken ICHNHGHOBPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x68F30E0", Offset = "0x68F20E0", VA = "0x1868F30E0")]
	[AsyncStateMachine(typeof(DMKCMAJEJLK))]
	private Task GFLPJDPFIAN([Optional] CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x68F2F10", Offset = "0x68F1F10", VA = "0x1868F2F10")]
	[AsyncStateMachine(typeof(GKOMNMLPNOJ))]
	private Task DCMJAFDJLEM(CancellationToken ICHNHGHOBPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x68F3890", Offset = "0x68F2890", VA = "0x1868F3890")]
	[AsyncStateMachine(typeof(LLBODFMABAG))]
	private Task NOKAAAHJJOG(CancellationToken FMJLEIICEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x68F2BD0", Offset = "0x68F1BD0", VA = "0x1868F2BD0")]
	private Task BGBILCIHJEI(JDGAAOKDGFM CMMMKALOAEA, CancellationToken ICHNHGHOBPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x68F3780", Offset = "0x68F2780", VA = "0x1868F3780")]
	[AsyncStateMachine(typeof(NOFLMPNLAIE))]
	private Task NEDDLIAEGDL(JDGAAOKDGFM CMMMKALOAEA, CancellationToken ICHNHGHOBPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x68F3430", Offset = "0x68F2430", VA = "0x1868F3430")]
	private bool LHKOIDJOCJC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public JIFFAPKMGIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[UnityEngine.Scripting.Preserve]
internal class IEAPNCCIKOO : MGLHCHFIOKJ, IHLALIKNOCJ, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct OOFJBLENMMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public IEAPNCCIKOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private NENCAGLHEIB<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x68FDB40", Offset = "0x68FCB40", VA = "0x1868FDB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x68FE0A0", Offset = "0x68FD0A0", VA = "0x1868FE0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private PAKLMFALEMK BJDLIPLDNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private IONKJBLKHOH CPMFHDAOGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private POKMPJKENIC PDPBLEDPOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private NODFFFGJLKO PCFKDKOIMLB;

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x68F07C0", Offset = "0x68EF7C0", VA = "0x1868F07C0", Slot = "6")]
	public void CJMKLAKCCOG(IONKJBLKHOH CPMFHDAOGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x68F0AA0", Offset = "0x68EFAA0", VA = "0x1868F0AA0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x68F0BE0", Offset = "0x68EFBE0", VA = "0x1868F0BE0", Slot = "5")]
	[AsyncStateMachine(typeof(OOFJBLENMMK))]
	public Task HEBJAFLMICE(string OCKDOKGOPLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x68F0CE0", Offset = "0x68EFCE0", VA = "0x1868F0CE0", Slot = "4")]
	public IDAKKNHINME LHKOIDJOCJC(JGGIBKMOPKC KIEKODJAMNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x68F0AF0", Offset = "0x68EFAF0", VA = "0x1868F0AF0")]
	private ABJDMNPDADN GIOMBGENANF(string OCKDOKGOPLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public IEAPNCCIKOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public static class JLDBAKGEKMB
{
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x68F4020", Offset = "0x68F3020", VA = "0x1868F4020")]
	public static void PCDGINNODBN(OIEDECFCIPC MJBHKMGKNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x68F3990", Offset = "0x68F2990", VA = "0x1868F3990")]
	internal static void GIPJKCJDJGI(OIEDECFCIPC MJBHKMGKNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x68F3AF0", Offset = "0x68F2AF0", VA = "0x1868F3AF0")]
	internal static void HABCFJNNFCD(OIEDECFCIPC MJBHKMGKNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x68F3BD0", Offset = "0x68F2BD0", VA = "0x1868F3BD0")]
	internal static void HFFGMCFOPKJ(OIEDECFCIPC MJBHKMGKNLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal class FLAHNLEMOEC : FAHJKKNNIFL<GCHMLLGGJOI>
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private sealed class ABLLBENKJOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public GCHMLLGGJOI message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public ABLLBENKJOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x68E0E20", Offset = "0x68DFE20", VA = "0x1868E0E20")]
		internal object ADGGABKMMGJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly FLAHNLEMOEC AFPJCELPLKK;

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x68EA3B0", Offset = "0x68E93B0", VA = "0x1868EA3B0")]
	public ExitGames.Client.Photon.Hashtable AFIENNPCBKD(GCHMLLGGJOI JJJNODJJIFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x68EA440", Offset = "0x68E9440", VA = "0x1868EA440", Slot = "5")]
	protected override void BJHLMKMEPAC(GCHMLLGGJOI JJJNODJJIFK, IDictionary<object, object> GPKMLHOONCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x68EA930", Offset = "0x68E9930", VA = "0x1868EA930", Slot = "6")]
	public override GCHMLLGGJOI OMCMMHECHCJ(IDictionary<object, object> GPKMLHOONCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x68EA570", Offset = "0x68E9570", VA = "0x1868EA570")]
	private static void HEFADAFEBPD(string IAOJIDPOIGN, GCHMLLGGJOI JJJNODJJIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x68EAC00", Offset = "0x68E9C00", VA = "0x1868EAC00")]
	public FLAHNLEMOEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x68EA680", Offset = "0x68E9680", VA = "0x1868EA680")]
	[CompilerGenerated]
	internal static string JJKAEHICOGJ(IKPHFCIJHCC KKAPFENLPIM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public static class NNBEAFFHBOG
{
	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public static IDAKKNHINME LBOLOKDADPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x68F6700", Offset = "0x68F5700", VA = "0x1868F6700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x68FC5F0", Offset = "0x68FB5F0", VA = "0x1868FC5F0")]
	public static bool LNACDIHMPJJ(this IDAKKNHINME PJNPPONDPNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x68F66A0", Offset = "0x68F56A0", VA = "0x1868F66A0")]
	public static IDAKKNHINME PCALKKCJHAL(DBNKOANBHNI NBGKPECNEFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x68FC3F0", Offset = "0x68FB3F0", VA = "0x1868FC3F0")]
	public static IDAKKNHINME LGMIFAKJHGE(IEnumerable<IDAKKNHINME> NCADPFFFDOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x68FC190", Offset = "0x68FB190", VA = "0x1868FC190")]
	public static string JIMAGKCMGHB(this IDAKKNHINME NIKEINPNLMA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public abstract class BFJOICLLHIK : GNJLKLDGKOF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public delegate IDAKKNHINME AKOOKOGBFEO([NotNull] JGGIBKMOPKC IKOLEFFAOND);

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class AFLBPFJIAEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public JGGIBKMOPKC photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public AFLBPFJIAEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x602E890", Offset = "0x602D890", VA = "0x18602E890")]
		internal IDAKKNHINME FONICDNKOIM(AKOOKOGBFEO v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private bool FFEBLLHHGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	protected readonly HashSet<AKOOKOGBFEO> NANOLIMBEIB;

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x68E2440", Offset = "0x68E1440", VA = "0x1868E2440", Slot = "4")]
	public void BMKGBGNHJPH(AKOOKOGBFEO HNCOMFBHAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x68E2790", Offset = "0x68E1790", VA = "0x1868E2790", Slot = "5")]
	public void NMIEOJMPANA(AKOOKOGBFEO HNCOMFBHAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x68E24A0", Offset = "0x68E14A0", VA = "0x1868E24A0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x68E24F0", Offset = "0x68E14F0", VA = "0x1868E24F0")]
	protected IDAKKNHINME HLNDDFNKIJM(JGGIBKMOPKC LDFGEIEBGOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x68E27F0", Offset = "0x68E17F0", VA = "0x1868E27F0")]
	protected BFJOICLLHIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public class KFCJMIDBODA : BFJOICLLHIK, HMADNGLLKOK, GNJLKLDGKOF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[CompilerGenerated]
	private sealed class FEKKINIPJJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public IDAKKNHINME result;

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public FEKKINIPJJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x68E9CD0", Offset = "0x68E8CD0", VA = "0x1868E9CD0")]
		internal object MNPCEEIDHKL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x68F4B40", Offset = "0x68F3B40", VA = "0x1868F4B40")]
	[UnityEngine.Scripting.Preserve]
	public KFCJMIDBODA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x68F4A30", Offset = "0x68F3A30", VA = "0x1868F4A30", Slot = "8")]
	public IDAKKNHINME MOINKICNKOH(JGGIBKMOPKC LDFGEIEBGOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class LFOCPBIOAGM : BFJOICLLHIK, PAKLMFALEMK, GNJLKLDGKOF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class BLGKGKMNILP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public IDAKKNHINME result;

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public BLGKGKMNILP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x68E2880", Offset = "0x68E1880", VA = "0x1868E2880")]
		internal object LBAOPLAMFIE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x68F4B40", Offset = "0x68F3B40", VA = "0x1868F4B40")]
	[UnityEngine.Scripting.Preserve]
	public LFOCPBIOAGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x68F6760", Offset = "0x68F5760", VA = "0x1868F6760", Slot = "8")]
	public IDAKKNHINME LHKOIDJOCJC(JGGIBKMOPKC KFFKBJPPNBI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class JNFEEMANLBJ
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private sealed class AKOJBOKJCLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public NENCAGLHEIB<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public AKOJBOKJCLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x68E19E0", Offset = "0x68E09E0", VA = "0x1868E19E0")]
		internal object POPMPBDCFMG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x68F4260", Offset = "0x68F3260", VA = "0x1868F4260")]
	public static NENCAGLHEIB<string> ANIACKMHPCP(NDLEKAMCBHL LAGKGKDNMJM, [Optional] string BADANOADNKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x68F4340", Offset = "0x68F3340", VA = "0x1868F4340")]
	public static void BCPGDPNMEIK(NENCAGLHEIB<string> OCBBLMCOHCB, NDLEKAMCBHL LAGKGKDNMJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x68F4400", Offset = "0x68F3400", VA = "0x1868F4400")]
	public static string IPJABOAKJAA(GCHMLLGGJOI EJMANJACCLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal static class AEBGNOKNDPO
{
	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x68E12A0", Offset = "0x68E02A0", VA = "0x1868E12A0")]
	public static void HJOFIGGFMNO(this MIMGKGBGIEK GMFPLFAACJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x68E12B0", Offset = "0x68E02B0", VA = "0x1868E12B0")]
	public static void PDMCNCCMPIL(this MIMGKGBGIEK GMFPLFAACJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x68E1180", Offset = "0x68E0180", VA = "0x1868E1180")]
	private static void DEEGLCBGJGI(this MIMGKGBGIEK GMFPLFAACJJ, bool ICKGDLGKCIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class IBEHKCNFDCH : NMDMGILHBIK, JIANBPEICIN, EHFFFFDDGHI, JALIFKAHMHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private readonly JIANBPEICIN BOOHEFFABNN;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public JGGIBKMOPKC MHKJELAFFJB
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x68EFB80", Offset = "0x68EEB80", VA = "0x1868EFB80", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public int JKOIIGCIPJA
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x68EFBD0", Offset = "0x68EEBD0", VA = "0x1868EFBD0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public int AJOABHGMCIA
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x68EF980", Offset = "0x68EE980", VA = "0x1868EF980", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public bool CHOBFOOMDGH
	{
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x7DB420", Offset = "0x7DA420", VA = "0x1807DB420", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int JDEIOKGOJKK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x883D20", Offset = "0x882D20", VA = "0x180883D20", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event JEAEHOOEGLF.HNKFEPHLHMC IELAHOLAAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event CAPCLLCCMIL NJFCJKHECPL
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x68EF9D0", Offset = "0x68EE9D0", VA = "0x1868EF9D0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x68EF8E0", Offset = "0x68EE8E0", VA = "0x1868EF8E0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> IEACGJBKEDN
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<JGGIBKMOPKC> AMBJEJDAHBF
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action IOMAFLECFJL
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x68EFA70", Offset = "0x68EEA70", VA = "0x1868EFA70", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x68EFDB0", Offset = "0x68EEDB0", VA = "0x1868EFDB0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0xDAF9C0", Offset = "0xDAE9C0", VA = "0x180DAF9C0")]
	public IBEHKCNFDCH(JIANBPEICIN BOOHEFFABNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x68EFC20", Offset = "0x68EEC20", VA = "0x1868EFC20", Slot = "8")]
	public bool LGOCLFKNCDA(byte PCFDAINLDCD, ExitGames.Client.Photon.Hashtable MFCAFAOAKOG, DEIAFONPDBM KLONJKOHOPF, SendOptions CEAGIMIMMJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x68EFCD0", Offset = "0x68EECD0", VA = "0x1868EFCD0", Slot = "16")]
	public JGGIBKMOPKC MFLOBAMMCPE(int PJJEGKKKKCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "19")]
	public void DLPOCEHNPMO(object KONODCHOCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "20")]
	public void IPNGCKLGEBI(object KONODCHOCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "21")]
	public void BGFKHPJEMBN(object KONODCHOCOG, bool LBDMBLELILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x68EFB30", Offset = "0x68EEB30", VA = "0x1868EFB30", Slot = "22")]
	public IDisposable IBLPIFGAHGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "23")]
	private bool ONHCNANAFCI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "24")]
	public void CAPNNALLOPM(StringBuilder EBOIGEOFGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x68EFB10", Offset = "0x68EEB10", VA = "0x1868EFB10", Slot = "25")]
	public bool HOPGADEFEAG(bool DGBNEECELDA, [Out] string FKMKCMGJCIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x82D710", Offset = "0x82C710", VA = "0x18082D710", Slot = "28")]
	public void LBJBHKFCBJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal struct INHAJCFKIEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	private readonly IDictionary<object, object> LPDEFAPJANH;

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x94ABA0", Offset = "0x949BA0", VA = "0x18094ABA0")]
	public INHAJCFKIEO(IDictionary<object, object> LPDEFAPJANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x68F1830", Offset = "0x68F0830", VA = "0x1868F1830")]
	public bool AEIOMDHJPBG([Out] GCHMLLGGJOI JJJNODJJIFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x68F18E0", Offset = "0x68F08E0", VA = "0x1868F18E0")]
	public Guid BCCHPLFAGDJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x68F1990", Offset = "0x68F0990", VA = "0x1868F1990")]
	public IDAKKNHINME DOKDMAKNNGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x68F1AD0", Offset = "0x68F0AD0", VA = "0x1868F1AD0")]
	public static ExitGames.Client.Photon.Hashtable EOFBBDOECDH(GCHMLLGGJOI JJJNODJJIFK, IDAKKNHINME PJNPPONDPNA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal static class IGFEGEOABOC
{
	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x68F0DA0", Offset = "0x68EFDA0", VA = "0x1868F0DA0")]
	public static bool FEDBIAALHLH(this BPINABCIEKB KJLIHJCMFFA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal struct HCFIPKNNBJL : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct JDICDCBOBAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public HCFIPKNNBJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x68F2370", Offset = "0x68F1370", VA = "0x1868F2370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x68F2550", Offset = "0x68F1550", VA = "0x1868F2550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	private readonly CancellationTokenSource EILAHEEOMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private bool FFEBLLHHGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private Task BKJCIFOIBEF;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public bool JAKHALGPHHN
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x68ED850", Offset = "0x68EC850", VA = "0x1868ED850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x68ED880", Offset = "0x68EC880", VA = "0x1868ED880")]
	public HCFIPKNNBJL(CancellationToken GHLJDIEPICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x68ED740", Offset = "0x68EC740", VA = "0x1868ED740")]
	[AsyncStateMachine(typeof(JDICDCBOBAJ))]
	public Task LIFIKKBFKEB(Func<CancellationToken, List<Task>> KFAOCLKJNJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x68ED6F0", Offset = "0x68EC6F0", VA = "0x1868ED6F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public readonly struct JGFNOPGJOLC<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct DLLLGOLMAGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public AsyncTaskMethodBuilder<PGLGENBDGKP<MAHHFMJICFI<TData>, HBNEILLBGHD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public JGFNOPGJOLC<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private TaskAwaiter<PGLGENBDGKP<MAHHFMJICFI<TData>, HBNEILLBGHD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x520EDF0", Offset = "0x520DDF0", VA = "0x18520EDF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x3519210", Offset = "0x3518210", VA = "0x183519210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private readonly HKAACFHKALK<TGetDataArg, TData> KOPMBDPCNDC;

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x94ABA0", Offset = "0x949BA0", VA = "0x18094ABA0")]
	internal JGFNOPGJOLC(HKAACFHKALK<TGetDataArg, TData> AKOGIKBAMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x3CCE940", Offset = "0x3CCD940", VA = "0x183CCE940")]
	[AsyncStateMachine(typeof(JGFNOPGJOLC<, >.DLLLGOLMAGA))]
	public Task<PGLGENBDGKP<MAHHFMJICFI<TData>, HBNEILLBGHD>> KNGFGDNIHNG(TGetDataArg OFDFAAHEGDG, string KAJKLLHGOBE, NENCAGLHEIB<string>.OGJMFKKDMDA OCBBLMCOHCB, CancellationToken GHLJDIEPICD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public static class LLLEHHNBMKN
{
	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x26B9B10", Offset = "0x26B8B10", VA = "0x1826B9B10")]
	public static JGFNOPGJOLC<TGetDataArg, TData> MGIIAIMPALM<TGetDataArg, TData>(HKAACFHKALK<TGetDataArg, TData> AKOGIKBAMPF)
	{
		return default(JGFNOPGJOLC<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public struct MAPGHKPFHLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public readonly int FMBAMNHBLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public readonly int? ENHCLOKMLJB;

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x3E127A0", Offset = "0x3E117A0", VA = "0x183E127A0")]
	public MAPGHKPFHLD(int EMIDNADEKEN, [Optional] int? LCLJCCIEPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x68FAC80", Offset = "0x68F9C80", VA = "0x1868FAC80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public interface KGGJGIHGFIE<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ELCHOGEGKGO();

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KGGJGIHGFIE<T> OPHEEBMKGCB(string BGEJECFEDMH);

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KGGJGIHGFIE<T> PHAPEKMHCPI(HKBLPKFHELI<T> MPOCNFDHKNL);

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KGGJGIHGFIE<T> GIMGOAKBOHI(int GOHOCIPCMMC);

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KGGJGIHGFIE<T> HOJDILKPDMM(int GOHOCIPCMMC, PBJAOABIFIP<T> BKHENBOBHMA);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public interface GKMPPDACLNH
{
	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KGGJGIHGFIE<T> OONFNOBJJIL<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	APILCMOIHFN HHKBPLKHDOK(Exception DNFOGIGBCCD);

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MAPGHKPFHLD IOALKCMIGDN(Exception DNFOGIGBCCD);
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public delegate string HKBLPKFHELI<in T>(T DNFOGIGBCCD) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public delegate int PBJAOABIFIP<in T>(T DNFOGIGBCCD) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DF")]
internal class LNLILBNDANG : GKMPPDACLNH
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	private delegate string HAHFFIMNFNG(Exception DNFOGIGBCCD);

	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	private delegate int HAFALHIGMIA(Exception DNFOGIGBCCD);

	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	private class DKOCAONINBK<T> : KGGJGIHGFIE<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private sealed class LHENNNJGCLE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000313")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
			public LHENNNJGCLE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0x7C35E0", Offset = "0x7C25E0", VA = "0x1807C35E0")]
			internal string DPBDGKOJGGP(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[CompilerGenerated]
		private sealed class PICNEIBCMME
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000314")]
			public HKBLPKFHELI<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
			public PICNEIBCMME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x3D6EC80", Offset = "0x3D6DC80", VA = "0x183D6EC80")]
			internal string PJFHPOFJNJB(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E5")]
		[CompilerGenerated]
		private sealed class KGKBJCNGIEO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000315")]
			public PBJAOABIFIP<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
			public KGKBJCNGIEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x3D6EC80", Offset = "0x3D6DC80", VA = "0x183D6EC80")]
			internal int EINMOPFKJGL(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private readonly LNLILBNDANG PKDJBMMFNAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private readonly Type EGADNKMPPMG;

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x520AED0", Offset = "0x5209ED0", VA = "0x18520AED0")]
		internal DKOCAONINBK(LNLILBNDANG PKDJBMMFNAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x520AB20", Offset = "0x5209B20", VA = "0x18520AB20", Slot = "4")]
		public void ELCHOGEGKGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x520ACB0", Offset = "0x5209CB0", VA = "0x18520ACB0", Slot = "5")]
		public KGGJGIHGFIE<T> OPHEEBMKGCB(string BGEJECFEDMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x520ADC0", Offset = "0x5209DC0", VA = "0x18520ADC0", Slot = "6")]
		public KGGJGIHGFIE<T> PHAPEKMHCPI(HKBLPKFHELI<T> MPOCNFDHKNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x520AB50", Offset = "0x5209B50", VA = "0x18520AB50", Slot = "7")]
		public KGGJGIHGFIE<T> GIMGOAKBOHI(int GOHOCIPCMMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x520AB90", Offset = "0x5209B90", VA = "0x18520AB90", Slot = "8")]
		public KGGJGIHGFIE<T> HOJDILKPDMM(int GOHOCIPCMMC, PBJAOABIFIP<T> BKHENBOBHMA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	private class NEMNEPFBINI<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private bool EOHGPJMFOLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private readonly List<Type> FGEKEFFJIOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private readonly Dictionary<Type, TVal> KDPOMGIKIJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private readonly Dictionary<Type, int> IEFFOAJAFFH;

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public IReadOnlyList<Type> DBDMACBDOMG
		{
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x40B8510", Offset = "0x40B7510", VA = "0x1840B8510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x40B8760", Offset = "0x40B7760", VA = "0x1840B8760")]
		public NEMNEPFBINI(Dictionary<Type, int> IEFFOAJAFFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x40B8370", Offset = "0x40B7370", VA = "0x1840B8370")]
		public void BGLDHBEBEIE(Type OHNEPKBBADL, TVal PAFHPJKJPEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x40B8410", Offset = "0x40B7410", VA = "0x1840B8410")]
		public bool BIIDOAFMBMG(Type EGADNKMPPMG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x40B8610", Offset = "0x40B7610", VA = "0x1840B8610")]
		public bool OJMEBDDGEHJ(TVal LDGMLLMKHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x40B85D0", Offset = "0x40B75D0", VA = "0x1840B85D0")]
		public TVal HBEPMKJLJFA(Type KBCNAJKPHNL)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x40B8230", Offset = "0x40B7230", VA = "0x1840B8230")]
		[CompilerGenerated]
		private int AEAPGMPDJBD(Type KKPONNPPBNG, Type LHMCFDGJBIO)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class LMJIKFBHBIG : IEnumerable<MAPGHKPFHLD>, IEnumerable, IEnumerator<MAPGHKPFHLD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private MAPGHKPFHLD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public LNLILBNDANG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private IEnumerator<MAPGHKPFHLD> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		private MAPGHKPFHLD System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0x358B660", Offset = "0x358A660", VA = "0x18358B660", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(MAPGHKPFHLD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(RVA = "0x68F7E00", Offset = "0x68F6E00", VA = "0x1868F7E00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x8164C0", Offset = "0x8154C0", VA = "0x1808164C0")]
		[DebuggerHidden]
		public LMJIKFBHBIG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x68F7E50", Offset = "0x68F6E50", VA = "0x1868F7E50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x68F7850", Offset = "0x68F6850", VA = "0x1868F7850", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x68F7800", Offset = "0x68F6800", VA = "0x1868F7800")]
		private void HPAIKACEAJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x68F77B0", Offset = "0x68F67B0", VA = "0x1868F77B0")]
		private void DGKIMGJJCCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x68F7DB0", Offset = "0x68F6DB0", VA = "0x1868F7DB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x68F7CF0", Offset = "0x68F6CF0", VA = "0x1868F7CF0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MAPGHKPFHLD> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x68F7CF0", Offset = "0x68F6CF0", VA = "0x1868F7CF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	private static readonly MAPGHKPFHLD HEFMOKMAOHD;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	private static readonly Dictionary<Type, int> KMAFNKJIJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	private readonly HashSet<Type> MJBMCEBEHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private readonly NEMNEPFBINI<int> NAEFCGEILNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private readonly NEMNEPFBINI<HAFALHIGMIA> HJKPOFFIOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	private readonly NEMNEPFBINI<HAHFFIMNFNG> IDDOPCEJHFN;

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x68F8960", Offset = "0x68F7960", VA = "0x1868F8960")]
	[ILJDPBHFAFI(DIDBPCEENMM.GameOnly)]
	private static void ELBLKAPGOPK(OIEDECFCIPC LDKHFAGODPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x68F93A0", Offset = "0x68F83A0", VA = "0x1868F93A0")]
	[RecRoom.NoEngine.Common.Preserve]
	public LNLILBNDANG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x2774FA0", Offset = "0x2773FA0", VA = "0x182774FA0", Slot = "4")]
	public KGGJGIHGFIE<T> OONFNOBJJIL<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x68F89D0", Offset = "0x68F79D0", VA = "0x1868F89D0", Slot = "5")]
	public APILCMOIHFN HHKBPLKHDOK(Exception DNFOGIGBCCD)
	{
		return default(APILCMOIHFN);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x68F8A60", Offset = "0x68F7A60", VA = "0x1868F8A60", Slot = "6")]
	public MAPGHKPFHLD IOALKCMIGDN(Exception? DNFOGIGBCCD)
	{
		return default(MAPGHKPFHLD);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x68F7FA0", Offset = "0x68F6FA0", VA = "0x1868F7FA0", Slot = "7")]
	[IteratorStateMachine(typeof(LMJIKFBHBIG))]
	public IEnumerable<MAPGHKPFHLD> ADIIPGHJKOB(Exception DNFOGIGBCCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x68F8C60", Offset = "0x68F7C60", VA = "0x1868F8C60", Slot = "8")]
	public string LMKFKJHNIIH(Exception? DNFOGIGBCCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x68F84D0", Offset = "0x68F74D0", VA = "0x1868F84D0")]
	private string CGLOIKHJKLC(AggregateException LOGPINHLDAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x68F8040", Offset = "0x68F7040", VA = "0x1868F8040")]
	private void BDOFACAGMIK(Type EGADNKMPPMG, int GOHOCIPCMMC, HAFALHIGMIA? KLECLJFNGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x68F9080", Offset = "0x68F8080", VA = "0x1868F9080")]
	private void NDPKPLECHJL(Type EGADNKMPPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x68F8DB0", Offset = "0x68F7DB0", VA = "0x1868F8DB0")]
	private void LMLBPOIPEBO(Type EGADNKMPPMG, HAHFFIMNFNG KKKOPBAHAHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x68F87E0", Offset = "0x68F77E0", VA = "0x1868F87E0")]
	private static int DFLEIIJHDBA(Type EGADNKMPPMG, Dictionary<Type, int> IEFFOAJAFFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x2964B70", Offset = "0x2963B70", VA = "0x182964B70")]
	private static bool INLIGCAGEPN<TVal>(NEMNEPFBINI<TVal> AGKDCPLPFCM, Type EGADNKMPPMG, [Out] TVal LDGMLLMKHLF) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x68F83F0", Offset = "0x68F73F0", VA = "0x1868F83F0")]
	[CompilerGenerated]
	internal static int CBNFLLBMHLK(Type JPKBDBAOJMI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public struct APILCMOIHFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public readonly MAPGHKPFHLD GIDKEBMCOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public readonly string KEFAHDJJLGG;

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x68E1B00", Offset = "0x68E0B00", VA = "0x1868E1B00")]
	public APILCMOIHFN(string ANOIKEJADDN, MAPGHKPFHLD GOHOCIPCMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x68E1A60", Offset = "0x68E0A60", VA = "0x1868E1A60")]
	public string GHMCLNJFFPG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public class AAGLIDGLEOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	private readonly KFNDCNMDHMI KFPEHLOMGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	private string DGPCKEEGJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	private long? NJELIFIIFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	private long? DGFFCIGKDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	private long? NDJLFEEPOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private string ABFNJIIPPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private OONPJIGGAPK LMCCAEAJIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private long? EKMCPAGCNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private bool JIHDMKAECCG;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public string KGBODJLEKPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public long LIDJKBOMDHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x68E0030", Offset = "0x68DF030", VA = "0x1868E0030")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public long DLBLMBAMBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x68E0D20", Offset = "0x68DFD20", VA = "0x1868E0D20")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public long PIBGAJIEEML
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x68E07B0", Offset = "0x68DF7B0", VA = "0x1868E07B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public string CCDHIGBEMDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x68E0090", Offset = "0x68DF090", VA = "0x1868E0090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public OONPJIGGAPK IDCKOIIDBPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0xDC9490", Offset = "0xDC8490", VA = "0x180DC9490")]
		get
		{
			return default(OONPJIGGAPK);
		}
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x68E0C30", Offset = "0x68DFC30", VA = "0x1868E0C30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public long DBGFGMJGFEP
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x68DFF50", Offset = "0x68DEF50", VA = "0x1868DFF50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x68E0D80", Offset = "0x68DFD80", VA = "0x1868E0D80")]
	[UnityEngine.Scripting.Preserve]
	public AAGLIDGLEOO([POILJEECDED(null)] KFNDCNMDHMI KFPEHLOMGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x68E00D0", Offset = "0x68DF0D0", VA = "0x1868E00D0")]
	private void FPELKAFMFCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x68E0320", Offset = "0x68DF320", VA = "0x1868E0320")]
	public void GNMBACIGKIM(long CFLPHBNCGDP, long CEJEMJLIMDC, [Optional] long? MPIGBBCKJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x68E0810", Offset = "0x68DF810", VA = "0x1868E0810")]
	public void IFEPCKJDGCB(long MPIGBBCKJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x68DFFB0", Offset = "0x68DEFB0", VA = "0x1868DFFB0")]
	public void DONNEPOOGCF(string IAOMDCCFODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x68E08B0", Offset = "0x68DF8B0", VA = "0x1868E08B0")]
	public void JGJPMJDKLKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal class MOMAGAAAECB : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private struct LIKMFKKDOFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public AsyncTaskMethodBuilder<GCHMLLGGJOI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public GCHMLLGGJOI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public MOMAGAAAECB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private TaskAwaiter<LACPOPGHEKN.BIJHKIMDKCD<GCHMLLGGJOI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x68F6870", Offset = "0x68F5870", VA = "0x1868F6870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x68F6DA0", Offset = "0x68F5DA0", VA = "0x1868F6DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private struct FIIELEGJHIO<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private sealed class PDHAMGMLAJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public GCHMLLGGJOI roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public PDHAMGMLAJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x68FE330", Offset = "0x68FD330", VA = "0x1868FE330")]
		internal GCHMLLGGJOI PIIFALNEBKG(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct FGCHIHCOJKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public AsyncTaskMethodBuilder<LACPOPGHEKN.BIJHKIMDKCD<GCHMLLGGJOI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public GCHMLLGGJOI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public MOMAGAAAECB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private GHAPMBGDDIL <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private TaskAwaiter<LACPOPGHEKN.BIJHKIMDKCD<GCHMLLGGJOI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x68E9D30", Offset = "0x68E8D30", VA = "0x1868E9D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x68EA340", Offset = "0x68E9340", VA = "0x1868EA340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct HLCLJFDKGIH<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public MOMAGAAAECB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x3A37380", Offset = "0x3A36380", VA = "0x183A37380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x3899F30", Offset = "0x3898F30", VA = "0x183899F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private struct KOCDCPAHADE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public MOMAGAAAECB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x68F5750", Offset = "0x68F4750", VA = "0x1868F5750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x68F5910", Offset = "0x68F4910", VA = "0x1868F5910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class LJODHNMAKLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public LJODHNMAKLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x68F6F60", Offset = "0x68F5F60", VA = "0x1868F6F60")]
		internal object PBCDAPBBFIA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x68F6EA0", Offset = "0x68F5EA0", VA = "0x1868F6EA0")]
		internal bool HINIPEADFJO(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class CLNOAPDDNBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public CLNOAPDDNBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x68E4A30", Offset = "0x68E3A30", VA = "0x1868E4A30")]
		internal object NMIMMLCJEAJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private sealed class AFJCAEAFDLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public AFJCAEAFDLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x68E12C0", Offset = "0x68E02C0", VA = "0x1868E12C0")]
		internal object GICACCPKAIB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private sealed class EFBKBCGAIFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public EFBKBCGAIFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x68E9BB0", Offset = "0x68E8BB0", VA = "0x1868E9BB0")]
		internal object KLKAOAICHPH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class AGFIKJNGPMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public MOMAGAAAECB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public AGFIKJNGPMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x68E1330", Offset = "0x68E0330", VA = "0x1868E1330")]
		internal object ADGGABKMMGJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private static readonly Guid LPLEIFEHBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public readonly NINLEEMOEAG POBAGANEMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private readonly LACPOPGHEKN LGMDLNCFIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private readonly EHFFFFDDGHI GMFPLFAACJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private readonly JALIFKAHMHF IJNIOFEPKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private bool LLHNHIHNJLD;

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x68FBF00", Offset = "0x68FAF00", VA = "0x1868FBF00")]
	public MOMAGAAAECB(NINLEEMOEAG LNPIDFLJKCD, LACPOPGHEKN LGMDLNCFIKN, EHFFFFDDGHI GMFPLFAACJJ, JALIFKAHMHF IJNIOFEPKJF, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x68FB180", Offset = "0x68FA180", VA = "0x1868FB180", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x68FB180", Offset = "0x68FA180", VA = "0x1868FB180")]
	public void JBGECJOBOOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x68FAE30", Offset = "0x68F9E30", VA = "0x1868FAE30")]
	public void BMGECBPCHJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x68FB3E0", Offset = "0x68FA3E0", VA = "0x1868FB3E0")]
	public void GLBJGEKGCDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x68FB020", Offset = "0x68FA020", VA = "0x1868FB020")]
	[AsyncStateMachine(typeof(LIKMFKKDOFH))]
	internal Task<GCHMLLGGJOI> DKGPPIDMIOG(NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, GCHMLLGGJOI EJMANJACCLC, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x299C900", Offset = "0x299B900", VA = "0x18299C900")]
	private static byte[] DHCDFDBNGPL<T>(T JJJNODJJIFK) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x299C910", Offset = "0x299B910", VA = "0x18299C910")]
	private static T HPBKDDKLMGO<T>(MessageParser<T> ILBBKIKPBGP, byte[] JJJNODJJIFK, T DPOJJABGFNL) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x68FB2A0", Offset = "0x68FA2A0", VA = "0x1868FB2A0")]
	[AsyncStateMachine(typeof(FGCHIHCOJKM))]
	private Task<LACPOPGHEKN.BIJHKIMDKCD<GCHMLLGGJOI>> EBHMKLFCDLJ(GCHMLLGGJOI EJMANJACCLC, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x299C680", Offset = "0x299B680", VA = "0x18299C680")]
	[AsyncStateMachine(typeof(HLCLJFDKGIH<>))]
	internal Task<T> CLLKPHIMNDB<T>(CancellationToken ICHNHGHOBPK, Func<CancellationToken, Task<T>> LLGPOKGDIJM, int JGIFOOKIDEE = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x68FAEF0", Offset = "0x68F9EF0", VA = "0x1868FAEF0")]
	[AsyncStateMachine(typeof(KOCDCPAHADE))]
	internal Task CLLKPHIMNDB(CancellationToken ICHNHGHOBPK, Func<CancellationToken, Task> LLGPOKGDIJM, int JGIFOOKIDEE = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x68FB710", Offset = "0x68FA710", VA = "0x1868FB710")]
	public EMBDJMOCHDN JIELMLPEFID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x68FBB80", Offset = "0x68FAB80", VA = "0x1868FBB80")]
	public LBEDDPJACIK NIJAHBLHBBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x68FBD40", Offset = "0x68FAD40", VA = "0x1868FBD40")]
	public NHKADONHMBA OGOOJMNOCII([Optional] NDLEKAMCBHL? LAGKGKDNMJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x68FB790", Offset = "0x68FA790", VA = "0x1868FB790")]
	public void JLPCIIILDMC(Func<Guid, bool> GLAGHBOKLNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x68FBA70", Offset = "0x68FAA70", VA = "0x1868FBA70")]
	public void NFIFKDLLCFN(Func<Guid, bool> KPAADBHAIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x68FB8F0", Offset = "0x68FA8F0", VA = "0x1868FB8F0")]
	public Guid MNFAHLCKBPM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x68FB4A0", Offset = "0x68FA4A0", VA = "0x1868FB4A0")]
	public void GOJDENELBKD(Guid HOGEIINGBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x68FBC00", Offset = "0x68FAC00", VA = "0x1868FBC00")]
	public void OFHFFDNEGPJ(GCHMLLGGJOI KLIPDADCFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x68FB5B0", Offset = "0x68FA5B0", VA = "0x1868FB5B0")]
	public void HEFADAFEBPD(string MEKCKBOEMKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x299CA60", Offset = "0x299BA60", VA = "0x18299CA60")]
	private T KDKHILLECBA<T>(T LDGMLLMKHLF) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x68FB6C0", Offset = "0x68FA6C0", VA = "0x1868FB6C0")]
	public void HKMLOKAGNKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x299C3D0", Offset = "0x299B3D0", VA = "0x18299C3D0")]
	[CompilerGenerated]
	internal static string AEMBCKOMKIL<T>(byte[] MFPMCBPILCI, int JBBBKAGKNMG, FIIELEGJHIO<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
internal sealed class PEMOJPDBOJL : NINLEEMOEAG
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class ABJOFDPKGFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public ABJOFDPKGFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x68FF6D0", Offset = "0x68FE6D0", VA = "0x1868FF6D0")]
		internal object EECIPEGFNGI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct HHKIBODJDEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public PEMOJPDBOJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public MOMAGAAAECB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private CGFLONACAMI <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private LBEDDPJACIK <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x6908670", Offset = "0x6907670", VA = "0x186908670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x6908F40", Offset = "0x6907F40", VA = "0x186908F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private struct DIJEGDNEJCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public PEMOJPDBOJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private bool <omIsEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private bool <omShouldBeEnabled>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private TaskAwaiter<KPBKEDCLNDD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		private TaskAwaiter<byte> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x6900D20", Offset = "0x68FFD20", VA = "0x186900D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x69014D0", Offset = "0x69004D0", VA = "0x1869014D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private struct KLGHHCHMCOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public AsyncTaskMethodBuilder<byte> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public PEMOJPDBOJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private TaskAwaiter<IPOEENMLOPF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x690CAD0", Offset = "0x690BAD0", VA = "0x18690CAD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x690CDF0", Offset = "0x690BDF0", VA = "0x18690CDF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private sealed class JCIOBJHAOGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public CGFLONACAMI presence;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public JCIOBJHAOGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x6909930", Offset = "0x6908930", VA = "0x186909930")]
		internal object GOLDFFJCAOI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private static readonly NDLEKAMCBHL LAGKGKDNMJM;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private static readonly NDLEKAMCBHL IKEGOFMGLFI;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private static readonly NDLEKAMCBHL BMLHKFGIGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	private readonly IKPHFCIJHCC HHGMNMHGNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000364")]
	private readonly BPINABCIEKB LFPHILBAAKL;

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x6914BE0", Offset = "0x6913BE0", VA = "0x186914BE0")]
	public PEMOJPDBOJL(IKPHFCIJHCC HHGMNMHGNBL, BPINABCIEKB LFPHILBAAKL, Guid IDKMDFCBEHN, IONKJBLKHOH CPMFHDAOGEO, CKGLENOBMMP PBKLEPKPAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x69149C0", Offset = "0x69139C0", VA = "0x1869149C0", Slot = "7")]
	[AsyncStateMachine(typeof(HHKIBODJDEH))]
	protected override Task OKLNDOMKEEE(MOMAGAAAECB ODBAMDFPOKB, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x69147B0", Offset = "0x69137B0", VA = "0x1869147B0")]
	[AsyncStateMachine(typeof(DIJEGDNEJCG))]
	private Task MKMCBBAICJO(CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x69148B0", Offset = "0x69138B0", VA = "0x1869148B0")]
	[AsyncStateMachine(typeof(KLGHHCHMCOC))]
	private Task<byte> ODJBJKECJNB(CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x69145D0", Offset = "0x69135D0", VA = "0x1869145D0")]
	private CGFLONACAMI LNAIBAHCEAK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
internal class PEFCMMGNIDO : NINLEEMOEAG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private struct EBKKIFNEEBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public PEFCMMGNIDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public MOMAGAAAECB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private TaskAwaiter<ECDKOBNKCNM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x6902720", Offset = "0x6901720", VA = "0x186902720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x69030A0", Offset = "0x69020A0", VA = "0x1869030A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400037E")]
	private readonly int EPJJCCJECJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400037F")]
	private readonly JEENCGOGKPP NGAIDKANJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public readonly long AEOCFDNBAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public readonly long KKJNOGLOGGM;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public ECDKOBNKCNM IKFBHMHKOAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7B0", Offset = "0x7CA7B0", VA = "0x1807CB7B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x7CB770", Offset = "0x7CA770", VA = "0x1807CB770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x69144A0", Offset = "0x69134A0", VA = "0x1869144A0")]
	public PEFCMMGNIDO(Guid IDKMDFCBEHN, IONKJBLKHOH CPMFHDAOGEO, CKGLENOBMMP PBKLEPKPAJE, int EPJJCCJECJG, JEENCGOGKPP NGAIDKANJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x6914380", Offset = "0x6913380", VA = "0x186914380", Slot = "7")]
	[AsyncStateMachine(typeof(EBKKIFNEEBF))]
	protected override Task OKLNDOMKEEE(MOMAGAAAECB ODBAMDFPOKB, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
internal abstract class FOHHPPLFJBE : NINLEEMOEAG
{
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private sealed class GCLNOANGAIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public FOHHPPLFJBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public KAABJCANIOP playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public GCLNOANGAIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x6905880", Offset = "0x6904880", VA = "0x186905880")]
		internal Task FFBPOKBLFEG(NENCAGLHEIB<string>.OGJMFKKDMDA postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x69058C0", Offset = "0x69048C0", VA = "0x1869058C0")]
		internal object KBJCJPJADHN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private struct MAJCEBBCOGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public FOHHPPLFJBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public MOMAGAAAECB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private GCLNOANGAIF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x690F270", Offset = "0x690E270", VA = "0x18690F270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x690FA30", Offset = "0x690EA30", VA = "0x18690FA30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private struct LOOGDNPNEFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public KAABJCANIOP playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public FOHHPPLFJBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x690EC80", Offset = "0x690DC80", VA = "0x18690EC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x690F210", Offset = "0x690E210", VA = "0x18690F210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x6905830", Offset = "0x6904830", VA = "0x186905830")]
	public FOHHPPLFJBE(Guid IDKMDFCBEHN, IONKJBLKHOH CPMFHDAOGEO, CKGLENOBMMP PBKLEPKPAJE, string JDMJMNDHOEC, FGADKHHKFHK BLOFAJKGCBC, bool IGMGOMGELJL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x69056F0", Offset = "0x69046F0", VA = "0x1869056F0", Slot = "7")]
	[AsyncStateMachine(typeof(MAJCEBBCOGO))]
	protected override Task OKLNDOMKEEE(MOMAGAAAECB ODBAMDFPOKB, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task ICJJIGMMLIE(MOMAGAAAECB ODBAMDFPOKB, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD);

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x69055B0", Offset = "0x69045B0", VA = "0x1869055B0")]
	[AsyncStateMachine(typeof(LOOGDNPNEFI))]
	private Task HFCPMKAMDBD(IDisposable CHLBEJOAMGM, KAABJCANIOP DGJBBGCPIHF, NENCAGLHEIB<string>.OGJMFKKDMDA OCBBLMCOHCB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
internal class GDBIONMAHEE : NINLEEMOEAG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private struct GGAFADLBOBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public GDBIONMAHEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public MOMAGAAAECB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private TaskAwaiter<EIIHNOKEGGJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x6905BF0", Offset = "0x6904BF0", VA = "0x186905BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x6906160", Offset = "0x6905160", VA = "0x186906160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400039F")]
	private readonly JDGAAOKDGFM CMMMKALOAEA;

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x6905B50", Offset = "0x6904B50", VA = "0x186905B50")]
	public GDBIONMAHEE(Guid IDKMDFCBEHN, IONKJBLKHOH CPMFHDAOGEO, CKGLENOBMMP PBKLEPKPAJE, JDGAAOKDGFM CMMMKALOAEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x6905950", Offset = "0x6904950", VA = "0x186905950", Slot = "6")]
	protected override string KCNFNDDBNKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x6905A30", Offset = "0x6904A30", VA = "0x186905A30", Slot = "7")]
	[AsyncStateMachine(typeof(GGAFADLBOBD))]
	protected override Task OKLNDOMKEEE(MOMAGAAAECB ODBAMDFPOKB, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
internal abstract class NINLEEMOEAG : DBEEHEKLCBO
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	public delegate Task CFJAEJBCPIL(NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD);

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private sealed class AAHPNJHHELC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public NINLEEMOEAG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public AAHPNJHHELC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x68FEEF0", Offset = "0x68FDEF0", VA = "0x1868FEEF0")]
		internal Task FKMMHOCIGKM(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private sealed class JHEDHACBPIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public AAHPNJHHELC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public JHEDHACBPIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x690ADF0", Offset = "0x6909DF0", VA = "0x18690ADF0")]
		internal object JDJDFNGNLHD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x690AD30", Offset = "0x6909D30", VA = "0x18690AD30")]
		internal object FCKFCCIPFPD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct NMCMJEDACAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public NINLEEMOEAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public Func<NINLEEMOEAG, NENCAGLHEIB<string>.OGJMFKKDMDA, MOMAGAAAECB> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private AAHPNJHHELC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private MOMAGAAAECB <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private TaskAwaiter<GCHMLLGGJOI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x6911B70", Offset = "0x6910B70", VA = "0x186911B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x6912D70", Offset = "0x6911D70", VA = "0x186912D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct OJLAHGKJGIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public Func<CancellationToken, Task> createDriverTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public Func<CancellationToken, Task> originalTaskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private CancellationTokenSource <driverCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private Task <driverTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private Task <originalTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x6913480", Offset = "0x6912480", VA = "0x186913480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x6913F10", Offset = "0x6912F10", VA = "0x186913F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private struct BDGEMLIAAJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public NINLEEMOEAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x68FFCB0", Offset = "0x68FECB0", VA = "0x1868FFCB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x6900010", Offset = "0x68FF010", VA = "0x186900010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public readonly Guid MEOKMLFOCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public readonly ByteString ICMJOCKCHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public readonly CKGLENOBMMP BLGEEEAHMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	protected readonly string CDDKKKJCPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	private readonly IONKJBLKHOH CPMFHDAOGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	private readonly bool IGMGOMGELJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	private readonly Queue<CFJAEJBCPIL> KEPPFBLFAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private readonly BEIPFBBPOOO PLFNIEOJBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	private readonly FGADKHHKFHK BLOFAJKGCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	private bool LIMAKLGNAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public OONPJIGGAPK ENDDKAIBPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public OONPJIGGAPK DGBCMAIKHJA;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public IONKJBLKHOH NIKBLBDBJJM
	{
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x7C4120", Offset = "0x7C3120", VA = "0x1807C4120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public DBOAJANNPMM BNJIHDAPCGF
	{
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x6911590", Offset = "0x6910590", VA = "0x186911590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public GLLEMKBOHHA KCPDHLOFPKI
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x69119A0", Offset = "0x69109A0", VA = "0x1869119A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public LJGNJILFANM DDLGOMBBCHN
	{
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x6911920", Offset = "0x6910920", VA = "0x186911920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event LLFLHEDIPMN BLGPCMFEJPM
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x6911570", Offset = "0x6910570", VA = "0x186911570", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x69119F0", Offset = "0x69109F0", VA = "0x1869119F0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x6911A10", Offset = "0x6910A10", VA = "0x186911A10")]
	protected NINLEEMOEAG(Guid IDKMDFCBEHN, IONKJBLKHOH CPMFHDAOGEO, CKGLENOBMMP PBKLEPKPAJE, string JDMJMNDHOEC, FGADKHHKFHK BLOFAJKGCBC, bool IGMGOMGELJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x69117C0", Offset = "0x69107C0", VA = "0x1869117C0", Slot = "6")]
	protected virtual string KCNFNDDBNKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x69110A0", Offset = "0x69100A0", VA = "0x1869110A0")]
	public void AAFJFAKMJOE(CFJAEJBCPIL JKBOPINACMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x6911250", Offset = "0x6910250", VA = "0x186911250")]
	protected void APCKNMPMCFB(float FBGJMCPJFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x6911100", Offset = "0x6910100", VA = "0x186911100")]
	[AsyncStateMachine(typeof(NMCMJEDACAE))]
	public Task AOFLBJDIDMG(CancellationToken GHLJDIEPICD, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, [Optional] Func<NINLEEMOEAG, NENCAGLHEIB<string>.OGJMFKKDMDA, MOMAGAAAECB> CJKEIHKKCCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x69112F0", Offset = "0x69102F0", VA = "0x1869112F0")]
	[AsyncStateMachine(typeof(OJLAHGKJGIB))]
	private static Task CDFKFLJGMPA(Func<CancellationToken, Task> ANKEAENEBHK, Func<CancellationToken, Task> EFEHNOGONBB, CancellationToken ICHNHGHOBPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x6911420", Offset = "0x6910420", VA = "0x186911420")]
	private void CGGONGIJBKJ(bool HBNABJDAFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x69116D0", Offset = "0x69106D0", VA = "0x1869116D0")]
	private void IOGHJJMEJKM(MOMAGAAAECB ODBAMDFPOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task OKLNDOMKEEE(MOMAGAAAECB ODBAMDFPOKB, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD);

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x6911800", Offset = "0x6910800", VA = "0x186911800")]
	[AsyncStateMachine(typeof(BDGEMLIAAJC))]
	private Task LAOCEGNKEMD(NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x6911270", Offset = "0x6910270", VA = "0x186911270")]
	public GCHMLLGGJOI BICAACALDFL(GHAPMBGDDIL ELEOJPJDIGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x69115E0", Offset = "0x69105E0", VA = "0x1869115E0")]
	[CompilerGenerated]
	private Task FFMEMBGPIBP(CancellationToken DCCCOAOAGBH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
internal sealed class HANEPJKICFK : FOHHPPLFJBE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct KDPDFECLCBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public HANEPJKICFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public MOMAGAAAECB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private LDBJDOIIBIB <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private LBEDDPJACIK <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x690BD00", Offset = "0x690AD00", VA = "0x18690BD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x690C470", Offset = "0x690B470", VA = "0x18690C470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private readonly IKPHFCIJHCC CDPKILJDGHB;

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x6906C10", Offset = "0x6905C10", VA = "0x186906C10")]
	public HANEPJKICFK(Guid IDKMDFCBEHN, IONKJBLKHOH CPMFHDAOGEO, IKPHFCIJHCC CDPKILJDGHB, CKGLENOBMMP PBKLEPKPAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x6906AC0", Offset = "0x6905AC0", VA = "0x186906AC0", Slot = "8")]
	[AsyncStateMachine(typeof(KDPDFECLCBO))]
	protected override Task ICJJIGMMLIE(MOMAGAAAECB ODBAMDFPOKB, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
internal class ABJDMNPDADN : NINLEEMOEAG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct ONJIDENIMJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public ABJDMNPDADN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public MOMAGAAAECB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private TaskAwaiter<EIIHNOKEGGJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x6913F70", Offset = "0x6912F70", VA = "0x186913F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x6914320", Offset = "0x6913320", VA = "0x186914320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	private readonly string FBDDIKFEOLE;

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x68FF620", Offset = "0x68FE620", VA = "0x1868FF620")]
	public ABJDMNPDADN(Guid IDKMDFCBEHN, IONKJBLKHOH CPMFHDAOGEO, CKGLENOBMMP PBKLEPKPAJE, string FBDDIKFEOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x68FF510", Offset = "0x68FE510", VA = "0x1868FF510", Slot = "7")]
	[AsyncStateMachine(typeof(ONJIDENIMJA))]
	protected override Task OKLNDOMKEEE(MOMAGAAAECB ODBAMDFPOKB, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
internal class GMOAPHJGCHN : FOHHPPLFJBE
{
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class EOAANEFMMNL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000114")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public AsyncTaskMethodBuilder<GCHMLLGGJOI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			public EOAANEFMMNL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			private TaskAwaiter<EIIHNOKEGGJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			private TaskAwaiter<GCHMLLGGJOI> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0x6918410", Offset = "0x6917410", VA = "0x186918410", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x69188D0", Offset = "0x69178D0", VA = "0x1869188D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public GMOAPHJGCHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public NHKADONHMBA serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public NEMIIIGBPPE roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public EMBDJMOCHDN uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public JCEBIMDNGKK roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public EOAANEFMMNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x6903E60", Offset = "0x6902E60", VA = "0x186903E60")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<GCHMLLGGJOI> DCIEGLGILBP(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private struct MOHHPKNJMMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public GMOAPHJGCHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public MOMAGAAAECB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private EOAANEFMMNL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private LDBJDOIIBIB <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private LBEDDPJACIK <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private GCHMLLGGJOI <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private TaskAwaiter<GCHMLLGGJOI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x690FA90", Offset = "0x690EA90", VA = "0x18690FA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x69109F0", Offset = "0x690F9F0", VA = "0x1869109F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	private static readonly NDLEKAMCBHL LAGKGKDNMJM;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	private static readonly NDLEKAMCBHL IKEGOFMGLFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	private readonly int NDEJNLADIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	[CanBeNull]
	private readonly KEGLOPNPEGK HNKOCDGICOF;

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x6906930", Offset = "0x6905930", VA = "0x186906930")]
	public GMOAPHJGCHN(Guid IDKMDFCBEHN, IONKJBLKHOH CPMFHDAOGEO, int NDEJNLADIOH, KEGLOPNPEGK HNKOCDGICOF, CKGLENOBMMP PBKLEPKPAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x6906470", Offset = "0x6905470", VA = "0x186906470", Slot = "8")]
	[AsyncStateMachine(typeof(MOHHPKNJMMP))]
	protected override Task ICJJIGMMLIE(MOMAGAAAECB ODBAMDFPOKB, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x6906780", Offset = "0x6905780", VA = "0x186906780")]
	private void PHLJOBGNJBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x69065B0", Offset = "0x69055B0", VA = "0x1869065B0")]
	private void JBCIGGKAHAO(NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, LDBJDOIIBIB JAKPAOCDOEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
internal abstract class KKLLGPKABGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public readonly NINLEEMOEAG POBAGANEMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public readonly MOMAGAAAECB OPJDJFBBLOC;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public DBOAJANNPMM BNJIHDAPCGF
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x690C970", Offset = "0x690B970", VA = "0x18690C970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public LJGNJILFANM DDLGOMBBCHN
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x690C9E0", Offset = "0x690B9E0", VA = "0x18690C9E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x690CA70", Offset = "0x690BA70", VA = "0x18690CA70")]
	protected KKLLGPKABGL(MOMAGAAAECB ODBAMDFPOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x690C9C0", Offset = "0x690B9C0", VA = "0x18690C9C0")]
	protected void HEFADAFEBPD(string MEKCKBOEMKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal struct JAGJGNGCDIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public Dictionary<Guid, List<HJDAJIGEOIG>> BDDFMGPCNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public Dictionary<Guid, List<HJDAJIGEOIG>> MEFHGCEAKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public Dictionary<Guid, List<HJDAJIGEOIG>> CJFJKNHFDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public List<Guid> AIMEIJFHJGA;

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x6909320", Offset = "0x6908320", VA = "0x186909320")]
	public static JAGJGNGCDIJ HBEPMKJLJFA(DBOAJANNPMM AKJKFGAFELN, OONPJIGGAPK PPHCJJJKLKN, DJJMNPKHNKF FPEFIIKFLDA)
	{
		return default(JAGJGNGCDIJ);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000119")]
internal struct GLHOMKANFFO
{
	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00")]
	public static GLHOMKANFFO EOFBBDOECDH()
	{
		return default(GLHOMKANFFO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal struct DDADELLHGIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public readonly KPBKEDCLNDD FMGHPDGBBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public readonly ENIOJCHHHIB MKFPKFMEJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public readonly string GBIPICNEONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public readonly OAKJFJKJCNE JEGJKPFGCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public readonly OAKJFJKJCNE AODPHMPACBN;

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x6900CA0", Offset = "0x68FFCA0", VA = "0x186900CA0")]
	public DDADELLHGIF(KPBKEDCLNDD FMGHPDGBBJI, ENIOJCHHHIB MKFPKFMEJCP, string GBIPICNEONK, OAKJFJKJCNE JEGJKPFGCEN, OAKJFJKJCNE AODPHMPACBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal struct GJPDDDJLLFJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private readonly MOMAGAAAECB ODBAMDFPOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private readonly Guid HOGEIINGBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	private bool HBNABJDAFPH;

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x69063C0", Offset = "0x69053C0", VA = "0x1869063C0")]
	public static GJPDDDJLLFJ MNFAHLCKBPM(MOMAGAAAECB ODBAMDFPOKB)
	{
		return default(GJPDDDJLLFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x845E10", Offset = "0x844E10", VA = "0x180845E10")]
	public void JANKKGPFENK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x69062C0", Offset = "0x69052C0", VA = "0x1869062C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x6906420", Offset = "0x6905420", VA = "0x186906420")]
	private GJPDDDJLLFJ(MOMAGAAAECB ODBAMDFPOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x69062C0", Offset = "0x69052C0", VA = "0x1869062C0")]
	private void GOJDENELBKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x6906320", Offset = "0x6905320", VA = "0x186906320")]
	private Func<Guid, bool> FHLCLNFIFPD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
internal class LBEDDPJACIK : KKLLGPKABGL, DBEEHEKLCBO
{
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	public delegate Task<OONPJIGGAPK> GJHMENNMIIO(DJJMNPKHNKF GPKMLHOONCL, EGMMGMPJFHP ICODMLMDDIO, BEIPFBBPOOO CPGMMJFAHHO, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private struct FMPGKHENLDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public LBEDDPJACIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public IKPHFCIJHCC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private GJPDDDJLLFJ <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private TaskAwaiter<GCHMLLGGJOI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x6904DE0", Offset = "0x6903DE0", VA = "0x186904DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x6905550", Offset = "0x6904550", VA = "0x186905550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private struct EHMDNCEHJGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public AsyncTaskMethodBuilder<GCHMLLGGJOI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public LBEDDPJACIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public IKPHFCIJHCC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private TaskAwaiter<GCHMLLGGJOI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x6903100", Offset = "0x6902100", VA = "0x186903100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x6903510", Offset = "0x6902510", VA = "0x186903510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private struct AAOCDJBALHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public LBEDDPJACIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public IKPHFCIJHCC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x68FF020", Offset = "0x68FE020", VA = "0x1868FF020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x68FF4B0", Offset = "0x68FE4B0", VA = "0x1868FF4B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private sealed class NCBNFMBDBJB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000122")]
		private struct <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			public AsyncTaskMethodBuilder<DDADELLHGIF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			public NCBNFMBDBJB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			private DDADELLHGIF <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			private TaskAwaiter<OONPJIGGAPK> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			private TaskAwaiter<DDADELLHGIF> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0x6916AD0", Offset = "0x6915AD0", VA = "0x186916AD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FC")]
			[Cpp2IlInjected.Address(RVA = "0x6917260", Offset = "0x6916260", VA = "0x186917260", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000123")]
		private struct <<LoadRoomLocal>b__4>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			public AsyncTaskMethodBuilder<DJJMNPKHNKF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public NCBNFMBDBJB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			private DJJMNPKHNKF <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			private TaskAwaiter<OONPJIGGAPK> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			private TaskAwaiter<DJJMNPKHNKF> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004FD")]
			[Cpp2IlInjected.Address(RVA = "0x69172D0", Offset = "0x69162D0", VA = "0x1869172D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FE")]
			[Cpp2IlInjected.Address(RVA = "0x6917920", Offset = "0x6916920", VA = "0x186917920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000124")]
		private struct <<LoadRoomLocal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			public NCBNFMBDBJB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			private TaskAwaiter<OONPJIGGAPK> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			private EGMMGMPJFHP <timedYielder>5__2;

			[Cpp2IlInjected.Token(Token = "0x60004FF")]
			[Cpp2IlInjected.Address(RVA = "0x6915730", Offset = "0x6914730", VA = "0x186915730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000500")]
			[Cpp2IlInjected.Address(RVA = "0x6916A70", Offset = "0x6915A70", VA = "0x186916A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public LBEDDPJACIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public IKPHFCIJHCC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public BEIPFBBPOOO preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public BEIPFBBPOOO downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public DDADELLHGIF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public BEIPFBBPOOO postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public DJJMNPKHNKF phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public GCFEKEDMOAJ.IKALHOMOJKH <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public NCBNFMBDBJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x6910F60", Offset = "0x690FF60", VA = "0x186910F60")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<DDADELLHGIF> DCPNFOAAONC(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x6910D00", Offset = "0x690FD00", VA = "0x186910D00")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<DJJMNPKHNKF> BBLOHPMFMAN(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x6910F20", Offset = "0x690FF20", VA = "0x186910F20")]
		internal void DAEGHEAKOOI(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x6910E20", Offset = "0x690FE20", VA = "0x186910E20")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task BDJPDKPGEIB(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct JCOPADDADJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public LBEDDPJACIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public IKPHFCIJHCC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private NCBNFMBDBJB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private TaskAwaiter<DDADELLHGIF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private TaskAwaiter<DJJMNPKHNKF> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x6909A70", Offset = "0x6908A70", VA = "0x186909A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x690A680", Offset = "0x6909680", VA = "0x18690A680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct EIBLFAMPDFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public LBEDDPJACIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x6903580", Offset = "0x6902580", VA = "0x186903580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x6903CC0", Offset = "0x6902CC0", VA = "0x186903CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct PNGDPAEBDMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public LBEDDPJACIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public DJJMNPKHNKF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public BEIPFBBPOOO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		private TaskAwaiter<OONPJIGGAPK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x6914D70", Offset = "0x6913D70", VA = "0x186914D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x69156D0", Offset = "0x69146D0", VA = "0x1869156D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct EAMJPMECNME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public AsyncTaskMethodBuilder<OONPJIGGAPK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public LBEDDPJACIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public DJJMNPKHNKF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public BEIPFBBPOOO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private TaskAwaiter<OONPJIGGAPK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x6901530", Offset = "0x6900530", VA = "0x186901530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x69026B0", Offset = "0x69016B0", VA = "0x1869026B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct HFMDFFIAMLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public AsyncTaskMethodBuilder<OONPJIGGAPK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public LBEDDPJACIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public DJJMNPKHNKF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public BEIPFBBPOOO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public EGMMGMPJFHP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private TaskAwaiter<OONPJIGGAPK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x6906CC0", Offset = "0x6905CC0", VA = "0x186906CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x6908080", Offset = "0x6907080", VA = "0x186908080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct JECHLOBKIDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public AsyncTaskMethodBuilder<OONPJIGGAPK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public LBEDDPJACIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public OONPJIGGAPK operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public BEIPFBBPOOO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public DJJMNPKHNKF deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		private TaskAwaiter<OONPJIGGAPK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x690A6E0", Offset = "0x69096E0", VA = "0x18690A6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x690A970", Offset = "0x6909970", VA = "0x18690A970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private sealed class NPOLANOMDBH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012D")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000497")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			public AsyncTaskMethodBuilder<OONPJIGGAPK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			public NPOLANOMDBH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400049A")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400049B")]
			private BEAMBDPEGJL <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400049C")]
			private TaskAwaiter<OONPJIGGAPK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0x6917990", Offset = "0x6916990", VA = "0x186917990", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000516")]
			[Cpp2IlInjected.Address(RVA = "0x6917FB0", Offset = "0x6916FB0", VA = "0x186917FB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public LBEDDPJACIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public DJJMNPKHNKF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public BEIPFBBPOOO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public GJHMENNMIIO masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public EGMMGMPJFHP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public OONPJIGGAPK originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public NPOLANOMDBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x6913360", Offset = "0x6912360", VA = "0x186913360")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<OONPJIGGAPK> IPPIJDPDPKG(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct AEKABCJBOPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public AsyncTaskMethodBuilder<OONPJIGGAPK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public LBEDDPJACIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public DJJMNPKHNKF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public BEIPFBBPOOO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public GJHMENNMIIO masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public EGMMGMPJFHP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private BEAMBDPEGJL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private TaskAwaiter<OONPJIGGAPK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x68FF740", Offset = "0x68FE740", VA = "0x1868FF740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x68FFC40", Offset = "0x68FEC40", VA = "0x1868FFC40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct NMDFPCEBPAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public LBEDDPJACIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public DJJMNPKHNKF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public BEIPFBBPOOO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private OONPJIGGAPK <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private IEnumerator<OONPJIGGAPK> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private TaskAwaiter<OONPJIGGAPK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x6912DD0", Offset = "0x6911DD0", VA = "0x186912DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x6913300", Offset = "0x6912300", VA = "0x186913300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct FEPDDDLJHMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public LBEDDPJACIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public DJJMNPKHNKF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x6903F80", Offset = "0x6902F80", VA = "0x186903F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x6904290", Offset = "0x6903290", VA = "0x186904290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private struct MOKCPCHIGAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public LBEDDPJACIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public DJJMNPKHNKF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x6910A50", Offset = "0x690FA50", VA = "0x186910A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x6910CA0", Offset = "0x690FCA0", VA = "0x186910CA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private readonly PIOKGJKNCFA FEPFIEPAJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	private readonly PIOKGJKNCFA FEODIMAMIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private readonly AAGLIDGLEOO LGAJGGNOGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private readonly OECOCIOAHAK IHPMDEDDLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000419")]
	private readonly ICACECALPCL CGDAFDHDMFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400041A")]
	private readonly HDMJGNJENFH BFBFBKPCEIB;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private IONKJBLKHOH NIKBLBDBJJM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x690DDB0", Offset = "0x690CDB0", VA = "0x18690DDB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event LLFLHEDIPMN BLGPCMFEJPM
	{
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x690D6A0", Offset = "0x690C6A0", VA = "0x18690D6A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x690E3C0", Offset = "0x690D3C0", VA = "0x18690E3C0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x690E680", Offset = "0x690D680", VA = "0x18690E680")]
	public LBEDDPJACIK(MOMAGAAAECB ODBAMDFPOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x690CFD0", Offset = "0x690BFD0", VA = "0x18690CFD0")]
	[AsyncStateMachine(typeof(FMPGKHENLDN))]
	public Task AGANPANAGGL(IKPHFCIJHCC MJJCOLDOFAC, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x690D280", Offset = "0x690C280", VA = "0x18690D280")]
	[AsyncStateMachine(typeof(EHMDNCEHJGA))]
	private Task<GCHMLLGGJOI> BEFGCCGGKCK(IKPHFCIJHCC MJJCOLDOFAC, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x690D6C0", Offset = "0x690C6C0", VA = "0x18690D6C0")]
	[AsyncStateMachine(typeof(AAOCDJBALHC))]
	private Task EFPKFADFFIB(IKPHFCIJHCC MJJCOLDOFAC, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x690E020", Offset = "0x690D020", VA = "0x18690E020")]
	[AsyncStateMachine(typeof(JCOPADDADJM))]
	private Task IFJPIKALBFH(IKPHFCIJHCC MJJCOLDOFAC, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken PLEDLIIHGAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x690DEF0", Offset = "0x690CEF0", VA = "0x18690DEF0")]
	[AsyncStateMachine(typeof(EIBLFAMPDFP))]
	private Task GOOKPPJAEOD(NENCAGLHEIB<string>.OGJMFKKDMDA OCBBLMCOHCB, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x690E530", Offset = "0x690D530", VA = "0x18690E530")]
	[AsyncStateMachine(typeof(PNGDPAEBDMH))]
	private Task PPPIKDOHLBL(DJJMNPKHNKF GPKMLHOONCL, BEIPFBBPOOO CPGMMJFAHHO, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x690DAC0", Offset = "0x690CAC0", VA = "0x18690DAC0")]
	[AsyncStateMachine(typeof(EAMJPMECNME))]
	private Task<OONPJIGGAPK> FOPKDEJIELF(DJJMNPKHNKF GPKMLHOONCL, EGMMGMPJFHP PCGPALCKNAJ, BEIPFBBPOOO CPGMMJFAHHO, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x690E1F0", Offset = "0x690D1F0", VA = "0x18690E1F0")]
	[AsyncStateMachine(typeof(HFMDFFIAMLI))]
	private Task<OONPJIGGAPK> LLGCBLDAMMN(DJJMNPKHNKF GPKMLHOONCL, EGMMGMPJFHP PCGPALCKNAJ, BEIPFBBPOOO CPGMMJFAHHO, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x690D520", Offset = "0x690C520", VA = "0x18690D520")]
	[AsyncStateMachine(typeof(JECHLOBKIDO))]
	private Task<OONPJIGGAPK> DNIGJONOLBP(OONPJIGGAPK PPHCJJJKLKN, DJJMNPKHNKF FPEFIIKFLDA, BEIPFBBPOOO CPGMMJFAHHO, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD, bool JNLANEFFDLJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x690D990", Offset = "0x690C990", VA = "0x18690D990")]
	private bool FEPMGDOHLPC(DJJMNPKHNKF GFMAEHMANMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x690DC20", Offset = "0x690CC20", VA = "0x18690DC20")]
	[AsyncStateMachine(typeof(AEKABCJBOPN))]
	protected Task<OONPJIGGAPK> GHBPBLBEKDA(DJJMNPKHNKF GPKMLHOONCL, EGMMGMPJFHP PCGPALCKNAJ, BEIPFBBPOOO CPGMMJFAHHO, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD, GJHMENNMIIO PHOKKLLJDFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x690D800", Offset = "0x690C800", VA = "0x18690D800")]
	[AsyncStateMachine(typeof(NMDFPCEBPAM))]
	private Task EGPGOAPGDPC(DJJMNPKHNKF GPKMLHOONCL, BEIPFBBPOOO CPGMMJFAHHO, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x690E370", Offset = "0x690D370", VA = "0x18690E370")]
	private void MALCNKNDAPG(OONPJIGGAPK FHMOJDNCJAP, BEIPFBBPOOO CPGMMJFAHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x690E1B0", Offset = "0x690D1B0", VA = "0x18690E1B0")]
	private void KAKPMEHKJAB(OONPJIGGAPK MJLIHAKBFML, [Out] OONPJIGGAPK JALLEBFGKMN, [Out] OONPJIGGAPK OCKOGBPGLJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x690DA80", Offset = "0x690CA80", VA = "0x18690DA80")]
	private Task<DDADELLHGIF> FFHCDOONALK(IKPHFCIJHCC MJJCOLDOFAC, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x690D950", Offset = "0x690C950", VA = "0x18690D950")]
	private Task<DJJMNPKHNKF> FCMKCIMDDHH(DDADELLHGIF GPKMLHOONCL, GCFEKEDMOAJ.IKALHOMOJKH LCLHDGLKCAE, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x690E3E0", Offset = "0x690D3E0", VA = "0x18690E3E0")]
	[AsyncStateMachine(typeof(FEPDDDLJHMM))]
	private Task PMOHMNAGKKC(DJJMNPKHNKF GPKMLHOONCL, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD, bool EMHALLKNNPF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x690DDE0", Offset = "0x690CDE0", VA = "0x18690DDE0")]
	[AsyncStateMachine(typeof(MOKCPCHIGAB))]
	private Task GJAKKJAECPC(DJJMNPKHNKF GPKMLHOONCL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x690D3E0", Offset = "0x690C3E0", VA = "0x18690D3E0")]
	private Task BGEIIJDOKAN(DJJMNPKHNKF GPKMLHOONCL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x690CFB0", Offset = "0x690BFB0", VA = "0x18690CFB0")]
	private Task ACCCMGAPABE(DJJMNPKHNKF GPKMLHOONCL, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x690DED0", Offset = "0x690CED0", VA = "0x18690DED0")]
	private Task GLOOMJPDBLD(DJJMNPKHNKF GPKMLHOONCL, EGMMGMPJFHP PCGPALCKNAJ, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x690CE60", Offset = "0x690BE60", VA = "0x18690CE60")]
	private Task ABDHHKHBANF(DJJMNPKHNKF GPKMLHOONCL, EGMMGMPJFHP PCGPALCKNAJ, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x69069E0", Offset = "0x69059E0", VA = "0x1869069E0")]
	private static Task IAJOCOCGDLC(CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x690D260", Offset = "0x690C260", VA = "0x18690D260")]
	private Task AOOFLBFANKO(DJJMNPKHNKF GPKMLHOONCL, EGMMGMPJFHP PCGPALCKNAJ, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x690D120", Offset = "0x690C120", VA = "0x18690D120")]
	private Task AMLHNBJMOBN(DJJMNPKHNKF GPKMLHOONCL, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x690E160", Offset = "0x690D160", VA = "0x18690E160")]
	private void IJLBHBLBGPP(IKPHFCIJHCC MJJCOLDOFAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x690E000", Offset = "0x690D000", VA = "0x18690E000")]
	public void HAFDODCKECP(long MPIGBBCKJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
	private static void KGKGGBBLICJ(KPBKEDCLNDD FMGHPDGBBJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal struct JEKJIMGNIFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	private IONKJBLKHOH CPMFHDAOGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	private DJJMNPKHNKF GPKMLHOONCL;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private DBOAJANNPMM BNJIHDAPCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x690ACE0", Offset = "0x6909CE0", VA = "0x18690ACE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x690AC00", Offset = "0x6909C00", VA = "0x18690AC00")]
	public static Task AOFLBJDIDMG(IONKJBLKHOH CPMFHDAOGEO, DJJMNPKHNKF GPKMLHOONCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x690A9E0", Offset = "0x69099E0", VA = "0x18690A9E0")]
	private void AOFLBJDIDMG()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal struct HAADKLHBPMA
{
	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x69069E0", Offset = "0x69059E0", VA = "0x1869069E0")]
	public static Task AOFLBJDIDMG(CancellationToken GHLJDIEPICD)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000134")]
internal struct EJBMEACBAJL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct HHFBNIAIAHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public MOMAGAAAECB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public DJJMNPKHNKF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private BEAMBDPEGJL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x69080F0", Offset = "0x69070F0", VA = "0x1869080F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x6908610", Offset = "0x6907610", VA = "0x186908610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x6903D20", Offset = "0x6902D20", VA = "0x186903D20")]
	[AsyncStateMachine(typeof(HHFBNIAIAHB))]
	public static Task AOFLBJDIDMG(MOMAGAAAECB ODBAMDFPOKB, DJJMNPKHNKF GPKMLHOONCL, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal struct LOKILOMCJIN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct JPMIPCOKAJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public MOMAGAAAECB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public DJJMNPKHNKF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public EGMMGMPJFHP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private OONPJIGGAPK <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private IONKJBLKHOH <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private DBOAJANNPMM <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private BEAMBDPEGJL <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private List<(PersistenceView, FFFNEPAFGPP)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private FFFNEPAFGPP <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x690AEB0", Offset = "0x6909EB0", VA = "0x18690AEB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x690BB10", Offset = "0x690AB10", VA = "0x18690BB10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x690E930", Offset = "0x690D930", VA = "0x18690E930")]
	[AsyncStateMachine(typeof(JPMIPCOKAJE))]
	public static Task AOFLBJDIDMG(MOMAGAAAECB ODBAMDFPOKB, DJJMNPKHNKF GPKMLHOONCL, EGMMGMPJFHP PCGPALCKNAJ, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x690EA80", Offset = "0x690DA80", VA = "0x18690EA80")]
	private static void PGFPNJGHHGI(PersistenceView DNJBPCJBPNH, FFFNEPAFGPP DKFEECFJOGP, DJJMNPKHNKF GPKMLHOONCL, OONPJIGGAPK PPHCJJJKLKN, bool BLJAJODNGFF)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct INMLGPDEMBM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private struct KEJAMOCEKPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public IONKJBLKHOH roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public DJJMNPKHNKF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x690C4D0", Offset = "0x690B4D0", VA = "0x18690C4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x690C910", Offset = "0x690B910", VA = "0x18690C910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x6909210", Offset = "0x6908210", VA = "0x186909210")]
	[AsyncStateMachine(typeof(KEJAMOCEKPL))]
	public static Task AOFLBJDIDMG(IONKJBLKHOH CPMFHDAOGEO, DJJMNPKHNKF GPKMLHOONCL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct FKOOBKHFJAJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct ICGCEEOEDOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public IONKJBLKHOH roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public DJJMNPKHNKF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public MOMAGAAAECB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x6908FA0", Offset = "0x6907FA0", VA = "0x186908FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x69091B0", Offset = "0x69081B0", VA = "0x1869091B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private sealed class CFKDDLNJIMD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200013E")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004F2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004F3")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004F4")]
			public NENCAGLHEIB<string>.OGJMFKKDMDA timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F5")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004F6")]
			public CFKDDLNJIMD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004F7")]
			private NENCAGLHEIB<string>.OGJMFKKDMDA <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004F8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600053B")]
			[Cpp2IlInjected.Address(RVA = "0x6918020", Offset = "0x6917020", VA = "0x186918020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053C")]
			[Cpp2IlInjected.Address(RVA = "0x69183B0", Offset = "0x69173B0", VA = "0x1869183B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public CFKDDLNJIMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x6900B80", Offset = "0x68FFB80", VA = "0x186900B80")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task PCEOGGHBFFD(NENCAGLHEIB<string>.OGJMFKKDMDA timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private struct BLHFLOPKMOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public FKOOBKHFJAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		private BEAMBDPEGJL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private TaskAwaiter<GCHMLLGGJOI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x6900070", Offset = "0x68FF070", VA = "0x186900070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x69009D0", Offset = "0x68FF9D0", VA = "0x1869009D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private sealed class JPMJMLENABG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public ICALOLDGKCF version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public JPMJMLENABG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x690BB70", Offset = "0x690AB70", VA = "0x18690BB70")]
		internal object BGNFLMMHCIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x690BC50", Offset = "0x690AC50", VA = "0x18690BC50")]
		internal object CFLEDPIBEND()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private IONKJBLKHOH CPMFHDAOGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	private DJJMNPKHNKF GPKMLHOONCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	private MOMAGAAAECB ODBAMDFPOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	private bool EMHALLKNNPF;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	private static readonly ByteString PLAJBGKDHLI;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private DBOAJANNPMM BNJIHDAPCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x6904580", Offset = "0x6903580", VA = "0x186904580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private LJGNJILFANM DDLGOMBBCHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x6904C70", Offset = "0x6903C70", VA = "0x186904C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x6904430", Offset = "0x6903430", VA = "0x186904430")]
	[AsyncStateMachine(typeof(ICGCEEOEDOA))]
	public static Task AOFLBJDIDMG(IONKJBLKHOH CPMFHDAOGEO, DJJMNPKHNKF GPKMLHOONCL, MOMAGAAAECB ODBAMDFPOKB, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD, bool EMHALLKNNPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x69042F0", Offset = "0x69032F0", VA = "0x1869042F0")]
	[AsyncStateMachine(typeof(BLHFLOPKMOA))]
	private Task AOFLBJDIDMG(NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x69045D0", Offset = "0x69035D0", VA = "0x1869045D0")]
	private void GNFGBPNGJMM([NotNull] OJAAFLOIAIF OIJIGDPADIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x6904D10", Offset = "0x6903D10", VA = "0x186904D10")]
	private bool NMNPGPCPJIE(ICALOLDGKCF OECHNNBOAGJ, OJAAFLOIAIF OIJIGDPADIG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
internal struct PGOPKMBOKKH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private struct PIFGDDGLLGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public AsyncTaskMethodBuilder<DJJMNPKHNKF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public PGOPKMBOKKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public GCFEKEDMOAJ.IKALHOMOJKH downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private BEAMBDPEGJL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private TaskAwaiter<(PGLGENBDGKP<OGMAALPGOBF, HBNEILLBGHD>, PGLGENBDGKP<MAHHFMJICFI<OJAAFLOIAIF>, HBNEILLBGHD>, PGLGENBDGKP<MAHHFMJICFI<FKEPIPDGFDA>, HBNEILLBGHD>, PGLGENBDGKP<MAHHFMJICFI<DNCLMLKIGIO>, HBNEILLBGHD>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x6930990", Offset = "0x692F990", VA = "0x186930990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x6931440", Offset = "0x6930440", VA = "0x186931440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct GLHMAKJOPII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public AsyncTaskMethodBuilder<PGLGENBDGKP<OGMAALPGOBF, HBNEILLBGHD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public PGOPKMBOKKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public GCFEKEDMOAJ.IKALHOMOJKH downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private BEAMBDPEGJL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private TaskAwaiter<PGLGENBDGKP<OGMAALPGOBF, HBNEILLBGHD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x691ED60", Offset = "0x691DD60", VA = "0x18691ED60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x691F370", Offset = "0x691E370", VA = "0x18691F370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000507")]
	private JGFNOPGJOLC<OAKJFJKJCNE, FKEPIPDGFDA> MJAANGLALNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	private JGFNOPGJOLC<OAKJFJKJCNE, OJAAFLOIAIF> PCFFINAKDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	private JGFNOPGJOLC<long, DNCLMLKIGIO> BPCOCOCFHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	private CBLAKJLFKGM NJMBPCLMCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	private KPBKEDCLNDD FMGHPDGBBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	private ENIOJCHHHIB MKFPKFMEJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	private string GBIPICNEONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	private OAKJFJKJCNE JEGJKPFGCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	private OAKJFJKJCNE AODPHMPACBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	private long MPIGBBCKJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private NENCAGLHEIB<string>.OGJMFKKDMDA OCBBLMCOHCB;

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x6930460", Offset = "0x692F460", VA = "0x186930460")]
	public static Task<DJJMNPKHNKF> EBONJIOAPJL(IONKJBLKHOH CPMFHDAOGEO, [In] DDADELLHGIF GPKMLHOONCL, GCFEKEDMOAJ.IKALHOMOJKH LCLHDGLKCAE, NENCAGLHEIB<string>.OGJMFKKDMDA OCBBLMCOHCB, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x69302D0", Offset = "0x692F2D0", VA = "0x1869302D0")]
	[AsyncStateMachine(typeof(PIFGDDGLLGH))]
	private Task<DJJMNPKHNKF> AOFLBJDIDMG(GCFEKEDMOAJ.IKALHOMOJKH LCLHDGLKCAE, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x69307D0", Offset = "0x692F7D0", VA = "0x1869307D0")]
	[AsyncStateMachine(typeof(GLHMAKJOPII))]
	private Task<PGLGENBDGKP<OGMAALPGOBF, HBNEILLBGHD>> FJFCKEHMACE(string GBIPICNEONK, long MPIGBBCKJJM, long? CFLPHBNCGDP, long? AKANBGAJAAH, GCFEKEDMOAJ.IKALHOMOJKH LCLHDGLKCAE, NENCAGLHEIB<string>.OGJMFKKDMDA KLEHDKGPLCB, CancellationToken GHLJDIEPICD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
internal struct GLIOCHHGBMH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct LLAKKFJGIPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public AsyncTaskMethodBuilder<DDADELLHGIF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public GLIOCHHGBMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private TaskAwaiter<DDADELLHGIF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x69294B0", Offset = "0x69284B0", VA = "0x1869294B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x69298B0", Offset = "0x69288B0", VA = "0x1869298B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct LDDDEDHABLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public AsyncTaskMethodBuilder<DDADELLHGIF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public GLIOCHHGBMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private TaskAwaiter<DDADELLHGIF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x6928710", Offset = "0x6927710", VA = "0x186928710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x6928B40", Offset = "0x6927B40", VA = "0x186928B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private sealed class JNILNKEKHLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public JNILNKEKHLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x15082A0", Offset = "0x15072A0", VA = "0x1815082A0")]
		internal bool HIHNEMOLCNP(ENIOJCHHHIB sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct JJLLEKJPECF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public AsyncTaskMethodBuilder<DDADELLHGIF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public OAKJFJKJCNE superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public DBOAJANNPMM callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private JNILNKEKHLG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public JPEOLCJKIBO roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private KPBKEDCLNDD <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private ENIOJCHHHIB <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private OAKJFJKJCNE <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		private OAKJFJKJCNE <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private TaskAwaiter<KPBKEDCLNDD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		private TaskAwaiter<JFNGOOKNNMM> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private TaskAwaiter<IPOEENMLOPF> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x6925800", Offset = "0x6924800", VA = "0x186925800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x6926940", Offset = "0x6925940", VA = "0x186926940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	private DBOAJANNPMM AKJKFGAFELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private AAGLIDGLEOO LGAJGGNOGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	private JPEOLCJKIBO NFJIIJDAOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private NENCAGLHEIB<string>.OGJMFKKDMDA OCBBLMCOHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	private long CFLPHBNCGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	private long CEJEMJLIMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	private long DOJEMLKPGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	private string FNMGFGJPBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	private OAKJFJKJCNE ODDMPOPADLG;

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x691F530", Offset = "0x691E530", VA = "0x18691F530")]
	public static Task<DDADELLHGIF> EBONJIOAPJL(IONKJBLKHOH CPMFHDAOGEO, IKPHFCIJHCC MJJCOLDOFAC, NENCAGLHEIB<string>.OGJMFKKDMDA OCBBLMCOHCB, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x691F3E0", Offset = "0x691E3E0", VA = "0x18691F3E0")]
	[AsyncStateMachine(typeof(LLAKKFJGIPM))]
	private Task<DDADELLHGIF> AOFLBJDIDMG(CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x691F7B0", Offset = "0x691E7B0", VA = "0x18691F7B0")]
	[AsyncStateMachine(typeof(LDDDEDHABLI))]
	private Task<DDADELLHGIF> FFHCDOONALK(NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x691F910", Offset = "0x691E910", VA = "0x18691F910")]
	[AsyncStateMachine(typeof(JJLLEKJPECF))]
	private static Task<DDADELLHGIF> FFHCDOONALK(DBOAJANNPMM AKJKFGAFELN, JPEOLCJKIBO NFJIIJDAOLL, long CFLPHBNCGDP, long CEJEMJLIMDC, long DOJEMLKPGCN, string FNMGFGJPBJD, OAKJFJKJCNE ODDMPOPADLG, CancellationToken GHLJDIEPICD, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x691FAB0", Offset = "0x691EAB0", VA = "0x18691FAB0")]
	private void ILHCBAFHKLN(KPBKEDCLNDD FMGHPDGBBJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
internal struct HACOFNPJJFK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct MGOCCBAGDCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public HACOFNPJJFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x692A570", Offset = "0x6929570", VA = "0x18692A570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x692AB00", Offset = "0x6929B00", VA = "0x18692AB00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	private DBOAJANNPMM AKJKFGAFELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	private DJJMNPKHNKF GPKMLHOONCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	private NENCAGLHEIB<string>.OGJMFKKDMDA OCBBLMCOHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	private float IBBDFEACEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	private float BDBPHFNJBJO;

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x69208A0", Offset = "0x691F8A0", VA = "0x1869208A0")]
	public static Task HBHPCAAJHHH(IONKJBLKHOH CPMFHDAOGEO, DJJMNPKHNKF GPKMLHOONCL, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x6920580", Offset = "0x691F580", VA = "0x186920580")]
	[AsyncStateMachine(typeof(MGOCCBAGDCN))]
	public Task AOFLBJDIDMG(CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x6920760", Offset = "0x691F760", VA = "0x186920760")]
	private static void EMMBOMJCPGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x6920A40", Offset = "0x691FA40", VA = "0x186920A40")]
	private void PHMJKDNPPGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x69206A0", Offset = "0x691F6A0", VA = "0x1869206A0")]
	private static float EEFPCBDGGLJ(DBOAJANNPMM AKJKFGAFELN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x6920BA0", Offset = "0x691FBA0", VA = "0x186920BA0")]
	private static float PNDHJPDFIIP()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014C")]
internal struct PBJCLDIOKEI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct DNMCENLLHOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public MOMAGAAAECB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public DJJMNPKHNKF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		private BEAMBDPEGJL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		private NINLEEMOEAG <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private IONKJBLKHOH <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private IDDNOGBDJII.CFBDAOCNKDJ <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private TaskAwaiter<GCHMLLGGJOI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x691C760", Offset = "0x691B760", VA = "0x18691C760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x691D100", Offset = "0x691C100", VA = "0x18691D100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private struct DCEEIFKMDPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private BEAMBDPEGJL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x691ADD0", Offset = "0x6919DD0", VA = "0x18691ADD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x691B0C0", Offset = "0x691A0C0", VA = "0x18691B0C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x69300D0", Offset = "0x692F0D0", VA = "0x1869300D0")]
	[AsyncStateMachine(typeof(DNMCENLLHOD))]
	public static Task AOFLBJDIDMG(MOMAGAAAECB ODBAMDFPOKB, DJJMNPKHNKF GPKMLHOONCL, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x6930060", Offset = "0x692F060", VA = "0x186930060")]
	private static Task<GCHMLLGGJOI> AFIONFMMHCF(MOMAGAAAECB ODBAMDFPOKB, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x6930210", Offset = "0x692F210", VA = "0x186930210")]
	[AsyncStateMachine(typeof(DCEEIFKMDPA))]
	private static Task CBBFJJOFLIC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014F")]
internal struct DCFNHJHCEBF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct GPACANEFBCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public DCFNHJHCEBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x691FE70", Offset = "0x691EE70", VA = "0x18691FE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x6920520", Offset = "0x691F520", VA = "0x186920520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private sealed class NAMIDGKOGJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public NAMIDGKOGJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x692AB60", Offset = "0x6929B60", VA = "0x18692AB60")]
		internal object BMDKLMOEMEN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct JBPHPBLIGPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public DCFNHJHCEBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private BEAMBDPEGJL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private LNENOGOJENC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x69249C0", Offset = "0x69239C0", VA = "0x1869249C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x6924F80", Offset = "0x6923F80", VA = "0x186924F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000571")]
	private bool JGAMHDMEIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000572")]
	private NENCAGLHEIB<string>.OGJMFKKDMDA OCBBLMCOHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000573")]
	private IONKJBLKHOH CPMFHDAOGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000574")]
	private CancellationToken GHLJDIEPICD;

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x691B210", Offset = "0x691A210", VA = "0x18691B210")]
	public static Task CGNPLKPNFED(IONKJBLKHOH CPMFHDAOGEO, bool JGAMHDMEIAP, NENCAGLHEIB<string>.OGJMFKKDMDA OCBBLMCOHCB, CancellationToken MDHGKEDAODJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x691B120", Offset = "0x691A120", VA = "0x18691B120")]
	[AsyncStateMachine(typeof(GPACANEFBCI))]
	private Task AOFLBJDIDMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x691B280", Offset = "0x691A280", VA = "0x18691B280")]
	[AsyncStateMachine(typeof(JBPHPBLIGPM))]
	private Task NFDEGKLIIBJ(bool DKCODGHGAEK, string DGPOLNCNDIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00")]
	private bool EADHBNAOHKC(bool JGAMHDMEIAP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000153")]
internal struct GMNINCEAHJC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct JBIHHDKDCIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public GMNINCEAHJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x6923D00", Offset = "0x6922D00", VA = "0x186923D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x6924270", Offset = "0x6923270", VA = "0x186924270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private sealed class MCKKIHPGIEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public MCKKIHPGIEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x6929F90", Offset = "0x6928F90", VA = "0x186929F90")]
		internal object BMDKLMOEMEN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct OMBJIMFKGGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public GMNINCEAHJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		private BEAMBDPEGJL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private LNENOGOJENC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x692F980", Offset = "0x692E980", VA = "0x18692F980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x692FF40", Offset = "0x692EF40", VA = "0x18692FF40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000585")]
	private IAGELFGALDI KPKJJFJDFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000586")]
	private NENCAGLHEIB<string>.OGJMFKKDMDA OCBBLMCOHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000587")]
	private IONKJBLKHOH CPMFHDAOGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000588")]
	private bool PAEGFDMFBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000589")]
	private DJJMNPKHNKF GPKMLHOONCL;

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x691FCA0", Offset = "0x691ECA0", VA = "0x18691FCA0")]
	public static Task<Scene> KIOOKONMCJE(IONKJBLKHOH CPMFHDAOGEO, IAGELFGALDI FDLJCIPALNC, NENCAGLHEIB<string>.OGJMFKKDMDA OCBBLMCOHCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x691FB10", Offset = "0x691EB10", VA = "0x18691FB10")]
	[AsyncStateMachine(typeof(JBIHHDKDCIP))]
	private Task<Scene> AOFLBJDIDMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x691FAE0", Offset = "0x691EAE0", VA = "0x18691FAE0")]
	private bool ABCGBLPKEOE(DJJMNPKHNKF GPKMLHOONCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x691FC30", Offset = "0x691EC30", VA = "0x18691FC30")]
	private void HEAOKNNECKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x691FD20", Offset = "0x691ED20", VA = "0x18691FD20")]
	[AsyncStateMachine(typeof(OMBJIMFKGGP))]
	private Task<Scene> NFDEGKLIIBJ(string DGPOLNCNDIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000157")]
internal struct ICACECALPCL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private struct NDCCCBEMAOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public AsyncTaskMethodBuilder<OONPJIGGAPK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public ICACECALPCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public OONPJIGGAPK nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public DJJMNPKHNKF deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private TaskAwaiter<OONPJIGGAPK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x692B7A0", Offset = "0x692A7A0", VA = "0x18692B7A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x692C280", Offset = "0x692B280", VA = "0x18692C280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct LGHOFCPPLAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public AsyncTaskMethodBuilder<OONPJIGGAPK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public ICACECALPCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public OONPJIGGAPK state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private TaskAwaiter<GCHMLLGGJOI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x6929160", Offset = "0x6928160", VA = "0x186929160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x6929440", Offset = "0x6928440", VA = "0x186929440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000597")]
	private readonly MOMAGAAAECB ODBAMDFPOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000598")]
	private readonly AAGLIDGLEOO LGAJGGNOGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000599")]
	private readonly OECOCIOAHAK IHPMDEDDLCA;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private NINLEEMOEAG POBAGANEMEM
	{
		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x515C5E0", Offset = "0x515B5E0", VA = "0x18515C5E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x69223E0", Offset = "0x69213E0", VA = "0x1869223E0")]
	public ICACECALPCL(MOMAGAAAECB ODBAMDFPOKB, AAGLIDGLEOO LGAJGGNOGIG, OECOCIOAHAK IHPMDEDDLCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x69220E0", Offset = "0x69210E0", VA = "0x1869220E0")]
	[AsyncStateMachine(typeof(NDCCCBEMAOM))]
	public Task<OONPJIGGAPK> FAJFNJNINBJ(OONPJIGGAPK NLFECMNBHAB, DJJMNPKHNKF FPEFIIKFLDA, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD, bool JNLANEFFDLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x6922280", Offset = "0x6921280", VA = "0x186922280")]
	[AsyncStateMachine(typeof(LGHOFCPPLAF))]
	private Task<OONPJIGGAPK> PKCHJLGGIEG(NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, OONPJIGGAPK DKOKOEEPCNN, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x69220B0", Offset = "0x69210B0", VA = "0x1869220B0")]
	private bool CNJJPGPPAMG(OONPJIGGAPK DDLIMMIMEHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x6922260", Offset = "0x6921260", VA = "0x186922260")]
	private void HEFADAFEBPD(string EGLDLFJKHIH)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct JDCLDGDBDMG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct LPGMJFBNNII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public NINLEEMOEAG operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public DJJMNPKHNKF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public EGMMGMPJFHP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private BEAMBDPEGJL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		private List<(PersistenceView, FFFNEPAFGPP)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		private (PersistenceView, FFFNEPAFGPP) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x6929920", Offset = "0x6928920", VA = "0x186929920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x6929F30", Offset = "0x6928F30", VA = "0x186929F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x6924FE0", Offset = "0x6923FE0", VA = "0x186924FE0")]
	[AsyncStateMachine(typeof(LPGMJFBNNII))]
	public static Task AOFLBJDIDMG(NINLEEMOEAG LNPIDFLJKCD, DJJMNPKHNKF GPKMLHOONCL, EGMMGMPJFHP PCGPALCKNAJ, CancellationToken GHLJDIEPICD)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal struct DBHBGGJJIBH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct IOAAHPDBADN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public NINLEEMOEAG operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public DJJMNPKHNKF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public EGMMGMPJFHP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private ICALOLDGKCF <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		private BEAMBDPEGJL <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private List<(PersistenceView, FFFNEPAFGPP)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private FFFNEPAFGPP <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x69233E0", Offset = "0x69223E0", VA = "0x1869233E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x6923C30", Offset = "0x6922C30", VA = "0x186923C30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x691AC90", Offset = "0x6919C90", VA = "0x18691AC90")]
	[AsyncStateMachine(typeof(IOAAHPDBADN))]
	public static Task AOFLBJDIDMG(NINLEEMOEAG LNPIDFLJKCD, DJJMNPKHNKF GPKMLHOONCL, EGMMGMPJFHP PCGPALCKNAJ, CancellationToken GHLJDIEPICD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal struct IDDNOGBDJII
{
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	public struct CFBDAOCNKDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public List<FHOBACOHIGF> CFLJIALIOBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public List<FFFNEPAFGPP> OHLNHDKFODM;

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x948150", Offset = "0x947150", VA = "0x180948150")]
		public CFBDAOCNKDJ(List<FHOBACOHIGF> CFLJIALIOBC, List<FFFNEPAFGPP> OHLNHDKFODM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class JPIMKJHDGFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public IEnumerable<FHOBACOHIGF> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public JPIMKJHDGFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x6927050", Offset = "0x6926050", VA = "0x186927050")]
		internal object KNPLCNKBGEN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	private IONKJBLKHOH CPMFHDAOGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	private DJJMNPKHNKF GPKMLHOONCL;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private DBOAJANNPMM BNJIHDAPCGF
	{
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x6922CB0", Offset = "0x6921CB0", VA = "0x186922CB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x69226A0", Offset = "0x69216A0", VA = "0x1869226A0")]
	public static CFBDAOCNKDJ AOFLBJDIDMG(IONKJBLKHOH CPMFHDAOGEO, DJJMNPKHNKF GPKMLHOONCL)
	{
		return default(CFBDAOCNKDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x6922440", Offset = "0x6921440", VA = "0x186922440")]
	private CFBDAOCNKDJ AOFLBJDIDMG()
	{
		return default(CFBDAOCNKDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x6922700", Offset = "0x6921700", VA = "0x186922700")]
	private CFBDAOCNKDJ BHKNHHJABDJ(OJAAFLOIAIF OIJIGDPADIG, ICALOLDGKCF CMBIELBGLCD)
	{
		return default(CFBDAOCNKDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x6922D00", Offset = "0x6921D00", VA = "0x186922D00")]
	private bool KAIBJNJKABJ(IEnumerable<FHOBACOHIGF> CFLJIALIOBC)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000161")]
internal struct LDPKICLHHML
{
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class OPKJFOKINMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public IDDNOGBDJII.CFBDAOCNKDJ instantiations;

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public OPKJFOKINMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x692FFB0", Offset = "0x692EFB0", VA = "0x18692FFB0")]
		internal object PCEOGGHBFFD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private sealed class CLKEDJHAFHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public CLKEDJHAFHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x691A540", Offset = "0x6919540", VA = "0x18691A540")]
		internal object FKMMHOCIGKM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x6928BB0", Offset = "0x6927BB0", VA = "0x186928BB0")]
	public static void AOFLBJDIDMG(NINLEEMOEAG LNPIDFLJKCD, DJJMNPKHNKF GPKMLHOONCL, IDDNOGBDJII.CFBDAOCNKDJ AAIJLNDEMJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
internal class OECOCIOAHAK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private struct EBLKCLCHELO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public OECOCIOAHAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public OONPJIGGAPK operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public DJJMNPKHNKF deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x691D330", Offset = "0x691C330", VA = "0x18691D330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x691DAA0", Offset = "0x691CAA0", VA = "0x18691DAA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private sealed class ECEACJODOJK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000167")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005DC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005DD")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005DE")]
			public ECEACJODOJK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005DF")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005E0")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x6932700", Offset = "0x6931700", VA = "0x186932700", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x69329C0", Offset = "0x69319C0", VA = "0x1869329C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public OECOCIOAHAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public DJJMNPKHNKF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public ECEACJODOJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x691DB00", Offset = "0x691CB00", VA = "0x18691DB00")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task FNIOFDLPFEO(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct MGFJIJHPAGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public OECOCIOAHAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public DJJMNPKHNKF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		private ECEACJODOJK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x6929FE0", Offset = "0x6928FE0", VA = "0x186929FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x692A510", Offset = "0x6929510", VA = "0x18692A510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct DHHNOBBLDKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public OECOCIOAHAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public DJJMNPKHNKF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		private Dictionary<Guid, List<HJDAJIGEOIG>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x691C150", Offset = "0x691B150", VA = "0x18691C150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x691C700", Offset = "0x691B700", VA = "0x18691C700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private struct JHECNCEKJIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public OECOCIOAHAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public DJJMNPKHNKF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		private NENCAGLHEIB<string>.OGJMFKKDMDA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		private Dictionary<Guid, List<HJDAJIGEOIG>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x6925120", Offset = "0x6924120", VA = "0x186925120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x69257A0", Offset = "0x69247A0", VA = "0x1869257A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private sealed class OHMFJJINLEM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016C")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000600")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000601")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000602")]
			public HJDAJIGEOIG handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000603")]
			public OHMFJJINLEM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000604")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005B9")]
			[Cpp2IlInjected.Address(RVA = "0x6932500", Offset = "0x6931500", VA = "0x186932500", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BA")]
			[Cpp2IlInjected.Address(RVA = "0x69326A0", Offset = "0x69316A0", VA = "0x1869326A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public LPMILMGMAIC runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public List<HJDAJIGEOIG> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		public DJJMNPKHNKF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public OHMFJJINLEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x692E610", Offset = "0x692D610", VA = "0x18692E610")]
		internal object OHIENOADGCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x692E520", Offset = "0x692D520", VA = "0x18692E520")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task KEOGHCKLDLJ(HJDAJIGEOIG handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x692E430", Offset = "0x692D430", VA = "0x18692E430")]
		internal object GFNFIKGCMGD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private struct OKHGBNJIAFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public LPMILMGMAIC runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public List<HJDAJIGEOIG> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public DJJMNPKHNKF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		private OHMFJJINLEM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x692F450", Offset = "0x692E450", VA = "0x18692F450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x692F920", Offset = "0x692E920", VA = "0x18692F920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private struct CLLIAKLLACM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public OECOCIOAHAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public DJJMNPKHNKF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x691A5D0", Offset = "0x69195D0", VA = "0x18691A5D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x691AB90", Offset = "0x6919B90", VA = "0x18691AB90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private sealed class EKHFBJJFKJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public EKHFBJJFKJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x691DD30", Offset = "0x691CD30", VA = "0x18691DD30")]
		internal object JJKLOPPMDMF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct PNIOMICOADB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public OECOCIOAHAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public DJJMNPKHNKF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		private BEAMBDPEGJL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x6931FE0", Offset = "0x6930FE0", VA = "0x186931FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x69324A0", Offset = "0x69314A0", VA = "0x1869324A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class GDOGLMJNIIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public GDOGLMJNIIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x691ECF0", Offset = "0x691DCF0", VA = "0x18691ECF0")]
		internal object IMBCANGNNBH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private struct JLPAOIGIICD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public OECOCIOAHAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		private BEAMBDPEGJL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		private TaskAwaiter<GCHMLLGGJOI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x69269B0", Offset = "0x69259B0", VA = "0x1869269B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x6926FF0", Offset = "0x6925FF0", VA = "0x186926FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private sealed class BCJNFGEIDDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public BCJNFGEIDDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x69197B0", Offset = "0x69187B0", VA = "0x1869197B0")]
		internal object DHIIKGNIAGG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005CE")]
	private readonly MOMAGAAAECB ODBAMDFPOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	private JAGJGNGCDIJ IHPMDEDDLCA;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private NINLEEMOEAG POBAGANEMEM
	{
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x10C5970", Offset = "0x10C4970", VA = "0x1810C5970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C50", Offset = "0x7C8C50", VA = "0x1807C9C50")]
	public OECOCIOAHAK(MOMAGAAAECB ODBAMDFPOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x692D610", Offset = "0x692C610", VA = "0x18692D610")]
	[AsyncStateMachine(typeof(EBLKCLCHELO))]
	public Task AOFLBJDIDMG(OONPJIGGAPK PPHCJJJKLKN, DJJMNPKHNKF FPEFIIKFLDA, NENCAGLHEIB<string>.OGJMFKKDMDA OCBBLMCOHCB, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x692D4D0", Offset = "0x692C4D0", VA = "0x18692D4D0")]
	[AsyncStateMachine(typeof(MGFJIJHPAGL))]
	private Task ABKPDAIMEIA(DJJMNPKHNKF GPKMLHOONCL, NENCAGLHEIB<string>.OGJMFKKDMDA OCBBLMCOHCB, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x692DF30", Offset = "0x692CF30", VA = "0x18692DF30")]
	[AsyncStateMachine(typeof(DHHNOBBLDKE))]
	private Task HGNAONIPCOK(DJJMNPKHNKF GPKMLHOONCL, NENCAGLHEIB<string>.OGJMFKKDMDA OCBBLMCOHCB, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x692E2F0", Offset = "0x692D2F0", VA = "0x18692E2F0")]
	[AsyncStateMachine(typeof(JHECNCEKJIN))]
	private Task PBFOOOGDKPH(DJJMNPKHNKF GPKMLHOONCL, NENCAGLHEIB<string>.OGJMFKKDMDA OCBBLMCOHCB, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x692DDE0", Offset = "0x692CDE0", VA = "0x18692DDE0")]
	[AsyncStateMachine(typeof(OKHGBNJIAFE))]
	private Task HFGAKOPGECE(Guid LMDLJLNCCKI, List<HJDAJIGEOIG> CMOFIGGFANK, LPMILMGMAIC JCPIODOOEHC, DJJMNPKHNKF GPKMLHOONCL, CancellationToken KONODCHOCOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x692E1B0", Offset = "0x692D1B0", VA = "0x18692E1B0")]
	[AsyncStateMachine(typeof(CLLIAKLLACM))]
	private Task LMKJKJCMPJD(DJJMNPKHNKF GPKMLHOONCL, NENCAGLHEIB<string>.OGJMFKKDMDA OCBBLMCOHCB, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x692DCA0", Offset = "0x692CCA0", VA = "0x18692DCA0")]
	[AsyncStateMachine(typeof(PNIOMICOADB))]
	private Task HFFDEEPEPFM(Guid NNNCOBPCLBM, DJJMNPKHNKF GPKMLHOONCL, NENCAGLHEIB<string>.OGJMFKKDMDA OCBBLMCOHCB, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x692E070", Offset = "0x692D070", VA = "0x18692E070")]
	[AsyncStateMachine(typeof(JLPAOIGIICD))]
	private Task KIJCMGDADHK(Guid NNNCOBPCLBM, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x692DB80", Offset = "0x692CB80", VA = "0x18692DB80")]
	private void GEDAMHGFFIM(Guid NNNCOBPCLBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x692D760", Offset = "0x692C760", VA = "0x18692D760")]
	private void EEFAGMGIILK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x692D9F0", Offset = "0x692C9F0", VA = "0x18692D9F0")]
	public Guid FOJCJKOIDGA(OONPJIGGAPK FHMOJDNCJAP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x692D810", Offset = "0x692C810", VA = "0x18692D810")]
	[CompilerGenerated]
	private object EHEFMKENKLN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
public readonly struct JCEBIMDNGKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400062C")]
	public readonly bool MIKFIIJHCHL;

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0xCBCF40", Offset = "0xCBBF40", VA = "0x180CBCF40")]
	public JCEBIMDNGKK(bool HNNDCEOHDHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000176")]
public readonly struct EIIHNOKEGGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400062D")]
	public readonly OJAAFLOIAIF? LALFHJPDALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400062E")]
	public readonly GPMNGLHIPMH HEAFFPLIENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400062F")]
	public readonly string? EADCHGAMFPC;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public IReadOnlyCollection<string> IAGKEGDMJCO
	{
		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x691DBF0", Offset = "0x691CBF0", VA = "0x18691DBF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public IReadOnlyDictionary<long, int> DHHCGKIHBLM
	{
		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x691DC10", Offset = "0x691CC10", VA = "0x18691DC10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x691DC30", Offset = "0x691CC30", VA = "0x18691DC30")]
	public EIIHNOKEGGJ(OJAAFLOIAIF? LAOLHNNNLCH, GPMNGLHIPMH AOHELAKBBBF, string? GBIPICNEONK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
internal class NHKADONHMBA : KKLLGPKABGL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private struct JBNHOJFNIKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public AsyncTaskMethodBuilder<EIIHNOKEGGJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public NHKADONHMBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public GGBJKOCDOKK serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public NEMIIIGBPPE roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		private BEAMBDPEGJL <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x69242E0", Offset = "0x69232E0", VA = "0x1869242E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x6924950", Offset = "0x6923950", VA = "0x186924950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class DFCDJBAEDBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public GGBJKOCDOKK serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public NHKADONHMBA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public DFCDJBAEDBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x691B490", Offset = "0x691A490", VA = "0x18691B490")]
		internal Task JEGDNBHLNND(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x691B3B0", Offset = "0x691A3B0", VA = "0x18691B3B0")]
		internal Task EHMAJHGOLBN(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private sealed class IPAEPOIINCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public DFCDJBAEDBI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public IPAEPOIINCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x6923C90", Offset = "0x6922C90", VA = "0x186923C90")]
		internal object ELBJKIMKILL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private sealed class BFHANGBKCBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public DFCDJBAEDBI CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public BFHANGBKCBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x6919B50", Offset = "0x6918B50", VA = "0x186919B50")]
		internal Task BDHCMDJGFCB(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private struct AJKIKPCJAPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public GGBJKOCDOKK serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public NHKADONHMBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		private IPAEPOIINCA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		private BEAMBDPEGJL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x6918D40", Offset = "0x6917D40", VA = "0x186918D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x69195B0", Offset = "0x69185B0", VA = "0x1869195B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000630")]
	private readonly NDLEKAMCBHL LAGKGKDNMJM;

	[Cpp2IlInjected.Token(Token = "0x4000631")]
	private static readonly TimeSpan DCLHJFIDKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000632")]
	private readonly PEKEFNKOFMG ECABEPHCLJM;

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x692D410", Offset = "0x692C410", VA = "0x18692D410")]
	public NHKADONHMBA(MOMAGAAAECB ODBAMDFPOKB, PEKEFNKOFMG ECABEPHCLJM, NDLEKAMCBHL LAGKGKDNMJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x692C2F0", Offset = "0x692B2F0", VA = "0x18692C2F0")]
	[AsyncStateMachine(typeof(JBNHOJFNIKB))]
	public Task<EIIHNOKEGGJ> AFIENNPCBKD(long CEJEMJLIMDC, NEMIIIGBPPE INKCNKEOKII, GGBJKOCDOKK NIJFMDGDCCJ, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x692D260", Offset = "0x692C260", VA = "0x18692D260")]
	[AsyncStateMachine(typeof(AJKIKPCJAPB))]
	private Task OFIFIHGGNDP(GGBJKOCDOKK NIJFMDGDCCJ, IEnumerable<PersistenceView> FCHKMLBDHJO, StringBuilder CLPACEELEOO, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x692CCB0", Offset = "0x692BCB0", VA = "0x18692CCB0")]
	private EIIHNOKEGGJ LILPGCNJBOO(long CEJEMJLIMDC, NEMIIIGBPPE INKCNKEOKII, GGBJKOCDOKK NIJFMDGDCCJ, IEnumerable<PersistenceView> FCHKMLBDHJO, StringBuilder CLPACEELEOO)
	{
		return default(EIIHNOKEGGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x692C450", Offset = "0x692B450", VA = "0x18692C450")]
	private OJAAFLOIAIF BOCHECIGBFE(long CEJEMJLIMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x692CA60", Offset = "0x692BA60", VA = "0x18692CA60")]
	private void EGFMNOMLBEA(OJAAFLOIAIF EJGBACDBHJK, StringBuilder CLPACEELEOO, IEnumerable<PersistenceView> FCHKMLBDHJO, [In] GLPFJGHGENL IKOHNLMPJNO, JFCACLAEMHA LONOHHHHFFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x692C5B0", Offset = "0x692B5B0", VA = "0x18692C5B0")]
	private void DNEPDKLEALC(OJAAFLOIAIF EJGBACDBHJK, StringBuilder CLPACEELEOO, PersistenceView DNJBPCJBPNH, JFCACLAEMHA LONOHHHHFFG, [In] GLPFJGHGENL IKOHNLMPJNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal class EMBDJMOCHDN : KKLLGPKABGL
{
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private sealed class HMLPODBMJIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public MIFHAEGHLLC.EDGFECBFDOL roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public HMLPODBMJIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x6922060", Offset = "0x6921060", VA = "0x186922060")]
		internal object LKGAKHKPCNA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct KHHCKPFMPIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public AsyncTaskMethodBuilder<(MIFHAEGHLLC.EDGFECBFDOL roomDataUpload, MIFHAEGHLLC.EDGFECBFDOL subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public EIIHNOKEGGJ roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public EMBDJMOCHDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		private HMLPODBMJIC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		private TaskAwaiter<MIFHAEGHLLC.EDGFECBFDOL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x69274F0", Offset = "0x69264F0", VA = "0x1869274F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x6927D40", Offset = "0x6926D40", VA = "0x186927D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct CAKAGLBDFEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public AsyncTaskMethodBuilder<ECDKOBNKCNM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public EMBDJMOCHDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public EIIHNOKEGGJ roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public KEGLOPNPEGK roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		private TaskAwaiter<(MIFHAEGHLLC.EDGFECBFDOL roomDataUpload, MIFHAEGHLLC.EDGFECBFDOL subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		private TaskAwaiter<ECDKOBNKCNM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x6919B90", Offset = "0x6918B90", VA = "0x186919B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x691A1B0", Offset = "0x69191B0", VA = "0x18691A1B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private struct IIGCNPBDLFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		public AsyncTaskMethodBuilder<JFNGOOKNNMM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public EMBDJMOCHDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public EIIHNOKEGGJ roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		private TaskAwaiter<(MIFHAEGHLLC.EDGFECBFDOL roomDataUpload, MIFHAEGHLLC.EDGFECBFDOL subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		private TaskAwaiter<JFNGOOKNNMM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x6922ED0", Offset = "0x6921ED0", VA = "0x186922ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x69232F0", Offset = "0x69222F0", VA = "0x1869232F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private sealed class OJFFEDCIGDP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000184")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400067E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400067F")]
			public AsyncTaskMethodBuilder<GCHMLLGGJOI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000680")]
			public OJFFEDCIGDP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000681")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000682")]
			private GCHMLLGGJOI <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000683")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000684")]
			private TaskAwaiter<JFNGOOKNNMM> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000685")]
			private TaskAwaiter<ECDKOBNKCNM> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000686")]
			private TaskAwaiter<GCHMLLGGJOI> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x6932A20", Offset = "0x6931A20", VA = "0x186932A20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x69339B0", Offset = "0x69329B0", VA = "0x1869339B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public EMBDJMOCHDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public EIIHNOKEGGJ roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public KEGLOPNPEGK roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public JCEBIMDNGKK roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public OJFFEDCIGDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x692E700", Offset = "0x692D700", VA = "0x18692E700")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<GCHMLLGGJOI> CFANBMCKOML(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private struct LCJMDAOJKOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public AsyncTaskMethodBuilder<GCHMLLGGJOI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		public EMBDJMOCHDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public EIIHNOKEGGJ roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public KEGLOPNPEGK roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		public JCEBIMDNGKK roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		public NENCAGLHEIB<string>.OGJMFKKDMDA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		private TaskAwaiter<GCHMLLGGJOI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x6928390", Offset = "0x6927390", VA = "0x186928390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x69286A0", Offset = "0x69276A0", VA = "0x1869286A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000655")]
	private static readonly NDLEKAMCBHL LAGKGKDNMJM;

	[Cpp2IlInjected.Token(Token = "0x4000656")]
	private static readonly NDLEKAMCBHL IKEGOFMGLFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000657")]
	private readonly HJJCDKOEFMD ODEMEOPLADP;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private IONKJBLKHOH NIKBLBDBJJM
	{
		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x690DDB0", Offset = "0x690CDB0", VA = "0x18690DDB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x691E400", Offset = "0x691D400", VA = "0x18691E400")]
	public EMBDJMOCHDN(MOMAGAAAECB ODBAMDFPOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x691DF40", Offset = "0x691CF40", VA = "0x18691DF40")]
	[AsyncStateMachine(typeof(KHHCKPFMPIA))]
	private Task<(MIFHAEGHLLC.EDGFECBFDOL, MIFHAEGHLLC.EDGFECBFDOL)> KAIPHJNHBGI(EIIHNOKEGGJ AFIGHNEJHMM, long CFLPHBNCGDP, long AKANBGAJAAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x691E1F0", Offset = "0x691D1F0", VA = "0x18691E1F0")]
	[AsyncStateMachine(typeof(CAKAGLBDFEF))]
	public Task<ECDKOBNKCNM> KLCNFGEGMJD(int NDEJNLADIOH, [CanBeNull] KEGLOPNPEGK HNKOCDGICOF, EIIHNOKEGGJ AFIGHNEJHMM, long CFLPHBNCGDP, long AKANBGAJAAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x691E080", Offset = "0x691D080", VA = "0x18691E080")]
	[AsyncStateMachine(typeof(IIGCNPBDLFN))]
	private Task<JFNGOOKNNMM> KCFMBBCGOHM(string FNMGFGJPBJD, int NDEJNLADIOH, EIIHNOKEGGJ AFIGHNEJHMM, long CFLPHBNCGDP, long AKANBGAJAAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x691DDA0", Offset = "0x691CDA0", VA = "0x18691DDA0")]
	[AsyncStateMachine(typeof(LCJMDAOJKOB))]
	public Task<GCHMLLGGJOI> JBICDBNPOCN(int NDEJNLADIOH, KEGLOPNPEGK? HNKOCDGICOF, EIIHNOKEGGJ AFIGHNEJHMM, long CFLPHBNCGDP, long AKANBGAJAAH, JCEBIMDNGKK OFKJCIKEAHL, NENCAGLHEIB<string>.OGJMFKKDMDA GJBPMGFOOIL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
public abstract class MOMJFOBEGHC<T> where T : MOMJFOBEGHC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000693")]
	internal readonly IONKJBLKHOH DFJFJHDBMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000694")]
	private int? LOCOBHBAIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000695")]
	protected readonly Guid MEOKMLFOCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000696")]
	protected readonly AMLKNBEIKDJ HHEAKBFKLNP;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	protected T ILHEDNACMGK
	{
		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x405CA70", Offset = "0x405BA70", VA = "0x18405CA70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x405CAD0", Offset = "0x405BAD0", VA = "0x18405CAD0")]
	internal MOMJFOBEGHC(IONKJBLKHOH DACFLCEEEEK, AMLKNBEIKDJ NJGNAINEOMI, [Optional] Guid? IDKMDFCBEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x405C990", Offset = "0x405B990", VA = "0x18405C990")]
	private GCHMLLGGJOI LEEGKJABBGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "4")]
	protected virtual void LDBANLPHICD(GCHMLLGGJOI JJJNODJJIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x405C780", Offset = "0x405B780", VA = "0x18405C780")]
	public T KFNHNCICHNB(JGGIBKMOPKC KFFKBJPPNBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x405C6F0", Offset = "0x405B6F0", VA = "0x18405C6F0")]
	public T AAMPMNHLFJL(int KPBDJJIKDAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x405C870", Offset = "0x405B870", VA = "0x18405C870", Slot = "5")]
	public virtual Task<IDAKKNHINME> KNCOIMOKHEE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
public class BAAPKIOPEDJ : MOMJFOBEGHC<BAAPKIOPEDJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000697")]
	private IKPHFCIJHCC KKAPFENLPIM;

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x69196E0", Offset = "0x69186E0", VA = "0x1869196E0")]
	internal BAAPKIOPEDJ(IONKJBLKHOH DACFLCEEEEK, AMLKNBEIKDJ NJGNAINEOMI, [Optional] Guid? IDKMDFCBEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x5F0BDC0", Offset = "0x5F0ADC0", VA = "0x185F0BDC0")]
	public BAAPKIOPEDJ LHLLOHOEHAK(IKPHFCIJHCC KKAPFENLPIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x6919610", Offset = "0x6918610", VA = "0x186919610", Slot = "4")]
	protected override void LDBANLPHICD(GCHMLLGGJOI JJJNODJJIFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
public class KIINJFEGLCA : MOMJFOBEGHC<KIINJFEGLCA>
{
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	internal enum ADIEBODPEOB
	{
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private struct KBIKBIGAHPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		public AsyncTaskMethodBuilder<IDAKKNHINME> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public KIINJFEGLCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		private TaskAwaiter<IDAKKNHINME> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x69270D0", Offset = "0x69260D0", VA = "0x1869270D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x6927480", Offset = "0x6926480", VA = "0x186927480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000698")]
	private ADIEBODPEOB IJPOAMDDODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000699")]
	private string DDBBMOEEBFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400069A")]
	private KEGLOPNPEGK KKAPFENLPIM;

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x69280D0", Offset = "0x69270D0", VA = "0x1869280D0")]
	internal KIINJFEGLCA(IONKJBLKHOH DACFLCEEEEK, AMLKNBEIKDJ NJGNAINEOMI, [Optional] Guid? IDKMDFCBEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x69280A0", Offset = "0x69270A0", VA = "0x1869280A0")]
	public KIINJFEGLCA NMBJFJFCJAI(string OCBNPBFKEJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0x6927DE0", Offset = "0x6926DE0", VA = "0x186927DE0")]
	public KIINJFEGLCA BHLOKMOJGMC(bool BLIPBDGKLDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x6927DB0", Offset = "0x6926DB0", VA = "0x186927DB0")]
	public KIINJFEGLCA AJENOPDDNHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x6927EF0", Offset = "0x6926EF0", VA = "0x186927EF0", Slot = "4")]
	protected override void LDBANLPHICD(GCHMLLGGJOI JJJNODJJIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x6927E00", Offset = "0x6926E00", VA = "0x186927E00", Slot = "5")]
	[AsyncStateMachine(typeof(KBIKBIGAHPC))]
	public override Task<IDAKKNHINME> KNCOIMOKHEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x6928060", Offset = "0x6927060", VA = "0x186928060")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<IDAKKNHINME> LJCIJAPEMHJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
internal static class DOODDNMDNPD
{
	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x691D1E0", Offset = "0x691C1E0", VA = "0x18691D1E0")]
	public static void LHNCEAKPCAN(this CGFLONACAMI BNEIKIKJGDP, BPINABCIEKB LFPHILBAAKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x691D160", Offset = "0x691C160", VA = "0x18691D160")]
	public static void DOHOLPGOLGM(this BPINABCIEKB KJLIHJCMFFA, [Optional] string JJJNODJJIFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
public static class LAFMBFCNKFI
{
	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x6928240", Offset = "0x6927240", VA = "0x186928240")]
	public static OAKJFJKJCNE IKJDMHPBOHC(this PJGFOMEADCP AFIGGADBIIA)
	{
		return default(OAKJFJKJCNE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x69282E0", Offset = "0x69272E0", VA = "0x1869282E0")]
	public static PJGFOMEADCP JBMHPJJPHEB(this OAKJFJKJCNE GPJAICKOOLN)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x200018D")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200018E")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006A7")]
			public DBNKOANBHNI ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006A8")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006A9")]
			public DBNKOANBHNI HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006AA")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006AB")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006AC")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x600061B")]
			[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		private static DBNKOANBHNI[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		private Dictionary<DBNKOANBHNI, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x69341F0", Offset = "0x69331F0", VA = "0x1869341F0")]
		public bool OOAJEIMONHE(DBNKOANBHNI NBGKPECNEFM, [Out] ResultConfig MOBEOAJIGJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x69340B0", Offset = "0x69330B0", VA = "0x1869340B0")]
		public ResultConfig CCNNBAMDPGL(DBNKOANBHNI KDLIPBNGNPF, [Optional] HashSet<DBNKOANBHNI> CGKIPHPCMDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x69347C0", Offset = "0x69337C0", VA = "0x1869347C0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x6934260", Offset = "0x6933260", VA = "0x186934260", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x8AA680", Offset = "0x8A9680", VA = "0x1808AA680")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
public static class PMBFFHAFOAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x69314B0", Offset = "0x69304B0", VA = "0x1869314B0")]
	[ILJDPBHFAFI(DIDBPCEENMM.GameOnly)]
	private static void LJGEHEAHHOL(OIEDECFCIPC LDKHFAGODPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
public interface JEENCGOGKPP : IEquatable<JEENCGOGKPP>
{
	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	DateTime KDCFIJNLADO
	{
		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GHBOGNHFFHJ();

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LDAKAJBMKAO(long CFLPHBNCGDP, long CEJEMJLIMDC, [Out] EIIHNOKEGGJ AFIGHNEJHMM);
}
[Cpp2IlInjected.Token(Token = "0x2000192")]
internal class NCJDNNJCBEM : OMFPKLCAGCI
{
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private sealed class NMIHHGMJCMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public JDGAAOKDGFM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public NMIHHGMJCMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x692D460", Offset = "0x692C460", VA = "0x18692D460")]
		internal object HIBMPPDMEBK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006B2")]
	private readonly AJLKOJAJEOD CGBACKGBDCI;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<JEENCGOGKPP> KNCCJHMJBOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x692AE80", Offset = "0x6929E80", VA = "0x18692AE80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x692B360", Offset = "0x692A360", VA = "0x18692B360", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x7C9C50", Offset = "0x7C8C50", VA = "0x1807C9C50")]
	[UnityEngine.Scripting.Preserve]
	public NCJDNNJCBEM([POILJEECDED(null)] AJLKOJAJEOD CGBACKGBDCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x692B410", Offset = "0x692A410", VA = "0x18692B410", Slot = "6")]
	public bool OIJFLPFKILH(long CFLPHBNCGDP, long CEJEMJLIMDC, EIIHNOKEGGJ AFIGHNEJHMM, JDGAAOKDGFM CMMMKALOAEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x1A6F590", Offset = "0x1A6E590", VA = "0x181A6F590")]
	private void DEEDDMMICKE(JEENCGOGKPP NGAIDKANJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x692ABE0", Offset = "0x6929BE0", VA = "0x18692ABE0", Slot = "7")]
	public bool BCJEAEMILJI(long CFLPHBNCGDP, long CEJEMJLIMDC, [Out] JEENCGOGKPP OHMDGACKMDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x692B6F0", Offset = "0x692A6F0", VA = "0x18692B6F0", Slot = "8")]
	public bool PGMCKEMJIIJ(long CFLPHBNCGDP, long CEJEMJLIMDC, JDGAAOKDGFM CMMMKALOAEA, [Out] JEENCGOGKPP OHMDGACKMDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x692AF30", Offset = "0x6929F30", VA = "0x18692AF30")]
	private void IKHDKNKDBLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x692AD50", Offset = "0x6929D50", VA = "0x18692AD50", Slot = "9")]
	public void DHBEIFLDLGF(long CFLPHBNCGDP, long CEJEMJLIMDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
internal abstract class DGNIEGKHCNH : AJLKOJAJEOD
{
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	protected enum BEJPFDNBPMJ : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private sealed class BCMAMAMBMBI : IEnumerable<JEENCGOGKPP>, IEnumerable, IEnumerator<JEENCGOGKPP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		private JEENCGOGKPP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public DGNIEGKHCNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		private JDGAAOKDGFM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		public JDGAAOKDGFM <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		private JEENCGOGKPP System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000643")]
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x8164C0", Offset = "0x8154C0", VA = "0x1808164C0")]
		[DebuggerHidden]
		public BCMAMAMBMBI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x6919820", Offset = "0x6918820", VA = "0x186919820", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x6919B00", Offset = "0x6918B00", VA = "0x186919B00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x6919A50", Offset = "0x6918A50", VA = "0x186919A50", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JEENCGOGKPP> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x6919A50", Offset = "0x6918A50", VA = "0x186919A50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private sealed class DAHOAFPFNMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public JDGAAOKDGFM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public DAHOAFPFNMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x691ABF0", Offset = "0x6919BF0", VA = "0x18691ABF0")]
		internal object AGBEMBLKDMJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[CompilerGenerated]
	private sealed class IMPIHKCHNHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		public DGNIEGKHCNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public IMPIHKCHNHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x6923360", Offset = "0x6922360", VA = "0x186923360")]
		internal void JBNKGHJFFCM(HECHJPNILAL.BHJKBDEMKJP ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006B8")]
	protected readonly string PGKMBNOFAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006B9")]
	private readonly object FHACHGNOHNL;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public abstract BKEHHEOPICK FCCLJCLNCPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x691C0B0", Offset = "0x691B0B0", VA = "0x18691C0B0")]
	protected DGNIEGKHCNH([CanBeNull] string EOPDPAPMIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x691B6B0", Offset = "0x691A6B0", VA = "0x18691B6B0", Slot = "5")]
	public bool BAAMNGEEHCL(long CFLPHBNCGDP, long CEJEMJLIMDC, JDGAAOKDGFM CMMMKALOAEA, [Out] JEENCGOGKPP NGAIDKANJFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x691BC20", Offset = "0x691AC20", VA = "0x18691BC20", Slot = "6")]
	[IteratorStateMachine(typeof(BCMAMAMBMBI))]
	public IEnumerable<JEENCGOGKPP> IFJPHPFJCFM(JDGAAOKDGFM CMMMKALOAEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void OOONIPALCLN(Stream LFBICFIPGNM, long CFLPHBNCGDP, long CEJEMJLIMDC, EIIHNOKEGGJ AFIGHNEJHMM);

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool LCGKPPKAEJA(Stream NNEHODPDOCM, long CFLPHBNCGDP, long CEJEMJLIMDC, EIGKNNEDJHI LEKBBKFMGED, [Out] EIIHNOKEGGJ AFIGHNEJHMM);

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x691B8A0", Offset = "0x691A8A0", VA = "0x18691B8A0", Slot = "7")]
	public JEENCGOGKPP HJOFNLAEPEB(long CFLPHBNCGDP, long CEJEMJLIMDC, EIIHNOKEGGJ AFIGHNEJHMM, JDGAAOKDGFM CMMMKALOAEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo EKFOKJBAHLB(long CFLPHBNCGDP, long CEJEMJLIMDC, JDGAAOKDGFM CMMMKALOAEA, BEJPFDNBPMJ GDPJPCEKAIG);

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo BDFBFAJBJDF(JDGAAOKDGFM CMMMKALOAEA, BEJPFDNBPMJ GDPJPCEKAIG);

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x691BCB0", Offset = "0x691ACB0", VA = "0x18691BCB0")]
	protected void MFOBOJNBGPC(HECHJPNILAL.BHJKBDEMKJP OGFINMFMKCA, string EGLDLFJKHIH, FileInfo GMMOFNMIFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x691BD20", Offset = "0x691AD20", VA = "0x18691BD20")]
	internal bool OGOHLCJNPCM(FileInfo IMLKJKFLKKH, long CFLPHBNCGDP, long CEJEMJLIMDC, [Out] EIIHNOKEGGJ AFIGHNEJHMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
	private void GKNEABDHHJL(Exception IKEDLLBMBGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
internal class OKEAMHFNHPD : DGNIEGKHCNH
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public override BKEHHEOPICK FCCLJCLNCPC
	{
		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0xC20640", Offset = "0xC1F640", VA = "0x180C20640", Slot = "8")]
		get
		{
			return default(BKEHHEOPICK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x692F390", Offset = "0x692E390", VA = "0x18692F390")]
	public OKEAMHFNHPD([Optional] string EOPDPAPMIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x692EA30", Offset = "0x692DA30", VA = "0x18692EA30")]
	private void JCMBDCOFBIP(JDGAAOKDGFM CMMMKALOAEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x692F100", Offset = "0x692E100", VA = "0x18692F100", Slot = "9")]
	internal override void OOONIPALCLN(Stream LFBICFIPGNM, long CFLPHBNCGDP, long CEJEMJLIMDC, EIIHNOKEGGJ AFIGHNEJHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x692EAB0", Offset = "0x692DAB0", VA = "0x18692EAB0", Slot = "10")]
	internal override bool LCGKPPKAEJA(Stream NNEHODPDOCM, long CFLPHBNCGDP, long CEJEMJLIMDC, EIGKNNEDJHI LEKBBKFMGED, [Out] EIIHNOKEGGJ AFIGHNEJHMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x692E940", Offset = "0x692D940", VA = "0x18692E940", Slot = "11")]
	protected override FileInfo EKFOKJBAHLB(long CFLPHBNCGDP, long CEJEMJLIMDC, JDGAAOKDGFM CMMMKALOAEA, BEJPFDNBPMJ GDPJPCEKAIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x692E830", Offset = "0x692D830", VA = "0x18692E830", Slot = "12")]
	protected override DirectoryInfo BDFBFAJBJDF(JDGAAOKDGFM CMMMKALOAEA, BEJPFDNBPMJ GDPJPCEKAIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
internal sealed class HFABKNDILAH : DGNIEGKHCNH
{
	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	private static readonly byte[] OHNEPKBBADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006CA")]
	private readonly byte[] HFAPLDDGAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006CB")]
	private readonly byte[] PLIHBMOKFCO;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public override BKEHHEOPICK FCCLJCLNCPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x57BF160", Offset = "0x57BE160", VA = "0x1857BF160", Slot = "8")]
		get
		{
			return default(BKEHHEOPICK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x6921A40", Offset = "0x6920A40", VA = "0x186921A40")]
	public HFABKNDILAH([Optional] string EOPDPAPMIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x69216F0", Offset = "0x69206F0", VA = "0x1869216F0", Slot = "9")]
	internal override void OOONIPALCLN(Stream LFBICFIPGNM, long CFLPHBNCGDP, long CEJEMJLIMDC, EIIHNOKEGGJ AFIGHNEJHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x6920EC0", Offset = "0x691FEC0", VA = "0x186920EC0", Slot = "10")]
	internal override bool LCGKPPKAEJA(Stream NNEHODPDOCM, long CFLPHBNCGDP, long CEJEMJLIMDC, EIGKNNEDJHI LEKBBKFMGED, [Out] EIIHNOKEGGJ AFIGHNEJHMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x6920E00", Offset = "0x691FE00", VA = "0x186920E00")]
	private void ILLKHPPKEOE(byte[] MFPMCBPILCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x6920CD0", Offset = "0x691FCD0", VA = "0x186920CD0", Slot = "11")]
	protected override FileInfo EKFOKJBAHLB(long CFLPHBNCGDP, long CEJEMJLIMDC, JDGAAOKDGFM CMMMKALOAEA, BEJPFDNBPMJ GDPJPCEKAIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x6920BC0", Offset = "0x691FBC0", VA = "0x186920BC0", Slot = "12")]
	protected override DirectoryInfo BDFBFAJBJDF(JDGAAOKDGFM CMMMKALOAEA, BEJPFDNBPMJ GDPJPCEKAIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
public enum BKEHHEOPICK : byte
{
	[Cpp2IlInjected.Token(Token = "0x40006CD")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40006CE")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40006CF")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
internal class FGENLHALFKM : AJLKOJAJEOD
{
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[CompilerGenerated]
	private sealed class HHGNEKBJJDF : IEnumerable<JEENCGOGKPP>, IEnumerable, IEnumerator<JEENCGOGKPP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		private JEENCGOGKPP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		public FGENLHALFKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		private JDGAAOKDGFM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006DB")]
		public JDGAAOKDGFM <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		private BKEHHEOPICK[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		private IEnumerator<JEENCGOGKPP> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		private JEENCGOGKPP System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600066A")]
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600066C")]
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x8164C0", Offset = "0x8154C0", VA = "0x1808164C0")]
		[DebuggerHidden]
		public HHGNEKBJJDF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x6921FD0", Offset = "0x6920FD0", VA = "0x186921FD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x6921BF0", Offset = "0x6920BF0", VA = "0x186921BF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x6921BA0", Offset = "0x6920BA0", VA = "0x186921BA0")]
		private void HPAIKACEAJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x6921F80", Offset = "0x6920F80", VA = "0x186921F80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x6921ED0", Offset = "0x6920ED0", VA = "0x186921ED0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JEENCGOGKPP> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x6921ED0", Offset = "0x6920ED0", VA = "0x186921ED0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006D0")]
	private readonly BKEHHEOPICK[] GFIEKAJHDAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006D1")]
	private readonly Dictionary<BKEHHEOPICK, AJLKOJAJEOD> OPNHBAOBAAH;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public BKEHHEOPICK FCCLJCLNCPC
	{
		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x691E5E0", Offset = "0x691D5E0", VA = "0x18691E5E0", Slot = "4")]
		get
		{
			return default(BKEHHEOPICK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x691E9A0", Offset = "0x691D9A0", VA = "0x18691E9A0")]
	[UnityEngine.Scripting.Preserve]
	public FGENLHALFKM(params AJLKOJAJEOD[] LACCEFDJDIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x691E490", Offset = "0x691D490", VA = "0x18691E490", Slot = "5")]
	public bool BAAMNGEEHCL(long CFLPHBNCGDP, long CEJEMJLIMDC, JDGAAOKDGFM CMMMKALOAEA, [Out] JEENCGOGKPP NGAIDKANJFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x691E780", Offset = "0x691D780", VA = "0x18691E780")]
	private void LACBMCGCPEO(int NCDCKNIDKFI, long CFLPHBNCGDP, long CEJEMJLIMDC, JDGAAOKDGFM CMMMKALOAEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x691E6F0", Offset = "0x691D6F0", VA = "0x18691E6F0", Slot = "6")]
	[IteratorStateMachine(typeof(HHGNEKBJJDF))]
	public IEnumerable<JEENCGOGKPP> IFJPHPFJCFM(JDGAAOKDGFM CMMMKALOAEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x691E610", Offset = "0x691D610", VA = "0x18691E610", Slot = "7")]
	public JEENCGOGKPP HJOFNLAEPEB(long CFLPHBNCGDP, long CEJEMJLIMDC, EIIHNOKEGGJ AFIGHNEJHMM, JDGAAOKDGFM CMMMKALOAEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
internal static class CIEGFKGBJOB
{
	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x691A480", Offset = "0x6919480", VA = "0x18691A480")]
	internal static byte[] OCFJMDFEOIC(byte[] MFPMCBPILCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x691A400", Offset = "0x6919400", VA = "0x18691A400")]
	public static void NAGBPIMMDAM(Stream FEMBCGGKAFB, byte[] CMEBPGIFJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x691A220", Offset = "0x6919220", VA = "0x18691A220")]
	public static bool BLLMJCHKHPH(Stream FEMBCGGKAFB, long CAGKLBMMDCH, EIGKNNEDJHI PAMHOPGINMM, [Out] byte[] HLCKGJCAJOG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
internal sealed class PNFCDAMOJFA : JEENCGOGKPP, IEquatable<JEENCGOGKPP>, IEquatable<PNFCDAMOJFA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006DF")]
	private readonly DGNIEGKHCNH IJCANLDINPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006E0")]
	public readonly FileInfo HELHGCNNHDN;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public BKEHHEOPICK FCCLJCLNCPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x635AEA0", Offset = "0x6359EA0", VA = "0x18635AEA0", Slot = "9")]
		get
		{
			return default(BKEHHEOPICK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public DateTime KDCFIJNLADO
	{
		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x6931970", Offset = "0x6930970", VA = "0x186931970", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x6931ED0", Offset = "0x6930ED0", VA = "0x186931ED0")]
	public PNFCDAMOJFA(DGNIEGKHCNH EKOFAMLCNFD, FileInfo IMLKJKFLKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x6931E20", Offset = "0x6930E20", VA = "0x186931E20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x6931C90", Offset = "0x6930C90", VA = "0x186931C90", Slot = "5")]
	public void GHBOGNHFFHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x6931DE0", Offset = "0x6930DE0", VA = "0x186931DE0", Slot = "6")]
	public bool LDAKAJBMKAO(long CFLPHBNCGDP, long CEJEMJLIMDC, [Out] EIIHNOKEGGJ AFIGHNEJHMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x6931BB0", Offset = "0x6930BB0", VA = "0x186931BB0", Slot = "7")]
	public bool Equals(JEENCGOGKPP JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x6931A00", Offset = "0x6930A00", VA = "0x186931A00", Slot = "8")]
	public bool Equals(PNFCDAMOJFA JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x6931AC0", Offset = "0x6930AC0", VA = "0x186931AC0", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x6931D50", Offset = "0x6930D50", VA = "0x186931D50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
public delegate void EIGKNNEDJHI(HECHJPNILAL.BHJKBDEMKJP PMPHIIIJDFC, string JJJNODJJIFK);
[Cpp2IlInjected.Token(Token = "0x20001A3")]
internal interface AJLKOJAJEOD
{
	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	BKEHHEOPICK FCCLJCLNCPC
	{
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BAAMNGEEHCL(long CFLPHBNCGDP, long CEJEMJLIMDC, JDGAAOKDGFM CMMMKALOAEA, [Out] JEENCGOGKPP NGAIDKANJFL);

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<JEENCGOGKPP> IFJPHPFJCFM(JDGAAOKDGFM CMMMKALOAEA);

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JEENCGOGKPP HJOFNLAEPEB(long CFLPHBNCGDP, long CEJEMJLIMDC, EIIHNOKEGGJ AFIGHNEJHMM, JDGAAOKDGFM CMMMKALOAEA);
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
