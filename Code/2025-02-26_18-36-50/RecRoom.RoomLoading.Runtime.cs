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
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Common;
using RecRoom.Persistence;
using Unity.Profiling;
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
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7C0C9A0", Offset = "0x7C0BDA0", VA = "0x187C0C9A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x975680", Offset = "0x974A80", VA = "0x180975680")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9756C0", Offset = "0x974AC0", VA = "0x1809756C0")]
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
	public class LogRegistrationIndex : EIAOKFHFGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7C06D90", Offset = "0x7C06190", VA = "0x187C06D90", Slot = "4")]
		public override void OCICFIBHEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_RoomLoading_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7C10010", Offset = "0x7C0F410", VA = "0x187C10010", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x242AF30", Offset = "0x242A330", VA = "0x18242AF30")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class JEPHHFGMCHL : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7BFE010", Offset = "0x7BFD410", VA = "0x187BFE010")]
	public JEPHHFGMCHL(string MIALAMIFNLM, Exception DIHKEEPHEOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class KPDMCICBJHH : JBDOFFKILIO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct MLHEFPCIOMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<CCDAHBCPCKI>> <>t__builder;

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
		private TaskAwaiter<JBPILBKHAGM<JHNKENAKGMI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7C0ABA0", Offset = "0x7C09FA0", VA = "0x187C0ABA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7C0ADE0", Offset = "0x7C0A1E0", VA = "0x187C0ADE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct AIKAGNBIHKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<DBEECBAIEKP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<DBEECBAIEKP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7BF2AB0", Offset = "0x7BF1EB0", VA = "0x187BF2AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7BF2CC0", Offset = "0x7BF20C0", VA = "0x187BF2CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	[UnityEngine.Scripting.Preserve]
	public KPDMCICBJHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7C00490", Offset = "0x7BFF890", VA = "0x187C00490", Slot = "4")]
	[AsyncStateMachine(typeof(MLHEFPCIOMH))]
	public Task<IReadOnlyList<CCDAHBCPCKI>> MJLFCHJNIMI(long FFFLOIOFAMB, long GHFFAIKCNFL, [Optional] CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7C00380", Offset = "0x7BFF780", VA = "0x187C00380", Slot = "5")]
	[AsyncStateMachine(typeof(AIKAGNBIHKD))]
	public Task<IReadOnlyList<DBEECBAIEKP>> GJJCNBJDPJA(IReadOnlyList<int> KIGCFNPIJBJ, [Optional] CancellationToken LAEIHJHNGEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface ILOGHKFFJCK : IEquatable<ILOGHKFFJCK>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int EKGHKOCBFEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	DBEECBAIEKP IOIIIAMPFKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime NKNHICAGDFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	PLBDHHLPCDB? HJPCGMLBGAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	PIKIEAEJGHF? HHOAOADHCJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	NPLFGADMADE DDHDAKKKAKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<GGLMIDJEDGD> JIMJEDANMDJ();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum NPLFGADMADE
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JBDOFFKILIO
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<CCDAHBCPCKI>> MJLFCHJNIMI(long FFFLOIOFAMB, long GHFFAIKCNFL, [Optional] CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<DBEECBAIEKP>> GJJCNBJDPJA(IReadOnlyList<int> KIGCFNPIJBJ, [Optional] CancellationToken LAEIHJHNGEK);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class ODBKAOCMIJK
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class FJADBLGECOG : ILOGHKFFJCK, IEquatable<ILOGHKFFJCK>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct ODLPMPGJMEL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<GGLMIDJEDGD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public FJADBLGECOG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private EKKKCNGJBOO <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<EPDFKONBMMJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<GGLMIDJEDGD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7C0CF50", Offset = "0x7C0C350", VA = "0x187C0CF50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7C0D410", Offset = "0x7C0C810", VA = "0x187C0D410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly CCDAHBCPCKI MEPGDKHHEID;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int EKGHKOCBFEO
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x94D480", Offset = "0x94C880", VA = "0x18094D480", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public DBEECBAIEKP IOIIIAMPFKB
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x94B800", Offset = "0x94AC00", VA = "0x18094B800", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime CIFKOFNMDFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2767270", Offset = "0x2766670", VA = "0x182767270", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public PLBDHHLPCDB? HJPCGMLBGAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x104C620", Offset = "0x104BA20", VA = "0x18104C620", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public PIKIEAEJGHF? HHOAOADHCJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2766410", Offset = "0x2765810", VA = "0x182766410", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public NPLFGADMADE DDHDAKKKAKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA6BC50", Offset = "0xA6B050", VA = "0x180A6BC50", Slot = "10")]
			get
			{
				return default(NPLFGADMADE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7BF92B0", Offset = "0x7BF86B0", VA = "0x187BF92B0", Slot = "9")]
		[AsyncStateMachine(typeof(ODLPMPGJMEL))]
		public Task<GGLMIDJEDGD> JIMJEDANMDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7BF93B0", Offset = "0x7BF87B0", VA = "0x187BF93B0")]
		public FJADBLGECOG(int MBIBLBLAFLH, DBEECBAIEKP LFKMDFJLHHG, CCDAHBCPCKI MEPGDKHHEID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7BF90C0", Offset = "0x7BF84C0", VA = "0x187BF90C0", Slot = "11")]
		public bool Equals(ILOGHKFFJCK OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7BF9150", Offset = "0x7BF8550", VA = "0x187BF9150", Slot = "0")]
		public override bool Equals(object GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7BF91F0", Offset = "0x7BF85F0", VA = "0x187BF91F0")]
		private bool FHDOMOHKHIL(FJADBLGECOG OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7BF9230", Offset = "0x7BF8630", VA = "0x187BF9230", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class GPADFBDCLKL : ILOGHKFFJCK, IEquatable<ILOGHKFFJCK>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct DJCDNLAJIMP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<GGLMIDJEDGD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public GPADFBDCLKL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<GGLMIDJEDGD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7BF8700", Offset = "0x7BF7B00", VA = "0x187BF8700", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7BF8950", Offset = "0x7BF7D50", VA = "0x187BF8950", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly JICNBBCNCAC FMCKNANIOCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly PLBDHHLPCDB KGABHKKMHOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly PIKIEAEJGHF KGFFBLPDGBD;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int EKGHKOCBFEO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7BFC2A0", Offset = "0x7BFB6A0", VA = "0x187BFC2A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public DBEECBAIEKP IOIIIAMPFKB
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7BFC2E0", Offset = "0x7BFB6E0", VA = "0x187BFC2E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime CIFKOFNMDFI
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7BFC520", Offset = "0x7BFB920", VA = "0x187BFC520", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public PLBDHHLPCDB? HJPCGMLBGAM
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7BFC730", Offset = "0x7BFBB30", VA = "0x187BFC730", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public PIKIEAEJGHF? HHOAOADHCJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7BFC6E0", Offset = "0x7BFBAE0", VA = "0x187BFC6E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public NPLFGADMADE DDHDAKKKAKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xA66FC0", Offset = "0xA663C0", VA = "0x180A66FC0", Slot = "10")]
			get
			{
				return default(NPLFGADMADE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1BE5860", Offset = "0x1BE4C60", VA = "0x181BE5860")]
		public GPADFBDCLKL(JICNBBCNCAC HNGPDEBEPAB, PLBDHHLPCDB HNCPOCNKKJK, PIKIEAEJGHF PFCGBJNJLHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7BFC5F0", Offset = "0x7BFB9F0", VA = "0x187BFC5F0", Slot = "9")]
		[AsyncStateMachine(typeof(DJCDNLAJIMP))]
		public Task<GGLMIDJEDGD> JIMJEDANMDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7BFC420", Offset = "0x7BFB820", VA = "0x187BFC420", Slot = "11")]
		public bool Equals(ILOGHKFFJCK OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7BFC370", Offset = "0x7BFB770", VA = "0x187BFC370", Slot = "0")]
		public override bool Equals(object GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7BFC4C0", Offset = "0x7BFB8C0", VA = "0x187BFC4C0")]
		private bool FHDOMOHKHIL(GPADFBDCLKL OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7BFC570", Offset = "0x7BFB970", VA = "0x187BFC570", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class MNHGHGLFJBJ : ILOGHKFFJCK, IEquatable<ILOGHKFFJCK>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct AFDHMPACOGO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<GGLMIDJEDGD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<GGLMIDJEDGD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7BF25F0", Offset = "0x7BF19F0", VA = "0x187BF25F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7BF2850", Offset = "0x7BF1C50", VA = "0x187BF2850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly DBEECBAIEKP MLGLKMBEGJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly PLBDHHLPCDB KGABHKKMHOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly PIKIEAEJGHF KGFFBLPDGBD;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int EKGHKOCBFEO
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7C0AE50", Offset = "0x7C0A250", VA = "0x187C0AE50", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public DBEECBAIEKP IOIIIAMPFKB
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime CIFKOFNMDFI
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public PLBDHHLPCDB? HJPCGMLBGAM
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7C0B1F0", Offset = "0x7C0A5F0", VA = "0x187C0B1F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public PIKIEAEJGHF? HHOAOADHCJO
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7C0B1A0", Offset = "0x7C0A5A0", VA = "0x187C0B1A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public NPLFGADMADE DDHDAKKKAKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "10")]
			get
			{
				return default(NPLFGADMADE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1BE5860", Offset = "0x1BE4C60", VA = "0x181BE5860")]
		public MNHGHGLFJBJ(DBEECBAIEKP LFKMDFJLHHG, PLBDHHLPCDB HNCPOCNKKJK, PIKIEAEJGHF PFCGBJNJLHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7C0B0D0", Offset = "0x7C0A4D0", VA = "0x187C0B0D0", Slot = "9")]
		[AsyncStateMachine(typeof(AFDHMPACOGO))]
		public Task<GGLMIDJEDGD> JIMJEDANMDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7C0AE70", Offset = "0x7C0A270", VA = "0x187C0AE70", Slot = "11")]
		public bool Equals(ILOGHKFFJCK OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7C0AEE0", Offset = "0x7C0A2E0", VA = "0x187C0AEE0", Slot = "0")]
		public override bool Equals(object GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7C0B040", Offset = "0x7C0A440", VA = "0x187C0B040", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7C0AF60", Offset = "0x7C0A360", VA = "0x187C0AF60")]
		private bool FHDOMOHKHIL(MNHGHGLFJBJ OKCHLIEAIJP)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct BFMMFGPBLFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<ILOGHKFFJCK>> <>t__builder;

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
		public ODBKAOCMIJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<CCDAHBCPCKI> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<CCDAHBCPCKI>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, DBEECBAIEKP account, CCDAHBCPCKI roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7BF4A80", Offset = "0x7BF3E80", VA = "0x187BF4A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7BF58C0", Offset = "0x7BF4CC0", VA = "0x187BF58C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct BDGCAOJOGIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, DBEECBAIEKP account, CCDAHBCPCKI roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<CCDAHBCPCKI> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public ODBKAOCMIJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<DBEECBAIEKP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7BF3ED0", Offset = "0x7BF32D0", VA = "0x187BF3ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7BF48D0", Offset = "0x7BF3CD0", VA = "0x187BF48D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly MLLFMMCDFHB NKHALHDCMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly JBDOFFKILIO GLHAEGHOLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly GBKJFIMCMFN FFKEAHPFOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly HNFGOLPBJLN<(long, long), IReadOnlyList<CCDAHBCPCKI>> DIAFGGNJELO;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7C0CE20", Offset = "0x7C0C220", VA = "0x187C0CE20")]
	[UnityEngine.Scripting.Preserve]
	public ODBKAOCMIJK([IBJCGEMJMJL(null)] JBDOFFKILIO GKGBKHAIAFK, [IBJCGEMJMJL(null)] GBKJFIMCMFN GABMMHOCOPK, [IBJCGEMJMJL(null)] MLLFMMCDFHB IBOEAOHNAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7C0CB30", Offset = "0x7C0BF30", VA = "0x187C0CB30")]
	[AsyncStateMachine(typeof(BFMMFGPBLFE))]
	public Task<IList<ILOGHKFFJCK>> CACKNOECBDP(long FFFLOIOFAMB, long OGHBKCHPPKA, bool CFBPABAAKPD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7C0CC80", Offset = "0x7C0C080", VA = "0x187C0CC80")]
	private bool MOJHFBLDGMN(DateTime? AAMKJDBEGPK, long FFFLOIOFAMB, long OGHBKCHPPKA, [Out] JICNBBCNCAC CIIBJONMFCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C0CA20", Offset = "0x7C0BE20", VA = "0x187C0CA20")]
	[AsyncStateMachine(typeof(BDGCAOJOGIM))]
	private Task<IReadOnlyList<(int, DBEECBAIEKP, CCDAHBCPCKI)>> BOLJJFHDLEG(IReadOnlyList<CCDAHBCPCKI> OAGFLGICHBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface GBKJFIMCMFN
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<JICNBBCNCAC> JCFEMMEGFDJ;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ICKKOCNOPIK(long FFFLOIOFAMB, long OGHBKCHPPKA, FIHJMIFDKFO KHDKGFGGFBO, DPOOOLNKMNK KEGDNPBCBNK);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IHHBEPAKLHM(long FFFLOIOFAMB, long OGHBKCHPPKA, [Out] JICNBBCNCAC CIIBJONMFCP);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DONKKGDHALC(long FFFLOIOFAMB, long OGHBKCHPPKA, DPOOOLNKMNK KEGDNPBCBNK, [Out] JICNBBCNCAC CIIBJONMFCP);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BKBMFNAHOML(long FFFLOIOFAMB, long OGHBKCHPPKA);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface DPIIEOFIMOM : HJPHNPODALD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool MACAIMLIHLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task PKHMDMABMJB
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BDMONGODBMC(Task CBPINBDBDCO, string MHKIBDNHKBD);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface KPLLGNPEHIH : HJPHNPODALD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GGLMIDJEDGD> KHCOBLOPMED(JICNBBCNCAC CIIBJONMFCP);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NBOEIFCOODG(CancellationToken LAEIHJHNGEK);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface DFPFMGJEMIJ : HJPHNPODALD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	FJGBFJOGCIJ ODEPJIBCIOA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BFIDLKAKGHF();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NOJCJJMPODG();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface HJPHNPODALD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HPHCPPKCEKM(CFEMEJBKCKD GHFCFJHMPHJ);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface OBPMHPKAJAE
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan AMBNFMBHAKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan OFPFCEAELIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan LPIDEMCAIHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan OCMKBAODPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool ONNBHNKGGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool BJJBIDFBEFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool LGMMLPDBBMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int LPGOOAMPLCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool NKHLDFHBKPB
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool POLLNJJDHMC
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum EGNAIGBOKNB
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum FDFGBGCLFKC
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
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct ONLCNDEELLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long HHDCJNGKHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long GHFFAIKCNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly EGNAIGBOKNB BMIPLDLMPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception HINHJPOOGLA;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7C0DBF0", Offset = "0x7C0CFF0", VA = "0x187C0DBF0")]
	public ONLCNDEELLL(long HHDCJNGKHGF, long GHFFAIKCNFL, EGNAIGBOKNB BMIPLDLMPCD, [CanBeNull] Exception HINHJPOOGLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7C0DBA0", Offset = "0x7C0CFA0", VA = "0x187C0DBA0")]
	public static ONLCNDEELLL BIBMBKHCCLP(GDBFIEIFOFD KMMJGNHILKN, EGNAIGBOKNB BMIPLDLMPCD, [Optional] Exception HINHJPOOGLA)
	{
		return default(ONLCNDEELLL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate void BHFIBGOCBGD(ONLCNDEELLL EDKKLGLMFKE);
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface CIJEFFLHNAA : HJPHNPODALD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action KOLOFNNGBAD;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event BHFIBGOCBGD BGEHMJMFPEG;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event BHFIBGOCBGD FBFLJJCBJCE;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event BHFIBGOCBGD MIMOGFPFFMB;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FNGFDLAHFPI();

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PDEEODDPKFD(ONLCNDEELLL EDKKLGLMFKE);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NDOILGLNJLL(ONLCNDEELLL EDKKLGLMFKE);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HDJGIOOMCDN(ONLCNDEELLL EDKKLGLMFKE);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MCHPNIELGPN(FDFGBGCLFKC MNGFNEKIDGN, bool JHGFMOPHGIB);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface FCMBODEBKNC : HJPHNPODALD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public enum Reason
	{
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		Invalid,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		TestCase,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		ServerDisconnect_ClientTimeout,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		ServerDisconnect_ServerTimeout,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		ServerDisconnect_ByServer,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		ServerDisconnect_ByClient,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		ServerDisconnect_Other,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		PresenceUpdate_SentToInvalidInstance,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		UnhandledExceptionDuringInitialRoomLoad,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		UnhandledExceptionDuringNonInitialLoad,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		FallbackFailure_UnhandledException,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		FallbackFailure_NoInternetConnection,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		FallbackFailure_Timeout,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		FallbackFailure_Cancelled,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		FallbackFailure_EndedInInvalidInstance,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		FallbackFailure_EndedInIncorrectInstance,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		FallbackFailure_EndedInIncorrectScene,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		FallbackFailure_AlreadyInTargetInstance,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		FallbackFailure_MatchmakingError
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool KLILGEALKOB
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NKJMPPNAMIC(Reason CEGFAIJENKH = Reason.Unknown);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LOJFANEMFED();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface FCMMGHLPILA : HJPHNPODALD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	TaskStatus DAHJAKNNHFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GJMCAALDLPD(GDBFIEIFOFD DHCIGOGFOEM, KLIKFJJFGJN KEFMNOFFBJN, CancellationToken DGLOFFGGICM);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class ONCFMADCJPL
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7C0DB50", Offset = "0x7C0CF50", VA = "0x187C0DB50")]
	public static bool OGDMFDDNMHJ(this FCMMGHLPILA HIENPDPIDMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public delegate Task CNLHFGLFLAC(CancellationToken LAAJFAFNFCN, int HGKMPCJFPLO, KNBIGIEKHKK KECAFPMAPCB);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface LCEMKOAHHCJ : HJPHNPODALD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HAHOBNDICJG(CNLHFGLFLAC KCNPFBCDHKP);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface CFEMEJBKCKD : EKKKCNGJBOO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	CancellationToken GGAJKGNLFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	GFKEMDIOCPC GJEBDKBIJEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	JFIOHCKEEIP MEDPGHPDIBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	PABAJGGCEIB OPDEEJLEAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	JJKJBCNAAJM MNHGCFJHHHI
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	JBCPMCBEPKG AABBPKBJLHN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	FFGHMBJEEPI KNCHOHPEJLD
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	ENHCOOGKGFN IBKKPEDKHPH
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	MBLNBFNLDAN KNCLIBPLBMC
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	DPIIEOFIMOM PHPFCFNFHLC
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	KPLLGNPEHIH BLOAHGPPOGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	CIJEFFLHNAA AGMOJFIJANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	FCMBODEBKNC OINFPFHDCHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	FCMMGHLPILA HHHIMKMGAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	LCEMKOAHHCJ IOMAKCALOKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	IFLFCLCHFEP KPNECHLBHHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	PMEHDCBJAMG JCPCCAIJBJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	GKBANNDJOKF BBMICFEAICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	AGKANHNJNLI HOLJPLDMKMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	PGODPOGHOLM NIAAEALDING
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	NKMJHFBEIDI OIIIDMNDHPP
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	DCMMBBANFEL COMDGOENGJF
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	FIJOEDODGBA BBCPFOAOKGM
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	KAONJJMLICJ PDEAINCIGPI
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	OICHENLNLMC HJMDJIOKCKO
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	DFPFMGJEMIJ NECKCCAIJPD
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	OBPMHPKAJAE OFABDIKCLFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	MLDPBHLIHNF LJMHJJJIELH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	GBKJFIMCMFN FIHFHECHDPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	IGEMEIBHHGN PBLKGCCPGLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	EGCFGIOCDGL LBFDAHGOLBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	KOGJGNIFGMB IJMHCEAMIBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	COLHIDLGKEK BPLNIKHAODG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	new bool IAMBHEBPFLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void FNIHNPMDEGC(KLIKFJJFGJN BDEANLGMCMP);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface IFLFCLCHFEP : HJPHNPODALD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AHECFMBNCBG HBHDBABAKDP(Guid EHMIFANHMPO);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OCDDHDAHAOD(Guid EHMIFANHMPO);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GAKIHJOFNMP(Guid EHMIFANHMPO, Task HALLDLPJOAJ);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LLEBADGMFLH(Guid EHMIFANHMPO, GGLMIDJEDGD HLHFLNDDPMM);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(GGLMIDJEDGD, Task)> IKNBHLBIMGO(Guid EHMIFANHMPO);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface MGDLBKFILKB : HJPHNPODALD, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface PMEHDCBJAMG : HJPHNPODALD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MFHFHJDKEDK(KKBOOBAMIML MIALAMIFNLM);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNHAKONBPOC(KKBOOBAMIML MIALAMIFNLM);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<IICNNDCPJEP> MIGBBFJGPHO(CancellationToken OBDPPPBJBFI);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface GKBANNDJOKF : HJPHNPODALD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AHECFMBNCBG HGLBMLMGBFM(KKBOOBAMIML LFICHDNKEMG);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BFIIGPGIAMF(Guid EHMIFANHMPO, Task HALLDLPJOAJ);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface AGKANHNJNLI : HJPHNPODALD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GGLMIDJEDGD> HOLJPLDMKMI(KKBOOBAMIML FNHJGBHLJLO);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface PGODPOGHOLM : HJPHNPODALD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HLOJEJEEEIJ> DNCEKBDAJFI(FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, GDBFIEIFOFD DHCIGOGFOEM, CancellationToken LAEIHJHNGEK);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface DCMMBBANFEL : HJPHNPODALD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GGLMIDJEDGD LDPDMFOPNIP(OPHKANJGPPK PCCBNDDCHNF);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task FGPHEEIMFAD(string DPEONNMDCPO);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface NKMJHFBEIDI : HJPHNPODALD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KKBOOBAMIML> LLJLNJMCBHI(KKBOOBAMIML NEMAHPGAGLG, OKCNIPGMDHK LNEKCGEMFKF, CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<KKBOOBAMIML> EKKLCMPHPCM(CancellationToken LAEIHJHNGEK, OKCNIPGMDHK LNEKCGEMFKF);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LGACCJIPMFL EPCMPIFOELB(GPIPDBGGDOE BINLGGPBHKF, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LGACCJIPMFL PCFPIJDPFLE(GPIPDBGGDOE BINLGGPBHKF, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface FIJOEDODGBA : HJPHNPODALD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GGLMIDJEDGD DCODFNMJCMH(OPHKANJGPPK PCCBNDDCHNF, IICNNDCPJEP IJECCKDIIBB);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GGLMIDJEDGD GJFDLFDAOAI(OPHKANJGPPK OFAFOALBCJK);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface KAONJJMLICJ
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FPCBPDEDEJP(MOHCECBCNBF MLLEHDDGIDO);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BKEMINFGCGO(MOHCECBCNBF MLLEHDDGIDO);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NKDEMNONHHF(MOHCECBCNBF MLLEHDDGIDO);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NKLGJAKJHLP(MOHCECBCNBF MLLEHDDGIDO);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class MOHCECBCNBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly GDBFIEIFOFD LKFJBGOPLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private Dictionary<string, string> GKLCHDICMMN;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public FGFDKLMANEA<string> FDLLKFHNDEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x94B800", Offset = "0x94AC00", VA = "0x18094B800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x94BA00", Offset = "0x94AE00", VA = "0x18094BA00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x951BA0", Offset = "0x950FA0", VA = "0x180951BA0")]
	public MOHCECBCNBF(GDBFIEIFOFD FJKJDPBPFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7C0B240", Offset = "0x7C0A640", VA = "0x187C0B240")]
	public MOHCECBCNBF HDNBEKIKOKN(string LKMGECEEGEE, string KBGCCIOIGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7C0B310", Offset = "0x7C0A710", VA = "0x187C0B310")]
	public bool JGLPDMLONCF([Out] IEnumerable<KeyValuePair<string, string>> DFCAGDHCENM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6CC7420", Offset = "0x6CC6820", VA = "0x186CC7420")]
	public MOHCECBCNBF KEICJFHIAJG(FGFDKLMANEA<string> ACNLNBKGHCE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface MLDPBHLIHNF
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool DMLMHKDAKPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string HLIBCKNADPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool KBLBFPAPBIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JEKBCJPJMLN();

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EAEHGMBKJAK KNIGFCJBFCN(long KGGKGOKAJFO);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GFADJGFDDHP<DDDGOPGHMJC, HFDFODLNHEC> NOMCENNLMBP(long KGGKGOKAJFO);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GFADJGFDDHP<DDDGOPGHMJC, BDHMMMHCHAA> BIKJMGAFNFP(long KGGKGOKAJFO);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GFADJGFDDHP<long, IPICNJAGLAJ> BDPONCEJILC();

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool APEFDMFINIG(long KGGKGOKAJFO, [Out] bool AGPCOPEHNOA);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<bool> OACDPPKMPNK(byte[] LBDLMMONJCN, byte[] BKNHKBPEOPF, CancellationToken LAEIHJHNGEK);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface EKKKCNGJBOO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool OGDMFDDNMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool JOHJFBAPLND
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool IAMBHEBPFLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	KLIKFJJFGJN FBGNEOOJICB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action KOLOFNNGBAD;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event BHFIBGOCBGD BGEHMJMFPEG;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event BHFIBGOCBGD FBFLJJCBJCE;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event BHFIBGOCBGD MIMOGFPFFMB;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LOJFANEMFED();

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "12")]
	PDOFNJJFGGG GBOHIKKIDNE();

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NNPFBKHPJCA MCEOJDHKKNA();

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task<GGLMIDJEDGD> KHCOBLOPMED(JICNBBCNCAC HNGPDEBEPAB);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task NBOEIFCOODG(CancellationToken LAEIHJHNGEK);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface JBCPMCBEPKG
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool IEKEDAJGKAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	string KBOFHEJFGBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AFAICANKEKJ(Scene IKIFIPCFCAK);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task POFBDKGIBFN(GNOIADKGAKA HAHHGLICJKA, IReadOnlyList<GNOIADKGAKA> LIHGJCKLJPP, CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task GPEMBCOABCB();

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task HCODODKKBIL();
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface JJKJBCNAAJM
{
	[Cpp2IlInjected.Token(Token = "0x17000054")]
	FBKMDCBFBII IELHGPMHDJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool JDAJIHBICLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool NDAMAILPILM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool ONHLGOOGPBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool FMAKLHLABOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	int LKKDFBNFBHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool ECHDLCKIPIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool KBDBJLOKCKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	int KDBBJFBCKKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	int GOCHGOMPGEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool HMJLNLMDMEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	bool JLOLNCHBJPC
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool DLPBDDKMGLG
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	float JAPCFPADPNL
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<float> OHKFJCAOJJI;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GFKEMDIOCPC EEEEGGLCMDD(GFKEMDIOCPC MJDEJLBGNCP);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AFLAIEJAMAP(GFKEMDIOCPC MGOKPJKELJG);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NOKFNOJLCEF();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task NFBAPPKPGIP(FGFDKLMANEA<string>.ICBJPFEBGDJ FMNICGKBFPD, CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ALAKPALLAHP(float KBBMEHINNKF);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HDMLFPDKBNM(string BPDGMLOBIKL);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<JKEGNLFNIEK> ADFJLIIPHPB();

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable EJNCDPLKNDI(object BPPCEJGCMKA, JKEGNLFNIEK AOGBMEDINNC);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<HHFNEHONJPO> CHCIAKKJPCM();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HFDFODLNHEC EJMDJLGJOPD(IEnumerable<PGEJPEMIJFO> MKBLJMJKMBD);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FODNLELDLGN(int FOBKIBNHAIN);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task HAOCONFFIJK();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void DDFPKPMLBEB();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool KEKPPOPBDNK();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task PKKDNMLBEAL(CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task ELOEIOCFIJM(CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<DAINPBEHNNK> PCPPCCDKION(DateTime HHGBEDNKANA, CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> OBKFJBJABFH(CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void IANCFKAHGCO(string MIALAMIFNLM = "", float LKDAAJDJIMN = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "25")]
	DONOJMBDAEC DFMDODJAGBF(MCIKJBCGIFM COFLABALPJG, LDLMBBIODPI OFPNBIDICMP, BDHMMMHCHAA BFKCOJOKKKN, IEnumerable<PersistenceView> ILKGDALPJFB, DHFOBBNDABM GNHOFHLJPMM);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void NKDEHPNIJEM(BDHMMMHCHAA BFKCOJOKKKN);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void MCJCIIBHHEF(PGEJPEMIJFO JOHGLFIKFAB, [In] DONOJMBDAEC KPNKMJMEKBH);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task BMLEPELCLLL(BDHMMMHCHAA HKMOFGELBFL, bool ODBNPPCAHOA, CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task EOOEPNKKAMI(CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void ELPMMOJPHHL(long FFFLOIOFAMB, long GHFFAIKCNFL, EPDFKONBMMJ OCNEFBOFEOP, CCDAHBCPCKI LHJPDJMBCCB, FIHJMIFDKFO KHDKGFGGFBO, ABMKIBHCAFE? FPKAICKNAPP, NKALECBGCLE? FMBNFEHPPJK);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void CKKOEMPGALP(long FFFLOIOFAMB, long GHFFAIKCNFL, NKALECBGCLE? FMBNFEHPPJK);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void JJILEANAIAA(PersistenceView LGIBBHGNFNO);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void LPPIJPOGNOF(string HONMDOFCACM, GDBFIEIFOFD FJKJDPBPFHP, ALHPBBOBFGN BFAPGALGCNE, [Optional] string? NOFPJMBGCMI, [Optional] string? NLGBJKCOGKL, [Optional] string? ABJDEJGJGFC);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool KBALFGMNPJO(PersistenceView GAFKCGNMDOE);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool IGDKHBCCAID(PGEJPEMIJFO JOHGLFIKFAB, GPALOJEHCIG MCCHAEKDNLN, [Out] IDECODEGFDL HDCIOAIJEFF);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task BCGIGANMKNJ(CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void DIHOGOLBOIP();

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "38")]
	IDisposable OKKGJOIAHDI();

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void KKHJAPECCHL(BDHMMMHCHAA HKMOFGELBFL, GPALOJEHCIG MCCHAEKDNLN);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<bool> HNOMOPKAPGB(JFIOHCKEEIP MGMCFGLJIGI, CancellationToken LAEIHJHNGEK, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void GIEBOHAMPOL(CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<AKEHIKAMMJM> EMKKCOKHMFB(PIGNKOFBEKF NEMAHPGAGLG);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<EPDFKONBMMJ> DEIMFBLAHCB(long FFFLOIOFAMB, bool FLFNIBCEEEJ, CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<JHNKENAKGMI> NONIBLJEHDA(long FFFLOIOFAMB, long GHFFAIKCNFL, long AFCAJMDPILG, CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<JHNKENAKGMI> EMIKALKJAEM(long FFFLOIOFAMB, long GHFFAIKCNFL, CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<HGLCHBODEAA> MBGAKKIANAF(string BPPPCIKOLON, CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "47")]
	Task<HGLCHBODEAA> NPAJIDKFFBB(string BPPPCIKOLON, long FFFLOIOFAMB, long GHFFAIKCNFL, string HDFGNIINOHH, NINDCCCDADD.LJLOIGMEIFH MIMFFPFKBEA, NINDCCCDADD.LJLOIGMEIFH BKNHKBPEOPF, int NCACHKHPMEG);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "49")]
	bool LLIKJJMLFCH();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool DODCDJCOABG();

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool BBFFDFJKBJD(IEnumerable<IDECODEGFDL> KEHOPFGECKG);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "52")]
	void EOGMIPAKGPD(List<GameObject> CAKPHJHDPLB);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "53")]
	float NKOFOJPEEAG();

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "54")]
	Task<bool> NCEAOFNLCOP(CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "55")]
	Task<Scene> IMMCCBPEFCO(string GOCBDOMNJJE, LoadSceneMode BALFDMIJJAJ, bool KFJFEEGFJLE, FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void GLJCJOCHJHK();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void JBCADINJCCP(bool GCDMKJKGKMA);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void BDMKFKFBLDL();

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "63")]
	void NANACBHIMAI();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void LHBKJFJKACK(bool FFJECJADKLA);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void FLOAGJDPGNF(GDBFIEIFOFD PNLPGKBGHHP);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "71")]
	Task MIBJENBLHOH(FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "72")]
	Task HACIABFEBDG(FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "73")]
	Task KGJKBOMMNMF(FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task IKBANJLHMAI(FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "75")]
	IDisposable AFPGDFIGKOM();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "76")]
	HDMJEPDNFFH MELLFDCAJEA();

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "77")]
	Task OGKJBLEHDAC(CancellationToken LAEIHJHNGEK);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface HDMJEPDNFFH
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task BHBCDFNLENC(CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CIJJMLJGCLJ(CancellationToken LAEIHJHNGEK);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct DONOJMBDAEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public HashSet<int> LGKHAGFDIME;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public enum DAINPBEHNNK : byte
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	No,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct MCIKJBCGIFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public string LDCCKJFDLNH;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface FBKMDCBFBII
{
	[Cpp2IlInjected.Token(Token = "0x17000062")]
	GDBFIEIFOFD GIAOPMCNFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	EPDFKONBMMJ LOFGFEACKLF
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	KOLBKODMCOP PHENFKDPING
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool NDHFBHHNDPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	bool NPLHFMGJAIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	int EBFEFFCMHNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action DGGKHFIPOPG;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<int> FFNCCKFPALI;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JCMHJAPIFDE();

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.PDLIEJBBEGE> PJBIIBNIDDH(long KGGKGOKAJFO, [Optional] CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<JEDBNHDCOIL> DGCIOBCPMBP(GDBFIEIFOFD FJKJDPBPFHP, [Optional] KLIKFJJFGJN KEFMNOFFBJN);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<JEDBNHDCOIL> BDJHOBEIDGL();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task PGLHNAKLHFI();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "15")]
	(GDBFIEIFOFD, KLIKFJJFGJN) LIPNJDOAEDJ();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IBBHMOLEKHK DANBGJFACLP();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void CFLPJCOLKBI(long KGGKGOKAJFO);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void HCOAIHPEJNP(GDBFIEIFOFD FJKJDPBPFHP, Matchmaking.MNCMKBGCEKL BIEIOPPGBOB, (int Major, int? Minor)? HKJCJLGBMOM);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface OICHENLNLMC
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LKIBLJONKGL([Out] IEnumerable<int> JODMOBKELOG);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KNBMOLHAGIH(FDINGGDGHDL LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HEEJONIDAME(FDINGGDGHDL LAAJFAFNFCN);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface AEGILOCDDFP
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string GOCCELFKNHM(GGLMIDJEDGD DNHNCONLMMK);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface IFHHAIBGOKI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CGJCKCBCGDD(COKLCMLMHGP.OKGDMFMHACK MPMNOKLGMMG);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KPHLKODFGBA(COKLCMLMHGP.OKGDMFMHACK MPMNOKLGMMG);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface FFGHMBJEEPI : IFHHAIBGOKI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GGLMIDJEDGD ICFPILFCHIO(OPHKANJGPPK OFAFOALBCJK);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface ENHCOOGKGFN : IFHHAIBGOKI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GGLMIDJEDGD LDPDMFOPNIP(OPHKANJGPPK EFGAKBIDOLG);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface EAEHGMBKJAK
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JOFBNNGKBOO<GNOIADKGAKA, PGAGFEIEKID>> NGDNNJACGFJ(string HDFGNIINOHH, long KGGKGOKAJFO, long? FFFLOIOFAMB, long? GHFFAIKCNFL, POCLACLHDNA.FKMGIKDICFJ GDCPCFLAODN, CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<JOFBNNGKBOO<IReadOnlyList<GNOIADKGAKA>, PGAGFEIEKID>> OADPDEHHAPO(IReadOnlyList<HFBGJKKCMEJ> CJHJCCPNCMF, CancellationToken LAEIHJHNGEK);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface GFADJGFDDHP<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JOFBNNGKBOO<ENCJOPBFNLI<TData>, PGAGFEIEKID>> AEBKHDPJLEJ(TGetDataArg ICONKPKJBGN, CancellationToken LAEIHJHNGEK);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal sealed class KFMILBOLIBF : CFEMEJBKCKD, EKKKCNGJBOO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct ODMPPCMIPCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public AsyncTaskMethodBuilder<GGLMIDJEDGD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public KFMILBOLIBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public JICNBBCNCAC autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TaskAwaiter<GGLMIDJEDGD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7C0D480", Offset = "0x7C0C880", VA = "0x187C0D480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7C0D700", Offset = "0x7C0CB00", VA = "0x187C0D700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct HPNDGOEOFMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public KFMILBOLIBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7BFDA00", Offset = "0x7BFCE00", VA = "0x187BFDA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7BFDC30", Offset = "0x7BFD030", VA = "0x187BFDC30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class BCKGCFPIBIL : IEnumerable<HJPHNPODALD>, IEnumerable, IEnumerator<HJPHNPODALD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private HJPHNPODALD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public KFMILBOLIBF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		private HJPHNPODALD System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xD230D0", Offset = "0xD224D0", VA = "0x180D230D0")]
		[DebuggerHidden]
		public BCKGCFPIBIL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7BF3A20", Offset = "0x7BF2E20", VA = "0x187BF3A20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7BF3E80", Offset = "0x7BF3280", VA = "0x187BF3E80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7BF3DD0", Offset = "0x7BF31D0", VA = "0x187BF3DD0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HJPHNPODALD> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7BF3DD0", Offset = "0x7BF31D0", VA = "0x187BF3DD0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly CancellationTokenSource EFHNLKOKFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly GFKEMDIOCPC MGOKPJKELJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private bool NLNPPHMOFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private LMLAKHIAEAD OJAOJJHKBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool IBEHBOPKFCF;

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public JFIOHCKEEIP MEDPGHPDIBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x94FD70", Offset = "0x94F170", VA = "0x18094FD70", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x94FB10", Offset = "0x94EF10", VA = "0x18094FB10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public PABAJGGCEIB OPDEEJLEAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x94FCC0", Offset = "0x94F0C0", VA = "0x18094FCC0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x94FD40", Offset = "0x94F140", VA = "0x18094FD40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public JJKJBCNAAJM MNHGCFJHHHI
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x951C60", Offset = "0x951060", VA = "0x180951C60", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x951C70", Offset = "0x951070", VA = "0x180951C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public JBCPMCBEPKG AABBPKBJLHN
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x94FD90", Offset = "0x94F190", VA = "0x18094FD90", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x94FD10", Offset = "0x94F110", VA = "0x18094FD10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public FFGHMBJEEPI KNCHOHPEJLD
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x94FD00", Offset = "0x94F100", VA = "0x18094FD00", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x94FAE0", Offset = "0x94EEE0", VA = "0x18094FAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public ENHCOOGKGFN IBKKPEDKHPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x955550", Offset = "0x954950", VA = "0x180955550", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9555C0", Offset = "0x9549C0", VA = "0x1809555C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public MBLNBFNLDAN KNCLIBPLBMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x955640", Offset = "0x954A40", VA = "0x180955640", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x9554E0", Offset = "0x9548E0", VA = "0x1809554E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public DPIIEOFIMOM PHPFCFNFHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9555D0", Offset = "0x9549D0", VA = "0x1809555D0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x955500", Offset = "0x954900", VA = "0x180955500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public KPLLGNPEHIH BLOAHGPPOGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA6B960", Offset = "0xA6AD60", VA = "0x180A6B960", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x1112680", Offset = "0x1111A80", VA = "0x181112680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public CIJEFFLHNAA AGMOJFIJANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x955620", Offset = "0x954A20", VA = "0x180955620", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x955600", Offset = "0x954A00", VA = "0x180955600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public FCMBODEBKNC OINFPFHDCHF
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xB83C50", Offset = "0xB83050", VA = "0x180B83C50", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xCDF050", Offset = "0xCDE450", VA = "0x180CDF050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public FCMMGHLPILA HHHIMKMGAKN
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x94E950", Offset = "0x94DD50", VA = "0x18094E950", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x94E910", Offset = "0x94DD10", VA = "0x18094E910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public LCEMKOAHHCJ IOMAKCALOKK
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xAB50D0", Offset = "0xAB44D0", VA = "0x180AB50D0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xCF2C30", Offset = "0xCF2030", VA = "0x180CF2C30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public IFLFCLCHFEP KPNECHLBHHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xBDB1F0", Offset = "0xBDA5F0", VA = "0x180BDB1F0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xBDB200", Offset = "0xBDA600", VA = "0x180BDB200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public MGDLBKFILKB HKGKHFNMCNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xB83B20", Offset = "0xB82F20", VA = "0x180B83B20", Slot = "58")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xF73B50", Offset = "0xF72F50", VA = "0x180F73B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public PMEHDCBJAMG JCPCCAIJBJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xB6EF10", Offset = "0xB6E310", VA = "0x180B6EF10", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xBF2860", Offset = "0xBF1C60", VA = "0x180BF2860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public GKBANNDJOKF BBMICFEAICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA36890", Offset = "0xA35C90", VA = "0x180A36890", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA362B0", Offset = "0xA356B0", VA = "0x180A362B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public AGKANHNJNLI HOLJPLDMKMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x94E8C0", Offset = "0x94DCC0", VA = "0x18094E8C0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x94E930", Offset = "0x94DD30", VA = "0x18094E930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public PGODPOGHOLM NIAAEALDING
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA3AE70", Offset = "0xA3A270", VA = "0x180A3AE70", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7C0", Offset = "0xA39BC0", VA = "0x180A3A7C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public NKMJHFBEIDI OIIIDMNDHPP
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA54810", Offset = "0xA53C10", VA = "0x180A54810", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA52C20", Offset = "0xA52020", VA = "0x180A52C20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public DCMMBBANFEL COMDGOENGJF
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA34A30", Offset = "0xA33E30", VA = "0x180A34A30", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA52E70", Offset = "0xA52270", VA = "0x180A52E70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public FIJOEDODGBA BBCPFOAOKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA34B60", Offset = "0xA33F60", VA = "0x180A34B60", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA3AD40", Offset = "0xA3A140", VA = "0x180A3AD40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public KAONJJMLICJ PDEAINCIGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xA34B70", Offset = "0xA33F70", VA = "0x180A34B70", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA30FA0", Offset = "0xA303A0", VA = "0x180A30FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public OICHENLNLMC HJMDJIOKCKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x9BC210", Offset = "0x9BB610", VA = "0x1809BC210", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9B6EB0", Offset = "0x9B62B0", VA = "0x1809B6EB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public DFPFMGJEMIJ NECKCCAIJPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xA24290", Offset = "0xA23690", VA = "0x180A24290", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x11F2B00", Offset = "0x11F1F00", VA = "0x1811F2B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public OBPMHPKAJAE OFABDIKCLFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x9B49B0", Offset = "0x9B3DB0", VA = "0x1809B49B0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA30560", Offset = "0xA2F960", VA = "0x180A30560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public MLDPBHLIHNF LJMHJJJIELH
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x9AE780", Offset = "0x9ADB80", VA = "0x1809AE780", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA598C0", Offset = "0xA58CC0", VA = "0x180A598C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public GBKJFIMCMFN FIHFHECHDPD
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x9BB8D0", Offset = "0x9BACD0", VA = "0x1809BB8D0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public IGEMEIBHHGN PBLKGCCPGLE
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x9B9F30", Offset = "0x9B9330", VA = "0x1809B9F30", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public EGCFGIOCDGL LBFDAHGOLBK
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x9BA830", Offset = "0x9B9C30", VA = "0x1809BA830", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public KOGJGNIFGMB IJMHCEAMIBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x9B9300", Offset = "0x9B8700", VA = "0x1809B9300", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public COLHIDLGKEK BPLNIKHAODG
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x9B9610", Offset = "0x9B8A10", VA = "0x1809B9610", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public KLIKFJJFGJN FBGNEOOJICB
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA27B70", Offset = "0xA26F70", VA = "0x180A27B70", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x11F2AC0", Offset = "0x11F1EC0", VA = "0x1811F2AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private bool HAKABMECDJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7BFF020", Offset = "0x7BFE420", VA = "0x187BFF020", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private bool OPCKMGOAHHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7BFECC0", Offset = "0x7BFE0C0", VA = "0x187BFECC0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private bool EHIKNBJBNLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x11758A0", Offset = "0x1174CA0", VA = "0x1811758A0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	private CancellationToken LPFEBDELAHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7BFF0E0", Offset = "0x7BFE4E0", VA = "0x187BFF0E0", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private GFKEMDIOCPC OIEBGAFPKIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	private bool CFIMGJLBHFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x11758A0", Offset = "0x1174CA0", VA = "0x1811758A0", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x116DBE0", Offset = "0x116CFE0", VA = "0x18116DBE0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	private event Action IHNOOMPNDMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x7BFF100", Offset = "0x7BFE500", VA = "0x187BFF100", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x7BFE890", Offset = "0x7BFDC90", VA = "0x187BFE890", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	private event BHFIBGOCBGD ABAAPBNKEJF
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7BFF080", Offset = "0x7BFE480", VA = "0x187BFF080", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7BFEFC0", Offset = "0x7BFE3C0", VA = "0x187BFEFC0", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event BHFIBGOCBGD CFMAOOPDEAC
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7BFEC60", Offset = "0x7BFE060", VA = "0x187BFEC60", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x7BFF160", Offset = "0x7BFE560", VA = "0x187BFF160", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event BHFIBGOCBGD BMEJBIOOKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7BFE8F0", Offset = "0x7BFDCF0", VA = "0x187BFE8F0", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7BFEC00", Offset = "0x7BFE000", VA = "0x187BFEC00", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x11F2AC0", Offset = "0x11F1EC0", VA = "0x1811F2AC0", Slot = "39")]
	public void FNIHNPMDEGC(KLIKFJJFGJN BDEANLGMCMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF330", Offset = "0x7BFE730", VA = "0x187BFF330")]
	[UnityEngine.Scripting.Preserve]
	internal KFMILBOLIBF([IBJCGEMJMJL(null)] GFKEMDIOCPC MGOKPJKELJG, [IBJCGEMJMJL(null)] JFIOHCKEEIP MGMCFGLJIGI, [IBJCGEMJMJL(null)] PABAJGGCEIB GKMJGJIIHAD, [IBJCGEMJMJL(null)] JJKJBCNAAJM MOKEOOADLAP, [IBJCGEMJMJL(null)] JBCPMCBEPKG PLMBJFDOPBK, [IBJCGEMJMJL(null)] FFGHMBJEEPI DPJMJJNONDI, [IBJCGEMJMJL(null)] ENHCOOGKGFN ADFGFLNPGOG, [IBJCGEMJMJL(null)] MBLNBFNLDAN CHKICNMGPAD, [IBJCGEMJMJL(null)] DPIIEOFIMOM CACFAEOIFNH, [IBJCGEMJMJL(null)] KPLLGNPEHIH PILDNBCJPBD, [IBJCGEMJMJL(null)] CIJEFFLHNAA HHONMODOICF, [IBJCGEMJMJL(null)] FCMBODEBKNC FOIFJMFNKIJ, [IBJCGEMJMJL(null)] FCMMGHLPILA HIENPDPIDMP, [IBJCGEMJMJL(null)] LCEMKOAHHCJ DNLMCJOKGEI, [IBJCGEMJMJL(null)] IFLFCLCHFEP GGFIOOHINMN, [IBJCGEMJMJL(null)] MGDLBKFILKB LNAHAONDIEH, [IBJCGEMJMJL(null)] PMEHDCBJAMG EKLKOFOKCAJ, [IBJCGEMJMJL(null)] GKBANNDJOKF EMDFGFNLMAL, [IBJCGEMJMJL(null)] AGKANHNJNLI DDMNIJNLCKC, [IBJCGEMJMJL(null)] PGODPOGHOLM LKBMJDKBGGL, [IBJCGEMJMJL(null)] DCMMBBANFEL GBHJIOELJIE, [IBJCGEMJMJL(null)] NKMJHFBEIDI FNFKCGGCBKG, [IBJCGEMJMJL(null)] FIJOEDODGBA EGBCPDEJJEK, [IBJCGEMJMJL(null)] KAONJJMLICJ EPLCNPPDIGO, [IBJCGEMJMJL(null)] OICHENLNLMC KGCLBBHLNLJ, [IBJCGEMJMJL(null)] OBPMHPKAJAE HIGIOODIHPF, [IBJCGEMJMJL(null)] MLDPBHLIHNF OOAHFJPLOHB, [IBJCGEMJMJL(null)] GBKJFIMCMFN MEDKFMLAJLB, [IBJCGEMJMJL(null)] IGEMEIBHHGN ALALDEOKAPP, [IBJCGEMJMJL(null)] EGCFGIOCDGL OAHKGNHNFGN, [IBJCGEMJMJL(null)] KOGJGNIFGMB PBOOMDNBGPL, [IBJCGEMJMJL(null)] COLHIDLGKEK OCMFPKGPGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7BFEF10", Offset = "0x7BFE310", VA = "0x187BFEF10")]
	private void HPHCPPKCEKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7BFEA60", Offset = "0x7BFDE60", VA = "0x187BFEA60", Slot = "57")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7BFED40", Offset = "0x7BFE140", VA = "0x187BFED40", Slot = "51")]
	private void GAHHLFNOMHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF1C0", Offset = "0x7BFE5C0", VA = "0x187BFF1C0", Slot = "52")]
	private PDOFNJJFGGG NHBMADDCCMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x7BFED90", Offset = "0x7BFE190", VA = "0x187BFED90", Slot = "53")]
	private NNPFBKHPJCA GNMKBFFAMOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7BFE950", Offset = "0x7BFDD50", VA = "0x187BFE950", Slot = "54")]
	[AsyncStateMachine(typeof(ODMPPCMIPCF))]
	private Task<GGLMIDJEDGD> BMMDKHADEMH(JICNBBCNCAC CIIBJONMFCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x7BFEE20", Offset = "0x7BFE220", VA = "0x187BFEE20", Slot = "55")]
	[AsyncStateMachine(typeof(HPNDGOEOFMG))]
	private Task HEJENGLKLGG(CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF250", Offset = "0x7BFE650", VA = "0x187BFF250")]
	[IteratorStateMachine(typeof(BCKGCFPIBIL))]
	private IEnumerable<HJPHNPODALD> NNBNOMOKLMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF2D0", Offset = "0x7BFE6D0", VA = "0x187BFF2D0")]
	[CompilerGenerated]
	private void OHLIENFNKEE(HJPHNPODALD MEFMJJOMDFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class AONEKBFECLA : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x157D3D0", Offset = "0x157C7D0", VA = "0x18157D3D0")]
	public AONEKBFECLA(string MIALAMIFNLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal class BIEKFCJMBNE : GIOJEJCDGJA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct NDFEICAGDOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public AsyncTaskMethodBuilder<GIOJEJCDGJA.KFHIANBIKAB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public HashSet<FCMBODEBKNC.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public BIEKFCJMBNE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7C0BE80", Offset = "0x7C0B280", VA = "0x187C0BE80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7C0C190", Offset = "0x7C0B590", VA = "0x187C0C190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly CFEMEJBKCKD GHFCFJHMPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly JJKJBCNAAJM MOKEOOADLAP;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private string HCHBDNCPNOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7BF5A40", Offset = "0x7BF4E40", VA = "0x187BF5A40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x957D80", Offset = "0x957180", VA = "0x180957D80")]
	public BIEKFCJMBNE(CFEMEJBKCKD GHFCFJHMPHJ, JJKJBCNAAJM MOKEOOADLAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x7BF5930", Offset = "0x7BF4D30", VA = "0x187BF5930", Slot = "5")]
	[AsyncStateMachine(typeof(NDFEICAGDOB))]
	public Task<GIOJEJCDGJA.KFHIANBIKAB> JLIAJJJFLHP(HashSet<FCMBODEBKNC.Reason> AIFEAOFIFJP, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal class KHEJEMCLCDI : ECDIGCHBPGC, GIOJEJCDGJA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct KMDDLJALCJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public AsyncTaskMethodBuilder<GIOJEJCDGJA.KFHIANBIKAB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public KHEJEMCLCDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public HashSet<FCMBODEBKNC.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private GDBFIEIFOFD <localRoomInstance>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private long <preFallbackInstance>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private bool <currentIsOffline>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TaskAwaiter<GIOJEJCDGJA.KFHIANBIKAB> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7BFF9B0", Offset = "0x7BFEDB0", VA = "0x187BFF9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7C00310", Offset = "0x7BFF710", VA = "0x187C00310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private string HCHBDNCPNOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x7BFF900", Offset = "0x7BFED00", VA = "0x187BFF900", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x957D80", Offset = "0x957180", VA = "0x180957D80")]
	public KHEJEMCLCDI(CFEMEJBKCKD GHFCFJHMPHJ, JJKJBCNAAJM MOKEOOADLAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF7B0", Offset = "0x7BFEBB0", VA = "0x187BFF7B0", Slot = "5")]
	[AsyncStateMachine(typeof(KMDDLJALCJL))]
	public Task<GIOJEJCDGJA.KFHIANBIKAB> JLIAJJJFLHP(HashSet<FCMBODEBKNC.Reason> AIFEAOFIFJP, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal class NKPELOMOEJK : ECDIGCHBPGC, GIOJEJCDGJA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct CALONAPONHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public AsyncTaskMethodBuilder<GIOJEJCDGJA.KFHIANBIKAB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public NKPELOMOEJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public HashSet<FCMBODEBKNC.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private TaskAwaiter<JEDBNHDCOIL> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private TaskAwaiter<GIOJEJCDGJA.KFHIANBIKAB> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7BF6830", Offset = "0x7BF5C30", VA = "0x187BF6830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7BF7220", Offset = "0x7BF6620", VA = "0x187BF7220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private string HCHBDNCPNOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x7C0C8F0", Offset = "0x7C0BCF0", VA = "0x187C0C8F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x957D80", Offset = "0x957180", VA = "0x180957D80")]
	public NKPELOMOEJK(CFEMEJBKCKD GHFCFJHMPHJ, JJKJBCNAAJM MOKEOOADLAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7C0C7A0", Offset = "0x7C0BBA0", VA = "0x187C0C7A0", Slot = "5")]
	[AsyncStateMachine(typeof(CALONAPONHH))]
	public Task<GIOJEJCDGJA.KFHIANBIKAB> JLIAJJJFLHP(HashSet<FCMBODEBKNC.Reason> AIFEAOFIFJP, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal class GENDMNDFJJB : ECDIGCHBPGC, GIOJEJCDGJA
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class BFCNMBAMPBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public JEDBNHDCOIL matchmakingErrorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public GDBFIEIFOFD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public long preFallbackInstance;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public BFCNMBAMPBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7BF4A00", Offset = "0x7BF3E00", VA = "0x187BF4A00")]
		internal object HEEEMJFKFIE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7BF4940", Offset = "0x7BF3D40", VA = "0x187BF4940")]
		internal object BHKJDKCJPDO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct FJAGOLCNMAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public AsyncTaskMethodBuilder<GIOJEJCDGJA.KFHIANBIKAB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public GENDMNDFJJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public HashSet<FCMBODEBKNC.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private BFCNMBAMPBE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private TaskAwaiter<JEDBNHDCOIL> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private TaskAwaiter<GIOJEJCDGJA.KFHIANBIKAB> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7BF9410", Offset = "0x7BF8810", VA = "0x187BF9410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7BFA050", Offset = "0x7BF9450", VA = "0x187BFA050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private string HCHBDNCPNOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7BFACE0", Offset = "0x7BFA0E0", VA = "0x187BFACE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x957D80", Offset = "0x957180", VA = "0x180957D80")]
	public GENDMNDFJJB(CFEMEJBKCKD GHFCFJHMPHJ, JJKJBCNAAJM MOKEOOADLAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7BFAB90", Offset = "0x7BF9F90", VA = "0x187BFAB90", Slot = "5")]
	[AsyncStateMachine(typeof(FJAGOLCNMAN))]
	public Task<GIOJEJCDGJA.KFHIANBIKAB> JLIAJJJFLHP(HashSet<FCMBODEBKNC.Reason> AIFEAOFIFJP, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal abstract class ECDIGCHBPGC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct FIPANILGLFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public IBCMILIKEJG log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public HashSet<FCMBODEBKNC.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public ECDIGCHBPGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private DJPNNBMEIAG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private List<FCMBODEBKNC.Reason> <newDisconnectTriggers>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8B40", Offset = "0x7BF7F40", VA = "0x187BF8B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7BF9060", Offset = "0x7BF8460", VA = "0x187BF9060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	protected readonly CFEMEJBKCKD GHFCFJHMPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	protected readonly JJKJBCNAAJM MOKEOOADLAP;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	protected FBKMDCBFBII IELHGPMHDJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7BF89C0", Offset = "0x7BF7DC0", VA = "0x187BF89C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x957D80", Offset = "0x957180", VA = "0x180957D80")]
	public ECDIGCHBPGC(CFEMEJBKCKD GHFCFJHMPHJ, JJKJBCNAAJM MOKEOOADLAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7BF8A10", Offset = "0x7BF7E10", VA = "0x187BF8A10")]
	[AsyncStateMachine(typeof(FIPANILGLFH))]
	protected Task PPLEDIAHBBB(IBCMILIKEJG DDKJAEALMGF, HashSet<FCMBODEBKNC.Reason> AIFEAOFIFJP, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class HDDOPJHJCKB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct GBOGMBPJDFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public AsyncTaskMethodBuilder<GIOJEJCDGJA.KFHIANBIKAB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public JJKJBCNAAJM callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7BFA1A0", Offset = "0x7BF95A0", VA = "0x187BFA1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7BFA520", Offset = "0x7BF9920", VA = "0x187BFA520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class NHOHHGJLPDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public string fallbackName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public CFEMEJBKCKD roomManager;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public NHOHHGJLPDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x7C0C200", Offset = "0x7C0B600", VA = "0x187C0C200")]
		internal object IJEGNCEFJIB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public static readonly float HOJOLOOOPIE;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	internal static readonly HashSet<FCMBODEBKNC.Reason> HBHHBCIMBMJ;

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7BFC900", Offset = "0x7BFBD00", VA = "0x187BFC900")]
	[AsyncStateMachine(typeof(GBOGMBPJDFO))]
	internal static Task<GIOJEJCDGJA.KFHIANBIKAB> DGNHDDJNOJL(JJKJBCNAAJM MOKEOOADLAP, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7BFC780", Offset = "0x7BFBB80", VA = "0x187BFC780")]
	internal static void CFGJLINFKFN(CFEMEJBKCKD GHFCFJHMPHJ, IBCMILIKEJG DDKJAEALMGF, string HONMDOFCACM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal interface GIOJEJCDGJA
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct KFHIANBIKAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public bool JHGFMOPHGIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public FCMBODEBKNC.Reason CEGFAIJENKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Enum? ABJDEJGJGFC;

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x7BFE850", Offset = "0x7BFDC50", VA = "0x187BFE850")]
		public static KFHIANBIKAB FLHKLEFIOME()
		{
			return default(KFHIANBIKAB);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x7BFE860", Offset = "0x7BFDC60", VA = "0x187BFE860")]
		public static KFHIANBIKAB PHLKPIKLKII(FCMBODEBKNC.Reason CEGFAIJENKH, [Optional] Enum? ABJDEJGJGFC)
		{
			return default(KFHIANBIKAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	string AGBBKPGPLDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<KFHIANBIKAB> JLIAJJJFLHP(HashSet<FCMBODEBKNC.Reason> AIFEAOFIFJP, CancellationToken LAEIHJHNGEK);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal struct BILNEPDMCCP
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class GFGJDPDBLBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public CFEMEJBKCKD manager;

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public GFGJDPDBLBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x7BFAD90", Offset = "0x7BFA190", VA = "0x187BFAD90")]
		internal Task AGFBPAFEBFM(CancellationToken cancellationToken, int roomTotalVersion, KNBIGIEKHKK localPlayerAccountRoleType)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private struct GCCDKKOCDIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public BILNEPDMCCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private JICNBBCNCAC <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private TaskAwaiter<DAINPBEHNNK> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private TaskAwaiter<GGLMIDJEDGD> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x7BFA590", Offset = "0x7BF9990", VA = "0x187BFA590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x7BFAB20", Offset = "0x7BF9F20", VA = "0x187BFAB20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private struct JEBMDMDCDJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public BILNEPDMCCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x7BFDC90", Offset = "0x7BFD090", VA = "0x187BFDC90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x7BFDFB0", Offset = "0x7BFD3B0", VA = "0x187BFDFB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly CancellationToken LAEIHJHNGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly CFEMEJBKCKD JEIEGFHFIPA;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private JFIOHCKEEIP MEDPGHPDIBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7BF6000", Offset = "0x7BF5400", VA = "0x187BF6000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private JJKJBCNAAJM MNHGCFJHHHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7BF5DD0", Offset = "0x7BF51D0", VA = "0x187BF5DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private FBKMDCBFBII IELHGPMHDJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7BF5E20", Offset = "0x7BF5220", VA = "0x187BF5E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private KPLLGNPEHIH BLOAHGPPOGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7BF5EA0", Offset = "0x7BF52A0", VA = "0x187BF5EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x2558C40", Offset = "0x2558040", VA = "0x182558C40")]
	public BILNEPDMCCP(CancellationToken LAEIHJHNGEK, CFEMEJBKCKD JEIEGFHFIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7BF6180", Offset = "0x7BF5580", VA = "0x187BF6180")]
	public static CNLHFGLFLAC NODOHPOJJPB(CFEMEJBKCKD JEIEGFHFIPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7BF5EF0", Offset = "0x7BF52F0", VA = "0x187BF5EF0")]
	[AsyncStateMachine(typeof(GCCDKKOCDIM))]
	public Task<bool> IKIFLPOJPIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7BF5BC0", Offset = "0x7BF4FC0", VA = "0x187BF5BC0")]
	private bool GPANONNKHLO([Out] JICNBBCNCAC CIIBJONMFCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7BF5AF0", Offset = "0x7BF4EF0", VA = "0x187BF5AF0")]
	[AsyncStateMachine(typeof(JEBMDMDCDJL))]
	private Task FOEGNAFBGHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7BF6050", Offset = "0x7BF5450", VA = "0x187BF6050")]
	private Task<DAINPBEHNNK> NNGHGBMKOMN(JICNBBCNCAC LNGOHJPIHDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal struct AHECFMBNCBG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly IFLFCLCHFEP GGFIOOHINMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly Guid EHMIFANHMPO;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private Task<(GGLMIDJEDGD, Task)> EHPFBIIGNKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x7BF29E0", Offset = "0x7BF1DE0", VA = "0x187BF29E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x4B420F0", Offset = "0x4B414F0", VA = "0x184B420F0")]
	public AHECFMBNCBG(IFLFCLCHFEP GGFIOOHINMN, Guid EHMIFANHMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7BF28C0", Offset = "0x7BF1CC0", VA = "0x187BF28C0")]
	public TaskAwaiter<(GGLMIDJEDGD, Task)> CHPBIIJHJCK()
	{
		return default(TaskAwaiter<(GGLMIDJEDGD, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7BF2910", Offset = "0x7BF1D10", VA = "0x187BF2910", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal struct OJJNGLKMFBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly TaskCompletionSource<(GGLMIDJEDGD, Task)> NLKMNIKGLDN;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Task<(GGLMIDJEDGD, Task)> EHPFBIIGNKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x7C0D850", Offset = "0x7C0CC50", VA = "0x187C0D850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7C0D9C0", Offset = "0x7C0CDC0", VA = "0x187C0D9C0")]
	public OJJNGLKMFBG(TimeSpan GAOGFDNIHEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7C0D890", Offset = "0x7C0CC90", VA = "0x187C0D890")]
	public void IGIAKLIKOCA(Task HALLDLPJOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7C0D7C0", Offset = "0x7C0CBC0", VA = "0x187C0D7C0")]
	public void DOCBADCHDJP(GGLMIDJEDGD DNHNCONLMMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7C0D770", Offset = "0x7C0CB70", VA = "0x187C0D770")]
	public void DNEAFHEGGPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7C0D930", Offset = "0x7C0CD30", VA = "0x187C0D930")]
	internal void LOPCJDNFILH(string MIALAMIFNLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public static class PHBNLIPEEOI
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class JKKPKJHADIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public CCDAHBCPCKI subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public JKKPKJHADIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x7BFE820", Offset = "0x7BFDC20", VA = "0x187BFE820")]
		internal bool CMDCBOOOPKM(KOLBKODMCOP s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E6E0", Offset = "0x7C0DAE0", VA = "0x187C0E6E0")]
	public static HLOJEJEEEIJ OILMBKHFGKP(long HHDCJNGKHGF, long GHFFAIKCNFL, string BPPPCIKOLON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E260", Offset = "0x7C0D660", VA = "0x187C0E260")]
	public static HLOJEJEEEIJ OILMBKHFGKP(long HHDCJNGKHGF, long GHFFAIKCNFL, DDDGOPGHMJC LBDLMMONJCN, long AFCAJMDPILG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E550", Offset = "0x7C0D950", VA = "0x187C0E550")]
	public static HLOJEJEEEIJ OILMBKHFGKP(AKEHIKAMMJM IJGHHIICOJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E320", Offset = "0x7C0D720", VA = "0x187C0E320")]
	public static HLOJEJEEEIJ OILMBKHFGKP(EPDFKONBMMJ PDFINDDHOBK, CCDAHBCPCKI OAKKOJCACFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E170", Offset = "0x7C0D570", VA = "0x187C0E170")]
	public static HLOJEJEEEIJ GELOBFDJBHG(this HLOJEJEEEIJ GOAPBALNOKD, EPDFKONBMMJ KCMEEOGPOBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x7C0DFE0", Offset = "0x7C0D3E0", VA = "0x187C0DFE0")]
	public static HLOJEJEEEIJ ELJMMIIIJMC(this HLOJEJEEEIJ GOAPBALNOKD, CCDAHBCPCKI NPGHBPFBGMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[RecRoom.NoEngine.Common.Preserve]
internal class PFPJDGHIDNM : DPIIEOFIMOM, HJPHNPODALD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct GOJGDKFDKPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public PFPJDGHIDNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private DJPNNBMEIAG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7BFBBA0", Offset = "0x7BFAFA0", VA = "0x187BFBBA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7BFC240", Offset = "0x7BFB640", VA = "0x187BFC240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly FDINGGDGHDL CLPANFADCPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private string MAKDOJCAJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private Task AMIPNLACKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private CFEMEJBKCKD GHFCFJHMPHJ;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool MACAIMLIHLM
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7C0DD70", Offset = "0x7C0D170", VA = "0x187C0DD70", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Task PKHMDMABMJB
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7C0DEC0", Offset = "0x7C0D2C0", VA = "0x187C0DEC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x94B7E0", Offset = "0x94ABE0", VA = "0x18094B7E0", Slot = "7")]
	public void HPHCPPKCEKM(CFEMEJBKCKD GHFCFJHMPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x7C0DC10", Offset = "0x7C0D010", VA = "0x187C0DC10", Slot = "6")]
	public void BDMONGODBMC(Task CBPINBDBDCO, string MHKIBDNHKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x7C0DDA0", Offset = "0x7C0D1A0", VA = "0x187C0DDA0")]
	[AsyncStateMachine(typeof(GOJGDKFDKPD))]
	private Task LNGIFBKFKDA(Task JNEEHFAADNH, string MHKIBDNHKBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x7C0DF50", Offset = "0x7C0D350", VA = "0x187C0DF50")]
	public PFPJDGHIDNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal class NJDOOCNDBBJ : DFPFMGJEMIJ, HJPHNPODALD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private bool BJIDJCMHIND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private FJGBFJOGCIJ PCEOIBMBDMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private JFIOHCKEEIP MGMCFGLJIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private OBPMHPKAJAE HIGIOODIHPF;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public FJGBFJOGCIJ ODEPJIBCIOA
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7C0C670", Offset = "0x7C0BA70", VA = "0x187C0C670", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x7C0C4F0", Offset = "0x7C0B8F0", VA = "0x187C0C4F0", Slot = "7")]
	public void HPHCPPKCEKM(CFEMEJBKCKD GHFCFJHMPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x7C0C300", Offset = "0x7C0B700", VA = "0x187C0C300", Slot = "5")]
	public void BFIDLKAKGHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x7C0C4B0", Offset = "0x7C0B8B0", VA = "0x187C0C4B0", Slot = "6")]
	public void NOJCJJMPODG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7C0C6E0", Offset = "0x7C0BAE0", VA = "0x187C0C6E0")]
	private Task LBPKNFIDCDN(BBNKNABMABP MEBAFDHEDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7C0C4B0", Offset = "0x7C0B8B0", VA = "0x187C0C4B0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public NJDOOCNDBBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
internal class AAHFAICHBKI : OBPMHPKAJAE
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private class IPKADIADMFP<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly FIIDOADKEDD MGBNFJALEFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private readonly string LKMGECEEGEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private readonly T IDJBNLNBJCD;

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public T DEDOPNLMLPL
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0xB39EB0", Offset = "0xB392B0", VA = "0x180B39EB0")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0xB396D0", Offset = "0xB38AD0", VA = "0x180B396D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x4741F30", Offset = "0x4741330", VA = "0x184741F30")]
		public IPKADIADMFP(FIIDOADKEDD MGBNFJALEFB, string LKMGECEEGEE, T IDJBNLNBJCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x4741890", Offset = "0x4740C90", VA = "0x184741890")]
		private void OPKDJNGJCGC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly FIIDOADKEDD MGBNFJALEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly IPKADIADMFP<TimeSpan> CNJLMPHFIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly IPKADIADMFP<TimeSpan> FHMEGOIBELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly IPKADIADMFP<TimeSpan> HEEKHMJOBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly IPKADIADMFP<TimeSpan> BELPBBDNNNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly IPKADIADMFP<bool> OBJCPOCHCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly IPKADIADMFP<bool> EECLFJGEPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly IPKADIADMFP<bool> EJLCGGMEGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly IPKADIADMFP<int> NBJIMJAGFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly IPKADIADMFP<bool> BJMECMHJLEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly IPKADIADMFP<bool> LHFBFNDPKBC;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public TimeSpan AMBNFMBHAKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x7BF0210", Offset = "0x7BEF610", VA = "0x187BF0210", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public TimeSpan OFPFCEAELIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x7BF0450", Offset = "0x7BEF850", VA = "0x187BF0450", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public TimeSpan LPIDEMCAIHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x7BF03D0", Offset = "0x7BEF7D0", VA = "0x187BF03D0", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public TimeSpan OCMKBAODPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x7BF0250", Offset = "0x7BEF650", VA = "0x187BF0250", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool ONNBHNKGGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x7BF02D0", Offset = "0x7BEF6D0", VA = "0x187BF02D0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool BJJBIDFBEFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x7BF0350", Offset = "0x7BEF750", VA = "0x187BF0350", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool LGMMLPDBBMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x7BF0390", Offset = "0x7BEF790", VA = "0x187BF0390", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public int LPGOOAMPLCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x7BF0410", Offset = "0x7BEF810", VA = "0x187BF0410", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool NKHLDFHBKPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x7BF0290", Offset = "0x7BEF690", VA = "0x187BF0290", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public bool POLLNJJDHMC
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7BF0310", Offset = "0x7BEF710", VA = "0x187BF0310", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x7BF0490", Offset = "0x7BEF890", VA = "0x187BF0490")]
	[UnityEngine.Scripting.Preserve]
	public AAHFAICHBKI([IBJCGEMJMJL(null)] FIIDOADKEDD MGBNFJALEFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[UnityEngine.Scripting.Preserve]
internal class DADHGGNDMGM : CIJEFFLHNAA, HJPHNPODALD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class FNGJPPIGDHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public ONLCNDEELLL roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public FNGJPPIGDHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x7BFA0C0", Offset = "0x7BF94C0", VA = "0x187BFA0C0")]
		internal object JHAOOHLOIIL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	[CompilerGenerated]
	private Action<FDFGBGCLFKC, bool> ENAGPLCPBFH;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action KOLOFNNGBAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x7BF81C0", Offset = "0x7BF75C0", VA = "0x187BF81C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8660", Offset = "0x7BF7A60", VA = "0x187BF8660", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event BHFIBGOCBGD BGEHMJMFPEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7BF85C0", Offset = "0x7BF79C0", VA = "0x187BF85C0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8450", Offset = "0x7BF7850", VA = "0x187BF8450", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event BHFIBGOCBGD FBFLJJCBJCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x7BF7F20", Offset = "0x7BF7320", VA = "0x187BF7F20", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x7BF83B0", Offset = "0x7BF77B0", VA = "0x187BF83B0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event BHFIBGOCBGD MIMOGFPFFMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8290", Offset = "0x7BF7690", VA = "0x187BF8290", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x7BF84F0", Offset = "0x7BF78F0", VA = "0x187BF84F0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "17")]
	public void HPHCPPKCEKM(CFEMEJBKCKD GHFCFJHMPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x7BF7FC0", Offset = "0x7BF73C0", VA = "0x187BF7FC0", Slot = "12")]
	public void FNGFDLAHFPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x7BF8590", Offset = "0x7BF7990", VA = "0x187BF8590", Slot = "13")]
	public void PDEEODDPKFD(ONLCNDEELLL EDKKLGLMFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x7BF8380", Offset = "0x7BF7780", VA = "0x187BF8380", Slot = "14")]
	public void NDOILGLNJLL(ONLCNDEELLL EDKKLGLMFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x7BF8260", Offset = "0x7BF7660", VA = "0x187BF8260", Slot = "15")]
	public void HDJGIOOMCDN(ONLCNDEELLL EDKKLGLMFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x7BF8330", Offset = "0x7BF7730", VA = "0x187BF8330", Slot = "16")]
	public void MCHPNIELGPN(FDFGBGCLFKC MNGFNEKIDGN, bool JHGFMOPHGIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x7BF7D50", Offset = "0x7BF7150", VA = "0x187BF7D50")]
	private void CNDNDIPPKBE(BHFIBGOCBGD AOGBMEDINNC, ONLCNDEELLL EDKKLGLMFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public DADHGGNDMGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[UnityEngine.Scripting.Preserve]
internal class HOBHGDFPGDM : FCMBODEBKNC, HJPHNPODALD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private class AALANMPLJKI : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct JGKAHMJGCII : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public AALANMPLJKI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public FCMBODEBKNC.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			private DJPNNBMEIAG <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			private GIOJEJCDGJA[] <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			private int <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			private TaskAwaiter<GIOJEJCDGJA.KFHIANBIKAB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x7BFE080", Offset = "0x7BFD480", VA = "0x187BFE080", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x7BFE7C0", Offset = "0x7BFDBC0", VA = "0x187BFE7C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct LHJFHIEHOMD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public AsyncTaskMethodBuilder<GIOJEJCDGJA.KFHIANBIKAB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public GIOJEJCDGJA fallbackProvider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public AALANMPLJKI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public FCMBODEBKNC.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			private DJPNNBMEIAG <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			private PIKOKLKNONL <individualFallbackTaskState>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			private TaskAwaiter<GIOJEJCDGJA.KFHIANBIKAB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x7C00630", Offset = "0x7BFFA30", VA = "0x187C00630", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x7C012E0", Offset = "0x7C006E0", VA = "0x187C012E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private sealed class KPJPBHHHFOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public GIOJEJCDGJA fallbackProvider;

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public KPJPBHHHFOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x7C005B0", Offset = "0x7BFF9B0", VA = "0x187C005B0")]
			internal object LBPNJAHMHDB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public Task CBPINBDBDCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public CancellationTokenSource GCEKMPIANPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public PIKOKLKNONL BCIELHGKJPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public JJKJBCNAAJM MOKEOOADLAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public ALHPBBOBFGN BFAPGALGCNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public GDBFIEIFOFD FJKJDPBPFHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public GIOJEJCDGJA[] CBNJIAEIOOO;

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public bool INNLJOEIPDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x7BF0900", Offset = "0x7BEFD00", VA = "0x187BF0900")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool MDLEBGFBHPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x7BF1AE0", Offset = "0x7BF0EE0", VA = "0x187BF1AE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x7BF24D0", Offset = "0x7BF18D0", VA = "0x187BF24D0")]
		public AALANMPLJKI(JJKJBCNAAJM MOKEOOADLAP, ALHPBBOBFGN BFAPGALGCNE, GDBFIEIFOFD FJKJDPBPFHP, GIOJEJCDGJA[] CBNJIAEIOOO, CancellationToken LAEIHJHNGEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x7BF13C0", Offset = "0x7BF07C0", VA = "0x187BF13C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x7BF17C0", Offset = "0x7BF0BC0", VA = "0x187BF17C0")]
		public void KFCPGKMLPPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x7BF1970", Offset = "0x7BF0D70", VA = "0x187BF1970")]
		public void LDHGAOBLLFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x7BF0920", Offset = "0x7BEFD20", VA = "0x187BF0920")]
		public void BPCGDAMGBAD(FCMBODEBKNC.Reason CHJLEBAOFOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x7BF1C70", Offset = "0x7BF1070", VA = "0x187BF1C70")]
		[AsyncStateMachine(typeof(JGKAHMJGCII))]
		public Task ONHLAHEGJMH(FCMBODEBKNC.Reason CEGFAIJENKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x7BF1830", Offset = "0x7BF0C30", VA = "0x187BF1830")]
		[AsyncStateMachine(typeof(LHJFHIEHOMD))]
		private Task<GIOJEJCDGJA.KFHIANBIKAB> KKEOMFOLBEO(FCMBODEBKNC.Reason CEGFAIJENKH, GIOJEJCDGJA IMJKKDJLCAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x7BF12A0", Offset = "0x7BF06A0", VA = "0x187BF12A0")]
		private void DMIMHMDNCKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x7BF1560", Offset = "0x7BF0960", VA = "0x187BF1560")]
		public bool JPHMDPFHEIJ(FCMBODEBKNC.Reason NPGMHPAKHMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x7BF1E80", Offset = "0x7BF1280", VA = "0x187BF1E80")]
		private void PJOCPNJCCDE(PIKOKLKNONL CEGAGHAOIDD, FCMBODEBKNC.Reason CEGFAIJENKH = FCMBODEBKNC.Reason.Unknown)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x7BF0BF0", Offset = "0x7BEFFF0", VA = "0x187BF0BF0")]
		private void CGPLALPCAAL(PIKOKLKNONL CEGAGHAOIDD, GIOJEJCDGJA.KFHIANBIKAB BIEIOPPGBOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7BF1610", Offset = "0x7BF0A10", VA = "0x187BF1610")]
		private void KDLKIPDKNOE(PIKOKLKNONL CEGAGHAOIDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7BF0ED0", Offset = "0x7BF02D0", VA = "0x187BF0ED0")]
		private void DGKJPGODIOP(PIKOKLKNONL CEGAGHAOIDD, GIOJEJCDGJA.KFHIANBIKAB BIEIOPPGBOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7BF1B00", Offset = "0x7BF0F00", VA = "0x187BF1B00")]
		private void NGINHJJFJEC(PIKOKLKNONL CEGAGHAOIDD, Exception DADIPHEHDBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7BF0DC0", Offset = "0x7BF01C0", VA = "0x187BF0DC0")]
		private void CIBKOONHIFB(GIOJEJCDGJA IMJKKDJLCAE, FCMBODEBKNC.Reason CEGFAIJENKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7BF1D70", Offset = "0x7BF1170", VA = "0x187BF1D70")]
		private void PAMKKBGIOCI(GIOJEJCDGJA IMJKKDJLCAE, FCMBODEBKNC.Reason CEGFAIJENKH, string ABJDEJGJGFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7BF2140", Offset = "0x7BF1540", VA = "0x187BF2140", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class PIKOKLKNONL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public Task<GIOJEJCDGJA.KFHIANBIKAB> CBPINBDBDCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public CancellationTokenSource GCEKMPIANPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public GIOJEJCDGJA IMJKKDJLCAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public FCMBODEBKNC.Reason CHJLEBAOFOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public HashSet<FCMBODEBKNC.Reason> AIFEAOFIFJP;

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public bool INNLJOEIPDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x7BF0900", Offset = "0x7BEFD00", VA = "0x187BF0900")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public bool MDLEBGFBHPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x7BF1AE0", Offset = "0x7BF0EE0", VA = "0x187BF1AE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7C0E770", Offset = "0x7C0DB70", VA = "0x187C0E770")]
		public void APDCJKMBNFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7C0E8E0", Offset = "0x7C0DCE0", VA = "0x187C0E8E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7C0E900", Offset = "0x7C0DD00", VA = "0x187C0E900", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7C0EC70", Offset = "0x7C0E070", VA = "0x187C0EC70")]
		public PIKOKLKNONL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class MGDBEHEKLOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public FCMBODEBKNC.Reason reason;

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public MGDBEHEKLOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7C07130", Offset = "0x7C06530", VA = "0x187C07130")]
		internal object JMPMEGGCDNN(PIKOKLKNONL x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7C070C0", Offset = "0x7C064C0", VA = "0x187C070C0")]
		internal object CIFGODJMLHL(AALANMPLJKI x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7C071A0", Offset = "0x7C065A0", VA = "0x187C071A0")]
		internal object OHBJELMODBG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct NAAMLONCLCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public FCMBODEBKNC.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public HOBHGDFPGDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private MGDBEHEKLOG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private DJPNNBMEIAG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7C0B3A0", Offset = "0x7C0A7A0", VA = "0x187C0B3A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x7C0BE20", Offset = "0x7C0B220", VA = "0x187C0BE20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct AONFFFHAHNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public HOBHGDFPGDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public FCMBODEBKNC.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private AALANMPLJKI <localTaskState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x7BF2D30", Offset = "0x7BF2130", VA = "0x187BF2D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x7BF39C0", Offset = "0x7BF2DC0", VA = "0x187BF39C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct BNLHKDOFKIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public HOBHGDFPGDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x7BF6230", Offset = "0x7BF5630", VA = "0x187BF6230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x7BF67D0", Offset = "0x7BF5BD0", VA = "0x187BF67D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	internal static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	internal static readonly IBCMILIKEJG JCBHFLILNPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private CFEMEJBKCKD GHFCFJHMPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private JJKJBCNAAJM MOKEOOADLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private AALANMPLJKI BMIMFNACHBF;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	private FBKMDCBFBII IELHGPMHDJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7BFCFB0", Offset = "0x7BFC3B0", VA = "0x187BFCFB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool KLILGEALKOB
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x20CBAA0", Offset = "0x20CAEA0", VA = "0x1820CBAA0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private bool OCFGDOIMDKD
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x7BFCF40", Offset = "0x7BFC340", VA = "0x187BFCF40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x7BFCEC0", Offset = "0x7BFC2C0", VA = "0x187BFCEC0", Slot = "7")]
	public void HPHCPPKCEKM(CFEMEJBKCKD GHFCFJHMPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x7BFCDD0", Offset = "0x7BFC1D0", VA = "0x187BFCDD0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x7BFCB30", Offset = "0x7BFBF30", VA = "0x187BFCB30", Slot = "9")]
	public void APDCJKMBNFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x7BFCDE0", Offset = "0x7BFC1E0", VA = "0x187BFCDE0")]
	private bool EHIIBKCEBOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x7BFD0F0", Offset = "0x7BFC4F0", VA = "0x187BFD0F0", Slot = "6")]
	private void KAFCOFFJEEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7BFD000", Offset = "0x7BFC400", VA = "0x187BFD000", Slot = "5")]
	[AsyncStateMachine(typeof(NAAMLONCLCB))]
	private Task JLDMGFBBPIA(FCMBODEBKNC.Reason CEGFAIJENKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x7BFD1C0", Offset = "0x7BFC5C0", VA = "0x187BFD1C0")]
	private bool LEBILHAJPOO(FCMBODEBKNC.Reason CEGFAIJENKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7BFD4A0", Offset = "0x7BFC8A0", VA = "0x187BFD4A0")]
	private GIOJEJCDGJA[] PMKCOFLMEMB(GDBFIEIFOFD HJPNCAOEOMF, ALHPBBOBFGN DBPNLAGHDNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7BFCCC0", Offset = "0x7BFC0C0", VA = "0x187BFCCC0")]
	[AsyncStateMachine(typeof(AONFFFHAHNM))]
	private Task DJKADILNNHB(FCMBODEBKNC.Reason CEGFAIJENKH, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x7BFD870", Offset = "0x7BFCC70", VA = "0x187BFD870")]
	[AsyncStateMachine(typeof(BNLHKDOFKIA))]
	private Task PNNIOHPBCLB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public HOBHGDFPGDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[RecRoom.NoEngine.Common.Preserve]
internal class MGKAAALGFHN : FCMMGHLPILA, HJPHNPODALD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct CLMOONLLFKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public GDBFIEIFOFD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public MGKAAALGFHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public KLIKFJJFGJN customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private DJPNNBMEIAG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x7BF7290", Offset = "0x7BF6690", VA = "0x187BF7290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x7BF7C00", Offset = "0x7BF7000", VA = "0x187BF7C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private struct GLPLMOEPMNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public MGKAAALGFHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public GDBFIEIFOFD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public KLIKFJJFGJN customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private FGFDKLMANEA<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private DJPNNBMEIAG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private OKCNIPGMDHK <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private MOHCECBCNBF <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x7BFADE0", Offset = "0x7BFA1E0", VA = "0x187BFADE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x7BFBA90", Offset = "0x7BFAE90", VA = "0x187BFBA90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class GNICGKPODPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public Matchmaking.MNCMKBGCEKL result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public KKHLHELFLNI errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public GNICGKPODPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x7BFBAF0", Offset = "0x7BFAEF0", VA = "0x187BFBAF0")]
		internal object CDNPOFFKFKB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class PCAHLAGJIPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public Task<HLOJEJEEEIJ> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public PCAHLAGJIPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
		internal Task<HLOJEJEEEIJ> PFEHKMGNBLE(FGFDKLMANEA<string>.ICBJPFEBGDJ _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct LMGDLEMCPEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public MGKAAALGFHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public GDBFIEIFOFD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public KLIKFJJFGJN customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public OKCNIPGMDHK joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private PCAHLAGJIPL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private MNIAMPGIDNC <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private DJPNNBMEIAG <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private DFIENIKFOMH <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private Task<Matchmaking.PDLIEJBBEGE> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private NEPIBFPMBLK <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private int <i>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private TaskAwaiter<Matchmaking.PDLIEJBBEGE> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private TaskAwaiter<HLOJEJEEEIJ> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x7C01350", Offset = "0x7C00750", VA = "0x187C01350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x7C06D30", Offset = "0x7C06130", VA = "0x187C06D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct FGNNBPCKAKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public MGKAAALGFHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private DJPNNBMEIAG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x7C1AFC0", Offset = "0x7C1A3C0", VA = "0x187C1AFC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x7C1BA30", Offset = "0x7C1AE30", VA = "0x187C1BA30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private struct AGJKPABIPKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public MGKAAALGFHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private GFKEMDIOCPC <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x7C12D80", Offset = "0x7C12180", VA = "0x187C12D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7C13200", Offset = "0x7C12600", VA = "0x187C13200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private struct FFMFCIGHGCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public AsyncTaskMethodBuilder<Matchmaking.PDLIEJBBEGE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public GDBFIEIFOFD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public MGKAAALGFHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private TaskAwaiter<Matchmaking.PDLIEJBBEGE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7C1AA80", Offset = "0x7C19E80", VA = "0x187C1AA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x7C1AF50", Offset = "0x7C1A350", VA = "0x187C1AF50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private struct ADDHGKPPLCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public Matchmaking.PDLIEJBBEGE serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public MGKAAALGFHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public OKCNIPGMDHK joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private DJPNNBMEIAG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private TaskAwaiter<BGGHNMEBHJH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7C126D0", Offset = "0x7C11AD0", VA = "0x187C126D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7C12D20", Offset = "0x7C12120", VA = "0x187C12D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class CMHBOPNHDAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public GDBFIEIFOFD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public CMHBOPNHDAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7C141B0", Offset = "0x7C135B0", VA = "0x187C141B0")]
		internal object FKNACOMAGNG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x7C140B0", Offset = "0x7C134B0", VA = "0x187C140B0")]
		internal string BCNAOJDFJCE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct JHAKGKENHII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public GDBFIEIFOFD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public MGKAAALGFHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private CMHBOPNHDAE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private DJPNNBMEIAG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x7C21AC0", Offset = "0x7C20EC0", VA = "0x187C21AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x7C22660", Offset = "0x7C21A60", VA = "0x187C22660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private struct EHCAJMCBLJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public MGKAAALGFHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public OKCNIPGMDHK joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public HLOJEJEEEIJ initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public GDBFIEIFOFD targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public MNIAMPGIDNC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7C17D60", Offset = "0x7C17160", VA = "0x187C17D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x7C18550", Offset = "0x7C17950", VA = "0x187C18550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private struct IAAKHLGFPDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public MGKAAALGFHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private DJPNNBMEIAG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private DJPNNBMEIAG <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private CancellationTokenSource <timeoutTcs>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private CancellationToken <timeoutToken>5__8;

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x7C1DB00", Offset = "0x7C1CF00", VA = "0x187C1DB00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F2F0", Offset = "0x7C1E6F0", VA = "0x187C1F2F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private struct PBNJJOCPOFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public KNBIGIEKHKK localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public MGKAAALGFHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private DJPNNBMEIAG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private TaskAwaiter<GGLMIDJEDGD> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D370", Offset = "0x7C2C770", VA = "0x187C2D370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x7C2DB60", Offset = "0x7C2CF60", VA = "0x187C2DB60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class BLKHIAINGLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public GDBFIEIFOFD targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public BLKHIAINGLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x7C13360", Offset = "0x7C12760", VA = "0x187C13360")]
		internal object DDEODLBLAHN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class EMDCIHADDJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public EMDCIHADDJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7C18620", Offset = "0x7C17A20", VA = "0x187C18620")]
		internal void IBGGOONPNEP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class OFMHBKOCNIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public GDBFIEIFOFD targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public OFMHBKOCNIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x7C2BB80", Offset = "0x7C2AF80", VA = "0x187C2BB80")]
		internal object MAPKJBLNLJB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class BKPPCDGKFCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public GDBFIEIFOFD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public BKPPCDGKFCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7C13260", Offset = "0x7C12660", VA = "0x187C13260")]
		internal string NLNFEHGMJNF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private static readonly IBCMILIKEJG CIFJELMIKFC;

	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private static readonly IBCMILIKEJG GAAHAIOKNHJ;

	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private static readonly IBCMILIKEJG DGCFJINECNH;

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private static readonly string CECBNALJPJE;

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly string FEFPIPLHAOM;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly string BJIIKNGFKPD;

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	public static readonly Guid JJOKINPIEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private MBLNBFNLDAN CHKICNMGPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private PABAJGGCEIB GKMJGJIIHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private JFIOHCKEEIP MGMCFGLJIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private CFEMEJBKCKD GHFCFJHMPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private JJKJBCNAAJM MOKEOOADLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private FCMBODEBKNC FOIFJMFNKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private DPIIEOFIMOM CACFAEOIFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private CIJEFFLHNAA HHONMODOICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private EGCFGIOCDGL OAHKGNHNFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private IGEMEIBHHGN ALALDEOKAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private IDisposable JIDFKEHHBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private COLHIDLGKEK OCMFPKGPGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly FDINGGDGHDL MCPJIMPMFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private NEPIBFPMBLK IIDGGBNJNJB;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public TaskStatus DAHJAKNNHFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x971C10", Offset = "0x971010", VA = "0x180971C10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x1108C40", Offset = "0x1108040", VA = "0x181108C40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private FBKMDCBFBII IELHGPMHDJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x7C09440", Offset = "0x7C08840", VA = "0x187C09440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x7C08FD0", Offset = "0x7C083D0", VA = "0x187C08FD0", Slot = "6")]
	public void HPHCPPKCEKM(CFEMEJBKCKD GHFCFJHMPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x7C081F0", Offset = "0x7C075F0", VA = "0x187C081F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x7C088B0", Offset = "0x7C07CB0", VA = "0x187C088B0", Slot = "5")]
	[AsyncStateMachine(typeof(CLMOONLLFKH))]
	public Task GJMCAALDLPD(GDBFIEIFOFD DHCIGOGFOEM, KLIKFJJFGJN KEFMNOFFBJN, CancellationToken DGLOFFGGICM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x7C07F50", Offset = "0x7C07350", VA = "0x187C07F50")]
	[AsyncStateMachine(typeof(GLPLMOEPMNH))]
	private Task CPCJDAFJBFG(GDBFIEIFOFD DHCIGOGFOEM, KLIKFJJFGJN KEFMNOFFBJN, CancellationToken DGLOFFGGICM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A320", Offset = "0x7C09720", VA = "0x187C0A320")]
	private void PGBIONPEKIC(EGCFGIOCDGL OAHKGNHNFGN, GDBFIEIFOFD DHCIGOGFOEM, Exception DADIPHEHDBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x7C07210", Offset = "0x7C06610", VA = "0x187C07210")]
	private static void BMOMJNLJBDB(MOHCECBCNBF BPPGOKMFDFE, Exception DADIPHEHDBH, [Optional] List<int> OPDPAHDHGHM, int NFAPJLNFMCI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x7C094F0", Offset = "0x7C088F0", VA = "0x187C094F0")]
	[AsyncStateMachine(typeof(LMGDLEMCPEC))]
	private Task IIGEGFEJFLM(FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE, GDBFIEIFOFD DHCIGOGFOEM, KLIKFJJFGJN KEFMNOFFBJN, OKCNIPGMDHK JFOKBCJFBJM, CancellationToken DGLOFFGGICM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x7C07DD0", Offset = "0x7C071D0", VA = "0x187C07DD0")]
	private void COCHAHMACBO([CallerMemberName] string GMBCKGNNDKD = "<unknown>")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x7C096D0", Offset = "0x7C08AD0", VA = "0x187C096D0")]
	[AsyncStateMachine(typeof(FGNNBPCKAKP))]
	private Task IMPPNOFNGCP(FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x7C08580", Offset = "0x7C07980", VA = "0x187C08580")]
	private void GINBJAEBCAI(GDBFIEIFOFD DHCIGOGFOEM, CancellationToken DGLOFFGGICM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x7C09E70", Offset = "0x7C09270", VA = "0x187C09E70")]
	private void NFLMFNMMNFK(GDBFIEIFOFD DHCIGOGFOEM, TaskStatus GLPBMEOEGBJ, string MIALAMIFNLM, OKCNIPGMDHK JFOKBCJFBJM, Exception BNMNAMAKIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x7C09650", Offset = "0x7C08A50", VA = "0x187C09650")]
	private void IJHOPNHFCHF(GDBFIEIFOFD DHCIGOGFOEM, OKCNIPGMDHK JFOKBCJFBJM, OperationCanceledException ENCCBHPHKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x7C09940", Offset = "0x7C08D40", VA = "0x187C09940")]
	private void JHJDCJDAKAG(GDBFIEIFOFD DHCIGOGFOEM, OKCNIPGMDHK JFOKBCJFBJM, Exception DADIPHEHDBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x7C089F0", Offset = "0x7C07DF0", VA = "0x187C089F0")]
	private void HCMNINFCOBH(GDBFIEIFOFD DHCIGOGFOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x7C09E10", Offset = "0x7C09210", VA = "0x187C09E10")]
	private static ONLCNDEELLL LGOOHGMPOFL(GDBFIEIFOFD DHCIGOGFOEM)
	{
		return default(ONLCNDEELLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x7C07BE0", Offset = "0x7C06FE0", VA = "0x187C07BE0")]
	[AsyncStateMachine(typeof(AGJKPABIPKJ))]
	private Task CAAIEFKDLLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A790", Offset = "0x7C09B90", VA = "0x187C0A790")]
	[AsyncStateMachine(typeof(FFMFCIGHGCK))]
	private Task<Matchmaking.PDLIEJBBEGE> PJBIIBNIDDH(GDBFIEIFOFD DHCIGOGFOEM, FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x7C09D00", Offset = "0x7C09100", VA = "0x187C09D00")]
	private static BGGHNMEBHJH KNENFONIEOO(Matchmaking.PDLIEJBBEGE FNMCKCCGIGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x7C09BB0", Offset = "0x7C08FB0", VA = "0x187C09BB0")]
	[AsyncStateMachine(typeof(ADDHGKPPLCK))]
	private Task KMPHLGJFGKC(Matchmaking.PDLIEJBBEGE FNMCKCCGIGM, OKCNIPGMDHK JFOKBCJFBJM, FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE, CancellationToken ENHKOFNDDIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x7C09800", Offset = "0x7C08C00", VA = "0x187C09800")]
	[AsyncStateMachine(typeof(JHAKGKENHII))]
	private Task JGLACHLKHGO(GDBFIEIFOFD DHCIGOGFOEM, CancellationTokenSource BGMKNBDDENN, Task LBMJEAPJKIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x7C07A70", Offset = "0x7C06E70", VA = "0x187C07A70")]
	[AsyncStateMachine(typeof(EHCAJMCBLJC))]
	private Task BOLJCLGJAKB(HLOJEJEEEIJ JIPCODKNIPN, MNIAMPGIDNC FKKJJFDOIBC, GDBFIEIFOFD BHLBEBPCKLE, OKCNIPGMDHK OEPFHMOFFDK, FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE, CancellationToken FOHJLPEAOKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x7C099C0", Offset = "0x7C08DC0", VA = "0x187C099C0")]
	private OKCNIPGMDHK KAPFJOGOIFO(OKCNIPGMDHK OEPFHMOFFDK, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x7C09300", Offset = "0x7C08700", VA = "0x187C09300")]
	[AsyncStateMachine(typeof(IAAKHLGFPDG))]
	private Task IAGFPINPDED(FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A1F0", Offset = "0x7C095F0", VA = "0x187C0A1F0")]
	[AsyncStateMachine(typeof(PBNJJOCPOFN))]
	private Task OFDIHHAOHIJ(CancellationToken LAEIHJHNGEK, int HGKMPCJFPLO, KNBIGIEKHKK KECAFPMAPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x7C08C00", Offset = "0x7C08000", VA = "0x187C08C00")]
	private static void HDACGMPKBDJ(GDBFIEIFOFD DHCIGOGFOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x7C08D80", Offset = "0x7C08180", VA = "0x187C08D80")]
	private void HJGHOBODNFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x7C08340", Offset = "0x7C07740", VA = "0x187C08340")]
	private void EIHAEGJDIIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x7C07D40", Offset = "0x7C07140", VA = "0x187C07D40")]
	private void CCBFOIJCILB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7C07CB0", Offset = "0x7C070B0", VA = "0x187C07CB0")]
	private void CAEACMEOOOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7C080A0", Offset = "0x7C074A0", VA = "0x187C080A0")]
	private static void DCFNEMFMFCA(GDBFIEIFOFD DHCIGOGFOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A0E0", Offset = "0x7C094E0", VA = "0x187C0A0E0")]
	private static CancellationTokenRegistration NODOBLCAGHB(GDBFIEIFOFD DHCIGOGFOEM, CancellationToken ENHKOFNDDIH)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7C08240", Offset = "0x7C07640", VA = "0x187C08240")]
	private static void EFHJNNCGDFM(GDBFIEIFOFD DHCIGOGFOEM, Exception DADIPHEHDBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x7C083D0", Offset = "0x7C077D0", VA = "0x187C083D0")]
	private void FFMIAAFGFOE(GDBFIEIFOFD DHCIGOGFOEM, Task LBMJEAPJKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x7C09490", Offset = "0x7C08890", VA = "0x187C09490")]
	private static void IEGNOINNOMJ(Func<string> OIKCDENKJMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x7C0AB10", Offset = "0x7C09F10", VA = "0x187C0AB10")]
	public MGKAAALGFHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7C08190", Offset = "0x7C07590", VA = "0x187C08190")]
	[CompilerGenerated]
	internal static (int, int?) DJBGONJLOGN(KKHLHELFLNI HKJCJLGBMOM)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[RecRoom.NoEngine.Common.Preserve]
internal class PHHMPDIKMFP : LCEMKOAHHCJ, HJPHNPODALD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private struct KCHLCLEBEJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public PHHMPDIKMFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public KNBIGIEKHKK localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x7C23420", Offset = "0x7C22820", VA = "0x187C23420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x7C23900", Offset = "0x7C22D00", VA = "0x187C23900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class ACIDGJCDLPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public PHHMPDIKMFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public KNBIGIEKHKK localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public ACIDGJCDLPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x7C12690", Offset = "0x7C11A90", VA = "0x187C12690")]
		internal List<Task> LCGOPENALCG(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct CJINNPMDFBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public CNLHFGLFLAC taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public KNBIGIEKHKK localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private DJPNNBMEIAG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x7C13CB0", Offset = "0x7C130B0", VA = "0x187C13CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x7C14050", Offset = "0x7C13450", VA = "0x187C14050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private struct GNFLKDPAHAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public PHHMPDIKMFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x7C1C1C0", Offset = "0x7C1B5C0", VA = "0x187C1C1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x7C1C4A0", Offset = "0x7C1B8A0", VA = "0x187C1C4A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private readonly HashSet<CNLHFGLFLAC> JEFFFBNIFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private PABAJGGCEIB GKMJGJIIHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private CFEMEJBKCKD GHFCFJHMPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private JKEGNLFNIEK PPDDAIIONNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private MHOKGHJKDDN NLJKAOLFEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private IDisposable JIDFKEHHBLJ;

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x7C2E640", Offset = "0x7C2DA40", VA = "0x187C2E640", Slot = "5")]
	public void HPHCPPKCEKM(CFEMEJBKCKD GHFCFJHMPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x7C2E460", Offset = "0x7C2D860", VA = "0x187C2E460", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x7C2E5E0", Offset = "0x7C2D9E0", VA = "0x187C2E5E0", Slot = "4")]
	public bool HAHOBNDICJG(CNLHFGLFLAC KCNPFBCDHKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x7C2EAE0", Offset = "0x7C2DEE0", VA = "0x187C2EAE0")]
	private void PGJGGBOBNAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x7C2E0F0", Offset = "0x7C2D4F0", VA = "0x187C2E0F0")]
	private void AKPLLBFDIKN(BPPINHJEEIJ MIMFFPFKBEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x7C2E9F0", Offset = "0x7C2DDF0", VA = "0x187C2E9F0")]
	[AsyncStateMachine(typeof(KCHLCLEBEJB))]
	private Task OANPGPFPHEB(int HGKMPCJFPLO, KNBIGIEKHKK KECAFPMAPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x7C2E920", Offset = "0x7C2DD20", VA = "0x187C2E920")]
	private Func<CancellationToken, List<Task>> IJDMMDJFHAP(int HGKMPCJFPLO, KNBIGIEKHKK KECAFPMAPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x7C2DC20", Offset = "0x7C2D020", VA = "0x187C2DC20")]
	private List<Task> AECFODHCLJI(int HGKMPCJFPLO, KNBIGIEKHKK KECAFPMAPCB, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x7C2E4C0", Offset = "0x7C2D8C0", VA = "0x187C2E4C0")]
	[AsyncStateMachine(typeof(CJINNPMDFBH))]
	private Task FMAKMFABLFG(CNLHFGLFLAC KBKNECNKOFI, CancellationToken LAAJFAFNFCN, int HGKMPCJFPLO, KNBIGIEKHKK KECAFPMAPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x7C2E390", Offset = "0x7C2D790", VA = "0x187C2E390")]
	[AsyncStateMachine(typeof(GNFLKDPAHAJ))]
	private Task BFBAKLPHOMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x7C2E310", Offset = "0x7C2D710", VA = "0x187C2E310")]
	private void APDCJKMBNFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x7C2EBB0", Offset = "0x7C2DFB0", VA = "0x187C2EBB0")]
	public PHHMPDIKMFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[UnityEngine.Scripting.Preserve]
internal sealed class KLJABJJDPKC : IFLFCLCHFEP, HJPHNPODALD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class LIKAAOCEMIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public LIKAAOCEMIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x7C27BC0", Offset = "0x7C26FC0", VA = "0x187C27BC0")]
		internal object FLOKHJPAGGA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class IDCMNJJMJBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public IDCMNJJMJBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F350", Offset = "0x7C1E750", VA = "0x187C1F350")]
		internal object GAKANDAJCAB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class ICOALDPLDIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public ICOALDPLDIF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class PCIKAOHIMMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public PCIKAOHIMMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x7C2DBC0", Offset = "0x7C2CFC0", VA = "0x187C2DBC0")]
		internal object CMBBAOIJJLP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class DIFMBJNJHPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public DIFMBJNJHPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x7C16370", Offset = "0x7C15770", VA = "0x187C16370")]
		internal object BPEIHKCAHLJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private readonly Dictionary<Guid, OJJNGLKMFBG> GGFIOOHINMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private readonly TimeSpan LIJJGCDKGDJ;

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "9")]
	public void HPHCPPKCEKM(CFEMEJBKCKD GHFCFJHMPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x7C24160", Offset = "0x7C23560", VA = "0x187C24160", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x7C244A0", Offset = "0x7C238A0", VA = "0x187C244A0", Slot = "4")]
	public AHECFMBNCBG HBHDBABAKDP(Guid EHMIFANHMPO)
	{
		return default(AHECFMBNCBG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x7C24B40", Offset = "0x7C23F40", VA = "0x187C24B40", Slot = "5")]
	public bool OCDDHDAHAOD(Guid EHMIFANHMPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x7C24170", Offset = "0x7C23570", VA = "0x187C24170", Slot = "6")]
	public bool GAKIHJOFNMP(Guid EHMIFANHMPO, Task HALLDLPJOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x7C24730", Offset = "0x7C23B30", VA = "0x187C24730", Slot = "7")]
	public bool LLEBADGMFLH(Guid EHMIFANHMPO, GGLMIDJEDGD DNHNCONLMMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x7C246C0", Offset = "0x7C23AC0", VA = "0x187C246C0", Slot = "8")]
	public Task<(GGLMIDJEDGD, Task)> IKNBHLBIMGO(Guid EHMIFANHMPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x7C24910", Offset = "0x7C23D10", VA = "0x187C24910")]
	private void MDLAMJHHIPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x7C24D50", Offset = "0x7C24150", VA = "0x187C24D50")]
	public KLJABJJDPKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[RecRoom.NoEngine.Common.Preserve]
internal class DANFOGPPFBP : MGDLBKFILKB, HJPHNPODALD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private class IKNANHBFMCE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private readonly GDBFIEIFOFD PNLPGKBGHHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private readonly CancellationTokenSource PMAMMIAHALH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public readonly CancellationToken FGEHPLBEBHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private bool ACLKLOBPBLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		private bool LIABCKHNDHI;

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F6B0", Offset = "0x7C1EAB0", VA = "0x187C1F6B0")]
		public IKNANHBFMCE(GDBFIEIFOFD PNLPGKBGHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F530", Offset = "0x7C1E930", VA = "0x187C1F530")]
		public void APDCJKMBNFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F680", Offset = "0x7C1EA80", VA = "0x187C1F680", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class JBBBMMDCDLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public BBNKNABMABP disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public JBBBMMDCDLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x7C20880", Offset = "0x7C1FC80", VA = "0x187C20880")]
		internal object KKMFBHCFHGN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private struct NFMPKALABLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public BBNKNABMABP disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public DANFOGPPFBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private DJPNNBMEIAG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B0D0", Offset = "0x7C2A4D0", VA = "0x187C2B0D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B520", Offset = "0x7C2A920", VA = "0x187C2B520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class IFPMKGNEELM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public DANFOGPPFBP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public IFPMKGNEELM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F3B0", Offset = "0x7C1E7B0", VA = "0x187C1F3B0")]
		internal object DBFEAAEOMEP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	private sealed class FCLDFNGBJCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public GDBFIEIFOFD newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public IFPMKGNEELM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public FCLDFNGBJCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x7C19DE0", Offset = "0x7C191E0", VA = "0x187C19DE0")]
		internal object DHKGAIMDGJL((GDBFIEIFOFD lastLocalPlayerRoomInstance, GDBFIEIFOFD newRoomInstance, FCMBODEBKNC fallbacks) x)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private struct ONNLONNGAEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public DANFOGPPFBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private DJPNNBMEIAG <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x7C2BC00", Offset = "0x7C2B000", VA = "0x187C2BC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xA48F40", Offset = "0xA48340", VA = "0x180A48F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class JEHDIEELCHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public GDBFIEIFOFD newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public JEHDIEELCHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x7C21A20", Offset = "0x7C20E20", VA = "0x187C21A20")]
		internal object MLDOFCGJCFL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x7C219A0", Offset = "0x7C20DA0", VA = "0x187C219A0")]
		internal void MBFIKAPIOLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x7C21960", Offset = "0x7C20D60", VA = "0x187C21960")]
		internal object JIHBEMKBCHC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x7C21920", Offset = "0x7C20D20", VA = "0x187C21920")]
		internal object GDHLOKLCDNJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private struct LOEPGBBEDEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public GDBFIEIFOFD newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public DANFOGPPFBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public KLIKFJJFGJN customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private JEHDIEELCHE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private DJPNNBMEIAG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private CancellationTokenRegistration <_>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x7C283C0", Offset = "0x7C277C0", VA = "0x187C283C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x7C29390", Offset = "0x7C28790", VA = "0x187C29390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private static readonly JHBJMKBEAME.CLNCGLOFCCF GCJIPGPAIEB;

	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private static readonly LOJJIFNAMJM DMNDIFGLLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private PABAJGGCEIB GKMJGJIIHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private CFEMEJBKCKD GHFCFJHMPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private FCMBODEBKNC FOIFJMFNKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private JJKJBCNAAJM MOKEOOADLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private OBPMHPKAJAE HIGIOODIHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private FCMMGHLPILA HIENPDPIDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private GDBFIEIFOFD ILGEADNPDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private IKNANHBFMCE CGGIAMDFELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private bool DEAMHCFKHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private Task KHMBBKILGBB;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private FBKMDCBFBII IELHGPMHDJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x7C15980", Offset = "0x7C14D80", VA = "0x187C15980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool MMNJAMDMOCP
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xAF41B0", Offset = "0xAF35B0", VA = "0x180AF41B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x7C15C50", Offset = "0x7C15050", VA = "0x187C15C50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x7C156E0", Offset = "0x7C14AE0", VA = "0x187C156E0", Slot = "4")]
	public void HPHCPPKCEKM(CFEMEJBKCKD GHFCFJHMPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x7C15180", Offset = "0x7C14580", VA = "0x187C15180", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x7C15B60", Offset = "0x7C14F60", VA = "0x187C15B60")]
	[AsyncStateMachine(typeof(NFMPKALABLI))]
	private Task LGGAAFPFBOE(BBNKNABMABP JCKONIJGJBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x7C14FF0", Offset = "0x7C143F0", VA = "0x187C14FF0")]
	private void DGGKHFIPOPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x7C159D0", Offset = "0x7C14DD0", VA = "0x187C159D0")]
	private void IALHOMNNMDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x7C15C60", Offset = "0x7C15060", VA = "0x187C15C60")]
	private void OEDBHEAMGBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x7C15660", Offset = "0x7C14A60", VA = "0x187C15660")]
	private bool FOMKPALDCME()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x7C15590", Offset = "0x7C14990", VA = "0x187C15590")]
	[AsyncStateMachine(typeof(ONNLONNGAEM))]
	private void FFNCCKFPALI(int KHELFHBHLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x7C152F0", Offset = "0x7C146F0", VA = "0x187C152F0")]
	private void FAMNGJLHAFJ([Out] IDisposable FCKMOJMEBAI, [Out] IDisposable MHHIMCDNMIE, [Out] IDisposable AOIODHAJDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x7C15DE0", Offset = "0x7C151E0", VA = "0x187C15DE0")]
	private bool OHADLHNMOME(GDBFIEIFOFD PNLPGKBGHHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x7C14E70", Offset = "0x7C14270", VA = "0x187C14E70")]
	private void CDOPDEMLCND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x7C14EC0", Offset = "0x7C142C0", VA = "0x187C14EC0")]
	[AsyncStateMachine(typeof(LOEPGBBEDEE))]
	private Task CPCJDAFJBFG(GDBFIEIFOFD PNLPGKBGHHP, KLIKFJJFGJN KEFMNOFFBJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x7C162A0", Offset = "0x7C156A0", VA = "0x187C162A0")]
	public DANFOGPPFBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[UnityEngine.Scripting.Preserve]
internal sealed class EOBHGCGMEGF : PMEHDCBJAMG, HJPHNPODALD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct FBDKCDFKHGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public AsyncTaskMethodBuilder<IICNNDCPJEP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public EOBHGCGMEGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private TaskAwaiter<IICNNDCPJEP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x7C19AE0", Offset = "0x7C18EE0", VA = "0x187C19AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x7C19D70", Offset = "0x7C19170", VA = "0x187C19D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class LKGDHCPAFDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public KKBOOBAMIML message;

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public LKGDHCPAFDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x7C28360", Offset = "0x7C27760", VA = "0x187C28360")]
		internal object NIGLDMLNAMF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class DNJAICJLCMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public KKBOOBAMIML messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public DNJAICJLCMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x7C16F10", Offset = "0x7C16310", VA = "0x187C16F10")]
		internal object GJNKMPFKJAA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class IGMIDLPJBHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public KKBOOBAMIML request;

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public IGMIDLPJBHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F4D0", Offset = "0x7C1E8D0", VA = "0x187C1F4D0")]
		internal object NKPKJNBICAA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct MAADJOBFMAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public KKBOOBAMIML request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public EOBHGCGMEGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private DJPNNBMEIAG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private TaskAwaiter<GPIPDBGGDOE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x7C298A0", Offset = "0x7C28CA0", VA = "0x187C298A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A170", Offset = "0x7C29570", VA = "0x187C2A170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private sealed class HPNILNBJGFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public KKBOOBAMIML operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public HPNILNBJGFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D5D0", Offset = "0x7C1C9D0", VA = "0x187C1D5D0")]
		internal object OGJHBFJOIFK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct FEPMMGDFBNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public KKBOOBAMIML operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public EOBHGCGMEGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private DJPNNBMEIAG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private OKCNIPGMDHK <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private TaskAwaiter<KKBOOBAMIML> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x7C19EA0", Offset = "0x7C192A0", VA = "0x187C19EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x7C1AA20", Offset = "0x7C19E20", VA = "0x187C1AA20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private struct NHIGAFHOHNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public AsyncTaskMethodBuilder<GPIPDBGGDOE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public EOBHGCGMEGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public KKBOOBAMIML request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private FAIEHJJNKFH.LHFEIKDEAMM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private OKCNIPGMDHK <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private TaskAwaiter<KKBOOBAMIML> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B5E0", Offset = "0x7C2A9E0", VA = "0x187C2B5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x7C2BB10", Offset = "0x7C2AF10", VA = "0x187C2BB10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class PKDEFGEEHIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public GPIPDBGGDOE operation;

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public PKDEFGEEHIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x7C2EC40", Offset = "0x7C2E040", VA = "0x187C2EC40")]
		internal object MGCGJFCHIGJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct MANPDNLCBNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public GPIPDBGGDOE operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public EOBHGCGMEGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private DJPNNBMEIAG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private FGFDKLMANEA<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A1D0", Offset = "0x7C295D0", VA = "0x187C2A1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A800", Offset = "0x7C29C00", VA = "0x187C2A800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class DFFCEGLCODL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public KKBOOBAMIML request;

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public DFFCEGLCODL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x7C16310", Offset = "0x7C15710", VA = "0x187C16310")]
		internal object FMNCIMLBDMH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class NHFEIHIGBGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public KKBOOBAMIML request;

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public NHFEIHIGBGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B580", Offset = "0x7C2A980", VA = "0x187C2B580")]
		internal object AKOHKOBKKLN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private CFEMEJBKCKD GHFCFJHMPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	private DPIIEOFIMOM CACFAEOIFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private GKBANNDJOKF EMDFGFNLMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	private NKMJHFBEIDI FNFKCGGCBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	private JFIOHCKEEIP MGMCFGLJIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	private TaskCompletionSource<IICNNDCPJEP> KDEHPOEHIMH;

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x7C18CC0", Offset = "0x7C180C0", VA = "0x187C18CC0", Slot = "7")]
	public void HPHCPPKCEKM(CFEMEJBKCKD GHFCFJHMPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x7C19750", Offset = "0x7C18B50", VA = "0x187C19750", Slot = "6")]
	[AsyncStateMachine(typeof(FBDKCDFKHGD))]
	public Task<IICNNDCPJEP> MIGBBFJGPHO(CancellationToken OBDPPPBJBFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7C193C0", Offset = "0x7C187C0", VA = "0x187C193C0", Slot = "4")]
	public void MFHFHJDKEDK(KKBOOBAMIML MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x7C18E40", Offset = "0x7C18240", VA = "0x187C18E40", Slot = "5")]
	public void JNHAKONBPOC(KKBOOBAMIML CICOFGCAFFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x7C191A0", Offset = "0x7C185A0", VA = "0x187C191A0")]
	[AsyncStateMachine(typeof(MAADJOBFMAK))]
	private Task LAIMLHKNANN(KKBOOBAMIML NEMAHPGAGLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x7C192B0", Offset = "0x7C186B0", VA = "0x187C192B0")]
	[AsyncStateMachine(typeof(FEPMMGDFBNP))]
	private Task LFGJKNFONMK(KKBOOBAMIML KHKPBKPELIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x7C186C0", Offset = "0x7C17AC0", VA = "0x187C186C0")]
	[AsyncStateMachine(typeof(NHIGAFHOHNO))]
	private Task<GPIPDBGGDOE> ACCLIEGHJCB(KKBOOBAMIML NEMAHPGAGLG, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x7C18DB0", Offset = "0x7C181B0", VA = "0x187C18DB0")]
	private OKCNIPGMDHK IGMMEANMPKO(KKBOOBAMIML FNHJGBHLJLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x7C18810", Offset = "0x7C17C10", VA = "0x187C18810")]
	[AsyncStateMachine(typeof(MANPDNLCBNC))]
	private Task ALADGHNMBNE(GPIPDBGGDOE FFEBDLHFDKK, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7C19860", Offset = "0x7C18C60", VA = "0x187C19860")]
	private GPIPDBGGDOE OAGEDGCLKBH(KKBOOBAMIML NEMAHPGAGLG, OKCNIPGMDHK LNEKCGEMFKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x322D360", Offset = "0x322C760", VA = "0x18322D360")]
	private T ECDIJKIJKOB<T>(T KBGCCIOIGBD) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x7C18930", Offset = "0x7C17D30", VA = "0x187C18930")]
	private GPIPDBGGDOE DAIBADBJHBE(KKBOOBAMIML NEMAHPGAGLG, OKCNIPGMDHK LNEKCGEMFKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public EOBHGCGMEGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[UnityEngine.Scripting.Preserve]
internal sealed class ABJEJMMFGDO : GKBANNDJOKF, HJPHNPODALD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class FAEODOHFKJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public FAEODOHFKJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x7C19A70", Offset = "0x7C18E70", VA = "0x187C19A70")]
		internal object MJJNNLGKOGP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class CEDOALMAMAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public CEDOALMAMAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x7C13530", Offset = "0x7C12930", VA = "0x187C13530")]
		internal object DJDDILNMKBJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	private JFIOHCKEEIP MGMCFGLJIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	private FIJOEDODGBA EGBCPDEJJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	private PMEHDCBJAMG EKLKOFOKCAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	private IFLFCLCHFEP GGFIOOHINMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	private OICHENLNLMC KGCLBBHLNLJ;

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x7C118D0", Offset = "0x7C10CD0", VA = "0x187C118D0", Slot = "6")]
	public void HPHCPPKCEKM(CFEMEJBKCKD GHFCFJHMPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x7C10C40", Offset = "0x7C10040", VA = "0x187C10C40", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x7C114A0", Offset = "0x7C108A0", VA = "0x187C114A0", Slot = "4")]
	public AHECFMBNCBG HGLBMLMGBFM(KKBOOBAMIML LFICHDNKEMG)
	{
		return default(AHECFMBNCBG);
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x7C107A0", Offset = "0x7C0FBA0", VA = "0x187C107A0", Slot = "5")]
	public void BFIIGPGIAMF(Guid EHMIFANHMPO, Task HALLDLPJOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x7C11190", Offset = "0x7C10590", VA = "0x187C11190")]
	private void EHIEJBKJENP(byte BEHNKEPLHBF, int GNEBHLDFAOJ, object KEMDCIKNPMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x7C11A40", Offset = "0x7C10E40", VA = "0x187C11A40")]
	private void IFBGPCAAPMH(DOJBJHGDOGF NBGBHBICCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x7C10CF0", Offset = "0x7C100F0", VA = "0x187C10CF0")]
	private void EANNENCBMHE(DOJBJHGDOGF NBGBHBICCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x7C11260", Offset = "0x7C10660", VA = "0x187C11260")]
	private void GICKBBEILJH(DOJBJHGDOGF NBGBHBICCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x7C123E0", Offset = "0x7C117E0", VA = "0x187C123E0")]
	private GGLMIDJEDGD MIPCONGCEEF(KKBOOBAMIML FNHJGBHLJLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x7C121D0", Offset = "0x7C115D0", VA = "0x187C121D0")]
	private void LKIFKAINBJP(KKBOOBAMIML KHKPBKPELIC, GGLMIDJEDGD DNHNCONLMMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x7C11FE0", Offset = "0x7C113E0", VA = "0x187C11FE0")]
	private bool LFPPEBLPELN(KKBOOBAMIML KHKPBKPELIC, GGLMIDJEDGD DNHNCONLMMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x7C10F70", Offset = "0x7C10370", VA = "0x187C10F70")]
	private bool EFIALGIBCKB(KKBOOBAMIML CNBLPINPMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x7C109B0", Offset = "0x7C0FDB0", VA = "0x187C109B0")]
	private bool CHFFNHLHHNB(byte BEHNKEPLHBF, ExitGames.Client.Photon.Hashtable NBGBHBICCPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public ABJEJMMFGDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[UnityEngine.Scripting.Preserve]
internal sealed class DKFEANDEPMH : AGKANHNJNLI, HJPHNPODALD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class KAJLLNGOKKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public IICNNDCPJEP operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public DKFEANDEPMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public KKBOOBAMIML roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public KAJLLNGOKKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x7C233B0", Offset = "0x7C227B0", VA = "0x187C233B0")]
		internal object HMELCPHOAHK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x7C23200", Offset = "0x7C22600", VA = "0x187C23200")]
		internal object FEDPNEENHFD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct CJECPMIKBBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public AsyncTaskMethodBuilder<GGLMIDJEDGD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public DKFEANDEPMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public KKBOOBAMIML roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private DJPNNBMEIAG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private TaskAwaiter<GGLMIDJEDGD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x7C135A0", Offset = "0x7C129A0", VA = "0x187C135A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x7C13C40", Offset = "0x7C13040", VA = "0x187C13C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class EIECNHJFFHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public IICNNDCPJEP operationType;

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public EIECNHJFFHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x7C185B0", Offset = "0x7C179B0", VA = "0x187C185B0")]
		internal object EJCICNDJCHN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class LBBPEAEDBAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public KKBOOBAMIML request;

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public LBBPEAEDBAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x7C261F0", Offset = "0x7C255F0", VA = "0x187C261F0")]
		internal object NJDOMBDJOOG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x7C26110", Offset = "0x7C25510", VA = "0x187C26110")]
		internal object DLCPKJGOBFG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x7C26180", Offset = "0x7C25580", VA = "0x187C26180")]
		internal object JACEJDFPMIJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct HLCPPLIFIMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public AsyncTaskMethodBuilder<GGLMIDJEDGD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public KKBOOBAMIML request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public DKFEANDEPMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private LBBPEAEDBAN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private DJPNNBMEIAG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		private AHECFMBNCBG <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private GGLMIDJEDGD <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private TaskAwaiter<(GGLMIDJEDGD validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x7C1CC90", Offset = "0x7C1C090", VA = "0x187C1CC90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D560", Offset = "0x7C1C960", VA = "0x187C1D560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	private JFIOHCKEEIP MGMCFGLJIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	private FIJOEDODGBA EGBCPDEJJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private GKBANNDJOKF EMDFGFNLMAL;

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x7C16A10", Offset = "0x7C15E10", VA = "0x187C16A10", Slot = "5")]
	public void HPHCPPKCEKM(CFEMEJBKCKD GHFCFJHMPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x7C16AC0", Offset = "0x7C15EC0", VA = "0x187C16AC0", Slot = "4")]
	[AsyncStateMachine(typeof(CJECPMIKBBJ))]
	private Task<GGLMIDJEDGD> IEKPCGHFLMG(KKBOOBAMIML FNHJGBHLJLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x7C16BE0", Offset = "0x7C15FE0", VA = "0x187C16BE0")]
	private bool IIHFICEBLHH(IICNNDCPJEP MNGFNEKIDGN, [Out] GGLMIDJEDGD BIEIOPPGBOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x7C16DD0", Offset = "0x7C161D0", VA = "0x187C16DD0")]
	[AsyncStateMachine(typeof(HLCPPLIFIMJ))]
	private Task<GGLMIDJEDGD> OPELMCPCPAM(KKBOOBAMIML NEMAHPGAGLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public DKFEANDEPMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class IMCGOCODLGF : PGODPOGHOLM, HJPHNPODALD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct DIOPNOMJDOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public AsyncTaskMethodBuilder<HLOJEJEEEIJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public GDBFIEIFOFD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public IMCGOCODLGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private TaskAwaiter<EPDFKONBMMJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private TaskAwaiter<HLOJEJEEEIJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x7C163D0", Offset = "0x7C157D0", VA = "0x187C163D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x7C169A0", Offset = "0x7C15DA0", VA = "0x187C169A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class IFPODFOCEPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public IFPODFOCEPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F420", Offset = "0x7C1E820", VA = "0x187C1F420")]
		internal object ILCIFLCHKAI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct KOPMGFCPBFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public AsyncTaskMethodBuilder<EPDFKONBMMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public IMCGOCODLGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public GDBFIEIFOFD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		private IFPODFOCEPP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private TaskAwaiter<EPDFKONBMMJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x7C25AB0", Offset = "0x7C24EB0", VA = "0x187C25AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x7C260A0", Offset = "0x7C254A0", VA = "0x187C260A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct LGHAEGBIJLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public AsyncTaskMethodBuilder<HLOJEJEEEIJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public IMCGOCODLGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public GDBFIEIFOFD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public EPDFKONBMMJ roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private TaskAwaiter<(DDDGOPGHMJC superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x7C26260", Offset = "0x7C25660", VA = "0x187C26260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x7C266C0", Offset = "0x7C25AC0", VA = "0x187C266C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private sealed class JEPFNFEEJFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public JEPFNFEEJFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xCE8F90", Offset = "0xCE8390", VA = "0x180CE8F90")]
		internal bool FGDGBOCJFFN(KOLBKODMCOP sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct LGOOFGMOGAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public AsyncTaskMethodBuilder<(DDDGOPGHMJC superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public EPDFKONBMMJ roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public IMCGOCODLGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public GDBFIEIFOFD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private TaskAwaiter<(DDDGOPGHMJC superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x7C26730", Offset = "0x7C25B30", VA = "0x187C26730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x7C26DD0", Offset = "0x7C261D0", VA = "0x187C26DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private sealed class GHKGGFBDLAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public GHKGGFBDLAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x7C1C110", Offset = "0x7C1B510", VA = "0x187C1C110")]
		internal object IGGMDIFLCNH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct KHHNAMOGFHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public AsyncTaskMethodBuilder<(DDDGOPGHMJC superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public KOLBKODMCOP subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public IMCGOCODLGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public GDBFIEIFOFD dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private GHKGGFBDLAA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private TaskAwaiter<JHNKENAKGMI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x7C239C0", Offset = "0x7C22DC0", VA = "0x187C239C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x7C240F0", Offset = "0x7C234F0", VA = "0x187C240F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	private static readonly (DDDGOPGHMJC superRoomData, long subRoomDataSaveId) GAICHPMGCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	private JJKJBCNAAJM MOKEOOADLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	private KOGJGNIFGMB PBOOMDNBGPL;

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x7C202D0", Offset = "0x7C1F6D0", VA = "0x187C202D0", Slot = "5")]
	public void HPHCPPKCEKM(CFEMEJBKCKD GHFCFJHMPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x7C20170", Offset = "0x7C1F570", VA = "0x187C20170", Slot = "4")]
	[AsyncStateMachine(typeof(DIOPNOMJDOE))]
	public Task<HLOJEJEEEIJ> DNCEKBDAJFI(FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, GDBFIEIFOFD DHCIGOGFOEM, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x7C20010", Offset = "0x7C1F410", VA = "0x187C20010")]
	[AsyncStateMachine(typeof(KOPMGFCPBFH))]
	private Task<EPDFKONBMMJ> CMJDMNBOIGG(GDBFIEIFOFD DHCIGOGFOEM, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x7C20360", Offset = "0x7C1F760", VA = "0x187C20360")]
	[AsyncStateMachine(typeof(LGHAEGBIJLK))]
	private Task<HLOJEJEEEIJ> JGPKANGEGEJ(GDBFIEIFOFD DHCIGOGFOEM, EPDFKONBMMJ OMEABIGPMID, long OGHBKCHPPKA, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x7C204D0", Offset = "0x7C1F8D0", VA = "0x187C204D0")]
	[AsyncStateMachine(typeof(LGOOFGMOGAE))]
	private Task<(DDDGOPGHMJC, long)> KCNJLCCLMDI(GDBFIEIFOFD DHCIGOGFOEM, EPDFKONBMMJ OMEABIGPMID, long OGHBKCHPPKA, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x7C20640", Offset = "0x7C1FA40", VA = "0x187C20640")]
	[AsyncStateMachine(typeof(KHHNAMOGFHM))]
	private Task<(DDDGOPGHMJC, long)> PIKOOMKPLHB(GDBFIEIFOFD GPFIGFDOMGJ, KOLBKODMCOP DFNCGPOAIGO, long OGHBKCHPPKA, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public IMCGOCODLGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[UnityEngine.Scripting.Preserve]
internal sealed class LKBNKABLJCJ : NKMJHFBEIDI, HJPHNPODALD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private sealed class EBOIBDKENKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public KKBOOBAMIML request;

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public EBOIBDKENKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x7C16F70", Offset = "0x7C16370", VA = "0x187C16F70")]
		internal object EMGPMPGGAEH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private struct FJNGOKCLLNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public AsyncTaskMethodBuilder<KKBOOBAMIML> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public KKBOOBAMIML request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public LKBNKABLJCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public OKCNIPGMDHK pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private DJPNNBMEIAG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private TaskAwaiter<KKBOOBAMIML> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x7C1BA90", Offset = "0x7C1AE90", VA = "0x187C1BA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x7C1C0A0", Offset = "0x7C1B4A0", VA = "0x187C1C0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private struct MMJOGDMDBPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public AsyncTaskMethodBuilder<KKBOOBAMIML> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public LKBNKABLJCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public OKCNIPGMDHK pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private DJPNNBMEIAG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private TaskAwaiter<PAFBOPDACHP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A860", Offset = "0x7C29C60", VA = "0x187C2A860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AE60", Offset = "0x7C2A260", VA = "0x187C2AE60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class KHAJEJLKBFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public KKBOOBAMIML request;

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public KHAJEJLKBFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x7C23960", Offset = "0x7C22D60", VA = "0x187C23960")]
		internal object ECNPHBKMAEH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private struct KNKJBDHHHFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public AsyncTaskMethodBuilder<KKBOOBAMIML> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public KKBOOBAMIML request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public LKBNKABLJCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public OKCNIPGMDHK pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private DJPNNBMEIAG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private JEBNFPBGHGM <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private CFDMPKCAGPN <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private TaskAwaiter<PAFBOPDACHP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x7C24E10", Offset = "0x7C24210", VA = "0x187C24E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x7C25A00", Offset = "0x7C24E00", VA = "0x187C25A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	private JFIOHCKEEIP MGMCFGLJIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private DFPFMGJEMIJ LBOLDJMDCCL;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private FJGBFJOGCIJ ODEPJIBCIOA
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x7C28010", Offset = "0x7C27410", VA = "0x187C28010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x7C27E20", Offset = "0x7C27220", VA = "0x187C27E20", Slot = "8")]
	public void HPHCPPKCEKM(CFEMEJBKCKD GHFCFJHMPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x7C280D0", Offset = "0x7C274D0", VA = "0x187C280D0", Slot = "4")]
	[AsyncStateMachine(typeof(FJNGOKCLLNP))]
	public Task<KKBOOBAMIML> LLJLNJMCBHI(KKBOOBAMIML NEMAHPGAGLG, OKCNIPGMDHK LNEKCGEMFKF, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x7C27C20", Offset = "0x7C27020", VA = "0x187C27C20", Slot = "5")]
	[AsyncStateMachine(typeof(MMJOGDMDBPC))]
	public Task<KKBOOBAMIML> EKKLCMPHPCM(CancellationToken LAEIHJHNGEK, OKCNIPGMDHK LNEKCGEMFKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x7C27D70", Offset = "0x7C27170", VA = "0x187C27D70", Slot = "6")]
	public LGACCJIPMFL EPCMPIFOELB(GPIPDBGGDOE BINLGGPBHKF, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x7C28230", Offset = "0x7C27630", VA = "0x187C28230", Slot = "7")]
	public LGACCJIPMFL PCFPIJDPFLE(GPIPDBGGDOE BINLGGPBHKF, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x7C27EB0", Offset = "0x7C272B0", VA = "0x187C27EB0")]
	[AsyncStateMachine(typeof(KNKJBDHHHFP))]
	private Task<KKBOOBAMIML> JMNHNLJPNKA(KKBOOBAMIML NEMAHPGAGLG, OKCNIPGMDHK LNEKCGEMFKF, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x347DD10", Offset = "0x347D110", VA = "0x18347DD10")]
	private static byte[] NNIEKIEGNAE(KKBOOBAMIML MIALAMIFNLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public LKBNKABLJCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[UnityEngine.Scripting.Preserve]
internal sealed class EFCMDHEGPNM : FIJOEDODGBA, HJPHNPODALD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000320")]
	private FFGHMBJEEPI DPJMJJNONDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000321")]
	private JFIOHCKEEIP MGMCFGLJIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000322")]
	private DPIIEOFIMOM CACFAEOIFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	private DCMMBBANFEL GBHJIOELJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	private JJKJBCNAAJM MOKEOOADLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private FCMMGHLPILA HIENPDPIDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	private LCEMKOAHHCJ DNLMCJOKGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	private OBPMHPKAJAE HIGIOODIHPF;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private FBKMDCBFBII IELHGPMHDJI
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x7C17540", Offset = "0x7C16940", VA = "0x187C17540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private static GGLMIDJEDGD FLHKLEFIOME
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x7C17140", Offset = "0x7C16540", VA = "0x187C17140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x7C173D0", Offset = "0x7C167D0", VA = "0x187C173D0", Slot = "6")]
	public void HPHCPPKCEKM(CFEMEJBKCKD GHFCFJHMPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x7C16FD0", Offset = "0x7C163D0", VA = "0x187C16FD0", Slot = "4")]
	public GGLMIDJEDGD DCODFNMJCMH(OPHKANJGPPK PCCBNDDCHNF, IICNNDCPJEP IJECCKDIIBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x7C17150", Offset = "0x7C16550", VA = "0x187C17150", Slot = "5")]
	public GGLMIDJEDGD GJFDLFDAOAI(OPHKANJGPPK OFAFOALBCJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x7C17590", Offset = "0x7C16990", VA = "0x187C17590")]
	private static GGLMIDJEDGD KCIIPNEEJDL(AOEFHBHKKHL CEGFAIJENKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public EFCMDHEGPNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public class KOGNBEPLDDK : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x7C25A70", Offset = "0x7C24E70", VA = "0x187C25A70")]
	public KOGNBEPLDDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x6F261A0", Offset = "0x6F255A0", VA = "0x186F261A0")]
	public KOGNBEPLDDK(string MIALAMIFNLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[UnityEngine.Scripting.Preserve]
internal sealed class JBMFODGNGOA : KPLLGNPEHIH, HJPHNPODALD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private struct CPDHFEDBPPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public AsyncTaskMethodBuilder<GGLMIDJEDGD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public JBMFODGNGOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public JICNBBCNCAC autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private FGFDKLMANEA<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		private BIPDBNACGLK <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private TaskAwaiter<GGLMIDJEDGD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x7C142B0", Offset = "0x7C136B0", VA = "0x187C142B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x7C14E00", Offset = "0x7C14200", VA = "0x187C14E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private struct EGCFNJKEEJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public JBMFODGNGOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x7C175A0", Offset = "0x7C169A0", VA = "0x187C175A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x7C17D00", Offset = "0x7C17100", VA = "0x187C17D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private struct JMHBNFLCECD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public JBMFODGNGOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x7C22C90", Offset = "0x7C22090", VA = "0x187C22C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x7C231A0", Offset = "0x7C225A0", VA = "0x187C231A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private struct LIHGKLIDDAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public JBMFODGNGOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x7C26E40", Offset = "0x7C26240", VA = "0x187C26E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x7C27590", Offset = "0x7C26990", VA = "0x187C27590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[CompilerGenerated]
	private struct NDNFLKDAGCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public JBMFODGNGOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AED0", Offset = "0x7C2A2D0", VA = "0x187C2AED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B070", Offset = "0x7C2A470", VA = "0x187C2B070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private struct HJPEOALELDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public JBMFODGNGOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x7C1C500", Offset = "0x7C1B900", VA = "0x187C1C500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x7C1CC30", Offset = "0x7C1C030", VA = "0x187C1CC30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private struct HPOFMLGEACL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public JBMFODGNGOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		private Task <delayTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D630", Offset = "0x7C1CA30", VA = "0x187C1D630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x7C1DAA0", Offset = "0x7C1CEA0", VA = "0x187C1DAA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct JHNJBGHPDFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public JBMFODGNGOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public DPOOOLNKMNK autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private FGFDKLMANEA<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x7C226C0", Offset = "0x7C21AC0", VA = "0x187C226C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x7C22C30", Offset = "0x7C22030", VA = "0x187C22C30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	private JFIOHCKEEIP MGMCFGLJIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	private CFEMEJBKCKD GHFCFJHMPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	private JJKJBCNAAJM MOKEOOADLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	private NKMJHFBEIDI FNFKCGGCBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private DPIIEOFIMOM CACFAEOIFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private LCEMKOAHHCJ DNLMCJOKGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private CancellationTokenSource BMGALKOCNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private Task MCONEFFOHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private TaskCompletionSource<int> CPGFFCFLNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private int HPPBEMFGPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private int OIPCJHPCJFB;

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x7C20C80", Offset = "0x7C20080", VA = "0x187C20C80", Slot = "6")]
	public void HPHCPPKCEKM(CFEMEJBKCKD GHFCFJHMPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x10B6D40", Offset = "0x10B6140", VA = "0x1810B6D40", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x7C21060", Offset = "0x7C20460", VA = "0x187C21060")]
	private void LBCLMLGFPAA(float AGIFAONKJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x7C20F30", Offset = "0x7C20330", VA = "0x187C20F30", Slot = "4")]
	[AsyncStateMachine(typeof(CPDHFEDBPPN))]
	public Task<GGLMIDJEDGD> KHCOBLOPMED(JICNBBCNCAC CIIBJONMFCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x7C213C0", Offset = "0x7C207C0", VA = "0x187C213C0", Slot = "5")]
	[AsyncStateMachine(typeof(EGCFNJKEEJF))]
	public Task NBOEIFCOODG([Optional] CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x10B6D40", Offset = "0x10B6140", VA = "0x1810B6D40")]
	public void MBBDCEMMKBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x7C20B10", Offset = "0x7C1FF10", VA = "0x187C20B10")]
	private BIPDBNACGLK HINKEEHELHK(JICNBBCNCAC CIIBJONMFCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x7C20910", Offset = "0x7C1FD10", VA = "0x187C20910")]
	[AsyncStateMachine(typeof(JMHBNFLCECD))]
	private Task BCFHKBHIMBO(CancellationToken DGLOFFGGICM, int HGKMPCJFPLO, KNBIGIEKHKK KECAFPMAPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x7C20E30", Offset = "0x7C20230", VA = "0x187C20E30")]
	[AsyncStateMachine(typeof(LIHGKLIDDAC))]
	private Task IOJBKKHPANI(CancellationToken DGLOFFGGICM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x7C214B0", Offset = "0x7C208B0", VA = "0x187C214B0")]
	[AsyncStateMachine(typeof(NDNFLKDAGCL))]
	private Task NDIEMEJIKBJ([Optional] CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x7C21730", Offset = "0x7C20B30", VA = "0x187C21730")]
	[AsyncStateMachine(typeof(HJPEOALELDD))]
	private Task OBHDNGCMGBN(CancellationToken DGLOFFGGICM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x7C21820", Offset = "0x7C20C20", VA = "0x187C21820")]
	[AsyncStateMachine(typeof(HPOFMLGEACL))]
	private Task OCGMNMOLEJA(CancellationToken EKNLLBIEBJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x7C215A0", Offset = "0x7C209A0", VA = "0x187C215A0")]
	private Task OBBBKFFHHBO(DPOOOLNKMNK KEGDNPBCBNK, CancellationToken DGLOFFGGICM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x7C20A00", Offset = "0x7C1FE00", VA = "0x187C20A00")]
	[AsyncStateMachine(typeof(JHNJBGHPDFK))]
	private Task ENPDKIEALDB(DPOOOLNKMNK KEGDNPBCBNK, CancellationToken DGLOFFGGICM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x7C21140", Offset = "0x7C20540", VA = "0x187C21140")]
	private bool LDPDMFOPNIP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public JBMFODGNGOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[UnityEngine.Scripting.Preserve]
internal class LPCOJDDNFLI : DCMMBBANFEL, HJPHNPODALD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct LIHIGICKKOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public LPCOJDDNFLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private FGFDKLMANEA<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x7C275F0", Offset = "0x7C269F0", VA = "0x187C275F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x7C27B60", Offset = "0x7C26F60", VA = "0x187C27B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400036C")]
	private ENHCOOGKGFN ADFGFLNPGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400036D")]
	private CFEMEJBKCKD GHFCFJHMPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400036E")]
	private FIJOEDODGBA EGBCPDEJJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400036F")]
	private NKMJHFBEIDI FNFKCGGCBKG;

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x7C29630", Offset = "0x7C28A30", VA = "0x187C29630", Slot = "6")]
	public void HPHCPPKCEKM(CFEMEJBKCKD GHFCFJHMPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x7C294E0", Offset = "0x7C288E0", VA = "0x187C294E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x7C29530", Offset = "0x7C28930", VA = "0x187C29530", Slot = "5")]
	[AsyncStateMachine(typeof(LIHIGICKKOJ))]
	public Task FGPHEEIMFAD(string DPEONNMDCPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x7C29840", Offset = "0x7C28C40", VA = "0x187C29840", Slot = "4")]
	public GGLMIDJEDGD LDPDMFOPNIP(OPHKANJGPPK PCCBNDDCHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x7C293F0", Offset = "0x7C287F0", VA = "0x187C293F0")]
	private ANEDJOBPDGC CFIJCCNCHLF(string DPEONNMDCPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public LPCOJDDNFLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public static class ILBCMDBLFKK
{
	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x7C1FB90", Offset = "0x7C1EF90", VA = "0x187C1FB90")]
	public static void LNPDIMNANJI(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x7C1FEB0", Offset = "0x7C1F2B0", VA = "0x187C1FEB0")]
	internal static void NPJBGAOHAMG(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x7C1FDD0", Offset = "0x7C1F1D0", VA = "0x187C1FDD0")]
	internal static void NLHLFPAENPL(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x7C1F760", Offset = "0x7C1EB60", VA = "0x187C1F760")]
	internal static void JBKHBMIPEGM(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x33CEB20", Offset = "0x33CDF20", VA = "0x1833CEB20")]
	private static void NCHDKGDOLCJ<Interface, Impl, Interface>(GFKEMDIOCPC MGOKPJKELJG) where Impl : Interface
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal class MCMAIIKCICA : CCAFNMCGKLI<KKBOOBAMIML>
{
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private sealed class HAJLHKBEJDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public KKBOOBAMIML message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public HAJLHKBEJDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x7C393B0", Offset = "0x7C387B0", VA = "0x187C393B0")]
		internal object HHJBKAHCBLF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly MCMAIIKCICA IMFIEPMCPDC;

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x7C42350", Offset = "0x7C41750", VA = "0x187C42350")]
	public ExitGames.Client.Photon.Hashtable IMJDHHAECMF(KKBOOBAMIML MIALAMIFNLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x7C423E0", Offset = "0x7C417E0", VA = "0x187C423E0", Slot = "5")]
	protected override void KICCMLHNNCD(KKBOOBAMIML MIALAMIFNLM, IDictionary<object, object> GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x7C42010", Offset = "0x7C41410", VA = "0x187C42010", Slot = "6")]
	public override KKBOOBAMIML GFOCOOKFNLL(IDictionary<object, object> GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x7C42240", Offset = "0x7C41640", VA = "0x187C42240")]
	private static void IEGNOINNOMJ(string PDMAGOJMJEB, KKBOOBAMIML MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x7C42860", Offset = "0x7C41C60", VA = "0x187C42860")]
	public MCMAIIKCICA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x7C42510", Offset = "0x7C41910", VA = "0x187C42510")]
	[CompilerGenerated]
	internal static string KJONBPEJBMC(HLOJEJEEEIJ GOAPBALNOKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public static class NFNDKIHMEBH
{
	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public static GGLMIDJEDGD FLHKLEFIOME
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x7C44A70", Offset = "0x7C43E70", VA = "0x187C44A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x7C44A50", Offset = "0x7C43E50", VA = "0x187C44A50")]
	public static bool GBIDAPBNAJP(this GGLMIDJEDGD DNHNCONLMMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x7C44CD0", Offset = "0x7C440D0", VA = "0x187C44CD0")]
	public static GGLMIDJEDGD KCIIPNEEJDL(AOEFHBHKKHL DCLADEMODOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x7C44AD0", Offset = "0x7C43ED0", VA = "0x187C44AD0")]
	public static GGLMIDJEDGD IAEEJIKKGPP(IEnumerable<GGLMIDJEDGD> KNEHOIAJNPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x7C447F0", Offset = "0x7C43BF0", VA = "0x187C447F0")]
	public static string CLMDBAJEOCA(this GGLMIDJEDGD BIEIOPPGBOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public abstract class COKLCMLMHGP : IFHHAIBGOKI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public delegate GGLMIDJEDGD OKGDMFMHACK([NotNull] OPHKANJGPPK JHKDFCONLEP);

	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private sealed class PDKLLDCFNGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public OPHKANJGPPK photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public PDKLLDCFNGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x13340C0", Offset = "0x13334C0", VA = "0x1813340C0")]
		internal GGLMIDJEDGD COBMLCPMIDC(OKGDMFMHACK v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400037C")]
	private bool NLNPPHMOFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400037D")]
	protected readonly HashSet<OKGDMFMHACK> KLOIPCLBLLE;

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x7C33280", Offset = "0x7C32680", VA = "0x187C33280", Slot = "4")]
	public void CGJCKCBCGDD(OKGDMFMHACK MPMNOKLGMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x7C33330", Offset = "0x7C32730", VA = "0x187C33330", Slot = "5")]
	public void KPHLKODFGBA(OKGDMFMHACK MPMNOKLGMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x7C332E0", Offset = "0x7C326E0", VA = "0x187C332E0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x7C33390", Offset = "0x7C32790", VA = "0x187C33390")]
	protected GGLMIDJEDGD OPJNPGGHPHE(OPHKANJGPPK OFAFOALBCJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x7C33630", Offset = "0x7C32A30", VA = "0x187C33630")]
	protected COKLCMLMHGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public class JNMPLEKFFEC : COKLCMLMHGP, FFGHMBJEEPI, IFHHAIBGOKI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[CompilerGenerated]
	private sealed class PPNPJEOFEDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public GGLMIDJEDGD result;

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public PPNPJEOFEDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x7C4A060", Offset = "0x7C49460", VA = "0x187C4A060")]
		internal object HAEGLPBHOAI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x7C3A0D0", Offset = "0x7C394D0", VA = "0x187C3A0D0")]
	[UnityEngine.Scripting.Preserve]
	public JNMPLEKFFEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x7C3C6A0", Offset = "0x7C3BAA0", VA = "0x187C3C6A0", Slot = "8")]
	public GGLMIDJEDGD ICFPILFCHIO(OPHKANJGPPK OFAFOALBCJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public class HEFELHIFDCD : COKLCMLMHGP, ENHCOOGKGFN, IFHHAIBGOKI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[CompilerGenerated]
	private sealed class CHPOCCDLEJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public GGLMIDJEDGD result;

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public CHPOCCDLEJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x7C331A0", Offset = "0x7C325A0", VA = "0x187C331A0")]
		internal object HHFLFFJJBCM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x7C3A0D0", Offset = "0x7C394D0", VA = "0x187C3A0D0")]
	[UnityEngine.Scripting.Preserve]
	public HEFELHIFDCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x7C39FC0", Offset = "0x7C393C0", VA = "0x187C39FC0", Slot = "8")]
	public GGLMIDJEDGD LDPDMFOPNIP(OPHKANJGPPK EFGAKBIDOLG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
internal static class KPJMDCGJAFI
{
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private sealed class CJKKOHHKDJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public FGFDKLMANEA<string> timer;

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public CJKKOHHKDJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x7C33200", Offset = "0x7C32600", VA = "0x187C33200")]
		internal object HEEAPOPNCPC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x7C3DF90", Offset = "0x7C3D390", VA = "0x187C3DF90")]
	public static FGFDKLMANEA<string> GBMBGLFNOGP(IBCMILIKEJG DDKJAEALMGF, [Optional] string KDCJEBLDBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x7C3DED0", Offset = "0x7C3D2D0", VA = "0x187C3DED0")]
	public static void CICAEOIMCJN(FGFDKLMANEA<string> ACNLNBKGHCE, IBCMILIKEJG DDKJAEALMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x7C3E070", Offset = "0x7C3D470", VA = "0x187C3E070")]
	public static string IHMCFIOKBKL(KKBOOBAMIML FNHJGBHLJLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
internal static class ANBAMBBKAHF
{
	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x7C2F950", Offset = "0x7C2ED50", VA = "0x187C2F950")]
	public static void KBJHCPGNBBI(this JFIOHCKEEIP MGMCFGLJIGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x7C2F940", Offset = "0x7C2ED40", VA = "0x187C2F940")]
	public static void DGMGEEEGKNK(this JFIOHCKEEIP MGMCFGLJIGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x7C2F820", Offset = "0x7C2EC20", VA = "0x187C2F820")]
	private static void CEKFNPCLDOI(this JFIOHCKEEIP MGMCFGLJIGI, bool HHDDJPGHEAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public class DDNGFGBIIKD : ECOCBFMFIOC, LIIDEAJGIMB, KOCGNCDMOPN, EDKLJOILFEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000385")]
	private readonly LIIDEAJGIMB BKMEGKKMPAP;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public OPHKANJGPPK CKOIGGKJGGH
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x7C33E50", Offset = "0x7C33250", VA = "0x187C33E50", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public int AKNODCDPMFD
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x7C34210", Offset = "0x7C33610", VA = "0x187C34210", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public int NKBFAKMAGKE
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x7C33E00", Offset = "0x7C33200", VA = "0x187C33E00", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public bool DIHDOFMHJHD
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public int KMDCADAAJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0xA6BC50", Offset = "0xA6B050", VA = "0x180A6BC50", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event BMBNGCGJOIM.OFOPFDAOBOK BAGHFLOBLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event FJMKBAPIJAM LHFOAEPBCEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x7C34170", Offset = "0x7C33570", VA = "0x187C34170", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x7C33EA0", Offset = "0x7C332A0", VA = "0x187C33EA0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<bool> PGBACEBCHGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<OPHKANJGPPK> KPAOCMPFANM
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event Action HPIDINHPCCE
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x7C33D60", Offset = "0x7C33160", VA = "0x187C33D60", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x7C33F40", Offset = "0x7C33340", VA = "0x187C33F40", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0xBB5BE0", Offset = "0xBB4FE0", VA = "0x180BB5BE0")]
	public DDNGFGBIIKD(LIIDEAJGIMB BKMEGKKMPAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x7C340C0", Offset = "0x7C334C0", VA = "0x187C340C0", Slot = "8")]
	public bool LABMAAMFCPG(byte BEHNKEPLHBF, object FNCHNJICPAH, APIINIHDAID HBPNGGLDACB, SendOptions DAEFANOOJBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x7C33FE0", Offset = "0x7C333E0", VA = "0x187C33FE0", Slot = "16")]
	public OPHKANJGPPK IAOPBEKPMAP(int NJNOPMJJKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "19")]
	public void BJPHDIPLHBD(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "20")]
	public void INFNFEODANG(object LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "21")]
	public void DHFIKMLHMPE(object LAAJFAFNFCN, bool LGLLAKCPHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x7C34260", Offset = "0x7C33660", VA = "0x187C34260", Slot = "22")]
	public IDisposable PIHIMIFAALK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "23")]
	private bool LMAIFDBLKBF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "24")]
	public void BDLIHPFLNBL(StringBuilder IICLAANMIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0xDB6AE0", Offset = "0xDB5EE0", VA = "0x180DB6AE0", Slot = "25")]
	public bool HEJANPGJFCG(bool NJNGBOFHOIL, [Out] string IFMHONGNKHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0xD47330", Offset = "0xD46730", VA = "0x180D47330", Slot = "28")]
	public void NMIFDHJFLHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
internal struct DOJBJHGDOGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000387")]
	private readonly IDictionary<object, object> NBGBHBICCPM;

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0xBCD900", Offset = "0xBCCD00", VA = "0x180BCD900")]
	public DOJBJHGDOGF(IDictionary<object, object> NBGBHBICCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x7C34770", Offset = "0x7C33B70", VA = "0x187C34770")]
	public bool JLMBHIIEEIK([Out] KKBOOBAMIML MIALAMIFNLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x7C34580", Offset = "0x7C33980", VA = "0x187C34580")]
	public Guid CINEDAJDELO()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x7C34630", Offset = "0x7C33A30", VA = "0x187C34630")]
	public GGLMIDJEDGD FADLGBJPEJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x7C34820", Offset = "0x7C33C20", VA = "0x187C34820")]
	public static ExitGames.Client.Photon.Hashtable OILMBKHFGKP(KKBOOBAMIML MIALAMIFNLM, GGLMIDJEDGD DNHNCONLMMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
internal static class BKOHJMBFGEE
{
	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x7C31F90", Offset = "0x7C31390", VA = "0x187C31F90")]
	public static bool ONCGCEEMNCP(this GDBFIEIFOFD FJKJDPBPFHP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal struct MHOKGHJKDDN : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private struct JHDDMGEPHFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public MHOKGHJKDDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x7C3BFC0", Offset = "0x7C3B3C0", VA = "0x187C3BFC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x7C3C1A0", Offset = "0x7C3B5A0", VA = "0x187C3C1A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000388")]
	private readonly CancellationTokenSource PMAMMIAHALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000389")]
	private bool NLNPPHMOFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400038A")]
	private Task CBPINBDBDCO;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool DLCFPDABHIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x7C42AF0", Offset = "0x7C41EF0", VA = "0x187C42AF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x7C42C80", Offset = "0x7C42080", VA = "0x187C42C80")]
	public MHOKGHJKDDN(CancellationToken LAEIHJHNGEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x7C42B70", Offset = "0x7C41F70", VA = "0x187C42B70")]
	[AsyncStateMachine(typeof(JHDDMGEPHFC))]
	public Task EFNPPBJIOOC(Func<CancellationToken, List<Task>> CMKCNDOGGAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x7C42B20", Offset = "0x7C41F20", VA = "0x187C42B20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public readonly struct LPKPFNJIIOO<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[CompilerGenerated]
	private struct MKGHBOBAOBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<ENCJOPBFNLI<TData>, PGAGFEIEKID>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public LPKPFNJIIOO<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private TaskAwaiter<JOFBNNGKBOO<ENCJOPBFNLI<TData>, PGAGFEIEKID>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x4DACEE0", Offset = "0x4DAC2E0", VA = "0x184DACEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x4724380", Offset = "0x4723780", VA = "0x184724380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000390")]
	private readonly GFADJGFDDHP<TGetDataArg, TData> JDFKOKOAHAA;

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0xBCD900", Offset = "0xBCCD00", VA = "0x180BCD900")]
	internal LPKPFNJIIOO(GFADJGFDDHP<TGetDataArg, TData> GKFDJGEMKAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x4B7A630", Offset = "0x4B79A30", VA = "0x184B7A630")]
	[AsyncStateMachine(typeof(LPKPFNJIIOO<, >.MKGHBOBAOBK))]
	public Task<JOFBNNGKBOO<ENCJOPBFNLI<TData>, PGAGFEIEKID>> NNOGBDHFLNJ(TGetDataArg ICONKPKJBGN, string JCFKNJHIFIM, FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public static class JOOLOPBAMME
{
	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x3152580", Offset = "0x3151980", VA = "0x183152580")]
	public static LPKPFNJIIOO<TGetDataArg, TData> FEOBEKOIKMG<TGetDataArg, TData>(GFADJGFDDHP<TGetDataArg, TData> GKFDJGEMKAB)
	{
		return default(LPKPFNJIIOO<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public struct KKHLHELFLNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public readonly int PJKJMMANGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public readonly int? PBLIJBMDKMM;

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x4B3D9C0", Offset = "0x4B3CDC0", VA = "0x184B3D9C0")]
	public KKHLHELFLNI(int FOBKIBNHAIN, [Optional] int? DKJHDEECFMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x7C3CBD0", Offset = "0x7C3BFD0", VA = "0x187C3CBD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public interface NKGPFFCLEIB<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HACHOHENIHO();

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NKGPFFCLEIB<T> MMJADBGGLEE(string BHPFPDNBMAP);

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NKGPFFCLEIB<T> EJGHJFBIGLA(JEJADIEGMNL<T> DPGENFDLIOO);

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NKGPFFCLEIB<T> IPLLFLFPJCJ(int HKJCJLGBMOM);

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NKGPFFCLEIB<T> ABJFGMNIBHJ(int HKJCJLGBMOM, FOKDKLHPCLD<T> DHJOOGALHPO);
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public interface EGCFGIOCDGL
{
	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NKGPFFCLEIB<T> KDDEFCMPNOC<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MBBDEMCCEJA KAMDDKHMIJC(Exception DADIPHEHDBH);

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KKHLHELFLNI FAMIBNGENCK(Exception DADIPHEHDBH);
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public delegate string JEJADIEGMNL<in T>(T DADIPHEHDBH) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public delegate int FOKDKLHPCLD<in T>(T DADIPHEHDBH) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000F5")]
internal class BHPLBCGMGON : EGCFGIOCDGL
{
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	private delegate string LFOICBAFJGI(Exception DADIPHEHDBH);

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	private delegate int CABJMDHPFFL(Exception DADIPHEHDBH);

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	private class HFBFNOIKNHI<T> : NKGPFFCLEIB<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000F9")]
		[CompilerGenerated]
		private sealed class DDCHFNDHFBA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public DDCHFNDHFBA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
			internal string EBIDACAFHDN(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		[CompilerGenerated]
		private sealed class CPKBGFOMDMP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			public JEJADIEGMNL<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public CPKBGFOMDMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0x4F8F370", Offset = "0x4F8E770", VA = "0x184F8F370")]
			internal string FBEPHHLPOCC(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FB")]
		[CompilerGenerated]
		private sealed class OEIFHGLENKB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			public FOKDKLHPCLD<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000479")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public OEIFHGLENKB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600047A")]
			[Cpp2IlInjected.Address(RVA = "0x4F8F370", Offset = "0x4F8E770", VA = "0x184F8F370")]
			internal int PEELHIJJIBO(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private readonly BHPLBCGMGON OAHKGNHNFGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private readonly Type NIECELIGEPL;

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x45D88D0", Offset = "0x45D7CD0", VA = "0x1845D88D0")]
		internal HFBFNOIKNHI(BHPLBCGMGON OAHKGNHNFGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x45D8740", Offset = "0x45D7B40", VA = "0x1845D8740", Slot = "4")]
		public void HACHOHENIHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x45D87B0", Offset = "0x45D7BB0", VA = "0x1845D87B0", Slot = "5")]
		public NKGPFFCLEIB<T> MMJADBGGLEE(string BHPFPDNBMAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x45D8620", Offset = "0x45D7A20", VA = "0x1845D8620", Slot = "6")]
		public NKGPFFCLEIB<T> EJGHJFBIGLA(JEJADIEGMNL<T> DPGENFDLIOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x45D8770", Offset = "0x45D7B70", VA = "0x1845D8770", Slot = "7")]
		public NKGPFFCLEIB<T> IPLLFLFPJCJ(int HKJCJLGBMOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x45D84F0", Offset = "0x45D78F0", VA = "0x1845D84F0", Slot = "8")]
		public NKGPFFCLEIB<T> ABJFGMNIBHJ(int HKJCJLGBMOM, FOKDKLHPCLD<T> DHJOOGALHPO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	private class MIPLIGONKNP<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private bool ODFJCGJKNCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private readonly List<Type> GBLAIAHAFME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private readonly Dictionary<Type, TVal> CFFOECLBAEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private readonly Dictionary<Type, int> GIPOGJJNGIL;

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public IReadOnlyList<Type> KLKILELLBDH
		{
			[Cpp2IlInjected.Token(Token = "0x600047D")]
			[Cpp2IlInjected.Address(RVA = "0x4D90CE0", Offset = "0x4D900E0", VA = "0x184D90CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x4D91180", Offset = "0x4D90580", VA = "0x184D91180")]
		public MIPLIGONKNP(Dictionary<Type, int> GIPOGJJNGIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x4D90FD0", Offset = "0x4D903D0", VA = "0x184D90FD0")]
		public void HBHDBABAKDP(Type LKMGECEEGEE, TVal DGOEGFOLJJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x4D90E40", Offset = "0x4D90240", VA = "0x184D90E40")]
		public bool GBPPMFIDIFK(Type NIECELIGEPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x4D91130", Offset = "0x4D90530", VA = "0x184D91130")]
		public bool NKNKPAELMGK(TVal KBGCCIOIGBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x471EBC0", Offset = "0x471DFC0", VA = "0x18471EBC0")]
		public TVal NPPDIJEBOHO(Type BMIPLDLMPCD)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x4D90E90", Offset = "0x4D90290", VA = "0x184D90E90")]
		[CompilerGenerated]
		private int GKKPHCADCFI(Type JBKJBPEMIHP, Type KMKKCGBNEGK)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private sealed class BIKJNIAMLLN : IEnumerable<KKHLHELFLNI>, IEnumerable, IEnumerator<KKHLHELFLNI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private KKHLHELFLNI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public BHPLBCGMGON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private IEnumerator<KKHLHELFLNI> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		private KKHLHELFLNI System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000487")]
			[Cpp2IlInjected.Address(RVA = "0x40845E0", Offset = "0x40839E0", VA = "0x1840845E0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KKHLHELFLNI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000489")]
			[Cpp2IlInjected.Address(RVA = "0x7C31BA0", Offset = "0x7C30FA0", VA = "0x187C31BA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0xD230D0", Offset = "0xD224D0", VA = "0x180D230D0")]
		[DebuggerHidden]
		public BIKJNIAMLLN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x7C31BF0", Offset = "0x7C30FF0", VA = "0x187C31BF0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x7C315E0", Offset = "0x7C309E0", VA = "0x187C315E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x7C31540", Offset = "0x7C30940", VA = "0x187C31540")]
		private void ACIHHJJLKBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x7C31590", Offset = "0x7C30990", VA = "0x187C31590")]
		private void CHJIKJDKKOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x7C31B50", Offset = "0x7C30F50", VA = "0x187C31B50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x7C31A90", Offset = "0x7C30E90", VA = "0x187C31A90", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KKHLHELFLNI> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x7C31A90", Offset = "0x7C30E90", VA = "0x187C31A90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	private static readonly KKHLHELFLNI IBJFIBKMOEF;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	private static readonly Dictionary<Type, int> LOBEBCOLCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400039E")]
	private readonly HashSet<Type> PJBALPLCJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400039F")]
	private readonly MIPLIGONKNP<int> BHEJCBKKJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	private readonly MIPLIGONKNP<CABJMDHPFFL> MJDFNDGJNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	private readonly MIPLIGONKNP<LFOICBAFJGI> LHBOAKJGILP;

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x7C2FDA0", Offset = "0x7C2F1A0", VA = "0x187C2FDA0")]
	[HLOHOCOKELO.IDGFAEKKODB.GGCNFHIOHEN]
	internal static void AOKDCDMDNDH(GFKEMDIOCPC BFAKMKOHPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x7C31190", Offset = "0x7C30590", VA = "0x187C31190")]
	[RecRoom.NoEngine.Common.Preserve]
	public BHPLBCGMGON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x3152A20", Offset = "0x3151E20", VA = "0x183152A20", Slot = "4")]
	public NKGPFFCLEIB<T> KDDEFCMPNOC<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x7C306A0", Offset = "0x7C2FAA0", VA = "0x187C306A0", Slot = "5")]
	public MBBDEMCCEJA KAMDDKHMIJC(Exception DADIPHEHDBH)
	{
		return default(MBBDEMCCEJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x7C301D0", Offset = "0x7C2F5D0", VA = "0x187C301D0", Slot = "6")]
	public KKHLHELFLNI FAMIBNGENCK(Exception? DADIPHEHDBH)
	{
		return default(KKHLHELFLNI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x7C2FD00", Offset = "0x7C2F100", VA = "0x187C2FD00", Slot = "7")]
	[IteratorStateMachine(typeof(BIKJNIAMLLN))]
	public IEnumerable<KKHLHELFLNI> AAHOAEOEGBI(Exception DADIPHEHDBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x7C30A40", Offset = "0x7C2FE40", VA = "0x187C30A40", Slot = "8")]
	public string LKFDCEEKHOJ(Exception? DADIPHEHDBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x7C30730", Offset = "0x7C2FB30", VA = "0x187C30730")]
	private string LIEDIEAHMLE(AggregateException JFCJJJCCDOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x7C30B90", Offset = "0x7C2FF90", VA = "0x187C30B90")]
	private void NMCBEGMPFOM(Type NIECELIGEPL, int HKJCJLGBMOM, CABJMDHPFFL? DACGCJPJGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x7C2FF80", Offset = "0x7C2F380", VA = "0x187C2FF80")]
	private void COHAJHIHDEE(Type NIECELIGEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x7C303D0", Offset = "0x7C2F7D0", VA = "0x187C303D0")]
	private void FAPPOPDCEKO(Type NIECELIGEPL, LFOICBAFJGI HMEAFCHDBHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x7C30F40", Offset = "0x7C30340", VA = "0x187C30F40")]
	private static int PFKNNOFOKOL(Type NIECELIGEPL, Dictionary<Type, int> GIPOGJJNGIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x3152610", Offset = "0x3151A10", VA = "0x183152610")]
	private static bool DFHBDEGHABM<TVal>(MIPLIGONKNP<TVal> BMKDAHEBDHE, Type NIECELIGEPL, [Out] TVal KBGCCIOIGBD) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x7C2FEA0", Offset = "0x7C2F2A0", VA = "0x187C2FEA0")]
	[CompilerGenerated]
	internal static int BEGIJGLFOAH(Type JCGAHLDLKGP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public struct MBBDEMCCEJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public readonly KKHLHELFLNI BMMPDABBJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public readonly string FOIJFGEECEJ;

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x7C41180", Offset = "0x7C40580", VA = "0x187C41180")]
	public MBBDEMCCEJA(string KMIFKCIEOPL, KKHLHELFLNI HKJCJLGBMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x7C410E0", Offset = "0x7C404E0", VA = "0x187C410E0")]
	public string COBOACDJHMF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public class MBLNBFNLDAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	private readonly CDIHIOEBGKL LOHJEJBMJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	private string MBNFJILOMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	private long? JOIMHEAAKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	private long? LHGGBPEJMFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	private long? LNKDIMMEPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	private string MCBEGGHJHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	private JBLLOOMMFJC CGHEECJFAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	private long? NOGGJOAOJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	private bool FEMDHMOBLEA;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public string JNBLNPIJHEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public long IMIDPFKKOIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x7C41B90", Offset = "0x7C40F90", VA = "0x187C41B90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public long LOAIIAPAPCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x7C41290", Offset = "0x7C40690", VA = "0x187C41290")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public long HPIIPLKHOLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x7C415C0", Offset = "0x7C409C0", VA = "0x187C415C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public string MPHGGLNFJKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x7C41B50", Offset = "0x7C40F50", VA = "0x187C41B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public JBLLOOMMFJC LJFLEIDNBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xC07FD0", Offset = "0xC073D0", VA = "0x180C07FD0")]
		get
		{
			return default(JBLLOOMMFJC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x7C411A0", Offset = "0x7C405A0", VA = "0x187C411A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public long NAJNFJJHCGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x7C41F70", Offset = "0x7C41370", VA = "0x187C41F70")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x7C41FD0", Offset = "0x7C413D0", VA = "0x187C41FD0")]
	[UnityEngine.Scripting.Preserve]
	public MBLNBFNLDAN([IBJCGEMJMJL(null)] CDIHIOEBGKL LOHJEJBMJCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x7C412F0", Offset = "0x7C406F0", VA = "0x187C412F0")]
	private void HGCHPFIOJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x7C41620", Offset = "0x7C40A20", VA = "0x187C41620")]
	public void KKIJNNAMHCF(long FFFLOIOFAMB, long OGHBKCHPPKA, [Optional] long? KGGKGOKAJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x7C41AB0", Offset = "0x7C40EB0", VA = "0x187C41AB0")]
	public void LGLBKGIPAGN(long KGGKGOKAJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x7C41540", Offset = "0x7C40940", VA = "0x187C41540")]
	public void IGLOAGBAAAJ(string AEDDPJHJGBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x7C41BF0", Offset = "0x7C40FF0", VA = "0x187C41BF0")]
	public void OFLGLBAHJEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
internal class LGACCJIPMFL : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private struct GFLOEPCPDID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public AsyncTaskMethodBuilder<KKBOOBAMIML> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public KKBOOBAMIML roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public LGACCJIPMFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private TaskAwaiter<FJGBFJOGCIJ.FACBLMDCNMH<KKBOOBAMIML>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x7C37C80", Offset = "0x7C37080", VA = "0x187C37C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x7C381C0", Offset = "0x7C375C0", VA = "0x187C381C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private struct GPDPPEDJPPO<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private sealed class GBPEBAFJEON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public KKBOOBAMIML roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public GBPEBAFJEON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x7C37010", Offset = "0x7C36410", VA = "0x187C37010")]
		internal KKBOOBAMIML GPFNIFAOLJM(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private struct NCKNDJNPJML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public AsyncTaskMethodBuilder<FJGBFJOGCIJ.FACBLMDCNMH<KKBOOBAMIML>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public KKBOOBAMIML roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public LGACCJIPMFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private JEBNFPBGHGM <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private TaskAwaiter<FJGBFJOGCIJ.FACBLMDCNMH<KKBOOBAMIML>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x7C44170", Offset = "0x7C43570", VA = "0x187C44170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x7C44780", Offset = "0x7C43B80", VA = "0x187C44780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private struct HBCAOHKJCEE<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public LGACCJIPMFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x4592AC0", Offset = "0x4591EC0", VA = "0x184592AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x3CEAD30", Offset = "0x3CEA130", VA = "0x183CEAD30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private struct JOICGPPBBAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public LGACCJIPMFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x7C3C7B0", Offset = "0x7C3BBB0", VA = "0x187C3C7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x7C3C970", Offset = "0x7C3BD70", VA = "0x187C3C970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private sealed class IJMHICPNOGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public IJMHICPNOGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x7C3B180", Offset = "0x7C3A580", VA = "0x187C3B180")]
		internal object HABMPLLPDBH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x7C3B1E0", Offset = "0x7C3A5E0", VA = "0x187C3B1E0")]
		internal bool KFFPBGCLADA(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private sealed class OAPBDDPIPPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public OAPBDDPIPPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x7C44D30", Offset = "0x7C44130", VA = "0x187C44D30")]
		internal object IIJKJKPNOHA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private sealed class AHKFMHKNONI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public AHKFMHKNONI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F7B0", Offset = "0x7C2EBB0", VA = "0x187C2F7B0")]
		internal object IDCIDKCGNAM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private sealed class ADBBIMFAMNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public ADBBIMFAMNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F740", Offset = "0x7C2EB40", VA = "0x187C2F740")]
		internal object CIEANLPGNBA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private sealed class MFLCEOGPIKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public LGACCJIPMFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public MFLCEOGPIKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x7C428A0", Offset = "0x7C41CA0", VA = "0x187C428A0")]
		internal object HHJBKAHCBLF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	private static readonly Guid KCGKLKEPKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public readonly GPIPDBGGDOE NBDKCOPBDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	private readonly FJGBFJOGCIJ HMFKALHBDAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	private readonly KOCGNCDMOPN MGMCFGLJIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	private readonly EDKLJOILFEA KMMOJIJCKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	private bool NENBNKLNDHI;

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x7C408A0", Offset = "0x7C3FCA0", VA = "0x187C408A0")]
	public LGACCJIPMFL(GPIPDBGGDOE FFEBDLHFDKK, FJGBFJOGCIJ HMFKALHBDAA, KOCGNCDMOPN MGMCFGLJIGI, EDKLJOILFEA KMMOJIJCKBA, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F9D0", Offset = "0x7C3EDD0", VA = "0x187C3F9D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x7C3FC20", Offset = "0x7C3F020", VA = "0x187C3FC20")]
	public void HKHGNPDOKNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F9E0", Offset = "0x7C3EDE0", VA = "0x187C3F9E0")]
	public void EOLPKLNFHGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F910", Offset = "0x7C3ED10", VA = "0x187C3F910")]
	public void CGNFCNLOJIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x7C3FE50", Offset = "0x7C3F250", VA = "0x187C3FE50")]
	[AsyncStateMachine(typeof(GFLOEPCPDID))]
	internal Task<KKBOOBAMIML> JDNEDLMJOAG(FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, KKBOOBAMIML FNHJGBHLJLO, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x347DD10", Offset = "0x347D110", VA = "0x18347DD10")]
	private static byte[] NIEEBDLCOJJ<T>(T MIALAMIFNLM) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x347D920", Offset = "0x347CD20", VA = "0x18347D920")]
	private static T KOOOLLKEHFJ<T>(MessageParser<T> KBFPIODOOCM, byte[] MIALAMIFNLM, T HILNFBANAMD) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x7C405B0", Offset = "0x7C3F9B0", VA = "0x187C405B0")]
	[AsyncStateMachine(typeof(NCKNDJNPJML))]
	private Task<FJGBFJOGCIJ.FACBLMDCNMH<KKBOOBAMIML>> PCKNOIEGACI(KKBOOBAMIML FNHJGBHLJLO, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x347DA70", Offset = "0x347CE70", VA = "0x18347DA70")]
	[AsyncStateMachine(typeof(HBCAOHKJCEE<>))]
	internal Task<T> LHHBGMDAJAO<T>(CancellationToken DGLOFFGGICM, Func<CancellationToken, Task<T>> PAOHIJCDFLP, int GCINMLANHNP = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x7C400C0", Offset = "0x7C3F4C0", VA = "0x187C400C0")]
	[AsyncStateMachine(typeof(JOICGPPBBAI))]
	internal Task LHHBGMDAJAO(CancellationToken DGLOFFGGICM, Func<CancellationToken, Task> PAOHIJCDFLP, int GCINMLANHNP = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x7C403D0", Offset = "0x7C3F7D0", VA = "0x187C403D0")]
	public MDEFBAINCHB OIOHKCCICJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x7C40350", Offset = "0x7C3F750", VA = "0x187C40350")]
	public FGCFMBILFGM NHGHOCKAECB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F710", Offset = "0x7C3EB10", VA = "0x187C3F710")]
	public IBCNCFMBDFO CDHJOJFGMBD([Optional] IBCMILIKEJG? DDKJAEALMGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x7C401F0", Offset = "0x7C3F5F0", VA = "0x187C401F0")]
	public void NAKHPHKCGKF(Func<Guid, bool> PKCGFPJGAEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x7C3FFB0", Offset = "0x7C3F3B0", VA = "0x187C3FFB0")]
	public void KDPLFFCCIFC(Func<Guid, bool> KOGBGLOGAFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x7C3FAA0", Offset = "0x7C3EEA0", VA = "0x187C3FAA0")]
	public Guid FKBAAGJCFKA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x7C404A0", Offset = "0x7C3F8A0", VA = "0x187C404A0")]
	public void OMBHMMCDFMM(Guid LDIJEIIPGKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x7C406F0", Offset = "0x7C3FAF0", VA = "0x187C406F0")]
	public void PHHOOCMICLB(KKBOOBAMIML EGKHLAKCBOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x7C3FD40", Offset = "0x7C3F140", VA = "0x187C3FD40")]
	public void IEGNOINNOMJ(string ELPDJAJBGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x347D830", Offset = "0x347CC30", VA = "0x18347D830")]
	private T ECDIJKIJKOB<T>(T KBGCCIOIGBD) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x7C40450", Offset = "0x7C3F850", VA = "0x187C40450")]
	public void OKHKDMFIAEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x347DD20", Offset = "0x347D120", VA = "0x18347DD20")]
	[CompilerGenerated]
	internal static string PDJIPKPBPIM<T>(byte[] HECJPBMFJGG, int FCDJJGFAGNO, GPDPPEDJPPO<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
internal sealed class PENMICHADGI : GPIPDBGGDOE
{
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private sealed class IINANFOELCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public IINANFOELCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x7C3B110", Offset = "0x7C3A510", VA = "0x187C3B110")]
		internal object MMFIKBIHOOK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct OEBHGCCDMBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public PENMICHADGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public LGACCJIPMFL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private IBBHMOLEKHK <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private FGCFMBILFGM <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x7C44D90", Offset = "0x7C44190", VA = "0x187C44D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x7C456E0", Offset = "0x7C44AE0", VA = "0x187C456E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private struct CDIJBOJGCND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public PENMICHADGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		private bool <omShouldBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		private TaskAwaiter<EPDFKONBMMJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		private TaskAwaiter<int> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x7C32A10", Offset = "0x7C31E10", VA = "0x187C32A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x7C33140", Offset = "0x7C32540", VA = "0x187C33140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct OMLFMLDFDLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public PENMICHADGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		private TaskAwaiter<JHNKENAKGMI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x7C48390", Offset = "0x7C47790", VA = "0x187C48390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x7C486A0", Offset = "0x7C47AA0", VA = "0x187C486A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private sealed class HIGMCIBJAFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public IBBHMOLEKHK presence;

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public HIGMCIBJAFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x7C3A6B0", Offset = "0x7C39AB0", VA = "0x187C3A6B0")]
		internal object MABPOCDHBEN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	private static readonly IBCMILIKEJG MMJIIFBIEIP;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	private static readonly IBCMILIKEJG MKABBCBOAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	private readonly HLOJEJEEEIJ JIPCODKNIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	private readonly GDBFIEIFOFD BIHCMIGBKEI;

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x7C494E0", Offset = "0x7C488E0", VA = "0x187C494E0")]
	public PENMICHADGI(HLOJEJEEEIJ JIPCODKNIPN, GDBFIEIFOFD BIHCMIGBKEI, Guid EHMIFANHMPO, CFEMEJBKCKD GHFCFJHMPHJ, OKCNIPGMDHK PNMPBHPCACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x7C490B0", Offset = "0x7C484B0", VA = "0x187C490B0", Slot = "7")]
	[AsyncStateMachine(typeof(OEBHGCCDMBG))]
	protected override Task DGGCIPIGFBN(LGACCJIPMFL OKNMIEHKKPG, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x7C49300", Offset = "0x7C48700", VA = "0x187C49300")]
	[AsyncStateMachine(typeof(CDIJBOJGCND))]
	private Task JBCADINJCCP(CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x7C491F0", Offset = "0x7C485F0", VA = "0x187C491F0")]
	[AsyncStateMachine(typeof(OMLFMLDFDLD))]
	private Task<int> GNEHCNEIMKK(CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x7C48ED0", Offset = "0x7C482D0", VA = "0x187C48ED0")]
	private IBBHMOLEKHK DANBGJFACLP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal class BIPDBNACGLK : GPIPDBGGDOE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private struct CDDEIMIALOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public BIPDBNACGLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public LGACCJIPMFL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private TaskAwaiter<AKEHIKAMMJM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x7C32010", Offset = "0x7C31410", VA = "0x187C32010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x7C329B0", Offset = "0x7C31DB0", VA = "0x187C329B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	private readonly int KGLJBMKFNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	private readonly JICNBBCNCAC HNGPDEBEPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public readonly long MBHFNFGPIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public readonly long GODDAHPEIHG;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public AKEHIKAMMJM GEHFHAKBAKP
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x9555D0", Offset = "0x9549D0", VA = "0x1809555D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x955500", Offset = "0x954900", VA = "0x180955500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x7C31E60", Offset = "0x7C31260", VA = "0x187C31E60")]
	public BIPDBNACGLK(Guid EHMIFANHMPO, CFEMEJBKCKD GHFCFJHMPHJ, OKCNIPGMDHK PNMPBHPCACL, int KGLJBMKFNLO, JICNBBCNCAC HNGPDEBEPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x7C31D40", Offset = "0x7C31140", VA = "0x187C31D40", Slot = "7")]
	[AsyncStateMachine(typeof(CDDEIMIALOH))]
	protected override Task DGGCIPIGFBN(LGACCJIPMFL OKNMIEHKKPG, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal abstract class DLAAIOANIIA : GPIPDBGGDOE
{
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private sealed class JPFEDBODOCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public DLAAIOANIIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public HDMJEPDNFFH playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public JPFEDBODOCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CA60", Offset = "0x7C3BE60", VA = "0x187C3CA60")]
		internal Task OOBOACCBIEH(FGFDKLMANEA<string>.ICBJPFEBGDJ postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x7C3C9D0", Offset = "0x7C3BDD0", VA = "0x187C3C9D0")]
		internal object ANKEGNJDMLN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct GEPOOGAIJGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public DLAAIOANIIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public LGACCJIPMFL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private JPFEDBODOCA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x7C37450", Offset = "0x7C36850", VA = "0x187C37450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x7C37C20", Offset = "0x7C37020", VA = "0x187C37C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct HDLCCHIOAGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public HDMJEPDNFFH playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public DLAAIOANIIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x7C399B0", Offset = "0x7C38DB0", VA = "0x187C399B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x7C39F60", Offset = "0x7C39360", VA = "0x187C39F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x7C34530", Offset = "0x7C33930", VA = "0x187C34530")]
	public DLAAIOANIIA(Guid EHMIFANHMPO, CFEMEJBKCKD GHFCFJHMPHJ, OKCNIPGMDHK PNMPBHPCACL, string KEFEFOJNANB, FDFGBGCLFKC MNGFNEKIDGN, bool JMBMPMPJDFC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x7C342B0", Offset = "0x7C336B0", VA = "0x187C342B0", Slot = "7")]
	[AsyncStateMachine(typeof(GEPOOGAIJGK))]
	protected override Task DGGCIPIGFBN(LGACCJIPMFL OKNMIEHKKPG, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task CGEGANKPCOH(LGACCJIPMFL OKNMIEHKKPG, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x7C343F0", Offset = "0x7C337F0", VA = "0x187C343F0")]
	[AsyncStateMachine(typeof(HDLCCHIOAGI))]
	private Task EEOOADNEGJD(IDisposable NBPLPKFHNIH, HDMJEPDNFFH KHBOOKEAAOD, FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal class HBHOPKPPHAM : GPIPDBGGDOE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct HFOLIKHDNIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public HBHOPKPPHAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public LGACCJIPMFL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private TaskAwaiter<FIHJMIFDKFO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x7C3A0E0", Offset = "0x7C394E0", VA = "0x187C3A0E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x7C3A650", Offset = "0x7C39A50", VA = "0x187C3A650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400042F")]
	private readonly DPOOOLNKMNK KEGDNPBCBNK;

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x7C39910", Offset = "0x7C38D10", VA = "0x187C39910")]
	public HBHOPKPPHAM(Guid EHMIFANHMPO, CFEMEJBKCKD GHFCFJHMPHJ, OKCNIPGMDHK PNMPBHPCACL, DPOOOLNKMNK KEGDNPBCBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x7C39830", Offset = "0x7C38C30", VA = "0x187C39830", Slot = "6")]
	protected override string DKGFFAOJPND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x7C39710", Offset = "0x7C38B10", VA = "0x187C39710", Slot = "7")]
	[AsyncStateMachine(typeof(HFOLIKHDNIC))]
	protected override Task DGGCIPIGFBN(LGACCJIPMFL OKNMIEHKKPG, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
internal abstract class GPIPDBGGDOE : JEEDOKEHIEI
{
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	public delegate Task ILHKDDEOLFL(FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private sealed class KIGIDJNPHNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public GPIPDBGGDOE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public KIGIDJNPHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CAA0", Offset = "0x7C3BEA0", VA = "0x187C3CAA0")]
		internal Task MMEEHMDAIMD(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private sealed class APIKNLCDIPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public KIGIDJNPHNI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public APIKNLCDIPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x7C2FB20", Offset = "0x7C2EF20", VA = "0x187C2FB20")]
		internal object GDPGBMAMEIJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private struct KMDEJHDFNAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public GPIPDBGGDOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public Func<GPIPDBGGDOE, FGFDKLMANEA<string>.ICBJPFEBGDJ, LGACCJIPMFL> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private KIGIDJNPHNI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		private LGACCJIPMFL <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		private TaskAwaiter<KKBOOBAMIML> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CCB0", Offset = "0x7C3C0B0", VA = "0x187C3CCB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x7C3DE70", Offset = "0x7C3D270", VA = "0x187C3DE70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private struct OKDNJDHAADA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public Func<CancellationToken, Task> createDriverTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public Func<CancellationToken, Task> originalTaskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private CancellationTokenSource <driverCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private Task <driverTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private Task <originalTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x7C46720", Offset = "0x7C45B20", VA = "0x187C46720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x7C471C0", Offset = "0x7C465C0", VA = "0x187C471C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct LACOEBDHBMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public GPIPDBGGDOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x7C3E130", Offset = "0x7C3D530", VA = "0x187C3E130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x7C3E490", Offset = "0x7C3D890", VA = "0x187C3E490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public readonly Guid FLJLEJEOHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public readonly ByteString IBJPEBFFPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public readonly OKCNIPGMDHK DOAKJIFMOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	protected readonly string OMJAHHBGIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	private readonly CFEMEJBKCKD GHFCFJHMPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	private readonly bool JMBMPMPJDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400043E")]
	private readonly Queue<ILHKDDEOLFL> OJIGAPDONEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400043F")]
	private readonly DFIENIKFOMH KICIKPCOPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000440")]
	private readonly FDFGBGCLFKC MNGFNEKIDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000441")]
	private bool ECJMKKGFKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public JBLLOOMMFJC GCBKJIIOIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public JBLLOOMMFJC DMOEKBIJOCL;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public CFEMEJBKCKD JDBIGNOPBHA
	{
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x94BDD0", Offset = "0x94B1D0", VA = "0x18094BDD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public JJKJBCNAAJM MNHGCFJHHHI
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x7C38BE0", Offset = "0x7C37FE0", VA = "0x187C38BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public JBCPMCBEPKG AABBPKBJLHN
	{
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x7C39200", Offset = "0x7C38600", VA = "0x187C39200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public FBKMDCBFBII IELHGPMHDJI
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x7C38DB0", Offset = "0x7C381B0", VA = "0x187C38DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event LLLEILNOHAD DKGAKCAMIEP
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x7C390E0", Offset = "0x7C384E0", VA = "0x187C390E0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x7C38FA0", Offset = "0x7C383A0", VA = "0x187C38FA0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x7C39250", Offset = "0x7C38650", VA = "0x187C39250")]
	protected GPIPDBGGDOE(Guid EHMIFANHMPO, CFEMEJBKCKD GHFCFJHMPHJ, OKCNIPGMDHK PNMPBHPCACL, string KEFEFOJNANB, FDFGBGCLFKC MNGFNEKIDGN, bool JMBMPMPJDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x7C38920", Offset = "0x7C37D20", VA = "0x187C38920", Slot = "6")]
	protected virtual string DKGFFAOJPND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x7C38B80", Offset = "0x7C37F80", VA = "0x187C38B80")]
	public void HCLIDNPLDDC(ILHKDDEOLFL KBKNECNKOFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x7C38F80", Offset = "0x7C38380", VA = "0x187C38F80")]
	protected void JPFMKGIKMLF(float FCEAHINHNGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x7C38E30", Offset = "0x7C38230", VA = "0x187C38E30")]
	[AsyncStateMachine(typeof(KMDEJHDFNAN))]
	public Task IKIFLPOJPIB(CancellationToken LAEIHJHNGEK, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, [Optional] Func<GPIPDBGGDOE, FGFDKLMANEA<string>.ICBJPFEBGDJ, LGACCJIPMFL> EIPJBMOCFKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x7C38A50", Offset = "0x7C37E50", VA = "0x187C38A50")]
	[AsyncStateMachine(typeof(OKDNJDHAADA))]
	private static Task GJIHJCIEDLC(Func<CancellationToken, Task> AEHHMEEBAGJ, Func<CancellationToken, Task> FJOGFPABEOH, CancellationToken DGLOFFGGICM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x7C38C30", Offset = "0x7C38030", VA = "0x187C38C30")]
	private void IADBIPKGCNN(bool JHGFMOPHGIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x7C386F0", Offset = "0x7C37AF0", VA = "0x187C386F0")]
	private void AKCOHOBDLOM(LGACCJIPMFL OKNMIEHKKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task DGGCIPIGFBN(LGACCJIPMFL OKNMIEHKKPG, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x7C38FC0", Offset = "0x7C383C0", VA = "0x187C38FC0")]
	[AsyncStateMachine(typeof(LACOEBDHBMI))]
	private Task NHJECLABBBJ(FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x7C39100", Offset = "0x7C38500", VA = "0x187C39100")]
	public KKBOOBAMIML OBPOADBCOIG(JEBNFPBGHGM JHIDIAHPODI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x7C38960", Offset = "0x7C37D60", VA = "0x187C38960")]
	[CompilerGenerated]
	private Task DKIKANDAKJN(CancellationToken CHBEBLKFDBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x7C39180", Offset = "0x7C38580", VA = "0x187C39180")]
	[CompilerGenerated]
	private object ODMFCCMPGID()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
internal sealed class MNGIPKDPBOH : DLAAIOANIIA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private struct PBKPLLKHGBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public MNGIPKDPBOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public LGACCJIPMFL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		private ONLCNDEELLL <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private FGCFMBILFGM <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x7C48710", Offset = "0x7C47B10", VA = "0x187C48710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x7C48E70", Offset = "0x7C48270", VA = "0x187C48E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	private readonly HLOJEJEEEIJ KJMNBFJKBLK;

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x7C42F00", Offset = "0x7C42300", VA = "0x187C42F00")]
	public MNGIPKDPBOH(Guid EHMIFANHMPO, CFEMEJBKCKD GHFCFJHMPHJ, HLOJEJEEEIJ KJMNBFJKBLK, OKCNIPGMDHK PNMPBHPCACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x7C42DB0", Offset = "0x7C421B0", VA = "0x187C42DB0", Slot = "8")]
	[AsyncStateMachine(typeof(PBKPLLKHGBM))]
	protected override Task CGEGANKPCOH(LGACCJIPMFL OKNMIEHKKPG, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
internal class ANEDJOBPDGC : GPIPDBGGDOE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct NALMPGOFLEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public ANEDJOBPDGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public LGACCJIPMFL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		private TaskAwaiter<FIHJMIFDKFO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x7C43D60", Offset = "0x7C43160", VA = "0x187C43D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x7C44110", Offset = "0x7C43510", VA = "0x187C44110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400046F")]
	private readonly string DAJOPLFHCAI;

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x7C2FA70", Offset = "0x7C2EE70", VA = "0x187C2FA70")]
	public ANEDJOBPDGC(Guid EHMIFANHMPO, CFEMEJBKCKD GHFCFJHMPHJ, OKCNIPGMDHK PNMPBHPCACL, string DAJOPLFHCAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x7C2F960", Offset = "0x7C2ED60", VA = "0x187C2F960", Slot = "7")]
	[AsyncStateMachine(typeof(NALMPGOFLEC))]
	protected override Task DGGCIPIGFBN(LGACCJIPMFL OKNMIEHKKPG, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
internal class JEDGKNBKHDA : DLAAIOANIIA
{
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private sealed class BDGKHJCFPOG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012A")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000482")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000483")]
			public AsyncTaskMethodBuilder<KKBOOBAMIML> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000484")]
			public BDGKHJCFPOG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000485")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000486")]
			private TaskAwaiter<FIHJMIFDKFO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000487")]
			private TaskAwaiter<KKBOOBAMIML> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000527")]
			[Cpp2IlInjected.Address(RVA = "0x7C4AF30", Offset = "0x7C4A330", VA = "0x187C4AF30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000528")]
			[Cpp2IlInjected.Address(RVA = "0x7C4B3F0", Offset = "0x7C4A7F0", VA = "0x187C4B3F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public JEDGKNBKHDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public IBCNCFMBDFO serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public MCIKJBCGIFM roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public MDEFBAINCHB uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public NKALECBGCLE roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public BDGKHJCFPOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x7C2FBE0", Offset = "0x7C2EFE0", VA = "0x187C2FBE0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<KKBOOBAMIML> DHOBJFBIAOB(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct OEMLCFNLJKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public JEDGKNBKHDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public LGACCJIPMFL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		private BDGKHJCFPOG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		private ONLCNDEELLL <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		private FGCFMBILFGM <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		private KKBOOBAMIML <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		private TaskAwaiter<KKBOOBAMIML> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x7C45740", Offset = "0x7C44B40", VA = "0x187C45740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x7C466C0", Offset = "0x7C45AC0", VA = "0x187C466C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	private static readonly IBCMILIKEJG MMJIIFBIEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000478")]
	private readonly int NCACHKHPMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000479")]
	[CanBeNull]
	private readonly ABMKIBHCAFE FPKAICKNAPP;

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x7C3BF10", Offset = "0x7C3B310", VA = "0x187C3BF10")]
	public JEDGKNBKHDA(Guid EHMIFANHMPO, CFEMEJBKCKD GHFCFJHMPHJ, int NCACHKHPMEG, ABMKIBHCAFE FPKAICKNAPP, OKCNIPGMDHK PNMPBHPCACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x7C3BA50", Offset = "0x7C3AE50", VA = "0x187C3BA50", Slot = "8")]
	[AsyncStateMachine(typeof(OEMLCFNLJKB))]
	protected override Task CGEGANKPCOH(LGACCJIPMFL OKNMIEHKKPG, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x7C3BB90", Offset = "0x7C3AF90", VA = "0x187C3BB90")]
	private void HKBPNCMNCGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x7C3BC90", Offset = "0x7C3B090", VA = "0x187C3BC90")]
	private void NKNCNDLCPIK(FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, ONLCNDEELLL EDKKLGLMFKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
internal abstract class GCLDIMIBKMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public readonly GPIPDBGGDOE NBDKCOPBDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public readonly LGACCJIPMFL FGMDAMLFBIN;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public JJKJBCNAAJM MNHGCFJHHHI
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x7C370F0", Offset = "0x7C364F0", VA = "0x187C370F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public FBKMDCBFBII IELHGPMHDJI
	{
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x7C37140", Offset = "0x7C36540", VA = "0x187C37140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x7C372F0", Offset = "0x7C366F0", VA = "0x187C372F0")]
	protected GCLDIMIBKMA(LGACCJIPMFL OKNMIEHKKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x7C371D0", Offset = "0x7C365D0", VA = "0x187C371D0")]
	protected void IEGNOINNOMJ(string ELPDJAJBGCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
internal struct MAFPIAFLMCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public Dictionary<Guid, List<EOAHMNKFLEL>> EOKPKJDCIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public Dictionary<Guid, List<EOAHMNKFLEL>> GILMABHAJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public Dictionary<Guid, List<EOAHMNKFLEL>> IPCIHBPIPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public List<Guid> LEFKJBLCFMD;

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x7C40AD0", Offset = "0x7C3FED0", VA = "0x187C40AD0")]
	public static MAFPIAFLMCC NPPDIJEBOHO(JJKJBCNAAJM MOKEOOADLAP, JBLLOOMMFJC FFFGJNJFNPO, BPPINHJEEIJ CAILOKLPAOE)
	{
		return default(MAFPIAFLMCC);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200012F")]
internal struct CIONLJJCMNN
{
	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0")]
	public static CIONLJJCMNN OILMBKHFGKP()
	{
		return default(CIONLJJCMNN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
internal struct GCMEINGJNIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public readonly EPDFKONBMMJ OCNEFBOFEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public readonly KOLBKODMCOP OILMJLBENOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public readonly string HDFGNIINOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public readonly IReadOnlyList<HFBGJKKCMEJ> CJHJCCPNCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public readonly DDDGOPGHMJC LBDLMMONJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public readonly DDDGOPGHMJC BKNHKBPEOPF;

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public bool LLLANJJNLBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x7C37350", Offset = "0x7C36750", VA = "0x187C37350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x7C373C0", Offset = "0x7C367C0", VA = "0x187C373C0")]
	public GCMEINGJNIC(EPDFKONBMMJ OCNEFBOFEOP, KOLBKODMCOP OILMJLBENOE, string HDFGNIINOHH, IReadOnlyList<HFBGJKKCMEJ> CJHJCCPNCMF, DDDGOPGHMJC LBDLMMONJCN, DDDGOPGHMJC BKNHKBPEOPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
internal struct GHELAHOMIBN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	private readonly LGACCJIPMFL OKNMIEHKKPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	private readonly Guid LDIJEIIPGKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	private bool JHGFMOPHGIB;

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x7C38240", Offset = "0x7C37640", VA = "0x187C38240")]
	public static GHELAHOMIBN FKBAAGJCFKA(LGACCJIPMFL OKNMIEHKKPG)
	{
		return default(GHELAHOMIBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0xFE00B0", Offset = "0xFDF4B0", VA = "0x180FE00B0")]
	public void JIEDCNHFBDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x7C38230", Offset = "0x7C37630", VA = "0x187C38230", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x7C38550", Offset = "0x7C37950", VA = "0x187C38550")]
	private GHELAHOMIBN(LGACCJIPMFL OKNMIEHKKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x7C38310", Offset = "0x7C37710", VA = "0x187C38310")]
	private void OMBHMMCDFMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x7C38270", Offset = "0x7C37670", VA = "0x187C38270")]
	private Func<Guid, bool> OJGNELBACHB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal class FGCFMBILFGM : GCLDIMIBKMA, JEEDOKEHIEI
{
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	public delegate Task<JBLLOOMMFJC> IKABHLDKEMD(BPPINHJEEIJ GIDGOODJFLJ, LGLIHLIPDKB KMMLKNBFAAP, DFIENIKFOMH FKKJJFDOIBC, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct FPAEEOGCNCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public FGCFMBILFGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public HLOJEJEEEIJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private GHELAHOMIBN <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private TaskAwaiter<KKBOOBAMIML> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x7C366E0", Offset = "0x7C35AE0", VA = "0x187C366E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x7C36FB0", Offset = "0x7C363B0", VA = "0x187C36FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct JJKCOMFENNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public AsyncTaskMethodBuilder<KKBOOBAMIML> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public FGCFMBILFGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public HLOJEJEEEIJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private TaskAwaiter<KKBOOBAMIML> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x7C3C200", Offset = "0x7C3B600", VA = "0x187C3C200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x7C3C630", Offset = "0x7C3BA30", VA = "0x187C3C630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private struct CPNGJGEOCEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public FGCFMBILFGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public HLOJEJEEEIJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x7C336C0", Offset = "0x7C32AC0", VA = "0x187C336C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x7C33D00", Offset = "0x7C33100", VA = "0x187C33D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private sealed class INGLBPKFLAJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000138")]
		private struct <<LoadRoomLocal>b__1>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004D0")]
			public AsyncTaskMethodBuilder<GCMEINGJNIC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004D1")]
			public INGLBPKFLAJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004D2")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004D3")]
			private GCMEINGJNIC <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40004D4")]
			private TaskAwaiter<JBLLOOMMFJC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40004D5")]
			private TaskAwaiter<GCMEINGJNIC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000571")]
			[Cpp2IlInjected.Address(RVA = "0x7C4A0C0", Offset = "0x7C494C0", VA = "0x187C4A0C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000572")]
			[Cpp2IlInjected.Address(RVA = "0x7C4A820", Offset = "0x7C49C20", VA = "0x187C4A820", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000139")]
		private struct <<LoadRoomLocal>b__3>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004D6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004D7")]
			public AsyncTaskMethodBuilder<BPPINHJEEIJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004D8")]
			public INGLBPKFLAJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004D9")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004DA")]
			private BPPINHJEEIJ <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004DB")]
			private TaskAwaiter<JBLLOOMMFJC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004DC")]
			private TaskAwaiter<BPPINHJEEIJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000573")]
			[Cpp2IlInjected.Address(RVA = "0x7C4A890", Offset = "0x7C49C90", VA = "0x187C4A890", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0x7C4AEC0", Offset = "0x7C4A2C0", VA = "0x187C4AEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public FGCFMBILFGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public HLOJEJEEEIJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public DFIENIKFOMH preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public DFIENIKFOMH downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public GCMEINGJNIC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public DFIENIKFOMH postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public BPPINHJEEIJ phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public POCLACLHDNA.FKMGIKDICFJ <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public INGLBPKFLAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x7C3B7B0", Offset = "0x7C3ABB0", VA = "0x187C3B7B0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<GCMEINGJNIC> LCDMLBLIDPG(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x7C3B530", Offset = "0x7C3A930", VA = "0x187C3B530")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<BPPINHJEEIJ> EKPPCONECJK(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x7C3B4F0", Offset = "0x7C3A8F0", VA = "0x187C3B4F0")]
		internal void CJJEKKNJNOK(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x7C3B650", Offset = "0x7C3AA50", VA = "0x187C3B650")]
		internal Task JMFHKLMAKKL(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x7C3B8F0", Offset = "0x7C3ACF0", VA = "0x187C3B8F0")]
		internal Task NPDBBMBGFON(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private struct MPBAMBDIBDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public FGCFMBILFGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public HLOJEJEEEIJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private INGLBPKFLAJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private TaskAwaiter<GCMEINGJNIC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private TaskAwaiter<BPPINHJEEIJ> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x7C42FB0", Offset = "0x7C423B0", VA = "0x187C42FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x7C43D00", Offset = "0x7C43100", VA = "0x187C43D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct OKHFNBIIBLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public FGCFMBILFGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public BPPINHJEEIJ phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public DFIENIKFOMH postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private TaskAwaiter<JBLLOOMMFJC> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		private LGLIHLIPDKB <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x7C47220", Offset = "0x7C46620", VA = "0x187C47220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x7C48330", Offset = "0x7C47730", VA = "0x187C48330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private struct HJPHBLIGJJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public FGCFMBILFGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x7C3A7F0", Offset = "0x7C39BF0", VA = "0x187C3A7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x7C3B0B0", Offset = "0x7C3A4B0", VA = "0x187C3B0B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private struct PMNOIEPGIOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public FGCFMBILFGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public BPPINHJEEIJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public DFIENIKFOMH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		private TaskAwaiter<JBLLOOMMFJC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x7C49670", Offset = "0x7C48A70", VA = "0x187C49670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x7C4A000", Offset = "0x7C49400", VA = "0x187C4A000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private struct LDEILIPBMHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public AsyncTaskMethodBuilder<JBLLOOMMFJC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public FGCFMBILFGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public BPPINHJEEIJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public DFIENIKFOMH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private TaskAwaiter<JBLLOOMMFJC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x7C3E4F0", Offset = "0x7C3D8F0", VA = "0x187C3E4F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x7C3F6A0", Offset = "0x7C3EAA0", VA = "0x187C3F6A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private struct OCEINLAHINN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public AsyncTaskMethodBuilder<JBLLOOMMFJC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public FGCFMBILFGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public BPPINHJEEIJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public DFIENIKFOMH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public LGLIHLIPDKB timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private TaskAwaiter<JBLLOOMMFJC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x7C5EF10", Offset = "0x7C5E310", VA = "0x187C5EF10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x7C60020", Offset = "0x7C5F420", VA = "0x187C60020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct PAFBBLAODGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public AsyncTaskMethodBuilder<JBLLOOMMFJC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public FGCFMBILFGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public JBLLOOMMFJC operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public DFIENIKFOMH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public BPPINHJEEIJ deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private TaskAwaiter<JBLLOOMMFJC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x7C618A0", Offset = "0x7C60CA0", VA = "0x187C618A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x7C61AF0", Offset = "0x7C60EF0", VA = "0x187C61AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private sealed class DENPELLMILE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000143")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400052C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400052D")]
			public AsyncTaskMethodBuilder<JBLLOOMMFJC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400052E")]
			public DENPELLMILE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400052F")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000530")]
			private DJPNNBMEIAG <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			private TaskAwaiter<JBLLOOMMFJC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600058B")]
			[Cpp2IlInjected.Address(RVA = "0x7C63A40", Offset = "0x7C62E40", VA = "0x187C63A40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058C")]
			[Cpp2IlInjected.Address(RVA = "0x7C64070", Offset = "0x7C63470", VA = "0x187C64070", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public FGCFMBILFGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public BPPINHJEEIJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public DFIENIKFOMH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public IKABHLDKEMD masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public LGLIHLIPDKB timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public JBLLOOMMFJC originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public DENPELLMILE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x7C50EC0", Offset = "0x7C502C0", VA = "0x187C50EC0")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<JBLLOOMMFJC> MBNPCEKHKNC(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private struct HKEOMNKAFIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public AsyncTaskMethodBuilder<JBLLOOMMFJC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public FGCFMBILFGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public BPPINHJEEIJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public DFIENIKFOMH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public IKABHLDKEMD masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public LGLIHLIPDKB timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private DJPNNBMEIAG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private TaskAwaiter<JBLLOOMMFJC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x7C54ED0", Offset = "0x7C542D0", VA = "0x187C54ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x7C553F0", Offset = "0x7C547F0", VA = "0x187C553F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct FGIGPNOKIPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public FGCFMBILFGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public BPPINHJEEIJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public DFIENIKFOMH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private JBLLOOMMFJC <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private IEnumerator<JBLLOOMMFJC> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private TaskAwaiter<JBLLOOMMFJC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x7C52F50", Offset = "0x7C52350", VA = "0x187C52F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x7C534A0", Offset = "0x7C528A0", VA = "0x187C534A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct IBNPCIHKGLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public FGCFMBILFGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public BPPINHJEEIJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x7C55B80", Offset = "0x7C54F80", VA = "0x187C55B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x7C55E70", Offset = "0x7C55270", VA = "0x187C55E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private struct LHDAJBHHCPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public FGCFMBILFGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public BPPINHJEEIJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x7C5D010", Offset = "0x7C5C410", VA = "0x187C5D010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x7C5D240", Offset = "0x7C5C640", VA = "0x187C5D240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private sealed class EGJPOAAHAJN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000149")]
		private struct <<RoomV2LoadLogic>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000556")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000557")]
			public AsyncTaskMethodBuilder<JBLLOOMMFJC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000558")]
			public EGJPOAAHAJN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000559")]
			public BPPINHJEEIJ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400055A")]
			public DFIENIKFOMH progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400055B")]
			public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400055C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400055D")]
			private TaskAwaiter<JBLLOOMMFJC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400055E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400055F")]
			private TaskAwaiter<LNNECADLIEA> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x6000597")]
			[Cpp2IlInjected.Address(RVA = "0x7C640E0", Offset = "0x7C634E0", VA = "0x187C640E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0x7C64B80", Offset = "0x7C63F80", VA = "0x187C64B80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public FGCFMBILFGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public PJENFBHPOMD mainLoadService;

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public EGJPOAAHAJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x7C51F20", Offset = "0x7C51320", VA = "0x187C51F20")]
		[AsyncStateMachine(typeof(<<RoomV2LoadLogic>b__0>d))]
		internal Task<JBLLOOMMFJC> JKEAEEHFFDH(BPPINHJEEIJ data, LGLIHLIPDKB _, DFIENIKFOMH progressTracker, FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct PFMIFLEFIKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public FGCFMBILFGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public BPPINHJEEIJ phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public DFIENIKFOMH postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		private EGJPOAAHAJN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		private LGLIHLIPDKB <timedYielder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private TaskAwaiter<JBLLOOMMFJC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x7C62060", Offset = "0x7C61460", VA = "0x187C62060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x7C62F20", Offset = "0x7C62320", VA = "0x187C62F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private struct CCCNIHCEGEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public FGCFMBILFGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public BPPINHJEEIJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x7C4FFC0", Offset = "0x7C4F3C0", VA = "0x187C4FFC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x7C503C0", Offset = "0x7C4F7C0", VA = "0x187C503C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct KOGFPPICJJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public AsyncTaskMethodBuilder<JBLLOOMMFJC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public FGCFMBILFGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public BPPINHJEEIJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public DFIENIKFOMH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private TaskAwaiter<JBLLOOMMFJC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x7C5A250", Offset = "0x7C59650", VA = "0x187C5A250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x7C5A870", Offset = "0x7C59C70", VA = "0x187C5A870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	private readonly FDINGGDGHDL DBINMOFPALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	private readonly FDINGGDGHDL MLELNEKHKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	private readonly MBLNBFNLDAN CHKICNMGPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	private readonly LFMOOOFFMNB AIBFBNBKOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	private readonly ABJDDLLLNDI ONDEEHPFNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	private ProfilerCounterValue<int> CPJDIEAHFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	private readonly MNIAMPGIDNC EDMJCKBLFNP;

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	private CFEMEJBKCKD JDBIGNOPBHA
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x7C354F0", Offset = "0x7C348F0", VA = "0x187C354F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event LLLEILNOHAD DKGAKCAMIEP
	{
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x7C36230", Offset = "0x7C35630", VA = "0x187C36230", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x7C35AA0", Offset = "0x7C34EA0", VA = "0x187C35AA0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x7C36420", Offset = "0x7C35820", VA = "0x187C36420")]
	public FGCFMBILFGM(LGACCJIPMFL OKNMIEHKKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x7C35220", Offset = "0x7C34620", VA = "0x187C35220")]
	[AsyncStateMachine(typeof(FPAEEOGCNCA))]
	public Task HLJJAOICHFK(HLOJEJEEEIJ NEMAHPGAGLG, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x7C35DE0", Offset = "0x7C351E0", VA = "0x187C35DE0")]
	[AsyncStateMachine(typeof(JJKCOMFENNJ))]
	private Task<KKBOOBAMIML> MJJIEBHIBFO(HLOJEJEEEIJ NEMAHPGAGLG, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x7C34F40", Offset = "0x7C34340", VA = "0x187C34F40")]
	[AsyncStateMachine(typeof(CPNGJGEOCEP))]
	private Task EPGCMAPHDKD(HLOJEJEEEIJ NEMAHPGAGLG, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x7C360F0", Offset = "0x7C354F0", VA = "0x187C360F0")]
	[AsyncStateMachine(typeof(MPBAMBDIBDA))]
	private Task NPBJMOLKGPF(HLOJEJEEEIJ NEMAHPGAGLG, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken NNLILNGJPMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x7C35790", Offset = "0x7C34B90", VA = "0x187C35790")]
	[AsyncStateMachine(typeof(OKHFNBIIBLG))]
	private Task KIKDPAONNLJ(BPPINHJEEIJ PIMCENOPMKL, DFIENIKFOMH EBIAFJLALFJ, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken BFGLMGKCPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x7C35C60", Offset = "0x7C35060", VA = "0x187C35C60")]
	[AsyncStateMachine(typeof(HJPHBLIGJJK))]
	private Task MIBJENBLHOH(FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x7C35AC0", Offset = "0x7C34EC0", VA = "0x187C35AC0")]
	[AsyncStateMachine(typeof(PMNOIEPGIOC))]
	private Task MDEOJHFIHDL(BPPINHJEEIJ GIDGOODJFLJ, DFIENIKFOMH FKKJJFDOIBC, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x7C350C0", Offset = "0x7C344C0", VA = "0x187C350C0")]
	[AsyncStateMachine(typeof(LDEILIPBMHG))]
	private Task<JBLLOOMMFJC> GOGCEKMEDOC(BPPINHJEEIJ GIDGOODJFLJ, LGLIHLIPDKB DHJAMPDDCGA, DFIENIKFOMH FKKJJFDOIBC, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x7C35610", Offset = "0x7C34A10", VA = "0x187C35610")]
	[AsyncStateMachine(typeof(OCEINLAHINN))]
	private Task<JBLLOOMMFJC> KEAMDFDOMIK(BPPINHJEEIJ GIDGOODJFLJ, LGLIHLIPDKB DHJAMPDDCGA, DFIENIKFOMH FKKJJFDOIBC, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x7C35370", Offset = "0x7C34770", VA = "0x187C35370")]
	[AsyncStateMachine(typeof(PAFBBLAODGC))]
	private Task<JBLLOOMMFJC> ILBJHGKIOOB(JBLLOOMMFJC FFFGJNJFNPO, BPPINHJEEIJ CAILOKLPAOE, DFIENIKFOMH FKKJJFDOIBC, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK, bool LKEGNGJABPA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B20", Offset = "0x7C33F20", VA = "0x187C34B20")]
	private bool BBDNDNJLMAI(BPPINHJEEIJ PIMCENOPMKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x7C35F40", Offset = "0x7C35340", VA = "0x187C35F40")]
	[AsyncStateMachine(typeof(HKEOMNKAFIF))]
	protected Task<JBLLOOMMFJC> MMPIDAMILLK(BPPINHJEEIJ GIDGOODJFLJ, LGLIHLIPDKB DHJAMPDDCGA, DFIENIKFOMH FKKJJFDOIBC, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK, IKABHLDKEMD EDMEMLGNACA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x7C35950", Offset = "0x7C34D50", VA = "0x187C35950")]
	[AsyncStateMachine(typeof(FGIGPNOKIPL))]
	private Task LFLJKGJIFLE(BPPINHJEEIJ GIDGOODJFLJ, DFIENIKFOMH FKKJJFDOIBC, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x7C35900", Offset = "0x7C34D00", VA = "0x187C35900")]
	private void LAKFIGOGGEA(JBLLOOMMFJC BMKIBAJMELF, DFIENIKFOMH FKKJJFDOIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x7C35080", Offset = "0x7C34480", VA = "0x187C35080")]
	private void GMLBHCNBHKF(JBLLOOMMFJC JIDEPALIAMB, [Out] JBLLOOMMFJC PBMPENMHACB, [Out] JBLLOOMMFJC FOGDCDFNADG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x7C34F00", Offset = "0x7C34300", VA = "0x187C34F00")]
	private Task<GCMEINGJNIC> EDOFDHBENFM(HLOJEJEEEIJ NEMAHPGAGLG, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x7C36280", Offset = "0x7C35680", VA = "0x187C36280")]
	private Task<BPPINHJEEIJ> PKGILMEBEND(GCMEINGJNIC GIDGOODJFLJ, POCLACLHDNA.FKMGIKDICFJ GDCPCFLAODN, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x7C34DB0", Offset = "0x7C341B0", VA = "0x187C34DB0")]
	[AsyncStateMachine(typeof(IBNPCIHKGLE))]
	private Task EBLPKLKMBAA(BPPINHJEEIJ GIDGOODJFLJ, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK, bool KOHAADJPPJH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x7C35520", Offset = "0x7C34920", VA = "0x187C35520")]
	[AsyncStateMachine(typeof(LHDAJBHHCPJ))]
	private Task JLKOHEHLGDH(BPPINHJEEIJ GIDGOODJFLJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x7C36250", Offset = "0x7C35650", VA = "0x187C36250")]
	private Task OPCMJDDFHEG(BPPINHJEEIJ GIDGOODJFLJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x7C34D90", Offset = "0x7C34190", VA = "0x187C34D90")]
	private Task EBGGFAHLEHK(BPPINHJEEIJ GIDGOODJFLJ, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x7C34C10", Offset = "0x7C34010", VA = "0x187C34C10")]
	private Task BNEFMJCNHNK(BPPINHJEEIJ GIDGOODJFLJ, LGLIHLIPDKB DHJAMPDDCGA, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B00", Offset = "0x7C33F00", VA = "0x187C34B00")]
	private Task ALEIPHLEHPD(BPPINHJEEIJ GIDGOODJFLJ, LGLIHLIPDKB DHJAMPDDCGA, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x7C36410", Offset = "0x7C35810", VA = "0x187C36410")]
	private static Task POADKFJFFAF(CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x7C360D0", Offset = "0x7C354D0", VA = "0x187C360D0")]
	private Task NKBNBONLINP(BPPINHJEEIJ GIDGOODJFLJ, LGLIHLIPDKB DHJAMPDDCGA, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x7C358E0", Offset = "0x7C34CE0", VA = "0x187C358E0")]
	private Task KOHCDBOFGDH(BPPINHJEEIJ GIDGOODJFLJ, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x7C35C10", Offset = "0x7C35010", VA = "0x187C35C10")]
	private void MGMDMHKNICO(HLOJEJEEEIJ NEMAHPGAGLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x7C34A50", Offset = "0x7C33E50", VA = "0x187C34A50")]
	public void AJLKPLHCNKL(long KGGKGOKAJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
	private static void HMIJIKMAHNE(EPDFKONBMMJ OCNEFBOFEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x7C362C0", Offset = "0x7C356C0", VA = "0x187C362C0")]
	[AsyncStateMachine(typeof(PFMIFLEFIKD))]
	private Task PKHPKIJMBFE(BPPINHJEEIJ PIMCENOPMKL, DFIENIKFOMH EBIAFJLALFJ, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken BFGLMGKCPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x7C34910", Offset = "0x7C33D10", VA = "0x187C34910")]
	[AsyncStateMachine(typeof(CCCNIHCEGEH))]
	private Task AJLGILJEAIF(BPPINHJEEIJ GIDGOODJFLJ, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x7C35D70", Offset = "0x7C35170", VA = "0x187C35D70")]
	private static PLEGJMDHKHI MIEEPACHJJG(BPPINHJEEIJ CAILOKLPAOE)
	{
		return default(PLEGJMDHKHI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x7C34C30", Offset = "0x7C34030", VA = "0x187C34C30")]
	[AsyncStateMachine(typeof(KOGFPPICJJK))]
	private Task<JBLLOOMMFJC> DEHKOKIPEME(BPPINHJEEIJ GIDGOODJFLJ, LGLIHLIPDKB DHJAMPDDCGA, DFIENIKFOMH FKKJJFDOIBC, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
	private void BJCCMJHDJMF(JBLLOOMMFJC IDACFNBBHFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
internal struct ONDGDCBJOBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400057C")]
	private CFEMEJBKCKD GHFCFJHMPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400057D")]
	private BPPINHJEEIJ GIDGOODJFLJ;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	private JJKJBCNAAJM MNHGCFJHHHI
	{
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x7C60AC0", Offset = "0x7C5FEC0", VA = "0x187C60AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x7C60B10", Offset = "0x7C5FF10", VA = "0x187C60B10")]
	public static Task IKIFLPOJPIB(CFEMEJBKCKD GHFCFJHMPHJ, BPPINHJEEIJ GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x7C60BF0", Offset = "0x7C5FFF0", VA = "0x187C60BF0")]
	private void IKIFLPOJPIB()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal struct IMLKNBPEINN
{
	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x7C57770", Offset = "0x7C56B70", VA = "0x187C57770")]
	public static Task IKIFLPOJPIB(CancellationToken LAEIHJHNGEK)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014F")]
internal struct EGNGKKLCAEI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct INLMJCFMJNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public LGACCJIPMFL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public BPPINHJEEIJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private DJPNNBMEIAG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x7C57850", Offset = "0x7C56C50", VA = "0x187C57850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x7C57D80", Offset = "0x7C57180", VA = "0x187C57D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x7C52080", Offset = "0x7C51480", VA = "0x187C52080")]
	[AsyncStateMachine(typeof(INLMJCFMJNK))]
	public static Task IKIFLPOJPIB(LGACCJIPMFL OKNMIEHKKPG, BPPINHJEEIJ GIDGOODJFLJ, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000151")]
internal struct BFLBNFDJPBA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct NNPCNOADPOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public LGACCJIPMFL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public BPPINHJEEIJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public LGLIHLIPDKB timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private CFEMEJBKCKD <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private JJKJBCNAAJM <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private JBLLOOMMFJC <operationState>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		private bool <isMaster>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		private DJPNNBMEIAG <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		private List<(PersistenceView, PGEJPEMIJFO)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private PGEJPEMIJFO <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x7C5DEE0", Offset = "0x7C5D2E0", VA = "0x187C5DEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x7C5EBC0", Offset = "0x7C5DFC0", VA = "0x187C5EBC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x7C4DF80", Offset = "0x7C4D380", VA = "0x187C4DF80")]
	[AsyncStateMachine(typeof(NNPCNOADPOI))]
	public static Task IKIFLPOJPIB(LGACCJIPMFL OKNMIEHKKPG, BPPINHJEEIJ GIDGOODJFLJ, LGLIHLIPDKB DHJAMPDDCGA, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E0D0", Offset = "0x7C4D4D0", VA = "0x187C4E0D0")]
	private static void ILNNBJBMLNO(PersistenceView GAFKCGNMDOE, PGEJPEMIJFO JOHGLFIKFAB, BPPINHJEEIJ GIDGOODJFLJ, JBLLOOMMFJC FFFGJNJFNPO, bool ODBNPPCAHOA)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000154")]
internal struct KAMCMAOKOHO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private struct GLFEEIDKCOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public CFEMEJBKCKD roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public BPPINHJEEIJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		private DJPNNBMEIAG <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x7C54850", Offset = "0x7C53C50", VA = "0x187C54850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x7C54E70", Offset = "0x7C54270", VA = "0x187C54E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x7C593B0", Offset = "0x7C587B0", VA = "0x187C593B0")]
	[AsyncStateMachine(typeof(GLFEEIDKCOG))]
	public static Task IKIFLPOJPIB(CFEMEJBKCKD GHFCFJHMPHJ, BPPINHJEEIJ GIDGOODJFLJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal struct IFDMBEJGMEE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct JOPOBHHCMFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public CFEMEJBKCKD roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public BPPINHJEEIJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public LGACCJIPMFL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x7C59140", Offset = "0x7C58540", VA = "0x187C59140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x7C59350", Offset = "0x7C58750", VA = "0x187C59350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private sealed class EMOIKIACKIA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000159")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005B1")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005B2")]
			public FGFDKLMANEA<string>.ICBJPFEBGDJ timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005B3")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005B4")]
			public EMOIKIACKIA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005B5")]
			private FGFDKLMANEA<string>.ICBJPFEBGDJ <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005B6")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005BB")]
			[Cpp2IlInjected.Address(RVA = "0x7C64F10", Offset = "0x7C64310", VA = "0x187C64F10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BC")]
			[Cpp2IlInjected.Address(RVA = "0x7C652A0", Offset = "0x7C646A0", VA = "0x187C652A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public EMOIKIACKIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x7C521C0", Offset = "0x7C515C0", VA = "0x187C521C0")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task EOCKDMDNAIL(FGFDKLMANEA<string>.ICBJPFEBGDJ timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private struct FDPBAMLECPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public IFDMBEJGMEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private DJPNNBMEIAG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private DJPNNBMEIAG <_>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		private TaskAwaiter<KKBOOBAMIML> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x7C522E0", Offset = "0x7C516E0", VA = "0x187C522E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x7C52EF0", Offset = "0x7C522F0", VA = "0x187C52EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private sealed class KOIMGGHMCPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public GPALOJEHCIG version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public KOIMGGHMCPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x7C5A990", Offset = "0x7C59D90", VA = "0x187C5A990")]
		internal object GLGHHHOPFBB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x7C5A8E0", Offset = "0x7C59CE0", VA = "0x187C5A8E0")]
		internal object DFBCEDBPLEB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A1")]
	private CFEMEJBKCKD GHFCFJHMPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005A2")]
	private BPPINHJEEIJ GIDGOODJFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005A3")]
	private LGACCJIPMFL OKNMIEHKKPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005A4")]
	private bool KOHAADJPPJH;

	[Cpp2IlInjected.Token(Token = "0x40005A5")]
	private static readonly ByteString ALPBPFEGPFI;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	private JJKJBCNAAJM MNHGCFJHHHI
	{
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x7C564B0", Offset = "0x7C558B0", VA = "0x187C564B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	private FBKMDCBFBII IELHGPMHDJI
	{
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x7C56500", Offset = "0x7C55900", VA = "0x187C56500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x7C565A0", Offset = "0x7C559A0", VA = "0x187C565A0")]
	[AsyncStateMachine(typeof(JOPOBHHCMFP))]
	public static Task IKIFLPOJPIB(CFEMEJBKCKD GHFCFJHMPHJ, BPPINHJEEIJ GIDGOODJFLJ, LGACCJIPMFL OKNMIEHKKPG, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK, bool KOHAADJPPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x7C566F0", Offset = "0x7C55AF0", VA = "0x187C566F0")]
	[AsyncStateMachine(typeof(FDPBAMLECPK))]
	private Task IKIFLPOJPIB(FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x7C56860", Offset = "0x7C55C60", VA = "0x187C56860")]
	private void OCBDKNNMIGL([NotNull] BDHMMMHCHAA HKMOFGELBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x7C56820", Offset = "0x7C55C20", VA = "0x187C56820")]
	private bool MICGLDODLDN(GPALOJEHCIG EPKMALKPPHD, BDHMMMHCHAA HKMOFGELBFL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal struct BGHLPIGEDAK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct BBBHFDHBKDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public AsyncTaskMethodBuilder<BPPINHJEEIJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public BGHLPIGEDAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public POCLACLHDNA.FKMGIKDICFJ downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		private DJPNNBMEIAG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		private TaskAwaiter<(JOFBNNGKBOO<GNOIADKGAKA, PGAGFEIEKID>, JOFBNNGKBOO<IReadOnlyList<GNOIADKGAKA>, PGAGFEIEKID>, JOFBNNGKBOO<ENCJOPBFNLI<BDHMMMHCHAA>, PGAGFEIEKID>, JOFBNNGKBOO<ENCJOPBFNLI<HFDFODLNHEC>, PGAGFEIEKID>, JOFBNNGKBOO<ENCJOPBFNLI<IPICNJAGLAJ>, PGAGFEIEKID>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D2E0", Offset = "0x7C4C6E0", VA = "0x187C4D2E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x7C4DE20", Offset = "0x7C4D220", VA = "0x187C4DE20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private struct GECIHKCMICD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<GNOIADKGAKA, PGAGFEIEKID>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public BGHLPIGEDAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public POCLACLHDNA.FKMGIKDICFJ downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		private DJPNNBMEIAG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		private TaskAwaiter<JOFBNNGKBOO<GNOIADKGAKA, PGAGFEIEKID>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x7C53550", Offset = "0x7C52950", VA = "0x187C53550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x7C53B70", Offset = "0x7C52F70", VA = "0x187C53B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private struct AHHOIJLPJHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<IReadOnlyList<GNOIADKGAKA>, PGAGFEIEKID>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public BGHLPIGEDAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public IReadOnlyList<HFBGJKKCMEJ> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private DJPNNBMEIAG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private TaskAwaiter<JOFBNNGKBOO<IReadOnlyList<GNOIADKGAKA>, PGAGFEIEKID>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x7C4C7A0", Offset = "0x7C4BBA0", VA = "0x187C4C7A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x7C4CD50", Offset = "0x7C4C150", VA = "0x187C4CD50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	private LPKPFNJIIOO<DDDGOPGHMJC, HFDFODLNHEC> CNALKCEPAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	private LPKPFNJIIOO<DDDGOPGHMJC, BDHMMMHCHAA> EDAEHLDOGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C8")]
	private LPKPFNJIIOO<long, IPICNJAGLAJ> JBHEBMIMAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C9")]
	private EAEHGMBKJAK OADHFJFIKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005CA")]
	private EPDFKONBMMJ OCNEFBOFEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005CB")]
	private KOLBKODMCOP OILMJLBENOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005CC")]
	private string HDFGNIINOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40005CD")]
	private IReadOnlyList<HFBGJKKCMEJ> CJHJCCPNCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40005CE")]
	private DDDGOPGHMJC LBDLMMONJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	private DDDGOPGHMJC BKNHKBPEOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40005D0")]
	private long KGGKGOKAJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	private FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE;

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E630", Offset = "0x7C4DA30", VA = "0x187C4E630")]
	public static Task<BPPINHJEEIJ> IJFMDAEMJDO(CFEMEJBKCKD GHFCFJHMPHJ, [In] GCMEINGJNIC GIDGOODJFLJ, POCLACLHDNA.FKMGIKDICFJ GDCPCFLAODN, FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x7C4EA10", Offset = "0x7C4DE10", VA = "0x187C4EA10")]
	[AsyncStateMachine(typeof(BBBHFDHBKDN))]
	private Task<BPPINHJEEIJ> IKIFLPOJPIB(POCLACLHDNA.FKMGIKDICFJ GDCPCFLAODN, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E2D0", Offset = "0x7C4D6D0", VA = "0x187C4E2D0")]
	[AsyncStateMachine(typeof(GECIHKCMICD))]
	private Task<JOFBNNGKBOO<GNOIADKGAKA, PGAGFEIEKID>> DFCFPGOPLNJ(string HDFGNIINOHH, long KGGKGOKAJFO, long? FFFLOIOFAMB, long? GHFFAIKCNFL, POCLACLHDNA.FKMGIKDICFJ GDCPCFLAODN, FGFDKLMANEA<string>.ICBJPFEBGDJ NLMHFHFIGIO, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x7C4E4A0", Offset = "0x7C4D8A0", VA = "0x187C4E4A0")]
	[AsyncStateMachine(typeof(AHHOIJLPJHI))]
	private Task<JOFBNNGKBOO<IReadOnlyList<GNOIADKGAKA>, PGAGFEIEKID>> IHMOHNEAAHJ(IReadOnlyList<HFBGJKKCMEJ> CJHJCCPNCMF, FGFDKLMANEA<string>.ICBJPFEBGDJ NLMHFHFIGIO, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000160")]
internal struct KOCCODGENJG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private struct OLKFNHNCLHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public AsyncTaskMethodBuilder<GCMEINGJNIC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public KOCCODGENJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private TaskAwaiter<GCMEINGJNIC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x7C60640", Offset = "0x7C5FA40", VA = "0x187C60640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x7C60A50", Offset = "0x7C5FE50", VA = "0x187C60A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private struct GEEPJBIJNIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public AsyncTaskMethodBuilder<GCMEINGJNIC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public KOCCODGENJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		private TaskAwaiter<GCMEINGJNIC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x7C53BE0", Offset = "0x7C52FE0", VA = "0x187C53BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x7C54010", Offset = "0x7C53410", VA = "0x187C54010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private sealed class JFHEOIOBIGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public JFHEOIOBIGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0xCE8F90", Offset = "0xCE8390", VA = "0x180CE8F90")]
		internal bool KEPJJMHFCEF(KOLBKODMCOP sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private struct LANGGNJPCMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public AsyncTaskMethodBuilder<GCMEINGJNIC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public DDDGOPGHMJC superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public JJKJBCNAAJM callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		private JFHEOIOBIGE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public MLDPBHLIHNF roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		private EPDFKONBMMJ <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		private KOLBKODMCOP <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		private IReadOnlyList<HFBGJKKCMEJ> <unitySubAssets>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		private DDDGOPGHMJC <superRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		private DDDGOPGHMJC <subRoomData>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		private TaskAwaiter<EPDFKONBMMJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		private TaskAwaiter<HGLCHBODEAA> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		private TaskAwaiter<JHNKENAKGMI> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x7C5AA70", Offset = "0x7C59E70", VA = "0x187C5AA70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x7C5BCD0", Offset = "0x7C5B0D0", VA = "0x187C5BCD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005F0")]
	private JJKJBCNAAJM MOKEOOADLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	private MBLNBFNLDAN CHKICNMGPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005F2")]
	private MLDPBHLIHNF OOAHFJPLOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005F3")]
	private FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005F4")]
	private long FFFLOIOFAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005F5")]
	private long OGHBKCHPPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005F6")]
	private long AFCAJMDPILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40005F7")]
	private string BPPPCIKOLON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40005F8")]
	private DDDGOPGHMJC PKCCECPMCHO;

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x7C59E90", Offset = "0x7C59290", VA = "0x187C59E90")]
	public static Task<GCMEINGJNIC> IJFMDAEMJDO(CFEMEJBKCKD GHFCFJHMPHJ, HLOJEJEEEIJ NEMAHPGAGLG, FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x7C5A0D0", Offset = "0x7C594D0", VA = "0x187C5A0D0")]
	[AsyncStateMachine(typeof(OLKFNHNCLHP))]
	private Task<GCMEINGJNIC> IKIFLPOJPIB(CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x7C59B90", Offset = "0x7C58F90", VA = "0x187C59B90")]
	[AsyncStateMachine(typeof(GEEPJBIJNIK))]
	private Task<GCMEINGJNIC> EDOFDHBENFM(FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x7C59CF0", Offset = "0x7C590F0", VA = "0x187C59CF0")]
	[AsyncStateMachine(typeof(LANGGNJPCMC))]
	private static Task<GCMEINGJNIC> EDOFDHBENFM(JJKJBCNAAJM MOKEOOADLAP, MLDPBHLIHNF OOAHFJPLOHB, long FFFLOIOFAMB, long OGHBKCHPPKA, long AFCAJMDPILG, string BPPPCIKOLON, DDDGOPGHMJC PKCCECPMCHO, CancellationToken LAEIHJHNGEK, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x7C5A220", Offset = "0x7C59620", VA = "0x187C5A220")]
	private void MLGMGNMJCAC(EPDFKONBMMJ OCNEFBOFEOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
internal struct KDIDDHPFEPB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private struct PPJENAMIEIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public KDIDDHPFEPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x7C62F80", Offset = "0x7C62380", VA = "0x187C62F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x7C63510", Offset = "0x7C62910", VA = "0x187C63510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400061C")]
	private JJKJBCNAAJM MOKEOOADLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400061D")]
	private BPPINHJEEIJ GIDGOODJFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400061E")]
	private FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400061F")]
	private float CJKHFHGKJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000620")]
	private float KHPGAGHGOMM;

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x7C59630", Offset = "0x7C58A30", VA = "0x187C59630")]
	public static Task GBNLLEDCFPD(CFEMEJBKCKD GHFCFJHMPHJ, BPPINHJEEIJ GIDGOODJFLJ, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0x7C597D0", Offset = "0x7C58BD0", VA = "0x187C597D0")]
	[AsyncStateMachine(typeof(PPJENAMIEIF))]
	public Task IKIFLPOJPIB(CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x7C594D0", Offset = "0x7C588D0", VA = "0x187C594D0")]
	private static void BFGNOPBDEED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(RVA = "0x7C599B0", Offset = "0x7C58DB0", VA = "0x187C599B0")]
	private void LEFHIPAGEMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(RVA = "0x7C598F0", Offset = "0x7C58CF0", VA = "0x187C598F0")]
	private static float IPFNBKLAGGC(JJKJBCNAAJM MOKEOOADLAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(RVA = "0x7C59610", Offset = "0x7C58A10", VA = "0x187C59610")]
	private static float CLADCFEIHGJ()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000168")]
internal struct NPIKJBCKNLJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct JCAFBGBAAAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public LGACCJIPMFL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public BPPINHJEEIJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		private DJPNNBMEIAG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		private GPIPDBGGDOE <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		private CFEMEJBKCKD <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		private OPHBAFAGJKK.FNBHKFLEHND <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		private TaskAwaiter<KKBOOBAMIML> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x7C58070", Offset = "0x7C57470", VA = "0x187C58070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x7C58890", Offset = "0x7C57C90", VA = "0x187C58890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private struct LCLLKDAJKEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		private DJPNNBMEIAG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x7C5BD40", Offset = "0x7C5B140", VA = "0x187C5BD40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x7C5C070", Offset = "0x7C5B470", VA = "0x187C5C070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x7C5ED50", Offset = "0x7C5E150", VA = "0x187C5ED50")]
	[AsyncStateMachine(typeof(JCAFBGBAAAM))]
	public static Task IKIFLPOJPIB(LGACCJIPMFL OKNMIEHKKPG, BPPINHJEEIJ GIDGOODJFLJ, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x7C5ECE0", Offset = "0x7C5E0E0", VA = "0x187C5ECE0")]
	private static Task<KKBOOBAMIML> BHHHALGGDHI(LGACCJIPMFL OKNMIEHKKPG, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x7C5EC20", Offset = "0x7C5E020", VA = "0x187C5EC20")]
	[AsyncStateMachine(typeof(LCLLKDAJKEF))]
	private static Task AEBJNKDJIPO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
internal struct IPJAGAKKMKN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct JLCFBCJKDJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public IPJAGAKKMKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x7C588F0", Offset = "0x7C57CF0", VA = "0x187C588F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x7C58FA0", Offset = "0x7C583A0", VA = "0x187C58FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private sealed class OAMNBDFGDOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public OAMNBDFGDOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x7C5EE90", Offset = "0x7C5E290", VA = "0x187C5EE90")]
		internal object IPLBJBMCICJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private struct CDJKDCPMFPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public IPJAGAKKMKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		private DJPNNBMEIAG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x7C50420", Offset = "0x7C4F820", VA = "0x187C50420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x7C508A0", Offset = "0x7C4FCA0", VA = "0x187C508A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400063B")]
	private bool IOHINMLPMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400063C")]
	private FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400063D")]
	private CFEMEJBKCKD GHFCFJHMPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400063E")]
	private CancellationToken LAEIHJHNGEK;

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x7C57F10", Offset = "0x7C57310", VA = "0x187C57F10")]
	public static Task HMHPKIGMEPC(CFEMEJBKCKD GHFCFJHMPHJ, bool IOHINMLPMHA, FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE, CancellationToken ENHKOFNDDIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x7C57F80", Offset = "0x7C57380", VA = "0x187C57F80")]
	[AsyncStateMachine(typeof(JLCFBCJKDJC))]
	private Task IKIFLPOJPIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x7C57DE0", Offset = "0x7C571E0", VA = "0x187C57DE0")]
	[AsyncStateMachine(typeof(CDJKDCPMFPI))]
	private Task GGDDPFFOFAN(bool KFJFEEGFJLE, string GOCBDOMNJJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0")]
	private bool ADEJKOJJLBE(bool IOHINMLPMHA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200016F")]
internal struct MOFCDNFIPLG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct ICOAJFPDOAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		public MOFCDNFIPLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x7C55ED0", Offset = "0x7C552D0", VA = "0x187C55ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x7C56440", Offset = "0x7C55840", VA = "0x187C56440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class FGOLLNBFJBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public FGOLLNBFJBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x7C53500", Offset = "0x7C52900", VA = "0x187C53500")]
		internal object IPLBJBMCICJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private struct PCAMLAPJPLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public MOFCDNFIPLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		private DJPNNBMEIAG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x7C61B60", Offset = "0x7C60F60", VA = "0x187C61B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x7C61FF0", Offset = "0x7C613F0", VA = "0x187C61FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400064E")]
	private HJFMPFKHBLD CGDPGJGBKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400064F")]
	private FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000650")]
	private CFEMEJBKCKD GHFCFJHMPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000651")]
	private bool NGBGLELGHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000652")]
	private BPPINHJEEIJ GIDGOODJFLJ;

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x7C5DD20", Offset = "0x7C5D120", VA = "0x187C5DD20")]
	public static Task<Scene> MPJHANNLHGP(CFEMEJBKCKD GHFCFJHMPHJ, HJFMPFKHBLD DODKGJGBFEC, FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x7C5DC00", Offset = "0x7C5D000", VA = "0x187C5DC00")]
	[AsyncStateMachine(typeof(ICOAJFPDOAO))]
	private Task<Scene> IKIFLPOJPIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x7C5DA10", Offset = "0x7C5CE10", VA = "0x187C5DA10")]
	private bool CHHAFFJHKBB(BPPINHJEEIJ GIDGOODJFLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0x7C5DB90", Offset = "0x7C5CF90", VA = "0x187C5DB90")]
	private void GLJCJOCHJHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x7C5DA40", Offset = "0x7C5CE40", VA = "0x187C5DA40")]
	[AsyncStateMachine(typeof(PCAMLAPJPLC))]
	private Task<Scene> GGDDPFFOFAN(string GOCBDOMNJJE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
internal struct ABJDDLLLNDI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private struct CAIFKHACGJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public AsyncTaskMethodBuilder<JBLLOOMMFJC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public ABJDDLLLNDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public JBLLOOMMFJC nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		public BPPINHJEEIJ deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		private TaskAwaiter<JBLLOOMMFJC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F1A0", Offset = "0x7C4E5A0", VA = "0x187C4F1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x7C4FC70", Offset = "0x7C4F070", VA = "0x187C4FC70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private struct ADCJKBGLBIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public AsyncTaskMethodBuilder<JBLLOOMMFJC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public ABJDDLLLNDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public JBLLOOMMFJC state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		private TaskAwaiter<KKBOOBAMIML> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x7C4C450", Offset = "0x7C4B850", VA = "0x187C4C450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x7C4C730", Offset = "0x7C4BB30", VA = "0x187C4C730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400065F")]
	private readonly LGACCJIPMFL OKNMIEHKKPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000660")]
	private readonly MBLNBFNLDAN CHKICNMGPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000661")]
	private readonly LFMOOOFFMNB AIBFBNBKOEE;

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	private GPIPDBGGDOE NBDKCOPBDCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x6235500", Offset = "0x6234900", VA = "0x186235500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x7C4BCC0", Offset = "0x7C4B0C0", VA = "0x187C4BCC0")]
	public ABJDDLLLNDI(LGACCJIPMFL OKNMIEHKKPG, MBLNBFNLDAN CHKICNMGPAD, LFMOOOFFMNB AIBFBNBKOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x7C4BB10", Offset = "0x7C4AF10", VA = "0x187C4BB10")]
	[AsyncStateMachine(typeof(CAIFKHACGJE))]
	public Task<JBLLOOMMFJC> KIBOEBIHJFN(JBLLOOMMFJC GMJCBGCLJND, BPPINHJEEIJ CAILOKLPAOE, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK, bool LKEGNGJABPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x7C4B990", Offset = "0x7C4AD90", VA = "0x187C4B990")]
	[AsyncStateMachine(typeof(ADCJKBGLBIB))]
	private Task<JBLLOOMMFJC> HMJLCOPDNIG(FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, JBLLOOMMFJC CEGAGHAOIDD, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x7C4BC90", Offset = "0x7C4B090", VA = "0x187C4BC90")]
	private bool LKGGLPPALPF(JBLLOOMMFJC NKDAOEOIAEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x7C4BAF0", Offset = "0x7C4AEF0", VA = "0x187C4BAF0")]
	private void IEGNOINNOMJ(string OIKCDENKJMH)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000176")]
internal struct NDOPLDENAIK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private struct ACKKHNGAKAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public GPIPDBGGDOE operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public BPPINHJEEIJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public LGLIHLIPDKB timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private DJPNNBMEIAG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		private List<(PersistenceView, PGEJPEMIJFO)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		private (PersistenceView, PGEJPEMIJFO) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x7C4BD20", Offset = "0x7C4B120", VA = "0x187C4BD20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x7C4C3F0", Offset = "0x7C4B7F0", VA = "0x187C4C3F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x7C5DDA0", Offset = "0x7C5D1A0", VA = "0x187C5DDA0")]
	[AsyncStateMachine(typeof(ACKKHNGAKAN))]
	public static Task IKIFLPOJPIB(GPIPDBGGDOE FFEBDLHFDKK, BPPINHJEEIJ GIDGOODJFLJ, LGLIHLIPDKB DHJAMPDDCGA, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000178")]
internal struct JNONPLDDPIP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private struct EBOLFIBIHPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		public GPIPDBGGDOE operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		public BPPINHJEEIJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		public LGLIHLIPDKB timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		private GPALOJEHCIG <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		private DJPNNBMEIAG <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		private List<(PersistenceView, PGEJPEMIJFO)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		private PGEJPEMIJFO <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x7C515E0", Offset = "0x7C509E0", VA = "0x187C515E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x7C51EC0", Offset = "0x7C512C0", VA = "0x187C51EC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x7C59000", Offset = "0x7C58400", VA = "0x187C59000")]
	[AsyncStateMachine(typeof(EBOLFIBIHPF))]
	public static Task IKIFLPOJPIB(GPIPDBGGDOE FFEBDLHFDKK, BPPINHJEEIJ GIDGOODJFLJ, LGLIHLIPDKB DHJAMPDDCGA, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
internal struct OPHBAFAGJKK
{
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	public struct FNBHKFLEHND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		public List<IDECODEGFDL> HAFLOLBIHEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		public List<PGEJPEMIJFO> NKECGMLLJBE;

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x9AB3A0", Offset = "0x9AA7A0", VA = "0x1809AB3A0")]
		public FNBHKFLEHND(List<IDECODEGFDL> HAFLOLBIHEL, List<PGEJPEMIJFO> NKECGMLLJBE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private sealed class KJCPGMBCPPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public IEnumerable<IDECODEGFDL> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public KJCPGMBCPPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x7C59B10", Offset = "0x7C58F10", VA = "0x187C59B10")]
		internal object FOEONIKJLAL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400068E")]
	private CFEMEJBKCKD GHFCFJHMPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400068F")]
	private BPPINHJEEIJ GIDGOODJFLJ;

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private JJKJBCNAAJM MNHGCFJHHHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x7C61590", Offset = "0x7C60990", VA = "0x187C61590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x7C61840", Offset = "0x7C60C40", VA = "0x187C61840")]
	public static FNBHKFLEHND IKIFLPOJPIB(CFEMEJBKCKD GHFCFJHMPHJ, BPPINHJEEIJ GIDGOODJFLJ)
	{
		return default(FNBHKFLEHND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x7C615E0", Offset = "0x7C609E0", VA = "0x187C615E0")]
	private FNBHKFLEHND IKIFLPOJPIB()
	{
		return default(FNBHKFLEHND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x7C60E10", Offset = "0x7C60210", VA = "0x187C60E10")]
	private FNBHKFLEHND ABJJGLOKFAF(BDHMMMHCHAA HKMOFGELBFL, GPALOJEHCIG MCCHAEKDNLN)
	{
		return default(FNBHKFLEHND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x7C613C0", Offset = "0x7C607C0", VA = "0x187C613C0")]
	private bool DFLOEOJDFKI(IEnumerable<IDECODEGFDL> HAFLOLBIHEL)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200017D")]
internal struct OEIFCFJLBNN
{
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private sealed class IBEEIIHDFFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		public OPHBAFAGJKK.FNBHKFLEHND instantiations;

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public IBEEIIHDFFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x7C55AD0", Offset = "0x7C54ED0", VA = "0x187C55AD0")]
		internal object EOCKDMDNAIL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private sealed class CPDOOMDMNLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public CPDOOMDMNLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x7C50E30", Offset = "0x7C50230", VA = "0x187C50E30")]
		internal object MMEEHMDAIMD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x7C60090", Offset = "0x7C5F490", VA = "0x187C60090")]
	public static void IKIFLPOJPIB(GPIPDBGGDOE FFEBDLHFDKK, BPPINHJEEIJ GIDGOODJFLJ, OPHBAFAGJKK.FNBHKFLEHND EPPMBMLCMFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal class LFMOOOFFMNB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct GJFGBPBKBCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public LFMOOOFFMNB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		public JBLLOOMMFJC operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		public BPPINHJEEIJ deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x7C54080", Offset = "0x7C53480", VA = "0x187C54080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x7C547F0", Offset = "0x7C53BF0", VA = "0x187C547F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private sealed class BBNDJLHDNFK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000183")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006A4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006A5")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006A6")]
			public BBNDJLHDNFK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006A7")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006A8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000630")]
			[Cpp2IlInjected.Address(RVA = "0x7C64BF0", Offset = "0x7C63FF0", VA = "0x187C64BF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000631")]
			[Cpp2IlInjected.Address(RVA = "0x7C64EB0", Offset = "0x7C642B0", VA = "0x187C64EB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		public LFMOOOFFMNB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public BPPINHJEEIJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public BBNDJLHDNFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x7C4DE90", Offset = "0x7C4D290", VA = "0x187C4DE90")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task OIHOOHLNMMB(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private struct DNGOBEBLOOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public LFMOOOFFMNB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		public BPPINHJEEIJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		private BBNDJLHDNFK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x7C50FE0", Offset = "0x7C503E0", VA = "0x187C50FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x7C51510", Offset = "0x7C50910", VA = "0x187C51510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private struct HOHOIPBOJDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		public LFMOOOFFMNB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public BPPINHJEEIJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		private Dictionary<Guid, List<EOAHMNKFLEL>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x7C55460", Offset = "0x7C54860", VA = "0x187C55460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x7C55A70", Offset = "0x7C54E70", VA = "0x187C55A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	private struct MBDFAHFMOHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		public LFMOOOFFMNB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public BPPINHJEEIJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		private Dictionary<Guid, List<EOAHMNKFLEL>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x7C5D2A0", Offset = "0x7C5C6A0", VA = "0x187C5D2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x7C5D940", Offset = "0x7C5CD40", VA = "0x187C5D940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[CompilerGenerated]
	private sealed class CAPLOJBNILK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000188")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006C8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006C9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006CA")]
			public EOAHMNKFLEL handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006CB")]
			public CAPLOJBNILK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006CC")]
			private DJPNNBMEIAG <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006CD")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x7C63570", Offset = "0x7C62970", VA = "0x187C63570", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063D")]
			[Cpp2IlInjected.Address(RVA = "0x7C639E0", Offset = "0x7C62DE0", VA = "0x187C639E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public BPDPCIOHIIP runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public List<EOAHMNKFLEL> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		public BPPINHJEEIJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public CAPLOJBNILK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x7C4FCE0", Offset = "0x7C4F0E0", VA = "0x187C4FCE0")]
		internal object AJDOPPONGMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x7C4FEC0", Offset = "0x7C4F2C0", VA = "0x187C4FEC0")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task JHEDCHADCOD(EOAHMNKFLEL handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x7C4FDD0", Offset = "0x7C4F1D0", VA = "0x187C4FDD0")]
		internal object COFHGBBDOLJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private struct CHIHCPIMGMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		public BPDPCIOHIIP runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		public List<EOAHMNKFLEL> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		public BPPINHJEEIJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		private CAPLOJBNILK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x7C50900", Offset = "0x7C4FD00", VA = "0x187C50900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x7C50DD0", Offset = "0x7C501D0", VA = "0x187C50DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[CompilerGenerated]
	private struct BPOHHKKEMAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		public LFMOOOFFMNB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		public BPPINHJEEIJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x7C4EB80", Offset = "0x7C4DF80", VA = "0x187C4EB80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F140", Offset = "0x7C4E540", VA = "0x187C4F140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private sealed class EALPEFEHKJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public EALPEFEHKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x7C51570", Offset = "0x7C50970", VA = "0x187C51570")]
		internal object FBCMFPJNBNG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private struct APKEGGHJCKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		public LFMOOOFFMNB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		public BPPINHJEEIJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		private DJPNNBMEIAG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x7C4CDC0", Offset = "0x7C4C1C0", VA = "0x187C4CDC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D280", Offset = "0x7C4C680", VA = "0x187C4D280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[CompilerGenerated]
	private sealed class MNNJPHEHPON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public MNNJPHEHPON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x7C5D9A0", Offset = "0x7C5CDA0", VA = "0x187C5D9A0")]
		internal object BHEJPHDIOLN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018F")]
	[CompilerGenerated]
	private struct IKKFFLBEOGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		public LFMOOOFFMNB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		private DJPNNBMEIAG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		private TaskAwaiter<KKBOOBAMIML> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x7C570D0", Offset = "0x7C564D0", VA = "0x187C570D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x7C57710", Offset = "0x7C56B10", VA = "0x187C57710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000190")]
	[CompilerGenerated]
	private sealed class PELHHICDGFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public PELHHICDGFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x7C70E40", Offset = "0x7C70240", VA = "0x187C70E40")]
		internal object HHEEEHJFEKC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000696")]
	private readonly LGACCJIPMFL OKNMIEHKKPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000697")]
	private MAFPIAFLMCC AIBFBNBKOEE;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private GPIPDBGGDOE NBDKCOPBDCK
	{
		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0xF04FD0", Offset = "0xF043D0", VA = "0x180F04FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x951BA0", Offset = "0x950FA0", VA = "0x180951BA0")]
	public LFMOOOFFMNB(LGACCJIPMFL OKNMIEHKKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C920", Offset = "0x7C5BD20", VA = "0x187C5C920")]
	[AsyncStateMachine(typeof(GJFGBPBKBCM))]
	public Task IKIFLPOJPIB(JBLLOOMMFJC FFFGJNJFNPO, BPPINHJEEIJ CAILOKLPAOE, FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C7E0", Offset = "0x7C5BBE0", VA = "0x187C5C7E0")]
	[AsyncStateMachine(typeof(DNGOBEBLOOD))]
	private Task HPJHCBIIJAL(BPPINHJEEIJ GIDGOODJFLJ, FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x7C5CCF0", Offset = "0x7C5C0F0", VA = "0x187C5CCF0")]
	[AsyncStateMachine(typeof(HOHOIPBOJDC))]
	private Task OGLEGCHEMFJ(BPPINHJEEIJ GIDGOODJFLJ, FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C410", Offset = "0x7C5B810", VA = "0x187C5C410")]
	[AsyncStateMachine(typeof(MBDFAHFMOHF))]
	private Task HIMJIGMOCED(BPPINHJEEIJ GIDGOODJFLJ, FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C0D0", Offset = "0x7C5B4D0", VA = "0x187C5C0D0")]
	[AsyncStateMachine(typeof(CHIHCPIMGMH))]
	private Task DJOJDIGHEKD(Guid NDLJCCHDEKE, List<EOAHMNKFLEL> GKJNMMLEIOL, BPDPCIOHIIP ELMNEDJBDIL, BPPINHJEEIJ GIDGOODJFLJ, CancellationToken LAAJFAFNFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C2D0", Offset = "0x7C5B6D0", VA = "0x187C5C2D0")]
	[AsyncStateMachine(typeof(BPOHHKKEMAK))]
	private Task EPILDHPEOHI(BPPINHJEEIJ GIDGOODJFLJ, FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x7C5CBB0", Offset = "0x7C5BFB0", VA = "0x187C5CBB0")]
	[AsyncStateMachine(typeof(APKEGGHJCKP))]
	private Task JLJABKJDFFA(Guid CCLPBBEIOKN, BPPINHJEEIJ GIDGOODJFLJ, FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x7C5CA70", Offset = "0x7C5BE70", VA = "0x187C5CA70")]
	[AsyncStateMachine(typeof(IKKFFLBEOGP))]
	private Task JJILKMOMMIE(Guid CCLPBBEIOKN, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C550", Offset = "0x7C5B950", VA = "0x187C5C550")]
	private void HNPOGBDJAJD(Guid CCLPBBEIOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C220", Offset = "0x7C5B620", VA = "0x187C5C220")]
	private void ENJIINKEBEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C670", Offset = "0x7C5BA70", VA = "0x187C5C670")]
	public Guid HPBBMFOLHML(JBLLOOMMFJC BMKIBAJMELF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x7C5CE30", Offset = "0x7C5C230", VA = "0x187C5CE30")]
	[CompilerGenerated]
	private object OPOKIDGHLAD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
internal struct FCGLHJNDJHK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private struct BLPLBFPGCKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		public FCGLHJNDJHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		private IEnumerator<HHFNEHONJPO> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x7C66160", Offset = "0x7C65560", VA = "0x187C66160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x7C66800", Offset = "0x7C65C00", VA = "0x187C66800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006F6")]
	private JJKJBCNAAJM MOKEOOADLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006F7")]
	private FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006F8")]
	private CancellationToken LAEIHJHNGEK;

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x7C68750", Offset = "0x7C67B50", VA = "0x187C68750")]
	public static Task EFNPPBJIOOC(JJKJBCNAAJM MOKEOOADLAP, FGFDKLMANEA<string>.ICBJPFEBGDJ ACNLNBKGHCE, CancellationToken ENHKOFNDDIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x7C687C0", Offset = "0x7C67BC0", VA = "0x187C687C0")]
	[AsyncStateMachine(typeof(BLPLBFPGCKE))]
	private Task IKIFLPOJPIB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000193")]
public readonly struct NKALECBGCLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006FF")]
	public readonly bool CLDBPOICLLF;

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x2740760", Offset = "0x273FB60", VA = "0x182740760")]
	public NKALECBGCLE(bool GNPGOGPIMDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
public readonly struct FIHJMIFDKFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000700")]
	public readonly BDHMMMHCHAA? CKLPDDICBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000701")]
	public readonly CCKFEHFPIPE BMOPKHPFPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000702")]
	public readonly string? LDCCKJFDLNH;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public IReadOnlyCollection<string> GNFABBJLGHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x7C68A80", Offset = "0x7C67E80", VA = "0x187C68A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public IReadOnlyDictionary<long, int> HECLMEPIEIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x7C68AA0", Offset = "0x7C67EA0", VA = "0x187C68AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x7C68AC0", Offset = "0x7C67EC0", VA = "0x187C68AC0")]
	public FIHJMIFDKFO(BDHMMMHCHAA? MIMFFPFKBEA, CCKFEHFPIPE FEEAFDFFHID, string? HDFGNIINOHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
internal class IBCNCFMBDFO : GCLDIMIBKMA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[CompilerGenerated]
	private struct CHDBBKALJAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		public AsyncTaskMethodBuilder<FIHJMIFDKFO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		public IBCNCFMBDFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		public LDLMBBIODPI serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		public MCIKJBCGIFM roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		private PersistenceView[] <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		private DJPNNBMEIAG <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x7C66860", Offset = "0x7C65C60", VA = "0x187C66860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x7C66ED0", Offset = "0x7C662D0", VA = "0x187C66ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private sealed class PDCGKPFNIJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		public float time;

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public PDCGKPFNIJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x7C70C30", Offset = "0x7C70030", VA = "0x187C70C30")]
		internal object GECEMBCJKKC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private struct EDFDGHKKOED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		public IBCNCFMBDFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		public PersistenceView[] activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		public LDLMBBIODPI serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		private PDCGKPFNIJK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		private DJPNNBMEIAG <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		private CancellationTokenSource <cts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		private EFMCPKJOHAF<Task> <tasks>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x7C67BB0", Offset = "0x7C66FB0", VA = "0x187C67BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x7C68680", Offset = "0x7C67A80", VA = "0x187C68680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000703")]
	private readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.Token(Token = "0x4000704")]
	private static readonly TimeSpan BOLEBGMNPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000705")]
	private readonly LDDGEGNMMJM KDNMHKOLIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000706")]
	private readonly HAHMCMAKCNH PGGLHCOCIFP;

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x7C6B940", Offset = "0x7C6AD40", VA = "0x187C6B940")]
	public IBCNCFMBDFO(LGACCJIPMFL OKNMIEHKKPG, LDDGEGNMMJM KDNMHKOLIJK, HAHMCMAKCNH KIBHPHMJLHB, IBCMILIKEJG DDKJAEALMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x7C6B520", Offset = "0x7C6A920", VA = "0x187C6B520")]
	[AsyncStateMachine(typeof(CHDBBKALJAO))]
	public Task<FIHJMIFDKFO> IMJDHHAECMF(long OGHBKCHPPKA, MCIKJBCGIFM COFLABALPJG, LDLMBBIODPI OFPNBIDICMP, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x7C6AF00", Offset = "0x7C6A300", VA = "0x187C6AF00")]
	[AsyncStateMachine(typeof(EDFDGHKKOED))]
	private Task FGBLCCOEKLD(LDLMBBIODPI OFPNBIDICMP, PersistenceView[] ILKGDALPJFB, StringBuilder ALMMEIIBAPL, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x7C6B040", Offset = "0x7C6A440", VA = "0x187C6B040")]
	private FIHJMIFDKFO FJLMJLDOCHN(long OGHBKCHPPKA, MCIKJBCGIFM COFLABALPJG, LDLMBBIODPI OFPNBIDICMP, IEnumerable<PersistenceView> ILKGDALPJFB, StringBuilder ALMMEIIBAPL)
	{
		return default(FIHJMIFDKFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x7C6AD40", Offset = "0x7C6A140", VA = "0x187C6AD40")]
	private BDHMMMHCHAA CMOABELAGEJ(long OGHBKCHPPKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x7C6B680", Offset = "0x7C6AA80", VA = "0x187C6B680")]
	private void OFGOJBEFDNG(BDHMMMHCHAA BFKCOJOKKKN, StringBuilder ALMMEIIBAPL, IEnumerable<PersistenceView> ILKGDALPJFB, [In] DONOJMBDAEC KPNKMJMEKBH, DHFOBBNDABM GNHOFHLJPMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x7C6A8A0", Offset = "0x7C69CA0", VA = "0x187C6A8A0")]
	private void AHCEOFOIABC(BDHMMMHCHAA BFKCOJOKKKN, StringBuilder ALMMEIIBAPL, PersistenceView GAFKCGNMDOE, DHFOBBNDABM GNHOFHLJPMM, [In] DONOJMBDAEC KPNKMJMEKBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
internal class MDEFBAINCHB : GCLDIMIBKMA
{
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private sealed class IKDJELPJCCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000723")]
		public NINDCCCDADD.LJLOIGMEIFH roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public IKDJELPJCCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x7C6B9A0", Offset = "0x7C6ADA0", VA = "0x187C6B9A0")]
		internal object JFIDCHPLNAK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[CompilerGenerated]
	private struct GOMHPJNBBGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000724")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000725")]
		public AsyncTaskMethodBuilder<(NINDCCCDADD.LJLOIGMEIFH roomDataUpload, NINDCCCDADD.LJLOIGMEIFH subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		public FIHJMIFDKFO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000727")]
		public MDEFBAINCHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000728")]
		private IKDJELPJCCO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400072A")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		private TaskAwaiter<NINDCCCDADD.LJLOIGMEIFH> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x7C69C90", Offset = "0x7C69090", VA = "0x187C69C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x7C6A4F0", Offset = "0x7C698F0", VA = "0x187C6A4F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019D")]
	[CompilerGenerated]
	private struct PCHAOBIPLLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		public AsyncTaskMethodBuilder<AKEHIKAMMJM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		public MDEFBAINCHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		public FIHJMIFDKFO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		public ABMKIBHCAFE roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		private TaskAwaiter<(NINDCCCDADD.LJLOIGMEIFH roomDataUpload, NINDCCCDADD.LJLOIGMEIFH subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000736")]
		private TaskAwaiter<AKEHIKAMMJM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x7C70520", Offset = "0x7C6F920", VA = "0x187C70520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x7C70BC0", Offset = "0x7C6FFC0", VA = "0x187C70BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[CompilerGenerated]
	private struct FMGFNCGMMCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000737")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000738")]
		public AsyncTaskMethodBuilder<HGLCHBODEAA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000739")]
		public MDEFBAINCHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		public FIHJMIFDKFO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		private TaskAwaiter<(NINDCCCDADD.LJLOIGMEIFH roomDataUpload, NINDCCCDADD.LJLOIGMEIFH subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000740")]
		private TaskAwaiter<HGLCHBODEAA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x7C68BC0", Offset = "0x7C67FC0", VA = "0x187C68BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x7C68FD0", Offset = "0x7C683D0", VA = "0x187C68FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[CompilerGenerated]
	private sealed class MIIIEPNCHIG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001A0")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000749")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400074A")]
			public AsyncTaskMethodBuilder<KKBOOBAMIML> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400074B")]
			public MIIIEPNCHIG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400074C")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400074D")]
			private KKBOOBAMIML <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400074E")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400074F")]
			private TaskAwaiter<HGLCHBODEAA> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000750")]
			private TaskAwaiter<AKEHIKAMMJM> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000751")]
			private TaskAwaiter<KKBOOBAMIML> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(RVA = "0x7C70EB0", Offset = "0x7C702B0", VA = "0x187C70EB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0x7C71E30", Offset = "0x7C71230", VA = "0x187C71E30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		public MDEFBAINCHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		public FIHJMIFDKFO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		public ABMKIBHCAFE roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000747")]
		public NKALECBGCLE roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public MIIIEPNCHIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x7C6DBF0", Offset = "0x7C6CFF0", VA = "0x187C6DBF0")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<KKBOOBAMIML> NOAHELNFNFA(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A1")]
	[CompilerGenerated]
	private struct CHDNCGBLJHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000752")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		public AsyncTaskMethodBuilder<KKBOOBAMIML> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000754")]
		public MDEFBAINCHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000755")]
		public FIHJMIFDKFO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000756")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000757")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000758")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000759")]
		public ABMKIBHCAFE roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400075A")]
		public NKALECBGCLE roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400075B")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400075C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400075D")]
		private TaskAwaiter<KKBOOBAMIML> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x7C66F40", Offset = "0x7C66340", VA = "0x187C66F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x7C67250", Offset = "0x7C66650", VA = "0x187C67250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000720")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.Token(Token = "0x4000721")]
	private static readonly IBCMILIKEJG MMJIIFBIEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000722")]
	private readonly PGODPOGHOLM LKBMJDKBGGL;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private CFEMEJBKCKD JDBIGNOPBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x7C354F0", Offset = "0x7C348F0", VA = "0x187C354F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x7C6DB60", Offset = "0x7C6CF60", VA = "0x187C6DB60")]
	public MDEFBAINCHB(LGACCJIPMFL OKNMIEHKKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x7C6D500", Offset = "0x7C6C900", VA = "0x187C6D500")]
	[AsyncStateMachine(typeof(GOMHPJNBBGO))]
	private Task<(NINDCCCDADD.LJLOIGMEIFH, NINDCCCDADD.LJLOIGMEIFH)> FBGNMICBCDI(FIHJMIFDKFO KHDKGFGGFBO, long FFFLOIOFAMB, long GHFFAIKCNFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x7C6D950", Offset = "0x7C6CD50", VA = "0x187C6D950")]
	[AsyncStateMachine(typeof(PCHAOBIPLLG))]
	public Task<AKEHIKAMMJM> KOOJKPAIHLF(int NCACHKHPMEG, [CanBeNull] ABMKIBHCAFE FPKAICKNAPP, FIHJMIFDKFO KHDKGFGGFBO, long FFFLOIOFAMB, long GHFFAIKCNFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x7C6D7E0", Offset = "0x7C6CBE0", VA = "0x187C6D7E0")]
	[AsyncStateMachine(typeof(FMGFNCGMMCO))]
	private Task<HGLCHBODEAA> ILHLAHFLHMB(string BPPPCIKOLON, int NCACHKHPMEG, FIHJMIFDKFO KHDKGFGGFBO, long FFFLOIOFAMB, long GHFFAIKCNFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x7C6D640", Offset = "0x7C6CA40", VA = "0x187C6D640")]
	[AsyncStateMachine(typeof(CHDNCGBLJHK))]
	public Task<KKBOOBAMIML> IEEEPFGLLOB(int NCACHKHPMEG, ABMKIBHCAFE? FPKAICKNAPP, FIHJMIFDKFO KHDKGFGGFBO, long FFFLOIOFAMB, long GHFFAIKCNFL, NKALECBGCLE FMBNFEHPPJK, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
public abstract class NKKCFLLFNFP<T> where T : NKKCFLLFNFP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400075E")]
	internal readonly CFEMEJBKCKD PJJJACMFHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400075F")]
	private int? CCFNJEFBKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000760")]
	protected readonly Guid FLJLEJEOHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000761")]
	protected readonly IICNNDCPJEP FEJKKBFBIPJ;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	protected T KBNBOPIGGIB
	{
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x4E7DD90", Offset = "0x4E7D190", VA = "0x184E7DD90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x4E7E120", Offset = "0x4E7D520", VA = "0x184E7E120")]
	internal NKKCFLLFNFP(CFEMEJBKCKD AGOLAMHOOKA, IICNNDCPJEP IJECCKDIIBB, [Optional] Guid? EHMIFANHMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0x4E7DDF0", Offset = "0x4E7D1F0", VA = "0x184E7DDF0")]
	private KKBOOBAMIML MNPGMLHIPOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "4")]
	protected virtual void DBJACMLEMFH(KKBOOBAMIML MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x4E7E000", Offset = "0x4E7D400", VA = "0x184E7E000")]
	public T PFKIFDFNNGO(OPHKANJGPPK EFGAKBIDOLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x4E7DCF0", Offset = "0x4E7D0F0", VA = "0x184E7DCF0")]
	public T FEMOGLJGEIK(int LBCNOPPNDAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x4E7DED0", Offset = "0x4E7D2D0", VA = "0x184E7DED0", Slot = "5")]
	public virtual Task<GGLMIDJEDGD> PEPKCJHFKAL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
public class PDOFNJJFGGG : NKKCFLLFNFP<PDOFNJJFGGG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000762")]
	private HLOJEJEEEIJ GOAPBALNOKD;

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x7C70D70", Offset = "0x7C70170", VA = "0x187C70D70")]
	internal PDOFNJJFGGG(CFEMEJBKCKD AGOLAMHOOKA, IICNNDCPJEP IJECCKDIIBB, [Optional] Guid? EHMIFANHMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x6FE2D10", Offset = "0x6FE2110", VA = "0x186FE2D10")]
	public PDOFNJJFGGG AOELMECGEJB(HLOJEJEEEIJ GOAPBALNOKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x7C70CA0", Offset = "0x7C700A0", VA = "0x187C70CA0", Slot = "4")]
	protected override void DBJACMLEMFH(KKBOOBAMIML MIALAMIFNLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
public class NNPFBKHPJCA : NKKCFLLFNFP<NNPFBKHPJCA>
{
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	internal enum MHDAGJLKBJB
	{
		[Cpp2IlInjected.Token(Token = "0x4000767")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000768")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	[CompilerGenerated]
	private struct BBHMFMHKIBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		public AsyncTaskMethodBuilder<GGLMIDJEDGD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400076C")]
		public NNPFBKHPJCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400076E")]
		private TaskAwaiter<GGLMIDJEDGD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x7C65C00", Offset = "0x7C65000", VA = "0x187C65C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x7C65FA0", Offset = "0x7C653A0", VA = "0x187C65FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000763")]
	private MHDAGJLKBJB LLKHAAJKOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000764")]
	private string ELHEMHIMMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000765")]
	private ABMKIBHCAFE GOAPBALNOKD;

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F100", Offset = "0x7C6E500", VA = "0x187C6F100")]
	internal NNPFBKHPJCA(CFEMEJBKCKD AGOLAMHOOKA, IICNNDCPJEP IJECCKDIIBB, [Optional] Guid? EHMIFANHMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x7C6EF90", Offset = "0x7C6E390", VA = "0x187C6EF90")]
	public NNPFBKHPJCA DJNCPBLKDPA(string GPFCOHGCDPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x7C6EDC0", Offset = "0x7C6E1C0", VA = "0x187C6EDC0")]
	public NNPFBKHPJCA CGNADFGKAJC(bool JCKIECNKFNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x7C6EFF0", Offset = "0x7C6E3F0", VA = "0x187C6EFF0")]
	public NNPFBKHPJCA OFJJEFAIGNB(bool AJOLOHBNOCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x7C6EFC0", Offset = "0x7C6E3C0", VA = "0x187C6EFC0")]
	public NNPFBKHPJCA IFHPFNHEPBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x7C6EDE0", Offset = "0x7C6E1E0", VA = "0x187C6EDE0", Slot = "4")]
	protected override void DBJACMLEMFH(KKBOOBAMIML MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F010", Offset = "0x7C6E410", VA = "0x187C6F010", Slot = "5")]
	[AsyncStateMachine(typeof(BBHMFMHKIBA))]
	public override Task<GGLMIDJEDGD> PEPKCJHFKAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x7C6EF50", Offset = "0x7C6E350", VA = "0x187C6EF50")]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task<GGLMIDJEDGD> DIHJIFFGOEA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A7")]
internal static class FDEEGLPCELP
{
	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x7C688B0", Offset = "0x7C67CB0", VA = "0x187C688B0")]
	public static void DFFPOANJANF(this IBBHMOLEKHK HPIPDBILBFN, GDBFIEIFOFD BIHCMIGBKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(RVA = "0x7C68A00", Offset = "0x7C67E00", VA = "0x187C68A00")]
	public static void HDACGMPKBDJ(this GDBFIEIFOFD FJKJDPBPFHP, [Optional] string MIALAMIFNLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
public static class BKICFDPOJFM
{
	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x7C660C0", Offset = "0x7C654C0", VA = "0x187C660C0")]
	public static DDDGOPGHMJC CKAMLLMOOFM(this HICEPPICJKO FMPCPEMKMLL)
	{
		return default(DDDGOPGHMJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x7C66010", Offset = "0x7C65410", VA = "0x187C66010")]
	public static HICEPPICJKO AAKCDLMCIDI(this DDDGOPGHMJC CEOPHGDOGCN)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x20001A9")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20001AA")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000772")]
			public AOEFHBHKKHL ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000773")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000774")]
			public AOEFHBHKKHL HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000775")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000776")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000777")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x600069C")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400076F")]
		private static AOEFHBHKKHL[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		private Dictionary<AOEFHBHKKHL, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x7C72250", Offset = "0x7C71650", VA = "0x187C72250")]
		public bool EPEJBEGBHOG(AOEFHBHKKHL DCLADEMODOF, [Out] ResultConfig HIGIOODIHPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x7C722C0", Offset = "0x7C716C0", VA = "0x187C722C0")]
		public ResultConfig MJADLMGCBBB(AOEFHBHKKHL CEGFAIJENKH, [Optional] HashSet<AOEFHBHKKHL> PBMABMKIGFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x7C729D0", Offset = "0x7C71DD0", VA = "0x187C729D0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x7C72400", Offset = "0x7C71800", VA = "0x187C72400", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0xA3C8E0", Offset = "0xA3BCE0", VA = "0x180A3C8E0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AC")]
public class HGLJCKMNEBN : COLHIDLGKEK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[CompilerGenerated]
	private struct KEMGBFMHMOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400077F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000780")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		public HGLJCKMNEBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x7C6BD10", Offset = "0x7C6B110", VA = "0x187C6BD10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x7C6BFA0", Offset = "0x7C6B3A0", VA = "0x187C6BFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AE")]
	[CompilerGenerated]
	private struct APJLONEHDIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000785")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000786")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000787")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000788")]
		public COLHIDLGKEK preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000789")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400078A")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400078B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x7C656F0", Offset = "0x7C64AF0", VA = "0x187C656F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x7C65BA0", Offset = "0x7C64FA0", VA = "0x187C65BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400077D")]
	private readonly FBFEGIANEKA GMCCMEHGAKN;

	[Cpp2IlInjected.Token(Token = "0x400077E")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public string IIJMDIOPBCE
	{
		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x7C6A560", Offset = "0x7C69960", VA = "0x187C6A560", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x7C6A7C0", Offset = "0x7C69BC0", VA = "0x187C6A7C0")]
	[HLOHOCOKELO.IDGFAEKKODB.GGCNFHIOHEN]
	internal static void NADFCFLHLDK(GFKEMDIOCPC BFAKMKOHPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x951BA0", Offset = "0x950FA0", VA = "0x180951BA0")]
	[RecRoom.NoEngine.Common.Preserve]
	public HGLJCKMNEBN([IBJCGEMJMJL(null)] FBFEGIANEKA GMCCMEHGAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x7C6A6B0", Offset = "0x7C69AB0", VA = "0x187C6A6B0", Slot = "5")]
	[AsyncStateMachine(typeof(KEMGBFMHMOM))]
	public Task IKIFLPOJPIB(FGFDKLMANEA<string>.ICBJPFEBGDJ NHGJLMMOIBD, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x7C6A590", Offset = "0x7C69990", VA = "0x187C6A590")]
	[AsyncStateMachine(typeof(APJLONEHDIH))]
	private Task HALKGFHDJAA(COLHIDLGKEK OCMFPKGPGCA, FGFDKLMANEA<string>.ICBJPFEBGDJ NHGJLMMOIBD, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AF")]
public interface FBFEGIANEKA : COLHIDLGKEK
{
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public interface COLHIDLGKEK
{
	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	string IIJMDIOPBCE
	{
		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task IKIFLPOJPIB(FGFDKLMANEA<string>.ICBJPFEBGDJ NHGJLMMOIBD, CancellationToken LAEIHJHNGEK);
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
public static class MAFPJCBHANM
{
	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x7C6D0F0", Offset = "0x7C6C4F0", VA = "0x187C6D0F0")]
	[HLOHOCOKELO.IDGFAEKKODB.GGCNFHIOHEN]
	internal static void HBMGFBHOMDP(GFKEMDIOCPC BFAKMKOHPNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B2")]
public interface JICNBBCNCAC : IEquatable<JICNBBCNCAC>
{
	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	DateTime KAMMJIANMNG
	{
		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FLGGKAAJILB();

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GMDEJNHCDGD(long FFFLOIOFAMB, long OGHBKCHPPKA, [Out] FIHJMIFDKFO KHDKGFGGFBO);
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
internal class KJGLBILIDPL : GBKJFIMCMFN
{
	[Cpp2IlInjected.Token(Token = "0x20001B4")]
	[CompilerGenerated]
	private sealed class EIAHJNDACIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400078E")]
		public DPOOOLNKMNK autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400078F")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public EIAHJNDACIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x7C686E0", Offset = "0x7C67AE0", VA = "0x187C686E0")]
		internal object HLLODCADANN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400078C")]
	private readonly LFKFODMLCGI MFGBIFDAMCC;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<JICNBBCNCAC> JCFEMMEGFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x7C6C120", Offset = "0x7C6B520", VA = "0x187C6C120", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x7C6C280", Offset = "0x7C6B680", VA = "0x187C6C280", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(RVA = "0x951BA0", Offset = "0x950FA0", VA = "0x180951BA0")]
	[UnityEngine.Scripting.Preserve]
	public KJGLBILIDPL([IBJCGEMJMJL(null)] LFKFODMLCGI MFGBIFDAMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(RVA = "0x7C6C330", Offset = "0x7C6B730", VA = "0x187C6C330", Slot = "6")]
	public bool ICKKOCNOPIK(long FFFLOIOFAMB, long OGHBKCHPPKA, FIHJMIFDKFO KHDKGFGGFBO, DPOOOLNKMNK KEGDNPBCBNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0xC3AA90", Offset = "0xC39E90", VA = "0x180C3AA90")]
	private void MOCNPDMEDBB(JICNBBCNCAC HNGPDEBEPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0x7C6C620", Offset = "0x7C6BA20", VA = "0x187C6C620", Slot = "7")]
	public bool IHHBEPAKLHM(long FFFLOIOFAMB, long OGHBKCHPPKA, [Out] JICNBBCNCAC CIIBJONMFCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x7C6C1D0", Offset = "0x7C6B5D0", VA = "0x187C6C1D0", Slot = "8")]
	public bool DONKKGDHALC(long FFFLOIOFAMB, long OGHBKCHPPKA, DPOOOLNKMNK KEGDNPBCBNK, [Out] JICNBBCNCAC CIIBJONMFCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x7C6C790", Offset = "0x7C6BB90", VA = "0x187C6C790")]
	private void KNNKKFJNIDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0x7C6C000", Offset = "0x7C6B400", VA = "0x187C6C000", Slot = "9")]
	public void BKBMFNAHOML(long FFFLOIOFAMB, long OGHBKCHPPKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
internal abstract class NMHGGPFAHAB : LFKFODMLCGI
{
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	protected enum PGHCPIICEKC : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000794")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x4000795")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001B8")]
	[CompilerGenerated]
	private sealed class OIOOFFGJPOP : IEnumerable<JICNBBCNCAC>, IEnumerable, IEnumerator<JICNBBCNCAC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000796")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000797")]
		private JICNBBCNCAC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000798")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000799")]
		public NMHGGPFAHAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400079A")]
		private DPOOOLNKMNK autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400079B")]
		public DPOOOLNKMNK <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400079C")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400079D")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		private JICNBBCNCAC System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60006D1")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60006D3")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0xD230D0", Offset = "0xD224D0", VA = "0x180D230D0")]
		[DebuggerHidden]
		public OIOOFFGJPOP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x7C701F0", Offset = "0x7C6F5F0", VA = "0x187C701F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x7C704D0", Offset = "0x7C6F8D0", VA = "0x187C704D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x7C70420", Offset = "0x7C6F820", VA = "0x187C70420", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JICNBBCNCAC> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x7C70420", Offset = "0x7C6F820", VA = "0x187C70420", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001B9")]
	[CompilerGenerated]
	private sealed class GMLELOOIBIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400079E")]
		public DPOOOLNKMNK autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400079F")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public GMLELOOIBIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x7C69BF0", Offset = "0x7C68FF0", VA = "0x187C69BF0")]
		internal object FPBBJJHEPCB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001BA")]
	[CompilerGenerated]
	private sealed class LAFDGFBPBMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007A0")]
		public NMHGGPFAHAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007A1")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public LAFDGFBPBMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x7C6D070", Offset = "0x7C6C470", VA = "0x187C6D070")]
		internal void BIMCGHMHIOC(DHLNLABPKJB.HHILMBEMCHL ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000792")]
	private readonly object ENCDJADMJDM;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	protected string OONAJNINCGI
	{
		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x7C6E720", Offset = "0x7C6DB20", VA = "0x187C6E720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public abstract ACKDHNOCNLO BAOOFOLGIBL
	{
		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x7C6ED40", Offset = "0x7C6E140", VA = "0x187C6ED40")]
	protected NMHGGPFAHAB([CanBeNull] string OOOIACMGLFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x7C6EB50", Offset = "0x7C6DF50", VA = "0x187C6EB50", Slot = "5")]
	public bool PJMAJGOOFLO(long FFFLOIOFAMB, long OGHBKCHPPKA, DPOOOLNKMNK KEGDNPBCBNK, [Out] JICNBBCNCAC HNGPDEBEPAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x7C6E320", Offset = "0x7C6D720", VA = "0x187C6E320", Slot = "6")]
	[IteratorStateMachine(typeof(OIOOFFGJPOP))]
	public IEnumerable<JICNBBCNCAC> BPHIFMCDOJM(DPOOOLNKMNK KEGDNPBCBNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void DLMOGAKHJCL(Stream FENEICALKKP, long FFFLOIOFAMB, long OGHBKCHPPKA, FIHJMIFDKFO KHDKGFGGFBO);

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool MMFDBEOGFFA(Stream IFABEIJLFBB, long FFFLOIOFAMB, long OGHBKCHPPKA, GAGKPNJFJCJ EICEGDAOEJP, [Out] FIHJMIFDKFO KHDKGFGGFBO);

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x7C6E3B0", Offset = "0x7C6D7B0", VA = "0x187C6E3B0", Slot = "7")]
	public JICNBBCNCAC DAFLGCCMCJH(long FFFLOIOFAMB, long OGHBKCHPPKA, FIHJMIFDKFO KHDKGFGGFBO, DPOOOLNKMNK KEGDNPBCBNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo INJAMIBBBIP(long FFFLOIOFAMB, long OGHBKCHPPKA, DPOOOLNKMNK KEGDNPBCBNK, PGHCPIICEKC PCBJIHANGHI);

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo EEGFBAGPJHP(DPOOOLNKMNK KEGDNPBCBNK, PGHCPIICEKC PCBJIHANGHI);

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x7C6E730", Offset = "0x7C6DB30", VA = "0x187C6E730")]
	protected void GJDEDFAEGKC(DHLNLABPKJB.HHILMBEMCHL BCCFDDJGNMI, string OIKCDENKJMH, FileInfo AIGLCGIOEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x7C6E7A0", Offset = "0x7C6DBA0", VA = "0x187C6E7A0")]
	internal bool LOIEOLACGNL(FileInfo LELIODNIKJM, long FFFLOIOFAMB, long OGHBKCHPPKA, [Out] FIHJMIFDKFO KHDKGFGGFBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
	private void FKHBKFDHGEO(Exception BNMNAMAKIOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BB")]
internal class GBHOINNMDNP : NMHGGPFAHAB
{
	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public override ACKDHNOCNLO BAOOFOLGIBL
	{
		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x1B443A0", Offset = "0x1B437A0", VA = "0x181B443A0", Slot = "8")]
		get
		{
			return default(ACKDHNOCNLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x7C69BB0", Offset = "0x7C68FB0", VA = "0x187C69BB0")]
	public GBHOINNMDNP([Optional] string OOOIACMGLFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x7C693D0", Offset = "0x7C687D0", VA = "0x187C693D0")]
	private void FOAEMBEOIGK(DPOOOLNKMNK KEGDNPBCBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(RVA = "0x7C69040", Offset = "0x7C68440", VA = "0x187C69040", Slot = "9")]
	internal override void DLMOGAKHJCL(Stream FENEICALKKP, long FFFLOIOFAMB, long OGHBKCHPPKA, FIHJMIFDKFO KHDKGFGGFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x7C69540", Offset = "0x7C68940", VA = "0x187C69540", Slot = "10")]
	internal override bool MMFDBEOGFFA(Stream IFABEIJLFBB, long FFFLOIOFAMB, long OGHBKCHPPKA, GAGKPNJFJCJ EICEGDAOEJP, [Out] FIHJMIFDKFO KHDKGFGGFBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x7C69450", Offset = "0x7C68850", VA = "0x187C69450", Slot = "11")]
	protected override FileInfo INJAMIBBBIP(long FFFLOIOFAMB, long OGHBKCHPPKA, DPOOOLNKMNK KEGDNPBCBNK, PGHCPIICEKC PCBJIHANGHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(RVA = "0x7C692D0", Offset = "0x7C686D0", VA = "0x187C692D0", Slot = "12")]
	protected override DirectoryInfo EEGFBAGPJHP(DPOOOLNKMNK KEGDNPBCBNK, PGHCPIICEKC PCBJIHANGHI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BC")]
internal sealed class NOAJNNOBBAM : NMHGGPFAHAB
{
	[Cpp2IlInjected.Token(Token = "0x40007A2")]
	private static readonly byte[] LKMGECEEGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007A3")]
	private readonly byte[] MLPIAMJJEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40007A4")]
	private readonly byte[] OCIPFNGLKPL;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public override ACKDHNOCNLO BAOOFOLGIBL
	{
		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x683ACF0", Offset = "0x683A0F0", VA = "0x18683ACF0", Slot = "8")]
		get
		{
			return default(ACKDHNOCNLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(RVA = "0x7C70100", Offset = "0x7C6F500", VA = "0x187C70100")]
	public NOAJNNOBBAM([Optional] string OOOIACMGLFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F270", Offset = "0x7C6E670", VA = "0x187C6F270", Slot = "9")]
	internal override void DLMOGAKHJCL(Stream FENEICALKKP, long FFFLOIOFAMB, long OGHBKCHPPKA, FIHJMIFDKFO KHDKGFGGFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F830", Offset = "0x7C6EC30", VA = "0x187C6F830", Slot = "10")]
	internal override bool MMFDBEOGFFA(Stream IFABEIJLFBB, long FFFLOIOFAMB, long OGHBKCHPPKA, GAGKPNJFJCJ EICEGDAOEJP, [Out] FIHJMIFDKFO KHDKGFGGFBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F640", Offset = "0x7C6EA40", VA = "0x187C6F640")]
	private void EFDLGLPFIIA(byte[] HECJPBMFJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F700", Offset = "0x7C6EB00", VA = "0x187C6F700", Slot = "11")]
	protected override FileInfo INJAMIBBBIP(long FFFLOIOFAMB, long OGHBKCHPPKA, DPOOOLNKMNK KEGDNPBCBNK, PGHCPIICEKC PCBJIHANGHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F530", Offset = "0x7C6E930", VA = "0x187C6F530", Slot = "12")]
	protected override DirectoryInfo EEGFBAGPJHP(DPOOOLNKMNK KEGDNPBCBNK, PGHCPIICEKC PCBJIHANGHI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BD")]
public enum ACKDHNOCNLO : byte
{
	[Cpp2IlInjected.Token(Token = "0x40007A6")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40007A7")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40007A8")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
internal class DJDKHDAADCI : LFKFODMLCGI
{
	[Cpp2IlInjected.Token(Token = "0x20001C0")]
	[CompilerGenerated]
	private sealed class KKHHCFNLNHK : IEnumerable<JICNBBCNCAC>, IEnumerable, IEnumerator<JICNBBCNCAC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007AF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007B0")]
		private JICNBBCNCAC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007B1")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007B2")]
		public DJDKHDAADCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007B3")]
		private DPOOOLNKMNK autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40007B4")]
		public DPOOOLNKMNK <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007B5")]
		private ACKDHNOCNLO[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007B6")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007B7")]
		private IEnumerator<JICNBBCNCAC> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		private JICNBBCNCAC System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60006F8")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60006FA")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0xD230D0", Offset = "0xD224D0", VA = "0x180D230D0")]
		[DebuggerHidden]
		public KKHHCFNLNHK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x7C6CFE0", Offset = "0x7C6C3E0", VA = "0x187C6CFE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x7C6CC00", Offset = "0x7C6C000", VA = "0x187C6CC00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x7C6CBB0", Offset = "0x7C6BFB0", VA = "0x187C6CBB0")]
		private void ACIHHJJLKBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x7C6CF90", Offset = "0x7C6C390", VA = "0x187C6CF90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x7C6CEE0", Offset = "0x7C6C2E0", VA = "0x187C6CEE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JICNBBCNCAC> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x7C6CEE0", Offset = "0x7C6C2E0", VA = "0x187C6CEE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007A9")]
	private readonly ACKDHNOCNLO[] GAJMCAJGHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007AA")]
	private readonly Dictionary<ACKDHNOCNLO, LFKFODMLCGI> HONGKFONCPI;

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public ACKDHNOCNLO BAOOFOLGIBL
	{
		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x7C676E0", Offset = "0x7C66AE0", VA = "0x187C676E0", Slot = "4")]
		get
		{
			return default(ACKDHNOCNLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x7C67860", Offset = "0x7C66C60", VA = "0x187C67860")]
	[UnityEngine.Scripting.Preserve]
	public DJDKHDAADCI(params LFKFODMLCGI[] BCDNICIKMPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x7C67710", Offset = "0x7C66B10", VA = "0x187C67710", Slot = "5")]
	public bool PJMAJGOOFLO(long FFFLOIOFAMB, long OGHBKCHPPKA, DPOOOLNKMNK KEGDNPBCBNK, [Out] JICNBBCNCAC HNGPDEBEPAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x7C674A0", Offset = "0x7C668A0", VA = "0x187C674A0")]
	private void GMHJOEODHKI(int OBCKKLACLKP, long FFFLOIOFAMB, long OGHBKCHPPKA, DPOOOLNKMNK KEGDNPBCBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x7C672C0", Offset = "0x7C666C0", VA = "0x187C672C0", Slot = "6")]
	[IteratorStateMachine(typeof(KKHHCFNLNHK))]
	public IEnumerable<JICNBBCNCAC> BPHIFMCDOJM(DPOOOLNKMNK KEGDNPBCBNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x7C67350", Offset = "0x7C66750", VA = "0x187C67350", Slot = "7")]
	public JICNBBCNCAC DAFLGCCMCJH(long FFFLOIOFAMB, long OGHBKCHPPKA, FIHJMIFDKFO KHDKGFGGFBO, DPOOOLNKMNK KEGDNPBCBNK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C1")]
internal static class KBKIAFLFDCN
{
	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0x7C6BC50", Offset = "0x7C6B050", VA = "0x187C6BC50")]
	internal static byte[] OFPMLOJBLCB(byte[] HECJPBMFJGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x7C6BBD0", Offset = "0x7C6AFD0", VA = "0x187C6BBD0")]
	public static void DPJIDKDFGNB(Stream EEGCINGNJGJ, byte[] PHHEOHNFCEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x7C6B9F0", Offset = "0x7C6ADF0", VA = "0x187C6B9F0")]
	public static bool DCBPHPBGDKO(Stream EEGCINGNJGJ, long CNNPKGGGLGA, GAGKPNJFJCJ MECCANOHMJO, [Out] byte[] EGADINBJMCA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C2")]
internal sealed class NBOLKFAMJDB : JICNBBCNCAC, IEquatable<JICNBBCNCAC>, IEquatable<NBOLKFAMJDB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007B8")]
	private readonly NMHGGPFAHAB ONANCPOCMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007B9")]
	public readonly FileInfo GMKMONGBLDJ;

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public ACKDHNOCNLO BAOOFOLGIBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x756D350", Offset = "0x756C750", VA = "0x18756D350", Slot = "9")]
		get
		{
			return default(ACKDHNOCNLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public DateTime KAMMJIANMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x7C6DD20", Offset = "0x7C6D120", VA = "0x187C6DD20", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0x7C6E210", Offset = "0x7C6D610", VA = "0x187C6E210")]
	public NBOLKFAMJDB(NMHGGPFAHAB PAKEKNLGDDE, FileInfo LELIODNIKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x7C6E160", Offset = "0x7C6D560", VA = "0x187C6E160", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x7C6DFD0", Offset = "0x7C6D3D0", VA = "0x187C6DFD0", Slot = "5")]
	public void FLGGKAAJILB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x7C6E090", Offset = "0x7C6D490", VA = "0x187C6E090", Slot = "6")]
	public bool GMDEJNHCDGD(long FFFLOIOFAMB, long OGHBKCHPPKA, [Out] FIHJMIFDKFO KHDKGFGGFBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x7C6DDB0", Offset = "0x7C6D1B0", VA = "0x187C6DDB0", Slot = "7")]
	public bool Equals(JICNBBCNCAC OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x7C6DE20", Offset = "0x7C6D220", VA = "0x187C6DE20", Slot = "8")]
	public bool Equals(NBOLKFAMJDB OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x7C6DEE0", Offset = "0x7C6D2E0", VA = "0x187C6DEE0", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x7C6E0D0", Offset = "0x7C6D4D0", VA = "0x187C6E0D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C3")]
public delegate void GAGKPNJFJCJ(DHLNLABPKJB.HHILMBEMCHL FPNAMINAOLN, string MIALAMIFNLM);
[Cpp2IlInjected.Token(Token = "0x20001C4")]
internal interface LFKFODMLCGI
{
	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	ACKDHNOCNLO BAOOFOLGIBL
	{
		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PJMAJGOOFLO(long FFFLOIOFAMB, long OGHBKCHPPKA, DPOOOLNKMNK KEGDNPBCBNK, [Out] JICNBBCNCAC HNGPDEBEPAB);

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<JICNBBCNCAC> BPHIFMCDOJM(DPOOOLNKMNK KEGDNPBCBNK);

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JICNBBCNCAC DAFLGCCMCJH(long FFFLOIOFAMB, long OGHBKCHPPKA, FIHJMIFDKFO KHDKGFGGFBO, DPOOOLNKMNK KEGDNPBCBNK);
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
